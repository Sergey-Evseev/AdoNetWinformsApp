using AdoNetWinformsApp.Entities;
using FastMember;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace AdoNetWinformsApp
{
    public partial class MainForm : Form
    {
        private const string GetGoodsWithInfoQuery = @"
            SELECT G.Id, G.[Name] AS N'Наименование', GT.[Name] AS N'Тип товара', G.Cost AS N'Себестоимость'
            FROM Goods AS G
            JOIN GoodsTypes AS GT
            ON G.GoodsTypeId = GT.Id";

        private WarehouseContext? _context;
        public MainForm()
        {
            InitializeComponent();
            _context = new WarehouseContext();
            _context.Database.Migrate();
        }

        private async void btnShowGoods_Click(object sender, EventArgs e)
        {
            var goods = await _context.Goods.ToListAsync();
            var table = new DataTable();
            using var reader = ObjectReader.Create(goods, "Id", "Name", "Cost", "GoodsTypeId");
            table.Load(reader);
            mainGrid.DataSource = null;
            mainGrid.DataSource = table;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context?.Dispose();
            _context = null;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            await _context.SaveChangesAsync();
        }

        private async void btnGoodsTypes_Click(object sender, EventArgs e)
        {
            var goodTypes = await _context.GoodTypes.ToListAsync();
            var table = new DataTable();
            using var reader = ObjectReader.Create(goodTypes, "Id", "Name");
            table.Load(reader);
            mainGrid.DataSource = null;
            mainGrid.DataSource = table;
        }
    }
}
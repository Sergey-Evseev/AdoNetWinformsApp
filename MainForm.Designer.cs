namespace AdoNetWinformsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainGrid = new System.Windows.Forms.DataGridView();
            this.btnShowGoods = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnGoodsTypes = new System.Windows.Forms.Button();
            this.btnDeliveries = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGoodsWIthTypes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainGrid
            // 
            this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGrid.Location = new System.Drawing.Point(10, 9);
            this.mainGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.RowHeadersWidth = 51;
            this.mainGrid.RowTemplate.Height = 29;
            this.mainGrid.Size = new System.Drawing.Size(679, 320);
            this.mainGrid.TabIndex = 2;
            // 
            // btnShowGoods
            // 
            this.btnShowGoods.Location = new System.Drawing.Point(695, 9);
            this.btnShowGoods.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowGoods.Name = "btnShowGoods";
            this.btnShowGoods.Size = new System.Drawing.Size(102, 22);
            this.btnShowGoods.TabIndex = 3;
            this.btnShowGoods.Text = "Товары";
            this.btnShowGoods.UseVisualStyleBackColor = true;
            this.btnShowGoods.Click += new System.EventHandler(this.btnShowGoods_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Location = new System.Drawing.Point(695, 35);
            this.btnSuppliers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(102, 22);
            this.btnSuppliers.TabIndex = 4;
            this.btnSuppliers.Text = "Поставщики";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnGoodsTypes
            // 
            this.btnGoodsTypes.Location = new System.Drawing.Point(695, 62);
            this.btnGoodsTypes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGoodsTypes.Name = "btnGoodsTypes";
            this.btnGoodsTypes.Size = new System.Drawing.Size(102, 22);
            this.btnGoodsTypes.TabIndex = 5;
            this.btnGoodsTypes.Text = "Типы товаров";
            this.btnGoodsTypes.UseVisualStyleBackColor = true;
            this.btnGoodsTypes.Click += new System.EventHandler(this.btnGoodsTypes_Click);
            // 
            // btnDeliveries
            // 
            this.btnDeliveries.Location = new System.Drawing.Point(695, 88);
            this.btnDeliveries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeliveries.Name = "btnDeliveries";
            this.btnDeliveries.Size = new System.Drawing.Size(102, 22);
            this.btnDeliveries.TabIndex = 6;
            this.btnDeliveries.Text = "Поставки";
            this.btnDeliveries.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(695, 289);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 40);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Обновить данные";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnGoodsWIthTypes
            // 
            this.btnGoodsWIthTypes.Location = new System.Drawing.Point(695, 124);
            this.btnGoodsWIthTypes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGoodsWIthTypes.Name = "btnGoodsWIthTypes";
            this.btnGoodsWIthTypes.Size = new System.Drawing.Size(102, 57);
            this.btnGoodsWIthTypes.TabIndex = 8;
            this.btnGoodsWIthTypes.Text = "Товары полная информация";
            this.btnGoodsWIthTypes.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 338);
            this.Controls.Add(this.btnGoodsWIthTypes);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDeliveries);
            this.Controls.Add(this.btnGoodsTypes);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnShowGoods);
            this.Controls.Add(this.mainGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView mainGrid;
        private Button btnShowGoods;
        private Button btnSuppliers;
        private Button btnGoodsTypes;
        private Button btnDeliveries;
        private Button btnUpdate;
        private Button btnGoodsWIthTypes;
    }
}
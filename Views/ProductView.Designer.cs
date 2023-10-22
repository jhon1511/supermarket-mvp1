namespace Supermarket_mvp1.Views
{
    partial class ProductView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabProductsList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            BtnSearch = new Button();
            DgProducts = new DataGridView();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabProductsDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtProductName = new TextBox();
            TxtProductCategorie = new TextBox();
            TxtProductId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            TxtProductPrice = new TextBox();
            label6 = new Label();
            TxtProductStock = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabProductsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).BeginInit();
            tabProductsDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(140, 38);
            label1.Name = "label1";
            label1.Size = new Size(100, 30);
            label1.TabIndex = 1;
            label1.Text = "Products";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabProductsList);
            tabControl1.Controls.Add(tabProductsDetail);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 2;
            // 
            // tabProductsList
            // 
            tabProductsList.Controls.Add(BtnClose);
            tabProductsList.Controls.Add(BtnDelete);
            tabProductsList.Controls.Add(BtnEdit);
            tabProductsList.Controls.Add(BtnNew);
            tabProductsList.Controls.Add(BtnSearch);
            tabProductsList.Controls.Add(DgProducts);
            tabProductsList.Controls.Add(TxtSearch);
            tabProductsList.Controls.Add(label2);
            tabProductsList.Location = new Point(4, 24);
            tabProductsList.Name = "tabProductsList";
            tabProductsList.Padding = new Padding(3);
            tabProductsList.Size = new Size(792, 322);
            tabProductsList.TabIndex = 0;
            tabProductsList.Text = "Products List ";
            tabProductsList.UseVisualStyleBackColor = true;
            tabProductsList.Click += tabPagePayModeList_Click;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cancel;
            BtnClose.Location = new Point(637, 263);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(137, 52);
            BtnClose.TabIndex = 12;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.save;
            BtnDelete.Location = new Point(637, 193);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(137, 52);
            BtnDelete.TabIndex = 11;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(637, 125);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(137, 52);
            BtnEdit.TabIndex = 10;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(637, 56);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(137, 52);
            BtnNew.TabIndex = 9;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(539, 27);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(69, 39);
            BtnSearch.TabIndex = 8;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgProducts
            // 
            DgProducts.AllowUserToAddRows = false;
            DgProducts.AllowUserToDeleteRows = false;
            DgProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProducts.Location = new Point(20, 82);
            DgProducts.Name = "DgProducts";
            DgProducts.ReadOnly = true;
            DgProducts.RowTemplate.Height = 25;
            DgProducts.Size = new Size(501, 221);
            DgProducts.TabIndex = 3;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TxtSearch.Location = new Point(20, 43);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(501, 23);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(20, 6);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Products";
            // 
            // tabProductsDetail
            // 
            tabProductsDetail.Controls.Add(TxtProductStock);
            tabProductsDetail.Controls.Add(label7);
            tabProductsDetail.Controls.Add(TxtProductPrice);
            tabProductsDetail.Controls.Add(label6);
            tabProductsDetail.Controls.Add(BtnCancel);
            tabProductsDetail.Controls.Add(BtnSave);
            tabProductsDetail.Controls.Add(TxtProductName);
            tabProductsDetail.Controls.Add(TxtProductCategorie);
            tabProductsDetail.Controls.Add(TxtProductId);
            tabProductsDetail.Controls.Add(label5);
            tabProductsDetail.Controls.Add(label4);
            tabProductsDetail.Controls.Add(label3);
            tabProductsDetail.Location = new Point(4, 24);
            tabProductsDetail.Name = "tabProductsDetail";
            tabProductsDetail.Padding = new Padding(3);
            tabProductsDetail.Size = new Size(792, 322);
            tabProductsDetail.TabIndex = 1;
            tabProductsDetail.Text = "Products Detail";
            tabProductsDetail.UseVisualStyleBackColor = true;
            tabProductsDetail.Click += tabProductsDetail_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(157, 247);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(89, 52);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(34, 247);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(89, 52);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(29, 62);
            TxtProductName.Multiline = true;
            TxtProductName.Name = "TxtProductName";
            TxtProductName.PlaceholderText = "Product Name";
            TxtProductName.Size = new Size(298, 23);
            TxtProductName.TabIndex = 5;
            // 
            // TxtProductCategorie
            // 
            TxtProductCategorie.Location = new Point(29, 194);
            TxtProductCategorie.Multiline = true;
            TxtProductCategorie.Name = "TxtProductCategorie";
            TxtProductCategorie.Size = new Size(298, 47);
            TxtProductCategorie.TabIndex = 4;
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(29, 18);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.ReadOnly = true;
            TxtProductId.Size = new Size(149, 23);
            TxtProductId.TabIndex = 3;
            TxtProductId.Text = "0";
            TxtProductId.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 176);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 2;
            label5.Text = "Category_Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 44);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 1;
            label4.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 3);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 0;
            label3.Text = "Product Id";
            // 
            // TxtProductPrice
            // 
            TxtProductPrice.Location = new Point(29, 106);
            TxtProductPrice.Multiline = true;
            TxtProductPrice.Name = "TxtProductPrice";
            TxtProductPrice.PlaceholderText = "Product Price";
            TxtProductPrice.Size = new Size(298, 23);
            TxtProductPrice.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 88);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 8;
            label6.Text = "Product Price";
            // 
            // TxtProductStock
            // 
            TxtProductStock.Location = new Point(29, 150);
            TxtProductStock.Multiline = true;
            TxtProductStock.Name = "TxtProductStock";
            TxtProductStock.Size = new Size(298, 23);
            TxtProductStock.TabIndex = 11;
            TxtProductStock.TextChanged += textBox2_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 132);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 10;
            label7.Text = "Stock";
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "ProductView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabProductsList.ResumeLayout(false);
            tabProductsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).EndInit();
            tabProductsDetail.ResumeLayout(false);
            tabProductsDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabProductsList;
        private DataGridView DgProducts;
        private TextBox TxtSearch;
        private Label label2;
        private TabPage tabProductsDetail;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProductName;
        private TextBox TxtProductCategorie;
        private TextBox TxtProductId;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnSearch;
        private TextBox TxtProductStock;
        private Label label7;
        private Label label6;
        private TextBox TxtProductPrice;
        protected internal TextBox textBox1;
    }
}
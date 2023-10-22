namespace Supermarket_mvp1.Views
{
    partial class CategoriesView
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
            tabCategorieList = new TabPage();
            DgCategorie = new DataGridView();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabCategorieDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtPayCategorieName = new TextBox();
            TxtCategorieObservation = new TextBox();
            TxtCategorieModeId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabCategorieList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategorie).BeginInit();
            tabCategorieDetail.SuspendLayout();
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
            pictureBox1.Image = Properties.Resources.categorías;
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
            label1.Size = new Size(116, 30);
            label1.TabIndex = 1;
            label1.Text = "Categories";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCategorieList);
            tabControl1.Controls.Add(tabCategorieDetail);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 2;
            // 
            // tabCategorieList
            // 
            tabCategorieList.Controls.Add(DgCategorie);
            tabCategorieList.Controls.Add(BtnClose);
            tabCategorieList.Controls.Add(BtnDelete);
            tabCategorieList.Controls.Add(BtnEdit);
            tabCategorieList.Controls.Add(BtnNew);
            tabCategorieList.Controls.Add(BtnSearch);
            tabCategorieList.Controls.Add(TxtSearch);
            tabCategorieList.Controls.Add(label2);
            tabCategorieList.Location = new Point(4, 24);
            tabCategorieList.Name = "tabCategorieList";
            tabCategorieList.Padding = new Padding(3);
            tabCategorieList.Size = new Size(792, 322);
            tabCategorieList.TabIndex = 0;
            tabCategorieList.Text = "Categorie List";
            tabCategorieList.UseVisualStyleBackColor = true;
            // 
            // DgCategorie
            // 
            DgCategorie.AllowUserToAddRows = false;
            DgCategorie.AllowUserToDeleteRows = false;
            DgCategorie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategorie.Location = new Point(24, 77);
            DgCategorie.Name = "DgCategorie";
            DgCategorie.ReadOnly = true;
            DgCategorie.RowTemplate.Height = 25;
            DgCategorie.Size = new Size(544, 234);
            DgCategorie.TabIndex = 13;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(649, 259);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(137, 52);
            BtnClose.TabIndex = 12;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(649, 189);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(137, 52);
            BtnDelete.TabIndex = 11;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(649, 121);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(137, 52);
            BtnEdit.TabIndex = 10;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(649, 52);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(137, 52);
            BtnNew.TabIndex = 9;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(574, 23);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(69, 39);
            BtnSearch.TabIndex = 8;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TxtSearch.Location = new Point(24, 39);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(544, 23);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(20, 6);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Categorie";
            // 
            // tabCategorieDetail
            // 
            tabCategorieDetail.Controls.Add(BtnCancel);
            tabCategorieDetail.Controls.Add(BtnSave);
            tabCategorieDetail.Controls.Add(TxtPayCategorieName);
            tabCategorieDetail.Controls.Add(TxtCategorieObservation);
            tabCategorieDetail.Controls.Add(TxtCategorieModeId);
            tabCategorieDetail.Controls.Add(label5);
            tabCategorieDetail.Controls.Add(label4);
            tabCategorieDetail.Controls.Add(label3);
            tabCategorieDetail.Location = new Point(4, 24);
            tabCategorieDetail.Name = "tabCategorieDetail";
            tabCategorieDetail.Padding = new Padding(3);
            tabCategorieDetail.Size = new Size(792, 322);
            tabCategorieDetail.TabIndex = 1;
            tabCategorieDetail.Text = "Categorie Detail";
            tabCategorieDetail.UseVisualStyleBackColor = true;
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
            // TxtPayCategorieName
            // 
            TxtPayCategorieName.Location = new Point(34, 101);
            TxtPayCategorieName.Multiline = true;
            TxtPayCategorieName.Name = "TxtPayCategorieName";
            TxtPayCategorieName.PlaceholderText = "Categorie Name";
            TxtPayCategorieName.ScrollBars = ScrollBars.Both;
            TxtPayCategorieName.Size = new Size(298, 23);
            TxtPayCategorieName.TabIndex = 5;
            // 
            // TxtCategorieObservation
            // 
            TxtCategorieObservation.Location = new Point(34, 153);
            TxtCategorieObservation.Multiline = true;
            TxtCategorieObservation.Name = "TxtCategorieObservation";
            TxtCategorieObservation.PlaceholderText = "Observation";
            TxtCategorieObservation.Size = new Size(298, 73);
            TxtCategorieObservation.TabIndex = 4;
            // 
            // TxtCategorieModeId
            // 
            TxtCategorieModeId.Location = new Point(34, 41);
            TxtCategorieModeId.Name = "TxtCategorieModeId";
            TxtCategorieModeId.ReadOnly = true;
            TxtCategorieModeId.Size = new Size(149, 23);
            TxtCategorieModeId.TabIndex = 3;
            TxtCategorieModeId.Text = "0";
            TxtCategorieModeId.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 138);
            label5.Name = "label5";
            label5.Size = new Size(125, 15);
            label5.TabIndex = 2;
            label5.Text = "Categorie Observation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 77);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 1;
            label4.Text = "Categorie Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 26);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 0;
            label3.Text = "Categorie Id";
            // 
            // CategoriesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategoriesView";
            Text = "CategoriesView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabCategorieList.ResumeLayout(false);
            tabCategorieList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategorie).EndInit();
            tabCategorieDetail.ResumeLayout(false);
            tabCategorieDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabCategorieList;
        private TextBox TxtSearch;
        private Label label2;
        private TabPage tabCategorieDetail;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtPayCategorieName;
        private TextBox TxtCategorieObservation;
        private TextBox TxtCategorieModeId;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnSearch;
        private DataGridView DgCategorie;
    }
}
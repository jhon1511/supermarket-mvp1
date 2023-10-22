namespace Supermarket_mvp1.Views
{
    partial class ProvidersView
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
            TabPage tabProvidersDetail;
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtPayModeName = new TextBox();
            TxtPayModeObservation = new TextBox();
            TxtPayModeId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabProvidersList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            BtnSearch = new Button();
            DgProviders = new DataGridView();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabProvidersDetail = new TabPage();
            tabProvidersDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabProvidersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).BeginInit();
            SuspendLayout();
            // 
            // tabProvidersDetail
            // 
            tabProvidersDetail.Controls.Add(BtnCancel);
            tabProvidersDetail.Controls.Add(BtnSave);
            tabProvidersDetail.Controls.Add(TxtPayModeName);
            tabProvidersDetail.Controls.Add(TxtPayModeObservation);
            tabProvidersDetail.Controls.Add(TxtPayModeId);
            tabProvidersDetail.Controls.Add(label5);
            tabProvidersDetail.Controls.Add(label4);
            tabProvidersDetail.Controls.Add(label3);
            tabProvidersDetail.Location = new Point(4, 24);
            tabProvidersDetail.Name = "tabProvidersDetail";
            tabProvidersDetail.Padding = new Padding(3);
            tabProvidersDetail.Size = new Size(801, 322);
            tabProvidersDetail.TabIndex = 1;
            tabProvidersDetail.Text = "Providers Detail";
            tabProvidersDetail.UseVisualStyleBackColor = true;
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
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(34, 101);
            TxtPayModeName.Multiline = true;
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "Product Name";
            TxtPayModeName.Size = new Size(298, 23);
            TxtPayModeName.TabIndex = 5;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(34, 153);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "Product Observation";
            TxtPayModeObservation.Size = new Size(298, 73);
            TxtPayModeObservation.TabIndex = 4;
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(34, 41);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.ReadOnly = true;
            TxtPayModeId.Size = new Size(149, 23);
            TxtPayModeId.TabIndex = 3;
            TxtPayModeId.Text = "0";
            TxtPayModeId.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 138);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 2;
            label5.Text = "Prodcut Observation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 77);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 1;
            label4.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 26);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 0;
            label3.Text = "Product Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(140, 38);
            label1.Name = "label1";
            label1.Size = new Size(105, 30);
            label1.TabIndex = 1;
            label1.Text = "Providers";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.providers;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 100);
            panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabProvidersList);
            tabControl1.Controls.Add(tabProvidersDetail);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 98);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(809, 350);
            tabControl1.TabIndex = 2;
            // 
            // tabProvidersList
            // 
            tabProvidersList.Controls.Add(BtnClose);
            tabProvidersList.Controls.Add(BtnDelete);
            tabProvidersList.Controls.Add(BtnEdit);
            tabProvidersList.Controls.Add(BtnNew);
            tabProvidersList.Controls.Add(BtnSearch);
            tabProvidersList.Controls.Add(DgProviders);
            tabProvidersList.Controls.Add(TxtSearch);
            tabProvidersList.Controls.Add(label2);
            tabProvidersList.Location = new Point(4, 24);
            tabProvidersList.Name = "tabProvidersList";
            tabProvidersList.Padding = new Padding(3);
            tabProvidersList.Size = new Size(801, 322);
            tabProvidersList.TabIndex = 0;
            tabProvidersList.Text = "Providers List ";
            tabProvidersList.UseVisualStyleBackColor = true;
            tabProvidersList.Click += tabPagePayModeList_Click;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cancel;
            BtnClose.Location = new Point(635, 265);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(137, 52);
            BtnClose.TabIndex = 12;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.save;
            BtnDelete.Location = new Point(635, 195);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(137, 52);
            BtnDelete.TabIndex = 11;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(635, 127);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(137, 52);
            BtnEdit.TabIndex = 10;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(635, 58);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(137, 52);
            BtnNew.TabIndex = 9;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(537, 29);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(69, 39);
            BtnSearch.TabIndex = 8;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgProviders
            // 
            DgProviders.AllowUserToAddRows = false;
            DgProviders.AllowUserToDeleteRows = false;
            DgProviders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProviders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProviders.Location = new Point(20, 86);
            DgProviders.Name = "DgProviders";
            DgProviders.ReadOnly = true;
            DgProviders.RowTemplate.Height = 25;
            DgProviders.Size = new Size(496, 209);
            DgProviders.TabIndex = 3;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TxtSearch.Location = new Point(20, 45);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(496, 23);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(20, 6);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Providers";
            // 
            // ProvidersView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 448);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProvidersView";
            Text = "ProvidersView";
            tabProvidersDetail.ResumeLayout(false);
            tabProvidersDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabProvidersList.ResumeLayout(false);
            tabProvidersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabProvidersList;
        private DataGridView DgProviders;
        private TextBox TxtSearch;
        private Label label2;
        private TabPage tabProvidersDetail;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtPayModeName;
        private TextBox TxtPayModeObservation;
        private TextBox TxtPayModeId;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnSearch;
    }
}
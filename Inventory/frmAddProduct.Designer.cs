namespace Inventory
{
    partial class frmAddProduct
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblProduct = new Label();
            txtProductName = new TextBox();
            lblCategory = new Label();
            cbCategory = new ComboBox();
            lblMfgDate = new Label();
            dtPickerMfgDate = new DateTimePicker();
            lblExpDate = new Label();
            dtPickerExpDate = new DateTimePicker();
            lblQty = new Label();
            txtQuantity = new TextBox();
            lblSellPrice = new Label();
            txtSellPrice = new TextBox();
            lblDescription = new Label();
            richTxtDescription = new RichTextBox();
            btnAddProduct = new Button();
            gridViewProductList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(159, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add Product";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProduct.ForeColor = Color.Black;
            lblProduct.Location = new Point(20, 63);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(70, 21);
            lblProduct.TabIndex = 1;
            lblProduct.Text = "Product";
            // 
            // txtProductName
            // 
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Font = new Font("Segoe UI", 10F);
            txtProductName.Location = new Point(110, 60);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(220, 25);
            txtProductName.TabIndex = 2;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCategory.ForeColor = Color.Black;
            lblCategory.Location = new Point(20, 98);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(80, 21);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Category";
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.Font = new Font("Segoe UI", 10F);
            cbCategory.Location = new Point(110, 95);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(220, 25);
            cbCategory.TabIndex = 4;
            // 
            // lblMfgDate
            // 
            lblMfgDate.AutoSize = true;
            lblMfgDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMfgDate.ForeColor = Color.Black;
            lblMfgDate.Location = new Point(20, 133);
            lblMfgDate.Name = "lblMfgDate";
            lblMfgDate.Size = new Size(85, 21);
            lblMfgDate.TabIndex = 5;
            lblMfgDate.Text = "Mfg. Date";
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.Font = new Font("Segoe UI", 10F);
            dtPickerMfgDate.Location = new Point(110, 130);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(220, 25);
            dtPickerMfgDate.TabIndex = 6;
            // 
            // lblExpDate
            // 
            lblExpDate.AutoSize = true;
            lblExpDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblExpDate.ForeColor = Color.Black;
            lblExpDate.Location = new Point(20, 168);
            lblExpDate.Name = "lblExpDate";
            lblExpDate.Size = new Size(82, 21);
            lblExpDate.TabIndex = 7;
            lblExpDate.Text = "Exp. Date";
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.Font = new Font("Segoe UI", 10F);
            dtPickerExpDate.Location = new Point(110, 165);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(220, 25);
            dtPickerExpDate.TabIndex = 8;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblQty.ForeColor = Color.Black;
            lblQty.Location = new Point(20, 203);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(40, 21);
            lblQty.TabIndex = 9;
            lblQty.Text = "Qty.";
            // 
            // txtQuantity
            // 
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Font = new Font("Segoe UI", 10F);
            txtQuantity.Location = new Point(110, 200);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(220, 25);
            txtQuantity.TabIndex = 10;
            // 
            // lblSellPrice
            // 
            lblSellPrice.AutoSize = true;
            lblSellPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSellPrice.ForeColor = Color.Black;
            lblSellPrice.Location = new Point(20, 238);
            lblSellPrice.Name = "lblSellPrice";
            lblSellPrice.Size = new Size(80, 21);
            lblSellPrice.TabIndex = 11;
            lblSellPrice.Text = "Sell Price";
            // 
            // txtSellPrice
            // 
            txtSellPrice.BorderStyle = BorderStyle.FixedSingle;
            txtSellPrice.Font = new Font("Segoe UI", 10F);
            txtSellPrice.Location = new Point(110, 235);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(220, 25);
            txtSellPrice.TabIndex = 12;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDescription.ForeColor = Color.Black;
            lblDescription.Location = new Point(360, 76);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(98, 21);
            lblDescription.TabIndex = 13;
            lblDescription.Text = "Description";
            // 
            // richTxtDescription
            // 
            richTxtDescription.Font = new Font("Segoe UI", 10F);
            richTxtDescription.Location = new Point(360, 109);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(400, 150);
            richTxtDescription.TabIndex = 14;
            richTxtDescription.Text = "";
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.FromArgb(64, 64, 64);
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(660, 272);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(100, 30);
            btnAddProduct.TabIndex = 15;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // gridViewProductList
            // 
            gridViewProductList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridViewProductList.Location = new Point(20, 308);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.Size = new Size(740, 148);
            gridViewProductList.TabIndex = 16;
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(780, 477);
            Controls.Add(gridViewProductList);
            Controls.Add(btnAddProduct);
            Controls.Add(richTxtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtSellPrice);
            Controls.Add(lblSellPrice);
            Controls.Add(txtQuantity);
            Controls.Add(lblQty);
            Controls.Add(dtPickerExpDate);
            Controls.Add(lblExpDate);
            Controls.Add(dtPickerMfgDate);
            Controls.Add(lblMfgDate);
            Controls.Add(cbCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtProductName);
            Controls.Add(lblProduct);
            Controls.Add(lblTitle);
            Name = "frmAddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory";
            Load += frmAddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblProduct;
        private TextBox txtProductName;
        private Label lblCategory;
        private ComboBox cbCategory;
        private Label lblMfgDate;
        private DateTimePicker dtPickerMfgDate;
        private Label lblExpDate;
        private DateTimePicker dtPickerExpDate;
        private Label lblQty;
        private TextBox txtQuantity;
        private Label lblSellPrice;
        private TextBox txtSellPrice;
        private Label lblDescription;
        private RichTextBox richTxtDescription;
        private Button btnAddProduct;
        private DataGridView gridViewProductList;
    }
}

namespace InventoryOrder.Forms
{
    partial class Cash
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cash));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.txtCReportNumb = new System.Windows.Forms.TextBox();
            this.gbCash = new System.Windows.Forms.GroupBox();
            this.dgvCash = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.btnAddorder = new System.Windows.Forms.Button();
            this.btncanOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.lblTranNo = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLookUpProd = new System.Windows.Forms.Button();
            this.pItems = new System.Windows.Forms.Panel();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblCReport = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbCash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCash)).BeginInit();
            this.gbOrder.SuspendLayout();
            this.pItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCname);
            this.groupBox1.Controls.Add(this.txtCReportNumb);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات العميل";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(22, 213);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(159, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(187, 213);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "اسم العميل:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "رقم البلاغ:";
            // 
            // txtCname
            // 
            this.txtCname.BackColor = System.Drawing.Color.White;
            this.txtCname.Location = new System.Drawing.Point(22, 138);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(205, 34);
            this.txtCname.TabIndex = 1;
            // 
            // txtCReportNumb
            // 
            this.txtCReportNumb.BackColor = System.Drawing.Color.White;
            this.txtCReportNumb.Location = new System.Drawing.Point(22, 87);
            this.txtCReportNumb.Name = "txtCReportNumb";
            this.txtCReportNumb.Size = new System.Drawing.Size(205, 34);
            this.txtCReportNumb.TabIndex = 0;
            this.txtCReportNumb.TextChanged += new System.EventHandler(this.txtCReportNumb_TextChanged);
            this.txtCReportNumb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCReportNumb_KeyPress);
            // 
            // gbCash
            // 
            this.gbCash.Controls.Add(this.dgvCash);
            this.gbCash.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCash.Location = new System.Drawing.Point(379, 12);
            this.gbCash.Name = "gbCash";
            this.gbCash.Size = new System.Drawing.Size(949, 610);
            this.gbCash.TabIndex = 4;
            this.gbCash.TabStop = false;
            this.gbCash.Text = "المنتجات التي تم اخذها بواسطة العميل:";
            // 
            // dgvCash
            // 
            this.dgvCash.AllowUserToAddRows = false;
            this.dgvCash.AllowUserToDeleteRows = false;
            this.dgvCash.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCash.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCash.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column8,
            this.Column9,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Delete});
            this.dgvCash.EnableHeadersVisualStyles = false;
            this.dgvCash.Location = new System.Drawing.Point(0, 27);
            this.dgvCash.Name = "dgvCash";
            this.dgvCash.ReadOnly = true;
            this.dgvCash.RowHeadersWidth = 45;
            this.dgvCash.RowTemplate.Height = 37;
            this.dgvCash.Size = new System.Drawing.Size(943, 559);
            this.dgvCash.TabIndex = 0;
            this.dgvCash.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCash_CellContentClick);
            this.dgvCash.SelectionChanged += new System.EventHandler(this.dgvCash_SelectionChanged);
            this.dgvCash.Validating += new System.ComponentModel.CancelEventHandler(this.dgvCash_Validating);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 115;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "cashid";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            this.Column8.Width = 110;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "proid";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            this.Column9.Width = 115;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "رقم الفاتورة";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 115;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "كود الصنف";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 115;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "الوصف";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "السعر";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 78;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "الكمية";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 78;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "الاجمالي";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 96;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 6;
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.btnAddorder);
            this.gbOrder.Controls.Add(this.btncanOrder);
            this.gbOrder.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrder.Location = new System.Drawing.Point(379, 625);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(936, 92);
            this.gbOrder.TabIndex = 4;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "العمليات المتاحة";
            // 
            // btnAddorder
            // 
            this.btnAddorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.btnAddorder.FlatAppearance.BorderSize = 0;
            this.btnAddorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddorder.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddorder.ForeColor = System.Drawing.Color.White;
            this.btnAddorder.Location = new System.Drawing.Point(601, 33);
            this.btnAddorder.Name = "btnAddorder";
            this.btnAddorder.Size = new System.Drawing.Size(190, 42);
            this.btnAddorder.TabIndex = 1;
            this.btnAddorder.Text = "تأكيد الطلب";
            this.btnAddorder.UseVisualStyleBackColor = false;
            this.btnAddorder.Click += new System.EventHandler(this.btnAddorder_Click);
            // 
            // btncanOrder
            // 
            this.btncanOrder.BackColor = System.Drawing.Color.Maroon;
            this.btncanOrder.FlatAppearance.BorderSize = 0;
            this.btncanOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncanOrder.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncanOrder.ForeColor = System.Drawing.Color.White;
            this.btncanOrder.Location = new System.Drawing.Point(213, 33);
            this.btncanOrder.Name = "btncanOrder";
            this.btncanOrder.Size = new System.Drawing.Size(205, 42);
            this.btncanOrder.TabIndex = 3;
            this.btncanOrder.Text = "الغاء العملية";
            this.btncanOrder.UseVisualStyleBackColor = false;
            this.btncanOrder.Click += new System.EventHandler(this.btncanOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "الإجمالي:";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(22, 225);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(122, 26);
            this.date.TabIndex = 6;
            this.date.Text = "***********";
            // 
            // lblTranNo
            // 
            this.lblTranNo.AutoSize = true;
            this.lblTranNo.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTranNo.Location = new System.Drawing.Point(22, 109);
            this.lblTranNo.Name = "lblTranNo";
            this.lblTranNo.Size = new System.Drawing.Size(38, 26);
            this.lblTranNo.TabIndex = 7;
            this.lblTranNo.Text = "{?}";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(41, 276);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(54, 26);
            this.lbltotal.TabIndex = 8;
            this.lbltotal.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(270, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "التاريخ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(252, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "رقم البلاغ:";
            // 
            // btnLookUpProd
            // 
            this.btnLookUpProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.btnLookUpProd.FlatAppearance.BorderSize = 0;
            this.btnLookUpProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLookUpProd.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookUpProd.ForeColor = System.Drawing.Color.White;
            this.btnLookUpProd.Location = new System.Drawing.Point(12, 323);
            this.btnLookUpProd.Name = "btnLookUpProd";
            this.btnLookUpProd.Size = new System.Drawing.Size(361, 62);
            this.btnLookUpProd.TabIndex = 11;
            this.btnLookUpProd.Text = "بحث عن الأصناف";
            this.btnLookUpProd.UseVisualStyleBackColor = false;
            this.btnLookUpProd.Click += new System.EventHandler(this.btnLookUpProd_Click_1);
            // 
            // pItems
            // 
            this.pItems.Controls.Add(this.txtQty);
            this.pItems.Controls.Add(this.txtBarcode);
            this.pItems.Controls.Add(this.lblCReport);
            this.pItems.Controls.Add(this.label5);
            this.pItems.Controls.Add(this.label9);
            this.pItems.Controls.Add(this.lbltotal);
            this.pItems.Controls.Add(this.label8);
            this.pItems.Controls.Add(this.label4);
            this.pItems.Controls.Add(this.lblTranNo);
            this.pItems.Controls.Add(this.date);
            this.pItems.Location = new System.Drawing.Point(12, 406);
            this.pItems.Name = "pItems";
            this.pItems.Size = new System.Drawing.Size(361, 311);
            this.pItems.TabIndex = 29;
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.Color.White;
            this.txtQty.Enabled = false;
            this.txtQty.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(22, 32);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(33, 34);
            this.txtQty.TabIndex = 32;
            this.txtQty.Text = "1";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.Color.White;
            this.txtBarcode.Enabled = false;
            this.txtBarcode.Location = new System.Drawing.Point(75, 35);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(247, 28);
            this.txtBarcode.TabIndex = 31;
            // 
            // lblCReport
            // 
            this.lblCReport.AutoSize = true;
            this.lblCReport.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCReport.Location = new System.Drawing.Point(41, 167);
            this.lblCReport.Name = "lblCReport";
            this.lblCReport.Size = new System.Drawing.Size(38, 26);
            this.lblCReport.TabIndex = 30;
            this.lblCReport.Text = "{?}";
            this.lblCReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(252, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "كود العملية:";
            // 
            // Cash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 729);
            this.Controls.Add(this.gbOrder);
            this.Controls.Add(this.pItems);
            this.Controls.Add(this.btnLookUpProd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCash);
            this.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Cash";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صرف المنتجات";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cash_FormClosing);
            this.Load += new System.EventHandler(this.Cash_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCash.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCash)).EndInit();
            this.gbOrder.ResumeLayout(false);
            this.pItems.ResumeLayout(false);
            this.pItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.TextBox txtCReportNumb;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbCash;
        private System.Windows.Forms.Button btncanOrder;
        private System.Windows.Forms.Button btnAddorder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvCash;
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.Button btnLookUpProd;
        public System.Windows.Forms.Label lbltotal;
        public System.Windows.Forms.Label lblTranNo;
        private System.Windows.Forms.Panel pItems;
        public System.Windows.Forms.Label lblCReport;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtQty;
        public System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}
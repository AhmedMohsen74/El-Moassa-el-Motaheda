
namespace InventoryOrder.Forms
{
    partial class Fatora
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fatora));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblfatora = new System.Windows.Forms.Label();
            this.txtfatoraSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvfatora = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnprintFatoras = new System.Windows.Forms.Button();
            this.btnDelfatora = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfatora)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblfatora);
            this.panel3.Controls.Add(this.txtfatoraSearch);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1357, 125);
            this.panel3.TabIndex = 11;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = " كود الفاتورة";
            // 
            // lblfatora
            // 
            this.lblfatora.AutoSize = true;
            this.lblfatora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfatora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.lblfatora.Location = new System.Drawing.Point(25, 64);
            this.lblfatora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfatora.Name = "lblfatora";
            this.lblfatora.Size = new System.Drawing.Size(35, 24);
            this.lblfatora.TabIndex = 8;
            this.lblfatora.Text = "{?}";
            // 
            // txtfatoraSearch
            // 
            this.txtfatoraSearch.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfatoraSearch.Location = new System.Drawing.Point(202, 54);
            this.txtfatoraSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtfatoraSearch.Name = "txtfatoraSearch";
            this.txtfatoraSearch.Size = new System.Drawing.Size(558, 34);
            this.txtfatoraSearch.TabIndex = 7;
            this.txtfatoraSearch.TextChanged += new System.EventHandler(this.txtfatora_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(792, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = " بحث بكود الفاتورة:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(1017, 36);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 62);
            this.button3.TabIndex = 5;
            this.button3.Text = "اضافة منتج";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvfatora
            // 
            this.dgvfatora.AllowUserToAddRows = false;
            this.dgvfatora.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvfatora.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvfatora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvfatora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvfatora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfatora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2,
            this.View});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvfatora.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvfatora.EnableHeadersVisualStyles = false;
            this.dgvfatora.Location = new System.Drawing.Point(8, 37);
            this.dgvfatora.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvfatora.Name = "dgvfatora";
            this.dgvfatora.ReadOnly = true;
            this.dgvfatora.RowHeadersWidth = 45;
            this.dgvfatora.RowTemplate.Height = 37;
            this.dgvfatora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvfatora.Size = new System.Drawing.Size(1349, 410);
            this.dgvfatora.TabIndex = 3;
            this.dgvfatora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfatora_CellContentClick);
            this.dgvfatora.SelectionChanged += new System.EventHandler(this.dgvfatora_SelectionChanged);
            // 
            // Column3
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "ID";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "رقم الفاتورة";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "تاريخ الفاتورة";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // View
            // 
            this.View.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            this.View.DefaultCellStyle = dataGridViewCellStyle4;
            this.View.HeaderText = "";
            this.View.MinimumWidth = 6;
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Text = "عرض المنتجات";
            this.View.ToolTipText = "عرض المنتجات";
            this.View.UseColumnTextForButtonValue = true;
            this.View.Width = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnprintFatoras);
            this.groupBox2.Controls.Add(this.btnDelfatora);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 590);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1349, 127);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتااحة:";
            // 
            // btnprintFatoras
            // 
            this.btnprintFatoras.FlatAppearance.BorderSize = 0;
            this.btnprintFatoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprintFatoras.Font = new System.Drawing.Font("Century Gothic", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprintFatoras.Image = ((System.Drawing.Image)(resources.GetObject("btnprintFatoras.Image")));
            this.btnprintFatoras.Location = new System.Drawing.Point(709, 37);
            this.btnprintFatoras.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnprintFatoras.Name = "btnprintFatoras";
            this.btnprintFatoras.Size = new System.Drawing.Size(258, 94);
            this.btnprintFatoras.TabIndex = 11;
            this.btnprintFatoras.UseVisualStyleBackColor = true;
            this.btnprintFatoras.Click += new System.EventHandler(this.btnprintFatoras_Click);
            // 
            // btnDelfatora
            // 
            this.btnDelfatora.BackColor = System.Drawing.Color.Maroon;
            this.btnDelfatora.Enabled = false;
            this.btnDelfatora.FlatAppearance.BorderSize = 0;
            this.btnDelfatora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelfatora.Font = new System.Drawing.Font("Century Gothic", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelfatora.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelfatora.Location = new System.Drawing.Point(331, 37);
            this.btnDelfatora.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelfatora.Name = "btnDelfatora";
            this.btnDelfatora.Size = new System.Drawing.Size(268, 83);
            this.btnDelfatora.TabIndex = 7;
            this.btnDelfatora.Text = "حذف فاتورة";
            this.btnDelfatora.UseVisualStyleBackColor = false;
            this.btnDelfatora.Click += new System.EventHandler(this.btnDelfatora_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvfatora);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 131);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1357, 453);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لائحة الفواتير";
            // 
            // Fatora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 729);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Fatora";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الفواتير";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfatora)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtfatoraSearch;
        private System.Windows.Forms.DataGridView dgvfatora;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnprintFatoras;
        private System.Windows.Forms.Button btnDelfatora;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblfatora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn View;
    }
}
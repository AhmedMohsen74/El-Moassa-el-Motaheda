
namespace InventoryOrder.Forms
{
    partial class UpdateProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProducts));
            this.txtFatId = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtsell = new System.Windows.Forms.TextBox();
            this.txtpurch = new System.Windows.Forms.TextBox();
            this.txtQTY = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtrealQTY = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFatId
            // 
            this.txtFatId.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFatId.Location = new System.Drawing.Point(79, 62);
            this.txtFatId.Name = "txtFatId";
            this.txtFatId.ReadOnly = true;
            this.txtFatId.Size = new System.Drawing.Size(414, 33);
            this.txtFatId.TabIndex = 25;
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(79, 538);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(414, 33);
            this.txttotal.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(79, 607);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 66);
            this.button1.TabIndex = 21;
            this.button1.Text = "الغاء";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Narrow", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(322, 607);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(240, 66);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "تعديل المنتج";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtsell
            // 
            this.txtsell.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsell.Location = new System.Drawing.Point(79, 470);
            this.txtsell.Name = "txtsell";
            this.txtsell.ReadOnly = true;
            this.txtsell.Size = new System.Drawing.Size(414, 33);
            this.txtsell.TabIndex = 19;
            // 
            // txtpurch
            // 
            this.txtpurch.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpurch.Location = new System.Drawing.Point(79, 402);
            this.txtpurch.Name = "txtpurch";
            this.txtpurch.Size = new System.Drawing.Size(414, 33);
            this.txtpurch.TabIndex = 18;
            this.txtpurch.TextChanged += new System.EventHandler(this.txtpurch_TextChanged);
            this.txtpurch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpurch_KeyPress);
            this.txtpurch.Validating += new System.ComponentModel.CancelEventHandler(this.txtpurch_Validating);
            // 
            // txtQTY
            // 
            this.txtQTY.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQTY.Location = new System.Drawing.Point(79, 334);
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.Size = new System.Drawing.Size(414, 33);
            this.txtQTY.TabIndex = 17;
            this.txtQTY.TextChanged += new System.EventHandler(this.txtQTY_TextChanged);
            this.txtQTY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQTY_KeyPress);
            this.txtQTY.Validating += new System.ComponentModel.CancelEventHandler(this.txtQTY_Validating);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(79, 198);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(414, 33);
            this.txtname.TabIndex = 16;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(79, 130);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(414, 33);
            this.txtID.TabIndex = 15;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtrealQTY);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFatId);
            this.panel1.Controls.Add(this.txttotal);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtsell);
            this.panel1.Controls.Add(this.txtpurch);
            this.panel1.Controls.Add(this.txtQTY);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(679, 703);
            this.panel1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(505, 538);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 31);
            this.label7.TabIndex = 46;
            this.label7.Text = "اجمالي:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(505, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 31);
            this.label6.TabIndex = 45;
            this.label6.Text = "سعر البيع:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(505, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 31);
            this.label5.TabIndex = 44;
            this.label5.Text = "سعر الشراء:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(499, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 31);
            this.label4.TabIndex = 43;
            this.label4.Text = "الوصف:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(505, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 31);
            this.label3.TabIndex = 42;
            this.label3.Text = "الكمية المتبقية:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(499, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 31);
            this.label2.TabIndex = 41;
            this.label2.Text = "كود المنتج:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(499, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 40;
            this.label1.Text = "كود الفاتورة:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(499, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 31);
            this.label8.TabIndex = 48;
            this.label8.Text = "الكمية الاصلية:";
            // 
            // txtrealQTY
            // 
            this.txtrealQTY.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrealQTY.Location = new System.Drawing.Point(79, 266);
            this.txtrealQTY.Name = "txtrealQTY";
            this.txtrealQTY.Size = new System.Drawing.Size(414, 33);
            this.txtrealQTY.TabIndex = 47;
            // 
            // UpdateProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 703);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.26415F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateProducts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تعديل بيانات منتج";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox txtFatId;
        public System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.TextBox txtsell;
        public System.Windows.Forms.TextBox txtpurch;
        public System.Windows.Forms.TextBox txtQTY;
        public System.Windows.Forms.TextBox txtname;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtrealQTY;
    }
}
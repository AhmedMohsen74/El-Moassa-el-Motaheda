
namespace InventoryOrder.Forms
{
    partial class FatoraModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FatoraModule));
            this.txtfatoraid = new System.Windows.Forms.TextBox();
            this.datefatoradate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtfatoraid
            // 
            this.txtfatoraid.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfatoraid.Location = new System.Drawing.Point(274, 128);
            this.txtfatoraid.Margin = new System.Windows.Forms.Padding(5);
            this.txtfatoraid.Name = "txtfatoraid";
            this.txtfatoraid.Size = new System.Drawing.Size(577, 33);
            this.txtfatoraid.TabIndex = 0;
            this.txtfatoraid.TextChanged += new System.EventHandler(this.txtfatoraid_TextChanged);
            this.txtfatoraid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfatoraid_KeyPress);
            this.txtfatoraid.Validated += new System.EventHandler(this.txtfatoraid_Validated);
            // 
            // datefatoradate
            // 
            this.datefatoradate.CustomFormat = "dd/MM/yyyy";
            this.datefatoradate.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datefatoradate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datefatoradate.Location = new System.Drawing.Point(274, 194);
            this.datefatoradate.Name = "datefatoradate";
            this.datefatoradate.Size = new System.Drawing.Size(577, 33);
            this.datefatoradate.TabIndex = 3;
            this.datefatoradate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "رقم الفاتورة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "تاريخ قدومها";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(274, 262);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(272, 75);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "اضافة فاتورة";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCan
            // 
            this.btnCan.BackColor = System.Drawing.Color.Maroon;
            this.btnCan.FlatAppearance.BorderSize = 0;
            this.btnCan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCan.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCan.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCan.Location = new System.Drawing.Point(579, 262);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(272, 75);
            this.btnCan.TabIndex = 8;
            this.btnCan.Text = "الغاء";
            this.btnCan.UseVisualStyleBackColor = false;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(108, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 5);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(108, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 5);
            this.panel2.TabIndex = 10;
            // 
            // FatoraModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 465);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datefatoradate);
            this.Controls.Add(this.txtfatoraid);
            this.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FatoraModule";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بيانات الفاتورة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker datefatoradate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCan;
        public System.Windows.Forms.TextBox txtfatoraid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
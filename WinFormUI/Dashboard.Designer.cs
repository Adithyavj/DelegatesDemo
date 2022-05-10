
namespace WinFormUI
{
    partial class Dashboard
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
            this.btn_msgbox = new System.Windows.Forms.Button();
            this.btn_txtbox = new System.Windows.Forms.Button();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_msgbox
            // 
            this.btn_msgbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_msgbox.Location = new System.Drawing.Point(36, 172);
            this.btn_msgbox.Name = "btn_msgbox";
            this.btn_msgbox.Size = new System.Drawing.Size(209, 81);
            this.btn_msgbox.TabIndex = 0;
            this.btn_msgbox.Text = "MessageBox Demo";
            this.btn_msgbox.UseVisualStyleBackColor = true;
            this.btn_msgbox.Click += new System.EventHandler(this.btn_msgbox_Click);
            // 
            // btn_txtbox
            // 
            this.btn_txtbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_txtbox.Location = new System.Drawing.Point(253, 172);
            this.btn_txtbox.Name = "btn_txtbox";
            this.btn_txtbox.Size = new System.Drawing.Size(209, 81);
            this.btn_txtbox.TabIndex = 1;
            this.btn_txtbox.Text = "TextBox Demo";
            this.btn_txtbox.UseVisualStyleBackColor = true;
            this.btn_txtbox.Click += new System.EventHandler(this.btn_txtbox_Click);
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Location = new System.Drawing.Point(258, 54);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(209, 23);
            this.txt_subtotal.TabIndex = 2;
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_subtotal.Location = new System.Drawing.Point(258, 22);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(73, 21);
            this.lbl_subtotal.TabIndex = 3;
            this.lbl_subtotal.Text = "Sub Total";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_total.Location = new System.Drawing.Point(258, 84);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(42, 21);
            this.lbl_total.TabIndex = 5;
            this.lbl_total.Text = "Total";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(258, 114);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(209, 23);
            this.txt_total.TabIndex = 4;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 283);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.lbl_subtotal);
            this.Controls.Add(this.txt_subtotal);
            this.Controls.Add(this.btn_txtbox);
            this.Controls.Add(this.btn_msgbox);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_msgbox;
        private System.Windows.Forms.Button btn_txtbox;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_total;
    }
}
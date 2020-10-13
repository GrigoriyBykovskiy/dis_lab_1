namespace dis_lab_1
{
    partial class Form3
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
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_surname = new System.Windows.Forms.Label();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.label_tail = new System.Windows.Forms.Label();
            this.textBox_tail = new System.Windows.Forms.TextBox();
            this.label_result = new System.Windows.Forms.Label();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(10, 10);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(89, 20);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "имя (ASCII):";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(10, 40);
            this.textBox_name.Multiline = true;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.ReadOnly = true;
            this.textBox_name.Size = new System.Drawing.Size(500, 35);
            this.textBox_name.TabIndex = 1;
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(10, 90);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(124, 20);
            this.label_surname.TabIndex = 0;
            this.label_surname.Text = "фамилия (ASCII):";
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(10, 130);
            this.textBox_surname.Multiline = true;
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.ReadOnly = true;
            this.textBox_surname.Size = new System.Drawing.Size(500, 35);
            this.textBox_surname.TabIndex = 1;
            // 
            // label_tail
            // 
            this.label_tail.AutoSize = true;
            this.label_tail.Location = new System.Drawing.Point(10, 180);
            this.label_tail.Name = "label_tail";
            this.label_tail.Size = new System.Drawing.Size(49, 20);
            this.label_tail.TabIndex = 0;
            this.label_tail.Text = "хвост:";
            // 
            // textBox_tail
            // 
            this.textBox_tail.Location = new System.Drawing.Point(10, 220);
            this.textBox_tail.Multiline = true;
            this.textBox_tail.Name = "textBox_tail";
            this.textBox_tail.ReadOnly = true;
            this.textBox_tail.Size = new System.Drawing.Size(500, 35);
            this.textBox_tail.TabIndex = 1;
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(10, 280);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(124, 20);
            this.label_result.TabIndex = 0;
            this.label_result.Text = "результат(ASCII):";
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(10, 320);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(500, 35);
            this.textBox_result.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.textBox_tail);
            this.Controls.Add(this.label_tail);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "РИС_л_р_1_результат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.Label label_tail;
        private System.Windows.Forms.TextBox textBox_tail;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.TextBox textBox_result;
    }
}
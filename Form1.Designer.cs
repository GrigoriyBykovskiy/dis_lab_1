namespace dis_lab_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_name = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.button_get_result = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.button_get_log = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_name
            // 
            resources.ApplyResources(this.label_name, "label_name");
            this.label_name.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_name.Name = "label_name";
            this.label_name.UseMnemonic = false;
            // 
            // label_surname
            // 
            resources.ApplyResources(this.label_surname, "label_surname");
            this.label_surname.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label_surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_surname.Name = "label_surname";
            this.label_surname.UseMnemonic = false;
            // 
            // button_get_result
            // 
            resources.ApplyResources(this.button_get_result, "button_get_result");
            this.button_get_result.Name = "button_get_result";
            this.button_get_result.UseVisualStyleBackColor = true;
            this.button_get_result.Click += new System.EventHandler(this.button_get_result_Click);
            // 
            // textBox_name
            // 
            resources.ApplyResources(this.textBox_name, "textBox_name");
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.GotFocus += new System.EventHandler(this.textBox_name_GotFocus);
            this.textBox_name.LostFocus += new System.EventHandler(this.textBox_name_LostFocus);
            // 
            // textBox_surname
            // 
            resources.ApplyResources(this.textBox_surname, "textBox_surname");
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.GotFocus += new System.EventHandler(this.textBox_surname_GotFocus);
            this.textBox_surname.LostFocus += new System.EventHandler(this.textBox_surname_LostFocus);
            // 
            // button_get_log
            // 
            resources.ApplyResources(this.button_get_log, "button_get_log");
            this.button_get_log.Name = "button_get_log";
            this.button_get_log.UseVisualStyleBackColor = true;
            this.button_get_log.Click += new System.EventHandler(this.button_get_log_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.button_get_log);
            this.Controls.Add(this.button_get_result);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Button button_get_result;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.Button button_get_log;
    }
}


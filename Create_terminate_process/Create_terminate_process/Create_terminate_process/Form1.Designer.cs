namespace Create_terminate_process
{
    partial class Form1
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
            this.b_start_first_process = new System.Windows.Forms.Button();
            this.b_start_second_process = new System.Windows.Forms.Button();
            this.b_start_third_process = new System.Windows.Forms.Button();
            this.lbl_first_process = new System.Windows.Forms.Label();
            this.lbl_second_process = new System.Windows.Forms.Label();
            this.lbl_third_process = new System.Windows.Forms.Label();
            this.tb_first_process = new System.Windows.Forms.TextBox();
            this.tb_second_process = new System.Windows.Forms.TextBox();
            this.tb_third_process = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b_start_first_process
            // 
            this.b_start_first_process.Location = new System.Drawing.Point(49, 224);
            this.b_start_first_process.Name = "b_start_first_process";
            this.b_start_first_process.Size = new System.Drawing.Size(157, 31);
            this.b_start_first_process.TabIndex = 0;
            this.b_start_first_process.Text = "Start first process";
            this.b_start_first_process.UseVisualStyleBackColor = true;
            this.b_start_first_process.Click += new System.EventHandler(this.b_start_first_process_Click);
            // 
            // b_start_second_process
            // 
            this.b_start_second_process.Location = new System.Drawing.Point(285, 224);
            this.b_start_second_process.Name = "b_start_second_process";
            this.b_start_second_process.Size = new System.Drawing.Size(157, 31);
            this.b_start_second_process.TabIndex = 1;
            this.b_start_second_process.Text = "Start second process";
            this.b_start_second_process.UseVisualStyleBackColor = true;
            this.b_start_second_process.Click += new System.EventHandler(this.b_start_second_process_Click);
            // 
            // b_start_third_process
            // 
            this.b_start_third_process.Location = new System.Drawing.Point(546, 224);
            this.b_start_third_process.Name = "b_start_third_process";
            this.b_start_third_process.Size = new System.Drawing.Size(157, 31);
            this.b_start_third_process.TabIndex = 2;
            this.b_start_third_process.Text = "Start third process";
            this.b_start_third_process.UseVisualStyleBackColor = true;
            this.b_start_third_process.Click += new System.EventHandler(this.b_start_third_process_Click);
            // 
            // lbl_first_process
            // 
            this.lbl_first_process.AutoSize = true;
            this.lbl_first_process.Location = new System.Drawing.Point(46, 162);
            this.lbl_first_process.Name = "lbl_first_process";
            this.lbl_first_process.Size = new System.Drawing.Size(205, 17);
            this.lbl_first_process.TabIndex = 3;
            this.lbl_first_process.Text = "Waiting for first process to start";
            // 
            // lbl_second_process
            // 
            this.lbl_second_process.AutoSize = true;
            this.lbl_second_process.Location = new System.Drawing.Point(282, 162);
            this.lbl_second_process.Name = "lbl_second_process";
            this.lbl_second_process.Size = new System.Drawing.Size(228, 17);
            this.lbl_second_process.TabIndex = 4;
            this.lbl_second_process.Text = "Waiting for second process to start";
            // 
            // lbl_third_process
            // 
            this.lbl_third_process.AutoSize = true;
            this.lbl_third_process.Location = new System.Drawing.Point(543, 162);
            this.lbl_third_process.Name = "lbl_third_process";
            this.lbl_third_process.Size = new System.Drawing.Size(210, 17);
            this.lbl_third_process.TabIndex = 5;
            this.lbl_third_process.Text = "Waiting for third process to start";
            // 
            // tb_first_process
            // 
            this.tb_first_process.Location = new System.Drawing.Point(49, 102);
            this.tb_first_process.Name = "tb_first_process";
            this.tb_first_process.Size = new System.Drawing.Size(199, 22);
            this.tb_first_process.TabIndex = 9;
            this.tb_first_process.Text = "Enter first process to start";
            this.tb_first_process.TextChanged += new System.EventHandler(this.tb_first_process_TextChanged);
            // 
            // tb_second_process
            // 
            this.tb_second_process.Location = new System.Drawing.Point(285, 102);
            this.tb_second_process.Name = "tb_second_process";
            this.tb_second_process.Size = new System.Drawing.Size(199, 22);
            this.tb_second_process.TabIndex = 10;
            this.tb_second_process.Text = "Enter second process to start";
            this.tb_second_process.TextChanged += new System.EventHandler(this.tb_second_process_TextChanged);
            // 
            // tb_third_process
            // 
            this.tb_third_process.Location = new System.Drawing.Point(546, 102);
            this.tb_third_process.Name = "tb_third_process";
            this.tb_third_process.Size = new System.Drawing.Size(199, 22);
            this.tb_third_process.TabIndex = 11;
            this.tb_third_process.Text = "Enter third process to start";
            this.tb_third_process.TextChanged += new System.EventHandler(this.tb_third_process_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 348);
            this.Controls.Add(this.tb_third_process);
            this.Controls.Add(this.tb_second_process);
            this.Controls.Add(this.tb_first_process);
            this.Controls.Add(this.lbl_third_process);
            this.Controls.Add(this.lbl_second_process);
            this.Controls.Add(this.lbl_first_process);
            this.Controls.Add(this.b_start_third_process);
            this.Controls.Add(this.b_start_second_process);
            this.Controls.Add(this.b_start_first_process);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_start_first_process;
        private System.Windows.Forms.Button b_start_second_process;
        private System.Windows.Forms.Button b_start_third_process;
        private System.Windows.Forms.Label lbl_first_process;
        private System.Windows.Forms.Label lbl_second_process;
        private System.Windows.Forms.Label lbl_third_process;
        private System.Windows.Forms.TextBox tb_first_process;
        private System.Windows.Forms.TextBox tb_second_process;
        private System.Windows.Forms.TextBox tb_third_process;
    }
}


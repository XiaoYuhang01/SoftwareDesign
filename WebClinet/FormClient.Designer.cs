
namespace WebClinet
{
    partial class FormClient
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
            this.textBox_SI = new System.Windows.Forms.TextBox();
            this.button_SI = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.textBox_FI = new System.Windows.Forms.TextBox();
            this.textBox_AI = new System.Windows.Forms.TextBox();
            this.button_AI = new System.Windows.Forms.Button();
            this.button_FI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_SI
            // 
            this.textBox_SI.Location = new System.Drawing.Point(116, 118);
            this.textBox_SI.Name = "textBox_SI";
            this.textBox_SI.Size = new System.Drawing.Size(100, 25);
            this.textBox_SI.TabIndex = 0;
            // 
            // button_SI
            // 
            this.button_SI.Location = new System.Drawing.Point(272, 108);
            this.button_SI.Name = "button_SI";
            this.button_SI.Size = new System.Drawing.Size(141, 40);
            this.button_SI.TabIndex = 1;
            this.button_SI.Text = "获取学生信息";
            this.button_SI.UseVisualStyleBackColor = true;
            this.button_SI.Click += new System.EventHandler(this.button_SI_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(493, 75);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(227, 291);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // textBox_FI
            // 
            this.textBox_FI.Location = new System.Drawing.Point(116, 305);
            this.textBox_FI.Name = "textBox_FI";
            this.textBox_FI.Size = new System.Drawing.Size(100, 25);
            this.textBox_FI.TabIndex = 3;
            // 
            // textBox_AI
            // 
            this.textBox_AI.Location = new System.Drawing.Point(116, 213);
            this.textBox_AI.Name = "textBox_AI";
            this.textBox_AI.Size = new System.Drawing.Size(100, 25);
            this.textBox_AI.TabIndex = 4;
            // 
            // button_AI
            // 
            this.button_AI.Location = new System.Drawing.Point(272, 203);
            this.button_AI.Name = "button_AI";
            this.button_AI.Size = new System.Drawing.Size(141, 40);
            this.button_AI.TabIndex = 5;
            this.button_AI.Text = "获取管理员信息";
            this.button_AI.UseVisualStyleBackColor = true;
            this.button_AI.Click += new System.EventHandler(this.button_AI_Click);
            // 
            // button_FI
            // 
            this.button_FI.Location = new System.Drawing.Point(272, 305);
            this.button_FI.Name = "button_FI";
            this.button_FI.Size = new System.Drawing.Size(141, 40);
            this.button_FI.TabIndex = 6;
            this.button_FI.Text = "获取学生缴费信息";
            this.button_FI.UseVisualStyleBackColor = true;
            this.button_FI.Click += new System.EventHandler(this.button_FI_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_FI);
            this.Controls.Add(this.button_AI);
            this.Controls.Add(this.textBox_AI);
            this.Controls.Add(this.textBox_FI);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.button_SI);
            this.Controls.Add(this.textBox_SI);
            this.Name = "FormClient";
            this.Text = "FormClinet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_SI;
        private System.Windows.Forms.Button button_SI;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.TextBox textBox_FI;
        private System.Windows.Forms.TextBox textBox_AI;
        private System.Windows.Forms.Button button_AI;
        private System.Windows.Forms.Button button_FI;
    }
}
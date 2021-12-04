
namespace AutoFareSystem1.Forms
{
    partial class Form4
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
            this.button_webserver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_webserver
            // 
            this.button_webserver.Location = new System.Drawing.Point(350, 196);
            this.button_webserver.Name = "button_webserver";
            this.button_webserver.Size = new System.Drawing.Size(75, 23);
            this.button_webserver.TabIndex = 0;
            this.button_webserver.Text = "网络服务";
            this.button_webserver.UseVisualStyleBackColor = true;
            this.button_webserver.Click += new System.EventHandler(this.button_webserver_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_webserver);
            this.Name = "Form4";
            this.Text = "客户端";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_webserver;
    }
}
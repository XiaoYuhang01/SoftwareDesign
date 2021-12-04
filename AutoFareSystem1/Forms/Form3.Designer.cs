
namespace AutoFareSystem1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.charge_btn = new System.Windows.Forms.Button();
            this.delay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_water = new System.Windows.Forms.Button();
            this.btn_elec = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eFareAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wFareAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(60, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "欢迎使用学生自助缴费系统！";
            // 
            // close_btn
            // 
            this.close_btn.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.close_btn.Location = new System.Drawing.Point(586, 24);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(99, 33);
            this.close_btn.TabIndex = 3;
            this.close_btn.Text = "关闭";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // charge_btn
            // 
            this.charge_btn.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.charge_btn.Location = new System.Drawing.Point(468, 24);
            this.charge_btn.Name = "charge_btn";
            this.charge_btn.Size = new System.Drawing.Size(99, 33);
            this.charge_btn.TabIndex = 4;
            this.charge_btn.Text = "缴费";
            this.charge_btn.UseVisualStyleBackColor = true;
            this.charge_btn.Click += new System.EventHandler(this.charge_btn_Click);
            // 
            // delay
            // 
            this.delay.AutoSize = true;
            this.delay.Font = new System.Drawing.Font("隶书", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.delay.Location = new System.Drawing.Point(26, 72);
            this.delay.Name = "delay";
            this.delay.Size = new System.Drawing.Size(0, 24);
            this.delay.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_water);
            this.panel1.Controls.Add(this.btn_elec);
            this.panel1.Controls.Add(this.delay);
            this.panel1.Controls.Add(this.charge_btn);
            this.panel1.Controls.Add(this.close_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 131);
            this.panel1.TabIndex = 0;
            // 
            // btn_water
            // 
            this.btn_water.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_water.Location = new System.Drawing.Point(586, 70);
            this.btn_water.Name = "btn_water";
            this.btn_water.Size = new System.Drawing.Size(99, 33);
            this.btn_water.TabIndex = 8;
            this.btn_water.Text = "用水";
            this.btn_water.UseVisualStyleBackColor = true;
            this.btn_water.Click += new System.EventHandler(this.btn_water_Click);
            // 
            // btn_elec
            // 
            this.btn_elec.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_elec.Location = new System.Drawing.Point(468, 70);
            this.btn_elec.Name = "btn_elec";
            this.btn_elec.Size = new System.Drawing.Size(99, 33);
            this.btn_elec.TabIndex = 7;
            this.btn_elec.Text = "用电";
            this.btn_elec.UseVisualStyleBackColor = true;
            this.btn_elec.Click += new System.EventHandler(this.btn_elec_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.eFareAmountDataGridViewTextBoxColumn,
            this.wFareAmountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(697, 179);
            this.dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "账号";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // eFareAmountDataGridViewTextBoxColumn
            // 
            this.eFareAmountDataGridViewTextBoxColumn.DataPropertyName = "EFareAmount";
            this.eFareAmountDataGridViewTextBoxColumn.HeaderText = "需缴电费";
            this.eFareAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eFareAmountDataGridViewTextBoxColumn.Name = "eFareAmountDataGridViewTextBoxColumn";
            this.eFareAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.eFareAmountDataGridViewTextBoxColumn.Width = 160;
            // 
            // wFareAmountDataGridViewTextBoxColumn
            // 
            this.wFareAmountDataGridViewTextBoxColumn.DataPropertyName = "WFareAmount";
            this.wFareAmountDataGridViewTextBoxColumn.HeaderText = "需缴水费";
            this.wFareAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.wFareAmountDataGridViewTextBoxColumn.Name = "wFareAmountDataGridViewTextBoxColumn";
            this.wFareAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.wFareAmountDataGridViewTextBoxColumn.Width = 160;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(AutoFareSystem1.Student);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 124);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(711, 214);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(703, 185);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "当前缴费";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(703, 185);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "历史缴费";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(697, 179);
            this.dataGridView2.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 338);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = " 学生端";
            this.Load += new System.EventHandler(this.user_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button charge_btn;
        public System.Windows.Forms.Label delay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_water;
        private System.Windows.Forms.Button btn_elec;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eFareAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wFareAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bindingSource2;
    }
}
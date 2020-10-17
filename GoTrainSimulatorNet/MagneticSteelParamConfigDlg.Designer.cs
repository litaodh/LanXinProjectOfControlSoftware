namespace Luster.TrafficSeries.UI
{
    partial class MagneticSteelParamConfigDlg
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
            this.magneticSteeldgv = new System.Windows.Forms.DataGridView();
            this.addbtn = new System.Windows.Forms.Button();
            this.modbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.magneticSteelNametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.timeouttxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.magneticSteelEndcmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deviceEndcmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.endendcmb = new System.Windows.Forms.ComboBox();
            this.startEndcmb = new System.Windows.Forms.ComboBox();
            this.boardCardDiscmb = new System.Windows.Forms.ComboBox();
            this.closebtn = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceEndNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magneticSteelEndNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magneticSteelbds = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.magneticSteeldgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magneticSteelbds)).BeginInit();
            this.SuspendLayout();
            // 
            // magneticSteeldgv
            // 
            this.magneticSteeldgv.AllowUserToAddRows = false;
            this.magneticSteeldgv.AllowUserToDeleteRows = false;
            this.magneticSteeldgv.AutoGenerateColumns = false;
            this.magneticSteeldgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.magneticSteeldgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.magneticSteeldgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.deviceEndNameDataGridViewTextBoxColumn,
            this.magneticSteelEndNameDataGridViewTextBoxColumn});
            this.magneticSteeldgv.DataSource = this.magneticSteelbds;
            this.magneticSteeldgv.Location = new System.Drawing.Point(14, 17);
            this.magneticSteeldgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.magneticSteeldgv.MultiSelect = false;
            this.magneticSteeldgv.Name = "magneticSteeldgv";
            this.magneticSteeldgv.RowHeadersVisible = false;
            this.magneticSteeldgv.RowTemplate.Height = 23;
            this.magneticSteeldgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.magneticSteeldgv.Size = new System.Drawing.Size(353, 507);
            this.magneticSteeldgv.TabIndex = 0;
            this.magneticSteeldgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.magneticSteeldgv_CellContentClick);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(373, 17);
            this.addbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(138, 54);
            this.addbtn.TabIndex = 1;
            this.addbtn.Text = "添 加";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // modbtn
            // 
            this.modbtn.Location = new System.Drawing.Point(373, 79);
            this.modbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modbtn.Name = "modbtn";
            this.modbtn.Size = new System.Drawing.Size(138, 54);
            this.modbtn.TabIndex = 2;
            this.modbtn.Text = "修 改";
            this.modbtn.UseVisualStyleBackColor = true;
            this.modbtn.Click += new System.EventHandler(this.modbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(373, 141);
            this.delbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(138, 54);
            this.delbtn.TabIndex = 3;
            this.delbtn.Text = "删 除";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.magneticSteelNametxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(520, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(378, 507);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数设置";
            // 
            // magneticSteelNametxt
            // 
            this.magneticSteelNametxt.Location = new System.Drawing.Point(72, 23);
            this.magneticSteelNametxt.Name = "magneticSteelNametxt";
            this.magneticSteelNametxt.Size = new System.Drawing.Size(294, 23);
            this.magneticSteelNametxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "磁钢名称:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.timeouttxt);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(7, 339);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(366, 62);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "超时设置";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "ms";
            // 
            // timeouttxt
            // 
            this.timeouttxt.Location = new System.Drawing.Point(65, 22);
            this.timeouttxt.Name = "timeouttxt";
            this.timeouttxt.Size = new System.Drawing.Size(263, 23);
            this.timeouttxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "超时时间:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.magneticSteelEndcmb);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(7, 272);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(366, 61);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "磁钢端";
            // 
            // magneticSteelEndcmb
            // 
            this.magneticSteelEndcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.magneticSteelEndcmb.FormattingEnabled = true;
            this.magneticSteelEndcmb.Location = new System.Drawing.Point(65, 22);
            this.magneticSteelEndcmb.Name = "magneticSteelEndcmb";
            this.magneticSteelEndcmb.Size = new System.Drawing.Size(294, 25);
            this.magneticSteelEndcmb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "端名称:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deviceEndcmb);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 65);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "设备方向";
            // 
            // deviceEndcmb
            // 
            this.deviceEndcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceEndcmb.FormattingEnabled = true;
            this.deviceEndcmb.Location = new System.Drawing.Point(66, 22);
            this.deviceEndcmb.Name = "deviceEndcmb";
            this.deviceEndcmb.Size = new System.Drawing.Size(294, 25);
            this.deviceEndcmb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "方向:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.endendcmb);
            this.groupBox2.Controls.Add(this.startEndcmb);
            this.groupBox2.Controls.Add(this.boardCardDiscmb);
            this.groupBox2.Location = new System.Drawing.Point(7, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 143);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "板卡与端口";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "截止端口:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "开始端口:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "板卡描述:";
            // 
            // endendcmb
            // 
            this.endendcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endendcmb.FormattingEnabled = true;
            this.endendcmb.Location = new System.Drawing.Point(196, 97);
            this.endendcmb.Name = "endendcmb";
            this.endendcmb.Size = new System.Drawing.Size(164, 25);
            this.endendcmb.TabIndex = 2;
            // 
            // startEndcmb
            // 
            this.startEndcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startEndcmb.FormattingEnabled = true;
            this.startEndcmb.Location = new System.Drawing.Point(6, 97);
            this.startEndcmb.Name = "startEndcmb";
            this.startEndcmb.Size = new System.Drawing.Size(164, 25);
            this.startEndcmb.TabIndex = 1;
            // 
            // boardCardDiscmb
            // 
            this.boardCardDiscmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boardCardDiscmb.FormattingEnabled = true;
            this.boardCardDiscmb.Location = new System.Drawing.Point(6, 43);
            this.boardCardDiscmb.Name = "boardCardDiscmb";
            this.boardCardDiscmb.Size = new System.Drawing.Size(354, 25);
            this.boardCardDiscmb.TabIndex = 0;
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(373, 202);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(138, 54);
            this.closebtn.TabIndex = 5;
            this.closebtn.Text = "关 闭";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "磁钢名称";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deviceEndNameDataGridViewTextBoxColumn
            // 
            this.deviceEndNameDataGridViewTextBoxColumn.DataPropertyName = "DeviceEndName";
            this.deviceEndNameDataGridViewTextBoxColumn.HeaderText = "设备方向";
            this.deviceEndNameDataGridViewTextBoxColumn.Name = "deviceEndNameDataGridViewTextBoxColumn";
            this.deviceEndNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // magneticSteelEndNameDataGridViewTextBoxColumn
            // 
            this.magneticSteelEndNameDataGridViewTextBoxColumn.DataPropertyName = "MagneticSteelEndName";
            this.magneticSteelEndNameDataGridViewTextBoxColumn.HeaderText = "磁钢端";
            this.magneticSteelEndNameDataGridViewTextBoxColumn.Name = "magneticSteelEndNameDataGridViewTextBoxColumn";
            this.magneticSteelEndNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // magneticSteelbds
            // 
            this.magneticSteelbds.DataSource = typeof(Luster.TrafficSeries.UI.MagneticSteelInfo);
            // 
            // MagneticSteelParamConfigDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 536);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.modbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.magneticSteeldgv);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MagneticSteelParamConfigDlg";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "磁钢参数配置";
            this.Load += new System.EventHandler(this.MagneticSteelParamConfigDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.magneticSteeldgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magneticSteelbds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView magneticSteeldgv;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button modbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource magneticSteelbds;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceEndNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magneticSteelEndNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox magneticSteelNametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox timeouttxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox magneticSteelEndcmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox deviceEndcmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox endendcmb;
        private System.Windows.Forms.ComboBox startEndcmb;
        private System.Windows.Forms.ComboBox boardCardDiscmb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button closebtn;
    }
}
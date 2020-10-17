namespace Luster.TrafficSeries.UI
{
    partial class CaissonParameterConfigDlg
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
            this.addbtn = new System.Windows.Forms.Button();
            this.modbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.parametergrp = new System.Windows.Forms.GroupBox();
            this.waterLevelTimetxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.caissonNametxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.hasPumpchk = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.liquidLevelSwitchChannlecmb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.liquidLevelSwitchDiscmb = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pumpChannlecmb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pumpBoardDiscmb = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fanChannlecmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fanBoardDiscmb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.motorBoardChannlecmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.motorboardDiscmb = new System.Windows.Forms.ComboBox();
            this.caissonInfodgv = new System.Windows.Forms.DataGridView();
            this.closebtn = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasWaterPumpDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.caissonbds = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.parametergrp.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caissonInfodgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caissonbds)).BeginInit();
            this.SuspendLayout();
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(374, 17);
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
            this.modbtn.Location = new System.Drawing.Point(374, 79);
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
            this.delbtn.Location = new System.Drawing.Point(374, 141);
            this.delbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(138, 54);
            this.delbtn.TabIndex = 3;
            this.delbtn.Text = "删 除";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // parametergrp
            // 
            this.parametergrp.Controls.Add(this.label11);
            this.parametergrp.Controls.Add(this.waterLevelTimetxt);
            this.parametergrp.Controls.Add(this.label10);
            this.parametergrp.Controls.Add(this.caissonNametxt);
            this.parametergrp.Controls.Add(this.label9);
            this.parametergrp.Controls.Add(this.hasPumpchk);
            this.parametergrp.Controls.Add(this.groupBox4);
            this.parametergrp.Controls.Add(this.groupBox3);
            this.parametergrp.Controls.Add(this.groupBox2);
            this.parametergrp.Controls.Add(this.groupBox1);
            this.parametergrp.Location = new System.Drawing.Point(519, 17);
            this.parametergrp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.parametergrp.Name = "parametergrp";
            this.parametergrp.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.parametergrp.Size = new System.Drawing.Size(378, 503);
            this.parametergrp.TabIndex = 4;
            this.parametergrp.TabStop = false;
            this.parametergrp.Text = "参数设置";
            // 
            // waterLevelTimetxt
            // 
            this.waterLevelTimetxt.Location = new System.Drawing.Point(97, 464);
            this.waterLevelTimetxt.Name = "waterLevelTimetxt";
            this.waterLevelTimetxt.Size = new System.Drawing.Size(237, 23);
            this.waterLevelTimetxt.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 467);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "水位监测时间:";
            // 
            // caissonNametxt
            // 
            this.caissonNametxt.Location = new System.Drawing.Point(77, 23);
            this.caissonNametxt.Name = "caissonNametxt";
            this.caissonNametxt.Size = new System.Drawing.Size(288, 23);
            this.caissonNametxt.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "沉箱名称:";
            // 
            // hasPumpchk
            // 
            this.hasPumpchk.AutoSize = true;
            this.hasPumpchk.Location = new System.Drawing.Point(6, 244);
            this.hasPumpchk.Name = "hasPumpchk";
            this.hasPumpchk.Size = new System.Drawing.Size(63, 21);
            this.hasPumpchk.TabIndex = 4;
            this.hasPumpchk.Text = "有水泵";
            this.hasPumpchk.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.liquidLevelSwitchChannlecmb);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.liquidLevelSwitchDiscmb);
            this.groupBox4.Location = new System.Drawing.Point(7, 368);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(365, 88);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "水位开关参数";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "通道号:";
            // 
            // liquidLevelSwitchChannlecmb
            // 
            this.liquidLevelSwitchChannlecmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.liquidLevelSwitchChannlecmb.FormattingEnabled = true;
            this.liquidLevelSwitchChannlecmb.Location = new System.Drawing.Point(71, 54);
            this.liquidLevelSwitchChannlecmb.Name = "liquidLevelSwitchChannlecmb";
            this.liquidLevelSwitchChannlecmb.Size = new System.Drawing.Size(288, 25);
            this.liquidLevelSwitchChannlecmb.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "板卡描述:";
            // 
            // liquidLevelSwitchDiscmb
            // 
            this.liquidLevelSwitchDiscmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.liquidLevelSwitchDiscmb.FormattingEnabled = true;
            this.liquidLevelSwitchDiscmb.Location = new System.Drawing.Point(71, 23);
            this.liquidLevelSwitchDiscmb.Name = "liquidLevelSwitchDiscmb";
            this.liquidLevelSwitchDiscmb.Size = new System.Drawing.Size(288, 25);
            this.liquidLevelSwitchDiscmb.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.pumpChannlecmb);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.pumpBoardDiscmb);
            this.groupBox3.Location = new System.Drawing.Point(7, 272);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(365, 88);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "水泵参数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "通道号:";
            // 
            // pumpChannlecmb
            // 
            this.pumpChannlecmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pumpChannlecmb.FormattingEnabled = true;
            this.pumpChannlecmb.Location = new System.Drawing.Point(71, 54);
            this.pumpChannlecmb.Name = "pumpChannlecmb";
            this.pumpChannlecmb.Size = new System.Drawing.Size(288, 25);
            this.pumpChannlecmb.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "板卡描述:";
            // 
            // pumpBoardDiscmb
            // 
            this.pumpBoardDiscmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pumpBoardDiscmb.FormattingEnabled = true;
            this.pumpBoardDiscmb.Location = new System.Drawing.Point(71, 23);
            this.pumpBoardDiscmb.Name = "pumpBoardDiscmb";
            this.pumpBoardDiscmb.Size = new System.Drawing.Size(288, 25);
            this.pumpBoardDiscmb.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.fanChannlecmb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.fanBoardDiscmb);
            this.groupBox2.Location = new System.Drawing.Point(7, 149);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(365, 88);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "风扇参数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "通道号:";
            // 
            // fanChannlecmb
            // 
            this.fanChannlecmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fanChannlecmb.FormattingEnabled = true;
            this.fanChannlecmb.Location = new System.Drawing.Point(71, 54);
            this.fanChannlecmb.Name = "fanChannlecmb";
            this.fanChannlecmb.Size = new System.Drawing.Size(288, 25);
            this.fanChannlecmb.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "板卡描述:";
            // 
            // fanBoardDiscmb
            // 
            this.fanBoardDiscmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fanBoardDiscmb.FormattingEnabled = true;
            this.fanBoardDiscmb.Location = new System.Drawing.Point(71, 23);
            this.fanBoardDiscmb.Name = "fanBoardDiscmb";
            this.fanBoardDiscmb.Size = new System.Drawing.Size(288, 25);
            this.fanBoardDiscmb.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.motorBoardChannlecmb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.motorboardDiscmb);
            this.groupBox1.Location = new System.Drawing.Point(7, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(365, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "电机参数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "通道号:";
            // 
            // motorBoardChannlecmb
            // 
            this.motorBoardChannlecmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.motorBoardChannlecmb.FormattingEnabled = true;
            this.motorBoardChannlecmb.Location = new System.Drawing.Point(71, 54);
            this.motorBoardChannlecmb.Name = "motorBoardChannlecmb";
            this.motorBoardChannlecmb.Size = new System.Drawing.Size(288, 25);
            this.motorBoardChannlecmb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "板卡描述:";
            // 
            // motorboardDiscmb
            // 
            this.motorboardDiscmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.motorboardDiscmb.FormattingEnabled = true;
            this.motorboardDiscmb.Location = new System.Drawing.Point(71, 23);
            this.motorboardDiscmb.Name = "motorboardDiscmb";
            this.motorboardDiscmb.Size = new System.Drawing.Size(288, 25);
            this.motorboardDiscmb.TabIndex = 0;
            // 
            // caissonInfodgv
            // 
            this.caissonInfodgv.AllowUserToAddRows = false;
            this.caissonInfodgv.AllowUserToDeleteRows = false;
            this.caissonInfodgv.AutoGenerateColumns = false;
            this.caissonInfodgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.caissonInfodgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.caissonInfodgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.hasWaterPumpDataGridViewCheckBoxColumn});
            this.caissonInfodgv.DataSource = this.caissonbds;
            this.caissonInfodgv.Location = new System.Drawing.Point(12, 13);
            this.caissonInfodgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.caissonInfodgv.MultiSelect = false;
            this.caissonInfodgv.Name = "caissonInfodgv";
            this.caissonInfodgv.RowHeadersVisible = false;
            this.caissonInfodgv.RowTemplate.Height = 23;
            this.caissonInfodgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.caissonInfodgv.Size = new System.Drawing.Size(353, 507);
            this.caissonInfodgv.TabIndex = 5;
            this.caissonInfodgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.caissonInfodgv_CellContentClick);
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(374, 203);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(138, 54);
            this.closebtn.TabIndex = 6;
            this.closebtn.Text = "关 闭";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "沉箱名称";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hasWaterPumpDataGridViewCheckBoxColumn
            // 
            this.hasWaterPumpDataGridViewCheckBoxColumn.DataPropertyName = "HasWaterPump";
            this.hasWaterPumpDataGridViewCheckBoxColumn.HeaderText = "是否有水泵设备";
            this.hasWaterPumpDataGridViewCheckBoxColumn.Name = "hasWaterPumpDataGridViewCheckBoxColumn";
            this.hasWaterPumpDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // caissonbds
            // 
            this.caissonbds.DataSource = typeof(Luster.TrafficSeries.UI.CaissonInfo);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(341, 467);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "ms";
            // 
            // CaissonParameterConfigDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(910, 536);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.caissonInfodgv);
            this.Controls.Add(this.parametergrp);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.modbtn);
            this.Controls.Add(this.addbtn);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CaissonParameterConfigDlg";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "沉箱参数配置";
            this.Load += new System.EventHandler(this.CaissonParameterConfigDlg_Load);
            this.parametergrp.ResumeLayout(false);
            this.parametergrp.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caissonInfodgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caissonbds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button modbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.GroupBox parametergrp;
        private System.Windows.Forms.CheckBox hasPumpchk;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox liquidLevelSwitchChannlecmb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox liquidLevelSwitchDiscmb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox pumpChannlecmb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox pumpBoardDiscmb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox fanChannlecmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox fanBoardDiscmb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox motorBoardChannlecmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox motorboardDiscmb;
        private System.Windows.Forms.DataGridView caissonInfodgv;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.BindingSource caissonbds;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasWaterPumpDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox caissonNametxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox waterLevelTimetxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}
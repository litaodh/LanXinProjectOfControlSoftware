namespace Luster.TrafficSeries.UI
{
    partial class CameraTriggerParamConfigDlg
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
            this.cameraTriggerInfodgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cameraSignalNametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cameraSetgrp = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cameraSeriecmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cameraTypecmb = new System.Windows.Forms.ComboBox();
            this.closebtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.modbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cameraTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cameraSerieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cameraTriggerInfobds = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cameraTriggerInfodgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraTriggerInfobds)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraTriggerInfodgv
            // 
            this.cameraTriggerInfodgv.AutoGenerateColumns = false;
            this.cameraTriggerInfodgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cameraTriggerInfodgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cameraTriggerInfodgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.cameraTypeDataGridViewTextBoxColumn,
            this.cameraSerieDataGridViewTextBoxColumn});
            this.cameraTriggerInfodgv.DataSource = this.cameraTriggerInfobds;
            this.cameraTriggerInfodgv.Location = new System.Drawing.Point(12, 12);
            this.cameraTriggerInfodgv.Name = "cameraTriggerInfodgv";
            this.cameraTriggerInfodgv.RowHeadersVisible = false;
            this.cameraTriggerInfodgv.RowTemplate.Height = 23;
            this.cameraTriggerInfodgv.Size = new System.Drawing.Size(358, 512);
            this.cameraTriggerInfodgv.TabIndex = 0;
            this.cameraTriggerInfodgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cameraTriggerInfodgv_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cameraSignalNametxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cameraSetgrp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cameraSeriecmb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cameraTypecmb);
            this.groupBox1.Location = new System.Drawing.Point(520, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 512);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数设置";
            // 
            // cameraSignalNametxt
            // 
            this.cameraSignalNametxt.Location = new System.Drawing.Point(73, 23);
            this.cameraSignalNametxt.Name = "cameraSignalNametxt";
            this.cameraSignalNametxt.Size = new System.Drawing.Size(299, 23);
            this.cameraSignalNametxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "信号名称:";
            // 
            // cameraSetgrp
            // 
            this.cameraSetgrp.Location = new System.Drawing.Point(6, 114);
            this.cameraSetgrp.Name = "cameraSetgrp";
            this.cameraSetgrp.Size = new System.Drawing.Size(366, 383);
            this.cameraSetgrp.TabIndex = 4;
            this.cameraSetgrp.TabStop = false;
            this.cameraSetgrp.Text = "线阵相机设置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "相机序列:";
            // 
            // cameraSeriecmb
            // 
            this.cameraSeriecmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cameraSeriecmb.FormattingEnabled = true;
            this.cameraSeriecmb.Location = new System.Drawing.Point(73, 83);
            this.cameraSeriecmb.Name = "cameraSeriecmb";
            this.cameraSeriecmb.Size = new System.Drawing.Size(299, 25);
            this.cameraSeriecmb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "相机类型:";
            // 
            // cameraTypecmb
            // 
            this.cameraTypecmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cameraTypecmb.FormattingEnabled = true;
            this.cameraTypecmb.Location = new System.Drawing.Point(73, 52);
            this.cameraTypecmb.Name = "cameraTypecmb";
            this.cameraTypecmb.Size = new System.Drawing.Size(299, 25);
            this.cameraTypecmb.TabIndex = 0;
            this.cameraTypecmb.SelectedIndexChanged += new System.EventHandler(this.cameraTypecmb_SelectedIndexChanged);
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(376, 197);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(138, 54);
            this.closebtn.TabIndex = 10;
            this.closebtn.Text = "关 闭";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(376, 135);
            this.delbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(138, 54);
            this.delbtn.TabIndex = 9;
            this.delbtn.Text = "删 除";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // modbtn
            // 
            this.modbtn.Location = new System.Drawing.Point(376, 73);
            this.modbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modbtn.Name = "modbtn";
            this.modbtn.Size = new System.Drawing.Size(138, 54);
            this.modbtn.TabIndex = 8;
            this.modbtn.Text = "修 改";
            this.modbtn.UseVisualStyleBackColor = true;
            this.modbtn.Click += new System.EventHandler(this.modbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(376, 11);
            this.addbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(138, 54);
            this.addbtn.TabIndex = 7;
            this.addbtn.Text = "添 加";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "相机信号名字";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cameraTypeDataGridViewTextBoxColumn
            // 
            this.cameraTypeDataGridViewTextBoxColumn.DataPropertyName = "CameraType";
            this.cameraTypeDataGridViewTextBoxColumn.HeaderText = "相机类型";
            this.cameraTypeDataGridViewTextBoxColumn.Name = "cameraTypeDataGridViewTextBoxColumn";
            this.cameraTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cameraSerieDataGridViewTextBoxColumn
            // 
            this.cameraSerieDataGridViewTextBoxColumn.DataPropertyName = "CameraSerie";
            this.cameraSerieDataGridViewTextBoxColumn.HeaderText = "相机系列名称";
            this.cameraSerieDataGridViewTextBoxColumn.Name = "cameraSerieDataGridViewTextBoxColumn";
            this.cameraSerieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cameraTriggerInfobds
            // 
            this.cameraTriggerInfobds.DataSource = typeof(Luster.TrafficSeries.UI.CameraTriggerInfo);
            // 
            // CameraTriggerParamConfigDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 536);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.modbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cameraTriggerInfodgv);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CameraTriggerParamConfigDlg";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "相机触发参数配置";
            this.Load += new System.EventHandler(this.CameraTriggerParamConfigDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cameraTriggerInfodgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraTriggerInfobds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView cameraTriggerInfodgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox cameraSetgrp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cameraSeriecmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cameraTypecmb;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button modbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.BindingSource cameraTriggerInfobds;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cameraTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cameraSerieDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox cameraSignalNametxt;
        private System.Windows.Forms.Label label3;
    }
}
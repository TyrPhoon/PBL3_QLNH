
namespace QLNH
{
    partial class fTableManager
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.LVHoaDon = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.panel3 = new System.Windows.Forms.Panel();
			this.tbtotal = new System.Windows.Forms.TextBox();
			this.Cbbbanchuyen = new System.Windows.Forms.ComboBox();
			this.BTChuyenban = new System.Windows.Forms.Button();
			this.NbrudGiamgia = new System.Windows.Forms.NumericUpDown();
			this.BTgiamgia = new System.Windows.Forms.Button();
			this.BTThanhToan = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.NbrudSoluong = new System.Windows.Forms.NumericUpDown();
			this.BTAddfood = new System.Windows.Forms.Button();
			this.CbbThucAn = new System.Windows.Forms.ComboBox();
			this.CbbDMTAn = new System.Windows.Forms.ComboBox();
			this.flpanelTable = new System.Windows.Forms.FlowLayoutPanel();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NbrudGiamgia)).BeginInit();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NbrudSoluong)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.LVHoaDon);
			this.panel2.Location = new System.Drawing.Point(481, 90);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(431, 294);
			this.panel2.TabIndex = 3;
			// 
			// LVHoaDon
			// 
			this.LVHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.LVHoaDon.GridLines = true;
			this.LVHoaDon.HideSelection = false;
			this.LVHoaDon.Location = new System.Drawing.Point(2, 2);
			this.LVHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.LVHoaDon.Name = "LVHoaDon";
			this.LVHoaDon.Size = new System.Drawing.Size(429, 290);
			this.LVHoaDon.TabIndex = 0;
			this.LVHoaDon.UseCompatibleStateImageBehavior = false;
			this.LVHoaDon.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Thức Ăn";
			this.columnHeader1.Width = 200;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Số Lượng";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 50;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Đơn Giá";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Thành Tiền";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader4.Width = 100;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.tbtotal);
			this.panel3.Controls.Add(this.Cbbbanchuyen);
			this.panel3.Controls.Add(this.BTChuyenban);
			this.panel3.Controls.Add(this.NbrudGiamgia);
			this.panel3.Controls.Add(this.BTgiamgia);
			this.panel3.Controls.Add(this.BTThanhToan);
			this.panel3.Location = new System.Drawing.Point(483, 388);
			this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(429, 66);
			this.panel3.TabIndex = 4;
			// 
			// tbtotal
			// 
			this.tbtotal.Enabled = false;
			this.tbtotal.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbtotal.ForeColor = System.Drawing.Color.DarkRed;
			this.tbtotal.Location = new System.Drawing.Point(212, 22);
			this.tbtotal.Name = "tbtotal";
			this.tbtotal.Size = new System.Drawing.Size(130, 27);
			this.tbtotal.TabIndex = 7;
			this.tbtotal.Text = "0";
			this.tbtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Cbbbanchuyen
			// 
			this.Cbbbanchuyen.FormattingEnabled = true;
			this.Cbbbanchuyen.Location = new System.Drawing.Point(4, 36);
			this.Cbbbanchuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Cbbbanchuyen.Name = "Cbbbanchuyen";
			this.Cbbbanchuyen.Size = new System.Drawing.Size(102, 24);
			this.Cbbbanchuyen.TabIndex = 4;
			// 
			// BTChuyenban
			// 
			this.BTChuyenban.Location = new System.Drawing.Point(3, 4);
			this.BTChuyenban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BTChuyenban.Name = "BTChuyenban";
			this.BTChuyenban.Size = new System.Drawing.Size(102, 31);
			this.BTChuyenban.TabIndex = 6;
			this.BTChuyenban.Text = "Chuyển bàn";
			this.BTChuyenban.UseVisualStyleBackColor = true;
			this.BTChuyenban.Click += new System.EventHandler(this.BTChuyenban_Click);
			// 
			// NbrudGiamgia
			// 
			this.NbrudGiamgia.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.NbrudGiamgia.Location = new System.Drawing.Point(112, 38);
			this.NbrudGiamgia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.NbrudGiamgia.Name = "NbrudGiamgia";
			this.NbrudGiamgia.Size = new System.Drawing.Size(94, 22);
			this.NbrudGiamgia.TabIndex = 4;
			this.NbrudGiamgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// BTgiamgia
			// 
			this.BTgiamgia.Location = new System.Drawing.Point(112, 4);
			this.BTgiamgia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BTgiamgia.Name = "BTgiamgia";
			this.BTgiamgia.Size = new System.Drawing.Size(94, 31);
			this.BTgiamgia.TabIndex = 5;
			this.BTgiamgia.Text = "Giảm giá";
			this.BTgiamgia.UseVisualStyleBackColor = true;
			this.BTgiamgia.Click += new System.EventHandler(this.BTgiamgia_Click);
			// 
			// BTThanhToan
			// 
			this.BTThanhToan.Location = new System.Drawing.Point(348, 2);
			this.BTThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BTThanhToan.Name = "BTThanhToan";
			this.BTThanhToan.Size = new System.Drawing.Size(78, 62);
			this.BTThanhToan.TabIndex = 4;
			this.BTThanhToan.Text = "Thanh toán";
			this.BTThanhToan.UseVisualStyleBackColor = true;
			this.BTThanhToan.Click += new System.EventHandler(this.BTThanhToan_Click);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.NbrudSoluong);
			this.panel4.Controls.Add(this.BTAddfood);
			this.panel4.Controls.Add(this.CbbThucAn);
			this.panel4.Controls.Add(this.CbbDMTAn);
			this.panel4.Location = new System.Drawing.Point(481, 26);
			this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(431, 58);
			this.panel4.TabIndex = 5;
			// 
			// NbrudSoluong
			// 
			this.NbrudSoluong.Location = new System.Drawing.Point(350, 18);
			this.NbrudSoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.NbrudSoluong.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.NbrudSoluong.Name = "NbrudSoluong";
			this.NbrudSoluong.Size = new System.Drawing.Size(62, 22);
			this.NbrudSoluong.TabIndex = 3;
			this.NbrudSoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// BTAddfood
			// 
			this.BTAddfood.Location = new System.Drawing.Point(226, 2);
			this.BTAddfood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BTAddfood.Name = "BTAddfood";
			this.BTAddfood.Size = new System.Drawing.Size(105, 52);
			this.BTAddfood.TabIndex = 2;
			this.BTAddfood.Text = "Thêm món";
			this.BTAddfood.UseVisualStyleBackColor = true;
			this.BTAddfood.Click += new System.EventHandler(this.BTAddfood_Click);
			// 
			// CbbThucAn
			// 
			this.CbbThucAn.FormattingEnabled = true;
			this.CbbThucAn.Location = new System.Drawing.Point(2, 30);
			this.CbbThucAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.CbbThucAn.Name = "CbbThucAn";
			this.CbbThucAn.Size = new System.Drawing.Size(199, 24);
			this.CbbThucAn.TabIndex = 1;
			// 
			// CbbDMTAn
			// 
			this.CbbDMTAn.FormattingEnabled = true;
			this.CbbDMTAn.Location = new System.Drawing.Point(3, 2);
			this.CbbDMTAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.CbbDMTAn.Name = "CbbDMTAn";
			this.CbbDMTAn.Size = new System.Drawing.Size(198, 24);
			this.CbbDMTAn.TabIndex = 0;
			this.CbbDMTAn.SelectedIndexChanged += new System.EventHandler(this.CbbDMTAn_SelectedIndexChanged);
			// 
			// flpanelTable
			// 
			this.flpanelTable.AutoScroll = true;
			this.flpanelTable.Location = new System.Drawing.Point(19, 26);
			this.flpanelTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.flpanelTable.Name = "flpanelTable";
			this.flpanelTable.Size = new System.Drawing.Size(456, 428);
			this.flpanelTable.TabIndex = 6;
			// 
			// fTableManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(924, 464);
			this.Controls.Add(this.flpanelTable);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "fTableManager";
			this.Text = "Phần mềm quản lý nhà hàng";
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NbrudGiamgia)).EndInit();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.NbrudSoluong)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView LVHoaDon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox Cbbbanchuyen;
        private System.Windows.Forms.Button BTChuyenban;
        private System.Windows.Forms.NumericUpDown NbrudGiamgia;
        private System.Windows.Forms.Button BTgiamgia;
        private System.Windows.Forms.Button BTThanhToan;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown NbrudSoluong;
        private System.Windows.Forms.Button BTAddfood;
        private System.Windows.Forms.ComboBox CbbThucAn;
        private System.Windows.Forms.ComboBox CbbDMTAn;
        private System.Windows.Forms.FlowLayoutPanel flpanelTable;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.TextBox tbtotal;
	}
}
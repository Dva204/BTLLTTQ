namespace BTLLTTQ { 
    partial class frmThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTongQuan = new System.Windows.Forms.GroupBox();
            this.lblSachQuaHan = new System.Windows.Forms.Label();
            this.lblBiHong = new System.Windows.Forms.Label();
            this.lblCoSan = new System.Windows.Forms.Label();
            this.lblDangMuon = new System.Windows.Forms.Label();
            this.lblTongSoSach = new System.Windows.Forms.Label();
            this.tabControlBaoCao = new System.Windows.Forms.TabControl();
            this.tabPageBang = new System.Windows.Forms.TabPage();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.cboLoaiBaoCao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageBieuDo = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboBieuDoChon = new System.Windows.Forms.ComboBox();
            this.btnVeBieuDo = new System.Windows.Forms.Button();
            this.chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTongQuan.SuspendLayout();
            this.tabControlBaoCao.SuspendLayout();
            this.tabPageBang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.tabPageBieuDo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTongQuan
            // 
            this.groupBoxTongQuan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxTongQuan.Controls.Add(this.lblSachQuaHan);
            this.groupBoxTongQuan.Controls.Add(this.lblBiHong);
            this.groupBoxTongQuan.Controls.Add(this.lblCoSan);
            this.groupBoxTongQuan.Controls.Add(this.lblDangMuon);
            this.groupBoxTongQuan.Controls.Add(this.lblTongSoSach);
            this.groupBoxTongQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTongQuan.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTongQuan.Name = "groupBoxTongQuan";
            this.groupBoxTongQuan.Size = new System.Drawing.Size(230, 426);
            this.groupBoxTongQuan.TabIndex = 0;
            this.groupBoxTongQuan.TabStop = false;
            this.groupBoxTongQuan.Text = "Thống kê tổng quan";
            // 
            // lblSachQuaHan
            // 
            this.lblSachQuaHan.AutoSize = true;
            this.lblSachQuaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSachQuaHan.ForeColor = System.Drawing.Color.Red;
            this.lblSachQuaHan.Location = new System.Drawing.Point(15, 147);
            this.lblSachQuaHan.Name = "lblSachQuaHan";
            this.lblSachQuaHan.Size = new System.Drawing.Size(117, 16);
            this.lblSachQuaHan.TabIndex = 11;
            this.lblSachQuaHan.Text = "Sách quá hạn: 0";
            // 
            // lblBiHong
            // 
            this.lblBiHong.AutoSize = true;
            this.lblBiHong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiHong.Location = new System.Drawing.Point(15, 118);
            this.lblBiHong.Name = "lblBiHong";
            this.lblBiHong.Size = new System.Drawing.Size(79, 16);
            this.lblBiHong.TabIndex = 3;
            this.lblBiHong.Text = "Hỏng/Mất: 0";
            // 
            // lblCoSan
            // 
            this.lblCoSan.AutoSize = true;
            this.lblCoSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoSan.Location = new System.Drawing.Point(15, 89);
            this.lblCoSan.Name = "lblCoSan";
            this.lblCoSan.Size = new System.Drawing.Size(62, 16);
            this.lblCoSan.TabIndex = 2;
            this.lblCoSan.Text = "Có sẵn: 0";
            // 
            // lblDangMuon
            // 
            this.lblDangMuon.AutoSize = true;
            this.lblDangMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangMuon.Location = new System.Drawing.Point(15, 60);
            this.lblDangMuon.Name = "lblDangMuon";
            this.lblDangMuon.Size = new System.Drawing.Size(88, 16);
            this.lblDangMuon.TabIndex = 1;
            this.lblDangMuon.Text = "Đang mượn: 0";
            // 
            // lblTongSoSach
            // 
            this.lblTongSoSach.AutoSize = true;
            this.lblTongSoSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSoSach.Location = new System.Drawing.Point(15, 31);
            this.lblTongSoSach.Name = "lblTongSoSach";
            this.lblTongSoSach.Size = new System.Drawing.Size(117, 16);
            this.lblTongSoSach.TabIndex = 0;
            this.lblTongSoSach.Text = "Tổng số sách: 0";
            // 
            // tabControlBaoCao
            // 
            this.tabControlBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlBaoCao.Controls.Add(this.tabPageBang);
            this.tabControlBaoCao.Controls.Add(this.tabPageBieuDo);
            this.tabControlBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlBaoCao.Location = new System.Drawing.Point(248, 12);
            this.tabControlBaoCao.Name = "tabControlBaoCao";
            this.tabControlBaoCao.SelectedIndex = 0;
            this.tabControlBaoCao.Size = new System.Drawing.Size(524, 426);
            this.tabControlBaoCao.TabIndex = 2;
            // 
            // tabPageBang
            // 
            this.tabPageBang.Controls.Add(this.dgvBaoCao);
            this.tabPageBang.Controls.Add(this.btnXemBaoCao);
            this.tabPageBang.Controls.Add(this.cboLoaiBaoCao);
            this.tabPageBang.Controls.Add(this.label5);
            this.tabPageBang.Location = new System.Drawing.Point(4, 24);
            this.tabPageBang.Name = "tabPageBang";
            this.tabPageBang.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBang.Size = new System.Drawing.Size(516, 398);
            this.tabPageBang.TabIndex = 0;
            this.tabPageBang.Text = "Báo cáo chi tiết";
            this.tabPageBang.UseVisualStyleBackColor = true;
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.AllowUserToAddRows = false;
            this.dgvBaoCao.AllowUserToDeleteRows = false;
            this.dgvBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCao.Location = new System.Drawing.Point(15, 48);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.ReadOnly = true;
            this.dgvBaoCao.Size = new System.Drawing.Size(485, 334);
            this.dgvBaoCao.TabIndex = 7;
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXemBaoCao.Location = new System.Drawing.Point(395, 15);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(105, 25);
            this.btnXemBaoCao.TabIndex = 6;
            this.btnXemBaoCao.Text = "Xem báo cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
            // 
            // cboLoaiBaoCao
            // 
            this.cboLoaiBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLoaiBaoCao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiBaoCao.FormattingEnabled = true;
            this.cboLoaiBaoCao.Location = new System.Drawing.Point(125, 16);
            this.cboLoaiBaoCao.Name = "cboLoaiBaoCao";
            this.cboLoaiBaoCao.Size = new System.Drawing.Size(264, 23);
            this.cboLoaiBaoCao.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chọn loại báo cáo:";
            // 
            // tabPageBieuDo
            // 
            this.tabPageBieuDo.Controls.Add(this.panel1);
            this.tabPageBieuDo.Controls.Add(this.chartThongKe);
            this.tabPageBieuDo.Location = new System.Drawing.Point(4, 24);
            this.tabPageBieuDo.Name = "tabPageBieuDo";
            this.tabPageBieuDo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBieuDo.Size = new System.Drawing.Size(516, 398);
            this.tabPageBieuDo.TabIndex = 1;
            this.tabPageBieuDo.Text = "Biểu đồ";
            this.tabPageBieuDo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboBieuDoChon);
            this.panel1.Controls.Add(this.btnVeBieuDo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 40);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chọn biểu đồ:";
            // 
            // cboBieuDoChon
            // 
            this.cboBieuDoChon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBieuDoChon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBieuDoChon.FormattingEnabled = true;
            this.cboBieuDoChon.Location = new System.Drawing.Point(105, 10);
            this.cboBieuDoChon.Name = "cboBieuDoChon";
            this.cboBieuDoChon.Size = new System.Drawing.Size(287, 23);
            this.cboBieuDoChon.TabIndex = 4;
            // 
            // btnVeBieuDo
            // 
            this.btnVeBieuDo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVeBieuDo.Location = new System.Drawing.Point(398, 9);
            this.btnVeBieuDo.Name = "btnVeBieuDo";
            this.btnVeBieuDo.Size = new System.Drawing.Size(100, 25);
            this.btnVeBieuDo.TabIndex = 3;
            this.btnVeBieuDo.Text = "Vẽ biểu đồ";
            this.btnVeBieuDo.UseVisualStyleBackColor = true;
            // 
            // chartThongKe
            // 
            this.chartThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartThongKe.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartThongKe.Legends.Add(legend1);
            this.chartThongKe.Location = new System.Drawing.Point(6, 49);
            this.chartThongKe.Name = "chartThongKe";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartThongKe.Series.Add(series1);
            this.chartThongKe.Size = new System.Drawing.Size(504, 343);
            this.chartThongKe.TabIndex = 0;
            this.chartThongKe.Text = "chart1";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.tabControlBaoCao);
            this.Controls.Add(this.groupBoxTongQuan);
            this.Name = "frmThongKe";
            this.Text = "Thống kê - Báo cáo";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.groupBoxTongQuan.ResumeLayout(false);
            this.groupBoxTongQuan.PerformLayout();
            this.tabControlBaoCao.ResumeLayout(false);
            this.tabPageBang.ResumeLayout(false);
            this.tabPageBang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.tabPageBieuDo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTongQuan;
        private System.Windows.Forms.Label lblBiHong;
        private System.Windows.Forms.Label lblCoSan;
        private System.Windows.Forms.Label lblDangMuon;
        private System.Windows.Forms.Label lblTongSoSach;
        private System.Windows.Forms.Label lblSachQuaHan;
        private System.Windows.Forms.TabControl tabControlBaoCao;
        private System.Windows.Forms.TabPage tabPageBang;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.ComboBox cboLoaiBaoCao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPageBieuDo;
        private System.Windows.Forms.Button btnVeBieuDo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboBieuDoChon;
    }
}
namespace IntersectionApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbFigures = new System.Windows.Forms.ComboBox();
            this.lblFigure = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.txtParamA = new System.Windows.Forms.TextBox();
            this.txtParamB = new System.Windows.Forms.TextBox();
            this.lblParamA = new System.Windows.Forms.Label();
            this.lblParamB = new System.Windows.Forms.Label();
            this.pnlDrawArea = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.Parameter1 = new System.Windows.Forms.TextBox();
            this.Parameter2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbFigures
            // 
            this.cmbFigures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFigures.FormattingEnabled = true;
            this.cmbFigures.Items.AddRange(new object[] {
            "Rectangle",
            "Ellipse",
            "Triangle"});
            this.cmbFigures.Location = new System.Drawing.Point(16, 36);
            this.cmbFigures.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFigures.Name = "cmbFigures";
            this.cmbFigures.Size = new System.Drawing.Size(160, 24);
            this.cmbFigures.TabIndex = 0;
            this.cmbFigures.SelectedIndexChanged += new System.EventHandler(this.cmbFigures_SelectedIndexChanged);
            // 
            // lblFigure
            // 
            this.lblFigure.AutoSize = true;
            this.lblFigure.Location = new System.Drawing.Point(16, 16);
            this.lblFigure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFigure.Name = "lblFigure";
            this.lblFigure.Size = new System.Drawing.Size(45, 16);
            this.lblFigure.TabIndex = 1;
            this.lblFigure.Text = "Figure";
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Location = new System.Drawing.Point(876, 16);
            this.lblLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(32, 16);
            this.lblLine.TabIndex = 2;
            this.lblLine.Text = "Line";
            // 
            // txtParamA
            // 
            this.txtParamA.Location = new System.Drawing.Point(916, 36);
            this.txtParamA.Margin = new System.Windows.Forms.Padding(4);
            this.txtParamA.Name = "txtParamA";
            this.txtParamA.Size = new System.Drawing.Size(39, 22);
            this.txtParamA.TabIndex = 3;
            // 
            // txtParamB
            // 
            this.txtParamB.Location = new System.Drawing.Point(982, 38);
            this.txtParamB.Margin = new System.Windows.Forms.Padding(4);
            this.txtParamB.Name = "txtParamB";
            this.txtParamB.Size = new System.Drawing.Size(34, 22);
            this.txtParamB.TabIndex = 4;
            // 
            // lblParamA
            // 
            this.lblParamA.AutoSize = true;
            this.lblParamA.Location = new System.Drawing.Point(916, 16);
            this.lblParamA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParamA.Name = "lblParamA";
            this.lblParamA.Size = new System.Drawing.Size(59, 16);
            this.lblParamA.TabIndex = 5;
            this.lblParamA.Text = "Param A";
            // 
            // lblParamB
            // 
            this.lblParamB.AutoSize = true;
            this.lblParamB.Location = new System.Drawing.Point(983, 18);
            this.lblParamB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParamB.Name = "lblParamB";
            this.lblParamB.Size = new System.Drawing.Size(59, 16);
            this.lblParamB.TabIndex = 6;
            this.lblParamB.Text = "Param B";
            // 
            // pnlDrawArea
            // 
            this.pnlDrawArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDrawArea.Location = new System.Drawing.Point(16, 69);
            this.pnlDrawArea.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDrawArea.Name = "pnlDrawArea";
            this.pnlDrawArea.Size = new System.Drawing.Size(1013, 492);
            this.pnlDrawArea.TabIndex = 8;
            this.pnlDrawArea.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDrawArea_Paint);
            this.pnlDrawArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDrawArea_MouseDown);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(16, 565);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(45, 16);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Result";
            // 
            // Parameter1
            // 
            this.Parameter1.Location = new System.Drawing.Point(448, 36);
            this.Parameter1.Margin = new System.Windows.Forms.Padding(4);
            this.Parameter1.Name = "Parameter1";
            this.Parameter1.Size = new System.Drawing.Size(58, 22);
            this.Parameter1.TabIndex = 10;
            this.Parameter1.Text = "100";
            // 
            // Parameter2
            // 
            this.Parameter2.Location = new System.Drawing.Point(526, 36);
            this.Parameter2.Margin = new System.Windows.Forms.Padding(4);
            this.Parameter2.Name = "Parameter2";
            this.Parameter2.Size = new System.Drawing.Size(53, 22);
            this.Parameter2.TabIndex = 11;
            this.Parameter2.Text = "200";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 592);
            this.Controls.Add(this.Parameter2);
            this.Controls.Add(this.Parameter1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.pnlDrawArea);
            this.Controls.Add(this.lblParamB);
            this.Controls.Add(this.lblParamA);
            this.Controls.Add(this.txtParamB);
            this.Controls.Add(this.txtParamA);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblFigure);
            this.Controls.Add(this.cmbFigures);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intersection App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.ComboBox cmbFigures;
        private System.Windows.Forms.Label lblFigure;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.TextBox txtParamA;
        private System.Windows.Forms.TextBox txtParamB;
        private System.Windows.Forms.Label lblParamA;
        private System.Windows.Forms.Label lblParamB;
        private System.Windows.Forms.Panel pnlDrawArea;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox Parameter1;
        private System.Windows.Forms.TextBox Parameter2;
    }
}

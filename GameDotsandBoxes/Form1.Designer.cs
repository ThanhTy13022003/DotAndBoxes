namespace GameDotsandBoxes
{
    partial class frmDotAndBox
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlChessBoard = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pctbAVATAR = new PictureBox();
            txtNamePlayer = new TextBox();
            proTime = new ProgressBar();
            pctbTurn = new PictureBox();
            txtIP = new TextBox();
            btnConnect = new Button();
            btnRule = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctbAVATAR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctbTurn).BeginInit();
            SuspendLayout();
            // 
            // pnlChessBoard
            // 
            pnlChessBoard.Location = new Point(12, 12);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(811, 628);
            pnlChessBoard.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pctbAVATAR);
            panel2.Location = new Point(856, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 350);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnRule);
            panel3.Controls.Add(btnConnect);
            panel3.Controls.Add(txtIP);
            panel3.Controls.Add(pctbTurn);
            panel3.Controls.Add(proTime);
            panel3.Controls.Add(txtNamePlayer);
            panel3.Location = new Point(856, 384);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 256);
            panel3.TabIndex = 2;
            // 
            // pctbAVATAR
            // 
            pctbAVATAR.Location = new Point(-1, -1);
            pctbAVATAR.Name = "pctbAVATAR";
            pctbAVATAR.Size = new Size(350, 350);
            pctbAVATAR.TabIndex = 0;
            pctbAVATAR.TabStop = false;
            // 
            // txtNamePlayer
            // 
            txtNamePlayer.Location = new Point(3, 3);
            txtNamePlayer.Multiline = true;
            txtNamePlayer.Name = "txtNamePlayer";
            txtNamePlayer.Size = new Size(187, 34);
            txtNamePlayer.TabIndex = 0;
            // 
            // proTime
            // 
            proTime.Location = new Point(3, 78);
            proTime.Name = "proTime";
            proTime.Size = new Size(187, 34);
            proTime.TabIndex = 1;
            // 
            // pctbTurn
            // 
            pctbTurn.Location = new Point(196, 3);
            pctbTurn.Name = "pctbTurn";
            pctbTurn.Size = new Size(151, 120);
            pctbTurn.TabIndex = 2;
            pctbTurn.TabStop = false;
            // 
            // txtIP
            // 
            txtIP.Location = new Point(3, 148);
            txtIP.Multiline = true;
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(187, 34);
            txtIP.TabIndex = 3;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(3, 212);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(187, 37);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnRule
            // 
            btnRule.Location = new Point(196, 148);
            btnRule.Name = "btnRule";
            btnRule.Size = new Size(151, 34);
            btnRule.TabIndex = 5;
            btnRule.Text = "Rule";
            btnRule.UseVisualStyleBackColor = true;
            btnRule.Click += btnRule_Click;
            // 
            // frmDotAndBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 693);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnlChessBoard);
            Name = "frmDotAndBox";
            Text = "Dot And Box";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctbAVATAR).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctbTurn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlChessBoard;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pctbAVATAR;
        private Button btnConnect;
        private TextBox txtIP;
        private PictureBox pctbTurn;
        private ProgressBar proTime;
        private TextBox txtNamePlayer;
        private Button btnRule;
    }
}
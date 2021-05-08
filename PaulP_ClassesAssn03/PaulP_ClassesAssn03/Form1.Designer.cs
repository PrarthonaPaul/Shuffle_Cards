namespace PaulP_ClassesAssn03
{
    partial class frmShuffleCards
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
            this.lstOut = new System.Windows.Forms.ListBox();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnPic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstOut
            // 
            this.lstOut.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOut.FormattingEnabled = true;
            this.lstOut.ItemHeight = 18;
            this.lstOut.Location = new System.Drawing.Point(15, 20);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(763, 292);
            this.lstOut.TabIndex = 0;
            // 
            // btnShuffle
            // 
            this.btnShuffle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.Location = new System.Drawing.Point(50, 329);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(245, 37);
            this.btnShuffle.TabIndex = 1;
            this.btnShuffle.Text = "shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnPic
            // 
            this.btnPic.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPic.Location = new System.Drawing.Point(434, 329);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(245, 37);
            this.btnPic.TabIndex = 2;
            this.btnPic.Text = "Card";
            this.btnPic.UseVisualStyleBackColor = true;
            // 
            // frmShuffleCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 368);
            this.Controls.Add(this.btnPic);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.lstOut);
            this.Name = "frmShuffleCards";
            this.Text = "Shuffle Cards";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstOut;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnPic;
    }
}


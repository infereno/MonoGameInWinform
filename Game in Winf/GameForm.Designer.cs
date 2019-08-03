namespace MonoGameInWinform
{
    partial class GameForm
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
            this.pctSurface = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctSurface)).BeginInit();
            this.SuspendLayout();
            // 
            // pctSurface
            // 
            this.pctSurface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctSurface.Location = new System.Drawing.Point(0, 0);
            this.pctSurface.Name = "pctSurface";
            this.pctSurface.Size = new System.Drawing.Size(800, 450);
            this.pctSurface.TabIndex = 0;
            this.pctSurface.TabStop = false;
            this.pctSurface.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctSurface_MouseMove);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctSurface);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GameScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameScreen_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.GameForm_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.pctSurface)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctSurface;
    }
}
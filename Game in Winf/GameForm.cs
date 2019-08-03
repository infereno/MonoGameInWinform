using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Xna.Framework;

namespace MonoGameInWinform
{
    public partial class GameForm : Form
    {
        public static Game1 gameclass;

        public GameForm()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            this.Location = new System.Drawing.Point(10, 10);
        }

        #region getDrawSurface
        public IntPtr getDrawSurface()
        {
            return pctSurface.Handle;
        }
        #endregion

        private void GameScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pctSurface_MouseMove(object sender, MouseEventArgs e)
        {
            Debug.WriteLine(e.Location);
        }

        private void GameForm_ResizeEnd(object sender, EventArgs e)
        {
            GraphicsDeviceManager g = gameclass.GetGraphicsDevice;
            g.PreferredBackBufferHeight = this.pctSurface.Size.Height;
            g.PreferredBackBufferWidth = this.pctSurface.Size.Width;
            g.ApplyChanges();
        }
    }
}

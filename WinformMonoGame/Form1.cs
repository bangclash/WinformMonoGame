using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinformMonoGame
{
    public partial class Form1 : Form
    {
        private Game1 gameObject;
        public Form1()
        {
            InitializeComponent();
        }

        public IntPtr GetDrawSurface()
        {
            return pictureBox1.Handle;
        }

        public void SetGameObject(Game1 game)
        {
            gameObject = game;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameObject.ChangeBackgroundColor();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //ログインボタン
        private void button1_Click(object sender, EventArgs e)
        {
            //Startを非表示
            this.Visible = false;

            //ログイン画面表示
            LogIn logIn = new LogIn();
            logIn.Show();
        }

        //終了ボタン
        private void button2_Click(object sender, EventArgs e)
        {
            //終了
            Application.Exit();
        }
    }
}

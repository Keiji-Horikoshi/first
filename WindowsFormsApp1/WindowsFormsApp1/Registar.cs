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
    public partial class Registar : Form
    {
        public Registar()
        {
            InitializeComponent();
        }

        private void Registar_Load(object sender, EventArgs e)
        {
            AppJob.Timer();
            time.Text = AppInfo.time;
            Calc();
            ShowMenu();
        }

        //テキストボックスに一会計の個数を表示(随時更新)
        public void ShowMenu()
        {
            textBoxS.Text = AppInfo.Sugi.ToString();
            textBoxH.Text = AppInfo.Haku.ToString();
            textBoxJ.Text = AppInfo.Ju.ToString();
            textBoxM.Text = AppInfo.Masu.ToString();
            textBoxK.Text = AppInfo.Kiku.ToString();
            textBoxG.Text = AppInfo.Gan.ToString();
            textBoxN.Text = AppInfo.Nabe.ToString();
            textBoxAc.Text = AppInfo.Acc.ToString();
        }

        //一会計の売上金額を計算(随時更新)
        public void Calc()
        {
            //計算
            int rev = int.Parse(DB.menu[0, 1]) * AppInfo.Sugi + int.Parse(DB.menu[1, 1]) * AppInfo.Haku +int.Parse(DB.menu[2, 1]) * AppInfo.Ju +
                int.Parse(DB.menu[3, 1]) * AppInfo.Masu + int.Parse(DB.menu[4, 1]) * AppInfo.Kiku + 
                int.Parse(DB.menu[5, 1]) * AppInfo.Gan +int.Parse(DB.menu[6, 1]) * AppInfo.Nabe;
            //保存
            AppInfo.Acc = rev;
        }

        //杉玉ボタン
        private void sugidama_Click(object sender, EventArgs e)
        {
            //Orderフォームに情報を渡す
            Order order = new Order(DB.menu[0, 0], DB.menu[0, 1], 1,AppInfo.Sugi);
            //Orderフォームを出す
            order.ShowDialog();
            Calc();
            ShowMenu();
        }
        //伯楽星ボタン
        private void hakurakusei_Click(object sender, EventArgs e)
        {
            //Orderフォームに情報を渡す
            Order order = new Order(DB.menu[1, 0], DB.menu[1, 1], 2, AppInfo.Haku);
            //Orderフォームを出す
            order.ShowDialog();
            Calc();
            ShowMenu();
        }
        //十四代ボタン
        private void juyondai_Click(object sender, EventArgs e)
        {
            //Orderフォームに情報を渡す
            Order order = new Order(DB.menu[2, 0], DB.menu[2, 1], 3, AppInfo.Ju);
            //Orderフォームを出す
            order.ShowDialog();
            Calc();
            ShowMenu();
        }
        //満寿泉ボタン
        private void masuizumi_Click(object sender, EventArgs e)
        {
            //Orderフォームに情報を渡す
            Order order = new Order(DB.menu[3, 0], DB.menu[3, 1], 4, AppInfo.Masu);
            //Orderフォームを出す
            order.ShowDialog();
            Calc();
            ShowMenu();
        }
        //菊姫ボタン
        private void kikuhime_Click(object sender, EventArgs e)
        {
            //Orderフォームに情報を渡す
            Order order = new Order(DB.menu[4, 0], DB.menu[4, 1], 5, AppInfo.Kiku);
            //Orderフォームを出す
            order.ShowDialog();
            Calc();
            ShowMenu();
        }
        //雁木ボタン
        private void gangi_Click(object sender, EventArgs e)
        {
            //Orderフォームに情報を渡す
            Order order = new Order(DB.menu[5, 0], DB.menu[6, 1], 6, AppInfo.Gan);
            //Orderフォームを出す
            order.ShowDialog();
            Calc();
            ShowMenu();
        }
        //鍋島ボタン
        private void nabeshima_Click(object sender, EventArgs e)
        {
            //Orderフォームに情報を渡す
            Order order = new Order(DB.menu[6, 0], DB.menu[6, 1], 7, AppInfo.Nabe);
            //Orderフォームを出す
            order.ShowDialog();
            Calc();
            ShowMenu();
        }
        //会計ボタン
        private void Account_Click(object sender, EventArgs e)
        {
            if (AppInfo.Acc != 0)//合計金額が0はダメ
            {
                //レシート画面へ移る
                Accounting accounting = new Accounting();
                accounting.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("注文がありません", "注意");
            }
        }
        //戻るボタン
        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Visible = true;
            this.Close();
        }
    }
}

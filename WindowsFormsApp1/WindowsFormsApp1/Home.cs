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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            //あいさつ
            label1.Text = "こんにちは" + AppInfo.user + "さん";
            //管理者メニューの表示切替
            if (AppInfo.mana == "manage")
            {
                button4.Visible = true;
            }
            else
            {
                button4.Visible = false;
            }
        }

        //レジ打ちボタン
        private void button1_Click(object sender, EventArgs e)
        {
            //一会計の売上個数をリセット
            AppJob.ResetMenu();

            //レジ打ちフォームを表示
            Registar registar = new Registar();
            registar.Show();

            //このフォームは隠す
            this.Visible = false;
        }

        //売上確認ボタン
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AppJob.ChekRev(), "今回の売上");
        }

        //退勤ボタン
        private void button3_Click(object sender, EventArgs e)
        {
            if (AppInfo.mana == "manage" && AppInfo.New == 0)//最新の売上が確認済みか判断
            {
                MessageBox.Show("まだ確認していない売上があります", "注意");
            }
            else
            {
                //売上を表示
                string detail = string.Format("今回の{0}さんの売上は" + Environment.NewLine, AppInfo.user);
                MessageBox.Show(detail + AppJob.ChekRev(), "今回の売上");

                //LogInを表示
                LogIn logIn = new LogIn();
                logIn.Visible = true;

                //ログインを閉じる
                this.Close();
            }
        }

        //集計ボタン
        private void button4_Click(object sender, EventArgs e)
        {
            if (AppRev.count == 0)//注文番号0
            {
                MessageBox.Show("今日の売上はありません", "お知らせ");
                Summery summery = new Summery();
                summery.ShowDialog();
            }
            else
            {
                //集計作業と表の表示
                Summery summery = new Summery();
                summery.MakeGrid();
                summery.AddGrid();
                summery.ShowDialog();
            }
        }
    }
}

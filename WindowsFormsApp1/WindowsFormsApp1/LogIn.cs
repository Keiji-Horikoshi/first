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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        
        //ログインボタン
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(AppJob.scan(textBox1.Text, textBox2.Text) == 1)
                {
                    //次のフォームを表示
                    Home home = new Home();
                    home.Show();

                    //ユーザーの売上リセット
                    AppJob.ResetRev();

                    //このフォームは閉じる
                    this.Close();
                }else
                {
                    MessageBox.Show("IDまたはPWが違います", "ログインできません");
                    textBox1.Focus();
                }

            }
            catch
            {
                MessageBox.Show("ログインにてエラーが発生しました。" + "Startへ戻ります。", "エラーメッセージ");
                //Startを表示
                Start start = new Start();
                start.Visible = true;

                //ログインを閉じる
                this.Close();
            }
        }

        //戻るボタン
        private void button2_Click(object sender, EventArgs e)
        {
            //Startを表示
            Start start = new Start();
            start.Visible = true;

            //ログインを閉じる
            this.Close();
        }
    }
}

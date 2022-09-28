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
    public partial class Order : Form
    {
        private string name;
        private string cost;
        private int judge;
        private int count;

        public Order(string name,string cost, int judge,int count)
        {
            InitializeComponent();
            this.name = name;//商品の名前
            this.cost = cost;//商品の値段
            this.judge = judge;//フィールド判定に使う
            this.count = count;//個数
        }

        private void Order_Load(object sender, EventArgs e)
        {
            Exh();
        }
        //立ち上がりの表示
        public void Exh()
        {
            Menu.Text = name;
            Object.Text = name + "：￥" + cost;
            quant.Text = count.ToString();
        }

        //カウントアップボタン
        private void Inc_Click(object sender, EventArgs e)
        {
            int q = int.Parse(quant.Text);
            if (q == 99)
            {
                quant.Text = 0.ToString();
            }
            else
            {
                quant.Text = (q + 1).ToString();
            }
        }
        //カウントダウンボタン
        private void Dec_Click(object sender, EventArgs e)
        {
            int q = int.Parse(quant.Text);
            if (q == 0)
            {
                quant.Text = 99.ToString();
            }
            else
            {
                quant.Text = (q - 1).ToString();
            }
        }
        //OKボタン
        private void Cer_Click(object sender, EventArgs e)
        {
            //個数を代入
            switch (judge - 1)
            {
                case 0:
                    AppInfo.Sugi =int.Parse(quant.Text);
                    break;
                case 1:
                    AppInfo.Haku = int.Parse(quant.Text);
                    break;
                case 2:
                    AppInfo.Ju = int.Parse(quant.Text);
                    break;
                case 3:
                    AppInfo.Masu = int.Parse(quant.Text);
                    break;
                case 4:
                    AppInfo.Kiku = int.Parse(quant.Text);
                    break;
                case 5:
                    AppInfo.Gan = int.Parse(quant.Text);
                    break;
                case 6:
                    AppInfo.Nabe = int.Parse(quant.Text);
                    break;
                default:
                    MessageBox.Show("引数エラー", "エラーメッセージ");
                    this.Close();break;
            }
            this.Close();
        }
        //戻るボタン
        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class Accounting : Form
    {
        public Accounting()
        {
            InitializeComponent();
        }

        private void Accounting_Load(object sender, EventArgs e)
        {
            AppJob.Timer();
            timer.Text = AppInfo.time;
            //表の作成
            Receipt.ColumnCount = 4;
            Receipt.Columns[0].HeaderText = "商品名";
            Receipt.Columns[1].HeaderText = "値段";
            Receipt.Columns[2].HeaderText = "個数";
            Receipt.Columns[3].HeaderText = "金額";
            Add_data();
        }
        //データロウの追加
        public void Add_data()
        {
            if (AppInfo.Sugi != 0)
            {
                Receipt.Rows.Add(DB.menu[0, 0], DB.menu[0, 1], AppInfo.Sugi, int.Parse(DB.menu[0, 1]) * AppInfo.Sugi);
            }
            if (AppInfo.Haku != 0)
            {
                Receipt.Rows.Add(DB.menu[1, 0], DB.menu[1, 1], AppInfo.Haku, int.Parse(DB.menu[1, 1]) * AppInfo.Haku);
            }
            if (AppInfo.Ju != 0)
            {
                Receipt.Rows.Add(DB.menu[2, 0], DB.menu[2, 1], AppInfo.Ju, int.Parse(DB.menu[2, 1]) * AppInfo.Ju);
            }
            if (AppInfo.Masu != 0)
            {
                Receipt.Rows.Add(DB.menu[3, 0], DB.menu[3, 1], AppInfo.Masu, int.Parse(DB.menu[3, 1]) * AppInfo.Masu);
            }
            if (AppInfo.Kiku != 0)
            {
                Receipt.Rows.Add(DB.menu[4, 0], DB.menu[4, 1], AppInfo.Kiku, int.Parse(DB.menu[4, 1]) * AppInfo.Kiku);
            }
            if (AppInfo.Gan != 0)
            {
                Receipt.Rows.Add(DB.menu[5, 0], DB.menu[5, 1], AppInfo.Gan, int.Parse(DB.menu[5, 1]) * AppInfo.Gan);
            }
            if (AppInfo.Nabe != 0)
            {
                Receipt.Rows.Add(DB.menu[6, 0], DB.menu[6, 1], AppInfo.Nabe, int.Parse(DB.menu[6, 1]) * AppInfo.Nabe);
            }
            Receipt.Rows.Add("小計", "", "", AppInfo.Acc);
            Receipt.Rows.Add("消費税", "", "", AppInfo.Acc * 0.1);
            Receipt.Rows.Add("合計", "", "", AppInfo.Acc * 1.1);
        }

        //確定ボタン
        private void Next_Click(object sender, EventArgs e)
        {
            if (textBoxB.Text == "")
            {
                MessageBox.Show("お預かりを入力してください", "注意");
            }
            else
            {
                if (Calculator() == true)//お預かりと釣計算をする
                {
                    //時間更新
                    AppJob.Timer();
                    timer.Text = AppInfo.time;

                    //レシート画面出力
                    //スクリプト
                    string s1 = ""; string s2 = ""; string s3 = ""; string s4 = ""; string s5 = ""; string s6 = "";
                    string s7 = ""; string s8 = ""; string s9 = ""; string s10 = ""; string s11 = ""; string s12 = "";
                    try
                    {
                        int j = Receipt.RowCount;
                        switch (j - 4)
                        {
                            case 7:
                                s7 = string.Format("{0}       {1}         {2}          {3}", Receipt.Rows[6].Cells[0].Value, Receipt.Rows[6].Cells[1].Value, Receipt.Rows[6].Cells[2].Value, Receipt.Rows[6].Cells[3].Value);
                                goto case 6;
                            case 6:
                                s6 = string.Format("{0}       {1}         {2}          {3}", Receipt.Rows[5].Cells[0].Value, Receipt.Rows[5].Cells[1].Value, Receipt.Rows[5].Cells[2].Value, Receipt.Rows[5].Cells[3].Value);
                                goto case 5;
                            case 5:
                                s5 = string.Format("{0}       {1}         {2}          {3}", Receipt.Rows[4].Cells[0].Value, Receipt.Rows[4].Cells[1].Value, Receipt.Rows[4].Cells[2].Value, Receipt.Rows[4].Cells[3].Value);
                                goto case 4;
                            case 4:
                                s4 = string.Format("{0}       {1}         {2}          {3}", Receipt.Rows[3].Cells[0].Value, Receipt.Rows[3].Cells[1].Value, Receipt.Rows[3].Cells[2].Value, Receipt.Rows[3].Cells[3].Value);
                                goto case 3;
                            case 3:
                                s3 = string.Format("{0}       {1}         {2}          {3}", Receipt.Rows[2].Cells[0].Value, Receipt.Rows[2].Cells[1].Value, Receipt.Rows[2].Cells[2].Value, Receipt.Rows[2].Cells[3].Value);
                                goto case 2;
                            case 2:
                                s2 = string.Format("{0}       {1}         {2}          {3}", Receipt.Rows[1].Cells[0].Value, Receipt.Rows[1].Cells[1].Value, Receipt.Rows[1].Cells[2].Value, Receipt.Rows[1].Cells[3].Value);
                                goto case 1;
                            case 1:
                                s1 = string.Format("{0}       {1}         {2}          {3}", Receipt.Rows[0].Cells[0].Value, Receipt.Rows[0].Cells[1].Value, Receipt.Rows[0].Cells[2].Value, Receipt.Rows[0].Cells[3].Value);
                                break;
                        }
                        int i = Receipt.RowCount - 4;
                        s8 = string.Format("{0}", Receipt.Rows[i].Cells[3].Value);
                        i = Receipt.RowCount - 3;
                        s9 = string.Format("{0}", Receipt.Rows[i].Cells[3].Value);
                        i = Receipt.RowCount - 2;
                        s10 = string.Format("{0}", Receipt.Rows[i].Cells[3].Value);
                        s11 = string.Format("{0}", textBoxP.Text);
                        s12 = string.Format("{0}", textBoxB.Text);
                    }
                    catch
                    {

                    }

                    string s = string.Format("                                  {0}" + Environment.NewLine +
                                           "商品名   :   単価   *   個数   =   金額" + Environment.NewLine +
                                           "=========================" + Environment.NewLine +
                                           "{1}" + Environment.NewLine +
                                           "{2}" + Environment.NewLine +
                                           "{3}" + Environment.NewLine +
                                           "{4}" + Environment.NewLine +
                                           "{5}" + Environment.NewLine +
                                           "{6}" + Environment.NewLine +
                                           "{7}" + Environment.NewLine +
                                           "------------------------------------------------" + Environment.NewLine +
                                           "小計　　                               {8}" + Environment.NewLine +
                                           "消費税　      10%                    {9}" + Environment.NewLine +
                                           "合計　　                               {10}" + Environment.NewLine +
                                           "お預かり                                 {11}" + Environment.NewLine +
                                           "お釣　　                                 {12}", timer.Text, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12);

                    //表示
                    MessageBox.Show(s, "レシート");

                    //会計数をカウント
                    AppRev.count = AppRev.count + 1;

                    //最新の売上を確認
                    AppInfo.New = 0;

                    //リストへ売上情報を追加
                    AppRev.Mastering();

                    //Homeへ戻る
                    Registar registar = new Registar();
                    registar.Close();
                    Home home = new Home();
                    home.Visible = true;

                    //ユーザーの売上更新
                    AppJob.AddRev();

                    this.Close();
                }
            }
        }

        //戻るボタン
        private void button2_Click(object sender, EventArgs e)
        {
            Registar registar = new Registar();
            registar.Visible = true;
            this.Close();
        }

        //お預かりテキストボックスの入力制限
        private void textBoxP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //バックスペースが押された時は有効（Deleteキーも有効）
            if (e.KeyChar == '\b')
            {
                return;
            }

            //数値0～9以外が押された時はイベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //エンターキーでお釣り計算
        private void textBoxP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Calculator();
            }
        }

        //計算のメソッド
        bool Calculator()
        {
            int i = Receipt.RowCount - 2;
            string s = Receipt.Rows[i].Cells[3].Value.ToString();
            if (long.Parse(textBoxP.Text) < long.Parse(s))
            {
                MessageBox.Show("お金が足りません", "注意");
                textBoxP.Focus();
                return false;
            }
            else
            {
                textBoxB.Text = (long.Parse(textBoxP.Text) - long.Parse(s)).ToString();
                Next.Focus();
                return true;
            }
        }
    }
}

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
    public partial class Summery : Form
    {
        public Summery()
        {
            InitializeComponent();
        }

        private void Summery_Load(object sender, EventArgs e)
        {

        }
        
        //データグリッドビュー作成
        public void MakeGrid()
        {
            //列数指定
            Master.ColumnCount = 13;
            //列ヘッダー作成
            Master.Columns[0].HeaderText = "注文番号";
            Master.Columns[1].HeaderText = "注文時間";
            Master.Columns[2].HeaderText = "担当者";
            Master.Columns[3].HeaderText = "杉玉";
            Master.Columns[4].HeaderText = "伯楽星";
            Master.Columns[5].HeaderText = "十四代";
            Master.Columns[6].HeaderText = "満寿泉";
            Master.Columns[7].HeaderText = "菊姫";
            Master.Columns[8].HeaderText = "雁木";
            Master.Columns[9].HeaderText = "鍋島";
            Master.Columns[10].HeaderText = "小計";
            Master.Columns[11].HeaderText = "税金";
            Master.Columns[12].HeaderText = "合計金額";
        }

        //表作成
        public void AddGrid()
        {
            int i = 0;//カウンター
            int s = AppRev.Master.Count;//リストの行数
            while (true)
            {
                Master.Rows.Add(AppRev.Master[i]);//行挿入
                i = i + 1;//カウンターアップ
                if (s == i)//挿入しきったか判断
                {
                    break;
                }
            }           
        }

        //確認ボタン
        private void certifize_Click(object sender, EventArgs e)
        {
            AppInfo.New = 1;//売上の確認
            this.Close();
        }
    }
}

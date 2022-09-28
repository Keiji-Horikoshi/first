using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
     class AppRev
    {
        //リスト作成
        public static List<string[]> Master = new List<string[]>();

        //ログオン中ユーザーの一日の売上を記憶
        public static int sugi
        { get; set; }
        public static int haku
        { get; set; }
        public static int ju
        { get; set; }
        public static int masu
        { get; set; }
        public static int kiku
        { get; set; }
        public static int gan
        { get; set; }
        public static int nabe
        { get; set; }
        public static int acc
        { get; set; }



        //会計数のカウント
        public static int count
        {
            get;set;
        }

        //一日の売上情報を保管
        public static void Mastering()
        {
            //売上情報を追加
            string[] Data = new string[13];
            Data[0] = count.ToString();//注文番号
            Data[1] = AppInfo.time;//時間
            Data[2] = AppInfo.user;//担当者
            Data[3] = AppInfo.Sugi.ToString();//以下商品の個数
            Data[4] = AppInfo.Haku.ToString();
            Data[5] = AppInfo.Ju.ToString();
            Data[6] = AppInfo.Masu.ToString();
            Data[7] = AppInfo.Kiku.ToString();
            Data[8] = AppInfo.Gan.ToString();
            Data[9] = AppInfo.Nabe.ToString();
            Data[10] = AppInfo.Acc.ToString();//小計、税、税込
            Data[11] = (AppInfo.Acc * 0.1).ToString();
            Data[12] = (AppInfo.Acc * 1.1).ToString();
            Master.Add(Data);
        }
        
    }
}

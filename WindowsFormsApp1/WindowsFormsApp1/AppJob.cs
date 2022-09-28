using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class AppJob
    {
        //ログイン認証
        public static int scan(string i,string p)
        {
            //テキストボックスのIDとPWを配列にする
            string[] IP = new string[] { i, p };
            //IDとPWの組み合わせを用意する
            DB db = new DB();
            string[] mem1 = new string[] { db.member[0, 0], db.member[0, 1] };
            string[] mem2 = new string[] { db.member[1, 0], db.member[1, 1] };
            string[] mem3 = new string[] { db.member[2, 0], db.member[2, 1] };
            //それぞれ比較してログイン認証を行う
            if (IP.SequenceEqual(mem1))
            {
                AppInfo.user = i;//ユーザーを確定
                AppInfo.mana="manage";//権限を付与
                return 1;//1ならOK
            }else if (IP.SequenceEqual(mem2))
            {
                AppInfo.user = i;
                AppInfo.mana = "m";
                return 1;
            } else if (IP.SequenceEqual(mem3))
            {
                AppInfo.user = i;
                AppInfo.mana = "m";
                return 1;
            }else { return 0; }

        }

        //時刻を表示
        public static void Timer()
        {
            AppInfo.time = DateTime.Now.ToString();
        }

        //一会計の注文個数と合計金額をリセット
        public static void ResetMenu()
        {
            AppInfo.Sugi = 0;
            AppInfo.Haku = 0;
            AppInfo.Ju = 0;
            AppInfo.Masu = 0;
            AppInfo.Kiku = 0;
            AppInfo.Gan = 0;
            AppInfo.Nabe = 0;
            AppInfo.Acc = 0;
        }

        //ログオン中ユーザーの売上をリセット
        public static void ResetRev()
        {
            AppRev.sugi = 0;
            AppRev.haku = 0;
            AppRev.ju = 0;
            AppRev.masu = 0;
            AppRev.kiku = 0;
            AppRev.gan = 0;
            AppRev.nabe = 0;
            AppRev.acc = 0;
        }

        //ログオン中ユーザーの売上を加算
        public static void AddRev()
        {
            AppRev.sugi = AppRev.sugi + AppInfo.Sugi;
            AppRev.haku = AppRev.haku + AppInfo.Haku;
            AppRev.ju = AppRev.ju + AppInfo.Ju;
            AppRev.masu = AppRev.masu + AppInfo.Masu;
            AppRev.kiku = AppRev.kiku + AppInfo.Kiku;
            AppRev.gan = AppRev.gan + AppInfo.Gan;
            AppRev.nabe = AppRev.nabe + AppInfo.Nabe;
            AppRev.acc = AppRev.acc + AppInfo.Acc;
        }

        //ログオン中ユーザーの売上を確認
        public static string ChekRev()
        {
            string s = string.Format("{0}:{1}個" + Environment.NewLine +
                                        "{2}:{3}個" + Environment.NewLine +
                                        "{4}:{5}個" + Environment.NewLine +
                                        "{6}:{7}個" + Environment.NewLine +
                                        "{8}:{9}個" + Environment.NewLine +
                                        "{10}:{11}個" + Environment.NewLine +
                                        "{12}:{13}個" + Environment.NewLine +
                                        "小計　:{14}" + Environment.NewLine +
                                        "税込　:{15}"
                                        , DB.menu[0, 0], AppRev.sugi, DB.menu[1, 0], AppRev.haku, DB.menu[2, 0], AppRev.ju, DB.menu[3, 0], AppRev.masu
                                        , DB.menu[4, 0], AppRev.kiku, DB.menu[5, 0], AppRev.gan, DB.menu[6, 0], AppRev.nabe, AppRev.acc, AppRev.acc * 1.1);
            return s;
        }
    }
}

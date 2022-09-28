using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class AppInfo
    {

        //ユーザーIDを記憶
        public static string user
        {
            get;set;
        }

        //管理者を認識
        public static string mana
        {
            get;set;
        }

        //時間
        public static string time
        {
            get;set;
        }

        //一会計の杉玉の個数
        public static int Sugi
        {
            get;set;
        }
        //一会計の伯楽星の個数
        public static int Haku
        {
            get; set;
        }
        //一会計の十四代の個数
        public static int Ju
        {
            get; set;
        }
        //一会計の満寿泉の個数
        public static int Masu
        {
            get; set;
        }
        //一会計の菊姫の個数
        public static int Kiku
        {
            get; set;
        }
        //一会計の雁木の個数
        public static int Gan
        {
            get; set;
        }
        //一会計の鍋島の個数
        public static int Nabe
        {
            get; set;
        }
        //一会計の売上金額
        public static int Acc
        {
            get; set;
        }

        //最新の売上があるかを判断
        public static int New
        { get; set; }
    }
}

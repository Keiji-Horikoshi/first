using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DB
    {
        //ログインに使うデータ
        public string[,] member = new string[3, 2] { { "tencho", "gokaicho" }, { "bit-a", "vita"}, { "bit-b", "BB"} };

        //商品のデータ
        public static string[,] menu = new string[7, 2] { { "杉玉　", "1600" }, { "伯楽星", "1700" }, { "十四代", "5000" }, 
                                { "満寿泉", "4000" }, { "菊姫　", "1400" },{ "雁木　", "1500" }, { "鍋島　", "1700" } };
    }
}

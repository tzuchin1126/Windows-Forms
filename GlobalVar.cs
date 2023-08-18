using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期中專案_0420
{
    internal class GlobalVar
    {
        public static List<ArrayList> list訂購品項 = new List<ArrayList>();
        public static string 備註事項 = "";

        public static string 使用者名稱 = "";
        public static int 使用者ID = 0;

        public static string 使用者帳號 = "";
        public static string 使用者密碼 = "";

        //預約系統使用
        public static string user_petName = ""; //會員的寵物名字
        public static string user_petType = ""; //會員的寵物類型

        //全域變數: 讓多個頁面判斷用戶有沒有登入成功
        public static string strDBConnectionString = "";
        public static bool is登入認證成功 = false;
        public static bool is會員註冊 = false;
        public static int 權限 = 0; //會員1000 員工100
        public static string image_dir = @"C:\Users\USER\Desktop\c#";

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMail
{
    public class Settings
    {
        //自分自身のインスタンスを格納
        private static Settings instance = null;

        private int port;           //ポート番号
        private string host;        //ホスト名
        private string mailAddr;    //メールアドレス
        private string pass;        //パスワード
        private bool ssl;

        public int Port { get => port; set => port = value; }
        public string Host { get => host; set => host = value; }
        public string MailAddr { get => mailAddr; set => mailAddr = value; }
        public string Pass { get => pass; set => pass = value; }
        public bool Ssl { get => ssl; set => ssl = value; }

        //外部からnewできないようにする
        private Settings() { }
       
        //初期値
        public string sHost()
        {
            return "smtp.gmail.com";           
        }
        public string sPort()
        {
            return 587 .ToString();
        }
        public string sPass()
        {
            return "OjsInfosys2019";
        }
        public string sMailadd()
        {
            return "ojsinfosys01@gmail.com";
        }
        

        //インスタンスの取得
        public static Settings getInstance()
        {
            if(instance == null)
            {
                instance = new Settings();
            }
            return instance;
        }
    }
}

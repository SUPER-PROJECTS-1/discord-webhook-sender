using ya;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord_Webhook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void sendDiscordWeb(string URL, string msg, string user)
        {
            Http.Post(URL, new System.Collections.Specialized.NameValueCollection()
           {
               {
                   "username",
                    user
               },
               {
                   "content",
                   msg
               }
           });
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            sendDiscordWeb(singweb.Text, singmgs.Text, singuser.Text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypt_Decrypt_Files
{
    internal class clsLogger
    {
        public static void Log(string message)
        {
            MessageBox.Show(message);
        }
    }
}

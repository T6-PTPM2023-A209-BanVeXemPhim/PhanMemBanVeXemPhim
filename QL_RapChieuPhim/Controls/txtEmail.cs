using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public class txtEmail:TextBox
    {
        ErrorProvider er = new ErrorProvider();
        public txtEmail()
        {
            this.KeyPress += Mail_KeyPress;
        }

        void Mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!this.Text.Contains("@") && !this.Text.Contains(".com"))
            {
                er.SetError(this, "Bạn cần nhập vào email");
            }
            else
            {
                er.Clear();
            }
        }
    }
}

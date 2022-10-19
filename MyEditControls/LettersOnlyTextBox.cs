using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEditControls
{
    public class LettersOnlyTextBox : TextBox
    {
        const int WM_PASTE = 0x0302;
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_PASTE)
            {
                if (Clipboard.GetText().Any(s => !char.IsLetter(s)))
                {
                    return;
                }
            }
            base.WndProc(ref m);
        }

    }
}

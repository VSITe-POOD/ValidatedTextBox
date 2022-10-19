using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEditControls
{
    public class NumericOnlyText : IValidateText
    {
        public bool IsValidCharacter(char c)
        {
            return char.IsDigit(c) || char.IsControl(c);
        }

        public bool IsValidText(string text)
        {
            return int.TryParse(text, out _);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEditControls
{
    public class LettersOnlyText : IValidateText
    {
        public bool IsValidCharacter(char c)
        {
            return char.IsLetter(c) || char.IsControl(c);
        }

        public bool IsValidText(string text)
        {
            return text.All(c => char.IsLetter(c));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEditControls
{
    public interface IValidateText
    {
        bool IsValidCharacter(char c);
        bool IsValidText(string text);
    }
}

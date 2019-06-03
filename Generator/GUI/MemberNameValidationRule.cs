using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Generator.GUI
{
    internal class MemberNameValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            CodeDomProvider provider = CodeDomProvider.CreateProvider("C#");
            var memberName = Convert.ToString(value);
            if (!string.IsNullOrEmpty(memberName) && provider.IsValidIdentifier(memberName))
                return ValidationResult.ValidResult;
            else
                return new ValidationResult(false, "Incorrect member name");
        }
    }
}

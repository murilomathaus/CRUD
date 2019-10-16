using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CRUD.Utils
{
    public class InputValidationRule : ValidationRule
    {
        ///<summary>
        ///Regex to match input
        ///</summary>
        public string Pattern { get; set; }
        /// <summary>
        /// Error message to be displayed
        /// </summary>
        public string ErrorMessage { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {

            string input = value.ToString();

            bool rt = Regex.IsMatch(input, $"{Pattern}");
            if (!rt)
            {
                return new ValidationResult(false, this.ErrorMessage);
            }
            else
            {
                return new ValidationResult(true, null);
            }
        }
    }
}

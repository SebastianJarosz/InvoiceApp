using System;

namespace DPSBuisnessLogicLibrary.BuisnessLogic.InvoiceMenagment.Validators
{
    /// <summary>
    /// Validator class for Invoice Number format
    /// </summary>
    public class InvoiceNumberValidator : IValidator<string>
    {
        public Tuple<bool, string> CheckValue(string modelToValidate)
        {
            if (modelToValidate.Length >= 12)
            {
                if (int.TryParse(modelToValidate.Substring(0, 4), out int y) && modelToValidate[4] == '/'
                    && int.TryParse(modelToValidate.Substring(5, 2), out int m) && modelToValidate[7] == '/'
                    && int.TryParse(modelToValidate.Substring(8, 2), out int d) && modelToValidate[10] == '-'
                    && int.TryParse(modelToValidate.Substring(11), out int n))
                {
                    return new Tuple<bool, string>(true, "OK");
                }
                else
                {
                    return new Tuple<bool, string>(false, "Nieprawidłowy format numeru faktury yyyy/mm/dd-nn");
                }
            }
            else
            {
                return new Tuple<bool, string>(
                    false,
                    "Nieprawidłowy format numeru faktury yyyy/mm/dd-nn"
                );
            }
        }
    }
}

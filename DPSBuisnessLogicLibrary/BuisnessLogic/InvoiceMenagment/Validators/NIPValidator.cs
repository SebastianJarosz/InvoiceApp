using System;

namespace DPSBuisnessLogicLibrary.BuisnessLogic.InvoiceMenagment.Validators
{
    /// <summary>
    /// Validator class for NIP format
    /// </summary>
    public class NIPValidator : IValidator<string>
    {
        public Tuple<bool, string> CheckValue(string modelToValidate)
        {
            if (modelToValidate.Length == 10 && modelToValidate != null)
            {
                if (int.TryParse(modelToValidate, out int c))
                {
                    return new Tuple<bool, string>(true, "OK");
                }
                else
                {
                    return new Tuple<bool, string>(false, "Nieprawidłowe znaki w NIP`e");
                }
            }
            else
            {
                return new Tuple<bool, string>(
                    false,
                    "Nieprawidłowa długość NIP`u"
                );
            }
        }
    }
}

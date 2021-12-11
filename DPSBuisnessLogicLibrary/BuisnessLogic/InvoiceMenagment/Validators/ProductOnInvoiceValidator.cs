using System;

namespace DPSBuisnessLogicLibrary.BuisnessLogic.InvoiceMenagment.Validators
{
    /// <summary>
    /// Validator class for Product on Invoice code format
    /// </summary>
    public class ProductOnInvoiceValidator : IValidator<string>
    {
        public Tuple<bool, string> CheckValue(string modelToValidate)
        {
            if (modelToValidate.Length > 0)
            {
                return new Tuple<bool, string>(true, "OK");
            }
            return new Tuple<bool, string>(false, "Nieprawidłowy kod produktu");
        }
    }
}

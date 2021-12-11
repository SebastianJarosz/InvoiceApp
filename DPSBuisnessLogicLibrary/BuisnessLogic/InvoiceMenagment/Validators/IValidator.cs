using System;

namespace DPSBuisnessLogicLibrary.BuisnessLogic.InvoiceMenagment.Validators
{
    /// <summary>
    /// Interface for validators classes
    /// </summary>
    /// <typeparam name="T">Type of object to check</typeparam>
    public interface IValidator<T>
    {
        Tuple<bool, string> CheckValue(T modelToValidate);
    }
}

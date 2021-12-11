using DPSBuisnessLogicLibrary.BuisnessLogic.InvoiceMenagment.Validators;
using NUnit.Framework;
using System;

namespace InvoiceMenagmentTests
{
    /// <summary>
    /// Unit testing class for InvoiceNumberValidator class
    /// </summary>
    public class InvoiceNumberValidatorTest
    {
        private string validInvoiceNumber;
        private string invalidInvoiceNumber;
        private InvoiceNumberValidator invoiceNumberValidator;

        [SetUp]
        public void Setup()
        {
            validInvoiceNumber = "1996/02/19-1";
            invalidInvoiceNumber = "199a/02/19-1";
            invoiceNumberValidator = new InvoiceNumberValidator();
        }

        [Test]
        public void CheckValue_ReturnTupleWhichContainBoolAndString_WhenValidationStringIsValid()
        {
            var result = invoiceNumberValidator.CheckValue(validInvoiceNumber);
            Assert.IsInstanceOf<Tuple<bool, string>>(result);
            Assert.IsTrue(result.Item1);
        }
        [Test]
        public void CheckValue_ReturnTupleWhichContainBoolAndString_WhenValidationStringIsInvalid()
        {
            var result = invoiceNumberValidator.CheckValue(invalidInvoiceNumber);
            Assert.IsInstanceOf<Tuple<bool, string>>(result);
            Assert.IsFalse(result.Item1);
        }
    }
}
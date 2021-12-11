using DPSBuisnessLogicLibrary.BuisnessLogic.InvoiceMenagment.InvoiceDTOS;
using DPSBuisnessLogicLibrary.BuisnessLogic.InvoiceMenagment.InvoiceMappers;
using DPSBuisnessLogicLibrary.BuisnessLogic.InvoiceMenagment.Validators;
using EntityFrameworkDPSLibrary.Models;
using EntityFrameworkDPSLibrary.Repositories;
using System;
using System.Collections.Generic;

namespace DPSBuisnessLogicLibrary.BuisnessLogic.InvoiceMenagment
{
    /// <summary>
    /// Menagment class for invoice 
    /// </summary>
    public class InvoiceMenager
    {
        private IMapper<InvoiceDTO, Tuple<Invoice, Buyer, Seller, List<ProductsOnInvoice>>> _mapper;
        private IRepository<Invoice, string> _invoiceRepository;
        private IRepository<ProductsOnInvoice, string> _productsOnInvoiceRepository;
        private IRepository<Buyer, string> _buyerRepository;
        private IRepository<Seller, string> _sellerRepository;
        private IRepository<Product, string> _productRepository;
        //ShouldI  use delegate for validation??
        private NIPValidator _nipValidator;
        private InvoiceNumberValidator _invoiceNumberValidator;
        private ProductOnInvoiceValidator _productOnInvoiceValidator;

        private string _messgaeSucces = "Pomyślnie dodano fakture.";
        private string _messgaeFailure = "Coś poszło nie tak sprawdź pola.";

        public InvoiceMenager(IMapper<InvoiceDTO, Tuple<Invoice, Buyer, Seller, List<ProductsOnInvoice>>> mapper,
                                IRepository<Invoice, string> invoiceRepository,
                                IRepository<ProductsOnInvoice, string> productsOnnvoiceRepository,
                                IRepository<Buyer, string> buyerRepository,
                                IRepository<Seller, string> sellerRepository,
                                IRepository<Product, string> productRepository,
                                NIPValidator nipValidator,
                                InvoiceNumberValidator invoiceNumberValidator,
                                ProductOnInvoiceValidator productOnInvoiceValidator)
        {
            _mapper = mapper;
            _invoiceRepository = invoiceRepository;
            _productsOnInvoiceRepository = productsOnnvoiceRepository;
            _buyerRepository = buyerRepository;
            _sellerRepository = sellerRepository;
            _productRepository = productRepository;
            _nipValidator = nipValidator;
            _invoiceNumberValidator = invoiceNumberValidator;
            _productOnInvoiceValidator = productOnInvoiceValidator;
        }

        public Tuple<bool, string> AddInvoice(InvoiceDTO newObject)
        {
            try
            {
                if (_nipValidator.CheckValue(newObject.BuyerNIP).Item1)
                {
                    if (_nipValidator.CheckValue(newObject.SellerNIP).Item1)
                    {

                        if (_invoiceRepository.Get(newObject.InvoiceNumber) == null
                            && _invoiceNumberValidator.CheckValue(newObject.InvoiceNumber).Item1)
                        {
                            var objectsToSaveTuple = _mapper.Map(newObject);
                            _invoiceRepository.Add(objectsToSaveTuple.Item1);
                            if (_buyerRepository.Get(objectsToSaveTuple.Item2.NIP) == null) _buyerRepository.Add(objectsToSaveTuple.Item2);
                            if (_sellerRepository.Get(objectsToSaveTuple.Item3.NIP) == null) _sellerRepository.Add(objectsToSaveTuple.Item3);

                            foreach (var productOnInovice in objectsToSaveTuple.Item4)
                            {
                                productOnInovice.Invoice = objectsToSaveTuple.Item1;
                                productOnInovice.Product = _productRepository.Get(productOnInovice.ProductCode);
                                _productsOnInvoiceRepository.Add(productOnInovice);
                            }

                            return new Tuple<bool, string>(true, _messgaeSucces);
                        }
                        return _invoiceNumberValidator.CheckValue(newObject.InvoiceNumber);
                    }
                    return _nipValidator.CheckValue(newObject.SellerNIP);
                }
                return _nipValidator.CheckValue(newObject.BuyerNIP);
            }
            catch (Exception)
            {
                return new Tuple<bool, string>(false, _messgaeFailure);
            }
        }

        public ICollection<InvoiceDTO> GetAllInvoices()
        {
            try
            {
                var invoiceList = _invoiceRepository.GetAll();
                var displayedInvoiceList = new List<InvoiceDTO>();
                foreach (var element in invoiceList)
                {
                    var buyer = _buyerRepository.Get(element.BuyerNIP);
                    var seller = _sellerRepository.Get(element.SellerNIP);
                    var productsOnInvoice = _productsOnInvoiceRepository.GetAll(element.InvoiceNumber);
                    List<ProductsOnInvoice> list = new List<ProductsOnInvoice>();

                    foreach (var product in productsOnInvoice)
                    {
                        product.Product = _productRepository.Get(product.ProductCode);
                        list.Add(product);
                    }
                    var tupleForMapping = new Tuple<Invoice, Buyer, Seller, List<ProductsOnInvoice>>(element, buyer, seller, list);
                    displayedInvoiceList.Add(_mapper.Map(tupleForMapping));
                }
                return displayedInvoiceList;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Tuple<bool, string, ProductsOnInvoiceDTO> CreateProductOnInvoice(string productCode, string quantity)
        {
            try
            {
                var product = _productRepository.Get(productCode);
                if (product != null
                    && _productOnInvoiceValidator.CheckValue(productCode).Item1
                    && float.TryParse(quantity, out float q) && q > 0f)
                {
                    return new Tuple<bool, string, ProductsOnInvoiceDTO>(true, "Ok",
                                                         new ProductsOnInvoiceDTO
                                                         {
                                                             ProductCode = product.Code,
                                                             ProductName = product.Name,
                                                             QuantityOfProduct = q,
                                                             ProductMeasureUnit = product.MeasureUnit.ToString()
                                                         });

                }
                return new Tuple<bool, string, ProductsOnInvoiceDTO>(false, "Nieprawidłowy kod produktu lub ilość", null);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

using DPSBuisnessLogicLibrary.BuisnessLogic.InvoiceMenagment.InvoiceDTOS;
using EntityFrameworkDPSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DPSBuisnessLogicLibrary.BuisnessLogic.InvoiceMenagment.InvoiceMappers
{
    /// <summary>
    /// Mapper class for Invoice and InvoiceDTO
    /// </summary>
    public class InvoiceMap : IMapper<InvoiceDTO, Tuple<Invoice, Buyer, Seller, List<ProductsOnInvoice>>>, IMapper<Tuple<Invoice, Buyer, Seller, List<ProductsOnInvoice>>, InvoiceDTO>
    {
        public Tuple<Invoice, Buyer, Seller, List<ProductsOnInvoice>> Map(InvoiceDTO mapFromObject)
        {
            var newProductList = mapFromObject
                                .ProductsList
                                .Select(element => new ProductsOnInvoice()
                                {
                                    InvoiceNumber = mapFromObject.InvoiceNumber,
                                    ProductCode = element.ProductCode,
                                    QuantityOfProduct = element.QuantityOfProduct
                                }).ToList();

            var outObject = new Tuple<Invoice, Buyer, Seller, List<ProductsOnInvoice>>(
                new Invoice()
                {
                    InvoiceNumber = mapFromObject.InvoiceNumber,
                    BuyerNIP = mapFromObject.BuyerNIP,
                    SellerNIP = mapFromObject.SellerNIP,
                    CreationTime = mapFromObject.CreationTime,
                    ModyficationTime = DateTime.Now
                },
                new Buyer()
                {
                    NIP = mapFromObject.BuyerNIP,
                    Name = mapFromObject.BuyerName,
                    Street = mapFromObject.BuyerStreet,
                    StreetNumber = mapFromObject.BuyerStreetNumber,
                    FlatNumber = mapFromObject.BuyerFlatNumber
                },
                new Seller()
                {
                    NIP = mapFromObject.SellerNIP,
                    Name = mapFromObject.SellerName,
                    Street = mapFromObject.SellerStreet,
                    StreetNumber = mapFromObject.SellerStreetNumber,
                    FlatNumber = mapFromObject.SellerFlatNumber
                },
                new List<ProductsOnInvoice>(newProductList)
                );
            ;
            return outObject;
        }

        public InvoiceDTO Map(Tuple<Invoice, Buyer, Seller, List<ProductsOnInvoice>> mapFromObject)
        {
            var list = new List<ProductsOnInvoiceDTO>();
            foreach (var element in mapFromObject.Item4)
            {
                ProductsOnInvoiceDTO newProduct = new ProductsOnInvoiceDTO()
                {
                    ProductCode = element.ProductCode,
                    ProductName = element.Product.Name,
                    QuantityOfProduct = element.QuantityOfProduct,
                    ProductMeasureUnit = element.Product.MeasureUnit.ToString()
                };
                list.Add(newProduct);
            }
            var outObject = new InvoiceDTO()
            {
                InvoiceNumber = mapFromObject.Item1.InvoiceNumber,
                CreationTime = mapFromObject.Item1.CreationTime,
                ModyficationTime = mapFromObject.Item1.ModyficationTime,
                BuyerNIP = mapFromObject.Item2.NIP,
                BuyerName = mapFromObject.Item2.Name,
                BuyerStreet = mapFromObject.Item2.Street,
                BuyerStreetNumber = mapFromObject.Item2.StreetNumber,
                BuyerFlatNumber = mapFromObject.Item2.FlatNumber,
                SellerNIP = mapFromObject.Item3.NIP,
                SellerName = mapFromObject.Item3.Name,
                SellerStreet = mapFromObject.Item3.Street,
                SellerStreetNumber = mapFromObject.Item3.StreetNumber,
                SellerFlatNumber = mapFromObject.Item3.FlatNumber,
                ProductsList = new List<ProductsOnInvoiceDTO>(list)
            };

            return outObject;
        }
    }
}

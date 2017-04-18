using Micro_GetEstimate_WCF.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microservice_GetEstimate_WCF.GetTaxes;

namespace Micro_GetEstimate_WCF
{
    public partial class GetEstimate
    {

        public SOCEstimate GetRecurringCharges(List<DataContract.ProductInfo> products)
        {
            SOCEstimate socEstimate = null;
            if (products != null)
            {
                socEstimate = new SOCEstimate();
                socEstimate.Monthly = products.Sum(prod => prod.Rate);
                socEstimate.FirstBill = socEstimate.Monthly + (products.Sum(prod => prod.Rate) / 2);  

                TaxRequest taxrequest = new TaxRequest();

                List<Microservice_GetEstimate_WCF.GetTaxes.ProductInfo> taxprodlst = new List<Microservice_GetEstimate_WCF.GetTaxes.ProductInfo>();

                //Get Taxes
                foreach(DataContract.ProductInfo prod in products)
                {
                    Microservice_GetEstimate_WCF.GetTaxes.ProductInfo taxProd= new Microservice_GetEstimate_WCF.GetTaxes.ProductInfo();
                    taxProd.ProductIOSC = prod.ProductIOSC;
                    taxProd.Rate = prod.Rate;

                    taxprodlst.Add(taxProd); 
                }

                taxrequest.Products = taxprodlst.ToArray(); 


                socEstimate.TaxResponse = GetTaxInfo(taxrequest);

            }

            return socEstimate;
        }


        
        private static TaxResponse GetTaxInfo(TaxRequest taxRequest)
        {
            TaxResponse taxresponse = null; 

            if (taxRequest != null)
            {
                GetTaxesClient getTaxesClient = new GetTaxesClient("NetTcpBinding_IGetTaxes");
                taxresponse = getTaxesClient.GetSOCTaxes(taxRequest);

            }             

            return taxresponse; 

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using Microservice_GetEstimate_WCF.GetTaxes;

namespace Micro_GetEstimate_WCF.DataContract
{
    
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "Microservice_WCF_library.ContractType".
    [DataContract]
    public class SOCEstimate
    {         
        private decimal monthly;
        [DataMember]
        public decimal Monthly { get => this.monthly; set => this.monthly = value; }

        
        private decimal firstBill;
        [DataMember]
        public decimal FirstBill { get => firstBill; set => firstBill = value; }


        private TaxResponse taxResponse;

        [DataMember]
        public TaxResponse TaxResponse { get => this.taxResponse; set => this.taxResponse = value; }
    }
}

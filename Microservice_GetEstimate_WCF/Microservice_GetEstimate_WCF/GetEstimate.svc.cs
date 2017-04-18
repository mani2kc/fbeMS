using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Micro_GetEstimate_WCF.DataContract;

namespace Micro_GetEstimate_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public partial class GetEstimate : IGetEstimate
    {

        public SOCResponse GetSOCEstimate(SOCRequest request)
        {
            SOCResponse response;

            if (request == null)
            {
                response = null;
                throw new ArgumentNullException("Response");
            }
            else
            {
                response = new SOCResponse();
                if (request != null && request.Products != null)
                {
                    response.SOCEstimate = GetRecurringCharges(request.Products);
                    response.Productlst = request.Products;

                }

            }

            return response;
        }

    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyServiceLibrary
{
    [ServiceContract]
    interface IMyBulkService
    {
        [OperationContract]
        string GetDetails(string sname);
        [OperationContract]
        double GetResult(int m1, int m2, int m3);
        [OperationContract]
        string GetResult1(int m1, int m2, int m3);
        [OperationContract]
        List<Country> GetAllContries();

    }

    [DataContract]
    public class Country
    {
        [DataMember]
        public int CountryID { get; set; }
        [DataMember]
        public string CountryCode { get; set; }
        [DataMember]
        public string CountryName { get; set; }
    }

}

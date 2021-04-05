using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Wcf_2v
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string FindByName(string S);
        [OperationContract]
        string[] Vardi();
        [OperationContract]
        int Vardusk();
        [OperationContract]
        string SortedbyName();
        [OperationContract]
        string SortedbyRun100m();
        [OperationContract]
        string SortedbyLeksana();
        [OperationContract]
        string SortedbyHeight();
        [OperationContract]
        string SortedbyNameBR();
        [OperationContract]
        string SortedbyRun100mBR();
        [OperationContract]
        string SortedbyLeksanaBR();
        [OperationContract]
        string SortedbyHeightBR();

    }  // 



    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}

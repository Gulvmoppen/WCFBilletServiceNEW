﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFBilletServiceNEW
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBilletten" in both code and config file together.
    [ServiceContract]
    public interface IBilletten
    {

       

        [OperationContract]
        int BilPris();

        [OperationContract]
        int BilPrisMedBrobizz();

        [OperationContract]
        int BilPrisØresund();

        [OperationBehavior]
        int BilPrisØresundMedBroBizz();

        [OperationContract]
        int McPris();

        [OperationContract]
        int McPrisMedBrobizz();

        [OperationContract]
        int McPrisMedØresund();

        [OperationContract]
        int McPrisØresundMedBroBizz();
    }


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

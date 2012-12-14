﻿using System.ServiceModel;

namespace WCFCustomHeaderDemo.Lib.Contracts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IComplexCustomHeaderService" in both code and config file together.
    [ServiceContract]
    public interface IComplexCustomHeaderService
    {
        [OperationContract]
        string DoWork();
    }
}

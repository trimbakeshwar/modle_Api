using RegisterCL;
using RegisterRL;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterRL.service
{
    public class registerRL : InterfaceRegisterRL
    {
        public string Return_data(register data)
        {
            return " my name is : " + data.firstName + " " + data.lastName + " user name is : " + data.userName + " password : " + data.passWord;
        }
    }
}

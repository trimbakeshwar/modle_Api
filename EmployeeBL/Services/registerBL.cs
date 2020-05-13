using RegisterCL;
using RegisterRL;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterBL.service
{
    public class registerBL : InterfaceRegisterBL
    {
        private InterfaceRegisterRL information;

        public string Return_data(register data)
        {
            return this.Return_data(data);
        }
        public registerBL(InterfaceRegisterRL information)
        {
            this.information = information;
        }
    }
}

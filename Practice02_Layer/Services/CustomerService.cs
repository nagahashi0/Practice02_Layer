using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice02_Layer.Services
{
    public class CustomerService
    {
        public Models.Customer.ListViewModel ListInitialize()
        {

            Models.Customer.ListViewModel mdl = new Models.Customer.ListViewModel();
            mdl.PageTitle = "顧客一覧";
            mdl.FilterItems = new Models.Customer.FilterViewModel()
                {
                    CustomerName = string.Empty,
                    EmployeeName = string.Empty
                };
            mdl.List = null;

            return mdl;

        }

        public Models.Customer.ListViewModel SearchListData(Models.Customer.FilterViewModel filter)
        {
            return null;
        }
    }
}
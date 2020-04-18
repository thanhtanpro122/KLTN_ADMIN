using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace KLTN_Admin.DataAccess
{
    public class AdminDataAccess
    {
        private RestClient client;
        public AdminDataAccess(RestClient client)
        {
            client = new RestClient("http://localhost:3000/");
        }
        public void GetAllAdmin()
        {
            var resquest = new RestRequest("/admin", Method.GET);

            var content = client.Execute(resquest).Content;
        }
    }
}


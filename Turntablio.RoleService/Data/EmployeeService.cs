using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace Turntablio.RoleService.Data
{
    public class EmployeeService
    {
        private readonly IHttpClientFactory _clientFactory;
        public EmployeeService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<Employee[]> GetEmplyeeAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
           "https://role-api.herokuapp.com/api/employees");
            //request.Headers.Add("Accept", "application/vnd.github.v3+json");
            //request.Headers.Add("User-Agent", "HttpClientFactory-Sample");

            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(request);

            return null;

        }
    }
}

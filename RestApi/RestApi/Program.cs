using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace RestApi
{
    class Program
    {
		//public class Authenticator
		//{
		//	private string ConsumerKey;
		//	private string ConsumerSecret;
		//	private string RequestTokenUrl;
		//	private string AccessTokenUrl;
		//	private string AuthorizeUrl;

		//	public Authenticator(string ConsumerKey, string ConsumerSecret, string RequestTokenUrl, string AccessTokenUrl, string AuthorizeUrl)
		//	{
		//		this.ConsumerKey = ConsumerKey;
		//		this.ConsumerSecret = ConsumerSecret;
		//		this.RequestTokenUrl = RequestTokenUrl;
		//		this.AccessTokenUrl = AccessTokenUrl;
		//		this.AuthorizeUrl = AuthorizeUrl;
		//	}

			static void Main(string[] args)
			{

			var client = new RestClient("https://localhost:44334/api/");
			var request = new RestRequest("emp/", Method.GET);
			var queryResult = client.Execute<List<Employees>>(request).Data;
			if (queryResult.Count>0)
			{
				var emps = queryResult.ToList<Employees>();

				foreach (var emp in emps)
				{
					Console.WriteLine(emp.FirstName);
					Console.WriteLine(emp.LastName);
					Console.WriteLine(emp.Email);
					Console.WriteLine(emp.Phone);
					Console.WriteLine(emp.HireDate);
					Console.WriteLine(emp.ManagerID);
					Console.WriteLine(emp.Salary);
					Console.WriteLine(emp.DepartmentID);
					Console.WriteLine();
				}

				var request1 = new RestRequest("emp/Add", Method.POST);
			
				request1.RequestFormat = DataFormat.Json;
				request1.AddBody(new Employees
				{
					FirstName = "deepika",
					LastName = "M",
					Email = "deepi.m@gmail.com",
					Phone = "987654321",
					HireDate = "2021-01-02",
					ManagerID = "2",
					Salary = "20000",
					DepartmentID = "3" 

				});
				IRestResponse<Employees> response = client.Execute<Employees>(request1);
				if(response.IsSuccessful)
                {
					Console.WriteLine(response.StatusCode);
					
					//var result = JsonConvert.DeserializeObject<Employees>(response.Content);

					//Console.WriteLine(results);
				}
				else
                {
					Console.WriteLine("something went wrong");
                
				}
				//var results = client.PostTaskAsync<Employees>("emp/Add",student);
			}
			var request2 = new RestRequest("emp/Delete/{id}", Method.DELETE);
			var id = Console.ReadLine();
			
			request2.AddParameter("EmpID", id);

			client.Execute(request);
			Console.ReadLine();

			//	Console.WriteLine("Hello Phil, you are awesome!");

			//Console.WriteLine(FetchFeed("http://philwilson.org", "blog/feed/atom"));
		}
			//private static string FetchFeed(string domain, string resource)
			//{
			//	var client = new RestClient(domain);
			//	var request = new RestRequest(resource);
			//	IRestResponse response = client.Execute(request);
			//	return response.Content;
			//}
			//public string GetAuthUrlToken()
			//{
			//	var baseUrl = "http://newapi.test.livechek.com/api/";
			//	var client = new RestClient(baseUrl);
			//	client.Authenticator = OAuth1Authenticator.ForRequestToken(this.ConsumerKey, this.ConsumerSecret);

			//	var request = new RestRequest("oauth/request_token", Method.POST);
			//	var response = client.Execute(request);


			//	//Assert.NotNull(response);
			//	//Assert.Equal(HttpStatusCode.OK, response.StatusCode);

			//	if (response.StatusCode != System.Net.HttpStatusCode.OK)
			//		throw new Exception("Request Token Step Failed");

			//	var qs = HttpUtility.ParseQueryString(response.Content);
			//	var oauth_token = qs["oauth_token"];
			//	var oauth_token_secret = qs["oauth_token_secret"];

			//	//Assert.NotNull(oauth_token);
			//	//Assert.NotNull(oauth_token_secret);

			//	request = new RestRequest("oauth/authorize");
			//	request.AddParameter("oauth_token", oauth_token);
			//	var url = client.BuildUri(request).ToString();
			//	//Process.Start(url);

			//	return url;
			//}
		//}



	}
}

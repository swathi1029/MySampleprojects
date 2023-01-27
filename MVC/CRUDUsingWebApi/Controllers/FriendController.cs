using CRUDUsingWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace CRUDUsingWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendController : ControllerBase
    {
        private FriendsContext Context { get; }
        
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public IEnumerable<Friend> Get()
        {
            List<Friend> customers = (from Friend in this.Context.Friends.Take(10)
                                        select Friend).ToList();
            return customers;
        }

        public Friend Get(int id)
        {
            Friend friend = this.Context.Friends.Find(id);
            if (friend == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return friend;
        }
        public HttpResponseMessage Post(Friend friend)
        {
            if (ModelState.IsValid)
            {
                this.Context.Friends.Add(friend);
                this.Context.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, friend);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = friend.FriendId }));
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }
    }
}

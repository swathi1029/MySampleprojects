using CRUDUsingApi.Interface;
using CRUDUsingApi.Models;
using CRUDUsingApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace CRUDUsingApi.Controllers
{
    [System.Web.Http.Route("api/[controller]")]
    [ApiController]
    public class FriendsController : ControllerBase
    {
        private FriendContext Context { get; }
        //[Microsoft.AspNetCore.Mvc.HttpGet]
        //[System.Web.Http.Route("~/api/Friends/Get")]
        //private IFriend members = new FriendRepository();

        //[System.Web.Http.HttpGet]
        //[System.Web.Http.Route("~/api/Friends/Get")]
        //public ActionResult<IEnumerable<Friend>> GetAllMembers()
        //{
        //    return members.GetAllMember();
        //}
        //[System.Web.Http.HttpGet]
        //[System.Web.Http.Route("~/api/Friends/Get/{id}")]
        //public ActionResult<Friend> GetMemberById(int id)
        //{
        //    return members.GetMember(id);
        //}
        [HttpGet]
        public IEnumerable<Friend> Get()
        {
            return this.Context.Friends.AsEnumerable();
        }

        [System.Web.Http.Route("~/api/Friends/Get/{id}")]
        public Friend Get(int id)
        {
            Friend friend = this.Context.Friends.Find(id);
            if (friend == null)
            {
                return friend;
            }

            return friend;
        }
        //    public string Post(Friend friend)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            this.Context.Friends.Add(friend);
        //            this.Context.SaveChanges();

        //            //HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, friend);
        //            //response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = friend.FriendId }));
        //            return "Successful";
        //        }
        //        else
        //        {
        //            return "Bad Request";
        //        }
        //    }
        //    public string Put(int id, Friend friend)
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return "Bad Request";
        //        }

        //        if (id != friend.FriendId)
        //        {
        //            return "Bad Request";
        //        }

        //        this.Context.Entry(friend).State = EntityState.Modified;

        //        try
        //        {
        //            this.Context.SaveChanges();
        //        }
        //        catch (DbUpdateConcurrencyException ex)
        //        {
        //            return "Not Found";
        //        }

        //        return "OK";
        //    }
        //    public string Delete(int id)
        //    {
        //        Friend friend = this.Context.Friends.Find(id);
        //        if (friend == null)
        //        {
        //            return "Bad Request";
        //        }

        //        this.Context.Friends.Remove(friend);

        //        try
        //        {
        //            this.Context.SaveChanges();
        //        }
        //        catch (DbUpdateConcurrencyException ex)
        //        {
        //            return "Not found";
        //        }

        //        return "OK";
        //    }

    }
}

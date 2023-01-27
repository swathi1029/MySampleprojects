using CRUDUsingApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDUsingApi.Interface
{
    interface IFriend
    {
        List<Friend> GetAllMember();
        Friend GetMember(int id);
       
    }
}

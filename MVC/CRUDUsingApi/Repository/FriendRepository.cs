using CRUDUsingApi.Interface;
using CRUDUsingApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDUsingApi.Repository
{
    public class FriendRepository : IFriend

    {
        List<Friend> lisMembers = new List<Friend>
        {
            new Friend{FirstName="Kirtesh", LastName="Shah", Address="Vadodara",City="Hyd",PostalCode="500032",Country="India",Notes="Student" },
            new Friend{FirstName="swapna", LastName="singh", Address="srnagar",City="Hyd",PostalCode="500032",Country="India",Notes="Student" },
            new Friend{FirstName="srusti", LastName="gsfdg", Address="retdfgs",City="Hyd",PostalCode="500032",Country="India",Notes="Student" },

        };
        public List<Friend> GetAllMember()
        {
            return lisMembers;
        }

        public Friend GetMember(int id)
        {
            return lisMembers.FirstOrDefault(x => x.FriendId == id);
        }
    }
}

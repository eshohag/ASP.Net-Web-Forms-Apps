using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FriendCircleInformation.DAL.Gateway;
using FriendCircleInformation.DAL.Model;

namespace FriendCircleInformation.BLL
{
    public class CheckPersonDetails
    {
        PersonGateway aPersonGateway=new PersonGateway();

        public string Save(Person aPerson)
        {
            if (aPersonGateway.Save(aPerson) > 0)
            {
                return "Successfully Saved";                
            }
              
            {
                return " faild Saved";
            }
        }

        public List<Person> GetPersonList()
        {
            return aPersonGateway.GetPersonList();
        }
    }
}
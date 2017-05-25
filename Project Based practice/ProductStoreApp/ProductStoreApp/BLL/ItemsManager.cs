using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProductStoreApp.DAL.Gateway;
using ProductStoreApp.DAL.Model;

namespace ProductStoreApp.BLL
{
    public class ItemsManager
    {
        ItemsGateway aItemsGateway=new ItemsGateway();
        public string Save(Item aItem)
        {
            if (aItem.Code.Length >= 3)
            {
                if (aItem.Quantity >= 0)
                {
                    if (aItemsGateway.IsCodeExistItem(aItem.Code) == null)
                    {
                        if (aItemsGateway.Save(aItem) > 0)
                        {
                            return "Save Successfully";
                        }
                        else
                        {
                            return "Save Faild";
                        }
                     }
                     else
                    {
                        if (aItemsGateway.GetUpdateQuantity(aItem.Quantity,aItem.Code) > 0)
                        {
                            return "Successfully Update your Quantity";
                        }
                        else
                        {
                            return "Faild Update";
                        }
                         //return "Existing Code or Already Entered this Code " + aItem.Code;
                     }
                 }
                 else
                 {
                     return "Quantity Must Be Positive value";
                 }              
             }
             else
             {
                return "Atleast 3 Charecter Or Long, Your Input Length is " + aItem.Code.Length;
             }                  
         }

         public List<Item> GetAllProduct()
         {
             return aItemsGateway.GetAllProduct();
         }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using ContactAPI.Models;

namespace ContactAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ContactsController : ApiController
    {
        private readonly SQL001Entities Context = new SQL001Entities();

        [Route("api/contact")]
        public IEnumerable<Contact> GetContacts()
        {
           
                return Context.Contacts;
           
        }
        [Route("api/contact/filtered/{searchText?}")]
        public IEnumerable<Contact> GetContact(string searchText=null)
        {
            if(searchText==null)
            {
                return Context.Contacts;
            }
            return Context.Contacts.Where(x => x.Name.Contains(searchText));
        }

        [Route("api/contact/find/{searchText}")]
        public Contact GetContact(int searchText)
        {
            return Context.Contacts.Where(x => x.ContactID==searchText).SingleOrDefault();
        }



    }
}
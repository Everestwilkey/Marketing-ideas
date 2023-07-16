using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing_ideas
{
    public abstract class Service : Advertisement
    {
        protected string _service;
        protected string _location;
        protected string _phoneNumber;

        public void SetService(string service)
        { _service = service; }
        public string GetService()
        { return _service; }
        public void SetLocation(string location)
        { _location = location; }
        public string GetLocation() 
        { return _location;}
        public void SetPhoneNumber(string phoneNumber)
        { _phoneNumber = phoneNumber; }
        public string PhoneNumber()
        { return _phoneNumber; }
    }
}

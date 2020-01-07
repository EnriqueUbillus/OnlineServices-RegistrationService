using System;
using System.Collections.Generic;
using System.Text;

namespace UserServices.Shared.TransferObject
{
    public class UserTO
    {
        public int ID { get; private set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public bool IsActivated { get; set; }
    }
}

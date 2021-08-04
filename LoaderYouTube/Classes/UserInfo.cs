using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoaderYouTube.Classes
{
    class UserInfo
    {
        public string Mail { get; private set; }
        public string Password { get; private set; }

        public UserInfo(string mail, string password)
        {
            Mail = mail ?? throw new ArgumentNullException(nameof(mail));
            Password = password ?? throw new ArgumentNullException(nameof(password));
        }
    }
}

using System.Collections.Generic;

namespace CustomerChat.Models
{
    public class User
    {
        //id, name, type, fontName, fontSize, fontColor, sex, age, friendsList, status, memberType

        public  string ConnectionId { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public List<User> friendsList { get; set; }
        public string fontName { get; set; }
        public string fontSize { get; set; }
        public string fontColor { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
        public string status { get; set; }
        public string memberType { get; set; }
        public string avator { get; set; }

        //public user Login(string UserName)
        //{ 


        //}

    }
}
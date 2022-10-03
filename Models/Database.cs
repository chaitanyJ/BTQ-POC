using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace datatable_app.Models
{
    public class Database
    {
        public List<User> userList { get; set; }
        public List<Countrycs> cList { get; set; }
        public Database()
        {
            userList = new List<User>() {
            new User() { Name = "John Doe", RollNo = "1", Div = "A" },
            new User() { Name = "hasfsa", RollNo = "200", Div = "B" },
            new User() { Name = "John Doe", RollNo = "3", Div = "C" },
            new User() { Name = "John Doe", RollNo = "4", Div = "D" },
            new User() { Name = "John Doe", RollNo = "5", Div = "E" },
            new User() { Name = "John zen", RollNo = "6", Div = "F" },
            new User() { Name = "John Doe", RollNo = "7", Div = "S" },
            new User() { Name = "John Doe", RollNo = "8", Div = "A" },
            new User() { Name = "John Doe", RollNo = "9", Div = "A" },
            new User() { Name = "John Doe", RollNo = "10", Div = "A" },
            new User() { Name = "John Doe", RollNo = "11", Div = "A" },
            new User() { Name = "John zen", RollNo = "12", Div = "A" },
            new User() { Name = "John Doe", RollNo = "13", Div = "A" },
            new User() { Name = "John Doe", RollNo = "14", Div = "A" },
            new User() { Name = "John Doe", RollNo = "15", Div = "A" },
            new User() { Name = "John Doe", RollNo = "16", Div = "A" },
            new User() { Name = "John Doe", RollNo = "17", Div = "A" },
            new User() { Name = "John zen", RollNo = "18", Div = "A" },
            new User() { Name = "John Doe", RollNo = "19", Div = "A" },
            new User() { Name = "John Doe", RollNo = "20", Div = "A" },
            new User() { Name = "John Doe", RollNo = "22", Div = "A" },
            new User() { Name = "John Doe", RollNo = "23", Div = "A" },
            new User() { Name = "John Doe", RollNo = "24", Div = "A" },
            new User() { Name = "John zen", RollNo = "25", Div = "Z" },  
        };

            cList = new List<Countrycs>() { 
                new Countrycs() { Cname = "india",Value="india"}
                , new Countrycs() { Cname = "us",Value="us" } 
                , new Countrycs() { Cname = "pak",Value="pak" } };
    } }
}
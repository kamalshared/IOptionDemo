using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOptionDemo.Models
{
    public class MyOption
    {
        public MyOption()
        {

        }
        public string Option1 { get; set; }
        public int Option2 { get; set; }
        
    }
}

namespace IOptionDemo
{
    class MyOptionsWithDelegateConfig
    {
        public string Option1 { get; internal set; }
        public int Option2 { get; internal set; }
    }

    class MySubOptions
    {
        public string suboption1 { get; set; }
        public int suboption2 { get; set; }
    }
}
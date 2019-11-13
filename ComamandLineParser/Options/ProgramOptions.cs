using MatthiWare.CommandLine.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComamandLineParser.Options
{
   public class ProgramOptions
    {
        [Required,Name("u","username"),Description("Login user")]
        public string Username { get; set; }
        [Required, Name("p", "password"), Description("password for user")]
        public string Passwrd { get; set; }
        [Name("v", "verbose"), Description("verbose output"),DefaultValue(true)]
        public bool Verbose { get; set; }
    }
}

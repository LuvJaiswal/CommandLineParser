using ComamandLineParser.Options;
using MatthiWare.CommandLine;
using System;

namespace ComamandLineParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new CommandLineParserOptions
            {
                AppName="Parser.csproj"

            };

            var parser = new CommandLineParser<ProgramOptions>();
            var result = parser.Parse(args);

            if (result.HasErrors)
            {
                Console.Error.WriteLine("parsing has errors");
                    
            }



        }
    }
}

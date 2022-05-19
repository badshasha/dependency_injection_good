// See https://aka.ms/new-console-template for more information
using Microsoft.Extension.DependencyInjection;

namespace injection
{

    public class ScopeClass{
        public ScopeClass()
        {
            System.Console.WriteLine("scope is working");
        }
    }

    public class Transient{
        public Transient(){
            System.Console.WriteLine("trnasient is working");
        }
    }

    public class MainProgram{
        public static void Main(string[] args){
             
                var collection = new ServiceCollection();
                collection.AddScope<ScopeClass>();
                collection.AddTransient<Transient>();
                              
                var builder = collection.buildServiceProvider();
                
                Parallel.For(1,10 ,i => {
                    System.Console.WriteLine($"scope id { builder.GetService<ScopeClass>().GetHashCode().ToString() }");
                    System.Console.WriteLine($"scope id { builder.GetService<Transient>().GetHashCode().ToString() }");
                });
        }

    }

    
}

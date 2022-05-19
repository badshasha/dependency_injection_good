// See https://aka.ms/new-console-template for more information
using Microsoft.Extension.DependencyInjection;

namespace injection
{
    public class MainProgram{

        public static void Main(string[] args){
             

            var collection = new SericeCollection();
            collection.AddScope<IDomain,Domain>();

            var provider = collection.BuildServiceProvied();
            IDomain doaminInfo = provider.GetService<IDomain>();

            // IDomain DomainClass = new Domain();
            Iui uiclass = new UI(doaminInfo);
            uiclass.PrintInfo();
            
        }

    }

    public interface IDomain{
        void GetData();
    }

    public class Domain : IDomain
    {
        public void GetData(){
            System.Console.WriteLine("Domain class information");
        }
    }

    public interface Iui{
        void PrintInfo();
    }

    public class UI : Iui
    {
        private readonly IDomain _dom;
        public UI(IDomain _dom)
        {
            this._dom=  _dom;
        }
        public void PrintInfo(){           
            _dom.GetData();
        }

    }
    
}

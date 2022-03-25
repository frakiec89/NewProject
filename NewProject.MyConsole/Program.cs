using NewProject.BL;
using NewProject.Core;
using NewProject.Prezenter;
using System;

namespace NewProject.MyConsole
{
    internal class Program
    {
        static void Main(string[] args) // сборка 
        {
            MyConsole myConsole = new MyConsole();
            BLContent bLContent = new BLContent();

            MyMessage myMessage = new MyMessage(bLContent, myConsole);


            Console.WriteLine("Hello World!");

            myConsole.Start();
        }
    }


    public class MyConsole : IViewMessage
    {
        public event EventHandler StartEvent;

        public void Start ()
        {
            Console.WriteLine("Ввеедите старт");
            var s = Console.ReadLine();
            if(s =="старт")
            {
                if(StartEvent != null)
                {
                    StartEvent(this, EventArgs.Empty);
                }
            }    
        }
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}

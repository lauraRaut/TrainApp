using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text.Json;

namespace TrainApp
{
    class Program
    {
        //private static void GetSingleTrain()
        //{
        //    Console.WriteLine("jotain tähän");
            
        //}
        static void Main(string[] args)
        {
            string input = "trains/latest/1";
            Train juna = TrainApi.GetSingleTrain(input);

            Console.WriteLine(juna.trainNumber);
            Console.WriteLine("Lauran terveiset");
            // Aadan terveiset
            //Erkin terveiset
            // hetan terveiset


        }
       
    }
   
}

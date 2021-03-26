using System;
using System.IO;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = Directory.GetCurrentDirectory();

            string line1;  
            string line2;
  
            //REFERENCIA: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-a-text-file-one-line-at-a-time

           
            System.IO.StreamReader file1 =
                new System.IO.StreamReader(@$"{path}\Archivo1.txt");  
            System.IO.StreamReader file2 =
                new System.IO.StreamReader(@$"{path}\Archivo2.txt"); 
            
            int counterFile1 = 0;
            int counterFile2 = 0;

            /*
                file1:           file2:

                Bienvenido 
                                Al
                curso de 
                                Programación II.
                                Espero que este
                semestre
                                se diviertan mucho!!!

            */
            
            //Primera parte
            while((line1 = file1.ReadLine()) != null && counterFile1 < 2)  
            {  
                System.Console.WriteLine(line1);  
                
                 while((line2 = file2.ReadLine()) != null && counterFile1 < 2)  
                {  
                    System.Console.WriteLine(line2);
                    counterFile1 += 1;
                    counterFile2 += 1;
                    break;                         
                }   

                if(counterFile2 == 2){
                    break;
                }

            }  
            
            // Segunda parte, orden invertido
             while((line1 = file2.ReadLine()) != null )  
            {  
                System.Console.WriteLine(line1);  
                
                 while((line2 = file1.ReadLine()) != null )  
                {  
                    System.Console.WriteLine(line2);
                    break;                         
                }     
            }
                    
        }



    }
}

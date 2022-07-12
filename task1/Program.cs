using System;
namespace task1
{
    public class task1
    {
        static void Main()
        {

            string word = "expert";
            
            if(word=="basic")
            {
                DocumentProgram basic = new DocumentProgram();    
                basic.OpenDocument();
                basic.EditDocument();
                basic.SaveDocument();
            }
            else if (word == "pro")
            {
                ProDocumentProgram pro = new ProDocumentProgram();
                pro.OpenDocument(); 
                pro.EditDocument();
                pro.SaveDocument();

            }
           else if(word == "expert")
            {
                ExpertDocumentProgram expert = new ExpertDocumentProgram(); 
                expert.OpenDocument();
                expert.EditDocument();
                expert.SaveDocument();

            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
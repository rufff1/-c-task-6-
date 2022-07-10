using System;
namespace task1
{
    public class task1
    {
        static void Main()
        {
            DocumentProgram basicprogram = new DocumentProgram();
            ExpertDocumentProgram expertDocumentProgram = new ExpertDocumentProgram();
            ProDocumentProgram proDocumentProgram = new ProDocumentProgram();


            basicprogram.OpenDocument();
            basicprogram.EditDocument();
            basicprogram.SaveDocument();

            //expertDocumentProgram.OpenDocument();
            //expertDocumentProgram.EditDocument();
            //expertDocumentProgram.SaveDocument();


            //proDocumentProgram.OpenDocument();
            //proDocumentProgram.EditDocument();
            //proDocumentProgram.SaveDocument();

        }
    }
}
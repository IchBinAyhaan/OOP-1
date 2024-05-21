namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Choose a program type (basic, pro, expert):");
            string programType = Console.ReadLine();

           
            DocumentProgram program;
            switch (programType)
            {
                case "basic":
                    program = new DocumentProgram();
                    break;
                case "pro":
                    program = new ProDocumentProgram();
                    break;
                case "expert":
                    program = new ExpertDocumentProgram();
                    break;
                default:
                    Console.WriteLine("Invalid program type.");
                    return;
            }

      
            program.OpenDocument();
            program.EditDocument();
            program.SaveDocument();
        }
    }

}

using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IRecipe interF)
        {
            File.WriteAllText("Recipe.txt", interF.GetTextToPrint());
        }
    }
}
using Irony.Parsing;
using OLC1_Project2_Jun18.FilesControl;
using OLC1_Project2_Jun18.LanguageGrammar;
using OLC1_Project2_Jun18.Singleton;

namespace OLC1_Project2_Jun18.BuilderPackage
{
    class Builder : Grammar
    {
        public static ParseTreeNode Build(string text)
        {

            BuildErrorSingleton buildError = BuildErrorSingleton.GetInstance();
            Gramatica gramatica = new Gramatica();
            LanguageData language = new LanguageData(gramatica);
            Parser parser = new Parser(language);
            ParseTree tree = parser.Parse(text);

            Report report = new Report();
            report.ErrorReport(buildError.ListError);

            return tree.Root;
        }

        public static void GenerateImage(ParseTreeNode root)
        {
            string graphDOT = ControlDOT.GetDOT(root);
            WINGRAPHVIZLib.DOT dot = new WINGRAPHVIZLib.DOT();
            WINGRAPHVIZLib.BinaryImage img = dot.ToPNG(graphDOT);
            img.Save("AST.png");
        }
    }
}

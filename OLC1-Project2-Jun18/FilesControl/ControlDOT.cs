using Irony.Parsing;

namespace OLC1_Project2_Jun18.FilesControl
{
    class ControlDOT
    {
        private static int counter;
        //private static string graph;

        internal static string GetDOT(ParseTreeNode root)
        {
            string graph;
            graph = "digraph ast {\r\n" +
                        "\tnode [shape = \"box\"]\r\n" +
                        $"\tnode0 [label = \"{Escape(root.ToString())}\"]\r\n";
            counter++;
            ThrowTree("node0", root, ref graph);
            graph += "}";

            return graph;
        }

        private static string Escape(string rootStr)
        {
            rootStr = rootStr.Replace("\\", "\\\\");
            rootStr = rootStr.Replace("\"", "\\\"");

            return rootStr;
        }

        private static void ThrowTree(string parent, ParseTreeNode root, ref string graph)
        {
            foreach (ParseTreeNode item in root.ChildNodes)
            {
                string child = "node" + counter.ToString();
                graph += $"{child} [label = \"{Escape(item.ToString())}\"]\r\n";
                graph += $"{parent} -> {child}\r\n";
                counter++;

                ThrowTree(child, item, ref graph);
            }
        }
    }
}

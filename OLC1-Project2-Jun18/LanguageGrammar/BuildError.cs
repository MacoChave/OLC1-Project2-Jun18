namespace OLC1_Project2_Jun18.LanguageGrammar
{
    internal class BuildError
    {
        private string type;
        private string errorStr;
        private int column;
        private int row;

        public BuildError(string type, string errorStr, int column, int row)
        {
            Type = type;
            ErrorStr = errorStr;
            Column = column;
            Row = row;
        }

        public string Type { get => type; set => type = value; }
        public string ErrorStr { get => errorStr; set => errorStr = value; }
        public int Column { get => column; set => column = value; }
        public int Row { get => row; set => row = value; }
    }
}
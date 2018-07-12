using System.Collections.Generic;
using OLC1_Project2_Jun18.LanguageGrammar;

namespace OLC1_Project2_Jun18.Singleton
{
    class BuildErrorSingleton
    {
        private static BuildErrorSingleton instance = null;
        private List<BuildError> listError;

        private BuildErrorSingleton()
        {
            ListError = new List<BuildError>();
        }

        internal List<BuildError> ListError { get => listError; set => listError = value; }

        internal static BuildErrorSingleton GetInstance()
        {
            if (instance == null)
                instance = new BuildErrorSingleton();

            return instance;
        }
    }
}

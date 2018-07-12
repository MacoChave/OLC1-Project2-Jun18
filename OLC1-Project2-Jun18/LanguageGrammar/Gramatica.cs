using Irony.Parsing;
using OLC1_Project2_Jun18.Singleton;

namespace OLC1_Project2_Jun18.LanguageGrammar
{
    class Gramatica : Grammar
    {
        public BuildErrorSingleton singleton = BuildErrorSingleton.GetInstance();

        public Gramatica() : base(caseSensitive: true)
        {
            #region ER
            var tpInteger = TerminalFactory.CreateCSharpNumber("numero");
            IdentifierTerminal tpId = new IdentifierTerminal("id");
            StringLiteral tpString = TerminalFactory.CreateCSharpString("cadena");
            var tpChar = TerminalFactory.CreateCSharpChar("caracter");

            CommentTerminal LINE_COMMENT = new CommentTerminal("LINE_COMMENT", "-->", "\n", "\r\n");
            CommentTerminal BLOCK_COMMENT = new CommentTerminal("BLOCK_COMMENT", "</", "/>");
            #endregion

            #region TERMINALES
            /*
             * TIPOS DE DATOS
             */
            var tkBoolean = ToTerm("Boolean");
            var tkString = ToTerm("Texto");
            var tkInteger = ToTerm("Entero");
            var tkChar = ToTerm("Carácter");
            var tkVacio = ToTerm("Vacio");

            /*
             * OPERADORES ARITMETICOS, LOGICOS, RELACIONAL
             */
            var tkPlus = ToTerm("+");
            var tkMinus = ToTerm("-");
            var tkMult = ToTerm("*");
            var tkDiv = ToTerm("/");
            var tkMod = ToTerm("%");
            var tkPow = ToTerm("^");
            var tkIncrement = ToTerm("++");
            var tkDecrement = ToTerm("--");
            var tkOpenPar = ToTerm("(");
            var tkClosePar = ToTerm(")");
            var tkEquals = ToTerm("==");
            var tkDiferent = ToTerm("!=");
            var tkLesser = ToTerm("<");
            var tkHigher = ToTerm(">");
            var tkLesserEq = ToTerm("<=");
            var tkHigherEq = ToTerm(">=");
            var tkCompare = ToTerm("~");
            var tkAnd = ToTerm("&&");
            var tkOr = ToTerm("||");
            var tkNot = ToTerm("!");

            /*
             * SIMBOLOS
             */
            var tkComma = ToTerm(",");
            var tkEqual = ToTerm("=");
            var tkColon = ToTerm(":");
            var tkSemicolon = ToTerm(";");
            var tkOpenSquarebracket = ToTerm("{");
            var tkCloseSquarebracket = ToTerm("}");
            var tkSlash = ToTerm("/");

            /*
             * RESERVADAS
             */
            var tkMain = ToTerm("Principal");
            var tkBreak = ToTerm("Romper");
            var tkContinue = ToTerm("Continuar");
            var tkReturn = ToTerm("Retorno");
            var tkMostrar = ToTerm("Mostrar");
            var tkDibujarAST = ToTerm("DibujarAST");
            var tkDibujarEXP = ToTerm("DibujarEXP");
            var tkDibujarTS = ToTerm("DibujarTS");
            var tkIf = ToTerm("Es_Verdadero");
            var tkElse = ToTerm("Es_falso");
            var tkFor = ToTerm("Para");
            var tkWhile = ToTerm("Mientras_que");
            var tkSwitch = ToTerm("Cambiar_a");
            var tkCase = ToTerm("Valor");
            var tkDefault = ToTerm("No_cumple");
            var tkDo = ToTerm("Hasta_que");
            var tkImport = ToTerm("Importar");
            var tkDefine = ToTerm("Definir");
            #endregion
            #region NO TERMINALES
            NonTerminal S = new NonTerminal("S"),
                        EPS = new NonTerminal("EPS"),
                        SOURCE = new NonTerminal("SOURCE"),
                        INVOCAR = new NonTerminal("INVOCAR"),
                        E = new NonTerminal("E"),
                        ER = new NonTerminal("ER"),
                        EL = new NonTerminal("EL"),
                        LIST_HEADER = new NonTerminal("LIST_HEADER"),
                        HEADER = new NonTerminal("HEADER"),
                        IMPORT = new NonTerminal("IMPORT"),
                        DEFINE = new NonTerminal("DEFINE"),
                        IMPORT_VALUE = new NonTerminal("IMPORT_VALUE"),
                        DEFINE_VLAUE = new NonTerminal("DEFINE_VALUE"),
                        PATH = new NonTerminal("PATH"),
                        LIST_SENT = new NonTerminal("LIST_SENT"),
                        SENT = new NonTerminal("SENT"),
                        VARIABLE = new NonTerminal("VARIABLE"),
                        TYPE = new NonTerminal("TIPO"),
                        LIST_ID = new NonTerminal("LIST_ID"),
                        ASSIGN = new NonTerminal("ASSIGN");
            #endregion
            #region GRAMATICA
            S.Rule = SOURCE;

            EPS.Rule = Empty;

            SOURCE.Rule = LIST_HEADER + LIST_SENT;

            LIST_HEADER.Rule = LIST_HEADER + HEADER
                             | HEADER;

            HEADER.Rule = IMPORT | DEFINE | SyntaxError;

            IMPORT.Rule = tkImport + IMPORT_VALUE + tkSemicolon;
            
            DEFINE.Rule = tkDefine + DEFINE_VLAUE + tkSemicolon;

            IMPORT_VALUE.Rule = PATH
                              | tpId + ToTerm(".clr");

            DEFINE_VLAUE.Rule = PATH
                              | tpInteger;

            PATH.Rule = PATH + tkSlash + tpString
                      | tpString;

            LIST_SENT.Rule = LIST_SENT + SENT
                           | SENT;

            SENT.Rule = VARIABLE + tkSemicolon
                      //| METHOD
                      //| FUNCTION
                      | SyntaxError;

            VARIABLE.Rule = TYPE + LIST_ID + ASSIGN;

            TYPE.Rule = tkBoolean | tkString | tkInteger | tkChar;

            LIST_ID.Rule = LIST_ID + tkComma + tpId
                         | tpId;

            ASSIGN.Rule = tkEqual + EL
                        | EPS;

            EL.Rule = EL + tkAnd + EL
                    | EL + tkOr + EL
                    | tkNot + EL
                    | ER;

            ER.Rule = ER + tkEquals + ER
                    | ER + tkDiferent + ER
                    | ER + tkLesser + ER
                    | ER + tkLesserEq + ER
                    | ER + tkHigher + ER
                    | ER + tkHigherEq + ER
                    | ER + tkCompare + ER
                    | E;

            E.Rule = E + tkPlus + E
                   | E + tkMinus + E
                   | E + tkMult + E
                   | E + tkDiv + E
                   | E + tkMod + E
                   | E + tkPow + E
                   | E + tkIncrement
                   | E + tkDecrement
                   | tkMinus + E
                   | tkOpenPar + E + tkClosePar
                   | tpInteger
                   | tpString
                   | tpChar
                   | ToTerm("true")
                   | ToTerm("false");
            #endregion
            #region PREFERENCIAS
            Root = S;

            NonGrammarTerminals.Add(BLOCK_COMMENT);
            NonGrammarTerminals.Add(LINE_COMMENT);

            MarkTransient(IMPORT_VALUE, DEFINE_VLAUE, PATH);

            RegisterOperators(1, Associativity.Left, tkPlus, tkMinus);
            RegisterOperators(2, Associativity.Left, tkMult, tkDiv, tkMod);
            RegisterOperators(3, Associativity.Right, tkPow);
            RegisterOperators(4, tkMinus);
            RegisterOperators(5, tkEquals, tkDiferent, tkLesser, tkHigher, tkLesserEq, tkHigherEq, tkCompare);
            RegisterOperators(6, Associativity.Left, tkOr);
            RegisterOperators(7, Associativity.Left, tkAnd);
            RegisterOperators(8, Associativity.Left, tkNot);
            RegisterOperators(9, tkOpenPar, tkClosePar);
            #endregion
        }
        public override void ReportParseError(ParsingContext context)
        {
            string errorStr = context.CurrentToken.ValueString;
            string type;
            int row, column;

            type = GetTypeError(ref errorStr);

            row = context.Source.Location.Line;
            column = context.Source.Location.Column;

            BuildError error = new BuildError(type, errorStr, column, row);
            singleton.ListError.Add(error);

            base.ReportParseError(context);
        }

        private string GetTypeError(ref string error)
        {
            string tipo;

            if (error.Contains("Invalid character"))
            {
                tipo = "Error Lexico";
                string delimStr = ":";
                char[] delimitator = delimStr.ToCharArray();
                string[] division = error.Split(delimitator, 2);
                division = division[1].Split('.');
                error = $"Caracter inválido {division[0]}";
            }
            else
                tipo = "Error Sintáctico";

            return tipo;
        }
    }
}

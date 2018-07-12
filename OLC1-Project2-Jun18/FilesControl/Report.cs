using System;
using System.Collections.Generic;
using System.IO;
using OLC1_Project2_Jun18.LanguageGrammar;

namespace OLC1_Project2_Jun18.FilesControl
{
    class Report
    {
        internal void ErrorReport(List<BuildError> listError)
        {
            string html = "";

            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;

            html += $"<!DOCTYPE html>\r\n" +
                $"<html lang=\"es\">\r\n" +
                $"<head>\r\n" +
                $"\t<meta charset=\"UTF-8\">\r\n" +
                $"\t<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n" +
                $"\t<meta http-equiv=\"X-UA-Compatible\" content=>\r\n" +
                $"\t<link rel=\"stylesheet\" href=\"estiloReporte.css\">\r\n" +
                $"\t<title>Repoertes</title>\r\n" +
                $"</head>\r\n" +
                $"<body>\r\n" +
                $"\t<h1>Tabla de errores encontrados</h1>\r\n" +
                $"\t<div class=\"hora\">\r\n" +
                $"\t\t<p>{day}</p>\r\n" +
                $"\t\t<p> - </p>\r\n" +
                $"\t\t<p>{month}</p>\r\n" +
                $"\t\t<p> - </p>\r\n" +
                $"\t\t<p>{year}</p>\r\n" +
                $"\t</div>\r\n" +
                $"\t<div class=\"fecha\">\r\n" +
                $"\t\t<p>{hour}</p>\r\n" +
                $"\t\t<p> : </p>\r\n" +
                $"\t\t<p>{minute}</p>\r\n" +
                $"\t\t<p> : </p>\r\n" +
                $"\t\t<p>{second}</p>\r\n" +
                $"\t</div>\r\n" +
                $"\t<div class=\"reporte\">\r\n" +
                $"\t\t<table class=\"tabla\">\r\n" +
                $"\t\t\t<tr>\r\n" +
                $"\t\t\t\t<th>Tipo</th>\r\n" +
                $"\t\t\t\t<th>Error</th>\r\n" +
                $"\t\t\t\t<th>Columna</th>\r\n" +
                $"\t\t\t\t<th>Fila</th>\r\n" +
                $"\t\t\t</tr>\r\n";

            foreach (BuildError item in listError)
            {
                html += $"\t\t\t<tr>\r\n" +
                        $"\t\t\t\t<td>{item.Type}</td>\r\n" +
                        $"\t\t\t\t<td>{item.ErrorStr}</td>\r\n" +
                        $"\t\t\t\t<td>{item.Column}</td>\r\n" +
                        $"\t\t\t\t<td>{item.Row}</td>\r\n" +
                        $"\t\t\t</tr>\r\n";
            }

            html += "\t\t</table>\r\n" +
                    "\t</div>\r\n" +
                    "</body>\r\n" +
                    "</html>\r\n";

            StreamWriter writer = new StreamWriter("report.html");
            writer.Write(html);
            writer.Close();
        }
    }
}

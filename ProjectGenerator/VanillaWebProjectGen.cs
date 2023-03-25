using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;
using System.IO;
using System.Diagnostics.Metrics;

namespace ProjectGenerator
{
    internal class VanillaWebProjectGen
    {
        readonly private static string documents = GetFolderPath(SpecialFolder.MyDocuments);
        readonly private static string assetsFolderName = "assets";
        readonly private static string jsFolderName = "js";
        readonly private static string cssFolderName = "css";
        readonly private static string resetCSSFileName = "reset.css";
        readonly private static string mainHTMLFile = "index.html";


        public static string folderFileGen(string projectName)
        {
            string projectFolder = Path.Combine(documents, "Repos", projectName);
            string assetsSubFolder = Path.Combine(documents, "Repos", projectName, assetsFolderName); ;
            string jsSubFolder = Path.Combine(documents, "Repos", projectName, jsFolderName); ;
            string cssSubFolder = Path.Combine(documents, "Repos", projectName, cssFolderName);

            Directory.CreateDirectory(projectFolder);
            Directory.CreateDirectory(assetsSubFolder);
            Directory.CreateDirectory(jsSubFolder);
            Directory.CreateDirectory(cssSubFolder);


            File.WriteAllText($"{jsSubFolder}{Path.DirectorySeparatorChar}{projectName}.js", "");
            File.WriteAllText($"{cssSubFolder}{Path.DirectorySeparatorChar}{resetCSSFileName}", resetCssBoilerplate());
            File.WriteAllText($"{cssSubFolder}{Path.DirectorySeparatorChar}{projectName}.css", "");
            File.WriteAllText($"{projectFolder}{Path.DirectorySeparatorChar}{mainHTMLFile}", htmlBoilerplate(projectName));

            Console.WriteLine($"Directory '{projectName}' created at: {projectFolder}");

            return projectFolder;
        }

        private static string htmlBoilerplate(string projectName)
        {
            string html = $@"<!DOCTYPE html>
<html lang=""en"">
    <head>
        <meta charset=""UTF-8"">
        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
        <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
        <title>{projectName}</title>
        <link rel='stylesheet' href='css/reset.css'>
        <link rel='stylesheet' href='css/{projectName}.css'>
        <script src='js/{projectName}.js' defer></script>
    </head>
    <body>
	
    </body>
</html>";

            return html;
        }

        private static string resetCssBoilerplate()
        {
            string css = $@"/* Box sizing rules */
*,
*::before,
*::after {{
    box-sizing: border-box;
}}

/* Remove default margin */
body,
h1,
h2,
h3,
h4,
p,
figure,
blockquote,
dl,
dd {{
    margin: 0;
}}

/* Remove list styles on ul, ol elements with a list role, which suggests default styling will be removed */
ul[role='list'],
ol[role='list'] {{
    list-style: none;
}}

/* Set core root defaults */
html:focus-within {{
    scroll-behavior: smooth;
}}

/* Set core body defaults */
body {{
    min-height: 100vh;
    text-rendering: optimizeSpeed;
    line-height: 1.5;
}}

/* A elements that don't have a class get default styles */
a:not([class]) {{
    text-decoration-skip-ink: auto;
    text-decoration: none;
}}

/* Make images easier to work with */
img,
picture {{
    max-width: 100%;
    display: block;
}}

/* Inherit fonts for inputs and buttons */
input,
button,
textarea,
select {{
    font: inherit;
}}";

            return css;
        }
    }
}

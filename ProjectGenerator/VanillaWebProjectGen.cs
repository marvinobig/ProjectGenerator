using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;
using System.IO;

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


        public static string folderFileGen(string projectName) { 
            string projectFolder = Path.Combine(documents,"Repos", projectName);
            string assetsSubFolder = Path.Combine(documents, "Repos", projectName, assetsFolderName); ;
            string jsSubFolder = Path.Combine(documents, "Repos", projectName, jsFolderName); ;
            string cssSubFolder = Path.Combine(documents, "Repos", projectName, cssFolderName); ;

            Directory.CreateDirectory(projectFolder);
            Directory.CreateDirectory(assetsSubFolder);
            Directory.CreateDirectory(jsSubFolder);
            Directory.CreateDirectory(cssSubFolder);

            File.WriteAllText($"{jsSubFolder}{Path.DirectorySeparatorChar}{projectName}.js", "");
            File.WriteAllText($"{cssSubFolder}{Path.DirectorySeparatorChar}{resetCSSFileName}","");
            File.WriteAllText($"{cssSubFolder}{Path.DirectorySeparatorChar}{projectName}.css", "");
            File.WriteAllText($"{projectFolder}{Path.DirectorySeparatorChar}{mainHTMLFile}","");

            Console.WriteLine($"Directory '{projectName}' created at: {projectFolder}");

            return projectFolder;
        }
    }
}

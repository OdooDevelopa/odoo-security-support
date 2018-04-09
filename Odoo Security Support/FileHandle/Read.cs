using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System;

namespace Odoo_Security_Support.FileHandle
{
    class Read
    {
        public static List<string> GetAccess(string folderPath)
        {
            var Files = GetListFile(folderPath, "ir.model.access.csv");
            var Access = new List<string>();
            if (Files.Count != 1) return null;
            else foreach (var file in Files)
                Access = File.ReadAllLines(file).ToList();
            return Access;
        }

        public static List<string> GetGroupId(string folderPath, string contain = "")
        {
            var Files = GetListFile(folderPath, "*.xml");
            var Groups = new List<string>();

            foreach (var file in Files)
            {
                var doc = XDocument.Load(file);
                var Records = doc.Descendants("record");
                foreach (var record in Records)
                {
                    var recordModel = record.Attribute("model").Value;
                    if (recordModel == "res.groups")
                    {
                        var recordId = record.Attribute("id").Value;
                        Groups.Add(recordId);
                    }
                }
            }

            return Groups;
        }
        
        public static List<string> GetModelName(string folderPath, string contain="")
        {
            var Files = GetListFile(folderPath); 
            var Models = new List<string>(); 

            foreach (var file in Files)
            {
                var Lines = File.ReadAllLines(file);
                foreach (var line in Lines)
                {
                    var thisLineIsModel = line.Contains("    _name") 
                                        && !line.Contains("_rec_name")
                                        && !line.Contains("#")
                                        && line.Contains("=")
                                        && (line.Contains("\"") || line.Contains("'"))
                                        && line.Contains(contain);
                    
                    if (thisLineIsModel)
                    {
                        var lineTrim = line.Trim();
                        lineTrim = lineTrim.Replace("\"", "'");
                        var start = lineTrim.IndexOf("'") + 1;
                        var length = lineTrim.LastIndexOf("'") - start;
                        var modelName = lineTrim.Substring(start, length);
                        Models.Add(modelName);
                    }
                }
            }
            return Models.Distinct().ToList();
        }

        private static List<string> GetListFile(string folderPath, string format="*.py")
        {
            var lstFile = new List<string>();
            FindFile(lstFile, folderPath, format);
            return lstFile;
        }

        private static void FindFile(List<string> lstFile, string folderPath, string format)
        {
            var Files = Directory.EnumerateFiles(folderPath, format);
            foreach (var file in Files)
                lstFile.Add(file);

            var Folders = Directory.GetDirectories(folderPath);
            foreach (var folder in Folders)
                FindFile(lstFile, folder, format);
        }
    }
}

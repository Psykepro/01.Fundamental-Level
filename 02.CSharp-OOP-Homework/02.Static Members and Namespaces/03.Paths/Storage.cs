using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using _01.Point3D;

namespace Path
{
    class Storage
    {
        public static void SavePath(string pathAndName, Path3D path)
        {
            string json = JsonConvert.SerializeObject(path);

            StreamWriter writer = new StreamWriter(pathAndName, false, Encoding.GetEncoding("Windows-1251"));
            using (writer)
            {
                writer.WriteLine(json);
            }
        }

        public static Path3D LoadPath(string filepath)
        {
            Point3D pointForAdd;
            int x;
            int y;
            int z;
            string pattern = @"""X"":([-]*\d+).*?""Y"":([-]*\d+).*?""Z"":([-]*\d+)";
            StreamReader reader = new StreamReader(filepath);
            Path3D formLoaded = new Path3D();
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {

                    MatchCollection matchXYZ = Regex.Matches(line, pattern);
                    for (int i = 0; i < matchXYZ.Count; i++)
                    {
                                        
                        x = int.Parse(matchXYZ[i].Groups[1].Value);
                        y = int.Parse(matchXYZ[i].Groups[2].Value);
                        z = int.Parse(matchXYZ[i].Groups[3].Value);
                        pointForAdd = new Point3D(x, y, z);
                        formLoaded.AddPoints(pointForAdd);                                              
                   
                    }
                    break;
                    

                }
            }
            return formLoaded;
        }
    }
}

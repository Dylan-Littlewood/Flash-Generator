
using System.Diagnostics;

namespace FlashGenerator
{
    internal class Utils
    {
        public static bool CheckDirectoryContains(DirectoryInfo source, DirectoryInfo target)
        {
            if (source.FullName.ToLower() == target.FullName.ToLower())
            {
                return true;
            }

            // Check if the target directory exists, if not, create it.
            if (!Directory.Exists(target.FullName))
            {
                return false;
            }

            bool filesMatch = true;

            // Copy each file into it's new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                if(!File.Exists(Path.Combine(target.FullName, fi.Name)))
                {
                    filesMatch = false;
                }
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir = new DirectoryInfo(Path.Combine(target.FullName, diSourceSubDir.Name));
                if(!CheckDirectoryContains(diSourceSubDir, nextTargetSubDir))
                {
                    filesMatch = false;
                }
            }
            return filesMatch;
        }
        public static void CopyDirectory(DirectoryInfo source, DirectoryInfo target)
        {
            if (source.FullName.ToLower() == target.FullName.ToLower())
            {
                return;
            }

            // Check if the target directory exists, if not, create it.
            if (Directory.Exists(target.FullName) == false)
            {
                Directory.CreateDirectory(target.FullName);
            }

            // Copy each file into it's new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                CopyFile(fi, target);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                CopyDirectory(diSourceSubDir, nextTargetSubDir);
            }
        }

        public static void CopyFile(FileInfo source, DirectoryInfo target) {

            // Check if the target directory exists, if not, create it.
            if (Directory.Exists(target.FullName) == false)
            {
                Directory.CreateDirectory(target.FullName);
            }

            if (File.Exists(target.FullName + "//" + source.Name) == true)
            {
                return;
            }

            Debug.WriteLine(@"Copying {0}\{1}", target.FullName, source.Name);
            source.CopyTo(Path.Combine(target.ToString(), source.Name), true);
        }

        public static void CreateBatchFile(string docPath, string flashFileName)
        {
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "GetFlashFileName.bat")))
            {
                outputFile.WriteLine("set FlashFileName=" + flashFileName);
            }
        }

        public static void UpdateBatchFile(string docPath, string flashFileName, int linePos = 0)
        {

            List<string> lines = new List<string>();

            using (StreamReader sr = new StreamReader(Path.Combine(docPath, "Update.bat")))
            {
                string? line;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    if(lines.Count == linePos)
                    {
                        lines.Add("set FlashFileName=" + flashFileName);
                    }
                    lines.Add(line);
                }
            }

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Update.bat")))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }
        }

        public static void Error(string message)
        {
            Debug.WriteLine(message);
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool Warning(string message)
        {
            DialogResult result = MessageBox.Show(message, "Are You Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return result == DialogResult.Yes;
        }

        public static bool Question(string message, string title, MessageBoxIcon icon = MessageBoxIcon.None)
        {
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, icon);
            return result == DialogResult.Yes;
        }
    }
}

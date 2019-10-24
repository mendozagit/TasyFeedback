using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using TasyFeedback.Models;

namespace TasyFeedback.Controllers
{
    public static class Ambiente
    {


        public static void CreateDatabaseIfNotExist()
        {
            using (var db = new TasyFbContext())
            {
                db.Database.EnsureCreated();
            }
        }
        public static string TextTime() {
            return DateTime.Now.ToString("ddMMyyyhhmmss");
        }
        public static bool CopiarFile(string sourceFile, string destFile, bool remplazar = true)
        {

            try
            {
                File.Copy(sourceFile, destFile, remplazar);
                return true;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }

            return false;
        }

        public static bool BorrarFile(string RutaArchivo)
        {

            // Delete a file by using File class static method...
            if (File.Exists(@RutaArchivo))
            {
                // Use a try block to catch IOExceptions, to
                // handle the case of the file already being
                // opened by another process.
                try
                {
                    File.Delete(@RutaArchivo);
                    return true;
                }
                catch (IOException e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
            return false;
        }
        public static bool VaciarDirectorio(string RutaDirectorio)
        {
            // Delete a directory and all subdirectories with Directory static method...
            if (Directory.Exists(@RutaDirectorio))
            {
                try
                {
                    foreach (var f in GetDirectoryFiles(RutaDirectorio))
                    {
                        File.Delete(RutaDirectorio + f);
                    }
                }
                catch (IOException e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return false;
        }
        public static bool CrearDirectorio(string RutaDirectorio)
        {

            //Create a new target folder.
            // If the directory already exists, this method does not create a new directory

            try
            {
                Directory.CreateDirectory(@RutaDirectorio);
                return true;
            }

            catch (IOException e)
            {
                MessageBox.Show(e.Message);
            }

            return false;
        }
        public static List<string> GetDirectoryFiles(string directorio)
        {
            List<string> filesList = new List<string>();
            DirectoryInfo d = new DirectoryInfo(@directorio);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.zip"); //Getting Text files

            foreach (FileInfo file in Files)
            {
                filesList.Add(file.Name);
            }
            return filesList;

        }

        public static bool MoverFile(string sourceFile, string NewNameDestFile)
        {

            try
            {
                File.Move(sourceFile, NewNameDestFile);
                return true;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }

            return false;
        }
        public static string GetFolderPath()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = @"C:\";

            using (dialog)
            {
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                    return dialog.SelectedPath + @"\";
                else
                    return "";
            }
        }
        public static Tuple<string, string> GetFilePath()
        {
            try
            {
                var filePath = string.Empty;
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "All files (*.*)|*.*";
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        filePath = openFileDialog.FileName;
                        if (filePath.Length == 0 || openFileDialog.SafeFileName.Length == 0)
                            return new Tuple<string, string>("", "");

                        return new Tuple<string, string>(filePath, openFileDialog.SafeFileName);
                    }
                }
                return new Tuple<string, string>("", "");
            }
            catch (Exception)
            {
                return new Tuple<string, string>("", "");
            }
        }
    }
}

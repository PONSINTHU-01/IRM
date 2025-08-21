class Program
{
    static void Main()
    {
        string folderPath = @"C:\TestFolder";

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Console.WriteLine("Folder created successfully!");
        }
        else
        {
            Console.WriteLine("Folder already exists.");
        }

        //if (Directory.Exists(folderPath))
        //{
        //    Directory.Delete(folderPath, true);
        //    Console.WriteLine("Folder deleted.");
        //}
        //else
        //{
        //    Console.WriteLine("No such folder found.");
        //}


        if (Directory.Exists(folderPath))
        {
            string[] files = Directory.GetFiles(folderPath);

            Console.WriteLine("Files in " + folderPath + ":");
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }

        //if (Directory.Exists(folderPath))
        //{
        //    string[] subDirs = Directory.GetDirectories(folderPath);

        //    Console.WriteLine("Subfolders in " + folderPath + ":");
        //    foreach (string dir in subDirs)
        //    {
        //        Console.WriteLine(dir);
        //    }
        //}
        //string sourcePath = @"C:\TestFolder";
        //string destinationPath = @"C:\NewTestFolder";

        //if (Directory.Exists(sourcePath))
        //{
        //    Directory.Move(sourcePath, destinationPath);
        //    Console.WriteLine("Folder moved/renamed successfully.");
        //}
    }
}

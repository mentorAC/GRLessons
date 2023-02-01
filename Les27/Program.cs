using System.Text;

namespace Les27
{
    class GameConfig
    {
        public int Score { get; set; }
        public string Player { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Writer-Reader

            //StreamReader

            //StreamWriter
            //StreamWriter(string path)
            //StreamWriter(string path, bool append)
            //string filename = "my_file.txt";

            #region Writer

            //using (var sw = new StreamWriter(filename, false, Encoding.Default))
            //{
            //    sw.WriteLine("Hi!");
            //    sw.WriteLine("51");
            //    sw.Write(new string('@', 50));
            //}

            //using (var sw = new StreamWriter(filename, true))
            //{
            //    //Flush
            //    sw.WriteLine();
            //    sw.WriteLine("5.21");
            //    sw.Write(new string('#', 10));
            //}
            #endregion

            #region Reader

            //StreamReader(path)
            //StreamReader(path, System.Text.Encoding encoding)

            //using (var sr = new StreamReader(filename, Encoding.Default))
            //{
            //    var text = sr.ReadToEnd();
            //    //var text = sr.ReadLine();
            //    //text = sr.ReadLine();
            //    //Console.WriteLine(text);
            //    ///////////////////////////////////
            //    //string? text;

            //    //while ((text = sr.ReadLine()) != null)
            //    //{
            //    //    Console.WriteLine(text);
            //    //}
            //    ///////////////////////////////////
            //    //int char_;
            //    //while ((char_ = sr.Peek()) != -1)
            //    //{
            //    //    Console.Write(char_);
            //    //}


            //}

            #endregion

            #endregion

            string path = "file.dat";
            string game_path = "game.dat";

            GameConfig game = new GameConfig()
            {
                Score = 51,
                Player = "Max"
            };

            //BinaryWriter()
            using (var bw = new BinaryWriter(File.Open(game_path, FileMode.OpenOrCreate),Encoding.UTF8))
            {
                //bw.Write("Hello binary file!");
                //bw.Write(100);

                bw.Write(game.Score);
                bw.Write("game.Player");
            }

            using (var br = new BinaryReader(File.Open(game_path, FileMode.Open), Encoding.UTF8))
            {
                int score  = br.ReadInt32();
                Console.WriteLine(score);

                var size = br.ReadByte();
                Console.WriteLine(size);
                //string name = br.ReadString();
                //Console.WriteLine(name);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JpegLicker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("args[1]:%s", args[1]);
            string baseImagePath;

            //引数の数がおかしい時の処理
            //今は雑デバッグ向けに暫定対応
            if (args.Length != 2)
            {
                Console.Write("ファイルパスを入力してね");
                baseImagePath = Console.ReadLine();
            }

            //元ファイルを開いてDCT係数を引っこ抜く
            try
            {
                using (System.IO.FileStream baseImageStream = new System.IO.FileStream(baseImagePath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                {
                    //todo: ここにJPEGのDCT係数を引っこ抜く処理を書く
                }
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("何かおかしいです");
                throw;
            }
            catch(System.Security.SecurityException ex)
            {
                Console.WriteLine("ファイルへのアクセス権がありません");
                throw;
            }
            catch(System.IO.IOException ex)
            {
                Console.WriteLine("ファイルにアクセスしようとしたらエラーを吐きました");
                throw;
            }

        }
    }
}

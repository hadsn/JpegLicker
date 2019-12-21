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
            string sourceImagePath = null;
            string destinationImagePath = null ;
            //引数の数がおかしい時の処理h
            //今は雑デバッグ向けに暫定対応
            if (args.Length != 2)
            {
                Console.Write("入力ファイルパスを入力してね");
                sourceImagePath = Console.ReadLine();
                Console.Write("出力ファイルパスを入力してね");
                destinationImagePath = Console.ReadLine();
            }
            /*else
            {
                sourceImagePath = args[1];
                destinationImagePath = args[2];
            }*/

            //元ファイルを開いてDCT係数を引っこ抜く
            try
            {
                using (System.IO.FileStream sourceImageStream = new System.IO.FileStream(sourceImagePath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    using (System.IO.FileStream destinationImageStream = new System.IO.FileStream(destinationImagePath, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write))
                {
                    //todo: ここにJPEGのDCT係数を引っこ抜く処理を書く
                    BitMiracle.LibJpeg.Classic.jpeg_decompress_struct sourceImageStruct = new BitMiracle.LibJpeg.Classic.jpeg_decompress_struct();
                    sourceImageStruct.jpeg_stdio_src(sourceImageStream);
                    sourceImageStruct.jpeg_read_header(true);

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

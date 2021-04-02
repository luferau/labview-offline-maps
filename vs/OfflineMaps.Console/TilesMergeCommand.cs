using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using ManyConsole;

namespace OfflineMaps.Console
{
    public class TilesMergeCommand : ConsoleCommand
    {
        private const int Success = 0;
        private const int Failure = 2;

        public string Source1 { get; set; }
        public string Source2 { get; set; }
        public string DestinationFolder { get; set; }

        private struct TileKey
        {
            private readonly int _x;
            private readonly int _y;
            private readonly int _zoom;

            public TileKey(int x, int y, int zoom)
            {
                _x = x;
                _y = y;
                _zoom = zoom;
            }

            // Equals and GetHashCode ommitted
            public override int GetHashCode()
            {
                unchecked // Overflow is fine, just wrap
                {
                    var hash = 17;
                    // Suitable nullity checks etc, of course :)
                    hash = hash * 23 + _x.GetHashCode();
                    hash = hash * 23 + _y.GetHashCode();
                    hash = hash * 23 + _zoom.GetHashCode();
                    return hash;
                }
            }

            public override bool Equals(object obj)
            {
                if (!(obj is TileKey))
                    return false;

                var key = (TileKey)obj;
                return key._x == _x && key._y == _y && key._zoom == _zoom;
            }
        }

        public TilesMergeCommand()
        {
            IsCommand("merge", "Merge map tile files.");
            HasRequiredOption("s1|source1=", "The full path to source 1 folder.", s1 => Source1 = s1);
            HasRequiredOption("s2|source2=", "The full path to source 2 folder.", s2 => Source2 = s2);
            HasRequiredOption("d|destination=", "The full path to destination folder.", d => DestinationFolder = d);
        }

        public override int Run(string[] remainingArguments)
        {
            try
            {
                #region Search for files in source folders

                var source1Files = Helper.GetFileList("*.*", Source1).ToArray();
                System.Console.WriteLine($"Source 1 {source1Files.Length} files found");

                /*
                var source2Files = Helper.GetFileList("*.*", Source2).ToArray();
                System.Console.WriteLine($"Source 2 {source2Files.Length} files found");
                */

                #endregion

                // z{zoom}\{x_div_1024}\x{x}\{y_div_1024}\y{y}
                var regexParts = new Regex(@"(\\)(x|y|z)(\d+)");
                var regexValue = new Regex(@"(\d+)");

                foreach (var filePath in source1Files)
                {
                    var parts = regexParts.Matches(filePath);
                    // var xPart = 
                }
                #region Read files

                var image1 = Image.FromFile(Source1);
                var image2 = Image.FromFile(Source2);

                #endregion

                #region Merge

                var target = new Bitmap(image1.Width, image2.Height, PixelFormat.Format32bppArgb);
                var graphics = Graphics.FromImage(target);

                graphics.CompositingMode = CompositingMode.SourceOver; // this is the default, but just to be clear

                graphics.DrawImage(image1, 0, 0);
                graphics.DrawImage(image2, 0, 0);

                #endregion

                #region Save

                // Get an ImageCodecInfo object that represents the PNG codec.
                var codecInfo = GetEncoderInfo("image/jpeg");

                // for the Quality parameter category.
                var encoder = Encoder.Quality;

                // EncoderParameter object in the array.
                var encoderParameters = new EncoderParameters(1);

                var encoderParameter = new EncoderParameter(encoder, 100L);
                encoderParameters.Param[0] = encoderParameter;

                var targetFileName = Path.ChangeExtension(Path.GetFileName(Source2), "jpg");
                var targetFilePath = Path.Combine(DestinationFolder, targetFileName);

                target.Save(targetFilePath, codecInfo, encoderParameters);

                #endregion

                System.Console.WriteLine("\nMerging completed.");

                return Success;
            }
            catch (Exception ex)
            {
                System.Console.Error.WriteLine(ex.Message);
                System.Console.Error.WriteLine(ex.StackTrace);

                return Failure;
            }
        }

        private static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            int j;
            var encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }
    }
}

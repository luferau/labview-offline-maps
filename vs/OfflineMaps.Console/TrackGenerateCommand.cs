using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using ManyConsole;
using Newtonsoft.Json;
using OfflineMaps.Core;

namespace OfflineMaps.Console
{
    public class TrackGenerateCommand : ConsoleCommand
    {
        private const int Success = 0;
        private const int Failure = 2;

        public string CoordinatesFilePath;
        public string TrackFileName;

        public TrackGenerateCommand()
        {
            IsCommand("trackgen", "Track generate with PointData's based on coordinates file");
            HasRequiredOption("c|coordinates=", "Full path to file with coordinates in format: caption,longitude,latitude,altitude", c => CoordinatesFilePath = c);
            HasRequiredOption("t|track=", "Track file name", t => TrackFileName = t);
        }

        public override int Run(string[] remainingArguments)
        {
            try
            {
                var coordinates = File.ReadAllLines(CoordinatesFilePath);

                var points = new List<PointData>();

                var rnd = new Random();

                foreach (var coordinate in coordinates)
                {
                    var parts = coordinate.Split(',');

                    var point = new PointData
                    {
                        Caption = parts[0],
                        Latitude_deg = double.Parse(parts[1], CultureInfo.InvariantCulture),
                        Longitude_deg = double.Parse(parts[2], CultureInfo.InvariantCulture),
                        Altitude_m = 100 + rnd.Next(200),
                        Speed_m_s = 60 + rnd.Next(10),
                        Temperature_C = 25 + rnd.Next(100) / 10.0,
                    };

                    points.Add(point);
                }

                var folder = Path.GetDirectoryName(CoordinatesFilePath);
                var pointsFilePath = Path.Combine(folder, TrackFileName);

                var jsonString = JsonConvert.SerializeObject(points, Formatting.Indented);
                File.WriteAllText(pointsFilePath, jsonString);

                System.Console.WriteLine("\nTrack file generated.");

                return Success;
            }
            catch (Exception ex)
            {
                System.Console.Error.WriteLine(ex.Message);
                System.Console.Error.WriteLine(ex.StackTrace);

                return Failure;
            }
        }
    }
}

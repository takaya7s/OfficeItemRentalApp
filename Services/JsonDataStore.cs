using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using OfficeItemRentalApp.Models;

namespace OfficeItemRentalApp.Services
{
    internal sealed class JsonDataStore
    {
        private readonly JsonSerializerOptions options;
        private readonly string path;

        public JsonDataStore(string path)
        {
            this.path = path;
            options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            options.Converters.Add(new JsonStringEnumConverter());
        }

        public RentalDatabase Load()
        {
            if (!File.Exists(path))
            {
                return new RentalDatabase();
            }

            try
            {
                var json = File.ReadAllText(path, Encoding.UTF8);
                var database = JsonSerializer.Deserialize<RentalDatabase>(json, options);
                return database ?? new RentalDatabase();
            }
            catch (JsonException ex)
            {
                throw new InvalidOperationException(
                    string.Format("データファイルの読み込みに失敗しました: {0} ({1})", path, ex.Message),
                    ex);
            }
        }

        public void Save(RentalDatabase database)
        {
            var directory = Path.GetDirectoryName(path);
            if (!string.IsNullOrWhiteSpace(directory))
            {
                Directory.CreateDirectory(directory);
            }

            var json = JsonSerializer.Serialize(database, options);
            File.WriteAllText(path, json, Encoding.UTF8);
        }
    }
}

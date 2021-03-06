﻿using System;
using System.IO;
using System.Text;
using System.Text.Json;

namespace SystemTextJsonSamples
{
    public class Utf8WriterToStream
    {
        public static void Run()
        {
            // <SnippetSerialize>
            var options = new JsonWriterOptions
            {
                Indented = true
            };

            using (var stream = new MemoryStream())
            {
                using (var writer = new Utf8JsonWriter(stream, options))
                {
                    writer.WriteStartObject();
                    writer.WriteString("date", DateTimeOffset.UtcNow);
                    writer.WriteNumber("temp", 42);
                    writer.WriteEndObject();
                }

                string json = Encoding.UTF8.GetString(stream.ToArray());
                Console.WriteLine(json);
            }
            // </SnippetSerialize>
            Console.WriteLine();
        }
    }
}

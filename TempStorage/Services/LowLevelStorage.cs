namespace TempStorage.Services
{
    using System;
    using TempStorage.Models;

    public class LowLevelStorage : ILowLevelStorage
    {
        public readonly AWSSettings awsSettings;

        public LowLevelStorage(
            AWSSettings awsSettings)
        {
            this.awsSettings = awsSettings;
        }

        public string Get(string path)
        {
            Console.WriteLine(
                $"LLS: Get: Bucket: {this.awsSettings.Bucket}. Path: {path}.");

            return $"Content at {path}";
        }

        public void Put(string path, string content) =>
            Console.WriteLine(
                $"LLS: Put: Bucket: {this.awsSettings.Bucket}. Path: {path}. Content: {content}.");
    }
}
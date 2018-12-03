﻿using System;
using Mongo.Migration.Migrations;
using MongoDB.Bson;

namespace Mongo.Migration.Test.TestDoubles
{
    internal class TestDocumentWithAutoMigrate_0_0_1 : Migration<TestDocumentWithAutoMigrate>
    {
        public TestDocumentWithAutoMigrate_0_0_1() : base("0.0.1")
        {
        }

        public override void Up(BsonDocument document)
        {
            var doors = document["Dors"].ToInt32();
            document.Add("Doors", doors);
            document.Remove("Dors");
        }

        public override void Down(BsonDocument document)
        {
            var doors = document["Doors"].ToInt32();
            document.Add("Dors", doors);
            document.Remove("Doors");
        }
    }
}
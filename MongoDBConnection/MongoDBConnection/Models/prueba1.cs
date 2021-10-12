using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Serializers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBConnection.Models
{
    public class prueba1
    {
        public ObjectId id { get; set; }
        public int MMSI { get; set; }
        public DateTime BaseDateTime { get; set; }
        public double LAT { get; set; }
        public double LON { get; set; }

        [BsonSerializer(typeof(BsonStringNumericSerializer))]
        public string Status { get; set; }
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }
        public string Descripcion_Tipo_Viaje { get; set; }

    }

    public class BsonStringNumericSerializer : SerializerBase<string>
    {
        public override string Deserialize(BsonDeserializationContext context, BsonDeserializationArgs args)
        {
            var bsonType = context.Reader.CurrentBsonType;
            switch (bsonType)
            {
                case BsonType.Null:
                    context.Reader.ReadNull();
                    return null;
                case BsonType.String:
                    return context.Reader.ReadString();
                case BsonType.Int32:
                    return context.Reader.ReadInt32().ToString(CultureInfo.InvariantCulture);
                default:
                    var message = string.Format($"Custom Cannot deserialize BsonString or BsonInt32 from BsonType {bsonType}");
                    throw new BsonSerializationException(message);
            }
        }

        public override void Serialize(BsonSerializationContext context, BsonSerializationArgs args, string value)
        {
            if (value != null)
            {
                if (int.TryParse(value, out var result))
                {
                    context.Writer.WriteInt32(result);
                }
                else
                {
                    context.Writer.WriteString(value);
                }
            }
            else
            {
                context.Writer.WriteNull();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.Models
{
    // To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
    //
    //    using QuickType;
    //
    //    var saveProp = SaveProp.FromJson(jsonString);


    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class SaveProp
    {
        [JsonProperty("sessionID")]
        public string SessionId { get; set; }

        [JsonProperty("Component")]
        public string Component { get; set; }

        [JsonProperty("Operation")]
        public string Operation { get; set; }

        [JsonProperty("PV_TOPIC")]
        public string PvTopic { get; set; }

        [JsonProperty("PV_PROCESSID")]
        public string PvProcessid { get; set; }

        [JsonProperty("PV_LANGUAGE")]
        public string PvLanguage { get; set; }

        [JsonProperty("PV_PURPOSE")]
        public string PvPurpose { get; set; }

        [JsonProperty("PV_DATA_LIST")]
        public PvDataList[] PvDataList { get; set; }

        [JsonProperty("PV_EXTRA")]
        public PvExtra[] PvExtra { get; set; }
    }

    public partial class PvDataList
    {
        [JsonProperty("PROP")]
        public PvDataListProp[][] Prop { get; set; }
    }

    public partial class PurpleProp
    {
        [JsonProperty("FIELD", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        [JsonProperty("BEFORE", NullValueHandling = NullValueHandling.Ignore)]
        public string Before { get; set; }

        [JsonProperty("AFTER", NullValueHandling = NullValueHandling.Ignore)]
        public string After { get; set; }
    }

    public partial class FluffyProp
    {
        [JsonProperty("TLCRG_TREF", NullValueHandling = NullValueHandling.Ignore)]
        public string TlcrgTref { get; set; }

        [JsonProperty("TLCRG_LREF", NullValueHandling = NullValueHandling.Ignore)]
        public string TlcrgLref { get; set; }

        [JsonProperty("TLCRG_CTYPE", NullValueHandling = NullValueHandling.Ignore)]
        public string TlcrgCtype { get; set; }

        [JsonProperty("TLCRG_SEQ", NullValueHandling = NullValueHandling.Ignore)]
        public string TlcrgSeq { get; set; }
    }

    public partial class TentacledProp
    {
        [JsonProperty("STATE", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        [JsonProperty("CRC", NullValueHandling = NullValueHandling.Ignore)]
        public string Crc { get; set; }
    }

    public partial class PvExtra
    {
        [JsonProperty("COMMIT")]
        public string Commit { get; set; }
    }

    public partial struct PropPropUnion
    {
        public FluffyProp FluffyProp;
        public PurpleProp[] PurplePropArray;

        public static implicit operator PropPropUnion(FluffyProp FluffyProp) => new PropPropUnion { FluffyProp = FluffyProp };
        public static implicit operator PropPropUnion(PurpleProp[] PurplePropArray) => new PropPropUnion { PurplePropArray = PurplePropArray };
    }

    public partial struct PvDataListProp
    {
        public PropPropUnion[] AnythingArray;
        public TentacledProp TentacledProp;

        public static implicit operator PvDataListProp(PropPropUnion[] AnythingArray) => new PvDataListProp { AnythingArray = AnythingArray };
        public static implicit operator PvDataListProp(TentacledProp TentacledProp) => new PvDataListProp { TentacledProp = TentacledProp };
    }

   /* public partial class SaveProp
    {
        public static SaveProp FromJson(string json) => JsonConvert.DeserializeObject<SaveProp>(json, TestAPI.Models.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this SaveProp self) => JsonConvert.SerializeObject(self, TestAPI.Models.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                PvDataListPropConverter.Singleton,
                PropPropUnionConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class PvDataListPropConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PvDataListProp) || t == typeof(PvDataListProp?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<TentacledProp>(reader);
                    return new PvDataListProp { TentacledProp = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<PropPropUnion[]>(reader);
                    return new PvDataListProp { AnythingArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type PvDataListProp");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (PvDataListProp)untypedValue;
            if (value.AnythingArray != null)
            {
                serializer.Serialize(writer, value.AnythingArray);
                return;
            }
            if (value.TentacledProp != null)
            {
                serializer.Serialize(writer, value.TentacledProp);
                return;
            }
            throw new Exception("Cannot marshal type PvDataListProp");
        }

        public static readonly PvDataListPropConverter Singleton = new PvDataListPropConverter();
    }

    internal class PropPropUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PropPropUnion) || t == typeof(PropPropUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<FluffyProp>(reader);
                    return new PropPropUnion { FluffyProp = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<PurpleProp[]>(reader);
                    return new PropPropUnion { PurplePropArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type PropPropUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (PropPropUnion)untypedValue;
            if (value.PurplePropArray != null)
            {
                serializer.Serialize(writer, value.PurplePropArray);
                return;
            }
            if (value.FluffyProp != null)
            {
                serializer.Serialize(writer, value.FluffyProp);
                return;
            }
            throw new Exception("Cannot marshal type PropPropUnion");
        }

        public static readonly PropPropUnionConverter Singleton = new PropPropUnionConverter();
    }*/
}


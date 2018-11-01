// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.GrowingObject
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class PartsMetadata : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"PartsMetadata\",\"namespace\":\"Energistics.Etp.v12.Protocol" +
				".GrowingObject\",\"fields\":[{\"name\":\"uri\",\"type\":\"string\"},{\"name\":\"indexKind\",\"ty" +
				"pe\":{\"type\":\"enum\",\"name\":\"ChannelIndexKind\",\"namespace\":\"Energistics.Etp.v12.Da" +
				"tatypes.ChannelData\",\"symbols\":[\"Time\",\"Depth\"],\"fullName\":\"Energistics.Etp.v12." +
				"Datatypes.ChannelData.ChannelIndexKind\",\"depends\":[]}},{\"name\":\"indexDirection\"," +
				"\"type\":{\"type\":\"enum\",\"name\":\"IndexDirection\",\"namespace\":\"Energistics.Etp.v12.D" +
				"atatypes.ChannelData\",\"symbols\":[\"Increasing\",\"Decreasing\"],\"fullName\":\"Energist" +
				"ics.Etp.v12.Datatypes.ChannelData.IndexDirection\",\"depends\":[]}},{\"name\":\"name\"," +
				"\"type\":\"string\"},{\"name\":\"indexInterval\",\"type\":{\"type\":\"record\",\"name\":\"IndexIn" +
				"terval\",\"namespace\":\"Energistics.Etp.v12.Datatypes.Object\",\"fields\":[{\"name\":\"st" +
				"artIndex\",\"type\":{\"type\":\"record\",\"name\":\"IndexValue\",\"namespace\":\"Energistics.E" +
				"tp.v12.Datatypes\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"long\",\"double\"]}],\"fu" +
				"llName\":\"Energistics.Etp.v12.Datatypes.IndexValue\",\"depends\":[]}},{\"name\":\"endIn" +
				"dex\",\"type\":\"Energistics.Etp.v12.Datatypes.IndexValue\"},{\"name\":\"uom\",\"type\":\"st" +
				"ring\"},{\"name\":\"depthDatum\",\"default\":\"\",\"type\":\"string\"}],\"fullName\":\"Energisti" +
				"cs.Etp.v12.Datatypes.Object.IndexInterval\",\"depends\":[\r\n  \"Energistics.Etp.v12.D" +
				"atatypes.IndexValue\",\r\n  \"Energistics.Etp.v12.Datatypes.IndexValue\"\r\n]}},{\"name\"" +
				":\"uuid\",\"default\":\"\",\"type\":\"string\"},{\"name\":\"customData\",\"type\":{\"type\":\"map\"," +
				"\"values\":{\"type\":\"record\",\"name\":\"DataValue\",\"namespace\":\"Energistics.Etp.v12.Da" +
				"tatypes\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"boolean\",\"int\",\"long\",\"float\"," +
				"\"double\",\"string\",{\"type\":\"record\",\"name\":\"ArrayOfBoolean\",\"namespace\":\"Energist" +
				"ics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\"" +
				":\"boolean\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfBoolean\",\"depends" +
				"\":[]},{\"type\":\"record\",\"name\":\"ArrayOfInt\",\"namespace\":\"Energistics.Etp.v12.Data" +
				"types\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"int\"}}],\"fullN" +
				"ame\":\"Energistics.Etp.v12.Datatypes.ArrayOfInt\",\"depends\":[]},{\"type\":\"record\",\"" +
				"name\":\"ArrayOfLong\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name" +
				"\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"long\"}}],\"fullName\":\"Energistics.Etp." +
				"v12.Datatypes.ArrayOfLong\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfFloat\"," +
				"\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"" +
				"type\":\"array\",\"items\":\"float\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.Array" +
				"OfFloat\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfDouble\",\"namespace\":\"Ener" +
				"gistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"it" +
				"ems\":\"double\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\"depen" +
				"ds\":[]},{\"type\":\"record\",\"name\":\"ArrayOfString\",\"namespace\":\"Energistics.Etp.v12" +
				".Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"string\"}}" +
				"],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfString\",\"depends\":[]},\"bytes\"" +
				"]}],\"fullName\":\"Energistics.Etp.v12.Datatypes.DataValue\",\"depends\":[\r\n  \"Energis" +
				"tics.Etp.v12.Datatypes.ArrayOfBoolean\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayO" +
				"fInt\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\r\n  \"Energistics.Etp.v12.D" +
				"atatypes.ArrayOfFloat\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\r\n  \"En" +
				"ergistics.Etp.v12.Datatypes.ArrayOfString\"\r\n]}}}],\"protocol\":\"6\",\"messageType\":\"" +
				"9\",\"senderRole\":\"store\",\"protocolRoles\":\"store,customer\",\"multipartFlag\":true,\"f" +
				"ullName\":\"Energistics.Etp.v12.Protocol.GrowingObject.PartsMetadata\",\"depends\":[\r" +
				"\n  \"Energistics.Etp.v12.Datatypes.ChannelData.ChannelIndexKind\",\r\n  \"Energistics" +
				".Etp.v12.Datatypes.ChannelData.IndexDirection\",\r\n  \"Energistics.Etp.v12.Datatype" +
				"s.Object.IndexInterval\",\r\n  \"Energistics.Etp.v12.Datatypes.DataValue\"\r\n]}");
		private string _uri;
		private Energistics.Etp.v12.Datatypes.ChannelData.ChannelIndexKind _indexKind;
		private Energistics.Etp.v12.Datatypes.ChannelData.IndexDirection _indexDirection;
		private string _name;
		private Energistics.Etp.v12.Datatypes.Object.IndexInterval _indexInterval;
		private string _uuid;
		private IDictionary<string,Energistics.Etp.v12.Datatypes.DataValue> _customData;
		public virtual Schema Schema
		{
			get
			{
				return PartsMetadata._SCHEMA;
			}
		}
		public string Uri
		{
			get
			{
				return this._uri;
			}
			set
			{
				this._uri = value;
			}
		}
		public Energistics.Etp.v12.Datatypes.ChannelData.ChannelIndexKind IndexKind
		{
			get
			{
				return this._indexKind;
			}
			set
			{
				this._indexKind = value;
			}
		}
		public Energistics.Etp.v12.Datatypes.ChannelData.IndexDirection IndexDirection
		{
			get
			{
				return this._indexDirection;
			}
			set
			{
				this._indexDirection = value;
			}
		}
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public Energistics.Etp.v12.Datatypes.Object.IndexInterval IndexInterval
		{
			get
			{
				return this._indexInterval;
			}
			set
			{
				this._indexInterval = value;
			}
		}
		public string Uuid
		{
			get
			{
				return this._uuid;
			}
			set
			{
				this._uuid = value;
			}
		}
		public IDictionary<string,Energistics.Etp.v12.Datatypes.DataValue> CustomData
		{
			get
			{
				return this._customData;
			}
			set
			{
				this._customData = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._uri;
			case 1: return this._indexKind;
			case 2: return this._indexDirection;
			case 3: return this._name;
			case 4: return this._indexInterval;
			case 5: return this._uuid;
			case 6: return this._customData;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._uri = (System.String)fieldValue; break;
			case 1: this._indexKind = (Energistics.Etp.v12.Datatypes.ChannelData.ChannelIndexKind)fieldValue; break;
			case 2: this._indexDirection = (Energistics.Etp.v12.Datatypes.ChannelData.IndexDirection)fieldValue; break;
			case 3: this._name = (System.String)fieldValue; break;
			case 4: this._indexInterval = (Energistics.Etp.v12.Datatypes.Object.IndexInterval)fieldValue; break;
			case 5: this._uuid = (System.String)fieldValue; break;
			case 6: this._customData = (IDictionary<string,Energistics.Etp.v12.Datatypes.DataValue>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}

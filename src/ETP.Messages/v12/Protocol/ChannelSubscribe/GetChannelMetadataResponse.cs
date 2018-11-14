// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.ChannelSubscribe
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class GetChannelMetadataResponse : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"GetChannelMetadataResponse\",\"namespace\":\"Energistics.Etp" +
				".v12.Protocol.ChannelSubscribe\",\"fields\":[{\"name\":\"metadata\",\"type\":{\"type\":\"arr" +
				"ay\",\"items\":{\"type\":\"record\",\"name\":\"ChannelMetadataRecord\",\"namespace\":\"Energis" +
				"tics.Etp.v12.Datatypes.ChannelData\",\"fields\":[{\"name\":\"uri\",\"type\":\"string\"},{\"n" +
				"ame\":\"id\",\"type\":\"long\"},{\"name\":\"indexes\",\"type\":{\"type\":\"array\",\"items\":{\"type" +
				"\":\"record\",\"name\":\"IndexMetadataRecord\",\"namespace\":\"Energistics.Etp.v12.Datatyp" +
				"es.ChannelData\",\"fields\":[{\"name\":\"indexKind\",\"default\":\"Time\",\"type\":{\"type\":\"e" +
				"num\",\"name\":\"ChannelIndexKind\",\"namespace\":\"Energistics.Etp.v12.Datatypes.Channe" +
				"lData\",\"symbols\":[\"Time\",\"Depth\"],\"fullName\":\"Energistics.Etp.v12.Datatypes.Chan" +
				"nelData.ChannelIndexKind\",\"depends\":[]}},{\"name\":\"interval\",\"type\":{\"type\":\"reco" +
				"rd\",\"name\":\"IndexInterval\",\"namespace\":\"Energistics.Etp.v12.Datatypes.Object\",\"f" +
				"ields\":[{\"name\":\"startIndex\",\"type\":{\"type\":\"record\",\"name\":\"IndexValue\",\"namesp" +
				"ace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"lo" +
				"ng\",\"double\"]}],\"fullName\":\"Energistics.Etp.v12.Datatypes.IndexValue\",\"depends\":" +
				"[]}},{\"name\":\"endIndex\",\"type\":\"Energistics.Etp.v12.Datatypes.IndexValue\"},{\"nam" +
				"e\":\"uom\",\"type\":\"string\"},{\"name\":\"depthDatum\",\"default\":\"\",\"type\":\"string\"}],\"f" +
				"ullName\":\"Energistics.Etp.v12.Datatypes.Object.IndexInterval\",\"depends\":[\r\n  \"En" +
				"ergistics.Etp.v12.Datatypes.IndexValue\",\r\n  \"Energistics.Etp.v12.Datatypes.Index" +
				"Value\"\r\n]}},{\"name\":\"direction\",\"default\":\"Increasing\",\"type\":{\"type\":\"enum\",\"na" +
				"me\":\"IndexDirection\",\"namespace\":\"Energistics.Etp.v12.Datatypes.ChannelData\",\"sy" +
				"mbols\":[\"Increasing\",\"Decreasing\"],\"fullName\":\"Energistics.Etp.v12.Datatypes.Cha" +
				"nnelData.IndexDirection\",\"depends\":[]}},{\"name\":\"name\",\"default\":\"\",\"type\":\"stri" +
				"ng\"}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ChannelData.IndexMetadataRecord\"" +
				",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.ChannelData.ChannelIndexKind\",\r\n " +
				" \"Energistics.Etp.v12.Datatypes.Object.IndexInterval\",\r\n  \"Energistics.Etp.v12.D" +
				"atatypes.ChannelData.IndexDirection\"\r\n]}}},{\"name\":\"channelName\",\"type\":\"string\"" +
				"},{\"name\":\"dataType\",\"type\":\"string\"},{\"name\":\"uom\",\"type\":\"string\"},{\"name\":\"me" +
				"asureClass\",\"type\":\"string\"},{\"name\":\"status\",\"type\":{\"type\":\"enum\",\"name\":\"Chan" +
				"nelStatusKind\",\"namespace\":\"Energistics.Etp.v12.Datatypes.ChannelData\",\"symbols\"" +
				":[\"Active\",\"Inactive\",\"Closed\"],\"fullName\":\"Energistics.Etp.v12.Datatypes.Channe" +
				"lData.ChannelStatusKind\",\"depends\":[]}},{\"name\":\"source\",\"type\":\"string\"},{\"name" +
				"\":\"axisVectorLengths\",\"type\":{\"type\":\"array\",\"items\":\"int\"}},{\"name\":\"customData" +
				"\",\"type\":{\"type\":\"map\",\"values\":{\"type\":\"record\",\"name\":\"DataValue\",\"namespace\":" +
				"\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"boolean" +
				"\",\"int\",\"long\",\"float\",\"double\",\"string\",{\"type\":\"record\",\"name\":\"ArrayOfBoolean" +
				"\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":" +
				"{\"type\":\"array\",\"items\":\"boolean\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.A" +
				"rrayOfBoolean\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfInt\",\"namespace\":\"E" +
				"nergistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\"," +
				"\"items\":\"int\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfInt\",\"depends\"" +
				":[]},{\"type\":\"record\",\"name\":\"ArrayOfLong\",\"namespace\":\"Energistics.Etp.v12.Data" +
				"types\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"long\"}}],\"full" +
				"Name\":\"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\"depends\":[]},{\"type\":\"record\"" +
				",\"name\":\"ArrayOfFloat\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"n" +
				"ame\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"float\"}}],\"fullName\":\"Energistics." +
				"Etp.v12.Datatypes.ArrayOfFloat\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfDo" +
				"uble\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"ty" +
				"pe\":{\"type\":\"array\",\"items\":\"double\"}}],\"fullName\":\"Energistics.Etp.v12.Datatype" +
				"s.ArrayOfDouble\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfString\",\"namespac" +
				"e\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"ar" +
				"ray\",\"items\":\"string\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfString" +
				"\",\"depends\":[]},\"bytes\"]}],\"fullName\":\"Energistics.Etp.v12.Datatypes.DataValue\"," +
				"\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfBoolean\",\r\n  \"Energistics.E" +
				"tp.v12.Datatypes.ArrayOfInt\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\r\n " +
				" \"Energistics.Etp.v12.Datatypes.ArrayOfFloat\",\r\n  \"Energistics.Etp.v12.Datatypes" +
				".ArrayOfDouble\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfString\"\r\n]}}},{\"name\":" +
				"\"attributeMetadata\",\"default\":[],\"type\":{\"type\":\"array\",\"items\":{\"type\":\"record\"" +
				",\"name\":\"AttributeMetadataRecord\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"f" +
				"ields\":[{\"name\":\"attributeId\",\"type\":\"int\"},{\"name\":\"attributeName\",\"type\":\"stri" +
				"ng\"},{\"name\":\"dataType\",\"type\":\"string\"},{\"name\":\"description\",\"type\":\"string\"}]" +
				",\"fullName\":\"Energistics.Etp.v12.Datatypes.AttributeMetadataRecord\",\"depends\":[]" +
				"}}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ChannelData.ChannelMetadataRecord" +
				"\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.ChannelData.IndexMetadataRecord\"" +
				",\r\n  \"Energistics.Etp.v12.Datatypes.ChannelData.ChannelStatusKind\",\r\n  \"Energist" +
				"ics.Etp.v12.Datatypes.DataValue\",\r\n  \"Energistics.Etp.v12.Datatypes.AttributeMet" +
				"adataRecord\"\r\n]}}},{\"name\":\"errors\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"reco" +
				"rd\",\"name\":\"ErrorInfo\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"n" +
				"ame\":\"uri\",\"type\":\"string\"},{\"name\":\"message\",\"type\":\"string\"},{\"name\":\"code\",\"t" +
				"ype\":\"int\"}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ErrorInfo\",\"depends\":[]}}" +
				"}],\"protocol\":\"21\",\"messageType\":\"2\",\"senderRole\":\"producer\",\"protocolRoles\":\"pr" +
				"oducer,consumer\",\"multipartFlag\":true,\"fullName\":\"Energistics.Etp.v12.Protocol.C" +
				"hannelSubscribe.GetChannelMetadataResponse\",\"depends\":[\r\n  \"Energistics.Etp.v12." +
				"Datatypes.ChannelData.ChannelMetadataRecord\",\r\n  \"Energistics.Etp.v12.Datatypes." +
				"ErrorInfo\"\r\n]}");
		private IList<Energistics.Etp.v12.Datatypes.ChannelData.ChannelMetadataRecord> _metadata;
		private IList<Energistics.Etp.v12.Datatypes.ErrorInfo> _errors;
		public virtual Schema Schema
		{
			get
			{
				return GetChannelMetadataResponse._SCHEMA;
			}
		}
		public IList<Energistics.Etp.v12.Datatypes.ChannelData.ChannelMetadataRecord> Metadata
		{
			get
			{
				return this._metadata;
			}
			set
			{
				this._metadata = value;
			}
		}
		public IList<Energistics.Etp.v12.Datatypes.ErrorInfo> Errors
		{
			get
			{
				return this._errors;
			}
			set
			{
				this._errors = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._metadata;
			case 1: return this._errors;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._metadata = (IList<Energistics.Etp.v12.Datatypes.ChannelData.ChannelMetadataRecord>)fieldValue; break;
			case 1: this._errors = (IList<Energistics.Etp.v12.Datatypes.ErrorInfo>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
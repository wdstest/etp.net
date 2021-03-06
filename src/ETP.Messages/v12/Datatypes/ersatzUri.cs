// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Datatypes
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class ersatzUri : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"ersatzUri\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"" +
				"fields\":[{\"name\":\"dataspace\",\"default\":[],\"type\":{\"type\":\"array\",\"items\":{\"type\"" +
				":\"record\",\"name\":\"ArrayOfString\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fi" +
				"elds\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"string\"}}],\"fullName\":\"E" +
				"nergistics.Etp.v12.Datatypes.ArrayOfString\",\"depends\":[]}}},{\"name\":\"contentType" +
				"\",\"type\":{\"type\":\"record\",\"name\":\"ersatzContentType\",\"namespace\":\"Energistics.Et" +
				"p.v12.Datatypes\",\"fields\":[{\"name\":\"format\",\"default\":\"XML\",\"type\":\"string\"},{\"n" +
				"ame\":\"family\",\"type\":\"string\"},{\"name\":\"familyVersion\",\"type\":{\"type\":\"record\",\"" +
				"name\":\"Version\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"m" +
				"ajor\",\"default\":0,\"type\":\"int\"},{\"name\":\"minor\",\"default\":0,\"type\":\"int\"},{\"name" +
				"\":\"revision\",\"default\":0,\"type\":\"int\"},{\"name\":\"patch\",\"default\":0,\"type\":\"int\"}" +
				"],\"fullName\":\"Energistics.Etp.v12.Datatypes.Version\",\"depends\":[]}},{\"name\":\"obj" +
				"ectType\",\"type\":\"string\"}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ersatzConte" +
				"ntType\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.Version\"\r\n]}},{\"name\":\"uui" +
				"d\",\"type\":{\"type\":\"fixed\",\"name\":\"Uuid\",\"namespace\":\"Energistics.Etp.v12.Datatyp" +
				"es\",\"size\":16,\"fullName\":\"Energistics.Etp.v12.Datatypes.Uuid\",\"depends\":[]}},{\"n" +
				"ame\":\"objectVersion\",\"default\":\"\",\"type\":\"string\"},{\"name\":\"queryString\",\"defaul" +
				"t\":\"\",\"type\":\"string\"}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ersatzUri\",\"de" +
				"pends\":[\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfString\",\r\n  \"Energistics.Etp.v" +
				"12.Datatypes.ersatzContentType\",\r\n  \"Energistics.Etp.v12.Datatypes.Uuid\"\r\n]}");
		private IList<Energistics.Etp.v12.Datatypes.ArrayOfString> _dataspace;
		private Energistics.Etp.v12.Datatypes.ersatzContentType _contentType;
		private Energistics.Etp.v12.Datatypes.Uuid _uuid;
		private string _objectVersion;
		private string _queryString;
		public virtual Schema Schema
		{
			get
			{
				return ersatzUri._SCHEMA;
			}
		}
		public IList<Energistics.Etp.v12.Datatypes.ArrayOfString> Dataspace
		{
			get
			{
				return this._dataspace;
			}
			set
			{
				this._dataspace = value;
			}
		}
		public Energistics.Etp.v12.Datatypes.ersatzContentType ContentType
		{
			get
			{
				return this._contentType;
			}
			set
			{
				this._contentType = value;
			}
		}
		public Energistics.Etp.v12.Datatypes.Uuid Uuid
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
		public string ObjectVersion
		{
			get
			{
				return this._objectVersion;
			}
			set
			{
				this._objectVersion = value;
			}
		}
		public string QueryString
		{
			get
			{
				return this._queryString;
			}
			set
			{
				this._queryString = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._dataspace;
			case 1: return this._contentType;
			case 2: return this._uuid;
			case 3: return this._objectVersion;
			case 4: return this._queryString;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._dataspace = (IList<Energistics.Etp.v12.Datatypes.ArrayOfString>)fieldValue; break;
			case 1: this._contentType = (Energistics.Etp.v12.Datatypes.ersatzContentType)fieldValue; break;
			case 2: this._uuid = (Energistics.Etp.v12.Datatypes.Uuid)fieldValue; break;
			case 3: this._objectVersion = (System.String)fieldValue; break;
			case 4: this._queryString = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}

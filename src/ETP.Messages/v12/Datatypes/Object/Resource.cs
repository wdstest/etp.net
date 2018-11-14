// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Datatypes.Object
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class Resource : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""Resource"",""namespace"":""Energistics.Etp.v12.Datatypes.Object"",""fields"":[{""name"":""uri"",""type"":""string""},{""name"":""contentType"",""type"":""string""},{""name"":""name"",""type"":""string""},{""name"":""customData"",""type"":{""type"":""map"",""values"":""string""}},{""name"":""resourceType"",""type"":{""type"":""enum"",""name"":""ResourceKind"",""namespace"":""Energistics.Etp.v12.Datatypes.Object"",""symbols"":[""DataObject"",""Folder"",""UriProtocol"",""DataSpace""],""fullName"":""Energistics.Etp.v12.Datatypes.Object.ResourceKind"",""depends"":[]}},{""name"":""childCount"",""default"":null,""type"":[""null"",""int""]},{""name"":""lastChanged"",""type"":[""null"",""long""]},{""name"":""objectNotifiable"",""type"":""boolean""}],""fullName"":""Energistics.Etp.v12.Datatypes.Object.Resource"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.Object.ResourceKind""
]}");
		private string _uri;
		private string _contentType;
		private string _name;
		private IDictionary<string,System.String> _customData;
		private Energistics.Etp.v12.Datatypes.Object.ResourceKind _resourceType;
		private System.Nullable<int> _childCount;
		private System.Nullable<long> _lastChanged;
		private bool _objectNotifiable;
		public virtual Schema Schema
		{
			get
			{
				return Resource._SCHEMA;
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
		public string ContentType
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
		public IDictionary<string,System.String> CustomData
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
		public Energistics.Etp.v12.Datatypes.Object.ResourceKind ResourceType
		{
			get
			{
				return this._resourceType;
			}
			set
			{
				this._resourceType = value;
			}
		}
		public System.Nullable<int> ChildCount
		{
			get
			{
				return this._childCount;
			}
			set
			{
				this._childCount = value;
			}
		}
		public System.Nullable<long> LastChanged
		{
			get
			{
				return this._lastChanged;
			}
			set
			{
				this._lastChanged = value;
			}
		}
		public bool ObjectNotifiable
		{
			get
			{
				return this._objectNotifiable;
			}
			set
			{
				this._objectNotifiable = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._uri;
			case 1: return this._contentType;
			case 2: return this._name;
			case 3: return this._customData;
			case 4: return this._resourceType;
			case 5: return this._childCount;
			case 6: return this._lastChanged;
			case 7: return this._objectNotifiable;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._uri = (System.String)fieldValue; break;
			case 1: this._contentType = (System.String)fieldValue; break;
			case 2: this._name = (System.String)fieldValue; break;
			case 3: this._customData = (IDictionary<string,System.String>)fieldValue; break;
			case 4: this._resourceType = (Energistics.Etp.v12.Datatypes.Object.ResourceKind)fieldValue; break;
			case 5: this._childCount = (System.Nullable<int>)fieldValue; break;
			case 6: this._lastChanged = (System.Nullable<long>)fieldValue; break;
			case 7: this._objectNotifiable = (System.Boolean)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}

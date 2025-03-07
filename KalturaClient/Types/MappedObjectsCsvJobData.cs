// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2022  Kaltura Inc.
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
// @ignore
// ===================================================================================================
using System;
using System.Xml;
using System.Collections.Generic;
using Kaltura.Enums;
using Kaltura.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class MappedObjectsCsvJobData : ExportCsvJobData
	{
		#region Constants
		public const string METADATA_PROFILE_ID = "metadataProfileId";
		public const string ADDITIONAL_FIELDS = "additionalFields";
		public const string MAPPED_FIELDS = "mappedFields";
		public const string OPTIONS = "options";
		#endregion

		#region Private Fields
		private int _MetadataProfileId = Int32.MinValue;
		private IList<CsvAdditionalFieldInfo> _AdditionalFields;
		private IList<KeyValue> _MappedFields;
		private ExportToCsvOptions _Options;
		#endregion

		#region Properties
		/// <summary>
		/// Use MetadataProfileIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MetadataProfileId
		{
			get { return _MetadataProfileId; }
			set 
			{ 
				_MetadataProfileId = value;
				OnPropertyChanged("MetadataProfileId");
			}
		}
		/// <summary>
		/// Use AdditionalFieldsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<CsvAdditionalFieldInfo> AdditionalFields
		{
			get { return _AdditionalFields; }
			set 
			{ 
				_AdditionalFields = value;
				OnPropertyChanged("AdditionalFields");
			}
		}
		/// <summary>
		/// Use MappedFieldsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<KeyValue> MappedFields
		{
			get { return _MappedFields; }
			set 
			{ 
				_MappedFields = value;
				OnPropertyChanged("MappedFields");
			}
		}
		/// <summary>
		/// Use OptionsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ExportToCsvOptions Options
		{
			get { return _Options; }
			set 
			{ 
				_Options = value;
				OnPropertyChanged("Options");
			}
		}
		#endregion

		#region CTor
		public MappedObjectsCsvJobData()
		{
		}

		public MappedObjectsCsvJobData(JToken node) : base(node)
		{
			if(node["metadataProfileId"] != null)
			{
				this._MetadataProfileId = ParseInt(node["metadataProfileId"].Value<string>());
			}
			if(node["additionalFields"] != null)
			{
				this._AdditionalFields = new List<CsvAdditionalFieldInfo>();
				foreach(var arrayNode in node["additionalFields"].Children())
				{
					this._AdditionalFields.Add(ObjectFactory.Create<CsvAdditionalFieldInfo>(arrayNode));
				}
			}
			if(node["mappedFields"] != null)
			{
				this._MappedFields = new List<KeyValue>();
				foreach(var arrayNode in node["mappedFields"].Children())
				{
					this._MappedFields.Add(ObjectFactory.Create<KeyValue>(arrayNode));
				}
			}
			if(node["options"] != null)
			{
				this._Options = ObjectFactory.Create<ExportToCsvOptions>(node["options"]);
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaMappedObjectsCsvJobData");
			kparams.AddIfNotNull("metadataProfileId", this._MetadataProfileId);
			kparams.AddIfNotNull("additionalFields", this._AdditionalFields);
			kparams.AddIfNotNull("mappedFields", this._MappedFields);
			kparams.AddIfNotNull("options", this._Options);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case METADATA_PROFILE_ID:
					return "MetadataProfileId";
				case ADDITIONAL_FIELDS:
					return "AdditionalFields";
				case MAPPED_FIELDS:
					return "MappedFields";
				case OPTIONS:
					return "Options";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}


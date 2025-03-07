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
	public class ESearchMetadataItemData : ESearchItemData
	{
		#region Constants
		public const string XPATH = "xpath";
		public const string METADATA_PROFILE_ID = "metadataProfileId";
		public const string METADATA_FIELD_ID = "metadataFieldId";
		public const string VALUE_TEXT = "valueText";
		public const string VALUE_INT = "valueInt";
		#endregion

		#region Private Fields
		private string _Xpath = null;
		private int _MetadataProfileId = Int32.MinValue;
		private int _MetadataFieldId = Int32.MinValue;
		private string _ValueText = null;
		private int _ValueInt = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use XpathAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Xpath
		{
			get { return _Xpath; }
			set 
			{ 
				_Xpath = value;
				OnPropertyChanged("Xpath");
			}
		}
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
		/// Use MetadataFieldIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MetadataFieldId
		{
			get { return _MetadataFieldId; }
			set 
			{ 
				_MetadataFieldId = value;
				OnPropertyChanged("MetadataFieldId");
			}
		}
		/// <summary>
		/// Use ValueTextAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ValueText
		{
			get { return _ValueText; }
			set 
			{ 
				_ValueText = value;
				OnPropertyChanged("ValueText");
			}
		}
		/// <summary>
		/// Use ValueIntAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ValueInt
		{
			get { return _ValueInt; }
			set 
			{ 
				_ValueInt = value;
				OnPropertyChanged("ValueInt");
			}
		}
		#endregion

		#region CTor
		public ESearchMetadataItemData()
		{
		}

		public ESearchMetadataItemData(JToken node) : base(node)
		{
			if(node["xpath"] != null)
			{
				this._Xpath = node["xpath"].Value<string>();
			}
			if(node["metadataProfileId"] != null)
			{
				this._MetadataProfileId = ParseInt(node["metadataProfileId"].Value<string>());
			}
			if(node["metadataFieldId"] != null)
			{
				this._MetadataFieldId = ParseInt(node["metadataFieldId"].Value<string>());
			}
			if(node["valueText"] != null)
			{
				this._ValueText = node["valueText"].Value<string>();
			}
			if(node["valueInt"] != null)
			{
				this._ValueInt = ParseInt(node["valueInt"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaESearchMetadataItemData");
			kparams.AddIfNotNull("xpath", this._Xpath);
			kparams.AddIfNotNull("metadataProfileId", this._MetadataProfileId);
			kparams.AddIfNotNull("metadataFieldId", this._MetadataFieldId);
			kparams.AddIfNotNull("valueText", this._ValueText);
			kparams.AddIfNotNull("valueInt", this._ValueInt);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case XPATH:
					return "Xpath";
				case METADATA_PROFILE_ID:
					return "MetadataProfileId";
				case METADATA_FIELD_ID:
					return "MetadataFieldId";
				case VALUE_TEXT:
					return "ValueText";
				case VALUE_INT:
					return "ValueInt";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}


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
	public class ExecuteMetadataXsltObjectTask : ObjectTask
	{
		#region Constants
		public const string METADATA_PROFILE_ID = "metadataProfileId";
		public const string METADATA_OBJECT_TYPE = "metadataObjectType";
		public const string XSLT = "xslt";
		#endregion

		#region Private Fields
		private int _MetadataProfileId = Int32.MinValue;
		private MetadataObjectType _MetadataObjectType = null;
		private string _Xslt = null;
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
		/// Use MetadataObjectTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public MetadataObjectType MetadataObjectType
		{
			get { return _MetadataObjectType; }
			set 
			{ 
				_MetadataObjectType = value;
				OnPropertyChanged("MetadataObjectType");
			}
		}
		/// <summary>
		/// Use XsltAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Xslt
		{
			get { return _Xslt; }
			set 
			{ 
				_Xslt = value;
				OnPropertyChanged("Xslt");
			}
		}
		#endregion

		#region CTor
		public ExecuteMetadataXsltObjectTask()
		{
		}

		public ExecuteMetadataXsltObjectTask(JToken node) : base(node)
		{
			if(node["metadataProfileId"] != null)
			{
				this._MetadataProfileId = ParseInt(node["metadataProfileId"].Value<string>());
			}
			if(node["metadataObjectType"] != null)
			{
				this._MetadataObjectType = (MetadataObjectType)StringEnum.Parse(typeof(MetadataObjectType), node["metadataObjectType"].Value<string>());
			}
			if(node["xslt"] != null)
			{
				this._Xslt = node["xslt"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaExecuteMetadataXsltObjectTask");
			kparams.AddIfNotNull("metadataProfileId", this._MetadataProfileId);
			kparams.AddIfNotNull("metadataObjectType", this._MetadataObjectType);
			kparams.AddIfNotNull("xslt", this._Xslt);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case METADATA_PROFILE_ID:
					return "MetadataProfileId";
				case METADATA_OBJECT_TYPE:
					return "MetadataObjectType";
				case XSLT:
					return "Xslt";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}


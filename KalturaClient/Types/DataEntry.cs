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
	public class DataEntry : BaseEntry
	{
		#region Constants
		public const string DATA_CONTENT = "dataContent";
		public const string RETRIEVE_DATA_CONTENT_BY_GET = "retrieveDataContentByGet";
		#endregion

		#region Private Fields
		private string _DataContent = null;
		private bool? _RetrieveDataContentByGet = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use DataContentAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DataContent
		{
			get { return _DataContent; }
			set 
			{ 
				_DataContent = value;
				OnPropertyChanged("DataContent");
			}
		}
		/// <summary>
		/// Use RetrieveDataContentByGetAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? RetrieveDataContentByGet
		{
			get { return _RetrieveDataContentByGet; }
			set 
			{ 
				_RetrieveDataContentByGet = value;
				OnPropertyChanged("RetrieveDataContentByGet");
			}
		}
		#endregion

		#region CTor
		public DataEntry()
		{
		}

		public DataEntry(JToken node) : base(node)
		{
			if(node["dataContent"] != null)
			{
				this._DataContent = node["dataContent"].Value<string>();
			}
			if(node["retrieveDataContentByGet"] != null)
			{
				this._RetrieveDataContentByGet = ParseBool(node["retrieveDataContentByGet"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDataEntry");
			kparams.AddIfNotNull("dataContent", this._DataContent);
			kparams.AddIfNotNull("retrieveDataContentByGet", this._RetrieveDataContentByGet);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DATA_CONTENT:
					return "DataContent";
				case RETRIEVE_DATA_CONTENT_BY_GET:
					return "RetrieveDataContentByGet";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}


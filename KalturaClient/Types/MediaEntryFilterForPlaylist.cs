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
	public class MediaEntryFilterForPlaylist : MediaEntryFilter
	{
		#region Constants
		public const string LIMIT = "limit";
		public const string NAME = "name";
		#endregion

		#region Private Fields
		private int _Limit = Int32.MinValue;
		private string _Name = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use LimitAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Limit
		{
			get { return _Limit; }
			set 
			{ 
				_Limit = value;
				OnPropertyChanged("Limit");
			}
		}
		/// <summary>
		/// Use NameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		#endregion

		#region CTor
		public MediaEntryFilterForPlaylist()
		{
		}

		public MediaEntryFilterForPlaylist(JToken node) : base(node)
		{
			if(node["limit"] != null)
			{
				this._Limit = ParseInt(node["limit"].Value<string>());
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaMediaEntryFilterForPlaylist");
			kparams.AddIfNotNull("limit", this._Limit);
			kparams.AddIfNotNull("name", this._Name);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case LIMIT:
					return "Limit";
				case NAME:
					return "Name";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}


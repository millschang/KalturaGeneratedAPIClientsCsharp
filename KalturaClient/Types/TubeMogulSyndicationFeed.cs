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
	public class TubeMogulSyndicationFeed : BaseSyndicationFeed
	{
		#region Constants
		public const string CATEGORY = "category";
		#endregion

		#region Private Fields
		private TubeMogulSyndicationFeedCategories _Category = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use CategoryAsDouble property instead
		/// </summary>
		[JsonProperty]
		public TubeMogulSyndicationFeedCategories Category
		{
			get { return _Category; }
			private set 
			{ 
				_Category = value;
				OnPropertyChanged("Category");
			}
		}
		#endregion

		#region CTor
		public TubeMogulSyndicationFeed()
		{
		}

		public TubeMogulSyndicationFeed(JToken node) : base(node)
		{
			if(node["category"] != null)
			{
				this._Category = (TubeMogulSyndicationFeedCategories)StringEnum.Parse(typeof(TubeMogulSyndicationFeedCategories), node["category"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaTubeMogulSyndicationFeed");
			kparams.AddIfNotNull("category", this._Category);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CATEGORY:
					return "Category";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}


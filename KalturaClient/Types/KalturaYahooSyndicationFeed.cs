// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platfroms allow them to do with
// text.
//
// Copyright (C) 2006-2015  Kaltura Inc.
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

namespace Kaltura
{
	public class KalturaYahooSyndicationFeed : KalturaBaseSyndicationFeed
	{
		#region Private Fields
		private KalturaYahooSyndicationFeedCategories _Category = null;
		private KalturaYahooSyndicationFeedAdultValues _AdultContent = null;
		private string _FeedDescription = null;
		private string _FeedLandingPage = null;
		#endregion

		#region Properties
		public KalturaYahooSyndicationFeedCategories Category
		{
			get { return _Category; }
			set 
			{ 
				_Category = value;
				OnPropertyChanged("Category");
			}
		}
		public KalturaYahooSyndicationFeedAdultValues AdultContent
		{
			get { return _AdultContent; }
			set 
			{ 
				_AdultContent = value;
				OnPropertyChanged("AdultContent");
			}
		}
		public string FeedDescription
		{
			get { return _FeedDescription; }
			set 
			{ 
				_FeedDescription = value;
				OnPropertyChanged("FeedDescription");
			}
		}
		public string FeedLandingPage
		{
			get { return _FeedLandingPage; }
			set 
			{ 
				_FeedLandingPage = value;
				OnPropertyChanged("FeedLandingPage");
			}
		}
		#endregion

		#region CTor
		public KalturaYahooSyndicationFeed()
		{
		}

		public KalturaYahooSyndicationFeed(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "category":
						this.Category = (KalturaYahooSyndicationFeedCategories)KalturaStringEnum.Parse(typeof(KalturaYahooSyndicationFeedCategories), txt);
						continue;
					case "adultContent":
						this.AdultContent = (KalturaYahooSyndicationFeedAdultValues)KalturaStringEnum.Parse(typeof(KalturaYahooSyndicationFeedAdultValues), txt);
						continue;
					case "feedDescription":
						this.FeedDescription = txt;
						continue;
					case "feedLandingPage":
						this.FeedLandingPage = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaYahooSyndicationFeed");
			kparams.AddIfNotNull("category", this.Category);
			kparams.AddIfNotNull("adultContent", this.AdultContent);
			kparams.AddIfNotNull("feedDescription", this.FeedDescription);
			kparams.AddIfNotNull("feedLandingPage", this.FeedLandingPage);
			return kparams;
		}
		#endregion
	}
}


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
// Copyright (C) 2006-2016  Kaltura Inc.
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
	public class KalturaEntryScheduleEventBaseFilter : KalturaScheduleEventFilter
	{
		#region Private Fields
		private string _TemplateEntryIdEqual = null;
		private string _EntryIdsLike = null;
		private string _EntryIdsMultiLikeOr = null;
		private string _EntryIdsMultiLikeAnd = null;
		private string _CategoryIdsLike = null;
		private string _CategoryIdsMultiLikeOr = null;
		private string _CategoryIdsMultiLikeAnd = null;
		#endregion

		#region Properties
		public string TemplateEntryIdEqual
		{
			get { return _TemplateEntryIdEqual; }
			set 
			{ 
				_TemplateEntryIdEqual = value;
				OnPropertyChanged("TemplateEntryIdEqual");
			}
		}
		public string EntryIdsLike
		{
			get { return _EntryIdsLike; }
			set 
			{ 
				_EntryIdsLike = value;
				OnPropertyChanged("EntryIdsLike");
			}
		}
		public string EntryIdsMultiLikeOr
		{
			get { return _EntryIdsMultiLikeOr; }
			set 
			{ 
				_EntryIdsMultiLikeOr = value;
				OnPropertyChanged("EntryIdsMultiLikeOr");
			}
		}
		public string EntryIdsMultiLikeAnd
		{
			get { return _EntryIdsMultiLikeAnd; }
			set 
			{ 
				_EntryIdsMultiLikeAnd = value;
				OnPropertyChanged("EntryIdsMultiLikeAnd");
			}
		}
		public string CategoryIdsLike
		{
			get { return _CategoryIdsLike; }
			set 
			{ 
				_CategoryIdsLike = value;
				OnPropertyChanged("CategoryIdsLike");
			}
		}
		public string CategoryIdsMultiLikeOr
		{
			get { return _CategoryIdsMultiLikeOr; }
			set 
			{ 
				_CategoryIdsMultiLikeOr = value;
				OnPropertyChanged("CategoryIdsMultiLikeOr");
			}
		}
		public string CategoryIdsMultiLikeAnd
		{
			get { return _CategoryIdsMultiLikeAnd; }
			set 
			{ 
				_CategoryIdsMultiLikeAnd = value;
				OnPropertyChanged("CategoryIdsMultiLikeAnd");
			}
		}
		#endregion

		#region CTor
		public KalturaEntryScheduleEventBaseFilter()
		{
		}

		public KalturaEntryScheduleEventBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "templateEntryIdEqual":
						this._TemplateEntryIdEqual = txt;
						continue;
					case "entryIdsLike":
						this._EntryIdsLike = txt;
						continue;
					case "entryIdsMultiLikeOr":
						this._EntryIdsMultiLikeOr = txt;
						continue;
					case "entryIdsMultiLikeAnd":
						this._EntryIdsMultiLikeAnd = txt;
						continue;
					case "categoryIdsLike":
						this._CategoryIdsLike = txt;
						continue;
					case "categoryIdsMultiLikeOr":
						this._CategoryIdsMultiLikeOr = txt;
						continue;
					case "categoryIdsMultiLikeAnd":
						this._CategoryIdsMultiLikeAnd = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaEntryScheduleEventBaseFilter");
			kparams.AddIfNotNull("templateEntryIdEqual", this._TemplateEntryIdEqual);
			kparams.AddIfNotNull("entryIdsLike", this._EntryIdsLike);
			kparams.AddIfNotNull("entryIdsMultiLikeOr", this._EntryIdsMultiLikeOr);
			kparams.AddIfNotNull("entryIdsMultiLikeAnd", this._EntryIdsMultiLikeAnd);
			kparams.AddIfNotNull("categoryIdsLike", this._CategoryIdsLike);
			kparams.AddIfNotNull("categoryIdsMultiLikeOr", this._CategoryIdsMultiLikeOr);
			kparams.AddIfNotNull("categoryIdsMultiLikeAnd", this._CategoryIdsMultiLikeAnd);
			return kparams;
		}
		#endregion
	}
}


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
// Copyright (C) 2006-2017  Kaltura Inc.
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
using System.IO;
using Kaltura.Request;
using Kaltura.Types;
using Kaltura.Enums;

namespace Kaltura.Services
{
	public class CaptionAssetItemSearchRequestBuilder : RequestBuilder<ListResponse<CaptionAssetItem>>
	{
		#region Constants
		public const string ENTRY_FILTER = "entryFilter";
		public const string CAPTION_ASSET_ITEM_FILTER = "captionAssetItemFilter";
		public const string CAPTION_ASSET_ITEM_PAGER = "captionAssetItemPager";
		#endregion

		public BaseEntryFilter EntryFilter
		{
			set;
			get;
		}
		public CaptionAssetItemFilter CaptionAssetItemFilter
		{
			set;
			get;
		}
		public FilterPager CaptionAssetItemPager
		{
			set;
			get;
		}

		public CaptionAssetItemSearchRequestBuilder()
			: base("captionsearch_captionassetitem", "search")
		{
		}

		public CaptionAssetItemSearchRequestBuilder(BaseEntryFilter entryFilter, CaptionAssetItemFilter captionAssetItemFilter, FilterPager captionAssetItemPager)
			: this()
		{
			this.EntryFilter = entryFilter;
			this.CaptionAssetItemFilter = captionAssetItemFilter;
			this.CaptionAssetItemPager = captionAssetItemPager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryFilter"))
				kparams.AddIfNotNull("entryFilter", EntryFilter);
			if (!isMapped("captionAssetItemFilter"))
				kparams.AddIfNotNull("captionAssetItemFilter", CaptionAssetItemFilter);
			if (!isMapped("captionAssetItemPager"))
				kparams.AddIfNotNull("captionAssetItemPager", CaptionAssetItemPager);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ListResponse<CaptionAssetItem>>(result);
		}
	}

	public class CaptionAssetItemSearchEntriesRequestBuilder : RequestBuilder<ListResponse<BaseEntry>>
	{
		#region Constants
		public const string ENTRY_FILTER = "entryFilter";
		public const string CAPTION_ASSET_ITEM_FILTER = "captionAssetItemFilter";
		public const string CAPTION_ASSET_ITEM_PAGER = "captionAssetItemPager";
		#endregion

		public BaseEntryFilter EntryFilter
		{
			set;
			get;
		}
		public CaptionAssetItemFilter CaptionAssetItemFilter
		{
			set;
			get;
		}
		public FilterPager CaptionAssetItemPager
		{
			set;
			get;
		}

		public CaptionAssetItemSearchEntriesRequestBuilder()
			: base("captionsearch_captionassetitem", "searchEntries")
		{
		}

		public CaptionAssetItemSearchEntriesRequestBuilder(BaseEntryFilter entryFilter, CaptionAssetItemFilter captionAssetItemFilter, FilterPager captionAssetItemPager)
			: this()
		{
			this.EntryFilter = entryFilter;
			this.CaptionAssetItemFilter = captionAssetItemFilter;
			this.CaptionAssetItemPager = captionAssetItemPager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryFilter"))
				kparams.AddIfNotNull("entryFilter", EntryFilter);
			if (!isMapped("captionAssetItemFilter"))
				kparams.AddIfNotNull("captionAssetItemFilter", CaptionAssetItemFilter);
			if (!isMapped("captionAssetItemPager"))
				kparams.AddIfNotNull("captionAssetItemPager", CaptionAssetItemPager);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ListResponse<BaseEntry>>(result);
		}
	}


	public class CaptionAssetItemService
	{
		private CaptionAssetItemService()
		{
		}

		public static CaptionAssetItemSearchRequestBuilder Search(BaseEntryFilter entryFilter = null, CaptionAssetItemFilter captionAssetItemFilter = null, FilterPager captionAssetItemPager = null)
		{
			return new CaptionAssetItemSearchRequestBuilder(entryFilter, captionAssetItemFilter, captionAssetItemPager);
		}

		public static CaptionAssetItemSearchEntriesRequestBuilder SearchEntries(BaseEntryFilter entryFilter = null, CaptionAssetItemFilter captionAssetItemFilter = null, FilterPager captionAssetItemPager = null)
		{
			return new CaptionAssetItemSearchEntriesRequestBuilder(entryFilter, captionAssetItemFilter, captionAssetItemPager);
		}
	}
}

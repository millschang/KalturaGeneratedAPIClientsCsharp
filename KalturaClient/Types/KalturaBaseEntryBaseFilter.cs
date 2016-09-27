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
	public class KalturaBaseEntryBaseFilter : KalturaRelatedFilter
	{
		#region Private Fields
		private string _IdEqual = null;
		private string _IdIn = null;
		private string _IdNotIn = null;
		private string _NameLike = null;
		private string _NameMultiLikeOr = null;
		private string _NameMultiLikeAnd = null;
		private string _NameEqual = null;
		private int _PartnerIdEqual = Int32.MinValue;
		private string _PartnerIdIn = null;
		private string _UserIdEqual = null;
		private string _UserIdIn = null;
		private string _CreatorIdEqual = null;
		private string _TagsLike = null;
		private string _TagsMultiLikeOr = null;
		private string _TagsMultiLikeAnd = null;
		private string _AdminTagsLike = null;
		private string _AdminTagsMultiLikeOr = null;
		private string _AdminTagsMultiLikeAnd = null;
		private string _CategoriesMatchAnd = null;
		private string _CategoriesMatchOr = null;
		private string _CategoriesNotContains = null;
		private string _CategoriesIdsMatchAnd = null;
		private string _CategoriesIdsMatchOr = null;
		private string _CategoriesIdsNotContains = null;
		private KalturaNullableBoolean _CategoriesIdsEmpty = (KalturaNullableBoolean)Int32.MinValue;
		private KalturaEntryStatus _StatusEqual = null;
		private KalturaEntryStatus _StatusNotEqual = null;
		private string _StatusIn = null;
		private string _StatusNotIn = null;
		private KalturaEntryModerationStatus _ModerationStatusEqual = (KalturaEntryModerationStatus)Int32.MinValue;
		private KalturaEntryModerationStatus _ModerationStatusNotEqual = (KalturaEntryModerationStatus)Int32.MinValue;
		private string _ModerationStatusIn = null;
		private string _ModerationStatusNotIn = null;
		private KalturaEntryType _TypeEqual = null;
		private string _TypeIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private int _TotalRankLessThanOrEqual = Int32.MinValue;
		private int _TotalRankGreaterThanOrEqual = Int32.MinValue;
		private int _GroupIdEqual = Int32.MinValue;
		private string _SearchTextMatchAnd = null;
		private string _SearchTextMatchOr = null;
		private int _AccessControlIdEqual = Int32.MinValue;
		private string _AccessControlIdIn = null;
		private int _StartDateGreaterThanOrEqual = Int32.MinValue;
		private int _StartDateLessThanOrEqual = Int32.MinValue;
		private int _StartDateGreaterThanOrEqualOrNull = Int32.MinValue;
		private int _StartDateLessThanOrEqualOrNull = Int32.MinValue;
		private int _EndDateGreaterThanOrEqual = Int32.MinValue;
		private int _EndDateLessThanOrEqual = Int32.MinValue;
		private int _EndDateGreaterThanOrEqualOrNull = Int32.MinValue;
		private int _EndDateLessThanOrEqualOrNull = Int32.MinValue;
		private string _ReferenceIdEqual = null;
		private string _ReferenceIdIn = null;
		private string _ReplacingEntryIdEqual = null;
		private string _ReplacingEntryIdIn = null;
		private string _ReplacedEntryIdEqual = null;
		private string _ReplacedEntryIdIn = null;
		private KalturaEntryReplacementStatus _ReplacementStatusEqual = null;
		private string _ReplacementStatusIn = null;
		private int _PartnerSortValueGreaterThanOrEqual = Int32.MinValue;
		private int _PartnerSortValueLessThanOrEqual = Int32.MinValue;
		private string _RootEntryIdEqual = null;
		private string _RootEntryIdIn = null;
		private string _ParentEntryIdEqual = null;
		private string _EntitledUsersEditMatchAnd = null;
		private string _EntitledUsersEditMatchOr = null;
		private string _EntitledUsersPublishMatchAnd = null;
		private string _EntitledUsersPublishMatchOr = null;
		private string _TagsNameMultiLikeOr = null;
		private string _TagsAdminTagsMultiLikeOr = null;
		private string _TagsAdminTagsNameMultiLikeOr = null;
		private string _TagsNameMultiLikeAnd = null;
		private string _TagsAdminTagsMultiLikeAnd = null;
		private string _TagsAdminTagsNameMultiLikeAnd = null;
		#endregion

		#region Properties
		public string IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		public string IdIn
		{
			get { return _IdIn; }
			set 
			{ 
				_IdIn = value;
				OnPropertyChanged("IdIn");
			}
		}
		public string IdNotIn
		{
			get { return _IdNotIn; }
			set 
			{ 
				_IdNotIn = value;
				OnPropertyChanged("IdNotIn");
			}
		}
		public string NameLike
		{
			get { return _NameLike; }
			set 
			{ 
				_NameLike = value;
				OnPropertyChanged("NameLike");
			}
		}
		public string NameMultiLikeOr
		{
			get { return _NameMultiLikeOr; }
			set 
			{ 
				_NameMultiLikeOr = value;
				OnPropertyChanged("NameMultiLikeOr");
			}
		}
		public string NameMultiLikeAnd
		{
			get { return _NameMultiLikeAnd; }
			set 
			{ 
				_NameMultiLikeAnd = value;
				OnPropertyChanged("NameMultiLikeAnd");
			}
		}
		public string NameEqual
		{
			get { return _NameEqual; }
			set 
			{ 
				_NameEqual = value;
				OnPropertyChanged("NameEqual");
			}
		}
		public int PartnerIdEqual
		{
			get { return _PartnerIdEqual; }
			set 
			{ 
				_PartnerIdEqual = value;
				OnPropertyChanged("PartnerIdEqual");
			}
		}
		public string PartnerIdIn
		{
			get { return _PartnerIdIn; }
			set 
			{ 
				_PartnerIdIn = value;
				OnPropertyChanged("PartnerIdIn");
			}
		}
		public string UserIdEqual
		{
			get { return _UserIdEqual; }
			set 
			{ 
				_UserIdEqual = value;
				OnPropertyChanged("UserIdEqual");
			}
		}
		public string UserIdIn
		{
			get { return _UserIdIn; }
			set 
			{ 
				_UserIdIn = value;
				OnPropertyChanged("UserIdIn");
			}
		}
		public string CreatorIdEqual
		{
			get { return _CreatorIdEqual; }
			set 
			{ 
				_CreatorIdEqual = value;
				OnPropertyChanged("CreatorIdEqual");
			}
		}
		public string TagsLike
		{
			get { return _TagsLike; }
			set 
			{ 
				_TagsLike = value;
				OnPropertyChanged("TagsLike");
			}
		}
		public string TagsMultiLikeOr
		{
			get { return _TagsMultiLikeOr; }
			set 
			{ 
				_TagsMultiLikeOr = value;
				OnPropertyChanged("TagsMultiLikeOr");
			}
		}
		public string TagsMultiLikeAnd
		{
			get { return _TagsMultiLikeAnd; }
			set 
			{ 
				_TagsMultiLikeAnd = value;
				OnPropertyChanged("TagsMultiLikeAnd");
			}
		}
		public string AdminTagsLike
		{
			get { return _AdminTagsLike; }
			set 
			{ 
				_AdminTagsLike = value;
				OnPropertyChanged("AdminTagsLike");
			}
		}
		public string AdminTagsMultiLikeOr
		{
			get { return _AdminTagsMultiLikeOr; }
			set 
			{ 
				_AdminTagsMultiLikeOr = value;
				OnPropertyChanged("AdminTagsMultiLikeOr");
			}
		}
		public string AdminTagsMultiLikeAnd
		{
			get { return _AdminTagsMultiLikeAnd; }
			set 
			{ 
				_AdminTagsMultiLikeAnd = value;
				OnPropertyChanged("AdminTagsMultiLikeAnd");
			}
		}
		public string CategoriesMatchAnd
		{
			get { return _CategoriesMatchAnd; }
			set 
			{ 
				_CategoriesMatchAnd = value;
				OnPropertyChanged("CategoriesMatchAnd");
			}
		}
		public string CategoriesMatchOr
		{
			get { return _CategoriesMatchOr; }
			set 
			{ 
				_CategoriesMatchOr = value;
				OnPropertyChanged("CategoriesMatchOr");
			}
		}
		public string CategoriesNotContains
		{
			get { return _CategoriesNotContains; }
			set 
			{ 
				_CategoriesNotContains = value;
				OnPropertyChanged("CategoriesNotContains");
			}
		}
		public string CategoriesIdsMatchAnd
		{
			get { return _CategoriesIdsMatchAnd; }
			set 
			{ 
				_CategoriesIdsMatchAnd = value;
				OnPropertyChanged("CategoriesIdsMatchAnd");
			}
		}
		public string CategoriesIdsMatchOr
		{
			get { return _CategoriesIdsMatchOr; }
			set 
			{ 
				_CategoriesIdsMatchOr = value;
				OnPropertyChanged("CategoriesIdsMatchOr");
			}
		}
		public string CategoriesIdsNotContains
		{
			get { return _CategoriesIdsNotContains; }
			set 
			{ 
				_CategoriesIdsNotContains = value;
				OnPropertyChanged("CategoriesIdsNotContains");
			}
		}
		public KalturaNullableBoolean CategoriesIdsEmpty
		{
			get { return _CategoriesIdsEmpty; }
			set 
			{ 
				_CategoriesIdsEmpty = value;
				OnPropertyChanged("CategoriesIdsEmpty");
			}
		}
		public KalturaEntryStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		public KalturaEntryStatus StatusNotEqual
		{
			get { return _StatusNotEqual; }
			set 
			{ 
				_StatusNotEqual = value;
				OnPropertyChanged("StatusNotEqual");
			}
		}
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		public string StatusNotIn
		{
			get { return _StatusNotIn; }
			set 
			{ 
				_StatusNotIn = value;
				OnPropertyChanged("StatusNotIn");
			}
		}
		public KalturaEntryModerationStatus ModerationStatusEqual
		{
			get { return _ModerationStatusEqual; }
			set 
			{ 
				_ModerationStatusEqual = value;
				OnPropertyChanged("ModerationStatusEqual");
			}
		}
		public KalturaEntryModerationStatus ModerationStatusNotEqual
		{
			get { return _ModerationStatusNotEqual; }
			set 
			{ 
				_ModerationStatusNotEqual = value;
				OnPropertyChanged("ModerationStatusNotEqual");
			}
		}
		public string ModerationStatusIn
		{
			get { return _ModerationStatusIn; }
			set 
			{ 
				_ModerationStatusIn = value;
				OnPropertyChanged("ModerationStatusIn");
			}
		}
		public string ModerationStatusNotIn
		{
			get { return _ModerationStatusNotIn; }
			set 
			{ 
				_ModerationStatusNotIn = value;
				OnPropertyChanged("ModerationStatusNotIn");
			}
		}
		public KalturaEntryType TypeEqual
		{
			get { return _TypeEqual; }
			set 
			{ 
				_TypeEqual = value;
				OnPropertyChanged("TypeEqual");
			}
		}
		public string TypeIn
		{
			get { return _TypeIn; }
			set 
			{ 
				_TypeIn = value;
				OnPropertyChanged("TypeIn");
			}
		}
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
			}
		}
		public int CreatedAtLessThanOrEqual
		{
			get { return _CreatedAtLessThanOrEqual; }
			set 
			{ 
				_CreatedAtLessThanOrEqual = value;
				OnPropertyChanged("CreatedAtLessThanOrEqual");
			}
		}
		public int UpdatedAtGreaterThanOrEqual
		{
			get { return _UpdatedAtGreaterThanOrEqual; }
			set 
			{ 
				_UpdatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("UpdatedAtGreaterThanOrEqual");
			}
		}
		public int UpdatedAtLessThanOrEqual
		{
			get { return _UpdatedAtLessThanOrEqual; }
			set 
			{ 
				_UpdatedAtLessThanOrEqual = value;
				OnPropertyChanged("UpdatedAtLessThanOrEqual");
			}
		}
		public int TotalRankLessThanOrEqual
		{
			get { return _TotalRankLessThanOrEqual; }
			set 
			{ 
				_TotalRankLessThanOrEqual = value;
				OnPropertyChanged("TotalRankLessThanOrEqual");
			}
		}
		public int TotalRankGreaterThanOrEqual
		{
			get { return _TotalRankGreaterThanOrEqual; }
			set 
			{ 
				_TotalRankGreaterThanOrEqual = value;
				OnPropertyChanged("TotalRankGreaterThanOrEqual");
			}
		}
		public int GroupIdEqual
		{
			get { return _GroupIdEqual; }
			set 
			{ 
				_GroupIdEqual = value;
				OnPropertyChanged("GroupIdEqual");
			}
		}
		public string SearchTextMatchAnd
		{
			get { return _SearchTextMatchAnd; }
			set 
			{ 
				_SearchTextMatchAnd = value;
				OnPropertyChanged("SearchTextMatchAnd");
			}
		}
		public string SearchTextMatchOr
		{
			get { return _SearchTextMatchOr; }
			set 
			{ 
				_SearchTextMatchOr = value;
				OnPropertyChanged("SearchTextMatchOr");
			}
		}
		public int AccessControlIdEqual
		{
			get { return _AccessControlIdEqual; }
			set 
			{ 
				_AccessControlIdEqual = value;
				OnPropertyChanged("AccessControlIdEqual");
			}
		}
		public string AccessControlIdIn
		{
			get { return _AccessControlIdIn; }
			set 
			{ 
				_AccessControlIdIn = value;
				OnPropertyChanged("AccessControlIdIn");
			}
		}
		public int StartDateGreaterThanOrEqual
		{
			get { return _StartDateGreaterThanOrEqual; }
			set 
			{ 
				_StartDateGreaterThanOrEqual = value;
				OnPropertyChanged("StartDateGreaterThanOrEqual");
			}
		}
		public int StartDateLessThanOrEqual
		{
			get { return _StartDateLessThanOrEqual; }
			set 
			{ 
				_StartDateLessThanOrEqual = value;
				OnPropertyChanged("StartDateLessThanOrEqual");
			}
		}
		public int StartDateGreaterThanOrEqualOrNull
		{
			get { return _StartDateGreaterThanOrEqualOrNull; }
			set 
			{ 
				_StartDateGreaterThanOrEqualOrNull = value;
				OnPropertyChanged("StartDateGreaterThanOrEqualOrNull");
			}
		}
		public int StartDateLessThanOrEqualOrNull
		{
			get { return _StartDateLessThanOrEqualOrNull; }
			set 
			{ 
				_StartDateLessThanOrEqualOrNull = value;
				OnPropertyChanged("StartDateLessThanOrEqualOrNull");
			}
		}
		public int EndDateGreaterThanOrEqual
		{
			get { return _EndDateGreaterThanOrEqual; }
			set 
			{ 
				_EndDateGreaterThanOrEqual = value;
				OnPropertyChanged("EndDateGreaterThanOrEqual");
			}
		}
		public int EndDateLessThanOrEqual
		{
			get { return _EndDateLessThanOrEqual; }
			set 
			{ 
				_EndDateLessThanOrEqual = value;
				OnPropertyChanged("EndDateLessThanOrEqual");
			}
		}
		public int EndDateGreaterThanOrEqualOrNull
		{
			get { return _EndDateGreaterThanOrEqualOrNull; }
			set 
			{ 
				_EndDateGreaterThanOrEqualOrNull = value;
				OnPropertyChanged("EndDateGreaterThanOrEqualOrNull");
			}
		}
		public int EndDateLessThanOrEqualOrNull
		{
			get { return _EndDateLessThanOrEqualOrNull; }
			set 
			{ 
				_EndDateLessThanOrEqualOrNull = value;
				OnPropertyChanged("EndDateLessThanOrEqualOrNull");
			}
		}
		public string ReferenceIdEqual
		{
			get { return _ReferenceIdEqual; }
			set 
			{ 
				_ReferenceIdEqual = value;
				OnPropertyChanged("ReferenceIdEqual");
			}
		}
		public string ReferenceIdIn
		{
			get { return _ReferenceIdIn; }
			set 
			{ 
				_ReferenceIdIn = value;
				OnPropertyChanged("ReferenceIdIn");
			}
		}
		public string ReplacingEntryIdEqual
		{
			get { return _ReplacingEntryIdEqual; }
			set 
			{ 
				_ReplacingEntryIdEqual = value;
				OnPropertyChanged("ReplacingEntryIdEqual");
			}
		}
		public string ReplacingEntryIdIn
		{
			get { return _ReplacingEntryIdIn; }
			set 
			{ 
				_ReplacingEntryIdIn = value;
				OnPropertyChanged("ReplacingEntryIdIn");
			}
		}
		public string ReplacedEntryIdEqual
		{
			get { return _ReplacedEntryIdEqual; }
			set 
			{ 
				_ReplacedEntryIdEqual = value;
				OnPropertyChanged("ReplacedEntryIdEqual");
			}
		}
		public string ReplacedEntryIdIn
		{
			get { return _ReplacedEntryIdIn; }
			set 
			{ 
				_ReplacedEntryIdIn = value;
				OnPropertyChanged("ReplacedEntryIdIn");
			}
		}
		public KalturaEntryReplacementStatus ReplacementStatusEqual
		{
			get { return _ReplacementStatusEqual; }
			set 
			{ 
				_ReplacementStatusEqual = value;
				OnPropertyChanged("ReplacementStatusEqual");
			}
		}
		public string ReplacementStatusIn
		{
			get { return _ReplacementStatusIn; }
			set 
			{ 
				_ReplacementStatusIn = value;
				OnPropertyChanged("ReplacementStatusIn");
			}
		}
		public int PartnerSortValueGreaterThanOrEqual
		{
			get { return _PartnerSortValueGreaterThanOrEqual; }
			set 
			{ 
				_PartnerSortValueGreaterThanOrEqual = value;
				OnPropertyChanged("PartnerSortValueGreaterThanOrEqual");
			}
		}
		public int PartnerSortValueLessThanOrEqual
		{
			get { return _PartnerSortValueLessThanOrEqual; }
			set 
			{ 
				_PartnerSortValueLessThanOrEqual = value;
				OnPropertyChanged("PartnerSortValueLessThanOrEqual");
			}
		}
		public string RootEntryIdEqual
		{
			get { return _RootEntryIdEqual; }
			set 
			{ 
				_RootEntryIdEqual = value;
				OnPropertyChanged("RootEntryIdEqual");
			}
		}
		public string RootEntryIdIn
		{
			get { return _RootEntryIdIn; }
			set 
			{ 
				_RootEntryIdIn = value;
				OnPropertyChanged("RootEntryIdIn");
			}
		}
		public string ParentEntryIdEqual
		{
			get { return _ParentEntryIdEqual; }
			set 
			{ 
				_ParentEntryIdEqual = value;
				OnPropertyChanged("ParentEntryIdEqual");
			}
		}
		public string EntitledUsersEditMatchAnd
		{
			get { return _EntitledUsersEditMatchAnd; }
			set 
			{ 
				_EntitledUsersEditMatchAnd = value;
				OnPropertyChanged("EntitledUsersEditMatchAnd");
			}
		}
		public string EntitledUsersEditMatchOr
		{
			get { return _EntitledUsersEditMatchOr; }
			set 
			{ 
				_EntitledUsersEditMatchOr = value;
				OnPropertyChanged("EntitledUsersEditMatchOr");
			}
		}
		public string EntitledUsersPublishMatchAnd
		{
			get { return _EntitledUsersPublishMatchAnd; }
			set 
			{ 
				_EntitledUsersPublishMatchAnd = value;
				OnPropertyChanged("EntitledUsersPublishMatchAnd");
			}
		}
		public string EntitledUsersPublishMatchOr
		{
			get { return _EntitledUsersPublishMatchOr; }
			set 
			{ 
				_EntitledUsersPublishMatchOr = value;
				OnPropertyChanged("EntitledUsersPublishMatchOr");
			}
		}
		public string TagsNameMultiLikeOr
		{
			get { return _TagsNameMultiLikeOr; }
			set 
			{ 
				_TagsNameMultiLikeOr = value;
				OnPropertyChanged("TagsNameMultiLikeOr");
			}
		}
		public string TagsAdminTagsMultiLikeOr
		{
			get { return _TagsAdminTagsMultiLikeOr; }
			set 
			{ 
				_TagsAdminTagsMultiLikeOr = value;
				OnPropertyChanged("TagsAdminTagsMultiLikeOr");
			}
		}
		public string TagsAdminTagsNameMultiLikeOr
		{
			get { return _TagsAdminTagsNameMultiLikeOr; }
			set 
			{ 
				_TagsAdminTagsNameMultiLikeOr = value;
				OnPropertyChanged("TagsAdminTagsNameMultiLikeOr");
			}
		}
		public string TagsNameMultiLikeAnd
		{
			get { return _TagsNameMultiLikeAnd; }
			set 
			{ 
				_TagsNameMultiLikeAnd = value;
				OnPropertyChanged("TagsNameMultiLikeAnd");
			}
		}
		public string TagsAdminTagsMultiLikeAnd
		{
			get { return _TagsAdminTagsMultiLikeAnd; }
			set 
			{ 
				_TagsAdminTagsMultiLikeAnd = value;
				OnPropertyChanged("TagsAdminTagsMultiLikeAnd");
			}
		}
		public string TagsAdminTagsNameMultiLikeAnd
		{
			get { return _TagsAdminTagsNameMultiLikeAnd; }
			set 
			{ 
				_TagsAdminTagsNameMultiLikeAnd = value;
				OnPropertyChanged("TagsAdminTagsNameMultiLikeAnd");
			}
		}
		#endregion

		#region CTor
		public KalturaBaseEntryBaseFilter()
		{
		}

		public KalturaBaseEntryBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "idEqual":
						this._IdEqual = txt;
						continue;
					case "idIn":
						this._IdIn = txt;
						continue;
					case "idNotIn":
						this._IdNotIn = txt;
						continue;
					case "nameLike":
						this._NameLike = txt;
						continue;
					case "nameMultiLikeOr":
						this._NameMultiLikeOr = txt;
						continue;
					case "nameMultiLikeAnd":
						this._NameMultiLikeAnd = txt;
						continue;
					case "nameEqual":
						this._NameEqual = txt;
						continue;
					case "partnerIdEqual":
						this._PartnerIdEqual = ParseInt(txt);
						continue;
					case "partnerIdIn":
						this._PartnerIdIn = txt;
						continue;
					case "userIdEqual":
						this._UserIdEqual = txt;
						continue;
					case "userIdIn":
						this._UserIdIn = txt;
						continue;
					case "creatorIdEqual":
						this._CreatorIdEqual = txt;
						continue;
					case "tagsLike":
						this._TagsLike = txt;
						continue;
					case "tagsMultiLikeOr":
						this._TagsMultiLikeOr = txt;
						continue;
					case "tagsMultiLikeAnd":
						this._TagsMultiLikeAnd = txt;
						continue;
					case "adminTagsLike":
						this._AdminTagsLike = txt;
						continue;
					case "adminTagsMultiLikeOr":
						this._AdminTagsMultiLikeOr = txt;
						continue;
					case "adminTagsMultiLikeAnd":
						this._AdminTagsMultiLikeAnd = txt;
						continue;
					case "categoriesMatchAnd":
						this._CategoriesMatchAnd = txt;
						continue;
					case "categoriesMatchOr":
						this._CategoriesMatchOr = txt;
						continue;
					case "categoriesNotContains":
						this._CategoriesNotContains = txt;
						continue;
					case "categoriesIdsMatchAnd":
						this._CategoriesIdsMatchAnd = txt;
						continue;
					case "categoriesIdsMatchOr":
						this._CategoriesIdsMatchOr = txt;
						continue;
					case "categoriesIdsNotContains":
						this._CategoriesIdsNotContains = txt;
						continue;
					case "categoriesIdsEmpty":
						this._CategoriesIdsEmpty = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "statusEqual":
						this._StatusEqual = (KalturaEntryStatus)KalturaStringEnum.Parse(typeof(KalturaEntryStatus), txt);
						continue;
					case "statusNotEqual":
						this._StatusNotEqual = (KalturaEntryStatus)KalturaStringEnum.Parse(typeof(KalturaEntryStatus), txt);
						continue;
					case "statusIn":
						this._StatusIn = txt;
						continue;
					case "statusNotIn":
						this._StatusNotIn = txt;
						continue;
					case "moderationStatusEqual":
						this._ModerationStatusEqual = (KalturaEntryModerationStatus)ParseEnum(typeof(KalturaEntryModerationStatus), txt);
						continue;
					case "moderationStatusNotEqual":
						this._ModerationStatusNotEqual = (KalturaEntryModerationStatus)ParseEnum(typeof(KalturaEntryModerationStatus), txt);
						continue;
					case "moderationStatusIn":
						this._ModerationStatusIn = txt;
						continue;
					case "moderationStatusNotIn":
						this._ModerationStatusNotIn = txt;
						continue;
					case "typeEqual":
						this._TypeEqual = (KalturaEntryType)KalturaStringEnum.Parse(typeof(KalturaEntryType), txt);
						continue;
					case "typeIn":
						this._TypeIn = txt;
						continue;
					case "createdAtGreaterThanOrEqual":
						this._CreatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "createdAtLessThanOrEqual":
						this._CreatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtGreaterThanOrEqual":
						this._UpdatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtLessThanOrEqual":
						this._UpdatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "totalRankLessThanOrEqual":
						this._TotalRankLessThanOrEqual = ParseInt(txt);
						continue;
					case "totalRankGreaterThanOrEqual":
						this._TotalRankGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "groupIdEqual":
						this._GroupIdEqual = ParseInt(txt);
						continue;
					case "searchTextMatchAnd":
						this._SearchTextMatchAnd = txt;
						continue;
					case "searchTextMatchOr":
						this._SearchTextMatchOr = txt;
						continue;
					case "accessControlIdEqual":
						this._AccessControlIdEqual = ParseInt(txt);
						continue;
					case "accessControlIdIn":
						this._AccessControlIdIn = txt;
						continue;
					case "startDateGreaterThanOrEqual":
						this._StartDateGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "startDateLessThanOrEqual":
						this._StartDateLessThanOrEqual = ParseInt(txt);
						continue;
					case "startDateGreaterThanOrEqualOrNull":
						this._StartDateGreaterThanOrEqualOrNull = ParseInt(txt);
						continue;
					case "startDateLessThanOrEqualOrNull":
						this._StartDateLessThanOrEqualOrNull = ParseInt(txt);
						continue;
					case "endDateGreaterThanOrEqual":
						this._EndDateGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "endDateLessThanOrEqual":
						this._EndDateLessThanOrEqual = ParseInt(txt);
						continue;
					case "endDateGreaterThanOrEqualOrNull":
						this._EndDateGreaterThanOrEqualOrNull = ParseInt(txt);
						continue;
					case "endDateLessThanOrEqualOrNull":
						this._EndDateLessThanOrEqualOrNull = ParseInt(txt);
						continue;
					case "referenceIdEqual":
						this._ReferenceIdEqual = txt;
						continue;
					case "referenceIdIn":
						this._ReferenceIdIn = txt;
						continue;
					case "replacingEntryIdEqual":
						this._ReplacingEntryIdEqual = txt;
						continue;
					case "replacingEntryIdIn":
						this._ReplacingEntryIdIn = txt;
						continue;
					case "replacedEntryIdEqual":
						this._ReplacedEntryIdEqual = txt;
						continue;
					case "replacedEntryIdIn":
						this._ReplacedEntryIdIn = txt;
						continue;
					case "replacementStatusEqual":
						this._ReplacementStatusEqual = (KalturaEntryReplacementStatus)KalturaStringEnum.Parse(typeof(KalturaEntryReplacementStatus), txt);
						continue;
					case "replacementStatusIn":
						this._ReplacementStatusIn = txt;
						continue;
					case "partnerSortValueGreaterThanOrEqual":
						this._PartnerSortValueGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "partnerSortValueLessThanOrEqual":
						this._PartnerSortValueLessThanOrEqual = ParseInt(txt);
						continue;
					case "rootEntryIdEqual":
						this._RootEntryIdEqual = txt;
						continue;
					case "rootEntryIdIn":
						this._RootEntryIdIn = txt;
						continue;
					case "parentEntryIdEqual":
						this._ParentEntryIdEqual = txt;
						continue;
					case "entitledUsersEditMatchAnd":
						this._EntitledUsersEditMatchAnd = txt;
						continue;
					case "entitledUsersEditMatchOr":
						this._EntitledUsersEditMatchOr = txt;
						continue;
					case "entitledUsersPublishMatchAnd":
						this._EntitledUsersPublishMatchAnd = txt;
						continue;
					case "entitledUsersPublishMatchOr":
						this._EntitledUsersPublishMatchOr = txt;
						continue;
					case "tagsNameMultiLikeOr":
						this._TagsNameMultiLikeOr = txt;
						continue;
					case "tagsAdminTagsMultiLikeOr":
						this._TagsAdminTagsMultiLikeOr = txt;
						continue;
					case "tagsAdminTagsNameMultiLikeOr":
						this._TagsAdminTagsNameMultiLikeOr = txt;
						continue;
					case "tagsNameMultiLikeAnd":
						this._TagsNameMultiLikeAnd = txt;
						continue;
					case "tagsAdminTagsMultiLikeAnd":
						this._TagsAdminTagsMultiLikeAnd = txt;
						continue;
					case "tagsAdminTagsNameMultiLikeAnd":
						this._TagsAdminTagsNameMultiLikeAnd = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaBaseEntryBaseFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("idNotIn", this._IdNotIn);
			kparams.AddIfNotNull("nameLike", this._NameLike);
			kparams.AddIfNotNull("nameMultiLikeOr", this._NameMultiLikeOr);
			kparams.AddIfNotNull("nameMultiLikeAnd", this._NameMultiLikeAnd);
			kparams.AddIfNotNull("nameEqual", this._NameEqual);
			kparams.AddIfNotNull("partnerIdEqual", this._PartnerIdEqual);
			kparams.AddIfNotNull("partnerIdIn", this._PartnerIdIn);
			kparams.AddIfNotNull("userIdEqual", this._UserIdEqual);
			kparams.AddIfNotNull("userIdIn", this._UserIdIn);
			kparams.AddIfNotNull("creatorIdEqual", this._CreatorIdEqual);
			kparams.AddIfNotNull("tagsLike", this._TagsLike);
			kparams.AddIfNotNull("tagsMultiLikeOr", this._TagsMultiLikeOr);
			kparams.AddIfNotNull("tagsMultiLikeAnd", this._TagsMultiLikeAnd);
			kparams.AddIfNotNull("adminTagsLike", this._AdminTagsLike);
			kparams.AddIfNotNull("adminTagsMultiLikeOr", this._AdminTagsMultiLikeOr);
			kparams.AddIfNotNull("adminTagsMultiLikeAnd", this._AdminTagsMultiLikeAnd);
			kparams.AddIfNotNull("categoriesMatchAnd", this._CategoriesMatchAnd);
			kparams.AddIfNotNull("categoriesMatchOr", this._CategoriesMatchOr);
			kparams.AddIfNotNull("categoriesNotContains", this._CategoriesNotContains);
			kparams.AddIfNotNull("categoriesIdsMatchAnd", this._CategoriesIdsMatchAnd);
			kparams.AddIfNotNull("categoriesIdsMatchOr", this._CategoriesIdsMatchOr);
			kparams.AddIfNotNull("categoriesIdsNotContains", this._CategoriesIdsNotContains);
			kparams.AddIfNotNull("categoriesIdsEmpty", this._CategoriesIdsEmpty);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusNotEqual", this._StatusNotEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("statusNotIn", this._StatusNotIn);
			kparams.AddIfNotNull("moderationStatusEqual", this._ModerationStatusEqual);
			kparams.AddIfNotNull("moderationStatusNotEqual", this._ModerationStatusNotEqual);
			kparams.AddIfNotNull("moderationStatusIn", this._ModerationStatusIn);
			kparams.AddIfNotNull("moderationStatusNotIn", this._ModerationStatusNotIn);
			kparams.AddIfNotNull("typeEqual", this._TypeEqual);
			kparams.AddIfNotNull("typeIn", this._TypeIn);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("totalRankLessThanOrEqual", this._TotalRankLessThanOrEqual);
			kparams.AddIfNotNull("totalRankGreaterThanOrEqual", this._TotalRankGreaterThanOrEqual);
			kparams.AddIfNotNull("groupIdEqual", this._GroupIdEqual);
			kparams.AddIfNotNull("searchTextMatchAnd", this._SearchTextMatchAnd);
			kparams.AddIfNotNull("searchTextMatchOr", this._SearchTextMatchOr);
			kparams.AddIfNotNull("accessControlIdEqual", this._AccessControlIdEqual);
			kparams.AddIfNotNull("accessControlIdIn", this._AccessControlIdIn);
			kparams.AddIfNotNull("startDateGreaterThanOrEqual", this._StartDateGreaterThanOrEqual);
			kparams.AddIfNotNull("startDateLessThanOrEqual", this._StartDateLessThanOrEqual);
			kparams.AddIfNotNull("startDateGreaterThanOrEqualOrNull", this._StartDateGreaterThanOrEqualOrNull);
			kparams.AddIfNotNull("startDateLessThanOrEqualOrNull", this._StartDateLessThanOrEqualOrNull);
			kparams.AddIfNotNull("endDateGreaterThanOrEqual", this._EndDateGreaterThanOrEqual);
			kparams.AddIfNotNull("endDateLessThanOrEqual", this._EndDateLessThanOrEqual);
			kparams.AddIfNotNull("endDateGreaterThanOrEqualOrNull", this._EndDateGreaterThanOrEqualOrNull);
			kparams.AddIfNotNull("endDateLessThanOrEqualOrNull", this._EndDateLessThanOrEqualOrNull);
			kparams.AddIfNotNull("referenceIdEqual", this._ReferenceIdEqual);
			kparams.AddIfNotNull("referenceIdIn", this._ReferenceIdIn);
			kparams.AddIfNotNull("replacingEntryIdEqual", this._ReplacingEntryIdEqual);
			kparams.AddIfNotNull("replacingEntryIdIn", this._ReplacingEntryIdIn);
			kparams.AddIfNotNull("replacedEntryIdEqual", this._ReplacedEntryIdEqual);
			kparams.AddIfNotNull("replacedEntryIdIn", this._ReplacedEntryIdIn);
			kparams.AddIfNotNull("replacementStatusEqual", this._ReplacementStatusEqual);
			kparams.AddIfNotNull("replacementStatusIn", this._ReplacementStatusIn);
			kparams.AddIfNotNull("partnerSortValueGreaterThanOrEqual", this._PartnerSortValueGreaterThanOrEqual);
			kparams.AddIfNotNull("partnerSortValueLessThanOrEqual", this._PartnerSortValueLessThanOrEqual);
			kparams.AddIfNotNull("rootEntryIdEqual", this._RootEntryIdEqual);
			kparams.AddIfNotNull("rootEntryIdIn", this._RootEntryIdIn);
			kparams.AddIfNotNull("parentEntryIdEqual", this._ParentEntryIdEqual);
			kparams.AddIfNotNull("entitledUsersEditMatchAnd", this._EntitledUsersEditMatchAnd);
			kparams.AddIfNotNull("entitledUsersEditMatchOr", this._EntitledUsersEditMatchOr);
			kparams.AddIfNotNull("entitledUsersPublishMatchAnd", this._EntitledUsersPublishMatchAnd);
			kparams.AddIfNotNull("entitledUsersPublishMatchOr", this._EntitledUsersPublishMatchOr);
			kparams.AddIfNotNull("tagsNameMultiLikeOr", this._TagsNameMultiLikeOr);
			kparams.AddIfNotNull("tagsAdminTagsMultiLikeOr", this._TagsAdminTagsMultiLikeOr);
			kparams.AddIfNotNull("tagsAdminTagsNameMultiLikeOr", this._TagsAdminTagsNameMultiLikeOr);
			kparams.AddIfNotNull("tagsNameMultiLikeAnd", this._TagsNameMultiLikeAnd);
			kparams.AddIfNotNull("tagsAdminTagsMultiLikeAnd", this._TagsAdminTagsMultiLikeAnd);
			kparams.AddIfNotNull("tagsAdminTagsNameMultiLikeAnd", this._TagsAdminTagsNameMultiLikeAnd);
			return kparams;
		}
		#endregion
	}
}


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
	public class KalturaCategoryBaseFilter : KalturaRelatedFilter
	{
		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private string _IdNotIn = null;
		private int _ParentIdEqual = Int32.MinValue;
		private string _ParentIdIn = null;
		private int _DepthEqual = Int32.MinValue;
		private string _FullNameEqual = null;
		private string _FullNameStartsWith = null;
		private string _FullNameIn = null;
		private string _FullIdsEqual = null;
		private string _FullIdsStartsWith = null;
		private string _FullIdsMatchOr = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private string _TagsLike = null;
		private string _TagsMultiLikeOr = null;
		private string _TagsMultiLikeAnd = null;
		private KalturaAppearInListType _AppearInListEqual = (KalturaAppearInListType)Int32.MinValue;
		private KalturaPrivacyType _PrivacyEqual = (KalturaPrivacyType)Int32.MinValue;
		private string _PrivacyIn = null;
		private KalturaInheritanceType _InheritanceTypeEqual = (KalturaInheritanceType)Int32.MinValue;
		private string _InheritanceTypeIn = null;
		private string _ReferenceIdEqual = null;
		private KalturaNullableBoolean _ReferenceIdEmpty = (KalturaNullableBoolean)Int32.MinValue;
		private KalturaContributionPolicyType _ContributionPolicyEqual = (KalturaContributionPolicyType)Int32.MinValue;
		private int _MembersCountGreaterThanOrEqual = Int32.MinValue;
		private int _MembersCountLessThanOrEqual = Int32.MinValue;
		private int _PendingMembersCountGreaterThanOrEqual = Int32.MinValue;
		private int _PendingMembersCountLessThanOrEqual = Int32.MinValue;
		private string _PrivacyContextEqual = null;
		private KalturaCategoryStatus _StatusEqual = (KalturaCategoryStatus)Int32.MinValue;
		private string _StatusIn = null;
		private int _InheritedParentIdEqual = Int32.MinValue;
		private string _InheritedParentIdIn = null;
		private int _PartnerSortValueGreaterThanOrEqual = Int32.MinValue;
		private int _PartnerSortValueLessThanOrEqual = Int32.MinValue;
		private string _AggregationCategoriesMultiLikeOr = null;
		private string _AggregationCategoriesMultiLikeAnd = null;
		#endregion

		#region Properties
		public int IdEqual
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
		public int ParentIdEqual
		{
			get { return _ParentIdEqual; }
			set 
			{ 
				_ParentIdEqual = value;
				OnPropertyChanged("ParentIdEqual");
			}
		}
		public string ParentIdIn
		{
			get { return _ParentIdIn; }
			set 
			{ 
				_ParentIdIn = value;
				OnPropertyChanged("ParentIdIn");
			}
		}
		public int DepthEqual
		{
			get { return _DepthEqual; }
			set 
			{ 
				_DepthEqual = value;
				OnPropertyChanged("DepthEqual");
			}
		}
		public string FullNameEqual
		{
			get { return _FullNameEqual; }
			set 
			{ 
				_FullNameEqual = value;
				OnPropertyChanged("FullNameEqual");
			}
		}
		public string FullNameStartsWith
		{
			get { return _FullNameStartsWith; }
			set 
			{ 
				_FullNameStartsWith = value;
				OnPropertyChanged("FullNameStartsWith");
			}
		}
		public string FullNameIn
		{
			get { return _FullNameIn; }
			set 
			{ 
				_FullNameIn = value;
				OnPropertyChanged("FullNameIn");
			}
		}
		public string FullIdsEqual
		{
			get { return _FullIdsEqual; }
			set 
			{ 
				_FullIdsEqual = value;
				OnPropertyChanged("FullIdsEqual");
			}
		}
		public string FullIdsStartsWith
		{
			get { return _FullIdsStartsWith; }
			set 
			{ 
				_FullIdsStartsWith = value;
				OnPropertyChanged("FullIdsStartsWith");
			}
		}
		public string FullIdsMatchOr
		{
			get { return _FullIdsMatchOr; }
			set 
			{ 
				_FullIdsMatchOr = value;
				OnPropertyChanged("FullIdsMatchOr");
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
		public KalturaAppearInListType AppearInListEqual
		{
			get { return _AppearInListEqual; }
			set 
			{ 
				_AppearInListEqual = value;
				OnPropertyChanged("AppearInListEqual");
			}
		}
		public KalturaPrivacyType PrivacyEqual
		{
			get { return _PrivacyEqual; }
			set 
			{ 
				_PrivacyEqual = value;
				OnPropertyChanged("PrivacyEqual");
			}
		}
		public string PrivacyIn
		{
			get { return _PrivacyIn; }
			set 
			{ 
				_PrivacyIn = value;
				OnPropertyChanged("PrivacyIn");
			}
		}
		public KalturaInheritanceType InheritanceTypeEqual
		{
			get { return _InheritanceTypeEqual; }
			set 
			{ 
				_InheritanceTypeEqual = value;
				OnPropertyChanged("InheritanceTypeEqual");
			}
		}
		public string InheritanceTypeIn
		{
			get { return _InheritanceTypeIn; }
			set 
			{ 
				_InheritanceTypeIn = value;
				OnPropertyChanged("InheritanceTypeIn");
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
		public KalturaNullableBoolean ReferenceIdEmpty
		{
			get { return _ReferenceIdEmpty; }
			set 
			{ 
				_ReferenceIdEmpty = value;
				OnPropertyChanged("ReferenceIdEmpty");
			}
		}
		public KalturaContributionPolicyType ContributionPolicyEqual
		{
			get { return _ContributionPolicyEqual; }
			set 
			{ 
				_ContributionPolicyEqual = value;
				OnPropertyChanged("ContributionPolicyEqual");
			}
		}
		public int MembersCountGreaterThanOrEqual
		{
			get { return _MembersCountGreaterThanOrEqual; }
			set 
			{ 
				_MembersCountGreaterThanOrEqual = value;
				OnPropertyChanged("MembersCountGreaterThanOrEqual");
			}
		}
		public int MembersCountLessThanOrEqual
		{
			get { return _MembersCountLessThanOrEqual; }
			set 
			{ 
				_MembersCountLessThanOrEqual = value;
				OnPropertyChanged("MembersCountLessThanOrEqual");
			}
		}
		public int PendingMembersCountGreaterThanOrEqual
		{
			get { return _PendingMembersCountGreaterThanOrEqual; }
			set 
			{ 
				_PendingMembersCountGreaterThanOrEqual = value;
				OnPropertyChanged("PendingMembersCountGreaterThanOrEqual");
			}
		}
		public int PendingMembersCountLessThanOrEqual
		{
			get { return _PendingMembersCountLessThanOrEqual; }
			set 
			{ 
				_PendingMembersCountLessThanOrEqual = value;
				OnPropertyChanged("PendingMembersCountLessThanOrEqual");
			}
		}
		public string PrivacyContextEqual
		{
			get { return _PrivacyContextEqual; }
			set 
			{ 
				_PrivacyContextEqual = value;
				OnPropertyChanged("PrivacyContextEqual");
			}
		}
		public KalturaCategoryStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
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
		public int InheritedParentIdEqual
		{
			get { return _InheritedParentIdEqual; }
			set 
			{ 
				_InheritedParentIdEqual = value;
				OnPropertyChanged("InheritedParentIdEqual");
			}
		}
		public string InheritedParentIdIn
		{
			get { return _InheritedParentIdIn; }
			set 
			{ 
				_InheritedParentIdIn = value;
				OnPropertyChanged("InheritedParentIdIn");
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
		public string AggregationCategoriesMultiLikeOr
		{
			get { return _AggregationCategoriesMultiLikeOr; }
			set 
			{ 
				_AggregationCategoriesMultiLikeOr = value;
				OnPropertyChanged("AggregationCategoriesMultiLikeOr");
			}
		}
		public string AggregationCategoriesMultiLikeAnd
		{
			get { return _AggregationCategoriesMultiLikeAnd; }
			set 
			{ 
				_AggregationCategoriesMultiLikeAnd = value;
				OnPropertyChanged("AggregationCategoriesMultiLikeAnd");
			}
		}
		#endregion

		#region CTor
		public KalturaCategoryBaseFilter()
		{
		}

		public KalturaCategoryBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "idEqual":
						this._IdEqual = ParseInt(txt);
						continue;
					case "idIn":
						this._IdIn = txt;
						continue;
					case "idNotIn":
						this._IdNotIn = txt;
						continue;
					case "parentIdEqual":
						this._ParentIdEqual = ParseInt(txt);
						continue;
					case "parentIdIn":
						this._ParentIdIn = txt;
						continue;
					case "depthEqual":
						this._DepthEqual = ParseInt(txt);
						continue;
					case "fullNameEqual":
						this._FullNameEqual = txt;
						continue;
					case "fullNameStartsWith":
						this._FullNameStartsWith = txt;
						continue;
					case "fullNameIn":
						this._FullNameIn = txt;
						continue;
					case "fullIdsEqual":
						this._FullIdsEqual = txt;
						continue;
					case "fullIdsStartsWith":
						this._FullIdsStartsWith = txt;
						continue;
					case "fullIdsMatchOr":
						this._FullIdsMatchOr = txt;
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
					case "tagsLike":
						this._TagsLike = txt;
						continue;
					case "tagsMultiLikeOr":
						this._TagsMultiLikeOr = txt;
						continue;
					case "tagsMultiLikeAnd":
						this._TagsMultiLikeAnd = txt;
						continue;
					case "appearInListEqual":
						this._AppearInListEqual = (KalturaAppearInListType)ParseEnum(typeof(KalturaAppearInListType), txt);
						continue;
					case "privacyEqual":
						this._PrivacyEqual = (KalturaPrivacyType)ParseEnum(typeof(KalturaPrivacyType), txt);
						continue;
					case "privacyIn":
						this._PrivacyIn = txt;
						continue;
					case "inheritanceTypeEqual":
						this._InheritanceTypeEqual = (KalturaInheritanceType)ParseEnum(typeof(KalturaInheritanceType), txt);
						continue;
					case "inheritanceTypeIn":
						this._InheritanceTypeIn = txt;
						continue;
					case "referenceIdEqual":
						this._ReferenceIdEqual = txt;
						continue;
					case "referenceIdEmpty":
						this._ReferenceIdEmpty = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "contributionPolicyEqual":
						this._ContributionPolicyEqual = (KalturaContributionPolicyType)ParseEnum(typeof(KalturaContributionPolicyType), txt);
						continue;
					case "membersCountGreaterThanOrEqual":
						this._MembersCountGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "membersCountLessThanOrEqual":
						this._MembersCountLessThanOrEqual = ParseInt(txt);
						continue;
					case "pendingMembersCountGreaterThanOrEqual":
						this._PendingMembersCountGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "pendingMembersCountLessThanOrEqual":
						this._PendingMembersCountLessThanOrEqual = ParseInt(txt);
						continue;
					case "privacyContextEqual":
						this._PrivacyContextEqual = txt;
						continue;
					case "statusEqual":
						this._StatusEqual = (KalturaCategoryStatus)ParseEnum(typeof(KalturaCategoryStatus), txt);
						continue;
					case "statusIn":
						this._StatusIn = txt;
						continue;
					case "inheritedParentIdEqual":
						this._InheritedParentIdEqual = ParseInt(txt);
						continue;
					case "inheritedParentIdIn":
						this._InheritedParentIdIn = txt;
						continue;
					case "partnerSortValueGreaterThanOrEqual":
						this._PartnerSortValueGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "partnerSortValueLessThanOrEqual":
						this._PartnerSortValueLessThanOrEqual = ParseInt(txt);
						continue;
					case "aggregationCategoriesMultiLikeOr":
						this._AggregationCategoriesMultiLikeOr = txt;
						continue;
					case "aggregationCategoriesMultiLikeAnd":
						this._AggregationCategoriesMultiLikeAnd = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaCategoryBaseFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("idNotIn", this._IdNotIn);
			kparams.AddIfNotNull("parentIdEqual", this._ParentIdEqual);
			kparams.AddIfNotNull("parentIdIn", this._ParentIdIn);
			kparams.AddIfNotNull("depthEqual", this._DepthEqual);
			kparams.AddIfNotNull("fullNameEqual", this._FullNameEqual);
			kparams.AddIfNotNull("fullNameStartsWith", this._FullNameStartsWith);
			kparams.AddIfNotNull("fullNameIn", this._FullNameIn);
			kparams.AddIfNotNull("fullIdsEqual", this._FullIdsEqual);
			kparams.AddIfNotNull("fullIdsStartsWith", this._FullIdsStartsWith);
			kparams.AddIfNotNull("fullIdsMatchOr", this._FullIdsMatchOr);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("tagsLike", this._TagsLike);
			kparams.AddIfNotNull("tagsMultiLikeOr", this._TagsMultiLikeOr);
			kparams.AddIfNotNull("tagsMultiLikeAnd", this._TagsMultiLikeAnd);
			kparams.AddIfNotNull("appearInListEqual", this._AppearInListEqual);
			kparams.AddIfNotNull("privacyEqual", this._PrivacyEqual);
			kparams.AddIfNotNull("privacyIn", this._PrivacyIn);
			kparams.AddIfNotNull("inheritanceTypeEqual", this._InheritanceTypeEqual);
			kparams.AddIfNotNull("inheritanceTypeIn", this._InheritanceTypeIn);
			kparams.AddIfNotNull("referenceIdEqual", this._ReferenceIdEqual);
			kparams.AddIfNotNull("referenceIdEmpty", this._ReferenceIdEmpty);
			kparams.AddIfNotNull("contributionPolicyEqual", this._ContributionPolicyEqual);
			kparams.AddIfNotNull("membersCountGreaterThanOrEqual", this._MembersCountGreaterThanOrEqual);
			kparams.AddIfNotNull("membersCountLessThanOrEqual", this._MembersCountLessThanOrEqual);
			kparams.AddIfNotNull("pendingMembersCountGreaterThanOrEqual", this._PendingMembersCountGreaterThanOrEqual);
			kparams.AddIfNotNull("pendingMembersCountLessThanOrEqual", this._PendingMembersCountLessThanOrEqual);
			kparams.AddIfNotNull("privacyContextEqual", this._PrivacyContextEqual);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("inheritedParentIdEqual", this._InheritedParentIdEqual);
			kparams.AddIfNotNull("inheritedParentIdIn", this._InheritedParentIdIn);
			kparams.AddIfNotNull("partnerSortValueGreaterThanOrEqual", this._PartnerSortValueGreaterThanOrEqual);
			kparams.AddIfNotNull("partnerSortValueLessThanOrEqual", this._PartnerSortValueLessThanOrEqual);
			kparams.AddIfNotNull("aggregationCategoriesMultiLikeOr", this._AggregationCategoriesMultiLikeOr);
			kparams.AddIfNotNull("aggregationCategoriesMultiLikeAnd", this._AggregationCategoriesMultiLikeAnd);
			return kparams;
		}
		#endregion
	}
}


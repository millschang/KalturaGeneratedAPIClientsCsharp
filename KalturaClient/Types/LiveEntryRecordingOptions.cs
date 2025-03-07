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
	public class LiveEntryRecordingOptions : ObjectBase
	{
		#region Constants
		public const string SHOULD_COPY_ENTITLEMENT = "shouldCopyEntitlement";
		public const string SHOULD_COPY_SCHEDULING = "shouldCopyScheduling";
		public const string SHOULD_COPY_THUMBNAIL = "shouldCopyThumbnail";
		public const string SHOULD_MAKE_HIDDEN = "shouldMakeHidden";
		public const string SHOULD_AUTO_ARCHIVE = "shouldAutoArchive";
		public const string NON_DELETED_CUE_POINTS_TAGS = "nonDeletedCuePointsTags";
		public const string ARCHIVE_VOD_SUFFIX_TIMEZONE = "archiveVodSuffixTimezone";
		#endregion

		#region Private Fields
		private NullableBoolean _ShouldCopyEntitlement = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _ShouldCopyScheduling = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _ShouldCopyThumbnail = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _ShouldMakeHidden = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _ShouldAutoArchive = (NullableBoolean)Int32.MinValue;
		private string _NonDeletedCuePointsTags = null;
		private string _ArchiveVodSuffixTimezone = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use ShouldCopyEntitlementAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean ShouldCopyEntitlement
		{
			get { return _ShouldCopyEntitlement; }
			set 
			{ 
				_ShouldCopyEntitlement = value;
				OnPropertyChanged("ShouldCopyEntitlement");
			}
		}
		/// <summary>
		/// Use ShouldCopySchedulingAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean ShouldCopyScheduling
		{
			get { return _ShouldCopyScheduling; }
			set 
			{ 
				_ShouldCopyScheduling = value;
				OnPropertyChanged("ShouldCopyScheduling");
			}
		}
		/// <summary>
		/// Use ShouldCopyThumbnailAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean ShouldCopyThumbnail
		{
			get { return _ShouldCopyThumbnail; }
			set 
			{ 
				_ShouldCopyThumbnail = value;
				OnPropertyChanged("ShouldCopyThumbnail");
			}
		}
		/// <summary>
		/// Use ShouldMakeHiddenAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean ShouldMakeHidden
		{
			get { return _ShouldMakeHidden; }
			set 
			{ 
				_ShouldMakeHidden = value;
				OnPropertyChanged("ShouldMakeHidden");
			}
		}
		/// <summary>
		/// Use ShouldAutoArchiveAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean ShouldAutoArchive
		{
			get { return _ShouldAutoArchive; }
			set 
			{ 
				_ShouldAutoArchive = value;
				OnPropertyChanged("ShouldAutoArchive");
			}
		}
		/// <summary>
		/// Use NonDeletedCuePointsTagsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string NonDeletedCuePointsTags
		{
			get { return _NonDeletedCuePointsTags; }
			set 
			{ 
				_NonDeletedCuePointsTags = value;
				OnPropertyChanged("NonDeletedCuePointsTags");
			}
		}
		/// <summary>
		/// Use ArchiveVodSuffixTimezoneAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ArchiveVodSuffixTimezone
		{
			get { return _ArchiveVodSuffixTimezone; }
			set 
			{ 
				_ArchiveVodSuffixTimezone = value;
				OnPropertyChanged("ArchiveVodSuffixTimezone");
			}
		}
		#endregion

		#region CTor
		public LiveEntryRecordingOptions()
		{
		}

		public LiveEntryRecordingOptions(JToken node) : base(node)
		{
			if(node["shouldCopyEntitlement"] != null)
			{
				this._ShouldCopyEntitlement = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["shouldCopyEntitlement"].Value<string>());
			}
			if(node["shouldCopyScheduling"] != null)
			{
				this._ShouldCopyScheduling = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["shouldCopyScheduling"].Value<string>());
			}
			if(node["shouldCopyThumbnail"] != null)
			{
				this._ShouldCopyThumbnail = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["shouldCopyThumbnail"].Value<string>());
			}
			if(node["shouldMakeHidden"] != null)
			{
				this._ShouldMakeHidden = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["shouldMakeHidden"].Value<string>());
			}
			if(node["shouldAutoArchive"] != null)
			{
				this._ShouldAutoArchive = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["shouldAutoArchive"].Value<string>());
			}
			if(node["nonDeletedCuePointsTags"] != null)
			{
				this._NonDeletedCuePointsTags = node["nonDeletedCuePointsTags"].Value<string>();
			}
			if(node["archiveVodSuffixTimezone"] != null)
			{
				this._ArchiveVodSuffixTimezone = node["archiveVodSuffixTimezone"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLiveEntryRecordingOptions");
			kparams.AddIfNotNull("shouldCopyEntitlement", this._ShouldCopyEntitlement);
			kparams.AddIfNotNull("shouldCopyScheduling", this._ShouldCopyScheduling);
			kparams.AddIfNotNull("shouldCopyThumbnail", this._ShouldCopyThumbnail);
			kparams.AddIfNotNull("shouldMakeHidden", this._ShouldMakeHidden);
			kparams.AddIfNotNull("shouldAutoArchive", this._ShouldAutoArchive);
			kparams.AddIfNotNull("nonDeletedCuePointsTags", this._NonDeletedCuePointsTags);
			kparams.AddIfNotNull("archiveVodSuffixTimezone", this._ArchiveVodSuffixTimezone);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SHOULD_COPY_ENTITLEMENT:
					return "ShouldCopyEntitlement";
				case SHOULD_COPY_SCHEDULING:
					return "ShouldCopyScheduling";
				case SHOULD_COPY_THUMBNAIL:
					return "ShouldCopyThumbnail";
				case SHOULD_MAKE_HIDDEN:
					return "ShouldMakeHidden";
				case SHOULD_AUTO_ARCHIVE:
					return "ShouldAutoArchive";
				case NON_DELETED_CUE_POINTS_TAGS:
					return "NonDeletedCuePointsTags";
				case ARCHIVE_VOD_SUFFIX_TIMEZONE:
					return "ArchiveVodSuffixTimezone";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}


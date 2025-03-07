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
	public class ReportInputFilter : ReportInputBaseFilter
	{
		#region Constants
		public const string KEYWORDS = "keywords";
		public const string SEARCH_IN_TAGS = "searchInTags";
		public const string SEARCH_IN_ADMIN_TAGS = "searchInAdminTags";
		public const string CATEGORIES = "categories";
		public const string CATEGORIES_IDS_IN = "categoriesIdsIn";
		public const string CUSTOM_VAR1IN = "customVar1In";
		public const string CUSTOM_VAR2IN = "customVar2In";
		public const string CUSTOM_VAR3IN = "customVar3In";
		public const string DEVICE_IN = "deviceIn";
		public const string COUNTRY_IN = "countryIn";
		public const string REGION_IN = "regionIn";
		public const string CITIES_IN = "citiesIn";
		public const string OPERATING_SYSTEM_FAMILY_IN = "operatingSystemFamilyIn";
		public const string OPERATING_SYSTEM_IN = "operatingSystemIn";
		public const string BROWSER_FAMILY_IN = "browserFamilyIn";
		public const string BROWSER_IN = "browserIn";
		public const string TIME_ZONE_OFFSET = "timeZoneOffset";
		public const string INTERVAL = "interval";
		public const string MEDIA_TYPE_IN = "mediaTypeIn";
		public const string SOURCE_TYPE_IN = "sourceTypeIn";
		public const string OWNER_IDS_IN = "ownerIdsIn";
		public const string ENTRY_OPERATOR = "entryOperator";
		public const string ENTRY_CREATED_AT_GREATER_THAN_OR_EQUAL = "entryCreatedAtGreaterThanOrEqual";
		public const string ENTRY_CREATED_AT_LESS_THAN_OR_EQUAL = "entryCreatedAtLessThanOrEqual";
		public const string ENTRY_ID_IN = "entryIdIn";
		public const string PLAYBACK_TYPE_IN = "playbackTypeIn";
		public const string PLAYBACK_CONTEXT_IDS_IN = "playbackContextIdsIn";
		public const string ROOT_ENTRY_ID_IN = "rootEntryIdIn";
		public const string ERROR_CODE_IN = "errorCodeIn";
		public const string PLAYER_VERSION_IN = "playerVersionIn";
		public const string ISP_IN = "ispIn";
		public const string APPLICATION_VERSION_IN = "applicationVersionIn";
		public const string NODE_IDS_IN = "nodeIdsIn";
		public const string CATEGORIES_ANCESTOR_ID_IN = "categoriesAncestorIdIn";
		public const string HOTSPOT_ID_IN = "hotspotIdIn";
		public const string CRM_ID_IN = "crmIdIn";
		public const string PLAYLIST_ID_IN = "playlistIdIn";
		public const string DOMAIN_IN = "domainIn";
		public const string CANONICAL_URL_IN = "canonicalUrlIn";
		public const string VIRTUAL_EVENT_ID_IN = "virtualEventIdIn";
		public const string ORIGIN_IN = "originIn";
		public const string UI_CONF_ID_IN = "uiConfIdIn";
		#endregion

		#region Private Fields
		private string _Keywords = null;
		private bool? _SearchInTags = null;
		private bool? _SearchInAdminTags = null;
		private string _Categories = null;
		private string _CategoriesIdsIn = null;
		private string _CustomVar1In = null;
		private string _CustomVar2In = null;
		private string _CustomVar3In = null;
		private string _DeviceIn = null;
		private string _CountryIn = null;
		private string _RegionIn = null;
		private string _CitiesIn = null;
		private string _OperatingSystemFamilyIn = null;
		private string _OperatingSystemIn = null;
		private string _BrowserFamilyIn = null;
		private string _BrowserIn = null;
		private int _TimeZoneOffset = Int32.MinValue;
		private ReportInterval _Interval = null;
		private string _MediaTypeIn = null;
		private string _SourceTypeIn = null;
		private string _OwnerIdsIn = null;
		private ESearchEntryOperator _EntryOperator;
		private int _EntryCreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _EntryCreatedAtLessThanOrEqual = Int32.MinValue;
		private string _EntryIdIn = null;
		private string _PlaybackTypeIn = null;
		private string _PlaybackContextIdsIn = null;
		private string _RootEntryIdIn = null;
		private string _ErrorCodeIn = null;
		private string _PlayerVersionIn = null;
		private string _IspIn = null;
		private string _ApplicationVersionIn = null;
		private string _NodeIdsIn = null;
		private string _CategoriesAncestorIdIn = null;
		private string _HotspotIdIn = null;
		private string _CrmIdIn = null;
		private string _PlaylistIdIn = null;
		private string _DomainIn = null;
		private string _CanonicalUrlIn = null;
		private string _VirtualEventIdIn = null;
		private string _OriginIn = null;
		private string _UiConfIdIn = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use KeywordsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Keywords
		{
			get { return _Keywords; }
			set 
			{ 
				_Keywords = value;
				OnPropertyChanged("Keywords");
			}
		}
		/// <summary>
		/// Use SearchInTagsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? SearchInTags
		{
			get { return _SearchInTags; }
			set 
			{ 
				_SearchInTags = value;
				OnPropertyChanged("SearchInTags");
			}
		}
		/// <summary>
		/// Use SearchInAdminTagsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? SearchInAdminTags
		{
			get { return _SearchInAdminTags; }
			set 
			{ 
				_SearchInAdminTags = value;
				OnPropertyChanged("SearchInAdminTags");
			}
		}
		/// <summary>
		/// Use CategoriesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Categories
		{
			get { return _Categories; }
			set 
			{ 
				_Categories = value;
				OnPropertyChanged("Categories");
			}
		}
		/// <summary>
		/// Use CategoriesIdsInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CategoriesIdsIn
		{
			get { return _CategoriesIdsIn; }
			set 
			{ 
				_CategoriesIdsIn = value;
				OnPropertyChanged("CategoriesIdsIn");
			}
		}
		/// <summary>
		/// Use CustomVar1InAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CustomVar1In
		{
			get { return _CustomVar1In; }
			set 
			{ 
				_CustomVar1In = value;
				OnPropertyChanged("CustomVar1In");
			}
		}
		/// <summary>
		/// Use CustomVar2InAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CustomVar2In
		{
			get { return _CustomVar2In; }
			set 
			{ 
				_CustomVar2In = value;
				OnPropertyChanged("CustomVar2In");
			}
		}
		/// <summary>
		/// Use CustomVar3InAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CustomVar3In
		{
			get { return _CustomVar3In; }
			set 
			{ 
				_CustomVar3In = value;
				OnPropertyChanged("CustomVar3In");
			}
		}
		/// <summary>
		/// Use DeviceInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DeviceIn
		{
			get { return _DeviceIn; }
			set 
			{ 
				_DeviceIn = value;
				OnPropertyChanged("DeviceIn");
			}
		}
		/// <summary>
		/// Use CountryInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CountryIn
		{
			get { return _CountryIn; }
			set 
			{ 
				_CountryIn = value;
				OnPropertyChanged("CountryIn");
			}
		}
		/// <summary>
		/// Use RegionInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RegionIn
		{
			get { return _RegionIn; }
			set 
			{ 
				_RegionIn = value;
				OnPropertyChanged("RegionIn");
			}
		}
		/// <summary>
		/// Use CitiesInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CitiesIn
		{
			get { return _CitiesIn; }
			set 
			{ 
				_CitiesIn = value;
				OnPropertyChanged("CitiesIn");
			}
		}
		/// <summary>
		/// Use OperatingSystemFamilyInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string OperatingSystemFamilyIn
		{
			get { return _OperatingSystemFamilyIn; }
			set 
			{ 
				_OperatingSystemFamilyIn = value;
				OnPropertyChanged("OperatingSystemFamilyIn");
			}
		}
		/// <summary>
		/// Use OperatingSystemInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string OperatingSystemIn
		{
			get { return _OperatingSystemIn; }
			set 
			{ 
				_OperatingSystemIn = value;
				OnPropertyChanged("OperatingSystemIn");
			}
		}
		/// <summary>
		/// Use BrowserFamilyInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string BrowserFamilyIn
		{
			get { return _BrowserFamilyIn; }
			set 
			{ 
				_BrowserFamilyIn = value;
				OnPropertyChanged("BrowserFamilyIn");
			}
		}
		/// <summary>
		/// Use BrowserInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string BrowserIn
		{
			get { return _BrowserIn; }
			set 
			{ 
				_BrowserIn = value;
				OnPropertyChanged("BrowserIn");
			}
		}
		/// <summary>
		/// Use TimeZoneOffsetAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int TimeZoneOffset
		{
			get { return _TimeZoneOffset; }
			set 
			{ 
				_TimeZoneOffset = value;
				OnPropertyChanged("TimeZoneOffset");
			}
		}
		/// <summary>
		/// Use IntervalAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ReportInterval Interval
		{
			get { return _Interval; }
			set 
			{ 
				_Interval = value;
				OnPropertyChanged("Interval");
			}
		}
		/// <summary>
		/// Use MediaTypeInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string MediaTypeIn
		{
			get { return _MediaTypeIn; }
			set 
			{ 
				_MediaTypeIn = value;
				OnPropertyChanged("MediaTypeIn");
			}
		}
		/// <summary>
		/// Use SourceTypeInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SourceTypeIn
		{
			get { return _SourceTypeIn; }
			set 
			{ 
				_SourceTypeIn = value;
				OnPropertyChanged("SourceTypeIn");
			}
		}
		/// <summary>
		/// Use OwnerIdsInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string OwnerIdsIn
		{
			get { return _OwnerIdsIn; }
			set 
			{ 
				_OwnerIdsIn = value;
				OnPropertyChanged("OwnerIdsIn");
			}
		}
		/// <summary>
		/// Use EntryOperatorAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ESearchEntryOperator EntryOperator
		{
			get { return _EntryOperator; }
			set 
			{ 
				_EntryOperator = value;
				OnPropertyChanged("EntryOperator");
			}
		}
		/// <summary>
		/// Use EntryCreatedAtGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int EntryCreatedAtGreaterThanOrEqual
		{
			get { return _EntryCreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_EntryCreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("EntryCreatedAtGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use EntryCreatedAtLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int EntryCreatedAtLessThanOrEqual
		{
			get { return _EntryCreatedAtLessThanOrEqual; }
			set 
			{ 
				_EntryCreatedAtLessThanOrEqual = value;
				OnPropertyChanged("EntryCreatedAtLessThanOrEqual");
			}
		}
		/// <summary>
		/// Use EntryIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EntryIdIn
		{
			get { return _EntryIdIn; }
			set 
			{ 
				_EntryIdIn = value;
				OnPropertyChanged("EntryIdIn");
			}
		}
		/// <summary>
		/// Use PlaybackTypeInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PlaybackTypeIn
		{
			get { return _PlaybackTypeIn; }
			set 
			{ 
				_PlaybackTypeIn = value;
				OnPropertyChanged("PlaybackTypeIn");
			}
		}
		/// <summary>
		/// Use PlaybackContextIdsInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PlaybackContextIdsIn
		{
			get { return _PlaybackContextIdsIn; }
			set 
			{ 
				_PlaybackContextIdsIn = value;
				OnPropertyChanged("PlaybackContextIdsIn");
			}
		}
		/// <summary>
		/// Use RootEntryIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RootEntryIdIn
		{
			get { return _RootEntryIdIn; }
			set 
			{ 
				_RootEntryIdIn = value;
				OnPropertyChanged("RootEntryIdIn");
			}
		}
		/// <summary>
		/// Use ErrorCodeInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ErrorCodeIn
		{
			get { return _ErrorCodeIn; }
			set 
			{ 
				_ErrorCodeIn = value;
				OnPropertyChanged("ErrorCodeIn");
			}
		}
		/// <summary>
		/// Use PlayerVersionInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PlayerVersionIn
		{
			get { return _PlayerVersionIn; }
			set 
			{ 
				_PlayerVersionIn = value;
				OnPropertyChanged("PlayerVersionIn");
			}
		}
		/// <summary>
		/// Use IspInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string IspIn
		{
			get { return _IspIn; }
			set 
			{ 
				_IspIn = value;
				OnPropertyChanged("IspIn");
			}
		}
		/// <summary>
		/// Use ApplicationVersionInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ApplicationVersionIn
		{
			get { return _ApplicationVersionIn; }
			set 
			{ 
				_ApplicationVersionIn = value;
				OnPropertyChanged("ApplicationVersionIn");
			}
		}
		/// <summary>
		/// Use NodeIdsInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string NodeIdsIn
		{
			get { return _NodeIdsIn; }
			set 
			{ 
				_NodeIdsIn = value;
				OnPropertyChanged("NodeIdsIn");
			}
		}
		/// <summary>
		/// Use CategoriesAncestorIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CategoriesAncestorIdIn
		{
			get { return _CategoriesAncestorIdIn; }
			set 
			{ 
				_CategoriesAncestorIdIn = value;
				OnPropertyChanged("CategoriesAncestorIdIn");
			}
		}
		/// <summary>
		/// Use HotspotIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string HotspotIdIn
		{
			get { return _HotspotIdIn; }
			set 
			{ 
				_HotspotIdIn = value;
				OnPropertyChanged("HotspotIdIn");
			}
		}
		/// <summary>
		/// Use CrmIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CrmIdIn
		{
			get { return _CrmIdIn; }
			set 
			{ 
				_CrmIdIn = value;
				OnPropertyChanged("CrmIdIn");
			}
		}
		/// <summary>
		/// Use PlaylistIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PlaylistIdIn
		{
			get { return _PlaylistIdIn; }
			set 
			{ 
				_PlaylistIdIn = value;
				OnPropertyChanged("PlaylistIdIn");
			}
		}
		/// <summary>
		/// Use DomainInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DomainIn
		{
			get { return _DomainIn; }
			set 
			{ 
				_DomainIn = value;
				OnPropertyChanged("DomainIn");
			}
		}
		/// <summary>
		/// Use CanonicalUrlInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CanonicalUrlIn
		{
			get { return _CanonicalUrlIn; }
			set 
			{ 
				_CanonicalUrlIn = value;
				OnPropertyChanged("CanonicalUrlIn");
			}
		}
		/// <summary>
		/// Use VirtualEventIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string VirtualEventIdIn
		{
			get { return _VirtualEventIdIn; }
			set 
			{ 
				_VirtualEventIdIn = value;
				OnPropertyChanged("VirtualEventIdIn");
			}
		}
		/// <summary>
		/// Use OriginInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string OriginIn
		{
			get { return _OriginIn; }
			set 
			{ 
				_OriginIn = value;
				OnPropertyChanged("OriginIn");
			}
		}
		/// <summary>
		/// Use UiConfIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UiConfIdIn
		{
			get { return _UiConfIdIn; }
			set 
			{ 
				_UiConfIdIn = value;
				OnPropertyChanged("UiConfIdIn");
			}
		}
		#endregion

		#region CTor
		public ReportInputFilter()
		{
		}

		public ReportInputFilter(JToken node) : base(node)
		{
			if(node["keywords"] != null)
			{
				this._Keywords = node["keywords"].Value<string>();
			}
			if(node["searchInTags"] != null)
			{
				this._SearchInTags = ParseBool(node["searchInTags"].Value<string>());
			}
			if(node["searchInAdminTags"] != null)
			{
				this._SearchInAdminTags = ParseBool(node["searchInAdminTags"].Value<string>());
			}
			if(node["categories"] != null)
			{
				this._Categories = node["categories"].Value<string>();
			}
			if(node["categoriesIdsIn"] != null)
			{
				this._CategoriesIdsIn = node["categoriesIdsIn"].Value<string>();
			}
			if(node["customVar1In"] != null)
			{
				this._CustomVar1In = node["customVar1In"].Value<string>();
			}
			if(node["customVar2In"] != null)
			{
				this._CustomVar2In = node["customVar2In"].Value<string>();
			}
			if(node["customVar3In"] != null)
			{
				this._CustomVar3In = node["customVar3In"].Value<string>();
			}
			if(node["deviceIn"] != null)
			{
				this._DeviceIn = node["deviceIn"].Value<string>();
			}
			if(node["countryIn"] != null)
			{
				this._CountryIn = node["countryIn"].Value<string>();
			}
			if(node["regionIn"] != null)
			{
				this._RegionIn = node["regionIn"].Value<string>();
			}
			if(node["citiesIn"] != null)
			{
				this._CitiesIn = node["citiesIn"].Value<string>();
			}
			if(node["operatingSystemFamilyIn"] != null)
			{
				this._OperatingSystemFamilyIn = node["operatingSystemFamilyIn"].Value<string>();
			}
			if(node["operatingSystemIn"] != null)
			{
				this._OperatingSystemIn = node["operatingSystemIn"].Value<string>();
			}
			if(node["browserFamilyIn"] != null)
			{
				this._BrowserFamilyIn = node["browserFamilyIn"].Value<string>();
			}
			if(node["browserIn"] != null)
			{
				this._BrowserIn = node["browserIn"].Value<string>();
			}
			if(node["timeZoneOffset"] != null)
			{
				this._TimeZoneOffset = ParseInt(node["timeZoneOffset"].Value<string>());
			}
			if(node["interval"] != null)
			{
				this._Interval = (ReportInterval)StringEnum.Parse(typeof(ReportInterval), node["interval"].Value<string>());
			}
			if(node["mediaTypeIn"] != null)
			{
				this._MediaTypeIn = node["mediaTypeIn"].Value<string>();
			}
			if(node["sourceTypeIn"] != null)
			{
				this._SourceTypeIn = node["sourceTypeIn"].Value<string>();
			}
			if(node["ownerIdsIn"] != null)
			{
				this._OwnerIdsIn = node["ownerIdsIn"].Value<string>();
			}
			if(node["entryOperator"] != null)
			{
				this._EntryOperator = ObjectFactory.Create<ESearchEntryOperator>(node["entryOperator"]);
			}
			if(node["entryCreatedAtGreaterThanOrEqual"] != null)
			{
				this._EntryCreatedAtGreaterThanOrEqual = ParseInt(node["entryCreatedAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["entryCreatedAtLessThanOrEqual"] != null)
			{
				this._EntryCreatedAtLessThanOrEqual = ParseInt(node["entryCreatedAtLessThanOrEqual"].Value<string>());
			}
			if(node["entryIdIn"] != null)
			{
				this._EntryIdIn = node["entryIdIn"].Value<string>();
			}
			if(node["playbackTypeIn"] != null)
			{
				this._PlaybackTypeIn = node["playbackTypeIn"].Value<string>();
			}
			if(node["playbackContextIdsIn"] != null)
			{
				this._PlaybackContextIdsIn = node["playbackContextIdsIn"].Value<string>();
			}
			if(node["rootEntryIdIn"] != null)
			{
				this._RootEntryIdIn = node["rootEntryIdIn"].Value<string>();
			}
			if(node["errorCodeIn"] != null)
			{
				this._ErrorCodeIn = node["errorCodeIn"].Value<string>();
			}
			if(node["playerVersionIn"] != null)
			{
				this._PlayerVersionIn = node["playerVersionIn"].Value<string>();
			}
			if(node["ispIn"] != null)
			{
				this._IspIn = node["ispIn"].Value<string>();
			}
			if(node["applicationVersionIn"] != null)
			{
				this._ApplicationVersionIn = node["applicationVersionIn"].Value<string>();
			}
			if(node["nodeIdsIn"] != null)
			{
				this._NodeIdsIn = node["nodeIdsIn"].Value<string>();
			}
			if(node["categoriesAncestorIdIn"] != null)
			{
				this._CategoriesAncestorIdIn = node["categoriesAncestorIdIn"].Value<string>();
			}
			if(node["hotspotIdIn"] != null)
			{
				this._HotspotIdIn = node["hotspotIdIn"].Value<string>();
			}
			if(node["crmIdIn"] != null)
			{
				this._CrmIdIn = node["crmIdIn"].Value<string>();
			}
			if(node["playlistIdIn"] != null)
			{
				this._PlaylistIdIn = node["playlistIdIn"].Value<string>();
			}
			if(node["domainIn"] != null)
			{
				this._DomainIn = node["domainIn"].Value<string>();
			}
			if(node["canonicalUrlIn"] != null)
			{
				this._CanonicalUrlIn = node["canonicalUrlIn"].Value<string>();
			}
			if(node["virtualEventIdIn"] != null)
			{
				this._VirtualEventIdIn = node["virtualEventIdIn"].Value<string>();
			}
			if(node["originIn"] != null)
			{
				this._OriginIn = node["originIn"].Value<string>();
			}
			if(node["uiConfIdIn"] != null)
			{
				this._UiConfIdIn = node["uiConfIdIn"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaReportInputFilter");
			kparams.AddIfNotNull("keywords", this._Keywords);
			kparams.AddIfNotNull("searchInTags", this._SearchInTags);
			kparams.AddIfNotNull("searchInAdminTags", this._SearchInAdminTags);
			kparams.AddIfNotNull("categories", this._Categories);
			kparams.AddIfNotNull("categoriesIdsIn", this._CategoriesIdsIn);
			kparams.AddIfNotNull("customVar1In", this._CustomVar1In);
			kparams.AddIfNotNull("customVar2In", this._CustomVar2In);
			kparams.AddIfNotNull("customVar3In", this._CustomVar3In);
			kparams.AddIfNotNull("deviceIn", this._DeviceIn);
			kparams.AddIfNotNull("countryIn", this._CountryIn);
			kparams.AddIfNotNull("regionIn", this._RegionIn);
			kparams.AddIfNotNull("citiesIn", this._CitiesIn);
			kparams.AddIfNotNull("operatingSystemFamilyIn", this._OperatingSystemFamilyIn);
			kparams.AddIfNotNull("operatingSystemIn", this._OperatingSystemIn);
			kparams.AddIfNotNull("browserFamilyIn", this._BrowserFamilyIn);
			kparams.AddIfNotNull("browserIn", this._BrowserIn);
			kparams.AddIfNotNull("timeZoneOffset", this._TimeZoneOffset);
			kparams.AddIfNotNull("interval", this._Interval);
			kparams.AddIfNotNull("mediaTypeIn", this._MediaTypeIn);
			kparams.AddIfNotNull("sourceTypeIn", this._SourceTypeIn);
			kparams.AddIfNotNull("ownerIdsIn", this._OwnerIdsIn);
			kparams.AddIfNotNull("entryOperator", this._EntryOperator);
			kparams.AddIfNotNull("entryCreatedAtGreaterThanOrEqual", this._EntryCreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("entryCreatedAtLessThanOrEqual", this._EntryCreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("entryIdIn", this._EntryIdIn);
			kparams.AddIfNotNull("playbackTypeIn", this._PlaybackTypeIn);
			kparams.AddIfNotNull("playbackContextIdsIn", this._PlaybackContextIdsIn);
			kparams.AddIfNotNull("rootEntryIdIn", this._RootEntryIdIn);
			kparams.AddIfNotNull("errorCodeIn", this._ErrorCodeIn);
			kparams.AddIfNotNull("playerVersionIn", this._PlayerVersionIn);
			kparams.AddIfNotNull("ispIn", this._IspIn);
			kparams.AddIfNotNull("applicationVersionIn", this._ApplicationVersionIn);
			kparams.AddIfNotNull("nodeIdsIn", this._NodeIdsIn);
			kparams.AddIfNotNull("categoriesAncestorIdIn", this._CategoriesAncestorIdIn);
			kparams.AddIfNotNull("hotspotIdIn", this._HotspotIdIn);
			kparams.AddIfNotNull("crmIdIn", this._CrmIdIn);
			kparams.AddIfNotNull("playlistIdIn", this._PlaylistIdIn);
			kparams.AddIfNotNull("domainIn", this._DomainIn);
			kparams.AddIfNotNull("canonicalUrlIn", this._CanonicalUrlIn);
			kparams.AddIfNotNull("virtualEventIdIn", this._VirtualEventIdIn);
			kparams.AddIfNotNull("originIn", this._OriginIn);
			kparams.AddIfNotNull("uiConfIdIn", this._UiConfIdIn);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case KEYWORDS:
					return "Keywords";
				case SEARCH_IN_TAGS:
					return "SearchInTags";
				case SEARCH_IN_ADMIN_TAGS:
					return "SearchInAdminTags";
				case CATEGORIES:
					return "Categories";
				case CATEGORIES_IDS_IN:
					return "CategoriesIdsIn";
				case CUSTOM_VAR1IN:
					return "CustomVar1In";
				case CUSTOM_VAR2IN:
					return "CustomVar2In";
				case CUSTOM_VAR3IN:
					return "CustomVar3In";
				case DEVICE_IN:
					return "DeviceIn";
				case COUNTRY_IN:
					return "CountryIn";
				case REGION_IN:
					return "RegionIn";
				case CITIES_IN:
					return "CitiesIn";
				case OPERATING_SYSTEM_FAMILY_IN:
					return "OperatingSystemFamilyIn";
				case OPERATING_SYSTEM_IN:
					return "OperatingSystemIn";
				case BROWSER_FAMILY_IN:
					return "BrowserFamilyIn";
				case BROWSER_IN:
					return "BrowserIn";
				case TIME_ZONE_OFFSET:
					return "TimeZoneOffset";
				case INTERVAL:
					return "Interval";
				case MEDIA_TYPE_IN:
					return "MediaTypeIn";
				case SOURCE_TYPE_IN:
					return "SourceTypeIn";
				case OWNER_IDS_IN:
					return "OwnerIdsIn";
				case ENTRY_OPERATOR:
					return "EntryOperator";
				case ENTRY_CREATED_AT_GREATER_THAN_OR_EQUAL:
					return "EntryCreatedAtGreaterThanOrEqual";
				case ENTRY_CREATED_AT_LESS_THAN_OR_EQUAL:
					return "EntryCreatedAtLessThanOrEqual";
				case ENTRY_ID_IN:
					return "EntryIdIn";
				case PLAYBACK_TYPE_IN:
					return "PlaybackTypeIn";
				case PLAYBACK_CONTEXT_IDS_IN:
					return "PlaybackContextIdsIn";
				case ROOT_ENTRY_ID_IN:
					return "RootEntryIdIn";
				case ERROR_CODE_IN:
					return "ErrorCodeIn";
				case PLAYER_VERSION_IN:
					return "PlayerVersionIn";
				case ISP_IN:
					return "IspIn";
				case APPLICATION_VERSION_IN:
					return "ApplicationVersionIn";
				case NODE_IDS_IN:
					return "NodeIdsIn";
				case CATEGORIES_ANCESTOR_ID_IN:
					return "CategoriesAncestorIdIn";
				case HOTSPOT_ID_IN:
					return "HotspotIdIn";
				case CRM_ID_IN:
					return "CrmIdIn";
				case PLAYLIST_ID_IN:
					return "PlaylistIdIn";
				case DOMAIN_IN:
					return "DomainIn";
				case CANONICAL_URL_IN:
					return "CanonicalUrlIn";
				case VIRTUAL_EVENT_ID_IN:
					return "VirtualEventIdIn";
				case ORIGIN_IN:
					return "OriginIn";
				case UI_CONF_ID_IN:
					return "UiConfIdIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}


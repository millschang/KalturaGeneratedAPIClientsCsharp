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
	public class KalturaPlaylist : KalturaBaseEntry
	{
		#region Private Fields
		private string _PlaylistContent = null;
		private IList<KalturaMediaEntryFilterForPlaylist> _Filters;
		private int _TotalResults = Int32.MinValue;
		private KalturaPlaylistType _PlaylistType = (KalturaPlaylistType)Int32.MinValue;
		private int _Plays = Int32.MinValue;
		private int _Views = Int32.MinValue;
		private int _Duration = Int32.MinValue;
		private string _ExecuteUrl = null;
		#endregion

		#region Properties
		public string PlaylistContent
		{
			get { return _PlaylistContent; }
			set 
			{ 
				_PlaylistContent = value;
				OnPropertyChanged("PlaylistContent");
			}
		}
		public new IList<KalturaMediaEntryFilterForPlaylist> Filters
		{
			get { return _Filters; }
			set 
			{ 
				_Filters = value;
				OnPropertyChanged("Filters");
			}
		}
		public int TotalResults
		{
			get { return _TotalResults; }
			set 
			{ 
				_TotalResults = value;
				OnPropertyChanged("TotalResults");
			}
		}
		public KalturaPlaylistType PlaylistType
		{
			get { return _PlaylistType; }
			set 
			{ 
				_PlaylistType = value;
				OnPropertyChanged("PlaylistType");
			}
		}
		public int Plays
		{
			get { return _Plays; }
		}
		public int Views
		{
			get { return _Views; }
		}
		public int Duration
		{
			get { return _Duration; }
		}
		public string ExecuteUrl
		{
			get { return _ExecuteUrl; }
		}
		#endregion

		#region CTor
		public KalturaPlaylist()
		{
		}

		public KalturaPlaylist(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "playlistContent":
						this._PlaylistContent = txt;
						continue;
					case "filters":
						this._Filters = new List<KalturaMediaEntryFilterForPlaylist>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Filters.Add((KalturaMediaEntryFilterForPlaylist)KalturaObjectFactory.Create(arrayNode, "KalturaMediaEntryFilterForPlaylist"));
						}
						continue;
					case "totalResults":
						this._TotalResults = ParseInt(txt);
						continue;
					case "playlistType":
						this._PlaylistType = (KalturaPlaylistType)ParseEnum(typeof(KalturaPlaylistType), txt);
						continue;
					case "plays":
						this._Plays = ParseInt(txt);
						continue;
					case "views":
						this._Views = ParseInt(txt);
						continue;
					case "duration":
						this._Duration = ParseInt(txt);
						continue;
					case "executeUrl":
						this._ExecuteUrl = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaPlaylist");
			kparams.AddIfNotNull("playlistContent", this._PlaylistContent);
			kparams.AddIfNotNull("filters", this._Filters);
			kparams.AddIfNotNull("totalResults", this._TotalResults);
			kparams.AddIfNotNull("playlistType", this._PlaylistType);
			kparams.AddIfNotNull("plays", this._Plays);
			kparams.AddIfNotNull("views", this._Views);
			kparams.AddIfNotNull("duration", this._Duration);
			kparams.AddIfNotNull("executeUrl", this._ExecuteUrl);
			return kparams;
		}
		#endregion
	}
}


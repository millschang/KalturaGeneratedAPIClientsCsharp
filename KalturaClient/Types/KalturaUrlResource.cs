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
	public class KalturaUrlResource : KalturaContentResource
	{
		#region Private Fields
		private string _Url = null;
		private bool? _ForceAsyncDownload = false;
		#endregion

		#region Properties
		public string Url
		{
			get { return _Url; }
			set 
			{ 
				_Url = value;
				OnPropertyChanged("Url");
			}
		}
		public bool? ForceAsyncDownload
		{
			get { return _ForceAsyncDownload; }
			set 
			{ 
				_ForceAsyncDownload = value;
				OnPropertyChanged("ForceAsyncDownload");
			}
		}
		#endregion

		#region CTor
		public KalturaUrlResource()
		{
		}

		public KalturaUrlResource(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "url":
						this.Url = txt;
						continue;
					case "forceAsyncDownload":
						this.ForceAsyncDownload = ParseBool(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaUrlResource");
			kparams.AddIfNotNull("url", this.Url);
			kparams.AddIfNotNull("forceAsyncDownload", this.ForceAsyncDownload);
			return kparams;
		}
		#endregion
	}
}


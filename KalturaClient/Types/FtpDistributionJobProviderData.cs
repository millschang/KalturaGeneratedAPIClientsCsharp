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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class FtpDistributionJobProviderData : ConfigurableDistributionJobProviderData
	{
		#region Constants
		public const string FILES_FOR_DISTRIBUTION = "filesForDistribution";
		#endregion

		#region Private Fields
		private IList<FtpDistributionFile> _FilesForDistribution;
		#endregion

		#region Properties
		[JsonProperty]
		public IList<FtpDistributionFile> FilesForDistribution
		{
			get { return _FilesForDistribution; }
			set 
			{ 
				_FilesForDistribution = value;
				OnPropertyChanged("FilesForDistribution");
			}
		}
		#endregion

		#region CTor
		public FtpDistributionJobProviderData()
		{
		}

		public FtpDistributionJobProviderData(JToken node) : base(node)
		{
			if(node["filesForDistribution"] != null)
			{
				this._FilesForDistribution = new List<FtpDistributionFile>();
				foreach(var arrayNode in node["filesForDistribution"].Children())
				{
					this._FilesForDistribution.Add(ObjectFactory.Create<FtpDistributionFile>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaFtpDistributionJobProviderData");
			kparams.AddIfNotNull("filesForDistribution", this._FilesForDistribution);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FILES_FOR_DISTRIBUTION:
					return "FilesForDistribution";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}


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
using Kaltura.Types;
using Kaltura.Enums;

namespace Kaltura
{
	public class Client : ClientBase
	{
		public Client(Configuration config) : base(config)
		{
				ApiVersion = "18.16.0";
				ClientTag = "dotnet:22-10-19";
		}
	
		#region Properties
			
 		public string ClientTag
 		{
 			get
 			{
 				return clientConfiguration.ClientTag;
 			}
 			set
 			{
 				clientConfiguration.ClientTag = value;
 			}
 		}
			
 		public void setClientTag(string value)
 		{
 			ClientTag = value;
 		}
			
 		public string getClientTag()
 		{
 			return ClientTag;
 		}
			
 		public string ApiVersion
 		{
 			get
 			{
 				return clientConfiguration.ApiVersion;
 			}
 			set
 			{
 				clientConfiguration.ApiVersion = value;
 			}
 		}
			
 		public void setApiVersion(string value)
 		{
 			ApiVersion = value;
 		}
			
 		public string getApiVersion()
 		{
 			return ApiVersion;
 		}
			
 		public int PartnerId
 		{
 			get
 			{
 				return requestConfiguration.PartnerId;
 			}
 			set
 			{
 				requestConfiguration.PartnerId = value;
 			}
 		}
			
 		public void setPartnerId(int value)
 		{
 			PartnerId = value;
 		}
			
 		public int getPartnerId()
 		{
 			return PartnerId;
 		}
			
 		public string KS
 		{
 			get
 			{
 				return requestConfiguration.Ks;
 			}
 			set
 			{
 				requestConfiguration.Ks = value;
 			}
 		}
			
 		public void setKS(string value)
 		{
 			KS = value;
 		}
			
 		public string getKS()
 		{
 			return KS;
 		}
			
 		public string SessionId
 		{
 			get
 			{
 				return requestConfiguration.Ks;
 			}
 			set
 			{
 				requestConfiguration.Ks = value;
 			}
 		}
			
 		public void setSessionId(string value)
 		{
 			SessionId = value;
 		}
			
 		public string getSessionId()
 		{
 			return SessionId;
 		}
			
 		public string Language
 		{
 			get
 			{
 				return requestConfiguration.Language;
 			}
 			set
 			{
 				requestConfiguration.Language = value;
 			}
 		}
			
 		public void setLanguage(string value)
 		{
 			Language = value;
 		}
			
 		public string getLanguage()
 		{
 			return Language;
 		}
		#endregion
	}
}

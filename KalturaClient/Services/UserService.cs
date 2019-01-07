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
using System.IO;
using Kaltura.Request;
using Kaltura.Types;
using Kaltura.Enums;
using Newtonsoft.Json.Linq;

namespace Kaltura.Services
{
	public class UserAddRequestBuilder : RequestBuilder<User>
	{
		#region Constants
		public const string USER = "user";
		#endregion

		public User User
		{
			set;
			get;
		}

		public UserAddRequestBuilder()
			: base("user", "add")
		{
		}

		public UserAddRequestBuilder(User user)
			: this()
		{
			this.User = user;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("user"))
				kparams.AddIfNotNull("user", User);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<User>(result);
		}
	}

	public class UserAddFromBulkUploadRequestBuilder : RequestBuilder<BulkUpload>
	{
		#region Constants
		public const string FILE_DATA = "fileData";
		public const string BULK_UPLOAD_DATA = "bulkUploadData";
		public const string BULK_UPLOAD_USER_DATA = "bulkUploadUserData";
		#endregion

		public Stream FileData
		{
			set;
			get;
		}
		public BulkUploadJobData BulkUploadData
		{
			set;
			get;
		}
		public BulkUploadUserData BulkUploadUserData
		{
			set;
			get;
		}

		public UserAddFromBulkUploadRequestBuilder()
			: base("user", "addFromBulkUpload")
		{
		}

		public UserAddFromBulkUploadRequestBuilder(Stream fileData, BulkUploadJobData bulkUploadData, BulkUploadUserData bulkUploadUserData)
			: this()
		{
			this.FileData = fileData;
			this.BulkUploadData = bulkUploadData;
			this.BulkUploadUserData = bulkUploadUserData;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("bulkUploadData"))
				kparams.AddIfNotNull("bulkUploadData", BulkUploadData);
			if (!isMapped("bulkUploadUserData"))
				kparams.AddIfNotNull("bulkUploadUserData", BulkUploadUserData);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			kfiles.Add("fileData", FileData);
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<BulkUpload>(result);
		}
	}

	public class UserCheckLoginDataExistsRequestBuilder : RequestBuilder<bool>
	{
		#region Constants
		public const string FILTER = "filter";
		#endregion

		public UserLoginDataFilter Filter
		{
			set;
			get;
		}

		public UserCheckLoginDataExistsRequestBuilder()
			: base("user", "checkLoginDataExists")
		{
		}

		public UserCheckLoginDataExistsRequestBuilder(UserLoginDataFilter filter)
			: this()
		{
			this.Filter = filter;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			if (result.Value<string>().Equals("1") || result.Value<string>().ToLower().Equals("true"))
				return true;
			return false;
		}
	}

	public class UserDeleteRequestBuilder : RequestBuilder<User>
	{
		#region Constants
		public const string USER_ID = "userId";
		#endregion

		public string UserId
		{
			set;
			get;
		}

		public UserDeleteRequestBuilder()
			: base("user", "delete")
		{
		}

		public UserDeleteRequestBuilder(string userId)
			: this()
		{
			this.UserId = userId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("userId"))
				kparams.AddIfNotNull("userId", UserId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<User>(result);
		}
	}

	public class UserDisableLoginRequestBuilder : RequestBuilder<User>
	{
		#region Constants
		public const string USER_ID = "userId";
		public const string LOGIN_ID = "loginId";
		#endregion

		public string UserId
		{
			set;
			get;
		}
		public string LoginId
		{
			set;
			get;
		}

		public UserDisableLoginRequestBuilder()
			: base("user", "disableLogin")
		{
		}

		public UserDisableLoginRequestBuilder(string userId, string loginId)
			: this()
		{
			this.UserId = userId;
			this.LoginId = loginId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("userId"))
				kparams.AddIfNotNull("userId", UserId);
			if (!isMapped("loginId"))
				kparams.AddIfNotNull("loginId", LoginId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<User>(result);
		}
	}

	public class UserEnableLoginRequestBuilder : RequestBuilder<User>
	{
		#region Constants
		public const string USER_ID = "userId";
		public const string LOGIN_ID = "loginId";
		public const string PASSWORD = "password";
		#endregion

		public string UserId
		{
			set;
			get;
		}
		public string LoginId
		{
			set;
			get;
		}
		public string Password
		{
			set;
			get;
		}

		public UserEnableLoginRequestBuilder()
			: base("user", "enableLogin")
		{
		}

		public UserEnableLoginRequestBuilder(string userId, string loginId, string password)
			: this()
		{
			this.UserId = userId;
			this.LoginId = loginId;
			this.Password = password;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("userId"))
				kparams.AddIfNotNull("userId", UserId);
			if (!isMapped("loginId"))
				kparams.AddIfNotNull("loginId", LoginId);
			if (!isMapped("password"))
				kparams.AddIfNotNull("password", Password);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<User>(result);
		}
	}

	public class UserExportToCsvRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string METADATA_PROFILE_ID = "metadataProfileId";
		public const string ADDITIONAL_FIELDS = "additionalFields";
		#endregion

		public UserFilter Filter
		{
			set;
			get;
		}
		public int MetadataProfileId
		{
			set;
			get;
		}
		public IList<CsvAdditionalFieldInfo> AdditionalFields
		{
			set;
			get;
		}

		public UserExportToCsvRequestBuilder()
			: base("user", "exportToCsv")
		{
		}

		public UserExportToCsvRequestBuilder(UserFilter filter, int metadataProfileId, IList<CsvAdditionalFieldInfo> additionalFields)
			: this()
		{
			this.Filter = filter;
			this.MetadataProfileId = metadataProfileId;
			this.AdditionalFields = additionalFields;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			if (!isMapped("metadataProfileId"))
				kparams.AddIfNotNull("metadataProfileId", MetadataProfileId);
			if (!isMapped("additionalFields"))
				kparams.AddIfNotNull("additionalFields", AdditionalFields);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return result.Value<string>();
		}
	}

	public class UserGetRequestBuilder : RequestBuilder<User>
	{
		#region Constants
		public const string USER_ID = "userId";
		#endregion

		public string UserId
		{
			set;
			get;
		}

		public UserGetRequestBuilder()
			: base("user", "get")
		{
		}

		public UserGetRequestBuilder(string userId)
			: this()
		{
			this.UserId = userId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("userId"))
				kparams.AddIfNotNull("userId", UserId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<User>(result);
		}
	}

	public class UserGetByLoginIdRequestBuilder : RequestBuilder<User>
	{
		#region Constants
		public const string LOGIN_ID = "loginId";
		#endregion

		public string LoginId
		{
			set;
			get;
		}

		public UserGetByLoginIdRequestBuilder()
			: base("user", "getByLoginId")
		{
		}

		public UserGetByLoginIdRequestBuilder(string loginId)
			: this()
		{
			this.LoginId = loginId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("loginId"))
				kparams.AddIfNotNull("loginId", LoginId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<User>(result);
		}
	}

	public class UserIndexRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string ID = "id";
		public const string SHOULD_UPDATE = "shouldUpdate";
		#endregion

		public string Id
		{
			set;
			get;
		}
		public bool ShouldUpdate
		{
			set;
			get;
		}

		public UserIndexRequestBuilder()
			: base("user", "index")
		{
		}

		public UserIndexRequestBuilder(string id, bool shouldUpdate)
			: this()
		{
			this.Id = id;
			this.ShouldUpdate = shouldUpdate;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("shouldUpdate"))
				kparams.AddIfNotNull("shouldUpdate", ShouldUpdate);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return result.Value<string>();
		}
	}

	public class UserListRequestBuilder : RequestBuilder<ListResponse<User>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public UserFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public UserListRequestBuilder()
			: base("user", "list")
		{
		}

		public UserListRequestBuilder(UserFilter filter, FilterPager pager)
			: this()
		{
			this.Filter = filter;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			if (!isMapped("pager"))
				kparams.AddIfNotNull("pager", Pager);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ListResponse<User>>(result);
		}
	}

	public class UserLoginRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public new const string PARTNER_ID = "partnerId";
		public const string USER_ID = "userId";
		public const string PASSWORD = "password";
		public const string EXPIRY = "expiry";
		public const string PRIVILEGES = "privileges";
		#endregion

		public new int PartnerId
		{
			set;
			get;
		}
		public string UserId
		{
			set;
			get;
		}
		public string Password
		{
			set;
			get;
		}
		public int Expiry
		{
			set;
			get;
		}
		public string Privileges
		{
			set;
			get;
		}

		public UserLoginRequestBuilder()
			: base("user", "login")
		{
		}

		public UserLoginRequestBuilder(int partnerId, string userId, string password, int expiry, string privileges)
			: this()
		{
			this.PartnerId = partnerId;
			this.UserId = userId;
			this.Password = password;
			this.Expiry = expiry;
			this.Privileges = privileges;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("partnerId"))
				kparams.AddIfNotNull("partnerId", PartnerId);
			if (!isMapped("userId"))
				kparams.AddIfNotNull("userId", UserId);
			if (!isMapped("password"))
				kparams.AddIfNotNull("password", Password);
			if (!isMapped("expiry"))
				kparams.AddIfNotNull("expiry", Expiry);
			if (!isMapped("privileges"))
				kparams.AddIfNotNull("privileges", Privileges);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return result.Value<string>();
		}
	}

	public class UserLoginByKsRequestBuilder : RequestBuilder<SessionResponse>
	{
		#region Constants
		public const string REQUESTED_PARTNER_ID = "requestedPartnerId";
		#endregion

		public int RequestedPartnerId
		{
			set;
			get;
		}

		public UserLoginByKsRequestBuilder()
			: base("user", "loginByKs")
		{
		}

		public UserLoginByKsRequestBuilder(int requestedPartnerId)
			: this()
		{
			this.RequestedPartnerId = requestedPartnerId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("requestedPartnerId"))
				kparams.AddIfNotNull("requestedPartnerId", RequestedPartnerId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<SessionResponse>(result);
		}
	}

	public class UserLoginByLoginIdRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string LOGIN_ID = "loginId";
		public const string PASSWORD = "password";
		public new const string PARTNER_ID = "partnerId";
		public const string EXPIRY = "expiry";
		public const string PRIVILEGES = "privileges";
		public const string OTP = "otp";
		#endregion

		public string LoginId
		{
			set;
			get;
		}
		public string Password
		{
			set;
			get;
		}
		public new int PartnerId
		{
			set;
			get;
		}
		public int Expiry
		{
			set;
			get;
		}
		public string Privileges
		{
			set;
			get;
		}
		public string Otp
		{
			set;
			get;
		}

		public UserLoginByLoginIdRequestBuilder()
			: base("user", "loginByLoginId")
		{
		}

		public UserLoginByLoginIdRequestBuilder(string loginId, string password, int partnerId, int expiry, string privileges, string otp)
			: this()
		{
			this.LoginId = loginId;
			this.Password = password;
			this.PartnerId = partnerId;
			this.Expiry = expiry;
			this.Privileges = privileges;
			this.Otp = otp;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("loginId"))
				kparams.AddIfNotNull("loginId", LoginId);
			if (!isMapped("password"))
				kparams.AddIfNotNull("password", Password);
			if (!isMapped("partnerId"))
				kparams.AddIfNotNull("partnerId", PartnerId);
			if (!isMapped("expiry"))
				kparams.AddIfNotNull("expiry", Expiry);
			if (!isMapped("privileges"))
				kparams.AddIfNotNull("privileges", Privileges);
			if (!isMapped("otp"))
				kparams.AddIfNotNull("otp", Otp);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return result.Value<string>();
		}
	}

	public class UserNotifyBanRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string USER_ID = "userId";
		#endregion

		public string UserId
		{
			set;
			get;
		}

		public UserNotifyBanRequestBuilder()
			: base("user", "notifyBan")
		{
		}

		public UserNotifyBanRequestBuilder(string userId)
			: this()
		{
			this.UserId = userId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("userId"))
				kparams.AddIfNotNull("userId", UserId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return null;
		}
	}

	public class UserResetPasswordRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string EMAIL = "email";
		#endregion

		public string Email
		{
			set;
			get;
		}

		public UserResetPasswordRequestBuilder()
			: base("user", "resetPassword")
		{
		}

		public UserResetPasswordRequestBuilder(string email)
			: this()
		{
			this.Email = email;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("email"))
				kparams.AddIfNotNull("email", Email);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return null;
		}
	}

	public class UserServeCsvRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id
		{
			set;
			get;
		}

		public UserServeCsvRequestBuilder()
			: base("user", "serveCsv")
		{
		}

		public UserServeCsvRequestBuilder(string id)
			: this()
		{
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return result.Value<string>();
		}
	}

	public class UserSetInitialPasswordRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string HASH_KEY = "hashKey";
		public const string NEW_PASSWORD = "newPassword";
		#endregion

		public string HashKey
		{
			set;
			get;
		}
		public string NewPassword
		{
			set;
			get;
		}

		public UserSetInitialPasswordRequestBuilder()
			: base("user", "setInitialPassword")
		{
		}

		public UserSetInitialPasswordRequestBuilder(string hashKey, string newPassword)
			: this()
		{
			this.HashKey = hashKey;
			this.NewPassword = newPassword;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("hashKey"))
				kparams.AddIfNotNull("hashKey", HashKey);
			if (!isMapped("newPassword"))
				kparams.AddIfNotNull("newPassword", NewPassword);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return null;
		}
	}

	public class UserUpdateRequestBuilder : RequestBuilder<User>
	{
		#region Constants
		public const string USER_ID = "userId";
		public const string USER = "user";
		#endregion

		public string UserId
		{
			set;
			get;
		}
		public User User
		{
			set;
			get;
		}

		public UserUpdateRequestBuilder()
			: base("user", "update")
		{
		}

		public UserUpdateRequestBuilder(string userId, User user)
			: this()
		{
			this.UserId = userId;
			this.User = user;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("userId"))
				kparams.AddIfNotNull("userId", UserId);
			if (!isMapped("user"))
				kparams.AddIfNotNull("user", User);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<User>(result);
		}
	}

	public class UserUpdateLoginDataRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string OLD_LOGIN_ID = "oldLoginId";
		public const string PASSWORD = "password";
		public const string NEW_LOGIN_ID = "newLoginId";
		public const string NEW_PASSWORD = "newPassword";
		public const string NEW_FIRST_NAME = "newFirstName";
		public const string NEW_LAST_NAME = "newLastName";
		#endregion

		public string OldLoginId
		{
			set;
			get;
		}
		public string Password
		{
			set;
			get;
		}
		public string NewLoginId
		{
			set;
			get;
		}
		public string NewPassword
		{
			set;
			get;
		}
		public string NewFirstName
		{
			set;
			get;
		}
		public string NewLastName
		{
			set;
			get;
		}

		public UserUpdateLoginDataRequestBuilder()
			: base("user", "updateLoginData")
		{
		}

		public UserUpdateLoginDataRequestBuilder(string oldLoginId, string password, string newLoginId, string newPassword, string newFirstName, string newLastName)
			: this()
		{
			this.OldLoginId = oldLoginId;
			this.Password = password;
			this.NewLoginId = newLoginId;
			this.NewPassword = newPassword;
			this.NewFirstName = newFirstName;
			this.NewLastName = newLastName;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("oldLoginId"))
				kparams.AddIfNotNull("oldLoginId", OldLoginId);
			if (!isMapped("password"))
				kparams.AddIfNotNull("password", Password);
			if (!isMapped("newLoginId"))
				kparams.AddIfNotNull("newLoginId", NewLoginId);
			if (!isMapped("newPassword"))
				kparams.AddIfNotNull("newPassword", NewPassword);
			if (!isMapped("newFirstName"))
				kparams.AddIfNotNull("newFirstName", NewFirstName);
			if (!isMapped("newLastName"))
				kparams.AddIfNotNull("newLastName", NewLastName);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return null;
		}
	}


	public class UserService
	{
		private UserService()
		{
		}

		public static UserAddRequestBuilder Add(User user)
		{
			return new UserAddRequestBuilder(user);
		}

		public static UserAddFromBulkUploadRequestBuilder AddFromBulkUpload(Stream fileData, BulkUploadJobData bulkUploadData = null, BulkUploadUserData bulkUploadUserData = null)
		{
			return new UserAddFromBulkUploadRequestBuilder(fileData, bulkUploadData, bulkUploadUserData);
		}

		public static UserCheckLoginDataExistsRequestBuilder CheckLoginDataExists(UserLoginDataFilter filter)
		{
			return new UserCheckLoginDataExistsRequestBuilder(filter);
		}

		public static UserDeleteRequestBuilder Delete(string userId)
		{
			return new UserDeleteRequestBuilder(userId);
		}

		public static UserDisableLoginRequestBuilder DisableLogin(string userId = null, string loginId = null)
		{
			return new UserDisableLoginRequestBuilder(userId, loginId);
		}

		public static UserEnableLoginRequestBuilder EnableLogin(string userId, string loginId, string password = null)
		{
			return new UserEnableLoginRequestBuilder(userId, loginId, password);
		}

		public static UserExportToCsvRequestBuilder ExportToCsv(UserFilter filter = null, int metadataProfileId = Int32.MinValue, IList<CsvAdditionalFieldInfo> additionalFields = null)
		{
			return new UserExportToCsvRequestBuilder(filter, metadataProfileId, additionalFields);
		}

		public static UserGetRequestBuilder Get(string userId = null)
		{
			return new UserGetRequestBuilder(userId);
		}

		public static UserGetByLoginIdRequestBuilder GetByLoginId(string loginId)
		{
			return new UserGetByLoginIdRequestBuilder(loginId);
		}

		public static UserIndexRequestBuilder Index(string id, bool shouldUpdate = true)
		{
			return new UserIndexRequestBuilder(id, shouldUpdate);
		}

		public static UserListRequestBuilder List(UserFilter filter = null, FilterPager pager = null)
		{
			return new UserListRequestBuilder(filter, pager);
		}

		public static UserLoginRequestBuilder Login(int partnerId, string userId, string password, int expiry = 86400, string privileges = "*")
		{
			return new UserLoginRequestBuilder(partnerId, userId, password, expiry, privileges);
		}

		public static UserLoginByKsRequestBuilder LoginByKs(int requestedPartnerId)
		{
			return new UserLoginByKsRequestBuilder(requestedPartnerId);
		}

		public static UserLoginByLoginIdRequestBuilder LoginByLoginId(string loginId, string password, int partnerId = Int32.MinValue, int expiry = 86400, string privileges = "*", string otp = null)
		{
			return new UserLoginByLoginIdRequestBuilder(loginId, password, partnerId, expiry, privileges, otp);
		}

		public static UserNotifyBanRequestBuilder NotifyBan(string userId)
		{
			return new UserNotifyBanRequestBuilder(userId);
		}

		public static UserResetPasswordRequestBuilder ResetPassword(string email)
		{
			return new UserResetPasswordRequestBuilder(email);
		}

		public static UserServeCsvRequestBuilder ServeCsv(string id)
		{
			return new UserServeCsvRequestBuilder(id);
		}

		public static UserSetInitialPasswordRequestBuilder SetInitialPassword(string hashKey, string newPassword)
		{
			return new UserSetInitialPasswordRequestBuilder(hashKey, newPassword);
		}

		public static UserUpdateRequestBuilder Update(string userId, User user)
		{
			return new UserUpdateRequestBuilder(userId, user);
		}

		public static UserUpdateLoginDataRequestBuilder UpdateLoginData(string oldLoginId, string password, string newLoginId = "", string newPassword = "", string newFirstName = null, string newLastName = null)
		{
			return new UserUpdateLoginDataRequestBuilder(oldLoginId, password, newLoginId, newPassword, newFirstName, newLastName);
		}
	}
}

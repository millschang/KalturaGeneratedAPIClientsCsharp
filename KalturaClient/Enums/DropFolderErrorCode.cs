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
namespace Kaltura.Enums
{
	public sealed class DropFolderErrorCode : StringEnum
	{
		public static readonly DropFolderErrorCode ERROR_CONNECT = new DropFolderErrorCode("1");
		public static readonly DropFolderErrorCode ERROR_AUTENTICATE = new DropFolderErrorCode("2");
		public static readonly DropFolderErrorCode ERROR_GET_PHISICAL_FILE_LIST = new DropFolderErrorCode("3");
		public static readonly DropFolderErrorCode ERROR_GET_DB_FILE_LIST = new DropFolderErrorCode("4");
		public static readonly DropFolderErrorCode DROP_FOLDER_APP_ERROR = new DropFolderErrorCode("5");
		public static readonly DropFolderErrorCode CONTENT_MATCH_POLICY_UNDEFINED = new DropFolderErrorCode("6");
		public static readonly DropFolderErrorCode MISSING_CONFIG = new DropFolderErrorCode("7");

		private DropFolderErrorCode(string name) : base(name) { }
	}
}

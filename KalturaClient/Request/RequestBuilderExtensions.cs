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

namespace Kaltura.Request
{
	public static class RequestBuilderExtensions
	{
		/// <summary>
		/// Impersonated partner id
		/// </summary>
		public static BaseRequestBuilder<T> WithPartnerId<T>(this BaseRequestBuilder<T> requestBuilder, int value)
		{
			requestBuilder.PartnerId = value;
			return requestBuilder;
		}
		/// <summary>
		/// Kaltura API session
		/// </summary>
		public static BaseRequestBuilder<T> WithKs<T>(this BaseRequestBuilder<T> requestBuilder, string value)
		{
			requestBuilder.Ks = value;
			return requestBuilder;
		}
		/// <summary>
		/// language
		/// </summary>
		public static BaseRequestBuilder<T> WithLanguage<T>(this BaseRequestBuilder<T> requestBuilder, string value)
		{
			requestBuilder.Language = value;
			return requestBuilder;
		}
		/// <summary>
		/// Response profile - this attribute will be automatically unset after every API call.
		/// </summary>
		public static BaseRequestBuilder<T> WithResponseProfile<T>(this BaseRequestBuilder<T> requestBuilder, BaseResponseProfile value)
		{
			requestBuilder.ResponseProfile = value;
			return requestBuilder;
		}
	}
}

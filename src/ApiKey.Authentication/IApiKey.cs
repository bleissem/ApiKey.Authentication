﻿// Copyright (c) Mihir Dilip. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace ApiKey.Authentication
{
	/// <summary>
	/// API Key Details
	/// </summary>
	public interface IApiKey
	{
		/// <summary>
		/// API Key
		/// </summary>
		string Key { get; }

		StringComparison StringComparison { get; }

		/// <summary>
		/// Owner of the API Key. It can be username or any other key owner name.
		/// </summary>
		string OwnerName { get; }

		/// <summary>
		/// Optional list of claims to be sent back with the authentication request.
		/// </summary>
		IReadOnlyCollection<Claim> Claims { get; }
	}
}
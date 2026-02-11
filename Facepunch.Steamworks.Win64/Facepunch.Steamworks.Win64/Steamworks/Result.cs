using System;

namespace Steamworks
{
	// Token: 0x02000032 RID: 50
	public enum Result
	{
		// Token: 0x04000857 RID: 2135
		None,
		// Token: 0x04000858 RID: 2136
		OK,
		// Token: 0x04000859 RID: 2137
		Fail,
		// Token: 0x0400085A RID: 2138
		NoConnection,
		// Token: 0x0400085B RID: 2139
		InvalidPassword = 5,
		// Token: 0x0400085C RID: 2140
		LoggedInElsewhere,
		// Token: 0x0400085D RID: 2141
		InvalidProtocolVer,
		// Token: 0x0400085E RID: 2142
		InvalidParam,
		// Token: 0x0400085F RID: 2143
		FileNotFound,
		// Token: 0x04000860 RID: 2144
		Busy,
		// Token: 0x04000861 RID: 2145
		InvalidState,
		// Token: 0x04000862 RID: 2146
		InvalidName,
		// Token: 0x04000863 RID: 2147
		InvalidEmail,
		// Token: 0x04000864 RID: 2148
		DuplicateName,
		// Token: 0x04000865 RID: 2149
		AccessDenied,
		// Token: 0x04000866 RID: 2150
		Timeout,
		// Token: 0x04000867 RID: 2151
		Banned,
		// Token: 0x04000868 RID: 2152
		AccountNotFound,
		// Token: 0x04000869 RID: 2153
		InvalidSteamID,
		// Token: 0x0400086A RID: 2154
		ServiceUnavailable,
		// Token: 0x0400086B RID: 2155
		NotLoggedOn,
		// Token: 0x0400086C RID: 2156
		Pending,
		// Token: 0x0400086D RID: 2157
		EncryptionFailure,
		// Token: 0x0400086E RID: 2158
		InsufficientPrivilege,
		// Token: 0x0400086F RID: 2159
		LimitExceeded,
		// Token: 0x04000870 RID: 2160
		Revoked,
		// Token: 0x04000871 RID: 2161
		Expired,
		// Token: 0x04000872 RID: 2162
		AlreadyRedeemed,
		// Token: 0x04000873 RID: 2163
		DuplicateRequest,
		// Token: 0x04000874 RID: 2164
		AlreadyOwned,
		// Token: 0x04000875 RID: 2165
		IPNotFound,
		// Token: 0x04000876 RID: 2166
		PersistFailed,
		// Token: 0x04000877 RID: 2167
		LockingFailed,
		// Token: 0x04000878 RID: 2168
		LogonSessionReplaced,
		// Token: 0x04000879 RID: 2169
		ConnectFailed,
		// Token: 0x0400087A RID: 2170
		HandshakeFailed,
		// Token: 0x0400087B RID: 2171
		IOFailure,
		// Token: 0x0400087C RID: 2172
		RemoteDisconnect,
		// Token: 0x0400087D RID: 2173
		ShoppingCartNotFound,
		// Token: 0x0400087E RID: 2174
		Blocked,
		// Token: 0x0400087F RID: 2175
		Ignored,
		// Token: 0x04000880 RID: 2176
		NoMatch,
		// Token: 0x04000881 RID: 2177
		AccountDisabled,
		// Token: 0x04000882 RID: 2178
		ServiceReadOnly,
		// Token: 0x04000883 RID: 2179
		AccountNotFeatured,
		// Token: 0x04000884 RID: 2180
		AdministratorOK,
		// Token: 0x04000885 RID: 2181
		ContentVersion,
		// Token: 0x04000886 RID: 2182
		TryAnotherCM,
		// Token: 0x04000887 RID: 2183
		PasswordRequiredToKickSession,
		// Token: 0x04000888 RID: 2184
		AlreadyLoggedInElsewhere,
		// Token: 0x04000889 RID: 2185
		Suspended,
		// Token: 0x0400088A RID: 2186
		Cancelled,
		// Token: 0x0400088B RID: 2187
		DataCorruption,
		// Token: 0x0400088C RID: 2188
		DiskFull,
		// Token: 0x0400088D RID: 2189
		RemoteCallFailed,
		// Token: 0x0400088E RID: 2190
		PasswordUnset,
		// Token: 0x0400088F RID: 2191
		ExternalAccountUnlinked,
		// Token: 0x04000890 RID: 2192
		PSNTicketInvalid,
		// Token: 0x04000891 RID: 2193
		ExternalAccountAlreadyLinked,
		// Token: 0x04000892 RID: 2194
		RemoteFileConflict,
		// Token: 0x04000893 RID: 2195
		IllegalPassword,
		// Token: 0x04000894 RID: 2196
		SameAsPreviousValue,
		// Token: 0x04000895 RID: 2197
		AccountLogonDenied,
		// Token: 0x04000896 RID: 2198
		CannotUseOldPassword,
		// Token: 0x04000897 RID: 2199
		InvalidLoginAuthCode,
		// Token: 0x04000898 RID: 2200
		AccountLogonDeniedNoMail,
		// Token: 0x04000899 RID: 2201
		HardwareNotCapableOfIPT,
		// Token: 0x0400089A RID: 2202
		IPTInitError,
		// Token: 0x0400089B RID: 2203
		ParentalControlRestricted,
		// Token: 0x0400089C RID: 2204
		FacebookQueryError,
		// Token: 0x0400089D RID: 2205
		ExpiredLoginAuthCode,
		// Token: 0x0400089E RID: 2206
		IPLoginRestrictionFailed,
		// Token: 0x0400089F RID: 2207
		AccountLockedDown,
		// Token: 0x040008A0 RID: 2208
		AccountLogonDeniedVerifiedEmailRequired,
		// Token: 0x040008A1 RID: 2209
		NoMatchingURL,
		// Token: 0x040008A2 RID: 2210
		BadResponse,
		// Token: 0x040008A3 RID: 2211
		RequirePasswordReEntry,
		// Token: 0x040008A4 RID: 2212
		ValueOutOfRange,
		// Token: 0x040008A5 RID: 2213
		UnexpectedError,
		// Token: 0x040008A6 RID: 2214
		Disabled,
		// Token: 0x040008A7 RID: 2215
		InvalidCEGSubmission,
		// Token: 0x040008A8 RID: 2216
		RestrictedDevice,
		// Token: 0x040008A9 RID: 2217
		RegionLocked,
		// Token: 0x040008AA RID: 2218
		RateLimitExceeded,
		// Token: 0x040008AB RID: 2219
		AccountLoginDeniedNeedTwoFactor,
		// Token: 0x040008AC RID: 2220
		ItemDeleted,
		// Token: 0x040008AD RID: 2221
		AccountLoginDeniedThrottle,
		// Token: 0x040008AE RID: 2222
		TwoFactorCodeMismatch,
		// Token: 0x040008AF RID: 2223
		TwoFactorActivationCodeMismatch,
		// Token: 0x040008B0 RID: 2224
		AccountAssociatedToMultiplePartners,
		// Token: 0x040008B1 RID: 2225
		NotModified,
		// Token: 0x040008B2 RID: 2226
		NoMobileDevice,
		// Token: 0x040008B3 RID: 2227
		TimeNotSynced,
		// Token: 0x040008B4 RID: 2228
		SmsCodeFailed,
		// Token: 0x040008B5 RID: 2229
		AccountLimitExceeded,
		// Token: 0x040008B6 RID: 2230
		AccountActivityLimitExceeded,
		// Token: 0x040008B7 RID: 2231
		PhoneActivityLimitExceeded,
		// Token: 0x040008B8 RID: 2232
		RefundToWallet,
		// Token: 0x040008B9 RID: 2233
		EmailSendFailure,
		// Token: 0x040008BA RID: 2234
		NotSettled,
		// Token: 0x040008BB RID: 2235
		NeedCaptcha,
		// Token: 0x040008BC RID: 2236
		GSLTDenied,
		// Token: 0x040008BD RID: 2237
		GSOwnerDenied,
		// Token: 0x040008BE RID: 2238
		InvalidItemType,
		// Token: 0x040008BF RID: 2239
		IPBanned,
		// Token: 0x040008C0 RID: 2240
		GSLTExpired,
		// Token: 0x040008C1 RID: 2241
		InsufficientFunds,
		// Token: 0x040008C2 RID: 2242
		TooManyPending,
		// Token: 0x040008C3 RID: 2243
		NoSiteLicensesFound,
		// Token: 0x040008C4 RID: 2244
		WGNetworkSendExceeded,
		// Token: 0x040008C5 RID: 2245
		AccountNotFriends,
		// Token: 0x040008C6 RID: 2246
		LimitedUserAccount,
		// Token: 0x040008C7 RID: 2247
		CantRemoveItem,
		// Token: 0x040008C8 RID: 2248
		AccountDeleted,
		// Token: 0x040008C9 RID: 2249
		ExistingUserCancelledLicense,
		// Token: 0x040008CA RID: 2250
		CommunityCooldown,
		// Token: 0x040008CB RID: 2251
		NoLauncherSpecified,
		// Token: 0x040008CC RID: 2252
		MustAgreeToSSA,
		// Token: 0x040008CD RID: 2253
		LauncherMigrated,
		// Token: 0x040008CE RID: 2254
		SteamRealmMismatch,
		// Token: 0x040008CF RID: 2255
		InvalidSignature,
		// Token: 0x040008D0 RID: 2256
		ParseFailure,
		// Token: 0x040008D1 RID: 2257
		NoVerifiedPhone
	}
}

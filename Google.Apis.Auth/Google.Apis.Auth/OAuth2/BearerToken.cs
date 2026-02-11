using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Net.Http;

namespace Google.Apis.Auth.OAuth2
{
	// Token: 0x02000009 RID: 9
	public class BearerToken : Object
	{
		// Token: 0x0600004C RID: 76 RVA: 0x0000227E File Offset: 0x0000047E
		// Note: this type is marked as 'beforefieldinit'.
		static BearerToken()
		{
			Il2CppClassPointerStore<BearerToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2", "BearerToken");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BearerToken>.NativeClassPtr);
			BearerToken.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearerToken>.NativeClassPtr, 100663415);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00008200 File Offset: 0x00006400
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BearerToken()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BearerToken>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearerToken.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000022B7 File Offset: 0x000004B7
		public BearerToken(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200003D RID: 61
		public class AuthorizationHeaderAccessMethod : Object
		{
			// Token: 0x060003F8 RID: 1016 RVA: 0x00014A64 File Offset: 0x00012C64
			// Note: this type is marked as 'beforefieldinit'.
			static AuthorizationHeaderAccessMethod()
			{
				Il2CppClassPointerStore<BearerToken.AuthorizationHeaderAccessMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BearerToken>.NativeClassPtr, "AuthorizationHeaderAccessMethod");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BearerToken.AuthorizationHeaderAccessMethod>.NativeClassPtr);
				BearerToken.AuthorizationHeaderAccessMethod.NativeFieldInfoPtr_Schema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearerToken.AuthorizationHeaderAccessMethod>.NativeClassPtr, "Schema");
				BearerToken.AuthorizationHeaderAccessMethod.NativeMethodInfoPtr_Intercept_Public_Virtual_Final_New_Void_HttpRequestMessage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearerToken.AuthorizationHeaderAccessMethod>.NativeClassPtr, 100663416);
				BearerToken.AuthorizationHeaderAccessMethod.NativeMethodInfoPtr_GetAccessToken_Public_Virtual_Final_New_String_HttpRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearerToken.AuthorizationHeaderAccessMethod>.NativeClassPtr, 100663417);
				BearerToken.AuthorizationHeaderAccessMethod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearerToken.AuthorizationHeaderAccessMethod>.NativeClassPtr, 100663418);
			}

			// Token: 0x060003F9 RID: 1017 RVA: 0x00014AE0 File Offset: 0x00012CE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152842, XrefRangeEnd = 1152851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Intercept(HttpRequestMessage request, string accessToken)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(accessToken);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearerToken.AuthorizationHeaderAccessMethod.NativeMethodInfoPtr_Intercept_Public_Virtual_Final_New_Void_HttpRequestMessage_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003FA RID: 1018 RVA: 0x00014B34 File Offset: 0x00012D34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152851, XrefRangeEnd = 1152860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual string GetAccessToken(HttpRequestMessage request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearerToken.AuthorizationHeaderAccessMethod.NativeMethodInfoPtr_GetAccessToken_Public_Virtual_Final_New_String_HttpRequestMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060003FB RID: 1019 RVA: 0x00014B7C File Offset: 0x00012D7C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AuthorizationHeaderAccessMethod()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BearerToken.AuthorizationHeaderAccessMethod>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearerToken.AuthorizationHeaderAccessMethod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003FC RID: 1020 RVA: 0x00003E5C File Offset: 0x0000205C
			public AuthorizationHeaderAccessMethod(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700017B RID: 379
			// (get) Token: 0x060003FD RID: 1021 RVA: 0x00014BB8 File Offset: 0x00012DB8
			// (set) Token: 0x060003FE RID: 1022 RVA: 0x00003E65 File Offset: 0x00002065
			public unsafe static string Schema
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BearerToken.AuthorizationHeaderAccessMethod.NativeFieldInfoPtr_Schema, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BearerToken.AuthorizationHeaderAccessMethod.NativeFieldInfoPtr_Schema, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000292 RID: 658
			private static readonly IntPtr NativeFieldInfoPtr_Schema;

			// Token: 0x04000293 RID: 659
			private static readonly IntPtr NativeMethodInfoPtr_Intercept_Public_Virtual_Final_New_Void_HttpRequestMessage_String_0;

			// Token: 0x04000294 RID: 660
			private static readonly IntPtr NativeMethodInfoPtr_GetAccessToken_Public_Virtual_Final_New_String_HttpRequestMessage_0;

			// Token: 0x04000295 RID: 661
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200003E RID: 62
		public class QueryParameterAccessMethod : Object
		{
			// Token: 0x060003FF RID: 1023 RVA: 0x00014BD8 File Offset: 0x00012DD8
			// Note: this type is marked as 'beforefieldinit'.
			static QueryParameterAccessMethod()
			{
				Il2CppClassPointerStore<BearerToken.QueryParameterAccessMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BearerToken>.NativeClassPtr, "QueryParameterAccessMethod");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BearerToken.QueryParameterAccessMethod>.NativeClassPtr);
				BearerToken.QueryParameterAccessMethod.NativeFieldInfoPtr_AccessTokenKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BearerToken.QueryParameterAccessMethod>.NativeClassPtr, "AccessTokenKey");
				BearerToken.QueryParameterAccessMethod.NativeMethodInfoPtr_Intercept_Public_Virtual_Final_New_Void_HttpRequestMessage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearerToken.QueryParameterAccessMethod>.NativeClassPtr, 100663419);
				BearerToken.QueryParameterAccessMethod.NativeMethodInfoPtr_GetAccessToken_Public_Virtual_Final_New_String_HttpRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearerToken.QueryParameterAccessMethod>.NativeClassPtr, 100663420);
				BearerToken.QueryParameterAccessMethod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BearerToken.QueryParameterAccessMethod>.NativeClassPtr, 100663421);
			}

			// Token: 0x06000400 RID: 1024 RVA: 0x00014C54 File Offset: 0x00012E54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152860, XrefRangeEnd = 1152901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Intercept(HttpRequestMessage request, string accessToken)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(accessToken);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearerToken.QueryParameterAccessMethod.NativeMethodInfoPtr_Intercept_Public_Virtual_Final_New_Void_HttpRequestMessage_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000401 RID: 1025 RVA: 0x00014CA8 File Offset: 0x00012EA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152901, XrefRangeEnd = 1152915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual string GetAccessToken(HttpRequestMessage request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearerToken.QueryParameterAccessMethod.NativeMethodInfoPtr_GetAccessToken_Public_Virtual_Final_New_String_HttpRequestMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000402 RID: 1026 RVA: 0x00014CF0 File Offset: 0x00012EF0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe QueryParameterAccessMethod()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BearerToken.QueryParameterAccessMethod>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BearerToken.QueryParameterAccessMethod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000403 RID: 1027 RVA: 0x00003E77 File Offset: 0x00002077
			public QueryParameterAccessMethod(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700017C RID: 380
			// (get) Token: 0x06000404 RID: 1028 RVA: 0x00014D2C File Offset: 0x00012F2C
			// (set) Token: 0x06000405 RID: 1029 RVA: 0x00003E80 File Offset: 0x00002080
			public unsafe static string AccessTokenKey
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BearerToken.QueryParameterAccessMethod.NativeFieldInfoPtr_AccessTokenKey, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BearerToken.QueryParameterAccessMethod.NativeFieldInfoPtr_AccessTokenKey, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000296 RID: 662
			private static readonly IntPtr NativeFieldInfoPtr_AccessTokenKey;

			// Token: 0x04000297 RID: 663
			private static readonly IntPtr NativeMethodInfoPtr_Intercept_Public_Virtual_Final_New_Void_HttpRequestMessage_String_0;

			// Token: 0x04000298 RID: 664
			private static readonly IntPtr NativeMethodInfoPtr_GetAccessToken_Public_Virtual_Final_New_String_HttpRequestMessage_0;

			// Token: 0x04000299 RID: 665
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

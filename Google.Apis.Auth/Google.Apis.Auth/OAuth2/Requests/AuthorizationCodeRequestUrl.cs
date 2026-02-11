using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Auth.OAuth2.Requests
{
	// Token: 0x02000026 RID: 38
	public class AuthorizationCodeRequestUrl : AuthorizationRequestUrl
	{
		// Token: 0x06000235 RID: 565 RVA: 0x0000EBD0 File Offset: 0x0000CDD0
		// Note: this type is marked as 'beforefieldinit'.
		static AuthorizationCodeRequestUrl()
		{
			Il2CppClassPointerStore<AuthorizationCodeRequestUrl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2.Requests", "AuthorizationCodeRequestUrl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthorizationCodeRequestUrl>.NativeClassPtr);
			AuthorizationCodeRequestUrl.NativeMethodInfoPtr__ctor_Public_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeRequestUrl>.NativeClassPtr, 100663799);
			AuthorizationCodeRequestUrl.NativeMethodInfoPtr_Build_Public_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeRequestUrl>.NativeClassPtr, 100663800);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000EC28 File Offset: 0x0000CE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156920, XrefRangeEnd = 1156925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthorizationCodeRequestUrl(Uri authorizationServerUrl)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthorizationCodeRequestUrl>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(authorizationServerUrl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeRequestUrl.NativeMethodInfoPtr__ctor_Public_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000EC74 File Offset: 0x0000CE74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1156936, RefRangeEnd = 1156939, XrefRangeStart = 1156925, XrefRangeEnd = 1156936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri Build()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeRequestUrl.NativeMethodInfoPtr_Build_Public_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002F5E File Offset: 0x0000115E
		public AuthorizationCodeRequestUrl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Uri_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Uri_0;
	}
}

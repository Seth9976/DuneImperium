using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Google.Apis.Auth.OAuth2.Requests
{
	// Token: 0x0200002C RID: 44
	public class RefreshTokenRequest : TokenRequest
	{
		// Token: 0x0600028F RID: 655 RVA: 0x0000FEF8 File Offset: 0x0000E0F8
		// Note: this type is marked as 'beforefieldinit'.
		static RefreshTokenRequest()
		{
			Il2CppClassPointerStore<RefreshTokenRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2.Requests", "RefreshTokenRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RefreshTokenRequest>.NativeClassPtr);
			RefreshTokenRequest.NativeFieldInfoPtr__RefreshToken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefreshTokenRequest>.NativeClassPtr, "<RefreshToken>k__BackingField");
			RefreshTokenRequest.NativeMethodInfoPtr_get_RefreshToken_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefreshTokenRequest>.NativeClassPtr, 100663841);
			RefreshTokenRequest.NativeMethodInfoPtr_set_RefreshToken_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefreshTokenRequest>.NativeClassPtr, 100663842);
			RefreshTokenRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefreshTokenRequest>.NativeClassPtr, 100663843);
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0000FF78 File Offset: 0x0000E178
		// (set) Token: 0x06000291 RID: 657 RVA: 0x0000FFB0 File Offset: 0x0000E1B0
		public unsafe string RefreshToken
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefreshTokenRequest.NativeMethodInfoPtr_get_RefreshToken_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefreshTokenRequest.NativeMethodInfoPtr_set_RefreshToken_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000FFF4 File Offset: 0x0000E1F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1156975, RefRangeEnd = 1156976, XrefRangeStart = 1156971, XrefRangeEnd = 1156975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RefreshTokenRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RefreshTokenRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefreshTokenRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x000031C2 File Offset: 0x000013C2
		public RefreshTokenRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000294 RID: 660 RVA: 0x00010030 File Offset: 0x0000E230
		// (set) Token: 0x06000295 RID: 661 RVA: 0x000031CB File Offset: 0x000013CB
		public unsafe string _RefreshToken_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RefreshTokenRequest.NativeFieldInfoPtr__RefreshToken_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RefreshTokenRequest.NativeFieldInfoPtr__RefreshToken_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeFieldInfoPtr__RefreshToken_k__BackingField;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_get_RefreshToken_Public_get_String_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_set_RefreshToken_Public_set_Void_String_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

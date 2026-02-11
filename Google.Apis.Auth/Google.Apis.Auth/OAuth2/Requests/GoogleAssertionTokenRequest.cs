using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Google.Apis.Auth.OAuth2.Requests
{
	// Token: 0x02000029 RID: 41
	public class GoogleAssertionTokenRequest : TokenRequest
	{
		// Token: 0x0600025E RID: 606 RVA: 0x0000F47C File Offset: 0x0000D67C
		// Note: this type is marked as 'beforefieldinit'.
		static GoogleAssertionTokenRequest()
		{
			Il2CppClassPointerStore<GoogleAssertionTokenRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2.Requests", "GoogleAssertionTokenRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleAssertionTokenRequest>.NativeClassPtr);
			GoogleAssertionTokenRequest.NativeFieldInfoPtr__Assertion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAssertionTokenRequest>.NativeClassPtr, "<Assertion>k__BackingField");
			GoogleAssertionTokenRequest.NativeMethodInfoPtr_get_Assertion_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAssertionTokenRequest>.NativeClassPtr, 100663818);
			GoogleAssertionTokenRequest.NativeMethodInfoPtr_set_Assertion_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAssertionTokenRequest>.NativeClassPtr, 100663819);
			GoogleAssertionTokenRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAssertionTokenRequest>.NativeClassPtr, 100663820);
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600025F RID: 607 RVA: 0x0000F4FC File Offset: 0x0000D6FC
		// (set) Token: 0x06000260 RID: 608 RVA: 0x0000F534 File Offset: 0x0000D734
		public unsafe string Assertion
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAssertionTokenRequest.NativeMethodInfoPtr_get_Assertion_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAssertionTokenRequest.NativeMethodInfoPtr_set_Assertion_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000F578 File Offset: 0x0000D778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156946, XrefRangeEnd = 1156950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoogleAssertionTokenRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleAssertionTokenRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAssertionTokenRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00003071 File Offset: 0x00001271
		public GoogleAssertionTokenRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000263 RID: 611 RVA: 0x0000F5B4 File Offset: 0x0000D7B4
		// (set) Token: 0x06000264 RID: 612 RVA: 0x0000307A File Offset: 0x0000127A
		public unsafe string _Assertion_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAssertionTokenRequest.NativeFieldInfoPtr__Assertion_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAssertionTokenRequest.NativeFieldInfoPtr__Assertion_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeFieldInfoPtr__Assertion_k__BackingField;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_get_Assertion_Public_get_String_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_set_Assertion_Public_set_Void_String_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace iap.claims
{
	// Token: 0x02000006 RID: 6
	public static class ClaimUrlHelper : Object
	{
		// Token: 0x06000043 RID: 67 RVA: 0x000037FC File Offset: 0x000019FC
		// Note: this type is marked as 'beforefieldinit'.
		static ClaimUrlHelper()
		{
			Il2CppClassPointerStore<ClaimUrlHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing-Claims.dll", "iap.claims", "ClaimUrlHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClaimUrlHelper>.NativeClassPtr);
			ClaimUrlHelper.NativeFieldInfoPtr_ClaimEndpoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimUrlHelper>.NativeClassPtr, "ClaimEndpoint");
			ClaimUrlHelper.NativeMethodInfoPtr_BuildSubmitClaimUrl_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimUrlHelper>.NativeClassPtr, 100663328);
			ClaimUrlHelper.NativeMethodInfoPtr_BuildClaimStatusUrl_Public_Static_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimUrlHelper>.NativeClassPtr, 100663329);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003868 File Offset: 0x00001A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267919, XrefRangeEnd = 1267922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string BuildSubmitClaimUrl(string commerceURL, string client)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(commerceURL);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(client);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimUrlHelper.NativeMethodInfoPtr_BuildSubmitClaimUrl_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000038B8 File Offset: 0x00001AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267922, XrefRangeEnd = 1267937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string BuildClaimStatusUrl(string commerceURL, string claimId, string client)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(commerceURL);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(claimId);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(client);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClaimUrlHelper.NativeMethodInfoPtr_BuildClaimStatusUrl_Public_Static_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000022AD File Offset: 0x000004AD
		public ClaimUrlHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00003918 File Offset: 0x00001B18
		// (set) Token: 0x06000048 RID: 72 RVA: 0x000022B6 File Offset: 0x000004B6
		public unsafe static string ClaimEndpoint
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ClaimUrlHelper.NativeFieldInfoPtr_ClaimEndpoint, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClaimUrlHelper.NativeFieldInfoPtr_ClaimEndpoint, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr_ClaimEndpoint;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_BuildSubmitClaimUrl_Public_Static_String_String_String_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_BuildClaimStatusUrl_Public_Static_String_String_String_String_0;
	}
}

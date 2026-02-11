using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization
{
	// Token: 0x0200001A RID: 26
	public static class AssetAddress : Object
	{
		// Token: 0x0600015A RID: 346 RVA: 0x0000E458 File Offset: 0x0000C658
		// Note: this type is marked as 'beforefieldinit'.
		static AssetAddress()
		{
			Il2CppClassPointerStore<AssetAddress>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "AssetAddress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetAddress>.NativeClassPtr);
			AssetAddress.NativeFieldInfoPtr_k_SubAssetEntryStartBracket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetAddress>.NativeClassPtr, "k_SubAssetEntryStartBracket");
			AssetAddress.NativeFieldInfoPtr_k_SubAssetEntryEndBracket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetAddress>.NativeClassPtr, "k_SubAssetEntryEndBracket");
			AssetAddress.NativeMethodInfoPtr_IsSubAsset_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetAddress>.NativeClassPtr, 100663565);
			AssetAddress.NativeMethodInfoPtr_GetGuid_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetAddress>.NativeClassPtr, 100663566);
			AssetAddress.NativeMethodInfoPtr_GetSubAssetName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetAddress>.NativeClassPtr, 100663567);
			AssetAddress.NativeMethodInfoPtr_FormatAddress_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetAddress>.NativeClassPtr, 100663568);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000E500 File Offset: 0x0000C700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066354, XrefRangeEnd = 1066355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSubAsset(string address)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetAddress.NativeMethodInfoPtr_IsSubAsset_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000E544 File Offset: 0x0000C744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066355, XrefRangeEnd = 1066362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetGuid(string address)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetAddress.NativeMethodInfoPtr_GetGuid_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000E580 File Offset: 0x0000C780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066362, XrefRangeEnd = 1066369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSubAssetName(string address)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetAddress.NativeMethodInfoPtr_GetSubAssetName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000E5BC File Offset: 0x0000C7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066369, XrefRangeEnd = 1066374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatAddress(string guid, string subAssetName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subAssetName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetAddress.NativeMethodInfoPtr_FormatAddress_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000028E3 File Offset: 0x00000AE3
		public AssetAddress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000160 RID: 352 RVA: 0x0000E60C File Offset: 0x0000C80C
		// (set) Token: 0x06000161 RID: 353 RVA: 0x000028EC File Offset: 0x00000AEC
		public unsafe static string k_SubAssetEntryStartBracket
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AssetAddress.NativeFieldInfoPtr_k_SubAssetEntryStartBracket, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetAddress.NativeFieldInfoPtr_k_SubAssetEntryStartBracket, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000162 RID: 354 RVA: 0x0000E62C File Offset: 0x0000C82C
		// (set) Token: 0x06000163 RID: 355 RVA: 0x000028FE File Offset: 0x00000AFE
		public unsafe static string k_SubAssetEntryEndBracket
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AssetAddress.NativeFieldInfoPtr_k_SubAssetEntryEndBracket, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetAddress.NativeFieldInfoPtr_k_SubAssetEntryEndBracket, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeFieldInfoPtr_k_SubAssetEntryStartBracket;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeFieldInfoPtr_k_SubAssetEntryEndBracket;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_IsSubAsset_Public_Static_Boolean_String_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_GetGuid_Public_Static_String_String_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_GetSubAssetName_Public_Static_String_String_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_FormatAddress_Public_Static_String_String_String_0;
	}
}

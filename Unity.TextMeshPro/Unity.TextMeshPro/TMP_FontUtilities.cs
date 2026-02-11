using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace TMPro
{
	// Token: 0x02000038 RID: 56
	public static class TMP_FontUtilities : Object
	{
		// Token: 0x060005BA RID: 1466 RVA: 0x0001C5B0 File Offset: 0x0001A7B0
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_FontUtilities()
		{
			Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_FontUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr);
			TMP_FontUtilities.NativeFieldInfoPtr_k_searchedFontAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr, "k_searchedFontAssets");
			TMP_FontUtilities.NativeMethodInfoPtr_SearchForCharacter_Public_Static_TMP_FontAsset_TMP_FontAsset_UInt32_byref_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr, 100663900);
			TMP_FontUtilities.NativeMethodInfoPtr_SearchForCharacter_Public_Static_TMP_FontAsset_List_1_TMP_FontAsset_UInt32_byref_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr, 100663901);
			TMP_FontUtilities.NativeMethodInfoPtr_SearchForCharacterInternal_Private_Static_TMP_FontAsset_TMP_FontAsset_UInt32_byref_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr, 100663902);
			TMP_FontUtilities.NativeMethodInfoPtr_SearchForCharacterInternal_Private_Static_TMP_FontAsset_List_1_TMP_FontAsset_UInt32_byref_TMP_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontUtilities>.NativeClassPtr, 100663903);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0001C644 File Offset: 0x0001A844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041208, XrefRangeEnd = 1041223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_FontAsset SearchForCharacter(TMP_FontAsset font, uint unicode, out TMP_Character character)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unicode;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_FontUtilities.NativeMethodInfoPtr_SearchForCharacter_Public_Static_TMP_FontAsset_TMP_FontAsset_UInt32_byref_TMP_Character_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			character = ((intPtr4 == 0) ? null : new TMP_Character(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr5) : null;
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0001C6BC File Offset: 0x0001A8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041223, XrefRangeEnd = 1041235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_FontAsset SearchForCharacter(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fonts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unicode;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_FontUtilities.NativeMethodInfoPtr_SearchForCharacter_Public_Static_TMP_FontAsset_List_1_TMP_FontAsset_UInt32_byref_TMP_Character_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			character = ((intPtr4 == 0) ? null : new TMP_Character(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr5) : null;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0001C734 File Offset: 0x0001A934
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1041268, RefRangeEnd = 1041272, XrefRangeStart = 1041235, XrefRangeEnd = 1041268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_FontAsset SearchForCharacterInternal(TMP_FontAsset font, uint unicode, out TMP_Character character)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unicode;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_FontUtilities.NativeMethodInfoPtr_SearchForCharacterInternal_Private_Static_TMP_FontAsset_TMP_FontAsset_UInt32_byref_TMP_Character_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			character = ((intPtr4 == 0) ? null : new TMP_Character(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr5) : null;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0001C7AC File Offset: 0x0001A9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041272, XrefRangeEnd = 1041284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_FontAsset SearchForCharacterInternal(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fonts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unicode;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_FontUtilities.NativeMethodInfoPtr_SearchForCharacterInternal_Private_Static_TMP_FontAsset_List_1_TMP_FontAsset_UInt32_byref_TMP_Character_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			character = ((intPtr4 == 0) ? null : new TMP_Character(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr5) : null;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00004E00 File Offset: 0x00003000
		public TMP_FontUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x0001C824 File Offset: 0x0001AA24
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x00004E09 File Offset: 0x00003009
		public unsafe static List<int> k_searchedFontAssets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontUtilities.NativeFieldInfoPtr_k_searchedFontAssets, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontUtilities.NativeFieldInfoPtr_k_searchedFontAssets, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeFieldInfoPtr_k_searchedFontAssets;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeMethodInfoPtr_SearchForCharacter_Public_Static_TMP_FontAsset_TMP_FontAsset_UInt32_byref_TMP_Character_0;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeMethodInfoPtr_SearchForCharacter_Public_Static_TMP_FontAsset_List_1_TMP_FontAsset_UInt32_byref_TMP_Character_0;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeMethodInfoPtr_SearchForCharacterInternal_Private_Static_TMP_FontAsset_TMP_FontAsset_UInt32_byref_TMP_Character_0;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeMethodInfoPtr_SearchForCharacterInternal_Private_Static_TMP_FontAsset_List_1_TMP_FontAsset_UInt32_byref_TMP_Character_0;
	}
}

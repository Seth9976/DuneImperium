using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace TMPro
{
	// Token: 0x02000039 RID: 57
	public class TMP_FontAssetUtilities : Object
	{
		// Token: 0x060005C2 RID: 1474 RVA: 0x0001C84C File Offset: 0x0001AA4C
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_FontAssetUtilities()
		{
			Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_FontAssetUtilities");
			TMP_FontAssetUtilities.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, "s_Instance");
			TMP_FontAssetUtilities.NativeFieldInfoPtr_k_SearchedAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, "k_SearchedAssets");
			TMP_FontAssetUtilities.NativeFieldInfoPtr_k_IsFontEngineInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, "k_IsFontEngineInitialized");
			TMP_FontAssetUtilities.NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_FontAssetUtilities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, 100663905);
			TMP_FontAssetUtilities.NativeMethodInfoPtr_GetCharacterFromFontAsset_Public_Static_TMP_Character_UInt32_TMP_FontAsset_Boolean_FontStyles_FontWeight_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, 100663906);
			TMP_FontAssetUtilities.NativeMethodInfoPtr_GetCharacterFromFontAsset_Internal_Private_Static_TMP_Character_UInt32_TMP_FontAsset_Boolean_FontStyles_FontWeight_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, 100663907);
			TMP_FontAssetUtilities.NativeMethodInfoPtr_GetCharacterFromFontAssets_Public_Static_TMP_Character_UInt32_TMP_FontAsset_List_1_TMP_FontAsset_Boolean_FontStyles_FontWeight_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, 100663908);
			TMP_FontAssetUtilities.NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Public_Static_TMP_SpriteCharacter_UInt32_TMP_SpriteAsset_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, 100663909);
			TMP_FontAssetUtilities.NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Internal_Private_Static_TMP_SpriteCharacter_UInt32_TMP_SpriteAsset_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, 100663910);
			TMP_FontAssetUtilities.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr, 100663911);
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x0001C93C File Offset: 0x0001AB3C
		public unsafe static TMP_FontAssetUtilities instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041284, XrefRangeEnd = 1041288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAssetUtilities.NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_FontAssetUtilities_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_FontAssetUtilities>(intPtr3) : null;
			}
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0001C970 File Offset: 0x0001AB70
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1041313, RefRangeEnd = 1041326, XrefRangeStart = 1041288, XrefRangeEnd = 1041313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceFontAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fontStyle;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fontWeight;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isAlternativeTypeface;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAssetUtilities.NativeMethodInfoPtr_GetCharacterFromFontAsset_Public_Static_TMP_Character_UInt32_TMP_FontAsset_Boolean_FontStyles_FontWeight_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Character>(intPtr3) : null;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0001C9FC File Offset: 0x0001ABFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1041352, RefRangeEnd = 1041355, XrefRangeStart = 1041326, XrefRangeEnd = 1041352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceFontAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fontStyle;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fontWeight;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isAlternativeTypeface;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAssetUtilities.NativeMethodInfoPtr_GetCharacterFromFontAsset_Internal_Private_Static_TMP_Character_UInt32_TMP_FontAsset_Boolean_FontStyles_FontWeight_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Character>(intPtr3) : null;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0001CA88 File Offset: 0x0001AC88
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1041391, RefRangeEnd = 1041397, XrefRangeStart = 1041355, XrefRangeEnd = 1041391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_Character GetCharacterFromFontAssets(uint unicode, TMP_FontAsset sourceFontAsset, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceFontAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fontAssets);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFallbacks;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fontStyle;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fontWeight;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isAlternativeTypeface;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAssetUtilities.NativeMethodInfoPtr_GetCharacterFromFontAssets_Public_Static_TMP_Character_UInt32_TMP_FontAsset_List_1_TMP_FontAsset_Boolean_FontStyles_FontWeight_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Character>(intPtr3) : null;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0001CB28 File Offset: 0x0001AD28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041397, XrefRangeEnd = 1041449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAssetUtilities.NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Public_Static_TMP_SpriteCharacter_UInt32_TMP_SpriteAsset_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteCharacter>(intPtr3) : null;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0001CB88 File Offset: 0x0001AD88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1041472, RefRangeEnd = 1041474, XrefRangeStart = 1041449, XrefRangeEnd = 1041472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAssetUtilities.NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Internal_Private_Static_TMP_SpriteCharacter_UInt32_TMP_SpriteAsset_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteCharacter>(intPtr3) : null;
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0001CBE8 File Offset: 0x0001ADE8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_FontAssetUtilities()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_FontAssetUtilities>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_FontAssetUtilities.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00004E1B File Offset: 0x0000301B
		public TMP_FontAssetUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x0001CC24 File Offset: 0x0001AE24
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x00004E24 File Offset: 0x00003024
		public unsafe static TMP_FontAssetUtilities s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAssetUtilities.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAssetUtilities>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAssetUtilities.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x0001CC4C File Offset: 0x0001AE4C
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x00004E36 File Offset: 0x00003036
		public unsafe static HashSet<int> k_SearchedAssets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAssetUtilities.NativeFieldInfoPtr_k_SearchedAssets, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAssetUtilities.NativeFieldInfoPtr_k_SearchedAssets, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x0001CC74 File Offset: 0x0001AE74
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x00004E48 File Offset: 0x00003048
		public unsafe static bool k_IsFontEngineInitialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TMP_FontAssetUtilities.NativeFieldInfoPtr_k_IsFontEngineInitialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_FontAssetUtilities.NativeFieldInfoPtr_k_IsFontEngineInitialized, (void*)(&value));
			}
		}

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeFieldInfoPtr_k_SearchedAssets;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeFieldInfoPtr_k_IsFontEngineInitialized;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_FontAssetUtilities_0;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterFromFontAsset_Public_Static_TMP_Character_UInt32_TMP_FontAsset_Boolean_FontStyles_FontWeight_byref_Boolean_0;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterFromFontAsset_Internal_Private_Static_TMP_Character_UInt32_TMP_FontAsset_Boolean_FontStyles_FontWeight_byref_Boolean_0;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterFromFontAssets_Public_Static_TMP_Character_UInt32_TMP_FontAsset_List_1_TMP_FontAsset_Boolean_FontStyles_FontWeight_byref_Boolean_0;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Public_Static_TMP_SpriteCharacter_UInt32_TMP_SpriteAsset_Boolean_0;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Internal_Private_Static_TMP_SpriteCharacter_UInt32_TMP_SpriteAsset_Boolean_0;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

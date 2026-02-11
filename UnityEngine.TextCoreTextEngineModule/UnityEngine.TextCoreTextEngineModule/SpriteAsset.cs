using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000013 RID: 19
	public class SpriteAsset : TextAsset
	{
		// Token: 0x060001D7 RID: 471 RVA: 0x0000C9B0 File Offset: 0x0000ABB0
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteAsset()
		{
			Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "SpriteAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr);
			SpriteAsset.NativeFieldInfoPtr_m_NameLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, "m_NameLookup");
			SpriteAsset.NativeFieldInfoPtr_m_GlyphIndexLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, "m_GlyphIndexLookup");
			SpriteAsset.NativeFieldInfoPtr_m_FaceInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, "m_FaceInfo");
			SpriteAsset.NativeFieldInfoPtr_m_SpriteAtlasTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, "m_SpriteAtlasTexture");
			SpriteAsset.NativeFieldInfoPtr_m_SpriteCharacterTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, "m_SpriteCharacterTable");
			SpriteAsset.NativeFieldInfoPtr_m_SpriteCharacterLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, "m_SpriteCharacterLookup");
			SpriteAsset.NativeFieldInfoPtr_m_SpriteGlyphTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, "m_SpriteGlyphTable");
			SpriteAsset.NativeFieldInfoPtr_m_SpriteGlyphLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, "m_SpriteGlyphLookup");
			SpriteAsset.NativeFieldInfoPtr_fallbackSpriteAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, "fallbackSpriteAssets");
			SpriteAsset.NativeFieldInfoPtr_m_IsSpriteAssetLookupTablesDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, "m_IsSpriteAssetLookupTablesDirty");
			SpriteAsset.NativeFieldInfoPtr_k_searchedSpriteAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, "k_searchedSpriteAssets");
			SpriteAsset.NativeMethodInfoPtr_get_faceInfo_Public_get_FaceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, 100663479);
			SpriteAsset.NativeMethodInfoPtr_set_faceInfo_Internal_set_Void_FaceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, 100663480);
			SpriteAsset.NativeMethodInfoPtr_get_spriteSheet_Public_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, 100663481);
			SpriteAsset.NativeMethodInfoPtr_set_spriteSheet_Internal_set_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, 100663482);
			SpriteAsset.NativeMethodInfoPtr_get_spriteCharacterTable_Public_get_List_1_SpriteCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, 100663483);
			SpriteAsset.NativeMethodInfoPtr_set_spriteCharacterTable_Internal_set_Void_List_1_SpriteCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, 100663484);
			SpriteAsset.NativeMethodInfoPtr_get_spriteCharacterLookupTable_Public_get_Dictionary_2_UInt32_SpriteCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, 100663485);
			SpriteAsset.NativeMethodInfoPtr_set_spriteCharacterLookupTable_Internal_set_Void_Dictionary_2_UInt32_SpriteCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, 100663486);
			SpriteAsset.NativeMethodInfoPtr_get_spriteGlyphTable_Public_get_List_1_SpriteGlyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, 100663487);
			SpriteAsset.NativeMethodInfoPtr_set_spriteGlyphTable_Internal_set_Void_List_1_SpriteGlyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, 100663488);
			SpriteAsset.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, 100663489);
			SpriteAsset.NativeMethodInfoPtr_UpdateLookupTables_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, 100663490);
			SpriteAsset.NativeMethodInfoPtr_GetSpriteIndexFromHashcode_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, 100663491);
			SpriteAsset.NativeMethodInfoPtr_GetSpriteIndexFromUnicode_Public_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, 100663492);
			SpriteAsset.NativeMethodInfoPtr_GetSpriteIndexFromName_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, 100663493);
			SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByUnicode_Public_Static_SpriteAsset_SpriteAsset_UInt32_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, 100663494);
			SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByUnicodeInternal_Private_Static_SpriteAsset_List_1_SpriteAsset_UInt32_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, 100663495);
			SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByUnicodeInternal_Private_Static_SpriteAsset_SpriteAsset_UInt32_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, 100663496);
			SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByHashCode_Public_Static_SpriteAsset_SpriteAsset_Int32_Boolean_byref_Int32_TextSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, 100663497);
			SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByHashCodeInternal_Private_Static_SpriteAsset_List_1_SpriteAsset_Int32_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, 100663498);
			SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByHashCodeInternal_Private_Static_SpriteAsset_SpriteAsset_Int32_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, 100663499);
			SpriteAsset.NativeMethodInfoPtr_SortGlyphTable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, 100663500);
			SpriteAsset.NativeMethodInfoPtr_SortCharacterTable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, 100663501);
			SpriteAsset.NativeMethodInfoPtr_SortGlyphAndCharacterTables_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, 100663502);
			SpriteAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, 100663503);
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0000CCB0 File Offset: 0x0000AEB0
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x0000CCE8 File Offset: 0x0000AEE8
		public unsafe FaceInfo faceInfo
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1100648, RefRangeEnd = 1100653, XrefRangeStart = 1100648, XrefRangeEnd = 1100648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.NativeMethodInfoPtr_get_faceInfo_Public_get_FaceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new FaceInfo(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.NativeMethodInfoPtr_set_faceInfo_Internal_set_Void_FaceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0000CD30 File Offset: 0x0000AF30
		// (set) Token: 0x060001DB RID: 475 RVA: 0x0000CD70 File Offset: 0x0000AF70
		public unsafe Texture spriteSheet
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 321260, RefRangeEnd = 321264, XrefRangeStart = 321260, XrefRangeEnd = 321264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.NativeMethodInfoPtr_get_spriteSheet_Public_get_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.NativeMethodInfoPtr_set_spriteSheet_Internal_set_Void_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0000CDB4 File Offset: 0x0000AFB4
		// (set) Token: 0x060001DD RID: 477 RVA: 0x0000CDF4 File Offset: 0x0000AFF4
		public unsafe List<SpriteCharacter> spriteCharacterTable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1100654, RefRangeEnd = 1100655, XrefRangeStart = 1100653, XrefRangeEnd = 1100654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.NativeMethodInfoPtr_get_spriteCharacterTable_Public_get_List_1_SpriteCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SpriteCharacter>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.NativeMethodInfoPtr_set_spriteCharacterTable_Internal_set_Void_List_1_SpriteCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001DE RID: 478 RVA: 0x0000CE38 File Offset: 0x0000B038
		// (set) Token: 0x060001DF RID: 479 RVA: 0x0000CE78 File Offset: 0x0000B078
		public unsafe Dictionary<uint, SpriteCharacter> spriteCharacterLookupTable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100655, XrefRangeEnd = 1100656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.NativeMethodInfoPtr_get_spriteCharacterLookupTable_Public_get_Dictionary_2_UInt32_SpriteCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, SpriteCharacter>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.NativeMethodInfoPtr_set_spriteCharacterLookupTable_Internal_set_Void_Dictionary_2_UInt32_SpriteCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0000CEBC File Offset: 0x0000B0BC
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x0000CEFC File Offset: 0x0000B0FC
		public unsafe List<SpriteGlyph> spriteGlyphTable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 321321, RefRangeEnd = 321322, XrefRangeStart = 321321, XrefRangeEnd = 321322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.NativeMethodInfoPtr_get_spriteGlyphTable_Public_get_List_1_SpriteGlyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SpriteGlyph>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.NativeMethodInfoPtr_set_spriteGlyphTable_Internal_set_Void_List_1_SpriteGlyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000CF40 File Offset: 0x0000B140
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000CF74 File Offset: 0x0000B174
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1100747, RefRangeEnd = 1100754, XrefRangeStart = 1100656, XrefRangeEnd = 1100747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLookupTables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.NativeMethodInfoPtr_UpdateLookupTables_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000CFA8 File Offset: 0x0000B1A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1100758, RefRangeEnd = 1100761, XrefRangeStart = 1100754, XrefRangeEnd = 1100758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSpriteIndexFromHashcode(int hashCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.NativeMethodInfoPtr_GetSpriteIndexFromHashcode_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000CFF4 File Offset: 0x0000B1F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1100765, RefRangeEnd = 1100768, XrefRangeStart = 1100761, XrefRangeEnd = 1100765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSpriteIndexFromUnicode(uint unicode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.NativeMethodInfoPtr_GetSpriteIndexFromUnicode_Public_Int32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000D040 File Offset: 0x0000B240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100768, XrefRangeEnd = 1100771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSpriteIndexFromName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.NativeMethodInfoPtr_GetSpriteIndexFromName_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000D090 File Offset: 0x0000B290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100771, XrefRangeEnd = 1100799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SpriteAsset SearchForSpriteByUnicode(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unicode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByUnicode_Public_Static_SpriteAsset_SpriteAsset_UInt32_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpriteAsset>(intPtr3) : null;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000D100 File Offset: 0x0000B300
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1100818, RefRangeEnd = 1100821, XrefRangeStart = 1100799, XrefRangeEnd = 1100818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SpriteAsset SearchForSpriteByUnicodeInternal(List<SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAssets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unicode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByUnicodeInternal_Private_Static_SpriteAsset_List_1_SpriteAsset_UInt32_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpriteAsset>(intPtr3) : null;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000D170 File Offset: 0x0000B370
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1100825, RefRangeEnd = 1100827, XrefRangeStart = 1100821, XrefRangeEnd = 1100825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SpriteAsset SearchForSpriteByUnicodeInternal(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unicode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByUnicodeInternal_Private_Static_SpriteAsset_SpriteAsset_UInt32_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpriteAsset>(intPtr3) : null;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000D1E0 File Offset: 0x0000B3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100827, XrefRangeEnd = 1100875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SpriteAsset SearchForSpriteByHashCode(SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex, TextSettings textSettings = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByHashCode_Public_Static_SpriteAsset_SpriteAsset_Int32_Boolean_byref_Int32_TextSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpriteAsset>(intPtr3) : null;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000D264 File Offset: 0x0000B464
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1100894, RefRangeEnd = 1100896, XrefRangeStart = 1100875, XrefRangeEnd = 1100894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SpriteAsset SearchForSpriteByHashCodeInternal(List<SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAssets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchFallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByHashCodeInternal_Private_Static_SpriteAsset_List_1_SpriteAsset_Int32_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpriteAsset>(intPtr3) : null;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000D2D4 File Offset: 0x0000B4D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1100900, RefRangeEnd = 1100902, XrefRangeStart = 1100896, XrefRangeEnd = 1100900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SpriteAsset SearchForSpriteByHashCodeInternal(SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchFallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByHashCodeInternal_Private_Static_SpriteAsset_SpriteAsset_Int32_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpriteAsset>(intPtr3) : null;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000D344 File Offset: 0x0000B544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100902, XrefRangeEnd = 1100925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortGlyphTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.NativeMethodInfoPtr_SortGlyphTable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000D378 File Offset: 0x0000B578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100925, XrefRangeEnd = 1100948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortCharacterTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.NativeMethodInfoPtr_SortCharacterTable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000D3AC File Offset: 0x0000B5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100948, XrefRangeEnd = 1100994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortGlyphAndCharacterTables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.NativeMethodInfoPtr_SortGlyphAndCharacterTables_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000D3E0 File Offset: 0x0000B5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100994, XrefRangeEnd = 1101009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpriteAsset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002ECF File Offset: 0x000010CF
		public SpriteAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0000D41C File Offset: 0x0000B61C
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00002ED8 File Offset: 0x000010D8
		public unsafe Dictionary<int, int> m_NameLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAsset.NativeFieldInfoPtr_m_NameLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAsset.NativeFieldInfoPtr_m_NameLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x0000D44C File Offset: 0x0000B64C
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00002EF7 File Offset: 0x000010F7
		public unsafe Dictionary<uint, int> m_GlyphIndexLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAsset.NativeFieldInfoPtr_m_GlyphIndexLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAsset.NativeFieldInfoPtr_m_GlyphIndexLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x0000D47C File Offset: 0x0000B67C
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00002F16 File Offset: 0x00001116
		public FaceInfo m_FaceInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAsset.NativeFieldInfoPtr_m_FaceInfo);
				return new FaceInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAsset.NativeFieldInfoPtr_m_FaceInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000D4AC File Offset: 0x0000B6AC
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00002F44 File Offset: 0x00001144
		public unsafe Texture m_SpriteAtlasTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAsset.NativeFieldInfoPtr_m_SpriteAtlasTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAsset.NativeFieldInfoPtr_m_SpriteAtlasTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001FA RID: 506 RVA: 0x0000D4DC File Offset: 0x0000B6DC
		// (set) Token: 0x060001FB RID: 507 RVA: 0x00002F63 File Offset: 0x00001163
		public unsafe List<SpriteCharacter> m_SpriteCharacterTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAsset.NativeFieldInfoPtr_m_SpriteCharacterTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SpriteCharacter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAsset.NativeFieldInfoPtr_m_SpriteCharacterTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001FC RID: 508 RVA: 0x0000D50C File Offset: 0x0000B70C
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00002F82 File Offset: 0x00001182
		public unsafe Dictionary<uint, SpriteCharacter> m_SpriteCharacterLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAsset.NativeFieldInfoPtr_m_SpriteCharacterLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, SpriteCharacter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAsset.NativeFieldInfoPtr_m_SpriteCharacterLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001FE RID: 510 RVA: 0x0000D53C File Offset: 0x0000B73C
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00002FA1 File Offset: 0x000011A1
		public unsafe List<SpriteGlyph> m_SpriteGlyphTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAsset.NativeFieldInfoPtr_m_SpriteGlyphTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SpriteGlyph>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAsset.NativeFieldInfoPtr_m_SpriteGlyphTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000200 RID: 512 RVA: 0x0000D56C File Offset: 0x0000B76C
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00002FC0 File Offset: 0x000011C0
		public unsafe Dictionary<uint, SpriteGlyph> m_SpriteGlyphLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAsset.NativeFieldInfoPtr_m_SpriteGlyphLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, SpriteGlyph>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAsset.NativeFieldInfoPtr_m_SpriteGlyphLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000202 RID: 514 RVA: 0x0000D59C File Offset: 0x0000B79C
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00002FDF File Offset: 0x000011DF
		public unsafe List<SpriteAsset> fallbackSpriteAssets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAsset.NativeFieldInfoPtr_fallbackSpriteAssets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SpriteAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAsset.NativeFieldInfoPtr_fallbackSpriteAssets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0000D5CC File Offset: 0x0000B7CC
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00002FFE File Offset: 0x000011FE
		public unsafe bool m_IsSpriteAssetLookupTablesDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAsset.NativeFieldInfoPtr_m_IsSpriteAssetLookupTablesDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteAsset.NativeFieldInfoPtr_m_IsSpriteAssetLookupTablesDirty)) = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000206 RID: 518 RVA: 0x0000D5F4 File Offset: 0x0000B7F4
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00003019 File Offset: 0x00001219
		public unsafe static HashSet<int> k_searchedSpriteAssets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpriteAsset.NativeFieldInfoPtr_k_searchedSpriteAssets, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpriteAsset.NativeFieldInfoPtr_k_searchedSpriteAssets, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeFieldInfoPtr_m_NameLookup;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphIndexLookup;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeFieldInfoPtr_m_FaceInfo;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteAtlasTexture;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteCharacterTable;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteCharacterLookup;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteGlyphTable;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteGlyphLookup;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeFieldInfoPtr_fallbackSpriteAssets;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeFieldInfoPtr_m_IsSpriteAssetLookupTablesDirty;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeFieldInfoPtr_k_searchedSpriteAssets;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_get_faceInfo_Public_get_FaceInfo_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_set_faceInfo_Internal_set_Void_FaceInfo_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteSheet_Public_get_Texture_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_set_spriteSheet_Internal_set_Void_Texture_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteCharacterTable_Public_get_List_1_SpriteCharacter_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_set_spriteCharacterTable_Internal_set_Void_List_1_SpriteCharacter_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteCharacterLookupTable_Public_get_Dictionary_2_UInt32_SpriteCharacter_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_set_spriteCharacterLookupTable_Internal_set_Void_Dictionary_2_UInt32_SpriteCharacter_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteGlyphTable_Public_get_List_1_SpriteGlyph_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_set_spriteGlyphTable_Internal_set_Void_List_1_SpriteGlyph_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLookupTables_Public_Void_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteIndexFromHashcode_Public_Int32_Int32_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteIndexFromUnicode_Public_Int32_UInt32_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteIndexFromName_Public_Int32_String_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_SearchForSpriteByUnicode_Public_Static_SpriteAsset_SpriteAsset_UInt32_Boolean_byref_Int32_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_SearchForSpriteByUnicodeInternal_Private_Static_SpriteAsset_List_1_SpriteAsset_UInt32_Boolean_byref_Int32_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_SearchForSpriteByUnicodeInternal_Private_Static_SpriteAsset_SpriteAsset_UInt32_Boolean_byref_Int32_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_SearchForSpriteByHashCode_Public_Static_SpriteAsset_SpriteAsset_Int32_Boolean_byref_Int32_TextSettings_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_SearchForSpriteByHashCodeInternal_Private_Static_SpriteAsset_List_1_SpriteAsset_Int32_Boolean_byref_Int32_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_SearchForSpriteByHashCodeInternal_Private_Static_SpriteAsset_SpriteAsset_Int32_Boolean_byref_Int32_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_SortGlyphTable_Public_Void_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_SortCharacterTable_Internal_Void_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_SortGlyphAndCharacterTables_Internal_Void_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000049 RID: 73
		[ObfuscatedName("UnityEngine.TextCore.Text.SpriteAsset+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600073E RID: 1854 RVA: 0x0001C308 File Offset: 0x0001A508
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SpriteAsset.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpriteAsset>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAsset.__c>.NativeClassPtr);
				SpriteAsset.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAsset.__c>.NativeClassPtr, "<>9");
				SpriteAsset.__c.NativeFieldInfoPtr___9__37_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAsset.__c>.NativeClassPtr, "<>9__37_0");
				SpriteAsset.__c.NativeFieldInfoPtr___9__38_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAsset.__c>.NativeClassPtr, "<>9__38_0");
				SpriteAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset.__c>.NativeClassPtr, 100663505);
				SpriteAsset.__c.NativeMethodInfoPtr__SortGlyphTable_b__37_0_Internal_UInt32_SpriteGlyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset.__c>.NativeClassPtr, 100663506);
				SpriteAsset.__c.NativeMethodInfoPtr__SortCharacterTable_b__38_0_Internal_UInt32_SpriteCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAsset.__c>.NativeClassPtr, 100663507);
			}

			// Token: 0x0600073F RID: 1855 RVA: 0x0001C3AC File Offset: 0x0001A5AC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteAsset.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000740 RID: 1856 RVA: 0x0001C3E8 File Offset: 0x0001A5E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint _SortGlyphTable_b__37_0(SpriteGlyph item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.__c.NativeMethodInfoPtr__SortGlyphTable_b__37_0_Internal_UInt32_SpriteGlyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000741 RID: 1857 RVA: 0x0001C438 File Offset: 0x0001A638
			[CallerCount(0)]
			public unsafe uint _SortCharacterTable_b__38_0(SpriteCharacter c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAsset.__c.NativeMethodInfoPtr__SortCharacterTable_b__38_0_Internal_UInt32_SpriteCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000742 RID: 1858 RVA: 0x000063B0 File Offset: 0x000045B0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002BD RID: 701
			// (get) Token: 0x06000743 RID: 1859 RVA: 0x0001C488 File Offset: 0x0001A688
			// (set) Token: 0x06000744 RID: 1860 RVA: 0x000063B9 File Offset: 0x000045B9
			public unsafe static SpriteAsset.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpriteAsset.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteAsset.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpriteAsset.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002BE RID: 702
			// (get) Token: 0x06000745 RID: 1861 RVA: 0x0001C4B0 File Offset: 0x0001A6B0
			// (set) Token: 0x06000746 RID: 1862 RVA: 0x000063CB File Offset: 0x000045CB
			public unsafe static Func<SpriteGlyph, uint> __9__37_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpriteAsset.__c.NativeFieldInfoPtr___9__37_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpriteGlyph, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpriteAsset.__c.NativeFieldInfoPtr___9__37_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002BF RID: 703
			// (get) Token: 0x06000747 RID: 1863 RVA: 0x0001C4D8 File Offset: 0x0001A6D8
			// (set) Token: 0x06000748 RID: 1864 RVA: 0x000063DD File Offset: 0x000045DD
			public unsafe static Func<SpriteCharacter, uint> __9__38_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpriteAsset.__c.NativeFieldInfoPtr___9__38_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpriteCharacter, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpriteAsset.__c.NativeFieldInfoPtr___9__38_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005EB RID: 1515
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040005EC RID: 1516
			private static readonly IntPtr NativeFieldInfoPtr___9__37_0;

			// Token: 0x040005ED RID: 1517
			private static readonly IntPtr NativeFieldInfoPtr___9__38_0;

			// Token: 0x040005EE RID: 1518
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005EF RID: 1519
			private static readonly IntPtr NativeMethodInfoPtr__SortGlyphTable_b__37_0_Internal_UInt32_SpriteGlyph_0;

			// Token: 0x040005F0 RID: 1520
			private static readonly IntPtr NativeMethodInfoPtr__SortCharacterTable_b__38_0_Internal_UInt32_SpriteCharacter_0;
		}

		// Token: 0x0200004A RID: 74
		[Serializable]
		public sealed class <>c
		{
		}
	}
}

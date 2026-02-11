using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore;

namespace TMPro
{
	// Token: 0x02000054 RID: 84
	public class TMP_SpriteAsset : TMP_Asset
	{
		// Token: 0x06000975 RID: 2421 RVA: 0x0002883C File Offset: 0x00026A3C
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_SpriteAsset()
		{
			Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_SpriteAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr);
			TMP_SpriteAsset.NativeFieldInfoPtr_m_NameLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "m_NameLookup");
			TMP_SpriteAsset.NativeFieldInfoPtr_m_GlyphIndexLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "m_GlyphIndexLookup");
			TMP_SpriteAsset.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "m_Version");
			TMP_SpriteAsset.NativeFieldInfoPtr_m_FaceInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "m_FaceInfo");
			TMP_SpriteAsset.NativeFieldInfoPtr_spriteSheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "spriteSheet");
			TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteCharacterTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "m_SpriteCharacterTable");
			TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteCharacterLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "m_SpriteCharacterLookup");
			TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteGlyphTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "m_SpriteGlyphTable");
			TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteGlyphLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "m_SpriteGlyphLookup");
			TMP_SpriteAsset.NativeFieldInfoPtr_spriteInfoList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "spriteInfoList");
			TMP_SpriteAsset.NativeFieldInfoPtr_fallbackSpriteAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "fallbackSpriteAssets");
			TMP_SpriteAsset.NativeFieldInfoPtr_m_IsSpriteAssetLookupTablesDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "m_IsSpriteAssetLookupTablesDirty");
			TMP_SpriteAsset.NativeFieldInfoPtr_k_searchedSpriteAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "k_searchedSpriteAssets");
			TMP_SpriteAsset.NativeMethodInfoPtr_get_version_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664339);
			TMP_SpriteAsset.NativeMethodInfoPtr_set_version_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664340);
			TMP_SpriteAsset.NativeMethodInfoPtr_get_faceInfo_Public_get_FaceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664341);
			TMP_SpriteAsset.NativeMethodInfoPtr_set_faceInfo_Internal_set_Void_FaceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664342);
			TMP_SpriteAsset.NativeMethodInfoPtr_get_spriteCharacterTable_Public_get_List_1_TMP_SpriteCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664343);
			TMP_SpriteAsset.NativeMethodInfoPtr_set_spriteCharacterTable_Internal_set_Void_List_1_TMP_SpriteCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664344);
			TMP_SpriteAsset.NativeMethodInfoPtr_get_spriteCharacterLookupTable_Public_get_Dictionary_2_UInt32_TMP_SpriteCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664345);
			TMP_SpriteAsset.NativeMethodInfoPtr_set_spriteCharacterLookupTable_Internal_set_Void_Dictionary_2_UInt32_TMP_SpriteCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664346);
			TMP_SpriteAsset.NativeMethodInfoPtr_get_spriteGlyphTable_Public_get_List_1_TMP_SpriteGlyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664347);
			TMP_SpriteAsset.NativeMethodInfoPtr_set_spriteGlyphTable_Internal_set_Void_List_1_TMP_SpriteGlyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664348);
			TMP_SpriteAsset.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664349);
			TMP_SpriteAsset.NativeMethodInfoPtr_GetDefaultSpriteMaterial_Private_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664350);
			TMP_SpriteAsset.NativeMethodInfoPtr_UpdateLookupTables_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664351);
			TMP_SpriteAsset.NativeMethodInfoPtr_GetSpriteIndexFromHashcode_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664352);
			TMP_SpriteAsset.NativeMethodInfoPtr_GetSpriteIndexFromUnicode_Public_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664353);
			TMP_SpriteAsset.NativeMethodInfoPtr_GetSpriteIndexFromName_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664354);
			TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByUnicode_Public_Static_TMP_SpriteAsset_TMP_SpriteAsset_UInt32_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664355);
			TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByUnicodeInternal_Private_Static_TMP_SpriteAsset_List_1_TMP_SpriteAsset_UInt32_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664356);
			TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByUnicodeInternal_Private_Static_TMP_SpriteAsset_TMP_SpriteAsset_UInt32_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664357);
			TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByHashCode_Public_Static_TMP_SpriteAsset_TMP_SpriteAsset_Int32_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664358);
			TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByHashCodeInternal_Private_Static_TMP_SpriteAsset_List_1_TMP_SpriteAsset_Int32_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664359);
			TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByHashCodeInternal_Private_Static_TMP_SpriteAsset_TMP_SpriteAsset_Int32_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664360);
			TMP_SpriteAsset.NativeMethodInfoPtr_SortGlyphTable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664361);
			TMP_SpriteAsset.NativeMethodInfoPtr_SortCharacterTable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664362);
			TMP_SpriteAsset.NativeMethodInfoPtr_SortGlyphAndCharacterTables_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664363);
			TMP_SpriteAsset.NativeMethodInfoPtr_UpgradeSpriteAsset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664364);
			TMP_SpriteAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, 100664365);
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x00028B8C File Offset: 0x00026D8C
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x00028BC4 File Offset: 0x00026DC4
		public unsafe string version
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_get_version_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_set_version_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x00028C08 File Offset: 0x00026E08
		// (set) Token: 0x06000979 RID: 2425 RVA: 0x00028C40 File Offset: 0x00026E40
		public unsafe FaceInfo faceInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_get_faceInfo_Public_get_FaceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new FaceInfo(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045914, XrefRangeEnd = 1045915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_set_faceInfo_Internal_set_Void_FaceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x00028C88 File Offset: 0x00026E88
		// (set) Token: 0x0600097B RID: 2427 RVA: 0x00028CC8 File Offset: 0x00026EC8
		public unsafe List<TMP_SpriteCharacter> spriteCharacterTable
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1045916, RefRangeEnd = 1045921, XrefRangeStart = 1045915, XrefRangeEnd = 1045916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_get_spriteCharacterTable_Public_get_List_1_TMP_SpriteCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TMP_SpriteCharacter>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_set_spriteCharacterTable_Internal_set_Void_List_1_TMP_SpriteCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x00028D0C File Offset: 0x00026F0C
		// (set) Token: 0x0600097D RID: 2429 RVA: 0x00028D4C File Offset: 0x00026F4C
		public unsafe Dictionary<uint, TMP_SpriteCharacter> spriteCharacterLookupTable
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1045922, RefRangeEnd = 1045924, XrefRangeStart = 1045921, XrefRangeEnd = 1045922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_get_spriteCharacterLookupTable_Public_get_Dictionary_2_UInt32_TMP_SpriteCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, TMP_SpriteCharacter>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_set_spriteCharacterLookupTable_Internal_set_Void_Dictionary_2_UInt32_TMP_SpriteCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x00028D90 File Offset: 0x00026F90
		// (set) Token: 0x0600097F RID: 2431 RVA: 0x00028DD0 File Offset: 0x00026FD0
		public unsafe List<TMP_SpriteGlyph> spriteGlyphTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_get_spriteGlyphTable_Public_get_List_1_TMP_SpriteGlyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TMP_SpriteGlyph>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_set_spriteGlyphTable_Internal_set_Void_List_1_TMP_SpriteGlyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00028E14 File Offset: 0x00027014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045924, XrefRangeEnd = 1045930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00028E48 File Offset: 0x00027048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045930, XrefRangeEnd = 1045944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetDefaultSpriteMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_GetDefaultSpriteMaterial_Private_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00028E88 File Offset: 0x00027088
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1046040, RefRangeEnd = 1046051, XrefRangeStart = 1045944, XrefRangeEnd = 1046040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLookupTables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_UpdateLookupTables_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00028EBC File Offset: 0x000270BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1046055, RefRangeEnd = 1046059, XrefRangeStart = 1046051, XrefRangeEnd = 1046055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSpriteIndexFromHashcode(int hashCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_GetSpriteIndexFromHashcode_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00028F08 File Offset: 0x00027108
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1046063, RefRangeEnd = 1046068, XrefRangeStart = 1046059, XrefRangeEnd = 1046063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSpriteIndexFromUnicode(uint unicode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_GetSpriteIndexFromUnicode_Public_Int32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00028F54 File Offset: 0x00027154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046068, XrefRangeEnd = 1046076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSpriteIndexFromName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_GetSpriteIndexFromName_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00028FA4 File Offset: 0x000271A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046076, XrefRangeEnd = 1046115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SpriteAsset SearchForSpriteByUnicode(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByUnicode_Public_Static_TMP_SpriteAsset_TMP_SpriteAsset_UInt32_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00029014 File Offset: 0x00027214
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1046134, RefRangeEnd = 1046139, XrefRangeStart = 1046115, XrefRangeEnd = 1046134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(List<TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByUnicodeInternal_Private_Static_TMP_SpriteAsset_List_1_TMP_SpriteAsset_UInt32_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00029084 File Offset: 0x00027284
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1046142, RefRangeEnd = 1046143, XrefRangeStart = 1046139, XrefRangeEnd = 1046142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByUnicodeInternal_Private_Static_TMP_SpriteAsset_TMP_SpriteAsset_UInt32_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x000290F4 File Offset: 0x000272F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046143, XrefRangeEnd = 1046201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SpriteAsset SearchForSpriteByHashCode(TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAsset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spriteIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByHashCode_Public_Static_TMP_SpriteAsset_TMP_SpriteAsset_Int32_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00029164 File Offset: 0x00027364
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1046220, RefRangeEnd = 1046223, XrefRangeStart = 1046201, XrefRangeEnd = 1046220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(List<TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByHashCodeInternal_Private_Static_TMP_SpriteAsset_List_1_TMP_SpriteAsset_Int32_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x000291D4 File Offset: 0x000273D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1046226, RefRangeEnd = 1046227, XrefRangeStart = 1046223, XrefRangeEnd = 1046226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_SearchForSpriteByHashCodeInternal_Private_Static_TMP_SpriteAsset_TMP_SpriteAsset_Int32_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00029244 File Offset: 0x00027444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046227, XrefRangeEnd = 1046250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortGlyphTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_SortGlyphTable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00029278 File Offset: 0x00027478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046250, XrefRangeEnd = 1046273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortCharacterTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_SortCharacterTable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x000292AC File Offset: 0x000274AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046273, XrefRangeEnd = 1046319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortGlyphAndCharacterTables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_SortGlyphAndCharacterTables_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x000292E0 File Offset: 0x000274E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1046383, RefRangeEnd = 1046385, XrefRangeStart = 1046319, XrefRangeEnd = 1046383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpgradeSpriteAsset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr_UpgradeSpriteAsset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00029314 File Offset: 0x00027514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046385, XrefRangeEnd = 1046400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_SpriteAsset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00006648 File Offset: 0x00004848
		public TMP_SpriteAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x00029350 File Offset: 0x00027550
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x00006651 File Offset: 0x00004851
		public unsafe Dictionary<int, int> m_NameLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_NameLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_NameLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x00029380 File Offset: 0x00027580
		// (set) Token: 0x06000995 RID: 2453 RVA: 0x00006670 File Offset: 0x00004870
		public unsafe Dictionary<uint, int> m_GlyphIndexLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_GlyphIndexLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_GlyphIndexLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x000293B0 File Offset: 0x000275B0
		// (set) Token: 0x06000997 RID: 2455 RVA: 0x0000668F File Offset: 0x0000488F
		public unsafe string m_Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_Version);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_Version), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x000293D8 File Offset: 0x000275D8
		// (set) Token: 0x06000999 RID: 2457 RVA: 0x000066AE File Offset: 0x000048AE
		public FaceInfo m_FaceInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_FaceInfo);
				return new FaceInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_FaceInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FaceInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x00029408 File Offset: 0x00027608
		// (set) Token: 0x0600099B RID: 2459 RVA: 0x000066DC File Offset: 0x000048DC
		public unsafe Texture spriteSheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_spriteSheet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_spriteSheet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x00029438 File Offset: 0x00027638
		// (set) Token: 0x0600099D RID: 2461 RVA: 0x000066FB File Offset: 0x000048FB
		public unsafe List<TMP_SpriteCharacter> m_SpriteCharacterTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteCharacterTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_SpriteCharacter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteCharacterTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x00029468 File Offset: 0x00027668
		// (set) Token: 0x0600099F RID: 2463 RVA: 0x0000671A File Offset: 0x0000491A
		public unsafe Dictionary<uint, TMP_SpriteCharacter> m_SpriteCharacterLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteCharacterLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, TMP_SpriteCharacter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteCharacterLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x00029498 File Offset: 0x00027698
		// (set) Token: 0x060009A1 RID: 2465 RVA: 0x00006739 File Offset: 0x00004939
		public unsafe List<TMP_SpriteGlyph> m_SpriteGlyphTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteGlyphTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_SpriteGlyph>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteGlyphTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x000294C8 File Offset: 0x000276C8
		// (set) Token: 0x060009A3 RID: 2467 RVA: 0x00006758 File Offset: 0x00004958
		public unsafe Dictionary<uint, TMP_SpriteGlyph> m_SpriteGlyphLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteGlyphLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<uint, TMP_SpriteGlyph>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_SpriteGlyphLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x000294F8 File Offset: 0x000276F8
		// (set) Token: 0x060009A5 RID: 2469 RVA: 0x00006777 File Offset: 0x00004977
		public unsafe List<TMP_Sprite> spriteInfoList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_spriteInfoList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_spriteInfoList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x00029528 File Offset: 0x00027728
		// (set) Token: 0x060009A7 RID: 2471 RVA: 0x00006796 File Offset: 0x00004996
		public unsafe List<TMP_SpriteAsset> fallbackSpriteAssets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_fallbackSpriteAssets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_SpriteAsset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_fallbackSpriteAssets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x00029558 File Offset: 0x00027758
		// (set) Token: 0x060009A9 RID: 2473 RVA: 0x000067B5 File Offset: 0x000049B5
		public unsafe bool m_IsSpriteAssetLookupTablesDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_IsSpriteAssetLookupTablesDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteAsset.NativeFieldInfoPtr_m_IsSpriteAssetLookupTablesDirty)) = value;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x00029580 File Offset: 0x00027780
		// (set) Token: 0x060009AB RID: 2475 RVA: 0x000067D0 File Offset: 0x000049D0
		public unsafe static HashSet<int> k_searchedSpriteAssets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_SpriteAsset.NativeFieldInfoPtr_k_searchedSpriteAssets, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_SpriteAsset.NativeFieldInfoPtr_k_searchedSpriteAssets, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeFieldInfoPtr_m_NameLookup;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphIndexLookup;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeFieldInfoPtr_m_FaceInfo;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeFieldInfoPtr_spriteSheet;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteCharacterTable;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteCharacterLookup;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteGlyphTable;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteGlyphLookup;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeFieldInfoPtr_spriteInfoList;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeFieldInfoPtr_fallbackSpriteAssets;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeFieldInfoPtr_m_IsSpriteAssetLookupTablesDirty;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeFieldInfoPtr_k_searchedSpriteAssets;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeMethodInfoPtr_get_version_Public_get_String_0;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeMethodInfoPtr_set_version_Internal_set_Void_String_0;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeMethodInfoPtr_get_faceInfo_Public_get_FaceInfo_0;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeMethodInfoPtr_set_faceInfo_Internal_set_Void_FaceInfo_0;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteCharacterTable_Public_get_List_1_TMP_SpriteCharacter_0;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeMethodInfoPtr_set_spriteCharacterTable_Internal_set_Void_List_1_TMP_SpriteCharacter_0;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteCharacterLookupTable_Public_get_Dictionary_2_UInt32_TMP_SpriteCharacter_0;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeMethodInfoPtr_set_spriteCharacterLookupTable_Internal_set_Void_Dictionary_2_UInt32_TMP_SpriteCharacter_0;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteGlyphTable_Public_get_List_1_TMP_SpriteGlyph_0;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeMethodInfoPtr_set_spriteGlyphTable_Internal_set_Void_List_1_TMP_SpriteGlyph_0;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultSpriteMaterial_Private_Material_0;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLookupTables_Public_Void_0;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteIndexFromHashcode_Public_Int32_Int32_0;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteIndexFromUnicode_Public_Int32_UInt32_0;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteIndexFromName_Public_Int32_String_0;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeMethodInfoPtr_SearchForSpriteByUnicode_Public_Static_TMP_SpriteAsset_TMP_SpriteAsset_UInt32_Boolean_byref_Int32_0;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeMethodInfoPtr_SearchForSpriteByUnicodeInternal_Private_Static_TMP_SpriteAsset_List_1_TMP_SpriteAsset_UInt32_Boolean_byref_Int32_0;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeMethodInfoPtr_SearchForSpriteByUnicodeInternal_Private_Static_TMP_SpriteAsset_TMP_SpriteAsset_UInt32_Boolean_byref_Int32_0;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeMethodInfoPtr_SearchForSpriteByHashCode_Public_Static_TMP_SpriteAsset_TMP_SpriteAsset_Int32_Boolean_byref_Int32_0;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeMethodInfoPtr_SearchForSpriteByHashCodeInternal_Private_Static_TMP_SpriteAsset_List_1_TMP_SpriteAsset_Int32_Boolean_byref_Int32_0;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeMethodInfoPtr_SearchForSpriteByHashCodeInternal_Private_Static_TMP_SpriteAsset_TMP_SpriteAsset_Int32_Boolean_byref_Int32_0;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeMethodInfoPtr_SortGlyphTable_Public_Void_0;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeMethodInfoPtr_SortCharacterTable_Internal_Void_0;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeMethodInfoPtr_SortGlyphAndCharacterTables_Internal_Void_0;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeMethodInfoPtr_UpgradeSpriteAsset_Private_Void_0;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000A8 RID: 168
		[ObfuscatedName("TMPro.TMP_SpriteAsset+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06000FF6 RID: 4086 RVA: 0x0003ED84 File Offset: 0x0003CF84
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TMP_SpriteAsset.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_SpriteAsset>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_SpriteAsset.__c>.NativeClassPtr);
				TMP_SpriteAsset.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset.__c>.NativeClassPtr, "<>9");
				TMP_SpriteAsset.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset.__c>.NativeClassPtr, "<>9__40_0");
				TMP_SpriteAsset.__c.NativeFieldInfoPtr___9__41_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteAsset.__c>.NativeClassPtr, "<>9__41_0");
				TMP_SpriteAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset.__c>.NativeClassPtr, 100664367);
				TMP_SpriteAsset.__c.NativeMethodInfoPtr__SortGlyphTable_b__40_0_Internal_UInt32_TMP_SpriteGlyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset.__c>.NativeClassPtr, 100664368);
				TMP_SpriteAsset.__c.NativeMethodInfoPtr__SortCharacterTable_b__41_0_Internal_UInt32_TMP_SpriteCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteAsset.__c>.NativeClassPtr, 100664369);
			}

			// Token: 0x06000FF7 RID: 4087 RVA: 0x0003EE28 File Offset: 0x0003D028
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SpriteAsset.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FF8 RID: 4088 RVA: 0x0003EE64 File Offset: 0x0003D064
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint _SortGlyphTable_b__40_0(TMP_SpriteGlyph item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.__c.NativeMethodInfoPtr__SortGlyphTable_b__40_0_Internal_UInt32_TMP_SpriteGlyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000FF9 RID: 4089 RVA: 0x0003EEB4 File Offset: 0x0003D0B4
			[CallerCount(0)]
			public unsafe uint _SortCharacterTable_b__41_0(TMP_SpriteCharacter c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteAsset.__c.NativeMethodInfoPtr__SortCharacterTable_b__41_0_Internal_UInt32_TMP_SpriteCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000FFA RID: 4090 RVA: 0x00009A2A File Offset: 0x00007C2A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005CC RID: 1484
			// (get) Token: 0x06000FFB RID: 4091 RVA: 0x0003EF04 File Offset: 0x0003D104
			// (set) Token: 0x06000FFC RID: 4092 RVA: 0x00009A33 File Offset: 0x00007C33
			public unsafe static TMP_SpriteAsset.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_SpriteAsset.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_SpriteAsset.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005CD RID: 1485
			// (get) Token: 0x06000FFD RID: 4093 RVA: 0x0003EF2C File Offset: 0x0003D12C
			// (set) Token: 0x06000FFE RID: 4094 RVA: 0x00009A45 File Offset: 0x00007C45
			public unsafe static Func<TMP_SpriteGlyph, uint> __9__40_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_SpriteAsset.__c.NativeFieldInfoPtr___9__40_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TMP_SpriteGlyph, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_SpriteAsset.__c.NativeFieldInfoPtr___9__40_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005CE RID: 1486
			// (get) Token: 0x06000FFF RID: 4095 RVA: 0x0003EF54 File Offset: 0x0003D154
			// (set) Token: 0x06001000 RID: 4096 RVA: 0x00009A57 File Offset: 0x00007C57
			public unsafe static Func<TMP_SpriteCharacter, uint> __9__41_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_SpriteAsset.__c.NativeFieldInfoPtr___9__41_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TMP_SpriteCharacter, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_SpriteAsset.__c.NativeFieldInfoPtr___9__41_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C79 RID: 3193
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000C7A RID: 3194
			private static readonly IntPtr NativeFieldInfoPtr___9__40_0;

			// Token: 0x04000C7B RID: 3195
			private static readonly IntPtr NativeFieldInfoPtr___9__41_0;

			// Token: 0x04000C7C RID: 3196
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000C7D RID: 3197
			private static readonly IntPtr NativeMethodInfoPtr__SortGlyphTable_b__40_0_Internal_UInt32_TMP_SpriteGlyph_0;

			// Token: 0x04000C7E RID: 3198
			private static readonly IntPtr NativeMethodInfoPtr__SortCharacterTable_b__41_0_Internal_UInt32_TMP_SpriteCharacter_0;
		}
	}
}

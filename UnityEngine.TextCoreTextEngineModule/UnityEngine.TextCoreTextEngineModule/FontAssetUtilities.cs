using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000009 RID: 9
	public static class FontAssetUtilities : Object
	{
		// Token: 0x0600012A RID: 298 RVA: 0x0000A74C File Offset: 0x0000894C
		// Note: this type is marked as 'beforefieldinit'.
		static FontAssetUtilities()
		{
			Il2CppClassPointerStore<FontAssetUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "FontAssetUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontAssetUtilities>.NativeClassPtr);
			FontAssetUtilities.NativeFieldInfoPtr_k_SearchedAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetUtilities>.NativeClassPtr, "k_SearchedAssets");
			FontAssetUtilities.NativeMethodInfoPtr_GetCharacterFromFontAsset_Internal_Static_Character_UInt32_FontAsset_Boolean_FontStyles_TextFontWeight_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAssetUtilities>.NativeClassPtr, 100663426);
			FontAssetUtilities.NativeMethodInfoPtr_GetCharacterFromFontAsset_Internal_Private_Static_Character_UInt32_FontAsset_Boolean_FontStyles_TextFontWeight_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAssetUtilities>.NativeClassPtr, 100663427);
			FontAssetUtilities.NativeMethodInfoPtr_GetCharacterFromFontAssets_Public_Static_Character_UInt32_FontAsset_List_1_FontAsset_Boolean_FontStyles_TextFontWeight_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAssetUtilities>.NativeClassPtr, 100663428);
			FontAssetUtilities.NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Public_Static_SpriteCharacter_UInt32_SpriteAsset_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAssetUtilities>.NativeClassPtr, 100663429);
			FontAssetUtilities.NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Internal_Private_Static_SpriteCharacter_UInt32_SpriteAsset_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAssetUtilities>.NativeClassPtr, 100663430);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000A7F4 File Offset: 0x000089F4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1099767, RefRangeEnd = 1099780, XrefRangeStart = 1099751, XrefRangeEnd = 1099767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Character GetCharacterFromFontAsset(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAssetUtilities.NativeMethodInfoPtr_GetCharacterFromFontAsset_Internal_Static_Character_UInt32_FontAsset_Boolean_FontStyles_TextFontWeight_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Character>(intPtr3) : null;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000A880 File Offset: 0x00008A80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1099807, RefRangeEnd = 1099810, XrefRangeStart = 1099780, XrefRangeEnd = 1099807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Character GetCharacterFromFontAsset_Internal(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAssetUtilities.NativeMethodInfoPtr_GetCharacterFromFontAsset_Internal_Private_Static_Character_UInt32_FontAsset_Boolean_FontStyles_TextFontWeight_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Character>(intPtr3) : null;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000A90C File Offset: 0x00008B0C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1099834, RefRangeEnd = 1099839, XrefRangeStart = 1099810, XrefRangeEnd = 1099834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Character GetCharacterFromFontAssets(uint unicode, FontAsset sourceFontAsset, List<FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAssetUtilities.NativeMethodInfoPtr_GetCharacterFromFontAssets_Public_Static_Character_UInt32_FontAsset_List_1_FontAsset_Boolean_FontStyles_TextFontWeight_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Character>(intPtr3) : null;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000A9AC File Offset: 0x00008BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099839, XrefRangeEnd = 1099879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAssetUtilities.NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Public_Static_SpriteCharacter_UInt32_SpriteAsset_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpriteCharacter>(intPtr3) : null;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000AA0C File Offset: 0x00008C0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1099898, RefRangeEnd = 1099900, XrefRangeStart = 1099879, XrefRangeEnd = 1099898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontAssetUtilities.NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Internal_Private_Static_SpriteCharacter_UInt32_SpriteAsset_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpriteCharacter>(intPtr3) : null;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000028E0 File Offset: 0x00000AE0
		public FontAssetUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0000AA6C File Offset: 0x00008C6C
		// (set) Token: 0x06000132 RID: 306 RVA: 0x000028E9 File Offset: 0x00000AE9
		public unsafe static HashSet<int> k_SearchedAssets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FontAssetUtilities.NativeFieldInfoPtr_k_SearchedAssets, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontAssetUtilities.NativeFieldInfoPtr_k_SearchedAssets, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeFieldInfoPtr_k_SearchedAssets;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterFromFontAsset_Internal_Static_Character_UInt32_FontAsset_Boolean_FontStyles_TextFontWeight_byref_Boolean_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterFromFontAsset_Internal_Private_Static_Character_UInt32_FontAsset_Boolean_FontStyles_TextFontWeight_byref_Boolean_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterFromFontAssets_Public_Static_Character_UInt32_FontAsset_List_1_FontAsset_Boolean_FontStyles_TextFontWeight_byref_Boolean_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Public_Static_SpriteCharacter_UInt32_SpriteAsset_Boolean_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteCharacterFromSpriteAsset_Internal_Private_Static_SpriteCharacter_UInt32_SpriteAsset_Boolean_0;
	}
}

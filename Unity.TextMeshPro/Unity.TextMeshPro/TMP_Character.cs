using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.TextCore;

namespace TMPro
{
	// Token: 0x02000020 RID: 32
	[Serializable]
	public class TMP_Character : TMP_TextElement
	{
		// Token: 0x06000300 RID: 768 RVA: 0x00013864 File Offset: 0x00011A64
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Character()
		{
			Il2CppClassPointerStore<TMP_Character>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Character");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Character>.NativeClassPtr);
			TMP_Character.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Character>.NativeClassPtr, 100663585);
			TMP_Character.NativeMethodInfoPtr__ctor_Public_Void_UInt32_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Character>.NativeClassPtr, 100663586);
			TMP_Character.NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_FontAsset_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Character>.NativeClassPtr, 100663587);
			TMP_Character.NativeMethodInfoPtr__ctor_Internal_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Character>.NativeClassPtr, 100663588);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x000138E4 File Offset: 0x00011AE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1038036, RefRangeEnd = 1038038, XrefRangeStart = 1038035, XrefRangeEnd = 1038036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Character()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Character>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Character.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00013920 File Offset: 0x00011B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038038, XrefRangeEnd = 1038042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Character(uint unicode, Glyph glyph)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Character>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(glyph);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Character.NativeMethodInfoPtr__ctor_Public_Void_UInt32_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0001397C File Offset: 0x00011B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038042, XrefRangeEnd = 1038046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Character(uint unicode, TMP_FontAsset fontAsset, Glyph glyph)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Character>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(glyph);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Character.NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_FontAsset_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x000139E8 File Offset: 0x00011BE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1038049, RefRangeEnd = 1038051, XrefRangeStart = 1038046, XrefRangeEnd = 1038049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Character(uint unicode, uint glyphIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Character>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glyphIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Character.NativeMethodInfoPtr__ctor_Internal_Void_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x000037E1 File Offset: 0x000019E1
		public TMP_Character(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_Glyph_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_TMP_FontAsset_Glyph_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UInt32_UInt32_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.TextCore;

namespace TMPro
{
	// Token: 0x02000069 RID: 105
	[Serializable]
	public class TMP_TextElement : Object
	{
		// Token: 0x06000D76 RID: 3446 RVA: 0x00037044 File Offset: 0x00035244
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_TextElement()
		{
			Il2CppClassPointerStore<TMP_TextElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_TextElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_TextElement>.NativeClassPtr);
			TMP_TextElement.NativeFieldInfoPtr_m_ElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextElement>.NativeClassPtr, "m_ElementType");
			TMP_TextElement.NativeFieldInfoPtr_m_Unicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextElement>.NativeClassPtr, "m_Unicode");
			TMP_TextElement.NativeFieldInfoPtr_m_TextAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextElement>.NativeClassPtr, "m_TextAsset");
			TMP_TextElement.NativeFieldInfoPtr_m_Glyph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextElement>.NativeClassPtr, "m_Glyph");
			TMP_TextElement.NativeFieldInfoPtr_m_GlyphIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextElement>.NativeClassPtr, "m_GlyphIndex");
			TMP_TextElement.NativeFieldInfoPtr_m_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextElement>.NativeClassPtr, "m_Scale");
			TMP_TextElement.NativeMethodInfoPtr_get_elementType_Public_get_TextElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextElement>.NativeClassPtr, 100664797);
			TMP_TextElement.NativeMethodInfoPtr_get_unicode_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextElement>.NativeClassPtr, 100664798);
			TMP_TextElement.NativeMethodInfoPtr_set_unicode_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextElement>.NativeClassPtr, 100664799);
			TMP_TextElement.NativeMethodInfoPtr_get_textAsset_Public_get_TMP_Asset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextElement>.NativeClassPtr, 100664800);
			TMP_TextElement.NativeMethodInfoPtr_set_textAsset_Public_set_Void_TMP_Asset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextElement>.NativeClassPtr, 100664801);
			TMP_TextElement.NativeMethodInfoPtr_get_glyph_Public_get_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextElement>.NativeClassPtr, 100664802);
			TMP_TextElement.NativeMethodInfoPtr_set_glyph_Public_set_Void_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextElement>.NativeClassPtr, 100664803);
			TMP_TextElement.NativeMethodInfoPtr_get_glyphIndex_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextElement>.NativeClassPtr, 100664804);
			TMP_TextElement.NativeMethodInfoPtr_set_glyphIndex_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextElement>.NativeClassPtr, 100664805);
			TMP_TextElement.NativeMethodInfoPtr_get_scale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextElement>.NativeClassPtr, 100664806);
			TMP_TextElement.NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextElement>.NativeClassPtr, 100664807);
			TMP_TextElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextElement>.NativeClassPtr, 100664808);
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000D77 RID: 3447 RVA: 0x000371DC File Offset: 0x000353DC
		public unsafe TextElementType elementType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextElement.NativeMethodInfoPtr_get_elementType_Public_get_TextElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x00037218 File Offset: 0x00035418
		// (set) Token: 0x06000D79 RID: 3449 RVA: 0x00037254 File Offset: 0x00035454
		public unsafe uint unicode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextElement.NativeMethodInfoPtr_get_unicode_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 310312, RefRangeEnd = 310318, XrefRangeStart = 310312, XrefRangeEnd = 310318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextElement.NativeMethodInfoPtr_set_unicode_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x00037294 File Offset: 0x00035494
		// (set) Token: 0x06000D7B RID: 3451 RVA: 0x000372D4 File Offset: 0x000354D4
		public unsafe TMP_Asset textAsset
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextElement.NativeMethodInfoPtr_get_textAsset_Public_get_TMP_Asset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Asset>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextElement.NativeMethodInfoPtr_set_textAsset_Public_set_Void_TMP_Asset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x00037318 File Offset: 0x00035518
		// (set) Token: 0x06000D7D RID: 3453 RVA: 0x00037358 File Offset: 0x00035558
		public unsafe Glyph glyph
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextElement.NativeMethodInfoPtr_get_glyph_Public_get_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Glyph>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextElement.NativeMethodInfoPtr_set_glyph_Public_set_Void_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x0003739C File Offset: 0x0003559C
		// (set) Token: 0x06000D7F RID: 3455 RVA: 0x000373D8 File Offset: 0x000355D8
		public unsafe uint glyphIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextElement.NativeMethodInfoPtr_get_glyphIndex_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextElement.NativeMethodInfoPtr_set_glyphIndex_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x00037418 File Offset: 0x00035618
		// (set) Token: 0x06000D81 RID: 3457 RVA: 0x00037454 File Offset: 0x00035654
		public unsafe float scale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextElement.NativeMethodInfoPtr_get_scale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 318232, RefRangeEnd = 318235, XrefRangeStart = 318232, XrefRangeEnd = 318235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextElement.NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x00037494 File Offset: 0x00035694
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_TextElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x000085DC File Offset: 0x000067DC
		public TMP_TextElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x000374D0 File Offset: 0x000356D0
		// (set) Token: 0x06000D85 RID: 3461 RVA: 0x000085E5 File Offset: 0x000067E5
		public unsafe TextElementType m_ElementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement.NativeFieldInfoPtr_m_ElementType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement.NativeFieldInfoPtr_m_ElementType)) = value;
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x000374F8 File Offset: 0x000356F8
		// (set) Token: 0x06000D87 RID: 3463 RVA: 0x00008600 File Offset: 0x00006800
		public unsafe uint m_Unicode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement.NativeFieldInfoPtr_m_Unicode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement.NativeFieldInfoPtr_m_Unicode)) = value;
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000D88 RID: 3464 RVA: 0x00037520 File Offset: 0x00035720
		// (set) Token: 0x06000D89 RID: 3465 RVA: 0x0000861B File Offset: 0x0000681B
		public unsafe TMP_Asset m_TextAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement.NativeFieldInfoPtr_m_TextAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Asset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement.NativeFieldInfoPtr_m_TextAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000D8A RID: 3466 RVA: 0x00037550 File Offset: 0x00035750
		// (set) Token: 0x06000D8B RID: 3467 RVA: 0x0000863A File Offset: 0x0000683A
		public unsafe Glyph m_Glyph
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement.NativeFieldInfoPtr_m_Glyph);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Glyph>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement.NativeFieldInfoPtr_m_Glyph), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000D8C RID: 3468 RVA: 0x00037580 File Offset: 0x00035780
		// (set) Token: 0x06000D8D RID: 3469 RVA: 0x00008659 File Offset: 0x00006859
		public unsafe uint m_GlyphIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement.NativeFieldInfoPtr_m_GlyphIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement.NativeFieldInfoPtr_m_GlyphIndex)) = value;
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000D8E RID: 3470 RVA: 0x000375A8 File Offset: 0x000357A8
		// (set) Token: 0x06000D8F RID: 3471 RVA: 0x00008674 File Offset: 0x00006874
		public unsafe float m_Scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement.NativeFieldInfoPtr_m_Scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement.NativeFieldInfoPtr_m_Scale)) = value;
			}
		}

		// Token: 0x04000AAD RID: 2733
		private static readonly IntPtr NativeFieldInfoPtr_m_ElementType;

		// Token: 0x04000AAE RID: 2734
		private static readonly IntPtr NativeFieldInfoPtr_m_Unicode;

		// Token: 0x04000AAF RID: 2735
		private static readonly IntPtr NativeFieldInfoPtr_m_TextAsset;

		// Token: 0x04000AB0 RID: 2736
		private static readonly IntPtr NativeFieldInfoPtr_m_Glyph;

		// Token: 0x04000AB1 RID: 2737
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphIndex;

		// Token: 0x04000AB2 RID: 2738
		private static readonly IntPtr NativeFieldInfoPtr_m_Scale;

		// Token: 0x04000AB3 RID: 2739
		private static readonly IntPtr NativeMethodInfoPtr_get_elementType_Public_get_TextElementType_0;

		// Token: 0x04000AB4 RID: 2740
		private static readonly IntPtr NativeMethodInfoPtr_get_unicode_Public_get_UInt32_0;

		// Token: 0x04000AB5 RID: 2741
		private static readonly IntPtr NativeMethodInfoPtr_set_unicode_Public_set_Void_UInt32_0;

		// Token: 0x04000AB6 RID: 2742
		private static readonly IntPtr NativeMethodInfoPtr_get_textAsset_Public_get_TMP_Asset_0;

		// Token: 0x04000AB7 RID: 2743
		private static readonly IntPtr NativeMethodInfoPtr_set_textAsset_Public_set_Void_TMP_Asset_0;

		// Token: 0x04000AB8 RID: 2744
		private static readonly IntPtr NativeMethodInfoPtr_get_glyph_Public_get_Glyph_0;

		// Token: 0x04000AB9 RID: 2745
		private static readonly IntPtr NativeMethodInfoPtr_set_glyph_Public_set_Void_Glyph_0;

		// Token: 0x04000ABA RID: 2746
		private static readonly IntPtr NativeMethodInfoPtr_get_glyphIndex_Public_get_UInt32_0;

		// Token: 0x04000ABB RID: 2747
		private static readonly IntPtr NativeMethodInfoPtr_set_glyphIndex_Public_set_Void_UInt32_0;

		// Token: 0x04000ABC RID: 2748
		private static readonly IntPtr NativeMethodInfoPtr_get_scale_Public_get_Single_0;

		// Token: 0x04000ABD RID: 2749
		private static readonly IntPtr NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0;

		// Token: 0x04000ABE RID: 2750
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

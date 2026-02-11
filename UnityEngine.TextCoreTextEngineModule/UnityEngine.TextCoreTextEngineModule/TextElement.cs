using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200001A RID: 26
	[Serializable]
	public class TextElement : Object
	{
		// Token: 0x0600023D RID: 573 RVA: 0x0000DF9C File Offset: 0x0000C19C
		// Note: this type is marked as 'beforefieldinit'.
		static TextElement()
		{
			Il2CppClassPointerStore<TextElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextElement>.NativeClassPtr);
			TextElement.NativeFieldInfoPtr_m_ElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "m_ElementType");
			TextElement.NativeFieldInfoPtr_m_Unicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "m_Unicode");
			TextElement.NativeFieldInfoPtr_m_TextAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "m_TextAsset");
			TextElement.NativeFieldInfoPtr_m_Glyph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "m_Glyph");
			TextElement.NativeFieldInfoPtr_m_GlyphIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "m_GlyphIndex");
			TextElement.NativeFieldInfoPtr_m_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "m_Scale");
			TextElement.NativeMethodInfoPtr_get_elementType_Public_get_TextElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100663525);
			TextElement.NativeMethodInfoPtr_get_unicode_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100663526);
			TextElement.NativeMethodInfoPtr_set_unicode_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100663527);
			TextElement.NativeMethodInfoPtr_get_textAsset_Public_get_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100663528);
			TextElement.NativeMethodInfoPtr_set_textAsset_Public_set_Void_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100663529);
			TextElement.NativeMethodInfoPtr_get_glyph_Public_get_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100663530);
			TextElement.NativeMethodInfoPtr_set_glyph_Public_set_Void_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100663531);
			TextElement.NativeMethodInfoPtr_get_glyphIndex_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100663532);
			TextElement.NativeMethodInfoPtr_set_glyphIndex_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100663533);
			TextElement.NativeMethodInfoPtr_get_scale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100663534);
			TextElement.NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100663535);
			TextElement.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100663536);
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600023E RID: 574 RVA: 0x0000E134 File Offset: 0x0000C334
		public unsafe TextElementType elementType
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1101036, RefRangeEnd = 1101038, XrefRangeStart = 1101036, XrefRangeEnd = 1101036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_get_elementType_Public_get_TextElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600023F RID: 575 RVA: 0x0000E170 File Offset: 0x0000C370
		// (set) Token: 0x06000240 RID: 576 RVA: 0x0000E1AC File Offset: 0x0000C3AC
		public unsafe uint unicode
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 334566, RefRangeEnd = 334587, XrefRangeStart = 334566, XrefRangeEnd = 334587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_get_unicode_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_set_unicode_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000241 RID: 577 RVA: 0x0000E1EC File Offset: 0x0000C3EC
		// (set) Token: 0x06000242 RID: 578 RVA: 0x0000E22C File Offset: 0x0000C42C
		public unsafe TextAsset textAsset
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 318167, RefRangeEnd = 318212, XrefRangeStart = 318167, XrefRangeEnd = 318212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_get_textAsset_Public_get_TextAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_set_textAsset_Public_set_Void_TextAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000243 RID: 579 RVA: 0x0000E270 File Offset: 0x0000C470
		// (set) Token: 0x06000244 RID: 580 RVA: 0x0000E2B0 File Offset: 0x0000C4B0
		public unsafe Glyph glyph
		{
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 337628, RefRangeEnd = 337663, XrefRangeStart = 337628, XrefRangeEnd = 337663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_get_glyph_Public_get_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_set_glyph_Public_set_Void_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000245 RID: 581 RVA: 0x0000E2F4 File Offset: 0x0000C4F4
		// (set) Token: 0x06000246 RID: 582 RVA: 0x0000E330 File Offset: 0x0000C530
		public unsafe uint glyphIndex
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 678450, RefRangeEnd = 678472, XrefRangeStart = 678450, XrefRangeEnd = 678472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_get_glyphIndex_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_set_glyphIndex_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000247 RID: 583 RVA: 0x0000E370 File Offset: 0x0000C570
		// (set) Token: 0x06000248 RID: 584 RVA: 0x0000E3AC File Offset: 0x0000C5AC
		public unsafe float scale
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 318216, RefRangeEnd = 318232, XrefRangeStart = 318216, XrefRangeEnd = 318232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_get_scale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000E3EC File Offset: 0x0000C5EC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000031BF File Offset: 0x000013BF
		public TextElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600024B RID: 587 RVA: 0x0000E428 File Offset: 0x0000C628
		// (set) Token: 0x0600024C RID: 588 RVA: 0x000031C8 File Offset: 0x000013C8
		public unsafe TextElementType m_ElementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_ElementType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_ElementType)) = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600024D RID: 589 RVA: 0x0000E450 File Offset: 0x0000C650
		// (set) Token: 0x0600024E RID: 590 RVA: 0x000031E3 File Offset: 0x000013E3
		public unsafe uint m_Unicode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_Unicode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_Unicode)) = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600024F RID: 591 RVA: 0x0000E478 File Offset: 0x0000C678
		// (set) Token: 0x06000250 RID: 592 RVA: 0x000031FE File Offset: 0x000013FE
		public unsafe TextAsset m_TextAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_TextAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_TextAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000251 RID: 593 RVA: 0x0000E4A8 File Offset: 0x0000C6A8
		// (set) Token: 0x06000252 RID: 594 RVA: 0x0000321D File Offset: 0x0000141D
		public unsafe Glyph m_Glyph
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_Glyph);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Glyph>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_Glyph), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000253 RID: 595 RVA: 0x0000E4D8 File Offset: 0x0000C6D8
		// (set) Token: 0x06000254 RID: 596 RVA: 0x0000323C File Offset: 0x0000143C
		public unsafe uint m_GlyphIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_GlyphIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_GlyphIndex)) = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000255 RID: 597 RVA: 0x0000E500 File Offset: 0x0000C700
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00003257 File Offset: 0x00001457
		public unsafe float m_Scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_Scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_Scale)) = value;
			}
		}

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeFieldInfoPtr_m_ElementType;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeFieldInfoPtr_m_Unicode;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeFieldInfoPtr_m_TextAsset;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeFieldInfoPtr_m_Glyph;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphIndex;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeFieldInfoPtr_m_Scale;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_get_elementType_Public_get_TextElementType_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_get_unicode_Public_get_UInt32_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_set_unicode_Public_set_Void_UInt32_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_get_textAsset_Public_get_TextAsset_0;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_set_textAsset_Public_set_Void_TextAsset_0;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_get_glyph_Public_get_Glyph_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_set_glyph_Public_set_Void_Glyph_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr_get_glyphIndex_Public_get_UInt32_0;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_set_glyphIndex_Public_set_Void_UInt32_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr_get_scale_Public_get_Single_0;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200001C RID: 28
	public sealed class TextElementInfo : ValueType
	{
		// Token: 0x06000259 RID: 601 RVA: 0x0000E5A8 File Offset: 0x0000C7A8
		// Note: this type is marked as 'beforefieldinit'.
		static TextElementInfo()
		{
			Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextElementInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr);
			TextElementInfo.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "character");
			TextElementInfo.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "index");
			TextElementInfo.NativeFieldInfoPtr_elementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "elementType");
			TextElementInfo.NativeFieldInfoPtr_stringLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "stringLength");
			TextElementInfo.NativeFieldInfoPtr_textElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "textElement");
			TextElementInfo.NativeFieldInfoPtr_alternativeGlyph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "alternativeGlyph");
			TextElementInfo.NativeFieldInfoPtr_fontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "fontAsset");
			TextElementInfo.NativeFieldInfoPtr_spriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "spriteAsset");
			TextElementInfo.NativeFieldInfoPtr_spriteIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "spriteIndex");
			TextElementInfo.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "material");
			TextElementInfo.NativeFieldInfoPtr_materialReferenceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "materialReferenceIndex");
			TextElementInfo.NativeFieldInfoPtr_isUsingAlternateTypeface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "isUsingAlternateTypeface");
			TextElementInfo.NativeFieldInfoPtr_pointSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "pointSize");
			TextElementInfo.NativeFieldInfoPtr_lineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "lineNumber");
			TextElementInfo.NativeFieldInfoPtr_pageNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "pageNumber");
			TextElementInfo.NativeFieldInfoPtr_vertexIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "vertexIndex");
			TextElementInfo.NativeFieldInfoPtr_vertexTopLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "vertexTopLeft");
			TextElementInfo.NativeFieldInfoPtr_vertexBottomLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "vertexBottomLeft");
			TextElementInfo.NativeFieldInfoPtr_vertexTopRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "vertexTopRight");
			TextElementInfo.NativeFieldInfoPtr_vertexBottomRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "vertexBottomRight");
			TextElementInfo.NativeFieldInfoPtr_topLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "topLeft");
			TextElementInfo.NativeFieldInfoPtr_bottomLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "bottomLeft");
			TextElementInfo.NativeFieldInfoPtr_topRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "topRight");
			TextElementInfo.NativeFieldInfoPtr_bottomRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "bottomRight");
			TextElementInfo.NativeFieldInfoPtr_origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "origin");
			TextElementInfo.NativeFieldInfoPtr_ascender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "ascender");
			TextElementInfo.NativeFieldInfoPtr_baseLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "baseLine");
			TextElementInfo.NativeFieldInfoPtr_descender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "descender");
			TextElementInfo.NativeFieldInfoPtr_adjustedAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "adjustedAscender");
			TextElementInfo.NativeFieldInfoPtr_adjustedDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "adjustedDescender");
			TextElementInfo.NativeFieldInfoPtr_adjustedHorizontalAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "adjustedHorizontalAdvance");
			TextElementInfo.NativeFieldInfoPtr_xAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "xAdvance");
			TextElementInfo.NativeFieldInfoPtr_aspectRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "aspectRatio");
			TextElementInfo.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "scale");
			TextElementInfo.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "color");
			TextElementInfo.NativeFieldInfoPtr_underlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "underlineColor");
			TextElementInfo.NativeFieldInfoPtr_underlineVertexIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "underlineVertexIndex");
			TextElementInfo.NativeFieldInfoPtr_strikethroughColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "strikethroughColor");
			TextElementInfo.NativeFieldInfoPtr_strikethroughVertexIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "strikethroughVertexIndex");
			TextElementInfo.NativeFieldInfoPtr_highlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "highlightColor");
			TextElementInfo.NativeFieldInfoPtr_highlightState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "highlightState");
			TextElementInfo.NativeFieldInfoPtr_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "style");
			TextElementInfo.NativeFieldInfoPtr_isVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, "isVisible");
			TextElementInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr, 100663537);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000E948 File Offset: 0x0000CB48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101038, XrefRangeEnd = 1101431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElementInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00003284 File Offset: 0x00001484
		public TextElementInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000328D File Offset: 0x0000148D
		public TextElementInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextElementInfo>.NativeClassPtr))
		{
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600025D RID: 605 RVA: 0x0000E984 File Offset: 0x0000CB84
		// (set) Token: 0x0600025E RID: 606 RVA: 0x0000329F File Offset: 0x0000149F
		public unsafe char character
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_character);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_character)) = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600025F RID: 607 RVA: 0x0000E9AC File Offset: 0x0000CBAC
		// (set) Token: 0x06000260 RID: 608 RVA: 0x000032BA File Offset: 0x000014BA
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000261 RID: 609 RVA: 0x0000E9D4 File Offset: 0x0000CBD4
		// (set) Token: 0x06000262 RID: 610 RVA: 0x000032D5 File Offset: 0x000014D5
		public unsafe TextElementType elementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_elementType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_elementType)) = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000263 RID: 611 RVA: 0x0000E9FC File Offset: 0x0000CBFC
		// (set) Token: 0x06000264 RID: 612 RVA: 0x000032F0 File Offset: 0x000014F0
		public unsafe int stringLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_stringLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_stringLength)) = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000265 RID: 613 RVA: 0x0000EA24 File Offset: 0x0000CC24
		// (set) Token: 0x06000266 RID: 614 RVA: 0x0000330B File Offset: 0x0000150B
		public unsafe TextElement textElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_textElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_textElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000267 RID: 615 RVA: 0x0000EA54 File Offset: 0x0000CC54
		// (set) Token: 0x06000268 RID: 616 RVA: 0x0000332A File Offset: 0x0000152A
		public unsafe Glyph alternativeGlyph
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_alternativeGlyph);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Glyph>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_alternativeGlyph), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000269 RID: 617 RVA: 0x0000EA84 File Offset: 0x0000CC84
		// (set) Token: 0x0600026A RID: 618 RVA: 0x00003349 File Offset: 0x00001549
		public unsafe FontAsset fontAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_fontAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_fontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600026B RID: 619 RVA: 0x0000EAB4 File Offset: 0x0000CCB4
		// (set) Token: 0x0600026C RID: 620 RVA: 0x00003368 File Offset: 0x00001568
		public unsafe SpriteAsset spriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_spriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_spriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0000EAE4 File Offset: 0x0000CCE4
		// (set) Token: 0x0600026E RID: 622 RVA: 0x00003387 File Offset: 0x00001587
		public unsafe int spriteIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_spriteIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_spriteIndex)) = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600026F RID: 623 RVA: 0x0000EB0C File Offset: 0x0000CD0C
		// (set) Token: 0x06000270 RID: 624 RVA: 0x000033A2 File Offset: 0x000015A2
		public unsafe Material material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000271 RID: 625 RVA: 0x0000EB3C File Offset: 0x0000CD3C
		// (set) Token: 0x06000272 RID: 626 RVA: 0x000033C1 File Offset: 0x000015C1
		public unsafe int materialReferenceIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_materialReferenceIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_materialReferenceIndex)) = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0000EB64 File Offset: 0x0000CD64
		// (set) Token: 0x06000274 RID: 628 RVA: 0x000033DC File Offset: 0x000015DC
		public unsafe bool isUsingAlternateTypeface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_isUsingAlternateTypeface);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_isUsingAlternateTypeface)) = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000275 RID: 629 RVA: 0x0000EB8C File Offset: 0x0000CD8C
		// (set) Token: 0x06000276 RID: 630 RVA: 0x000033F7 File Offset: 0x000015F7
		public unsafe float pointSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_pointSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_pointSize)) = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0000EBB4 File Offset: 0x0000CDB4
		// (set) Token: 0x06000278 RID: 632 RVA: 0x00003412 File Offset: 0x00001612
		public unsafe int lineNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_lineNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_lineNumber)) = value;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000279 RID: 633 RVA: 0x0000EBDC File Offset: 0x0000CDDC
		// (set) Token: 0x0600027A RID: 634 RVA: 0x0000342D File Offset: 0x0000162D
		public unsafe int pageNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_pageNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_pageNumber)) = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600027B RID: 635 RVA: 0x0000EC04 File Offset: 0x0000CE04
		// (set) Token: 0x0600027C RID: 636 RVA: 0x00003448 File Offset: 0x00001648
		public unsafe int vertexIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_vertexIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_vertexIndex)) = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600027D RID: 637 RVA: 0x0000EC2C File Offset: 0x0000CE2C
		// (set) Token: 0x0600027E RID: 638 RVA: 0x00003463 File Offset: 0x00001663
		public unsafe TextVertex vertexTopLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_vertexTopLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_vertexTopLeft)) = value;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600027F RID: 639 RVA: 0x0000EC54 File Offset: 0x0000CE54
		// (set) Token: 0x06000280 RID: 640 RVA: 0x0000347E File Offset: 0x0000167E
		public unsafe TextVertex vertexBottomLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_vertexBottomLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_vertexBottomLeft)) = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000281 RID: 641 RVA: 0x0000EC7C File Offset: 0x0000CE7C
		// (set) Token: 0x06000282 RID: 642 RVA: 0x00003499 File Offset: 0x00001699
		public unsafe TextVertex vertexTopRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_vertexTopRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_vertexTopRight)) = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000283 RID: 643 RVA: 0x0000ECA4 File Offset: 0x0000CEA4
		// (set) Token: 0x06000284 RID: 644 RVA: 0x000034B4 File Offset: 0x000016B4
		public unsafe TextVertex vertexBottomRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_vertexBottomRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_vertexBottomRight)) = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0000ECCC File Offset: 0x0000CECC
		// (set) Token: 0x06000286 RID: 646 RVA: 0x000034CF File Offset: 0x000016CF
		public unsafe Vector3 topLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_topLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_topLeft)) = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000287 RID: 647 RVA: 0x0000ECF4 File Offset: 0x0000CEF4
		// (set) Token: 0x06000288 RID: 648 RVA: 0x000034EA File Offset: 0x000016EA
		public unsafe Vector3 bottomLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_bottomLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_bottomLeft)) = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000289 RID: 649 RVA: 0x0000ED1C File Offset: 0x0000CF1C
		// (set) Token: 0x0600028A RID: 650 RVA: 0x00003505 File Offset: 0x00001705
		public unsafe Vector3 topRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_topRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_topRight)) = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600028B RID: 651 RVA: 0x0000ED44 File Offset: 0x0000CF44
		// (set) Token: 0x0600028C RID: 652 RVA: 0x00003520 File Offset: 0x00001720
		public unsafe Vector3 bottomRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_bottomRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_bottomRight)) = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600028D RID: 653 RVA: 0x0000ED6C File Offset: 0x0000CF6C
		// (set) Token: 0x0600028E RID: 654 RVA: 0x0000353B File Offset: 0x0000173B
		public unsafe float origin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_origin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_origin)) = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600028F RID: 655 RVA: 0x0000ED94 File Offset: 0x0000CF94
		// (set) Token: 0x06000290 RID: 656 RVA: 0x00003556 File Offset: 0x00001756
		public unsafe float ascender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_ascender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_ascender)) = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000291 RID: 657 RVA: 0x0000EDBC File Offset: 0x0000CFBC
		// (set) Token: 0x06000292 RID: 658 RVA: 0x00003571 File Offset: 0x00001771
		public unsafe float baseLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_baseLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_baseLine)) = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0000EDE4 File Offset: 0x0000CFE4
		// (set) Token: 0x06000294 RID: 660 RVA: 0x0000358C File Offset: 0x0000178C
		public unsafe float descender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_descender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_descender)) = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0000EE0C File Offset: 0x0000D00C
		// (set) Token: 0x06000296 RID: 662 RVA: 0x000035A7 File Offset: 0x000017A7
		public unsafe float adjustedAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_adjustedAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_adjustedAscender)) = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000297 RID: 663 RVA: 0x0000EE34 File Offset: 0x0000D034
		// (set) Token: 0x06000298 RID: 664 RVA: 0x000035C2 File Offset: 0x000017C2
		public unsafe float adjustedDescender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_adjustedDescender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_adjustedDescender)) = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000299 RID: 665 RVA: 0x0000EE5C File Offset: 0x0000D05C
		// (set) Token: 0x0600029A RID: 666 RVA: 0x000035DD File Offset: 0x000017DD
		public unsafe float adjustedHorizontalAdvance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_adjustedHorizontalAdvance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_adjustedHorizontalAdvance)) = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600029B RID: 667 RVA: 0x0000EE84 File Offset: 0x0000D084
		// (set) Token: 0x0600029C RID: 668 RVA: 0x000035F8 File Offset: 0x000017F8
		public unsafe float xAdvance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_xAdvance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_xAdvance)) = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600029D RID: 669 RVA: 0x0000EEAC File Offset: 0x0000D0AC
		// (set) Token: 0x0600029E RID: 670 RVA: 0x00003613 File Offset: 0x00001813
		public unsafe float aspectRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_aspectRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_aspectRatio)) = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600029F RID: 671 RVA: 0x0000EED4 File Offset: 0x0000D0D4
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x0000362E File Offset: 0x0000182E
		public unsafe float scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_scale)) = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x0000EEFC File Offset: 0x0000D0FC
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x00003649 File Offset: 0x00001849
		public unsafe Color32 color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_color)) = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x0000EF24 File Offset: 0x0000D124
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x00003664 File Offset: 0x00001864
		public unsafe Color32 underlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_underlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_underlineColor)) = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0000EF4C File Offset: 0x0000D14C
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x0000367F File Offset: 0x0000187F
		public unsafe int underlineVertexIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_underlineVertexIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_underlineVertexIndex)) = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0000EF74 File Offset: 0x0000D174
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x0000369A File Offset: 0x0000189A
		public unsafe Color32 strikethroughColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_strikethroughColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_strikethroughColor)) = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000EF9C File Offset: 0x0000D19C
		// (set) Token: 0x060002AA RID: 682 RVA: 0x000036B5 File Offset: 0x000018B5
		public unsafe int strikethroughVertexIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_strikethroughVertexIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_strikethroughVertexIndex)) = value;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060002AB RID: 683 RVA: 0x0000EFC4 File Offset: 0x0000D1C4
		// (set) Token: 0x060002AC RID: 684 RVA: 0x000036D0 File Offset: 0x000018D0
		public unsafe Color32 highlightColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_highlightColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_highlightColor)) = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060002AD RID: 685 RVA: 0x0000EFEC File Offset: 0x0000D1EC
		// (set) Token: 0x060002AE RID: 686 RVA: 0x000036EB File Offset: 0x000018EB
		public unsafe HighlightState highlightState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_highlightState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_highlightState)) = value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060002AF RID: 687 RVA: 0x0000F014 File Offset: 0x0000D214
		// (set) Token: 0x060002B0 RID: 688 RVA: 0x00003706 File Offset: 0x00001906
		public unsafe FontStyles style
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_style);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_style)) = value;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x0000F03C File Offset: 0x0000D23C
		// (set) Token: 0x060002B2 RID: 690 RVA: 0x00003721 File Offset: 0x00001921
		public unsafe bool isVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_isVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElementInfo.NativeFieldInfoPtr_isVisible)) = value;
			}
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000373C File Offset: 0x0000193C
		public string ToStringTest()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeFieldInfoPtr_character;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeFieldInfoPtr_elementType;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeFieldInfoPtr_stringLength;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeFieldInfoPtr_textElement;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeFieldInfoPtr_alternativeGlyph;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeFieldInfoPtr_fontAsset;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeFieldInfoPtr_spriteAsset;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeFieldInfoPtr_spriteIndex;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeFieldInfoPtr_material;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeFieldInfoPtr_materialReferenceIndex;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeFieldInfoPtr_isUsingAlternateTypeface;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeFieldInfoPtr_pointSize;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeFieldInfoPtr_lineNumber;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeFieldInfoPtr_pageNumber;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeFieldInfoPtr_vertexIndex;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeFieldInfoPtr_vertexTopLeft;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeFieldInfoPtr_vertexBottomLeft;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeFieldInfoPtr_vertexTopRight;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeFieldInfoPtr_vertexBottomRight;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeFieldInfoPtr_topLeft;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeFieldInfoPtr_bottomLeft;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeFieldInfoPtr_topRight;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeFieldInfoPtr_bottomRight;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeFieldInfoPtr_origin;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeFieldInfoPtr_ascender;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeFieldInfoPtr_baseLine;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeFieldInfoPtr_descender;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeFieldInfoPtr_adjustedAscender;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeFieldInfoPtr_adjustedDescender;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeFieldInfoPtr_adjustedHorizontalAdvance;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeFieldInfoPtr_xAdvance;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeFieldInfoPtr_aspectRatio;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeFieldInfoPtr_underlineColor;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeFieldInfoPtr_underlineVertexIndex;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeFieldInfoPtr_strikethroughColor;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeFieldInfoPtr_strikethroughVertexIndex;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeFieldInfoPtr_highlightColor;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeFieldInfoPtr_highlightState;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeFieldInfoPtr_style;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeFieldInfoPtr_isVisible;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}

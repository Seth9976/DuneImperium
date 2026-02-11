using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000024 RID: 36
	public sealed class TMP_CharacterInfo : ValueType
	{
		// Token: 0x0600032C RID: 812 RVA: 0x000144B4 File Offset: 0x000126B4
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_CharacterInfo()
		{
			Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_CharacterInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr);
			TMP_CharacterInfo.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "character");
			TMP_CharacterInfo.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "index");
			TMP_CharacterInfo.NativeFieldInfoPtr_stringLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "stringLength");
			TMP_CharacterInfo.NativeFieldInfoPtr_elementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "elementType");
			TMP_CharacterInfo.NativeFieldInfoPtr_textElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "textElement");
			TMP_CharacterInfo.NativeFieldInfoPtr_fontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "fontAsset");
			TMP_CharacterInfo.NativeFieldInfoPtr_spriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "spriteAsset");
			TMP_CharacterInfo.NativeFieldInfoPtr_spriteIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "spriteIndex");
			TMP_CharacterInfo.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "material");
			TMP_CharacterInfo.NativeFieldInfoPtr_materialReferenceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "materialReferenceIndex");
			TMP_CharacterInfo.NativeFieldInfoPtr_isUsingAlternateTypeface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "isUsingAlternateTypeface");
			TMP_CharacterInfo.NativeFieldInfoPtr_pointSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "pointSize");
			TMP_CharacterInfo.NativeFieldInfoPtr_lineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "lineNumber");
			TMP_CharacterInfo.NativeFieldInfoPtr_pageNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "pageNumber");
			TMP_CharacterInfo.NativeFieldInfoPtr_vertexIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "vertexIndex");
			TMP_CharacterInfo.NativeFieldInfoPtr_vertex_BL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "vertex_BL");
			TMP_CharacterInfo.NativeFieldInfoPtr_vertex_TL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "vertex_TL");
			TMP_CharacterInfo.NativeFieldInfoPtr_vertex_TR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "vertex_TR");
			TMP_CharacterInfo.NativeFieldInfoPtr_vertex_BR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "vertex_BR");
			TMP_CharacterInfo.NativeFieldInfoPtr_topLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "topLeft");
			TMP_CharacterInfo.NativeFieldInfoPtr_bottomLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "bottomLeft");
			TMP_CharacterInfo.NativeFieldInfoPtr_topRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "topRight");
			TMP_CharacterInfo.NativeFieldInfoPtr_bottomRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "bottomRight");
			TMP_CharacterInfo.NativeFieldInfoPtr_origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "origin");
			TMP_CharacterInfo.NativeFieldInfoPtr_xAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "xAdvance");
			TMP_CharacterInfo.NativeFieldInfoPtr_ascender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "ascender");
			TMP_CharacterInfo.NativeFieldInfoPtr_baseLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "baseLine");
			TMP_CharacterInfo.NativeFieldInfoPtr_descender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "descender");
			TMP_CharacterInfo.NativeFieldInfoPtr_adjustedAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "adjustedAscender");
			TMP_CharacterInfo.NativeFieldInfoPtr_adjustedDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "adjustedDescender");
			TMP_CharacterInfo.NativeFieldInfoPtr_aspectRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "aspectRatio");
			TMP_CharacterInfo.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "scale");
			TMP_CharacterInfo.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "color");
			TMP_CharacterInfo.NativeFieldInfoPtr_underlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "underlineColor");
			TMP_CharacterInfo.NativeFieldInfoPtr_underlineVertexIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "underlineVertexIndex");
			TMP_CharacterInfo.NativeFieldInfoPtr_strikethroughColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "strikethroughColor");
			TMP_CharacterInfo.NativeFieldInfoPtr_strikethroughVertexIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "strikethroughVertexIndex");
			TMP_CharacterInfo.NativeFieldInfoPtr_highlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "highlightColor");
			TMP_CharacterInfo.NativeFieldInfoPtr_highlightState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "highlightState");
			TMP_CharacterInfo.NativeFieldInfoPtr_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "style");
			TMP_CharacterInfo.NativeFieldInfoPtr_isVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr, "isVisible");
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000383C File Offset: 0x00001A3C
		public TMP_CharacterInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00003845 File Offset: 0x00001A45
		public TMP_CharacterInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_CharacterInfo>.NativeClassPtr))
		{
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00014818 File Offset: 0x00012A18
		// (set) Token: 0x06000330 RID: 816 RVA: 0x00003857 File Offset: 0x00001A57
		public unsafe char character
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_character);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_character)) = value;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000331 RID: 817 RVA: 0x00014840 File Offset: 0x00012A40
		// (set) Token: 0x06000332 RID: 818 RVA: 0x00003872 File Offset: 0x00001A72
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000333 RID: 819 RVA: 0x00014868 File Offset: 0x00012A68
		// (set) Token: 0x06000334 RID: 820 RVA: 0x0000388D File Offset: 0x00001A8D
		public unsafe int stringLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_stringLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_stringLength)) = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000335 RID: 821 RVA: 0x00014890 File Offset: 0x00012A90
		// (set) Token: 0x06000336 RID: 822 RVA: 0x000038A8 File Offset: 0x00001AA8
		public unsafe TMP_TextElementType elementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_elementType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_elementType)) = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000337 RID: 823 RVA: 0x000148B8 File Offset: 0x00012AB8
		// (set) Token: 0x06000338 RID: 824 RVA: 0x000038C3 File Offset: 0x00001AC3
		public unsafe TMP_TextElement textElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_textElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_TextElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_textElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000339 RID: 825 RVA: 0x000148E8 File Offset: 0x00012AE8
		// (set) Token: 0x0600033A RID: 826 RVA: 0x000038E2 File Offset: 0x00001AE2
		public unsafe TMP_FontAsset fontAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_fontAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_fontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600033B RID: 827 RVA: 0x00014918 File Offset: 0x00012B18
		// (set) Token: 0x0600033C RID: 828 RVA: 0x00003901 File Offset: 0x00001B01
		public unsafe TMP_SpriteAsset spriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_spriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_spriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00014948 File Offset: 0x00012B48
		// (set) Token: 0x0600033E RID: 830 RVA: 0x00003920 File Offset: 0x00001B20
		public unsafe int spriteIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_spriteIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_spriteIndex)) = value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600033F RID: 831 RVA: 0x00014970 File Offset: 0x00012B70
		// (set) Token: 0x06000340 RID: 832 RVA: 0x0000393B File Offset: 0x00001B3B
		public unsafe Material material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000341 RID: 833 RVA: 0x000149A0 File Offset: 0x00012BA0
		// (set) Token: 0x06000342 RID: 834 RVA: 0x0000395A File Offset: 0x00001B5A
		public unsafe int materialReferenceIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_materialReferenceIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_materialReferenceIndex)) = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000343 RID: 835 RVA: 0x000149C8 File Offset: 0x00012BC8
		// (set) Token: 0x06000344 RID: 836 RVA: 0x00003975 File Offset: 0x00001B75
		public unsafe bool isUsingAlternateTypeface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_isUsingAlternateTypeface);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_isUsingAlternateTypeface)) = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000345 RID: 837 RVA: 0x000149F0 File Offset: 0x00012BF0
		// (set) Token: 0x06000346 RID: 838 RVA: 0x00003990 File Offset: 0x00001B90
		public unsafe float pointSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_pointSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_pointSize)) = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000347 RID: 839 RVA: 0x00014A18 File Offset: 0x00012C18
		// (set) Token: 0x06000348 RID: 840 RVA: 0x000039AB File Offset: 0x00001BAB
		public unsafe int lineNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_lineNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_lineNumber)) = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000349 RID: 841 RVA: 0x00014A40 File Offset: 0x00012C40
		// (set) Token: 0x0600034A RID: 842 RVA: 0x000039C6 File Offset: 0x00001BC6
		public unsafe int pageNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_pageNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_pageNumber)) = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600034B RID: 843 RVA: 0x00014A68 File Offset: 0x00012C68
		// (set) Token: 0x0600034C RID: 844 RVA: 0x000039E1 File Offset: 0x00001BE1
		public unsafe int vertexIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_vertexIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_vertexIndex)) = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600034D RID: 845 RVA: 0x00014A90 File Offset: 0x00012C90
		// (set) Token: 0x0600034E RID: 846 RVA: 0x000039FC File Offset: 0x00001BFC
		public unsafe TMP_Vertex vertex_BL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_vertex_BL);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_vertex_BL)) = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600034F RID: 847 RVA: 0x00014AB8 File Offset: 0x00012CB8
		// (set) Token: 0x06000350 RID: 848 RVA: 0x00003A17 File Offset: 0x00001C17
		public unsafe TMP_Vertex vertex_TL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_vertex_TL);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_vertex_TL)) = value;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000351 RID: 849 RVA: 0x00014AE0 File Offset: 0x00012CE0
		// (set) Token: 0x06000352 RID: 850 RVA: 0x00003A32 File Offset: 0x00001C32
		public unsafe TMP_Vertex vertex_TR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_vertex_TR);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_vertex_TR)) = value;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000353 RID: 851 RVA: 0x00014B08 File Offset: 0x00012D08
		// (set) Token: 0x06000354 RID: 852 RVA: 0x00003A4D File Offset: 0x00001C4D
		public unsafe TMP_Vertex vertex_BR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_vertex_BR);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_vertex_BR)) = value;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000355 RID: 853 RVA: 0x00014B30 File Offset: 0x00012D30
		// (set) Token: 0x06000356 RID: 854 RVA: 0x00003A68 File Offset: 0x00001C68
		public unsafe Vector3 topLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_topLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_topLeft)) = value;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000357 RID: 855 RVA: 0x00014B58 File Offset: 0x00012D58
		// (set) Token: 0x06000358 RID: 856 RVA: 0x00003A83 File Offset: 0x00001C83
		public unsafe Vector3 bottomLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_bottomLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_bottomLeft)) = value;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000359 RID: 857 RVA: 0x00014B80 File Offset: 0x00012D80
		// (set) Token: 0x0600035A RID: 858 RVA: 0x00003A9E File Offset: 0x00001C9E
		public unsafe Vector3 topRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_topRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_topRight)) = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600035B RID: 859 RVA: 0x00014BA8 File Offset: 0x00012DA8
		// (set) Token: 0x0600035C RID: 860 RVA: 0x00003AB9 File Offset: 0x00001CB9
		public unsafe Vector3 bottomRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_bottomRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_bottomRight)) = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600035D RID: 861 RVA: 0x00014BD0 File Offset: 0x00012DD0
		// (set) Token: 0x0600035E RID: 862 RVA: 0x00003AD4 File Offset: 0x00001CD4
		public unsafe float origin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_origin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_origin)) = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600035F RID: 863 RVA: 0x00014BF8 File Offset: 0x00012DF8
		// (set) Token: 0x06000360 RID: 864 RVA: 0x00003AEF File Offset: 0x00001CEF
		public unsafe float xAdvance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_xAdvance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_xAdvance)) = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000361 RID: 865 RVA: 0x00014C20 File Offset: 0x00012E20
		// (set) Token: 0x06000362 RID: 866 RVA: 0x00003B0A File Offset: 0x00001D0A
		public unsafe float ascender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_ascender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_ascender)) = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000363 RID: 867 RVA: 0x00014C48 File Offset: 0x00012E48
		// (set) Token: 0x06000364 RID: 868 RVA: 0x00003B25 File Offset: 0x00001D25
		public unsafe float baseLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_baseLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_baseLine)) = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000365 RID: 869 RVA: 0x00014C70 File Offset: 0x00012E70
		// (set) Token: 0x06000366 RID: 870 RVA: 0x00003B40 File Offset: 0x00001D40
		public unsafe float descender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_descender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_descender)) = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000367 RID: 871 RVA: 0x00014C98 File Offset: 0x00012E98
		// (set) Token: 0x06000368 RID: 872 RVA: 0x00003B5B File Offset: 0x00001D5B
		public unsafe float adjustedAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_adjustedAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_adjustedAscender)) = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000369 RID: 873 RVA: 0x00014CC0 File Offset: 0x00012EC0
		// (set) Token: 0x0600036A RID: 874 RVA: 0x00003B76 File Offset: 0x00001D76
		public unsafe float adjustedDescender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_adjustedDescender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_adjustedDescender)) = value;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600036B RID: 875 RVA: 0x00014CE8 File Offset: 0x00012EE8
		// (set) Token: 0x0600036C RID: 876 RVA: 0x00003B91 File Offset: 0x00001D91
		public unsafe float aspectRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_aspectRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_aspectRatio)) = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600036D RID: 877 RVA: 0x00014D10 File Offset: 0x00012F10
		// (set) Token: 0x0600036E RID: 878 RVA: 0x00003BAC File Offset: 0x00001DAC
		public unsafe float scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_scale)) = value;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600036F RID: 879 RVA: 0x00014D38 File Offset: 0x00012F38
		// (set) Token: 0x06000370 RID: 880 RVA: 0x00003BC7 File Offset: 0x00001DC7
		public unsafe Color32 color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_color)) = value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000371 RID: 881 RVA: 0x00014D60 File Offset: 0x00012F60
		// (set) Token: 0x06000372 RID: 882 RVA: 0x00003BE2 File Offset: 0x00001DE2
		public unsafe Color32 underlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_underlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_underlineColor)) = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000373 RID: 883 RVA: 0x00014D88 File Offset: 0x00012F88
		// (set) Token: 0x06000374 RID: 884 RVA: 0x00003BFD File Offset: 0x00001DFD
		public unsafe int underlineVertexIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_underlineVertexIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_underlineVertexIndex)) = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000375 RID: 885 RVA: 0x00014DB0 File Offset: 0x00012FB0
		// (set) Token: 0x06000376 RID: 886 RVA: 0x00003C18 File Offset: 0x00001E18
		public unsafe Color32 strikethroughColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_strikethroughColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_strikethroughColor)) = value;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000377 RID: 887 RVA: 0x00014DD8 File Offset: 0x00012FD8
		// (set) Token: 0x06000378 RID: 888 RVA: 0x00003C33 File Offset: 0x00001E33
		public unsafe int strikethroughVertexIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_strikethroughVertexIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_strikethroughVertexIndex)) = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000379 RID: 889 RVA: 0x00014E00 File Offset: 0x00013000
		// (set) Token: 0x0600037A RID: 890 RVA: 0x00003C4E File Offset: 0x00001E4E
		public unsafe Color32 highlightColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_highlightColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_highlightColor)) = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600037B RID: 891 RVA: 0x00014E28 File Offset: 0x00013028
		// (set) Token: 0x0600037C RID: 892 RVA: 0x00003C69 File Offset: 0x00001E69
		public unsafe HighlightState highlightState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_highlightState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_highlightState)) = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600037D RID: 893 RVA: 0x00014E50 File Offset: 0x00013050
		// (set) Token: 0x0600037E RID: 894 RVA: 0x00003C84 File Offset: 0x00001E84
		public unsafe FontStyles style
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_style);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_style)) = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600037F RID: 895 RVA: 0x00014E78 File Offset: 0x00013078
		// (set) Token: 0x06000380 RID: 896 RVA: 0x00003C9F File Offset: 0x00001E9F
		public unsafe bool isVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_isVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_CharacterInfo.NativeFieldInfoPtr_isVisible)) = value;
			}
		}

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeFieldInfoPtr_character;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeFieldInfoPtr_stringLength;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeFieldInfoPtr_elementType;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeFieldInfoPtr_textElement;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeFieldInfoPtr_fontAsset;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeFieldInfoPtr_spriteAsset;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeFieldInfoPtr_spriteIndex;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeFieldInfoPtr_material;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeFieldInfoPtr_materialReferenceIndex;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeFieldInfoPtr_isUsingAlternateTypeface;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeFieldInfoPtr_pointSize;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeFieldInfoPtr_lineNumber;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeFieldInfoPtr_pageNumber;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeFieldInfoPtr_vertexIndex;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeFieldInfoPtr_vertex_BL;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeFieldInfoPtr_vertex_TL;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeFieldInfoPtr_vertex_TR;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeFieldInfoPtr_vertex_BR;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeFieldInfoPtr_topLeft;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeFieldInfoPtr_bottomLeft;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeFieldInfoPtr_topRight;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeFieldInfoPtr_bottomRight;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeFieldInfoPtr_origin;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeFieldInfoPtr_xAdvance;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeFieldInfoPtr_ascender;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeFieldInfoPtr_baseLine;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeFieldInfoPtr_descender;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeFieldInfoPtr_adjustedAscender;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeFieldInfoPtr_adjustedDescender;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeFieldInfoPtr_aspectRatio;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeFieldInfoPtr_underlineColor;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeFieldInfoPtr_underlineVertexIndex;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeFieldInfoPtr_strikethroughColor;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeFieldInfoPtr_strikethroughVertexIndex;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeFieldInfoPtr_highlightColor;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeFieldInfoPtr_highlightState;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeFieldInfoPtr_style;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeFieldInfoPtr_isVisible;
	}
}

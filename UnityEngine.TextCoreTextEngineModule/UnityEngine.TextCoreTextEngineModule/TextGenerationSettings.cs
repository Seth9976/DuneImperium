using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200001D RID: 29
	public class TextGenerationSettings : Object
	{
		// Token: 0x060002B4 RID: 692 RVA: 0x0000F064 File Offset: 0x0000D264
		// Note: this type is marked as 'beforefieldinit'.
		static TextGenerationSettings()
		{
			Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextGenerationSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr);
			TextGenerationSettings.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "text");
			TextGenerationSettings.NativeFieldInfoPtr_screenRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "screenRect");
			TextGenerationSettings.NativeFieldInfoPtr_margins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "margins");
			TextGenerationSettings.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "scale");
			TextGenerationSettings.NativeFieldInfoPtr_fontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "fontAsset");
			TextGenerationSettings.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "material");
			TextGenerationSettings.NativeFieldInfoPtr_spriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "spriteAsset");
			TextGenerationSettings.NativeFieldInfoPtr_styleSheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "styleSheet");
			TextGenerationSettings.NativeFieldInfoPtr_fontStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "fontStyle");
			TextGenerationSettings.NativeFieldInfoPtr_textSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "textSettings");
			TextGenerationSettings.NativeFieldInfoPtr_textAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "textAlignment");
			TextGenerationSettings.NativeFieldInfoPtr_overflowMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "overflowMode");
			TextGenerationSettings.NativeFieldInfoPtr_wordWrap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "wordWrap");
			TextGenerationSettings.NativeFieldInfoPtr_wordWrappingRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "wordWrappingRatio");
			TextGenerationSettings.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "color");
			TextGenerationSettings.NativeFieldInfoPtr_fontColorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "fontColorGradient");
			TextGenerationSettings.NativeFieldInfoPtr_fontColorGradientPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "fontColorGradientPreset");
			TextGenerationSettings.NativeFieldInfoPtr_tintSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "tintSprites");
			TextGenerationSettings.NativeFieldInfoPtr_overrideRichTextColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "overrideRichTextColors");
			TextGenerationSettings.NativeFieldInfoPtr_shouldConvertToLinearSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "shouldConvertToLinearSpace");
			TextGenerationSettings.NativeFieldInfoPtr_fontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "fontSize");
			TextGenerationSettings.NativeFieldInfoPtr_autoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "autoSize");
			TextGenerationSettings.NativeFieldInfoPtr_fontSizeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "fontSizeMin");
			TextGenerationSettings.NativeFieldInfoPtr_fontSizeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "fontSizeMax");
			TextGenerationSettings.NativeFieldInfoPtr_enableKerning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "enableKerning");
			TextGenerationSettings.NativeFieldInfoPtr_richText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "richText");
			TextGenerationSettings.NativeFieldInfoPtr_isRightToLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "isRightToLeft");
			TextGenerationSettings.NativeFieldInfoPtr_extraPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "extraPadding");
			TextGenerationSettings.NativeFieldInfoPtr_parseControlCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "parseControlCharacters");
			TextGenerationSettings.NativeFieldInfoPtr_isOrthographic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "isOrthographic");
			TextGenerationSettings.NativeFieldInfoPtr_tagNoParsing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "tagNoParsing");
			TextGenerationSettings.NativeFieldInfoPtr_characterSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "characterSpacing");
			TextGenerationSettings.NativeFieldInfoPtr_wordSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "wordSpacing");
			TextGenerationSettings.NativeFieldInfoPtr_lineSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "lineSpacing");
			TextGenerationSettings.NativeFieldInfoPtr_paragraphSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "paragraphSpacing");
			TextGenerationSettings.NativeFieldInfoPtr_lineSpacingMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "lineSpacingMax");
			TextGenerationSettings.NativeFieldInfoPtr_textWrappingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "textWrappingMode");
			TextGenerationSettings.NativeFieldInfoPtr_maxVisibleCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "maxVisibleCharacters");
			TextGenerationSettings.NativeFieldInfoPtr_maxVisibleWords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "maxVisibleWords");
			TextGenerationSettings.NativeFieldInfoPtr_maxVisibleLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "maxVisibleLines");
			TextGenerationSettings.NativeFieldInfoPtr_firstVisibleCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "firstVisibleCharacter");
			TextGenerationSettings.NativeFieldInfoPtr_useMaxVisibleDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "useMaxVisibleDescender");
			TextGenerationSettings.NativeFieldInfoPtr_fontWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "fontWeight");
			TextGenerationSettings.NativeFieldInfoPtr_pageToDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "pageToDisplay");
			TextGenerationSettings.NativeFieldInfoPtr_horizontalMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "horizontalMapping");
			TextGenerationSettings.NativeFieldInfoPtr_verticalMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "verticalMapping");
			TextGenerationSettings.NativeFieldInfoPtr_uvLineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "uvLineOffset");
			TextGenerationSettings.NativeFieldInfoPtr_geometrySortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "geometrySortingOrder");
			TextGenerationSettings.NativeFieldInfoPtr_inverseYAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "inverseYAxis");
			TextGenerationSettings.NativeFieldInfoPtr_charWidthMaxAdj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "charWidthMaxAdj");
			TextGenerationSettings.NativeFieldInfoPtr_inputSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, "inputSource");
			TextGenerationSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, 100663538);
			TextGenerationSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, 100663539);
			TextGenerationSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, 100663540);
			TextGenerationSettings.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TextGenerationSettings_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, 100663541);
			TextGenerationSettings.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, 100663542);
			TextGenerationSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr, 100663543);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000F508 File Offset: 0x0000D708
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1101459, RefRangeEnd = 1101460, XrefRangeStart = 1101431, XrefRangeEnd = 1101459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(TextGenerationSettings other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerationSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000F558 File Offset: 0x0000D758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101460, XrefRangeEnd = 1101469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextGenerationSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000F5B0 File Offset: 0x0000D7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101469, XrefRangeEnd = 1101588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextGenerationSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000F5F8 File Offset: 0x0000D7F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1101589, RefRangeEnd = 1101592, XrefRangeStart = 1101588, XrefRangeEnd = 1101589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(TextGenerationSettings left, TextGenerationSettings right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerationSettings.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TextGenerationSettings_TextGenerationSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000F64C File Offset: 0x0000D84C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101592, XrefRangeEnd = 1102055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextGenerationSettings.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000F690 File Offset: 0x0000D890
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1102056, RefRangeEnd = 1102058, XrefRangeStart = 1102055, XrefRangeEnd = 1102056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextGenerationSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextGenerationSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerationSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00003749 File Offset: 0x00001949
		public TextGenerationSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0000F6CC File Offset: 0x0000D8CC
		// (set) Token: 0x060002BD RID: 701 RVA: 0x00003752 File Offset: 0x00001952
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060002BE RID: 702 RVA: 0x0000F6F4 File Offset: 0x0000D8F4
		// (set) Token: 0x060002BF RID: 703 RVA: 0x00003771 File Offset: 0x00001971
		public unsafe Rect screenRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_screenRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_screenRect)) = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0000F71C File Offset: 0x0000D91C
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x0000378C File Offset: 0x0000198C
		public unsafe Vector4 margins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_margins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_margins)) = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0000F744 File Offset: 0x0000D944
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x000037A7 File Offset: 0x000019A7
		public unsafe float scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_scale)) = value;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x0000F76C File Offset: 0x0000D96C
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x000037C2 File Offset: 0x000019C2
		public unsafe FontAsset fontAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_fontAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_fontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x0000F79C File Offset: 0x0000D99C
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x000037E1 File Offset: 0x000019E1
		public unsafe Material material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x0000F7CC File Offset: 0x0000D9CC
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x00003800 File Offset: 0x00001A00
		public unsafe SpriteAsset spriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_spriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_spriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0000F7FC File Offset: 0x0000D9FC
		// (set) Token: 0x060002CB RID: 715 RVA: 0x0000381F File Offset: 0x00001A1F
		public unsafe TextStyleSheet styleSheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_styleSheet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextStyleSheet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_styleSheet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060002CC RID: 716 RVA: 0x0000F82C File Offset: 0x0000DA2C
		// (set) Token: 0x060002CD RID: 717 RVA: 0x0000383E File Offset: 0x00001A3E
		public unsafe FontStyles fontStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_fontStyle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_fontStyle)) = value;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060002CE RID: 718 RVA: 0x0000F854 File Offset: 0x0000DA54
		// (set) Token: 0x060002CF RID: 719 RVA: 0x00003859 File Offset: 0x00001A59
		public unsafe TextSettings textSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_textSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_textSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x0000F884 File Offset: 0x0000DA84
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x00003878 File Offset: 0x00001A78
		public unsafe TextAlignment textAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_textAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_textAlignment)) = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x0000F8AC File Offset: 0x0000DAAC
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x00003893 File Offset: 0x00001A93
		public unsafe TextOverflowMode overflowMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_overflowMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_overflowMode)) = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x0000F8D4 File Offset: 0x0000DAD4
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x000038AE File Offset: 0x00001AAE
		public unsafe bool wordWrap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_wordWrap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_wordWrap)) = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0000F8FC File Offset: 0x0000DAFC
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x000038C9 File Offset: 0x00001AC9
		public unsafe float wordWrappingRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_wordWrappingRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_wordWrappingRatio)) = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x0000F924 File Offset: 0x0000DB24
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x000038E4 File Offset: 0x00001AE4
		public unsafe Color color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_color)) = value;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060002DA RID: 730 RVA: 0x0000F94C File Offset: 0x0000DB4C
		// (set) Token: 0x060002DB RID: 731 RVA: 0x000038FF File Offset: 0x00001AFF
		public unsafe TextColorGradient fontColorGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_fontColorGradient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextColorGradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_fontColorGradient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060002DC RID: 732 RVA: 0x0000F97C File Offset: 0x0000DB7C
		// (set) Token: 0x060002DD RID: 733 RVA: 0x0000391E File Offset: 0x00001B1E
		public unsafe TextColorGradient fontColorGradientPreset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_fontColorGradientPreset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextColorGradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_fontColorGradientPreset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0000F9AC File Offset: 0x0000DBAC
		// (set) Token: 0x060002DF RID: 735 RVA: 0x0000393D File Offset: 0x00001B3D
		public unsafe bool tintSprites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_tintSprites);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_tintSprites)) = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x0000F9D4 File Offset: 0x0000DBD4
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x00003958 File Offset: 0x00001B58
		public unsafe bool overrideRichTextColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_overrideRichTextColors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_overrideRichTextColors)) = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x0000F9FC File Offset: 0x0000DBFC
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x00003973 File Offset: 0x00001B73
		public unsafe bool shouldConvertToLinearSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_shouldConvertToLinearSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_shouldConvertToLinearSpace)) = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x0000FA24 File Offset: 0x0000DC24
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x0000398E File Offset: 0x00001B8E
		public unsafe float fontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_fontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_fontSize)) = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x0000FA4C File Offset: 0x0000DC4C
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x000039A9 File Offset: 0x00001BA9
		public unsafe bool autoSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_autoSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_autoSize)) = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x0000FA74 File Offset: 0x0000DC74
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x000039C4 File Offset: 0x00001BC4
		public unsafe float fontSizeMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_fontSizeMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_fontSizeMin)) = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060002EA RID: 746 RVA: 0x0000FA9C File Offset: 0x0000DC9C
		// (set) Token: 0x060002EB RID: 747 RVA: 0x000039DF File Offset: 0x00001BDF
		public unsafe float fontSizeMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_fontSizeMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_fontSizeMax)) = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060002EC RID: 748 RVA: 0x0000FAC4 File Offset: 0x0000DCC4
		// (set) Token: 0x060002ED RID: 749 RVA: 0x000039FA File Offset: 0x00001BFA
		public unsafe bool enableKerning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_enableKerning);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_enableKerning)) = value;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060002EE RID: 750 RVA: 0x0000FAEC File Offset: 0x0000DCEC
		// (set) Token: 0x060002EF RID: 751 RVA: 0x00003A15 File Offset: 0x00001C15
		public unsafe bool richText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_richText);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_richText)) = value;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x0000FB14 File Offset: 0x0000DD14
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x00003A30 File Offset: 0x00001C30
		public unsafe bool isRightToLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_isRightToLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_isRightToLeft)) = value;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x0000FB3C File Offset: 0x0000DD3C
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x00003A4B File Offset: 0x00001C4B
		public unsafe float extraPadding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_extraPadding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_extraPadding)) = value;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x0000FB64 File Offset: 0x0000DD64
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x00003A66 File Offset: 0x00001C66
		public unsafe bool parseControlCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_parseControlCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_parseControlCharacters)) = value;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x0000FB8C File Offset: 0x0000DD8C
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x00003A81 File Offset: 0x00001C81
		public unsafe bool isOrthographic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_isOrthographic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_isOrthographic)) = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x0000FBB4 File Offset: 0x0000DDB4
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x00003A9C File Offset: 0x00001C9C
		public unsafe bool tagNoParsing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_tagNoParsing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_tagNoParsing)) = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060002FA RID: 762 RVA: 0x0000FBDC File Offset: 0x0000DDDC
		// (set) Token: 0x060002FB RID: 763 RVA: 0x00003AB7 File Offset: 0x00001CB7
		public unsafe float characterSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_characterSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_characterSpacing)) = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060002FC RID: 764 RVA: 0x0000FC04 File Offset: 0x0000DE04
		// (set) Token: 0x060002FD RID: 765 RVA: 0x00003AD2 File Offset: 0x00001CD2
		public unsafe float wordSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_wordSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_wordSpacing)) = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060002FE RID: 766 RVA: 0x0000FC2C File Offset: 0x0000DE2C
		// (set) Token: 0x060002FF RID: 767 RVA: 0x00003AED File Offset: 0x00001CED
		public unsafe float lineSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_lineSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_lineSpacing)) = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0000FC54 File Offset: 0x0000DE54
		// (set) Token: 0x06000301 RID: 769 RVA: 0x00003B08 File Offset: 0x00001D08
		public unsafe float paragraphSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_paragraphSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_paragraphSpacing)) = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0000FC7C File Offset: 0x0000DE7C
		// (set) Token: 0x06000303 RID: 771 RVA: 0x00003B23 File Offset: 0x00001D23
		public unsafe float lineSpacingMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_lineSpacingMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_lineSpacingMax)) = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000304 RID: 772 RVA: 0x0000FCA4 File Offset: 0x0000DEA4
		// (set) Token: 0x06000305 RID: 773 RVA: 0x00003B3E File Offset: 0x00001D3E
		public unsafe TextWrappingMode textWrappingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_textWrappingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_textWrappingMode)) = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000306 RID: 774 RVA: 0x0000FCCC File Offset: 0x0000DECC
		// (set) Token: 0x06000307 RID: 775 RVA: 0x00003B59 File Offset: 0x00001D59
		public unsafe int maxVisibleCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_maxVisibleCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_maxVisibleCharacters)) = value;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000308 RID: 776 RVA: 0x0000FCF4 File Offset: 0x0000DEF4
		// (set) Token: 0x06000309 RID: 777 RVA: 0x00003B74 File Offset: 0x00001D74
		public unsafe int maxVisibleWords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_maxVisibleWords);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_maxVisibleWords)) = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600030A RID: 778 RVA: 0x0000FD1C File Offset: 0x0000DF1C
		// (set) Token: 0x0600030B RID: 779 RVA: 0x00003B8F File Offset: 0x00001D8F
		public unsafe int maxVisibleLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_maxVisibleLines);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_maxVisibleLines)) = value;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600030C RID: 780 RVA: 0x0000FD44 File Offset: 0x0000DF44
		// (set) Token: 0x0600030D RID: 781 RVA: 0x00003BAA File Offset: 0x00001DAA
		public unsafe int firstVisibleCharacter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_firstVisibleCharacter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_firstVisibleCharacter)) = value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600030E RID: 782 RVA: 0x0000FD6C File Offset: 0x0000DF6C
		// (set) Token: 0x0600030F RID: 783 RVA: 0x00003BC5 File Offset: 0x00001DC5
		public unsafe bool useMaxVisibleDescender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_useMaxVisibleDescender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_useMaxVisibleDescender)) = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000310 RID: 784 RVA: 0x0000FD94 File Offset: 0x0000DF94
		// (set) Token: 0x06000311 RID: 785 RVA: 0x00003BE0 File Offset: 0x00001DE0
		public unsafe TextFontWeight fontWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_fontWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_fontWeight)) = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000312 RID: 786 RVA: 0x0000FDBC File Offset: 0x0000DFBC
		// (set) Token: 0x06000313 RID: 787 RVA: 0x00003BFB File Offset: 0x00001DFB
		public unsafe int pageToDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_pageToDisplay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_pageToDisplay)) = value;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000314 RID: 788 RVA: 0x0000FDE4 File Offset: 0x0000DFE4
		// (set) Token: 0x06000315 RID: 789 RVA: 0x00003C16 File Offset: 0x00001E16
		public unsafe TextureMapping horizontalMapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_horizontalMapping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_horizontalMapping)) = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000316 RID: 790 RVA: 0x0000FE0C File Offset: 0x0000E00C
		// (set) Token: 0x06000317 RID: 791 RVA: 0x00003C31 File Offset: 0x00001E31
		public unsafe TextureMapping verticalMapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_verticalMapping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_verticalMapping)) = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000318 RID: 792 RVA: 0x0000FE34 File Offset: 0x0000E034
		// (set) Token: 0x06000319 RID: 793 RVA: 0x00003C4C File Offset: 0x00001E4C
		public unsafe float uvLineOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_uvLineOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_uvLineOffset)) = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0000FE5C File Offset: 0x0000E05C
		// (set) Token: 0x0600031B RID: 795 RVA: 0x00003C67 File Offset: 0x00001E67
		public unsafe VertexSortingOrder geometrySortingOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_geometrySortingOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_geometrySortingOrder)) = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600031C RID: 796 RVA: 0x0000FE84 File Offset: 0x0000E084
		// (set) Token: 0x0600031D RID: 797 RVA: 0x00003C82 File Offset: 0x00001E82
		public unsafe bool inverseYAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_inverseYAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_inverseYAxis)) = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0000FEAC File Offset: 0x0000E0AC
		// (set) Token: 0x0600031F RID: 799 RVA: 0x00003C9D File Offset: 0x00001E9D
		public unsafe float charWidthMaxAdj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_charWidthMaxAdj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_charWidthMaxAdj)) = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0000FED4 File Offset: 0x0000E0D4
		// (set) Token: 0x06000321 RID: 801 RVA: 0x00003CB8 File Offset: 0x00001EB8
		public unsafe TextInputSource inputSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_inputSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerationSettings.NativeFieldInfoPtr_inputSource)) = value;
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000FEFC File Offset: 0x0000E0FC
		public static bool operator !=(TextGenerationSettings left, TextGenerationSettings right)
		{
			return !Object.Equals(left, right);
		}

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeFieldInfoPtr_screenRect;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeFieldInfoPtr_margins;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeFieldInfoPtr_fontAsset;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeFieldInfoPtr_material;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeFieldInfoPtr_spriteAsset;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeFieldInfoPtr_styleSheet;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeFieldInfoPtr_fontStyle;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeFieldInfoPtr_textSettings;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeFieldInfoPtr_textAlignment;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeFieldInfoPtr_overflowMode;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeFieldInfoPtr_wordWrap;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeFieldInfoPtr_wordWrappingRatio;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeFieldInfoPtr_fontColorGradient;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeFieldInfoPtr_fontColorGradientPreset;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeFieldInfoPtr_tintSprites;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeFieldInfoPtr_overrideRichTextColors;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeFieldInfoPtr_shouldConvertToLinearSpace;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeFieldInfoPtr_fontSize;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeFieldInfoPtr_autoSize;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeFieldInfoPtr_fontSizeMin;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeFieldInfoPtr_fontSizeMax;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeFieldInfoPtr_enableKerning;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeFieldInfoPtr_richText;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeFieldInfoPtr_isRightToLeft;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeFieldInfoPtr_extraPadding;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeFieldInfoPtr_parseControlCharacters;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeFieldInfoPtr_isOrthographic;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeFieldInfoPtr_tagNoParsing;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeFieldInfoPtr_characterSpacing;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeFieldInfoPtr_wordSpacing;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeFieldInfoPtr_lineSpacing;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeFieldInfoPtr_paragraphSpacing;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeFieldInfoPtr_lineSpacingMax;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeFieldInfoPtr_textWrappingMode;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeFieldInfoPtr_maxVisibleCharacters;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeFieldInfoPtr_maxVisibleWords;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeFieldInfoPtr_maxVisibleLines;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeFieldInfoPtr_firstVisibleCharacter;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeFieldInfoPtr_useMaxVisibleDescender;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeFieldInfoPtr_fontWeight;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeFieldInfoPtr_pageToDisplay;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeFieldInfoPtr_horizontalMapping;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeFieldInfoPtr_verticalMapping;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeFieldInfoPtr_uvLineOffset;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeFieldInfoPtr_geometrySortingOrder;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeFieldInfoPtr_inverseYAxis;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeFieldInfoPtr_charWidthMaxAdj;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeFieldInfoPtr_inputSource;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextGenerationSettings_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TextGenerationSettings_TextGenerationSettings_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

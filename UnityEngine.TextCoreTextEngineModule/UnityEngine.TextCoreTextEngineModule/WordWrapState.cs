using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200002B RID: 43
	public sealed class WordWrapState : ValueType
	{
		// Token: 0x06000472 RID: 1138 RVA: 0x0001397C File Offset: 0x00011B7C
		// Note: this type is marked as 'beforefieldinit'.
		static WordWrapState()
		{
			Il2CppClassPointerStore<WordWrapState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "WordWrapState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr);
			WordWrapState.NativeFieldInfoPtr_previousWordBreak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "previousWordBreak");
			WordWrapState.NativeFieldInfoPtr_totalCharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "totalCharacterCount");
			WordWrapState.NativeFieldInfoPtr_visibleCharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "visibleCharacterCount");
			WordWrapState.NativeFieldInfoPtr_visibleSpaceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "visibleSpaceCount");
			WordWrapState.NativeFieldInfoPtr_visibleSpriteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "visibleSpriteCount");
			WordWrapState.NativeFieldInfoPtr_visibleLinkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "visibleLinkCount");
			WordWrapState.NativeFieldInfoPtr_firstCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "firstCharacterIndex");
			WordWrapState.NativeFieldInfoPtr_firstVisibleCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "firstVisibleCharacterIndex");
			WordWrapState.NativeFieldInfoPtr_lastCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "lastCharacterIndex");
			WordWrapState.NativeFieldInfoPtr_lastVisibleCharIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "lastVisibleCharIndex");
			WordWrapState.NativeFieldInfoPtr_lineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "lineNumber");
			WordWrapState.NativeFieldInfoPtr_maxCapHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "maxCapHeight");
			WordWrapState.NativeFieldInfoPtr_maxAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "maxAscender");
			WordWrapState.NativeFieldInfoPtr_maxDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "maxDescender");
			WordWrapState.NativeFieldInfoPtr_maxLineAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "maxLineAscender");
			WordWrapState.NativeFieldInfoPtr_maxLineDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "maxLineDescender");
			WordWrapState.NativeFieldInfoPtr_startOfLineAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "startOfLineAscender");
			WordWrapState.NativeFieldInfoPtr_xAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "xAdvance");
			WordWrapState.NativeFieldInfoPtr_preferredWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "preferredWidth");
			WordWrapState.NativeFieldInfoPtr_preferredHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "preferredHeight");
			WordWrapState.NativeFieldInfoPtr_previousLineScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "previousLineScale");
			WordWrapState.NativeFieldInfoPtr_pageAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "pageAscender");
			WordWrapState.NativeFieldInfoPtr_wordCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "wordCount");
			WordWrapState.NativeFieldInfoPtr_fontStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "fontStyle");
			WordWrapState.NativeFieldInfoPtr_fontScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "fontScale");
			WordWrapState.NativeFieldInfoPtr_fontScaleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "fontScaleMultiplier");
			WordWrapState.NativeFieldInfoPtr_italicAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "italicAngle");
			WordWrapState.NativeFieldInfoPtr_currentFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "currentFontSize");
			WordWrapState.NativeFieldInfoPtr_baselineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "baselineOffset");
			WordWrapState.NativeFieldInfoPtr_lineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "lineOffset");
			WordWrapState.NativeFieldInfoPtr_textInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "textInfo");
			WordWrapState.NativeFieldInfoPtr_lineInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "lineInfo");
			WordWrapState.NativeFieldInfoPtr_vertexColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "vertexColor");
			WordWrapState.NativeFieldInfoPtr_underlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "underlineColor");
			WordWrapState.NativeFieldInfoPtr_strikethroughColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "strikethroughColor");
			WordWrapState.NativeFieldInfoPtr_highlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "highlightColor");
			WordWrapState.NativeFieldInfoPtr_highlightState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "highlightState");
			WordWrapState.NativeFieldInfoPtr_basicStyleStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "basicStyleStack");
			WordWrapState.NativeFieldInfoPtr_italicAngleStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "italicAngleStack");
			WordWrapState.NativeFieldInfoPtr_colorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "colorStack");
			WordWrapState.NativeFieldInfoPtr_underlineColorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "underlineColorStack");
			WordWrapState.NativeFieldInfoPtr_strikethroughColorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "strikethroughColorStack");
			WordWrapState.NativeFieldInfoPtr_highlightColorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "highlightColorStack");
			WordWrapState.NativeFieldInfoPtr_highlightStateStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "highlightStateStack");
			WordWrapState.NativeFieldInfoPtr_colorGradientStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "colorGradientStack");
			WordWrapState.NativeFieldInfoPtr_sizeStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "sizeStack");
			WordWrapState.NativeFieldInfoPtr_indentStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "indentStack");
			WordWrapState.NativeFieldInfoPtr_fontWeightStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "fontWeightStack");
			WordWrapState.NativeFieldInfoPtr_styleStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "styleStack");
			WordWrapState.NativeFieldInfoPtr_baselineStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "baselineStack");
			WordWrapState.NativeFieldInfoPtr_actionStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "actionStack");
			WordWrapState.NativeFieldInfoPtr_materialReferenceStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "materialReferenceStack");
			WordWrapState.NativeFieldInfoPtr_lineJustificationStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "lineJustificationStack");
			WordWrapState.NativeFieldInfoPtr_lastBaseGlyphIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "lastBaseGlyphIndex");
			WordWrapState.NativeFieldInfoPtr_spriteAnimationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "spriteAnimationId");
			WordWrapState.NativeFieldInfoPtr_currentFontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "currentFontAsset");
			WordWrapState.NativeFieldInfoPtr_currentSpriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "currentSpriteAsset");
			WordWrapState.NativeFieldInfoPtr_currentMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "currentMaterial");
			WordWrapState.NativeFieldInfoPtr_currentMaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "currentMaterialIndex");
			WordWrapState.NativeFieldInfoPtr_meshExtents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "meshExtents");
			WordWrapState.NativeFieldInfoPtr_tagNoParsing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "tagNoParsing");
			WordWrapState.NativeFieldInfoPtr_isNonBreakingSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "isNonBreakingSpace");
			WordWrapState.NativeFieldInfoPtr_isDrivenLineSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "isDrivenLineSpacing");
			WordWrapState.NativeFieldInfoPtr_fxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "fxScale");
			WordWrapState.NativeFieldInfoPtr_fxRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "fxRotation");
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00004C93 File Offset: 0x00002E93
		public WordWrapState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00004C9C File Offset: 0x00002E9C
		public WordWrapState()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr))
		{
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00013EC0 File Offset: 0x000120C0
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x00004CAE File Offset: 0x00002EAE
		public unsafe int previousWordBreak
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_previousWordBreak);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_previousWordBreak)) = value;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x00013EE8 File Offset: 0x000120E8
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x00004CC9 File Offset: 0x00002EC9
		public unsafe int totalCharacterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_totalCharacterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_totalCharacterCount)) = value;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x00013F10 File Offset: 0x00012110
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x00004CE4 File Offset: 0x00002EE4
		public unsafe int visibleCharacterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_visibleCharacterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_visibleCharacterCount)) = value;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x00013F38 File Offset: 0x00012138
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x00004CFF File Offset: 0x00002EFF
		public unsafe int visibleSpaceCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_visibleSpaceCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_visibleSpaceCount)) = value;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x00013F60 File Offset: 0x00012160
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x00004D1A File Offset: 0x00002F1A
		public unsafe int visibleSpriteCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_visibleSpriteCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_visibleSpriteCount)) = value;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x00013F88 File Offset: 0x00012188
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x00004D35 File Offset: 0x00002F35
		public unsafe int visibleLinkCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_visibleLinkCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_visibleLinkCount)) = value;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x00013FB0 File Offset: 0x000121B0
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x00004D50 File Offset: 0x00002F50
		public unsafe int firstCharacterIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_firstCharacterIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_firstCharacterIndex)) = value;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x00013FD8 File Offset: 0x000121D8
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x00004D6B File Offset: 0x00002F6B
		public unsafe int firstVisibleCharacterIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_firstVisibleCharacterIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_firstVisibleCharacterIndex)) = value;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x00014000 File Offset: 0x00012200
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x00004D86 File Offset: 0x00002F86
		public unsafe int lastCharacterIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lastCharacterIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lastCharacterIndex)) = value;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x00014028 File Offset: 0x00012228
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x00004DA1 File Offset: 0x00002FA1
		public unsafe int lastVisibleCharIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lastVisibleCharIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lastVisibleCharIndex)) = value;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00014050 File Offset: 0x00012250
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x00004DBC File Offset: 0x00002FBC
		public unsafe int lineNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lineNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lineNumber)) = value;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00014078 File Offset: 0x00012278
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x00004DD7 File Offset: 0x00002FD7
		public unsafe float maxCapHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_maxCapHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_maxCapHeight)) = value;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x000140A0 File Offset: 0x000122A0
		// (set) Token: 0x0600048E RID: 1166 RVA: 0x00004DF2 File Offset: 0x00002FF2
		public unsafe float maxAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_maxAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_maxAscender)) = value;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x000140C8 File Offset: 0x000122C8
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x00004E0D File Offset: 0x0000300D
		public unsafe float maxDescender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_maxDescender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_maxDescender)) = value;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x000140F0 File Offset: 0x000122F0
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x00004E28 File Offset: 0x00003028
		public unsafe float maxLineAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_maxLineAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_maxLineAscender)) = value;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x00014118 File Offset: 0x00012318
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x00004E43 File Offset: 0x00003043
		public unsafe float maxLineDescender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_maxLineDescender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_maxLineDescender)) = value;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00014140 File Offset: 0x00012340
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x00004E5E File Offset: 0x0000305E
		public unsafe float startOfLineAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_startOfLineAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_startOfLineAscender)) = value;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00014168 File Offset: 0x00012368
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x00004E79 File Offset: 0x00003079
		public unsafe float xAdvance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_xAdvance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_xAdvance)) = value;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x00014190 File Offset: 0x00012390
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x00004E94 File Offset: 0x00003094
		public unsafe float preferredWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_preferredWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_preferredWidth)) = value;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x000141B8 File Offset: 0x000123B8
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x00004EAF File Offset: 0x000030AF
		public unsafe float preferredHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_preferredHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_preferredHeight)) = value;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x000141E0 File Offset: 0x000123E0
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x00004ECA File Offset: 0x000030CA
		public unsafe float previousLineScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_previousLineScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_previousLineScale)) = value;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00014208 File Offset: 0x00012408
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x00004EE5 File Offset: 0x000030E5
		public unsafe float pageAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_pageAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_pageAscender)) = value;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00014230 File Offset: 0x00012430
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x00004F00 File Offset: 0x00003100
		public unsafe int wordCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_wordCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_wordCount)) = value;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00014258 File Offset: 0x00012458
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00004F1B File Offset: 0x0000311B
		public unsafe FontStyles fontStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_fontStyle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_fontStyle)) = value;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00014280 File Offset: 0x00012480
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x00004F36 File Offset: 0x00003136
		public unsafe float fontScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_fontScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_fontScale)) = value;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x000142A8 File Offset: 0x000124A8
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x00004F51 File Offset: 0x00003151
		public unsafe float fontScaleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_fontScaleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_fontScaleMultiplier)) = value;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x000142D0 File Offset: 0x000124D0
		// (set) Token: 0x060004AA RID: 1194 RVA: 0x00004F6C File Offset: 0x0000316C
		public unsafe int italicAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_italicAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_italicAngle)) = value;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x000142F8 File Offset: 0x000124F8
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x00004F87 File Offset: 0x00003187
		public unsafe float currentFontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_currentFontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_currentFontSize)) = value;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x00014320 File Offset: 0x00012520
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x00004FA2 File Offset: 0x000031A2
		public unsafe float baselineOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_baselineOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_baselineOffset)) = value;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x00014348 File Offset: 0x00012548
		// (set) Token: 0x060004B0 RID: 1200 RVA: 0x00004FBD File Offset: 0x000031BD
		public unsafe float lineOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lineOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lineOffset)) = value;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00014370 File Offset: 0x00012570
		// (set) Token: 0x060004B2 RID: 1202 RVA: 0x00004FD8 File Offset: 0x000031D8
		public unsafe TextInfo textInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_textInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_textInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x000143A0 File Offset: 0x000125A0
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x00004FF7 File Offset: 0x000031F7
		public unsafe LineInfo lineInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lineInfo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lineInfo)) = value;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x000143C8 File Offset: 0x000125C8
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x00005012 File Offset: 0x00003212
		public unsafe Color32 vertexColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_vertexColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_vertexColor)) = value;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x000143F0 File Offset: 0x000125F0
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x0000502D File Offset: 0x0000322D
		public unsafe Color32 underlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_underlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_underlineColor)) = value;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00014418 File Offset: 0x00012618
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00005048 File Offset: 0x00003248
		public unsafe Color32 strikethroughColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_strikethroughColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_strikethroughColor)) = value;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x00014440 File Offset: 0x00012640
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x00005063 File Offset: 0x00003263
		public unsafe Color32 highlightColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_highlightColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_highlightColor)) = value;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x00014468 File Offset: 0x00012668
		// (set) Token: 0x060004BE RID: 1214 RVA: 0x0000507E File Offset: 0x0000327E
		public unsafe HighlightState highlightState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_highlightState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_highlightState)) = value;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00014490 File Offset: 0x00012690
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x00005099 File Offset: 0x00003299
		public unsafe FontStyleStack basicStyleStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_basicStyleStack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_basicStyleStack)) = value;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x000144B8 File Offset: 0x000126B8
		// (set) Token: 0x060004C2 RID: 1218 RVA: 0x000050B4 File Offset: 0x000032B4
		public TextProcessingStack<int> italicAngleStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_italicAngleStack);
				return new TextProcessingStack<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_italicAngleStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x000144E8 File Offset: 0x000126E8
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x000050E2 File Offset: 0x000032E2
		public TextProcessingStack<Color32> colorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_colorStack);
				return new TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_colorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00014518 File Offset: 0x00012718
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x00005110 File Offset: 0x00003310
		public TextProcessingStack<Color32> underlineColorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_underlineColorStack);
				return new TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_underlineColorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00014548 File Offset: 0x00012748
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x0000513E File Offset: 0x0000333E
		public TextProcessingStack<Color32> strikethroughColorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_strikethroughColorStack);
				return new TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_strikethroughColorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00014578 File Offset: 0x00012778
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x0000516C File Offset: 0x0000336C
		public TextProcessingStack<Color32> highlightColorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_highlightColorStack);
				return new TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_highlightColorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x000145A8 File Offset: 0x000127A8
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x0000519A File Offset: 0x0000339A
		public TextProcessingStack<HighlightState> highlightStateStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_highlightStateStack);
				return new TextProcessingStack<HighlightState>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<HighlightState>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_highlightStateStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<HighlightState>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x000145D8 File Offset: 0x000127D8
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x000051C8 File Offset: 0x000033C8
		public TextProcessingStack<TextColorGradient> colorGradientStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_colorGradientStack);
				return new TextProcessingStack<TextColorGradient>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<TextColorGradient>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_colorGradientStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<TextColorGradient>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x00014608 File Offset: 0x00012808
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x000051F6 File Offset: 0x000033F6
		public TextProcessingStack<float> sizeStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_sizeStack);
				return new TextProcessingStack<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_sizeStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00014638 File Offset: 0x00012838
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x00005224 File Offset: 0x00003424
		public TextProcessingStack<float> indentStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_indentStack);
				return new TextProcessingStack<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_indentStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00014668 File Offset: 0x00012868
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x00005252 File Offset: 0x00003452
		public TextProcessingStack<TextFontWeight> fontWeightStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_fontWeightStack);
				return new TextProcessingStack<TextFontWeight>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<TextFontWeight>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_fontWeightStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<TextFontWeight>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00014698 File Offset: 0x00012898
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x00005280 File Offset: 0x00003480
		public TextProcessingStack<int> styleStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_styleStack);
				return new TextProcessingStack<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_styleStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x000146C8 File Offset: 0x000128C8
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x000052AE File Offset: 0x000034AE
		public TextProcessingStack<float> baselineStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_baselineStack);
				return new TextProcessingStack<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_baselineStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x000146F8 File Offset: 0x000128F8
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x000052DC File Offset: 0x000034DC
		public TextProcessingStack<int> actionStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_actionStack);
				return new TextProcessingStack<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_actionStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x00014728 File Offset: 0x00012928
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x0000530A File Offset: 0x0000350A
		public TextProcessingStack<MaterialReference> materialReferenceStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_materialReferenceStack);
				return new TextProcessingStack<MaterialReference>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<MaterialReference>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_materialReferenceStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<MaterialReference>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x00014758 File Offset: 0x00012958
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x00005338 File Offset: 0x00003538
		public TextProcessingStack<TextAlignment> lineJustificationStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lineJustificationStack);
				return new TextProcessingStack<TextAlignment>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<TextAlignment>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lineJustificationStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<TextAlignment>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00014788 File Offset: 0x00012988
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x00005366 File Offset: 0x00003566
		public unsafe int lastBaseGlyphIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lastBaseGlyphIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lastBaseGlyphIndex)) = value;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x000147B0 File Offset: 0x000129B0
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00005381 File Offset: 0x00003581
		public unsafe int spriteAnimationId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_spriteAnimationId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_spriteAnimationId)) = value;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x000147D8 File Offset: 0x000129D8
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x0000539C File Offset: 0x0000359C
		public unsafe FontAsset currentFontAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_currentFontAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_currentFontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00014808 File Offset: 0x00012A08
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x000053BB File Offset: 0x000035BB
		public unsafe SpriteAsset currentSpriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_currentSpriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_currentSpriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00014838 File Offset: 0x00012A38
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x000053DA File Offset: 0x000035DA
		public unsafe Material currentMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_currentMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_currentMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00014868 File Offset: 0x00012A68
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x000053F9 File Offset: 0x000035F9
		public unsafe int currentMaterialIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_currentMaterialIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_currentMaterialIndex)) = value;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x00014890 File Offset: 0x00012A90
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x00005414 File Offset: 0x00003614
		public unsafe Extents meshExtents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_meshExtents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_meshExtents)) = value;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x000148B8 File Offset: 0x00012AB8
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x0000542F File Offset: 0x0000362F
		public unsafe bool tagNoParsing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_tagNoParsing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_tagNoParsing)) = value;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x000148E0 File Offset: 0x00012AE0
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x0000544A File Offset: 0x0000364A
		public unsafe bool isNonBreakingSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_isNonBreakingSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_isNonBreakingSpace)) = value;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00014908 File Offset: 0x00012B08
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x00005465 File Offset: 0x00003665
		public unsafe bool isDrivenLineSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_isDrivenLineSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_isDrivenLineSpacing)) = value;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00014930 File Offset: 0x00012B30
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x00005480 File Offset: 0x00003680
		public unsafe Vector3 fxScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_fxScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_fxScale)) = value;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x00014958 File Offset: 0x00012B58
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x0000549B File Offset: 0x0000369B
		public unsafe Quaternion fxRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_fxRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_fxRotation)) = value;
			}
		}

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeFieldInfoPtr_previousWordBreak;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeFieldInfoPtr_totalCharacterCount;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeFieldInfoPtr_visibleCharacterCount;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeFieldInfoPtr_visibleSpaceCount;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeFieldInfoPtr_visibleSpriteCount;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeFieldInfoPtr_visibleLinkCount;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeFieldInfoPtr_firstCharacterIndex;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeFieldInfoPtr_firstVisibleCharacterIndex;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeFieldInfoPtr_lastCharacterIndex;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeFieldInfoPtr_lastVisibleCharIndex;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeFieldInfoPtr_lineNumber;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeFieldInfoPtr_maxCapHeight;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeFieldInfoPtr_maxAscender;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeFieldInfoPtr_maxDescender;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeFieldInfoPtr_maxLineAscender;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeFieldInfoPtr_maxLineDescender;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeFieldInfoPtr_startOfLineAscender;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeFieldInfoPtr_xAdvance;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeFieldInfoPtr_preferredWidth;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeFieldInfoPtr_preferredHeight;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeFieldInfoPtr_previousLineScale;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeFieldInfoPtr_pageAscender;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeFieldInfoPtr_wordCount;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeFieldInfoPtr_fontStyle;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeFieldInfoPtr_fontScale;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeFieldInfoPtr_fontScaleMultiplier;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeFieldInfoPtr_italicAngle;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeFieldInfoPtr_currentFontSize;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeFieldInfoPtr_baselineOffset;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeFieldInfoPtr_lineOffset;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeFieldInfoPtr_textInfo;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeFieldInfoPtr_lineInfo;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeFieldInfoPtr_vertexColor;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeFieldInfoPtr_underlineColor;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeFieldInfoPtr_strikethroughColor;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeFieldInfoPtr_highlightColor;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeFieldInfoPtr_highlightState;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeFieldInfoPtr_basicStyleStack;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeFieldInfoPtr_italicAngleStack;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeFieldInfoPtr_colorStack;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeFieldInfoPtr_underlineColorStack;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeFieldInfoPtr_strikethroughColorStack;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeFieldInfoPtr_highlightColorStack;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeFieldInfoPtr_highlightStateStack;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeFieldInfoPtr_colorGradientStack;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeFieldInfoPtr_sizeStack;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeFieldInfoPtr_indentStack;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeFieldInfoPtr_fontWeightStack;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeFieldInfoPtr_styleStack;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeFieldInfoPtr_baselineStack;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeFieldInfoPtr_actionStack;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeFieldInfoPtr_materialReferenceStack;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeFieldInfoPtr_lineJustificationStack;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeFieldInfoPtr_lastBaseGlyphIndex;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeFieldInfoPtr_spriteAnimationId;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeFieldInfoPtr_currentFontAsset;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeFieldInfoPtr_currentSpriteAsset;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeFieldInfoPtr_currentMaterial;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeFieldInfoPtr_currentMaterialIndex;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeFieldInfoPtr_meshExtents;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeFieldInfoPtr_tagNoParsing;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeFieldInfoPtr_isNonBreakingSpace;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeFieldInfoPtr_isDrivenLineSpacing;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeFieldInfoPtr_fxScale;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeFieldInfoPtr_fxRotation;
	}
}

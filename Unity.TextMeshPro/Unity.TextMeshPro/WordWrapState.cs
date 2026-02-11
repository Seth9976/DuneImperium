using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace TMPro
{
	// Token: 0x0200001C RID: 28
	public sealed class WordWrapState : ValueType
	{
		// Token: 0x0600026B RID: 619 RVA: 0x00012584 File Offset: 0x00010784
		// Note: this type is marked as 'beforefieldinit'.
		static WordWrapState()
		{
			Il2CppClassPointerStore<WordWrapState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "WordWrapState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr);
			WordWrapState.NativeFieldInfoPtr_previous_WordBreak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "previous_WordBreak");
			WordWrapState.NativeFieldInfoPtr_total_CharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "total_CharacterCount");
			WordWrapState.NativeFieldInfoPtr_visible_CharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "visible_CharacterCount");
			WordWrapState.NativeFieldInfoPtr_visible_SpriteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "visible_SpriteCount");
			WordWrapState.NativeFieldInfoPtr_visible_LinkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "visible_LinkCount");
			WordWrapState.NativeFieldInfoPtr_firstCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "firstCharacterIndex");
			WordWrapState.NativeFieldInfoPtr_firstVisibleCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "firstVisibleCharacterIndex");
			WordWrapState.NativeFieldInfoPtr_lastCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "lastCharacterIndex");
			WordWrapState.NativeFieldInfoPtr_lastVisibleCharIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "lastVisibleCharIndex");
			WordWrapState.NativeFieldInfoPtr_lineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "lineNumber");
			WordWrapState.NativeFieldInfoPtr_maxCapHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "maxCapHeight");
			WordWrapState.NativeFieldInfoPtr_maxAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "maxAscender");
			WordWrapState.NativeFieldInfoPtr_maxDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "maxDescender");
			WordWrapState.NativeFieldInfoPtr_startOfLineAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "startOfLineAscender");
			WordWrapState.NativeFieldInfoPtr_maxLineAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "maxLineAscender");
			WordWrapState.NativeFieldInfoPtr_maxLineDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "maxLineDescender");
			WordWrapState.NativeFieldInfoPtr_pageAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "pageAscender");
			WordWrapState.NativeFieldInfoPtr_horizontalAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "horizontalAlignment");
			WordWrapState.NativeFieldInfoPtr_marginLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "marginLeft");
			WordWrapState.NativeFieldInfoPtr_marginRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "marginRight");
			WordWrapState.NativeFieldInfoPtr_xAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "xAdvance");
			WordWrapState.NativeFieldInfoPtr_preferredWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "preferredWidth");
			WordWrapState.NativeFieldInfoPtr_preferredHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "preferredHeight");
			WordWrapState.NativeFieldInfoPtr_previousLineScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "previousLineScale");
			WordWrapState.NativeFieldInfoPtr_wordCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "wordCount");
			WordWrapState.NativeFieldInfoPtr_fontStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "fontStyle");
			WordWrapState.NativeFieldInfoPtr_italicAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "italicAngle");
			WordWrapState.NativeFieldInfoPtr_fontScaleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "fontScaleMultiplier");
			WordWrapState.NativeFieldInfoPtr_currentFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "currentFontSize");
			WordWrapState.NativeFieldInfoPtr_baselineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "baselineOffset");
			WordWrapState.NativeFieldInfoPtr_lineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "lineOffset");
			WordWrapState.NativeFieldInfoPtr_isDrivenLineSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "isDrivenLineSpacing");
			WordWrapState.NativeFieldInfoPtr_glyphHorizontalAdvanceAdjustment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "glyphHorizontalAdvanceAdjustment");
			WordWrapState.NativeFieldInfoPtr_cSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "cSpace");
			WordWrapState.NativeFieldInfoPtr_mSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "mSpace");
			WordWrapState.NativeFieldInfoPtr_textInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "textInfo");
			WordWrapState.NativeFieldInfoPtr_lineInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "lineInfo");
			WordWrapState.NativeFieldInfoPtr_vertexColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "vertexColor");
			WordWrapState.NativeFieldInfoPtr_underlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "underlineColor");
			WordWrapState.NativeFieldInfoPtr_strikethroughColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "strikethroughColor");
			WordWrapState.NativeFieldInfoPtr_highlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "highlightColor");
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
			WordWrapState.NativeFieldInfoPtr_spriteAnimationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "spriteAnimationID");
			WordWrapState.NativeFieldInfoPtr_currentFontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "currentFontAsset");
			WordWrapState.NativeFieldInfoPtr_currentSpriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "currentSpriteAsset");
			WordWrapState.NativeFieldInfoPtr_currentMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "currentMaterial");
			WordWrapState.NativeFieldInfoPtr_currentMaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "currentMaterialIndex");
			WordWrapState.NativeFieldInfoPtr_meshExtents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "meshExtents");
			WordWrapState.NativeFieldInfoPtr_tagNoParsing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "tagNoParsing");
			WordWrapState.NativeFieldInfoPtr_isNonBreakingSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, "isNonBreakingSpace");
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00002F21 File Offset: 0x00001121
		public WordWrapState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002F2A File Offset: 0x0000112A
		public WordWrapState()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr))
		{
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00012AC8 File Offset: 0x00010CC8
		// (set) Token: 0x0600026F RID: 623 RVA: 0x00002F3C File Offset: 0x0000113C
		public unsafe int previous_WordBreak
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_previous_WordBreak);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_previous_WordBreak)) = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000270 RID: 624 RVA: 0x00012AF0 File Offset: 0x00010CF0
		// (set) Token: 0x06000271 RID: 625 RVA: 0x00002F57 File Offset: 0x00001157
		public unsafe int total_CharacterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_total_CharacterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_total_CharacterCount)) = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000272 RID: 626 RVA: 0x00012B18 File Offset: 0x00010D18
		// (set) Token: 0x06000273 RID: 627 RVA: 0x00002F72 File Offset: 0x00001172
		public unsafe int visible_CharacterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_visible_CharacterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_visible_CharacterCount)) = value;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000274 RID: 628 RVA: 0x00012B40 File Offset: 0x00010D40
		// (set) Token: 0x06000275 RID: 629 RVA: 0x00002F8D File Offset: 0x0000118D
		public unsafe int visible_SpriteCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_visible_SpriteCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_visible_SpriteCount)) = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00012B68 File Offset: 0x00010D68
		// (set) Token: 0x06000277 RID: 631 RVA: 0x00002FA8 File Offset: 0x000011A8
		public unsafe int visible_LinkCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_visible_LinkCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_visible_LinkCount)) = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000278 RID: 632 RVA: 0x00012B90 File Offset: 0x00010D90
		// (set) Token: 0x06000279 RID: 633 RVA: 0x00002FC3 File Offset: 0x000011C3
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

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600027A RID: 634 RVA: 0x00012BB8 File Offset: 0x00010DB8
		// (set) Token: 0x0600027B RID: 635 RVA: 0x00002FDE File Offset: 0x000011DE
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

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600027C RID: 636 RVA: 0x00012BE0 File Offset: 0x00010DE0
		// (set) Token: 0x0600027D RID: 637 RVA: 0x00002FF9 File Offset: 0x000011F9
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

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600027E RID: 638 RVA: 0x00012C08 File Offset: 0x00010E08
		// (set) Token: 0x0600027F RID: 639 RVA: 0x00003014 File Offset: 0x00001214
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

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000280 RID: 640 RVA: 0x00012C30 File Offset: 0x00010E30
		// (set) Token: 0x06000281 RID: 641 RVA: 0x0000302F File Offset: 0x0000122F
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

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000282 RID: 642 RVA: 0x00012C58 File Offset: 0x00010E58
		// (set) Token: 0x06000283 RID: 643 RVA: 0x0000304A File Offset: 0x0000124A
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

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000284 RID: 644 RVA: 0x00012C80 File Offset: 0x00010E80
		// (set) Token: 0x06000285 RID: 645 RVA: 0x00003065 File Offset: 0x00001265
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

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00012CA8 File Offset: 0x00010EA8
		// (set) Token: 0x06000287 RID: 647 RVA: 0x00003080 File Offset: 0x00001280
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

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000288 RID: 648 RVA: 0x00012CD0 File Offset: 0x00010ED0
		// (set) Token: 0x06000289 RID: 649 RVA: 0x0000309B File Offset: 0x0000129B
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

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600028A RID: 650 RVA: 0x00012CF8 File Offset: 0x00010EF8
		// (set) Token: 0x0600028B RID: 651 RVA: 0x000030B6 File Offset: 0x000012B6
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

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600028C RID: 652 RVA: 0x00012D20 File Offset: 0x00010F20
		// (set) Token: 0x0600028D RID: 653 RVA: 0x000030D1 File Offset: 0x000012D1
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

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600028E RID: 654 RVA: 0x00012D48 File Offset: 0x00010F48
		// (set) Token: 0x0600028F RID: 655 RVA: 0x000030EC File Offset: 0x000012EC
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

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000290 RID: 656 RVA: 0x00012D70 File Offset: 0x00010F70
		// (set) Token: 0x06000291 RID: 657 RVA: 0x00003107 File Offset: 0x00001307
		public unsafe HorizontalAlignmentOptions horizontalAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_horizontalAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_horizontalAlignment)) = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000292 RID: 658 RVA: 0x00012D98 File Offset: 0x00010F98
		// (set) Token: 0x06000293 RID: 659 RVA: 0x00003122 File Offset: 0x00001322
		public unsafe float marginLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_marginLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_marginLeft)) = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000294 RID: 660 RVA: 0x00012DC0 File Offset: 0x00010FC0
		// (set) Token: 0x06000295 RID: 661 RVA: 0x0000313D File Offset: 0x0000133D
		public unsafe float marginRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_marginRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_marginRight)) = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000296 RID: 662 RVA: 0x00012DE8 File Offset: 0x00010FE8
		// (set) Token: 0x06000297 RID: 663 RVA: 0x00003158 File Offset: 0x00001358
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

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000298 RID: 664 RVA: 0x00012E10 File Offset: 0x00011010
		// (set) Token: 0x06000299 RID: 665 RVA: 0x00003173 File Offset: 0x00001373
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

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00012E38 File Offset: 0x00011038
		// (set) Token: 0x0600029B RID: 667 RVA: 0x0000318E File Offset: 0x0000138E
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

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600029C RID: 668 RVA: 0x00012E60 File Offset: 0x00011060
		// (set) Token: 0x0600029D RID: 669 RVA: 0x000031A9 File Offset: 0x000013A9
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

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600029E RID: 670 RVA: 0x00012E88 File Offset: 0x00011088
		// (set) Token: 0x0600029F RID: 671 RVA: 0x000031C4 File Offset: 0x000013C4
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

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x00012EB0 File Offset: 0x000110B0
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x000031DF File Offset: 0x000013DF
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

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x00012ED8 File Offset: 0x000110D8
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x000031FA File Offset: 0x000013FA
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

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x00012F00 File Offset: 0x00011100
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x00003215 File Offset: 0x00001415
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

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x00012F28 File Offset: 0x00011128
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x00003230 File Offset: 0x00001430
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

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x00012F50 File Offset: 0x00011150
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x0000324B File Offset: 0x0000144B
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

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002AA RID: 682 RVA: 0x00012F78 File Offset: 0x00011178
		// (set) Token: 0x060002AB RID: 683 RVA: 0x00003266 File Offset: 0x00001466
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

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002AC RID: 684 RVA: 0x00012FA0 File Offset: 0x000111A0
		// (set) Token: 0x060002AD RID: 685 RVA: 0x00003281 File Offset: 0x00001481
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

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002AE RID: 686 RVA: 0x00012FC8 File Offset: 0x000111C8
		// (set) Token: 0x060002AF RID: 687 RVA: 0x0000329C File Offset: 0x0000149C
		public unsafe float glyphHorizontalAdvanceAdjustment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_glyphHorizontalAdvanceAdjustment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_glyphHorizontalAdvanceAdjustment)) = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x00012FF0 File Offset: 0x000111F0
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x000032B7 File Offset: 0x000014B7
		public unsafe float cSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_cSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_cSpace)) = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x00013018 File Offset: 0x00011218
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x000032D2 File Offset: 0x000014D2
		public unsafe float mSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_mSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_mSpace)) = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x00013040 File Offset: 0x00011240
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x000032ED File Offset: 0x000014ED
		public unsafe TMP_TextInfo textInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_textInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_TextInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_textInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x00013070 File Offset: 0x00011270
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x0000330C File Offset: 0x0000150C
		public unsafe TMP_LineInfo lineInfo
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

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x00013098 File Offset: 0x00011298
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x00003327 File Offset: 0x00001527
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

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002BA RID: 698 RVA: 0x000130C0 File Offset: 0x000112C0
		// (set) Token: 0x060002BB RID: 699 RVA: 0x00003342 File Offset: 0x00001542
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

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002BC RID: 700 RVA: 0x000130E8 File Offset: 0x000112E8
		// (set) Token: 0x060002BD RID: 701 RVA: 0x0000335D File Offset: 0x0000155D
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

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002BE RID: 702 RVA: 0x00013110 File Offset: 0x00011310
		// (set) Token: 0x060002BF RID: 703 RVA: 0x00003378 File Offset: 0x00001578
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

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x00013138 File Offset: 0x00011338
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x00003393 File Offset: 0x00001593
		public unsafe TMP_FontStyleStack basicStyleStack
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

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x00013160 File Offset: 0x00011360
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x000033AE File Offset: 0x000015AE
		public TMP_TextProcessingStack<int> italicAngleStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_italicAngleStack);
				return new TMP_TextProcessingStack<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_italicAngleStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00013190 File Offset: 0x00011390
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x000033DC File Offset: 0x000015DC
		public TMP_TextProcessingStack<Color32> colorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_colorStack);
				return new TMP_TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_colorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x000131C0 File Offset: 0x000113C0
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x0000340A File Offset: 0x0000160A
		public TMP_TextProcessingStack<Color32> underlineColorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_underlineColorStack);
				return new TMP_TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_underlineColorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x000131F0 File Offset: 0x000113F0
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x00003438 File Offset: 0x00001638
		public TMP_TextProcessingStack<Color32> strikethroughColorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_strikethroughColorStack);
				return new TMP_TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_strikethroughColorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060002CA RID: 714 RVA: 0x00013220 File Offset: 0x00011420
		// (set) Token: 0x060002CB RID: 715 RVA: 0x00003466 File Offset: 0x00001666
		public TMP_TextProcessingStack<Color32> highlightColorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_highlightColorStack);
				return new TMP_TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_highlightColorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00013250 File Offset: 0x00011450
		// (set) Token: 0x060002CD RID: 717 RVA: 0x00003494 File Offset: 0x00001694
		public TMP_TextProcessingStack<HighlightState> highlightStateStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_highlightStateStack);
				return new TMP_TextProcessingStack<HighlightState>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<HighlightState>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_highlightStateStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<HighlightState>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060002CE RID: 718 RVA: 0x00013280 File Offset: 0x00011480
		// (set) Token: 0x060002CF RID: 719 RVA: 0x000034C2 File Offset: 0x000016C2
		public TMP_TextProcessingStack<TMP_ColorGradient> colorGradientStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_colorGradientStack);
				return new TMP_TextProcessingStack<TMP_ColorGradient>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<TMP_ColorGradient>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_colorGradientStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<TMP_ColorGradient>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x000132B0 File Offset: 0x000114B0
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x000034F0 File Offset: 0x000016F0
		public TMP_TextProcessingStack<float> sizeStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_sizeStack);
				return new TMP_TextProcessingStack<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_sizeStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x000132E0 File Offset: 0x000114E0
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x0000351E File Offset: 0x0000171E
		public TMP_TextProcessingStack<float> indentStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_indentStack);
				return new TMP_TextProcessingStack<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_indentStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x00013310 File Offset: 0x00011510
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x0000354C File Offset: 0x0000174C
		public TMP_TextProcessingStack<FontWeight> fontWeightStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_fontWeightStack);
				return new TMP_TextProcessingStack<FontWeight>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<FontWeight>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_fontWeightStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<FontWeight>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x00013340 File Offset: 0x00011540
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x0000357A File Offset: 0x0000177A
		public TMP_TextProcessingStack<int> styleStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_styleStack);
				return new TMP_TextProcessingStack<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_styleStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x00013370 File Offset: 0x00011570
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x000035A8 File Offset: 0x000017A8
		public TMP_TextProcessingStack<float> baselineStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_baselineStack);
				return new TMP_TextProcessingStack<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_baselineStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060002DA RID: 730 RVA: 0x000133A0 File Offset: 0x000115A0
		// (set) Token: 0x060002DB RID: 731 RVA: 0x000035D6 File Offset: 0x000017D6
		public TMP_TextProcessingStack<int> actionStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_actionStack);
				return new TMP_TextProcessingStack<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_actionStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060002DC RID: 732 RVA: 0x000133D0 File Offset: 0x000115D0
		// (set) Token: 0x060002DD RID: 733 RVA: 0x00003604 File Offset: 0x00001804
		public TMP_TextProcessingStack<MaterialReference> materialReferenceStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_materialReferenceStack);
				return new TMP_TextProcessingStack<MaterialReference>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<MaterialReference>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_materialReferenceStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<MaterialReference>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060002DE RID: 734 RVA: 0x00013400 File Offset: 0x00011600
		// (set) Token: 0x060002DF RID: 735 RVA: 0x00003632 File Offset: 0x00001832
		public TMP_TextProcessingStack<HorizontalAlignmentOptions> lineJustificationStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lineJustificationStack);
				return new TMP_TextProcessingStack<HorizontalAlignmentOptions>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<HorizontalAlignmentOptions>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_lineJustificationStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<HorizontalAlignmentOptions>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x00013430 File Offset: 0x00011630
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x00003660 File Offset: 0x00001860
		public unsafe int spriteAnimationID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_spriteAnimationID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_spriteAnimationID)) = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x00013458 File Offset: 0x00011658
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x0000367B File Offset: 0x0000187B
		public unsafe TMP_FontAsset currentFontAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_currentFontAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_currentFontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x00013488 File Offset: 0x00011688
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x0000369A File Offset: 0x0000189A
		public unsafe TMP_SpriteAsset currentSpriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_currentSpriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WordWrapState.NativeFieldInfoPtr_currentSpriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x000134B8 File Offset: 0x000116B8
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x000036B9 File Offset: 0x000018B9
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

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x000134E8 File Offset: 0x000116E8
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x000036D8 File Offset: 0x000018D8
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

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060002EA RID: 746 RVA: 0x00013510 File Offset: 0x00011710
		// (set) Token: 0x060002EB RID: 747 RVA: 0x000036F3 File Offset: 0x000018F3
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

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060002EC RID: 748 RVA: 0x00013538 File Offset: 0x00011738
		// (set) Token: 0x060002ED RID: 749 RVA: 0x0000370E File Offset: 0x0000190E
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

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002EE RID: 750 RVA: 0x00013560 File Offset: 0x00011760
		// (set) Token: 0x060002EF RID: 751 RVA: 0x00003729 File Offset: 0x00001929
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

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeFieldInfoPtr_previous_WordBreak;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeFieldInfoPtr_total_CharacterCount;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeFieldInfoPtr_visible_CharacterCount;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeFieldInfoPtr_visible_SpriteCount;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeFieldInfoPtr_visible_LinkCount;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeFieldInfoPtr_firstCharacterIndex;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeFieldInfoPtr_firstVisibleCharacterIndex;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeFieldInfoPtr_lastCharacterIndex;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeFieldInfoPtr_lastVisibleCharIndex;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeFieldInfoPtr_lineNumber;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeFieldInfoPtr_maxCapHeight;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeFieldInfoPtr_maxAscender;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeFieldInfoPtr_maxDescender;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeFieldInfoPtr_startOfLineAscender;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeFieldInfoPtr_maxLineAscender;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeFieldInfoPtr_maxLineDescender;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeFieldInfoPtr_pageAscender;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeFieldInfoPtr_horizontalAlignment;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeFieldInfoPtr_marginLeft;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeFieldInfoPtr_marginRight;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeFieldInfoPtr_xAdvance;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeFieldInfoPtr_preferredWidth;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeFieldInfoPtr_preferredHeight;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeFieldInfoPtr_previousLineScale;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeFieldInfoPtr_wordCount;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeFieldInfoPtr_fontStyle;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeFieldInfoPtr_italicAngle;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeFieldInfoPtr_fontScaleMultiplier;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeFieldInfoPtr_currentFontSize;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeFieldInfoPtr_baselineOffset;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeFieldInfoPtr_lineOffset;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeFieldInfoPtr_isDrivenLineSpacing;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeFieldInfoPtr_glyphHorizontalAdvanceAdjustment;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeFieldInfoPtr_cSpace;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeFieldInfoPtr_mSpace;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeFieldInfoPtr_textInfo;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeFieldInfoPtr_lineInfo;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeFieldInfoPtr_vertexColor;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeFieldInfoPtr_underlineColor;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeFieldInfoPtr_strikethroughColor;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeFieldInfoPtr_highlightColor;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeFieldInfoPtr_basicStyleStack;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeFieldInfoPtr_italicAngleStack;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeFieldInfoPtr_colorStack;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeFieldInfoPtr_underlineColorStack;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeFieldInfoPtr_strikethroughColorStack;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeFieldInfoPtr_highlightColorStack;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeFieldInfoPtr_highlightStateStack;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeFieldInfoPtr_colorGradientStack;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeFieldInfoPtr_sizeStack;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeFieldInfoPtr_indentStack;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeFieldInfoPtr_fontWeightStack;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeFieldInfoPtr_styleStack;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeFieldInfoPtr_baselineStack;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeFieldInfoPtr_actionStack;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeFieldInfoPtr_materialReferenceStack;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeFieldInfoPtr_lineJustificationStack;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeFieldInfoPtr_spriteAnimationID;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeFieldInfoPtr_currentFontAsset;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeFieldInfoPtr_currentSpriteAsset;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeFieldInfoPtr_currentMaterial;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeFieldInfoPtr_currentMaterialIndex;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeFieldInfoPtr_meshExtents;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeFieldInfoPtr_tagNoParsing;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeFieldInfoPtr_isNonBreakingSpace;
	}
}

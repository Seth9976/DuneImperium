using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200001E RID: 30
	public class TextGenerator : Object
	{
		// Token: 0x06000323 RID: 803 RVA: 0x0000FF18 File Offset: 0x0000E118
		// Note: this type is marked as 'beforefieldinit'.
		static TextGenerator()
		{
			Il2CppClassPointerStore<TextGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr);
			TextGenerator.NativeFieldInfoPtr_s_TextGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "s_TextGenerator");
			TextGenerator.NativeFieldInfoPtr_m_TextBackingArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_TextBackingArray");
			TextGenerator.NativeFieldInfoPtr_m_TextProcessingArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_TextProcessingArray");
			TextGenerator.NativeFieldInfoPtr_m_InternalTextProcessingArraySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_InternalTextProcessingArraySize");
			TextGenerator.NativeFieldInfoPtr_m_VertexBufferAutoSizeReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_VertexBufferAutoSizeReduction");
			TextGenerator.NativeFieldInfoPtr_m_HtmlTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_HtmlTag");
			TextGenerator.NativeFieldInfoPtr_m_HighlightState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_HighlightState");
			TextGenerator.NativeFieldInfoPtr_m_IsIgnoringAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_IsIgnoringAlignment");
			TextGenerator.NativeFieldInfoPtr_m_IsTextTruncated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_IsTextTruncated");
			TextGenerator.NativeFieldInfoPtr_OnMissingCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "OnMissingCharacter");
			TextGenerator.NativeFieldInfoPtr_m_RectTransformCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_RectTransformCorners");
			TextGenerator.NativeFieldInfoPtr_m_MarginWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MarginWidth");
			TextGenerator.NativeFieldInfoPtr_m_MarginHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MarginHeight");
			TextGenerator.NativeFieldInfoPtr_m_PreferredWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_PreferredWidth");
			TextGenerator.NativeFieldInfoPtr_m_PreferredHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_PreferredHeight");
			TextGenerator.NativeFieldInfoPtr_m_CurrentFontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_CurrentFontAsset");
			TextGenerator.NativeFieldInfoPtr_m_CurrentMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_CurrentMaterial");
			TextGenerator.NativeFieldInfoPtr_m_CurrentMaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_CurrentMaterialIndex");
			TextGenerator.NativeFieldInfoPtr_m_MaterialReferenceStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MaterialReferenceStack");
			TextGenerator.NativeFieldInfoPtr_m_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_Padding");
			TextGenerator.NativeFieldInfoPtr_m_CurrentSpriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_CurrentSpriteAsset");
			TextGenerator.NativeFieldInfoPtr_m_TotalCharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_TotalCharacterCount");
			TextGenerator.NativeFieldInfoPtr_m_FontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_FontSize");
			TextGenerator.NativeFieldInfoPtr_m_FontScaleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_FontScaleMultiplier");
			TextGenerator.NativeFieldInfoPtr_m_CurrentFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_CurrentFontSize");
			TextGenerator.NativeFieldInfoPtr_m_SizeStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_SizeStack");
			TextGenerator.NativeFieldInfoPtr_m_TextStyleStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_TextStyleStacks");
			TextGenerator.NativeFieldInfoPtr_m_TextStyleStackDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_TextStyleStackDepth");
			TextGenerator.NativeFieldInfoPtr_m_FontStyleInternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_FontStyleInternal");
			TextGenerator.NativeFieldInfoPtr_m_FontStyleStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_FontStyleStack");
			TextGenerator.NativeFieldInfoPtr_m_FontWeightInternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_FontWeightInternal");
			TextGenerator.NativeFieldInfoPtr_m_FontWeightStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_FontWeightStack");
			TextGenerator.NativeFieldInfoPtr_m_LineJustification = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LineJustification");
			TextGenerator.NativeFieldInfoPtr_m_LineJustificationStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LineJustificationStack");
			TextGenerator.NativeFieldInfoPtr_m_BaselineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_BaselineOffset");
			TextGenerator.NativeFieldInfoPtr_m_BaselineOffsetStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_BaselineOffsetStack");
			TextGenerator.NativeFieldInfoPtr_m_FontColor32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_FontColor32");
			TextGenerator.NativeFieldInfoPtr_m_HtmlColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_HtmlColor");
			TextGenerator.NativeFieldInfoPtr_m_UnderlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_UnderlineColor");
			TextGenerator.NativeFieldInfoPtr_m_StrikethroughColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_StrikethroughColor");
			TextGenerator.NativeFieldInfoPtr_m_ColorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_ColorStack");
			TextGenerator.NativeFieldInfoPtr_m_UnderlineColorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_UnderlineColorStack");
			TextGenerator.NativeFieldInfoPtr_m_StrikethroughColorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_StrikethroughColorStack");
			TextGenerator.NativeFieldInfoPtr_m_HighlightColorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_HighlightColorStack");
			TextGenerator.NativeFieldInfoPtr_m_HighlightStateStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_HighlightStateStack");
			TextGenerator.NativeFieldInfoPtr_m_ItalicAngleStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_ItalicAngleStack");
			TextGenerator.NativeFieldInfoPtr_m_ColorGradientPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_ColorGradientPreset");
			TextGenerator.NativeFieldInfoPtr_m_ColorGradientStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_ColorGradientStack");
			TextGenerator.NativeFieldInfoPtr_m_ColorGradientPresetIsTinted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_ColorGradientPresetIsTinted");
			TextGenerator.NativeFieldInfoPtr_m_ActionStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_ActionStack");
			TextGenerator.NativeFieldInfoPtr_m_LineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LineOffset");
			TextGenerator.NativeFieldInfoPtr_m_LineHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LineHeight");
			TextGenerator.NativeFieldInfoPtr_m_IsDrivenLineSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_IsDrivenLineSpacing");
			TextGenerator.NativeFieldInfoPtr_m_CSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_CSpacing");
			TextGenerator.NativeFieldInfoPtr_m_MonoSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MonoSpacing");
			TextGenerator.NativeFieldInfoPtr_m_XAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_XAdvance");
			TextGenerator.NativeFieldInfoPtr_m_TagLineIndent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_TagLineIndent");
			TextGenerator.NativeFieldInfoPtr_m_TagIndent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_TagIndent");
			TextGenerator.NativeFieldInfoPtr_m_IndentStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_IndentStack");
			TextGenerator.NativeFieldInfoPtr_m_TagNoParsing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_TagNoParsing");
			TextGenerator.NativeFieldInfoPtr_m_CharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_CharacterCount");
			TextGenerator.NativeFieldInfoPtr_m_FirstCharacterOfLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_FirstCharacterOfLine");
			TextGenerator.NativeFieldInfoPtr_m_LastCharacterOfLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LastCharacterOfLine");
			TextGenerator.NativeFieldInfoPtr_m_FirstVisibleCharacterOfLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_FirstVisibleCharacterOfLine");
			TextGenerator.NativeFieldInfoPtr_m_LastVisibleCharacterOfLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LastVisibleCharacterOfLine");
			TextGenerator.NativeFieldInfoPtr_m_MaxLineAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MaxLineAscender");
			TextGenerator.NativeFieldInfoPtr_m_MaxLineDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MaxLineDescender");
			TextGenerator.NativeFieldInfoPtr_m_LineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LineNumber");
			TextGenerator.NativeFieldInfoPtr_m_LineVisibleCharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LineVisibleCharacterCount");
			TextGenerator.NativeFieldInfoPtr_m_LineVisibleSpaceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LineVisibleSpaceCount");
			TextGenerator.NativeFieldInfoPtr_m_FirstOverflowCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_FirstOverflowCharacterIndex");
			TextGenerator.NativeFieldInfoPtr_m_PageNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_PageNumber");
			TextGenerator.NativeFieldInfoPtr_m_MarginLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MarginLeft");
			TextGenerator.NativeFieldInfoPtr_m_MarginRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MarginRight");
			TextGenerator.NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_Width");
			TextGenerator.NativeFieldInfoPtr_m_MeshExtents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MeshExtents");
			TextGenerator.NativeFieldInfoPtr_m_MaxCapHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MaxCapHeight");
			TextGenerator.NativeFieldInfoPtr_m_MaxAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MaxAscender");
			TextGenerator.NativeFieldInfoPtr_m_MaxDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MaxDescender");
			TextGenerator.NativeFieldInfoPtr_m_IsNewPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_IsNewPage");
			TextGenerator.NativeFieldInfoPtr_m_IsNonBreakingSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_IsNonBreakingSpace");
			TextGenerator.NativeFieldInfoPtr_m_SavedWordWrapState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_SavedWordWrapState");
			TextGenerator.NativeFieldInfoPtr_m_SavedLineState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_SavedLineState");
			TextGenerator.NativeFieldInfoPtr_m_SavedEllipsisState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_SavedEllipsisState");
			TextGenerator.NativeFieldInfoPtr_m_SavedLastValidState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_SavedLastValidState");
			TextGenerator.NativeFieldInfoPtr_m_SavedSoftLineBreakState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_SavedSoftLineBreakState");
			TextGenerator.NativeFieldInfoPtr_m_TextElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_TextElementType");
			TextGenerator.NativeFieldInfoPtr_m_isTextLayoutPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_isTextLayoutPhase");
			TextGenerator.NativeFieldInfoPtr_m_SpriteIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_SpriteIndex");
			TextGenerator.NativeFieldInfoPtr_m_SpriteColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_SpriteColor");
			TextGenerator.NativeFieldInfoPtr_m_CachedTextElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_CachedTextElement");
			TextGenerator.NativeFieldInfoPtr_m_HighlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_HighlightColor");
			TextGenerator.NativeFieldInfoPtr_m_CharWidthAdjDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_CharWidthAdjDelta");
			TextGenerator.NativeFieldInfoPtr_m_MaxFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MaxFontSize");
			TextGenerator.NativeFieldInfoPtr_m_MinFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MinFontSize");
			TextGenerator.NativeFieldInfoPtr_m_AutoSizeIterationCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_AutoSizeIterationCount");
			TextGenerator.NativeFieldInfoPtr_m_AutoSizeMaxIterationCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_AutoSizeMaxIterationCount");
			TextGenerator.NativeFieldInfoPtr_m_IsAutoSizePointSizeSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_IsAutoSizePointSizeSet");
			TextGenerator.NativeFieldInfoPtr_m_StartOfLineAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_StartOfLineAscender");
			TextGenerator.NativeFieldInfoPtr_m_LineSpacingDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LineSpacingDelta");
			TextGenerator.NativeFieldInfoPtr_m_MaterialReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MaterialReferences");
			TextGenerator.NativeFieldInfoPtr_m_SpriteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_SpriteCount");
			TextGenerator.NativeFieldInfoPtr_m_StyleStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_StyleStack");
			TextGenerator.NativeFieldInfoPtr_m_EllipsisInsertionCandidateStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_EllipsisInsertionCandidateStack");
			TextGenerator.NativeFieldInfoPtr_m_SpriteAnimationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_SpriteAnimationId");
			TextGenerator.NativeFieldInfoPtr_m_ItalicAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_ItalicAngle");
			TextGenerator.NativeFieldInfoPtr_m_FXScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_FXScale");
			TextGenerator.NativeFieldInfoPtr_m_FXRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_FXRotation");
			TextGenerator.NativeFieldInfoPtr_m_LastBaseGlyphIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_LastBaseGlyphIndex");
			TextGenerator.NativeFieldInfoPtr_m_PageAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_PageAscender");
			TextGenerator.NativeFieldInfoPtr_m_XmlAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_XmlAttribute");
			TextGenerator.NativeFieldInfoPtr_m_AttributeParameterValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_AttributeParameterValues");
			TextGenerator.NativeFieldInfoPtr_m_MaterialReferenceIndexLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_MaterialReferenceIndexLookup");
			TextGenerator.NativeFieldInfoPtr_m_IsCalculatingPreferredValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_IsCalculatingPreferredValues");
			TextGenerator.NativeFieldInfoPtr_m_DefaultSpriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_DefaultSpriteAsset");
			TextGenerator.NativeFieldInfoPtr_m_TintSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_TintSprite");
			TextGenerator.NativeFieldInfoPtr_m_Ellipsis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_Ellipsis");
			TextGenerator.NativeFieldInfoPtr_m_Underline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_Underline");
			TextGenerator.NativeFieldInfoPtr_m_InternalTextElementInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "m_InternalTextElementInfo");
			TextGenerator.NativeMethodInfoPtr_GetTextGenerator_Private_Static_TextGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663544);
			TextGenerator.NativeMethodInfoPtr_GenerateText_Public_Static_Void_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663545);
			TextGenerator.NativeMethodInfoPtr_GetPreferredValues_Public_Static_Vector2_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663546);
			TextGenerator.NativeMethodInfoPtr_get_isTextTruncated_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663547);
			TextGenerator.NativeMethodInfoPtr_Prepare_Private_Void_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663548);
			TextGenerator.NativeMethodInfoPtr_GenerateTextMesh_Private_Void_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663549);
			TextGenerator.NativeMethodInfoPtr_SaveWordWrappingState_Private_Void_byref_WordWrapState_Int32_Int32_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663550);
			TextGenerator.NativeMethodInfoPtr_RestoreWordWrappingState_Protected_Int32_byref_WordWrapState_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663551);
			TextGenerator.NativeMethodInfoPtr_ValidateHtmlTag_Protected_Boolean_Il2CppStructArray_1_TextProcessingElement_Int32_byref_Int32_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663552);
			TextGenerator.NativeMethodInfoPtr_SaveGlyphVertexInfo_Private_Void_Single_Single_Color32_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663553);
			TextGenerator.NativeMethodInfoPtr_SaveSpriteVertexInfo_Private_Void_Color32_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663554);
			TextGenerator.NativeMethodInfoPtr_DrawUnderlineMesh_Private_Void_Vector3_Vector3_Single_Single_Single_Single_Color32_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663555);
			TextGenerator.NativeMethodInfoPtr_DrawTextHighlight_Private_Void_Vector3_Vector3_Color32_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663556);
			TextGenerator.NativeMethodInfoPtr_ClearMesh_Private_Static_Void_Boolean_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663557);
			TextGenerator.NativeMethodInfoPtr_SetArraySizes_Internal_Int32_Il2CppStructArray_1_TextProcessingElement_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663558);
			TextGenerator.NativeMethodInfoPtr_GetTextElement_Internal_TextElement_TextGenerationSettings_UInt32_FontAsset_FontStyles_TextFontWeight_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663559);
			TextGenerator.NativeMethodInfoPtr_ComputeMarginSize_Private_Void_Rect_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663560);
			TextGenerator.NativeMethodInfoPtr_GetSpecialCharacters_Protected_Void_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663561);
			TextGenerator.NativeMethodInfoPtr_GetEllipsisSpecialCharacter_Protected_Void_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663562);
			TextGenerator.NativeMethodInfoPtr_GetUnderlineSpecialCharacter_Protected_Void_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663563);
			TextGenerator.NativeMethodInfoPtr_GetPreferredValuesInternal_Private_Vector2_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663564);
			TextGenerator.NativeMethodInfoPtr_CalculatePreferredValues_Protected_Virtual_New_Vector2_byref_Single_Vector2_Boolean_TextWrappingMode_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663565);
			TextGenerator.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663566);
			TextGenerator.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663567);
			TextGenerator.NativeMethodInfoPtr_PopulateTextProcessingArray_Private_Void_TextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663568);
			TextGenerator.NativeMethodInfoPtr_InsertNewLine_Private_Void_Int32_Single_Single_Single_Single_Single_Single_Single_byref_Boolean_byref_Single_TextGenerationSettings_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663569);
			TextGenerator.NativeMethodInfoPtr_DoMissingGlyphCallback_Protected_Void_UInt32_Int32_FontAsset_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663570);
			TextGenerator.NativeMethodInfoPtr_ClearMarkupTagAttributes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663571);
			TextGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, 100663572);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00010AD8 File Offset: 0x0000ECD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1102089, RefRangeEnd = 1102090, XrefRangeStart = 1102081, XrefRangeEnd = 1102089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TextGenerator GetTextGenerator()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_GetTextGenerator_Private_Static_TextGenerator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextGenerator>(intPtr3) : null;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00010B0C File Offset: 0x0000ED0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1102105, RefRangeEnd = 1102106, XrefRangeStart = 1102090, XrefRangeEnd = 1102105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GenerateText(TextGenerationSettings settings, TextInfo textInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_GenerateText_Public_Static_Void_TextGenerationSettings_TextInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00010B54 File Offset: 0x0000ED54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1102138, RefRangeEnd = 1102139, XrefRangeStart = 1102106, XrefRangeEnd = 1102138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 GetPreferredValues(TextGenerationSettings settings, TextInfo textInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_GetPreferredValues_Public_Static_Vector2_TextGenerationSettings_TextInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000327 RID: 807 RVA: 0x00010BA8 File Offset: 0x0000EDA8
		public unsafe static bool isTextTruncated
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1102141, RefRangeEnd = 1102142, XrefRangeStart = 1102139, XrefRangeEnd = 1102141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_get_isTextTruncated_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00010BD8 File Offset: 0x0000EDD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1102155, RefRangeEnd = 1102157, XrefRangeStart = 1102142, XrefRangeEnd = 1102155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Prepare(TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(generationSettings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_Prepare_Private_Void_TextGenerationSettings_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00010C2C File Offset: 0x0000EE2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1103262, RefRangeEnd = 1103263, XrefRangeStart = 1102157, XrefRangeEnd = 1103262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateTextMesh(TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(generationSettings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_GenerateTextMesh_Private_Void_TextGenerationSettings_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00010C80 File Offset: 0x0000EE80
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1103281, RefRangeEnd = 1103301, XrefRangeStart = 1103263, XrefRangeEnd = 1103281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveWordWrappingState(ref WordWrapState state, int index, int count, TextInfo textInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(state);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_SaveWordWrappingState_Private_Void_byref_WordWrapState_Int32_Int32_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00010CF4 File Offset: 0x0000EEF4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1103319, RefRangeEnd = 1103330, XrefRangeStart = 1103301, XrefRangeEnd = 1103319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RestoreWordWrappingState(ref WordWrapState state, TextInfo textInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(state);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_RestoreWordWrappingState_Protected_Int32_byref_WordWrapState_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00010D54 File Offset: 0x0000EF54
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1103431, RefRangeEnd = 1103434, XrefRangeStart = 1103330, XrefRangeEnd = 1103431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateHtmlTag(Il2CppStructArray<TextProcessingElement> chars, int startIndex, out int endIndex, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &endIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generationSettings);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_ValidateHtmlTag_Protected_Boolean_Il2CppStructArray_1_TextProcessingElement_Int32_byref_Int32_TextGenerationSettings_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00010DE4 File Offset: 0x0000EFE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1103483, RefRangeEnd = 1103484, XrefRangeStart = 1103434, XrefRangeEnd = 1103483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveGlyphVertexInfo(float padding, float stylePadding, Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref padding;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stylePadding;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vertexColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generationSettings);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_SaveGlyphVertexInfo_Private_Void_Single_Single_Color32_TextGenerationSettings_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00010E64 File Offset: 0x0000F064
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1103547, RefRangeEnd = 1103548, XrefRangeStart = 1103484, XrefRangeEnd = 1103547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveSpriteVertexInfo(Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vertexColor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generationSettings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_SaveSpriteVertexInfo_Private_Void_Color32_TextGenerationSettings_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00010EC8 File Offset: 0x0000F0C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1103594, RefRangeEnd = 1103597, XrefRangeStart = 1103548, XrefRangeEnd = 1103594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawUnderlineMesh(Vector3 start, Vector3 end, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startScale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endScale;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxScale;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sdfScale;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref underlineColor;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generationSettings);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_DrawUnderlineMesh_Private_Void_Vector3_Vector3_Single_Single_Single_Single_Color32_TextGenerationSettings_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00010F84 File Offset: 0x0000F184
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1103618, RefRangeEnd = 1103620, XrefRangeStart = 1103597, XrefRangeEnd = 1103618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawTextHighlight(Vector3 start, Vector3 end, Color32 highlightColor, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref highlightColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generationSettings);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_DrawTextHighlight_Private_Void_Vector3_Vector3_Color32_TextGenerationSettings_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00011004 File Offset: 0x0000F204
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1103622, RefRangeEnd = 1103624, XrefRangeStart = 1103620, XrefRangeEnd = 1103622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearMesh(bool updateMesh, TextInfo textInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateMesh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_ClearMesh_Private_Static_Void_Boolean_TextInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00011048 File Offset: 0x0000F248
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1103833, RefRangeEnd = 1103834, XrefRangeStart = 1103624, XrefRangeEnd = 1103833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int SetArraySizes(Il2CppStructArray<TextProcessingElement> textProcessingArray, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textProcessingArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generationSettings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_SetArraySizes_Internal_Int32_Il2CppStructArray_1_TextProcessingElement_TextGenerationSettings_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x000110BC File Offset: 0x0000F2BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1103845, RefRangeEnd = 1103846, XrefRangeStart = 1103834, XrefRangeEnd = 1103845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextElement GetTextElement(TextGenerationSettings generationSettings, uint unicode, FontAsset fontAsset, FontStyles fontStyle, TextFontWeight fontWeight, out bool isUsingAlternativeTypeface)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(generationSettings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unicode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fontStyle;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fontWeight;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isUsingAlternativeTypeface;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_GetTextElement_Internal_TextElement_TextGenerationSettings_UInt32_FontAsset_FontStyles_TextFontWeight_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextElement>(intPtr3) : null;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00011158 File Offset: 0x0000F358
		[CallerCount(0)]
		public unsafe void ComputeMarginSize(Rect rect, Vector4 margins)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref margins;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_ComputeMarginSize_Private_Void_Rect_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x000111A4 File Offset: 0x0000F3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103846, XrefRangeEnd = 1103851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetSpecialCharacters(TextGenerationSettings generationSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(generationSettings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_GetSpecialCharacters_Protected_Void_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000336 RID: 822 RVA: 0x000111E8 File Offset: 0x0000F3E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1103863, RefRangeEnd = 1103866, XrefRangeStart = 1103851, XrefRangeEnd = 1103863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetEllipsisSpecialCharacter(TextGenerationSettings generationSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(generationSettings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_GetEllipsisSpecialCharacter_Protected_Void_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0001122C File Offset: 0x0000F42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103866, XrefRangeEnd = 1103870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetUnderlineSpecialCharacter(TextGenerationSettings generationSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(generationSettings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_GetUnderlineSpecialCharacter_Protected_Void_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00011270 File Offset: 0x0000F470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103870, XrefRangeEnd = 1103879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetPreferredValuesInternal(TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(generationSettings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_GetPreferredValuesInternal_Private_Vector2_TextGenerationSettings_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x000112D0 File Offset: 0x0000F4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103879, XrefRangeEnd = 1104212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, TextWrappingMode textWrapMode, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &fontSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref marginSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTextAutoSizingEnabled;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textWrapMode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generationSettings);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextGenerator.NativeMethodInfoPtr_CalculatePreferredValues_Protected_Virtual_New_Vector2_byref_Single_Vector2_Boolean_TextWrappingMode_TextGenerationSettings_TextInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00011374 File Offset: 0x0000F574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104212, XrefRangeEnd = 1104220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateTextBackingArray(string sourceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x000113B8 File Offset: 0x0000F5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104220, XrefRangeEnd = 1104230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateTextBackingArray(string sourceText, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00011418 File Offset: 0x0000F618
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1104346, RefRangeEnd = 1104347, XrefRangeStart = 1104230, XrefRangeEnd = 1104346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateTextProcessingArray(TextGenerationSettings generationSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(generationSettings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_PopulateTextProcessingArray_Private_Void_TextGenerationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0001145C File Offset: 0x0000F65C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1104365, RefRangeEnd = 1104367, XrefRangeStart = 1104347, XrefRangeEnd = 1104365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseScale;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentElementScale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentEmScale;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref boldSpacingAdjustment;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref characterSpacingAdjustment;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineGap;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isMaxVisibleDescenderSet;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maxVisibleDescender;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generationSettings);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_InsertNewLine_Private_Void_Int32_Single_Single_Single_Single_Single_Single_Single_byref_Boolean_byref_Single_TextGenerationSettings_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00011544 File Offset: 0x0000F744
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1104369, RefRangeEnd = 1104370, XrefRangeStart = 1104367, XrefRangeEnd = 1104369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoMissingGlyphCallback(uint unicode, int stringIndex, FontAsset fontAsset, TextInfo textInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stringIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_DoMissingGlyphCallback_Protected_Void_UInt32_Int32_FontAsset_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033F RID: 831 RVA: 0x000115B8 File Offset: 0x0000F7B8
		[CallerCount(0)]
		public unsafe void ClearMarkupTagAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr_ClearMarkupTagAttributes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x000115EC File Offset: 0x0000F7EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1104504, RefRangeEnd = 1104506, XrefRangeStart = 1104370, XrefRangeEnd = 1104504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextGenerator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00003CD3 File Offset: 0x00001ED3
		public TextGenerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000342 RID: 834 RVA: 0x00011628 File Offset: 0x0000F828
		// (set) Token: 0x06000343 RID: 835 RVA: 0x00003CDC File Offset: 0x00001EDC
		public unsafe static TextGenerator s_TextGenerator
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextGenerator.NativeFieldInfoPtr_s_TextGenerator, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextGenerator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextGenerator.NativeFieldInfoPtr_s_TextGenerator, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00011650 File Offset: 0x0000F850
		// (set) Token: 0x06000345 RID: 837 RVA: 0x00003CEE File Offset: 0x00001EEE
		public TextBackingContainer m_TextBackingArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_TextBackingArray);
				return new TextBackingContainer(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextBackingContainer>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_TextBackingArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextBackingContainer>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000346 RID: 838 RVA: 0x00011680 File Offset: 0x0000F880
		// (set) Token: 0x06000347 RID: 839 RVA: 0x00003D1C File Offset: 0x00001F1C
		public unsafe Il2CppStructArray<TextProcessingElement> m_TextProcessingArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_TextProcessingArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TextProcessingElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_TextProcessingArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000348 RID: 840 RVA: 0x000116B0 File Offset: 0x0000F8B0
		// (set) Token: 0x06000349 RID: 841 RVA: 0x00003D3B File Offset: 0x00001F3B
		public unsafe int m_InternalTextProcessingArraySize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_InternalTextProcessingArraySize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_InternalTextProcessingArraySize)) = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600034A RID: 842 RVA: 0x000116D8 File Offset: 0x0000F8D8
		// (set) Token: 0x0600034B RID: 843 RVA: 0x00003D56 File Offset: 0x00001F56
		public unsafe bool m_VertexBufferAutoSizeReduction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_VertexBufferAutoSizeReduction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_VertexBufferAutoSizeReduction)) = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600034C RID: 844 RVA: 0x00011700 File Offset: 0x0000F900
		// (set) Token: 0x0600034D RID: 845 RVA: 0x00003D71 File Offset: 0x00001F71
		public unsafe Il2CppStructArray<char> m_HtmlTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_HtmlTag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_HtmlTag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600034E RID: 846 RVA: 0x00011730 File Offset: 0x0000F930
		// (set) Token: 0x0600034F RID: 847 RVA: 0x00003D90 File Offset: 0x00001F90
		public unsafe HighlightState m_HighlightState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_HighlightState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_HighlightState)) = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00011758 File Offset: 0x0000F958
		// (set) Token: 0x06000351 RID: 849 RVA: 0x00003DAB File Offset: 0x00001FAB
		public unsafe bool m_IsIgnoringAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_IsIgnoringAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_IsIgnoringAlignment)) = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00011780 File Offset: 0x0000F980
		// (set) Token: 0x06000353 RID: 851 RVA: 0x00003DC6 File Offset: 0x00001FC6
		public unsafe static bool m_IsTextTruncated
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TextGenerator.NativeFieldInfoPtr_m_IsTextTruncated, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextGenerator.NativeFieldInfoPtr_m_IsTextTruncated, (void*)(&value));
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000354 RID: 852 RVA: 0x0001179C File Offset: 0x0000F99C
		// (set) Token: 0x06000355 RID: 853 RVA: 0x00003DD4 File Offset: 0x00001FD4
		public unsafe static TextGenerator.MissingCharacterEventCallback OnMissingCharacter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextGenerator.NativeFieldInfoPtr_OnMissingCharacter, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextGenerator.MissingCharacterEventCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextGenerator.NativeFieldInfoPtr_OnMissingCharacter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000356 RID: 854 RVA: 0x000117C4 File Offset: 0x0000F9C4
		// (set) Token: 0x06000357 RID: 855 RVA: 0x00003DE6 File Offset: 0x00001FE6
		public unsafe Il2CppStructArray<Vector3> m_RectTransformCorners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_RectTransformCorners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_RectTransformCorners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000358 RID: 856 RVA: 0x000117F4 File Offset: 0x0000F9F4
		// (set) Token: 0x06000359 RID: 857 RVA: 0x00003E05 File Offset: 0x00002005
		public unsafe float m_MarginWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MarginWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MarginWidth)) = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600035A RID: 858 RVA: 0x0001181C File Offset: 0x0000FA1C
		// (set) Token: 0x0600035B RID: 859 RVA: 0x00003E20 File Offset: 0x00002020
		public unsafe float m_MarginHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MarginHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MarginHeight)) = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00011844 File Offset: 0x0000FA44
		// (set) Token: 0x0600035D RID: 861 RVA: 0x00003E3B File Offset: 0x0000203B
		public unsafe float m_PreferredWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_PreferredWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_PreferredWidth)) = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600035E RID: 862 RVA: 0x0001186C File Offset: 0x0000FA6C
		// (set) Token: 0x0600035F RID: 863 RVA: 0x00003E56 File Offset: 0x00002056
		public unsafe float m_PreferredHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_PreferredHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_PreferredHeight)) = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00011894 File Offset: 0x0000FA94
		// (set) Token: 0x06000361 RID: 865 RVA: 0x00003E71 File Offset: 0x00002071
		public unsafe FontAsset m_CurrentFontAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_CurrentFontAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_CurrentFontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000362 RID: 866 RVA: 0x000118C4 File Offset: 0x0000FAC4
		// (set) Token: 0x06000363 RID: 867 RVA: 0x00003E90 File Offset: 0x00002090
		public unsafe Material m_CurrentMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_CurrentMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_CurrentMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000364 RID: 868 RVA: 0x000118F4 File Offset: 0x0000FAF4
		// (set) Token: 0x06000365 RID: 869 RVA: 0x00003EAF File Offset: 0x000020AF
		public unsafe int m_CurrentMaterialIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_CurrentMaterialIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_CurrentMaterialIndex)) = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000366 RID: 870 RVA: 0x0001191C File Offset: 0x0000FB1C
		// (set) Token: 0x06000367 RID: 871 RVA: 0x00003ECA File Offset: 0x000020CA
		public TextProcessingStack<MaterialReference> m_MaterialReferenceStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MaterialReferenceStack);
				return new TextProcessingStack<MaterialReference>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<MaterialReference>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MaterialReferenceStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<MaterialReference>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000368 RID: 872 RVA: 0x0001194C File Offset: 0x0000FB4C
		// (set) Token: 0x06000369 RID: 873 RVA: 0x00003EF8 File Offset: 0x000020F8
		public unsafe float m_Padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_Padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_Padding)) = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600036A RID: 874 RVA: 0x00011974 File Offset: 0x0000FB74
		// (set) Token: 0x0600036B RID: 875 RVA: 0x00003F13 File Offset: 0x00002113
		public unsafe SpriteAsset m_CurrentSpriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_CurrentSpriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_CurrentSpriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600036C RID: 876 RVA: 0x000119A4 File Offset: 0x0000FBA4
		// (set) Token: 0x0600036D RID: 877 RVA: 0x00003F32 File Offset: 0x00002132
		public unsafe int m_TotalCharacterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_TotalCharacterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_TotalCharacterCount)) = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600036E RID: 878 RVA: 0x000119CC File Offset: 0x0000FBCC
		// (set) Token: 0x0600036F RID: 879 RVA: 0x00003F4D File Offset: 0x0000214D
		public unsafe float m_FontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_FontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_FontSize)) = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000370 RID: 880 RVA: 0x000119F4 File Offset: 0x0000FBF4
		// (set) Token: 0x06000371 RID: 881 RVA: 0x00003F68 File Offset: 0x00002168
		public unsafe float m_FontScaleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_FontScaleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_FontScaleMultiplier)) = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000372 RID: 882 RVA: 0x00011A1C File Offset: 0x0000FC1C
		// (set) Token: 0x06000373 RID: 883 RVA: 0x00003F83 File Offset: 0x00002183
		public unsafe float m_CurrentFontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_CurrentFontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_CurrentFontSize)) = value;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00011A44 File Offset: 0x0000FC44
		// (set) Token: 0x06000375 RID: 885 RVA: 0x00003F9E File Offset: 0x0000219E
		public TextProcessingStack<float> m_SizeStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_SizeStack);
				return new TextProcessingStack<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_SizeStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00011A74 File Offset: 0x0000FC74
		// (set) Token: 0x06000377 RID: 887 RVA: 0x00003FCC File Offset: 0x000021CC
		public unsafe Il2CppReferenceArray<TextProcessingStack<int>> m_TextStyleStacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_TextStyleStacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextProcessingStack<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_TextStyleStacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00011AA4 File Offset: 0x0000FCA4
		// (set) Token: 0x06000379 RID: 889 RVA: 0x00003FEB File Offset: 0x000021EB
		public unsafe int m_TextStyleStackDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_TextStyleStackDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_TextStyleStackDepth)) = value;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00011ACC File Offset: 0x0000FCCC
		// (set) Token: 0x0600037B RID: 891 RVA: 0x00004006 File Offset: 0x00002206
		public unsafe FontStyles m_FontStyleInternal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_FontStyleInternal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_FontStyleInternal)) = value;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00011AF4 File Offset: 0x0000FCF4
		// (set) Token: 0x0600037D RID: 893 RVA: 0x00004021 File Offset: 0x00002221
		public unsafe FontStyleStack m_FontStyleStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_FontStyleStack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_FontStyleStack)) = value;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600037E RID: 894 RVA: 0x00011B1C File Offset: 0x0000FD1C
		// (set) Token: 0x0600037F RID: 895 RVA: 0x0000403C File Offset: 0x0000223C
		public unsafe TextFontWeight m_FontWeightInternal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_FontWeightInternal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_FontWeightInternal)) = value;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00011B44 File Offset: 0x0000FD44
		// (set) Token: 0x06000381 RID: 897 RVA: 0x00004057 File Offset: 0x00002257
		public TextProcessingStack<TextFontWeight> m_FontWeightStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_FontWeightStack);
				return new TextProcessingStack<TextFontWeight>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<TextFontWeight>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_FontWeightStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<TextFontWeight>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00011B74 File Offset: 0x0000FD74
		// (set) Token: 0x06000383 RID: 899 RVA: 0x00004085 File Offset: 0x00002285
		public unsafe TextAlignment m_LineJustification
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LineJustification);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LineJustification)) = value;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000384 RID: 900 RVA: 0x00011B9C File Offset: 0x0000FD9C
		// (set) Token: 0x06000385 RID: 901 RVA: 0x000040A0 File Offset: 0x000022A0
		public TextProcessingStack<TextAlignment> m_LineJustificationStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LineJustificationStack);
				return new TextProcessingStack<TextAlignment>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<TextAlignment>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LineJustificationStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<TextAlignment>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00011BCC File Offset: 0x0000FDCC
		// (set) Token: 0x06000387 RID: 903 RVA: 0x000040CE File Offset: 0x000022CE
		public unsafe float m_BaselineOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_BaselineOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_BaselineOffset)) = value;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000388 RID: 904 RVA: 0x00011BF4 File Offset: 0x0000FDF4
		// (set) Token: 0x06000389 RID: 905 RVA: 0x000040E9 File Offset: 0x000022E9
		public TextProcessingStack<float> m_BaselineOffsetStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_BaselineOffsetStack);
				return new TextProcessingStack<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_BaselineOffsetStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600038A RID: 906 RVA: 0x00011C24 File Offset: 0x0000FE24
		// (set) Token: 0x0600038B RID: 907 RVA: 0x00004117 File Offset: 0x00002317
		public unsafe Color32 m_FontColor32
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_FontColor32);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_FontColor32)) = value;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00011C4C File Offset: 0x0000FE4C
		// (set) Token: 0x0600038D RID: 909 RVA: 0x00004132 File Offset: 0x00002332
		public unsafe Color32 m_HtmlColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_HtmlColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_HtmlColor)) = value;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600038E RID: 910 RVA: 0x00011C74 File Offset: 0x0000FE74
		// (set) Token: 0x0600038F RID: 911 RVA: 0x0000414D File Offset: 0x0000234D
		public unsafe Color32 m_UnderlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_UnderlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_UnderlineColor)) = value;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00011C9C File Offset: 0x0000FE9C
		// (set) Token: 0x06000391 RID: 913 RVA: 0x00004168 File Offset: 0x00002368
		public unsafe Color32 m_StrikethroughColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_StrikethroughColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_StrikethroughColor)) = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00011CC4 File Offset: 0x0000FEC4
		// (set) Token: 0x06000393 RID: 915 RVA: 0x00004183 File Offset: 0x00002383
		public TextProcessingStack<Color32> m_ColorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_ColorStack);
				return new TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_ColorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00011CF4 File Offset: 0x0000FEF4
		// (set) Token: 0x06000395 RID: 917 RVA: 0x000041B1 File Offset: 0x000023B1
		public TextProcessingStack<Color32> m_UnderlineColorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_UnderlineColorStack);
				return new TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_UnderlineColorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000396 RID: 918 RVA: 0x00011D24 File Offset: 0x0000FF24
		// (set) Token: 0x06000397 RID: 919 RVA: 0x000041DF File Offset: 0x000023DF
		public TextProcessingStack<Color32> m_StrikethroughColorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_StrikethroughColorStack);
				return new TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_StrikethroughColorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00011D54 File Offset: 0x0000FF54
		// (set) Token: 0x06000399 RID: 921 RVA: 0x0000420D File Offset: 0x0000240D
		public TextProcessingStack<Color32> m_HighlightColorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_HighlightColorStack);
				return new TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_HighlightColorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<Color32>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00011D84 File Offset: 0x0000FF84
		// (set) Token: 0x0600039B RID: 923 RVA: 0x0000423B File Offset: 0x0000243B
		public TextProcessingStack<HighlightState> m_HighlightStateStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_HighlightStateStack);
				return new TextProcessingStack<HighlightState>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<HighlightState>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_HighlightStateStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<HighlightState>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00011DB4 File Offset: 0x0000FFB4
		// (set) Token: 0x0600039D RID: 925 RVA: 0x00004269 File Offset: 0x00002469
		public TextProcessingStack<int> m_ItalicAngleStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_ItalicAngleStack);
				return new TextProcessingStack<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_ItalicAngleStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00011DE4 File Offset: 0x0000FFE4
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00004297 File Offset: 0x00002497
		public unsafe TextColorGradient m_ColorGradientPreset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_ColorGradientPreset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextColorGradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_ColorGradientPreset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00011E14 File Offset: 0x00010014
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x000042B6 File Offset: 0x000024B6
		public TextProcessingStack<TextColorGradient> m_ColorGradientStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_ColorGradientStack);
				return new TextProcessingStack<TextColorGradient>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<TextColorGradient>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_ColorGradientStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<TextColorGradient>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00011E44 File Offset: 0x00010044
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x000042E4 File Offset: 0x000024E4
		public unsafe bool m_ColorGradientPresetIsTinted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_ColorGradientPresetIsTinted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_ColorGradientPresetIsTinted)) = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x00011E6C File Offset: 0x0001006C
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x000042FF File Offset: 0x000024FF
		public TextProcessingStack<int> m_ActionStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_ActionStack);
				return new TextProcessingStack<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_ActionStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x00011E9C File Offset: 0x0001009C
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x0000432D File Offset: 0x0000252D
		public unsafe float m_LineOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LineOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LineOffset)) = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00011EC4 File Offset: 0x000100C4
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x00004348 File Offset: 0x00002548
		public unsafe float m_LineHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LineHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LineHeight)) = value;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060003AA RID: 938 RVA: 0x00011EEC File Offset: 0x000100EC
		// (set) Token: 0x060003AB RID: 939 RVA: 0x00004363 File Offset: 0x00002563
		public unsafe bool m_IsDrivenLineSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_IsDrivenLineSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_IsDrivenLineSpacing)) = value;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060003AC RID: 940 RVA: 0x00011F14 File Offset: 0x00010114
		// (set) Token: 0x060003AD RID: 941 RVA: 0x0000437E File Offset: 0x0000257E
		public unsafe float m_CSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_CSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_CSpacing)) = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060003AE RID: 942 RVA: 0x00011F3C File Offset: 0x0001013C
		// (set) Token: 0x060003AF RID: 943 RVA: 0x00004399 File Offset: 0x00002599
		public unsafe float m_MonoSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MonoSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MonoSpacing)) = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x00011F64 File Offset: 0x00010164
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x000043B4 File Offset: 0x000025B4
		public unsafe float m_XAdvance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_XAdvance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_XAdvance)) = value;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x00011F8C File Offset: 0x0001018C
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x000043CF File Offset: 0x000025CF
		public unsafe float m_TagLineIndent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_TagLineIndent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_TagLineIndent)) = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x00011FB4 File Offset: 0x000101B4
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x000043EA File Offset: 0x000025EA
		public unsafe float m_TagIndent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_TagIndent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_TagIndent)) = value;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x00011FDC File Offset: 0x000101DC
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x00004405 File Offset: 0x00002605
		public TextProcessingStack<float> m_IndentStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_IndentStack);
				return new TextProcessingStack<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_IndentStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x0001200C File Offset: 0x0001020C
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x00004433 File Offset: 0x00002633
		public unsafe bool m_TagNoParsing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_TagNoParsing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_TagNoParsing)) = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00012034 File Offset: 0x00010234
		// (set) Token: 0x060003BB RID: 955 RVA: 0x0000444E File Offset: 0x0000264E
		public unsafe int m_CharacterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_CharacterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_CharacterCount)) = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060003BC RID: 956 RVA: 0x0001205C File Offset: 0x0001025C
		// (set) Token: 0x060003BD RID: 957 RVA: 0x00004469 File Offset: 0x00002669
		public unsafe int m_FirstCharacterOfLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_FirstCharacterOfLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_FirstCharacterOfLine)) = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00012084 File Offset: 0x00010284
		// (set) Token: 0x060003BF RID: 959 RVA: 0x00004484 File Offset: 0x00002684
		public unsafe int m_LastCharacterOfLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LastCharacterOfLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LastCharacterOfLine)) = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x000120AC File Offset: 0x000102AC
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x0000449F File Offset: 0x0000269F
		public unsafe int m_FirstVisibleCharacterOfLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_FirstVisibleCharacterOfLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_FirstVisibleCharacterOfLine)) = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x000120D4 File Offset: 0x000102D4
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x000044BA File Offset: 0x000026BA
		public unsafe int m_LastVisibleCharacterOfLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LastVisibleCharacterOfLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LastVisibleCharacterOfLine)) = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x000120FC File Offset: 0x000102FC
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x000044D5 File Offset: 0x000026D5
		public unsafe float m_MaxLineAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MaxLineAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MaxLineAscender)) = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x00012124 File Offset: 0x00010324
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x000044F0 File Offset: 0x000026F0
		public unsafe float m_MaxLineDescender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MaxLineDescender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MaxLineDescender)) = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x0001214C File Offset: 0x0001034C
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x0000450B File Offset: 0x0000270B
		public unsafe int m_LineNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LineNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LineNumber)) = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00012174 File Offset: 0x00010374
		// (set) Token: 0x060003CB RID: 971 RVA: 0x00004526 File Offset: 0x00002726
		public unsafe int m_LineVisibleCharacterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LineVisibleCharacterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LineVisibleCharacterCount)) = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060003CC RID: 972 RVA: 0x0001219C File Offset: 0x0001039C
		// (set) Token: 0x060003CD RID: 973 RVA: 0x00004541 File Offset: 0x00002741
		public unsafe int m_LineVisibleSpaceCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LineVisibleSpaceCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LineVisibleSpaceCount)) = value;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060003CE RID: 974 RVA: 0x000121C4 File Offset: 0x000103C4
		// (set) Token: 0x060003CF RID: 975 RVA: 0x0000455C File Offset: 0x0000275C
		public unsafe int m_FirstOverflowCharacterIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_FirstOverflowCharacterIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_FirstOverflowCharacterIndex)) = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x000121EC File Offset: 0x000103EC
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x00004577 File Offset: 0x00002777
		public unsafe int m_PageNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_PageNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_PageNumber)) = value;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00012214 File Offset: 0x00010414
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x00004592 File Offset: 0x00002792
		public unsafe float m_MarginLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MarginLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MarginLeft)) = value;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x0001223C File Offset: 0x0001043C
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x000045AD File Offset: 0x000027AD
		public unsafe float m_MarginRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MarginRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MarginRight)) = value;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00012264 File Offset: 0x00010464
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x000045C8 File Offset: 0x000027C8
		public unsafe float m_Width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_Width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_Width)) = value;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x0001228C File Offset: 0x0001048C
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x000045E3 File Offset: 0x000027E3
		public unsafe Extents m_MeshExtents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MeshExtents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MeshExtents)) = value;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060003DA RID: 986 RVA: 0x000122B4 File Offset: 0x000104B4
		// (set) Token: 0x060003DB RID: 987 RVA: 0x000045FE File Offset: 0x000027FE
		public unsafe float m_MaxCapHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MaxCapHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MaxCapHeight)) = value;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060003DC RID: 988 RVA: 0x000122DC File Offset: 0x000104DC
		// (set) Token: 0x060003DD RID: 989 RVA: 0x00004619 File Offset: 0x00002819
		public unsafe float m_MaxAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MaxAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MaxAscender)) = value;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060003DE RID: 990 RVA: 0x00012304 File Offset: 0x00010504
		// (set) Token: 0x060003DF RID: 991 RVA: 0x00004634 File Offset: 0x00002834
		public unsafe float m_MaxDescender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MaxDescender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MaxDescender)) = value;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x0001232C File Offset: 0x0001052C
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x0000464F File Offset: 0x0000284F
		public unsafe bool m_IsNewPage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_IsNewPage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_IsNewPage)) = value;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x00012354 File Offset: 0x00010554
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x0000466A File Offset: 0x0000286A
		public unsafe bool m_IsNonBreakingSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_IsNonBreakingSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_IsNonBreakingSpace)) = value;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x0001237C File Offset: 0x0001057C
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x00004685 File Offset: 0x00002885
		public WordWrapState m_SavedWordWrapState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_SavedWordWrapState);
				return new WordWrapState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_SavedWordWrapState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x000123AC File Offset: 0x000105AC
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x000046B3 File Offset: 0x000028B3
		public WordWrapState m_SavedLineState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_SavedLineState);
				return new WordWrapState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_SavedLineState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x000123DC File Offset: 0x000105DC
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x000046E1 File Offset: 0x000028E1
		public WordWrapState m_SavedEllipsisState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_SavedEllipsisState);
				return new WordWrapState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_SavedEllipsisState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x0001240C File Offset: 0x0001060C
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x0000470F File Offset: 0x0000290F
		public WordWrapState m_SavedLastValidState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_SavedLastValidState);
				return new WordWrapState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_SavedLastValidState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x0001243C File Offset: 0x0001063C
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x0000473D File Offset: 0x0000293D
		public WordWrapState m_SavedSoftLineBreakState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_SavedSoftLineBreakState);
				return new WordWrapState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_SavedSoftLineBreakState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x0001246C File Offset: 0x0001066C
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x0000476B File Offset: 0x0000296B
		public unsafe TextElementType m_TextElementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_TextElementType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_TextElementType)) = value;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00012494 File Offset: 0x00010694
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x00004786 File Offset: 0x00002986
		public unsafe bool m_isTextLayoutPhase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_isTextLayoutPhase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_isTextLayoutPhase)) = value;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x000124BC File Offset: 0x000106BC
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x000047A1 File Offset: 0x000029A1
		public unsafe int m_SpriteIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_SpriteIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_SpriteIndex)) = value;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x000124E4 File Offset: 0x000106E4
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x000047BC File Offset: 0x000029BC
		public unsafe Color32 m_SpriteColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_SpriteColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_SpriteColor)) = value;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x0001250C File Offset: 0x0001070C
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x000047D7 File Offset: 0x000029D7
		public unsafe TextElement m_CachedTextElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_CachedTextElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_CachedTextElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0001253C File Offset: 0x0001073C
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x000047F6 File Offset: 0x000029F6
		public unsafe Color32 m_HighlightColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_HighlightColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_HighlightColor)) = value;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x00012564 File Offset: 0x00010764
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x00004811 File Offset: 0x00002A11
		public unsafe float m_CharWidthAdjDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_CharWidthAdjDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_CharWidthAdjDelta)) = value;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x0001258C File Offset: 0x0001078C
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x0000482C File Offset: 0x00002A2C
		public unsafe float m_MaxFontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MaxFontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MaxFontSize)) = value;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x000125B4 File Offset: 0x000107B4
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x00004847 File Offset: 0x00002A47
		public unsafe float m_MinFontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MinFontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MinFontSize)) = value;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x000125DC File Offset: 0x000107DC
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x00004862 File Offset: 0x00002A62
		public unsafe int m_AutoSizeIterationCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_AutoSizeIterationCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_AutoSizeIterationCount)) = value;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x00012604 File Offset: 0x00010804
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x0000487D File Offset: 0x00002A7D
		public unsafe int m_AutoSizeMaxIterationCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_AutoSizeMaxIterationCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_AutoSizeMaxIterationCount)) = value;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x0001262C File Offset: 0x0001082C
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x00004898 File Offset: 0x00002A98
		public unsafe bool m_IsAutoSizePointSizeSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_IsAutoSizePointSizeSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_IsAutoSizePointSizeSet)) = value;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00012654 File Offset: 0x00010854
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x000048B3 File Offset: 0x00002AB3
		public unsafe float m_StartOfLineAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_StartOfLineAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_StartOfLineAscender)) = value;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x0001267C File Offset: 0x0001087C
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x000048CE File Offset: 0x00002ACE
		public unsafe float m_LineSpacingDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LineSpacingDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LineSpacingDelta)) = value;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x000126A4 File Offset: 0x000108A4
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x000048E9 File Offset: 0x00002AE9
		public unsafe Il2CppReferenceArray<MaterialReference> m_MaterialReferences
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MaterialReferences);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MaterialReference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MaterialReferences), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x000126D4 File Offset: 0x000108D4
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x00004908 File Offset: 0x00002B08
		public unsafe int m_SpriteCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_SpriteCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_SpriteCount)) = value;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x000126FC File Offset: 0x000108FC
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x00004923 File Offset: 0x00002B23
		public TextProcessingStack<int> m_StyleStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_StyleStack);
				return new TextProcessingStack<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_StyleStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x0001272C File Offset: 0x0001092C
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x00004951 File Offset: 0x00002B51
		public TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_EllipsisInsertionCandidateStack);
				return new TextProcessingStack<WordWrapState>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingStack<WordWrapState>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_EllipsisInsertionCandidateStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextProcessingStack<WordWrapState>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x0001275C File Offset: 0x0001095C
		// (set) Token: 0x06000413 RID: 1043 RVA: 0x0000497F File Offset: 0x00002B7F
		public unsafe int m_SpriteAnimationId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_SpriteAnimationId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_SpriteAnimationId)) = value;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x00012784 File Offset: 0x00010984
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x0000499A File Offset: 0x00002B9A
		public unsafe int m_ItalicAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_ItalicAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_ItalicAngle)) = value;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x000127AC File Offset: 0x000109AC
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x000049B5 File Offset: 0x00002BB5
		public unsafe Vector3 m_FXScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_FXScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_FXScale)) = value;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x000127D4 File Offset: 0x000109D4
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x000049D0 File Offset: 0x00002BD0
		public unsafe Quaternion m_FXRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_FXRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_FXRotation)) = value;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x000127FC File Offset: 0x000109FC
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x000049EB File Offset: 0x00002BEB
		public unsafe int m_LastBaseGlyphIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LastBaseGlyphIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_LastBaseGlyphIndex)) = value;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x00012824 File Offset: 0x00010A24
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x00004A06 File Offset: 0x00002C06
		public unsafe float m_PageAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_PageAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_PageAscender)) = value;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x0001284C File Offset: 0x00010A4C
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x00004A21 File Offset: 0x00002C21
		public unsafe Il2CppStructArray<RichTextTagAttribute> m_XmlAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_XmlAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RichTextTagAttribute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_XmlAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x0001287C File Offset: 0x00010A7C
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x00004A40 File Offset: 0x00002C40
		public unsafe Il2CppStructArray<float> m_AttributeParameterValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_AttributeParameterValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_AttributeParameterValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x000128AC File Offset: 0x00010AAC
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x00004A5F File Offset: 0x00002C5F
		public unsafe Dictionary<int, int> m_MaterialReferenceIndexLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MaterialReferenceIndexLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_MaterialReferenceIndexLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x000128DC File Offset: 0x00010ADC
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x00004A7E File Offset: 0x00002C7E
		public unsafe bool m_IsCalculatingPreferredValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_IsCalculatingPreferredValues);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_IsCalculatingPreferredValues)) = value;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x00012904 File Offset: 0x00010B04
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x00004A99 File Offset: 0x00002C99
		public unsafe SpriteAsset m_DefaultSpriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_DefaultSpriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_DefaultSpriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x00012934 File Offset: 0x00010B34
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x00004AB8 File Offset: 0x00002CB8
		public unsafe bool m_TintSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_TintSprite);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_TintSprite)) = value;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x0001295C File Offset: 0x00010B5C
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x00004AD3 File Offset: 0x00002CD3
		public TextGenerator.SpecialCharacter m_Ellipsis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_Ellipsis);
				return new TextGenerator.SpecialCharacter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextGenerator.SpecialCharacter>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_Ellipsis), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextGenerator.SpecialCharacter>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x0001298C File Offset: 0x00010B8C
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x00004B01 File Offset: 0x00002D01
		public TextGenerator.SpecialCharacter m_Underline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_Underline);
				return new TextGenerator.SpecialCharacter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextGenerator.SpecialCharacter>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_Underline), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextGenerator.SpecialCharacter>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x000129BC File Offset: 0x00010BBC
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x00004B2F File Offset: 0x00002D2F
		public unsafe Il2CppReferenceArray<TextElementInfo> m_InternalTextElementInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_InternalTextElementInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextElementInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.NativeFieldInfoPtr_m_InternalTextElementInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x000129EC File Offset: 0x00010BEC
		public static Vector2 GetCursorPosition(TextGenerationSettings settings, int index)
		{
			bool flag = settings.fontAsset == null || settings.fontAsset.characterLookupTable == null;
			Vector2 vector;
			if (flag)
			{
				Debug.LogWarning("Can't Generate Mesh, No Font Asset has been assigned.");
				vector = Vector2.zero;
			}
			else
			{
				TextInfo textInfo = new TextInfo();
				TextGenerator.GenerateText(settings, textInfo);
				vector = TextGenerator.GetCursorPosition(textInfo, settings.screenRect, index, true);
			}
			return vector;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00012A54 File Offset: 0x00010C54
		public static Vector2 GetCursorPosition(TextInfo textInfo, Rect screenRect, int index, [Optional] bool inverseYAxis)
		{
			Vector2 vector = screenRect.position;
			bool flag = textInfo.characterCount == 0;
			Vector2 vector2;
			if (flag)
			{
				vector2 = vector;
			}
			else
			{
				TextElementInfo textElementInfo = textInfo.textElementInfo[textInfo.characterCount - 1];
				LineInfo lineInfo = textInfo.lineInfo[textElementInfo.lineNumber];
				float num = lineInfo.lineHeight - (lineInfo.ascender - lineInfo.descender);
				bool flag2 = index >= textInfo.characterCount;
				if (flag2)
				{
					vector += (inverseYAxis ? new Vector2(textElementInfo.xAdvance, screenRect.height - lineInfo.ascender - num) : new Vector2(textElementInfo.xAdvance, lineInfo.descender));
					vector2 = vector;
				}
				else
				{
					textElementInfo = textInfo.textElementInfo[index];
					lineInfo = textInfo.lineInfo[textElementInfo.lineNumber];
					num = lineInfo.lineHeight - (lineInfo.ascender - lineInfo.descender);
					vector += (inverseYAxis ? new Vector2(textElementInfo.origin, screenRect.height - lineInfo.ascender - num) : new Vector2(textElementInfo.origin, lineInfo.descender));
					vector2 = vector;
				}
			}
			return vector2;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00012B80 File Offset: 0x00010D80
		public static float GetPreferredWidth(TextGenerationSettings settings, TextInfo textInfo)
		{
			bool flag = settings.fontAsset == null || settings.fontAsset.characterLookupTable == null;
			float num;
			if (flag)
			{
				Debug.LogWarning("Can't Generate Mesh, No Font Asset has been assigned.");
				num = 0f;
			}
			else
			{
				TextGenerator textGenerator = TextGenerator.GetTextGenerator();
				textGenerator.Prepare(settings, textInfo);
				num = textGenerator.GetPreferredWidthInternal(settings, textInfo);
			}
			return num;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00012BE0 File Offset: 0x00010DE0
		public static float GetPreferredHeight(TextGenerationSettings settings, TextInfo textInfo)
		{
			bool flag = settings.fontAsset == null || settings.fontAsset.characterLookupTable == null;
			float num;
			if (flag)
			{
				Debug.LogWarning("Can't Generate Mesh, No Font Asset has been assigned.");
				num = 0f;
			}
			else
			{
				TextGenerator textGenerator = TextGenerator.GetTextGenerator();
				textGenerator.Prepare(settings, textInfo);
				num = textGenerator.GetPreferredHeightInternal(settings, textInfo);
			}
			return num;
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x00012C40 File Offset: 0x00010E40
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x00004B4E File Offset: 0x00002D4E
		public bool vertexBufferAutoSizeReduction
		{
			get
			{
				return this.m_VertexBufferAutoSizeReduction;
			}
			set
			{
				this.m_VertexBufferAutoSizeReduction = value;
			}
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00004B58 File Offset: 0x00002D58
		public static void add_OnMissingCharacter(TextGenerator.MissingCharacterEventCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00004B65 File Offset: 0x00002D65
		public static void remove_OnMissingCharacter(TextGenerator.MissingCharacterEventCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00012C58 File Offset: 0x00010E58
		public float GetPreferredWidthInternal(TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			bool flag = generationSettings.textSettings == null;
			float num;
			if (flag)
			{
				num = 0f;
			}
			else
			{
				float num2 = (generationSettings.autoSize ? generationSettings.fontSizeMax : this.m_FontSize);
				this.m_MinFontSize = generationSettings.fontSizeMin;
				this.m_MaxFontSize = generationSettings.fontSizeMax;
				this.m_CharWidthAdjDelta = 0f;
				Vector2 largePositiveVector = TextGeneratorUtilities.largePositiveVector2;
				TextWrappingMode textWrappingMode = (generationSettings.wordWrap ? TextWrappingMode.NoWrap : TextWrappingMode.PreserveWhitespaceNoWrap);
				this.m_AutoSizeIterationCount = 0;
				float x = this.CalculatePreferredValues(ref num2, largePositiveVector, true, textWrappingMode, generationSettings, textInfo).x;
				num = x;
			}
			return num;
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00012CF0 File Offset: 0x00010EF0
		public float GetPreferredHeightInternal(TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			bool flag = generationSettings.textSettings == null;
			float num;
			if (flag)
			{
				num = 0f;
			}
			else
			{
				float num2 = (generationSettings.autoSize ? generationSettings.fontSizeMax : this.m_FontSize);
				this.m_MinFontSize = generationSettings.fontSizeMin;
				this.m_MaxFontSize = generationSettings.fontSizeMax;
				this.m_CharWidthAdjDelta = 0f;
				Vector2 vector = new Vector2((this.m_MarginWidth != 0f) ? this.m_MarginWidth : 32767f, 32767f);
				this.m_IsAutoSizePointSizeSet = false;
				this.m_AutoSizeIterationCount = 0;
				float num3 = 0f;
				TextWrappingMode textWrappingMode = (generationSettings.wordWrap ? TextWrappingMode.Normal : TextWrappingMode.NoWrap);
				while (!this.m_IsAutoSizePointSizeSet)
				{
					num3 = this.CalculatePreferredValues(ref num2, vector, generationSettings.autoSize, textWrappingMode, generationSettings, textInfo).y;
					this.m_AutoSizeIterationCount++;
				}
				num = num3;
			}
			return num;
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00004B72 File Offset: 0x00002D72
		public void PopulateTextBackingArray(StringBuilder sourceText, int start, int length)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00004B7F File Offset: 0x00002D7F
		public void PopulateTextBackingArray(Il2CppStructArray<char> sourceText, int start, int length)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeFieldInfoPtr_s_TextGenerator;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeFieldInfoPtr_m_TextBackingArray;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeFieldInfoPtr_m_TextProcessingArray;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalTextProcessingArraySize;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeFieldInfoPtr_m_VertexBufferAutoSizeReduction;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeFieldInfoPtr_m_HtmlTag;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeFieldInfoPtr_m_HighlightState;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeFieldInfoPtr_m_IsIgnoringAlignment;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeFieldInfoPtr_m_IsTextTruncated;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeFieldInfoPtr_OnMissingCharacter;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeFieldInfoPtr_m_RectTransformCorners;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeFieldInfoPtr_m_MarginWidth;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeFieldInfoPtr_m_MarginHeight;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeFieldInfoPtr_m_PreferredWidth;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeFieldInfoPtr_m_PreferredHeight;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentFontAsset;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentMaterial;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentMaterialIndex;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeFieldInfoPtr_m_MaterialReferenceStack;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeFieldInfoPtr_m_Padding;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentSpriteAsset;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeFieldInfoPtr_m_TotalCharacterCount;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeFieldInfoPtr_m_FontSize;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeFieldInfoPtr_m_FontScaleMultiplier;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentFontSize;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeFieldInfoPtr_m_SizeStack;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeFieldInfoPtr_m_TextStyleStacks;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeFieldInfoPtr_m_TextStyleStackDepth;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeFieldInfoPtr_m_FontStyleInternal;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeFieldInfoPtr_m_FontStyleStack;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeFieldInfoPtr_m_FontWeightInternal;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeFieldInfoPtr_m_FontWeightStack;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeFieldInfoPtr_m_LineJustification;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeFieldInfoPtr_m_LineJustificationStack;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeFieldInfoPtr_m_BaselineOffset;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeFieldInfoPtr_m_BaselineOffsetStack;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeFieldInfoPtr_m_FontColor32;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeFieldInfoPtr_m_HtmlColor;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeFieldInfoPtr_m_UnderlineColor;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeFieldInfoPtr_m_StrikethroughColor;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorStack;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeFieldInfoPtr_m_UnderlineColorStack;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeFieldInfoPtr_m_StrikethroughColorStack;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeFieldInfoPtr_m_HighlightColorStack;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeFieldInfoPtr_m_HighlightStateStack;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeFieldInfoPtr_m_ItalicAngleStack;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorGradientPreset;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorGradientStack;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorGradientPresetIsTinted;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeFieldInfoPtr_m_ActionStack;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeFieldInfoPtr_m_LineOffset;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeFieldInfoPtr_m_LineHeight;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeFieldInfoPtr_m_IsDrivenLineSpacing;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeFieldInfoPtr_m_CSpacing;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeFieldInfoPtr_m_MonoSpacing;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeFieldInfoPtr_m_XAdvance;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeFieldInfoPtr_m_TagLineIndent;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeFieldInfoPtr_m_TagIndent;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeFieldInfoPtr_m_IndentStack;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeFieldInfoPtr_m_TagNoParsing;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeFieldInfoPtr_m_CharacterCount;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstCharacterOfLine;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeFieldInfoPtr_m_LastCharacterOfLine;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstVisibleCharacterOfLine;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeFieldInfoPtr_m_LastVisibleCharacterOfLine;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxLineAscender;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxLineDescender;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeFieldInfoPtr_m_LineNumber;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeFieldInfoPtr_m_LineVisibleCharacterCount;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeFieldInfoPtr_m_LineVisibleSpaceCount;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstOverflowCharacterIndex;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeFieldInfoPtr_m_PageNumber;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeFieldInfoPtr_m_MarginLeft;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeFieldInfoPtr_m_MarginRight;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeFieldInfoPtr_m_Width;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeFieldInfoPtr_m_MeshExtents;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxCapHeight;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxAscender;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxDescender;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeFieldInfoPtr_m_IsNewPage;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeFieldInfoPtr_m_IsNonBreakingSpace;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeFieldInfoPtr_m_SavedWordWrapState;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeFieldInfoPtr_m_SavedLineState;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeFieldInfoPtr_m_SavedEllipsisState;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeFieldInfoPtr_m_SavedLastValidState;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeFieldInfoPtr_m_SavedSoftLineBreakState;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeFieldInfoPtr_m_TextElementType;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeFieldInfoPtr_m_isTextLayoutPhase;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteIndex;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteColor;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedTextElement;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeFieldInfoPtr_m_HighlightColor;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeFieldInfoPtr_m_CharWidthAdjDelta;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxFontSize;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeFieldInfoPtr_m_MinFontSize;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeFieldInfoPtr_m_AutoSizeIterationCount;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeFieldInfoPtr_m_AutoSizeMaxIterationCount;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeFieldInfoPtr_m_IsAutoSizePointSizeSet;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeFieldInfoPtr_m_StartOfLineAscender;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeFieldInfoPtr_m_LineSpacingDelta;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeFieldInfoPtr_m_MaterialReferences;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteCount;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeFieldInfoPtr_m_StyleStack;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeFieldInfoPtr_m_EllipsisInsertionCandidateStack;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteAnimationId;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeFieldInfoPtr_m_ItalicAngle;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeFieldInfoPtr_m_FXScale;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeFieldInfoPtr_m_FXRotation;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeFieldInfoPtr_m_LastBaseGlyphIndex;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeFieldInfoPtr_m_PageAscender;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeFieldInfoPtr_m_XmlAttribute;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeFieldInfoPtr_m_AttributeParameterValues;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeFieldInfoPtr_m_MaterialReferenceIndexLookup;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeFieldInfoPtr_m_IsCalculatingPreferredValues;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultSpriteAsset;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeFieldInfoPtr_m_TintSprite;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeFieldInfoPtr_m_Ellipsis;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeFieldInfoPtr_m_Underline;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalTextElementInfo;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeMethodInfoPtr_GetTextGenerator_Private_Static_TextGenerator_0;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeMethodInfoPtr_GenerateText_Public_Static_Void_TextGenerationSettings_TextInfo_0;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredValues_Public_Static_Vector2_TextGenerationSettings_TextInfo_0;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeMethodInfoPtr_get_isTextTruncated_Public_Static_get_Boolean_0;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeMethodInfoPtr_Prepare_Private_Void_TextGenerationSettings_TextInfo_0;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_GenerateTextMesh_Private_Void_TextGenerationSettings_TextInfo_0;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr_SaveWordWrappingState_Private_Void_byref_WordWrapState_Int32_Int32_TextInfo_0;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr_RestoreWordWrappingState_Protected_Int32_byref_WordWrapState_TextInfo_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_ValidateHtmlTag_Protected_Boolean_Il2CppStructArray_1_TextProcessingElement_Int32_byref_Int32_TextGenerationSettings_TextInfo_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_SaveGlyphVertexInfo_Private_Void_Single_Single_Color32_TextGenerationSettings_TextInfo_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_SaveSpriteVertexInfo_Private_Void_Color32_TextGenerationSettings_TextInfo_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_DrawUnderlineMesh_Private_Void_Vector3_Vector3_Single_Single_Single_Single_Color32_TextGenerationSettings_TextInfo_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr_DrawTextHighlight_Private_Void_Vector3_Vector3_Color32_TextGenerationSettings_TextInfo_0;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr_ClearMesh_Private_Static_Void_Boolean_TextInfo_0;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr_SetArraySizes_Internal_Int32_Il2CppStructArray_1_TextProcessingElement_TextGenerationSettings_TextInfo_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr_GetTextElement_Internal_TextElement_TextGenerationSettings_UInt32_FontAsset_FontStyles_TextFontWeight_byref_Boolean_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_ComputeMarginSize_Private_Void_Rect_Vector4_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialCharacters_Protected_Void_TextGenerationSettings_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_GetEllipsisSpecialCharacter_Protected_Void_TextGenerationSettings_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_GetUnderlineSpecialCharacter_Protected_Void_TextGenerationSettings_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredValuesInternal_Private_Vector2_TextGenerationSettings_TextInfo_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_CalculatePreferredValues_Protected_Virtual_New_Vector2_byref_Single_Vector2_Boolean_TextWrappingMode_TextGenerationSettings_TextInfo_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_String_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_String_Int32_Int32_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr_PopulateTextProcessingArray_Private_Void_TextGenerationSettings_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_InsertNewLine_Private_Void_Int32_Single_Single_Single_Single_Single_Single_Single_byref_Boolean_byref_Single_TextGenerationSettings_TextInfo_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr_DoMissingGlyphCallback_Protected_Void_UInt32_Int32_FontAsset_TextInfo_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_ClearMarkupTagAttributes_Private_Void_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040002C1 RID: 705
		public const int k_Tab = 9;

		// Token: 0x040002C2 RID: 706
		public const int k_LineFeed = 10;

		// Token: 0x040002C3 RID: 707
		public const int k_CarriageReturn = 13;

		// Token: 0x040002C4 RID: 708
		public const int k_Space = 32;

		// Token: 0x040002C5 RID: 709
		public const int k_DoubleQuotes = 34;

		// Token: 0x040002C6 RID: 710
		public const int k_NumberSign = 35;

		// Token: 0x040002C7 RID: 711
		public const int k_PercentSign = 37;

		// Token: 0x040002C8 RID: 712
		public const int k_SingleQuote = 39;

		// Token: 0x040002C9 RID: 713
		public const int k_Plus = 43;

		// Token: 0x040002CA RID: 714
		public const int k_Minus = 45;

		// Token: 0x040002CB RID: 715
		public const int k_Period = 46;

		// Token: 0x040002CC RID: 716
		public const int k_LesserThan = 60;

		// Token: 0x040002CD RID: 717
		public const int k_Equal = 61;

		// Token: 0x040002CE RID: 718
		public const int k_GreaterThan = 62;

		// Token: 0x040002CF RID: 719
		public const int k_Underline = 95;

		// Token: 0x040002D0 RID: 720
		public const int k_NoBreakSpace = 160;

		// Token: 0x040002D1 RID: 721
		public const int k_SoftHyphen = 173;

		// Token: 0x040002D2 RID: 722
		public const int k_HyphenMinus = 45;

		// Token: 0x040002D3 RID: 723
		public const int k_FigureSpace = 8199;

		// Token: 0x040002D4 RID: 724
		public const int k_Hyphen = 8208;

		// Token: 0x040002D5 RID: 725
		public const int k_NonBreakingHyphen = 8209;

		// Token: 0x040002D6 RID: 726
		public const int k_ZeroWidthSpace = 8203;

		// Token: 0x040002D7 RID: 727
		public const int k_NarrowNoBreakSpace = 8239;

		// Token: 0x040002D8 RID: 728
		public const int k_WordJoiner = 8288;

		// Token: 0x040002D9 RID: 729
		public const int k_HorizontalEllipsis = 8230;

		// Token: 0x040002DA RID: 730
		public const int k_RightSingleQuote = 8217;

		// Token: 0x040002DB RID: 731
		public const int k_Square = 9633;

		// Token: 0x040002DC RID: 732
		public const int k_HangulJamoStart = 4352;

		// Token: 0x040002DD RID: 733
		public const int k_HangulJamoEnd = 4607;

		// Token: 0x040002DE RID: 734
		public const int k_CjkStart = 11904;

		// Token: 0x040002DF RID: 735
		public const int k_CjkEnd = 40959;

		// Token: 0x040002E0 RID: 736
		public const int k_HangulJameExtendedStart = 43360;

		// Token: 0x040002E1 RID: 737
		public const int k_HangulJameExtendedEnd = 43391;

		// Token: 0x040002E2 RID: 738
		public const int k_HangulSyllablesStart = 44032;

		// Token: 0x040002E3 RID: 739
		public const int k_HangulSyllablesEnd = 55295;

		// Token: 0x040002E4 RID: 740
		public const int k_CjkIdeographsStart = 63744;

		// Token: 0x040002E5 RID: 741
		public const int k_CjkIdeographsEnd = 64255;

		// Token: 0x040002E6 RID: 742
		public const int k_CjkFormsStart = 65072;

		// Token: 0x040002E7 RID: 743
		public const int k_CjkFormsEnd = 65103;

		// Token: 0x040002E8 RID: 744
		public const int k_CjkHalfwidthStart = 65280;

		// Token: 0x040002E9 RID: 745
		public const int k_CjkHalfwidthEnd = 65519;

		// Token: 0x040002EA RID: 746
		public const int k_EndOfText = 3;

		// Token: 0x040002EB RID: 747
		public const float k_FloatUnset = -32767f;

		// Token: 0x040002EC RID: 748
		public const int k_MaxCharacters = 8;

		// Token: 0x0200004B RID: 75
		public sealed class MissingCharacterEventCallback : MulticastDelegate
		{
			// Token: 0x06000749 RID: 1865 RVA: 0x000063EF File Offset: 0x000045EF
			// Note: this type is marked as 'beforefieldinit'.
			static MissingCharacterEventCallback()
			{
				Il2CppClassPointerStore<TextGenerator.MissingCharacterEventCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "MissingCharacterEventCallback");
				TextGenerator.MissingCharacterEventCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator.MissingCharacterEventCallback>.NativeClassPtr, 100663573);
				TextGenerator.MissingCharacterEventCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UInt32_Int32_TextInfo_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator.MissingCharacterEventCallback>.NativeClassPtr, 100663574);
			}

			// Token: 0x0600074A RID: 1866 RVA: 0x0001C500 File Offset: 0x0001A700
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102058, XrefRangeEnd = 1102061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MissingCharacterEventCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextGenerator.MissingCharacterEventCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.MissingCharacterEventCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600074B RID: 1867 RVA: 0x0001C55C File Offset: 0x0001A75C
			[CallerCount(0)]
			public unsafe void Invoke(uint unicode, int stringIndex, TextInfo text, FontAsset fontAsset)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref unicode;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stringIndex;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(text);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.MissingCharacterEventCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UInt32_Int32_TextInfo_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600074C RID: 1868 RVA: 0x0000642D File Offset: 0x0000462D
			public MissingCharacterEventCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600074D RID: 1869 RVA: 0x00006436 File Offset: 0x00004636
			public static implicit operator TextGenerator.MissingCharacterEventCallback(Action<uint, int, TextInfo, FontAsset> A_0)
			{
				return DelegateSupport.ConvertDelegate<TextGenerator.MissingCharacterEventCallback>(A_0);
			}

			// Token: 0x0600074E RID: 1870 RVA: 0x0000643E File Offset: 0x0000463E
			public static TextGenerator.MissingCharacterEventCallback operator +(TextGenerator.MissingCharacterEventCallback A_0, TextGenerator.MissingCharacterEventCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<TextGenerator.MissingCharacterEventCallback>();
			}

			// Token: 0x0600074F RID: 1871 RVA: 0x0000644C File Offset: 0x0000464C
			public static TextGenerator.MissingCharacterEventCallback operator -(TextGenerator.MissingCharacterEventCallback A_0, TextGenerator.MissingCharacterEventCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<TextGenerator.MissingCharacterEventCallback>();
				}
				return delegate2;
			}

			// Token: 0x040005F1 RID: 1521
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040005F2 RID: 1522
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UInt32_Int32_TextInfo_FontAsset_0;
		}

		// Token: 0x0200004C RID: 76
		public sealed class SpecialCharacter : ValueType
		{
			// Token: 0x06000750 RID: 1872 RVA: 0x0001C5D0 File Offset: 0x0001A7D0
			// Note: this type is marked as 'beforefieldinit'.
			static SpecialCharacter()
			{
				Il2CppClassPointerStore<TextGenerator.SpecialCharacter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextGenerator>.NativeClassPtr, "SpecialCharacter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextGenerator.SpecialCharacter>.NativeClassPtr);
				TextGenerator.SpecialCharacter.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator.SpecialCharacter>.NativeClassPtr, "character");
				TextGenerator.SpecialCharacter.NativeFieldInfoPtr_fontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator.SpecialCharacter>.NativeClassPtr, "fontAsset");
				TextGenerator.SpecialCharacter.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator.SpecialCharacter>.NativeClassPtr, "material");
				TextGenerator.SpecialCharacter.NativeFieldInfoPtr_materialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextGenerator.SpecialCharacter>.NativeClassPtr, "materialIndex");
				TextGenerator.SpecialCharacter.NativeMethodInfoPtr__ctor_Public_Void_Character_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextGenerator.SpecialCharacter>.NativeClassPtr, 100663575);
			}

			// Token: 0x06000751 RID: 1873 RVA: 0x0001C660 File Offset: 0x0001A860
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1102075, RefRangeEnd = 1102081, XrefRangeStart = 1102061, XrefRangeEnd = 1102075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpecialCharacter(Character character, int materialIndex)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextGenerator.SpecialCharacter>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref materialIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextGenerator.SpecialCharacter.NativeMethodInfoPtr__ctor_Public_Void_Character_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000752 RID: 1874 RVA: 0x0000645D File Offset: 0x0000465D
			public SpecialCharacter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000753 RID: 1875 RVA: 0x00006466 File Offset: 0x00004666
			public SpecialCharacter()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextGenerator.SpecialCharacter>.NativeClassPtr))
			{
			}

			// Token: 0x170002C0 RID: 704
			// (get) Token: 0x06000754 RID: 1876 RVA: 0x0001C6C0 File Offset: 0x0001A8C0
			// (set) Token: 0x06000755 RID: 1877 RVA: 0x00006478 File Offset: 0x00004678
			public unsafe Character character
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.SpecialCharacter.NativeFieldInfoPtr_character);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Character>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.SpecialCharacter.NativeFieldInfoPtr_character), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002C1 RID: 705
			// (get) Token: 0x06000756 RID: 1878 RVA: 0x0001C6F0 File Offset: 0x0001A8F0
			// (set) Token: 0x06000757 RID: 1879 RVA: 0x00006497 File Offset: 0x00004697
			public unsafe FontAsset fontAsset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.SpecialCharacter.NativeFieldInfoPtr_fontAsset);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FontAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.SpecialCharacter.NativeFieldInfoPtr_fontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002C2 RID: 706
			// (get) Token: 0x06000758 RID: 1880 RVA: 0x0001C720 File Offset: 0x0001A920
			// (set) Token: 0x06000759 RID: 1881 RVA: 0x000064B6 File Offset: 0x000046B6
			public unsafe Material material
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.SpecialCharacter.NativeFieldInfoPtr_material);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.SpecialCharacter.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002C3 RID: 707
			// (get) Token: 0x0600075A RID: 1882 RVA: 0x0001C750 File Offset: 0x0001A950
			// (set) Token: 0x0600075B RID: 1883 RVA: 0x000064D5 File Offset: 0x000046D5
			public unsafe int materialIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.SpecialCharacter.NativeFieldInfoPtr_materialIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextGenerator.SpecialCharacter.NativeFieldInfoPtr_materialIndex)) = value;
				}
			}

			// Token: 0x040005F3 RID: 1523
			private static readonly IntPtr NativeFieldInfoPtr_character;

			// Token: 0x040005F4 RID: 1524
			private static readonly IntPtr NativeFieldInfoPtr_fontAsset;

			// Token: 0x040005F5 RID: 1525
			private static readonly IntPtr NativeFieldInfoPtr_material;

			// Token: 0x040005F6 RID: 1526
			private static readonly IntPtr NativeFieldInfoPtr_materialIndex;

			// Token: 0x040005F7 RID: 1527
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Character_Int32_0;
		}
	}
}

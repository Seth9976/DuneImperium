using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x02000067 RID: 103
	public class TMP_Text : MaskableGraphic
	{
		// Token: 0x06000A7F RID: 2687 RVA: 0x0002C8A8 File Offset: 0x0002AAA8
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Text()
		{
			Il2CppClassPointerStore<TMP_Text>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Text");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr);
			TMP_Text.NativeFieldInfoPtr_m_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_text");
			TMP_Text.NativeFieldInfoPtr_m_IsTextBackingStringDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_IsTextBackingStringDirty");
			TMP_Text.NativeFieldInfoPtr_m_TextPreprocessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_TextPreprocessor");
			TMP_Text.NativeFieldInfoPtr_m_isRightToLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isRightToLeft");
			TMP_Text.NativeFieldInfoPtr_m_fontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontAsset");
			TMP_Text.NativeFieldInfoPtr_m_currentFontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_currentFontAsset");
			TMP_Text.NativeFieldInfoPtr_m_isSDFShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isSDFShader");
			TMP_Text.NativeFieldInfoPtr_m_sharedMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_sharedMaterial");
			TMP_Text.NativeFieldInfoPtr_m_currentMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_currentMaterial");
			TMP_Text.NativeFieldInfoPtr_m_materialReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_materialReferences");
			TMP_Text.NativeFieldInfoPtr_m_materialReferenceIndexLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_materialReferenceIndexLookup");
			TMP_Text.NativeFieldInfoPtr_m_materialReferenceStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_materialReferenceStack");
			TMP_Text.NativeFieldInfoPtr_m_currentMaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_currentMaterialIndex");
			TMP_Text.NativeFieldInfoPtr_m_fontSharedMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontSharedMaterials");
			TMP_Text.NativeFieldInfoPtr_m_fontMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontMaterial");
			TMP_Text.NativeFieldInfoPtr_m_fontMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontMaterials");
			TMP_Text.NativeFieldInfoPtr_m_isMaterialDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isMaterialDirty");
			TMP_Text.NativeFieldInfoPtr_m_fontColor32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontColor32");
			TMP_Text.NativeFieldInfoPtr_m_fontColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontColor");
			TMP_Text.NativeFieldInfoPtr_s_colorWhite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "s_colorWhite");
			TMP_Text.NativeFieldInfoPtr_m_underlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_underlineColor");
			TMP_Text.NativeFieldInfoPtr_m_strikethroughColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_strikethroughColor");
			TMP_Text.NativeFieldInfoPtr_m_enableVertexGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_enableVertexGradient");
			TMP_Text.NativeFieldInfoPtr_m_colorMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_colorMode");
			TMP_Text.NativeFieldInfoPtr_m_fontColorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontColorGradient");
			TMP_Text.NativeFieldInfoPtr_m_fontColorGradientPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontColorGradientPreset");
			TMP_Text.NativeFieldInfoPtr_m_spriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_spriteAsset");
			TMP_Text.NativeFieldInfoPtr_m_tintAllSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_tintAllSprites");
			TMP_Text.NativeFieldInfoPtr_m_tintSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_tintSprite");
			TMP_Text.NativeFieldInfoPtr_m_spriteColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_spriteColor");
			TMP_Text.NativeFieldInfoPtr_m_StyleSheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_StyleSheet");
			TMP_Text.NativeFieldInfoPtr_m_TextStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_TextStyle");
			TMP_Text.NativeFieldInfoPtr_m_TextStyleHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_TextStyleHashCode");
			TMP_Text.NativeFieldInfoPtr_m_overrideHtmlColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_overrideHtmlColors");
			TMP_Text.NativeFieldInfoPtr_m_faceColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_faceColor");
			TMP_Text.NativeFieldInfoPtr_m_outlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_outlineColor");
			TMP_Text.NativeFieldInfoPtr_m_outlineWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_outlineWidth");
			TMP_Text.NativeFieldInfoPtr_m_fontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontSize");
			TMP_Text.NativeFieldInfoPtr_m_currentFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_currentFontSize");
			TMP_Text.NativeFieldInfoPtr_m_fontSizeBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontSizeBase");
			TMP_Text.NativeFieldInfoPtr_m_sizeStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_sizeStack");
			TMP_Text.NativeFieldInfoPtr_m_fontWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontWeight");
			TMP_Text.NativeFieldInfoPtr_m_FontWeightInternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_FontWeightInternal");
			TMP_Text.NativeFieldInfoPtr_m_FontWeightStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_FontWeightStack");
			TMP_Text.NativeFieldInfoPtr_m_enableAutoSizing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_enableAutoSizing");
			TMP_Text.NativeFieldInfoPtr_m_maxFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxFontSize");
			TMP_Text.NativeFieldInfoPtr_m_minFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_minFontSize");
			TMP_Text.NativeFieldInfoPtr_m_AutoSizeIterationCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_AutoSizeIterationCount");
			TMP_Text.NativeFieldInfoPtr_m_AutoSizeMaxIterationCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_AutoSizeMaxIterationCount");
			TMP_Text.NativeFieldInfoPtr_m_IsAutoSizePointSizeSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_IsAutoSizePointSizeSet");
			TMP_Text.NativeFieldInfoPtr_m_fontSizeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontSizeMin");
			TMP_Text.NativeFieldInfoPtr_m_fontSizeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontSizeMax");
			TMP_Text.NativeFieldInfoPtr_m_fontStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontStyle");
			TMP_Text.NativeFieldInfoPtr_m_FontStyleInternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_FontStyleInternal");
			TMP_Text.NativeFieldInfoPtr_m_fontStyleStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontStyleStack");
			TMP_Text.NativeFieldInfoPtr_m_isUsingBold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isUsingBold");
			TMP_Text.NativeFieldInfoPtr_m_HorizontalAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_HorizontalAlignment");
			TMP_Text.NativeFieldInfoPtr_m_VerticalAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_VerticalAlignment");
			TMP_Text.NativeFieldInfoPtr_m_textAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_textAlignment");
			TMP_Text.NativeFieldInfoPtr_m_lineJustification = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lineJustification");
			TMP_Text.NativeFieldInfoPtr_m_lineJustificationStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lineJustificationStack");
			TMP_Text.NativeFieldInfoPtr_m_textContainerLocalCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_textContainerLocalCorners");
			TMP_Text.NativeFieldInfoPtr_m_characterSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_characterSpacing");
			TMP_Text.NativeFieldInfoPtr_m_cSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_cSpacing");
			TMP_Text.NativeFieldInfoPtr_m_monoSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_monoSpacing");
			TMP_Text.NativeFieldInfoPtr_m_wordSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_wordSpacing");
			TMP_Text.NativeFieldInfoPtr_m_lineSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lineSpacing");
			TMP_Text.NativeFieldInfoPtr_m_lineSpacingDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lineSpacingDelta");
			TMP_Text.NativeFieldInfoPtr_m_lineHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lineHeight");
			TMP_Text.NativeFieldInfoPtr_m_IsDrivenLineSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_IsDrivenLineSpacing");
			TMP_Text.NativeFieldInfoPtr_m_lineSpacingMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lineSpacingMax");
			TMP_Text.NativeFieldInfoPtr_m_paragraphSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_paragraphSpacing");
			TMP_Text.NativeFieldInfoPtr_m_charWidthMaxAdj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_charWidthMaxAdj");
			TMP_Text.NativeFieldInfoPtr_m_charWidthAdjDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_charWidthAdjDelta");
			TMP_Text.NativeFieldInfoPtr_m_enableWordWrapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_enableWordWrapping");
			TMP_Text.NativeFieldInfoPtr_m_isCharacterWrappingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isCharacterWrappingEnabled");
			TMP_Text.NativeFieldInfoPtr_m_isNonBreakingSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isNonBreakingSpace");
			TMP_Text.NativeFieldInfoPtr_m_isIgnoringAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isIgnoringAlignment");
			TMP_Text.NativeFieldInfoPtr_m_wordWrappingRatios = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_wordWrappingRatios");
			TMP_Text.NativeFieldInfoPtr_m_overflowMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_overflowMode");
			TMP_Text.NativeFieldInfoPtr_m_firstOverflowCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_firstOverflowCharacterIndex");
			TMP_Text.NativeFieldInfoPtr_m_linkedTextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_linkedTextComponent");
			TMP_Text.NativeFieldInfoPtr_parentLinkedComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "parentLinkedComponent");
			TMP_Text.NativeFieldInfoPtr_m_isTextTruncated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isTextTruncated");
			TMP_Text.NativeFieldInfoPtr_m_enableKerning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_enableKerning");
			TMP_Text.NativeFieldInfoPtr_m_GlyphHorizontalAdvanceAdjustment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_GlyphHorizontalAdvanceAdjustment");
			TMP_Text.NativeFieldInfoPtr_m_enableExtraPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_enableExtraPadding");
			TMP_Text.NativeFieldInfoPtr_checkPaddingRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "checkPaddingRequired");
			TMP_Text.NativeFieldInfoPtr_m_isRichText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isRichText");
			TMP_Text.NativeFieldInfoPtr_m_parseCtrlCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_parseCtrlCharacters");
			TMP_Text.NativeFieldInfoPtr_m_isOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isOverlay");
			TMP_Text.NativeFieldInfoPtr_m_isOrthographic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isOrthographic");
			TMP_Text.NativeFieldInfoPtr_m_isCullingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isCullingEnabled");
			TMP_Text.NativeFieldInfoPtr_m_isMaskingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isMaskingEnabled");
			TMP_Text.NativeFieldInfoPtr_isMaskUpdateRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "isMaskUpdateRequired");
			TMP_Text.NativeFieldInfoPtr_m_ignoreCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_ignoreCulling");
			TMP_Text.NativeFieldInfoPtr_m_horizontalMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_horizontalMapping");
			TMP_Text.NativeFieldInfoPtr_m_verticalMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_verticalMapping");
			TMP_Text.NativeFieldInfoPtr_m_uvLineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_uvLineOffset");
			TMP_Text.NativeFieldInfoPtr_m_renderMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_renderMode");
			TMP_Text.NativeFieldInfoPtr_m_geometrySortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_geometrySortingOrder");
			TMP_Text.NativeFieldInfoPtr_m_IsTextObjectScaleStatic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_IsTextObjectScaleStatic");
			TMP_Text.NativeFieldInfoPtr_m_VertexBufferAutoSizeReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_VertexBufferAutoSizeReduction");
			TMP_Text.NativeFieldInfoPtr_m_firstVisibleCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_firstVisibleCharacter");
			TMP_Text.NativeFieldInfoPtr_m_maxVisibleCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxVisibleCharacters");
			TMP_Text.NativeFieldInfoPtr_m_maxVisibleWords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxVisibleWords");
			TMP_Text.NativeFieldInfoPtr_m_maxVisibleLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxVisibleLines");
			TMP_Text.NativeFieldInfoPtr_m_useMaxVisibleDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_useMaxVisibleDescender");
			TMP_Text.NativeFieldInfoPtr_m_pageToDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_pageToDisplay");
			TMP_Text.NativeFieldInfoPtr_m_isNewPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isNewPage");
			TMP_Text.NativeFieldInfoPtr_m_margin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_margin");
			TMP_Text.NativeFieldInfoPtr_m_marginLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_marginLeft");
			TMP_Text.NativeFieldInfoPtr_m_marginRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_marginRight");
			TMP_Text.NativeFieldInfoPtr_m_marginWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_marginWidth");
			TMP_Text.NativeFieldInfoPtr_m_marginHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_marginHeight");
			TMP_Text.NativeFieldInfoPtr_m_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_width");
			TMP_Text.NativeFieldInfoPtr_m_textInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_textInfo");
			TMP_Text.NativeFieldInfoPtr_m_havePropertiesChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_havePropertiesChanged");
			TMP_Text.NativeFieldInfoPtr_m_isUsingLegacyAnimationComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isUsingLegacyAnimationComponent");
			TMP_Text.NativeFieldInfoPtr_m_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_transform");
			TMP_Text.NativeFieldInfoPtr_m_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_rectTransform");
			TMP_Text.NativeFieldInfoPtr_m_PreviousRectTransformSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_PreviousRectTransformSize");
			TMP_Text.NativeFieldInfoPtr_m_PreviousPivotPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_PreviousPivotPosition");
			TMP_Text.NativeFieldInfoPtr__autoSizeTextContainer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "<autoSizeTextContainer>k__BackingField");
			TMP_Text.NativeFieldInfoPtr_m_autoSizeTextContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_autoSizeTextContainer");
			TMP_Text.NativeFieldInfoPtr_m_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_mesh");
			TMP_Text.NativeFieldInfoPtr_m_isVolumetricText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isVolumetricText");
			TMP_Text.NativeFieldInfoPtr_OnFontAssetRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "OnFontAssetRequest");
			TMP_Text.NativeFieldInfoPtr_OnSpriteAssetRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "OnSpriteAssetRequest");
			TMP_Text.NativeFieldInfoPtr_OnPreRenderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "OnPreRenderText");
			TMP_Text.NativeFieldInfoPtr_m_spriteAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_spriteAnimator");
			TMP_Text.NativeFieldInfoPtr_m_flexibleHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_flexibleHeight");
			TMP_Text.NativeFieldInfoPtr_m_flexibleWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_flexibleWidth");
			TMP_Text.NativeFieldInfoPtr_m_minWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_minWidth");
			TMP_Text.NativeFieldInfoPtr_m_minHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_minHeight");
			TMP_Text.NativeFieldInfoPtr_m_maxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxWidth");
			TMP_Text.NativeFieldInfoPtr_m_maxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxHeight");
			TMP_Text.NativeFieldInfoPtr_m_LayoutElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_LayoutElement");
			TMP_Text.NativeFieldInfoPtr_m_preferredWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_preferredWidth");
			TMP_Text.NativeFieldInfoPtr_m_renderedWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_renderedWidth");
			TMP_Text.NativeFieldInfoPtr_m_isPreferredWidthDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isPreferredWidthDirty");
			TMP_Text.NativeFieldInfoPtr_m_preferredHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_preferredHeight");
			TMP_Text.NativeFieldInfoPtr_m_renderedHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_renderedHeight");
			TMP_Text.NativeFieldInfoPtr_m_isPreferredHeightDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isPreferredHeightDirty");
			TMP_Text.NativeFieldInfoPtr_m_isCalculatingPreferredValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isCalculatingPreferredValues");
			TMP_Text.NativeFieldInfoPtr_m_layoutPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_layoutPriority");
			TMP_Text.NativeFieldInfoPtr_m_isLayoutDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isLayoutDirty");
			TMP_Text.NativeFieldInfoPtr_m_isAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isAwake");
			TMP_Text.NativeFieldInfoPtr_m_isWaitingOnResourceLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isWaitingOnResourceLoad");
			TMP_Text.NativeFieldInfoPtr_m_inputSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_inputSource");
			TMP_Text.NativeFieldInfoPtr_m_fontScaleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_fontScaleMultiplier");
			TMP_Text.NativeFieldInfoPtr_m_htmlTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_htmlTag");
			TMP_Text.NativeFieldInfoPtr_m_xmlAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_xmlAttribute");
			TMP_Text.NativeFieldInfoPtr_m_attributeParameterValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_attributeParameterValues");
			TMP_Text.NativeFieldInfoPtr_tag_LineIndent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "tag_LineIndent");
			TMP_Text.NativeFieldInfoPtr_tag_Indent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "tag_Indent");
			TMP_Text.NativeFieldInfoPtr_m_indentStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_indentStack");
			TMP_Text.NativeFieldInfoPtr_tag_NoParsing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "tag_NoParsing");
			TMP_Text.NativeFieldInfoPtr_m_isParsingText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isParsingText");
			TMP_Text.NativeFieldInfoPtr_m_FXMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_FXMatrix");
			TMP_Text.NativeFieldInfoPtr_m_isFXMatrixSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_isFXMatrixSet");
			TMP_Text.NativeFieldInfoPtr_m_TextProcessingArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_TextProcessingArray");
			TMP_Text.NativeFieldInfoPtr_m_InternalTextProcessingArraySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_InternalTextProcessingArraySize");
			TMP_Text.NativeFieldInfoPtr_m_internalCharacterInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_internalCharacterInfo");
			TMP_Text.NativeFieldInfoPtr_m_totalCharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_totalCharacterCount");
			TMP_Text.NativeFieldInfoPtr_m_SavedWordWrapState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_SavedWordWrapState");
			TMP_Text.NativeFieldInfoPtr_m_SavedLineState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_SavedLineState");
			TMP_Text.NativeFieldInfoPtr_m_SavedEllipsisState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_SavedEllipsisState");
			TMP_Text.NativeFieldInfoPtr_m_SavedLastValidState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_SavedLastValidState");
			TMP_Text.NativeFieldInfoPtr_m_SavedSoftLineBreakState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_SavedSoftLineBreakState");
			TMP_Text.NativeFieldInfoPtr_m_EllipsisInsertionCandidateStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_EllipsisInsertionCandidateStack");
			TMP_Text.NativeFieldInfoPtr_m_characterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_characterCount");
			TMP_Text.NativeFieldInfoPtr_m_firstCharacterOfLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_firstCharacterOfLine");
			TMP_Text.NativeFieldInfoPtr_m_firstVisibleCharacterOfLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_firstVisibleCharacterOfLine");
			TMP_Text.NativeFieldInfoPtr_m_lastCharacterOfLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lastCharacterOfLine");
			TMP_Text.NativeFieldInfoPtr_m_lastVisibleCharacterOfLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lastVisibleCharacterOfLine");
			TMP_Text.NativeFieldInfoPtr_m_lineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lineNumber");
			TMP_Text.NativeFieldInfoPtr_m_lineVisibleCharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lineVisibleCharacterCount");
			TMP_Text.NativeFieldInfoPtr_m_pageNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_pageNumber");
			TMP_Text.NativeFieldInfoPtr_m_PageAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_PageAscender");
			TMP_Text.NativeFieldInfoPtr_m_maxTextAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxTextAscender");
			TMP_Text.NativeFieldInfoPtr_m_maxCapHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxCapHeight");
			TMP_Text.NativeFieldInfoPtr_m_ElementAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_ElementAscender");
			TMP_Text.NativeFieldInfoPtr_m_ElementDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_ElementDescender");
			TMP_Text.NativeFieldInfoPtr_m_maxLineAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxLineAscender");
			TMP_Text.NativeFieldInfoPtr_m_maxLineDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_maxLineDescender");
			TMP_Text.NativeFieldInfoPtr_m_startOfLineAscender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_startOfLineAscender");
			TMP_Text.NativeFieldInfoPtr_m_startOfLineDescender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_startOfLineDescender");
			TMP_Text.NativeFieldInfoPtr_m_lineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_lineOffset");
			TMP_Text.NativeFieldInfoPtr_m_meshExtents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_meshExtents");
			TMP_Text.NativeFieldInfoPtr_m_htmlColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_htmlColor");
			TMP_Text.NativeFieldInfoPtr_m_colorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_colorStack");
			TMP_Text.NativeFieldInfoPtr_m_underlineColorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_underlineColorStack");
			TMP_Text.NativeFieldInfoPtr_m_strikethroughColorStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_strikethroughColorStack");
			TMP_Text.NativeFieldInfoPtr_m_HighlightStateStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_HighlightStateStack");
			TMP_Text.NativeFieldInfoPtr_m_colorGradientPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_colorGradientPreset");
			TMP_Text.NativeFieldInfoPtr_m_colorGradientStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_colorGradientStack");
			TMP_Text.NativeFieldInfoPtr_m_colorGradientPresetIsTinted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_colorGradientPresetIsTinted");
			TMP_Text.NativeFieldInfoPtr_m_tabSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_tabSpacing");
			TMP_Text.NativeFieldInfoPtr_m_spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_spacing");
			TMP_Text.NativeFieldInfoPtr_m_TextStyleStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_TextStyleStacks");
			TMP_Text.NativeFieldInfoPtr_m_TextStyleStackDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_TextStyleStackDepth");
			TMP_Text.NativeFieldInfoPtr_m_ItalicAngleStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_ItalicAngleStack");
			TMP_Text.NativeFieldInfoPtr_m_ItalicAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_ItalicAngle");
			TMP_Text.NativeFieldInfoPtr_m_actionStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_actionStack");
			TMP_Text.NativeFieldInfoPtr_m_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_padding");
			TMP_Text.NativeFieldInfoPtr_m_baselineOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_baselineOffset");
			TMP_Text.NativeFieldInfoPtr_m_baselineOffsetStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_baselineOffsetStack");
			TMP_Text.NativeFieldInfoPtr_m_xAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_xAdvance");
			TMP_Text.NativeFieldInfoPtr_m_textElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_textElementType");
			TMP_Text.NativeFieldInfoPtr_m_cached_TextElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_cached_TextElement");
			TMP_Text.NativeFieldInfoPtr_m_Ellipsis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_Ellipsis");
			TMP_Text.NativeFieldInfoPtr_m_Underline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_Underline");
			TMP_Text.NativeFieldInfoPtr_m_defaultSpriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_defaultSpriteAsset");
			TMP_Text.NativeFieldInfoPtr_m_currentSpriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_currentSpriteAsset");
			TMP_Text.NativeFieldInfoPtr_m_spriteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_spriteCount");
			TMP_Text.NativeFieldInfoPtr_m_spriteIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_spriteIndex");
			TMP_Text.NativeFieldInfoPtr_m_spriteAnimationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_spriteAnimationID");
			TMP_Text.NativeFieldInfoPtr_k_ParseTextMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "k_ParseTextMarker");
			TMP_Text.NativeFieldInfoPtr_k_InsertNewLineMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "k_InsertNewLineMarker");
			TMP_Text.NativeFieldInfoPtr_m_ignoreActiveState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_ignoreActiveState");
			TMP_Text.NativeFieldInfoPtr_m_TextBackingArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "m_TextBackingArray");
			TMP_Text.NativeFieldInfoPtr_k_Power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "k_Power");
			TMP_Text.NativeFieldInfoPtr_k_LargePositiveVector2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "k_LargePositiveVector2");
			TMP_Text.NativeFieldInfoPtr_k_LargeNegativeVector2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "k_LargeNegativeVector2");
			TMP_Text.NativeFieldInfoPtr_k_LargePositiveFloat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "k_LargePositiveFloat");
			TMP_Text.NativeFieldInfoPtr_k_LargeNegativeFloat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "k_LargeNegativeFloat");
			TMP_Text.NativeFieldInfoPtr_k_LargePositiveInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "k_LargePositiveInt");
			TMP_Text.NativeFieldInfoPtr_k_LargeNegativeInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "k_LargeNegativeInt");
			TMP_Text.NativeMethodInfoPtr_get_text_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664485);
			TMP_Text.NativeMethodInfoPtr_set_text_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664486);
			TMP_Text.NativeMethodInfoPtr_get_textPreprocessor_Public_get_ITextPreprocessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664487);
			TMP_Text.NativeMethodInfoPtr_set_textPreprocessor_Public_set_Void_ITextPreprocessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664488);
			TMP_Text.NativeMethodInfoPtr_get_isRightToLeftText_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664489);
			TMP_Text.NativeMethodInfoPtr_set_isRightToLeftText_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664490);
			TMP_Text.NativeMethodInfoPtr_get_font_Public_get_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664491);
			TMP_Text.NativeMethodInfoPtr_set_font_Public_set_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664492);
			TMP_Text.NativeMethodInfoPtr_get_fontSharedMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664493);
			TMP_Text.NativeMethodInfoPtr_set_fontSharedMaterial_Public_Virtual_New_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664494);
			TMP_Text.NativeMethodInfoPtr_get_fontSharedMaterials_Public_Virtual_New_get_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664495);
			TMP_Text.NativeMethodInfoPtr_set_fontSharedMaterials_Public_Virtual_New_set_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664496);
			TMP_Text.NativeMethodInfoPtr_get_fontMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664497);
			TMP_Text.NativeMethodInfoPtr_set_fontMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664498);
			TMP_Text.NativeMethodInfoPtr_get_fontMaterials_Public_Virtual_New_get_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664499);
			TMP_Text.NativeMethodInfoPtr_set_fontMaterials_Public_Virtual_New_set_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664500);
			TMP_Text.NativeMethodInfoPtr_get_color_Public_Virtual_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664501);
			TMP_Text.NativeMethodInfoPtr_set_color_Public_Virtual_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664502);
			TMP_Text.NativeMethodInfoPtr_get_alpha_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664503);
			TMP_Text.NativeMethodInfoPtr_set_alpha_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664504);
			TMP_Text.NativeMethodInfoPtr_get_enableVertexGradient_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664505);
			TMP_Text.NativeMethodInfoPtr_set_enableVertexGradient_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664506);
			TMP_Text.NativeMethodInfoPtr_get_colorGradient_Public_get_VertexGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664507);
			TMP_Text.NativeMethodInfoPtr_set_colorGradient_Public_set_Void_VertexGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664508);
			TMP_Text.NativeMethodInfoPtr_get_colorGradientPreset_Public_get_TMP_ColorGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664509);
			TMP_Text.NativeMethodInfoPtr_set_colorGradientPreset_Public_set_Void_TMP_ColorGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664510);
			TMP_Text.NativeMethodInfoPtr_get_spriteAsset_Public_get_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664511);
			TMP_Text.NativeMethodInfoPtr_set_spriteAsset_Public_set_Void_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664512);
			TMP_Text.NativeMethodInfoPtr_get_tintAllSprites_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664513);
			TMP_Text.NativeMethodInfoPtr_set_tintAllSprites_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664514);
			TMP_Text.NativeMethodInfoPtr_get_styleSheet_Public_get_TMP_StyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664515);
			TMP_Text.NativeMethodInfoPtr_set_styleSheet_Public_set_Void_TMP_StyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664516);
			TMP_Text.NativeMethodInfoPtr_get_textStyle_Public_get_TMP_Style_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664517);
			TMP_Text.NativeMethodInfoPtr_set_textStyle_Public_set_Void_TMP_Style_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664518);
			TMP_Text.NativeMethodInfoPtr_get_overrideColorTags_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664519);
			TMP_Text.NativeMethodInfoPtr_set_overrideColorTags_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664520);
			TMP_Text.NativeMethodInfoPtr_get_faceColor_Public_get_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664521);
			TMP_Text.NativeMethodInfoPtr_set_faceColor_Public_set_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664522);
			TMP_Text.NativeMethodInfoPtr_get_outlineColor_Public_get_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664523);
			TMP_Text.NativeMethodInfoPtr_set_outlineColor_Public_set_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664524);
			TMP_Text.NativeMethodInfoPtr_get_outlineWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664525);
			TMP_Text.NativeMethodInfoPtr_set_outlineWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664526);
			TMP_Text.NativeMethodInfoPtr_get_fontSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664527);
			TMP_Text.NativeMethodInfoPtr_set_fontSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664528);
			TMP_Text.NativeMethodInfoPtr_get_fontWeight_Public_get_FontWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664529);
			TMP_Text.NativeMethodInfoPtr_set_fontWeight_Public_set_Void_FontWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664530);
			TMP_Text.NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664531);
			TMP_Text.NativeMethodInfoPtr_get_enableAutoSizing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664532);
			TMP_Text.NativeMethodInfoPtr_set_enableAutoSizing_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664533);
			TMP_Text.NativeMethodInfoPtr_get_fontSizeMin_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664534);
			TMP_Text.NativeMethodInfoPtr_set_fontSizeMin_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664535);
			TMP_Text.NativeMethodInfoPtr_get_fontSizeMax_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664536);
			TMP_Text.NativeMethodInfoPtr_set_fontSizeMax_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664537);
			TMP_Text.NativeMethodInfoPtr_get_fontStyle_Public_get_FontStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664538);
			TMP_Text.NativeMethodInfoPtr_set_fontStyle_Public_set_Void_FontStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664539);
			TMP_Text.NativeMethodInfoPtr_get_isUsingBold_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664540);
			TMP_Text.NativeMethodInfoPtr_get_horizontalAlignment_Public_get_HorizontalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664541);
			TMP_Text.NativeMethodInfoPtr_set_horizontalAlignment_Public_set_Void_HorizontalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664542);
			TMP_Text.NativeMethodInfoPtr_get_verticalAlignment_Public_get_VerticalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664543);
			TMP_Text.NativeMethodInfoPtr_set_verticalAlignment_Public_set_Void_VerticalAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664544);
			TMP_Text.NativeMethodInfoPtr_get_alignment_Public_get_TextAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664545);
			TMP_Text.NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664546);
			TMP_Text.NativeMethodInfoPtr_get_characterSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664547);
			TMP_Text.NativeMethodInfoPtr_set_characterSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664548);
			TMP_Text.NativeMethodInfoPtr_get_wordSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664549);
			TMP_Text.NativeMethodInfoPtr_set_wordSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664550);
			TMP_Text.NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664551);
			TMP_Text.NativeMethodInfoPtr_set_lineSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664552);
			TMP_Text.NativeMethodInfoPtr_get_lineSpacingAdjustment_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664553);
			TMP_Text.NativeMethodInfoPtr_set_lineSpacingAdjustment_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664554);
			TMP_Text.NativeMethodInfoPtr_get_paragraphSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664555);
			TMP_Text.NativeMethodInfoPtr_set_paragraphSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664556);
			TMP_Text.NativeMethodInfoPtr_get_characterWidthAdjustment_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664557);
			TMP_Text.NativeMethodInfoPtr_set_characterWidthAdjustment_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664558);
			TMP_Text.NativeMethodInfoPtr_get_enableWordWrapping_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664559);
			TMP_Text.NativeMethodInfoPtr_set_enableWordWrapping_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664560);
			TMP_Text.NativeMethodInfoPtr_get_wordWrappingRatios_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664561);
			TMP_Text.NativeMethodInfoPtr_set_wordWrappingRatios_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664562);
			TMP_Text.NativeMethodInfoPtr_get_overflowMode_Public_get_TextOverflowModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664563);
			TMP_Text.NativeMethodInfoPtr_set_overflowMode_Public_set_Void_TextOverflowModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664564);
			TMP_Text.NativeMethodInfoPtr_get_isTextOverflowing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664565);
			TMP_Text.NativeMethodInfoPtr_get_firstOverflowCharacterIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664566);
			TMP_Text.NativeMethodInfoPtr_get_linkedTextComponent_Public_get_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664567);
			TMP_Text.NativeMethodInfoPtr_set_linkedTextComponent_Public_set_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664568);
			TMP_Text.NativeMethodInfoPtr_get_isTextTruncated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664569);
			TMP_Text.NativeMethodInfoPtr_get_enableKerning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664570);
			TMP_Text.NativeMethodInfoPtr_set_enableKerning_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664571);
			TMP_Text.NativeMethodInfoPtr_get_extraPadding_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664572);
			TMP_Text.NativeMethodInfoPtr_set_extraPadding_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664573);
			TMP_Text.NativeMethodInfoPtr_get_richText_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664574);
			TMP_Text.NativeMethodInfoPtr_set_richText_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664575);
			TMP_Text.NativeMethodInfoPtr_get_parseCtrlCharacters_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664576);
			TMP_Text.NativeMethodInfoPtr_set_parseCtrlCharacters_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664577);
			TMP_Text.NativeMethodInfoPtr_get_isOverlay_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664578);
			TMP_Text.NativeMethodInfoPtr_set_isOverlay_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664579);
			TMP_Text.NativeMethodInfoPtr_get_isOrthographic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664580);
			TMP_Text.NativeMethodInfoPtr_set_isOrthographic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664581);
			TMP_Text.NativeMethodInfoPtr_get_enableCulling_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664582);
			TMP_Text.NativeMethodInfoPtr_set_enableCulling_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664583);
			TMP_Text.NativeMethodInfoPtr_get_ignoreVisibility_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664584);
			TMP_Text.NativeMethodInfoPtr_set_ignoreVisibility_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664585);
			TMP_Text.NativeMethodInfoPtr_get_horizontalMapping_Public_get_TextureMappingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664586);
			TMP_Text.NativeMethodInfoPtr_set_horizontalMapping_Public_set_Void_TextureMappingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664587);
			TMP_Text.NativeMethodInfoPtr_get_verticalMapping_Public_get_TextureMappingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664588);
			TMP_Text.NativeMethodInfoPtr_set_verticalMapping_Public_set_Void_TextureMappingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664589);
			TMP_Text.NativeMethodInfoPtr_get_mappingUvLineOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664590);
			TMP_Text.NativeMethodInfoPtr_set_mappingUvLineOffset_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664591);
			TMP_Text.NativeMethodInfoPtr_get_renderMode_Public_get_TextRenderFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664592);
			TMP_Text.NativeMethodInfoPtr_set_renderMode_Public_set_Void_TextRenderFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664593);
			TMP_Text.NativeMethodInfoPtr_get_geometrySortingOrder_Public_get_VertexSortingOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664594);
			TMP_Text.NativeMethodInfoPtr_set_geometrySortingOrder_Public_set_Void_VertexSortingOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664595);
			TMP_Text.NativeMethodInfoPtr_get_isTextObjectScaleStatic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664596);
			TMP_Text.NativeMethodInfoPtr_set_isTextObjectScaleStatic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664597);
			TMP_Text.NativeMethodInfoPtr_get_vertexBufferAutoSizeReduction_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664598);
			TMP_Text.NativeMethodInfoPtr_set_vertexBufferAutoSizeReduction_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664599);
			TMP_Text.NativeMethodInfoPtr_get_firstVisibleCharacter_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664600);
			TMP_Text.NativeMethodInfoPtr_set_firstVisibleCharacter_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664601);
			TMP_Text.NativeMethodInfoPtr_get_maxVisibleCharacters_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664602);
			TMP_Text.NativeMethodInfoPtr_set_maxVisibleCharacters_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664603);
			TMP_Text.NativeMethodInfoPtr_get_maxVisibleWords_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664604);
			TMP_Text.NativeMethodInfoPtr_set_maxVisibleWords_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664605);
			TMP_Text.NativeMethodInfoPtr_get_maxVisibleLines_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664606);
			TMP_Text.NativeMethodInfoPtr_set_maxVisibleLines_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664607);
			TMP_Text.NativeMethodInfoPtr_get_useMaxVisibleDescender_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664608);
			TMP_Text.NativeMethodInfoPtr_set_useMaxVisibleDescender_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664609);
			TMP_Text.NativeMethodInfoPtr_get_pageToDisplay_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664610);
			TMP_Text.NativeMethodInfoPtr_set_pageToDisplay_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664611);
			TMP_Text.NativeMethodInfoPtr_get_margin_Public_Virtual_New_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664612);
			TMP_Text.NativeMethodInfoPtr_set_margin_Public_Virtual_New_set_Void_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664613);
			TMP_Text.NativeMethodInfoPtr_get_textInfo_Public_get_TMP_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664614);
			TMP_Text.NativeMethodInfoPtr_get_havePropertiesChanged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664615);
			TMP_Text.NativeMethodInfoPtr_set_havePropertiesChanged_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664616);
			TMP_Text.NativeMethodInfoPtr_get_isUsingLegacyAnimationComponent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664617);
			TMP_Text.NativeMethodInfoPtr_set_isUsingLegacyAnimationComponent_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664618);
			TMP_Text.NativeMethodInfoPtr_get_transform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664619);
			TMP_Text.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664620);
			TMP_Text.NativeMethodInfoPtr_get_autoSizeTextContainer_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664621);
			TMP_Text.NativeMethodInfoPtr_set_autoSizeTextContainer_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664622);
			TMP_Text.NativeMethodInfoPtr_get_mesh_Public_Virtual_New_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664623);
			TMP_Text.NativeMethodInfoPtr_get_isVolumetricText_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664624);
			TMP_Text.NativeMethodInfoPtr_set_isVolumetricText_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664625);
			TMP_Text.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664626);
			TMP_Text.NativeMethodInfoPtr_get_textBounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664627);
			TMP_Text.NativeMethodInfoPtr_add_OnFontAssetRequest_Public_Static_add_Void_Func_3_Int32_String_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664628);
			TMP_Text.NativeMethodInfoPtr_remove_OnFontAssetRequest_Public_Static_rem_Void_Func_3_Int32_String_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664629);
			TMP_Text.NativeMethodInfoPtr_add_OnSpriteAssetRequest_Public_Static_add_Void_Func_3_Int32_String_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664630);
			TMP_Text.NativeMethodInfoPtr_remove_OnSpriteAssetRequest_Public_Static_rem_Void_Func_3_Int32_String_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664631);
			TMP_Text.NativeMethodInfoPtr_add_OnPreRenderText_Public_Virtual_New_add_Void_Action_1_TMP_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664632);
			TMP_Text.NativeMethodInfoPtr_remove_OnPreRenderText_Public_Virtual_New_rem_Void_Action_1_TMP_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664633);
			TMP_Text.NativeMethodInfoPtr_get_spriteAnimator_Protected_get_TMP_SpriteAnimator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664634);
			TMP_Text.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664635);
			TMP_Text.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664636);
			TMP_Text.NativeMethodInfoPtr_get_minWidth_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664637);
			TMP_Text.NativeMethodInfoPtr_get_minHeight_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664638);
			TMP_Text.NativeMethodInfoPtr_get_maxWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664639);
			TMP_Text.NativeMethodInfoPtr_get_maxHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664640);
			TMP_Text.NativeMethodInfoPtr_get_layoutElement_Protected_get_LayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664641);
			TMP_Text.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664642);
			TMP_Text.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664643);
			TMP_Text.NativeMethodInfoPtr_get_renderedWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664644);
			TMP_Text.NativeMethodInfoPtr_get_renderedHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664645);
			TMP_Text.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664646);
			TMP_Text.NativeMethodInfoPtr_LoadFontAsset_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664647);
			TMP_Text.NativeMethodInfoPtr_SetSharedMaterial_Protected_Virtual_New_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664648);
			TMP_Text.NativeMethodInfoPtr_GetMaterial_Protected_Virtual_New_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664649);
			TMP_Text.NativeMethodInfoPtr_SetFontBaseMaterial_Protected_Virtual_New_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664650);
			TMP_Text.NativeMethodInfoPtr_GetSharedMaterials_Protected_Virtual_New_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664651);
			TMP_Text.NativeMethodInfoPtr_SetSharedMaterials_Protected_Virtual_New_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664652);
			TMP_Text.NativeMethodInfoPtr_GetMaterials_Protected_Virtual_New_Il2CppReferenceArray_1_Material_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664653);
			TMP_Text.NativeMethodInfoPtr_CreateMaterialInstance_Protected_Virtual_New_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664654);
			TMP_Text.NativeMethodInfoPtr_SetVertexColorGradient_Protected_Void_TMP_ColorGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664655);
			TMP_Text.NativeMethodInfoPtr_SetTextSortingOrder_Protected_Void_VertexSortingOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664656);
			TMP_Text.NativeMethodInfoPtr_SetTextSortingOrder_Protected_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664657);
			TMP_Text.NativeMethodInfoPtr_SetFaceColor_Protected_Virtual_New_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664658);
			TMP_Text.NativeMethodInfoPtr_SetOutlineColor_Protected_Virtual_New_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664659);
			TMP_Text.NativeMethodInfoPtr_SetOutlineThickness_Protected_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664660);
			TMP_Text.NativeMethodInfoPtr_SetShaderDepth_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664661);
			TMP_Text.NativeMethodInfoPtr_SetCulling_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664662);
			TMP_Text.NativeMethodInfoPtr_UpdateCulling_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664663);
			TMP_Text.NativeMethodInfoPtr_GetPaddingForMaterial_Protected_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664664);
			TMP_Text.NativeMethodInfoPtr_GetPaddingForMaterial_Protected_Virtual_New_Single_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664665);
			TMP_Text.NativeMethodInfoPtr_GetTextContainerLocalCorners_Protected_Virtual_New_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664666);
			TMP_Text.NativeMethodInfoPtr_ForceMeshUpdate_Public_Virtual_New_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664667);
			TMP_Text.NativeMethodInfoPtr_UpdateGeometry_Public_Virtual_New_Void_Mesh_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664668);
			TMP_Text.NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_New_Void_TMP_VertexDataUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664669);
			TMP_Text.NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664670);
			TMP_Text.NativeMethodInfoPtr_SetVertices_Public_Virtual_New_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664671);
			TMP_Text.NativeMethodInfoPtr_UpdateMeshPadding_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664672);
			TMP_Text.NativeMethodInfoPtr_CrossFadeColor_Public_Virtual_Void_Color_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664673);
			TMP_Text.NativeMethodInfoPtr_CrossFadeAlpha_Public_Virtual_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664674);
			TMP_Text.NativeMethodInfoPtr_InternalCrossFadeColor_Protected_Virtual_New_Void_Color_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664675);
			TMP_Text.NativeMethodInfoPtr_InternalCrossFadeAlpha_Protected_Virtual_New_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664676);
			TMP_Text.NativeMethodInfoPtr_ParseInputText_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664677);
			TMP_Text.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664678);
			TMP_Text.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664679);
			TMP_Text.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_StringBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664680);
			TMP_Text.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664681);
			TMP_Text.NativeMethodInfoPtr_PopulateTextProcessingArray_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664682);
			TMP_Text.NativeMethodInfoPtr_SetTextInternal_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664683);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664684);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664685);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664686);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664687);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664688);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664689);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664690);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664691);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664692);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664693);
			TMP_Text.NativeMethodInfoPtr_SetText_Private_Void_StringBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664694);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664695);
			TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664696);
			TMP_Text.NativeMethodInfoPtr_SetCharArray_Public_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664697);
			TMP_Text.NativeMethodInfoPtr_SetCharArray_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664698);
			TMP_Text.NativeMethodInfoPtr_GetStyle_Private_TMP_Style_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664699);
			TMP_Text.NativeMethodInfoPtr_ReplaceOpeningStyleTag_Private_Boolean_byref_TextBackingContainer_Int32_byref_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664700);
			TMP_Text.NativeMethodInfoPtr_ReplaceOpeningStyleTag_Private_Boolean_byref_Il2CppStructArray_1_Int32_Int32_byref_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664701);
			TMP_Text.NativeMethodInfoPtr_ReplaceClosingStyleTag_Private_Void_byref_TextBackingContainer_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664702);
			TMP_Text.NativeMethodInfoPtr_ReplaceClosingStyleTag_Private_Void_byref_Il2CppStructArray_1_Int32_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664703);
			TMP_Text.NativeMethodInfoPtr_InsertOpeningStyleTag_Private_Boolean_TMP_Style_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664704);
			TMP_Text.NativeMethodInfoPtr_InsertClosingStyleTag_Private_Void_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664705);
			TMP_Text.NativeMethodInfoPtr_GetMarkupTagHashCode_Private_Int32_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664706);
			TMP_Text.NativeMethodInfoPtr_GetMarkupTagHashCode_Private_Int32_TextBackingContainer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664707);
			TMP_Text.NativeMethodInfoPtr_GetStyleHashCode_Private_Int32_byref_Il2CppStructArray_1_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664708);
			TMP_Text.NativeMethodInfoPtr_GetStyleHashCode_Private_Int32_byref_TextBackingContainer_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664709);
			TMP_Text.NativeMethodInfoPtr_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664710);
			TMP_Text.NativeMethodInfoPtr_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664711);
			TMP_Text.NativeMethodInfoPtr_AddFloatToInternalTextBackingArray_Private_Void_Single_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664712);
			TMP_Text.NativeMethodInfoPtr_AddIntegerToInternalTextBackingArray_Private_Void_Double_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664713);
			TMP_Text.NativeMethodInfoPtr_InternalTextBackingArrayToString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664714);
			TMP_Text.NativeMethodInfoPtr_SetArraySizes_Internal_Virtual_New_Int32_Il2CppStructArray_1_UnicodeChar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664715);
			TMP_Text.NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664716);
			TMP_Text.NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664717);
			TMP_Text.NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664718);
			TMP_Text.NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664719);
			TMP_Text.NativeMethodInfoPtr_GetPreferredWidth_Protected_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664720);
			TMP_Text.NativeMethodInfoPtr_GetPreferredWidth_Private_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664721);
			TMP_Text.NativeMethodInfoPtr_GetPreferredHeight_Protected_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664722);
			TMP_Text.NativeMethodInfoPtr_GetPreferredHeight_Private_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664723);
			TMP_Text.NativeMethodInfoPtr_GetRenderedValues_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664724);
			TMP_Text.NativeMethodInfoPtr_GetRenderedValues_Public_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664725);
			TMP_Text.NativeMethodInfoPtr_GetRenderedWidth_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664726);
			TMP_Text.NativeMethodInfoPtr_GetRenderedWidth_Protected_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664727);
			TMP_Text.NativeMethodInfoPtr_GetRenderedHeight_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664728);
			TMP_Text.NativeMethodInfoPtr_GetRenderedHeight_Protected_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664729);
			TMP_Text.NativeMethodInfoPtr_CalculatePreferredValues_Protected_Virtual_New_Vector2_byref_Single_Vector2_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664730);
			TMP_Text.NativeMethodInfoPtr_GetCompoundBounds_Protected_Virtual_New_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664731);
			TMP_Text.NativeMethodInfoPtr_GetCanvasSpaceClippingRect_Internal_Virtual_New_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664732);
			TMP_Text.NativeMethodInfoPtr_GetTextBounds_Protected_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664733);
			TMP_Text.NativeMethodInfoPtr_GetTextBounds_Protected_Bounds_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664734);
			TMP_Text.NativeMethodInfoPtr_AdjustLineOffset_Protected_Void_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664735);
			TMP_Text.NativeMethodInfoPtr_ResizeLineExtents_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664736);
			TMP_Text.NativeMethodInfoPtr_GetTextInfo_Public_Virtual_New_TMP_TextInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664737);
			TMP_Text.NativeMethodInfoPtr_ComputeMarginSize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664738);
			TMP_Text.NativeMethodInfoPtr_InsertNewLine_Protected_Void_Int32_Single_Single_Single_Single_Single_Single_Single_Single_byref_Boolean_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664739);
			TMP_Text.NativeMethodInfoPtr_SaveWordWrappingState_Protected_Void_byref_WordWrapState_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664740);
			TMP_Text.NativeMethodInfoPtr_RestoreWordWrappingState_Protected_Int32_byref_WordWrapState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664741);
			TMP_Text.NativeMethodInfoPtr_SaveGlyphVertexInfo_Protected_Virtual_New_Void_Single_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664742);
			TMP_Text.NativeMethodInfoPtr_SaveSpriteVertexInfo_Protected_Virtual_New_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664743);
			TMP_Text.NativeMethodInfoPtr_FillCharacterVertexBuffers_Protected_Virtual_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664744);
			TMP_Text.NativeMethodInfoPtr_FillCharacterVertexBuffers_Protected_Virtual_New_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664745);
			TMP_Text.NativeMethodInfoPtr_FillSpriteVertexBuffers_Protected_Virtual_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664746);
			TMP_Text.NativeMethodInfoPtr_DrawUnderlineMesh_Protected_Virtual_New_Void_Vector3_Vector3_byref_Int32_Single_Single_Single_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664747);
			TMP_Text.NativeMethodInfoPtr_DrawTextHighlight_Protected_Virtual_New_Void_Vector3_Vector3_byref_Int32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664748);
			TMP_Text.NativeMethodInfoPtr_LoadDefaultSettings_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664749);
			TMP_Text.NativeMethodInfoPtr_GetSpecialCharacters_Protected_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664750);
			TMP_Text.NativeMethodInfoPtr_GetEllipsisSpecialCharacter_Protected_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664751);
			TMP_Text.NativeMethodInfoPtr_GetUnderlineSpecialCharacter_Protected_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664752);
			TMP_Text.NativeMethodInfoPtr_ReplaceTagWithCharacter_Protected_Void_Il2CppStructArray_1_Int32_Int32_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664753);
			TMP_Text.NativeMethodInfoPtr_GetFontAssetForWeight_Protected_TMP_FontAsset_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664754);
			TMP_Text.NativeMethodInfoPtr_GetTextElement_Internal_TMP_TextElement_UInt32_TMP_FontAsset_FontStyles_FontWeight_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664755);
			TMP_Text.NativeMethodInfoPtr_SetActiveSubMeshes_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664756);
			TMP_Text.NativeMethodInfoPtr_DestroySubMeshObjects_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664757);
			TMP_Text.NativeMethodInfoPtr_ClearMesh_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664758);
			TMP_Text.NativeMethodInfoPtr_ClearMesh_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664759);
			TMP_Text.NativeMethodInfoPtr_GetParsedText_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664760);
			TMP_Text.NativeMethodInfoPtr_IsSelfOrLinkedAncestor_Internal_Boolean_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664761);
			TMP_Text.NativeMethodInfoPtr_ReleaseLinkedTextComponent_Internal_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664762);
			TMP_Text.NativeMethodInfoPtr_PackUV_Protected_Vector2_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664763);
			TMP_Text.NativeMethodInfoPtr_PackUV_Protected_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664764);
			TMP_Text.NativeMethodInfoPtr_InternalUpdate_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664765);
			TMP_Text.NativeMethodInfoPtr_HexToInt_Protected_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664766);
			TMP_Text.NativeMethodInfoPtr_GetUTF16_Protected_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664767);
			TMP_Text.NativeMethodInfoPtr_GetUTF16_Protected_Int32_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664768);
			TMP_Text.NativeMethodInfoPtr_GetUTF16_Internal_Int32_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664769);
			TMP_Text.NativeMethodInfoPtr_GetUTF16_Protected_Int32_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664770);
			TMP_Text.NativeMethodInfoPtr_GetUTF16_Private_Int32_TextBackingContainer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664771);
			TMP_Text.NativeMethodInfoPtr_GetUTF32_Protected_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664772);
			TMP_Text.NativeMethodInfoPtr_GetUTF32_Protected_Int32_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664773);
			TMP_Text.NativeMethodInfoPtr_GetUTF32_Internal_Int32_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664774);
			TMP_Text.NativeMethodInfoPtr_GetUTF32_Protected_Int32_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664775);
			TMP_Text.NativeMethodInfoPtr_GetUTF32_Private_Int32_TextBackingContainer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664776);
			TMP_Text.NativeMethodInfoPtr_HexCharsToColor_Protected_Color32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664777);
			TMP_Text.NativeMethodInfoPtr_HexCharsToColor_Protected_Color32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664778);
			TMP_Text.NativeMethodInfoPtr_GetAttributeParameters_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_byref_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664779);
			TMP_Text.NativeMethodInfoPtr_ConvertToFloat_Protected_Single_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664780);
			TMP_Text.NativeMethodInfoPtr_ConvertToFloat_Protected_Single_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664781);
			TMP_Text.NativeMethodInfoPtr_ValidateHtmlTag_Internal_Boolean_Il2CppStructArray_1_UnicodeChar_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664782);
			TMP_Text.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, 100664783);
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x0002F218 File Offset: 0x0002D418
		// (set) Token: 0x06000A81 RID: 2689 RVA: 0x0002F25C File Offset: 0x0002D45C
		public unsafe virtual string text
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_text_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047327, XrefRangeEnd = 1047329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_set_text_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x0002F2AC File Offset: 0x0002D4AC
		// (set) Token: 0x06000A83 RID: 2691 RVA: 0x0002F2EC File Offset: 0x0002D4EC
		public unsafe ITextPreprocessor textPreprocessor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_textPreprocessor_Public_get_ITextPreprocessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITextPreprocessor>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_textPreprocessor_Public_set_Void_ITextPreprocessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x0002F330 File Offset: 0x0002D530
		// (set) Token: 0x06000A85 RID: 2693 RVA: 0x0002F36C File Offset: 0x0002D56C
		public unsafe bool isRightToLeftText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_isRightToLeftText_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_isRightToLeftText_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x0002F3AC File Offset: 0x0002D5AC
		// (set) Token: 0x06000A87 RID: 2695 RVA: 0x0002F3EC File Offset: 0x0002D5EC
		public unsafe TMP_FontAsset font
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_font_Public_get_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1047334, RefRangeEnd = 1047340, XrefRangeStart = 1047329, XrefRangeEnd = 1047334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_font_Public_set_Void_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x0002F430 File Offset: 0x0002D630
		// (set) Token: 0x06000A89 RID: 2697 RVA: 0x0002F47C File Offset: 0x0002D67C
		public unsafe virtual Material fontSharedMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_fontSharedMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047340, XrefRangeEnd = 1047344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_set_fontSharedMaterial_Public_Virtual_New_set_Void_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x0002F4CC File Offset: 0x0002D6CC
		// (set) Token: 0x06000A8B RID: 2699 RVA: 0x0002F518 File Offset: 0x0002D718
		public unsafe virtual Il2CppReferenceArray<Material> fontSharedMaterials
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_fontSharedMaterials_Public_Virtual_New_get_Il2CppReferenceArray_1_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_set_fontSharedMaterials_Public_Virtual_New_set_Void_Il2CppReferenceArray_1_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x0002F568 File Offset: 0x0002D768
		// (set) Token: 0x06000A8D RID: 2701 RVA: 0x0002F5A8 File Offset: 0x0002D7A8
		public unsafe Material fontMaterial
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1047344, RefRangeEnd = 1047346, XrefRangeStart = 1047344, XrefRangeEnd = 1047344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_fontMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047346, XrefRangeEnd = 1047353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_fontMaterial_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x0002F5EC File Offset: 0x0002D7EC
		// (set) Token: 0x06000A8F RID: 2703 RVA: 0x0002F638 File Offset: 0x0002D838
		public unsafe virtual Il2CppReferenceArray<Material> fontMaterials
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_fontMaterials_Public_Virtual_New_get_Il2CppReferenceArray_1_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_set_fontMaterials_Public_Virtual_New_set_Void_Il2CppReferenceArray_1_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x0002F688 File Offset: 0x0002D888
		// (set) Token: 0x06000A91 RID: 2705 RVA: 0x0002F6D0 File Offset: 0x0002D8D0
		public unsafe override Color color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_color_Public_Virtual_get_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_set_color_Public_Virtual_set_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x0002F71C File Offset: 0x0002D91C
		// (set) Token: 0x06000A93 RID: 2707 RVA: 0x0002F758 File Offset: 0x0002D958
		public unsafe float alpha
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_alpha_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_alpha_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x0002F798 File Offset: 0x0002D998
		// (set) Token: 0x06000A95 RID: 2709 RVA: 0x0002F7D4 File Offset: 0x0002D9D4
		public unsafe bool enableVertexGradient
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_enableVertexGradient_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_enableVertexGradient_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x0002F814 File Offset: 0x0002DA14
		// (set) Token: 0x06000A97 RID: 2711 RVA: 0x0002F850 File Offset: 0x0002DA50
		public unsafe VertexGradient colorGradient
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_colorGradient_Public_get_VertexGradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_colorGradient_Public_set_Void_VertexGradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x0002F890 File Offset: 0x0002DA90
		// (set) Token: 0x06000A99 RID: 2713 RVA: 0x0002F8D0 File Offset: 0x0002DAD0
		public unsafe TMP_ColorGradient colorGradientPreset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_colorGradientPreset_Public_get_TMP_ColorGradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_ColorGradient>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047353, XrefRangeEnd = 1047354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_colorGradientPreset_Public_set_Void_TMP_ColorGradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x0002F914 File Offset: 0x0002DB14
		// (set) Token: 0x06000A9B RID: 2715 RVA: 0x0002F954 File Offset: 0x0002DB54
		public unsafe TMP_SpriteAsset spriteAsset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_spriteAsset_Public_get_TMP_SpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047354, XrefRangeEnd = 1047355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_spriteAsset_Public_set_Void_TMP_SpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x0002F998 File Offset: 0x0002DB98
		// (set) Token: 0x06000A9D RID: 2717 RVA: 0x0002F9D4 File Offset: 0x0002DBD4
		public unsafe bool tintAllSprites
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_tintAllSprites_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_tintAllSprites_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x0002FA14 File Offset: 0x0002DC14
		// (set) Token: 0x06000A9F RID: 2719 RVA: 0x0002FA54 File Offset: 0x0002DC54
		public unsafe TMP_StyleSheet styleSheet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_styleSheet_Public_get_TMP_StyleSheet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_StyleSheet>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047355, XrefRangeEnd = 1047356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_styleSheet_Public_set_Void_TMP_StyleSheet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x0002FA98 File Offset: 0x0002DC98
		// (set) Token: 0x06000AA1 RID: 2721 RVA: 0x0002FAD8 File Offset: 0x0002DCD8
		public unsafe TMP_Style textStyle
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1047360, RefRangeEnd = 1047362, XrefRangeStart = 1047356, XrefRangeEnd = 1047360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_textStyle_Public_get_TMP_Style_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Style>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047362, XrefRangeEnd = 1047364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_textStyle_Public_set_Void_TMP_Style_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x0002FB1C File Offset: 0x0002DD1C
		// (set) Token: 0x06000AA3 RID: 2723 RVA: 0x0002FB58 File Offset: 0x0002DD58
		public unsafe bool overrideColorTags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_overrideColorTags_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_overrideColorTags_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x0002FB98 File Offset: 0x0002DD98
		// (set) Token: 0x06000AA5 RID: 2725 RVA: 0x0002FBD4 File Offset: 0x0002DDD4
		public unsafe Color32 faceColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047364, XrefRangeEnd = 1047374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_faceColor_Public_get_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047374, XrefRangeEnd = 1047375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_faceColor_Public_set_Void_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x0002FC14 File Offset: 0x0002DE14
		// (set) Token: 0x06000AA7 RID: 2727 RVA: 0x0002FC50 File Offset: 0x0002DE50
		public unsafe Color32 outlineColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047375, XrefRangeEnd = 1047385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_outlineColor_Public_get_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047385, XrefRangeEnd = 1047386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_outlineColor_Public_set_Void_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x0002FC90 File Offset: 0x0002DE90
		// (set) Token: 0x06000AA9 RID: 2729 RVA: 0x0002FCCC File Offset: 0x0002DECC
		public unsafe float outlineWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047386, XrefRangeEnd = 1047395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_outlineWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_outlineWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x0002FD0C File Offset: 0x0002DF0C
		// (set) Token: 0x06000AAB RID: 2731 RVA: 0x0002FD48 File Offset: 0x0002DF48
		public unsafe float fontSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_fontSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1047395, RefRangeEnd = 1047406, XrefRangeStart = 1047395, XrefRangeEnd = 1047395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_fontSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x0002FD88 File Offset: 0x0002DF88
		// (set) Token: 0x06000AAD RID: 2733 RVA: 0x0002FDC4 File Offset: 0x0002DFC4
		public unsafe FontWeight fontWeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_fontWeight_Public_get_FontWeight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_fontWeight_Public_set_Void_FontWeight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x0002FE04 File Offset: 0x0002E004
		public unsafe float pixelsPerUnit
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047406, XrefRangeEnd = 1047422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x0002FE40 File Offset: 0x0002E040
		// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x0002FE7C File Offset: 0x0002E07C
		public unsafe bool enableAutoSizing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_enableAutoSizing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1047422, RefRangeEnd = 1047423, XrefRangeStart = 1047422, XrefRangeEnd = 1047422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_enableAutoSizing_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x0002FEBC File Offset: 0x0002E0BC
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x0002FEF8 File Offset: 0x0002E0F8
		public unsafe float fontSizeMin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_fontSizeMin_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1047423, RefRangeEnd = 1047424, XrefRangeStart = 1047423, XrefRangeEnd = 1047423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_fontSizeMin_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0002FF38 File Offset: 0x0002E138
		// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x0002FF74 File Offset: 0x0002E174
		public unsafe float fontSizeMax
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_fontSizeMax_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1047424, RefRangeEnd = 1047425, XrefRangeStart = 1047424, XrefRangeEnd = 1047424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_fontSizeMax_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x0002FFB4 File Offset: 0x0002E1B4
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x0002FFF0 File Offset: 0x0002E1F0
		public unsafe FontStyles fontStyle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_fontStyle_Public_get_FontStyles_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1047425, RefRangeEnd = 1047426, XrefRangeStart = 1047425, XrefRangeEnd = 1047425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_fontStyle_Public_set_Void_FontStyles_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x00030030 File Offset: 0x0002E230
		public unsafe bool isUsingBold
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_isUsingBold_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x0003006C File Offset: 0x0002E26C
		// (set) Token: 0x06000AB9 RID: 2745 RVA: 0x000300A8 File Offset: 0x0002E2A8
		public unsafe HorizontalAlignmentOptions horizontalAlignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_horizontalAlignment_Public_get_HorizontalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_horizontalAlignment_Public_set_Void_HorizontalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x000300E8 File Offset: 0x0002E2E8
		// (set) Token: 0x06000ABB RID: 2747 RVA: 0x00030124 File Offset: 0x0002E324
		public unsafe VerticalAlignmentOptions verticalAlignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_verticalAlignment_Public_get_VerticalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_verticalAlignment_Public_set_Void_VerticalAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x00030164 File Offset: 0x0002E364
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x000301A0 File Offset: 0x0002E3A0
		public unsafe TextAlignmentOptions alignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_alignment_Public_get_TextAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1047426, RefRangeEnd = 1047429, XrefRangeStart = 1047426, XrefRangeEnd = 1047426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAlignmentOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x000301E0 File Offset: 0x0002E3E0
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x0003021C File Offset: 0x0002E41C
		public unsafe float characterSpacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_characterSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_characterSpacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x0003025C File Offset: 0x0002E45C
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x00030298 File Offset: 0x0002E498
		public unsafe float wordSpacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_wordSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_wordSpacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x000302D8 File Offset: 0x0002E4D8
		// (set) Token: 0x06000AC3 RID: 2755 RVA: 0x00030314 File Offset: 0x0002E514
		public unsafe float lineSpacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_lineSpacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x00030354 File Offset: 0x0002E554
		// (set) Token: 0x06000AC5 RID: 2757 RVA: 0x00030390 File Offset: 0x0002E590
		public unsafe float lineSpacingAdjustment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_lineSpacingAdjustment_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_lineSpacingAdjustment_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x000303D0 File Offset: 0x0002E5D0
		// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x0003040C File Offset: 0x0002E60C
		public unsafe float paragraphSpacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_paragraphSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_paragraphSpacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x0003044C File Offset: 0x0002E64C
		// (set) Token: 0x06000AC9 RID: 2761 RVA: 0x00030488 File Offset: 0x0002E688
		public unsafe float characterWidthAdjustment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_characterWidthAdjustment_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_characterWidthAdjustment_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000ACA RID: 2762 RVA: 0x000304C8 File Offset: 0x0002E6C8
		// (set) Token: 0x06000ACB RID: 2763 RVA: 0x00030504 File Offset: 0x0002E704
		public unsafe bool enableWordWrapping
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_enableWordWrapping_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1047429, RefRangeEnd = 1047434, XrefRangeStart = 1047429, XrefRangeEnd = 1047429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_enableWordWrapping_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x00030544 File Offset: 0x0002E744
		// (set) Token: 0x06000ACD RID: 2765 RVA: 0x00030580 File Offset: 0x0002E780
		public unsafe float wordWrappingRatios
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_wordWrappingRatios_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_wordWrappingRatios_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x000305C0 File Offset: 0x0002E7C0
		// (set) Token: 0x06000ACF RID: 2767 RVA: 0x000305FC File Offset: 0x0002E7FC
		public unsafe TextOverflowModes overflowMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_overflowMode_Public_get_TextOverflowModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_overflowMode_Public_set_Void_TextOverflowModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x0003063C File Offset: 0x0002E83C
		public unsafe bool isTextOverflowing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_isTextOverflowing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x00030678 File Offset: 0x0002E878
		public unsafe int firstOverflowCharacterIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_firstOverflowCharacterIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x000306B4 File Offset: 0x0002E8B4
		// (set) Token: 0x06000AD3 RID: 2771 RVA: 0x000306F4 File Offset: 0x0002E8F4
		public unsafe TMP_Text linkedTextComponent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_linkedTextComponent_Public_get_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1047444, RefRangeEnd = 1047445, XrefRangeStart = 1047434, XrefRangeEnd = 1047444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_linkedTextComponent_Public_set_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x00030738 File Offset: 0x0002E938
		public unsafe bool isTextTruncated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_isTextTruncated_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x00030774 File Offset: 0x0002E974
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x000307B0 File Offset: 0x0002E9B0
		public unsafe bool enableKerning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_enableKerning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_enableKerning_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x000307F0 File Offset: 0x0002E9F0
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x0003082C File Offset: 0x0002EA2C
		public unsafe bool extraPadding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_extraPadding_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1047445, RefRangeEnd = 1047447, XrefRangeStart = 1047445, XrefRangeEnd = 1047445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_extraPadding_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x0003086C File Offset: 0x0002EA6C
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x000308A8 File Offset: 0x0002EAA8
		public unsafe bool richText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_richText_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1047447, RefRangeEnd = 1047450, XrefRangeStart = 1047447, XrefRangeEnd = 1047447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_richText_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x000308E8 File Offset: 0x0002EAE8
		// (set) Token: 0x06000ADC RID: 2780 RVA: 0x00030924 File Offset: 0x0002EB24
		public unsafe bool parseCtrlCharacters
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_parseCtrlCharacters_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_parseCtrlCharacters_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x00030964 File Offset: 0x0002EB64
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x000309A0 File Offset: 0x0002EBA0
		public unsafe bool isOverlay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_isOverlay_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_isOverlay_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x000309E0 File Offset: 0x0002EBE0
		// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x00030A1C File Offset: 0x0002EC1C
		public unsafe bool isOrthographic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_isOrthographic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_isOrthographic_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x00030A5C File Offset: 0x0002EC5C
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x00030A98 File Offset: 0x0002EC98
		public unsafe bool enableCulling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_enableCulling_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_enableCulling_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x00030AD8 File Offset: 0x0002ECD8
		// (set) Token: 0x06000AE4 RID: 2788 RVA: 0x00030B14 File Offset: 0x0002ED14
		public unsafe bool ignoreVisibility
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_ignoreVisibility_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_ignoreVisibility_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x00030B54 File Offset: 0x0002ED54
		// (set) Token: 0x06000AE6 RID: 2790 RVA: 0x00030B90 File Offset: 0x0002ED90
		public unsafe TextureMappingOptions horizontalMapping
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_horizontalMapping_Public_get_TextureMappingOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_horizontalMapping_Public_set_Void_TextureMappingOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x00030BD0 File Offset: 0x0002EDD0
		// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x00030C0C File Offset: 0x0002EE0C
		public unsafe TextureMappingOptions verticalMapping
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_verticalMapping_Public_get_TextureMappingOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_verticalMapping_Public_set_Void_TextureMappingOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x00030C4C File Offset: 0x0002EE4C
		// (set) Token: 0x06000AEA RID: 2794 RVA: 0x00030C88 File Offset: 0x0002EE88
		public unsafe float mappingUvLineOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_mappingUvLineOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_mappingUvLineOffset_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x00030CC8 File Offset: 0x0002EEC8
		// (set) Token: 0x06000AEC RID: 2796 RVA: 0x00030D04 File Offset: 0x0002EF04
		public unsafe TextRenderFlags renderMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_renderMode_Public_get_TextRenderFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_renderMode_Public_set_Void_TextRenderFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x00030D44 File Offset: 0x0002EF44
		// (set) Token: 0x06000AEE RID: 2798 RVA: 0x00030D80 File Offset: 0x0002EF80
		public unsafe VertexSortingOrder geometrySortingOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_geometrySortingOrder_Public_get_VertexSortingOrder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_geometrySortingOrder_Public_set_Void_VertexSortingOrder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x00030DC0 File Offset: 0x0002EFC0
		// (set) Token: 0x06000AF0 RID: 2800 RVA: 0x00030DFC File Offset: 0x0002EFFC
		public unsafe bool isTextObjectScaleStatic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_isTextObjectScaleStatic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047450, XrefRangeEnd = 1047456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_isTextObjectScaleStatic_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x00030E3C File Offset: 0x0002F03C
		// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x00030E78 File Offset: 0x0002F078
		public unsafe bool vertexBufferAutoSizeReduction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_vertexBufferAutoSizeReduction_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_vertexBufferAutoSizeReduction_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x00030EB8 File Offset: 0x0002F0B8
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x00030EF4 File Offset: 0x0002F0F4
		public unsafe int firstVisibleCharacter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_firstVisibleCharacter_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1047456, RefRangeEnd = 1047460, XrefRangeStart = 1047456, XrefRangeEnd = 1047456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_firstVisibleCharacter_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x00030F34 File Offset: 0x0002F134
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x00030F70 File Offset: 0x0002F170
		public unsafe int maxVisibleCharacters
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_maxVisibleCharacters_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_maxVisibleCharacters_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x00030FB0 File Offset: 0x0002F1B0
		// (set) Token: 0x06000AF8 RID: 2808 RVA: 0x00030FEC File Offset: 0x0002F1EC
		public unsafe int maxVisibleWords
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_maxVisibleWords_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_maxVisibleWords_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x0003102C File Offset: 0x0002F22C
		// (set) Token: 0x06000AFA RID: 2810 RVA: 0x00031068 File Offset: 0x0002F268
		public unsafe int maxVisibleLines
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_maxVisibleLines_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_maxVisibleLines_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x000310A8 File Offset: 0x0002F2A8
		// (set) Token: 0x06000AFC RID: 2812 RVA: 0x000310E4 File Offset: 0x0002F2E4
		public unsafe bool useMaxVisibleDescender
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_useMaxVisibleDescender_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_useMaxVisibleDescender_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x00031124 File Offset: 0x0002F324
		// (set) Token: 0x06000AFE RID: 2814 RVA: 0x00031160 File Offset: 0x0002F360
		public unsafe int pageToDisplay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_pageToDisplay_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_pageToDisplay_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x000311A0 File Offset: 0x0002F3A0
		// (set) Token: 0x06000B00 RID: 2816 RVA: 0x000311E8 File Offset: 0x0002F3E8
		public unsafe virtual Vector4 margin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_margin_Public_Virtual_New_get_Vector4_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_set_margin_Public_Virtual_New_set_Void_Vector4_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x00031234 File Offset: 0x0002F434
		public unsafe TMP_TextInfo textInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_textInfo_Public_get_TMP_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_TextInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000B02 RID: 2818 RVA: 0x00031274 File Offset: 0x0002F474
		// (set) Token: 0x06000B03 RID: 2819 RVA: 0x000312B0 File Offset: 0x0002F4B0
		public unsafe bool havePropertiesChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_havePropertiesChanged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1047460, RefRangeEnd = 1047465, XrefRangeStart = 1047460, XrefRangeEnd = 1047460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_havePropertiesChanged_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x000312F0 File Offset: 0x0002F4F0
		// (set) Token: 0x06000B05 RID: 2821 RVA: 0x0003132C File Offset: 0x0002F52C
		public unsafe bool isUsingLegacyAnimationComponent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_isUsingLegacyAnimationComponent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_isUsingLegacyAnimationComponent_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x0003136C File Offset: 0x0002F56C
		public new unsafe Transform transform
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 1047473, RefRangeEnd = 1047488, XrefRangeStart = 1047465, XrefRangeEnd = 1047473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_transform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x000313AC File Offset: 0x0002F5AC
		public new unsafe RectTransform rectTransform
		{
			[CallerCount(52)]
			[CachedScanResults(RefRangeStart = 1047496, RefRangeEnd = 1047548, XrefRangeStart = 1047488, XrefRangeEnd = 1047496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x000313EC File Offset: 0x0002F5EC
		// (set) Token: 0x06000B09 RID: 2825 RVA: 0x00031434 File Offset: 0x0002F634
		public unsafe virtual bool autoSizeTextContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_autoSizeTextContainer_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_set_autoSizeTextContainer_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x00031480 File Offset: 0x0002F680
		public unsafe virtual Mesh mesh
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_mesh_Public_Virtual_New_get_Mesh_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x000314CC File Offset: 0x0002F6CC
		// (set) Token: 0x06000B0C RID: 2828 RVA: 0x00031508 File Offset: 0x0002F708
		public unsafe bool isVolumetricText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_isVolumetricText_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047548, XrefRangeEnd = 1047549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_set_isVolumetricText_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x00031548 File Offset: 0x0002F748
		public unsafe Bounds bounds
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1047553, RefRangeEnd = 1047556, XrefRangeStart = 1047549, XrefRangeEnd = 1047553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x00031584 File Offset: 0x0002F784
		public unsafe Bounds textBounds
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1047557, RefRangeEnd = 1047559, XrefRangeStart = 1047556, XrefRangeEnd = 1047557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_textBounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x000315C0 File Offset: 0x0002F7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047559, XrefRangeEnd = 1047572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_add_OnFontAssetRequest_Public_Static_add_Void_Func_3_Int32_String_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x000315F8 File Offset: 0x0002F7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047572, XrefRangeEnd = 1047585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_remove_OnFontAssetRequest_Public_Static_rem_Void_Func_3_Int32_String_TMP_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x00031630 File Offset: 0x0002F830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047585, XrefRangeEnd = 1047598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_add_OnSpriteAssetRequest_Public_Static_add_Void_Func_3_Int32_String_TMP_SpriteAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00031668 File Offset: 0x0002F868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047598, XrefRangeEnd = 1047611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_remove_OnSpriteAssetRequest_Public_Static_rem_Void_Func_3_Int32_String_TMP_SpriteAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x000316A0 File Offset: 0x0002F8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047611, XrefRangeEnd = 1047616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_OnPreRenderText(Action<TMP_TextInfo> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_add_OnPreRenderText_Public_Virtual_New_add_Void_Action_1_TMP_TextInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x000316F0 File Offset: 0x0002F8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047616, XrefRangeEnd = 1047621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_OnPreRenderText(Action<TMP_TextInfo> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_remove_OnPreRenderText_Public_Virtual_New_rem_Void_Action_1_TMP_TextInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x00031740 File Offset: 0x0002F940
		public unsafe TMP_SpriteAnimator spriteAnimator
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047621, XrefRangeEnd = 1047637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_spriteAnimator_Protected_get_TMP_SpriteAnimator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAnimator>(intPtr3) : null;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x00031780 File Offset: 0x0002F980
		public unsafe virtual float flexibleHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x000317BC File Offset: 0x0002F9BC
		public unsafe virtual float flexibleWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x000317F8 File Offset: 0x0002F9F8
		public unsafe virtual float minWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_minWidth_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x00031834 File Offset: 0x0002FA34
		public unsafe virtual float minHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_minHeight_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000B1A RID: 2842 RVA: 0x00031870 File Offset: 0x0002FA70
		public unsafe float maxWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_maxWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x000318AC File Offset: 0x0002FAAC
		public unsafe float maxHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_maxHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x000318E8 File Offset: 0x0002FAE8
		public unsafe LayoutElement layoutElement
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047637, XrefRangeEnd = 1047645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_layoutElement_Protected_get_LayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LayoutElement>(intPtr3) : null;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x00031928 File Offset: 0x0002FB28
		public unsafe virtual float preferredWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047645, XrefRangeEnd = 1047646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x00031970 File Offset: 0x0002FB70
		public unsafe virtual float preferredHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047646, XrefRangeEnd = 1047647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x000319B8 File Offset: 0x0002FBB8
		public unsafe virtual float renderedWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047647, XrefRangeEnd = 1047648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_renderedWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x00031A00 File Offset: 0x0002FC00
		public unsafe virtual float renderedHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047648, XrefRangeEnd = 1047649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_get_renderedHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x00031A48 File Offset: 0x0002FC48
		public unsafe virtual int layoutPriority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00031A84 File Offset: 0x0002FC84
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LoadFontAsset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_LoadFontAsset_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00031AC0 File Offset: 0x0002FCC0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSharedMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetSharedMaterial_Protected_Virtual_New_Void_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00031B10 File Offset: 0x0002FD10
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Material GetMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetMaterial_Protected_Virtual_New_Material_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00031B6C File Offset: 0x0002FD6C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetFontBaseMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetFontBaseMaterial_Protected_Virtual_New_Void_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00031BBC File Offset: 0x0002FDBC
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Material> GetSharedMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetSharedMaterials_Protected_Virtual_New_Il2CppReferenceArray_1_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00031C08 File Offset: 0x0002FE08
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSharedMaterials(Il2CppReferenceArray<Material> materials)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(materials);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetSharedMaterials_Protected_Virtual_New_Void_Il2CppReferenceArray_1_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00031C58 File Offset: 0x0002FE58
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Material> GetMaterials(Il2CppReferenceArray<Material> mats)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mats);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetMaterials_Protected_Virtual_New_Il2CppReferenceArray_1_Material_Il2CppReferenceArray_1_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr3) : null;
			}
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00031CB4 File Offset: 0x0002FEB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047649, XrefRangeEnd = 1047660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Material CreateMaterialInstance(Material source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_CreateMaterialInstance_Protected_Virtual_New_Material_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00031D10 File Offset: 0x0002FF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047660, XrefRangeEnd = 1047664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertexColorGradient(TMP_ColorGradient gradient)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gradient);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetVertexColorGradient_Protected_Void_TMP_ColorGradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00031D54 File Offset: 0x0002FF54
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextSortingOrder(VertexSortingOrder order)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref order;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetTextSortingOrder_Protected_Void_VertexSortingOrder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00031D94 File Offset: 0x0002FF94
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextSortingOrder(Il2CppStructArray<int> order)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(order);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetTextSortingOrder_Protected_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00031DD8 File Offset: 0x0002FFD8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetFaceColor(Color32 color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetFaceColor_Protected_Virtual_New_Void_Color32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00031E24 File Offset: 0x00030024
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetOutlineColor(Color32 color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetOutlineColor_Protected_Virtual_New_Void_Color32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00031E70 File Offset: 0x00030070
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetOutlineThickness(float thickness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thickness;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetOutlineThickness_Protected_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00031EBC File Offset: 0x000300BC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetShaderDepth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetShaderDepth_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00031EF8 File Offset: 0x000300F8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetCulling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetCulling_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00031F34 File Offset: 0x00030134
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateCulling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_UpdateCulling_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00031F70 File Offset: 0x00030170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047664, XrefRangeEnd = 1047678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetPaddingForMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetPaddingForMaterial_Protected_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00031FB8 File Offset: 0x000301B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047678, XrefRangeEnd = 1047689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetPaddingForMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetPaddingForMaterial_Protected_Virtual_New_Single_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00032010 File Offset: 0x00030210
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<Vector3> GetTextContainerLocalCorners()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetTextContainerLocalCorners_Protected_Virtual_New_Il2CppStructArray_1_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x0003205C File Offset: 0x0003025C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ForceMeshUpdate(bool ignoreActiveState = false, bool forceTextReparsing = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ignoreActiveState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceTextReparsing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_ForceMeshUpdate_Public_Virtual_New_Void_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x000320B4 File Offset: 0x000302B4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateGeometry(Mesh mesh, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_UpdateGeometry_Public_Virtual_New_Void_Mesh_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x00032110 File Offset: 0x00030310
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_New_Void_TMP_VertexDataUpdateFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x0003215C File Offset: 0x0003035C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateVertexData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00032198 File Offset: 0x00030398
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetVertices(Il2CppStructArray<Vector3> vertices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vertices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetVertices_Public_Virtual_New_Void_Il2CppStructArray_1_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x000321E8 File Offset: 0x000303E8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateMeshPadding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_UpdateMeshPadding_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x00032224 File Offset: 0x00030424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047689, XrefRangeEnd = 1047690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetColor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreTimeScale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useAlpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_CrossFadeColor_Public_Virtual_Void_Color_Single_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00032298 File Offset: 0x00030498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047690, XrefRangeEnd = 1047691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alpha;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreTimeScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_CrossFadeAlpha_Public_Virtual_Void_Single_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x00032300 File Offset: 0x00030500
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetColor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreTimeScale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useAlpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_InternalCrossFadeColor_Protected_Virtual_New_Void_Color_Single_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00032374 File Offset: 0x00030574
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alpha;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreTimeScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_InternalCrossFadeAlpha_Protected_Virtual_New_Void_Single_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x000323DC File Offset: 0x000305DC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1047703, RefRangeEnd = 1047708, XrefRangeStart = 1047691, XrefRangeEnd = 1047703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseInputText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ParseInputText_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x00032410 File Offset: 0x00030610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047708, XrefRangeEnd = 1047714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateTextBackingArray(string sourceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00032454 File Offset: 0x00030654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047714, XrefRangeEnd = 1047722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x000324B4 File Offset: 0x000306B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047722, XrefRangeEnd = 1047733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateTextBackingArray(StringBuilder sourceText, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_StringBuilder_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00032514 File Offset: 0x00030714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047733, XrefRangeEnd = 1047740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateTextBackingArray(Il2CppStructArray<char> sourceText, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00032574 File Offset: 0x00030774
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1047812, RefRangeEnd = 1047820, XrefRangeStart = 1047740, XrefRangeEnd = 1047812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateTextProcessingArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_PopulateTextProcessingArray_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x000325A8 File Offset: 0x000307A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047820, XrefRangeEnd = 1047827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextInternal(string sourceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetTextInternal_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x000325EC File Offset: 0x000307EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1047836, RefRangeEnd = 1047838, XrefRangeStart = 1047827, XrefRangeEnd = 1047836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string sourceText, bool syncTextInputBox = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref syncTextInputBox;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x0003263C File Offset: 0x0003083C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047838, XrefRangeEnd = 1047839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string sourceText, float arg0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg0;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x0003268C File Offset: 0x0003088C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047839, XrefRangeEnd = 1047840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string sourceText, float arg0, float arg1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x000326EC File Offset: 0x000308EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047840, XrefRangeEnd = 1047841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string sourceText, float arg0, float arg1, float arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00032758 File Offset: 0x00030958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047841, XrefRangeEnd = 1047842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x000327D4 File Offset: 0x000309D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047842, XrefRangeEnd = 1047843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg3;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0003285C File Offset: 0x00030A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047843, XrefRangeEnd = 1047844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg3;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg4;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg5;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x000328F4 File Offset: 0x00030AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047844, XrefRangeEnd = 1047845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg3;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg4;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg5;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg6;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00032998 File Offset: 0x00030B98
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1047866, RefRangeEnd = 1047873, XrefRangeStart = 1047845, XrefRangeEnd = 1047866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg3;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg4;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg5;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg6;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg7;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00032A4C File Offset: 0x00030C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047873, XrefRangeEnd = 1047876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(StringBuilder sourceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00032A90 File Offset: 0x00030C90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1047889, RefRangeEnd = 1047890, XrefRangeStart = 1047876, XrefRangeEnd = 1047889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(StringBuilder sourceText, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Private_Void_StringBuilder_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00032AF0 File Offset: 0x00030CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047890, XrefRangeEnd = 1047892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(Il2CppStructArray<char> sourceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00032B34 File Offset: 0x00030D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047892, XrefRangeEnd = 1047893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(Il2CppStructArray<char> sourceText, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetText_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00032B94 File Offset: 0x00030D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCharArray(Il2CppStructArray<char> sourceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetCharArray_Public_Void_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00032BD8 File Offset: 0x00030DD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1047903, RefRangeEnd = 1047906, XrefRangeStart = 1047893, XrefRangeEnd = 1047903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCharArray(Il2CppStructArray<char> sourceText, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SetCharArray_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00032C38 File Offset: 0x00030E38
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1047917, RefRangeEnd = 1047923, XrefRangeStart = 1047906, XrefRangeEnd = 1047917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Style GetStyle(int hashCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetStyle_Private_TMP_Style_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Style>(intPtr3) : null;
			}
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00032C84 File Offset: 0x00030E84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1047940, RefRangeEnd = 1047941, XrefRangeStart = 1047923, XrefRangeEnd = 1047940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReplaceOpeningStyleTag(ref TMP_Text.TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref Il2CppStructArray<TMP_Text.UnicodeChar> charBuffer, ref int writeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &srcOffset;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ReplaceOpeningStyleTag_Private_Boolean_byref_TextBackingContainer_Int32_byref_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			charBuffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<TMP_Text.UnicodeChar>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00032D28 File Offset: 0x00030F28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1047972, RefRangeEnd = 1047974, XrefRangeStart = 1047941, XrefRangeEnd = 1047972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReplaceOpeningStyleTag(ref Il2CppStructArray<int> sourceText, int srcIndex, out int srcOffset, ref Il2CppStructArray<TMP_Text.UnicodeChar> charBuffer, ref int writeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &srcOffset;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ReplaceOpeningStyleTag_Private_Boolean_byref_Il2CppStructArray_1_Int32_Int32_byref_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			sourceText = ((intPtr5 == 0) ? null : new Il2CppStructArray<int>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			charBuffer = ((intPtr6 == 0) ? null : new Il2CppStructArray<TMP_Text.UnicodeChar>(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00032DE4 File Offset: 0x00030FE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1047981, RefRangeEnd = 1047982, XrefRangeStart = 1047974, XrefRangeEnd = 1047981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplaceClosingStyleTag(ref TMP_Text.TextBackingContainer sourceText, int srcIndex, ref Il2CppStructArray<TMP_Text.UnicodeChar> charBuffer, ref int writeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(sourceText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ReplaceClosingStyleTag_Private_Void_byref_TextBackingContainer_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			charBuffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<TMP_Text.UnicodeChar>(intPtr4));
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00032E6C File Offset: 0x0003106C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1048008, RefRangeEnd = 1048010, XrefRangeStart = 1047982, XrefRangeEnd = 1048008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplaceClosingStyleTag(ref Il2CppStructArray<int> sourceText, int srcIndex, ref Il2CppStructArray<TMP_Text.UnicodeChar> charBuffer, ref int writeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(sourceText);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ReplaceClosingStyleTag_Private_Void_byref_Il2CppStructArray_1_Int32_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			sourceText = ((intPtr5 == 0) ? null : new Il2CppStructArray<int>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			charBuffer = ((intPtr6 == 0) ? null : new Il2CppStructArray<TMP_Text.UnicodeChar>(intPtr6));
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00032F0C File Offset: 0x0003110C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1048016, RefRangeEnd = 1048017, XrefRangeStart = 1048010, XrefRangeEnd = 1048016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InsertOpeningStyleTag(TMP_Style style, int srcIndex, ref Il2CppStructArray<TMP_Text.UnicodeChar> charBuffer, ref int writeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(style);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_InsertOpeningStyleTag_Private_Boolean_TMP_Style_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			charBuffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<TMP_Text.UnicodeChar>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00032FA0 File Offset: 0x000311A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1048024, RefRangeEnd = 1048025, XrefRangeStart = 1048017, XrefRangeEnd = 1048024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertClosingStyleTag(ref Il2CppStructArray<TMP_Text.UnicodeChar> charBuffer, ref int writeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(charBuffer);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_InsertClosingStyleTag_Private_Void_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			charBuffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<TMP_Text.UnicodeChar>(intPtr4));
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x00033008 File Offset: 0x00031208
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1048029, RefRangeEnd = 1048031, XrefRangeStart = 1048025, XrefRangeEnd = 1048029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMarkupTagHashCode(Il2CppStructArray<int> tagDefinition, int readIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tagDefinition);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetMarkupTagHashCode_Private_Int32_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x00033064 File Offset: 0x00031264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048031, XrefRangeEnd = 1048037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMarkupTagHashCode(TMP_Text.TextBackingContainer tagDefinition, int readIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tagDefinition));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetMarkupTagHashCode_Private_Int32_TextBackingContainer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x000330C4 File Offset: 0x000312C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048037, XrefRangeEnd = 1048042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetStyleHashCode(ref Il2CppStructArray<int> text, int index, out int closeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(text);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &closeIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetStyleHashCode_Private_Int32_byref_Il2CppStructArray_1_Int32_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			text = ((intPtr4 == 0) ? null : new Il2CppStructArray<int>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00033144 File Offset: 0x00031344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048042, XrefRangeEnd = 1048052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetStyleHashCode(ref TMP_Text.TextBackingContainer text, int index, out int closeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &closeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetStyleHashCode_Private_Int32_byref_TextBackingContainer_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x000331B0 File Offset: 0x000313B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048052, XrefRangeEnd = 1048062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResizeInternalArray<T>(ref Il2CppArrayBase<T> array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.MethodInfoStoreGeneric_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
			}
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00033208 File Offset: 0x00031408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048062, XrefRangeEnd = 1048064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResizeInternalArray<T>(ref Il2CppArrayBase<T> array, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.MethodInfoStoreGeneric_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			array = ((intPtr4 == 0) ? null : new Il2CppArrayBase<T>(intPtr4));
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x00033270 File Offset: 0x00031470
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1048099, RefRangeEnd = 1048100, XrefRangeStart = 1048064, XrefRangeEnd = 1048099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref padding;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref precision;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_AddFloatToInternalTextBackingArray_Private_Void_Single_Int32_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x000332DC File Offset: 0x000314DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048100, XrefRangeEnd = 1048106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref padding;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &writeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_AddIntegerToInternalTextBackingArray_Private_Void_Double_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x00033338 File Offset: 0x00031538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048106, XrefRangeEnd = 1048115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string InternalTextBackingArrayToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_InternalTextBackingArrayToString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x00033370 File Offset: 0x00031570
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int SetArraySizes(Il2CppStructArray<TMP_Text.UnicodeChar> unicodeChars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unicodeChars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetArraySizes_Internal_Virtual_New_Int32_Il2CppStructArray_1_UnicodeChar_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x000333C8 File Offset: 0x000315C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048115, XrefRangeEnd = 1048117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetPreferredValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x00033404 File Offset: 0x00031604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048117, XrefRangeEnd = 1048120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetPreferredValues(float width, float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0003345C File Offset: 0x0003165C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048120, XrefRangeEnd = 1048133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetPreferredValues(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x000334AC File Offset: 0x000316AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048133, XrefRangeEnd = 1048142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetPreferredValues(string text, float width, float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_String_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x00033518 File Offset: 0x00031718
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1048153, RefRangeEnd = 1048155, XrefRangeStart = 1048142, XrefRangeEnd = 1048153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPreferredWidth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetPreferredWidth_Protected_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00033554 File Offset: 0x00031754
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1048156, RefRangeEnd = 1048159, XrefRangeStart = 1048155, XrefRangeEnd = 1048156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPreferredWidth(Vector2 margin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref margin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetPreferredWidth_Private_Single_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x000335A0 File Offset: 0x000317A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1048174, RefRangeEnd = 1048176, XrefRangeStart = 1048159, XrefRangeEnd = 1048174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPreferredHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetPreferredHeight_Protected_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x000335DC File Offset: 0x000317DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1048177, RefRangeEnd = 1048180, XrefRangeStart = 1048176, XrefRangeEnd = 1048177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPreferredHeight(Vector2 margin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref margin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetPreferredHeight_Private_Single_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00033628 File Offset: 0x00031828
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1048181, RefRangeEnd = 1048183, XrefRangeStart = 1048180, XrefRangeEnd = 1048181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetRenderedValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetRenderedValues_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00033664 File Offset: 0x00031864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048183, XrefRangeEnd = 1048184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetRenderedValues(bool onlyVisibleCharacters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref onlyVisibleCharacters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetRenderedValues_Public_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x000336B0 File Offset: 0x000318B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRenderedWidth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetRenderedWidth_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x000336EC File Offset: 0x000318EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048184, XrefRangeEnd = 1048185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRenderedWidth(bool onlyVisibleCharacters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref onlyVisibleCharacters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetRenderedWidth_Protected_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00033738 File Offset: 0x00031938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRenderedHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetRenderedHeight_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00033774 File Offset: 0x00031974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048185, XrefRangeEnd = 1048186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRenderedHeight(bool onlyVisibleCharacters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref onlyVisibleCharacters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetRenderedHeight_Protected_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x000337C0 File Offset: 0x000319C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048186, XrefRangeEnd = 1048405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &fontSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref marginSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTextAutoSizingEnabled;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isWordWrappingEnabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_CalculatePreferredValues_Protected_Virtual_New_Vector2_byref_Single_Vector2_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00033840 File Offset: 0x00031A40
		[CallerCount(492)]
		[CachedScanResults(RefRangeStart = 547521, RefRangeEnd = 548013, XrefRangeStart = 547521, XrefRangeEnd = 548013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Bounds GetCompoundBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetCompoundBounds_Protected_Virtual_New_Bounds_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00033888 File Offset: 0x00031A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048405, XrefRangeEnd = 1048406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Rect GetCanvasSpaceClippingRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetCanvasSpaceClippingRect_Internal_Virtual_New_Rect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x000338D0 File Offset: 0x00031AD0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1048420, RefRangeEnd = 1048426, XrefRangeStart = 1048406, XrefRangeEnd = 1048420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bounds GetTextBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetTextBounds_Protected_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x0003390C File Offset: 0x00031B0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1048440, RefRangeEnd = 1048443, XrefRangeStart = 1048426, XrefRangeEnd = 1048440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bounds GetTextBounds(bool onlyVisibleCharacters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref onlyVisibleCharacters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetTextBounds_Protected_Bounds_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00033958 File Offset: 0x00031B58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1048443, RefRangeEnd = 1048446, XrefRangeStart = 1048443, XrefRangeEnd = 1048443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdjustLineOffset(int startIndex, int endIndex, float offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_AdjustLineOffset_Protected_Void_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x000339B4 File Offset: 0x00031BB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1048462, RefRangeEnd = 1048465, XrefRangeStart = 1048446, XrefRangeEnd = 1048462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResizeLineExtents(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ResizeLineExtents_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x000339F4 File Offset: 0x00031BF4
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TMP_TextInfo GetTextInfo(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetTextInfo_Public_Virtual_New_TMP_TextInfo_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_TextInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00033A50 File Offset: 0x00031C50
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ComputeMarginSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_ComputeMarginSize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x00033A8C File Offset: 0x00031C8C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1048484, RefRangeEnd = 1048488, XrefRangeStart = 1048465, XrefRangeEnd = 1048484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float glyphAdjustment, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseScale;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentElementScale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentEmScale;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glyphAdjustment;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref boldSpacingAdjustment;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref characterSpacingAdjustment;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineGap;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isMaxVisibleDescenderSet;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maxVisibleDescender;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_InsertNewLine_Protected_Void_Int32_Single_Single_Single_Single_Single_Single_Single_Single_byref_Boolean_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00033B5C File Offset: 0x00031D5C
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 1048508, RefRangeEnd = 1048544, XrefRangeStart = 1048488, XrefRangeEnd = 1048508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveWordWrappingState(ref WordWrapState state, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(state);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_SaveWordWrappingState_Protected_Void_byref_WordWrapState_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00033BBC File Offset: 0x00031DBC
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1048565, RefRangeEnd = 1048588, XrefRangeStart = 1048544, XrefRangeEnd = 1048565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RestoreWordWrappingState(ref WordWrapState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_RestoreWordWrappingState_Protected_Int32_byref_WordWrapState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x00033C0C File Offset: 0x00031E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048588, XrefRangeEnd = 1048628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref padding;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style_padding;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vertexColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SaveGlyphVertexInfo_Protected_Virtual_New_Void_Single_Single_Color32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00033C74 File Offset: 0x00031E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048628, XrefRangeEnd = 1048673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SaveSpriteVertexInfo(Color32 vertexColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vertexColor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SaveSpriteVertexInfo_Protected_Virtual_New_Void_Color32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00033CC0 File Offset: 0x00031EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048673, XrefRangeEnd = 1048678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FillCharacterVertexBuffers(int i, int index_X4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index_X4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_FillCharacterVertexBuffers_Protected_Virtual_New_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00033D18 File Offset: 0x00031F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048678, XrefRangeEnd = 1048684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index_X4;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVolumetric;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_FillCharacterVertexBuffers_Protected_Virtual_New_Void_Int32_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00033D80 File Offset: 0x00031F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048684, XrefRangeEnd = 1048689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FillSpriteVertexBuffers(int i, int index_X4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index_X4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_FillSpriteVertexBuffers_Protected_Virtual_New_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00033DD8 File Offset: 0x00031FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048689, XrefRangeEnd = 1048714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startScale;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endScale;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxScale;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sdfScale;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref underlineColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_DrawUnderlineMesh_Protected_Virtual_New_Void_Vector3_Vector3_byref_Int32_Single_Single_Single_Single_Color32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00033E84 File Offset: 0x00032084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048714, XrefRangeEnd = 1048724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref highlightColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_DrawTextHighlight_Protected_Virtual_New_Void_Vector3_Vector3_byref_Int32_Color32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00033EF8 File Offset: 0x000320F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1048761, RefRangeEnd = 1048763, XrefRangeStart = 1048724, XrefRangeEnd = 1048761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadDefaultSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_LoadDefaultSettings_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00033F2C File Offset: 0x0003212C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1048765, RefRangeEnd = 1048767, XrefRangeStart = 1048763, XrefRangeEnd = 1048765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetSpecialCharacters(TMP_FontAsset fontAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetSpecialCharacters_Protected_Void_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00033F70 File Offset: 0x00032170
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1048792, RefRangeEnd = 1048795, XrefRangeStart = 1048767, XrefRangeEnd = 1048792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetEllipsisSpecialCharacter_Protected_Void_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00033FB4 File Offset: 0x000321B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1048810, RefRangeEnd = 1048813, XrefRangeStart = 1048795, XrefRangeEnd = 1048810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUnderlineSpecialCharacter_Protected_Void_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00033FF8 File Offset: 0x000321F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048813, XrefRangeEnd = 1048814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplaceTagWithCharacter(Il2CppStructArray<int> chars, int insertionIndex, int tagLength, char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref insertionIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ReplaceTagWithCharacter_Protected_Void_Il2CppStructArray_1_Int32_Int32_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x00034064 File Offset: 0x00032264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048814, XrefRangeEnd = 1048815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_FontAsset GetFontAssetForWeight(int fontWeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fontWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetFontAssetForWeight_Protected_TMP_FontAsset_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr3) : null;
			}
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x000340B0 File Offset: 0x000322B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1048833, RefRangeEnd = 1048835, XrefRangeStart = 1048815, XrefRangeEnd = 1048833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_TextElement GetTextElement(uint unicode, TMP_FontAsset fontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isUsingAlternativeTypeface)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fontStyle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fontWeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isUsingAlternativeTypeface;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetTextElement_Internal_TMP_TextElement_UInt32_TMP_FontAsset_FontStyles_FontWeight_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_TextElement>(intPtr3) : null;
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0003413C File Offset: 0x0003233C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetActiveSubMeshes(bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_SetActiveSubMeshes_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00034188 File Offset: 0x00032388
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroySubMeshObjects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_DestroySubMeshObjects_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x000341C4 File Offset: 0x000323C4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_ClearMesh_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00034200 File Offset: 0x00032400
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearMesh(bool uploadGeometry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uploadGeometry;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_ClearMesh_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x0003424C File Offset: 0x0003244C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048835, XrefRangeEnd = 1048841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetParsedText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_GetParsedText_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00034290 File Offset: 0x00032490
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1048851, RefRangeEnd = 1048853, XrefRangeStart = 1048841, XrefRangeEnd = 1048851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSelfOrLinkedAncestor(TMP_Text targetTextComponent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetTextComponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_IsSelfOrLinkedAncestor_Internal_Boolean_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x000342E0 File Offset: 0x000324E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1048865, RefRangeEnd = 1048868, XrefRangeStart = 1048853, XrefRangeEnd = 1048865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseLinkedTextComponent(TMP_Text targetTextComponent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetTextComponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ReleaseLinkedTextComponent_Internal_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x00034324 File Offset: 0x00032524
		[CallerCount(0)]
		public unsafe Vector2 PackUV(float x, float y, float scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_PackUV_Protected_Vector2_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x0003438C File Offset: 0x0003258C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1048868, RefRangeEnd = 1048876, XrefRangeStart = 1048868, XrefRangeEnd = 1048868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float PackUV(float x, float y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_PackUV_Protected_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x000343E4 File Offset: 0x000325E4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InternalUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_Text.NativeMethodInfoPtr_InternalUpdate_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00034420 File Offset: 0x00032620
		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 1048876, RefRangeEnd = 1048958, XrefRangeStart = 1048876, XrefRangeEnd = 1048876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int HexToInt(char hex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_HexToInt_Protected_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x0003446C File Offset: 0x0003266C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048958, XrefRangeEnd = 1048966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF16(string text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF16_Protected_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x000344C8 File Offset: 0x000326C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1048970, RefRangeEnd = 1048972, XrefRangeStart = 1048966, XrefRangeEnd = 1048970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF16(Il2CppStructArray<int> text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF16_Protected_Int32_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00034524 File Offset: 0x00032724
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1048970, RefRangeEnd = 1048972, XrefRangeStart = 1048970, XrefRangeEnd = 1048972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF16(Il2CppStructArray<uint> text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF16_Internal_Int32_Il2CppStructArray_1_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00034580 File Offset: 0x00032780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048972, XrefRangeEnd = 1048980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF16(StringBuilder text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF16_Protected_Int32_StringBuilder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x000345DC File Offset: 0x000327DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1048988, RefRangeEnd = 1048989, XrefRangeStart = 1048980, XrefRangeEnd = 1048988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF16(TMP_Text.TextBackingContainer text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(text));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF16_Private_Int32_TextBackingContainer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x0003463C File Offset: 0x0003283C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1048989, XrefRangeEnd = 1049005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF32(string text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF32_Protected_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x00034698 File Offset: 0x00032898
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1049013, RefRangeEnd = 1049015, XrefRangeStart = 1049005, XrefRangeEnd = 1049013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF32(Il2CppStructArray<int> text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF32_Protected_Int32_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x000346F4 File Offset: 0x000328F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1049013, RefRangeEnd = 1049015, XrefRangeStart = 1049013, XrefRangeEnd = 1049015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF32(Il2CppStructArray<uint> text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF32_Internal_Int32_Il2CppStructArray_1_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00034750 File Offset: 0x00032950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049015, XrefRangeEnd = 1049031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF32(StringBuilder text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF32_Protected_Int32_StringBuilder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x000347AC File Offset: 0x000329AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1049047, RefRangeEnd = 1049048, XrefRangeStart = 1049031, XrefRangeEnd = 1049047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUTF32(TMP_Text.TextBackingContainer text, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(text));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetUTF32_Private_Int32_TextBackingContainer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0003480C File Offset: 0x00032A0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1049064, RefRangeEnd = 1049065, XrefRangeStart = 1049048, XrefRangeEnd = 1049064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color32 HexCharsToColor(Il2CppStructArray<char> hexChars, int tagCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hexChars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tagCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_HexCharsToColor_Protected_Color32_Il2CppStructArray_1_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x00034868 File Offset: 0x00032A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049065, XrefRangeEnd = 1049078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color32 HexCharsToColor(Il2CppStructArray<char> hexChars, int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hexChars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_HexCharsToColor_Protected_Color32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x000348D4 File Offset: 0x00032AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049078, XrefRangeEnd = 1049082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAttributeParameters(Il2CppStructArray<char> chars, int startIndex, int length, ref Il2CppStructArray<float> parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_GetAttributeParameters_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_byref_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parameters = ((intPtr4 == 0) ? null : new Il2CppStructArray<float>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00034968 File Offset: 0x00032B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049082, XrefRangeEnd = 1049083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ConvertToFloat(Il2CppStructArray<char> chars, int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ConvertToFloat_Protected_Single_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x000349D4 File Offset: 0x00032BD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1049086, RefRangeEnd = 1049087, XrefRangeStart = 1049083, XrefRangeEnd = 1049086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ConvertToFloat(Il2CppStructArray<char> chars, int startIndex, int length, out int lastIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lastIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ConvertToFloat_Protected_Single_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00034A4C File Offset: 0x00032C4C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1049254, RefRangeEnd = 1049259, XrefRangeStart = 1049087, XrefRangeEnd = 1049254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateHtmlTag(Il2CppStructArray<TMP_Text.UnicodeChar> chars, int startIndex, out int endIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &endIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr_ValidateHtmlTag_Internal_Boolean_Il2CppStructArray_1_UnicodeChar_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00034AB8 File Offset: 0x00032CB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1049384, RefRangeEnd = 1049386, XrefRangeStart = 1049259, XrefRangeEnd = 1049384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Text()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00006CE3 File Offset: 0x00004EE3
		public TMP_Text(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000BAC RID: 2988 RVA: 0x00034AF4 File Offset: 0x00032CF4
		// (set) Token: 0x06000BAD RID: 2989 RVA: 0x00006CEC File Offset: 0x00004EEC
		public unsafe string m_text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000BAE RID: 2990 RVA: 0x00034B1C File Offset: 0x00032D1C
		// (set) Token: 0x06000BAF RID: 2991 RVA: 0x00006D0B File Offset: 0x00004F0B
		public unsafe bool m_IsTextBackingStringDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_IsTextBackingStringDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_IsTextBackingStringDirty)) = value;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x00034B44 File Offset: 0x00032D44
		// (set) Token: 0x06000BB1 RID: 2993 RVA: 0x00006D26 File Offset: 0x00004F26
		public unsafe ITextPreprocessor m_TextPreprocessor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextPreprocessor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITextPreprocessor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextPreprocessor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x00034B74 File Offset: 0x00032D74
		// (set) Token: 0x06000BB3 RID: 2995 RVA: 0x00006D45 File Offset: 0x00004F45
		public unsafe bool m_isRightToLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isRightToLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isRightToLeft)) = value;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x00034B9C File Offset: 0x00032D9C
		// (set) Token: 0x06000BB5 RID: 2997 RVA: 0x00006D60 File Offset: 0x00004F60
		public unsafe TMP_FontAsset m_fontAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x00034BCC File Offset: 0x00032DCC
		// (set) Token: 0x06000BB7 RID: 2999 RVA: 0x00006D7F File Offset: 0x00004F7F
		public unsafe TMP_FontAsset m_currentFontAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentFontAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentFontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x00034BFC File Offset: 0x00032DFC
		// (set) Token: 0x06000BB9 RID: 3001 RVA: 0x00006D9E File Offset: 0x00004F9E
		public unsafe bool m_isSDFShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isSDFShader);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isSDFShader)) = value;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000BBA RID: 3002 RVA: 0x00034C24 File Offset: 0x00032E24
		// (set) Token: 0x06000BBB RID: 3003 RVA: 0x00006DB9 File Offset: 0x00004FB9
		public unsafe Material m_sharedMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_sharedMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_sharedMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000BBC RID: 3004 RVA: 0x00034C54 File Offset: 0x00032E54
		// (set) Token: 0x06000BBD RID: 3005 RVA: 0x00006DD8 File Offset: 0x00004FD8
		public unsafe Material m_currentMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x00034C84 File Offset: 0x00032E84
		// (set) Token: 0x06000BBF RID: 3007 RVA: 0x00006DF7 File Offset: 0x00004FF7
		public unsafe static Il2CppReferenceArray<MaterialReference> m_materialReferences
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_materialReferences, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MaterialReference>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_materialReferences, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x00034CAC File Offset: 0x00032EAC
		// (set) Token: 0x06000BC1 RID: 3009 RVA: 0x00006E09 File Offset: 0x00005009
		public unsafe static Dictionary<int, int> m_materialReferenceIndexLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_materialReferenceIndexLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_materialReferenceIndexLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x00034CD4 File Offset: 0x00032ED4
		// (set) Token: 0x06000BC3 RID: 3011 RVA: 0x00006E1B File Offset: 0x0000501B
		public unsafe static TMP_TextProcessingStack<MaterialReference> m_materialReferenceStack
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<MaterialReference>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_materialReferenceStack, intPtr);
				return new TMP_TextProcessingStack<MaterialReference>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<MaterialReference>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_materialReferenceStack, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x00034D10 File Offset: 0x00032F10
		// (set) Token: 0x06000BC5 RID: 3013 RVA: 0x00006E32 File Offset: 0x00005032
		public unsafe int m_currentMaterialIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentMaterialIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentMaterialIndex)) = value;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x00034D38 File Offset: 0x00032F38
		// (set) Token: 0x06000BC7 RID: 3015 RVA: 0x00006E4D File Offset: 0x0000504D
		public unsafe Il2CppReferenceArray<Material> m_fontSharedMaterials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSharedMaterials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSharedMaterials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x00034D68 File Offset: 0x00032F68
		// (set) Token: 0x06000BC9 RID: 3017 RVA: 0x00006E6C File Offset: 0x0000506C
		public unsafe Material m_fontMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x00034D98 File Offset: 0x00032F98
		// (set) Token: 0x06000BCB RID: 3019 RVA: 0x00006E8B File Offset: 0x0000508B
		public unsafe Il2CppReferenceArray<Material> m_fontMaterials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontMaterials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontMaterials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x00034DC8 File Offset: 0x00032FC8
		// (set) Token: 0x06000BCD RID: 3021 RVA: 0x00006EAA File Offset: 0x000050AA
		public unsafe bool m_isMaterialDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isMaterialDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isMaterialDirty)) = value;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x00034DF0 File Offset: 0x00032FF0
		// (set) Token: 0x06000BCF RID: 3023 RVA: 0x00006EC5 File Offset: 0x000050C5
		public unsafe Color32 m_fontColor32
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontColor32);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontColor32)) = value;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x00034E18 File Offset: 0x00033018
		// (set) Token: 0x06000BD1 RID: 3025 RVA: 0x00006EE0 File Offset: 0x000050E0
		public unsafe Color m_fontColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontColor)) = value;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x00034E40 File Offset: 0x00033040
		// (set) Token: 0x06000BD3 RID: 3027 RVA: 0x00006EFB File Offset: 0x000050FB
		public unsafe static Color32 s_colorWhite
		{
			get
			{
				Color32 color;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_s_colorWhite, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_s_colorWhite, (void*)(&value));
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x00034E5C File Offset: 0x0003305C
		// (set) Token: 0x06000BD5 RID: 3029 RVA: 0x00006F09 File Offset: 0x00005109
		public unsafe Color32 m_underlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_underlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_underlineColor)) = value;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x00034E84 File Offset: 0x00033084
		// (set) Token: 0x06000BD7 RID: 3031 RVA: 0x00006F24 File Offset: 0x00005124
		public unsafe Color32 m_strikethroughColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_strikethroughColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_strikethroughColor)) = value;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x00034EAC File Offset: 0x000330AC
		// (set) Token: 0x06000BD9 RID: 3033 RVA: 0x00006F3F File Offset: 0x0000513F
		public unsafe bool m_enableVertexGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableVertexGradient);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableVertexGradient)) = value;
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x00034ED4 File Offset: 0x000330D4
		// (set) Token: 0x06000BDB RID: 3035 RVA: 0x00006F5A File Offset: 0x0000515A
		public unsafe ColorMode m_colorMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorMode)) = value;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x00034EFC File Offset: 0x000330FC
		// (set) Token: 0x06000BDD RID: 3037 RVA: 0x00006F75 File Offset: 0x00005175
		public unsafe VertexGradient m_fontColorGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontColorGradient);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontColorGradient)) = value;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000BDE RID: 3038 RVA: 0x00034F24 File Offset: 0x00033124
		// (set) Token: 0x06000BDF RID: 3039 RVA: 0x00006F90 File Offset: 0x00005190
		public unsafe TMP_ColorGradient m_fontColorGradientPreset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontColorGradientPreset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_ColorGradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontColorGradientPreset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x00034F54 File Offset: 0x00033154
		// (set) Token: 0x06000BE1 RID: 3041 RVA: 0x00006FAF File Offset: 0x000051AF
		public unsafe TMP_SpriteAsset m_spriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x00034F84 File Offset: 0x00033184
		// (set) Token: 0x06000BE3 RID: 3043 RVA: 0x00006FCE File Offset: 0x000051CE
		public unsafe bool m_tintAllSprites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_tintAllSprites);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_tintAllSprites)) = value;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x00034FAC File Offset: 0x000331AC
		// (set) Token: 0x06000BE5 RID: 3045 RVA: 0x00006FE9 File Offset: 0x000051E9
		public unsafe bool m_tintSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_tintSprite);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_tintSprite)) = value;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x00034FD4 File Offset: 0x000331D4
		// (set) Token: 0x06000BE7 RID: 3047 RVA: 0x00007004 File Offset: 0x00005204
		public unsafe Color32 m_spriteColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteColor)) = value;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x00034FFC File Offset: 0x000331FC
		// (set) Token: 0x06000BE9 RID: 3049 RVA: 0x0000701F File Offset: 0x0000521F
		public unsafe TMP_StyleSheet m_StyleSheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_StyleSheet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_StyleSheet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_StyleSheet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x0003502C File Offset: 0x0003322C
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x0000703E File Offset: 0x0000523E
		public unsafe TMP_Style m_TextStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextStyle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Style>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextStyle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x0003505C File Offset: 0x0003325C
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x0000705D File Offset: 0x0000525D
		public unsafe int m_TextStyleHashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextStyleHashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextStyleHashCode)) = value;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x00035084 File Offset: 0x00033284
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x00007078 File Offset: 0x00005278
		public unsafe bool m_overrideHtmlColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_overrideHtmlColors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_overrideHtmlColors)) = value;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x000350AC File Offset: 0x000332AC
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x00007093 File Offset: 0x00005293
		public unsafe Color32 m_faceColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_faceColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_faceColor)) = value;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x000350D4 File Offset: 0x000332D4
		// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x000070AE File Offset: 0x000052AE
		public unsafe Color32 m_outlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_outlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_outlineColor)) = value;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x000350FC File Offset: 0x000332FC
		// (set) Token: 0x06000BF5 RID: 3061 RVA: 0x000070C9 File Offset: 0x000052C9
		public unsafe float m_outlineWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_outlineWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_outlineWidth)) = value;
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x00035124 File Offset: 0x00033324
		// (set) Token: 0x06000BF7 RID: 3063 RVA: 0x000070E4 File Offset: 0x000052E4
		public unsafe float m_fontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSize)) = value;
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x0003514C File Offset: 0x0003334C
		// (set) Token: 0x06000BF9 RID: 3065 RVA: 0x000070FF File Offset: 0x000052FF
		public unsafe float m_currentFontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentFontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentFontSize)) = value;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x00035174 File Offset: 0x00033374
		// (set) Token: 0x06000BFB RID: 3067 RVA: 0x0000711A File Offset: 0x0000531A
		public unsafe float m_fontSizeBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSizeBase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSizeBase)) = value;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000BFC RID: 3068 RVA: 0x0003519C File Offset: 0x0003339C
		// (set) Token: 0x06000BFD RID: 3069 RVA: 0x00007135 File Offset: 0x00005335
		public TMP_TextProcessingStack<float> m_sizeStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_sizeStack);
				return new TMP_TextProcessingStack<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_sizeStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000BFE RID: 3070 RVA: 0x000351CC File Offset: 0x000333CC
		// (set) Token: 0x06000BFF RID: 3071 RVA: 0x00007163 File Offset: 0x00005363
		public unsafe FontWeight m_fontWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontWeight)) = value;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000C00 RID: 3072 RVA: 0x000351F4 File Offset: 0x000333F4
		// (set) Token: 0x06000C01 RID: 3073 RVA: 0x0000717E File Offset: 0x0000537E
		public unsafe FontWeight m_FontWeightInternal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_FontWeightInternal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_FontWeightInternal)) = value;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000C02 RID: 3074 RVA: 0x0003521C File Offset: 0x0003341C
		// (set) Token: 0x06000C03 RID: 3075 RVA: 0x00007199 File Offset: 0x00005399
		public TMP_TextProcessingStack<FontWeight> m_FontWeightStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_FontWeightStack);
				return new TMP_TextProcessingStack<FontWeight>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<FontWeight>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_FontWeightStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<FontWeight>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x0003524C File Offset: 0x0003344C
		// (set) Token: 0x06000C05 RID: 3077 RVA: 0x000071C7 File Offset: 0x000053C7
		public unsafe bool m_enableAutoSizing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableAutoSizing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableAutoSizing)) = value;
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x00035274 File Offset: 0x00033474
		// (set) Token: 0x06000C07 RID: 3079 RVA: 0x000071E2 File Offset: 0x000053E2
		public unsafe float m_maxFontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxFontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxFontSize)) = value;
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x0003529C File Offset: 0x0003349C
		// (set) Token: 0x06000C09 RID: 3081 RVA: 0x000071FD File Offset: 0x000053FD
		public unsafe float m_minFontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_minFontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_minFontSize)) = value;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x000352C4 File Offset: 0x000334C4
		// (set) Token: 0x06000C0B RID: 3083 RVA: 0x00007218 File Offset: 0x00005418
		public unsafe int m_AutoSizeIterationCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_AutoSizeIterationCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_AutoSizeIterationCount)) = value;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000C0C RID: 3084 RVA: 0x000352EC File Offset: 0x000334EC
		// (set) Token: 0x06000C0D RID: 3085 RVA: 0x00007233 File Offset: 0x00005433
		public unsafe int m_AutoSizeMaxIterationCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_AutoSizeMaxIterationCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_AutoSizeMaxIterationCount)) = value;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x00035314 File Offset: 0x00033514
		// (set) Token: 0x06000C0F RID: 3087 RVA: 0x0000724E File Offset: 0x0000544E
		public unsafe bool m_IsAutoSizePointSizeSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_IsAutoSizePointSizeSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_IsAutoSizePointSizeSet)) = value;
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000C10 RID: 3088 RVA: 0x0003533C File Offset: 0x0003353C
		// (set) Token: 0x06000C11 RID: 3089 RVA: 0x00007269 File Offset: 0x00005469
		public unsafe float m_fontSizeMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSizeMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSizeMin)) = value;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000C12 RID: 3090 RVA: 0x00035364 File Offset: 0x00033564
		// (set) Token: 0x06000C13 RID: 3091 RVA: 0x00007284 File Offset: 0x00005484
		public unsafe float m_fontSizeMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSizeMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontSizeMax)) = value;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x0003538C File Offset: 0x0003358C
		// (set) Token: 0x06000C15 RID: 3093 RVA: 0x0000729F File Offset: 0x0000549F
		public unsafe FontStyles m_fontStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontStyle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontStyle)) = value;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x000353B4 File Offset: 0x000335B4
		// (set) Token: 0x06000C17 RID: 3095 RVA: 0x000072BA File Offset: 0x000054BA
		public unsafe FontStyles m_FontStyleInternal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_FontStyleInternal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_FontStyleInternal)) = value;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000C18 RID: 3096 RVA: 0x000353DC File Offset: 0x000335DC
		// (set) Token: 0x06000C19 RID: 3097 RVA: 0x000072D5 File Offset: 0x000054D5
		public unsafe TMP_FontStyleStack m_fontStyleStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontStyleStack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontStyleStack)) = value;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000C1A RID: 3098 RVA: 0x00035404 File Offset: 0x00033604
		// (set) Token: 0x06000C1B RID: 3099 RVA: 0x000072F0 File Offset: 0x000054F0
		public unsafe bool m_isUsingBold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isUsingBold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isUsingBold)) = value;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000C1C RID: 3100 RVA: 0x0003542C File Offset: 0x0003362C
		// (set) Token: 0x06000C1D RID: 3101 RVA: 0x0000730B File Offset: 0x0000550B
		public unsafe HorizontalAlignmentOptions m_HorizontalAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_HorizontalAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_HorizontalAlignment)) = value;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000C1E RID: 3102 RVA: 0x00035454 File Offset: 0x00033654
		// (set) Token: 0x06000C1F RID: 3103 RVA: 0x00007326 File Offset: 0x00005526
		public unsafe VerticalAlignmentOptions m_VerticalAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_VerticalAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_VerticalAlignment)) = value;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000C20 RID: 3104 RVA: 0x0003547C File Offset: 0x0003367C
		// (set) Token: 0x06000C21 RID: 3105 RVA: 0x00007341 File Offset: 0x00005541
		public unsafe TextAlignmentOptions m_textAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_textAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_textAlignment)) = value;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000C22 RID: 3106 RVA: 0x000354A4 File Offset: 0x000336A4
		// (set) Token: 0x06000C23 RID: 3107 RVA: 0x0000735C File Offset: 0x0000555C
		public unsafe HorizontalAlignmentOptions m_lineJustification
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineJustification);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineJustification)) = value;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x000354CC File Offset: 0x000336CC
		// (set) Token: 0x06000C25 RID: 3109 RVA: 0x00007377 File Offset: 0x00005577
		public TMP_TextProcessingStack<HorizontalAlignmentOptions> m_lineJustificationStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineJustificationStack);
				return new TMP_TextProcessingStack<HorizontalAlignmentOptions>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<HorizontalAlignmentOptions>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineJustificationStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<HorizontalAlignmentOptions>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000C26 RID: 3110 RVA: 0x000354FC File Offset: 0x000336FC
		// (set) Token: 0x06000C27 RID: 3111 RVA: 0x000073A5 File Offset: 0x000055A5
		public unsafe Il2CppStructArray<Vector3> m_textContainerLocalCorners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_textContainerLocalCorners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_textContainerLocalCorners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000C28 RID: 3112 RVA: 0x0003552C File Offset: 0x0003372C
		// (set) Token: 0x06000C29 RID: 3113 RVA: 0x000073C4 File Offset: 0x000055C4
		public unsafe float m_characterSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_characterSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_characterSpacing)) = value;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x00035554 File Offset: 0x00033754
		// (set) Token: 0x06000C2B RID: 3115 RVA: 0x000073DF File Offset: 0x000055DF
		public unsafe float m_cSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_cSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_cSpacing)) = value;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x0003557C File Offset: 0x0003377C
		// (set) Token: 0x06000C2D RID: 3117 RVA: 0x000073FA File Offset: 0x000055FA
		public unsafe float m_monoSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_monoSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_monoSpacing)) = value;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x000355A4 File Offset: 0x000337A4
		// (set) Token: 0x06000C2F RID: 3119 RVA: 0x00007415 File Offset: 0x00005615
		public unsafe float m_wordSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_wordSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_wordSpacing)) = value;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000C30 RID: 3120 RVA: 0x000355CC File Offset: 0x000337CC
		// (set) Token: 0x06000C31 RID: 3121 RVA: 0x00007430 File Offset: 0x00005630
		public unsafe float m_lineSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineSpacing)) = value;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x000355F4 File Offset: 0x000337F4
		// (set) Token: 0x06000C33 RID: 3123 RVA: 0x0000744B File Offset: 0x0000564B
		public unsafe float m_lineSpacingDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineSpacingDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineSpacingDelta)) = value;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x0003561C File Offset: 0x0003381C
		// (set) Token: 0x06000C35 RID: 3125 RVA: 0x00007466 File Offset: 0x00005666
		public unsafe float m_lineHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineHeight)) = value;
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000C36 RID: 3126 RVA: 0x00035644 File Offset: 0x00033844
		// (set) Token: 0x06000C37 RID: 3127 RVA: 0x00007481 File Offset: 0x00005681
		public unsafe bool m_IsDrivenLineSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_IsDrivenLineSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_IsDrivenLineSpacing)) = value;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000C38 RID: 3128 RVA: 0x0003566C File Offset: 0x0003386C
		// (set) Token: 0x06000C39 RID: 3129 RVA: 0x0000749C File Offset: 0x0000569C
		public unsafe float m_lineSpacingMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineSpacingMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineSpacingMax)) = value;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000C3A RID: 3130 RVA: 0x00035694 File Offset: 0x00033894
		// (set) Token: 0x06000C3B RID: 3131 RVA: 0x000074B7 File Offset: 0x000056B7
		public unsafe float m_paragraphSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_paragraphSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_paragraphSpacing)) = value;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x000356BC File Offset: 0x000338BC
		// (set) Token: 0x06000C3D RID: 3133 RVA: 0x000074D2 File Offset: 0x000056D2
		public unsafe float m_charWidthMaxAdj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_charWidthMaxAdj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_charWidthMaxAdj)) = value;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x000356E4 File Offset: 0x000338E4
		// (set) Token: 0x06000C3F RID: 3135 RVA: 0x000074ED File Offset: 0x000056ED
		public unsafe float m_charWidthAdjDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_charWidthAdjDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_charWidthAdjDelta)) = value;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x0003570C File Offset: 0x0003390C
		// (set) Token: 0x06000C41 RID: 3137 RVA: 0x00007508 File Offset: 0x00005708
		public unsafe bool m_enableWordWrapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableWordWrapping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableWordWrapping)) = value;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x00035734 File Offset: 0x00033934
		// (set) Token: 0x06000C43 RID: 3139 RVA: 0x00007523 File Offset: 0x00005723
		public unsafe bool m_isCharacterWrappingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isCharacterWrappingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isCharacterWrappingEnabled)) = value;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x0003575C File Offset: 0x0003395C
		// (set) Token: 0x06000C45 RID: 3141 RVA: 0x0000753E File Offset: 0x0000573E
		public unsafe bool m_isNonBreakingSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isNonBreakingSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isNonBreakingSpace)) = value;
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x00035784 File Offset: 0x00033984
		// (set) Token: 0x06000C47 RID: 3143 RVA: 0x00007559 File Offset: 0x00005759
		public unsafe bool m_isIgnoringAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isIgnoringAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isIgnoringAlignment)) = value;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x000357AC File Offset: 0x000339AC
		// (set) Token: 0x06000C49 RID: 3145 RVA: 0x00007574 File Offset: 0x00005774
		public unsafe float m_wordWrappingRatios
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_wordWrappingRatios);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_wordWrappingRatios)) = value;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000C4A RID: 3146 RVA: 0x000357D4 File Offset: 0x000339D4
		// (set) Token: 0x06000C4B RID: 3147 RVA: 0x0000758F File Offset: 0x0000578F
		public unsafe TextOverflowModes m_overflowMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_overflowMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_overflowMode)) = value;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000C4C RID: 3148 RVA: 0x000357FC File Offset: 0x000339FC
		// (set) Token: 0x06000C4D RID: 3149 RVA: 0x000075AA File Offset: 0x000057AA
		public unsafe int m_firstOverflowCharacterIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_firstOverflowCharacterIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_firstOverflowCharacterIndex)) = value;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000C4E RID: 3150 RVA: 0x00035824 File Offset: 0x00033A24
		// (set) Token: 0x06000C4F RID: 3151 RVA: 0x000075C5 File Offset: 0x000057C5
		public unsafe TMP_Text m_linkedTextComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_linkedTextComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_linkedTextComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000C50 RID: 3152 RVA: 0x00035854 File Offset: 0x00033A54
		// (set) Token: 0x06000C51 RID: 3153 RVA: 0x000075E4 File Offset: 0x000057E4
		public unsafe TMP_Text parentLinkedComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_parentLinkedComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_parentLinkedComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x00035884 File Offset: 0x00033A84
		// (set) Token: 0x06000C53 RID: 3155 RVA: 0x00007603 File Offset: 0x00005803
		public unsafe bool m_isTextTruncated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isTextTruncated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isTextTruncated)) = value;
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x000358AC File Offset: 0x00033AAC
		// (set) Token: 0x06000C55 RID: 3157 RVA: 0x0000761E File Offset: 0x0000581E
		public unsafe bool m_enableKerning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableKerning);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableKerning)) = value;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x000358D4 File Offset: 0x00033AD4
		// (set) Token: 0x06000C57 RID: 3159 RVA: 0x00007639 File Offset: 0x00005839
		public unsafe float m_GlyphHorizontalAdvanceAdjustment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_GlyphHorizontalAdvanceAdjustment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_GlyphHorizontalAdvanceAdjustment)) = value;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x000358FC File Offset: 0x00033AFC
		// (set) Token: 0x06000C59 RID: 3161 RVA: 0x00007654 File Offset: 0x00005854
		public unsafe bool m_enableExtraPadding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableExtraPadding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_enableExtraPadding)) = value;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x00035924 File Offset: 0x00033B24
		// (set) Token: 0x06000C5B RID: 3163 RVA: 0x0000766F File Offset: 0x0000586F
		public unsafe bool checkPaddingRequired
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_checkPaddingRequired);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_checkPaddingRequired)) = value;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x0003594C File Offset: 0x00033B4C
		// (set) Token: 0x06000C5D RID: 3165 RVA: 0x0000768A File Offset: 0x0000588A
		public unsafe bool m_isRichText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isRichText);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isRichText)) = value;
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000C5E RID: 3166 RVA: 0x00035974 File Offset: 0x00033B74
		// (set) Token: 0x06000C5F RID: 3167 RVA: 0x000076A5 File Offset: 0x000058A5
		public unsafe bool m_parseCtrlCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_parseCtrlCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_parseCtrlCharacters)) = value;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x0003599C File Offset: 0x00033B9C
		// (set) Token: 0x06000C61 RID: 3169 RVA: 0x000076C0 File Offset: 0x000058C0
		public unsafe bool m_isOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isOverlay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isOverlay)) = value;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000C62 RID: 3170 RVA: 0x000359C4 File Offset: 0x00033BC4
		// (set) Token: 0x06000C63 RID: 3171 RVA: 0x000076DB File Offset: 0x000058DB
		public unsafe bool m_isOrthographic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isOrthographic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isOrthographic)) = value;
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000C64 RID: 3172 RVA: 0x000359EC File Offset: 0x00033BEC
		// (set) Token: 0x06000C65 RID: 3173 RVA: 0x000076F6 File Offset: 0x000058F6
		public unsafe bool m_isCullingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isCullingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isCullingEnabled)) = value;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000C66 RID: 3174 RVA: 0x00035A14 File Offset: 0x00033C14
		// (set) Token: 0x06000C67 RID: 3175 RVA: 0x00007711 File Offset: 0x00005911
		public unsafe bool m_isMaskingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isMaskingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isMaskingEnabled)) = value;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000C68 RID: 3176 RVA: 0x00035A3C File Offset: 0x00033C3C
		// (set) Token: 0x06000C69 RID: 3177 RVA: 0x0000772C File Offset: 0x0000592C
		public unsafe bool isMaskUpdateRequired
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_isMaskUpdateRequired);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_isMaskUpdateRequired)) = value;
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000C6A RID: 3178 RVA: 0x00035A64 File Offset: 0x00033C64
		// (set) Token: 0x06000C6B RID: 3179 RVA: 0x00007747 File Offset: 0x00005947
		public unsafe bool m_ignoreCulling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ignoreCulling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ignoreCulling)) = value;
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000C6C RID: 3180 RVA: 0x00035A8C File Offset: 0x00033C8C
		// (set) Token: 0x06000C6D RID: 3181 RVA: 0x00007762 File Offset: 0x00005962
		public unsafe TextureMappingOptions m_horizontalMapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_horizontalMapping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_horizontalMapping)) = value;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000C6E RID: 3182 RVA: 0x00035AB4 File Offset: 0x00033CB4
		// (set) Token: 0x06000C6F RID: 3183 RVA: 0x0000777D File Offset: 0x0000597D
		public unsafe TextureMappingOptions m_verticalMapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_verticalMapping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_verticalMapping)) = value;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000C70 RID: 3184 RVA: 0x00035ADC File Offset: 0x00033CDC
		// (set) Token: 0x06000C71 RID: 3185 RVA: 0x00007798 File Offset: 0x00005998
		public unsafe float m_uvLineOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_uvLineOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_uvLineOffset)) = value;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000C72 RID: 3186 RVA: 0x00035B04 File Offset: 0x00033D04
		// (set) Token: 0x06000C73 RID: 3187 RVA: 0x000077B3 File Offset: 0x000059B3
		public unsafe TextRenderFlags m_renderMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_renderMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_renderMode)) = value;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000C74 RID: 3188 RVA: 0x00035B2C File Offset: 0x00033D2C
		// (set) Token: 0x06000C75 RID: 3189 RVA: 0x000077CE File Offset: 0x000059CE
		public unsafe VertexSortingOrder m_geometrySortingOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_geometrySortingOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_geometrySortingOrder)) = value;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x00035B54 File Offset: 0x00033D54
		// (set) Token: 0x06000C77 RID: 3191 RVA: 0x000077E9 File Offset: 0x000059E9
		public unsafe bool m_IsTextObjectScaleStatic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_IsTextObjectScaleStatic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_IsTextObjectScaleStatic)) = value;
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x00035B7C File Offset: 0x00033D7C
		// (set) Token: 0x06000C79 RID: 3193 RVA: 0x00007804 File Offset: 0x00005A04
		public unsafe bool m_VertexBufferAutoSizeReduction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_VertexBufferAutoSizeReduction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_VertexBufferAutoSizeReduction)) = value;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x00035BA4 File Offset: 0x00033DA4
		// (set) Token: 0x06000C7B RID: 3195 RVA: 0x0000781F File Offset: 0x00005A1F
		public unsafe int m_firstVisibleCharacter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_firstVisibleCharacter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_firstVisibleCharacter)) = value;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000C7C RID: 3196 RVA: 0x00035BCC File Offset: 0x00033DCC
		// (set) Token: 0x06000C7D RID: 3197 RVA: 0x0000783A File Offset: 0x00005A3A
		public unsafe int m_maxVisibleCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxVisibleCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxVisibleCharacters)) = value;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000C7E RID: 3198 RVA: 0x00035BF4 File Offset: 0x00033DF4
		// (set) Token: 0x06000C7F RID: 3199 RVA: 0x00007855 File Offset: 0x00005A55
		public unsafe int m_maxVisibleWords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxVisibleWords);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxVisibleWords)) = value;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000C80 RID: 3200 RVA: 0x00035C1C File Offset: 0x00033E1C
		// (set) Token: 0x06000C81 RID: 3201 RVA: 0x00007870 File Offset: 0x00005A70
		public unsafe int m_maxVisibleLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxVisibleLines);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxVisibleLines)) = value;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000C82 RID: 3202 RVA: 0x00035C44 File Offset: 0x00033E44
		// (set) Token: 0x06000C83 RID: 3203 RVA: 0x0000788B File Offset: 0x00005A8B
		public unsafe bool m_useMaxVisibleDescender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_useMaxVisibleDescender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_useMaxVisibleDescender)) = value;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000C84 RID: 3204 RVA: 0x00035C6C File Offset: 0x00033E6C
		// (set) Token: 0x06000C85 RID: 3205 RVA: 0x000078A6 File Offset: 0x00005AA6
		public unsafe int m_pageToDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_pageToDisplay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_pageToDisplay)) = value;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000C86 RID: 3206 RVA: 0x00035C94 File Offset: 0x00033E94
		// (set) Token: 0x06000C87 RID: 3207 RVA: 0x000078C1 File Offset: 0x00005AC1
		public unsafe bool m_isNewPage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isNewPage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isNewPage)) = value;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000C88 RID: 3208 RVA: 0x00035CBC File Offset: 0x00033EBC
		// (set) Token: 0x06000C89 RID: 3209 RVA: 0x000078DC File Offset: 0x00005ADC
		public unsafe Vector4 m_margin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_margin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_margin)) = value;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000C8A RID: 3210 RVA: 0x00035CE4 File Offset: 0x00033EE4
		// (set) Token: 0x06000C8B RID: 3211 RVA: 0x000078F7 File Offset: 0x00005AF7
		public unsafe float m_marginLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_marginLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_marginLeft)) = value;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000C8C RID: 3212 RVA: 0x00035D0C File Offset: 0x00033F0C
		// (set) Token: 0x06000C8D RID: 3213 RVA: 0x00007912 File Offset: 0x00005B12
		public unsafe float m_marginRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_marginRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_marginRight)) = value;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000C8E RID: 3214 RVA: 0x00035D34 File Offset: 0x00033F34
		// (set) Token: 0x06000C8F RID: 3215 RVA: 0x0000792D File Offset: 0x00005B2D
		public unsafe float m_marginWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_marginWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_marginWidth)) = value;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x00035D5C File Offset: 0x00033F5C
		// (set) Token: 0x06000C91 RID: 3217 RVA: 0x00007948 File Offset: 0x00005B48
		public unsafe float m_marginHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_marginHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_marginHeight)) = value;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000C92 RID: 3218 RVA: 0x00035D84 File Offset: 0x00033F84
		// (set) Token: 0x06000C93 RID: 3219 RVA: 0x00007963 File Offset: 0x00005B63
		public unsafe float m_width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_width)) = value;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x00035DAC File Offset: 0x00033FAC
		// (set) Token: 0x06000C95 RID: 3221 RVA: 0x0000797E File Offset: 0x00005B7E
		public unsafe TMP_TextInfo m_textInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_textInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_TextInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_textInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x00035DDC File Offset: 0x00033FDC
		// (set) Token: 0x06000C97 RID: 3223 RVA: 0x0000799D File Offset: 0x00005B9D
		public unsafe bool m_havePropertiesChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_havePropertiesChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_havePropertiesChanged)) = value;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x00035E04 File Offset: 0x00034004
		// (set) Token: 0x06000C99 RID: 3225 RVA: 0x000079B8 File Offset: 0x00005BB8
		public unsafe bool m_isUsingLegacyAnimationComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isUsingLegacyAnimationComponent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isUsingLegacyAnimationComponent)) = value;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000C9A RID: 3226 RVA: 0x00035E2C File Offset: 0x0003402C
		// (set) Token: 0x06000C9B RID: 3227 RVA: 0x000079D3 File Offset: 0x00005BD3
		public unsafe Transform m_transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000C9C RID: 3228 RVA: 0x00035E5C File Offset: 0x0003405C
		// (set) Token: 0x06000C9D RID: 3229 RVA: 0x000079F2 File Offset: 0x00005BF2
		public unsafe RectTransform m_rectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_rectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_rectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000C9E RID: 3230 RVA: 0x00035E8C File Offset: 0x0003408C
		// (set) Token: 0x06000C9F RID: 3231 RVA: 0x00007A11 File Offset: 0x00005C11
		public unsafe Vector2 m_PreviousRectTransformSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_PreviousRectTransformSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_PreviousRectTransformSize)) = value;
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x00035EB4 File Offset: 0x000340B4
		// (set) Token: 0x06000CA1 RID: 3233 RVA: 0x00007A2C File Offset: 0x00005C2C
		public unsafe Vector2 m_PreviousPivotPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_PreviousPivotPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_PreviousPivotPosition)) = value;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x00035EDC File Offset: 0x000340DC
		// (set) Token: 0x06000CA3 RID: 3235 RVA: 0x00007A47 File Offset: 0x00005C47
		public unsafe bool _autoSizeTextContainer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr__autoSizeTextContainer_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr__autoSizeTextContainer_k__BackingField)) = value;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x00035F04 File Offset: 0x00034104
		// (set) Token: 0x06000CA5 RID: 3237 RVA: 0x00007A62 File Offset: 0x00005C62
		public unsafe bool m_autoSizeTextContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_autoSizeTextContainer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_autoSizeTextContainer)) = value;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x00035F2C File Offset: 0x0003412C
		// (set) Token: 0x06000CA7 RID: 3239 RVA: 0x00007A7D File Offset: 0x00005C7D
		public unsafe Mesh m_mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x00035F5C File Offset: 0x0003415C
		// (set) Token: 0x06000CA9 RID: 3241 RVA: 0x00007A9C File Offset: 0x00005C9C
		public unsafe bool m_isVolumetricText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isVolumetricText);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isVolumetricText)) = value;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000CAA RID: 3242 RVA: 0x00035F84 File Offset: 0x00034184
		// (set) Token: 0x06000CAB RID: 3243 RVA: 0x00007AB7 File Offset: 0x00005CB7
		public unsafe static Func<int, string, TMP_FontAsset> OnFontAssetRequest
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_OnFontAssetRequest, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string, TMP_FontAsset>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_OnFontAssetRequest, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x00035FAC File Offset: 0x000341AC
		// (set) Token: 0x06000CAD RID: 3245 RVA: 0x00007AC9 File Offset: 0x00005CC9
		public unsafe static Func<int, string, TMP_SpriteAsset> OnSpriteAssetRequest
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_OnSpriteAssetRequest, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string, TMP_SpriteAsset>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_OnSpriteAssetRequest, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000CAE RID: 3246 RVA: 0x00035FD4 File Offset: 0x000341D4
		// (set) Token: 0x06000CAF RID: 3247 RVA: 0x00007ADB File Offset: 0x00005CDB
		public unsafe Action<TMP_TextInfo> OnPreRenderText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_OnPreRenderText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TMP_TextInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_OnPreRenderText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x00036004 File Offset: 0x00034204
		// (set) Token: 0x06000CB1 RID: 3249 RVA: 0x00007AFA File Offset: 0x00005CFA
		public unsafe TMP_SpriteAnimator m_spriteAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAnimator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x00036034 File Offset: 0x00034234
		// (set) Token: 0x06000CB3 RID: 3251 RVA: 0x00007B19 File Offset: 0x00005D19
		public unsafe float m_flexibleHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_flexibleHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_flexibleHeight)) = value;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x0003605C File Offset: 0x0003425C
		// (set) Token: 0x06000CB5 RID: 3253 RVA: 0x00007B34 File Offset: 0x00005D34
		public unsafe float m_flexibleWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_flexibleWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_flexibleWidth)) = value;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x00036084 File Offset: 0x00034284
		// (set) Token: 0x06000CB7 RID: 3255 RVA: 0x00007B4F File Offset: 0x00005D4F
		public unsafe float m_minWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_minWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_minWidth)) = value;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x000360AC File Offset: 0x000342AC
		// (set) Token: 0x06000CB9 RID: 3257 RVA: 0x00007B6A File Offset: 0x00005D6A
		public unsafe float m_minHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_minHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_minHeight)) = value;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x000360D4 File Offset: 0x000342D4
		// (set) Token: 0x06000CBB RID: 3259 RVA: 0x00007B85 File Offset: 0x00005D85
		public unsafe float m_maxWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxWidth)) = value;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x000360FC File Offset: 0x000342FC
		// (set) Token: 0x06000CBD RID: 3261 RVA: 0x00007BA0 File Offset: 0x00005DA0
		public unsafe float m_maxHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxHeight)) = value;
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x00036124 File Offset: 0x00034324
		// (set) Token: 0x06000CBF RID: 3263 RVA: 0x00007BBB File Offset: 0x00005DBB
		public unsafe LayoutElement m_LayoutElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_LayoutElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_LayoutElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x00036154 File Offset: 0x00034354
		// (set) Token: 0x06000CC1 RID: 3265 RVA: 0x00007BDA File Offset: 0x00005DDA
		public unsafe float m_preferredWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_preferredWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_preferredWidth)) = value;
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x0003617C File Offset: 0x0003437C
		// (set) Token: 0x06000CC3 RID: 3267 RVA: 0x00007BF5 File Offset: 0x00005DF5
		public unsafe float m_renderedWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_renderedWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_renderedWidth)) = value;
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x000361A4 File Offset: 0x000343A4
		// (set) Token: 0x06000CC5 RID: 3269 RVA: 0x00007C10 File Offset: 0x00005E10
		public unsafe bool m_isPreferredWidthDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isPreferredWidthDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isPreferredWidthDirty)) = value;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x000361CC File Offset: 0x000343CC
		// (set) Token: 0x06000CC7 RID: 3271 RVA: 0x00007C2B File Offset: 0x00005E2B
		public unsafe float m_preferredHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_preferredHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_preferredHeight)) = value;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x000361F4 File Offset: 0x000343F4
		// (set) Token: 0x06000CC9 RID: 3273 RVA: 0x00007C46 File Offset: 0x00005E46
		public unsafe float m_renderedHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_renderedHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_renderedHeight)) = value;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x0003621C File Offset: 0x0003441C
		// (set) Token: 0x06000CCB RID: 3275 RVA: 0x00007C61 File Offset: 0x00005E61
		public unsafe bool m_isPreferredHeightDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isPreferredHeightDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isPreferredHeightDirty)) = value;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x00036244 File Offset: 0x00034444
		// (set) Token: 0x06000CCD RID: 3277 RVA: 0x00007C7C File Offset: 0x00005E7C
		public unsafe bool m_isCalculatingPreferredValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isCalculatingPreferredValues);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isCalculatingPreferredValues)) = value;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x0003626C File Offset: 0x0003446C
		// (set) Token: 0x06000CCF RID: 3279 RVA: 0x00007C97 File Offset: 0x00005E97
		public unsafe int m_layoutPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_layoutPriority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_layoutPriority)) = value;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x00036294 File Offset: 0x00034494
		// (set) Token: 0x06000CD1 RID: 3281 RVA: 0x00007CB2 File Offset: 0x00005EB2
		public unsafe bool m_isLayoutDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isLayoutDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isLayoutDirty)) = value;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x000362BC File Offset: 0x000344BC
		// (set) Token: 0x06000CD3 RID: 3283 RVA: 0x00007CCD File Offset: 0x00005ECD
		public unsafe bool m_isAwake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isAwake);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isAwake)) = value;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x000362E4 File Offset: 0x000344E4
		// (set) Token: 0x06000CD5 RID: 3285 RVA: 0x00007CE8 File Offset: 0x00005EE8
		public unsafe bool m_isWaitingOnResourceLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isWaitingOnResourceLoad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isWaitingOnResourceLoad)) = value;
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x0003630C File Offset: 0x0003450C
		// (set) Token: 0x06000CD7 RID: 3287 RVA: 0x00007D03 File Offset: 0x00005F03
		public unsafe TMP_Text.TextInputSources m_inputSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_inputSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_inputSource)) = value;
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x00036334 File Offset: 0x00034534
		// (set) Token: 0x06000CD9 RID: 3289 RVA: 0x00007D1E File Offset: 0x00005F1E
		public unsafe float m_fontScaleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontScaleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_fontScaleMultiplier)) = value;
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x0003635C File Offset: 0x0003455C
		// (set) Token: 0x06000CDB RID: 3291 RVA: 0x00007D39 File Offset: 0x00005F39
		public unsafe static Il2CppStructArray<char> m_htmlTag
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_htmlTag, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_htmlTag, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000CDC RID: 3292 RVA: 0x00036384 File Offset: 0x00034584
		// (set) Token: 0x06000CDD RID: 3293 RVA: 0x00007D4B File Offset: 0x00005F4B
		public unsafe static Il2CppStructArray<RichTextTagAttribute> m_xmlAttribute
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_xmlAttribute, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RichTextTagAttribute>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_xmlAttribute, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x000363AC File Offset: 0x000345AC
		// (set) Token: 0x06000CDF RID: 3295 RVA: 0x00007D5D File Offset: 0x00005F5D
		public unsafe static Il2CppStructArray<float> m_attributeParameterValues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_attributeParameterValues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_attributeParameterValues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x000363D4 File Offset: 0x000345D4
		// (set) Token: 0x06000CE1 RID: 3297 RVA: 0x00007D6F File Offset: 0x00005F6F
		public unsafe float tag_LineIndent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_tag_LineIndent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_tag_LineIndent)) = value;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x000363FC File Offset: 0x000345FC
		// (set) Token: 0x06000CE3 RID: 3299 RVA: 0x00007D8A File Offset: 0x00005F8A
		public unsafe float tag_Indent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_tag_Indent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_tag_Indent)) = value;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x00036424 File Offset: 0x00034624
		// (set) Token: 0x06000CE5 RID: 3301 RVA: 0x00007DA5 File Offset: 0x00005FA5
		public TMP_TextProcessingStack<float> m_indentStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_indentStack);
				return new TMP_TextProcessingStack<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_indentStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x00036454 File Offset: 0x00034654
		// (set) Token: 0x06000CE7 RID: 3303 RVA: 0x00007DD3 File Offset: 0x00005FD3
		public unsafe bool tag_NoParsing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_tag_NoParsing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_tag_NoParsing)) = value;
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x0003647C File Offset: 0x0003467C
		// (set) Token: 0x06000CE9 RID: 3305 RVA: 0x00007DEE File Offset: 0x00005FEE
		public unsafe bool m_isParsingText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isParsingText);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isParsingText)) = value;
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x000364A4 File Offset: 0x000346A4
		// (set) Token: 0x06000CEB RID: 3307 RVA: 0x00007E09 File Offset: 0x00006009
		public unsafe Matrix4x4 m_FXMatrix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_FXMatrix);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_FXMatrix)) = value;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000CEC RID: 3308 RVA: 0x000364CC File Offset: 0x000346CC
		// (set) Token: 0x06000CED RID: 3309 RVA: 0x00007E24 File Offset: 0x00006024
		public unsafe bool m_isFXMatrixSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isFXMatrixSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_isFXMatrixSet)) = value;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x000364F4 File Offset: 0x000346F4
		// (set) Token: 0x06000CEF RID: 3311 RVA: 0x00007E3F File Offset: 0x0000603F
		public unsafe Il2CppStructArray<TMP_Text.UnicodeChar> m_TextProcessingArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextProcessingArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TMP_Text.UnicodeChar>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextProcessingArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x00036524 File Offset: 0x00034724
		// (set) Token: 0x06000CF1 RID: 3313 RVA: 0x00007E5E File Offset: 0x0000605E
		public unsafe int m_InternalTextProcessingArraySize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_InternalTextProcessingArraySize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_InternalTextProcessingArraySize)) = value;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x0003654C File Offset: 0x0003474C
		// (set) Token: 0x06000CF3 RID: 3315 RVA: 0x00007E79 File Offset: 0x00006079
		public unsafe Il2CppReferenceArray<TMP_CharacterInfo> m_internalCharacterInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_internalCharacterInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_CharacterInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_internalCharacterInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x0003657C File Offset: 0x0003477C
		// (set) Token: 0x06000CF5 RID: 3317 RVA: 0x00007E98 File Offset: 0x00006098
		public unsafe int m_totalCharacterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_totalCharacterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_totalCharacterCount)) = value;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x000365A4 File Offset: 0x000347A4
		// (set) Token: 0x06000CF7 RID: 3319 RVA: 0x00007EB3 File Offset: 0x000060B3
		public unsafe static WordWrapState m_SavedWordWrapState
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_SavedWordWrapState, intPtr);
				return new WordWrapState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_SavedWordWrapState, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x000365E0 File Offset: 0x000347E0
		// (set) Token: 0x06000CF9 RID: 3321 RVA: 0x00007ECA File Offset: 0x000060CA
		public unsafe static WordWrapState m_SavedLineState
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_SavedLineState, intPtr);
				return new WordWrapState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_SavedLineState, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000CFA RID: 3322 RVA: 0x0003661C File Offset: 0x0003481C
		// (set) Token: 0x06000CFB RID: 3323 RVA: 0x00007EE1 File Offset: 0x000060E1
		public unsafe static WordWrapState m_SavedEllipsisState
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_SavedEllipsisState, intPtr);
				return new WordWrapState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_SavedEllipsisState, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x00036658 File Offset: 0x00034858
		// (set) Token: 0x06000CFD RID: 3325 RVA: 0x00007EF8 File Offset: 0x000060F8
		public unsafe static WordWrapState m_SavedLastValidState
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_SavedLastValidState, intPtr);
				return new WordWrapState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_SavedLastValidState, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x00036694 File Offset: 0x00034894
		// (set) Token: 0x06000CFF RID: 3327 RVA: 0x00007F0F File Offset: 0x0000610F
		public unsafe static WordWrapState m_SavedSoftLineBreakState
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_SavedSoftLineBreakState, intPtr);
				return new WordWrapState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WordWrapState>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_SavedSoftLineBreakState, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000D00 RID: 3328 RVA: 0x000366D0 File Offset: 0x000348D0
		// (set) Token: 0x06000D01 RID: 3329 RVA: 0x00007F26 File Offset: 0x00006126
		public unsafe static TMP_TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<WordWrapState>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_m_EllipsisInsertionCandidateStack, intPtr);
				return new TMP_TextProcessingStack<WordWrapState>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<WordWrapState>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_m_EllipsisInsertionCandidateStack, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x0003670C File Offset: 0x0003490C
		// (set) Token: 0x06000D03 RID: 3331 RVA: 0x00007F3D File Offset: 0x0000613D
		public unsafe int m_characterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_characterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_characterCount)) = value;
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x00036734 File Offset: 0x00034934
		// (set) Token: 0x06000D05 RID: 3333 RVA: 0x00007F58 File Offset: 0x00006158
		public unsafe int m_firstCharacterOfLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_firstCharacterOfLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_firstCharacterOfLine)) = value;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000D06 RID: 3334 RVA: 0x0003675C File Offset: 0x0003495C
		// (set) Token: 0x06000D07 RID: 3335 RVA: 0x00007F73 File Offset: 0x00006173
		public unsafe int m_firstVisibleCharacterOfLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_firstVisibleCharacterOfLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_firstVisibleCharacterOfLine)) = value;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000D08 RID: 3336 RVA: 0x00036784 File Offset: 0x00034984
		// (set) Token: 0x06000D09 RID: 3337 RVA: 0x00007F8E File Offset: 0x0000618E
		public unsafe int m_lastCharacterOfLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lastCharacterOfLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lastCharacterOfLine)) = value;
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x000367AC File Offset: 0x000349AC
		// (set) Token: 0x06000D0B RID: 3339 RVA: 0x00007FA9 File Offset: 0x000061A9
		public unsafe int m_lastVisibleCharacterOfLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lastVisibleCharacterOfLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lastVisibleCharacterOfLine)) = value;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x000367D4 File Offset: 0x000349D4
		// (set) Token: 0x06000D0D RID: 3341 RVA: 0x00007FC4 File Offset: 0x000061C4
		public unsafe int m_lineNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineNumber)) = value;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x000367FC File Offset: 0x000349FC
		// (set) Token: 0x06000D0F RID: 3343 RVA: 0x00007FDF File Offset: 0x000061DF
		public unsafe int m_lineVisibleCharacterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineVisibleCharacterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineVisibleCharacterCount)) = value;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x00036824 File Offset: 0x00034A24
		// (set) Token: 0x06000D11 RID: 3345 RVA: 0x00007FFA File Offset: 0x000061FA
		public unsafe int m_pageNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_pageNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_pageNumber)) = value;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x0003684C File Offset: 0x00034A4C
		// (set) Token: 0x06000D13 RID: 3347 RVA: 0x00008015 File Offset: 0x00006215
		public unsafe float m_PageAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_PageAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_PageAscender)) = value;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000D14 RID: 3348 RVA: 0x00036874 File Offset: 0x00034A74
		// (set) Token: 0x06000D15 RID: 3349 RVA: 0x00008030 File Offset: 0x00006230
		public unsafe float m_maxTextAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxTextAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxTextAscender)) = value;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x0003689C File Offset: 0x00034A9C
		// (set) Token: 0x06000D17 RID: 3351 RVA: 0x0000804B File Offset: 0x0000624B
		public unsafe float m_maxCapHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxCapHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxCapHeight)) = value;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x000368C4 File Offset: 0x00034AC4
		// (set) Token: 0x06000D19 RID: 3353 RVA: 0x00008066 File Offset: 0x00006266
		public unsafe float m_ElementAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ElementAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ElementAscender)) = value;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000D1A RID: 3354 RVA: 0x000368EC File Offset: 0x00034AEC
		// (set) Token: 0x06000D1B RID: 3355 RVA: 0x00008081 File Offset: 0x00006281
		public unsafe float m_ElementDescender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ElementDescender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ElementDescender)) = value;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000D1C RID: 3356 RVA: 0x00036914 File Offset: 0x00034B14
		// (set) Token: 0x06000D1D RID: 3357 RVA: 0x0000809C File Offset: 0x0000629C
		public unsafe float m_maxLineAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxLineAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxLineAscender)) = value;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x0003693C File Offset: 0x00034B3C
		// (set) Token: 0x06000D1F RID: 3359 RVA: 0x000080B7 File Offset: 0x000062B7
		public unsafe float m_maxLineDescender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxLineDescender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_maxLineDescender)) = value;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000D20 RID: 3360 RVA: 0x00036964 File Offset: 0x00034B64
		// (set) Token: 0x06000D21 RID: 3361 RVA: 0x000080D2 File Offset: 0x000062D2
		public unsafe float m_startOfLineAscender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_startOfLineAscender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_startOfLineAscender)) = value;
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000D22 RID: 3362 RVA: 0x0003698C File Offset: 0x00034B8C
		// (set) Token: 0x06000D23 RID: 3363 RVA: 0x000080ED File Offset: 0x000062ED
		public unsafe float m_startOfLineDescender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_startOfLineDescender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_startOfLineDescender)) = value;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x000369B4 File Offset: 0x00034BB4
		// (set) Token: 0x06000D25 RID: 3365 RVA: 0x00008108 File Offset: 0x00006308
		public unsafe float m_lineOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_lineOffset)) = value;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x000369DC File Offset: 0x00034BDC
		// (set) Token: 0x06000D27 RID: 3367 RVA: 0x00008123 File Offset: 0x00006323
		public unsafe Extents m_meshExtents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_meshExtents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_meshExtents)) = value;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000D28 RID: 3368 RVA: 0x00036A04 File Offset: 0x00034C04
		// (set) Token: 0x06000D29 RID: 3369 RVA: 0x0000813E File Offset: 0x0000633E
		public unsafe Color32 m_htmlColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_htmlColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_htmlColor)) = value;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000D2A RID: 3370 RVA: 0x00036A2C File Offset: 0x00034C2C
		// (set) Token: 0x06000D2B RID: 3371 RVA: 0x00008159 File Offset: 0x00006359
		public TMP_TextProcessingStack<Color32> m_colorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorStack);
				return new TMP_TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000D2C RID: 3372 RVA: 0x00036A5C File Offset: 0x00034C5C
		// (set) Token: 0x06000D2D RID: 3373 RVA: 0x00008187 File Offset: 0x00006387
		public TMP_TextProcessingStack<Color32> m_underlineColorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_underlineColorStack);
				return new TMP_TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_underlineColorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000D2E RID: 3374 RVA: 0x00036A8C File Offset: 0x00034C8C
		// (set) Token: 0x06000D2F RID: 3375 RVA: 0x000081B5 File Offset: 0x000063B5
		public TMP_TextProcessingStack<Color32> m_strikethroughColorStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_strikethroughColorStack);
				return new TMP_TextProcessingStack<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_strikethroughColorStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<Color32>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000D30 RID: 3376 RVA: 0x00036ABC File Offset: 0x00034CBC
		// (set) Token: 0x06000D31 RID: 3377 RVA: 0x000081E3 File Offset: 0x000063E3
		public TMP_TextProcessingStack<HighlightState> m_HighlightStateStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_HighlightStateStack);
				return new TMP_TextProcessingStack<HighlightState>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<HighlightState>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_HighlightStateStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<HighlightState>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000D32 RID: 3378 RVA: 0x00036AEC File Offset: 0x00034CEC
		// (set) Token: 0x06000D33 RID: 3379 RVA: 0x00008211 File Offset: 0x00006411
		public unsafe TMP_ColorGradient m_colorGradientPreset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorGradientPreset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_ColorGradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorGradientPreset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x00036B1C File Offset: 0x00034D1C
		// (set) Token: 0x06000D35 RID: 3381 RVA: 0x00008230 File Offset: 0x00006430
		public TMP_TextProcessingStack<TMP_ColorGradient> m_colorGradientStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorGradientStack);
				return new TMP_TextProcessingStack<TMP_ColorGradient>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<TMP_ColorGradient>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorGradientStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<TMP_ColorGradient>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000D36 RID: 3382 RVA: 0x00036B4C File Offset: 0x00034D4C
		// (set) Token: 0x06000D37 RID: 3383 RVA: 0x0000825E File Offset: 0x0000645E
		public unsafe bool m_colorGradientPresetIsTinted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorGradientPresetIsTinted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_colorGradientPresetIsTinted)) = value;
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000D38 RID: 3384 RVA: 0x00036B74 File Offset: 0x00034D74
		// (set) Token: 0x06000D39 RID: 3385 RVA: 0x00008279 File Offset: 0x00006479
		public unsafe float m_tabSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_tabSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_tabSpacing)) = value;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x00036B9C File Offset: 0x00034D9C
		// (set) Token: 0x06000D3B RID: 3387 RVA: 0x00008294 File Offset: 0x00006494
		public unsafe float m_spacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spacing)) = value;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x00036BC4 File Offset: 0x00034DC4
		// (set) Token: 0x06000D3D RID: 3389 RVA: 0x000082AF File Offset: 0x000064AF
		public unsafe Il2CppReferenceArray<TMP_TextProcessingStack<int>> m_TextStyleStacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextStyleStacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_TextProcessingStack<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextStyleStacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x00036BF4 File Offset: 0x00034DF4
		// (set) Token: 0x06000D3F RID: 3391 RVA: 0x000082CE File Offset: 0x000064CE
		public unsafe int m_TextStyleStackDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextStyleStackDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextStyleStackDepth)) = value;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x00036C1C File Offset: 0x00034E1C
		// (set) Token: 0x06000D41 RID: 3393 RVA: 0x000082E9 File Offset: 0x000064E9
		public TMP_TextProcessingStack<int> m_ItalicAngleStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ItalicAngleStack);
				return new TMP_TextProcessingStack<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ItalicAngleStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x00036C4C File Offset: 0x00034E4C
		// (set) Token: 0x06000D43 RID: 3395 RVA: 0x00008317 File Offset: 0x00006517
		public unsafe int m_ItalicAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ItalicAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ItalicAngle)) = value;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000D44 RID: 3396 RVA: 0x00036C74 File Offset: 0x00034E74
		// (set) Token: 0x06000D45 RID: 3397 RVA: 0x00008332 File Offset: 0x00006532
		public TMP_TextProcessingStack<int> m_actionStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_actionStack);
				return new TMP_TextProcessingStack<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_actionStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000D46 RID: 3398 RVA: 0x00036CA4 File Offset: 0x00034EA4
		// (set) Token: 0x06000D47 RID: 3399 RVA: 0x00008360 File Offset: 0x00006560
		public unsafe float m_padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_padding)) = value;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000D48 RID: 3400 RVA: 0x00036CCC File Offset: 0x00034ECC
		// (set) Token: 0x06000D49 RID: 3401 RVA: 0x0000837B File Offset: 0x0000657B
		public unsafe float m_baselineOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_baselineOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_baselineOffset)) = value;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000D4A RID: 3402 RVA: 0x00036CF4 File Offset: 0x00034EF4
		// (set) Token: 0x06000D4B RID: 3403 RVA: 0x00008396 File Offset: 0x00006596
		public TMP_TextProcessingStack<float> m_baselineOffsetStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_baselineOffsetStack);
				return new TMP_TextProcessingStack<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_baselineOffsetStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_TextProcessingStack<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000D4C RID: 3404 RVA: 0x00036D24 File Offset: 0x00034F24
		// (set) Token: 0x06000D4D RID: 3405 RVA: 0x000083C4 File Offset: 0x000065C4
		public unsafe float m_xAdvance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_xAdvance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_xAdvance)) = value;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000D4E RID: 3406 RVA: 0x00036D4C File Offset: 0x00034F4C
		// (set) Token: 0x06000D4F RID: 3407 RVA: 0x000083DF File Offset: 0x000065DF
		public unsafe TMP_TextElementType m_textElementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_textElementType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_textElementType)) = value;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000D50 RID: 3408 RVA: 0x00036D74 File Offset: 0x00034F74
		// (set) Token: 0x06000D51 RID: 3409 RVA: 0x000083FA File Offset: 0x000065FA
		public unsafe TMP_TextElement m_cached_TextElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_cached_TextElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_TextElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_cached_TextElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000D52 RID: 3410 RVA: 0x00036DA4 File Offset: 0x00034FA4
		// (set) Token: 0x06000D53 RID: 3411 RVA: 0x00008419 File Offset: 0x00006619
		public TMP_Text.SpecialCharacter m_Ellipsis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_Ellipsis);
				return new TMP_Text.SpecialCharacter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_Ellipsis), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000D54 RID: 3412 RVA: 0x00036DD4 File Offset: 0x00034FD4
		// (set) Token: 0x06000D55 RID: 3413 RVA: 0x00008447 File Offset: 0x00006647
		public TMP_Text.SpecialCharacter m_Underline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_Underline);
				return new TMP_Text.SpecialCharacter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_Underline), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000D56 RID: 3414 RVA: 0x00036E04 File Offset: 0x00035004
		// (set) Token: 0x06000D57 RID: 3415 RVA: 0x00008475 File Offset: 0x00006675
		public unsafe TMP_SpriteAsset m_defaultSpriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_defaultSpriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_defaultSpriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000D58 RID: 3416 RVA: 0x00036E34 File Offset: 0x00035034
		// (set) Token: 0x06000D59 RID: 3417 RVA: 0x00008494 File Offset: 0x00006694
		public unsafe TMP_SpriteAsset m_currentSpriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentSpriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_currentSpriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000D5A RID: 3418 RVA: 0x00036E64 File Offset: 0x00035064
		// (set) Token: 0x06000D5B RID: 3419 RVA: 0x000084B3 File Offset: 0x000066B3
		public unsafe int m_spriteCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteCount)) = value;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000D5C RID: 3420 RVA: 0x00036E8C File Offset: 0x0003508C
		// (set) Token: 0x06000D5D RID: 3421 RVA: 0x000084CE File Offset: 0x000066CE
		public unsafe int m_spriteIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteIndex)) = value;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000D5E RID: 3422 RVA: 0x00036EB4 File Offset: 0x000350B4
		// (set) Token: 0x06000D5F RID: 3423 RVA: 0x000084E9 File Offset: 0x000066E9
		public unsafe int m_spriteAnimationID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteAnimationID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_spriteAnimationID)) = value;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000D60 RID: 3424 RVA: 0x00036EDC File Offset: 0x000350DC
		// (set) Token: 0x06000D61 RID: 3425 RVA: 0x00008504 File Offset: 0x00006704
		public unsafe static ProfilerMarker k_ParseTextMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_k_ParseTextMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_k_ParseTextMarker, (void*)(&value));
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000D62 RID: 3426 RVA: 0x00036EF8 File Offset: 0x000350F8
		// (set) Token: 0x06000D63 RID: 3427 RVA: 0x00008512 File Offset: 0x00006712
		public unsafe static ProfilerMarker k_InsertNewLineMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_k_InsertNewLineMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_k_InsertNewLineMarker, (void*)(&value));
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000D64 RID: 3428 RVA: 0x00036F14 File Offset: 0x00035114
		// (set) Token: 0x06000D65 RID: 3429 RVA: 0x00008520 File Offset: 0x00006720
		public unsafe bool m_ignoreActiveState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ignoreActiveState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_ignoreActiveState)) = value;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000D66 RID: 3430 RVA: 0x00036F3C File Offset: 0x0003513C
		// (set) Token: 0x06000D67 RID: 3431 RVA: 0x0000853B File Offset: 0x0000673B
		public TMP_Text.TextBackingContainer m_TextBackingArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextBackingArray);
				return new TMP_Text.TextBackingContainer(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_m_TextBackingArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x00036F6C File Offset: 0x0003516C
		// (set) Token: 0x06000D69 RID: 3433 RVA: 0x00008569 File Offset: 0x00006769
		public unsafe Il2CppStructArray<Decimal> k_Power
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_k_Power);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Decimal>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.NativeFieldInfoPtr_k_Power), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000D6A RID: 3434 RVA: 0x00036F9C File Offset: 0x0003519C
		// (set) Token: 0x06000D6B RID: 3435 RVA: 0x00008588 File Offset: 0x00006788
		public unsafe static Vector2 k_LargePositiveVector2
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_k_LargePositiveVector2, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_k_LargePositiveVector2, (void*)(&value));
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000D6C RID: 3436 RVA: 0x00036FB8 File Offset: 0x000351B8
		// (set) Token: 0x06000D6D RID: 3437 RVA: 0x00008596 File Offset: 0x00006796
		public unsafe static Vector2 k_LargeNegativeVector2
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_k_LargeNegativeVector2, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_k_LargeNegativeVector2, (void*)(&value));
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000D6E RID: 3438 RVA: 0x00036FD4 File Offset: 0x000351D4
		// (set) Token: 0x06000D6F RID: 3439 RVA: 0x000085A4 File Offset: 0x000067A4
		public unsafe static float k_LargePositiveFloat
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_k_LargePositiveFloat, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_k_LargePositiveFloat, (void*)(&value));
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000D70 RID: 3440 RVA: 0x00036FF0 File Offset: 0x000351F0
		// (set) Token: 0x06000D71 RID: 3441 RVA: 0x000085B2 File Offset: 0x000067B2
		public unsafe static float k_LargeNegativeFloat
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_k_LargeNegativeFloat, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_k_LargeNegativeFloat, (void*)(&value));
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x0003700C File Offset: 0x0003520C
		// (set) Token: 0x06000D73 RID: 3443 RVA: 0x000085C0 File Offset: 0x000067C0
		public unsafe static int k_LargePositiveInt
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_k_LargePositiveInt, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_k_LargePositiveInt, (void*)(&value));
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000D74 RID: 3444 RVA: 0x00037028 File Offset: 0x00035228
		// (set) Token: 0x06000D75 RID: 3445 RVA: 0x000085CE File Offset: 0x000067CE
		public unsafe static int k_LargeNegativeInt
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Text.NativeFieldInfoPtr_k_LargeNegativeInt, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Text.NativeFieldInfoPtr_k_LargeNegativeInt, (void*)(&value));
			}
		}

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeFieldInfoPtr_m_text;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeFieldInfoPtr_m_IsTextBackingStringDirty;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeFieldInfoPtr_m_TextPreprocessor;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeFieldInfoPtr_m_isRightToLeft;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeFieldInfoPtr_m_fontAsset;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeFieldInfoPtr_m_currentFontAsset;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeFieldInfoPtr_m_isSDFShader;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeFieldInfoPtr_m_sharedMaterial;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeFieldInfoPtr_m_currentMaterial;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeFieldInfoPtr_m_materialReferences;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeFieldInfoPtr_m_materialReferenceIndexLookup;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeFieldInfoPtr_m_materialReferenceStack;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeFieldInfoPtr_m_currentMaterialIndex;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeFieldInfoPtr_m_fontSharedMaterials;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeFieldInfoPtr_m_fontMaterial;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeFieldInfoPtr_m_fontMaterials;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeFieldInfoPtr_m_isMaterialDirty;

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeFieldInfoPtr_m_fontColor32;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeFieldInfoPtr_m_fontColor;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeFieldInfoPtr_s_colorWhite;

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeFieldInfoPtr_m_underlineColor;

		// Token: 0x040008AF RID: 2223
		private static readonly IntPtr NativeFieldInfoPtr_m_strikethroughColor;

		// Token: 0x040008B0 RID: 2224
		private static readonly IntPtr NativeFieldInfoPtr_m_enableVertexGradient;

		// Token: 0x040008B1 RID: 2225
		private static readonly IntPtr NativeFieldInfoPtr_m_colorMode;

		// Token: 0x040008B2 RID: 2226
		private static readonly IntPtr NativeFieldInfoPtr_m_fontColorGradient;

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeFieldInfoPtr_m_fontColorGradientPreset;

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeFieldInfoPtr_m_spriteAsset;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeFieldInfoPtr_m_tintAllSprites;

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeFieldInfoPtr_m_tintSprite;

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeFieldInfoPtr_m_spriteColor;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeFieldInfoPtr_m_StyleSheet;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeFieldInfoPtr_m_TextStyle;

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeFieldInfoPtr_m_TextStyleHashCode;

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeFieldInfoPtr_m_overrideHtmlColors;

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeFieldInfoPtr_m_faceColor;

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeFieldInfoPtr_m_outlineColor;

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeFieldInfoPtr_m_outlineWidth;

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeFieldInfoPtr_m_fontSize;

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeFieldInfoPtr_m_currentFontSize;

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeFieldInfoPtr_m_fontSizeBase;

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeFieldInfoPtr_m_sizeStack;

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeFieldInfoPtr_m_fontWeight;

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeFieldInfoPtr_m_FontWeightInternal;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeFieldInfoPtr_m_FontWeightStack;

		// Token: 0x040008C6 RID: 2246
		private static readonly IntPtr NativeFieldInfoPtr_m_enableAutoSizing;

		// Token: 0x040008C7 RID: 2247
		private static readonly IntPtr NativeFieldInfoPtr_m_maxFontSize;

		// Token: 0x040008C8 RID: 2248
		private static readonly IntPtr NativeFieldInfoPtr_m_minFontSize;

		// Token: 0x040008C9 RID: 2249
		private static readonly IntPtr NativeFieldInfoPtr_m_AutoSizeIterationCount;

		// Token: 0x040008CA RID: 2250
		private static readonly IntPtr NativeFieldInfoPtr_m_AutoSizeMaxIterationCount;

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeFieldInfoPtr_m_IsAutoSizePointSizeSet;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeFieldInfoPtr_m_fontSizeMin;

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeFieldInfoPtr_m_fontSizeMax;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeFieldInfoPtr_m_fontStyle;

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeFieldInfoPtr_m_FontStyleInternal;

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeFieldInfoPtr_m_fontStyleStack;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeFieldInfoPtr_m_isUsingBold;

		// Token: 0x040008D2 RID: 2258
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalAlignment;

		// Token: 0x040008D3 RID: 2259
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalAlignment;

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeFieldInfoPtr_m_textAlignment;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeFieldInfoPtr_m_lineJustification;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeFieldInfoPtr_m_lineJustificationStack;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeFieldInfoPtr_m_textContainerLocalCorners;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeFieldInfoPtr_m_characterSpacing;

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeFieldInfoPtr_m_cSpacing;

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeFieldInfoPtr_m_monoSpacing;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeFieldInfoPtr_m_wordSpacing;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeFieldInfoPtr_m_lineSpacing;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeFieldInfoPtr_m_lineSpacingDelta;

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeFieldInfoPtr_m_lineHeight;

		// Token: 0x040008DF RID: 2271
		private static readonly IntPtr NativeFieldInfoPtr_m_IsDrivenLineSpacing;

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeFieldInfoPtr_m_lineSpacingMax;

		// Token: 0x040008E1 RID: 2273
		private static readonly IntPtr NativeFieldInfoPtr_m_paragraphSpacing;

		// Token: 0x040008E2 RID: 2274
		private static readonly IntPtr NativeFieldInfoPtr_m_charWidthMaxAdj;

		// Token: 0x040008E3 RID: 2275
		private static readonly IntPtr NativeFieldInfoPtr_m_charWidthAdjDelta;

		// Token: 0x040008E4 RID: 2276
		private static readonly IntPtr NativeFieldInfoPtr_m_enableWordWrapping;

		// Token: 0x040008E5 RID: 2277
		private static readonly IntPtr NativeFieldInfoPtr_m_isCharacterWrappingEnabled;

		// Token: 0x040008E6 RID: 2278
		private static readonly IntPtr NativeFieldInfoPtr_m_isNonBreakingSpace;

		// Token: 0x040008E7 RID: 2279
		private static readonly IntPtr NativeFieldInfoPtr_m_isIgnoringAlignment;

		// Token: 0x040008E8 RID: 2280
		private static readonly IntPtr NativeFieldInfoPtr_m_wordWrappingRatios;

		// Token: 0x040008E9 RID: 2281
		private static readonly IntPtr NativeFieldInfoPtr_m_overflowMode;

		// Token: 0x040008EA RID: 2282
		private static readonly IntPtr NativeFieldInfoPtr_m_firstOverflowCharacterIndex;

		// Token: 0x040008EB RID: 2283
		private static readonly IntPtr NativeFieldInfoPtr_m_linkedTextComponent;

		// Token: 0x040008EC RID: 2284
		private static readonly IntPtr NativeFieldInfoPtr_parentLinkedComponent;

		// Token: 0x040008ED RID: 2285
		private static readonly IntPtr NativeFieldInfoPtr_m_isTextTruncated;

		// Token: 0x040008EE RID: 2286
		private static readonly IntPtr NativeFieldInfoPtr_m_enableKerning;

		// Token: 0x040008EF RID: 2287
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphHorizontalAdvanceAdjustment;

		// Token: 0x040008F0 RID: 2288
		private static readonly IntPtr NativeFieldInfoPtr_m_enableExtraPadding;

		// Token: 0x040008F1 RID: 2289
		private static readonly IntPtr NativeFieldInfoPtr_checkPaddingRequired;

		// Token: 0x040008F2 RID: 2290
		private static readonly IntPtr NativeFieldInfoPtr_m_isRichText;

		// Token: 0x040008F3 RID: 2291
		private static readonly IntPtr NativeFieldInfoPtr_m_parseCtrlCharacters;

		// Token: 0x040008F4 RID: 2292
		private static readonly IntPtr NativeFieldInfoPtr_m_isOverlay;

		// Token: 0x040008F5 RID: 2293
		private static readonly IntPtr NativeFieldInfoPtr_m_isOrthographic;

		// Token: 0x040008F6 RID: 2294
		private static readonly IntPtr NativeFieldInfoPtr_m_isCullingEnabled;

		// Token: 0x040008F7 RID: 2295
		private static readonly IntPtr NativeFieldInfoPtr_m_isMaskingEnabled;

		// Token: 0x040008F8 RID: 2296
		private static readonly IntPtr NativeFieldInfoPtr_isMaskUpdateRequired;

		// Token: 0x040008F9 RID: 2297
		private static readonly IntPtr NativeFieldInfoPtr_m_ignoreCulling;

		// Token: 0x040008FA RID: 2298
		private static readonly IntPtr NativeFieldInfoPtr_m_horizontalMapping;

		// Token: 0x040008FB RID: 2299
		private static readonly IntPtr NativeFieldInfoPtr_m_verticalMapping;

		// Token: 0x040008FC RID: 2300
		private static readonly IntPtr NativeFieldInfoPtr_m_uvLineOffset;

		// Token: 0x040008FD RID: 2301
		private static readonly IntPtr NativeFieldInfoPtr_m_renderMode;

		// Token: 0x040008FE RID: 2302
		private static readonly IntPtr NativeFieldInfoPtr_m_geometrySortingOrder;

		// Token: 0x040008FF RID: 2303
		private static readonly IntPtr NativeFieldInfoPtr_m_IsTextObjectScaleStatic;

		// Token: 0x04000900 RID: 2304
		private static readonly IntPtr NativeFieldInfoPtr_m_VertexBufferAutoSizeReduction;

		// Token: 0x04000901 RID: 2305
		private static readonly IntPtr NativeFieldInfoPtr_m_firstVisibleCharacter;

		// Token: 0x04000902 RID: 2306
		private static readonly IntPtr NativeFieldInfoPtr_m_maxVisibleCharacters;

		// Token: 0x04000903 RID: 2307
		private static readonly IntPtr NativeFieldInfoPtr_m_maxVisibleWords;

		// Token: 0x04000904 RID: 2308
		private static readonly IntPtr NativeFieldInfoPtr_m_maxVisibleLines;

		// Token: 0x04000905 RID: 2309
		private static readonly IntPtr NativeFieldInfoPtr_m_useMaxVisibleDescender;

		// Token: 0x04000906 RID: 2310
		private static readonly IntPtr NativeFieldInfoPtr_m_pageToDisplay;

		// Token: 0x04000907 RID: 2311
		private static readonly IntPtr NativeFieldInfoPtr_m_isNewPage;

		// Token: 0x04000908 RID: 2312
		private static readonly IntPtr NativeFieldInfoPtr_m_margin;

		// Token: 0x04000909 RID: 2313
		private static readonly IntPtr NativeFieldInfoPtr_m_marginLeft;

		// Token: 0x0400090A RID: 2314
		private static readonly IntPtr NativeFieldInfoPtr_m_marginRight;

		// Token: 0x0400090B RID: 2315
		private static readonly IntPtr NativeFieldInfoPtr_m_marginWidth;

		// Token: 0x0400090C RID: 2316
		private static readonly IntPtr NativeFieldInfoPtr_m_marginHeight;

		// Token: 0x0400090D RID: 2317
		private static readonly IntPtr NativeFieldInfoPtr_m_width;

		// Token: 0x0400090E RID: 2318
		private static readonly IntPtr NativeFieldInfoPtr_m_textInfo;

		// Token: 0x0400090F RID: 2319
		private static readonly IntPtr NativeFieldInfoPtr_m_havePropertiesChanged;

		// Token: 0x04000910 RID: 2320
		private static readonly IntPtr NativeFieldInfoPtr_m_isUsingLegacyAnimationComponent;

		// Token: 0x04000911 RID: 2321
		private static readonly IntPtr NativeFieldInfoPtr_m_transform;

		// Token: 0x04000912 RID: 2322
		private static readonly IntPtr NativeFieldInfoPtr_m_rectTransform;

		// Token: 0x04000913 RID: 2323
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousRectTransformSize;

		// Token: 0x04000914 RID: 2324
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousPivotPosition;

		// Token: 0x04000915 RID: 2325
		private static readonly IntPtr NativeFieldInfoPtr__autoSizeTextContainer_k__BackingField;

		// Token: 0x04000916 RID: 2326
		private static readonly IntPtr NativeFieldInfoPtr_m_autoSizeTextContainer;

		// Token: 0x04000917 RID: 2327
		private static readonly IntPtr NativeFieldInfoPtr_m_mesh;

		// Token: 0x04000918 RID: 2328
		private static readonly IntPtr NativeFieldInfoPtr_m_isVolumetricText;

		// Token: 0x04000919 RID: 2329
		private static readonly IntPtr NativeFieldInfoPtr_OnFontAssetRequest;

		// Token: 0x0400091A RID: 2330
		private static readonly IntPtr NativeFieldInfoPtr_OnSpriteAssetRequest;

		// Token: 0x0400091B RID: 2331
		private static readonly IntPtr NativeFieldInfoPtr_OnPreRenderText;

		// Token: 0x0400091C RID: 2332
		private static readonly IntPtr NativeFieldInfoPtr_m_spriteAnimator;

		// Token: 0x0400091D RID: 2333
		private static readonly IntPtr NativeFieldInfoPtr_m_flexibleHeight;

		// Token: 0x0400091E RID: 2334
		private static readonly IntPtr NativeFieldInfoPtr_m_flexibleWidth;

		// Token: 0x0400091F RID: 2335
		private static readonly IntPtr NativeFieldInfoPtr_m_minWidth;

		// Token: 0x04000920 RID: 2336
		private static readonly IntPtr NativeFieldInfoPtr_m_minHeight;

		// Token: 0x04000921 RID: 2337
		private static readonly IntPtr NativeFieldInfoPtr_m_maxWidth;

		// Token: 0x04000922 RID: 2338
		private static readonly IntPtr NativeFieldInfoPtr_m_maxHeight;

		// Token: 0x04000923 RID: 2339
		private static readonly IntPtr NativeFieldInfoPtr_m_LayoutElement;

		// Token: 0x04000924 RID: 2340
		private static readonly IntPtr NativeFieldInfoPtr_m_preferredWidth;

		// Token: 0x04000925 RID: 2341
		private static readonly IntPtr NativeFieldInfoPtr_m_renderedWidth;

		// Token: 0x04000926 RID: 2342
		private static readonly IntPtr NativeFieldInfoPtr_m_isPreferredWidthDirty;

		// Token: 0x04000927 RID: 2343
		private static readonly IntPtr NativeFieldInfoPtr_m_preferredHeight;

		// Token: 0x04000928 RID: 2344
		private static readonly IntPtr NativeFieldInfoPtr_m_renderedHeight;

		// Token: 0x04000929 RID: 2345
		private static readonly IntPtr NativeFieldInfoPtr_m_isPreferredHeightDirty;

		// Token: 0x0400092A RID: 2346
		private static readonly IntPtr NativeFieldInfoPtr_m_isCalculatingPreferredValues;

		// Token: 0x0400092B RID: 2347
		private static readonly IntPtr NativeFieldInfoPtr_m_layoutPriority;

		// Token: 0x0400092C RID: 2348
		private static readonly IntPtr NativeFieldInfoPtr_m_isLayoutDirty;

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeFieldInfoPtr_m_isAwake;

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeFieldInfoPtr_m_isWaitingOnResourceLoad;

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeFieldInfoPtr_m_inputSource;

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeFieldInfoPtr_m_fontScaleMultiplier;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeFieldInfoPtr_m_htmlTag;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeFieldInfoPtr_m_xmlAttribute;

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeFieldInfoPtr_m_attributeParameterValues;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeFieldInfoPtr_tag_LineIndent;

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeFieldInfoPtr_tag_Indent;

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeFieldInfoPtr_m_indentStack;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeFieldInfoPtr_tag_NoParsing;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeFieldInfoPtr_m_isParsingText;

		// Token: 0x04000939 RID: 2361
		private static readonly IntPtr NativeFieldInfoPtr_m_FXMatrix;

		// Token: 0x0400093A RID: 2362
		private static readonly IntPtr NativeFieldInfoPtr_m_isFXMatrixSet;

		// Token: 0x0400093B RID: 2363
		private static readonly IntPtr NativeFieldInfoPtr_m_TextProcessingArray;

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalTextProcessingArraySize;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeFieldInfoPtr_m_internalCharacterInfo;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeFieldInfoPtr_m_totalCharacterCount;

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeFieldInfoPtr_m_SavedWordWrapState;

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeFieldInfoPtr_m_SavedLineState;

		// Token: 0x04000941 RID: 2369
		private static readonly IntPtr NativeFieldInfoPtr_m_SavedEllipsisState;

		// Token: 0x04000942 RID: 2370
		private static readonly IntPtr NativeFieldInfoPtr_m_SavedLastValidState;

		// Token: 0x04000943 RID: 2371
		private static readonly IntPtr NativeFieldInfoPtr_m_SavedSoftLineBreakState;

		// Token: 0x04000944 RID: 2372
		private static readonly IntPtr NativeFieldInfoPtr_m_EllipsisInsertionCandidateStack;

		// Token: 0x04000945 RID: 2373
		private static readonly IntPtr NativeFieldInfoPtr_m_characterCount;

		// Token: 0x04000946 RID: 2374
		private static readonly IntPtr NativeFieldInfoPtr_m_firstCharacterOfLine;

		// Token: 0x04000947 RID: 2375
		private static readonly IntPtr NativeFieldInfoPtr_m_firstVisibleCharacterOfLine;

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeFieldInfoPtr_m_lastCharacterOfLine;

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeFieldInfoPtr_m_lastVisibleCharacterOfLine;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeFieldInfoPtr_m_lineNumber;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeFieldInfoPtr_m_lineVisibleCharacterCount;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeFieldInfoPtr_m_pageNumber;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeFieldInfoPtr_m_PageAscender;

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeFieldInfoPtr_m_maxTextAscender;

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeFieldInfoPtr_m_maxCapHeight;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeFieldInfoPtr_m_ElementAscender;

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeFieldInfoPtr_m_ElementDescender;

		// Token: 0x04000952 RID: 2386
		private static readonly IntPtr NativeFieldInfoPtr_m_maxLineAscender;

		// Token: 0x04000953 RID: 2387
		private static readonly IntPtr NativeFieldInfoPtr_m_maxLineDescender;

		// Token: 0x04000954 RID: 2388
		private static readonly IntPtr NativeFieldInfoPtr_m_startOfLineAscender;

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeFieldInfoPtr_m_startOfLineDescender;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeFieldInfoPtr_m_lineOffset;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeFieldInfoPtr_m_meshExtents;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeFieldInfoPtr_m_htmlColor;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeFieldInfoPtr_m_colorStack;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeFieldInfoPtr_m_underlineColorStack;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeFieldInfoPtr_m_strikethroughColorStack;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeFieldInfoPtr_m_HighlightStateStack;

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeFieldInfoPtr_m_colorGradientPreset;

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeFieldInfoPtr_m_colorGradientStack;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeFieldInfoPtr_m_colorGradientPresetIsTinted;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeFieldInfoPtr_m_tabSpacing;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeFieldInfoPtr_m_spacing;

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeFieldInfoPtr_m_TextStyleStacks;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeFieldInfoPtr_m_TextStyleStackDepth;

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeFieldInfoPtr_m_ItalicAngleStack;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeFieldInfoPtr_m_ItalicAngle;

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeFieldInfoPtr_m_actionStack;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeFieldInfoPtr_m_padding;

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeFieldInfoPtr_m_baselineOffset;

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeFieldInfoPtr_m_baselineOffsetStack;

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeFieldInfoPtr_m_xAdvance;

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeFieldInfoPtr_m_textElementType;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeFieldInfoPtr_m_cached_TextElement;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeFieldInfoPtr_m_Ellipsis;

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeFieldInfoPtr_m_Underline;

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultSpriteAsset;

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeFieldInfoPtr_m_currentSpriteAsset;

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeFieldInfoPtr_m_spriteCount;

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeFieldInfoPtr_m_spriteIndex;

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeFieldInfoPtr_m_spriteAnimationID;

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeFieldInfoPtr_k_ParseTextMarker;

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeFieldInfoPtr_k_InsertNewLineMarker;

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeFieldInfoPtr_m_ignoreActiveState;

		// Token: 0x04000977 RID: 2423
		private static readonly IntPtr NativeFieldInfoPtr_m_TextBackingArray;

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeFieldInfoPtr_k_Power;

		// Token: 0x04000979 RID: 2425
		private static readonly IntPtr NativeFieldInfoPtr_k_LargePositiveVector2;

		// Token: 0x0400097A RID: 2426
		private static readonly IntPtr NativeFieldInfoPtr_k_LargeNegativeVector2;

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeFieldInfoPtr_k_LargePositiveFloat;

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeFieldInfoPtr_k_LargeNegativeFloat;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeFieldInfoPtr_k_LargePositiveInt;

		// Token: 0x0400097E RID: 2430
		private static readonly IntPtr NativeFieldInfoPtr_k_LargeNegativeInt;

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_Virtual_New_get_String_0;

		// Token: 0x04000980 RID: 2432
		private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000981 RID: 2433
		private static readonly IntPtr NativeMethodInfoPtr_get_textPreprocessor_Public_get_ITextPreprocessor_0;

		// Token: 0x04000982 RID: 2434
		private static readonly IntPtr NativeMethodInfoPtr_set_textPreprocessor_Public_set_Void_ITextPreprocessor_0;

		// Token: 0x04000983 RID: 2435
		private static readonly IntPtr NativeMethodInfoPtr_get_isRightToLeftText_Public_get_Boolean_0;

		// Token: 0x04000984 RID: 2436
		private static readonly IntPtr NativeMethodInfoPtr_set_isRightToLeftText_Public_set_Void_Boolean_0;

		// Token: 0x04000985 RID: 2437
		private static readonly IntPtr NativeMethodInfoPtr_get_font_Public_get_TMP_FontAsset_0;

		// Token: 0x04000986 RID: 2438
		private static readonly IntPtr NativeMethodInfoPtr_set_font_Public_set_Void_TMP_FontAsset_0;

		// Token: 0x04000987 RID: 2439
		private static readonly IntPtr NativeMethodInfoPtr_get_fontSharedMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeMethodInfoPtr_set_fontSharedMaterial_Public_Virtual_New_set_Void_Material_0;

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeMethodInfoPtr_get_fontSharedMaterials_Public_Virtual_New_get_Il2CppReferenceArray_1_Material_0;

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeMethodInfoPtr_set_fontSharedMaterials_Public_Virtual_New_set_Void_Il2CppReferenceArray_1_Material_0;

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeMethodInfoPtr_get_fontMaterial_Public_get_Material_0;

		// Token: 0x0400098C RID: 2444
		private static readonly IntPtr NativeMethodInfoPtr_set_fontMaterial_Public_set_Void_Material_0;

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeMethodInfoPtr_get_fontMaterials_Public_Virtual_New_get_Il2CppReferenceArray_1_Material_0;

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeMethodInfoPtr_set_fontMaterials_Public_Virtual_New_set_Void_Il2CppReferenceArray_1_Material_0;

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_Virtual_get_Color_0;

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_Virtual_set_Void_Color_0;

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeMethodInfoPtr_get_alpha_Public_get_Single_0;

		// Token: 0x04000992 RID: 2450
		private static readonly IntPtr NativeMethodInfoPtr_set_alpha_Public_set_Void_Single_0;

		// Token: 0x04000993 RID: 2451
		private static readonly IntPtr NativeMethodInfoPtr_get_enableVertexGradient_Public_get_Boolean_0;

		// Token: 0x04000994 RID: 2452
		private static readonly IntPtr NativeMethodInfoPtr_set_enableVertexGradient_Public_set_Void_Boolean_0;

		// Token: 0x04000995 RID: 2453
		private static readonly IntPtr NativeMethodInfoPtr_get_colorGradient_Public_get_VertexGradient_0;

		// Token: 0x04000996 RID: 2454
		private static readonly IntPtr NativeMethodInfoPtr_set_colorGradient_Public_set_Void_VertexGradient_0;

		// Token: 0x04000997 RID: 2455
		private static readonly IntPtr NativeMethodInfoPtr_get_colorGradientPreset_Public_get_TMP_ColorGradient_0;

		// Token: 0x04000998 RID: 2456
		private static readonly IntPtr NativeMethodInfoPtr_set_colorGradientPreset_Public_set_Void_TMP_ColorGradient_0;

		// Token: 0x04000999 RID: 2457
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteAsset_Public_get_TMP_SpriteAsset_0;

		// Token: 0x0400099A RID: 2458
		private static readonly IntPtr NativeMethodInfoPtr_set_spriteAsset_Public_set_Void_TMP_SpriteAsset_0;

		// Token: 0x0400099B RID: 2459
		private static readonly IntPtr NativeMethodInfoPtr_get_tintAllSprites_Public_get_Boolean_0;

		// Token: 0x0400099C RID: 2460
		private static readonly IntPtr NativeMethodInfoPtr_set_tintAllSprites_Public_set_Void_Boolean_0;

		// Token: 0x0400099D RID: 2461
		private static readonly IntPtr NativeMethodInfoPtr_get_styleSheet_Public_get_TMP_StyleSheet_0;

		// Token: 0x0400099E RID: 2462
		private static readonly IntPtr NativeMethodInfoPtr_set_styleSheet_Public_set_Void_TMP_StyleSheet_0;

		// Token: 0x0400099F RID: 2463
		private static readonly IntPtr NativeMethodInfoPtr_get_textStyle_Public_get_TMP_Style_0;

		// Token: 0x040009A0 RID: 2464
		private static readonly IntPtr NativeMethodInfoPtr_set_textStyle_Public_set_Void_TMP_Style_0;

		// Token: 0x040009A1 RID: 2465
		private static readonly IntPtr NativeMethodInfoPtr_get_overrideColorTags_Public_get_Boolean_0;

		// Token: 0x040009A2 RID: 2466
		private static readonly IntPtr NativeMethodInfoPtr_set_overrideColorTags_Public_set_Void_Boolean_0;

		// Token: 0x040009A3 RID: 2467
		private static readonly IntPtr NativeMethodInfoPtr_get_faceColor_Public_get_Color32_0;

		// Token: 0x040009A4 RID: 2468
		private static readonly IntPtr NativeMethodInfoPtr_set_faceColor_Public_set_Void_Color32_0;

		// Token: 0x040009A5 RID: 2469
		private static readonly IntPtr NativeMethodInfoPtr_get_outlineColor_Public_get_Color32_0;

		// Token: 0x040009A6 RID: 2470
		private static readonly IntPtr NativeMethodInfoPtr_set_outlineColor_Public_set_Void_Color32_0;

		// Token: 0x040009A7 RID: 2471
		private static readonly IntPtr NativeMethodInfoPtr_get_outlineWidth_Public_get_Single_0;

		// Token: 0x040009A8 RID: 2472
		private static readonly IntPtr NativeMethodInfoPtr_set_outlineWidth_Public_set_Void_Single_0;

		// Token: 0x040009A9 RID: 2473
		private static readonly IntPtr NativeMethodInfoPtr_get_fontSize_Public_get_Single_0;

		// Token: 0x040009AA RID: 2474
		private static readonly IntPtr NativeMethodInfoPtr_set_fontSize_Public_set_Void_Single_0;

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeMethodInfoPtr_get_fontWeight_Public_get_FontWeight_0;

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeMethodInfoPtr_set_fontWeight_Public_set_Void_FontWeight_0;

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0;

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeMethodInfoPtr_get_enableAutoSizing_Public_get_Boolean_0;

		// Token: 0x040009AF RID: 2479
		private static readonly IntPtr NativeMethodInfoPtr_set_enableAutoSizing_Public_set_Void_Boolean_0;

		// Token: 0x040009B0 RID: 2480
		private static readonly IntPtr NativeMethodInfoPtr_get_fontSizeMin_Public_get_Single_0;

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeMethodInfoPtr_set_fontSizeMin_Public_set_Void_Single_0;

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeMethodInfoPtr_get_fontSizeMax_Public_get_Single_0;

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeMethodInfoPtr_set_fontSizeMax_Public_set_Void_Single_0;

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeMethodInfoPtr_get_fontStyle_Public_get_FontStyles_0;

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeMethodInfoPtr_set_fontStyle_Public_set_Void_FontStyles_0;

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeMethodInfoPtr_get_isUsingBold_Public_get_Boolean_0;

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalAlignment_Public_get_HorizontalAlignmentOptions_0;

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalAlignment_Public_set_Void_HorizontalAlignmentOptions_0;

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalAlignment_Public_get_VerticalAlignmentOptions_0;

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalAlignment_Public_set_Void_VerticalAlignmentOptions_0;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeMethodInfoPtr_get_alignment_Public_get_TextAlignmentOptions_0;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAlignmentOptions_0;

		// Token: 0x040009BD RID: 2493
		private static readonly IntPtr NativeMethodInfoPtr_get_characterSpacing_Public_get_Single_0;

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeMethodInfoPtr_set_characterSpacing_Public_set_Void_Single_0;

		// Token: 0x040009BF RID: 2495
		private static readonly IntPtr NativeMethodInfoPtr_get_wordSpacing_Public_get_Single_0;

		// Token: 0x040009C0 RID: 2496
		private static readonly IntPtr NativeMethodInfoPtr_set_wordSpacing_Public_set_Void_Single_0;

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0;

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeMethodInfoPtr_set_lineSpacing_Public_set_Void_Single_0;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeMethodInfoPtr_get_lineSpacingAdjustment_Public_get_Single_0;

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeMethodInfoPtr_set_lineSpacingAdjustment_Public_set_Void_Single_0;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeMethodInfoPtr_get_paragraphSpacing_Public_get_Single_0;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeMethodInfoPtr_set_paragraphSpacing_Public_set_Void_Single_0;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeMethodInfoPtr_get_characterWidthAdjustment_Public_get_Single_0;

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeMethodInfoPtr_set_characterWidthAdjustment_Public_set_Void_Single_0;

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeMethodInfoPtr_get_enableWordWrapping_Public_get_Boolean_0;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeMethodInfoPtr_set_enableWordWrapping_Public_set_Void_Boolean_0;

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeMethodInfoPtr_get_wordWrappingRatios_Public_get_Single_0;

		// Token: 0x040009CC RID: 2508
		private static readonly IntPtr NativeMethodInfoPtr_set_wordWrappingRatios_Public_set_Void_Single_0;

		// Token: 0x040009CD RID: 2509
		private static readonly IntPtr NativeMethodInfoPtr_get_overflowMode_Public_get_TextOverflowModes_0;

		// Token: 0x040009CE RID: 2510
		private static readonly IntPtr NativeMethodInfoPtr_set_overflowMode_Public_set_Void_TextOverflowModes_0;

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeMethodInfoPtr_get_isTextOverflowing_Public_get_Boolean_0;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeMethodInfoPtr_get_firstOverflowCharacterIndex_Public_get_Int32_0;

		// Token: 0x040009D1 RID: 2513
		private static readonly IntPtr NativeMethodInfoPtr_get_linkedTextComponent_Public_get_TMP_Text_0;

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeMethodInfoPtr_set_linkedTextComponent_Public_set_Void_TMP_Text_0;

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeMethodInfoPtr_get_isTextTruncated_Public_get_Boolean_0;

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeMethodInfoPtr_get_enableKerning_Public_get_Boolean_0;

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeMethodInfoPtr_set_enableKerning_Public_set_Void_Boolean_0;

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeMethodInfoPtr_get_extraPadding_Public_get_Boolean_0;

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeMethodInfoPtr_set_extraPadding_Public_set_Void_Boolean_0;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeMethodInfoPtr_get_richText_Public_get_Boolean_0;

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeMethodInfoPtr_set_richText_Public_set_Void_Boolean_0;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeMethodInfoPtr_get_parseCtrlCharacters_Public_get_Boolean_0;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeMethodInfoPtr_set_parseCtrlCharacters_Public_set_Void_Boolean_0;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeMethodInfoPtr_get_isOverlay_Public_get_Boolean_0;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeMethodInfoPtr_set_isOverlay_Public_set_Void_Boolean_0;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeMethodInfoPtr_get_isOrthographic_Public_get_Boolean_0;

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeMethodInfoPtr_set_isOrthographic_Public_set_Void_Boolean_0;

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeMethodInfoPtr_get_enableCulling_Public_get_Boolean_0;

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeMethodInfoPtr_set_enableCulling_Public_set_Void_Boolean_0;

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreVisibility_Public_get_Boolean_0;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeMethodInfoPtr_set_ignoreVisibility_Public_set_Void_Boolean_0;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalMapping_Public_get_TextureMappingOptions_0;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalMapping_Public_set_Void_TextureMappingOptions_0;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalMapping_Public_get_TextureMappingOptions_0;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalMapping_Public_set_Void_TextureMappingOptions_0;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeMethodInfoPtr_get_mappingUvLineOffset_Public_get_Single_0;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeMethodInfoPtr_set_mappingUvLineOffset_Public_set_Void_Single_0;

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeMethodInfoPtr_get_renderMode_Public_get_TextRenderFlags_0;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeMethodInfoPtr_set_renderMode_Public_set_Void_TextRenderFlags_0;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeMethodInfoPtr_get_geometrySortingOrder_Public_get_VertexSortingOrder_0;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeMethodInfoPtr_set_geometrySortingOrder_Public_set_Void_VertexSortingOrder_0;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeMethodInfoPtr_get_isTextObjectScaleStatic_Public_get_Boolean_0;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeMethodInfoPtr_set_isTextObjectScaleStatic_Public_set_Void_Boolean_0;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeMethodInfoPtr_get_vertexBufferAutoSizeReduction_Public_get_Boolean_0;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeMethodInfoPtr_set_vertexBufferAutoSizeReduction_Public_set_Void_Boolean_0;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeMethodInfoPtr_get_firstVisibleCharacter_Public_get_Int32_0;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeMethodInfoPtr_set_firstVisibleCharacter_Public_set_Void_Int32_0;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeMethodInfoPtr_get_maxVisibleCharacters_Public_get_Int32_0;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeMethodInfoPtr_set_maxVisibleCharacters_Public_set_Void_Int32_0;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeMethodInfoPtr_get_maxVisibleWords_Public_get_Int32_0;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeMethodInfoPtr_set_maxVisibleWords_Public_set_Void_Int32_0;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeMethodInfoPtr_get_maxVisibleLines_Public_get_Int32_0;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeMethodInfoPtr_set_maxVisibleLines_Public_set_Void_Int32_0;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeMethodInfoPtr_get_useMaxVisibleDescender_Public_get_Boolean_0;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeMethodInfoPtr_set_useMaxVisibleDescender_Public_set_Void_Boolean_0;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeMethodInfoPtr_get_pageToDisplay_Public_get_Int32_0;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeMethodInfoPtr_set_pageToDisplay_Public_set_Void_Int32_0;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeMethodInfoPtr_get_margin_Public_Virtual_New_get_Vector4_0;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeMethodInfoPtr_set_margin_Public_Virtual_New_set_Void_Vector4_0;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeMethodInfoPtr_get_textInfo_Public_get_TMP_TextInfo_0;

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeMethodInfoPtr_get_havePropertiesChanged_Public_get_Boolean_0;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeMethodInfoPtr_set_havePropertiesChanged_Public_set_Void_Boolean_0;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeMethodInfoPtr_get_isUsingLegacyAnimationComponent_Public_get_Boolean_0;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeMethodInfoPtr_set_isUsingLegacyAnimationComponent_Public_set_Void_Boolean_0;

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeMethodInfoPtr_get_transform_Public_get_Transform_0;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0;

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeMethodInfoPtr_get_autoSizeTextContainer_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeMethodInfoPtr_set_autoSizeTextContainer_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeMethodInfoPtr_get_mesh_Public_Virtual_New_get_Mesh_0;

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeMethodInfoPtr_get_isVolumetricText_Public_get_Boolean_0;

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeMethodInfoPtr_set_isVolumetricText_Public_set_Void_Boolean_0;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeMethodInfoPtr_get_textBounds_Public_get_Bounds_0;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeMethodInfoPtr_add_OnFontAssetRequest_Public_Static_add_Void_Func_3_Int32_String_TMP_FontAsset_0;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnFontAssetRequest_Public_Static_rem_Void_Func_3_Int32_String_TMP_FontAsset_0;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSpriteAssetRequest_Public_Static_add_Void_Func_3_Int32_String_TMP_SpriteAsset_0;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSpriteAssetRequest_Public_Static_rem_Void_Func_3_Int32_String_TMP_SpriteAsset_0;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeMethodInfoPtr_add_OnPreRenderText_Public_Virtual_New_add_Void_Action_1_TMP_TextInfo_0;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnPreRenderText_Public_Virtual_New_rem_Void_Action_1_TMP_TextInfo_0;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteAnimator_Protected_get_TMP_SpriteAnimator_0;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeMethodInfoPtr_get_minWidth_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeMethodInfoPtr_get_minHeight_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeMethodInfoPtr_get_maxWidth_Public_get_Single_0;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeMethodInfoPtr_get_maxHeight_Public_get_Single_0;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutElement_Protected_get_LayoutElement_0;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeMethodInfoPtr_get_renderedWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeMethodInfoPtr_get_renderedHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeMethodInfoPtr_LoadFontAsset_Protected_Virtual_New_Void_0;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeMethodInfoPtr_SetSharedMaterial_Protected_Virtual_New_Void_Material_0;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterial_Protected_Virtual_New_Material_Material_0;

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeMethodInfoPtr_SetFontBaseMaterial_Protected_Virtual_New_Void_Material_0;

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMaterials_Protected_Virtual_New_Il2CppReferenceArray_1_Material_0;

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeMethodInfoPtr_SetSharedMaterials_Protected_Virtual_New_Void_Il2CppReferenceArray_1_Material_0;

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterials_Protected_Virtual_New_Il2CppReferenceArray_1_Material_Il2CppReferenceArray_1_Material_0;

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeMethodInfoPtr_CreateMaterialInstance_Protected_Virtual_New_Material_Material_0;

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeMethodInfoPtr_SetVertexColorGradient_Protected_Void_TMP_ColorGradient_0;

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeMethodInfoPtr_SetTextSortingOrder_Protected_Void_VertexSortingOrder_0;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeMethodInfoPtr_SetTextSortingOrder_Protected_Void_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeMethodInfoPtr_SetFaceColor_Protected_Virtual_New_Void_Color32_0;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeMethodInfoPtr_SetOutlineColor_Protected_Virtual_New_Void_Color32_0;

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeMethodInfoPtr_SetOutlineThickness_Protected_Virtual_New_Void_Single_0;

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeMethodInfoPtr_SetShaderDepth_Protected_Virtual_New_Void_0;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeMethodInfoPtr_SetCulling_Protected_Virtual_New_Void_0;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCulling_Internal_Virtual_New_Void_0;

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeMethodInfoPtr_GetPaddingForMaterial_Protected_Virtual_New_Single_0;

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeMethodInfoPtr_GetPaddingForMaterial_Protected_Virtual_New_Single_Material_0;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeMethodInfoPtr_GetTextContainerLocalCorners_Protected_Virtual_New_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeMethodInfoPtr_ForceMeshUpdate_Public_Virtual_New_Void_Boolean_Boolean_0;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGeometry_Public_Virtual_New_Void_Mesh_Int32_0;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_New_Void_TMP_VertexDataUpdateFlags_0;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVertexData_Public_Virtual_New_Void_0;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeMethodInfoPtr_SetVertices_Public_Virtual_New_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMeshPadding_Public_Virtual_New_Void_0;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeMethodInfoPtr_CrossFadeColor_Public_Virtual_Void_Color_Single_Boolean_Boolean_0;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeMethodInfoPtr_CrossFadeAlpha_Public_Virtual_Void_Single_Single_Boolean_0;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeMethodInfoPtr_InternalCrossFadeColor_Protected_Virtual_New_Void_Color_Single_Boolean_Boolean_0;

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeMethodInfoPtr_InternalCrossFadeAlpha_Protected_Virtual_New_Void_Single_Single_Boolean_0;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeMethodInfoPtr_ParseInputText_Protected_Void_0;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_String_0;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_String_Int32_Int32_0;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_StringBuilder_Int32_Int32_0;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeMethodInfoPtr_PopulateTextBackingArray_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeMethodInfoPtr_PopulateTextProcessingArray_Private_Void_0;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeMethodInfoPtr_SetTextInternal_Private_Void_String_0;

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Boolean_0;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Single_0;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_0;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_0;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_0;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_0;

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Single_Single_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_StringBuilder_0;

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Private_Void_StringBuilder_Int32_Int32_0;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeMethodInfoPtr_SetCharArray_Public_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeMethodInfoPtr_SetCharArray_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeMethodInfoPtr_GetStyle_Private_TMP_Style_Int32_0;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceOpeningStyleTag_Private_Boolean_byref_TextBackingContainer_Int32_byref_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceOpeningStyleTag_Private_Boolean_byref_Il2CppStructArray_1_Int32_Int32_byref_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceClosingStyleTag_Private_Void_byref_TextBackingContainer_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0;

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceClosingStyleTag_Private_Void_byref_Il2CppStructArray_1_Int32_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0;

		// Token: 0x04000A5A RID: 2650
		private static readonly IntPtr NativeMethodInfoPtr_InsertOpeningStyleTag_Private_Boolean_TMP_Style_Int32_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0;

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeMethodInfoPtr_InsertClosingStyleTag_Private_Void_byref_Il2CppStructArray_1_UnicodeChar_byref_Int32_0;

		// Token: 0x04000A5C RID: 2652
		private static readonly IntPtr NativeMethodInfoPtr_GetMarkupTagHashCode_Private_Int32_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x04000A5D RID: 2653
		private static readonly IntPtr NativeMethodInfoPtr_GetMarkupTagHashCode_Private_Int32_TextBackingContainer_Int32_0;

		// Token: 0x04000A5E RID: 2654
		private static readonly IntPtr NativeMethodInfoPtr_GetStyleHashCode_Private_Int32_byref_Il2CppStructArray_1_Int32_Int32_byref_Int32_0;

		// Token: 0x04000A5F RID: 2655
		private static readonly IntPtr NativeMethodInfoPtr_GetStyleHashCode_Private_Int32_byref_TextBackingContainer_Int32_byref_Int32_0;

		// Token: 0x04000A60 RID: 2656
		private static readonly IntPtr NativeMethodInfoPtr_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_0;

		// Token: 0x04000A61 RID: 2657
		private static readonly IntPtr NativeMethodInfoPtr_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x04000A62 RID: 2658
		private static readonly IntPtr NativeMethodInfoPtr_AddFloatToInternalTextBackingArray_Private_Void_Single_Int32_Int32_byref_Int32_0;

		// Token: 0x04000A63 RID: 2659
		private static readonly IntPtr NativeMethodInfoPtr_AddIntegerToInternalTextBackingArray_Private_Void_Double_Int32_byref_Int32_0;

		// Token: 0x04000A64 RID: 2660
		private static readonly IntPtr NativeMethodInfoPtr_InternalTextBackingArrayToString_Private_String_0;

		// Token: 0x04000A65 RID: 2661
		private static readonly IntPtr NativeMethodInfoPtr_SetArraySizes_Internal_Virtual_New_Int32_Il2CppStructArray_1_UnicodeChar_0;

		// Token: 0x04000A66 RID: 2662
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_0;

		// Token: 0x04000A67 RID: 2663
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_Single_Single_0;

		// Token: 0x04000A68 RID: 2664
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_String_0;

		// Token: 0x04000A69 RID: 2665
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredValues_Public_Vector2_String_Single_Single_0;

		// Token: 0x04000A6A RID: 2666
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredWidth_Protected_Single_0;

		// Token: 0x04000A6B RID: 2667
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredWidth_Private_Single_Vector2_0;

		// Token: 0x04000A6C RID: 2668
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredHeight_Protected_Single_0;

		// Token: 0x04000A6D RID: 2669
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredHeight_Private_Single_Vector2_0;

		// Token: 0x04000A6E RID: 2670
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderedValues_Public_Vector2_0;

		// Token: 0x04000A6F RID: 2671
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderedValues_Public_Vector2_Boolean_0;

		// Token: 0x04000A70 RID: 2672
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderedWidth_Private_Single_0;

		// Token: 0x04000A71 RID: 2673
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderedWidth_Protected_Single_Boolean_0;

		// Token: 0x04000A72 RID: 2674
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderedHeight_Private_Single_0;

		// Token: 0x04000A73 RID: 2675
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderedHeight_Protected_Single_Boolean_0;

		// Token: 0x04000A74 RID: 2676
		private static readonly IntPtr NativeMethodInfoPtr_CalculatePreferredValues_Protected_Virtual_New_Vector2_byref_Single_Vector2_Boolean_Boolean_0;

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeMethodInfoPtr_GetCompoundBounds_Protected_Virtual_New_Bounds_0;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeMethodInfoPtr_GetCanvasSpaceClippingRect_Internal_Virtual_New_Rect_0;

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeMethodInfoPtr_GetTextBounds_Protected_Bounds_0;

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeMethodInfoPtr_GetTextBounds_Protected_Bounds_Boolean_0;

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeMethodInfoPtr_AdjustLineOffset_Protected_Void_Int32_Int32_Single_0;

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeMethodInfoPtr_ResizeLineExtents_Protected_Void_Int32_0;

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeMethodInfoPtr_GetTextInfo_Public_Virtual_New_TMP_TextInfo_String_0;

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeMethodInfoPtr_ComputeMarginSize_Public_Virtual_New_Void_0;

		// Token: 0x04000A7D RID: 2685
		private static readonly IntPtr NativeMethodInfoPtr_InsertNewLine_Protected_Void_Int32_Single_Single_Single_Single_Single_Single_Single_Single_byref_Boolean_byref_Single_0;

		// Token: 0x04000A7E RID: 2686
		private static readonly IntPtr NativeMethodInfoPtr_SaveWordWrappingState_Protected_Void_byref_WordWrapState_Int32_Int32_0;

		// Token: 0x04000A7F RID: 2687
		private static readonly IntPtr NativeMethodInfoPtr_RestoreWordWrappingState_Protected_Int32_byref_WordWrapState_0;

		// Token: 0x04000A80 RID: 2688
		private static readonly IntPtr NativeMethodInfoPtr_SaveGlyphVertexInfo_Protected_Virtual_New_Void_Single_Single_Color32_0;

		// Token: 0x04000A81 RID: 2689
		private static readonly IntPtr NativeMethodInfoPtr_SaveSpriteVertexInfo_Protected_Virtual_New_Void_Color32_0;

		// Token: 0x04000A82 RID: 2690
		private static readonly IntPtr NativeMethodInfoPtr_FillCharacterVertexBuffers_Protected_Virtual_New_Void_Int32_Int32_0;

		// Token: 0x04000A83 RID: 2691
		private static readonly IntPtr NativeMethodInfoPtr_FillCharacterVertexBuffers_Protected_Virtual_New_Void_Int32_Int32_Boolean_0;

		// Token: 0x04000A84 RID: 2692
		private static readonly IntPtr NativeMethodInfoPtr_FillSpriteVertexBuffers_Protected_Virtual_New_Void_Int32_Int32_0;

		// Token: 0x04000A85 RID: 2693
		private static readonly IntPtr NativeMethodInfoPtr_DrawUnderlineMesh_Protected_Virtual_New_Void_Vector3_Vector3_byref_Int32_Single_Single_Single_Single_Color32_0;

		// Token: 0x04000A86 RID: 2694
		private static readonly IntPtr NativeMethodInfoPtr_DrawTextHighlight_Protected_Virtual_New_Void_Vector3_Vector3_byref_Int32_Color32_0;

		// Token: 0x04000A87 RID: 2695
		private static readonly IntPtr NativeMethodInfoPtr_LoadDefaultSettings_Protected_Void_0;

		// Token: 0x04000A88 RID: 2696
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialCharacters_Protected_Void_TMP_FontAsset_0;

		// Token: 0x04000A89 RID: 2697
		private static readonly IntPtr NativeMethodInfoPtr_GetEllipsisSpecialCharacter_Protected_Void_TMP_FontAsset_0;

		// Token: 0x04000A8A RID: 2698
		private static readonly IntPtr NativeMethodInfoPtr_GetUnderlineSpecialCharacter_Protected_Void_TMP_FontAsset_0;

		// Token: 0x04000A8B RID: 2699
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceTagWithCharacter_Protected_Void_Il2CppStructArray_1_Int32_Int32_Int32_Char_0;

		// Token: 0x04000A8C RID: 2700
		private static readonly IntPtr NativeMethodInfoPtr_GetFontAssetForWeight_Protected_TMP_FontAsset_Int32_0;

		// Token: 0x04000A8D RID: 2701
		private static readonly IntPtr NativeMethodInfoPtr_GetTextElement_Internal_TMP_TextElement_UInt32_TMP_FontAsset_FontStyles_FontWeight_byref_Boolean_0;

		// Token: 0x04000A8E RID: 2702
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveSubMeshes_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04000A8F RID: 2703
		private static readonly IntPtr NativeMethodInfoPtr_DestroySubMeshObjects_Protected_Virtual_New_Void_0;

		// Token: 0x04000A90 RID: 2704
		private static readonly IntPtr NativeMethodInfoPtr_ClearMesh_Public_Virtual_New_Void_0;

		// Token: 0x04000A91 RID: 2705
		private static readonly IntPtr NativeMethodInfoPtr_ClearMesh_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04000A92 RID: 2706
		private static readonly IntPtr NativeMethodInfoPtr_GetParsedText_Public_Virtual_New_String_0;

		// Token: 0x04000A93 RID: 2707
		private static readonly IntPtr NativeMethodInfoPtr_IsSelfOrLinkedAncestor_Internal_Boolean_TMP_Text_0;

		// Token: 0x04000A94 RID: 2708
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseLinkedTextComponent_Internal_Void_TMP_Text_0;

		// Token: 0x04000A95 RID: 2709
		private static readonly IntPtr NativeMethodInfoPtr_PackUV_Protected_Vector2_Single_Single_Single_0;

		// Token: 0x04000A96 RID: 2710
		private static readonly IntPtr NativeMethodInfoPtr_PackUV_Protected_Single_Single_Single_0;

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeMethodInfoPtr_InternalUpdate_Internal_Virtual_New_Void_0;

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeMethodInfoPtr_HexToInt_Protected_Int32_Char_0;

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF16_Protected_Int32_String_Int32_0;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF16_Protected_Int32_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF16_Internal_Int32_Il2CppStructArray_1_UInt32_Int32_0;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF16_Protected_Int32_StringBuilder_Int32_0;

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF16_Private_Int32_TextBackingContainer_Int32_0;

		// Token: 0x04000A9E RID: 2718
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF32_Protected_Int32_String_Int32_0;

		// Token: 0x04000A9F RID: 2719
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF32_Protected_Int32_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x04000AA0 RID: 2720
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF32_Internal_Int32_Il2CppStructArray_1_UInt32_Int32_0;

		// Token: 0x04000AA1 RID: 2721
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF32_Protected_Int32_StringBuilder_Int32_0;

		// Token: 0x04000AA2 RID: 2722
		private static readonly IntPtr NativeMethodInfoPtr_GetUTF32_Private_Int32_TextBackingContainer_Int32_0;

		// Token: 0x04000AA3 RID: 2723
		private static readonly IntPtr NativeMethodInfoPtr_HexCharsToColor_Protected_Color32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04000AA4 RID: 2724
		private static readonly IntPtr NativeMethodInfoPtr_HexCharsToColor_Protected_Color32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000AA5 RID: 2725
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeParameters_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_byref_Il2CppStructArray_1_Single_0;

		// Token: 0x04000AA6 RID: 2726
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToFloat_Protected_Single_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000AA7 RID: 2727
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToFloat_Protected_Single_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0;

		// Token: 0x04000AA8 RID: 2728
		private static readonly IntPtr NativeMethodInfoPtr_ValidateHtmlTag_Internal_Boolean_Il2CppStructArray_1_UnicodeChar_Int32_byref_Int32_0;

		// Token: 0x04000AA9 RID: 2729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020000A9 RID: 169
		[StructLayout(2)]
		public struct CharacterSubstitution
		{
			// Token: 0x06001001 RID: 4097 RVA: 0x0003EF7C File Offset: 0x0003D17C
			// Note: this type is marked as 'beforefieldinit'.
			static CharacterSubstitution()
			{
				Il2CppClassPointerStore<TMP_Text.CharacterSubstitution>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "CharacterSubstitution");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Text.CharacterSubstitution>.NativeClassPtr);
				TMP_Text.CharacterSubstitution.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.CharacterSubstitution>.NativeClassPtr, "index");
				TMP_Text.CharacterSubstitution.NativeFieldInfoPtr_unicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.CharacterSubstitution>.NativeClassPtr, "unicode");
				TMP_Text.CharacterSubstitution.NativeMethodInfoPtr__ctor_Public_Void_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.CharacterSubstitution>.NativeClassPtr, 100664785);
			}

			// Token: 0x06001002 RID: 4098 RVA: 0x0003EFE4 File Offset: 0x0003D1E4
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 283577, RefRangeEnd = 283616, XrefRangeStart = 283577, XrefRangeEnd = 283616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CharacterSubstitution(int index, uint unicode)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unicode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.CharacterSubstitution.NativeMethodInfoPtr__ctor_Public_Void_Int32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001003 RID: 4099 RVA: 0x00009A69 File Offset: 0x00007C69
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_Text.CharacterSubstitution>.NativeClassPtr, ref this));
			}

			// Token: 0x04000C7F RID: 3199
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04000C80 RID: 3200
			private static readonly IntPtr NativeFieldInfoPtr_unicode;

			// Token: 0x04000C81 RID: 3201
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_UInt32_0;

			// Token: 0x04000C82 RID: 3202
			[FieldOffset(0)]
			public int index;

			// Token: 0x04000C83 RID: 3203
			[FieldOffset(4)]
			public uint unicode;
		}

		// Token: 0x020000AA RID: 170
		public enum TextInputSources
		{
			// Token: 0x04000C85 RID: 3205
			TextInputBox,
			// Token: 0x04000C86 RID: 3206
			SetText,
			// Token: 0x04000C87 RID: 3207
			SetTextArray,
			// Token: 0x04000C88 RID: 3208
			TextString
		}

		// Token: 0x020000AB RID: 171
		[StructLayout(2)]
		public struct UnicodeChar
		{
			// Token: 0x06001004 RID: 4100 RVA: 0x0003F024 File Offset: 0x0003D224
			// Note: this type is marked as 'beforefieldinit'.
			static UnicodeChar()
			{
				Il2CppClassPointerStore<TMP_Text.UnicodeChar>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "UnicodeChar");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Text.UnicodeChar>.NativeClassPtr);
				TMP_Text.UnicodeChar.NativeFieldInfoPtr_unicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.UnicodeChar>.NativeClassPtr, "unicode");
				TMP_Text.UnicodeChar.NativeFieldInfoPtr_stringIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.UnicodeChar>.NativeClassPtr, "stringIndex");
				TMP_Text.UnicodeChar.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.UnicodeChar>.NativeClassPtr, "length");
			}

			// Token: 0x06001005 RID: 4101 RVA: 0x00009A7B File Offset: 0x00007C7B
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_Text.UnicodeChar>.NativeClassPtr, ref this));
			}

			// Token: 0x04000C89 RID: 3209
			private static readonly IntPtr NativeFieldInfoPtr_unicode;

			// Token: 0x04000C8A RID: 3210
			private static readonly IntPtr NativeFieldInfoPtr_stringIndex;

			// Token: 0x04000C8B RID: 3211
			private static readonly IntPtr NativeFieldInfoPtr_length;

			// Token: 0x04000C8C RID: 3212
			[FieldOffset(0)]
			public int unicode;

			// Token: 0x04000C8D RID: 3213
			[FieldOffset(4)]
			public int stringIndex;

			// Token: 0x04000C8E RID: 3214
			[FieldOffset(8)]
			public int length;
		}

		// Token: 0x020000AC RID: 172
		public sealed class SpecialCharacter : ValueType
		{
			// Token: 0x06001006 RID: 4102 RVA: 0x0003F08C File Offset: 0x0003D28C
			// Note: this type is marked as 'beforefieldinit'.
			static SpecialCharacter()
			{
				Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "SpecialCharacter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr);
				TMP_Text.SpecialCharacter.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr, "character");
				TMP_Text.SpecialCharacter.NativeFieldInfoPtr_fontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr, "fontAsset");
				TMP_Text.SpecialCharacter.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr, "material");
				TMP_Text.SpecialCharacter.NativeFieldInfoPtr_materialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr, "materialIndex");
				TMP_Text.SpecialCharacter.NativeMethodInfoPtr__ctor_Public_Void_TMP_Character_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr, 100664786);
			}

			// Token: 0x06001007 RID: 4103 RVA: 0x0003F11C File Offset: 0x0003D31C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1047230, RefRangeEnd = 1047231, XrefRangeStart = 1047217, XrefRangeEnd = 1047230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpecialCharacter(TMP_Character character, int materialIndex)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref materialIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.SpecialCharacter.NativeMethodInfoPtr__ctor_Public_Void_TMP_Character_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001008 RID: 4104 RVA: 0x00009A8D File Offset: 0x00007C8D
			public SpecialCharacter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001009 RID: 4105 RVA: 0x00009A96 File Offset: 0x00007C96
			public SpecialCharacter()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Text.SpecialCharacter>.NativeClassPtr))
			{
			}

			// Token: 0x170005CF RID: 1487
			// (get) Token: 0x0600100A RID: 4106 RVA: 0x0003F17C File Offset: 0x0003D37C
			// (set) Token: 0x0600100B RID: 4107 RVA: 0x00009AA8 File Offset: 0x00007CA8
			public unsafe TMP_Character character
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.SpecialCharacter.NativeFieldInfoPtr_character);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Character>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.SpecialCharacter.NativeFieldInfoPtr_character), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005D0 RID: 1488
			// (get) Token: 0x0600100C RID: 4108 RVA: 0x0003F1AC File Offset: 0x0003D3AC
			// (set) Token: 0x0600100D RID: 4109 RVA: 0x00009AC7 File Offset: 0x00007CC7
			public unsafe TMP_FontAsset fontAsset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.SpecialCharacter.NativeFieldInfoPtr_fontAsset);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.SpecialCharacter.NativeFieldInfoPtr_fontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005D1 RID: 1489
			// (get) Token: 0x0600100E RID: 4110 RVA: 0x0003F1DC File Offset: 0x0003D3DC
			// (set) Token: 0x0600100F RID: 4111 RVA: 0x00009AE6 File Offset: 0x00007CE6
			public unsafe Material material
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.SpecialCharacter.NativeFieldInfoPtr_material);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.SpecialCharacter.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005D2 RID: 1490
			// (get) Token: 0x06001010 RID: 4112 RVA: 0x0003F20C File Offset: 0x0003D40C
			// (set) Token: 0x06001011 RID: 4113 RVA: 0x00009B05 File Offset: 0x00007D05
			public unsafe int materialIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.SpecialCharacter.NativeFieldInfoPtr_materialIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.SpecialCharacter.NativeFieldInfoPtr_materialIndex)) = value;
				}
			}

			// Token: 0x04000C8F RID: 3215
			private static readonly IntPtr NativeFieldInfoPtr_character;

			// Token: 0x04000C90 RID: 3216
			private static readonly IntPtr NativeFieldInfoPtr_fontAsset;

			// Token: 0x04000C91 RID: 3217
			private static readonly IntPtr NativeFieldInfoPtr_material;

			// Token: 0x04000C92 RID: 3218
			private static readonly IntPtr NativeFieldInfoPtr_materialIndex;

			// Token: 0x04000C93 RID: 3219
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TMP_Character_Int32_0;
		}

		// Token: 0x020000AD RID: 173
		public sealed class TextBackingContainer : ValueType
		{
			// Token: 0x06001012 RID: 4114 RVA: 0x0003F234 File Offset: 0x0003D434
			// Note: this type is marked as 'beforefieldinit'.
			static TextBackingContainer()
			{
				Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "TextBackingContainer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr);
				TMP_Text.TextBackingContainer.NativeFieldInfoPtr_m_Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, "m_Array");
				TMP_Text.TextBackingContainer.NativeFieldInfoPtr_m_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, "m_Count");
				TMP_Text.TextBackingContainer.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, 100664787);
				TMP_Text.TextBackingContainer.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, 100664788);
				TMP_Text.TextBackingContainer.NativeMethodInfoPtr_set_Count_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, 100664789);
				TMP_Text.TextBackingContainer.NativeMethodInfoPtr_get_Item_Public_get_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, 100664790);
				TMP_Text.TextBackingContainer.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, 100664791);
				TMP_Text.TextBackingContainer.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, 100664792);
				TMP_Text.TextBackingContainer.NativeMethodInfoPtr_Resize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr, 100664793);
			}

			// Token: 0x170005D5 RID: 1493
			// (get) Token: 0x06001013 RID: 4115 RVA: 0x0003F314 File Offset: 0x0003D514
			public unsafe int Capacity
			{
				[CallerCount(22)]
				[CachedScanResults(RefRangeStart = 336051, RefRangeEnd = 336073, XrefRangeStart = 336051, XrefRangeEnd = 336073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.TextBackingContainer.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170005D6 RID: 1494
			// (get) Token: 0x06001014 RID: 4116 RVA: 0x0003F358 File Offset: 0x0003D558
			// (set) Token: 0x06001015 RID: 4117 RVA: 0x0003F39C File Offset: 0x0003D59C
			public unsafe int Count
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.TextBackingContainer.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(8)]
				[CachedScanResults(RefRangeStart = 310301, RefRangeEnd = 310309, XrefRangeStart = 310301, XrefRangeEnd = 310309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.TextBackingContainer.NativeMethodInfoPtr_set_Count_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170005D7 RID: 1495
			public unsafe uint this[int index]
			{
				[CallerCount(39)]
				[CachedScanResults(RefRangeStart = 1047231, RefRangeEnd = 1047270, XrefRangeStart = 1047231, XrefRangeEnd = 1047231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.TextBackingContainer.NativeMethodInfoPtr_get_Item_Public_get_UInt32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}
				[CallerCount(33)]
				[CachedScanResults(RefRangeStart = 1047274, RefRangeEnd = 1047307, XrefRangeStart = 1047270, XrefRangeEnd = 1047274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.TextBackingContainer.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001018 RID: 4120 RVA: 0x0003F484 File Offset: 0x0003D684
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1047311, RefRangeEnd = 1047312, XrefRangeStart = 1047307, XrefRangeEnd = 1047311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TextBackingContainer(int size)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref size;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.TextBackingContainer.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001019 RID: 4121 RVA: 0x0003F4D0 File Offset: 0x0003D6D0
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1047316, RefRangeEnd = 1047327, XrefRangeStart = 1047312, XrefRangeEnd = 1047316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Resize(int size)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref size;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.TextBackingContainer.NativeMethodInfoPtr_Resize_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600101A RID: 4122 RVA: 0x00009B20 File Offset: 0x00007D20
			public TextBackingContainer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600101B RID: 4123 RVA: 0x00009B29 File Offset: 0x00007D29
			public TextBackingContainer()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Text.TextBackingContainer>.NativeClassPtr))
			{
			}

			// Token: 0x170005D3 RID: 1491
			// (get) Token: 0x0600101C RID: 4124 RVA: 0x0003F514 File Offset: 0x0003D714
			// (set) Token: 0x0600101D RID: 4125 RVA: 0x00009B3B File Offset: 0x00007D3B
			public unsafe Il2CppStructArray<uint> m_Array
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.TextBackingContainer.NativeFieldInfoPtr_m_Array);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.TextBackingContainer.NativeFieldInfoPtr_m_Array), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005D4 RID: 1492
			// (get) Token: 0x0600101E RID: 4126 RVA: 0x0003F544 File Offset: 0x0003D744
			// (set) Token: 0x0600101F RID: 4127 RVA: 0x00009B5A File Offset: 0x00007D5A
			public unsafe int m_Count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.TextBackingContainer.NativeFieldInfoPtr_m_Count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Text.TextBackingContainer.NativeFieldInfoPtr_m_Count)) = value;
				}
			}

			// Token: 0x04000C94 RID: 3220
			private static readonly IntPtr NativeFieldInfoPtr_m_Array;

			// Token: 0x04000C95 RID: 3221
			private static readonly IntPtr NativeFieldInfoPtr_m_Count;

			// Token: 0x04000C96 RID: 3222
			private static readonly IntPtr NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0;

			// Token: 0x04000C97 RID: 3223
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

			// Token: 0x04000C98 RID: 3224
			private static readonly IntPtr NativeMethodInfoPtr_set_Count_Public_set_Void_Int32_0;

			// Token: 0x04000C99 RID: 3225
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_UInt32_Int32_0;

			// Token: 0x04000C9A RID: 3226
			private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_UInt32_0;

			// Token: 0x04000C9B RID: 3227
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000C9C RID: 3228
			private static readonly IntPtr NativeMethodInfoPtr_Resize_Public_Void_Int32_0;
		}

		// Token: 0x020000AE RID: 174
		[ObfuscatedName("TMPro.TMP_Text+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06001020 RID: 4128 RVA: 0x0003F56C File Offset: 0x0003D76C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TMP_Text.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_Text>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Text.__c>.NativeClassPtr);
				TMP_Text.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.__c>.NativeClassPtr, "<>9");
				TMP_Text.__c.NativeFieldInfoPtr___9__622_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Text.__c>.NativeClassPtr, "<>9__622_0");
				TMP_Text.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.__c>.NativeClassPtr, 100664795);
				TMP_Text.__c.NativeMethodInfoPtr___ctor_b__622_0_Internal_Void_TMP_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Text.__c>.NativeClassPtr, 100664796);
			}

			// Token: 0x06001021 RID: 4129 RVA: 0x0003F5E8 File Offset: 0x0003D7E8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Text.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001022 RID: 4130 RVA: 0x0003F624 File Offset: 0x0003D824
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__622_0(TMP_TextInfo <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Text.__c.NativeMethodInfoPtr___ctor_b__622_0_Internal_Void_TMP_TextInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001023 RID: 4131 RVA: 0x00009B75 File Offset: 0x00007D75
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005D8 RID: 1496
			// (get) Token: 0x06001024 RID: 4132 RVA: 0x0003F668 File Offset: 0x0003D868
			// (set) Token: 0x06001025 RID: 4133 RVA: 0x00009B7E File Offset: 0x00007D7E
			public unsafe static TMP_Text.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_Text.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_Text.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005D9 RID: 1497
			// (get) Token: 0x06001026 RID: 4134 RVA: 0x0003F690 File Offset: 0x0003D890
			// (set) Token: 0x06001027 RID: 4135 RVA: 0x00009B90 File Offset: 0x00007D90
			public unsafe static Action<TMP_TextInfo> __9__622_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TMP_Text.__c.NativeFieldInfoPtr___9__622_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TMP_TextInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TMP_Text.__c.NativeFieldInfoPtr___9__622_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C9D RID: 3229
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000C9E RID: 3230
			private static readonly IntPtr NativeFieldInfoPtr___9__622_0;

			// Token: 0x04000C9F RID: 3231
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000CA0 RID: 3232
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__622_0_Internal_Void_TMP_TextInfo_0;
		}

		// Token: 0x020000AF RID: 175
		private sealed class MethodInfoStoreGeneric_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04000CA1 RID: 3233
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TMP_Text.NativeMethodInfoPtr_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<TMP_Text>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000B0 RID: 176
		private sealed class MethodInfoStoreGeneric_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_Int32_0<T>
		{
			// Token: 0x04000CA2 RID: 3234
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TMP_Text.NativeMethodInfoPtr_ResizeInternalArray_Private_Void_byref_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<TMP_Text>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

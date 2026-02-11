using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x02000040 RID: 64
	public class TMP_InputField : Selectable
	{
		// Token: 0x06000605 RID: 1541 RVA: 0x0001D94C File Offset: 0x0001BB4C
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_InputField()
		{
			Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_InputField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr);
			TMP_InputField.NativeFieldInfoPtr_m_SoftKeyboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_SoftKeyboard");
			TMP_InputField.NativeFieldInfoPtr_kSeparators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "kSeparators");
			TMP_InputField.NativeFieldInfoPtr_m_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_RectTransform");
			TMP_InputField.NativeFieldInfoPtr_m_TextViewport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_TextViewport");
			TMP_InputField.NativeFieldInfoPtr_m_TextComponentRectMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_TextComponentRectMask");
			TMP_InputField.NativeFieldInfoPtr_m_TextViewportRectMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_TextViewportRectMask");
			TMP_InputField.NativeFieldInfoPtr_m_CachedViewportRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_CachedViewportRect");
			TMP_InputField.NativeFieldInfoPtr_m_TextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_TextComponent");
			TMP_InputField.NativeFieldInfoPtr_m_TextComponentRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_TextComponentRectTransform");
			TMP_InputField.NativeFieldInfoPtr_m_Placeholder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_Placeholder");
			TMP_InputField.NativeFieldInfoPtr_m_VerticalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_VerticalScrollbar");
			TMP_InputField.NativeFieldInfoPtr_m_VerticalScrollbarEventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_VerticalScrollbarEventHandler");
			TMP_InputField.NativeFieldInfoPtr_m_IsDrivenByLayoutComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_IsDrivenByLayoutComponents");
			TMP_InputField.NativeFieldInfoPtr_m_LayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_LayoutGroup");
			TMP_InputField.NativeFieldInfoPtr_m_IScrollHandlerParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_IScrollHandlerParent");
			TMP_InputField.NativeFieldInfoPtr_m_ScrollPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_ScrollPosition");
			TMP_InputField.NativeFieldInfoPtr_m_ScrollSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_ScrollSensitivity");
			TMP_InputField.NativeFieldInfoPtr_m_ContentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_ContentType");
			TMP_InputField.NativeFieldInfoPtr_m_InputType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_InputType");
			TMP_InputField.NativeFieldInfoPtr_m_AsteriskChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_AsteriskChar");
			TMP_InputField.NativeFieldInfoPtr_m_KeyboardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_KeyboardType");
			TMP_InputField.NativeFieldInfoPtr_m_LineType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_LineType");
			TMP_InputField.NativeFieldInfoPtr_m_HideMobileInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_HideMobileInput");
			TMP_InputField.NativeFieldInfoPtr_m_HideSoftKeyboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_HideSoftKeyboard");
			TMP_InputField.NativeFieldInfoPtr_m_CharacterValidation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_CharacterValidation");
			TMP_InputField.NativeFieldInfoPtr_m_RegexValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_RegexValue");
			TMP_InputField.NativeFieldInfoPtr_m_GlobalPointSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_GlobalPointSize");
			TMP_InputField.NativeFieldInfoPtr_m_CharacterLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_CharacterLimit");
			TMP_InputField.NativeFieldInfoPtr_m_OnEndEdit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_OnEndEdit");
			TMP_InputField.NativeFieldInfoPtr_m_OnSubmit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_OnSubmit");
			TMP_InputField.NativeFieldInfoPtr_m_OnSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_OnSelect");
			TMP_InputField.NativeFieldInfoPtr_m_OnDeselect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_OnDeselect");
			TMP_InputField.NativeFieldInfoPtr_m_OnTextSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_OnTextSelection");
			TMP_InputField.NativeFieldInfoPtr_m_OnEndTextSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_OnEndTextSelection");
			TMP_InputField.NativeFieldInfoPtr_m_OnValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_OnValueChanged");
			TMP_InputField.NativeFieldInfoPtr_m_OnTouchScreenKeyboardStatusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_OnTouchScreenKeyboardStatusChanged");
			TMP_InputField.NativeFieldInfoPtr_m_OnValidateInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_OnValidateInput");
			TMP_InputField.NativeFieldInfoPtr_m_CaretColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_CaretColor");
			TMP_InputField.NativeFieldInfoPtr_m_CustomCaretColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_CustomCaretColor");
			TMP_InputField.NativeFieldInfoPtr_m_SelectionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_SelectionColor");
			TMP_InputField.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_Text");
			TMP_InputField.NativeFieldInfoPtr_m_CaretBlinkRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_CaretBlinkRate");
			TMP_InputField.NativeFieldInfoPtr_m_CaretWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_CaretWidth");
			TMP_InputField.NativeFieldInfoPtr_m_ReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_ReadOnly");
			TMP_InputField.NativeFieldInfoPtr_m_RichText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_RichText");
			TMP_InputField.NativeFieldInfoPtr_m_StringPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_StringPosition");
			TMP_InputField.NativeFieldInfoPtr_m_StringSelectPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_StringSelectPosition");
			TMP_InputField.NativeFieldInfoPtr_m_CaretPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_CaretPosition");
			TMP_InputField.NativeFieldInfoPtr_m_CaretSelectPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_CaretSelectPosition");
			TMP_InputField.NativeFieldInfoPtr_caretRectTrans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "caretRectTrans");
			TMP_InputField.NativeFieldInfoPtr_m_CursorVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_CursorVerts");
			TMP_InputField.NativeFieldInfoPtr_m_CachedInputRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_CachedInputRenderer");
			TMP_InputField.NativeFieldInfoPtr_m_LastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_LastPosition");
			TMP_InputField.NativeFieldInfoPtr_m_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_Mesh");
			TMP_InputField.NativeFieldInfoPtr_m_AllowInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_AllowInput");
			TMP_InputField.NativeFieldInfoPtr_m_ShouldActivateNextUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_ShouldActivateNextUpdate");
			TMP_InputField.NativeFieldInfoPtr_m_UpdateDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_UpdateDrag");
			TMP_InputField.NativeFieldInfoPtr_m_DragPositionOutOfBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_DragPositionOutOfBounds");
			TMP_InputField.NativeFieldInfoPtr_kHScrollSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "kHScrollSpeed");
			TMP_InputField.NativeFieldInfoPtr_kVScrollSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "kVScrollSpeed");
			TMP_InputField.NativeFieldInfoPtr_m_CaretVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_CaretVisible");
			TMP_InputField.NativeFieldInfoPtr_m_BlinkCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_BlinkCoroutine");
			TMP_InputField.NativeFieldInfoPtr_m_BlinkStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_BlinkStartTime");
			TMP_InputField.NativeFieldInfoPtr_m_DragCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_DragCoroutine");
			TMP_InputField.NativeFieldInfoPtr_m_OriginalText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_OriginalText");
			TMP_InputField.NativeFieldInfoPtr_m_WasCanceled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_WasCanceled");
			TMP_InputField.NativeFieldInfoPtr_m_HasDoneFocusTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_HasDoneFocusTransition");
			TMP_InputField.NativeFieldInfoPtr_m_WaitForSecondsRealtime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_WaitForSecondsRealtime");
			TMP_InputField.NativeFieldInfoPtr_m_PreventCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_PreventCallback");
			TMP_InputField.NativeFieldInfoPtr_m_TouchKeyboardAllowsInPlaceEditing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_TouchKeyboardAllowsInPlaceEditing");
			TMP_InputField.NativeFieldInfoPtr_m_IsTextComponentUpdateRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_IsTextComponentUpdateRequired");
			TMP_InputField.NativeFieldInfoPtr_m_isLastKeyBackspace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_isLastKeyBackspace");
			TMP_InputField.NativeFieldInfoPtr_m_PointerDownClickStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_PointerDownClickStartTime");
			TMP_InputField.NativeFieldInfoPtr_m_KeyDownStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_KeyDownStartTime");
			TMP_InputField.NativeFieldInfoPtr_m_DoubleClickDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_DoubleClickDelay");
			TMP_InputField.NativeFieldInfoPtr_kEmailSpecialCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "kEmailSpecialCharacters");
			TMP_InputField.NativeFieldInfoPtr_m_IsCompositionActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_IsCompositionActive");
			TMP_InputField.NativeFieldInfoPtr_m_ShouldUpdateIMEWindowPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_ShouldUpdateIMEWindowPosition");
			TMP_InputField.NativeFieldInfoPtr_m_PreviousIMEInsertionLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_PreviousIMEInsertionLine");
			TMP_InputField.NativeFieldInfoPtr_m_GlobalFontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_GlobalFontAsset");
			TMP_InputField.NativeFieldInfoPtr_m_OnFocusSelectAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_OnFocusSelectAll");
			TMP_InputField.NativeFieldInfoPtr_m_isSelectAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_isSelectAll");
			TMP_InputField.NativeFieldInfoPtr_m_ResetOnDeActivation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_ResetOnDeActivation");
			TMP_InputField.NativeFieldInfoPtr_m_SelectionStillActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_SelectionStillActive");
			TMP_InputField.NativeFieldInfoPtr_m_ReleaseSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_ReleaseSelection");
			TMP_InputField.NativeFieldInfoPtr_m_PreviouslySelectedObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_PreviouslySelectedObject");
			TMP_InputField.NativeFieldInfoPtr_m_RestoreOriginalTextOnEscape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_RestoreOriginalTextOnEscape");
			TMP_InputField.NativeFieldInfoPtr_m_isRichTextEditingAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_isRichTextEditingAllowed");
			TMP_InputField.NativeFieldInfoPtr_m_LineLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_LineLimit");
			TMP_InputField.NativeFieldInfoPtr_m_InputValidator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_InputValidator");
			TMP_InputField.NativeFieldInfoPtr_m_isSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_isSelected");
			TMP_InputField.NativeFieldInfoPtr_m_IsStringPositionDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_IsStringPositionDirty");
			TMP_InputField.NativeFieldInfoPtr_m_IsCaretPositionDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_IsCaretPositionDirty");
			TMP_InputField.NativeFieldInfoPtr_m_forceRectTransformAdjustment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_forceRectTransformAdjustment");
			TMP_InputField.NativeFieldInfoPtr_m_ProcessingEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "m_ProcessingEvent");
			TMP_InputField.NativeMethodInfoPtr_get_inputSystem_Private_get_BaseInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663948);
			TMP_InputField.NativeMethodInfoPtr_get_compositionString_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663949);
			TMP_InputField.NativeMethodInfoPtr_get_compositionLength_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663950);
			TMP_InputField.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663951);
			TMP_InputField.NativeMethodInfoPtr_get_mesh_Protected_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663952);
			TMP_InputField.NativeMethodInfoPtr_get_shouldHideMobileInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663953);
			TMP_InputField.NativeMethodInfoPtr_set_shouldHideMobileInput_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663954);
			TMP_InputField.NativeMethodInfoPtr_get_shouldHideSoftKeyboard_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663955);
			TMP_InputField.NativeMethodInfoPtr_set_shouldHideSoftKeyboard_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663956);
			TMP_InputField.NativeMethodInfoPtr_isKeyboardUsingEvents_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663957);
			TMP_InputField.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663958);
			TMP_InputField.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663959);
			TMP_InputField.NativeMethodInfoPtr_SetTextWithoutNotify_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663960);
			TMP_InputField.NativeMethodInfoPtr_SetText_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663961);
			TMP_InputField.NativeMethodInfoPtr_get_isFocused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663962);
			TMP_InputField.NativeMethodInfoPtr_get_caretBlinkRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663963);
			TMP_InputField.NativeMethodInfoPtr_set_caretBlinkRate_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663964);
			TMP_InputField.NativeMethodInfoPtr_get_caretWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663965);
			TMP_InputField.NativeMethodInfoPtr_set_caretWidth_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663966);
			TMP_InputField.NativeMethodInfoPtr_get_textViewport_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663967);
			TMP_InputField.NativeMethodInfoPtr_set_textViewport_Public_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663968);
			TMP_InputField.NativeMethodInfoPtr_get_textComponent_Public_get_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663969);
			TMP_InputField.NativeMethodInfoPtr_set_textComponent_Public_set_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663970);
			TMP_InputField.NativeMethodInfoPtr_get_placeholder_Public_get_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663971);
			TMP_InputField.NativeMethodInfoPtr_set_placeholder_Public_set_Void_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663972);
			TMP_InputField.NativeMethodInfoPtr_get_verticalScrollbar_Public_get_Scrollbar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663973);
			TMP_InputField.NativeMethodInfoPtr_set_verticalScrollbar_Public_set_Void_Scrollbar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663974);
			TMP_InputField.NativeMethodInfoPtr_get_scrollSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663975);
			TMP_InputField.NativeMethodInfoPtr_set_scrollSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663976);
			TMP_InputField.NativeMethodInfoPtr_get_caretColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663977);
			TMP_InputField.NativeMethodInfoPtr_set_caretColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663978);
			TMP_InputField.NativeMethodInfoPtr_get_customCaretColor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663979);
			TMP_InputField.NativeMethodInfoPtr_set_customCaretColor_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663980);
			TMP_InputField.NativeMethodInfoPtr_get_selectionColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663981);
			TMP_InputField.NativeMethodInfoPtr_set_selectionColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663982);
			TMP_InputField.NativeMethodInfoPtr_get_onEndEdit_Public_get_SubmitEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663983);
			TMP_InputField.NativeMethodInfoPtr_set_onEndEdit_Public_set_Void_SubmitEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663984);
			TMP_InputField.NativeMethodInfoPtr_get_onSubmit_Public_get_SubmitEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663985);
			TMP_InputField.NativeMethodInfoPtr_set_onSubmit_Public_set_Void_SubmitEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663986);
			TMP_InputField.NativeMethodInfoPtr_get_onSelect_Public_get_SelectionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663987);
			TMP_InputField.NativeMethodInfoPtr_set_onSelect_Public_set_Void_SelectionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663988);
			TMP_InputField.NativeMethodInfoPtr_get_onDeselect_Public_get_SelectionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663989);
			TMP_InputField.NativeMethodInfoPtr_set_onDeselect_Public_set_Void_SelectionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663990);
			TMP_InputField.NativeMethodInfoPtr_get_onTextSelection_Public_get_TextSelectionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663991);
			TMP_InputField.NativeMethodInfoPtr_set_onTextSelection_Public_set_Void_TextSelectionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663992);
			TMP_InputField.NativeMethodInfoPtr_get_onEndTextSelection_Public_get_TextSelectionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663993);
			TMP_InputField.NativeMethodInfoPtr_set_onEndTextSelection_Public_set_Void_TextSelectionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663994);
			TMP_InputField.NativeMethodInfoPtr_get_onValueChanged_Public_get_OnChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663995);
			TMP_InputField.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_OnChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663996);
			TMP_InputField.NativeMethodInfoPtr_get_onTouchScreenKeyboardStatusChanged_Public_get_TouchScreenKeyboardEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663997);
			TMP_InputField.NativeMethodInfoPtr_set_onTouchScreenKeyboardStatusChanged_Public_set_Void_TouchScreenKeyboardEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663998);
			TMP_InputField.NativeMethodInfoPtr_get_onValidateInput_Public_get_OnValidateInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100663999);
			TMP_InputField.NativeMethodInfoPtr_set_onValidateInput_Public_set_Void_OnValidateInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664000);
			TMP_InputField.NativeMethodInfoPtr_get_characterLimit_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664001);
			TMP_InputField.NativeMethodInfoPtr_set_characterLimit_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664002);
			TMP_InputField.NativeMethodInfoPtr_get_pointSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664003);
			TMP_InputField.NativeMethodInfoPtr_set_pointSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664004);
			TMP_InputField.NativeMethodInfoPtr_get_fontAsset_Public_get_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664005);
			TMP_InputField.NativeMethodInfoPtr_set_fontAsset_Public_set_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664006);
			TMP_InputField.NativeMethodInfoPtr_get_onFocusSelectAll_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664007);
			TMP_InputField.NativeMethodInfoPtr_set_onFocusSelectAll_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664008);
			TMP_InputField.NativeMethodInfoPtr_get_resetOnDeActivation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664009);
			TMP_InputField.NativeMethodInfoPtr_set_resetOnDeActivation_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664010);
			TMP_InputField.NativeMethodInfoPtr_get_restoreOriginalTextOnEscape_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664011);
			TMP_InputField.NativeMethodInfoPtr_set_restoreOriginalTextOnEscape_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664012);
			TMP_InputField.NativeMethodInfoPtr_get_isRichTextEditingAllowed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664013);
			TMP_InputField.NativeMethodInfoPtr_set_isRichTextEditingAllowed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664014);
			TMP_InputField.NativeMethodInfoPtr_get_contentType_Public_get_ContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664015);
			TMP_InputField.NativeMethodInfoPtr_set_contentType_Public_set_Void_ContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664016);
			TMP_InputField.NativeMethodInfoPtr_get_lineType_Public_get_LineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664017);
			TMP_InputField.NativeMethodInfoPtr_set_lineType_Public_set_Void_LineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664018);
			TMP_InputField.NativeMethodInfoPtr_get_lineLimit_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664019);
			TMP_InputField.NativeMethodInfoPtr_set_lineLimit_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664020);
			TMP_InputField.NativeMethodInfoPtr_get_inputType_Public_get_InputType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664021);
			TMP_InputField.NativeMethodInfoPtr_set_inputType_Public_set_Void_InputType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664022);
			TMP_InputField.NativeMethodInfoPtr_get_keyboardType_Public_get_TouchScreenKeyboardType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664023);
			TMP_InputField.NativeMethodInfoPtr_set_keyboardType_Public_set_Void_TouchScreenKeyboardType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664024);
			TMP_InputField.NativeMethodInfoPtr_get_characterValidation_Public_get_CharacterValidation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664025);
			TMP_InputField.NativeMethodInfoPtr_set_characterValidation_Public_set_Void_CharacterValidation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664026);
			TMP_InputField.NativeMethodInfoPtr_get_inputValidator_Public_get_TMP_InputValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664027);
			TMP_InputField.NativeMethodInfoPtr_set_inputValidator_Public_set_Void_TMP_InputValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664028);
			TMP_InputField.NativeMethodInfoPtr_get_readOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664029);
			TMP_InputField.NativeMethodInfoPtr_set_readOnly_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664030);
			TMP_InputField.NativeMethodInfoPtr_get_richText_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664031);
			TMP_InputField.NativeMethodInfoPtr_set_richText_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664032);
			TMP_InputField.NativeMethodInfoPtr_get_multiLine_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664033);
			TMP_InputField.NativeMethodInfoPtr_get_asteriskChar_Public_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664034);
			TMP_InputField.NativeMethodInfoPtr_set_asteriskChar_Public_set_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664035);
			TMP_InputField.NativeMethodInfoPtr_get_wasCanceled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664036);
			TMP_InputField.NativeMethodInfoPtr_ClampStringPos_Protected_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664037);
			TMP_InputField.NativeMethodInfoPtr_ClampCaretPos_Protected_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664038);
			TMP_InputField.NativeMethodInfoPtr_get_caretPositionInternal_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664039);
			TMP_InputField.NativeMethodInfoPtr_set_caretPositionInternal_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664040);
			TMP_InputField.NativeMethodInfoPtr_get_stringPositionInternal_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664041);
			TMP_InputField.NativeMethodInfoPtr_set_stringPositionInternal_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664042);
			TMP_InputField.NativeMethodInfoPtr_get_caretSelectPositionInternal_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664043);
			TMP_InputField.NativeMethodInfoPtr_set_caretSelectPositionInternal_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664044);
			TMP_InputField.NativeMethodInfoPtr_get_stringSelectPositionInternal_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664045);
			TMP_InputField.NativeMethodInfoPtr_set_stringSelectPositionInternal_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664046);
			TMP_InputField.NativeMethodInfoPtr_get_hasSelection_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664047);
			TMP_InputField.NativeMethodInfoPtr_get_caretPosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664048);
			TMP_InputField.NativeMethodInfoPtr_set_caretPosition_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664049);
			TMP_InputField.NativeMethodInfoPtr_get_selectionAnchorPosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664050);
			TMP_InputField.NativeMethodInfoPtr_set_selectionAnchorPosition_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664051);
			TMP_InputField.NativeMethodInfoPtr_get_selectionFocusPosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664052);
			TMP_InputField.NativeMethodInfoPtr_set_selectionFocusPosition_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664053);
			TMP_InputField.NativeMethodInfoPtr_get_stringPosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664054);
			TMP_InputField.NativeMethodInfoPtr_set_stringPosition_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664055);
			TMP_InputField.NativeMethodInfoPtr_get_selectionStringAnchorPosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664056);
			TMP_InputField.NativeMethodInfoPtr_set_selectionStringAnchorPosition_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664057);
			TMP_InputField.NativeMethodInfoPtr_get_selectionStringFocusPosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664058);
			TMP_InputField.NativeMethodInfoPtr_set_selectionStringFocusPosition_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664059);
			TMP_InputField.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664060);
			TMP_InputField.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664061);
			TMP_InputField.NativeMethodInfoPtr_ON_TEXT_CHANGED_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664062);
			TMP_InputField.NativeMethodInfoPtr_CaretBlink_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664063);
			TMP_InputField.NativeMethodInfoPtr_SetCaretVisible_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664064);
			TMP_InputField.NativeMethodInfoPtr_SetCaretActive_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664065);
			TMP_InputField.NativeMethodInfoPtr_OnFocus_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664066);
			TMP_InputField.NativeMethodInfoPtr_SelectAll_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664067);
			TMP_InputField.NativeMethodInfoPtr_MoveTextEnd_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664068);
			TMP_InputField.NativeMethodInfoPtr_MoveTextStart_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664069);
			TMP_InputField.NativeMethodInfoPtr_MoveToEndOfLine_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664070);
			TMP_InputField.NativeMethodInfoPtr_MoveToStartOfLine_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664071);
			TMP_InputField.NativeMethodInfoPtr_get_clipboard_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664072);
			TMP_InputField.NativeMethodInfoPtr_set_clipboard_Private_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664073);
			TMP_InputField.NativeMethodInfoPtr_InPlaceEditing_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664074);
			TMP_InputField.NativeMethodInfoPtr_UpdateStringPositionFromKeyboard_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664075);
			TMP_InputField.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664076);
			TMP_InputField.NativeMethodInfoPtr_MayDrag_Private_Boolean_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664077);
			TMP_InputField.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664078);
			TMP_InputField.NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664079);
			TMP_InputField.NativeMethodInfoPtr_MouseDragOutsideRect_Private_IEnumerator_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664080);
			TMP_InputField.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664081);
			TMP_InputField.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664082);
			TMP_InputField.NativeMethodInfoPtr_KeyPressed_Protected_EditState_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664083);
			TMP_InputField.NativeMethodInfoPtr_IsValidChar_Protected_Virtual_New_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664084);
			TMP_InputField.NativeMethodInfoPtr_ProcessEvent_Public_Void_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664085);
			TMP_InputField.NativeMethodInfoPtr_OnUpdateSelected_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664086);
			TMP_InputField.NativeMethodInfoPtr_OnScroll_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664087);
			TMP_InputField.NativeMethodInfoPtr_GetScrollPositionRelativeToViewport_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664088);
			TMP_InputField.NativeMethodInfoPtr_GetSelectedString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664089);
			TMP_InputField.NativeMethodInfoPtr_FindNextWordBegin_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664090);
			TMP_InputField.NativeMethodInfoPtr_MoveRight_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664091);
			TMP_InputField.NativeMethodInfoPtr_FindPrevWordBegin_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664092);
			TMP_InputField.NativeMethodInfoPtr_MoveLeft_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664093);
			TMP_InputField.NativeMethodInfoPtr_LineUpCharacterPosition_Private_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664094);
			TMP_InputField.NativeMethodInfoPtr_LineDownCharacterPosition_Private_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664095);
			TMP_InputField.NativeMethodInfoPtr_PageUpCharacterPosition_Private_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664096);
			TMP_InputField.NativeMethodInfoPtr_PageDownCharacterPosition_Private_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664097);
			TMP_InputField.NativeMethodInfoPtr_MoveDown_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664098);
			TMP_InputField.NativeMethodInfoPtr_MoveDown_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664099);
			TMP_InputField.NativeMethodInfoPtr_MoveUp_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664100);
			TMP_InputField.NativeMethodInfoPtr_MoveUp_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664101);
			TMP_InputField.NativeMethodInfoPtr_MovePageUp_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664102);
			TMP_InputField.NativeMethodInfoPtr_MovePageUp_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664103);
			TMP_InputField.NativeMethodInfoPtr_MovePageDown_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664104);
			TMP_InputField.NativeMethodInfoPtr_MovePageDown_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664105);
			TMP_InputField.NativeMethodInfoPtr_Delete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664106);
			TMP_InputField.NativeMethodInfoPtr_DeleteKey_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664107);
			TMP_InputField.NativeMethodInfoPtr_Backspace_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664108);
			TMP_InputField.NativeMethodInfoPtr_Append_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664109);
			TMP_InputField.NativeMethodInfoPtr_Append_Protected_Virtual_New_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664110);
			TMP_InputField.NativeMethodInfoPtr_Insert_Private_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664111);
			TMP_InputField.NativeMethodInfoPtr_UpdateTouchKeyboardFromEditChanges_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664112);
			TMP_InputField.NativeMethodInfoPtr_SendOnValueChangedAndUpdateLabel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664113);
			TMP_InputField.NativeMethodInfoPtr_SendOnValueChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664114);
			TMP_InputField.NativeMethodInfoPtr_SendOnEndEdit_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664115);
			TMP_InputField.NativeMethodInfoPtr_SendOnSubmit_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664116);
			TMP_InputField.NativeMethodInfoPtr_SendOnFocus_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664117);
			TMP_InputField.NativeMethodInfoPtr_SendOnFocusLost_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664118);
			TMP_InputField.NativeMethodInfoPtr_SendOnTextSelection_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664119);
			TMP_InputField.NativeMethodInfoPtr_SendOnEndTextSelection_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664120);
			TMP_InputField.NativeMethodInfoPtr_SendTouchScreenKeyboardStatusChanged_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664121);
			TMP_InputField.NativeMethodInfoPtr_UpdateLabel_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664122);
			TMP_InputField.NativeMethodInfoPtr_UpdateScrollbar_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664123);
			TMP_InputField.NativeMethodInfoPtr_OnScrollbarValueChange_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664124);
			TMP_InputField.NativeMethodInfoPtr_UpdateMaskRegions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664125);
			TMP_InputField.NativeMethodInfoPtr_AdjustTextPositionRelativeToViewport_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664126);
			TMP_InputField.NativeMethodInfoPtr_GetCaretPositionFromStringIndex_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664127);
			TMP_InputField.NativeMethodInfoPtr_GetMinCaretPositionFromStringIndex_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664128);
			TMP_InputField.NativeMethodInfoPtr_GetMaxCaretPositionFromStringIndex_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664129);
			TMP_InputField.NativeMethodInfoPtr_GetStringIndexFromCaretPosition_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664130);
			TMP_InputField.NativeMethodInfoPtr_ForceLabelUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664131);
			TMP_InputField.NativeMethodInfoPtr_MarkGeometryAsDirty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664132);
			TMP_InputField.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664133);
			TMP_InputField.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664134);
			TMP_InputField.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664135);
			TMP_InputField.NativeMethodInfoPtr_UpdateGeometry_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664136);
			TMP_InputField.NativeMethodInfoPtr_AssignPositioningIfNeeded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664137);
			TMP_InputField.NativeMethodInfoPtr_OnFillVBO_Private_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664138);
			TMP_InputField.NativeMethodInfoPtr_GenerateCaret_Private_Void_VertexHelper_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664139);
			TMP_InputField.NativeMethodInfoPtr_CreateCursorVerts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664140);
			TMP_InputField.NativeMethodInfoPtr_GenerateHightlight_Private_Void_VertexHelper_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664141);
			TMP_InputField.NativeMethodInfoPtr_AdjustRectTransformRelativeToViewport_Private_Void_Vector2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664142);
			TMP_InputField.NativeMethodInfoPtr_Validate_Protected_Char_String_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664143);
			TMP_InputField.NativeMethodInfoPtr_ActivateInputField_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664144);
			TMP_InputField.NativeMethodInfoPtr_ActivateInputFieldInternal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664145);
			TMP_InputField.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664146);
			TMP_InputField.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664147);
			TMP_InputField.NativeMethodInfoPtr_OnControlClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664148);
			TMP_InputField.NativeMethodInfoPtr_ReleaseSelection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664149);
			TMP_InputField.NativeMethodInfoPtr_DeactivateInputField_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664150);
			TMP_InputField.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664151);
			TMP_InputField.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664152);
			TMP_InputField.NativeMethodInfoPtr_EnforceContentType_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664153);
			TMP_InputField.NativeMethodInfoPtr_SetTextComponentWrapMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664154);
			TMP_InputField.NativeMethodInfoPtr_SetTextComponentRichTextMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664155);
			TMP_InputField.NativeMethodInfoPtr_SetToCustomIfContentTypeIsNot_Private_Void_Il2CppStructArray_1_ContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664156);
			TMP_InputField.NativeMethodInfoPtr_SetToCustom_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664157);
			TMP_InputField.NativeMethodInfoPtr_SetToCustom_Private_Void_CharacterValidation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664158);
			TMP_InputField.NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664159);
			TMP_InputField.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664160);
			TMP_InputField.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664161);
			TMP_InputField.NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664162);
			TMP_InputField.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664163);
			TMP_InputField.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664164);
			TMP_InputField.NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664165);
			TMP_InputField.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664166);
			TMP_InputField.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664167);
			TMP_InputField.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664168);
			TMP_InputField.NativeMethodInfoPtr_SetGlobalPointSize_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664169);
			TMP_InputField.NativeMethodInfoPtr_SetGlobalFontAsset_Public_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664170);
			TMP_InputField.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, 100664172);
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x0001F268 File Offset: 0x0001D468
		public unsafe BaseInput inputSystem
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1041657, RefRangeEnd = 1041667, XrefRangeStart = 1041639, XrefRangeEnd = 1041657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_inputSystem_Private_get_BaseInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInput>(intPtr3) : null;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x0001F2A8 File Offset: 0x0001D4A8
		public unsafe string compositionString
		{
			[CallerCount(115)]
			[CachedScanResults(RefRangeStart = 1041675, RefRangeEnd = 1041790, XrefRangeStart = 1041667, XrefRangeEnd = 1041675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_compositionString_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x0001F2E0 File Offset: 0x0001D4E0
		public unsafe int compositionLength
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041790, XrefRangeEnd = 1041791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_compositionLength_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0001F31C File Offset: 0x0001D51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041791, XrefRangeEnd = 1041847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_InputField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x0001F358 File Offset: 0x0001D558
		public unsafe Mesh mesh
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1041856, RefRangeEnd = 1041860, XrefRangeStart = 1041847, XrefRangeEnd = 1041856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_mesh_Protected_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x0001F398 File Offset: 0x0001D598
		// (set) Token: 0x0600060C RID: 1548 RVA: 0x0001F3D4 File Offset: 0x0001D5D4
		public unsafe bool shouldHideMobileInput
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1041864, RefRangeEnd = 1041866, XrefRangeStart = 1041860, XrefRangeEnd = 1041864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_shouldHideMobileInput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041866, XrefRangeEnd = 1041871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_shouldHideMobileInput_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x0001F414 File Offset: 0x0001D614
		// (set) Token: 0x0600060E RID: 1550 RVA: 0x0001F450 File Offset: 0x0001D650
		public unsafe bool shouldHideSoftKeyboard
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1041875, RefRangeEnd = 1041879, XrefRangeStart = 1041871, XrefRangeEnd = 1041875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_shouldHideSoftKeyboard_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041879, XrefRangeEnd = 1041890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_shouldHideSoftKeyboard_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0001F490 File Offset: 0x0001D690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041890, XrefRangeEnd = 1041894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool isKeyboardUsingEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_isKeyboardUsingEvents_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x0001F4CC File Offset: 0x0001D6CC
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x0001F504 File Offset: 0x0001D704
		public unsafe string text
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1041895, RefRangeEnd = 1041907, XrefRangeStart = 1041894, XrefRangeEnd = 1041895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0001F548 File Offset: 0x0001D748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041907, XrefRangeEnd = 1041908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextWithoutNotify(string input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SetTextWithoutNotify_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0001F58C File Offset: 0x0001D78C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1041923, RefRangeEnd = 1041927, XrefRangeStart = 1041908, XrefRangeEnd = 1041923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetText(string value, bool sendCallback = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendCallback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SetText_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x0001F5DC File Offset: 0x0001D7DC
		public unsafe bool isFocused
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_isFocused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x0001F618 File Offset: 0x0001D818
		// (set) Token: 0x06000616 RID: 1558 RVA: 0x0001F654 File Offset: 0x0001D854
		public unsafe float caretBlinkRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_caretBlinkRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041927, XrefRangeEnd = 1041931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_caretBlinkRate_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x0001F694 File Offset: 0x0001D894
		// (set) Token: 0x06000618 RID: 1560 RVA: 0x0001F6D0 File Offset: 0x0001D8D0
		public unsafe int caretWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_caretWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041931, XrefRangeEnd = 1041938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_caretWidth_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x0001F710 File Offset: 0x0001D910
		// (set) Token: 0x0600061A RID: 1562 RVA: 0x0001F750 File Offset: 0x0001D950
		public unsafe RectTransform textViewport
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_textViewport_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041938, XrefRangeEnd = 1041941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_textViewport_Public_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x0001F794 File Offset: 0x0001D994
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x0001F7D4 File Offset: 0x0001D9D4
		public unsafe TMP_Text textComponent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_textComponent_Public_get_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041941, XrefRangeEnd = 1041945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_textComponent_Public_set_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x0001F818 File Offset: 0x0001DA18
		// (set) Token: 0x0600061E RID: 1566 RVA: 0x0001F858 File Offset: 0x0001DA58
		public unsafe Graphic placeholder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_placeholder_Public_get_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041945, XrefRangeEnd = 1041948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_placeholder_Public_set_Void_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x0001F89C File Offset: 0x0001DA9C
		// (set) Token: 0x06000620 RID: 1568 RVA: 0x0001F8DC File Offset: 0x0001DADC
		public unsafe Scrollbar verticalScrollbar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_verticalScrollbar_Public_get_Scrollbar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041948, XrefRangeEnd = 1041974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_verticalScrollbar_Public_set_Void_Scrollbar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x0001F920 File Offset: 0x0001DB20
		// (set) Token: 0x06000622 RID: 1570 RVA: 0x0001F95C File Offset: 0x0001DB5C
		public unsafe float scrollSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_scrollSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041974, XrefRangeEnd = 1041981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_scrollSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x0001F99C File Offset: 0x0001DB9C
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x0001F9D8 File Offset: 0x0001DBD8
		public unsafe Color caretColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_caretColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041981, XrefRangeEnd = 1041986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_caretColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x0001FA18 File Offset: 0x0001DC18
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x0001FA54 File Offset: 0x0001DC54
		public unsafe bool customCaretColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_customCaretColor_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041986, XrefRangeEnd = 1041990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_customCaretColor_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x0001FA94 File Offset: 0x0001DC94
		// (set) Token: 0x06000628 RID: 1576 RVA: 0x0001FAD0 File Offset: 0x0001DCD0
		public unsafe Color selectionColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_selectionColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041990, XrefRangeEnd = 1041995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_selectionColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x0001FB10 File Offset: 0x0001DD10
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x0001FB50 File Offset: 0x0001DD50
		public unsafe TMP_InputField.SubmitEvent onEndEdit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_onEndEdit_Public_get_SubmitEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_InputField.SubmitEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041995, XrefRangeEnd = 1041998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_onEndEdit_Public_set_Void_SubmitEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x0001FB94 File Offset: 0x0001DD94
		// (set) Token: 0x0600062C RID: 1580 RVA: 0x0001FBD4 File Offset: 0x0001DDD4
		public unsafe TMP_InputField.SubmitEvent onSubmit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_onSubmit_Public_get_SubmitEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_InputField.SubmitEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041998, XrefRangeEnd = 1042001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_onSubmit_Public_set_Void_SubmitEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x0001FC18 File Offset: 0x0001DE18
		// (set) Token: 0x0600062E RID: 1582 RVA: 0x0001FC58 File Offset: 0x0001DE58
		public unsafe TMP_InputField.SelectionEvent onSelect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_onSelect_Public_get_SelectionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_InputField.SelectionEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042001, XrefRangeEnd = 1042004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_onSelect_Public_set_Void_SelectionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x0001FC9C File Offset: 0x0001DE9C
		// (set) Token: 0x06000630 RID: 1584 RVA: 0x0001FCDC File Offset: 0x0001DEDC
		public unsafe TMP_InputField.SelectionEvent onDeselect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_onDeselect_Public_get_SelectionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_InputField.SelectionEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042004, XrefRangeEnd = 1042007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_onDeselect_Public_set_Void_SelectionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x0001FD20 File Offset: 0x0001DF20
		// (set) Token: 0x06000632 RID: 1586 RVA: 0x0001FD60 File Offset: 0x0001DF60
		public unsafe TMP_InputField.TextSelectionEvent onTextSelection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_onTextSelection_Public_get_TextSelectionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_InputField.TextSelectionEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042007, XrefRangeEnd = 1042010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_onTextSelection_Public_set_Void_TextSelectionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x0001FDA4 File Offset: 0x0001DFA4
		// (set) Token: 0x06000634 RID: 1588 RVA: 0x0001FDE4 File Offset: 0x0001DFE4
		public unsafe TMP_InputField.TextSelectionEvent onEndTextSelection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_onEndTextSelection_Public_get_TextSelectionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_InputField.TextSelectionEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042010, XrefRangeEnd = 1042013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_onEndTextSelection_Public_set_Void_TextSelectionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x0001FE28 File Offset: 0x0001E028
		// (set) Token: 0x06000636 RID: 1590 RVA: 0x0001FE68 File Offset: 0x0001E068
		public unsafe TMP_InputField.OnChangeEvent onValueChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_onValueChanged_Public_get_OnChangeEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_InputField.OnChangeEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042013, XrefRangeEnd = 1042016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_OnChangeEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x0001FEAC File Offset: 0x0001E0AC
		// (set) Token: 0x06000638 RID: 1592 RVA: 0x0001FEEC File Offset: 0x0001E0EC
		public unsafe TMP_InputField.TouchScreenKeyboardEvent onTouchScreenKeyboardStatusChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_onTouchScreenKeyboardStatusChanged_Public_get_TouchScreenKeyboardEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_InputField.TouchScreenKeyboardEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042016, XrefRangeEnd = 1042019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_onTouchScreenKeyboardStatusChanged_Public_set_Void_TouchScreenKeyboardEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x0001FF30 File Offset: 0x0001E130
		// (set) Token: 0x0600063A RID: 1594 RVA: 0x0001FF70 File Offset: 0x0001E170
		public unsafe TMP_InputField.OnValidateInput onValidateInput
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_onValidateInput_Public_get_OnValidateInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_InputField.OnValidateInput>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1042022, RefRangeEnd = 1042024, XrefRangeStart = 1042019, XrefRangeEnd = 1042022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_onValidateInput_Public_set_Void_OnValidateInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x0001FFB4 File Offset: 0x0001E1B4
		// (set) Token: 0x0600063C RID: 1596 RVA: 0x0001FFF0 File Offset: 0x0001E1F0
		public unsafe int characterLimit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_characterLimit_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042024, XrefRangeEnd = 1042033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_characterLimit_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x00020030 File Offset: 0x0001E230
		// (set) Token: 0x0600063E RID: 1598 RVA: 0x0002006C File Offset: 0x0001E26C
		public unsafe float pointSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_pointSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042033, XrefRangeEnd = 1042051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_pointSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x000200AC File Offset: 0x0001E2AC
		// (set) Token: 0x06000640 RID: 1600 RVA: 0x000200EC File Offset: 0x0001E2EC
		public unsafe TMP_FontAsset fontAsset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_fontAsset_Public_get_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042051, XrefRangeEnd = 1042065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_fontAsset_Public_set_Void_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x00020130 File Offset: 0x0001E330
		// (set) Token: 0x06000642 RID: 1602 RVA: 0x0002016C File Offset: 0x0001E36C
		public unsafe bool onFocusSelectAll
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_onFocusSelectAll_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_onFocusSelectAll_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x000201AC File Offset: 0x0001E3AC
		// (set) Token: 0x06000644 RID: 1604 RVA: 0x000201E8 File Offset: 0x0001E3E8
		public unsafe bool resetOnDeActivation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_resetOnDeActivation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_resetOnDeActivation_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x00020228 File Offset: 0x0001E428
		// (set) Token: 0x06000646 RID: 1606 RVA: 0x00020264 File Offset: 0x0001E464
		public unsafe bool restoreOriginalTextOnEscape
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_restoreOriginalTextOnEscape_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_restoreOriginalTextOnEscape_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x000202A4 File Offset: 0x0001E4A4
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x000202E0 File Offset: 0x0001E4E0
		public unsafe bool isRichTextEditingAllowed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_isRichTextEditingAllowed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_isRichTextEditingAllowed_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x00020320 File Offset: 0x0001E520
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x0002035C File Offset: 0x0001E55C
		public unsafe TMP_InputField.ContentType contentType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_contentType_Public_get_ContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1042081, RefRangeEnd = 1042089, XrefRangeStart = 1042065, XrefRangeEnd = 1042081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_contentType_Public_set_Void_ContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x0002039C File Offset: 0x0001E59C
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x000203D8 File Offset: 0x0001E5D8
		public unsafe TMP_InputField.LineType lineType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_lineType_Public_get_LineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042089, XrefRangeEnd = 1042098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_lineType_Public_set_Void_LineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x00020418 File Offset: 0x0001E618
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x00020454 File Offset: 0x0001E654
		public unsafe int lineLimit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_lineLimit_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042098, XrefRangeEnd = 1042101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_lineLimit_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x00020494 File Offset: 0x0001E694
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x000204D0 File Offset: 0x0001E6D0
		public unsafe TMP_InputField.InputType inputType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_inputType_Public_get_InputType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042101, XrefRangeEnd = 1042105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_inputType_Public_set_Void_InputType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x00020510 File Offset: 0x0001E710
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x0002054C File Offset: 0x0001E74C
		public unsafe TouchScreenKeyboardType keyboardType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_keyboardType_Public_get_TouchScreenKeyboardType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042105, XrefRangeEnd = 1042109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_keyboardType_Public_set_Void_TouchScreenKeyboardType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x0002058C File Offset: 0x0001E78C
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x000205C8 File Offset: 0x0001E7C8
		public unsafe TMP_InputField.CharacterValidation characterValidation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_characterValidation_Public_get_CharacterValidation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042109, XrefRangeEnd = 1042113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_characterValidation_Public_set_Void_CharacterValidation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x00020608 File Offset: 0x0001E808
		// (set) Token: 0x06000656 RID: 1622 RVA: 0x00020648 File Offset: 0x0001E848
		public unsafe TMP_InputValidator inputValidator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_inputValidator_Public_get_TMP_InputValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_InputValidator>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042113, XrefRangeEnd = 1042117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_inputValidator_Public_set_Void_TMP_InputValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x0002068C File Offset: 0x0001E88C
		// (set) Token: 0x06000658 RID: 1624 RVA: 0x000206C8 File Offset: 0x0001E8C8
		public unsafe bool readOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_readOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_readOnly_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x00020708 File Offset: 0x0001E908
		// (set) Token: 0x0600065A RID: 1626 RVA: 0x00020744 File Offset: 0x0001E944
		public unsafe bool richText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_richText_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042117, XrefRangeEnd = 1042122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_richText_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x00020784 File Offset: 0x0001E984
		public unsafe bool multiLine
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1042122, RefRangeEnd = 1042124, XrefRangeStart = 1042122, XrefRangeEnd = 1042122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_multiLine_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x000207C0 File Offset: 0x0001E9C0
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x000207FC File Offset: 0x0001E9FC
		public unsafe char asteriskChar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_asteriskChar_Public_get_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042124, XrefRangeEnd = 1042128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_asteriskChar_Public_set_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x0002083C File Offset: 0x0001EA3C
		public unsafe bool wasCanceled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_wasCanceled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00020878 File Offset: 0x0001EA78
		[CallerCount(0)]
		public unsafe void ClampStringPos(ref int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_ClampStringPos_Protected_Void_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x000208B8 File Offset: 0x0001EAB8
		[CallerCount(0)]
		public unsafe void ClampCaretPos(ref int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_ClampCaretPos_Protected_Void_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x000208F8 File Offset: 0x0001EAF8
		// (set) Token: 0x06000662 RID: 1634 RVA: 0x00020934 File Offset: 0x0001EB34
		public unsafe int caretPositionInternal
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1042129, RefRangeEnd = 1042140, XrefRangeStart = 1042128, XrefRangeEnd = 1042129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_caretPositionInternal_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1042140, RefRangeEnd = 1042149, XrefRangeStart = 1042140, XrefRangeEnd = 1042140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_caretPositionInternal_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x00020974 File Offset: 0x0001EB74
		// (set) Token: 0x06000664 RID: 1636 RVA: 0x000209B0 File Offset: 0x0001EBB0
		public unsafe int stringPositionInternal
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1042150, RefRangeEnd = 1042158, XrefRangeStart = 1042149, XrefRangeEnd = 1042150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_stringPositionInternal_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1042158, RefRangeEnd = 1042161, XrefRangeStart = 1042158, XrefRangeEnd = 1042158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_stringPositionInternal_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x000209F0 File Offset: 0x0001EBF0
		// (set) Token: 0x06000666 RID: 1638 RVA: 0x00020A2C File Offset: 0x0001EC2C
		public unsafe int caretSelectPositionInternal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042161, XrefRangeEnd = 1042162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_caretSelectPositionInternal_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1042162, RefRangeEnd = 1042173, XrefRangeStart = 1042162, XrefRangeEnd = 1042162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_caretSelectPositionInternal_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x00020A6C File Offset: 0x0001EC6C
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x00020AA8 File Offset: 0x0001ECA8
		public unsafe int stringSelectPositionInternal
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1042174, RefRangeEnd = 1042179, XrefRangeStart = 1042173, XrefRangeEnd = 1042174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_stringSelectPositionInternal_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1042179, RefRangeEnd = 1042182, XrefRangeStart = 1042179, XrefRangeEnd = 1042179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_stringSelectPositionInternal_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x00020AE8 File Offset: 0x0001ECE8
		public new unsafe bool hasSelection
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1042185, RefRangeEnd = 1042196, XrefRangeStart = 1042182, XrefRangeEnd = 1042185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_hasSelection_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x00020B24 File Offset: 0x0001ED24
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x00020B60 File Offset: 0x0001ED60
		public unsafe int caretPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_caretPosition_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042196, XrefRangeEnd = 1042199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_caretPosition_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x00020BA0 File Offset: 0x0001EDA0
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x00020BDC File Offset: 0x0001EDDC
		public unsafe int selectionAnchorPosition
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1042129, RefRangeEnd = 1042140, XrefRangeStart = 1042129, XrefRangeEnd = 1042140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_selectionAnchorPosition_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042199, XrefRangeEnd = 1042200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_selectionAnchorPosition_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x00020C1C File Offset: 0x0001EE1C
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x00020C58 File Offset: 0x0001EE58
		public unsafe int selectionFocusPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_selectionFocusPosition_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042200, XrefRangeEnd = 1042201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_selectionFocusPosition_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x00020C98 File Offset: 0x0001EE98
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x00020CD4 File Offset: 0x0001EED4
		public unsafe int stringPosition
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1042174, RefRangeEnd = 1042179, XrefRangeStart = 1042174, XrefRangeEnd = 1042179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_stringPosition_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042201, XrefRangeEnd = 1042204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_stringPosition_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x00020D14 File Offset: 0x0001EF14
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x00020D50 File Offset: 0x0001EF50
		public unsafe int selectionStringAnchorPosition
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1042150, RefRangeEnd = 1042158, XrefRangeStart = 1042150, XrefRangeEnd = 1042158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_selectionStringAnchorPosition_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042204, XrefRangeEnd = 1042205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_selectionStringAnchorPosition_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x00020D90 File Offset: 0x0001EF90
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x00020DCC File Offset: 0x0001EFCC
		public unsafe int selectionStringFocusPosition
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1042174, RefRangeEnd = 1042179, XrefRangeStart = 1042174, XrefRangeEnd = 1042179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_selectionStringFocusPosition_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042205, XrefRangeEnd = 1042206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_selectionStringFocusPosition_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00020E0C File Offset: 0x0001F00C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042206, XrefRangeEnd = 1042349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00020E48 File Offset: 0x0001F048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042349, XrefRangeEnd = 1042410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00020E84 File Offset: 0x0001F084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042410, XrefRangeEnd = 1042436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ON_TEXT_CHANGED(global::UnityEngine.Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_ON_TEXT_CHANGED_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00020EC8 File Offset: 0x0001F0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042436, XrefRangeEnd = 1042441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CaretBlink()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_CaretBlink_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00020F08 File Offset: 0x0001F108
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1042443, RefRangeEnd = 1042444, XrefRangeStart = 1042441, XrefRangeEnd = 1042443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCaretVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SetCaretVisible_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00020F3C File Offset: 0x0001F13C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1042444, RefRangeEnd = 1042447, XrefRangeStart = 1042444, XrefRangeEnd = 1042444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCaretActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SetCaretActive_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00020F70 File Offset: 0x0001F170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042447, XrefRangeEnd = 1042448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_OnFocus_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00020FA4 File Offset: 0x0001F1A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1042449, RefRangeEnd = 1042453, XrefRangeStart = 1042448, XrefRangeEnd = 1042449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SelectAll_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00020FD8 File Offset: 0x0001F1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042453, XrefRangeEnd = 1042468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveTextEnd(bool shift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MoveTextEnd_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00021018 File Offset: 0x0001F218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042468, XrefRangeEnd = 1042482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveTextStart(bool shift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MoveTextStart_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00021058 File Offset: 0x0001F258
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1042496, RefRangeEnd = 1042497, XrefRangeStart = 1042482, XrefRangeEnd = 1042496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToEndOfLine(bool shift, bool ctrl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ctrl;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MoveToEndOfLine_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x000210A4 File Offset: 0x0001F2A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1042511, RefRangeEnd = 1042512, XrefRangeStart = 1042497, XrefRangeEnd = 1042511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToStartOfLine(bool shift, bool ctrl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ctrl;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MoveToStartOfLine_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x000210F0 File Offset: 0x0001F2F0
		// (set) Token: 0x06000683 RID: 1667 RVA: 0x0002111C File Offset: 0x0001F31C
		public unsafe static string clipboard
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042512, XrefRangeEnd = 1042516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_get_clipboard_Private_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1042520, RefRangeEnd = 1042522, XrefRangeStart = 1042516, XrefRangeEnd = 1042520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_set_clipboard_Private_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00021154 File Offset: 0x0001F354
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1042534, RefRangeEnd = 1042541, XrefRangeStart = 1042522, XrefRangeEnd = 1042534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InPlaceEditing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_InPlaceEditing_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00021190 File Offset: 0x0001F390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042541, XrefRangeEnd = 1042558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStringPositionFromKeyboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_UpdateStringPositionFromKeyboard_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x000211C4 File Offset: 0x0001F3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042558, XrefRangeEnd = 1042575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00021200 File Offset: 0x0001F400
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1042581, RefRangeEnd = 1042585, XrefRangeStart = 1042575, XrefRangeEnd = 1042581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MayDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MayDrag_Private_Boolean_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00021250 File Offset: 0x0001F450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042585, XrefRangeEnd = 1042586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeginDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x000212A0 File Offset: 0x0001F4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042586, XrefRangeEnd = 1042617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x000212F0 File Offset: 0x0001F4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042617, XrefRangeEnd = 1042623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator MouseDragOutsideRect(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MouseDragOutsideRect_Private_IEnumerator_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00021340 File Offset: 0x0001F540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042623, XrefRangeEnd = 1042624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEndDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00021390 File Offset: 0x0001F590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042624, XrefRangeEnd = 1042635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x000213E0 File Offset: 0x0001F5E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1042675, RefRangeEnd = 1042677, XrefRangeStart = 1042635, XrefRangeEnd = 1042675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_InputField.EditState KeyPressed(Event evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_KeyPressed_Protected_EditState_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00021430 File Offset: 0x0001F630
		[CallerCount(0)]
		public unsafe virtual bool IsValidChar(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_IsValidChar_Protected_Virtual_New_Boolean_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00021484 File Offset: 0x0001F684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042677, XrefRangeEnd = 1042678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessEvent(Event e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_ProcessEvent_Public_Void_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x000214C8 File Offset: 0x0001F6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042678, XrefRangeEnd = 1042696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnUpdateSelected(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_OnUpdateSelected_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00021518 File Offset: 0x0001F718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042696, XrefRangeEnd = 1042706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnScroll(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_OnScroll_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00021568 File Offset: 0x0001F768
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1042709, RefRangeEnd = 1042712, XrefRangeStart = 1042706, XrefRangeEnd = 1042709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetScrollPositionRelativeToViewport()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_GetScrollPositionRelativeToViewport_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x000215A4 File Offset: 0x0001F7A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1042719, RefRangeEnd = 1042720, XrefRangeStart = 1042712, XrefRangeEnd = 1042719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSelectedString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_GetSelectedString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x000215DC File Offset: 0x0001F7DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042720, XrefRangeEnd = 1042728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindNextWordBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_FindNextWordBegin_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00021618 File Offset: 0x0001F818
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1042783, RefRangeEnd = 1042785, XrefRangeStart = 1042728, XrefRangeEnd = 1042783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveRight(bool shift, bool ctrl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ctrl;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MoveRight_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00021664 File Offset: 0x0001F864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042785, XrefRangeEnd = 1042795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindPrevWordBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_FindPrevWordBegin_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x000216A0 File Offset: 0x0001F8A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1042854, RefRangeEnd = 1042856, XrefRangeStart = 1042795, XrefRangeEnd = 1042854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveLeft(bool shift, bool ctrl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ctrl;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MoveLeft_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x000216EC File Offset: 0x0001F8EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1042859, RefRangeEnd = 1042860, XrefRangeStart = 1042856, XrefRangeEnd = 1042859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LineUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref originalPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref goToFirstChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_LineUpCharacterPosition_Private_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00021744 File Offset: 0x0001F944
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1042863, RefRangeEnd = 1042864, XrefRangeStart = 1042860, XrefRangeEnd = 1042863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LineDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref originalPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref goToLastChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_LineDownCharacterPosition_Private_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0002179C File Offset: 0x0001F99C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1042869, RefRangeEnd = 1042870, XrefRangeStart = 1042864, XrefRangeEnd = 1042869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int PageUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref originalPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref goToFirstChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_PageUpCharacterPosition_Private_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x000217F4 File Offset: 0x0001F9F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1042875, RefRangeEnd = 1042876, XrefRangeStart = 1042870, XrefRangeEnd = 1042875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int PageDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref originalPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref goToLastChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_PageDownCharacterPosition_Private_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0002184C File Offset: 0x0001FA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042876, XrefRangeEnd = 1042877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveDown(bool shift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MoveDown_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0002188C File Offset: 0x0001FA8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1042900, RefRangeEnd = 1042903, XrefRangeStart = 1042877, XrefRangeEnd = 1042900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveDown(bool shift, bool goToLastChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref goToLastChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MoveDown_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x000218D8 File Offset: 0x0001FAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042903, XrefRangeEnd = 1042904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveUp(bool shift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MoveUp_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00021918 File Offset: 0x0001FB18
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1042927, RefRangeEnd = 1042930, XrefRangeStart = 1042904, XrefRangeEnd = 1042927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveUp(bool shift, bool goToFirstChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref goToFirstChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MoveUp_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00021964 File Offset: 0x0001FB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042930, XrefRangeEnd = 1042931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MovePageUp(bool shift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MovePageUp_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x000219A4 File Offset: 0x0001FBA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1042964, RefRangeEnd = 1042966, XrefRangeStart = 1042931, XrefRangeEnd = 1042964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MovePageUp(bool shift, bool goToFirstChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref goToFirstChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MovePageUp_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x000219F0 File Offset: 0x0001FBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042966, XrefRangeEnd = 1042967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MovePageDown(bool shift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MovePageDown_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00021A30 File Offset: 0x0001FC30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1043000, RefRangeEnd = 1043002, XrefRangeStart = 1042967, XrefRangeEnd = 1043000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MovePageDown(bool shift, bool goToLastChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref goToLastChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MovePageDown_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00021A7C File Offset: 0x0001FC7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1043004, RefRangeEnd = 1043007, XrefRangeStart = 1043002, XrefRangeEnd = 1043004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Delete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_Delete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00021AB0 File Offset: 0x0001FCB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1043016, RefRangeEnd = 1043017, XrefRangeStart = 1043007, XrefRangeEnd = 1043016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_DeleteKey_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00021AE4 File Offset: 0x0001FCE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043017, XrefRangeEnd = 1043049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Backspace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_Backspace_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00021B18 File Offset: 0x0001FD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043049, XrefRangeEnd = 1043051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Append(string input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_Append_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00021B68 File Offset: 0x0001FD68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043051, XrefRangeEnd = 1043069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Append(char input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_Append_Protected_Virtual_New_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00021BB4 File Offset: 0x0001FDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043069, XrefRangeEnd = 1043084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_Insert_Private_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00021BF4 File Offset: 0x0001FDF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1043086, RefRangeEnd = 1043088, XrefRangeStart = 1043084, XrefRangeEnd = 1043086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTouchKeyboardFromEditChanges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_UpdateTouchKeyboardFromEditChanges_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00021C28 File Offset: 0x0001FE28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1043092, RefRangeEnd = 1043095, XrefRangeStart = 1043088, XrefRangeEnd = 1043092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnValueChangedAndUpdateLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SendOnValueChangedAndUpdateLabel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00021C5C File Offset: 0x0001FE5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1043098, RefRangeEnd = 1043099, XrefRangeStart = 1043095, XrefRangeEnd = 1043098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnValueChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SendOnValueChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00021C90 File Offset: 0x0001FE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043099, XrefRangeEnd = 1043102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnEndEdit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SendOnEndEdit_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00021CC4 File Offset: 0x0001FEC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1043105, RefRangeEnd = 1043106, XrefRangeStart = 1043102, XrefRangeEnd = 1043105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnSubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SendOnSubmit_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00021CF8 File Offset: 0x0001FEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043106, XrefRangeEnd = 1043109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SendOnFocus_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00021D2C File Offset: 0x0001FF2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043109, XrefRangeEnd = 1043112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnFocusLost()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SendOnFocusLost_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00021D60 File Offset: 0x0001FF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043112, XrefRangeEnd = 1043118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnTextSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SendOnTextSelection_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00021D94 File Offset: 0x0001FF94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1043124, RefRangeEnd = 1043126, XrefRangeStart = 1043118, XrefRangeEnd = 1043124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnEndTextSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SendOnEndTextSelection_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00021DC8 File Offset: 0x0001FFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043126, XrefRangeEnd = 1043130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendTouchScreenKeyboardStatusChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SendTouchScreenKeyboardStatusChanged_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00021DFC File Offset: 0x0001FFFC
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1043184, RefRangeEnd = 1043203, XrefRangeStart = 1043130, XrefRangeEnd = 1043184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_UpdateLabel_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00021E30 File Offset: 0x00020030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043203, XrefRangeEnd = 1043211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScrollbar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_UpdateScrollbar_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00021E64 File Offset: 0x00020064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043211, XrefRangeEnd = 1043212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnScrollbarValueChange(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_OnScrollbarValueChange_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00021EA4 File Offset: 0x000200A4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaskRegions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_UpdateMaskRegions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00021ED8 File Offset: 0x000200D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1043226, RefRangeEnd = 1043228, XrefRangeStart = 1043212, XrefRangeEnd = 1043226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdjustTextPositionRelativeToViewport(float relativePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref relativePosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_AdjustTextPositionRelativeToViewport_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00021F18 File Offset: 0x00020118
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1043228, RefRangeEnd = 1043230, XrefRangeStart = 1043228, XrefRangeEnd = 1043228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCaretPositionFromStringIndex(int stringIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stringIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_GetCaretPositionFromStringIndex_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00021F64 File Offset: 0x00020164
		[CallerCount(0)]
		public unsafe int GetMinCaretPositionFromStringIndex(int stringIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stringIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_GetMinCaretPositionFromStringIndex_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00021FB0 File Offset: 0x000201B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1043228, RefRangeEnd = 1043230, XrefRangeStart = 1043228, XrefRangeEnd = 1043230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMaxCaretPositionFromStringIndex(int stringIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stringIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_GetMaxCaretPositionFromStringIndex_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00021FFC File Offset: 0x000201FC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1043231, RefRangeEnd = 1043245, XrefRangeStart = 1043230, XrefRangeEnd = 1043231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetStringIndexFromCaretPosition(int caretPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref caretPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_GetStringIndexFromCaretPosition_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00022048 File Offset: 0x00020248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043245, XrefRangeEnd = 1043246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceLabelUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_ForceLabelUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0002207C File Offset: 0x0002027C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1043250, RefRangeEnd = 1043252, XrefRangeStart = 1043246, XrefRangeEnd = 1043250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkGeometryAsDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_MarkGeometryAsDirty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x000220B0 File Offset: 0x000202B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043252, XrefRangeEnd = 1043261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Rebuild(CanvasUpdate update)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref update;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x000220FC File Offset: 0x000202FC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LayoutComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00022138 File Offset: 0x00020338
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GraphicUpdateComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00022174 File Offset: 0x00020374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043261, XrefRangeEnd = 1043270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGeometry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_UpdateGeometry_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x000221A8 File Offset: 0x000203A8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1043325, RefRangeEnd = 1043334, XrefRangeStart = 1043270, XrefRangeEnd = 1043325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignPositioningIfNeeded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_AssignPositioningIfNeeded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x000221DC File Offset: 0x000203DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1043372, RefRangeEnd = 1043374, XrefRangeStart = 1043334, XrefRangeEnd = 1043372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFillVBO(Mesh vbo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vbo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_OnFillVBO_Private_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00022220 File Offset: 0x00020420
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1043438, RefRangeEnd = 1043439, XrefRangeStart = 1043374, XrefRangeEnd = 1043438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vbo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref roundingOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_GenerateCaret_Private_Void_VertexHelper_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00022270 File Offset: 0x00020470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043439, XrefRangeEnd = 1043450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateCursorVerts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_CreateCursorVerts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x000222A4 File Offset: 0x000204A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1043478, RefRangeEnd = 1043479, XrefRangeStart = 1043450, XrefRangeEnd = 1043478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vbo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref roundingOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_GenerateHightlight_Private_Void_VertexHelper_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x000222F4 File Offset: 0x000204F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1043515, RefRangeEnd = 1043517, XrefRangeStart = 1043479, XrefRangeEnd = 1043515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCharVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_AdjustRectTransformRelativeToViewport_Private_Void_Vector2_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00022350 File Offset: 0x00020550
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1043537, RefRangeEnd = 1043539, XrefRangeStart = 1043517, XrefRangeEnd = 1043537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char Validate(string text, int pos, char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_Validate_Protected_Char_String_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x000223BC File Offset: 0x000205BC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1043549, RefRangeEnd = 1043554, XrefRangeStart = 1043539, XrefRangeEnd = 1043549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateInputField()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_ActivateInputField_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x000223F0 File Offset: 0x000205F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1043620, RefRangeEnd = 1043621, XrefRangeStart = 1043554, XrefRangeEnd = 1043620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateInputFieldInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_ActivateInputFieldInternal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00022424 File Offset: 0x00020624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043621, XrefRangeEnd = 1043626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00022474 File Offset: 0x00020674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043626, XrefRangeEnd = 1043627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x000224C4 File Offset: 0x000206C4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnControlClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_OnControlClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x000224F8 File Offset: 0x000206F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1043636, RefRangeEnd = 1043637, XrefRangeStart = 1043627, XrefRangeEnd = 1043636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_ReleaseSelection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x0002252C File Offset: 0x0002072C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1043662, RefRangeEnd = 1043667, XrefRangeStart = 1043637, XrefRangeEnd = 1043662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeactivateInputField(bool clearSelection = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clearSelection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_DeactivateInputField_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x0002256C File Offset: 0x0002076C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043667, XrefRangeEnd = 1043672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDeselect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x000225BC File Offset: 0x000207BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043672, XrefRangeEnd = 1043675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSubmit(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0002260C File Offset: 0x0002080C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043675, XrefRangeEnd = 1043688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnforceContentType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_EnforceContentType_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00022640 File Offset: 0x00020840
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1043693, RefRangeEnd = 1043697, XrefRangeStart = 1043688, XrefRangeEnd = 1043693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextComponentWrapMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SetTextComponentWrapMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00022674 File Offset: 0x00020874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043697, XrefRangeEnd = 1043702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextComponentRichTextMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SetTextComponentRichTextMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x000226A8 File Offset: 0x000208A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043702, XrefRangeEnd = 1043704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToCustomIfContentTypeIsNot([Optional] Il2CppStructArray<TMP_InputField.ContentType> allowedContentTypes)
		{
			if (allowedContentTypes == null)
			{
				allowedContentTypes = new Il2CppStructArray<TMP_InputField.ContentType>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(allowedContentTypes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SetToCustomIfContentTypeIsNot_Private_Void_Il2CppStructArray_1_ContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x000226F8 File Offset: 0x000208F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043704, XrefRangeEnd = 1043705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToCustom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SetToCustom_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0002272C File Offset: 0x0002092C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToCustom(TMP_InputField.CharacterValidation characterValidation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref characterValidation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SetToCustom_Private_Void_CharacterValidation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0002276C File Offset: 0x0002096C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043705, XrefRangeEnd = 1043707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instant;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x000227C4 File Offset: 0x000209C4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00022800 File Offset: 0x00020A00
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x0002283C File Offset: 0x00020A3C
		public unsafe virtual float minWidth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122524, RefRangeEnd = 122525, XrefRangeStart = 122524, XrefRangeEnd = 122525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x00022884 File Offset: 0x00020A84
		public unsafe virtual float preferredWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043707, XrefRangeEnd = 1043720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x000228CC File Offset: 0x00020ACC
		public unsafe virtual float flexibleWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x00022914 File Offset: 0x00020B14
		public unsafe virtual float minHeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122524, RefRangeEnd = 122525, XrefRangeStart = 122524, XrefRangeEnd = 122525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x0002295C File Offset: 0x00020B5C
		public unsafe virtual float preferredHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043720, XrefRangeEnd = 1043733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x000229A4 File Offset: 0x00020BA4
		public unsafe virtual float flexibleHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x000229EC File Offset: 0x00020BEC
		public unsafe virtual int layoutPriority
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_InputField.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00022A34 File Offset: 0x00020C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043733, XrefRangeEnd = 1043744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGlobalPointSize(float pointSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SetGlobalPointSize_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00022A74 File Offset: 0x00020C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043744, XrefRangeEnd = 1043755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGlobalFontAsset(TMP_FontAsset fontAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_SetGlobalFontAsset_Public_Void_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00022AB8 File Offset: 0x00020CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Transform UnityEngine_UI_ICanvasElement_get_transform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00004F2D File Offset: 0x0000312D
		public void SetToCustomIfContentTypeIsNot(params TMP_InputField.ContentType[] allowedContentTypes)
		{
			this.SetToCustomIfContentTypeIsNot(new Il2CppStructArray<TMP_InputField.ContentType>(allowedContentTypes));
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00004F3B File Offset: 0x0000313B
		public TMP_InputField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x00022AF8 File Offset: 0x00020CF8
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x00004F44 File Offset: 0x00003144
		public unsafe TouchScreenKeyboard m_SoftKeyboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_SoftKeyboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchScreenKeyboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_SoftKeyboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x00022B28 File Offset: 0x00020D28
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x00004F63 File Offset: 0x00003163
		public unsafe static Il2CppStructArray<char> kSeparators
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_InputField.NativeFieldInfoPtr_kSeparators, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_InputField.NativeFieldInfoPtr_kSeparators, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x00022B50 File Offset: 0x00020D50
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x00004F75 File Offset: 0x00003175
		public unsafe RectTransform m_RectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_RectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_RectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x00022B80 File Offset: 0x00020D80
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x00004F94 File Offset: 0x00003194
		public unsafe RectTransform m_TextViewport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_TextViewport);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_TextViewport), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x00022BB0 File Offset: 0x00020DB0
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x00004FB3 File Offset: 0x000031B3
		public unsafe RectMask2D m_TextComponentRectMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_TextComponentRectMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectMask2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_TextComponentRectMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x00022BE0 File Offset: 0x00020DE0
		// (set) Token: 0x060006F3 RID: 1779 RVA: 0x00004FD2 File Offset: 0x000031D2
		public unsafe RectMask2D m_TextViewportRectMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_TextViewportRectMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectMask2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_TextViewportRectMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x00022C10 File Offset: 0x00020E10
		// (set) Token: 0x060006F5 RID: 1781 RVA: 0x00004FF1 File Offset: 0x000031F1
		public unsafe Rect m_CachedViewportRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CachedViewportRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CachedViewportRect)) = value;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x00022C38 File Offset: 0x00020E38
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x0000500C File Offset: 0x0000320C
		public unsafe TMP_Text m_TextComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_TextComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_TextComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x00022C68 File Offset: 0x00020E68
		// (set) Token: 0x060006F9 RID: 1785 RVA: 0x0000502B File Offset: 0x0000322B
		public unsafe RectTransform m_TextComponentRectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_TextComponentRectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_TextComponentRectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x00022C98 File Offset: 0x00020E98
		// (set) Token: 0x060006FB RID: 1787 RVA: 0x0000504A File Offset: 0x0000324A
		public unsafe Graphic m_Placeholder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_Placeholder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_Placeholder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x00022CC8 File Offset: 0x00020EC8
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x00005069 File Offset: 0x00003269
		public unsafe Scrollbar m_VerticalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_VerticalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_VerticalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x00022CF8 File Offset: 0x00020EF8
		// (set) Token: 0x060006FF RID: 1791 RVA: 0x00005088 File Offset: 0x00003288
		public unsafe TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_VerticalScrollbarEventHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_ScrollbarEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_VerticalScrollbarEventHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x00022D28 File Offset: 0x00020F28
		// (set) Token: 0x06000701 RID: 1793 RVA: 0x000050A7 File Offset: 0x000032A7
		public unsafe bool m_IsDrivenByLayoutComponents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_IsDrivenByLayoutComponents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_IsDrivenByLayoutComponents)) = value;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x00022D50 File Offset: 0x00020F50
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x000050C2 File Offset: 0x000032C2
		public unsafe LayoutGroup m_LayoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_LayoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_LayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x00022D80 File Offset: 0x00020F80
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x000050E1 File Offset: 0x000032E1
		public unsafe IScrollHandler m_IScrollHandlerParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_IScrollHandlerParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IScrollHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_IScrollHandlerParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x00022DB0 File Offset: 0x00020FB0
		// (set) Token: 0x06000707 RID: 1799 RVA: 0x00005100 File Offset: 0x00003300
		public unsafe float m_ScrollPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ScrollPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ScrollPosition)) = value;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x00022DD8 File Offset: 0x00020FD8
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x0000511B File Offset: 0x0000331B
		public unsafe float m_ScrollSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ScrollSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ScrollSensitivity)) = value;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x00022E00 File Offset: 0x00021000
		// (set) Token: 0x0600070B RID: 1803 RVA: 0x00005136 File Offset: 0x00003336
		public unsafe TMP_InputField.ContentType m_ContentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ContentType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ContentType)) = value;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x00022E28 File Offset: 0x00021028
		// (set) Token: 0x0600070D RID: 1805 RVA: 0x00005151 File Offset: 0x00003351
		public unsafe TMP_InputField.InputType m_InputType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_InputType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_InputType)) = value;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x00022E50 File Offset: 0x00021050
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x0000516C File Offset: 0x0000336C
		public unsafe char m_AsteriskChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_AsteriskChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_AsteriskChar)) = value;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x00022E78 File Offset: 0x00021078
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x00005187 File Offset: 0x00003387
		public unsafe TouchScreenKeyboardType m_KeyboardType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_KeyboardType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_KeyboardType)) = value;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x00022EA0 File Offset: 0x000210A0
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x000051A2 File Offset: 0x000033A2
		public unsafe TMP_InputField.LineType m_LineType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_LineType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_LineType)) = value;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x00022EC8 File Offset: 0x000210C8
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x000051BD File Offset: 0x000033BD
		public unsafe bool m_HideMobileInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_HideMobileInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_HideMobileInput)) = value;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x00022EF0 File Offset: 0x000210F0
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x000051D8 File Offset: 0x000033D8
		public unsafe bool m_HideSoftKeyboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_HideSoftKeyboard);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_HideSoftKeyboard)) = value;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x00022F18 File Offset: 0x00021118
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x000051F3 File Offset: 0x000033F3
		public unsafe TMP_InputField.CharacterValidation m_CharacterValidation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CharacterValidation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CharacterValidation)) = value;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x00022F40 File Offset: 0x00021140
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x0000520E File Offset: 0x0000340E
		public unsafe string m_RegexValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_RegexValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_RegexValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x00022F68 File Offset: 0x00021168
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x0000522D File Offset: 0x0000342D
		public unsafe float m_GlobalPointSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_GlobalPointSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_GlobalPointSize)) = value;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00022F90 File Offset: 0x00021190
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x00005248 File Offset: 0x00003448
		public unsafe int m_CharacterLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CharacterLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CharacterLimit)) = value;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x00022FB8 File Offset: 0x000211B8
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x00005263 File Offset: 0x00003463
		public unsafe TMP_InputField.SubmitEvent m_OnEndEdit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnEndEdit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField.SubmitEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnEndEdit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x00022FE8 File Offset: 0x000211E8
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x00005282 File Offset: 0x00003482
		public unsafe TMP_InputField.SubmitEvent m_OnSubmit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnSubmit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField.SubmitEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnSubmit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x00023018 File Offset: 0x00021218
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x000052A1 File Offset: 0x000034A1
		public unsafe TMP_InputField.SelectionEvent m_OnSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnSelect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField.SelectionEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnSelect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x00023048 File Offset: 0x00021248
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x000052C0 File Offset: 0x000034C0
		public unsafe TMP_InputField.SelectionEvent m_OnDeselect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnDeselect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField.SelectionEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnDeselect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x00023078 File Offset: 0x00021278
		// (set) Token: 0x06000729 RID: 1833 RVA: 0x000052DF File Offset: 0x000034DF
		public unsafe TMP_InputField.TextSelectionEvent m_OnTextSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnTextSelection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField.TextSelectionEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnTextSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x000230A8 File Offset: 0x000212A8
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x000052FE File Offset: 0x000034FE
		public unsafe TMP_InputField.TextSelectionEvent m_OnEndTextSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnEndTextSelection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField.TextSelectionEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnEndTextSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x000230D8 File Offset: 0x000212D8
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x0000531D File Offset: 0x0000351D
		public unsafe TMP_InputField.OnChangeEvent m_OnValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField.OnChangeEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x00023108 File Offset: 0x00021308
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x0000533C File Offset: 0x0000353C
		public unsafe TMP_InputField.TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnTouchScreenKeyboardStatusChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField.TouchScreenKeyboardEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnTouchScreenKeyboardStatusChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x00023138 File Offset: 0x00021338
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x0000535B File Offset: 0x0000355B
		public unsafe TMP_InputField.OnValidateInput m_OnValidateInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnValidateInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField.OnValidateInput>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnValidateInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x00023168 File Offset: 0x00021368
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x0000537A File Offset: 0x0000357A
		public unsafe Color m_CaretColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CaretColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CaretColor)) = value;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x00023190 File Offset: 0x00021390
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x00005395 File Offset: 0x00003595
		public unsafe bool m_CustomCaretColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CustomCaretColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CustomCaretColor)) = value;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x000231B8 File Offset: 0x000213B8
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x000053B0 File Offset: 0x000035B0
		public unsafe Color m_SelectionColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_SelectionColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_SelectionColor)) = value;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x000231E0 File Offset: 0x000213E0
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x000053CB File Offset: 0x000035CB
		public unsafe string m_Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x00023208 File Offset: 0x00021408
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x000053EA File Offset: 0x000035EA
		public unsafe float m_CaretBlinkRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CaretBlinkRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CaretBlinkRate)) = value;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x00023230 File Offset: 0x00021430
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x00005405 File Offset: 0x00003605
		public unsafe int m_CaretWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CaretWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CaretWidth)) = value;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x00023258 File Offset: 0x00021458
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x00005420 File Offset: 0x00003620
		public unsafe bool m_ReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ReadOnly)) = value;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x00023280 File Offset: 0x00021480
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x0000543B File Offset: 0x0000363B
		public unsafe bool m_RichText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_RichText);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_RichText)) = value;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x000232A8 File Offset: 0x000214A8
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x00005456 File Offset: 0x00003656
		public unsafe int m_StringPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_StringPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_StringPosition)) = value;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x000232D0 File Offset: 0x000214D0
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x00005471 File Offset: 0x00003671
		public unsafe int m_StringSelectPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_StringSelectPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_StringSelectPosition)) = value;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x000232F8 File Offset: 0x000214F8
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x0000548C File Offset: 0x0000368C
		public unsafe int m_CaretPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CaretPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CaretPosition)) = value;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x00023320 File Offset: 0x00021520
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x000054A7 File Offset: 0x000036A7
		public unsafe int m_CaretSelectPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CaretSelectPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CaretSelectPosition)) = value;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x00023348 File Offset: 0x00021548
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x000054C2 File Offset: 0x000036C2
		public unsafe RectTransform caretRectTrans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_caretRectTrans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_caretRectTrans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x00023378 File Offset: 0x00021578
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x000054E1 File Offset: 0x000036E1
		public unsafe Il2CppStructArray<UIVertex> m_CursorVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CursorVerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<UIVertex>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CursorVerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x000233A8 File Offset: 0x000215A8
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x00005500 File Offset: 0x00003700
		public unsafe CanvasRenderer m_CachedInputRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CachedInputRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CachedInputRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x000233D8 File Offset: 0x000215D8
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x0000551F File Offset: 0x0000371F
		public unsafe Vector2 m_LastPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_LastPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_LastPosition)) = value;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x00023400 File Offset: 0x00021600
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x0000553A File Offset: 0x0000373A
		public unsafe Mesh m_Mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_Mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_Mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x00023430 File Offset: 0x00021630
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x00005559 File Offset: 0x00003759
		public unsafe bool m_AllowInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_AllowInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_AllowInput)) = value;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x00023458 File Offset: 0x00021658
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x00005574 File Offset: 0x00003774
		public unsafe bool m_ShouldActivateNextUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ShouldActivateNextUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ShouldActivateNextUpdate)) = value;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x00023480 File Offset: 0x00021680
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x0000558F File Offset: 0x0000378F
		public unsafe bool m_UpdateDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_UpdateDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_UpdateDrag)) = value;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x000234A8 File Offset: 0x000216A8
		// (set) Token: 0x0600075B RID: 1883 RVA: 0x000055AA File Offset: 0x000037AA
		public unsafe bool m_DragPositionOutOfBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_DragPositionOutOfBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_DragPositionOutOfBounds)) = value;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x000234D0 File Offset: 0x000216D0
		// (set) Token: 0x0600075D RID: 1885 RVA: 0x000055C5 File Offset: 0x000037C5
		public unsafe static float kHScrollSpeed
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TMP_InputField.NativeFieldInfoPtr_kHScrollSpeed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_InputField.NativeFieldInfoPtr_kHScrollSpeed, (void*)(&value));
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x000234EC File Offset: 0x000216EC
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x000055D3 File Offset: 0x000037D3
		public unsafe static float kVScrollSpeed
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TMP_InputField.NativeFieldInfoPtr_kVScrollSpeed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_InputField.NativeFieldInfoPtr_kVScrollSpeed, (void*)(&value));
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x00023508 File Offset: 0x00021708
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x000055E1 File Offset: 0x000037E1
		public unsafe bool m_CaretVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CaretVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_CaretVisible)) = value;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x00023530 File Offset: 0x00021730
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x000055FC File Offset: 0x000037FC
		public unsafe Coroutine m_BlinkCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_BlinkCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_BlinkCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x00023560 File Offset: 0x00021760
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x0000561B File Offset: 0x0000381B
		public unsafe float m_BlinkStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_BlinkStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_BlinkStartTime)) = value;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x00023588 File Offset: 0x00021788
		// (set) Token: 0x06000767 RID: 1895 RVA: 0x00005636 File Offset: 0x00003836
		public unsafe Coroutine m_DragCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_DragCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_DragCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x000235B8 File Offset: 0x000217B8
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x00005655 File Offset: 0x00003855
		public unsafe string m_OriginalText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OriginalText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OriginalText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x000235E0 File Offset: 0x000217E0
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x00005674 File Offset: 0x00003874
		public unsafe bool m_WasCanceled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_WasCanceled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_WasCanceled)) = value;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x00023608 File Offset: 0x00021808
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x0000568F File Offset: 0x0000388F
		public unsafe bool m_HasDoneFocusTransition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_HasDoneFocusTransition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_HasDoneFocusTransition)) = value;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x00023630 File Offset: 0x00021830
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x000056AA File Offset: 0x000038AA
		public unsafe WaitForSecondsRealtime m_WaitForSecondsRealtime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_WaitForSecondsRealtime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSecondsRealtime>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_WaitForSecondsRealtime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x00023660 File Offset: 0x00021860
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x000056C9 File Offset: 0x000038C9
		public unsafe bool m_PreventCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_PreventCallback);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_PreventCallback)) = value;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x00023688 File Offset: 0x00021888
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x000056E4 File Offset: 0x000038E4
		public unsafe bool m_TouchKeyboardAllowsInPlaceEditing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_TouchKeyboardAllowsInPlaceEditing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_TouchKeyboardAllowsInPlaceEditing)) = value;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x000236B0 File Offset: 0x000218B0
		// (set) Token: 0x06000775 RID: 1909 RVA: 0x000056FF File Offset: 0x000038FF
		public unsafe bool m_IsTextComponentUpdateRequired
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_IsTextComponentUpdateRequired);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_IsTextComponentUpdateRequired)) = value;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x000236D8 File Offset: 0x000218D8
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x0000571A File Offset: 0x0000391A
		public unsafe bool m_isLastKeyBackspace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_isLastKeyBackspace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_isLastKeyBackspace)) = value;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x00023700 File Offset: 0x00021900
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x00005735 File Offset: 0x00003935
		public unsafe float m_PointerDownClickStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_PointerDownClickStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_PointerDownClickStartTime)) = value;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x00023728 File Offset: 0x00021928
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x00005750 File Offset: 0x00003950
		public unsafe float m_KeyDownStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_KeyDownStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_KeyDownStartTime)) = value;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x00023750 File Offset: 0x00021950
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x0000576B File Offset: 0x0000396B
		public unsafe float m_DoubleClickDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_DoubleClickDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_DoubleClickDelay)) = value;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x00023778 File Offset: 0x00021978
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x00005786 File Offset: 0x00003986
		public unsafe static string kEmailSpecialCharacters
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_InputField.NativeFieldInfoPtr_kEmailSpecialCharacters, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_InputField.NativeFieldInfoPtr_kEmailSpecialCharacters, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x00023798 File Offset: 0x00021998
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x00005798 File Offset: 0x00003998
		public unsafe bool m_IsCompositionActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_IsCompositionActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_IsCompositionActive)) = value;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x000237C0 File Offset: 0x000219C0
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x000057B3 File Offset: 0x000039B3
		public unsafe bool m_ShouldUpdateIMEWindowPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ShouldUpdateIMEWindowPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ShouldUpdateIMEWindowPosition)) = value;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x000237E8 File Offset: 0x000219E8
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x000057CE File Offset: 0x000039CE
		public unsafe int m_PreviousIMEInsertionLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_PreviousIMEInsertionLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_PreviousIMEInsertionLine)) = value;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x00023810 File Offset: 0x00021A10
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x000057E9 File Offset: 0x000039E9
		public unsafe TMP_FontAsset m_GlobalFontAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_GlobalFontAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_GlobalFontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x00023840 File Offset: 0x00021A40
		// (set) Token: 0x06000789 RID: 1929 RVA: 0x00005808 File Offset: 0x00003A08
		public unsafe bool m_OnFocusSelectAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnFocusSelectAll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_OnFocusSelectAll)) = value;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x00023868 File Offset: 0x00021A68
		// (set) Token: 0x0600078B RID: 1931 RVA: 0x00005823 File Offset: 0x00003A23
		public unsafe bool m_isSelectAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_isSelectAll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_isSelectAll)) = value;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x00023890 File Offset: 0x00021A90
		// (set) Token: 0x0600078D RID: 1933 RVA: 0x0000583E File Offset: 0x00003A3E
		public unsafe bool m_ResetOnDeActivation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ResetOnDeActivation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ResetOnDeActivation)) = value;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x000238B8 File Offset: 0x00021AB8
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x00005859 File Offset: 0x00003A59
		public unsafe bool m_SelectionStillActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_SelectionStillActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_SelectionStillActive)) = value;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x000238E0 File Offset: 0x00021AE0
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x00005874 File Offset: 0x00003A74
		public unsafe bool m_ReleaseSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ReleaseSelection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ReleaseSelection)) = value;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x00023908 File Offset: 0x00021B08
		// (set) Token: 0x06000793 RID: 1939 RVA: 0x0000588F File Offset: 0x00003A8F
		public unsafe GameObject m_PreviouslySelectedObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_PreviouslySelectedObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_PreviouslySelectedObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x00023938 File Offset: 0x00021B38
		// (set) Token: 0x06000795 RID: 1941 RVA: 0x000058AE File Offset: 0x00003AAE
		public unsafe bool m_RestoreOriginalTextOnEscape
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_RestoreOriginalTextOnEscape);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_RestoreOriginalTextOnEscape)) = value;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x00023960 File Offset: 0x00021B60
		// (set) Token: 0x06000797 RID: 1943 RVA: 0x000058C9 File Offset: 0x00003AC9
		public unsafe bool m_isRichTextEditingAllowed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_isRichTextEditingAllowed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_isRichTextEditingAllowed)) = value;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x00023988 File Offset: 0x00021B88
		// (set) Token: 0x06000799 RID: 1945 RVA: 0x000058E4 File Offset: 0x00003AE4
		public unsafe int m_LineLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_LineLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_LineLimit)) = value;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x000239B0 File Offset: 0x00021BB0
		// (set) Token: 0x0600079B RID: 1947 RVA: 0x000058FF File Offset: 0x00003AFF
		public unsafe TMP_InputValidator m_InputValidator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_InputValidator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputValidator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_InputValidator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x000239E0 File Offset: 0x00021BE0
		// (set) Token: 0x0600079D RID: 1949 RVA: 0x0000591E File Offset: 0x00003B1E
		public unsafe bool m_isSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_isSelected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_isSelected)) = value;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x00023A08 File Offset: 0x00021C08
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x00005939 File Offset: 0x00003B39
		public unsafe bool m_IsStringPositionDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_IsStringPositionDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_IsStringPositionDirty)) = value;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x00023A30 File Offset: 0x00021C30
		// (set) Token: 0x060007A1 RID: 1953 RVA: 0x00005954 File Offset: 0x00003B54
		public unsafe bool m_IsCaretPositionDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_IsCaretPositionDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_IsCaretPositionDirty)) = value;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x00023A58 File Offset: 0x00021C58
		// (set) Token: 0x060007A3 RID: 1955 RVA: 0x0000596F File Offset: 0x00003B6F
		public unsafe bool m_forceRectTransformAdjustment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_forceRectTransformAdjustment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_forceRectTransformAdjustment)) = value;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060007A4 RID: 1956 RVA: 0x00023A80 File Offset: 0x00021C80
		// (set) Token: 0x060007A5 RID: 1957 RVA: 0x0000598A File Offset: 0x00003B8A
		public unsafe Event m_ProcessingEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ProcessingEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Event>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField.NativeFieldInfoPtr_m_ProcessingEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeFieldInfoPtr_m_SoftKeyboard;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeFieldInfoPtr_kSeparators;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeFieldInfoPtr_m_RectTransform;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeFieldInfoPtr_m_TextViewport;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeFieldInfoPtr_m_TextComponentRectMask;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeFieldInfoPtr_m_TextViewportRectMask;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedViewportRect;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeFieldInfoPtr_m_TextComponent;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeFieldInfoPtr_m_TextComponentRectTransform;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeFieldInfoPtr_m_Placeholder;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalScrollbar;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalScrollbarEventHandler;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeFieldInfoPtr_m_IsDrivenByLayoutComponents;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeFieldInfoPtr_m_LayoutGroup;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeFieldInfoPtr_m_IScrollHandlerParent;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeFieldInfoPtr_m_ScrollPosition;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeFieldInfoPtr_m_ScrollSensitivity;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeFieldInfoPtr_m_ContentType;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeFieldInfoPtr_m_InputType;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeFieldInfoPtr_m_AsteriskChar;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeFieldInfoPtr_m_KeyboardType;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeFieldInfoPtr_m_LineType;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeFieldInfoPtr_m_HideMobileInput;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeFieldInfoPtr_m_HideSoftKeyboard;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeFieldInfoPtr_m_CharacterValidation;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeFieldInfoPtr_m_RegexValue;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeFieldInfoPtr_m_GlobalPointSize;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeFieldInfoPtr_m_CharacterLimit;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeFieldInfoPtr_m_OnEndEdit;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeFieldInfoPtr_m_OnSubmit;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeFieldInfoPtr_m_OnSelect;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeFieldInfoPtr_m_OnDeselect;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeFieldInfoPtr_m_OnTextSelection;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeFieldInfoPtr_m_OnEndTextSelection;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeFieldInfoPtr_m_OnValueChanged;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeFieldInfoPtr_m_OnTouchScreenKeyboardStatusChanged;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeFieldInfoPtr_m_OnValidateInput;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeFieldInfoPtr_m_CaretColor;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomCaretColor;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectionColor;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeFieldInfoPtr_m_Text;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeFieldInfoPtr_m_CaretBlinkRate;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeFieldInfoPtr_m_CaretWidth;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeFieldInfoPtr_m_ReadOnly;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeFieldInfoPtr_m_RichText;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeFieldInfoPtr_m_StringPosition;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeFieldInfoPtr_m_StringSelectPosition;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeFieldInfoPtr_m_CaretPosition;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeFieldInfoPtr_m_CaretSelectPosition;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeFieldInfoPtr_caretRectTrans;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeFieldInfoPtr_m_CursorVerts;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedInputRenderer;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeFieldInfoPtr_m_LastPosition;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeFieldInfoPtr_m_Mesh;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeFieldInfoPtr_m_AllowInput;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldActivateNextUpdate;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateDrag;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeFieldInfoPtr_m_DragPositionOutOfBounds;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeFieldInfoPtr_kHScrollSpeed;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeFieldInfoPtr_kVScrollSpeed;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeFieldInfoPtr_m_CaretVisible;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeFieldInfoPtr_m_BlinkCoroutine;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeFieldInfoPtr_m_BlinkStartTime;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeFieldInfoPtr_m_DragCoroutine;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeFieldInfoPtr_m_OriginalText;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeFieldInfoPtr_m_WasCanceled;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeFieldInfoPtr_m_HasDoneFocusTransition;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeFieldInfoPtr_m_WaitForSecondsRealtime;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeFieldInfoPtr_m_PreventCallback;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeFieldInfoPtr_m_TouchKeyboardAllowsInPlaceEditing;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeFieldInfoPtr_m_IsTextComponentUpdateRequired;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeFieldInfoPtr_m_isLastKeyBackspace;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeFieldInfoPtr_m_PointerDownClickStartTime;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeFieldInfoPtr_m_KeyDownStartTime;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeFieldInfoPtr_m_DoubleClickDelay;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeFieldInfoPtr_kEmailSpecialCharacters;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeFieldInfoPtr_m_IsCompositionActive;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldUpdateIMEWindowPosition;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousIMEInsertionLine;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeFieldInfoPtr_m_GlobalFontAsset;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeFieldInfoPtr_m_OnFocusSelectAll;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeFieldInfoPtr_m_isSelectAll;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeFieldInfoPtr_m_ResetOnDeActivation;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectionStillActive;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeFieldInfoPtr_m_ReleaseSelection;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviouslySelectedObject;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeFieldInfoPtr_m_RestoreOriginalTextOnEscape;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeFieldInfoPtr_m_isRichTextEditingAllowed;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeFieldInfoPtr_m_LineLimit;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeFieldInfoPtr_m_InputValidator;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeFieldInfoPtr_m_isSelected;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeFieldInfoPtr_m_IsStringPositionDirty;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeFieldInfoPtr_m_IsCaretPositionDirty;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeFieldInfoPtr_m_forceRectTransformAdjustment;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeFieldInfoPtr_m_ProcessingEvent;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeMethodInfoPtr_get_inputSystem_Private_get_BaseInput_0;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeMethodInfoPtr_get_compositionString_Private_get_String_0;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeMethodInfoPtr_get_compositionLength_Private_get_Int32_0;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeMethodInfoPtr_get_mesh_Protected_get_Mesh_0;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr_get_shouldHideMobileInput_Public_get_Boolean_0;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr_set_shouldHideMobileInput_Public_set_Void_Boolean_0;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeMethodInfoPtr_get_shouldHideSoftKeyboard_Public_get_Boolean_0;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeMethodInfoPtr_set_shouldHideSoftKeyboard_Public_set_Void_Boolean_0;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeMethodInfoPtr_isKeyboardUsingEvents_Private_Boolean_0;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeMethodInfoPtr_SetTextWithoutNotify_Public_Void_String_0;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Private_Void_String_Boolean_0;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeMethodInfoPtr_get_isFocused_Public_get_Boolean_0;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeMethodInfoPtr_get_caretBlinkRate_Public_get_Single_0;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeMethodInfoPtr_set_caretBlinkRate_Public_set_Void_Single_0;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeMethodInfoPtr_get_caretWidth_Public_get_Int32_0;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeMethodInfoPtr_set_caretWidth_Public_set_Void_Int32_0;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeMethodInfoPtr_get_textViewport_Public_get_RectTransform_0;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeMethodInfoPtr_set_textViewport_Public_set_Void_RectTransform_0;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeMethodInfoPtr_get_textComponent_Public_get_TMP_Text_0;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeMethodInfoPtr_set_textComponent_Public_set_Void_TMP_Text_0;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeMethodInfoPtr_get_placeholder_Public_get_Graphic_0;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeMethodInfoPtr_set_placeholder_Public_set_Void_Graphic_0;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalScrollbar_Public_get_Scrollbar_0;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalScrollbar_Public_set_Void_Scrollbar_0;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeMethodInfoPtr_get_scrollSensitivity_Public_get_Single_0;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeMethodInfoPtr_set_scrollSensitivity_Public_set_Void_Single_0;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeMethodInfoPtr_get_caretColor_Public_get_Color_0;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeMethodInfoPtr_set_caretColor_Public_set_Void_Color_0;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeMethodInfoPtr_get_customCaretColor_Public_get_Boolean_0;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeMethodInfoPtr_set_customCaretColor_Public_set_Void_Boolean_0;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeMethodInfoPtr_get_selectionColor_Public_get_Color_0;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeMethodInfoPtr_set_selectionColor_Public_set_Void_Color_0;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeMethodInfoPtr_get_onEndEdit_Public_get_SubmitEvent_0;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeMethodInfoPtr_set_onEndEdit_Public_set_Void_SubmitEvent_0;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeMethodInfoPtr_get_onSubmit_Public_get_SubmitEvent_0;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeMethodInfoPtr_set_onSubmit_Public_set_Void_SubmitEvent_0;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeMethodInfoPtr_get_onSelect_Public_get_SelectionEvent_0;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeMethodInfoPtr_set_onSelect_Public_set_Void_SelectionEvent_0;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeMethodInfoPtr_get_onDeselect_Public_get_SelectionEvent_0;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeMethodInfoPtr_set_onDeselect_Public_set_Void_SelectionEvent_0;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeMethodInfoPtr_get_onTextSelection_Public_get_TextSelectionEvent_0;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeMethodInfoPtr_set_onTextSelection_Public_set_Void_TextSelectionEvent_0;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeMethodInfoPtr_get_onEndTextSelection_Public_get_TextSelectionEvent_0;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeMethodInfoPtr_set_onEndTextSelection_Public_set_Void_TextSelectionEvent_0;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeMethodInfoPtr_get_onValueChanged_Public_get_OnChangeEvent_0;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_OnChangeEvent_0;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeMethodInfoPtr_get_onTouchScreenKeyboardStatusChanged_Public_get_TouchScreenKeyboardEvent_0;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeMethodInfoPtr_set_onTouchScreenKeyboardStatusChanged_Public_set_Void_TouchScreenKeyboardEvent_0;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeMethodInfoPtr_get_onValidateInput_Public_get_OnValidateInput_0;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeMethodInfoPtr_set_onValidateInput_Public_set_Void_OnValidateInput_0;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeMethodInfoPtr_get_characterLimit_Public_get_Int32_0;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeMethodInfoPtr_set_characterLimit_Public_set_Void_Int32_0;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeMethodInfoPtr_get_pointSize_Public_get_Single_0;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeMethodInfoPtr_set_pointSize_Public_set_Void_Single_0;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeMethodInfoPtr_get_fontAsset_Public_get_TMP_FontAsset_0;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeMethodInfoPtr_set_fontAsset_Public_set_Void_TMP_FontAsset_0;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeMethodInfoPtr_get_onFocusSelectAll_Public_get_Boolean_0;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeMethodInfoPtr_set_onFocusSelectAll_Public_set_Void_Boolean_0;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeMethodInfoPtr_get_resetOnDeActivation_Public_get_Boolean_0;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeMethodInfoPtr_set_resetOnDeActivation_Public_set_Void_Boolean_0;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeMethodInfoPtr_get_restoreOriginalTextOnEscape_Public_get_Boolean_0;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeMethodInfoPtr_set_restoreOriginalTextOnEscape_Public_set_Void_Boolean_0;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeMethodInfoPtr_get_isRichTextEditingAllowed_Public_get_Boolean_0;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeMethodInfoPtr_set_isRichTextEditingAllowed_Public_set_Void_Boolean_0;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr_get_contentType_Public_get_ContentType_0;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeMethodInfoPtr_set_contentType_Public_set_Void_ContentType_0;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeMethodInfoPtr_get_lineType_Public_get_LineType_0;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeMethodInfoPtr_set_lineType_Public_set_Void_LineType_0;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr_get_lineLimit_Public_get_Int32_0;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeMethodInfoPtr_set_lineLimit_Public_set_Void_Int32_0;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr_get_inputType_Public_get_InputType_0;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeMethodInfoPtr_set_inputType_Public_set_Void_InputType_0;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeMethodInfoPtr_get_keyboardType_Public_get_TouchScreenKeyboardType_0;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeMethodInfoPtr_set_keyboardType_Public_set_Void_TouchScreenKeyboardType_0;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeMethodInfoPtr_get_characterValidation_Public_get_CharacterValidation_0;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr_set_characterValidation_Public_set_Void_CharacterValidation_0;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr_get_inputValidator_Public_get_TMP_InputValidator_0;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr_set_inputValidator_Public_set_Void_TMP_InputValidator_0;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeMethodInfoPtr_get_readOnly_Public_get_Boolean_0;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeMethodInfoPtr_set_readOnly_Public_set_Void_Boolean_0;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeMethodInfoPtr_get_richText_Public_get_Boolean_0;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeMethodInfoPtr_set_richText_Public_set_Void_Boolean_0;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeMethodInfoPtr_get_multiLine_Public_get_Boolean_0;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeMethodInfoPtr_get_asteriskChar_Public_get_Char_0;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeMethodInfoPtr_set_asteriskChar_Public_set_Void_Char_0;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeMethodInfoPtr_get_wasCanceled_Public_get_Boolean_0;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeMethodInfoPtr_ClampStringPos_Protected_Void_byref_Int32_0;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeMethodInfoPtr_ClampCaretPos_Protected_Void_byref_Int32_0;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeMethodInfoPtr_get_caretPositionInternal_Protected_get_Int32_0;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeMethodInfoPtr_set_caretPositionInternal_Protected_set_Void_Int32_0;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeMethodInfoPtr_get_stringPositionInternal_Protected_get_Int32_0;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeMethodInfoPtr_set_stringPositionInternal_Protected_set_Void_Int32_0;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeMethodInfoPtr_get_caretSelectPositionInternal_Protected_get_Int32_0;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeMethodInfoPtr_set_caretSelectPositionInternal_Protected_set_Void_Int32_0;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeMethodInfoPtr_get_stringSelectPositionInternal_Protected_get_Int32_0;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeMethodInfoPtr_set_stringSelectPositionInternal_Protected_set_Void_Int32_0;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeMethodInfoPtr_get_hasSelection_Private_get_Boolean_0;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeMethodInfoPtr_get_caretPosition_Public_get_Int32_0;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeMethodInfoPtr_set_caretPosition_Public_set_Void_Int32_0;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeMethodInfoPtr_get_selectionAnchorPosition_Public_get_Int32_0;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeMethodInfoPtr_set_selectionAnchorPosition_Public_set_Void_Int32_0;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeMethodInfoPtr_get_selectionFocusPosition_Public_get_Int32_0;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeMethodInfoPtr_set_selectionFocusPosition_Public_set_Void_Int32_0;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeMethodInfoPtr_get_stringPosition_Public_get_Int32_0;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeMethodInfoPtr_set_stringPosition_Public_set_Void_Int32_0;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeMethodInfoPtr_get_selectionStringAnchorPosition_Public_get_Int32_0;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeMethodInfoPtr_set_selectionStringAnchorPosition_Public_set_Void_Int32_0;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeMethodInfoPtr_get_selectionStringFocusPosition_Public_get_Int32_0;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeMethodInfoPtr_set_selectionStringFocusPosition_Public_set_Void_Int32_0;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeMethodInfoPtr_ON_TEXT_CHANGED_Private_Void_Object_0;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeMethodInfoPtr_CaretBlink_Private_IEnumerator_0;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeMethodInfoPtr_SetCaretVisible_Private_Void_0;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeMethodInfoPtr_SetCaretActive_Private_Void_0;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeMethodInfoPtr_OnFocus_Protected_Void_0;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeMethodInfoPtr_SelectAll_Protected_Void_0;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeMethodInfoPtr_MoveTextEnd_Public_Void_Boolean_0;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeMethodInfoPtr_MoveTextStart_Public_Void_Boolean_0;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeMethodInfoPtr_MoveToEndOfLine_Public_Void_Boolean_Boolean_0;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeMethodInfoPtr_MoveToStartOfLine_Public_Void_Boolean_Boolean_0;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeMethodInfoPtr_get_clipboard_Private_Static_get_String_0;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeMethodInfoPtr_set_clipboard_Private_Static_set_Void_String_0;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeMethodInfoPtr_InPlaceEditing_Private_Boolean_0;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStringPositionFromKeyboard_Private_Void_0;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeMethodInfoPtr_MayDrag_Private_Boolean_PointerEventData_0;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeMethodInfoPtr_MouseDragOutsideRect_Private_IEnumerator_PointerEventData_0;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeMethodInfoPtr_OnEndDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeMethodInfoPtr_KeyPressed_Protected_EditState_Event_0;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeMethodInfoPtr_IsValidChar_Protected_Virtual_New_Boolean_Char_0;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEvent_Public_Void_Event_0;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdateSelected_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeMethodInfoPtr_OnScroll_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeMethodInfoPtr_GetScrollPositionRelativeToViewport_Private_Single_0;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectedString_Private_String_0;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeMethodInfoPtr_FindNextWordBegin_Private_Int32_0;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeMethodInfoPtr_MoveRight_Private_Void_Boolean_Boolean_0;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeMethodInfoPtr_FindPrevWordBegin_Private_Int32_0;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeMethodInfoPtr_MoveLeft_Private_Void_Boolean_Boolean_0;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeMethodInfoPtr_LineUpCharacterPosition_Private_Int32_Int32_Boolean_0;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeMethodInfoPtr_LineDownCharacterPosition_Private_Int32_Int32_Boolean_0;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeMethodInfoPtr_PageUpCharacterPosition_Private_Int32_Int32_Boolean_0;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeMethodInfoPtr_PageDownCharacterPosition_Private_Int32_Int32_Boolean_0;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeMethodInfoPtr_MoveDown_Private_Void_Boolean_0;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeMethodInfoPtr_MoveDown_Private_Void_Boolean_Boolean_0;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeMethodInfoPtr_MoveUp_Private_Void_Boolean_0;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeMethodInfoPtr_MoveUp_Private_Void_Boolean_Boolean_0;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeMethodInfoPtr_MovePageUp_Private_Void_Boolean_0;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeMethodInfoPtr_MovePageUp_Private_Void_Boolean_Boolean_0;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeMethodInfoPtr_MovePageDown_Private_Void_Boolean_0;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeMethodInfoPtr_MovePageDown_Private_Void_Boolean_Boolean_0;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Private_Void_0;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeMethodInfoPtr_DeleteKey_Private_Void_0;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeMethodInfoPtr_Backspace_Private_Void_0;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeMethodInfoPtr_Append_Protected_Virtual_New_Void_String_0;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeMethodInfoPtr_Append_Protected_Virtual_New_Void_Char_0;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Private_Void_Char_0;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTouchKeyboardFromEditChanges_Private_Void_0;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr_SendOnValueChangedAndUpdateLabel_Private_Void_0;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeMethodInfoPtr_SendOnValueChanged_Private_Void_0;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr_SendOnEndEdit_Protected_Void_0;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeMethodInfoPtr_SendOnSubmit_Protected_Void_0;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeMethodInfoPtr_SendOnFocus_Protected_Void_0;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeMethodInfoPtr_SendOnFocusLost_Protected_Void_0;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeMethodInfoPtr_SendOnTextSelection_Protected_Void_0;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeMethodInfoPtr_SendOnEndTextSelection_Protected_Void_0;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeMethodInfoPtr_SendTouchScreenKeyboardStatusChanged_Protected_Void_0;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLabel_Protected_Void_0;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScrollbar_Private_Void_0;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeMethodInfoPtr_OnScrollbarValueChange_Private_Void_Single_0;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaskRegions_Private_Void_0;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr_AdjustTextPositionRelativeToViewport_Private_Void_Single_0;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeMethodInfoPtr_GetCaretPositionFromStringIndex_Private_Int32_Int32_0;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeMethodInfoPtr_GetMinCaretPositionFromStringIndex_Private_Int32_Int32_0;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxCaretPositionFromStringIndex_Private_Int32_Int32_0;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeMethodInfoPtr_GetStringIndexFromCaretPosition_Private_Int32_Int32_0;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeMethodInfoPtr_ForceLabelUpdate_Public_Void_0;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeMethodInfoPtr_MarkGeometryAsDirty_Private_Void_0;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGeometry_Private_Void_0;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr_AssignPositioningIfNeeded_Private_Void_0;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr_OnFillVBO_Private_Void_Mesh_0;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeMethodInfoPtr_GenerateCaret_Private_Void_VertexHelper_Vector2_0;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeMethodInfoPtr_CreateCursorVerts_Private_Void_0;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeMethodInfoPtr_GenerateHightlight_Private_Void_VertexHelper_Vector2_0;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeMethodInfoPtr_AdjustRectTransformRelativeToViewport_Private_Void_Vector2_Single_Boolean_0;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Protected_Char_String_Int32_Char_0;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeMethodInfoPtr_ActivateInputField_Public_Void_0;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeMethodInfoPtr_ActivateInputFieldInternal_Private_Void_0;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeMethodInfoPtr_OnControlClick_Public_Void_0;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseSelection_Public_Void_0;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateInputField_Public_Void_Boolean_0;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeMethodInfoPtr_EnforceContentType_Private_Void_0;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr_SetTextComponentWrapMode_Private_Void_0;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeMethodInfoPtr_SetTextComponentRichTextMode_Private_Void_0;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeMethodInfoPtr_SetToCustomIfContentTypeIsNot_Private_Void_Il2CppStructArray_1_ContentType_0;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeMethodInfoPtr_SetToCustom_Private_Void_0;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeMethodInfoPtr_SetToCustom_Private_Void_CharacterValidation_0;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalPointSize_Public_Void_Single_0;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalFontAsset_Public_Void_TMP_FontAsset_0;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0;

		// Token: 0x0200008F RID: 143
		public enum ContentType
		{
			// Token: 0x04000C08 RID: 3080
			Standard,
			// Token: 0x04000C09 RID: 3081
			Autocorrected,
			// Token: 0x04000C0A RID: 3082
			IntegerNumber,
			// Token: 0x04000C0B RID: 3083
			DecimalNumber,
			// Token: 0x04000C0C RID: 3084
			Alphanumeric,
			// Token: 0x04000C0D RID: 3085
			Name,
			// Token: 0x04000C0E RID: 3086
			EmailAddress,
			// Token: 0x04000C0F RID: 3087
			Password,
			// Token: 0x04000C10 RID: 3088
			Pin,
			// Token: 0x04000C11 RID: 3089
			Custom
		}

		// Token: 0x02000090 RID: 144
		public enum InputType
		{
			// Token: 0x04000C13 RID: 3091
			Standard,
			// Token: 0x04000C14 RID: 3092
			AutoCorrect,
			// Token: 0x04000C15 RID: 3093
			Password
		}

		// Token: 0x02000091 RID: 145
		public enum CharacterValidation
		{
			// Token: 0x04000C17 RID: 3095
			None,
			// Token: 0x04000C18 RID: 3096
			Digit,
			// Token: 0x04000C19 RID: 3097
			Integer,
			// Token: 0x04000C1A RID: 3098
			Decimal,
			// Token: 0x04000C1B RID: 3099
			Alphanumeric,
			// Token: 0x04000C1C RID: 3100
			Name,
			// Token: 0x04000C1D RID: 3101
			Regex,
			// Token: 0x04000C1E RID: 3102
			EmailAddress,
			// Token: 0x04000C1F RID: 3103
			CustomValidator
		}

		// Token: 0x02000092 RID: 146
		public enum LineType
		{
			// Token: 0x04000C21 RID: 3105
			SingleLine,
			// Token: 0x04000C22 RID: 3106
			MultiLineSubmit,
			// Token: 0x04000C23 RID: 3107
			MultiLineNewline
		}

		// Token: 0x02000093 RID: 147
		public sealed class OnValidateInput : MulticastDelegate
		{
			// Token: 0x06000F58 RID: 3928 RVA: 0x0003D344 File Offset: 0x0003B544
			// Note: this type is marked as 'beforefieldinit'.
			static OnValidateInput()
			{
				Il2CppClassPointerStore<TMP_InputField.OnValidateInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "OnValidateInput");
				TMP_InputField.OnValidateInput.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField.OnValidateInput>.NativeClassPtr, 100664173);
				TMP_InputField.OnValidateInput.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Char_String_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField.OnValidateInput>.NativeClassPtr, 100664174);
				TMP_InputField.OnValidateInput.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int32_Char_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField.OnValidateInput>.NativeClassPtr, 100664175);
				TMP_InputField.OnValidateInput.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Char_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField.OnValidateInput>.NativeClassPtr, 100664176);
			}

			// Token: 0x06000F59 RID: 3929 RVA: 0x0003D3B8 File Offset: 0x0003B5B8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1041565, RefRangeEnd = 1041568, XrefRangeStart = 1041561, XrefRangeEnd = 1041565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnValidateInput(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_InputField.OnValidateInput>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.OnValidateInput.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F5A RID: 3930 RVA: 0x0003D414 File Offset: 0x0003B614
			[CallerCount(0)]
			public unsafe char Invoke(string text, int charIndex, char addedChar)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addedChar;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.OnValidateInput.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Char_String_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000F5B RID: 3931 RVA: 0x0003D480 File Offset: 0x0003B680
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041568, XrefRangeEnd = 1041575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addedChar;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.OnValidateInput.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int32_Char_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000F5C RID: 3932 RVA: 0x0003D514 File Offset: 0x0003B714
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041575, XrefRangeEnd = 1041577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe char EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.OnValidateInput.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Char_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000F5D RID: 3933 RVA: 0x000093E4 File Offset: 0x000075E4
			public OnValidateInput(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000F5E RID: 3934 RVA: 0x000093ED File Offset: 0x000075ED
			public static implicit operator TMP_InputField.OnValidateInput(Func<string, int, char, char> A_0)
			{
				return DelegateSupport.ConvertDelegate<TMP_InputField.OnValidateInput>(A_0);
			}

			// Token: 0x06000F5F RID: 3935 RVA: 0x000093F5 File Offset: 0x000075F5
			public static TMP_InputField.OnValidateInput operator +(TMP_InputField.OnValidateInput A_0, TMP_InputField.OnValidateInput A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<TMP_InputField.OnValidateInput>();
			}

			// Token: 0x06000F60 RID: 3936 RVA: 0x00009403 File Offset: 0x00007603
			public static TMP_InputField.OnValidateInput operator -(TMP_InputField.OnValidateInput A_0, TMP_InputField.OnValidateInput A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<TMP_InputField.OnValidateInput>();
				}
				return delegate2;
			}

			// Token: 0x04000C24 RID: 3108
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000C25 RID: 3109
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Char_String_Int32_Char_0;

			// Token: 0x04000C26 RID: 3110
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int32_Char_AsyncCallback_Object_0;

			// Token: 0x04000C27 RID: 3111
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Char_IAsyncResult_0;
		}

		// Token: 0x02000094 RID: 148
		[Serializable]
		public class SubmitEvent : UnityEvent<string>
		{
			// Token: 0x06000F61 RID: 3937 RVA: 0x00009414 File Offset: 0x00007614
			// Note: this type is marked as 'beforefieldinit'.
			static SubmitEvent()
			{
				Il2CppClassPointerStore<TMP_InputField.SubmitEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "SubmitEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_InputField.SubmitEvent>.NativeClassPtr);
				TMP_InputField.SubmitEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField.SubmitEvent>.NativeClassPtr, 100664177);
			}

			// Token: 0x06000F62 RID: 3938 RVA: 0x0003D564 File Offset: 0x0003B764
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1041580, RefRangeEnd = 1041582, XrefRangeStart = 1041577, XrefRangeEnd = 1041580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SubmitEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_InputField.SubmitEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.SubmitEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F63 RID: 3939 RVA: 0x00009448 File Offset: 0x00007648
			public SubmitEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000C28 RID: 3112
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000095 RID: 149
		[Serializable]
		public class OnChangeEvent : UnityEvent<string>
		{
			// Token: 0x06000F64 RID: 3940 RVA: 0x00009451 File Offset: 0x00007651
			// Note: this type is marked as 'beforefieldinit'.
			static OnChangeEvent()
			{
				Il2CppClassPointerStore<TMP_InputField.OnChangeEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "OnChangeEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_InputField.OnChangeEvent>.NativeClassPtr);
				TMP_InputField.OnChangeEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField.OnChangeEvent>.NativeClassPtr, 100664178);
			}

			// Token: 0x06000F65 RID: 3941 RVA: 0x0003D5A0 File Offset: 0x0003B7A0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1041585, RefRangeEnd = 1041586, XrefRangeStart = 1041582, XrefRangeEnd = 1041585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnChangeEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_InputField.OnChangeEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.OnChangeEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F66 RID: 3942 RVA: 0x00009485 File Offset: 0x00007685
			public OnChangeEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000C29 RID: 3113
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000096 RID: 150
		[Serializable]
		public class SelectionEvent : UnityEvent<string>
		{
			// Token: 0x06000F67 RID: 3943 RVA: 0x0000948E File Offset: 0x0000768E
			// Note: this type is marked as 'beforefieldinit'.
			static SelectionEvent()
			{
				Il2CppClassPointerStore<TMP_InputField.SelectionEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "SelectionEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_InputField.SelectionEvent>.NativeClassPtr);
				TMP_InputField.SelectionEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField.SelectionEvent>.NativeClassPtr, 100664179);
			}

			// Token: 0x06000F68 RID: 3944 RVA: 0x0003D5DC File Offset: 0x0003B7DC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1041589, RefRangeEnd = 1041591, XrefRangeStart = 1041586, XrefRangeEnd = 1041589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SelectionEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_InputField.SelectionEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.SelectionEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F69 RID: 3945 RVA: 0x000094C2 File Offset: 0x000076C2
			public SelectionEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000C2A RID: 3114
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000097 RID: 151
		[Serializable]
		public class TextSelectionEvent : UnityEvent<string, int, int>
		{
			// Token: 0x06000F6A RID: 3946 RVA: 0x000094CB File Offset: 0x000076CB
			// Note: this type is marked as 'beforefieldinit'.
			static TextSelectionEvent()
			{
				Il2CppClassPointerStore<TMP_InputField.TextSelectionEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "TextSelectionEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_InputField.TextSelectionEvent>.NativeClassPtr);
				TMP_InputField.TextSelectionEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField.TextSelectionEvent>.NativeClassPtr, 100664180);
			}

			// Token: 0x06000F6B RID: 3947 RVA: 0x0003D618 File Offset: 0x0003B818
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1041594, RefRangeEnd = 1041596, XrefRangeStart = 1041591, XrefRangeEnd = 1041594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TextSelectionEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_InputField.TextSelectionEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.TextSelectionEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F6C RID: 3948 RVA: 0x000094FF File Offset: 0x000076FF
			public TextSelectionEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000C2B RID: 3115
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000098 RID: 152
		[Serializable]
		public class TouchScreenKeyboardEvent : UnityEvent<TouchScreenKeyboard.Status>
		{
			// Token: 0x06000F6D RID: 3949 RVA: 0x00009508 File Offset: 0x00007708
			// Note: this type is marked as 'beforefieldinit'.
			static TouchScreenKeyboardEvent()
			{
				Il2CppClassPointerStore<TMP_InputField.TouchScreenKeyboardEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "TouchScreenKeyboardEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_InputField.TouchScreenKeyboardEvent>.NativeClassPtr);
				TMP_InputField.TouchScreenKeyboardEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField.TouchScreenKeyboardEvent>.NativeClassPtr, 100664181);
			}

			// Token: 0x06000F6E RID: 3950 RVA: 0x0003D654 File Offset: 0x0003B854
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1041599, RefRangeEnd = 1041600, XrefRangeStart = 1041596, XrefRangeEnd = 1041599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TouchScreenKeyboardEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_InputField.TouchScreenKeyboardEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField.TouchScreenKeyboardEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F6F RID: 3951 RVA: 0x0000953C File Offset: 0x0000773C
			public TouchScreenKeyboardEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000C2C RID: 3116
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000099 RID: 153
		public enum EditState
		{
			// Token: 0x04000C2E RID: 3118
			Continue,
			// Token: 0x04000C2F RID: 3119
			Finish
		}

		// Token: 0x0200009A RID: 154
		[ObfuscatedName("TMPro.TMP_InputField+<CaretBlink>d__276")]
		public sealed class _CaretBlink_d__276 : global::Il2CppSystem.Object
		{
			// Token: 0x06000F70 RID: 3952 RVA: 0x0003D690 File Offset: 0x0003B890
			// Note: this type is marked as 'beforefieldinit'.
			static _CaretBlink_d__276()
			{
				Il2CppClassPointerStore<TMP_InputField._CaretBlink_d__276>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "<CaretBlink>d__276");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_InputField._CaretBlink_d__276>.NativeClassPtr);
				TMP_InputField._CaretBlink_d__276.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField._CaretBlink_d__276>.NativeClassPtr, "<>1__state");
				TMP_InputField._CaretBlink_d__276.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField._CaretBlink_d__276>.NativeClassPtr, "<>2__current");
				TMP_InputField._CaretBlink_d__276.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField._CaretBlink_d__276>.NativeClassPtr, "<>4__this");
				TMP_InputField._CaretBlink_d__276.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField._CaretBlink_d__276>.NativeClassPtr, 100664182);
				TMP_InputField._CaretBlink_d__276.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField._CaretBlink_d__276>.NativeClassPtr, 100664183);
				TMP_InputField._CaretBlink_d__276.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField._CaretBlink_d__276>.NativeClassPtr, 100664184);
				TMP_InputField._CaretBlink_d__276.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField._CaretBlink_d__276>.NativeClassPtr, 100664185);
				TMP_InputField._CaretBlink_d__276.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField._CaretBlink_d__276>.NativeClassPtr, 100664186);
				TMP_InputField._CaretBlink_d__276.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField._CaretBlink_d__276>.NativeClassPtr, 100664187);
			}

			// Token: 0x06000F71 RID: 3953 RVA: 0x0003D770 File Offset: 0x0003B970
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CaretBlink_d__276(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_InputField._CaretBlink_d__276>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField._CaretBlink_d__276.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000F72 RID: 3954 RVA: 0x0003D7B8 File Offset: 0x0003B9B8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField._CaretBlink_d__276.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F73 RID: 3955 RVA: 0x0003D7EC File Offset: 0x0003B9EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041600, XrefRangeEnd = 1041605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField._CaretBlink_d__276.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170005A2 RID: 1442
			// (get) Token: 0x06000F74 RID: 3956 RVA: 0x0003D828 File Offset: 0x0003BA28
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField._CaretBlink_d__276.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000F75 RID: 3957 RVA: 0x0003D868 File Offset: 0x0003BA68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041605, XrefRangeEnd = 1041610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField._CaretBlink_d__276.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005A3 RID: 1443
			// (get) Token: 0x06000F76 RID: 3958 RVA: 0x0003D89C File Offset: 0x0003BA9C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField._CaretBlink_d__276.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000F77 RID: 3959 RVA: 0x00009545 File Offset: 0x00007745
			public _CaretBlink_d__276(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700059F RID: 1439
			// (get) Token: 0x06000F78 RID: 3960 RVA: 0x0003D8DC File Offset: 0x0003BADC
			// (set) Token: 0x06000F79 RID: 3961 RVA: 0x0000954E File Offset: 0x0000774E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._CaretBlink_d__276.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._CaretBlink_d__276.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005A0 RID: 1440
			// (get) Token: 0x06000F7A RID: 3962 RVA: 0x0003D904 File Offset: 0x0003BB04
			// (set) Token: 0x06000F7B RID: 3963 RVA: 0x00009569 File Offset: 0x00007769
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._CaretBlink_d__276.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._CaretBlink_d__276.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005A1 RID: 1441
			// (get) Token: 0x06000F7C RID: 3964 RVA: 0x0003D934 File Offset: 0x0003BB34
			// (set) Token: 0x06000F7D RID: 3965 RVA: 0x00009588 File Offset: 0x00007788
			public unsafe TMP_InputField __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._CaretBlink_d__276.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._CaretBlink_d__276.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C30 RID: 3120
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000C31 RID: 3121
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000C32 RID: 3122
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000C33 RID: 3123
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000C34 RID: 3124
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000C35 RID: 3125
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000C36 RID: 3126
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000C37 RID: 3127
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000C38 RID: 3128
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200009B RID: 155
		[ObfuscatedName("TMPro.TMP_InputField+<MouseDragOutsideRect>d__294")]
		public sealed class _MouseDragOutsideRect_d__294 : global::Il2CppSystem.Object
		{
			// Token: 0x06000F7E RID: 3966 RVA: 0x0003D964 File Offset: 0x0003BB64
			// Note: this type is marked as 'beforefieldinit'.
			static _MouseDragOutsideRect_d__294()
			{
				Il2CppClassPointerStore<TMP_InputField._MouseDragOutsideRect_d__294>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_InputField>.NativeClassPtr, "<MouseDragOutsideRect>d__294");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_InputField._MouseDragOutsideRect_d__294>.NativeClassPtr);
				TMP_InputField._MouseDragOutsideRect_d__294.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField._MouseDragOutsideRect_d__294>.NativeClassPtr, "<>1__state");
				TMP_InputField._MouseDragOutsideRect_d__294.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField._MouseDragOutsideRect_d__294>.NativeClassPtr, "<>2__current");
				TMP_InputField._MouseDragOutsideRect_d__294.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField._MouseDragOutsideRect_d__294>.NativeClassPtr, "<>4__this");
				TMP_InputField._MouseDragOutsideRect_d__294.NativeFieldInfoPtr_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_InputField._MouseDragOutsideRect_d__294>.NativeClassPtr, "eventData");
				TMP_InputField._MouseDragOutsideRect_d__294.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField._MouseDragOutsideRect_d__294>.NativeClassPtr, 100664188);
				TMP_InputField._MouseDragOutsideRect_d__294.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField._MouseDragOutsideRect_d__294>.NativeClassPtr, 100664189);
				TMP_InputField._MouseDragOutsideRect_d__294.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField._MouseDragOutsideRect_d__294>.NativeClassPtr, 100664190);
				TMP_InputField._MouseDragOutsideRect_d__294.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField._MouseDragOutsideRect_d__294>.NativeClassPtr, 100664191);
				TMP_InputField._MouseDragOutsideRect_d__294.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField._MouseDragOutsideRect_d__294>.NativeClassPtr, 100664192);
				TMP_InputField._MouseDragOutsideRect_d__294.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputField._MouseDragOutsideRect_d__294>.NativeClassPtr, 100664193);
			}

			// Token: 0x06000F7F RID: 3967 RVA: 0x0003DA58 File Offset: 0x0003BC58
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MouseDragOutsideRect_d__294(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_InputField._MouseDragOutsideRect_d__294>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField._MouseDragOutsideRect_d__294.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000F80 RID: 3968 RVA: 0x0003DAA0 File Offset: 0x0003BCA0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField._MouseDragOutsideRect_d__294.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F81 RID: 3969 RVA: 0x0003DAD4 File Offset: 0x0003BCD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041610, XrefRangeEnd = 1041634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField._MouseDragOutsideRect_d__294.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170005A8 RID: 1448
			// (get) Token: 0x06000F82 RID: 3970 RVA: 0x0003DB10 File Offset: 0x0003BD10
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField._MouseDragOutsideRect_d__294.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000F83 RID: 3971 RVA: 0x0003DB50 File Offset: 0x0003BD50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1041634, XrefRangeEnd = 1041639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField._MouseDragOutsideRect_d__294.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005A9 RID: 1449
			// (get) Token: 0x06000F84 RID: 3972 RVA: 0x0003DB84 File Offset: 0x0003BD84
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_InputField._MouseDragOutsideRect_d__294.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000F85 RID: 3973 RVA: 0x000095A7 File Offset: 0x000077A7
			public _MouseDragOutsideRect_d__294(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005A4 RID: 1444
			// (get) Token: 0x06000F86 RID: 3974 RVA: 0x0003DBC4 File Offset: 0x0003BDC4
			// (set) Token: 0x06000F87 RID: 3975 RVA: 0x000095B0 File Offset: 0x000077B0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._MouseDragOutsideRect_d__294.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._MouseDragOutsideRect_d__294.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005A5 RID: 1445
			// (get) Token: 0x06000F88 RID: 3976 RVA: 0x0003DBEC File Offset: 0x0003BDEC
			// (set) Token: 0x06000F89 RID: 3977 RVA: 0x000095CB File Offset: 0x000077CB
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._MouseDragOutsideRect_d__294.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._MouseDragOutsideRect_d__294.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005A6 RID: 1446
			// (get) Token: 0x06000F8A RID: 3978 RVA: 0x0003DC1C File Offset: 0x0003BE1C
			// (set) Token: 0x06000F8B RID: 3979 RVA: 0x000095EA File Offset: 0x000077EA
			public unsafe TMP_InputField __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._MouseDragOutsideRect_d__294.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._MouseDragOutsideRect_d__294.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005A7 RID: 1447
			// (get) Token: 0x06000F8C RID: 3980 RVA: 0x0003DC4C File Offset: 0x0003BE4C
			// (set) Token: 0x06000F8D RID: 3981 RVA: 0x00009609 File Offset: 0x00007809
			public unsafe PointerEventData eventData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._MouseDragOutsideRect_d__294.NativeFieldInfoPtr_eventData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_InputField._MouseDragOutsideRect_d__294.NativeFieldInfoPtr_eventData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000C39 RID: 3129
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000C3A RID: 3130
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000C3B RID: 3131
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000C3C RID: 3132
			private static readonly IntPtr NativeFieldInfoPtr_eventData;

			// Token: 0x04000C3D RID: 3133
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000C3E RID: 3134
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000C3F RID: 3135
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000C40 RID: 3136
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000C41 RID: 3137
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000C42 RID: 3138
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

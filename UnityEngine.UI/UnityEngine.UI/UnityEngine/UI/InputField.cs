using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000019 RID: 25
	public class InputField : Selectable
	{
		// Token: 0x0600026F RID: 623 RVA: 0x0001087C File Offset: 0x0000EA7C
		// Note: this type is marked as 'beforefieldinit'.
		static InputField()
		{
			Il2CppClassPointerStore<InputField>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "InputField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputField>.NativeClassPtr);
			InputField.NativeFieldInfoPtr_m_Keyboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_Keyboard");
			InputField.NativeFieldInfoPtr_kSeparators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "kSeparators");
			InputField.NativeFieldInfoPtr_s_IsQuestDevice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "s_IsQuestDevice");
			InputField.NativeFieldInfoPtr_m_TextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_TextComponent");
			InputField.NativeFieldInfoPtr_m_Placeholder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_Placeholder");
			InputField.NativeFieldInfoPtr_m_ContentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_ContentType");
			InputField.NativeFieldInfoPtr_m_InputType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_InputType");
			InputField.NativeFieldInfoPtr_m_AsteriskChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_AsteriskChar");
			InputField.NativeFieldInfoPtr_m_KeyboardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_KeyboardType");
			InputField.NativeFieldInfoPtr_m_LineType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_LineType");
			InputField.NativeFieldInfoPtr_m_HideMobileInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_HideMobileInput");
			InputField.NativeFieldInfoPtr_m_CharacterValidation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_CharacterValidation");
			InputField.NativeFieldInfoPtr_m_CharacterLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_CharacterLimit");
			InputField.NativeFieldInfoPtr_m_OnSubmit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_OnSubmit");
			InputField.NativeFieldInfoPtr_m_OnDidEndEdit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_OnDidEndEdit");
			InputField.NativeFieldInfoPtr_m_OnValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_OnValueChanged");
			InputField.NativeFieldInfoPtr_m_OnValidateInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_OnValidateInput");
			InputField.NativeFieldInfoPtr_m_CaretColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_CaretColor");
			InputField.NativeFieldInfoPtr_m_CustomCaretColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_CustomCaretColor");
			InputField.NativeFieldInfoPtr_m_SelectionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_SelectionColor");
			InputField.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_Text");
			InputField.NativeFieldInfoPtr_m_CaretBlinkRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_CaretBlinkRate");
			InputField.NativeFieldInfoPtr_m_CaretWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_CaretWidth");
			InputField.NativeFieldInfoPtr_m_ReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_ReadOnly");
			InputField.NativeFieldInfoPtr_m_ShouldActivateOnSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_ShouldActivateOnSelect");
			InputField.NativeFieldInfoPtr_m_CaretPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_CaretPosition");
			InputField.NativeFieldInfoPtr_m_CaretSelectPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_CaretSelectPosition");
			InputField.NativeFieldInfoPtr_caretRectTrans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "caretRectTrans");
			InputField.NativeFieldInfoPtr_m_CursorVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_CursorVerts");
			InputField.NativeFieldInfoPtr_m_InputTextCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_InputTextCache");
			InputField.NativeFieldInfoPtr_m_CachedInputRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_CachedInputRenderer");
			InputField.NativeFieldInfoPtr_m_PreventFontCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_PreventFontCallback");
			InputField.NativeFieldInfoPtr_m_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_Mesh");
			InputField.NativeFieldInfoPtr_m_AllowInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_AllowInput");
			InputField.NativeFieldInfoPtr_m_ShouldActivateNextUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_ShouldActivateNextUpdate");
			InputField.NativeFieldInfoPtr_m_UpdateDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_UpdateDrag");
			InputField.NativeFieldInfoPtr_m_DragPositionOutOfBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_DragPositionOutOfBounds");
			InputField.NativeFieldInfoPtr_kHScrollSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "kHScrollSpeed");
			InputField.NativeFieldInfoPtr_kVScrollSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "kVScrollSpeed");
			InputField.NativeFieldInfoPtr_m_CaretVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_CaretVisible");
			InputField.NativeFieldInfoPtr_m_BlinkCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_BlinkCoroutine");
			InputField.NativeFieldInfoPtr_m_BlinkStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_BlinkStartTime");
			InputField.NativeFieldInfoPtr_m_DrawStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_DrawStart");
			InputField.NativeFieldInfoPtr_m_DrawEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_DrawEnd");
			InputField.NativeFieldInfoPtr_m_DragCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_DragCoroutine");
			InputField.NativeFieldInfoPtr_m_OriginalText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_OriginalText");
			InputField.NativeFieldInfoPtr_m_WasCanceled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_WasCanceled");
			InputField.NativeFieldInfoPtr_m_HasDoneFocusTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_HasDoneFocusTransition");
			InputField.NativeFieldInfoPtr_m_WaitForSecondsRealtime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_WaitForSecondsRealtime");
			InputField.NativeFieldInfoPtr_m_TouchKeyboardAllowsInPlaceEditing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_TouchKeyboardAllowsInPlaceEditing");
			InputField.NativeFieldInfoPtr_m_IsCompositionActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_IsCompositionActive");
			InputField.NativeFieldInfoPtr_kEmailSpecialCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "kEmailSpecialCharacters");
			InputField.NativeFieldInfoPtr_kOculusQuestDeviceModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "kOculusQuestDeviceModel");
			InputField.NativeFieldInfoPtr_m_ProcessingEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "m_ProcessingEvent");
			InputField.NativeFieldInfoPtr_k_MaxTextLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField>.NativeClassPtr, "k_MaxTextLength");
			InputField.NativeMethodInfoPtr_get_input_Private_get_BaseInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663691);
			InputField.NativeMethodInfoPtr_get_compositionString_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663692);
			InputField.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663693);
			InputField.NativeMethodInfoPtr_get_mesh_Protected_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663694);
			InputField.NativeMethodInfoPtr_get_cachedInputTextGenerator_Protected_get_TextGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663695);
			InputField.NativeMethodInfoPtr_set_shouldHideMobileInput_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663696);
			InputField.NativeMethodInfoPtr_get_shouldHideMobileInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663697);
			InputField.NativeMethodInfoPtr_set_shouldActivateOnSelect_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663698);
			InputField.NativeMethodInfoPtr_get_shouldActivateOnSelect_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663699);
			InputField.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663700);
			InputField.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663701);
			InputField.NativeMethodInfoPtr_SetTextWithoutNotify_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663702);
			InputField.NativeMethodInfoPtr_SetText_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663703);
			InputField.NativeMethodInfoPtr_get_isFocused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663704);
			InputField.NativeMethodInfoPtr_get_caretBlinkRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663705);
			InputField.NativeMethodInfoPtr_set_caretBlinkRate_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663706);
			InputField.NativeMethodInfoPtr_get_caretWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663707);
			InputField.NativeMethodInfoPtr_set_caretWidth_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663708);
			InputField.NativeMethodInfoPtr_get_textComponent_Public_get_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663709);
			InputField.NativeMethodInfoPtr_set_textComponent_Public_set_Void_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663710);
			InputField.NativeMethodInfoPtr_get_placeholder_Public_get_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663711);
			InputField.NativeMethodInfoPtr_set_placeholder_Public_set_Void_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663712);
			InputField.NativeMethodInfoPtr_get_caretColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663713);
			InputField.NativeMethodInfoPtr_set_caretColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663714);
			InputField.NativeMethodInfoPtr_get_customCaretColor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663715);
			InputField.NativeMethodInfoPtr_set_customCaretColor_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663716);
			InputField.NativeMethodInfoPtr_get_selectionColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663717);
			InputField.NativeMethodInfoPtr_set_selectionColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663718);
			InputField.NativeMethodInfoPtr_get_onEndEdit_Public_get_EndEditEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663719);
			InputField.NativeMethodInfoPtr_set_onEndEdit_Public_set_Void_EndEditEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663720);
			InputField.NativeMethodInfoPtr_get_onSubmit_Public_get_SubmitEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663721);
			InputField.NativeMethodInfoPtr_set_onSubmit_Public_set_Void_SubmitEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663722);
			InputField.NativeMethodInfoPtr_get_onValueChange_Public_get_OnChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663723);
			InputField.NativeMethodInfoPtr_set_onValueChange_Public_set_Void_OnChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663724);
			InputField.NativeMethodInfoPtr_get_onValueChanged_Public_get_OnChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663725);
			InputField.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_OnChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663726);
			InputField.NativeMethodInfoPtr_get_onValidateInput_Public_get_OnValidateInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663727);
			InputField.NativeMethodInfoPtr_set_onValidateInput_Public_set_Void_OnValidateInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663728);
			InputField.NativeMethodInfoPtr_get_characterLimit_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663729);
			InputField.NativeMethodInfoPtr_set_characterLimit_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663730);
			InputField.NativeMethodInfoPtr_get_contentType_Public_get_ContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663731);
			InputField.NativeMethodInfoPtr_set_contentType_Public_set_Void_ContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663732);
			InputField.NativeMethodInfoPtr_get_lineType_Public_get_LineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663733);
			InputField.NativeMethodInfoPtr_set_lineType_Public_set_Void_LineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663734);
			InputField.NativeMethodInfoPtr_get_inputType_Public_get_InputType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663735);
			InputField.NativeMethodInfoPtr_set_inputType_Public_set_Void_InputType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663736);
			InputField.NativeMethodInfoPtr_get_touchScreenKeyboard_Public_get_TouchScreenKeyboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663737);
			InputField.NativeMethodInfoPtr_get_keyboardType_Public_get_TouchScreenKeyboardType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663738);
			InputField.NativeMethodInfoPtr_set_keyboardType_Public_set_Void_TouchScreenKeyboardType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663739);
			InputField.NativeMethodInfoPtr_get_characterValidation_Public_get_CharacterValidation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663740);
			InputField.NativeMethodInfoPtr_set_characterValidation_Public_set_Void_CharacterValidation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663741);
			InputField.NativeMethodInfoPtr_get_readOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663742);
			InputField.NativeMethodInfoPtr_set_readOnly_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663743);
			InputField.NativeMethodInfoPtr_get_multiLine_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663744);
			InputField.NativeMethodInfoPtr_get_asteriskChar_Public_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663745);
			InputField.NativeMethodInfoPtr_set_asteriskChar_Public_set_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663746);
			InputField.NativeMethodInfoPtr_get_wasCanceled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663747);
			InputField.NativeMethodInfoPtr_ClampPos_Protected_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663748);
			InputField.NativeMethodInfoPtr_get_caretPositionInternal_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663749);
			InputField.NativeMethodInfoPtr_set_caretPositionInternal_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663750);
			InputField.NativeMethodInfoPtr_get_caretSelectPositionInternal_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663751);
			InputField.NativeMethodInfoPtr_set_caretSelectPositionInternal_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663752);
			InputField.NativeMethodInfoPtr_get_hasSelection_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663753);
			InputField.NativeMethodInfoPtr_get_caretPosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663754);
			InputField.NativeMethodInfoPtr_set_caretPosition_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663755);
			InputField.NativeMethodInfoPtr_get_selectionAnchorPosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663756);
			InputField.NativeMethodInfoPtr_set_selectionAnchorPosition_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663757);
			InputField.NativeMethodInfoPtr_get_selectionFocusPosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663758);
			InputField.NativeMethodInfoPtr_set_selectionFocusPosition_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663759);
			InputField.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663760);
			InputField.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663761);
			InputField.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663762);
			InputField.NativeMethodInfoPtr_CaretBlink_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663763);
			InputField.NativeMethodInfoPtr_SetCaretVisible_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663764);
			InputField.NativeMethodInfoPtr_SetCaretActive_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663765);
			InputField.NativeMethodInfoPtr_UpdateCaretMaterial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663766);
			InputField.NativeMethodInfoPtr_OnFocus_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663767);
			InputField.NativeMethodInfoPtr_SelectAll_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663768);
			InputField.NativeMethodInfoPtr_MoveTextEnd_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663769);
			InputField.NativeMethodInfoPtr_MoveTextStart_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663770);
			InputField.NativeMethodInfoPtr_get_clipboard_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663771);
			InputField.NativeMethodInfoPtr_set_clipboard_Private_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663772);
			InputField.NativeMethodInfoPtr_TouchScreenKeyboardShouldBeUsed_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663773);
			InputField.NativeMethodInfoPtr_InPlaceEditing_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663774);
			InputField.NativeMethodInfoPtr_InPlaceEditingChanged_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663775);
			InputField.NativeMethodInfoPtr_GetInternalSelection_Private_RangeInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663776);
			InputField.NativeMethodInfoPtr_UpdateKeyboardCaret_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663777);
			InputField.NativeMethodInfoPtr_UpdateCaretFromKeyboard_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663778);
			InputField.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663779);
			InputField.NativeMethodInfoPtr_ScreenToLocal_Public_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663780);
			InputField.NativeMethodInfoPtr_GetUnclampedCharacterLineFromPosition_Private_Int32_Vector2_TextGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663781);
			InputField.NativeMethodInfoPtr_GetCharacterIndexFromPosition_Protected_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663782);
			InputField.NativeMethodInfoPtr_MayDrag_Private_Boolean_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663783);
			InputField.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663784);
			InputField.NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663785);
			InputField.NativeMethodInfoPtr_MouseDragOutsideRect_Private_IEnumerator_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663786);
			InputField.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663787);
			InputField.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663788);
			InputField.NativeMethodInfoPtr_KeyPressed_Protected_EditState_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663789);
			InputField.NativeMethodInfoPtr_IsValidChar_Private_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663790);
			InputField.NativeMethodInfoPtr_ProcessEvent_Public_Void_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663791);
			InputField.NativeMethodInfoPtr_OnUpdateSelected_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663792);
			InputField.NativeMethodInfoPtr_GetSelectedString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663793);
			InputField.NativeMethodInfoPtr_FindtNextWordBegin_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663794);
			InputField.NativeMethodInfoPtr_MoveRight_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663795);
			InputField.NativeMethodInfoPtr_FindtPrevWordBegin_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663796);
			InputField.NativeMethodInfoPtr_MoveLeft_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663797);
			InputField.NativeMethodInfoPtr_DetermineCharacterLine_Private_Int32_Int32_TextGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663798);
			InputField.NativeMethodInfoPtr_LineUpCharacterPosition_Private_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663799);
			InputField.NativeMethodInfoPtr_LineDownCharacterPosition_Private_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663800);
			InputField.NativeMethodInfoPtr_MoveDown_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663801);
			InputField.NativeMethodInfoPtr_MoveDown_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663802);
			InputField.NativeMethodInfoPtr_MoveUp_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663803);
			InputField.NativeMethodInfoPtr_MoveUp_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663804);
			InputField.NativeMethodInfoPtr_Delete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663805);
			InputField.NativeMethodInfoPtr_ForwardSpace_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663806);
			InputField.NativeMethodInfoPtr_Backspace_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663807);
			InputField.NativeMethodInfoPtr_Insert_Private_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663808);
			InputField.NativeMethodInfoPtr_UpdateTouchKeyboardFromEditChanges_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663809);
			InputField.NativeMethodInfoPtr_SendOnValueChangedAndUpdateLabel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663810);
			InputField.NativeMethodInfoPtr_SendOnValueChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663811);
			InputField.NativeMethodInfoPtr_SendOnEndEdit_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663812);
			InputField.NativeMethodInfoPtr_SendOnSubmit_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663813);
			InputField.NativeMethodInfoPtr_Append_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663814);
			InputField.NativeMethodInfoPtr_Append_Protected_Virtual_New_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663815);
			InputField.NativeMethodInfoPtr_UpdateLabel_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663816);
			InputField.NativeMethodInfoPtr_IsSelectionVisible_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663817);
			InputField.NativeMethodInfoPtr_GetLineStartPosition_Private_Static_Int32_TextGenerator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663818);
			InputField.NativeMethodInfoPtr_GetLineEndPosition_Private_Static_Int32_TextGenerator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663819);
			InputField.NativeMethodInfoPtr_SetDrawRangeToContainCaretPosition_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663820);
			InputField.NativeMethodInfoPtr_ForceLabelUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663821);
			InputField.NativeMethodInfoPtr_MarkGeometryAsDirty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663822);
			InputField.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663823);
			InputField.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663824);
			InputField.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663825);
			InputField.NativeMethodInfoPtr_UpdateGeometry_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663826);
			InputField.NativeMethodInfoPtr_AssignPositioningIfNeeded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663827);
			InputField.NativeMethodInfoPtr_OnFillVBO_Private_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663828);
			InputField.NativeMethodInfoPtr_GenerateCaret_Private_Void_VertexHelper_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663829);
			InputField.NativeMethodInfoPtr_CreateCursorVerts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663830);
			InputField.NativeMethodInfoPtr_GenerateHighlight_Private_Void_VertexHelper_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663831);
			InputField.NativeMethodInfoPtr_Validate_Protected_Char_String_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663832);
			InputField.NativeMethodInfoPtr_ActivateInputField_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663833);
			InputField.NativeMethodInfoPtr_ActivateInputFieldInternal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663834);
			InputField.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663835);
			InputField.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663836);
			InputField.NativeMethodInfoPtr_DeactivateInputField_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663837);
			InputField.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663838);
			InputField.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663839);
			InputField.NativeMethodInfoPtr_EnforceContentType_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663840);
			InputField.NativeMethodInfoPtr_EnforceTextHOverflow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663841);
			InputField.NativeMethodInfoPtr_SetToCustomIfContentTypeIsNot_Private_Void_Il2CppStructArray_1_ContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663842);
			InputField.NativeMethodInfoPtr_SetToCustom_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663843);
			InputField.NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663844);
			InputField.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663845);
			InputField.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663846);
			InputField.NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663847);
			InputField.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663848);
			InputField.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663849);
			InputField.NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663850);
			InputField.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663851);
			InputField.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663852);
			InputField.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663853);
			InputField.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField>.NativeClassPtr, 100663855);
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000270 RID: 624 RVA: 0x000119C8 File Offset: 0x0000FBC8
		public unsafe BaseInput input
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1086111, RefRangeEnd = 1086121, XrefRangeStart = 1086093, XrefRangeEnd = 1086111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_input_Private_get_BaseInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInput>(intPtr3) : null;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00011A08 File Offset: 0x0000FC08
		public unsafe string compositionString
		{
			[CallerCount(88)]
			[CachedScanResults(RefRangeStart = 1086129, RefRangeEnd = 1086217, XrefRangeStart = 1086121, XrefRangeEnd = 1086129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_compositionString_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00011A40 File Offset: 0x0000FC40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1086255, RefRangeEnd = 1086256, XrefRangeStart = 1086217, XrefRangeEnd = 1086255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00011A7C File Offset: 0x0000FC7C
		public unsafe Mesh mesh
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1086265, RefRangeEnd = 1086269, XrefRangeStart = 1086256, XrefRangeEnd = 1086265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_mesh_Protected_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000274 RID: 628 RVA: 0x00011ABC File Offset: 0x0000FCBC
		public unsafe TextGenerator cachedInputTextGenerator
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 1086274, RefRangeEnd = 1086303, XrefRangeStart = 1086269, XrefRangeEnd = 1086274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_cachedInputTextGenerator_Protected_get_TextGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextGenerator>(intPtr3) : null;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00011B3C File Offset: 0x0000FD3C
		// (set) Token: 0x06000275 RID: 629 RVA: 0x00011AFC File Offset: 0x0000FCFC
		public unsafe bool shouldHideMobileInput
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1086310, RefRangeEnd = 1086311, XrefRangeStart = 1086306, XrefRangeEnd = 1086310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_shouldHideMobileInput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086303, XrefRangeEnd = 1086306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_shouldHideMobileInput_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000278 RID: 632 RVA: 0x00011BC4 File Offset: 0x0000FDC4
		// (set) Token: 0x06000277 RID: 631 RVA: 0x00011B78 File Offset: 0x0000FD78
		public unsafe virtual bool shouldActivateOnSelect
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086311, XrefRangeEnd = 1086312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_get_shouldActivateOnSelect_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_set_shouldActivateOnSelect_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00011C0C File Offset: 0x0000FE0C
		// (set) Token: 0x0600027A RID: 634 RVA: 0x00011C44 File Offset: 0x0000FE44
		public unsafe string text
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1086313, RefRangeEnd = 1086318, XrefRangeStart = 1086312, XrefRangeEnd = 1086313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00011C88 File Offset: 0x0000FE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086318, XrefRangeEnd = 1086319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextWithoutNotify(string input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_SetTextWithoutNotify_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00011CCC File Offset: 0x0000FECC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1086371, RefRangeEnd = 1086374, XrefRangeStart = 1086319, XrefRangeEnd = 1086371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_SetText_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00011D1C File Offset: 0x0000FF1C
		public unsafe bool isFocused
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_isFocused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600027E RID: 638 RVA: 0x00011D58 File Offset: 0x0000FF58
		// (set) Token: 0x0600027F RID: 639 RVA: 0x00011D94 File Offset: 0x0000FF94
		public unsafe float caretBlinkRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_caretBlinkRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086374, XrefRangeEnd = 1086378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_caretBlinkRate_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000280 RID: 640 RVA: 0x00011DD4 File Offset: 0x0000FFD4
		// (set) Token: 0x06000281 RID: 641 RVA: 0x00011E10 File Offset: 0x00010010
		public unsafe int caretWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_caretWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086378, XrefRangeEnd = 1086385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_caretWidth_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000282 RID: 642 RVA: 0x00011E50 File Offset: 0x00010050
		// (set) Token: 0x06000283 RID: 643 RVA: 0x00011E90 File Offset: 0x00010090
		public unsafe Text textComponent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_textComponent_Public_get_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Text>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1086430, RefRangeEnd = 1086431, XrefRangeStart = 1086385, XrefRangeEnd = 1086430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_textComponent_Public_set_Void_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000284 RID: 644 RVA: 0x00011ED4 File Offset: 0x000100D4
		// (set) Token: 0x06000285 RID: 645 RVA: 0x00011F14 File Offset: 0x00010114
		public unsafe Graphic placeholder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_placeholder_Public_get_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1086434, RefRangeEnd = 1086435, XrefRangeStart = 1086431, XrefRangeEnd = 1086434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_placeholder_Public_set_Void_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00011F58 File Offset: 0x00010158
		// (set) Token: 0x06000287 RID: 647 RVA: 0x00011F94 File Offset: 0x00010194
		public unsafe Color caretColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_caretColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086435, XrefRangeEnd = 1086440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_caretColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000288 RID: 648 RVA: 0x00011FD4 File Offset: 0x000101D4
		// (set) Token: 0x06000289 RID: 649 RVA: 0x00012010 File Offset: 0x00010210
		public unsafe bool customCaretColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_customCaretColor_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086440, XrefRangeEnd = 1086444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_customCaretColor_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600028A RID: 650 RVA: 0x00012050 File Offset: 0x00010250
		// (set) Token: 0x0600028B RID: 651 RVA: 0x0001208C File Offset: 0x0001028C
		public unsafe Color selectionColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_selectionColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086444, XrefRangeEnd = 1086449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_selectionColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600028C RID: 652 RVA: 0x000120CC File Offset: 0x000102CC
		// (set) Token: 0x0600028D RID: 653 RVA: 0x0001210C File Offset: 0x0001030C
		public unsafe InputField.EndEditEvent onEndEdit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_onEndEdit_Public_get_EndEditEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputField.EndEditEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086449, XrefRangeEnd = 1086452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_onEndEdit_Public_set_Void_EndEditEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600028E RID: 654 RVA: 0x00012150 File Offset: 0x00010350
		// (set) Token: 0x0600028F RID: 655 RVA: 0x00012190 File Offset: 0x00010390
		public unsafe InputField.SubmitEvent onSubmit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_onSubmit_Public_get_SubmitEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputField.SubmitEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086452, XrefRangeEnd = 1086455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_onSubmit_Public_set_Void_SubmitEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000290 RID: 656 RVA: 0x000121D4 File Offset: 0x000103D4
		// (set) Token: 0x06000291 RID: 657 RVA: 0x00012214 File Offset: 0x00010414
		public unsafe InputField.OnChangeEvent onValueChange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_onValueChange_Public_get_OnChangeEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputField.OnChangeEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086455, XrefRangeEnd = 1086458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_onValueChange_Public_set_Void_OnChangeEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000292 RID: 658 RVA: 0x00012258 File Offset: 0x00010458
		// (set) Token: 0x06000293 RID: 659 RVA: 0x00012298 File Offset: 0x00010498
		public unsafe InputField.OnChangeEvent onValueChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_onValueChanged_Public_get_OnChangeEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputField.OnChangeEvent>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_OnChangeEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000294 RID: 660 RVA: 0x000122DC File Offset: 0x000104DC
		// (set) Token: 0x06000295 RID: 661 RVA: 0x0001231C File Offset: 0x0001051C
		public unsafe InputField.OnValidateInput onValidateInput
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_onValidateInput_Public_get_OnValidateInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputField.OnValidateInput>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1086461, RefRangeEnd = 1086462, XrefRangeStart = 1086458, XrefRangeEnd = 1086461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_onValidateInput_Public_set_Void_OnValidateInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000296 RID: 662 RVA: 0x00012360 File Offset: 0x00010560
		// (set) Token: 0x06000297 RID: 663 RVA: 0x0001239C File Offset: 0x0001059C
		public unsafe int characterLimit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_characterLimit_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086462, XrefRangeEnd = 1086471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_characterLimit_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000298 RID: 664 RVA: 0x000123DC File Offset: 0x000105DC
		// (set) Token: 0x06000299 RID: 665 RVA: 0x00012418 File Offset: 0x00010618
		public unsafe InputField.ContentType contentType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_contentType_Public_get_ContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1086487, RefRangeEnd = 1086493, XrefRangeStart = 1086471, XrefRangeEnd = 1086487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_contentType_Public_set_Void_ContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00012458 File Offset: 0x00010658
		// (set) Token: 0x0600029B RID: 667 RVA: 0x00012494 File Offset: 0x00010694
		public unsafe InputField.LineType lineType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_lineType_Public_get_LineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1086502, RefRangeEnd = 1086504, XrefRangeStart = 1086493, XrefRangeEnd = 1086502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_lineType_Public_set_Void_LineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600029C RID: 668 RVA: 0x000124D4 File Offset: 0x000106D4
		// (set) Token: 0x0600029D RID: 669 RVA: 0x00012510 File Offset: 0x00010710
		public unsafe InputField.InputType inputType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_inputType_Public_get_InputType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086504, XrefRangeEnd = 1086508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_inputType_Public_set_Void_InputType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600029E RID: 670 RVA: 0x00012550 File Offset: 0x00010750
		public unsafe TouchScreenKeyboard touchScreenKeyboard
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_touchScreenKeyboard_Public_get_TouchScreenKeyboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TouchScreenKeyboard>(intPtr3) : null;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600029F RID: 671 RVA: 0x00012590 File Offset: 0x00010790
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x000125CC File Offset: 0x000107CC
		public unsafe TouchScreenKeyboardType keyboardType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_keyboardType_Public_get_TouchScreenKeyboardType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086508, XrefRangeEnd = 1086512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_keyboardType_Public_set_Void_TouchScreenKeyboardType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x0001260C File Offset: 0x0001080C
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x00012648 File Offset: 0x00010848
		public unsafe InputField.CharacterValidation characterValidation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_characterValidation_Public_get_CharacterValidation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086512, XrefRangeEnd = 1086516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_characterValidation_Public_set_Void_CharacterValidation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x00012688 File Offset: 0x00010888
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x000126C4 File Offset: 0x000108C4
		public unsafe bool readOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_readOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_readOnly_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00012704 File Offset: 0x00010904
		public unsafe bool multiLine
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_multiLine_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x00012740 File Offset: 0x00010940
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x0001277C File Offset: 0x0001097C
		public unsafe char asteriskChar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_asteriskChar_Public_get_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086516, XrefRangeEnd = 1086520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_asteriskChar_Public_set_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x000127BC File Offset: 0x000109BC
		public unsafe bool wasCanceled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_wasCanceled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x000127F8 File Offset: 0x000109F8
		[CallerCount(0)]
		public unsafe void ClampPos(ref int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_ClampPos_Protected_Void_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060002AA RID: 682 RVA: 0x00012838 File Offset: 0x00010A38
		// (set) Token: 0x060002AB RID: 683 RVA: 0x00012874 File Offset: 0x00010A74
		public unsafe int caretPositionInternal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086520, XrefRangeEnd = 1086521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_caretPositionInternal_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1086521, RefRangeEnd = 1086522, XrefRangeStart = 1086521, XrefRangeEnd = 1086521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_caretPositionInternal_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060002AC RID: 684 RVA: 0x000128B4 File Offset: 0x00010AB4
		// (set) Token: 0x060002AD RID: 685 RVA: 0x000128F0 File Offset: 0x00010AF0
		public unsafe int caretSelectPositionInternal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086522, XrefRangeEnd = 1086523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_caretSelectPositionInternal_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1086523, RefRangeEnd = 1086524, XrefRangeStart = 1086523, XrefRangeEnd = 1086523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_caretSelectPositionInternal_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060002AE RID: 686 RVA: 0x00012930 File Offset: 0x00010B30
		public new unsafe bool hasSelection
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1086526, RefRangeEnd = 1086530, XrefRangeStart = 1086524, XrefRangeEnd = 1086526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_hasSelection_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060002AF RID: 687 RVA: 0x0001296C File Offset: 0x00010B6C
		// (set) Token: 0x060002B0 RID: 688 RVA: 0x000129A8 File Offset: 0x00010BA8
		public unsafe int caretPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_caretPosition_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086530, XrefRangeEnd = 1086533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_caretPosition_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x000129E8 File Offset: 0x00010BE8
		// (set) Token: 0x060002B2 RID: 690 RVA: 0x00012A24 File Offset: 0x00010C24
		public unsafe int selectionAnchorPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_selectionAnchorPosition_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086533, XrefRangeEnd = 1086534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_selectionAnchorPosition_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x00012A64 File Offset: 0x00010C64
		// (set) Token: 0x060002B4 RID: 692 RVA: 0x00012AA0 File Offset: 0x00010CA0
		public unsafe int selectionFocusPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_selectionFocusPosition_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086534, XrefRangeEnd = 1086535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_selectionFocusPosition_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00012AE0 File Offset: 0x00010CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086535, XrefRangeEnd = 1086572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00012B1C File Offset: 0x00010D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086572, XrefRangeEnd = 1086614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00012B58 File Offset: 0x00010D58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1086619, RefRangeEnd = 1086620, XrefRangeStart = 1086614, XrefRangeEnd = 1086619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00012B94 File Offset: 0x00010D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086620, XrefRangeEnd = 1086625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CaretBlink()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_CaretBlink_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00012BD4 File Offset: 0x00010DD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1086627, RefRangeEnd = 1086628, XrefRangeStart = 1086625, XrefRangeEnd = 1086627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCaretVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_SetCaretVisible_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00012C08 File Offset: 0x00010E08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1086628, RefRangeEnd = 1086631, XrefRangeStart = 1086628, XrefRangeEnd = 1086628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCaretActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_SetCaretActive_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00012C3C File Offset: 0x00010E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086631, XrefRangeEnd = 1086644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCaretMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_UpdateCaretMaterial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00012C70 File Offset: 0x00010E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086644, XrefRangeEnd = 1086645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_OnFocus_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00012CA4 File Offset: 0x00010EA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1086646, RefRangeEnd = 1086649, XrefRangeStart = 1086645, XrefRangeEnd = 1086646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_SelectAll_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00012CD8 File Offset: 0x00010ED8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1086656, RefRangeEnd = 1086657, XrefRangeStart = 1086649, XrefRangeEnd = 1086656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveTextEnd(bool shift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_MoveTextEnd_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00012D18 File Offset: 0x00010F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086657, XrefRangeEnd = 1086662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveTextStart(bool shift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_MoveTextStart_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x00012D58 File Offset: 0x00010F58
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x00012D84 File Offset: 0x00010F84
		public unsafe static string clipboard
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086662, XrefRangeEnd = 1086666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_get_clipboard_Private_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1086670, RefRangeEnd = 1086671, XrefRangeStart = 1086666, XrefRangeEnd = 1086670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_set_clipboard_Private_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00012DBC File Offset: 0x00010FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086671, XrefRangeEnd = 1086680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TouchScreenKeyboardShouldBeUsed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_TouchScreenKeyboardShouldBeUsed_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00012DF8 File Offset: 0x00010FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086680, XrefRangeEnd = 1086681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InPlaceEditing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_InPlaceEditing_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00012E34 File Offset: 0x00011034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086681, XrefRangeEnd = 1086685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InPlaceEditingChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_InPlaceEditingChanged_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00012E70 File Offset: 0x00011070
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1086693, RefRangeEnd = 1086695, XrefRangeStart = 1086685, XrefRangeEnd = 1086693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RangeInt GetInternalSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_GetInternalSelection_Private_RangeInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00012EAC File Offset: 0x000110AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1086705, RefRangeEnd = 1086706, XrefRangeStart = 1086695, XrefRangeEnd = 1086705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateKeyboardCaret()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_UpdateKeyboardCaret_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00012EE0 File Offset: 0x000110E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1086715, RefRangeEnd = 1086716, XrefRangeStart = 1086706, XrefRangeEnd = 1086715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCaretFromKeyboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_UpdateCaretFromKeyboard_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00012F14 File Offset: 0x00011114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086716, XrefRangeEnd = 1086777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00012F50 File Offset: 0x00011150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086777, XrefRangeEnd = 1086811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 ScreenToLocal(Vector2 screen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screen;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_ScreenToLocal_Public_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00012F9C File Offset: 0x0001119C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1086812, RefRangeEnd = 1086813, XrefRangeStart = 1086811, XrefRangeEnd = 1086812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_GetUnclampedCharacterLineFromPosition_Private_Int32_Vector2_TextGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00012FF8 File Offset: 0x000111F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1086832, RefRangeEnd = 1086833, XrefRangeStart = 1086813, XrefRangeEnd = 1086832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCharacterIndexFromPosition(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_GetCharacterIndexFromPosition_Protected_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00013044 File Offset: 0x00011244
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1086838, RefRangeEnd = 1086842, XrefRangeStart = 1086833, XrefRangeEnd = 1086838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MayDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_MayDrag_Private_Boolean_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00013094 File Offset: 0x00011294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086842, XrefRangeEnd = 1086843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeginDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002CE RID: 718 RVA: 0x000130E4 File Offset: 0x000112E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086843, XrefRangeEnd = 1086871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00013134 File Offset: 0x00011334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086871, XrefRangeEnd = 1086877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator MouseDragOutsideRect(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_MouseDragOutsideRect_Private_IEnumerator_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00013184 File Offset: 0x00011384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086877, XrefRangeEnd = 1086878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEndDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x000131D4 File Offset: 0x000113D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086878, XrefRangeEnd = 1086889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00013224 File Offset: 0x00011424
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1086909, RefRangeEnd = 1086911, XrefRangeStart = 1086889, XrefRangeEnd = 1086909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputField.EditState KeyPressed(Event evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_KeyPressed_Protected_EditState_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00013274 File Offset: 0x00011474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086911, XrefRangeEnd = 1086913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValidChar(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_IsValidChar_Private_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x000132C0 File Offset: 0x000114C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086913, XrefRangeEnd = 1086914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessEvent(Event e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_ProcessEvent_Public_Void_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00013304 File Offset: 0x00011504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086914, XrefRangeEnd = 1086929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnUpdateSelected(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_OnUpdateSelected_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00013354 File Offset: 0x00011554
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1086935, RefRangeEnd = 1086936, XrefRangeStart = 1086929, XrefRangeEnd = 1086935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSelectedString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_GetSelectedString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0001338C File Offset: 0x0001158C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086936, XrefRangeEnd = 1086943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindtNextWordBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_FindtNextWordBegin_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x000133C8 File Offset: 0x000115C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086943, XrefRangeEnd = 1086948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_MoveRight_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00013414 File Offset: 0x00011614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086948, XrefRangeEnd = 1086955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindtPrevWordBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_FindtPrevWordBegin_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00013450 File Offset: 0x00011650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086955, XrefRangeEnd = 1086960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_MoveLeft_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0001349C File Offset: 0x0001169C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1086967, RefRangeEnd = 1086973, XrefRangeStart = 1086960, XrefRangeEnd = 1086967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int DetermineCharacterLine(int charPos, TextGenerator generator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_DetermineCharacterLine_Private_Int32_Int32_TextGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000134F8 File Offset: 0x000116F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1086998, RefRangeEnd = 1086999, XrefRangeStart = 1086973, XrefRangeEnd = 1086998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_LineUpCharacterPosition_Private_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00013550 File Offset: 0x00011750
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087033, RefRangeEnd = 1087034, XrefRangeStart = 1086999, XrefRangeEnd = 1087033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_LineDownCharacterPosition_Private_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x000135A8 File Offset: 0x000117A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087034, XrefRangeEnd = 1087035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveDown(bool shift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_MoveDown_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x000135E8 File Offset: 0x000117E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1087045, RefRangeEnd = 1087047, XrefRangeStart = 1087035, XrefRangeEnd = 1087045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_MoveDown_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00013634 File Offset: 0x00011834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087047, XrefRangeEnd = 1087048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveUp(bool shift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_MoveUp_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00013674 File Offset: 0x00011874
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1087058, RefRangeEnd = 1087060, XrefRangeStart = 1087048, XrefRangeEnd = 1087058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_MoveUp_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x000136C0 File Offset: 0x000118C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1087072, RefRangeEnd = 1087074, XrefRangeStart = 1087060, XrefRangeEnd = 1087072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Delete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_Delete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x000136F4 File Offset: 0x000118F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087074, XrefRangeEnd = 1087082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForwardSpace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_ForwardSpace_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00013728 File Offset: 0x00011928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087082, XrefRangeEnd = 1087094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Backspace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_Backspace_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0001375C File Offset: 0x0001195C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087107, RefRangeEnd = 1087108, XrefRangeStart = 1087094, XrefRangeEnd = 1087107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_Insert_Private_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0001379C File Offset: 0x0001199C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1087110, RefRangeEnd = 1087113, XrefRangeStart = 1087108, XrefRangeEnd = 1087110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTouchKeyboardFromEditChanges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_UpdateTouchKeyboardFromEditChanges_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x000137D0 File Offset: 0x000119D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087113, XrefRangeEnd = 1087115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnValueChangedAndUpdateLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_SendOnValueChangedAndUpdateLabel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00013804 File Offset: 0x00011A04
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1087121, RefRangeEnd = 1087126, XrefRangeStart = 1087115, XrefRangeEnd = 1087121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnValueChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_SendOnValueChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00013838 File Offset: 0x00011A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087126, XrefRangeEnd = 1087132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnEndEdit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_SendOnEndEdit_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0001386C File Offset: 0x00011A6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087138, RefRangeEnd = 1087139, XrefRangeStart = 1087132, XrefRangeEnd = 1087138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOnSubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_SendOnSubmit_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000138A0 File Offset: 0x00011AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087139, XrefRangeEnd = 1087141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Append(string input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_Append_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000138F0 File Offset: 0x00011AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087141, XrefRangeEnd = 1087169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Append(char input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_Append_Protected_Virtual_New_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0001393C File Offset: 0x00011B3C
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1087215, RefRangeEnd = 1087232, XrefRangeStart = 1087169, XrefRangeEnd = 1087215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_UpdateLabel_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00013970 File Offset: 0x00011B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087232, XrefRangeEnd = 1087236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSelectionVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_IsSelectionVisible_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x000139AC File Offset: 0x00011BAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1087245, RefRangeEnd = 1087247, XrefRangeStart = 1087236, XrefRangeEnd = 1087245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLineStartPosition(TextGenerator gen, int line)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gen);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_GetLineStartPosition_Private_Static_Int32_TextGenerator_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000139FC File Offset: 0x00011BFC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1087256, RefRangeEnd = 1087261, XrefRangeStart = 1087247, XrefRangeEnd = 1087256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLineEndPosition(TextGenerator gen, int line)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gen);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_GetLineEndPosition_Private_Static_Int32_TextGenerator_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00013A4C File Offset: 0x00011C4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087347, RefRangeEnd = 1087348, XrefRangeStart = 1087261, XrefRangeEnd = 1087347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDrawRangeToContainCaretPosition(int caretPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref caretPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_SetDrawRangeToContainCaretPosition_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00013A8C File Offset: 0x00011C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087348, XrefRangeEnd = 1087349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceLabelUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_ForceLabelUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00013AC0 File Offset: 0x00011CC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1087353, RefRangeEnd = 1087355, XrefRangeStart = 1087349, XrefRangeEnd = 1087353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkGeometryAsDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_MarkGeometryAsDirty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00013AF4 File Offset: 0x00011CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087355, XrefRangeEnd = 1087356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Rebuild(CanvasUpdate update)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref update;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00013B40 File Offset: 0x00011D40
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LayoutComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00013B7C File Offset: 0x00011D7C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GraphicUpdateComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00013BB8 File Offset: 0x00011DB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087428, RefRangeEnd = 1087429, XrefRangeStart = 1087356, XrefRangeEnd = 1087428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGeometry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_UpdateGeometry_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00013BEC File Offset: 0x00011DEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1087484, RefRangeEnd = 1087486, XrefRangeStart = 1087429, XrefRangeEnd = 1087484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignPositioningIfNeeded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_AssignPositioningIfNeeded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00013C20 File Offset: 0x00011E20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087508, RefRangeEnd = 1087509, XrefRangeStart = 1087486, XrefRangeEnd = 1087508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFillVBO(Mesh vbo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vbo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_OnFillVBO_Private_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00013C64 File Offset: 0x00011E64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087589, RefRangeEnd = 1087590, XrefRangeStart = 1087509, XrefRangeEnd = 1087589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_GenerateCaret_Private_Void_VertexHelper_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00013CB4 File Offset: 0x00011EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087590, XrefRangeEnd = 1087601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateCursorVerts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_CreateCursorVerts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00013CE8 File Offset: 0x00011EE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087652, RefRangeEnd = 1087653, XrefRangeStart = 1087601, XrefRangeEnd = 1087652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_GenerateHighlight_Private_Void_VertexHelper_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00013D38 File Offset: 0x00011F38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1087689, RefRangeEnd = 1087691, XrefRangeStart = 1087653, XrefRangeEnd = 1087689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_Validate_Protected_Char_String_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00013DA4 File Offset: 0x00011FA4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1087702, RefRangeEnd = 1087707, XrefRangeStart = 1087691, XrefRangeEnd = 1087702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateInputField()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_ActivateInputField_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00013DD8 File Offset: 0x00011FD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087773, RefRangeEnd = 1087774, XrefRangeStart = 1087707, XrefRangeEnd = 1087773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateInputFieldInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_ActivateInputFieldInternal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00013E0C File Offset: 0x0001200C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087776, RefRangeEnd = 1087777, XrefRangeStart = 1087774, XrefRangeEnd = 1087776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00013E5C File Offset: 0x0001205C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087777, XrefRangeEnd = 1087778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00013EAC File Offset: 0x000120AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1087805, RefRangeEnd = 1087809, XrefRangeStart = 1087778, XrefRangeEnd = 1087805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeactivateInputField()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_DeactivateInputField_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00013EE0 File Offset: 0x000120E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1087811, RefRangeEnd = 1087812, XrefRangeStart = 1087809, XrefRangeEnd = 1087811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDeselect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00013F30 File Offset: 0x00012130
		[CallerCount(0)]
		public unsafe virtual void OnSubmit(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00013F80 File Offset: 0x00012180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087812, XrefRangeEnd = 1087825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnforceContentType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_EnforceContentType_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00013FB4 File Offset: 0x000121B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1087830, RefRangeEnd = 1087833, XrefRangeStart = 1087825, XrefRangeEnd = 1087830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnforceTextHOverflow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_EnforceTextHOverflow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00013FE8 File Offset: 0x000121E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087833, XrefRangeEnd = 1087835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToCustomIfContentTypeIsNot([Optional] Il2CppStructArray<InputField.ContentType> allowedContentTypes)
		{
			if (allowedContentTypes == null)
			{
				allowedContentTypes = new Il2CppStructArray<InputField.ContentType>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(allowedContentTypes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_SetToCustomIfContentTypeIsNot_Private_Void_Il2CppStructArray_1_ContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00014038 File Offset: 0x00012238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087835, XrefRangeEnd = 1087836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToCustom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_SetToCustom_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0001406C File Offset: 0x0001226C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087836, XrefRangeEnd = 1087838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x000140C4 File Offset: 0x000122C4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00014100 File Offset: 0x00012300
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600030C RID: 780 RVA: 0x0001413C File Offset: 0x0001233C
		public unsafe virtual float minWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600030D RID: 781 RVA: 0x00014184 File Offset: 0x00012384
		public unsafe virtual float preferredWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087838, XrefRangeEnd = 1087848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600030E RID: 782 RVA: 0x000141CC File Offset: 0x000123CC
		public unsafe virtual float flexibleWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600030F RID: 783 RVA: 0x00014214 File Offset: 0x00012414
		public unsafe virtual float minHeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122524, RefRangeEnd = 122525, XrefRangeStart = 122524, XrefRangeEnd = 122525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000310 RID: 784 RVA: 0x0001425C File Offset: 0x0001245C
		public unsafe virtual float preferredHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087848, XrefRangeEnd = 1087858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000311 RID: 785 RVA: 0x000142A4 File Offset: 0x000124A4
		public unsafe virtual float flexibleHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000312 RID: 786 RVA: 0x000142EC File Offset: 0x000124EC
		public unsafe virtual int layoutPriority
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputField.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00014334 File Offset: 0x00012534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Transform UnityEngine_UI_ICanvasElement_get_transform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00002D8B File Offset: 0x00000F8B
		public void SetToCustomIfContentTypeIsNot(params InputField.ContentType[] allowedContentTypes)
		{
			this.SetToCustomIfContentTypeIsNot(new Il2CppStructArray<InputField.ContentType>(allowedContentTypes));
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002D99 File Offset: 0x00000F99
		public InputField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000316 RID: 790 RVA: 0x00014374 File Offset: 0x00012574
		// (set) Token: 0x06000317 RID: 791 RVA: 0x00002DA2 File Offset: 0x00000FA2
		public unsafe TouchScreenKeyboard m_Keyboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_Keyboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchScreenKeyboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_Keyboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000318 RID: 792 RVA: 0x000143A4 File Offset: 0x000125A4
		// (set) Token: 0x06000319 RID: 793 RVA: 0x00002DC1 File Offset: 0x00000FC1
		public unsafe static Il2CppStructArray<char> kSeparators
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputField.NativeFieldInfoPtr_kSeparators, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputField.NativeFieldInfoPtr_kSeparators, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600031A RID: 794 RVA: 0x000143CC File Offset: 0x000125CC
		// (set) Token: 0x0600031B RID: 795 RVA: 0x00002DD3 File Offset: 0x00000FD3
		public unsafe static bool s_IsQuestDevice
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(InputField.NativeFieldInfoPtr_s_IsQuestDevice, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputField.NativeFieldInfoPtr_s_IsQuestDevice, (void*)(&value));
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600031C RID: 796 RVA: 0x000143E8 File Offset: 0x000125E8
		// (set) Token: 0x0600031D RID: 797 RVA: 0x00002DE1 File Offset: 0x00000FE1
		public unsafe Text m_TextComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_TextComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_TextComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600031E RID: 798 RVA: 0x00014418 File Offset: 0x00012618
		// (set) Token: 0x0600031F RID: 799 RVA: 0x00002E00 File Offset: 0x00001000
		public unsafe Graphic m_Placeholder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_Placeholder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_Placeholder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00014448 File Offset: 0x00012648
		// (set) Token: 0x06000321 RID: 801 RVA: 0x00002E1F File Offset: 0x0000101F
		public unsafe InputField.ContentType m_ContentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_ContentType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_ContentType)) = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00014470 File Offset: 0x00012670
		// (set) Token: 0x06000323 RID: 803 RVA: 0x00002E3A File Offset: 0x0000103A
		public unsafe InputField.InputType m_InputType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_InputType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_InputType)) = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00014498 File Offset: 0x00012698
		// (set) Token: 0x06000325 RID: 805 RVA: 0x00002E55 File Offset: 0x00001055
		public unsafe char m_AsteriskChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_AsteriskChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_AsteriskChar)) = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000326 RID: 806 RVA: 0x000144C0 File Offset: 0x000126C0
		// (set) Token: 0x06000327 RID: 807 RVA: 0x00002E70 File Offset: 0x00001070
		public unsafe TouchScreenKeyboardType m_KeyboardType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_KeyboardType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_KeyboardType)) = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000328 RID: 808 RVA: 0x000144E8 File Offset: 0x000126E8
		// (set) Token: 0x06000329 RID: 809 RVA: 0x00002E8B File Offset: 0x0000108B
		public unsafe InputField.LineType m_LineType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_LineType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_LineType)) = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600032A RID: 810 RVA: 0x00014510 File Offset: 0x00012710
		// (set) Token: 0x0600032B RID: 811 RVA: 0x00002EA6 File Offset: 0x000010A6
		public unsafe bool m_HideMobileInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_HideMobileInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_HideMobileInput)) = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600032C RID: 812 RVA: 0x00014538 File Offset: 0x00012738
		// (set) Token: 0x0600032D RID: 813 RVA: 0x00002EC1 File Offset: 0x000010C1
		public unsafe InputField.CharacterValidation m_CharacterValidation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CharacterValidation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CharacterValidation)) = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00014560 File Offset: 0x00012760
		// (set) Token: 0x0600032F RID: 815 RVA: 0x00002EDC File Offset: 0x000010DC
		public unsafe int m_CharacterLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CharacterLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CharacterLimit)) = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000330 RID: 816 RVA: 0x00014588 File Offset: 0x00012788
		// (set) Token: 0x06000331 RID: 817 RVA: 0x00002EF7 File Offset: 0x000010F7
		public unsafe InputField.SubmitEvent m_OnSubmit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_OnSubmit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField.SubmitEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_OnSubmit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000332 RID: 818 RVA: 0x000145B8 File Offset: 0x000127B8
		// (set) Token: 0x06000333 RID: 819 RVA: 0x00002F16 File Offset: 0x00001116
		public unsafe InputField.EndEditEvent m_OnDidEndEdit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_OnDidEndEdit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField.EndEditEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_OnDidEndEdit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000334 RID: 820 RVA: 0x000145E8 File Offset: 0x000127E8
		// (set) Token: 0x06000335 RID: 821 RVA: 0x00002F35 File Offset: 0x00001135
		public unsafe InputField.OnChangeEvent m_OnValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_OnValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField.OnChangeEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_OnValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00014618 File Offset: 0x00012818
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00002F54 File Offset: 0x00001154
		public unsafe InputField.OnValidateInput m_OnValidateInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_OnValidateInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField.OnValidateInput>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_OnValidateInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00014648 File Offset: 0x00012848
		// (set) Token: 0x06000339 RID: 825 RVA: 0x00002F73 File Offset: 0x00001173
		public unsafe Color m_CaretColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CaretColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CaretColor)) = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00014670 File Offset: 0x00012870
		// (set) Token: 0x0600033B RID: 827 RVA: 0x00002F8E File Offset: 0x0000118E
		public unsafe bool m_CustomCaretColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CustomCaretColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CustomCaretColor)) = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00014698 File Offset: 0x00012898
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00002FA9 File Offset: 0x000011A9
		public unsafe Color m_SelectionColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_SelectionColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_SelectionColor)) = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600033E RID: 830 RVA: 0x000146C0 File Offset: 0x000128C0
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00002FC4 File Offset: 0x000011C4
		public unsafe string m_Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000340 RID: 832 RVA: 0x000146E8 File Offset: 0x000128E8
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00002FE3 File Offset: 0x000011E3
		public unsafe float m_CaretBlinkRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CaretBlinkRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CaretBlinkRate)) = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000342 RID: 834 RVA: 0x00014710 File Offset: 0x00012910
		// (set) Token: 0x06000343 RID: 835 RVA: 0x00002FFE File Offset: 0x000011FE
		public unsafe int m_CaretWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CaretWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CaretWidth)) = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00014738 File Offset: 0x00012938
		// (set) Token: 0x06000345 RID: 837 RVA: 0x00003019 File Offset: 0x00001219
		public unsafe bool m_ReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_ReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_ReadOnly)) = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000346 RID: 838 RVA: 0x00014760 File Offset: 0x00012960
		// (set) Token: 0x06000347 RID: 839 RVA: 0x00003034 File Offset: 0x00001234
		public unsafe bool m_ShouldActivateOnSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_ShouldActivateOnSelect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_ShouldActivateOnSelect)) = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000348 RID: 840 RVA: 0x00014788 File Offset: 0x00012988
		// (set) Token: 0x06000349 RID: 841 RVA: 0x0000304F File Offset: 0x0000124F
		public unsafe int m_CaretPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CaretPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CaretPosition)) = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600034A RID: 842 RVA: 0x000147B0 File Offset: 0x000129B0
		// (set) Token: 0x0600034B RID: 843 RVA: 0x0000306A File Offset: 0x0000126A
		public unsafe int m_CaretSelectPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CaretSelectPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CaretSelectPosition)) = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600034C RID: 844 RVA: 0x000147D8 File Offset: 0x000129D8
		// (set) Token: 0x0600034D RID: 845 RVA: 0x00003085 File Offset: 0x00001285
		public unsafe RectTransform caretRectTrans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_caretRectTrans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_caretRectTrans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600034E RID: 846 RVA: 0x00014808 File Offset: 0x00012A08
		// (set) Token: 0x0600034F RID: 847 RVA: 0x000030A4 File Offset: 0x000012A4
		public unsafe Il2CppStructArray<UIVertex> m_CursorVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CursorVerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<UIVertex>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CursorVerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00014838 File Offset: 0x00012A38
		// (set) Token: 0x06000351 RID: 849 RVA: 0x000030C3 File Offset: 0x000012C3
		public unsafe TextGenerator m_InputTextCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_InputTextCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_InputTextCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00014868 File Offset: 0x00012A68
		// (set) Token: 0x06000353 RID: 851 RVA: 0x000030E2 File Offset: 0x000012E2
		public unsafe CanvasRenderer m_CachedInputRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CachedInputRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CachedInputRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00014898 File Offset: 0x00012A98
		// (set) Token: 0x06000355 RID: 853 RVA: 0x00003101 File Offset: 0x00001301
		public unsafe bool m_PreventFontCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_PreventFontCallback);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_PreventFontCallback)) = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000356 RID: 854 RVA: 0x000148C0 File Offset: 0x00012AC0
		// (set) Token: 0x06000357 RID: 855 RVA: 0x0000311C File Offset: 0x0000131C
		public unsafe Mesh m_Mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_Mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_Mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000358 RID: 856 RVA: 0x000148F0 File Offset: 0x00012AF0
		// (set) Token: 0x06000359 RID: 857 RVA: 0x0000313B File Offset: 0x0000133B
		public unsafe bool m_AllowInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_AllowInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_AllowInput)) = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00014918 File Offset: 0x00012B18
		// (set) Token: 0x0600035B RID: 859 RVA: 0x00003156 File Offset: 0x00001356
		public unsafe bool m_ShouldActivateNextUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_ShouldActivateNextUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_ShouldActivateNextUpdate)) = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00014940 File Offset: 0x00012B40
		// (set) Token: 0x0600035D RID: 861 RVA: 0x00003171 File Offset: 0x00001371
		public unsafe bool m_UpdateDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_UpdateDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_UpdateDrag)) = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600035E RID: 862 RVA: 0x00014968 File Offset: 0x00012B68
		// (set) Token: 0x0600035F RID: 863 RVA: 0x0000318C File Offset: 0x0000138C
		public unsafe bool m_DragPositionOutOfBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_DragPositionOutOfBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_DragPositionOutOfBounds)) = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00014990 File Offset: 0x00012B90
		// (set) Token: 0x06000361 RID: 865 RVA: 0x000031A7 File Offset: 0x000013A7
		public unsafe static float kHScrollSpeed
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(InputField.NativeFieldInfoPtr_kHScrollSpeed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputField.NativeFieldInfoPtr_kHScrollSpeed, (void*)(&value));
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000362 RID: 866 RVA: 0x000149AC File Offset: 0x00012BAC
		// (set) Token: 0x06000363 RID: 867 RVA: 0x000031B5 File Offset: 0x000013B5
		public unsafe static float kVScrollSpeed
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(InputField.NativeFieldInfoPtr_kVScrollSpeed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputField.NativeFieldInfoPtr_kVScrollSpeed, (void*)(&value));
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000364 RID: 868 RVA: 0x000149C8 File Offset: 0x00012BC8
		// (set) Token: 0x06000365 RID: 869 RVA: 0x000031C3 File Offset: 0x000013C3
		public unsafe bool m_CaretVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CaretVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_CaretVisible)) = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000366 RID: 870 RVA: 0x000149F0 File Offset: 0x00012BF0
		// (set) Token: 0x06000367 RID: 871 RVA: 0x000031DE File Offset: 0x000013DE
		public unsafe Coroutine m_BlinkCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_BlinkCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_BlinkCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000368 RID: 872 RVA: 0x00014A20 File Offset: 0x00012C20
		// (set) Token: 0x06000369 RID: 873 RVA: 0x000031FD File Offset: 0x000013FD
		public unsafe float m_BlinkStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_BlinkStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_BlinkStartTime)) = value;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600036A RID: 874 RVA: 0x00014A48 File Offset: 0x00012C48
		// (set) Token: 0x0600036B RID: 875 RVA: 0x00003218 File Offset: 0x00001418
		public unsafe int m_DrawStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_DrawStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_DrawStart)) = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600036C RID: 876 RVA: 0x00014A70 File Offset: 0x00012C70
		// (set) Token: 0x0600036D RID: 877 RVA: 0x00003233 File Offset: 0x00001433
		public unsafe int m_DrawEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_DrawEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_DrawEnd)) = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600036E RID: 878 RVA: 0x00014A98 File Offset: 0x00012C98
		// (set) Token: 0x0600036F RID: 879 RVA: 0x0000324E File Offset: 0x0000144E
		public unsafe Coroutine m_DragCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_DragCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_DragCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000370 RID: 880 RVA: 0x00014AC8 File Offset: 0x00012CC8
		// (set) Token: 0x06000371 RID: 881 RVA: 0x0000326D File Offset: 0x0000146D
		public unsafe string m_OriginalText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_OriginalText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_OriginalText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000372 RID: 882 RVA: 0x00014AF0 File Offset: 0x00012CF0
		// (set) Token: 0x06000373 RID: 883 RVA: 0x0000328C File Offset: 0x0000148C
		public unsafe bool m_WasCanceled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_WasCanceled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_WasCanceled)) = value;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00014B18 File Offset: 0x00012D18
		// (set) Token: 0x06000375 RID: 885 RVA: 0x000032A7 File Offset: 0x000014A7
		public unsafe bool m_HasDoneFocusTransition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_HasDoneFocusTransition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_HasDoneFocusTransition)) = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00014B40 File Offset: 0x00012D40
		// (set) Token: 0x06000377 RID: 887 RVA: 0x000032C2 File Offset: 0x000014C2
		public unsafe WaitForSecondsRealtime m_WaitForSecondsRealtime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_WaitForSecondsRealtime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSecondsRealtime>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_WaitForSecondsRealtime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00014B70 File Offset: 0x00012D70
		// (set) Token: 0x06000379 RID: 889 RVA: 0x000032E1 File Offset: 0x000014E1
		public unsafe bool m_TouchKeyboardAllowsInPlaceEditing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_TouchKeyboardAllowsInPlaceEditing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_TouchKeyboardAllowsInPlaceEditing)) = value;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00014B98 File Offset: 0x00012D98
		// (set) Token: 0x0600037B RID: 891 RVA: 0x000032FC File Offset: 0x000014FC
		public unsafe bool m_IsCompositionActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_IsCompositionActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_IsCompositionActive)) = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00014BC0 File Offset: 0x00012DC0
		// (set) Token: 0x0600037D RID: 893 RVA: 0x00003317 File Offset: 0x00001517
		public unsafe static string kEmailSpecialCharacters
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputField.NativeFieldInfoPtr_kEmailSpecialCharacters, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputField.NativeFieldInfoPtr_kEmailSpecialCharacters, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600037E RID: 894 RVA: 0x00014BE0 File Offset: 0x00012DE0
		// (set) Token: 0x0600037F RID: 895 RVA: 0x00003329 File Offset: 0x00001529
		public unsafe static string kOculusQuestDeviceModel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputField.NativeFieldInfoPtr_kOculusQuestDeviceModel, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputField.NativeFieldInfoPtr_kOculusQuestDeviceModel, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00014C00 File Offset: 0x00012E00
		// (set) Token: 0x06000381 RID: 897 RVA: 0x0000333B File Offset: 0x0000153B
		public unsafe Event m_ProcessingEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_ProcessingEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Event>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField.NativeFieldInfoPtr_m_ProcessingEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00014C30 File Offset: 0x00012E30
		// (set) Token: 0x06000383 RID: 899 RVA: 0x0000335A File Offset: 0x0000155A
		public unsafe static int k_MaxTextLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(InputField.NativeFieldInfoPtr_k_MaxTextLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputField.NativeFieldInfoPtr_k_MaxTextLength, (void*)(&value));
			}
		}

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeFieldInfoPtr_m_Keyboard;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeFieldInfoPtr_kSeparators;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeFieldInfoPtr_s_IsQuestDevice;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeFieldInfoPtr_m_TextComponent;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeFieldInfoPtr_m_Placeholder;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeFieldInfoPtr_m_ContentType;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeFieldInfoPtr_m_InputType;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeFieldInfoPtr_m_AsteriskChar;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeFieldInfoPtr_m_KeyboardType;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeFieldInfoPtr_m_LineType;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeFieldInfoPtr_m_HideMobileInput;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeFieldInfoPtr_m_CharacterValidation;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeFieldInfoPtr_m_CharacterLimit;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeFieldInfoPtr_m_OnSubmit;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeFieldInfoPtr_m_OnDidEndEdit;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeFieldInfoPtr_m_OnValueChanged;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeFieldInfoPtr_m_OnValidateInput;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeFieldInfoPtr_m_CaretColor;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomCaretColor;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectionColor;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeFieldInfoPtr_m_Text;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeFieldInfoPtr_m_CaretBlinkRate;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeFieldInfoPtr_m_CaretWidth;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeFieldInfoPtr_m_ReadOnly;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldActivateOnSelect;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeFieldInfoPtr_m_CaretPosition;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeFieldInfoPtr_m_CaretSelectPosition;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeFieldInfoPtr_caretRectTrans;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeFieldInfoPtr_m_CursorVerts;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeFieldInfoPtr_m_InputTextCache;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedInputRenderer;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeFieldInfoPtr_m_PreventFontCallback;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeFieldInfoPtr_m_Mesh;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeFieldInfoPtr_m_AllowInput;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldActivateNextUpdate;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateDrag;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeFieldInfoPtr_m_DragPositionOutOfBounds;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeFieldInfoPtr_kHScrollSpeed;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeFieldInfoPtr_kVScrollSpeed;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeFieldInfoPtr_m_CaretVisible;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeFieldInfoPtr_m_BlinkCoroutine;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeFieldInfoPtr_m_BlinkStartTime;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeFieldInfoPtr_m_DrawStart;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeFieldInfoPtr_m_DrawEnd;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeFieldInfoPtr_m_DragCoroutine;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeFieldInfoPtr_m_OriginalText;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeFieldInfoPtr_m_WasCanceled;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeFieldInfoPtr_m_HasDoneFocusTransition;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeFieldInfoPtr_m_WaitForSecondsRealtime;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeFieldInfoPtr_m_TouchKeyboardAllowsInPlaceEditing;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeFieldInfoPtr_m_IsCompositionActive;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeFieldInfoPtr_kEmailSpecialCharacters;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeFieldInfoPtr_kOculusQuestDeviceModel;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeFieldInfoPtr_m_ProcessingEvent;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeFieldInfoPtr_k_MaxTextLength;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_get_input_Private_get_BaseInput_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_get_compositionString_Private_get_String_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_get_mesh_Protected_get_Mesh_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_get_cachedInputTextGenerator_Protected_get_TextGenerator_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_set_shouldHideMobileInput_Public_set_Void_Boolean_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_get_shouldHideMobileInput_Public_get_Boolean_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_set_shouldActivateOnSelect_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_get_shouldActivateOnSelect_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_SetTextWithoutNotify_Public_Void_String_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Private_Void_String_Boolean_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_get_isFocused_Public_get_Boolean_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_get_caretBlinkRate_Public_get_Single_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_set_caretBlinkRate_Public_set_Void_Single_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_get_caretWidth_Public_get_Int32_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_set_caretWidth_Public_set_Void_Int32_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_get_textComponent_Public_get_Text_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_set_textComponent_Public_set_Void_Text_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_get_placeholder_Public_get_Graphic_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_set_placeholder_Public_set_Void_Graphic_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_get_caretColor_Public_get_Color_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_set_caretColor_Public_set_Void_Color_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_get_customCaretColor_Public_get_Boolean_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_set_customCaretColor_Public_set_Void_Boolean_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_get_selectionColor_Public_get_Color_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_set_selectionColor_Public_set_Void_Color_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_get_onEndEdit_Public_get_EndEditEvent_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_set_onEndEdit_Public_set_Void_EndEditEvent_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_get_onSubmit_Public_get_SubmitEvent_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_set_onSubmit_Public_set_Void_SubmitEvent_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_get_onValueChange_Public_get_OnChangeEvent_0;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_set_onValueChange_Public_set_Void_OnChangeEvent_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr_get_onValueChanged_Public_get_OnChangeEvent_0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_OnChangeEvent_0;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_get_onValidateInput_Public_get_OnValidateInput_0;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_set_onValidateInput_Public_set_Void_OnValidateInput_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr_get_characterLimit_Public_get_Int32_0;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr_set_characterLimit_Public_set_Void_Int32_0;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr_get_contentType_Public_get_ContentType_0;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_set_contentType_Public_set_Void_ContentType_0;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr_get_lineType_Public_get_LineType_0;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_set_lineType_Public_set_Void_LineType_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr_get_inputType_Public_get_InputType_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_set_inputType_Public_set_Void_InputType_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_get_touchScreenKeyboard_Public_get_TouchScreenKeyboard_0;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_get_keyboardType_Public_get_TouchScreenKeyboardType_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_set_keyboardType_Public_set_Void_TouchScreenKeyboardType_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr_get_characterValidation_Public_get_CharacterValidation_0;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr_set_characterValidation_Public_set_Void_CharacterValidation_0;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr_get_readOnly_Public_get_Boolean_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_set_readOnly_Public_set_Void_Boolean_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr_get_multiLine_Public_get_Boolean_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr_get_asteriskChar_Public_get_Char_0;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr_set_asteriskChar_Public_set_Void_Char_0;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr_get_wasCanceled_Public_get_Boolean_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr_ClampPos_Protected_Void_byref_Int32_0;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr_get_caretPositionInternal_Protected_get_Int32_0;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr_set_caretPositionInternal_Protected_set_Void_Int32_0;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr_get_caretSelectPositionInternal_Protected_get_Int32_0;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeMethodInfoPtr_set_caretSelectPositionInternal_Protected_set_Void_Int32_0;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeMethodInfoPtr_get_hasSelection_Private_get_Boolean_0;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeMethodInfoPtr_get_caretPosition_Public_get_Int32_0;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr_set_caretPosition_Public_set_Void_Int32_0;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr_get_selectionAnchorPosition_Public_get_Int32_0;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_set_selectionAnchorPosition_Public_set_Void_Int32_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_get_selectionFocusPosition_Public_get_Int32_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_set_selectionFocusPosition_Public_set_Void_Int32_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_CaretBlink_Private_IEnumerator_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_SetCaretVisible_Private_Void_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_SetCaretActive_Private_Void_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCaretMaterial_Private_Void_0;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr_OnFocus_Protected_Void_0;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_SelectAll_Protected_Void_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr_MoveTextEnd_Public_Void_Boolean_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr_MoveTextStart_Public_Void_Boolean_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr_get_clipboard_Private_Static_get_String_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr_set_clipboard_Private_Static_set_Void_String_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr_TouchScreenKeyboardShouldBeUsed_Private_Boolean_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr_InPlaceEditing_Private_Boolean_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_InPlaceEditingChanged_Private_Boolean_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_GetInternalSelection_Private_RangeInt_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr_UpdateKeyboardCaret_Private_Void_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCaretFromKeyboard_Private_Void_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToLocal_Public_Vector2_Vector2_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_GetUnclampedCharacterLineFromPosition_Private_Int32_Vector2_TextGenerator_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterIndexFromPosition_Protected_Int32_Vector2_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_MayDrag_Private_Boolean_PointerEventData_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_MouseDragOutsideRect_Private_IEnumerator_PointerEventData_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr_OnEndDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_KeyPressed_Protected_EditState_Event_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr_IsValidChar_Private_Boolean_Char_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEvent_Public_Void_Event_0;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdateSelected_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectedString_Private_String_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_FindtNextWordBegin_Private_Int32_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_MoveRight_Private_Void_Boolean_Boolean_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_FindtPrevWordBegin_Private_Int32_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr_MoveLeft_Private_Void_Boolean_Boolean_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr_DetermineCharacterLine_Private_Int32_Int32_TextGenerator_0;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr_LineUpCharacterPosition_Private_Int32_Int32_Boolean_0;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeMethodInfoPtr_LineDownCharacterPosition_Private_Int32_Int32_Boolean_0;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeMethodInfoPtr_MoveDown_Private_Void_Boolean_0;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr_MoveDown_Private_Void_Boolean_Boolean_0;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr_MoveUp_Private_Void_Boolean_0;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeMethodInfoPtr_MoveUp_Private_Void_Boolean_Boolean_0;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Private_Void_0;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeMethodInfoPtr_ForwardSpace_Private_Void_0;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr_Backspace_Private_Void_0;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Private_Void_Char_0;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTouchKeyboardFromEditChanges_Private_Void_0;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr_SendOnValueChangedAndUpdateLabel_Private_Void_0;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeMethodInfoPtr_SendOnValueChanged_Private_Void_0;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr_SendOnEndEdit_Protected_Void_0;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr_SendOnSubmit_Protected_Void_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr_Append_Protected_Virtual_New_Void_String_0;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr_Append_Protected_Virtual_New_Void_Char_0;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLabel_Protected_Void_0;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeMethodInfoPtr_IsSelectionVisible_Private_Boolean_0;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeMethodInfoPtr_GetLineStartPosition_Private_Static_Int32_TextGenerator_Int32_0;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeMethodInfoPtr_GetLineEndPosition_Private_Static_Int32_TextGenerator_Int32_0;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeMethodInfoPtr_SetDrawRangeToContainCaretPosition_Private_Void_Int32_0;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeMethodInfoPtr_ForceLabelUpdate_Public_Void_0;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeMethodInfoPtr_MarkGeometryAsDirty_Private_Void_0;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGeometry_Private_Void_0;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr_AssignPositioningIfNeeded_Private_Void_0;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeMethodInfoPtr_OnFillVBO_Private_Void_Mesh_0;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeMethodInfoPtr_GenerateCaret_Private_Void_VertexHelper_Vector2_0;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeMethodInfoPtr_CreateCursorVerts_Private_Void_0;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeMethodInfoPtr_GenerateHighlight_Private_Void_VertexHelper_Vector2_0;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Protected_Char_String_Int32_Char_0;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeMethodInfoPtr_ActivateInputField_Public_Void_0;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeMethodInfoPtr_ActivateInputFieldInternal_Private_Void_0;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateInputField_Public_Void_0;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_EnforceContentType_Private_Void_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_EnforceTextHOverflow_Private_Void_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_SetToCustomIfContentTypeIsNot_Private_Void_Il2CppStructArray_1_ContentType_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_SetToCustom_Private_Void_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0;

		// Token: 0x02000090 RID: 144
		public enum ContentType
		{
			// Token: 0x0400094E RID: 2382
			Standard,
			// Token: 0x0400094F RID: 2383
			Autocorrected,
			// Token: 0x04000950 RID: 2384
			IntegerNumber,
			// Token: 0x04000951 RID: 2385
			DecimalNumber,
			// Token: 0x04000952 RID: 2386
			Alphanumeric,
			// Token: 0x04000953 RID: 2387
			Name,
			// Token: 0x04000954 RID: 2388
			EmailAddress,
			// Token: 0x04000955 RID: 2389
			Password,
			// Token: 0x04000956 RID: 2390
			Pin,
			// Token: 0x04000957 RID: 2391
			Custom
		}

		// Token: 0x02000091 RID: 145
		public enum InputType
		{
			// Token: 0x04000959 RID: 2393
			Standard,
			// Token: 0x0400095A RID: 2394
			AutoCorrect,
			// Token: 0x0400095B RID: 2395
			Password
		}

		// Token: 0x02000092 RID: 146
		public enum CharacterValidation
		{
			// Token: 0x0400095D RID: 2397
			None,
			// Token: 0x0400095E RID: 2398
			Integer,
			// Token: 0x0400095F RID: 2399
			Decimal,
			// Token: 0x04000960 RID: 2400
			Alphanumeric,
			// Token: 0x04000961 RID: 2401
			Name,
			// Token: 0x04000962 RID: 2402
			EmailAddress
		}

		// Token: 0x02000093 RID: 147
		public enum LineType
		{
			// Token: 0x04000964 RID: 2404
			SingleLine,
			// Token: 0x04000965 RID: 2405
			MultiLineSubmit,
			// Token: 0x04000966 RID: 2406
			MultiLineNewline
		}

		// Token: 0x02000094 RID: 148
		public sealed class OnValidateInput : MulticastDelegate
		{
			// Token: 0x06000C47 RID: 3143 RVA: 0x00035D48 File Offset: 0x00033F48
			// Note: this type is marked as 'beforefieldinit'.
			static OnValidateInput()
			{
				Il2CppClassPointerStore<InputField.OnValidateInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputField>.NativeClassPtr, "OnValidateInput");
				InputField.OnValidateInput.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField.OnValidateInput>.NativeClassPtr, 100663856);
				InputField.OnValidateInput.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Char_String_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField.OnValidateInput>.NativeClassPtr, 100663857);
				InputField.OnValidateInput.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int32_Char_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField.OnValidateInput>.NativeClassPtr, 100663858);
				InputField.OnValidateInput.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Char_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField.OnValidateInput>.NativeClassPtr, 100663859);
			}

			// Token: 0x06000C48 RID: 3144 RVA: 0x00035DBC File Offset: 0x00033FBC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1041565, RefRangeEnd = 1041568, XrefRangeStart = 1041565, XrefRangeEnd = 1041568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnValidateInput(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputField.OnValidateInput>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.OnValidateInput.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C49 RID: 3145 RVA: 0x00035E18 File Offset: 0x00034018
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.OnValidateInput.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Char_String_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000C4A RID: 3146 RVA: 0x00035E84 File Offset: 0x00034084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086030, XrefRangeEnd = 1086037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, Object @object)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.OnValidateInput.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int32_Char_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000C4B RID: 3147 RVA: 0x00035F18 File Offset: 0x00034118
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe char EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.OnValidateInput.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Char_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000C4C RID: 3148 RVA: 0x000068A7 File Offset: 0x00004AA7
			public OnValidateInput(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000C4D RID: 3149 RVA: 0x000068B0 File Offset: 0x00004AB0
			public static implicit operator InputField.OnValidateInput(Func<string, int, char, char> A_0)
			{
				return DelegateSupport.ConvertDelegate<InputField.OnValidateInput>(A_0);
			}

			// Token: 0x06000C4E RID: 3150 RVA: 0x000068B8 File Offset: 0x00004AB8
			public static InputField.OnValidateInput operator +(InputField.OnValidateInput A_0, InputField.OnValidateInput A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<InputField.OnValidateInput>();
			}

			// Token: 0x06000C4F RID: 3151 RVA: 0x000068C6 File Offset: 0x00004AC6
			public static InputField.OnValidateInput operator -(InputField.OnValidateInput A_0, InputField.OnValidateInput A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<InputField.OnValidateInput>();
				}
				return delegate2;
			}

			// Token: 0x04000967 RID: 2407
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000968 RID: 2408
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Char_String_Int32_Char_0;

			// Token: 0x04000969 RID: 2409
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int32_Char_AsyncCallback_Object_0;

			// Token: 0x0400096A RID: 2410
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Char_IAsyncResult_0;
		}

		// Token: 0x02000095 RID: 149
		[Serializable]
		public class SubmitEvent : UnityEvent<string>
		{
			// Token: 0x06000C50 RID: 3152 RVA: 0x000068D7 File Offset: 0x00004AD7
			// Note: this type is marked as 'beforefieldinit'.
			static SubmitEvent()
			{
				Il2CppClassPointerStore<InputField.SubmitEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputField>.NativeClassPtr, "SubmitEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputField.SubmitEvent>.NativeClassPtr);
				InputField.SubmitEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField.SubmitEvent>.NativeClassPtr, 100663860);
			}

			// Token: 0x06000C51 RID: 3153 RVA: 0x00035F68 File Offset: 0x00034168
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086037, XrefRangeEnd = 1086040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SubmitEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputField.SubmitEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.SubmitEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C52 RID: 3154 RVA: 0x0000690B File Offset: 0x00004B0B
			public SubmitEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400096B RID: 2411
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000096 RID: 150
		[Serializable]
		public class EndEditEvent : UnityEvent<string>
		{
			// Token: 0x06000C53 RID: 3155 RVA: 0x00006914 File Offset: 0x00004B14
			// Note: this type is marked as 'beforefieldinit'.
			static EndEditEvent()
			{
				Il2CppClassPointerStore<InputField.EndEditEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputField>.NativeClassPtr, "EndEditEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputField.EndEditEvent>.NativeClassPtr);
				InputField.EndEditEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField.EndEditEvent>.NativeClassPtr, 100663861);
			}

			// Token: 0x06000C54 RID: 3156 RVA: 0x00035FA4 File Offset: 0x000341A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086040, XrefRangeEnd = 1086043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EndEditEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputField.EndEditEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.EndEditEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C55 RID: 3157 RVA: 0x00006948 File Offset: 0x00004B48
			public EndEditEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400096C RID: 2412
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000097 RID: 151
		[Serializable]
		public class OnChangeEvent : UnityEvent<string>
		{
			// Token: 0x06000C56 RID: 3158 RVA: 0x00006951 File Offset: 0x00004B51
			// Note: this type is marked as 'beforefieldinit'.
			static OnChangeEvent()
			{
				Il2CppClassPointerStore<InputField.OnChangeEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputField>.NativeClassPtr, "OnChangeEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputField.OnChangeEvent>.NativeClassPtr);
				InputField.OnChangeEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField.OnChangeEvent>.NativeClassPtr, 100663862);
			}

			// Token: 0x06000C57 RID: 3159 RVA: 0x00035FE0 File Offset: 0x000341E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086043, XrefRangeEnd = 1086046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnChangeEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputField.OnChangeEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField.OnChangeEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C58 RID: 3160 RVA: 0x00006985 File Offset: 0x00004B85
			public OnChangeEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400096D RID: 2413
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000098 RID: 152
		public enum EditState
		{
			// Token: 0x0400096F RID: 2415
			Continue,
			// Token: 0x04000970 RID: 2416
			Finish
		}

		// Token: 0x02000099 RID: 153
		[ObfuscatedName("UnityEngine.UI.InputField+<CaretBlink>d__170")]
		public sealed class _CaretBlink_d__170 : Object
		{
			// Token: 0x06000C59 RID: 3161 RVA: 0x0003601C File Offset: 0x0003421C
			// Note: this type is marked as 'beforefieldinit'.
			static _CaretBlink_d__170()
			{
				Il2CppClassPointerStore<InputField._CaretBlink_d__170>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputField>.NativeClassPtr, "<CaretBlink>d__170");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputField._CaretBlink_d__170>.NativeClassPtr);
				InputField._CaretBlink_d__170.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField._CaretBlink_d__170>.NativeClassPtr, "<>1__state");
				InputField._CaretBlink_d__170.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField._CaretBlink_d__170>.NativeClassPtr, "<>2__current");
				InputField._CaretBlink_d__170.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField._CaretBlink_d__170>.NativeClassPtr, "<>4__this");
				InputField._CaretBlink_d__170.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField._CaretBlink_d__170>.NativeClassPtr, 100663863);
				InputField._CaretBlink_d__170.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField._CaretBlink_d__170>.NativeClassPtr, 100663864);
				InputField._CaretBlink_d__170.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField._CaretBlink_d__170>.NativeClassPtr, 100663865);
				InputField._CaretBlink_d__170.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField._CaretBlink_d__170>.NativeClassPtr, 100663866);
				InputField._CaretBlink_d__170.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField._CaretBlink_d__170>.NativeClassPtr, 100663867);
				InputField._CaretBlink_d__170.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField._CaretBlink_d__170>.NativeClassPtr, 100663868);
			}

			// Token: 0x06000C5A RID: 3162 RVA: 0x000360FC File Offset: 0x000342FC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CaretBlink_d__170(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputField._CaretBlink_d__170>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField._CaretBlink_d__170.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C5B RID: 3163 RVA: 0x00036144 File Offset: 0x00034344
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField._CaretBlink_d__170.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C5C RID: 3164 RVA: 0x00036178 File Offset: 0x00034378
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086046, XrefRangeEnd = 1086051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField._CaretBlink_d__170.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000419 RID: 1049
			// (get) Token: 0x06000C5D RID: 3165 RVA: 0x000361B4 File Offset: 0x000343B4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField._CaretBlink_d__170.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000C5E RID: 3166 RVA: 0x000361F4 File Offset: 0x000343F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086051, XrefRangeEnd = 1086056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField._CaretBlink_d__170.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700041A RID: 1050
			// (get) Token: 0x06000C5F RID: 3167 RVA: 0x00036228 File Offset: 0x00034428
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField._CaretBlink_d__170.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000C60 RID: 3168 RVA: 0x0000698E File Offset: 0x00004B8E
			public _CaretBlink_d__170(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000416 RID: 1046
			// (get) Token: 0x06000C61 RID: 3169 RVA: 0x00036268 File Offset: 0x00034468
			// (set) Token: 0x06000C62 RID: 3170 RVA: 0x00006997 File Offset: 0x00004B97
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._CaretBlink_d__170.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._CaretBlink_d__170.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000417 RID: 1047
			// (get) Token: 0x06000C63 RID: 3171 RVA: 0x00036290 File Offset: 0x00034490
			// (set) Token: 0x06000C64 RID: 3172 RVA: 0x000069B2 File Offset: 0x00004BB2
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._CaretBlink_d__170.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._CaretBlink_d__170.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000418 RID: 1048
			// (get) Token: 0x06000C65 RID: 3173 RVA: 0x000362C0 File Offset: 0x000344C0
			// (set) Token: 0x06000C66 RID: 3174 RVA: 0x000069D1 File Offset: 0x00004BD1
			public unsafe InputField __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._CaretBlink_d__170.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._CaretBlink_d__170.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000971 RID: 2417
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000972 RID: 2418
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000973 RID: 2419
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000974 RID: 2420
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000975 RID: 2421
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000976 RID: 2422
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000977 RID: 2423
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000978 RID: 2424
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000979 RID: 2425
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200009A RID: 154
		[ObfuscatedName("UnityEngine.UI.InputField+<MouseDragOutsideRect>d__194")]
		public sealed class _MouseDragOutsideRect_d__194 : Object
		{
			// Token: 0x06000C67 RID: 3175 RVA: 0x000362F0 File Offset: 0x000344F0
			// Note: this type is marked as 'beforefieldinit'.
			static _MouseDragOutsideRect_d__194()
			{
				Il2CppClassPointerStore<InputField._MouseDragOutsideRect_d__194>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputField>.NativeClassPtr, "<MouseDragOutsideRect>d__194");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputField._MouseDragOutsideRect_d__194>.NativeClassPtr);
				InputField._MouseDragOutsideRect_d__194.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField._MouseDragOutsideRect_d__194>.NativeClassPtr, "<>1__state");
				InputField._MouseDragOutsideRect_d__194.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField._MouseDragOutsideRect_d__194>.NativeClassPtr, "<>2__current");
				InputField._MouseDragOutsideRect_d__194.NativeFieldInfoPtr_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField._MouseDragOutsideRect_d__194>.NativeClassPtr, "eventData");
				InputField._MouseDragOutsideRect_d__194.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputField._MouseDragOutsideRect_d__194>.NativeClassPtr, "<>4__this");
				InputField._MouseDragOutsideRect_d__194.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField._MouseDragOutsideRect_d__194>.NativeClassPtr, 100663869);
				InputField._MouseDragOutsideRect_d__194.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField._MouseDragOutsideRect_d__194>.NativeClassPtr, 100663870);
				InputField._MouseDragOutsideRect_d__194.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField._MouseDragOutsideRect_d__194>.NativeClassPtr, 100663871);
				InputField._MouseDragOutsideRect_d__194.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField._MouseDragOutsideRect_d__194>.NativeClassPtr, 100663872);
				InputField._MouseDragOutsideRect_d__194.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField._MouseDragOutsideRect_d__194>.NativeClassPtr, 100663873);
				InputField._MouseDragOutsideRect_d__194.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputField._MouseDragOutsideRect_d__194>.NativeClassPtr, 100663874);
			}

			// Token: 0x06000C68 RID: 3176 RVA: 0x000363E4 File Offset: 0x000345E4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MouseDragOutsideRect_d__194(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputField._MouseDragOutsideRect_d__194>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField._MouseDragOutsideRect_d__194.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C69 RID: 3177 RVA: 0x0003642C File Offset: 0x0003462C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField._MouseDragOutsideRect_d__194.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C6A RID: 3178 RVA: 0x00036460 File Offset: 0x00034660
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086056, XrefRangeEnd = 1086088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField._MouseDragOutsideRect_d__194.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700041F RID: 1055
			// (get) Token: 0x06000C6B RID: 3179 RVA: 0x0003649C File Offset: 0x0003469C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField._MouseDragOutsideRect_d__194.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000C6C RID: 3180 RVA: 0x000364DC File Offset: 0x000346DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086088, XrefRangeEnd = 1086093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField._MouseDragOutsideRect_d__194.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000420 RID: 1056
			// (get) Token: 0x06000C6D RID: 3181 RVA: 0x00036510 File Offset: 0x00034710
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputField._MouseDragOutsideRect_d__194.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000C6E RID: 3182 RVA: 0x000069F0 File Offset: 0x00004BF0
			public _MouseDragOutsideRect_d__194(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700041B RID: 1051
			// (get) Token: 0x06000C6F RID: 3183 RVA: 0x00036550 File Offset: 0x00034750
			// (set) Token: 0x06000C70 RID: 3184 RVA: 0x000069F9 File Offset: 0x00004BF9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._MouseDragOutsideRect_d__194.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._MouseDragOutsideRect_d__194.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700041C RID: 1052
			// (get) Token: 0x06000C71 RID: 3185 RVA: 0x00036578 File Offset: 0x00034778
			// (set) Token: 0x06000C72 RID: 3186 RVA: 0x00006A14 File Offset: 0x00004C14
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._MouseDragOutsideRect_d__194.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._MouseDragOutsideRect_d__194.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700041D RID: 1053
			// (get) Token: 0x06000C73 RID: 3187 RVA: 0x000365A8 File Offset: 0x000347A8
			// (set) Token: 0x06000C74 RID: 3188 RVA: 0x00006A33 File Offset: 0x00004C33
			public unsafe PointerEventData eventData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._MouseDragOutsideRect_d__194.NativeFieldInfoPtr_eventData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._MouseDragOutsideRect_d__194.NativeFieldInfoPtr_eventData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700041E RID: 1054
			// (get) Token: 0x06000C75 RID: 3189 RVA: 0x000365D8 File Offset: 0x000347D8
			// (set) Token: 0x06000C76 RID: 3190 RVA: 0x00006A52 File Offset: 0x00004C52
			public unsafe InputField __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._MouseDragOutsideRect_d__194.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputField._MouseDragOutsideRect_d__194.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400097A RID: 2426
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400097B RID: 2427
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400097C RID: 2428
			private static readonly IntPtr NativeFieldInfoPtr_eventData;

			// Token: 0x0400097D RID: 2429
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400097E RID: 2430
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400097F RID: 2431
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000980 RID: 2432
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000981 RID: 2433
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000982 RID: 2434
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000983 RID: 2435
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

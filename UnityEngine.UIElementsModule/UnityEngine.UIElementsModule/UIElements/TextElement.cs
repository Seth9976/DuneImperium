using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001DB RID: 475
	public class TextElement : BindableElement
	{
		// Token: 0x060024F9 RID: 9465 RVA: 0x000A5540 File Offset: 0x000A3740
		// Note: this type is marked as 'beforefieldinit'.
		static TextElement()
		{
			Il2CppClassPointerStore<TextElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TextElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextElement>.NativeClassPtr);
			TextElement.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "ussClassName");
			TextElement.NativeFieldInfoPtr__uitkTextHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "<uitkTextHandle>k__BackingField");
			TextElement.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "m_Text");
			TextElement.NativeFieldInfoPtr_m_EnableRichText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "m_EnableRichText");
			TextElement.NativeFieldInfoPtr_m_ParseEscapeSequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "m_ParseEscapeSequences");
			TextElement.NativeFieldInfoPtr_m_DisplayTooltipWhenElided = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "m_DisplayTooltipWhenElided");
			TextElement.NativeFieldInfoPtr__isElided_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "<isElided>k__BackingField");
			TextElement.NativeFieldInfoPtr_k_EllipsisText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "k_EllipsisText");
			TextElement.NativeFieldInfoPtr_elidedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "elidedText");
			TextElement.NativeFieldInfoPtr_m_WasElided = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "m_WasElided");
			TextElement.NativeFieldInfoPtr_editingManipulator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "editingManipulator");
			TextElement.NativeFieldInfoPtr_m_Multiline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "m_Multiline");
			TextElement.NativeFieldInfoPtr_m_TouchScreenKeyboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "m_TouchScreenKeyboard");
			TextElement.NativeFieldInfoPtr_m_KeyboardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "m_KeyboardType");
			TextElement.NativeFieldInfoPtr_m_HideMobileInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "m_HideMobileInput");
			TextElement.NativeFieldInfoPtr_m_IsReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "m_IsReadOnly");
			TextElement.NativeFieldInfoPtr_m_MaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "m_MaxLength");
			TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextEdition_isDelayed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "<UnityEngine.UIElements.ITextEdition.isDelayed>k__BackingField");
			TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextEdition_AcceptCharacter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "<UnityEngine.UIElements.ITextEdition.AcceptCharacter>k__BackingField");
			TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextEdition_UpdateScrollOffset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "<UnityEngine.UIElements.ITextEdition.UpdateScrollOffset>k__BackingField");
			TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextEdition_UpdateValueFromText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "<UnityEngine.UIElements.ITextEdition.UpdateValueFromText>k__BackingField");
			TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextEdition_UpdateTextFromValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "<UnityEngine.UIElements.ITextEdition.UpdateTextFromValue>k__BackingField");
			TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextEdition_MoveFocusToCompositeRoot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "<UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot>k__BackingField");
			TextElement.NativeFieldInfoPtr_m_RenderedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "m_RenderedText");
			TextElement.NativeFieldInfoPtr_m_OriginalText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "m_OriginalText");
			TextElement.NativeFieldInfoPtr_m_MaskChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "m_MaskChar");
			TextElement.NativeFieldInfoPtr_m_IsPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "m_IsPassword");
			TextElement.NativeFieldInfoPtr_m_AutoCorrection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "m_AutoCorrection");
			TextElement.NativeFieldInfoPtr_m_SelectingManipulator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "m_SelectingManipulator");
			TextElement.NativeFieldInfoPtr_m_IsSelectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "m_IsSelectable");
			TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextSelection_doubleClickSelectsWord_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "<UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord>k__BackingField");
			TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextSelection_tripleClickSelectsLine_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "<UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine>k__BackingField");
			TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextSelection_selectAllOnFocus_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "<UnityEngine.UIElements.ITextSelection.selectAllOnFocus>k__BackingField");
			TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextSelection_selectAllOnMouseUp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "<UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp>k__BackingField");
			TextElement.NativeFieldInfoPtr_m_SelectionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "m_SelectionColor");
			TextElement.NativeFieldInfoPtr_m_CursorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "m_CursorColor");
			TextElement.NativeFieldInfoPtr_m_CursorWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "m_CursorWidth");
			TextElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668887);
			TextElement.NativeMethodInfoPtr_get_uitkTextHandle_Internal_get_UITKTextHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668888);
			TextElement.NativeMethodInfoPtr_set_uitkTextHandle_Internal_set_Void_UITKTextHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668889);
			TextElement.NativeMethodInfoPtr_OnGeometryChanged_Private_Void_GeometryChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668890);
			TextElement.NativeMethodInfoPtr_get_text_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668891);
			TextElement.NativeMethodInfoPtr_set_text_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668892);
			TextElement.NativeMethodInfoPtr_get_enableRichText_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668893);
			TextElement.NativeMethodInfoPtr_set_enableRichText_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668894);
			TextElement.NativeMethodInfoPtr_get_parseEscapeSequences_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668895);
			TextElement.NativeMethodInfoPtr_set_parseEscapeSequences_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668896);
			TextElement.NativeMethodInfoPtr_get_displayTooltipWhenElided_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668897);
			TextElement.NativeMethodInfoPtr_set_displayTooltipWhenElided_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668898);
			TextElement.NativeMethodInfoPtr_get_isElided_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668899);
			TextElement.NativeMethodInfoPtr_set_isElided_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668900);
			TextElement.NativeMethodInfoPtr_OnGenerateVisualContent_Internal_Void_MeshGenerationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668901);
			TextElement.NativeMethodInfoPtr_ElideText_Internal_String_String_String_Single_TextOverflowPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668902);
			TextElement.NativeMethodInfoPtr_UpdateTooltip_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668903);
			TextElement.NativeMethodInfoPtr_UpdateVisibleText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668904);
			TextElement.NativeMethodInfoPtr_ShouldElide_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668905);
			TextElement.NativeMethodInfoPtr_get_hasFocus_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668906);
			TextElement.NativeMethodInfoPtr_MeasureTextSize_Public_Vector2_String_Single_MeasureMode_Single_MeasureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668907);
			TextElement.NativeMethodInfoPtr_DoMeasure_FamOrAssem_Virtual_Vector2_Single_MeasureMode_Single_MeasureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668908);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_INotifyValueChanged_System_String__get_value_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668909);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_INotifyValueChanged_System_String__set_value_Private_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668910);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_INotifyValueChanged_System_String__SetValueWithoutNotify_Private_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668911);
			TextElement.NativeMethodInfoPtr_get_edition_Internal_get_ITextEdition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668912);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_multiline_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668913);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_multiline_Private_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668914);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_keyboardType_Private_Virtual_Final_New_get_TouchScreenKeyboardType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668915);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_keyboardType_Private_Virtual_Final_New_set_Void_TouchScreenKeyboardType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668916);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_hideMobileInput_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668917);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_hideMobileInput_Private_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668918);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_isReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668919);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_isReadOnly_Private_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668920);
			TextElement.NativeMethodInfoPtr_ProcessMenuCommand_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668921);
			TextElement.NativeMethodInfoPtr_Cut_Private_Void_DropdownMenuAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668922);
			TextElement.NativeMethodInfoPtr_Copy_Private_Void_DropdownMenuAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668923);
			TextElement.NativeMethodInfoPtr_Paste_Private_Void_DropdownMenuAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668924);
			TextElement.NativeMethodInfoPtr_BuildContextualMenu_Private_Void_ContextualMenuPopulateEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668925);
			TextElement.NativeMethodInfoPtr_CutActionStatus_Private_Status_DropdownMenuAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668926);
			TextElement.NativeMethodInfoPtr_CopyActionStatus_Private_Status_DropdownMenuAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668927);
			TextElement.NativeMethodInfoPtr_PasteActionStatus_Private_Status_DropdownMenuAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668928);
			TextElement.NativeMethodInfoPtr_ExecuteDefaultActionAtTarget_Protected_Virtual_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668929);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_maxLength_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668930);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_maxLength_Private_Virtual_Final_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668931);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_isDelayed_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668932);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_isDelayed_Private_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668933);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_SaveValueAndText_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668934);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_RestoreValueAndText_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668935);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_AcceptCharacter_Private_Virtual_Final_New_get_Func_2_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668936);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_AcceptCharacter_Private_Virtual_Final_New_set_Void_Func_2_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668937);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_UpdateScrollOffset_Private_Virtual_Final_New_get_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668938);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_UpdateScrollOffset_Private_Virtual_Final_New_set_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668939);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_UpdateValueFromText_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668940);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_UpdateValueFromText_Private_Virtual_Final_New_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668941);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_UpdateTextFromValue_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668942);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_UpdateTextFromValue_Private_Virtual_Final_New_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668943);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_MoveFocusToCompositeRoot_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668944);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_MoveFocusToCompositeRoot_Private_Virtual_Final_New_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668945);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_UpdateText_Private_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668946);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_CullString_Private_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668947);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_maskChar_Private_Virtual_Final_New_set_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668948);
			TextElement.NativeMethodInfoPtr_get_effectiveMaskChar_Private_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668949);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_isPassword_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668950);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_isPassword_Private_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668951);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_autoCorrection_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668952);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_autoCorrection_Private_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668953);
			TextElement.NativeMethodInfoPtr_get_renderedText_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668954);
			TextElement.NativeMethodInfoPtr_set_renderedText_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668955);
			TextElement.NativeMethodInfoPtr_get_originalText_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668956);
			TextElement.NativeMethodInfoPtr_get_selection_Public_get_ITextSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668957);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_isSelectable_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668958);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_set_isSelectable_Private_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668959);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_cursorIndex_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668960);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_set_cursorIndex_Private_Virtual_Final_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668961);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_selectIndex_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668962);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_set_selectIndex_Private_Virtual_Final_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668963);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_SelectAll_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668964);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_SelectNone_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668965);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_HasSelection_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668966);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_doubleClickSelectsWord_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668967);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_tripleClickSelectsLine_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668968);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_selectAllOnFocus_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668969);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_set_selectAllOnFocus_Private_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668970);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_selectAllOnMouseUp_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668971);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_set_selectAllOnMouseUp_Private_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668972);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_cursorPosition_Private_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668973);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_lineHeightAtCursorPosition_Private_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668974);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_selectionColor_Private_Virtual_Final_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668975);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_set_selectionColor_Private_Virtual_Final_New_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668976);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_cursorColor_Private_Virtual_Final_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668977);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_set_cursorColor_Private_Virtual_Final_New_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668978);
			TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_cursorWidth_Private_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668979);
			TextElement.NativeMethodInfoPtr_get_selectingManipulator_Internal_get_TextSelectingManipulator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668980);
			TextElement.NativeMethodInfoPtr_DrawHighlighting_Private_Void_MeshGenerationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668981);
			TextElement.NativeMethodInfoPtr_DrawCaret_Internal_Void_MeshGenerationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668982);
			TextElement.NativeMethodInfoPtr_GetLastCharacterAt_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement>.NativeClassPtr, 100668983);
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x000A5FE8 File Offset: 0x000A41E8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 339500, RefRangeEnd = 339512, XrefRangeStart = 339465, XrefRangeEnd = 339500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x060024FB RID: 9467 RVA: 0x000A6024 File Offset: 0x000A4224
		// (set) Token: 0x060024FC RID: 9468 RVA: 0x000A6064 File Offset: 0x000A4264
		public unsafe UITKTextHandle uitkTextHandle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_get_uitkTextHandle_Internal_get_UITKTextHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UITKTextHandle>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_set_uitkTextHandle_Internal_set_Void_UITKTextHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x000A60A8 File Offset: 0x000A42A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339512, XrefRangeEnd = 339513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGeometryChanged(GeometryChangedEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_OnGeometryChanged_Private_Void_GeometryChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x060024FE RID: 9470 RVA: 0x000A60EC File Offset: 0x000A42EC
		// (set) Token: 0x060024FF RID: 9471 RVA: 0x000A6130 File Offset: 0x000A4330
		public unsafe virtual string text
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339513, XrefRangeEnd = 339516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextElement.NativeMethodInfoPtr_get_text_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339516, XrefRangeEnd = 339519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextElement.NativeMethodInfoPtr_set_text_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x06002500 RID: 9472 RVA: 0x000A6180 File Offset: 0x000A4380
		// (set) Token: 0x06002501 RID: 9473 RVA: 0x000A61BC File Offset: 0x000A43BC
		public unsafe bool enableRichText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_get_enableRichText_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 339520, RefRangeEnd = 339522, XrefRangeStart = 339519, XrefRangeEnd = 339520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_set_enableRichText_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x06002502 RID: 9474 RVA: 0x000A61FC File Offset: 0x000A43FC
		// (set) Token: 0x06002503 RID: 9475 RVA: 0x000A6238 File Offset: 0x000A4438
		public unsafe bool parseEscapeSequences
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_get_parseEscapeSequences_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 339523, RefRangeEnd = 339525, XrefRangeStart = 339522, XrefRangeEnd = 339523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_set_parseEscapeSequences_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06002504 RID: 9476 RVA: 0x000A6278 File Offset: 0x000A4478
		// (set) Token: 0x06002505 RID: 9477 RVA: 0x000A62B4 File Offset: 0x000A44B4
		public unsafe bool displayTooltipWhenElided
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_get_displayTooltipWhenElided_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339525, XrefRangeEnd = 339527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_set_displayTooltipWhenElided_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06002506 RID: 9478 RVA: 0x000A62F4 File Offset: 0x000A44F4
		// (set) Token: 0x06002507 RID: 9479 RVA: 0x000A6330 File Offset: 0x000A4530
		public unsafe bool isElided
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_get_isElided_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_set_isElided_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x000A6370 File Offset: 0x000A4570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339527, XrefRangeEnd = 339545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGenerateVisualContent(MeshGenerationContext mgc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_OnGenerateVisualContent_Internal_Void_MeshGenerationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x000A63B4 File Offset: 0x000A45B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 339584, RefRangeEnd = 339585, XrefRangeStart = 339545, XrefRangeEnd = 339584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ElideText(string drawText, string ellipsisText, float width, TextOverflowPosition textOverflowPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(drawText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ellipsisText);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textOverflowPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_ElideText_Internal_String_String_String_Single_TextOverflowPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x000A642C File Offset: 0x000A462C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339585, XrefRangeEnd = 339586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UpdateTooltip_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x000A6460 File Offset: 0x000A4660
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 339602, RefRangeEnd = 339606, XrefRangeStart = 339586, XrefRangeEnd = 339602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisibleText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UpdateVisibleText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x000A6494 File Offset: 0x000A4694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339606, XrefRangeEnd = 339608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldElide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_ShouldElide_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x0600250D RID: 9485 RVA: 0x000A64D0 File Offset: 0x000A46D0
		public unsafe bool hasFocus
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 339608, RefRangeEnd = 339623, XrefRangeStart = 339608, XrefRangeEnd = 339608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_get_hasFocus_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x000A650C File Offset: 0x000A470C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 339624, RefRangeEnd = 339627, XrefRangeStart = 339623, XrefRangeEnd = 339624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 MeasureTextSize(string textToMeasure, float width, VisualElement.MeasureMode widthMode, float height, VisualElement.MeasureMode heightMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(textToMeasure);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref widthMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_MeasureTextSize_Public_Vector2_String_Single_MeasureMode_Single_MeasureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x000A6594 File Offset: 0x000A4794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339627, XrefRangeEnd = 339644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desiredWidth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref widthMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref desiredHeight;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextElement.NativeMethodInfoPtr_DoMeasure_FamOrAssem_Virtual_Vector2_Single_MeasureMode_Single_MeasureMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06002510 RID: 9488 RVA: 0x000A6614 File Offset: 0x000A4814
		// (set) Token: 0x06002511 RID: 9489 RVA: 0x000A664C File Offset: 0x000A484C
		public unsafe virtual string UnityEngine.UIElements.INotifyValueChanged<System.String>.value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339644, XrefRangeEnd = 339646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_INotifyValueChanged_System_String__get_value_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339646, XrefRangeEnd = 339654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_INotifyValueChanged_System_String__set_value_Private_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002512 RID: 9490 RVA: 0x000A6690 File Offset: 0x000A4890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339654, XrefRangeEnd = 339667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_UIElements_INotifyValueChanged_System_String__SetValueWithoutNotify(string newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_INotifyValueChanged_System_String__SetValueWithoutNotify_Private_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06002513 RID: 9491 RVA: 0x000A66D4 File Offset: 0x000A48D4
		public unsafe ITextEdition edition
		{
			[CallerCount(1295)]
			[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_get_edition_Internal_get_ITextEdition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITextEdition>(intPtr3) : null;
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06002514 RID: 9492 RVA: 0x000A6714 File Offset: 0x000A4914
		// (set) Token: 0x06002515 RID: 9493 RVA: 0x000A6750 File Offset: 0x000A4950
		public unsafe virtual bool UnityEngine.UIElements.ITextEdition.multiline
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_multiline_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339667, XrefRangeEnd = 339670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_multiline_Private_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06002516 RID: 9494 RVA: 0x000A6790 File Offset: 0x000A4990
		// (set) Token: 0x06002517 RID: 9495 RVA: 0x000A67CC File Offset: 0x000A49CC
		public unsafe virtual TouchScreenKeyboardType UnityEngine.UIElements.ITextEdition.keyboardType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_keyboardType_Private_Virtual_Final_New_get_TouchScreenKeyboardType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_keyboardType_Private_Virtual_Final_New_set_Void_TouchScreenKeyboardType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06002518 RID: 9496 RVA: 0x000A680C File Offset: 0x000A4A0C
		// (set) Token: 0x06002519 RID: 9497 RVA: 0x000A6848 File Offset: 0x000A4A48
		public unsafe virtual bool UnityEngine.UIElements.ITextEdition.hideMobileInput
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339670, XrefRangeEnd = 339674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_hideMobileInput_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339674, XrefRangeEnd = 339678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_hideMobileInput_Private_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x0600251A RID: 9498 RVA: 0x000A6888 File Offset: 0x000A4A88
		// (set) Token: 0x0600251B RID: 9499 RVA: 0x000A68C4 File Offset: 0x000A4AC4
		public unsafe virtual bool UnityEngine.UIElements.ITextEdition.isReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_isReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339678, XrefRangeEnd = 339684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_isReadOnly_Private_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600251C RID: 9500 RVA: 0x000A6904 File Offset: 0x000A4B04
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 339694, RefRangeEnd = 339697, XrefRangeStart = 339684, XrefRangeEnd = 339694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessMenuCommand(string command)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_ProcessMenuCommand_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600251D RID: 9501 RVA: 0x000A6948 File Offset: 0x000A4B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339697, XrefRangeEnd = 339700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cut(DropdownMenuAction a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_Cut_Private_Void_DropdownMenuAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x000A698C File Offset: 0x000A4B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339700, XrefRangeEnd = 339703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Copy(DropdownMenuAction a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_Copy_Private_Void_DropdownMenuAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x000A69D0 File Offset: 0x000A4BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339703, XrefRangeEnd = 339706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Paste(DropdownMenuAction a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_Paste_Private_Void_DropdownMenuAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x000A6A14 File Offset: 0x000A4C14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 339733, RefRangeEnd = 339734, XrefRangeStart = 339706, XrefRangeEnd = 339733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildContextualMenu(ContextualMenuPopulateEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_BuildContextualMenu_Private_Void_ContextualMenuPopulateEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x000A6A58 File Offset: 0x000A4C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339734, XrefRangeEnd = 339741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DropdownMenuAction.Status CutActionStatus(DropdownMenuAction a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_CutActionStatus_Private_Status_DropdownMenuAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002522 RID: 9506 RVA: 0x000A6AA8 File Offset: 0x000A4CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339741, XrefRangeEnd = 339748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DropdownMenuAction.Status CopyActionStatus(DropdownMenuAction a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_CopyActionStatus_Private_Status_DropdownMenuAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002523 RID: 9507 RVA: 0x000A6AF8 File Offset: 0x000A4CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339748, XrefRangeEnd = 339750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DropdownMenuAction.Status PasteActionStatus(DropdownMenuAction a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_PasteActionStatus_Private_Status_DropdownMenuAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x000A6B48 File Offset: 0x000A4D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339750, XrefRangeEnd = 339782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ExecuteDefaultActionAtTarget(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextElement.NativeMethodInfoPtr_ExecuteDefaultActionAtTarget_Protected_Virtual_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06002525 RID: 9509 RVA: 0x000A6B98 File Offset: 0x000A4D98
		// (set) Token: 0x06002526 RID: 9510 RVA: 0x000A6BD4 File Offset: 0x000A4DD4
		public unsafe virtual int UnityEngine.UIElements.ITextEdition.maxLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_maxLength_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339782, XrefRangeEnd = 339785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_maxLength_Private_Virtual_Final_New_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06002527 RID: 9511 RVA: 0x000A6C14 File Offset: 0x000A4E14
		// (set) Token: 0x06002528 RID: 9512 RVA: 0x000A6C50 File Offset: 0x000A4E50
		public unsafe virtual bool UnityEngine.UIElements.ITextEdition.isDelayed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_isDelayed_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_isDelayed_Private_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002529 RID: 9513 RVA: 0x000A6C90 File Offset: 0x000A4E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339785, XrefRangeEnd = 339786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_UIElements_ITextEdition_SaveValueAndText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_SaveValueAndText_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600252A RID: 9514 RVA: 0x000A6CC4 File Offset: 0x000A4EC4
		[CallerCount(0)]
		public unsafe virtual void UnityEngine_UIElements_ITextEdition_RestoreValueAndText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_RestoreValueAndText_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x0600252B RID: 9515 RVA: 0x000A6CF8 File Offset: 0x000A4EF8
		// (set) Token: 0x0600252C RID: 9516 RVA: 0x000A6D38 File Offset: 0x000A4F38
		public unsafe virtual Func<char, bool> UnityEngine.UIElements.ITextEdition.AcceptCharacter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_AcceptCharacter_Private_Virtual_Final_New_get_Func_2_Char_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<char, bool>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339786, XrefRangeEnd = 339787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_AcceptCharacter_Private_Virtual_Final_New_set_Void_Func_2_Char_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x0600252D RID: 9517 RVA: 0x000A6D7C File Offset: 0x000A4F7C
		// (set) Token: 0x0600252E RID: 9518 RVA: 0x000A6DBC File Offset: 0x000A4FBC
		public unsafe virtual Action<bool> UnityEngine.UIElements.ITextEdition.UpdateScrollOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_UpdateScrollOffset_Private_Virtual_Final_New_get_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339787, XrefRangeEnd = 339788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_UpdateScrollOffset_Private_Virtual_Final_New_set_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x0600252F RID: 9519 RVA: 0x000A6E00 File Offset: 0x000A5000
		// (set) Token: 0x06002530 RID: 9520 RVA: 0x000A6E40 File Offset: 0x000A5040
		public unsafe virtual Action UnityEngine.UIElements.ITextEdition.UpdateValueFromText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_UpdateValueFromText_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339788, XrefRangeEnd = 339789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_UpdateValueFromText_Private_Virtual_Final_New_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x06002531 RID: 9521 RVA: 0x000A6E84 File Offset: 0x000A5084
		// (set) Token: 0x06002532 RID: 9522 RVA: 0x000A6EC4 File Offset: 0x000A50C4
		public unsafe virtual Action UnityEngine.UIElements.ITextEdition.UpdateTextFromValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_UpdateTextFromValue_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339789, XrefRangeEnd = 339790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_UpdateTextFromValue_Private_Virtual_Final_New_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x06002533 RID: 9523 RVA: 0x000A6F08 File Offset: 0x000A5108
		// (set) Token: 0x06002534 RID: 9524 RVA: 0x000A6F48 File Offset: 0x000A5148
		public unsafe virtual Action UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_MoveFocusToCompositeRoot_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_MoveFocusToCompositeRoot_Private_Virtual_Final_New_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x000A6F8C File Offset: 0x000A518C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339790, XrefRangeEnd = 339810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_UIElements_ITextEdition_UpdateText(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_UpdateText_Private_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x000A6FD0 File Offset: 0x000A51D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339810, XrefRangeEnd = 339814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string UnityEngine_UIElements_ITextEdition_CullString(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_CullString_Private_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x060025A8 RID: 9640 RVA: 0x0000F743 File Offset: 0x0000D943
		// (set) Token: 0x06002537 RID: 9527 RVA: 0x000A7018 File Offset: 0x000A5218
		public unsafe virtual char UnityEngine.UIElements.ITextEdition.maskChar
		{
			get
			{
				return this.m_MaskChar;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339814, XrefRangeEnd = 339818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_maskChar_Private_Virtual_Final_New_set_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06002538 RID: 9528 RVA: 0x000A7058 File Offset: 0x000A5258
		public unsafe char effectiveMaskChar
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339818, XrefRangeEnd = 339821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_get_effectiveMaskChar_Private_get_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06002539 RID: 9529 RVA: 0x000A7094 File Offset: 0x000A5294
		// (set) Token: 0x0600253A RID: 9530 RVA: 0x000A70D0 File Offset: 0x000A52D0
		public unsafe virtual bool UnityEngine.UIElements.ITextEdition.isPassword
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_isPassword_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339821, XrefRangeEnd = 339822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_isPassword_Private_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x0600253B RID: 9531 RVA: 0x000A7110 File Offset: 0x000A5310
		// (set) Token: 0x0600253C RID: 9532 RVA: 0x000A714C File Offset: 0x000A534C
		public unsafe virtual bool UnityEngine.UIElements.ITextEdition.autoCorrection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_autoCorrection_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_autoCorrection_Private_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x0600253D RID: 9533 RVA: 0x000A718C File Offset: 0x000A538C
		// (set) Token: 0x0600253E RID: 9534 RVA: 0x000A71C4 File Offset: 0x000A53C4
		public unsafe string renderedText
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 339835, RefRangeEnd = 339836, XrefRangeStart = 339822, XrefRangeEnd = 339835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_get_renderedText_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339836, XrefRangeEnd = 339840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_set_renderedText_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x0600253F RID: 9535 RVA: 0x000A7208 File Offset: 0x000A5408
		public unsafe string originalText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_get_originalText_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06002540 RID: 9536 RVA: 0x000A7240 File Offset: 0x000A5440
		public unsafe ITextSelection selection
		{
			[CallerCount(1295)]
			[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_get_selection_Public_get_ITextSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITextSelection>(intPtr3) : null;
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x06002541 RID: 9537 RVA: 0x000A7280 File Offset: 0x000A5480
		// (set) Token: 0x06002542 RID: 9538 RVA: 0x000A72BC File Offset: 0x000A54BC
		public unsafe virtual bool UnityEngine.UIElements.ITextSelection.isSelectable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_isSelectable_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_set_isSelectable_Private_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06002543 RID: 9539 RVA: 0x000A72FC File Offset: 0x000A54FC
		// (set) Token: 0x06002544 RID: 9540 RVA: 0x000A7338 File Offset: 0x000A5538
		public unsafe virtual int UnityEngine.UIElements.ITextSelection.cursorIndex
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339840, XrefRangeEnd = 339845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_cursorIndex_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339845, XrefRangeEnd = 339850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_set_cursorIndex_Private_Virtual_Final_New_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06002545 RID: 9541 RVA: 0x000A7378 File Offset: 0x000A5578
		// (set) Token: 0x06002546 RID: 9542 RVA: 0x000A73B4 File Offset: 0x000A55B4
		public unsafe virtual int UnityEngine.UIElements.ITextSelection.selectIndex
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339850, XrefRangeEnd = 339855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_selectIndex_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339855, XrefRangeEnd = 339860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_set_selectIndex_Private_Virtual_Final_New_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002547 RID: 9543 RVA: 0x000A73F4 File Offset: 0x000A55F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339860, XrefRangeEnd = 339865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_UIElements_ITextSelection_SelectAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_SelectAll_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002548 RID: 9544 RVA: 0x000A7428 File Offset: 0x000A5628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339865, XrefRangeEnd = 339870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_UIElements_ITextSelection_SelectNone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_SelectNone_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x000A745C File Offset: 0x000A565C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339870, XrefRangeEnd = 339873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool UnityEngine_UIElements_ITextSelection_HasSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_HasSelection_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x0600254A RID: 9546 RVA: 0x000A7498 File Offset: 0x000A5698
		// (set) Token: 0x060025AC RID: 9644 RVA: 0x0000F759 File Offset: 0x0000D959
		public unsafe virtual bool UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_doubleClickSelectsWord_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._UnityEngine_UIElements_ITextSelection_doubleClickSelectsWord_k__BackingField = value;
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x0600254B RID: 9547 RVA: 0x000A74D4 File Offset: 0x000A56D4
		// (set) Token: 0x060025AD RID: 9645 RVA: 0x0000F762 File Offset: 0x0000D962
		public unsafe virtual bool UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_tripleClickSelectsLine_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._UnityEngine_UIElements_ITextSelection_tripleClickSelectsLine_k__BackingField = value;
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x0600254C RID: 9548 RVA: 0x000A7510 File Offset: 0x000A5710
		// (set) Token: 0x0600254D RID: 9549 RVA: 0x000A754C File Offset: 0x000A574C
		public unsafe virtual bool UnityEngine.UIElements.ITextSelection.selectAllOnFocus
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_selectAllOnFocus_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_set_selectAllOnFocus_Private_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x0600254E RID: 9550 RVA: 0x000A758C File Offset: 0x000A578C
		// (set) Token: 0x0600254F RID: 9551 RVA: 0x000A75C8 File Offset: 0x000A57C8
		public unsafe virtual bool UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_selectAllOnMouseUp_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_set_selectAllOnMouseUp_Private_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06002550 RID: 9552 RVA: 0x000A7608 File Offset: 0x000A5808
		public unsafe virtual Vector2 UnityEngine.UIElements.ITextSelection.cursorPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339873, XrefRangeEnd = 339878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_cursorPosition_Private_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06002551 RID: 9553 RVA: 0x000A7644 File Offset: 0x000A5844
		public unsafe virtual float UnityEngine.UIElements.ITextSelection.lineHeightAtCursorPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339878, XrefRangeEnd = 339883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_lineHeightAtCursorPosition_Private_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x06002552 RID: 9554 RVA: 0x000A7680 File Offset: 0x000A5880
		// (set) Token: 0x06002553 RID: 9555 RVA: 0x000A76BC File Offset: 0x000A58BC
		public unsafe virtual Color UnityEngine.UIElements.ITextSelection.selectionColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_selectionColor_Private_Virtual_Final_New_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339883, XrefRangeEnd = 339884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_set_selectionColor_Private_Virtual_Final_New_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x06002554 RID: 9556 RVA: 0x000A76FC File Offset: 0x000A58FC
		// (set) Token: 0x06002555 RID: 9557 RVA: 0x000A7738 File Offset: 0x000A5938
		public unsafe virtual Color UnityEngine.UIElements.ITextSelection.cursorColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_cursorColor_Private_Virtual_Final_New_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339884, XrefRangeEnd = 339885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_set_cursorColor_Private_Virtual_Final_New_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x06002556 RID: 9558 RVA: 0x000A7778 File Offset: 0x000A5978
		// (set) Token: 0x060025B1 RID: 9649 RVA: 0x000A7F5C File Offset: 0x000A615C
		public unsafe virtual float UnityEngine.UIElements.ITextSelection.cursorWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_cursorWidth_Private_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = Mathf.Approximately(this.m_CursorWidth, value);
				if (!flag)
				{
					this.m_CursorWidth = value;
					base.MarkDirtyRepaint();
				}
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x06002557 RID: 9559 RVA: 0x000A77B4 File Offset: 0x000A59B4
		public unsafe TextSelectingManipulator selectingManipulator
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 339890, RefRangeEnd = 339899, XrefRangeStart = 339885, XrefRangeEnd = 339890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_get_selectingManipulator_Internal_get_TextSelectingManipulator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextSelectingManipulator>(intPtr3) : null;
			}
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x000A77F4 File Offset: 0x000A59F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 339950, RefRangeEnd = 339951, XrefRangeStart = 339899, XrefRangeEnd = 339950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawHighlighting(MeshGenerationContext mgc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_DrawHighlighting_Private_Void_MeshGenerationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x000A7838 File Offset: 0x000A5A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339951, XrefRangeEnd = 339975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawCaret(MeshGenerationContext mgc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_DrawCaret_Internal_Void_MeshGenerationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x000A787C File Offset: 0x000A5A7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 339981, RefRangeEnd = 339982, XrefRangeStart = 339975, XrefRangeEnd = 339981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLastCharacterAt(int lineIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lineIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.NativeMethodInfoPtr_GetLastCharacterAt_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x0000F329 File Offset: 0x0000D529
		public TextElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x0600255C RID: 9564 RVA: 0x000A78C8 File Offset: 0x000A5AC8
		// (set) Token: 0x0600255D RID: 9565 RVA: 0x0000F332 File Offset: 0x0000D532
		public unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextElement.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextElement.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x0600255E RID: 9566 RVA: 0x000A78E8 File Offset: 0x000A5AE8
		// (set) Token: 0x0600255F RID: 9567 RVA: 0x0000F344 File Offset: 0x0000D544
		public unsafe UITKTextHandle _uitkTextHandle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr__uitkTextHandle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UITKTextHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr__uitkTextHandle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x06002560 RID: 9568 RVA: 0x000A7918 File Offset: 0x000A5B18
		// (set) Token: 0x06002561 RID: 9569 RVA: 0x0000F363 File Offset: 0x0000D563
		public unsafe string m_Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06002562 RID: 9570 RVA: 0x000A7940 File Offset: 0x000A5B40
		// (set) Token: 0x06002563 RID: 9571 RVA: 0x0000F382 File Offset: 0x0000D582
		public unsafe bool m_EnableRichText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_EnableRichText);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_EnableRichText)) = value;
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06002564 RID: 9572 RVA: 0x000A7968 File Offset: 0x000A5B68
		// (set) Token: 0x06002565 RID: 9573 RVA: 0x0000F39D File Offset: 0x0000D59D
		public unsafe bool m_ParseEscapeSequences
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_ParseEscapeSequences);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_ParseEscapeSequences)) = value;
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06002566 RID: 9574 RVA: 0x000A7990 File Offset: 0x000A5B90
		// (set) Token: 0x06002567 RID: 9575 RVA: 0x0000F3B8 File Offset: 0x0000D5B8
		public unsafe bool m_DisplayTooltipWhenElided
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_DisplayTooltipWhenElided);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_DisplayTooltipWhenElided)) = value;
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x06002568 RID: 9576 RVA: 0x000A79B8 File Offset: 0x000A5BB8
		// (set) Token: 0x06002569 RID: 9577 RVA: 0x0000F3D3 File Offset: 0x0000D5D3
		public unsafe bool _isElided_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr__isElided_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr__isElided_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x0600256A RID: 9578 RVA: 0x000A79E0 File Offset: 0x000A5BE0
		// (set) Token: 0x0600256B RID: 9579 RVA: 0x0000F3EE File Offset: 0x0000D5EE
		public unsafe static string k_EllipsisText
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextElement.NativeFieldInfoPtr_k_EllipsisText, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextElement.NativeFieldInfoPtr_k_EllipsisText, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x0600256C RID: 9580 RVA: 0x000A7A00 File Offset: 0x000A5C00
		// (set) Token: 0x0600256D RID: 9581 RVA: 0x0000F400 File Offset: 0x0000D600
		public unsafe string elidedText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_elidedText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_elidedText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x0600256E RID: 9582 RVA: 0x000A7A28 File Offset: 0x000A5C28
		// (set) Token: 0x0600256F RID: 9583 RVA: 0x0000F41F File Offset: 0x0000D61F
		public unsafe bool m_WasElided
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_WasElided);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_WasElided)) = value;
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06002570 RID: 9584 RVA: 0x000A7A50 File Offset: 0x000A5C50
		// (set) Token: 0x06002571 RID: 9585 RVA: 0x0000F43A File Offset: 0x0000D63A
		public unsafe TextEditingManipulator editingManipulator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_editingManipulator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextEditingManipulator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_editingManipulator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06002572 RID: 9586 RVA: 0x000A7A80 File Offset: 0x000A5C80
		// (set) Token: 0x06002573 RID: 9587 RVA: 0x0000F459 File Offset: 0x0000D659
		public unsafe bool m_Multiline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_Multiline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_Multiline)) = value;
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06002574 RID: 9588 RVA: 0x000A7AA8 File Offset: 0x000A5CA8
		// (set) Token: 0x06002575 RID: 9589 RVA: 0x0000F474 File Offset: 0x0000D674
		public unsafe TouchScreenKeyboard m_TouchScreenKeyboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_TouchScreenKeyboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchScreenKeyboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_TouchScreenKeyboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06002576 RID: 9590 RVA: 0x000A7AD8 File Offset: 0x000A5CD8
		// (set) Token: 0x06002577 RID: 9591 RVA: 0x0000F493 File Offset: 0x0000D693
		public unsafe TouchScreenKeyboardType m_KeyboardType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_KeyboardType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_KeyboardType)) = value;
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06002578 RID: 9592 RVA: 0x000A7B00 File Offset: 0x000A5D00
		// (set) Token: 0x06002579 RID: 9593 RVA: 0x0000F4AE File Offset: 0x0000D6AE
		public unsafe bool m_HideMobileInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_HideMobileInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_HideMobileInput)) = value;
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x0600257A RID: 9594 RVA: 0x000A7B28 File Offset: 0x000A5D28
		// (set) Token: 0x0600257B RID: 9595 RVA: 0x0000F4C9 File Offset: 0x0000D6C9
		public unsafe bool m_IsReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_IsReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_IsReadOnly)) = value;
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x0600257C RID: 9596 RVA: 0x000A7B50 File Offset: 0x000A5D50
		// (set) Token: 0x0600257D RID: 9597 RVA: 0x0000F4E4 File Offset: 0x0000D6E4
		public unsafe int m_MaxLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_MaxLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_MaxLength)) = value;
			}
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x0600257E RID: 9598 RVA: 0x000A7B78 File Offset: 0x000A5D78
		// (set) Token: 0x0600257F RID: 9599 RVA: 0x0000F4FF File Offset: 0x0000D6FF
		public unsafe bool _UnityEngine_UIElements_ITextEdition_isDelayed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextEdition_isDelayed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextEdition_isDelayed_k__BackingField)) = value;
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06002580 RID: 9600 RVA: 0x000A7BA0 File Offset: 0x000A5DA0
		// (set) Token: 0x06002581 RID: 9601 RVA: 0x0000F51A File Offset: 0x0000D71A
		public unsafe Func<char, bool> _UnityEngine_UIElements_ITextEdition_AcceptCharacter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextEdition_AcceptCharacter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<char, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextEdition_AcceptCharacter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06002582 RID: 9602 RVA: 0x000A7BD0 File Offset: 0x000A5DD0
		// (set) Token: 0x06002583 RID: 9603 RVA: 0x0000F539 File Offset: 0x0000D739
		public unsafe Action<bool> _UnityEngine_UIElements_ITextEdition_UpdateScrollOffset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextEdition_UpdateScrollOffset_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextEdition_UpdateScrollOffset_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06002584 RID: 9604 RVA: 0x000A7C00 File Offset: 0x000A5E00
		// (set) Token: 0x06002585 RID: 9605 RVA: 0x0000F558 File Offset: 0x0000D758
		public unsafe Action _UnityEngine_UIElements_ITextEdition_UpdateValueFromText_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextEdition_UpdateValueFromText_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextEdition_UpdateValueFromText_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06002586 RID: 9606 RVA: 0x000A7C30 File Offset: 0x000A5E30
		// (set) Token: 0x06002587 RID: 9607 RVA: 0x0000F577 File Offset: 0x0000D777
		public unsafe Action _UnityEngine_UIElements_ITextEdition_UpdateTextFromValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextEdition_UpdateTextFromValue_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextEdition_UpdateTextFromValue_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x06002588 RID: 9608 RVA: 0x000A7C60 File Offset: 0x000A5E60
		// (set) Token: 0x06002589 RID: 9609 RVA: 0x0000F596 File Offset: 0x0000D796
		public unsafe Action _UnityEngine_UIElements_ITextEdition_MoveFocusToCompositeRoot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextEdition_MoveFocusToCompositeRoot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextEdition_MoveFocusToCompositeRoot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x0600258A RID: 9610 RVA: 0x000A7C90 File Offset: 0x000A5E90
		// (set) Token: 0x0600258B RID: 9611 RVA: 0x0000F5B5 File Offset: 0x0000D7B5
		public unsafe string m_RenderedText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_RenderedText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_RenderedText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x0600258C RID: 9612 RVA: 0x000A7CB8 File Offset: 0x000A5EB8
		// (set) Token: 0x0600258D RID: 9613 RVA: 0x0000F5D4 File Offset: 0x0000D7D4
		public unsafe string m_OriginalText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_OriginalText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_OriginalText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x0600258E RID: 9614 RVA: 0x000A7CE0 File Offset: 0x000A5EE0
		// (set) Token: 0x0600258F RID: 9615 RVA: 0x0000F5F3 File Offset: 0x0000D7F3
		public unsafe char m_MaskChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_MaskChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_MaskChar)) = value;
			}
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06002590 RID: 9616 RVA: 0x000A7D08 File Offset: 0x000A5F08
		// (set) Token: 0x06002591 RID: 9617 RVA: 0x0000F60E File Offset: 0x0000D80E
		public unsafe bool m_IsPassword
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_IsPassword);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_IsPassword)) = value;
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06002592 RID: 9618 RVA: 0x000A7D30 File Offset: 0x000A5F30
		// (set) Token: 0x06002593 RID: 9619 RVA: 0x0000F629 File Offset: 0x0000D829
		public unsafe bool m_AutoCorrection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_AutoCorrection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_AutoCorrection)) = value;
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06002594 RID: 9620 RVA: 0x000A7D58 File Offset: 0x000A5F58
		// (set) Token: 0x06002595 RID: 9621 RVA: 0x0000F644 File Offset: 0x0000D844
		public unsafe TextSelectingManipulator m_SelectingManipulator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_SelectingManipulator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextSelectingManipulator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_SelectingManipulator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06002596 RID: 9622 RVA: 0x000A7D88 File Offset: 0x000A5F88
		// (set) Token: 0x06002597 RID: 9623 RVA: 0x0000F663 File Offset: 0x0000D863
		public unsafe bool m_IsSelectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_IsSelectable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_IsSelectable)) = value;
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06002598 RID: 9624 RVA: 0x000A7DB0 File Offset: 0x000A5FB0
		// (set) Token: 0x06002599 RID: 9625 RVA: 0x0000F67E File Offset: 0x0000D87E
		public unsafe bool _UnityEngine_UIElements_ITextSelection_doubleClickSelectsWord_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextSelection_doubleClickSelectsWord_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextSelection_doubleClickSelectsWord_k__BackingField)) = value;
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x0600259A RID: 9626 RVA: 0x000A7DD8 File Offset: 0x000A5FD8
		// (set) Token: 0x0600259B RID: 9627 RVA: 0x0000F699 File Offset: 0x0000D899
		public unsafe bool _UnityEngine_UIElements_ITextSelection_tripleClickSelectsLine_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextSelection_tripleClickSelectsLine_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextSelection_tripleClickSelectsLine_k__BackingField)) = value;
			}
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x0600259C RID: 9628 RVA: 0x000A7E00 File Offset: 0x000A6000
		// (set) Token: 0x0600259D RID: 9629 RVA: 0x0000F6B4 File Offset: 0x0000D8B4
		public unsafe bool _UnityEngine_UIElements_ITextSelection_selectAllOnFocus_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextSelection_selectAllOnFocus_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextSelection_selectAllOnFocus_k__BackingField)) = value;
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x0600259E RID: 9630 RVA: 0x000A7E28 File Offset: 0x000A6028
		// (set) Token: 0x0600259F RID: 9631 RVA: 0x0000F6CF File Offset: 0x0000D8CF
		public unsafe bool _UnityEngine_UIElements_ITextSelection_selectAllOnMouseUp_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextSelection_selectAllOnMouseUp_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr__UnityEngine_UIElements_ITextSelection_selectAllOnMouseUp_k__BackingField)) = value;
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x060025A0 RID: 9632 RVA: 0x000A7E50 File Offset: 0x000A6050
		// (set) Token: 0x060025A1 RID: 9633 RVA: 0x0000F6EA File Offset: 0x0000D8EA
		public unsafe Color m_SelectionColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_SelectionColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_SelectionColor)) = value;
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x060025A2 RID: 9634 RVA: 0x000A7E78 File Offset: 0x000A6078
		// (set) Token: 0x060025A3 RID: 9635 RVA: 0x0000F705 File Offset: 0x0000D905
		public unsafe Color m_CursorColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_CursorColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_CursorColor)) = value;
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x060025A4 RID: 9636 RVA: 0x000A7EA0 File Offset: 0x000A60A0
		// (set) Token: 0x060025A5 RID: 9637 RVA: 0x0000F720 File Offset: 0x0000D920
		public unsafe float m_CursorWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_CursorWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.NativeFieldInfoPtr_m_CursorWidth)) = value;
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x060025A6 RID: 9638 RVA: 0x0000F73B File Offset: 0x0000D93B
		public TouchScreenKeyboard UnityEngine.UIElements.ITextEdition.touchScreenKeyboard
		{
			get
			{
				return this.m_TouchScreenKeyboard;
			}
		}

		// Token: 0x060025A7 RID: 9639 RVA: 0x000A7EC8 File Offset: 0x000A60C8
		public void UnityEngine.UIElements.ITextEdition.ResetValueAndText()
		{
			this.m_OriginalText = (this.text = null);
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x060025A9 RID: 9641 RVA: 0x0000F74B File Offset: 0x0000D94B
		public new ITextElementExperimentalFeatures experimental
		{
			get
			{
				return this;
			}
		}

		// Token: 0x060025AA RID: 9642 RVA: 0x0000F74E File Offset: 0x0000D94E
		public void UnityEngine.UIElements.ITextElementExperimentalFeatures.SetRenderedText(string renderedText)
		{
			this.renderedText = renderedText;
		}

		// Token: 0x060025AB RID: 9643 RVA: 0x000A7EE8 File Offset: 0x000A60E8
		public void UnityEngine.UIElements.ITextSelection.SelectRange(int cursorIndex, int selectionIndex)
		{
			bool isSelectable = this.selection.isSelectable;
			if (isSelectable)
			{
				this.selectingManipulator.m_SelectingUtilities.cursorIndex = cursorIndex;
				this.selectingManipulator.m_SelectingUtilities.selectIndex = selectionIndex;
			}
		}

		// Token: 0x060025AE RID: 9646 RVA: 0x000A7F2C File Offset: 0x000A612C
		public void UnityEngine.UIElements.ITextSelection.MoveTextEnd()
		{
			bool isSelectable = this.selection.isSelectable;
			if (isSelectable)
			{
				this.selectingManipulator.m_SelectingUtilities.MoveTextEnd();
			}
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x060025AF RID: 9647 RVA: 0x0000F76B File Offset: 0x0000D96B
		// (set) Token: 0x060025B0 RID: 9648 RVA: 0x0000F778 File Offset: 0x0000D978
		public Color cursorColor
		{
			get
			{
				return this.selection.cursorColor;
			}
			set
			{
				this.selection.cursorColor = value;
			}
		}

		// Token: 0x04001A93 RID: 6803
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x04001A94 RID: 6804
		private static readonly IntPtr NativeFieldInfoPtr__uitkTextHandle_k__BackingField;

		// Token: 0x04001A95 RID: 6805
		private static readonly IntPtr NativeFieldInfoPtr_m_Text;

		// Token: 0x04001A96 RID: 6806
		private static readonly IntPtr NativeFieldInfoPtr_m_EnableRichText;

		// Token: 0x04001A97 RID: 6807
		private static readonly IntPtr NativeFieldInfoPtr_m_ParseEscapeSequences;

		// Token: 0x04001A98 RID: 6808
		private static readonly IntPtr NativeFieldInfoPtr_m_DisplayTooltipWhenElided;

		// Token: 0x04001A99 RID: 6809
		private static readonly IntPtr NativeFieldInfoPtr__isElided_k__BackingField;

		// Token: 0x04001A9A RID: 6810
		private static readonly IntPtr NativeFieldInfoPtr_k_EllipsisText;

		// Token: 0x04001A9B RID: 6811
		private static readonly IntPtr NativeFieldInfoPtr_elidedText;

		// Token: 0x04001A9C RID: 6812
		private static readonly IntPtr NativeFieldInfoPtr_m_WasElided;

		// Token: 0x04001A9D RID: 6813
		private static readonly IntPtr NativeFieldInfoPtr_editingManipulator;

		// Token: 0x04001A9E RID: 6814
		private static readonly IntPtr NativeFieldInfoPtr_m_Multiline;

		// Token: 0x04001A9F RID: 6815
		private static readonly IntPtr NativeFieldInfoPtr_m_TouchScreenKeyboard;

		// Token: 0x04001AA0 RID: 6816
		private static readonly IntPtr NativeFieldInfoPtr_m_KeyboardType;

		// Token: 0x04001AA1 RID: 6817
		private static readonly IntPtr NativeFieldInfoPtr_m_HideMobileInput;

		// Token: 0x04001AA2 RID: 6818
		private static readonly IntPtr NativeFieldInfoPtr_m_IsReadOnly;

		// Token: 0x04001AA3 RID: 6819
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxLength;

		// Token: 0x04001AA4 RID: 6820
		private static readonly IntPtr NativeFieldInfoPtr__UnityEngine_UIElements_ITextEdition_isDelayed_k__BackingField;

		// Token: 0x04001AA5 RID: 6821
		private static readonly IntPtr NativeFieldInfoPtr__UnityEngine_UIElements_ITextEdition_AcceptCharacter_k__BackingField;

		// Token: 0x04001AA6 RID: 6822
		private static readonly IntPtr NativeFieldInfoPtr__UnityEngine_UIElements_ITextEdition_UpdateScrollOffset_k__BackingField;

		// Token: 0x04001AA7 RID: 6823
		private static readonly IntPtr NativeFieldInfoPtr__UnityEngine_UIElements_ITextEdition_UpdateValueFromText_k__BackingField;

		// Token: 0x04001AA8 RID: 6824
		private static readonly IntPtr NativeFieldInfoPtr__UnityEngine_UIElements_ITextEdition_UpdateTextFromValue_k__BackingField;

		// Token: 0x04001AA9 RID: 6825
		private static readonly IntPtr NativeFieldInfoPtr__UnityEngine_UIElements_ITextEdition_MoveFocusToCompositeRoot_k__BackingField;

		// Token: 0x04001AAA RID: 6826
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderedText;

		// Token: 0x04001AAB RID: 6827
		private static readonly IntPtr NativeFieldInfoPtr_m_OriginalText;

		// Token: 0x04001AAC RID: 6828
		private static readonly IntPtr NativeFieldInfoPtr_m_MaskChar;

		// Token: 0x04001AAD RID: 6829
		private static readonly IntPtr NativeFieldInfoPtr_m_IsPassword;

		// Token: 0x04001AAE RID: 6830
		private static readonly IntPtr NativeFieldInfoPtr_m_AutoCorrection;

		// Token: 0x04001AAF RID: 6831
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectingManipulator;

		// Token: 0x04001AB0 RID: 6832
		private static readonly IntPtr NativeFieldInfoPtr_m_IsSelectable;

		// Token: 0x04001AB1 RID: 6833
		private static readonly IntPtr NativeFieldInfoPtr__UnityEngine_UIElements_ITextSelection_doubleClickSelectsWord_k__BackingField;

		// Token: 0x04001AB2 RID: 6834
		private static readonly IntPtr NativeFieldInfoPtr__UnityEngine_UIElements_ITextSelection_tripleClickSelectsLine_k__BackingField;

		// Token: 0x04001AB3 RID: 6835
		private static readonly IntPtr NativeFieldInfoPtr__UnityEngine_UIElements_ITextSelection_selectAllOnFocus_k__BackingField;

		// Token: 0x04001AB4 RID: 6836
		private static readonly IntPtr NativeFieldInfoPtr__UnityEngine_UIElements_ITextSelection_selectAllOnMouseUp_k__BackingField;

		// Token: 0x04001AB5 RID: 6837
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectionColor;

		// Token: 0x04001AB6 RID: 6838
		private static readonly IntPtr NativeFieldInfoPtr_m_CursorColor;

		// Token: 0x04001AB7 RID: 6839
		private static readonly IntPtr NativeFieldInfoPtr_m_CursorWidth;

		// Token: 0x04001AB8 RID: 6840
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001AB9 RID: 6841
		private static readonly IntPtr NativeMethodInfoPtr_get_uitkTextHandle_Internal_get_UITKTextHandle_0;

		// Token: 0x04001ABA RID: 6842
		private static readonly IntPtr NativeMethodInfoPtr_set_uitkTextHandle_Internal_set_Void_UITKTextHandle_0;

		// Token: 0x04001ABB RID: 6843
		private static readonly IntPtr NativeMethodInfoPtr_OnGeometryChanged_Private_Void_GeometryChangedEvent_0;

		// Token: 0x04001ABC RID: 6844
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_Virtual_New_get_String_0;

		// Token: 0x04001ABD RID: 6845
		private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04001ABE RID: 6846
		private static readonly IntPtr NativeMethodInfoPtr_get_enableRichText_Public_get_Boolean_0;

		// Token: 0x04001ABF RID: 6847
		private static readonly IntPtr NativeMethodInfoPtr_set_enableRichText_Public_set_Void_Boolean_0;

		// Token: 0x04001AC0 RID: 6848
		private static readonly IntPtr NativeMethodInfoPtr_get_parseEscapeSequences_Public_get_Boolean_0;

		// Token: 0x04001AC1 RID: 6849
		private static readonly IntPtr NativeMethodInfoPtr_set_parseEscapeSequences_Public_set_Void_Boolean_0;

		// Token: 0x04001AC2 RID: 6850
		private static readonly IntPtr NativeMethodInfoPtr_get_displayTooltipWhenElided_Public_get_Boolean_0;

		// Token: 0x04001AC3 RID: 6851
		private static readonly IntPtr NativeMethodInfoPtr_set_displayTooltipWhenElided_Public_set_Void_Boolean_0;

		// Token: 0x04001AC4 RID: 6852
		private static readonly IntPtr NativeMethodInfoPtr_get_isElided_Public_get_Boolean_0;

		// Token: 0x04001AC5 RID: 6853
		private static readonly IntPtr NativeMethodInfoPtr_set_isElided_Private_set_Void_Boolean_0;

		// Token: 0x04001AC6 RID: 6854
		private static readonly IntPtr NativeMethodInfoPtr_OnGenerateVisualContent_Internal_Void_MeshGenerationContext_0;

		// Token: 0x04001AC7 RID: 6855
		private static readonly IntPtr NativeMethodInfoPtr_ElideText_Internal_String_String_String_Single_TextOverflowPosition_0;

		// Token: 0x04001AC8 RID: 6856
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTooltip_Private_Void_0;

		// Token: 0x04001AC9 RID: 6857
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisibleText_Private_Void_0;

		// Token: 0x04001ACA RID: 6858
		private static readonly IntPtr NativeMethodInfoPtr_ShouldElide_Private_Boolean_0;

		// Token: 0x04001ACB RID: 6859
		private static readonly IntPtr NativeMethodInfoPtr_get_hasFocus_Internal_get_Boolean_0;

		// Token: 0x04001ACC RID: 6860
		private static readonly IntPtr NativeMethodInfoPtr_MeasureTextSize_Public_Vector2_String_Single_MeasureMode_Single_MeasureMode_0;

		// Token: 0x04001ACD RID: 6861
		private static readonly IntPtr NativeMethodInfoPtr_DoMeasure_FamOrAssem_Virtual_Vector2_Single_MeasureMode_Single_MeasureMode_0;

		// Token: 0x04001ACE RID: 6862
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_INotifyValueChanged_System_String__get_value_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04001ACF RID: 6863
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_INotifyValueChanged_System_String__set_value_Private_Virtual_Final_New_set_Void_String_0;

		// Token: 0x04001AD0 RID: 6864
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_INotifyValueChanged_System_String__SetValueWithoutNotify_Private_Virtual_Final_New_Void_String_0;

		// Token: 0x04001AD1 RID: 6865
		private static readonly IntPtr NativeMethodInfoPtr_get_edition_Internal_get_ITextEdition_0;

		// Token: 0x04001AD2 RID: 6866
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_multiline_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001AD3 RID: 6867
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_multiline_Private_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04001AD4 RID: 6868
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_keyboardType_Private_Virtual_Final_New_get_TouchScreenKeyboardType_0;

		// Token: 0x04001AD5 RID: 6869
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_keyboardType_Private_Virtual_Final_New_set_Void_TouchScreenKeyboardType_0;

		// Token: 0x04001AD6 RID: 6870
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_hideMobileInput_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001AD7 RID: 6871
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_hideMobileInput_Private_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04001AD8 RID: 6872
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_isReadOnly_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001AD9 RID: 6873
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_isReadOnly_Private_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04001ADA RID: 6874
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMenuCommand_Private_Void_String_0;

		// Token: 0x04001ADB RID: 6875
		private static readonly IntPtr NativeMethodInfoPtr_Cut_Private_Void_DropdownMenuAction_0;

		// Token: 0x04001ADC RID: 6876
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Private_Void_DropdownMenuAction_0;

		// Token: 0x04001ADD RID: 6877
		private static readonly IntPtr NativeMethodInfoPtr_Paste_Private_Void_DropdownMenuAction_0;

		// Token: 0x04001ADE RID: 6878
		private static readonly IntPtr NativeMethodInfoPtr_BuildContextualMenu_Private_Void_ContextualMenuPopulateEvent_0;

		// Token: 0x04001ADF RID: 6879
		private static readonly IntPtr NativeMethodInfoPtr_CutActionStatus_Private_Status_DropdownMenuAction_0;

		// Token: 0x04001AE0 RID: 6880
		private static readonly IntPtr NativeMethodInfoPtr_CopyActionStatus_Private_Status_DropdownMenuAction_0;

		// Token: 0x04001AE1 RID: 6881
		private static readonly IntPtr NativeMethodInfoPtr_PasteActionStatus_Private_Status_DropdownMenuAction_0;

		// Token: 0x04001AE2 RID: 6882
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDefaultActionAtTarget_Protected_Virtual_Void_EventBase_0;

		// Token: 0x04001AE3 RID: 6883
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_maxLength_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001AE4 RID: 6884
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_maxLength_Private_Virtual_Final_New_set_Void_Int32_0;

		// Token: 0x04001AE5 RID: 6885
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_isDelayed_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001AE6 RID: 6886
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_isDelayed_Private_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04001AE7 RID: 6887
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_SaveValueAndText_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001AE8 RID: 6888
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_RestoreValueAndText_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001AE9 RID: 6889
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_AcceptCharacter_Private_Virtual_Final_New_get_Func_2_Char_Boolean_0;

		// Token: 0x04001AEA RID: 6890
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_AcceptCharacter_Private_Virtual_Final_New_set_Void_Func_2_Char_Boolean_0;

		// Token: 0x04001AEB RID: 6891
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_UpdateScrollOffset_Private_Virtual_Final_New_get_Action_1_Boolean_0;

		// Token: 0x04001AEC RID: 6892
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_UpdateScrollOffset_Private_Virtual_Final_New_set_Void_Action_1_Boolean_0;

		// Token: 0x04001AED RID: 6893
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_UpdateValueFromText_Private_Virtual_Final_New_get_Action_0;

		// Token: 0x04001AEE RID: 6894
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_UpdateValueFromText_Private_Virtual_Final_New_set_Void_Action_0;

		// Token: 0x04001AEF RID: 6895
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_UpdateTextFromValue_Private_Virtual_Final_New_get_Action_0;

		// Token: 0x04001AF0 RID: 6896
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_UpdateTextFromValue_Private_Virtual_Final_New_set_Void_Action_0;

		// Token: 0x04001AF1 RID: 6897
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_MoveFocusToCompositeRoot_Private_Virtual_Final_New_get_Action_0;

		// Token: 0x04001AF2 RID: 6898
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_MoveFocusToCompositeRoot_Private_Virtual_Final_New_set_Void_Action_0;

		// Token: 0x04001AF3 RID: 6899
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_UpdateText_Private_Virtual_Final_New_Void_String_0;

		// Token: 0x04001AF4 RID: 6900
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_CullString_Private_Virtual_Final_New_String_String_0;

		// Token: 0x04001AF5 RID: 6901
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_maskChar_Private_Virtual_Final_New_set_Void_Char_0;

		// Token: 0x04001AF6 RID: 6902
		private static readonly IntPtr NativeMethodInfoPtr_get_effectiveMaskChar_Private_get_Char_0;

		// Token: 0x04001AF7 RID: 6903
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_isPassword_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001AF8 RID: 6904
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_isPassword_Private_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04001AF9 RID: 6905
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_get_autoCorrection_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001AFA RID: 6906
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextEdition_set_autoCorrection_Private_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04001AFB RID: 6907
		private static readonly IntPtr NativeMethodInfoPtr_get_renderedText_Internal_get_String_0;

		// Token: 0x04001AFC RID: 6908
		private static readonly IntPtr NativeMethodInfoPtr_set_renderedText_Internal_set_Void_String_0;

		// Token: 0x04001AFD RID: 6909
		private static readonly IntPtr NativeMethodInfoPtr_get_originalText_Internal_get_String_0;

		// Token: 0x04001AFE RID: 6910
		private static readonly IntPtr NativeMethodInfoPtr_get_selection_Public_get_ITextSelection_0;

		// Token: 0x04001AFF RID: 6911
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_isSelectable_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001B00 RID: 6912
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_set_isSelectable_Private_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04001B01 RID: 6913
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_cursorIndex_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001B02 RID: 6914
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_set_cursorIndex_Private_Virtual_Final_New_set_Void_Int32_0;

		// Token: 0x04001B03 RID: 6915
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_selectIndex_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001B04 RID: 6916
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_set_selectIndex_Private_Virtual_Final_New_set_Void_Int32_0;

		// Token: 0x04001B05 RID: 6917
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_SelectAll_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001B06 RID: 6918
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_SelectNone_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001B07 RID: 6919
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_HasSelection_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001B08 RID: 6920
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_doubleClickSelectsWord_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001B09 RID: 6921
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_tripleClickSelectsLine_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001B0A RID: 6922
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_selectAllOnFocus_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001B0B RID: 6923
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_set_selectAllOnFocus_Private_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04001B0C RID: 6924
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_selectAllOnMouseUp_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001B0D RID: 6925
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_set_selectAllOnMouseUp_Private_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04001B0E RID: 6926
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_cursorPosition_Private_Virtual_Final_New_get_Vector2_0;

		// Token: 0x04001B0F RID: 6927
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_lineHeightAtCursorPosition_Private_Virtual_Final_New_get_Single_0;

		// Token: 0x04001B10 RID: 6928
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_selectionColor_Private_Virtual_Final_New_get_Color_0;

		// Token: 0x04001B11 RID: 6929
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_set_selectionColor_Private_Virtual_Final_New_set_Void_Color_0;

		// Token: 0x04001B12 RID: 6930
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_cursorColor_Private_Virtual_Final_New_get_Color_0;

		// Token: 0x04001B13 RID: 6931
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_set_cursorColor_Private_Virtual_Final_New_set_Void_Color_0;

		// Token: 0x04001B14 RID: 6932
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_ITextSelection_get_cursorWidth_Private_Virtual_Final_New_get_Single_0;

		// Token: 0x04001B15 RID: 6933
		private static readonly IntPtr NativeMethodInfoPtr_get_selectingManipulator_Internal_get_TextSelectingManipulator_0;

		// Token: 0x04001B16 RID: 6934
		private static readonly IntPtr NativeMethodInfoPtr_DrawHighlighting_Private_Void_MeshGenerationContext_0;

		// Token: 0x04001B17 RID: 6935
		private static readonly IntPtr NativeMethodInfoPtr_DrawCaret_Internal_Void_MeshGenerationContext_0;

		// Token: 0x04001B18 RID: 6936
		private static readonly IntPtr NativeMethodInfoPtr_GetLastCharacterAt_Private_Int32_Int32_0;

		// Token: 0x020004E8 RID: 1256
		public new class UxmlFactory : UxmlFactory<TextElement, TextElement.UxmlTraits>
		{
			// Token: 0x06003F30 RID: 16176 RVA: 0x0001A7E9 File Offset: 0x000189E9
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<TextElement.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextElement.UxmlFactory>.NativeClassPtr);
				TextElement.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement.UxmlFactory>.NativeClassPtr, 100668985);
			}

			// Token: 0x06003F31 RID: 16177 RVA: 0x000FBEC8 File Offset: 0x000FA0C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339417, XrefRangeEnd = 339420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextElement.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F32 RID: 16178 RVA: 0x0001A81D File Offset: 0x00018A1D
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002CAD RID: 11437
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004E9 RID: 1257
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			// Token: 0x06003F33 RID: 16179 RVA: 0x000FBF04 File Offset: 0x000FA104
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<TextElement.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextElement>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextElement.UxmlTraits>.NativeClassPtr);
				TextElement.UxmlTraits.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement.UxmlTraits>.NativeClassPtr, "m_Text");
				TextElement.UxmlTraits.NativeFieldInfoPtr_m_EnableRichText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement.UxmlTraits>.NativeClassPtr, "m_EnableRichText");
				TextElement.UxmlTraits.NativeFieldInfoPtr_m_ParseEscapeSequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement.UxmlTraits>.NativeClassPtr, "m_ParseEscapeSequences");
				TextElement.UxmlTraits.NativeFieldInfoPtr_m_DisplayTooltipWhenElided = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextElement.UxmlTraits>.NativeClassPtr, "m_DisplayTooltipWhenElided");
				TextElement.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement.UxmlTraits>.NativeClassPtr, 100668986);
				TextElement.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextElement.UxmlTraits>.NativeClassPtr, 100668987);
			}

			// Token: 0x06003F34 RID: 16180 RVA: 0x000FBFA8 File Offset: 0x000FA1A8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 339427, RefRangeEnd = 339428, XrefRangeStart = 339420, XrefRangeEnd = 339427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bag);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextElement.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F35 RID: 16181 RVA: 0x000FC020 File Offset: 0x000FA220
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 339461, RefRangeEnd = 339465, XrefRangeStart = 339428, XrefRangeEnd = 339461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextElement.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextElement.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F36 RID: 16182 RVA: 0x0001A826 File Offset: 0x00018A26
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012FB RID: 4859
			// (get) Token: 0x06003F37 RID: 16183 RVA: 0x000FC05C File Offset: 0x000FA25C
			// (set) Token: 0x06003F38 RID: 16184 RVA: 0x0001A82F File Offset: 0x00018A2F
			public unsafe UxmlStringAttributeDescription m_Text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.UxmlTraits.NativeFieldInfoPtr_m_Text);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.UxmlTraits.NativeFieldInfoPtr_m_Text), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012FC RID: 4860
			// (get) Token: 0x06003F39 RID: 16185 RVA: 0x000FC08C File Offset: 0x000FA28C
			// (set) Token: 0x06003F3A RID: 16186 RVA: 0x0001A84E File Offset: 0x00018A4E
			public unsafe UxmlBoolAttributeDescription m_EnableRichText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.UxmlTraits.NativeFieldInfoPtr_m_EnableRichText);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.UxmlTraits.NativeFieldInfoPtr_m_EnableRichText), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012FD RID: 4861
			// (get) Token: 0x06003F3B RID: 16187 RVA: 0x000FC0BC File Offset: 0x000FA2BC
			// (set) Token: 0x06003F3C RID: 16188 RVA: 0x0001A86D File Offset: 0x00018A6D
			public unsafe UxmlBoolAttributeDescription m_ParseEscapeSequences
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.UxmlTraits.NativeFieldInfoPtr_m_ParseEscapeSequences);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.UxmlTraits.NativeFieldInfoPtr_m_ParseEscapeSequences), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170012FE RID: 4862
			// (get) Token: 0x06003F3D RID: 16189 RVA: 0x000FC0EC File Offset: 0x000FA2EC
			// (set) Token: 0x06003F3E RID: 16190 RVA: 0x0001A88C File Offset: 0x00018A8C
			public unsafe UxmlBoolAttributeDescription m_DisplayTooltipWhenElided
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.UxmlTraits.NativeFieldInfoPtr_m_DisplayTooltipWhenElided);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextElement.UxmlTraits.NativeFieldInfoPtr_m_DisplayTooltipWhenElided), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002CAE RID: 11438
			private static readonly IntPtr NativeFieldInfoPtr_m_Text;

			// Token: 0x04002CAF RID: 11439
			private static readonly IntPtr NativeFieldInfoPtr_m_EnableRichText;

			// Token: 0x04002CB0 RID: 11440
			private static readonly IntPtr NativeFieldInfoPtr_m_ParseEscapeSequences;

			// Token: 0x04002CB1 RID: 11441
			private static readonly IntPtr NativeFieldInfoPtr_m_DisplayTooltipWhenElided;

			// Token: 0x04002CB2 RID: 11442
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x04002CB3 RID: 11443
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0200059C RID: 1436
			public sealed class <get_uxmlChildElementsDescription>d__5
			{
			}
		}
	}
}

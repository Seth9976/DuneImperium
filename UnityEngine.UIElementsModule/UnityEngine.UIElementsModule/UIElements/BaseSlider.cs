using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000042 RID: 66
	public class BaseSlider<TValueType> : BaseField<TValueType>
	{
		// Token: 0x0600058B RID: 1419 RVA: 0x00031718 File Offset: 0x0002F918
		// Note: this type is marked as 'beforefieldinit'.
		static BaseSlider()
		{
			Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BaseSlider`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValueType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr);
			BaseSlider<TValueType>.NativeFieldInfoPtr_m_AdjustedPageSizeFromClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, "m_AdjustedPageSizeFromClick");
			BaseSlider<TValueType>.NativeFieldInfoPtr__dragContainer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, "<dragContainer>k__BackingField");
			BaseSlider<TValueType>.NativeFieldInfoPtr__dragElement_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, "<dragElement>k__BackingField");
			BaseSlider<TValueType>.NativeFieldInfoPtr__trackElement_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, "<trackElement>k__BackingField");
			BaseSlider<TValueType>.NativeFieldInfoPtr__dragBorderElement_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, "<dragBorderElement>k__BackingField");
			BaseSlider<TValueType>.NativeFieldInfoPtr__inputTextField_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, "<inputTextField>k__BackingField");
			BaseSlider<TValueType>.NativeFieldInfoPtr_m_IsEditingTextField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, "m_IsEditingTextField");
			BaseSlider<TValueType>.NativeFieldInfoPtr_m_LowValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, "m_LowValue");
			BaseSlider<TValueType>.NativeFieldInfoPtr_m_HighValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, "m_HighValue");
			BaseSlider<TValueType>.NativeFieldInfoPtr_m_PageSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, "m_PageSize");
			BaseSlider<TValueType>.NativeFieldInfoPtr_m_ShowInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, "m_ShowInputField");
			BaseSlider<TValueType>.NativeFieldInfoPtr__clamped_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, "<clamped>k__BackingField");
			BaseSlider<TValueType>.NativeFieldInfoPtr__clampedDragger_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, "<clampedDragger>k__BackingField");
			BaseSlider<TValueType>.NativeFieldInfoPtr_m_DragElementStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, "m_DragElementStartPos");
			BaseSlider<TValueType>.NativeFieldInfoPtr_m_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, "m_Direction");
			BaseSlider<TValueType>.NativeFieldInfoPtr_m_Inverted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, "m_Inverted");
			BaseSlider<TValueType>.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, "ussClassName");
			BaseSlider<TValueType>.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, "labelUssClassName");
			BaseSlider<TValueType>.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, "inputUssClassName");
			BaseSlider<TValueType>.NativeFieldInfoPtr_horizontalVariantUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, "horizontalVariantUssClassName");
			BaseSlider<TValueType>.NativeFieldInfoPtr_verticalVariantUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, "verticalVariantUssClassName");
			BaseSlider<TValueType>.NativeFieldInfoPtr_dragContainerUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, "dragContainerUssClassName");
			BaseSlider<TValueType>.NativeFieldInfoPtr_trackerUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, "trackerUssClassName");
			BaseSlider<TValueType>.NativeFieldInfoPtr_draggerUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, "draggerUssClassName");
			BaseSlider<TValueType>.NativeFieldInfoPtr_draggerBorderUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, "draggerBorderUssClassName");
			BaseSlider<TValueType>.NativeFieldInfoPtr_textFieldClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, "textFieldClassName");
			BaseSlider<TValueType>.NativeMethodInfoPtr_get_dragContainer_Internal_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664062);
			BaseSlider<TValueType>.NativeMethodInfoPtr_set_dragContainer_Private_set_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664063);
			BaseSlider<TValueType>.NativeMethodInfoPtr_get_dragElement_Internal_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664064);
			BaseSlider<TValueType>.NativeMethodInfoPtr_set_dragElement_Private_set_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664065);
			BaseSlider<TValueType>.NativeMethodInfoPtr_get_trackElement_Internal_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664066);
			BaseSlider<TValueType>.NativeMethodInfoPtr_set_trackElement_Private_set_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664067);
			BaseSlider<TValueType>.NativeMethodInfoPtr_get_dragBorderElement_Internal_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664068);
			BaseSlider<TValueType>.NativeMethodInfoPtr_set_dragBorderElement_Private_set_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664069);
			BaseSlider<TValueType>.NativeMethodInfoPtr_get_inputTextField_Internal_get_TextField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664070);
			BaseSlider<TValueType>.NativeMethodInfoPtr_set_inputTextField_Private_set_Void_TextField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664071);
			BaseSlider<TValueType>.NativeMethodInfoPtr_get_canSwitchToMixedValue_FamAndAssem_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664072);
			BaseSlider<TValueType>.NativeMethodInfoPtr_get_lowValue_Public_get_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664073);
			BaseSlider<TValueType>.NativeMethodInfoPtr_set_lowValue_Public_set_Void_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664074);
			BaseSlider<TValueType>.NativeMethodInfoPtr_get_highValue_Public_get_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664075);
			BaseSlider<TValueType>.NativeMethodInfoPtr_set_highValue_Public_set_Void_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664076);
			BaseSlider<TValueType>.NativeMethodInfoPtr_SetHighValueWithoutNotify_Internal_Void_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664077);
			BaseSlider<TValueType>.NativeMethodInfoPtr_get_pageSize_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664078);
			BaseSlider<TValueType>.NativeMethodInfoPtr_set_pageSize_Public_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664079);
			BaseSlider<TValueType>.NativeMethodInfoPtr_get_showInputField_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664080);
			BaseSlider<TValueType>.NativeMethodInfoPtr_set_showInputField_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664081);
			BaseSlider<TValueType>.NativeMethodInfoPtr_get_clamped_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664082);
			BaseSlider<TValueType>.NativeMethodInfoPtr_set_clamped_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664083);
			BaseSlider<TValueType>.NativeMethodInfoPtr_get_clampedDragger_Internal_get_ClampedDragger_1_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664084);
			BaseSlider<TValueType>.NativeMethodInfoPtr_set_clampedDragger_Private_set_Void_ClampedDragger_1_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664085);
			BaseSlider<TValueType>.NativeMethodInfoPtr_Clamp_Private_TValueType_TValueType_TValueType_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664086);
			BaseSlider<TValueType>.NativeMethodInfoPtr_GetClampedValue_Private_TValueType_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664087);
			BaseSlider<TValueType>.NativeMethodInfoPtr_get_value_Public_Virtual_get_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664088);
			BaseSlider<TValueType>.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664089);
			BaseSlider<TValueType>.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_New_Void_Vector3_DeltaSpeed_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664090);
			BaseSlider<TValueType>.NativeMethodInfoPtr_UnityEngine_UIElements_IValueField_TValueType__StartDragging_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664091);
			BaseSlider<TValueType>.NativeMethodInfoPtr_UnityEngine_UIElements_IValueField_TValueType__StopDragging_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664092);
			BaseSlider<TValueType>.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664093);
			BaseSlider<TValueType>.NativeMethodInfoPtr_get_direction_Public_get_SliderDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664094);
			BaseSlider<TValueType>.NativeMethodInfoPtr_set_direction_Public_set_Void_SliderDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664095);
			BaseSlider<TValueType>.NativeMethodInfoPtr_get_inverted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664096);
			BaseSlider<TValueType>.NativeMethodInfoPtr_set_inverted_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664097);
			BaseSlider<TValueType>.NativeMethodInfoPtr__ctor_Internal_Void_String_TValueType_TValueType_SliderDirection_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664098);
			BaseSlider<TValueType>.NativeMethodInfoPtr_GetClosestPowerOfTen_Protected_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664099);
			BaseSlider<TValueType>.NativeMethodInfoPtr_RoundToMultipleOf_Protected_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664100);
			BaseSlider<TValueType>.NativeMethodInfoPtr_ClampValue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664101);
			BaseSlider<TValueType>.NativeMethodInfoPtr_SliderLerpUnclamped_Internal_Abstract_Virtual_New_TValueType_TValueType_TValueType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664102);
			BaseSlider<TValueType>.NativeMethodInfoPtr_SliderNormalizeValue_Internal_Abstract_Virtual_New_Single_TValueType_TValueType_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664103);
			BaseSlider<TValueType>.NativeMethodInfoPtr_ParseStringToValue_Internal_Abstract_Virtual_New_TValueType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664104);
			BaseSlider<TValueType>.NativeMethodInfoPtr_ComputeValueFromKey_Internal_Abstract_Virtual_New_Void_SliderKey_TValueType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664105);
			BaseSlider<TValueType>.NativeMethodInfoPtr_SliderLerpDirectionalUnclamped_Private_TValueType_TValueType_TValueType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664106);
			BaseSlider<TValueType>.NativeMethodInfoPtr_SetSliderValueFromDrag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664107);
			BaseSlider<TValueType>.NativeMethodInfoPtr_ComputeValueAndDirectionFromDrag_Private_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664108);
			BaseSlider<TValueType>.NativeMethodInfoPtr_SetSliderValueFromClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664109);
			BaseSlider<TValueType>.NativeMethodInfoPtr_OnKeyDown_Private_Void_KeyDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664110);
			BaseSlider<TValueType>.NativeMethodInfoPtr_OnNavigationMove_Private_Void_NavigationMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664111);
			BaseSlider<TValueType>.NativeMethodInfoPtr_ComputeValueAndDirectionFromClick_Internal_Virtual_New_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664112);
			BaseSlider<TValueType>.NativeMethodInfoPtr_AdjustDragElement_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664113);
			BaseSlider<TValueType>.NativeMethodInfoPtr_UpdateDragElementPosition_Private_Void_GeometryChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664114);
			BaseSlider<TValueType>.NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664115);
			BaseSlider<TValueType>.NativeMethodInfoPtr_SameValues_Private_Boolean_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664116);
			BaseSlider<TValueType>.NativeMethodInfoPtr_UpdateDragElementPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664117);
			BaseSlider<TValueType>.NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664118);
			BaseSlider<TValueType>.NativeMethodInfoPtr_UpdateTextFieldVisibility_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664119);
			BaseSlider<TValueType>.NativeMethodInfoPtr_UpdateTextFieldValue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664120);
			BaseSlider<TValueType>.NativeMethodInfoPtr_OnTextFieldFocusIn_Private_Void_FocusInEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664121);
			BaseSlider<TValueType>.NativeMethodInfoPtr_OnTextFieldFocusOut_Private_Void_FocusOutEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664122);
			BaseSlider<TValueType>.NativeMethodInfoPtr_OnInputNavigationMoveEvent_Private_Void_NavigationMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664123);
			BaseSlider<TValueType>.NativeMethodInfoPtr_OnTextFieldValueChange_Private_Void_ChangeEvent_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664124);
			BaseSlider<TValueType>.NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664125);
			BaseSlider<TValueType>.NativeMethodInfoPtr_RegisterEditingCallbacks_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664126);
			BaseSlider<TValueType>.NativeMethodInfoPtr_UnregisterEditingCallbacks_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, 100664127);
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x00031EB4 File Offset: 0x000300B4
		// (set) Token: 0x0600058D RID: 1421 RVA: 0x00031EF4 File Offset: 0x000300F4
		public unsafe VisualElement dragContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_get_dragContainer_Internal_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289419, XrefRangeEnd = 289420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_set_dragContainer_Private_set_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x00031F38 File Offset: 0x00030138
		// (set) Token: 0x0600058F RID: 1423 RVA: 0x00031F78 File Offset: 0x00030178
		public unsafe VisualElement dragElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_get_dragElement_Internal_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289420, XrefRangeEnd = 289421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_set_dragElement_Private_set_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x00031FBC File Offset: 0x000301BC
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x00031FFC File Offset: 0x000301FC
		public unsafe VisualElement trackElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_get_trackElement_Internal_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289421, XrefRangeEnd = 289422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_set_trackElement_Private_set_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x00032040 File Offset: 0x00030240
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x00032080 File Offset: 0x00030280
		public unsafe VisualElement dragBorderElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_get_dragBorderElement_Internal_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289422, XrefRangeEnd = 289423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_set_dragBorderElement_Private_set_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x000320C4 File Offset: 0x000302C4
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x00032104 File Offset: 0x00030304
		public unsafe TextField inputTextField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_get_inputTextField_Internal_get_TextField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextField>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289423, XrefRangeEnd = 289424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_set_inputTextField_Private_set_Void_TextField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x00032148 File Offset: 0x00030348
		public unsafe override bool canSwitchToMixedValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289424, XrefRangeEnd = 289429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSlider<TValueType>.NativeMethodInfoPtr_get_canSwitchToMixedValue_FamAndAssem_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00032190 File Offset: 0x00030390
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x000321CC File Offset: 0x000303CC
		public unsafe TValueType lowValue
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 289429, RefRangeEnd = 289434, XrefRangeStart = 289429, XrefRangeEnd = 289429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_get_lowValue_Public_get_TValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TValueType>(intPtr, false, true);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 289438, RefRangeEnd = 289439, XrefRangeStart = 289434, XrefRangeEnd = 289438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TValueType).IsValueType)
					{
						TValueType tvalueType = value;
						intPtr = ((tvalueType is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalueType as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalueType as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_set_lowValue_Public_set_Void_TValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00032244 File Offset: 0x00030444
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x00032280 File Offset: 0x00030480
		public unsafe TValueType highValue
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 289439, RefRangeEnd = 289444, XrefRangeStart = 289439, XrefRangeEnd = 289439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_get_highValue_Public_get_TValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TValueType>(intPtr, false, true);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 289448, RefRangeEnd = 289449, XrefRangeStart = 289444, XrefRangeEnd = 289448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TValueType).IsValueType)
					{
						TValueType tvalueType = value;
						intPtr = ((tvalueType is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalueType as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalueType as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_set_highValue_Public_set_Void_TValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x000322F8 File Offset: 0x000304F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289449, XrefRangeEnd = 289453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHighValueWithoutNotify(TValueType newHighValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TValueType).IsValueType)
				{
					TValueType tvalueType = newHighValue;
					intPtr = ((tvalueType is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalueType as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalueType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref newHighValue;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_SetHighValueWithoutNotify_Internal_Void_TValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x00032370 File Offset: 0x00030570
		// (set) Token: 0x0600059D RID: 1437 RVA: 0x000323B8 File Offset: 0x000305B8
		public unsafe virtual float pageSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 289453, RefRangeEnd = 289454, XrefRangeStart = 289453, XrefRangeEnd = 289453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSlider<TValueType>.NativeMethodInfoPtr_get_pageSize_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 289454, RefRangeEnd = 289455, XrefRangeStart = 289454, XrefRangeEnd = 289454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSlider<TValueType>.NativeMethodInfoPtr_set_pageSize_Public_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x00032404 File Offset: 0x00030604
		// (set) Token: 0x0600059F RID: 1439 RVA: 0x0003244C File Offset: 0x0003064C
		public unsafe virtual bool showInputField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSlider<TValueType>.NativeMethodInfoPtr_get_showInputField_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289455, XrefRangeEnd = 289456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSlider<TValueType>.NativeMethodInfoPtr_set_showInputField_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x00032498 File Offset: 0x00030698
		// (set) Token: 0x060005A1 RID: 1441 RVA: 0x000324D4 File Offset: 0x000306D4
		public unsafe bool clamped
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_get_clamped_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_set_clamped_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x00032514 File Offset: 0x00030714
		// (set) Token: 0x060005A3 RID: 1443 RVA: 0x00032554 File Offset: 0x00030754
		public unsafe ClampedDragger<TValueType> clampedDragger
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_get_clampedDragger_Internal_get_ClampedDragger_1_TValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClampedDragger<TValueType>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289456, XrefRangeEnd = 289457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_set_clampedDragger_Private_set_Void_ClampedDragger_1_TValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00032598 File Offset: 0x00030798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289457, XrefRangeEnd = 289459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TValueType Clamp(TValueType value, TValueType lowBound, TValueType highBound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TValueType).IsValueType)
				{
					TValueType tvalueType = value;
					intPtr = ((tvalueType is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalueType as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalueType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TValueType).IsValueType)
			{
				TValueType tvalueType2 = lowBound;
				intPtr2 = ((tvalueType2 is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalueType2 as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalueType2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref lowBound;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(TValueType).IsValueType)
			{
				TValueType tvalueType3 = highBound;
				intPtr3 = ((tvalueType3 is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalueType3 as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalueType3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref highBound;
			}
			ptr4 = intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_Clamp_Private_TValueType_TValueType_TValueType_TValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			return IL2CPP.PointerToValueGeneric<TValueType>(intPtr4, false, true);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x000326A8 File Offset: 0x000308A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289459, XrefRangeEnd = 289463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TValueType GetClampedValue(TValueType newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TValueType).IsValueType)
				{
					TValueType tvalueType = newValue;
					intPtr = ((tvalueType is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalueType as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalueType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref newValue;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_GetClampedValue_Private_TValueType_TValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<TValueType>(intPtr2, false, true);
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x00032728 File Offset: 0x00030928
		// (set) Token: 0x060005A7 RID: 1447 RVA: 0x0003276C File Offset: 0x0003096C
		public unsafe override TValueType value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289463, XrefRangeEnd = 289465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSlider<TValueType>.NativeMethodInfoPtr_get_value_Public_Virtual_get_TValueType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TValueType>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289465, XrefRangeEnd = 289510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TValueType).IsValueType)
					{
						TValueType tvalueType = value;
						intPtr = ((tvalueType is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalueType as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalueType as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSlider<TValueType>.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_TValueType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x000327F0 File Offset: 0x000309F0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delta;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TValueType).IsValueType)
			{
				TValueType tvalueType = startValue;
				intPtr = ((tvalueType is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalueType as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalueType as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref startValue;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSlider<TValueType>.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_New_Void_Vector3_DeltaSpeed_TValueType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00032890 File Offset: 0x00030A90
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_UIElements_IValueField_TValueType__StartDragging()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_UnityEngine_UIElements_IValueField_TValueType__StartDragging_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x000328C4 File Offset: 0x00030AC4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_UIElements_IValueField_TValueType__StopDragging()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_UnityEngine_UIElements_IValueField_TValueType__StopDragging_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x000328F8 File Offset: 0x00030AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289510, XrefRangeEnd = 289514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValueWithoutNotify(TValueType newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TValueType).IsValueType)
				{
					TValueType tvalueType = newValue;
					intPtr = ((tvalueType is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalueType as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalueType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref newValue;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSlider<TValueType>.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_TValueType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x0003297C File Offset: 0x00030B7C
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x000329B8 File Offset: 0x00030BB8
		public unsafe SliderDirection direction
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 289514, RefRangeEnd = 289515, XrefRangeStart = 289514, XrefRangeEnd = 289514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_get_direction_Public_get_SliderDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 289527, RefRangeEnd = 289531, XrefRangeStart = 289515, XrefRangeEnd = 289527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_set_direction_Public_set_Void_SliderDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x000329F8 File Offset: 0x00030BF8
		// (set) Token: 0x060005AF RID: 1455 RVA: 0x00032A34 File Offset: 0x00030C34
		public unsafe bool inverted
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 289531, RefRangeEnd = 289536, XrefRangeStart = 289531, XrefRangeEnd = 289531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_get_inverted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 289537, RefRangeEnd = 289538, XrefRangeStart = 289536, XrefRangeEnd = 289537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_set_inverted_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00032A74 File Offset: 0x00030C74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 289651, RefRangeEnd = 289653, XrefRangeStart = 289538, XrefRangeEnd = 289651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseSlider(string label, TValueType start, TValueType end, SliderDirection direction = SliderDirection.Horizontal, float pageSize = 0f)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TValueType).IsValueType)
			{
				TValueType tvalueType = start;
				intPtr = ((tvalueType is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalueType as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalueType as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref start;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TValueType).IsValueType)
			{
				TValueType tvalueType2 = end;
				intPtr2 = ((tvalueType2 is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalueType2 as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalueType2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref end;
			}
			ptr3 = intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pageSize;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr__ctor_Internal_Void_String_TValueType_TValueType_SliderDirection_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00032B6C File Offset: 0x00030D6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289665, RefRangeEnd = 289666, XrefRangeStart = 289653, XrefRangeEnd = 289665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetClosestPowerOfTen(float positiveNumber)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref positiveNumber;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_GetClosestPowerOfTen_Protected_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00032BAC File Offset: 0x00030DAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 289667, RefRangeEnd = 289669, XrefRangeStart = 289666, XrefRangeEnd = 289667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float RoundToMultipleOf(float value, float roundingValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref roundingValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_RoundToMultipleOf_Protected_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00032BF8 File Offset: 0x00030DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289669, XrefRangeEnd = 289671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClampValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_ClampValue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00032C2C File Offset: 0x00030E2C
		[CallerCount(0)]
		public unsafe virtual TValueType SliderLerpUnclamped(TValueType a, TValueType b, float interpolant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TValueType).IsValueType)
				{
					TValueType tvalueType = a;
					intPtr = ((tvalueType is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalueType as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalueType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref a;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TValueType).IsValueType)
			{
				TValueType tvalueType2 = b;
				intPtr2 = ((tvalueType2 is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalueType2 as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalueType2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref b;
			}
			ptr3 = intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interpolant;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSlider<TValueType>.NativeMethodInfoPtr_SliderLerpUnclamped_Internal_Abstract_Virtual_New_TValueType_TValueType_TValueType_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return IL2CPP.PointerToValueGeneric<TValueType>(intPtr3, false, true);
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00032D10 File Offset: 0x00030F10
		[CallerCount(0)]
		public unsafe virtual float SliderNormalizeValue(TValueType currentValue, TValueType lowerValue, TValueType higherValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TValueType).IsValueType)
				{
					TValueType tvalueType = currentValue;
					intPtr = ((tvalueType is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalueType as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalueType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref currentValue;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TValueType).IsValueType)
			{
				TValueType tvalueType2 = lowerValue;
				intPtr2 = ((tvalueType2 is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalueType2 as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalueType2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref lowerValue;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(TValueType).IsValueType)
			{
				TValueType tvalueType3 = higherValue;
				intPtr3 = ((tvalueType3 is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalueType3 as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalueType3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref higherValue;
			}
			ptr4 = intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSlider<TValueType>.NativeMethodInfoPtr_SliderNormalizeValue_Internal_Abstract_Virtual_New_Single_TValueType_TValueType_TValueType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00032E30 File Offset: 0x00031030
		[CallerCount(0)]
		public unsafe virtual TValueType ParseStringToValue(string previousValue, string newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(previousValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSlider<TValueType>.NativeMethodInfoPtr_ParseStringToValue_Internal_Abstract_Virtual_New_TValueType_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TValueType>(intPtr, false, true);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00032E98 File Offset: 0x00031098
		[CallerCount(0)]
		public unsafe virtual void ComputeValueFromKey(BaseSlider<TValueType>.SliderKey sliderKey, bool isShift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sliderKey;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isShift;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSlider<TValueType>.NativeMethodInfoPtr_ComputeValueFromKey_Internal_Abstract_Virtual_New_Void_SliderKey_TValueType_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00032EF0 File Offset: 0x000310F0
		[CallerCount(0)]
		public unsafe TValueType SliderLerpDirectionalUnclamped(TValueType a, TValueType b, float positionInterpolant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TValueType).IsValueType)
				{
					TValueType tvalueType = a;
					intPtr = ((tvalueType is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalueType as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalueType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref a;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TValueType).IsValueType)
			{
				TValueType tvalueType2 = b;
				intPtr2 = ((tvalueType2 is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalueType2 as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalueType2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref b;
			}
			ptr3 = intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positionInterpolant;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_SliderLerpDirectionalUnclamped_Private_TValueType_TValueType_TValueType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return IL2CPP.PointerToValueGeneric<TValueType>(intPtr3, false, true);
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00032FC8 File Offset: 0x000311C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289671, XrefRangeEnd = 289680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderValueFromDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_SetSliderValueFromDrag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00032FFC File Offset: 0x000311FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289680, XrefRangeEnd = 289682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ComputeValueAndDirectionFromDrag(float sliderLength, float dragElementLength, float dragElementPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sliderLength;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dragElementLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dragElementPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_ComputeValueAndDirectionFromDrag_Private_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00033058 File Offset: 0x00031258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289682, XrefRangeEnd = 289707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderValueFromClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_SetSliderValueFromClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0003308C File Offset: 0x0003128C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289707, XrefRangeEnd = 289719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnKeyDown(KeyDownEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_OnKeyDown_Private_Void_KeyDownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x000330D0 File Offset: 0x000312D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289719, XrefRangeEnd = 289725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnNavigationMove(NavigationMoveEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_OnNavigationMove_Private_Void_NavigationMoveEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00033114 File Offset: 0x00031314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289725, XrefRangeEnd = 289728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sliderLength;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dragElementLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dragElementPos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dragElementLastPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSlider<TValueType>.NativeMethodInfoPtr_ComputeValueAndDirectionFromClick_Internal_Virtual_New_Void_Single_Single_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00033188 File Offset: 0x00031388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289728, XrefRangeEnd = 289772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdjustDragElement(float factor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref factor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_AdjustDragElement_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x000331C8 File Offset: 0x000313C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289772, XrefRangeEnd = 289773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDragElementPosition(GeometryChangedEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_UpdateDragElementPosition_Private_Void_GeometryChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0003320C File Offset: 0x0003140C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289773, XrefRangeEnd = 289776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnViewDataReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSlider<TValueType>.NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00033248 File Offset: 0x00031448
		[CallerCount(0)]
		public unsafe bool SameValues(float a, float b, float epsilon)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref epsilon;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_SameValues_Private_Boolean_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x000332B0 File Offset: 0x000314B0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 289796, RefRangeEnd = 289806, XrefRangeStart = 289776, XrefRangeEnd = 289796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDragElementPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_UpdateDragElementPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x000332E4 File Offset: 0x000314E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289806, XrefRangeEnd = 289816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ExecuteDefaultAction(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSlider<TValueType>.NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00033334 File Offset: 0x00031534
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 289854, RefRangeEnd = 289856, XrefRangeStart = 289816, XrefRangeEnd = 289854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTextFieldVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_UpdateTextFieldVisibility_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00033368 File Offset: 0x00031568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289856, XrefRangeEnd = 289864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTextFieldValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_UpdateTextFieldValue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0003339C File Offset: 0x0003159C
		[CallerCount(0)]
		public unsafe void OnTextFieldFocusIn(FocusInEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_OnTextFieldFocusIn_Private_Void_FocusInEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x000333E0 File Offset: 0x000315E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289864, XrefRangeEnd = 289865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTextFieldFocusOut(FocusOutEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_OnTextFieldFocusOut_Private_Void_FocusOutEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00033424 File Offset: 0x00031624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289865, XrefRangeEnd = 289867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputNavigationMoveEvent(NavigationMoveEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_OnInputNavigationMoveEvent_Private_Void_NavigationMoveEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00033468 File Offset: 0x00031668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289867, XrefRangeEnd = 289872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTextFieldValueChange(ChangeEvent<string> evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.NativeMethodInfoPtr_OnTextFieldValueChange_Private_Void_ChangeEvent_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x000334AC File Offset: 0x000316AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289872, XrefRangeEnd = 289876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateMixedValueContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSlider<TValueType>.NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x000334E8 File Offset: 0x000316E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289876, XrefRangeEnd = 289896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RegisterEditingCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSlider<TValueType>.NativeMethodInfoPtr_RegisterEditingCallbacks_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00033524 File Offset: 0x00031724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289896, XrefRangeEnd = 289916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UnregisterEditingCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseSlider<TValueType>.NativeMethodInfoPtr_UnregisterEditingCallbacks_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00003CCF File Offset: 0x00001ECF
		public BaseSlider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x00033560 File Offset: 0x00031760
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x00003CD8 File Offset: 0x00001ED8
		public unsafe float m_AdjustedPageSizeFromClick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr_m_AdjustedPageSizeFromClick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr_m_AdjustedPageSizeFromClick)) = value;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x00033588 File Offset: 0x00031788
		// (set) Token: 0x060005D2 RID: 1490 RVA: 0x00003CF3 File Offset: 0x00001EF3
		public unsafe VisualElement _dragContainer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr__dragContainer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr__dragContainer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x000335B8 File Offset: 0x000317B8
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x00003D12 File Offset: 0x00001F12
		public unsafe VisualElement _dragElement_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr__dragElement_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr__dragElement_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x000335E8 File Offset: 0x000317E8
		// (set) Token: 0x060005D6 RID: 1494 RVA: 0x00003D31 File Offset: 0x00001F31
		public unsafe VisualElement _trackElement_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr__trackElement_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr__trackElement_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x00033618 File Offset: 0x00031818
		// (set) Token: 0x060005D8 RID: 1496 RVA: 0x00003D50 File Offset: 0x00001F50
		public unsafe VisualElement _dragBorderElement_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr__dragBorderElement_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr__dragBorderElement_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x00033648 File Offset: 0x00031848
		// (set) Token: 0x060005DA RID: 1498 RVA: 0x00003D6F File Offset: 0x00001F6F
		public unsafe TextField _inputTextField_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr__inputTextField_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr__inputTextField_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x00033678 File Offset: 0x00031878
		// (set) Token: 0x060005DC RID: 1500 RVA: 0x00003D8E File Offset: 0x00001F8E
		public unsafe bool m_IsEditingTextField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr_m_IsEditingTextField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr_m_IsEditingTextField)) = value;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x000336A0 File Offset: 0x000318A0
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x000336C8 File Offset: 0x000318C8
		public unsafe TValueType m_LowValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr_m_LowValue);
				return IL2CPP.PointerToValueGeneric<TValueType>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr_m_LowValue);
				Type typeFromHandle = typeof(TValueType);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x00033770 File Offset: 0x00031970
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x00033798 File Offset: 0x00031998
		public unsafe TValueType m_HighValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr_m_HighValue);
				return IL2CPP.PointerToValueGeneric<TValueType>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr_m_HighValue);
				Type typeFromHandle = typeof(TValueType);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x00033840 File Offset: 0x00031A40
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x00003DA9 File Offset: 0x00001FA9
		public unsafe float m_PageSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr_m_PageSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr_m_PageSize)) = value;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00033868 File Offset: 0x00031A68
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x00003DC4 File Offset: 0x00001FC4
		public unsafe bool m_ShowInputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr_m_ShowInputField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr_m_ShowInputField)) = value;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x00033890 File Offset: 0x00031A90
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x00003DDF File Offset: 0x00001FDF
		public unsafe bool _clamped_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr__clamped_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr__clamped_k__BackingField)) = value;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x000338B8 File Offset: 0x00031AB8
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x00003DFA File Offset: 0x00001FFA
		public unsafe ClampedDragger<TValueType> _clampedDragger_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr__clampedDragger_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedDragger<TValueType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr__clampedDragger_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x000338E8 File Offset: 0x00031AE8
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x00003E19 File Offset: 0x00002019
		public unsafe Rect m_DragElementStartPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr_m_DragElementStartPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr_m_DragElementStartPos)) = value;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x00033910 File Offset: 0x00031B10
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x00003E34 File Offset: 0x00002034
		public unsafe SliderDirection m_Direction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr_m_Direction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr_m_Direction)) = value;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x00033938 File Offset: 0x00031B38
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x00003E4F File Offset: 0x0000204F
		public unsafe bool m_Inverted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr_m_Inverted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSlider<TValueType>.NativeFieldInfoPtr_m_Inverted)) = value;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x00033960 File Offset: 0x00031B60
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x00003E6A File Offset: 0x0000206A
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseSlider<TValueType>.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseSlider<TValueType>.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x00033980 File Offset: 0x00031B80
		// (set) Token: 0x060005F2 RID: 1522 RVA: 0x00003E7C File Offset: 0x0000207C
		public new unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseSlider<TValueType>.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseSlider<TValueType>.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x000339A0 File Offset: 0x00031BA0
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x00003E8E File Offset: 0x0000208E
		public new unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseSlider<TValueType>.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseSlider<TValueType>.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x000339C0 File Offset: 0x00031BC0
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x00003EA0 File Offset: 0x000020A0
		public unsafe static string horizontalVariantUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseSlider<TValueType>.NativeFieldInfoPtr_horizontalVariantUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseSlider<TValueType>.NativeFieldInfoPtr_horizontalVariantUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x000339E0 File Offset: 0x00031BE0
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x00003EB2 File Offset: 0x000020B2
		public unsafe static string verticalVariantUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseSlider<TValueType>.NativeFieldInfoPtr_verticalVariantUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseSlider<TValueType>.NativeFieldInfoPtr_verticalVariantUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x00033A00 File Offset: 0x00031C00
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x00003EC4 File Offset: 0x000020C4
		public unsafe static string dragContainerUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseSlider<TValueType>.NativeFieldInfoPtr_dragContainerUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseSlider<TValueType>.NativeFieldInfoPtr_dragContainerUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x00033A20 File Offset: 0x00031C20
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x00003ED6 File Offset: 0x000020D6
		public unsafe static string trackerUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseSlider<TValueType>.NativeFieldInfoPtr_trackerUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseSlider<TValueType>.NativeFieldInfoPtr_trackerUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x00033A40 File Offset: 0x00031C40
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x00003EE8 File Offset: 0x000020E8
		public unsafe static string draggerUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseSlider<TValueType>.NativeFieldInfoPtr_draggerUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseSlider<TValueType>.NativeFieldInfoPtr_draggerUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x00033A60 File Offset: 0x00031C60
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x00003EFA File Offset: 0x000020FA
		public unsafe static string draggerBorderUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseSlider<TValueType>.NativeFieldInfoPtr_draggerBorderUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseSlider<TValueType>.NativeFieldInfoPtr_draggerBorderUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x00033A80 File Offset: 0x00031C80
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x00003F0C File Offset: 0x0000210C
		public unsafe static string textFieldClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseSlider<TValueType>.NativeFieldInfoPtr_textFieldClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseSlider<TValueType>.NativeFieldInfoPtr_textFieldClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x00033AA0 File Offset: 0x00031CA0
		public TValueType range
		{
			get
			{
				return this.SliderRange();
			}
		}

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeFieldInfoPtr_m_AdjustedPageSizeFromClick;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeFieldInfoPtr__dragContainer_k__BackingField;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeFieldInfoPtr__dragElement_k__BackingField;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeFieldInfoPtr__trackElement_k__BackingField;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeFieldInfoPtr__dragBorderElement_k__BackingField;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeFieldInfoPtr__inputTextField_k__BackingField;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeFieldInfoPtr_m_IsEditingTextField;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeFieldInfoPtr_m_LowValue;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeFieldInfoPtr_m_HighValue;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeFieldInfoPtr_m_PageSize;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeFieldInfoPtr_m_ShowInputField;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeFieldInfoPtr__clamped_k__BackingField;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeFieldInfoPtr__clampedDragger_k__BackingField;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeFieldInfoPtr_m_DragElementStartPos;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeFieldInfoPtr_m_Direction;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeFieldInfoPtr_m_Inverted;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeFieldInfoPtr_horizontalVariantUssClassName;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeFieldInfoPtr_verticalVariantUssClassName;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeFieldInfoPtr_dragContainerUssClassName;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeFieldInfoPtr_trackerUssClassName;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeFieldInfoPtr_draggerUssClassName;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeFieldInfoPtr_draggerBorderUssClassName;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeFieldInfoPtr_textFieldClassName;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeMethodInfoPtr_get_dragContainer_Internal_get_VisualElement_0;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeMethodInfoPtr_set_dragContainer_Private_set_Void_VisualElement_0;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeMethodInfoPtr_get_dragElement_Internal_get_VisualElement_0;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeMethodInfoPtr_set_dragElement_Private_set_Void_VisualElement_0;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeMethodInfoPtr_get_trackElement_Internal_get_VisualElement_0;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr_set_trackElement_Private_set_Void_VisualElement_0;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr_get_dragBorderElement_Internal_get_VisualElement_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr_set_dragBorderElement_Private_set_Void_VisualElement_0;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeMethodInfoPtr_get_inputTextField_Internal_get_TextField_0;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeMethodInfoPtr_set_inputTextField_Private_set_Void_TextField_0;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeMethodInfoPtr_get_canSwitchToMixedValue_FamAndAssem_Virtual_get_Boolean_0;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeMethodInfoPtr_get_lowValue_Public_get_TValueType_0;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr_set_lowValue_Public_set_Void_TValueType_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr_get_highValue_Public_get_TValueType_0;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeMethodInfoPtr_set_highValue_Public_set_Void_TValueType_0;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr_SetHighValueWithoutNotify_Internal_Void_TValueType_0;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeMethodInfoPtr_get_pageSize_Public_Virtual_New_get_Single_0;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeMethodInfoPtr_set_pageSize_Public_Virtual_New_set_Void_Single_0;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeMethodInfoPtr_get_showInputField_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeMethodInfoPtr_set_showInputField_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeMethodInfoPtr_get_clamped_Internal_get_Boolean_0;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeMethodInfoPtr_set_clamped_Internal_set_Void_Boolean_0;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr_get_clampedDragger_Internal_get_ClampedDragger_1_TValueType_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr_set_clampedDragger_Private_set_Void_ClampedDragger_1_TValueType_0;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Private_TValueType_TValueType_TValueType_TValueType_0;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeMethodInfoPtr_GetClampedValue_Private_TValueType_TValueType_0;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_get_TValueType_0;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_TValueType_0;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_New_Void_Vector3_DeltaSpeed_TValueType_0;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IValueField_TValueType__StartDragging_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IValueField_TValueType__StopDragging_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_TValueType_0;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeMethodInfoPtr_get_direction_Public_get_SliderDirection_0;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr_set_direction_Public_set_Void_SliderDirection_0;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr_get_inverted_Public_get_Boolean_0;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr_set_inverted_Public_set_Void_Boolean_0;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_TValueType_TValueType_SliderDirection_Single_0;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestPowerOfTen_Protected_Static_Single_Single_0;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeMethodInfoPtr_RoundToMultipleOf_Protected_Static_Single_Single_Single_0;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeMethodInfoPtr_ClampValue_Private_Void_0;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr_SliderLerpUnclamped_Internal_Abstract_Virtual_New_TValueType_TValueType_TValueType_Single_0;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeMethodInfoPtr_SliderNormalizeValue_Internal_Abstract_Virtual_New_Single_TValueType_TValueType_TValueType_0;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr_ParseStringToValue_Internal_Abstract_Virtual_New_TValueType_String_String_0;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr_ComputeValueFromKey_Internal_Abstract_Virtual_New_Void_SliderKey_TValueType_Boolean_0;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr_SliderLerpDirectionalUnclamped_Private_TValueType_TValueType_TValueType_Single_0;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderValueFromDrag_Private_Void_0;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeMethodInfoPtr_ComputeValueAndDirectionFromDrag_Private_Void_Single_Single_Single_0;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderValueFromClick_Private_Void_0;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeMethodInfoPtr_OnKeyDown_Private_Void_KeyDownEvent_0;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeMethodInfoPtr_OnNavigationMove_Private_Void_NavigationMoveEvent_0;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeMethodInfoPtr_ComputeValueAndDirectionFromClick_Internal_Virtual_New_Void_Single_Single_Single_Single_0;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeMethodInfoPtr_AdjustDragElement_Public_Void_Single_0;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDragElementPosition_Private_Void_GeometryChangedEvent_0;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeMethodInfoPtr_SameValues_Private_Boolean_Single_Single_Single_0;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDragElementPosition_Private_Void_0;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_Void_EventBase_0;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTextFieldVisibility_Private_Void_0;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTextFieldValue_Private_Void_0;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeMethodInfoPtr_OnTextFieldFocusIn_Private_Void_FocusInEvent_0;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeMethodInfoPtr_OnTextFieldFocusOut_Private_Void_FocusOutEvent_0;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeMethodInfoPtr_OnInputNavigationMoveEvent_Private_Void_NavigationMoveEvent_0;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeMethodInfoPtr_OnTextFieldValueChange_Private_Void_ChangeEvent_1_String_0;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEditingCallbacks_Internal_Virtual_Void_0;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterEditingCallbacks_Internal_Virtual_Void_0;

		// Token: 0x04000477 RID: 1143
		public const float kDefaultPageSize = 0f;

		// Token: 0x04000478 RID: 1144
		public const bool kDefaultShowInputField = false;

		// Token: 0x04000479 RID: 1145
		public const bool kDefaultInverted = false;

		// Token: 0x02000335 RID: 821
		public new class UxmlTraits : BaseField<TValueType>.UxmlTraits
		{
			// Token: 0x060035BD RID: 13757 RVA: 0x000DEA20 File Offset: 0x000DCC20
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<BaseSlider<TValueType>.UxmlTraits>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseSlider<TValueType>>.NativeClassPtr, "UxmlTraits"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValueType>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseSlider<TValueType>.UxmlTraits>.NativeClassPtr);
				BaseSlider<TValueType>.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSlider<TValueType>.UxmlTraits>.NativeClassPtr, 100664129);
			}

			// Token: 0x060035BE RID: 13758 RVA: 0x000DEA9C File Offset: 0x000DCC9C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 289418, RefRangeEnd = 289419, XrefRangeStart = 289406, XrefRangeEnd = 289418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseSlider<TValueType>.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSlider<TValueType>.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060035BF RID: 13759 RVA: 0x00015E46 File Offset: 0x00014046
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002693 RID: 9875
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000336 RID: 822
		public enum SliderKey
		{
			// Token: 0x04002695 RID: 9877
			None,
			// Token: 0x04002696 RID: 9878
			Lowest,
			// Token: 0x04002697 RID: 9879
			LowerPage,
			// Token: 0x04002698 RID: 9880
			Lower,
			// Token: 0x04002699 RID: 9881
			Higher,
			// Token: 0x0400269A RID: 9882
			HigherPage,
			// Token: 0x0400269B RID: 9883
			Highest
		}
	}
}

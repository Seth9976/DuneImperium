using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000066 RID: 102
	public class BaseField<TValueType> : BindableElement
	{
		// Token: 0x0600093A RID: 2362 RVA: 0x0003DB18 File Offset: 0x0003BD18
		// Note: this type is marked as 'beforefieldinit'.
		static BaseField()
		{
			Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BaseField`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValueType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr);
			BaseField<TValueType>.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "ussClassName");
			BaseField<TValueType>.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "labelUssClassName");
			BaseField<TValueType>.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "inputUssClassName");
			BaseField<TValueType>.NativeFieldInfoPtr_noLabelVariantUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "noLabelVariantUssClassName");
			BaseField<TValueType>.NativeFieldInfoPtr_labelDraggerVariantUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "labelDraggerVariantUssClassName");
			BaseField<TValueType>.NativeFieldInfoPtr_mixedValueLabelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "mixedValueLabelUssClassName");
			BaseField<TValueType>.NativeFieldInfoPtr_alignedFieldUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "alignedFieldUssClassName");
			BaseField<TValueType>.NativeFieldInfoPtr_inspectorFieldUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "inspectorFieldUssClassName");
			BaseField<TValueType>.NativeFieldInfoPtr_mixedValueString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "mixedValueString");
			BaseField<TValueType>.NativeFieldInfoPtr_serializedPropertyCopyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "serializedPropertyCopyName");
			BaseField<TValueType>.NativeFieldInfoPtr_s_LabelWidthRatioProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "s_LabelWidthRatioProperty");
			BaseField<TValueType>.NativeFieldInfoPtr_s_LabelExtraPaddingProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "s_LabelExtraPaddingProperty");
			BaseField<TValueType>.NativeFieldInfoPtr_s_LabelBaseMinWidthProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "s_LabelBaseMinWidthProperty");
			BaseField<TValueType>.NativeFieldInfoPtr_s_LabelExtraContextWidthProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "s_LabelExtraContextWidthProperty");
			BaseField<TValueType>.NativeFieldInfoPtr_m_LabelWidthRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "m_LabelWidthRatio");
			BaseField<TValueType>.NativeFieldInfoPtr_m_LabelExtraPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "m_LabelExtraPadding");
			BaseField<TValueType>.NativeFieldInfoPtr_m_LabelBaseMinWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "m_LabelBaseMinWidth");
			BaseField<TValueType>.NativeFieldInfoPtr_m_LabelExtraContextWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "m_LabelExtraContextWidth");
			BaseField<TValueType>.NativeFieldInfoPtr_m_VisualInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "m_VisualInput");
			BaseField<TValueType>.NativeFieldInfoPtr_expressionEvaluated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "expressionEvaluated");
			BaseField<TValueType>.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "m_Value");
			BaseField<TValueType>.NativeFieldInfoPtr_onValidateValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "onValidateValue");
			BaseField<TValueType>.NativeFieldInfoPtr__labelElement_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "<labelElement>k__BackingField");
			BaseField<TValueType>.NativeFieldInfoPtr_m_ShowMixedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "m_ShowMixedValue");
			BaseField<TValueType>.NativeFieldInfoPtr_m_MixedValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "m_MixedValueLabel");
			BaseField<TValueType>.NativeFieldInfoPtr_m_SkipValidation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "m_SkipValidation");
			BaseField<TValueType>.NativeFieldInfoPtr_m_CachedContextWidthElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "m_CachedContextWidthElement");
			BaseField<TValueType>.NativeFieldInfoPtr_m_CachedInspectorElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "m_CachedInspectorElement");
			BaseField<TValueType>.NativeFieldInfoPtr__UnityEngine_UIElements_IEditableElement_editingStarted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "<UnityEngine.UIElements.IEditableElement.editingStarted>k__BackingField");
			BaseField<TValueType>.NativeFieldInfoPtr__UnityEngine_UIElements_IEditableElement_editingEnded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "<UnityEngine.UIElements.IEditableElement.editingEnded>k__BackingField");
			BaseField<TValueType>.NativeMethodInfoPtr_get_visualInput_Internal_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664620);
			BaseField<TValueType>.NativeMethodInfoPtr_set_visualInput_Internal_set_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664621);
			BaseField<TValueType>.NativeMethodInfoPtr_get_rawValue_Protected_get_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664622);
			BaseField<TValueType>.NativeMethodInfoPtr_set_rawValue_Protected_set_Void_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664623);
			BaseField<TValueType>.NativeMethodInfoPtr_add_onValidateValue_Internal_add_Void_Func_2_TValueType_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664624);
			BaseField<TValueType>.NativeMethodInfoPtr_remove_onValidateValue_Internal_rem_Void_Func_2_TValueType_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664625);
			BaseField<TValueType>.NativeMethodInfoPtr_get_value_Public_Virtual_New_get_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664626);
			BaseField<TValueType>.NativeMethodInfoPtr_set_value_Public_Virtual_New_set_Void_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664627);
			BaseField<TValueType>.NativeMethodInfoPtr_get_labelElement_Public_Virtual_Final_New_get_Label_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664628);
			BaseField<TValueType>.NativeMethodInfoPtr_set_labelElement_Private_set_Void_Label_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664629);
			BaseField<TValueType>.NativeMethodInfoPtr_get_label_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664630);
			BaseField<TValueType>.NativeMethodInfoPtr_set_label_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664631);
			BaseField<TValueType>.NativeMethodInfoPtr_get_showMixedValue_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664632);
			BaseField<TValueType>.NativeMethodInfoPtr_set_showMixedValue_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664633);
			BaseField<TValueType>.NativeMethodInfoPtr_get_canSwitchToMixedValue_FamAndAssem_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664634);
			BaseField<TValueType>.NativeMethodInfoPtr_get_mixedValueLabel_Protected_get_Label_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664635);
			BaseField<TValueType>.NativeMethodInfoPtr_UnityEngine_UIElements_IEditableElement_get_editingStarted_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664636);
			BaseField<TValueType>.NativeMethodInfoPtr_UnityEngine_UIElements_IEditableElement_get_editingEnded_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664637);
			BaseField<TValueType>.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664638);
			BaseField<TValueType>.NativeMethodInfoPtr__ctor_Protected_Void_String_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664639);
			BaseField<TValueType>.NativeMethodInfoPtr_EqualsCurrentValue_Internal_Virtual_New_Boolean_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664640);
			BaseField<TValueType>.NativeMethodInfoPtr_OnAttachToPanel_Private_Void_AttachToPanelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664641);
			BaseField<TValueType>.NativeMethodInfoPtr_OnDetachFromPanel_Private_Void_DetachFromPanelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664642);
			BaseField<TValueType>.NativeMethodInfoPtr_RegisterEditingCallbacks_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664643);
			BaseField<TValueType>.NativeMethodInfoPtr_UnregisterEditingCallbacks_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664644);
			BaseField<TValueType>.NativeMethodInfoPtr_StartEditing_Internal_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664645);
			BaseField<TValueType>.NativeMethodInfoPtr_EndEditing_Internal_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664646);
			BaseField<TValueType>.NativeMethodInfoPtr_OnCustomStyleResolved_Private_Void_CustomStyleResolvedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664647);
			BaseField<TValueType>.NativeMethodInfoPtr_OnInspectorFieldGeometryChanged_Private_Void_GeometryChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664648);
			BaseField<TValueType>.NativeMethodInfoPtr_AlignLabel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664649);
			BaseField<TValueType>.NativeMethodInfoPtr_ValidatedValue_Internal_TValueType_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664650);
			BaseField<TValueType>.NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664651);
			BaseField<TValueType>.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_New_Void_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664652);
			BaseField<TValueType>.NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664653);
			BaseField<TValueType>.NativeMethodInfoPtr_GetTooltipRect_Internal_Virtual_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, 100664654);
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x0003E098 File Offset: 0x0003C298
		// (set) Token: 0x0600093C RID: 2364 RVA: 0x0003E0D8 File Offset: 0x0003C2D8
		public unsafe VisualElement visualInput
		{
			[CallerCount(95)]
			[CachedScanResults(RefRangeStart = 295669, RefRangeEnd = 295764, XrefRangeStart = 295669, XrefRangeEnd = 295669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseField<TValueType>.NativeMethodInfoPtr_get_visualInput_Internal_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295764, XrefRangeEnd = 295857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseField<TValueType>.NativeMethodInfoPtr_set_visualInput_Internal_set_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x0003E11C File Offset: 0x0003C31C
		// (set) Token: 0x0600093E RID: 2366 RVA: 0x0003E158 File Offset: 0x0003C358
		public unsafe TValueType rawValue
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 295857, RefRangeEnd = 295859, XrefRangeStart = 295857, XrefRangeEnd = 295857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseField<TValueType>.NativeMethodInfoPtr_get_rawValue_Protected_get_TValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TValueType>(intPtr, false, true);
			}
			[CallerCount(0)]
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BaseField<TValueType>.NativeMethodInfoPtr_set_rawValue_Protected_set_Void_TValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x0003E1D0 File Offset: 0x0003C3D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295864, RefRangeEnd = 295865, XrefRangeStart = 295859, XrefRangeEnd = 295864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_onValidateValue(Func<TValueType, TValueType> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseField<TValueType>.NativeMethodInfoPtr_add_onValidateValue_Internal_add_Void_Func_2_TValueType_TValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0003E214 File Offset: 0x0003C414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295865, XrefRangeEnd = 295870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_onValidateValue(Func<TValueType, TValueType> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseField<TValueType>.NativeMethodInfoPtr_remove_onValidateValue_Internal_rem_Void_Func_2_TValueType_TValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x0003E258 File Offset: 0x0003C458
		// (set) Token: 0x06000942 RID: 2370 RVA: 0x0003E29C File Offset: 0x0003C49C
		public unsafe virtual TValueType value
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 295857, RefRangeEnd = 295859, XrefRangeStart = 295857, XrefRangeEnd = 295859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseField<TValueType>.NativeMethodInfoPtr_get_value_Public_Virtual_New_get_TValueType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TValueType>(intPtr, false, true);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 295881, RefRangeEnd = 295882, XrefRangeStart = 295870, XrefRangeEnd = 295881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseField<TValueType>.NativeMethodInfoPtr_set_value_Public_Virtual_New_set_Void_TValueType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x0003E320 File Offset: 0x0003C520
		// (set) Token: 0x06000944 RID: 2372 RVA: 0x0003E360 File Offset: 0x0003C560
		public unsafe virtual Label labelElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseField<TValueType>.NativeMethodInfoPtr_get_labelElement_Public_Virtual_Final_New_get_Label_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Label>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295882, XrefRangeEnd = 295893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseField<TValueType>.NativeMethodInfoPtr_set_labelElement_Private_set_Void_Label_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x0003E3A4 File Offset: 0x0003C5A4
		// (set) Token: 0x06000946 RID: 2374 RVA: 0x0003E3DC File Offset: 0x0003C5DC
		public unsafe virtual string label
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295893, XrefRangeEnd = 295908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseField<TValueType>.NativeMethodInfoPtr_get_label_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 295916, RefRangeEnd = 295920, XrefRangeStart = 295908, XrefRangeEnd = 295916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseField<TValueType>.NativeMethodInfoPtr_set_label_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x0003E420 File Offset: 0x0003C620
		// (set) Token: 0x06000948 RID: 2376 RVA: 0x0003E45C File Offset: 0x0003C65C
		public unsafe virtual bool showMixedValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseField<TValueType>.NativeMethodInfoPtr_get_showMixedValue_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 295920, RefRangeEnd = 295924, XrefRangeStart = 295920, XrefRangeEnd = 295920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseField<TValueType>.NativeMethodInfoPtr_set_showMixedValue_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x0003E49C File Offset: 0x0003C69C
		public unsafe virtual bool canSwitchToMixedValue
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseField<TValueType>.NativeMethodInfoPtr_get_canSwitchToMixedValue_FamAndAssem_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x0003E4E4 File Offset: 0x0003C6E4
		public unsafe Label mixedValueLabel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 295936, RefRangeEnd = 295937, XrefRangeStart = 295924, XrefRangeEnd = 295936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseField<TValueType>.NativeMethodInfoPtr_get_mixedValueLabel_Protected_get_Label_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Label>(intPtr3) : null;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x0003E524 File Offset: 0x0003C724
		// (set) Token: 0x0600099B RID: 2459 RVA: 0x00005715 File Offset: 0x00003915
		public unsafe virtual Action UnityEngine.UIElements.IEditableElement.editingStarted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseField<TValueType>.NativeMethodInfoPtr_UnityEngine_UIElements_IEditableElement_get_editingStarted_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			set
			{
				this._UnityEngine_UIElements_IEditableElement_editingStarted_k__BackingField = value;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x0600094C RID: 2380 RVA: 0x0003E564 File Offset: 0x0003C764
		// (set) Token: 0x0600099C RID: 2460 RVA: 0x0000571E File Offset: 0x0000391E
		public unsafe virtual Action UnityEngine.UIElements.IEditableElement.editingEnded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseField<TValueType>.NativeMethodInfoPtr_UnityEngine_UIElements_IEditableElement_get_editingEnded_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			set
			{
				this._UnityEngine_UIElements_IEditableElement_editingEnded_k__BackingField = value;
			}
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0003E5A4 File Offset: 0x0003C7A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295979, RefRangeEnd = 295980, XrefRangeStart = 295937, XrefRangeEnd = 295979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseField(string label)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseField<TValueType>.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x0003E5F0 File Offset: 0x0003C7F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296256, RefRangeEnd = 296257, XrefRangeStart = 295980, XrefRangeEnd = 296256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseField(string label, VisualElement visualInput)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(visualInput);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseField<TValueType>.NativeMethodInfoPtr__ctor_Protected_Void_String_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x0003E650 File Offset: 0x0003C850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296257, XrefRangeEnd = 296264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool EqualsCurrentValue(TValueType value)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseField<TValueType>.NativeMethodInfoPtr_EqualsCurrentValue_Internal_Virtual_New_Boolean_TValueType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x0003E6E0 File Offset: 0x0003C8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296264, XrefRangeEnd = 296297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAttachToPanel(AttachToPanelEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseField<TValueType>.NativeMethodInfoPtr_OnAttachToPanel_Private_Void_AttachToPanelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0003E724 File Offset: 0x0003C924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296297, XrefRangeEnd = 296301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDetachFromPanel(DetachFromPanelEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseField<TValueType>.NativeMethodInfoPtr_OnDetachFromPanel_Private_Void_DetachFromPanelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0003E768 File Offset: 0x0003C968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296301, XrefRangeEnd = 296364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RegisterEditingCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseField<TValueType>.NativeMethodInfoPtr_RegisterEditingCallbacks_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0003E7A4 File Offset: 0x0003C9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296364, XrefRangeEnd = 296379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnregisterEditingCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseField<TValueType>.NativeMethodInfoPtr_UnregisterEditingCallbacks_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0003E7E0 File Offset: 0x0003C9E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296379, XrefRangeEnd = 296382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartEditing(EventBase e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseField<TValueType>.NativeMethodInfoPtr_StartEditing_Internal_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x0003E824 File Offset: 0x0003CA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296382, XrefRangeEnd = 296385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndEditing(EventBase e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseField<TValueType>.NativeMethodInfoPtr_EndEditing_Internal_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x0003E868 File Offset: 0x0003CA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296385, XrefRangeEnd = 296411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCustomStyleResolved(CustomStyleResolvedEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseField<TValueType>.NativeMethodInfoPtr_OnCustomStyleResolved_Private_Void_CustomStyleResolvedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x0003E8AC File Offset: 0x0003CAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296411, XrefRangeEnd = 296432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInspectorFieldGeometryChanged(GeometryChangedEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseField<TValueType>.NativeMethodInfoPtr_OnInspectorFieldGeometryChanged_Private_Void_GeometryChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0003E8F0 File Offset: 0x0003CAF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 296463, RefRangeEnd = 296465, XrefRangeStart = 296432, XrefRangeEnd = 296463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseField<TValueType>.NativeMethodInfoPtr_AlignLabel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0003E924 File Offset: 0x0003CB24
		[CallerCount(0)]
		public unsafe TValueType ValidatedValue(TValueType value)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BaseField<TValueType>.NativeMethodInfoPtr_ValidatedValue_Internal_TValueType_TValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<TValueType>(intPtr2, false, true);
			}
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x0003E9A4 File Offset: 0x0003CBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296465, XrefRangeEnd = 296469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateMixedValueContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseField<TValueType>.NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x0003E9E0 File Offset: 0x0003CBE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296472, RefRangeEnd = 296473, XrefRangeStart = 296469, XrefRangeEnd = 296472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetValueWithoutNotify(TValueType newValue)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseField<TValueType>.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_New_Void_TValueType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x0003EA64 File Offset: 0x0003CC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296473, XrefRangeEnd = 296487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnViewDataReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseField<TValueType>.NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x0003EAA0 File Offset: 0x0003CCA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296487, XrefRangeEnd = 296490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Rect GetTooltipRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseField<TValueType>.NativeMethodInfoPtr_GetTooltipRect_Internal_Virtual_Rect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00005447 File Offset: 0x00003647
		public BaseField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x0003EAE8 File Offset: 0x0003CCE8
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x00005450 File Offset: 0x00003650
		public unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseField<TValueType>.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseField<TValueType>.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x0003EB08 File Offset: 0x0003CD08
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x00005462 File Offset: 0x00003662
		public unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseField<TValueType>.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseField<TValueType>.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x0003EB28 File Offset: 0x0003CD28
		// (set) Token: 0x06000964 RID: 2404 RVA: 0x00005474 File Offset: 0x00003674
		public unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseField<TValueType>.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseField<TValueType>.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x0003EB48 File Offset: 0x0003CD48
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x00005486 File Offset: 0x00003686
		public unsafe static string noLabelVariantUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseField<TValueType>.NativeFieldInfoPtr_noLabelVariantUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseField<TValueType>.NativeFieldInfoPtr_noLabelVariantUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x0003EB68 File Offset: 0x0003CD68
		// (set) Token: 0x06000968 RID: 2408 RVA: 0x00005498 File Offset: 0x00003698
		public unsafe static string labelDraggerVariantUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseField<TValueType>.NativeFieldInfoPtr_labelDraggerVariantUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseField<TValueType>.NativeFieldInfoPtr_labelDraggerVariantUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x0003EB88 File Offset: 0x0003CD88
		// (set) Token: 0x0600096A RID: 2410 RVA: 0x000054AA File Offset: 0x000036AA
		public unsafe static string mixedValueLabelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseField<TValueType>.NativeFieldInfoPtr_mixedValueLabelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseField<TValueType>.NativeFieldInfoPtr_mixedValueLabelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x0003EBA8 File Offset: 0x0003CDA8
		// (set) Token: 0x0600096C RID: 2412 RVA: 0x000054BC File Offset: 0x000036BC
		public unsafe static string alignedFieldUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseField<TValueType>.NativeFieldInfoPtr_alignedFieldUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseField<TValueType>.NativeFieldInfoPtr_alignedFieldUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x0003EBC8 File Offset: 0x0003CDC8
		// (set) Token: 0x0600096E RID: 2414 RVA: 0x000054CE File Offset: 0x000036CE
		public unsafe static string inspectorFieldUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseField<TValueType>.NativeFieldInfoPtr_inspectorFieldUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseField<TValueType>.NativeFieldInfoPtr_inspectorFieldUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x0003EBE8 File Offset: 0x0003CDE8
		// (set) Token: 0x06000970 RID: 2416 RVA: 0x000054E0 File Offset: 0x000036E0
		public unsafe static string mixedValueString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseField<TValueType>.NativeFieldInfoPtr_mixedValueString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseField<TValueType>.NativeFieldInfoPtr_mixedValueString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x0003EC08 File Offset: 0x0003CE08
		// (set) Token: 0x06000972 RID: 2418 RVA: 0x000054F2 File Offset: 0x000036F2
		public unsafe static PropertyName serializedPropertyCopyName
		{
			get
			{
				PropertyName propertyName;
				IL2CPP.il2cpp_field_static_get_value(BaseField<TValueType>.NativeFieldInfoPtr_serializedPropertyCopyName, (void*)(&propertyName));
				return propertyName;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseField<TValueType>.NativeFieldInfoPtr_serializedPropertyCopyName, (void*)(&value));
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x0003EC24 File Offset: 0x0003CE24
		// (set) Token: 0x06000974 RID: 2420 RVA: 0x00005500 File Offset: 0x00003700
		public unsafe static CustomStyleProperty<float> s_LabelWidthRatioProperty
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CustomStyleProperty<float>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(BaseField<TValueType>.NativeFieldInfoPtr_s_LabelWidthRatioProperty, intPtr);
				return new CustomStyleProperty<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomStyleProperty<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseField<TValueType>.NativeFieldInfoPtr_s_LabelWidthRatioProperty, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x0003EC60 File Offset: 0x0003CE60
		// (set) Token: 0x06000976 RID: 2422 RVA: 0x00005517 File Offset: 0x00003717
		public unsafe static CustomStyleProperty<float> s_LabelExtraPaddingProperty
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CustomStyleProperty<float>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(BaseField<TValueType>.NativeFieldInfoPtr_s_LabelExtraPaddingProperty, intPtr);
				return new CustomStyleProperty<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomStyleProperty<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseField<TValueType>.NativeFieldInfoPtr_s_LabelExtraPaddingProperty, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x0003EC9C File Offset: 0x0003CE9C
		// (set) Token: 0x06000978 RID: 2424 RVA: 0x0000552E File Offset: 0x0000372E
		public unsafe static CustomStyleProperty<float> s_LabelBaseMinWidthProperty
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CustomStyleProperty<float>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(BaseField<TValueType>.NativeFieldInfoPtr_s_LabelBaseMinWidthProperty, intPtr);
				return new CustomStyleProperty<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomStyleProperty<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseField<TValueType>.NativeFieldInfoPtr_s_LabelBaseMinWidthProperty, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x0003ECD8 File Offset: 0x0003CED8
		// (set) Token: 0x0600097A RID: 2426 RVA: 0x00005545 File Offset: 0x00003745
		public unsafe static CustomStyleProperty<float> s_LabelExtraContextWidthProperty
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CustomStyleProperty<float>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(BaseField<TValueType>.NativeFieldInfoPtr_s_LabelExtraContextWidthProperty, intPtr);
				return new CustomStyleProperty<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomStyleProperty<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseField<TValueType>.NativeFieldInfoPtr_s_LabelExtraContextWidthProperty, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x0003ED14 File Offset: 0x0003CF14
		// (set) Token: 0x0600097C RID: 2428 RVA: 0x0000555C File Offset: 0x0000375C
		public unsafe float m_LabelWidthRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr_m_LabelWidthRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr_m_LabelWidthRatio)) = value;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x0003ED3C File Offset: 0x0003CF3C
		// (set) Token: 0x0600097E RID: 2430 RVA: 0x00005577 File Offset: 0x00003777
		public unsafe float m_LabelExtraPadding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr_m_LabelExtraPadding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr_m_LabelExtraPadding)) = value;
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x0003ED64 File Offset: 0x0003CF64
		// (set) Token: 0x06000980 RID: 2432 RVA: 0x00005592 File Offset: 0x00003792
		public unsafe float m_LabelBaseMinWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr_m_LabelBaseMinWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr_m_LabelBaseMinWidth)) = value;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x0003ED8C File Offset: 0x0003CF8C
		// (set) Token: 0x06000982 RID: 2434 RVA: 0x000055AD File Offset: 0x000037AD
		public unsafe float m_LabelExtraContextWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr_m_LabelExtraContextWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr_m_LabelExtraContextWidth)) = value;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x0003EDB4 File Offset: 0x0003CFB4
		// (set) Token: 0x06000984 RID: 2436 RVA: 0x000055C8 File Offset: 0x000037C8
		public unsafe VisualElement m_VisualInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr_m_VisualInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr_m_VisualInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x0003EDE4 File Offset: 0x0003CFE4
		// (set) Token: 0x06000986 RID: 2438 RVA: 0x000055E7 File Offset: 0x000037E7
		public unsafe Action<ExpressionEvaluator.Expression> expressionEvaluated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr_expressionEvaluated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ExpressionEvaluator.Expression>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr_expressionEvaluated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x0003EE14 File Offset: 0x0003D014
		// (set) Token: 0x06000988 RID: 2440 RVA: 0x0003EE3C File Offset: 0x0003D03C
		public unsafe TValueType m_Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr_m_Value);
				return IL2CPP.PointerToValueGeneric<TValueType>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr_m_Value);
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

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x0003EEE4 File Offset: 0x0003D0E4
		// (set) Token: 0x0600098A RID: 2442 RVA: 0x00005606 File Offset: 0x00003806
		public unsafe Func<TValueType, TValueType> onValidateValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr_onValidateValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TValueType, TValueType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr_onValidateValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x0003EF14 File Offset: 0x0003D114
		// (set) Token: 0x0600098C RID: 2444 RVA: 0x00005625 File Offset: 0x00003825
		public unsafe Label _labelElement_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr__labelElement_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Label>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr__labelElement_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x0003EF44 File Offset: 0x0003D144
		// (set) Token: 0x0600098E RID: 2446 RVA: 0x00005644 File Offset: 0x00003844
		public unsafe bool m_ShowMixedValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr_m_ShowMixedValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr_m_ShowMixedValue)) = value;
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x0003EF6C File Offset: 0x0003D16C
		// (set) Token: 0x06000990 RID: 2448 RVA: 0x0000565F File Offset: 0x0000385F
		public unsafe Label m_MixedValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr_m_MixedValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Label>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr_m_MixedValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x0003EF9C File Offset: 0x0003D19C
		// (set) Token: 0x06000992 RID: 2450 RVA: 0x0000567E File Offset: 0x0000387E
		public unsafe bool m_SkipValidation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr_m_SkipValidation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr_m_SkipValidation)) = value;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x0003EFC4 File Offset: 0x0003D1C4
		// (set) Token: 0x06000994 RID: 2452 RVA: 0x00005699 File Offset: 0x00003899
		public unsafe VisualElement m_CachedContextWidthElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr_m_CachedContextWidthElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr_m_CachedContextWidthElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x0003EFF4 File Offset: 0x0003D1F4
		// (set) Token: 0x06000996 RID: 2454 RVA: 0x000056B8 File Offset: 0x000038B8
		public unsafe VisualElement m_CachedInspectorElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr_m_CachedInspectorElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr_m_CachedInspectorElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x0003F024 File Offset: 0x0003D224
		// (set) Token: 0x06000998 RID: 2456 RVA: 0x000056D7 File Offset: 0x000038D7
		public unsafe Action _UnityEngine_UIElements_IEditableElement_editingStarted_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr__UnityEngine_UIElements_IEditableElement_editingStarted_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr__UnityEngine_UIElements_IEditableElement_editingStarted_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x0003F054 File Offset: 0x0003D254
		// (set) Token: 0x0600099A RID: 2458 RVA: 0x000056F6 File Offset: 0x000038F6
		public unsafe Action _UnityEngine_UIElements_IEditableElement_editingEnded_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr__UnityEngine_UIElements_IEditableElement_editingEnded_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.NativeFieldInfoPtr__UnityEngine_UIElements_IEditableElement_editingEnded_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x00005727 File Offset: 0x00003927
		public void SetValueWithoutValidation(TValueType newValue)
		{
			this.m_SkipValidation = true;
			this.value = newValue;
			this.m_SkipValidation = false;
		}

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeFieldInfoPtr_noLabelVariantUssClassName;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeFieldInfoPtr_labelDraggerVariantUssClassName;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeFieldInfoPtr_mixedValueLabelUssClassName;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeFieldInfoPtr_alignedFieldUssClassName;

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeFieldInfoPtr_inspectorFieldUssClassName;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeFieldInfoPtr_mixedValueString;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeFieldInfoPtr_serializedPropertyCopyName;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeFieldInfoPtr_s_LabelWidthRatioProperty;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeFieldInfoPtr_s_LabelExtraPaddingProperty;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeFieldInfoPtr_s_LabelBaseMinWidthProperty;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeFieldInfoPtr_s_LabelExtraContextWidthProperty;

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeFieldInfoPtr_m_LabelWidthRatio;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeFieldInfoPtr_m_LabelExtraPadding;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeFieldInfoPtr_m_LabelBaseMinWidth;

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeFieldInfoPtr_m_LabelExtraContextWidth;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeFieldInfoPtr_m_VisualInput;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeFieldInfoPtr_expressionEvaluated;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeFieldInfoPtr_onValidateValue;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeFieldInfoPtr__labelElement_k__BackingField;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeFieldInfoPtr_m_ShowMixedValue;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeFieldInfoPtr_m_MixedValueLabel;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeFieldInfoPtr_m_SkipValidation;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedContextWidthElement;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedInspectorElement;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeFieldInfoPtr__UnityEngine_UIElements_IEditableElement_editingStarted_k__BackingField;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeFieldInfoPtr__UnityEngine_UIElements_IEditableElement_editingEnded_k__BackingField;

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeMethodInfoPtr_get_visualInput_Internal_get_VisualElement_0;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeMethodInfoPtr_set_visualInput_Internal_set_Void_VisualElement_0;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeMethodInfoPtr_get_rawValue_Protected_get_TValueType_0;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeMethodInfoPtr_set_rawValue_Protected_set_Void_TValueType_0;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeMethodInfoPtr_add_onValidateValue_Internal_add_Void_Func_2_TValueType_TValueType_0;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeMethodInfoPtr_remove_onValidateValue_Internal_rem_Void_Func_2_TValueType_TValueType_0;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_New_get_TValueType_0;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_Virtual_New_set_Void_TValueType_0;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeMethodInfoPtr_get_labelElement_Public_Virtual_Final_New_get_Label_0;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeMethodInfoPtr_set_labelElement_Private_set_Void_Label_0;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeMethodInfoPtr_get_label_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeMethodInfoPtr_set_label_Public_set_Void_String_0;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeMethodInfoPtr_get_showMixedValue_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeMethodInfoPtr_set_showMixedValue_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeMethodInfoPtr_get_canSwitchToMixedValue_FamAndAssem_Virtual_New_get_Boolean_0;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeMethodInfoPtr_get_mixedValueLabel_Protected_get_Label_0;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IEditableElement_get_editingStarted_Private_Virtual_Final_New_get_Action_0;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IEditableElement_get_editingEnded_Private_Virtual_Final_New_get_Action_0;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_VisualElement_0;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeMethodInfoPtr_EqualsCurrentValue_Internal_Virtual_New_Boolean_TValueType_0;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeMethodInfoPtr_OnAttachToPanel_Private_Void_AttachToPanelEvent_0;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeMethodInfoPtr_OnDetachFromPanel_Private_Void_DetachFromPanelEvent_0;

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEditingCallbacks_Internal_Virtual_New_Void_0;

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterEditingCallbacks_Internal_Virtual_New_Void_0;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeMethodInfoPtr_StartEditing_Internal_Void_EventBase_0;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeMethodInfoPtr_EndEditing_Internal_Void_EventBase_0;

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeMethodInfoPtr_OnCustomStyleResolved_Private_Void_CustomStyleResolvedEvent_0;

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeMethodInfoPtr_OnInspectorFieldGeometryChanged_Private_Void_GeometryChangedEvent_0;

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeMethodInfoPtr_AlignLabel_Private_Void_0;

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeMethodInfoPtr_ValidatedValue_Internal_TValueType_TValueType_0;

		// Token: 0x040006AD RID: 1709
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_New_Void_0;

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_New_Void_TValueType_0;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0;

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeMethodInfoPtr_GetTooltipRect_Internal_Virtual_Rect_0;

		// Token: 0x02000385 RID: 901
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			// Token: 0x060037E9 RID: 14313 RVA: 0x000E4B5C File Offset: 0x000E2D5C
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<BaseField<TValueType>.UxmlTraits>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseField<TValueType>>.NativeClassPtr, "UxmlTraits"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValueType>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseField<TValueType>.UxmlTraits>.NativeClassPtr);
				BaseField<TValueType>.UxmlTraits.NativeFieldInfoPtr_m_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseField<TValueType>.UxmlTraits>.NativeClassPtr, "m_Label");
				BaseField<TValueType>.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>.UxmlTraits>.NativeClassPtr, 100664656);
				BaseField<TValueType>.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>.UxmlTraits>.NativeClassPtr, 100664657);
				BaseField<TValueType>.UxmlTraits.NativeMethodInfoPtr_ParseChoiceList_Internal_Static_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseField<TValueType>.UxmlTraits>.NativeClassPtr, 100664658);
			}

			// Token: 0x060037EA RID: 14314 RVA: 0x000E4C14 File Offset: 0x000E2E14
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 295628, RefRangeEnd = 295629, XrefRangeStart = 295617, XrefRangeEnd = 295628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseField<TValueType>.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseField<TValueType>.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037EB RID: 14315 RVA: 0x000E4C50 File Offset: 0x000E2E50
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 295645, RefRangeEnd = 295653, XrefRangeStart = 295629, XrefRangeEnd = 295645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseField<TValueType>.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037EC RID: 14316 RVA: 0x000E4CC8 File Offset: 0x000E2EC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295653, XrefRangeEnd = 295669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static List<string> ParseChoiceList(string choicesFromBag)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(choicesFromBag);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseField<TValueType>.UxmlTraits.NativeMethodInfoPtr_ParseChoiceList_Internal_Static_List_1_String_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
				}
			}

			// Token: 0x060037ED RID: 14317 RVA: 0x00017339 File Offset: 0x00015539
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700113C RID: 4412
			// (get) Token: 0x060037EE RID: 14318 RVA: 0x000E4D0C File Offset: 0x000E2F0C
			// (set) Token: 0x060037EF RID: 14319 RVA: 0x00017342 File Offset: 0x00015542
			public unsafe UxmlStringAttributeDescription m_Label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.UxmlTraits.NativeFieldInfoPtr_m_Label);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseField<TValueType>.UxmlTraits.NativeFieldInfoPtr_m_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040027C5 RID: 10181
			private static readonly IntPtr NativeFieldInfoPtr_m_Label;

			// Token: 0x040027C6 RID: 10182
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040027C7 RID: 10183
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x040027C8 RID: 10184
			private static readonly IntPtr NativeMethodInfoPtr_ParseChoiceList_Internal_Static_List_1_String_String_0;
		}
	}
}

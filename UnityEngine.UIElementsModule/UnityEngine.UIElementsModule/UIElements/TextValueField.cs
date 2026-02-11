using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.UIElements
{
	// Token: 0x0200008C RID: 140
	public class TextValueField<TValueType> : TextInputBaseField<TValueType>
	{
		// Token: 0x06000E35 RID: 3637 RVA: 0x0004EF34 File Offset: 0x0004D134
		// Note: this type is marked as 'beforefieldinit'.
		static TextValueField()
		{
			Il2CppClassPointerStore<TextValueField<TValueType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TextValueField`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValueType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextValueField<TValueType>>.NativeClassPtr);
			TextValueField<TValueType>.NativeFieldInfoPtr_m_Dragger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextValueField<TValueType>>.NativeClassPtr, "m_Dragger");
			TextValueField<TValueType>.NativeFieldInfoPtr_m_ForceUpdateDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextValueField<TValueType>>.NativeClassPtr, "m_ForceUpdateDisplay");
			TextValueField<TValueType>.NativeMethodInfoPtr_get_textValueInput_Private_get_TextValueInput_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>>.NativeClassPtr, 100665317);
			TextValueField<TValueType>.NativeMethodInfoPtr_get_formatString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>>.NativeClassPtr, 100665318);
			TextValueField<TValueType>.NativeMethodInfoPtr__ctor_Protected_Void_String_Int32_TextValueInput_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>>.NativeClassPtr, 100665319);
			TextValueField<TValueType>.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Abstract_Virtual_New_Void_Vector3_DeltaSpeed_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>>.NativeClassPtr, 100665320);
			TextValueField<TValueType>.NativeMethodInfoPtr_StartDragging_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>>.NativeClassPtr, 100665321);
			TextValueField<TValueType>.NativeMethodInfoPtr_StopDragging_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>>.NativeClassPtr, 100665322);
			TextValueField<TValueType>.NativeMethodInfoPtr_get_value_Public_Virtual_get_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>>.NativeClassPtr, 100665323);
			TextValueField<TValueType>.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>>.NativeClassPtr, 100665324);
			TextValueField<TValueType>.NativeMethodInfoPtr_UpdateValueFromText_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>>.NativeClassPtr, 100665325);
			TextValueField<TValueType>.NativeMethodInfoPtr_UpdateTextFromValue_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>>.NativeClassPtr, 100665326);
			TextValueField<TValueType>.NativeMethodInfoPtr_OnIsReadOnlyChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>>.NativeClassPtr, 100665327);
			TextValueField<TValueType>.NativeMethodInfoPtr_CanTryParse_Internal_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>>.NativeClassPtr, 100665328);
			TextValueField<TValueType>.NativeMethodInfoPtr_AddLabelDragger_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>>.NativeClassPtr, 100665329);
			TextValueField<TValueType>.NativeMethodInfoPtr_EnableLabelDragger_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>>.NativeClassPtr, 100665330);
			TextValueField<TValueType>.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>>.NativeClassPtr, 100665331);
			TextValueField<TValueType>.NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>>.NativeClassPtr, 100665332);
			TextValueField<TValueType>.NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>>.NativeClassPtr, 100665333);
			TextValueField<TValueType>.NativeMethodInfoPtr_RegisterEditingCallbacks_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>>.NativeClassPtr, 100665334);
			TextValueField<TValueType>.NativeMethodInfoPtr_UnregisterEditingCallbacks_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>>.NativeClassPtr, 100665335);
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x0004F144 File Offset: 0x0004D344
		public unsafe TextValueField<TValueType>.TextValueInput textValueInput
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305413, XrefRangeEnd = 305414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextValueField<TValueType>.NativeMethodInfoPtr_get_textValueInput_Private_get_TextValueInput_TValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextValueField<TValueType>.TextValueInput>(intPtr3) : null;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x0004F184 File Offset: 0x0004D384
		// (set) Token: 0x06000E4E RID: 3662 RVA: 0x0004F75C File Offset: 0x0004D95C
		public unsafe string formatString
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 305415, RefRangeEnd = 305421, XrefRangeStart = 305414, XrefRangeEnd = 305415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextValueField<TValueType>.NativeMethodInfoPtr_get_formatString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				bool flag = this.textValueInput.formatString != value;
				if (flag)
				{
					this.textValueInput.formatString = value;
					base.textEdition.UpdateText(this.ValueToString(base.rawValue));
				}
			}
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x0004F1BC File Offset: 0x0004D3BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 305445, RefRangeEnd = 305447, XrefRangeStart = 305421, XrefRangeEnd = 305445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextValueField(string label, int maxLength, TextValueField<TValueType>.TextValueInput textValueInput)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextValueField<TValueType>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textValueInput);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextValueField<TValueType>.NativeMethodInfoPtr__ctor_Protected_Void_String_Int32_TextValueInput_TValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x0004F228 File Offset: 0x0004D428
		[CallerCount(0)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextValueField<TValueType>.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Abstract_Virtual_New_Void_Vector3_DeltaSpeed_TValueType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x0004F2C8 File Offset: 0x0004D4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305447, XrefRangeEnd = 305502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartDragging()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextValueField<TValueType>.NativeMethodInfoPtr_StartDragging_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x0004F2FC File Offset: 0x0004D4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305502, XrefRangeEnd = 305529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StopDragging()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextValueField<TValueType>.NativeMethodInfoPtr_StopDragging_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x0004F330 File Offset: 0x0004D530
		// (set) Token: 0x06000E3D RID: 3645 RVA: 0x0004F374 File Offset: 0x0004D574
		public unsafe override TValueType value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305529, XrefRangeEnd = 305533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextValueField<TValueType>.NativeMethodInfoPtr_get_value_Public_Virtual_get_TValueType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TValueType>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305533, XrefRangeEnd = 305547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextValueField<TValueType>.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_TValueType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x0004F3F8 File Offset: 0x0004D5F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305547, XrefRangeEnd = 305549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateValueFromText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextValueField<TValueType>.NativeMethodInfoPtr_UpdateValueFromText_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x0004F434 File Offset: 0x0004D634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305549, XrefRangeEnd = 305551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateTextFromValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextValueField<TValueType>.NativeMethodInfoPtr_UpdateTextFromValue_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x0004F470 File Offset: 0x0004D670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305551, XrefRangeEnd = 305557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnIsReadOnlyChanged(bool newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextValueField<TValueType>.NativeMethodInfoPtr_OnIsReadOnlyChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x0004F4B0 File Offset: 0x0004D6B0
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanTryParse(string textString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(textString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextValueField<TValueType>.NativeMethodInfoPtr_CanTryParse_Internal_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x0004F508 File Offset: 0x0004D708
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 305672, RefRangeEnd = 305674, XrefRangeStart = 305557, XrefRangeEnd = 305672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddLabelDragger<TDraggerType>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextValueField<TDraggerType>.MethodInfoStoreGeneric_AddLabelDragger_Protected_Void_0.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x0004F53C File Offset: 0x0004D73C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 305680, RefRangeEnd = 305686, XrefRangeStart = 305674, XrefRangeEnd = 305680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableLabelDragger(bool enable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextValueField<TValueType>.NativeMethodInfoPtr_EnableLabelDragger_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x0004F57C File Offset: 0x0004D77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305686, XrefRangeEnd = 305706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextValueField<TValueType>.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_TValueType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x0004F600 File Offset: 0x0004D800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305706, XrefRangeEnd = 305723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ExecuteDefaultAction(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextValueField<TValueType>.NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x0004F650 File Offset: 0x0004D850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305723, XrefRangeEnd = 305729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnViewDataReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextValueField<TValueType>.NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x0004F68C File Offset: 0x0004D88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305729, XrefRangeEnd = 305855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RegisterEditingCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextValueField<TValueType>.NativeMethodInfoPtr_RegisterEditingCallbacks_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x0004F6C8 File Offset: 0x0004D8C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305855, XrefRangeEnd = 305952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UnregisterEditingCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextValueField<TValueType>.NativeMethodInfoPtr_UnregisterEditingCallbacks_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x0000753B File Offset: 0x0000573B
		public TextValueField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x0004F704 File Offset: 0x0004D904
		// (set) Token: 0x06000E4B RID: 3659 RVA: 0x00007544 File Offset: 0x00005744
		public unsafe BaseFieldMouseDragger m_Dragger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextValueField<TValueType>.NativeFieldInfoPtr_m_Dragger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseFieldMouseDragger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextValueField<TValueType>.NativeFieldInfoPtr_m_Dragger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x0004F734 File Offset: 0x0004D934
		// (set) Token: 0x06000E4D RID: 3661 RVA: 0x00007563 File Offset: 0x00005763
		public unsafe bool m_ForceUpdateDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextValueField<TValueType>.NativeFieldInfoPtr_m_ForceUpdateDisplay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextValueField<TValueType>.NativeFieldInfoPtr_m_ForceUpdateDisplay)) = value;
			}
		}

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeFieldInfoPtr_m_Dragger;

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeFieldInfoPtr_m_ForceUpdateDisplay;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeMethodInfoPtr_get_textValueInput_Private_get_TextValueInput_TValueType_0;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeMethodInfoPtr_get_formatString_Public_get_String_0;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_Int32_TextValueInput_TValueType_0;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Abstract_Virtual_New_Void_Vector3_DeltaSpeed_TValueType_0;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeMethodInfoPtr_StartDragging_Public_Virtual_Final_New_Void_0;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeMethodInfoPtr_StopDragging_Public_Virtual_Final_New_Void_0;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_get_TValueType_0;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_TValueType_0;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValueFromText_Internal_Virtual_Void_0;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTextFromValue_Internal_Virtual_Void_0;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeMethodInfoPtr_OnIsReadOnlyChanged_Private_Void_Boolean_0;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeMethodInfoPtr_CanTryParse_Internal_Virtual_New_Boolean_String_0;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeMethodInfoPtr_AddLabelDragger_Protected_Void_0;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeMethodInfoPtr_EnableLabelDragger_Private_Void_Boolean_0;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_TValueType_0;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_Void_EventBase_0;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEditingCallbacks_Internal_Virtual_Void_0;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterEditingCallbacks_Internal_Virtual_Void_0;

		// Token: 0x040009FE RID: 2558
		public const int kMaxValueFieldLength = 1000;

		// Token: 0x020003C7 RID: 967
		public class TextValueInput : TextInputBaseField<TValueType>.TextInputBase
		{
			// Token: 0x060039A6 RID: 14758 RVA: 0x000E9CB4 File Offset: 0x000E7EB4
			// Note: this type is marked as 'beforefieldinit'.
			static TextValueInput()
			{
				Il2CppClassPointerStore<TextValueField<TValueType>.TextValueInput>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextValueField<TValueType>>.NativeClassPtr, "TextValueInput"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValueType>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextValueField<TValueType>.TextValueInput>.NativeClassPtr);
				TextValueField<TValueType>.TextValueInput.NativeFieldInfoPtr__formatString_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextValueField<TValueType>.TextValueInput>.NativeClassPtr, "<formatString>k__BackingField");
				TextValueField<TValueType>.TextValueInput.NativeMethodInfoPtr_get_textValueFieldParent_Private_get_TextValueField_1_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>.TextValueInput>.NativeClassPtr, 100665336);
				TextValueField<TValueType>.TextValueInput.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>.TextValueInput>.NativeClassPtr, 100665337);
				TextValueField<TValueType>.TextValueInput.NativeMethodInfoPtr_AcceptCharacter_Internal_Virtual_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>.TextValueInput>.NativeClassPtr, 100665338);
				TextValueField<TValueType>.TextValueInput.NativeMethodInfoPtr_get_allowedCharacters_Protected_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>.TextValueInput>.NativeClassPtr, 100665339);
				TextValueField<TValueType>.TextValueInput.NativeMethodInfoPtr_get_formatString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>.TextValueInput>.NativeClassPtr, 100665340);
				TextValueField<TValueType>.TextValueInput.NativeMethodInfoPtr_set_formatString_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>.TextValueInput>.NativeClassPtr, 100665341);
				TextValueField<TValueType>.TextValueInput.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Abstract_Virtual_New_Void_Vector3_DeltaSpeed_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>.TextValueInput>.NativeClassPtr, 100665342);
				TextValueField<TValueType>.TextValueInput.NativeMethodInfoPtr_StartDragging_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>.TextValueInput>.NativeClassPtr, 100665343);
				TextValueField<TValueType>.TextValueInput.NativeMethodInfoPtr_StopDragging_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>.TextValueInput>.NativeClassPtr, 100665344);
				TextValueField<TValueType>.TextValueInput.NativeMethodInfoPtr_ValueToString_Protected_Abstract_Virtual_New_String_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>.TextValueInput>.NativeClassPtr, 100665345);
				TextValueField<TValueType>.TextValueInput.NativeMethodInfoPtr_StringToValue_Protected_Virtual_TValueType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextValueField<TValueType>.TextValueInput>.NativeClassPtr, 100665346);
			}

			// Token: 0x170011B6 RID: 4534
			// (get) Token: 0x060039A7 RID: 14759 RVA: 0x000E9E0C File Offset: 0x000E800C
			public unsafe TextValueField<TValueType> textValueFieldParent
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305311, XrefRangeEnd = 305313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextValueField<TValueType>.TextValueInput.NativeMethodInfoPtr_get_textValueFieldParent_Private_get_TextValueField_1_TValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextValueField<TValueType>>(intPtr3) : null;
				}
			}

			// Token: 0x060039A8 RID: 14760 RVA: 0x000E9E4C File Offset: 0x000E804C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 305337, RefRangeEnd = 305340, XrefRangeStart = 305313, XrefRangeEnd = 305337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TextValueInput()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextValueField<TValueType>.TextValueInput>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextValueField<TValueType>.TextValueInput.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039A9 RID: 14761 RVA: 0x000E9E88 File Offset: 0x000E8088
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305340, XrefRangeEnd = 305342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool AcceptCharacter(char c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref c;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextValueField<TValueType>.TextValueInput.NativeMethodInfoPtr_AcceptCharacter_Internal_Virtual_Boolean_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170011B7 RID: 4535
			// (get) Token: 0x060039AA RID: 14762 RVA: 0x000E9EDC File Offset: 0x000E80DC
			public unsafe virtual string allowedCharacters
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextValueField<TValueType>.TextValueInput.NativeMethodInfoPtr_get_allowedCharacters_Protected_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170011B8 RID: 4536
			// (get) Token: 0x060039AB RID: 14763 RVA: 0x000E9F20 File Offset: 0x000E8120
			// (set) Token: 0x060039AC RID: 14764 RVA: 0x000E9F58 File Offset: 0x000E8158
			public unsafe string formatString
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextValueField<TValueType>.TextValueInput.NativeMethodInfoPtr_get_formatString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305342, XrefRangeEnd = 305343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextValueField<TValueType>.TextValueInput.NativeMethodInfoPtr_set_formatString_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060039AD RID: 14765 RVA: 0x000E9F9C File Offset: 0x000E819C
			[CallerCount(0)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextValueField<TValueType>.TextValueInput.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Abstract_Virtual_New_Void_Vector3_DeltaSpeed_TValueType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x060039AE RID: 14766 RVA: 0x000EA03C File Offset: 0x000E823C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305343, XrefRangeEnd = 305355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void StartDragging()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextValueField<TValueType>.TextValueInput.NativeMethodInfoPtr_StartDragging_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039AF RID: 14767 RVA: 0x000EA070 File Offset: 0x000E8270
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305355, XrefRangeEnd = 305405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void StopDragging()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextValueField<TValueType>.TextValueInput.NativeMethodInfoPtr_StopDragging_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039B0 RID: 14768 RVA: 0x000EA0A4 File Offset: 0x000E82A4
			[CallerCount(0)]
			public unsafe virtual string ValueToString(TValueType value)
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextValueField<TValueType>.TextValueInput.NativeMethodInfoPtr_ValueToString_Protected_Abstract_Virtual_New_String_TValueType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.Il2CppStringToManaged(intPtr2);
				}
			}

			// Token: 0x060039B1 RID: 14769 RVA: 0x000EA130 File Offset: 0x000E8330
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305405, XrefRangeEnd = 305413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override TValueType StringToValue(string str)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextValueField<TValueType>.TextValueInput.NativeMethodInfoPtr_StringToValue_Protected_Virtual_TValueType_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TValueType>(intPtr, false, true);
				}
			}

			// Token: 0x060039B2 RID: 14770 RVA: 0x0001856E File Offset: 0x0001676E
			public TextValueInput(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011B5 RID: 4533
			// (get) Token: 0x060039B3 RID: 14771 RVA: 0x000EA188 File Offset: 0x000E8388
			// (set) Token: 0x060039B4 RID: 14772 RVA: 0x00018577 File Offset: 0x00016777
			public unsafe string _formatString_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextValueField<TValueType>.TextValueInput.NativeFieldInfoPtr__formatString_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextValueField<TValueType>.TextValueInput.NativeFieldInfoPtr__formatString_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040028C3 RID: 10435
			private static readonly IntPtr NativeFieldInfoPtr__formatString_k__BackingField;

			// Token: 0x040028C4 RID: 10436
			private static readonly IntPtr NativeMethodInfoPtr_get_textValueFieldParent_Private_get_TextValueField_1_TValueType_0;

			// Token: 0x040028C5 RID: 10437
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

			// Token: 0x040028C6 RID: 10438
			private static readonly IntPtr NativeMethodInfoPtr_AcceptCharacter_Internal_Virtual_Boolean_Char_0;

			// Token: 0x040028C7 RID: 10439
			private static readonly IntPtr NativeMethodInfoPtr_get_allowedCharacters_Protected_Abstract_Virtual_New_get_String_0;

			// Token: 0x040028C8 RID: 10440
			private static readonly IntPtr NativeMethodInfoPtr_get_formatString_Public_get_String_0;

			// Token: 0x040028C9 RID: 10441
			private static readonly IntPtr NativeMethodInfoPtr_set_formatString_Public_set_Void_String_0;

			// Token: 0x040028CA RID: 10442
			private static readonly IntPtr NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Abstract_Virtual_New_Void_Vector3_DeltaSpeed_TValueType_0;

			// Token: 0x040028CB RID: 10443
			private static readonly IntPtr NativeMethodInfoPtr_StartDragging_Public_Void_0;

			// Token: 0x040028CC RID: 10444
			private static readonly IntPtr NativeMethodInfoPtr_StopDragging_Public_Void_0;

			// Token: 0x040028CD RID: 10445
			private static readonly IntPtr NativeMethodInfoPtr_ValueToString_Protected_Abstract_Virtual_New_String_TValueType_0;

			// Token: 0x040028CE RID: 10446
			private static readonly IntPtr NativeMethodInfoPtr_StringToValue_Protected_Virtual_TValueType_String_0;
		}

		// Token: 0x020003C8 RID: 968
		private sealed class MethodInfoStoreGeneric_AddLabelDragger_Protected_Void_0
		{
			// Token: 0x040028CF RID: 10447
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TextValueField<TDraggerType>.NativeMethodInfoPtr_AddLabelDragger_Protected_Void_0, Il2CppClassPointerStore<TextValueField<TDraggerType>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDraggerType>.NativeClassPtr)) }))));
		}
	}
}

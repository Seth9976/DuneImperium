using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200006B RID: 107
	public class TextInputBaseField<TValueType> : BaseField<TValueType>
	{
		// Token: 0x060009D1 RID: 2513 RVA: 0x0003FE04 File Offset: 0x0003E004
		// Note: this type is marked as 'beforefieldinit'.
		static TextInputBaseField()
		{
			Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TextInputBaseField`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValueType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr);
			TextInputBaseField<TValueType>.NativeFieldInfoPtr_s_SelectionColorProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, "s_SelectionColorProperty");
			TextInputBaseField<TValueType>.NativeFieldInfoPtr_s_CursorColorProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, "s_CursorColorProperty");
			TextInputBaseField<TValueType>.NativeFieldInfoPtr_m_VisualInputTabIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, "m_VisualInputTabIndex");
			TextInputBaseField<TValueType>.NativeFieldInfoPtr_m_TextInputBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, "m_TextInputBase");
			TextInputBaseField<TValueType>.NativeFieldInfoPtr_m_UpdateTextFromValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, "m_UpdateTextFromValue");
			TextInputBaseField<TValueType>.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, "ussClassName");
			TextInputBaseField<TValueType>.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, "labelUssClassName");
			TextInputBaseField<TValueType>.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, "inputUssClassName");
			TextInputBaseField<TValueType>.NativeFieldInfoPtr_multilineContainerClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, "multilineContainerClassName");
			TextInputBaseField<TValueType>.NativeFieldInfoPtr_singleLineInputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, "singleLineInputUssClassName");
			TextInputBaseField<TValueType>.NativeFieldInfoPtr_multilineInputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, "multilineInputUssClassName");
			TextInputBaseField<TValueType>.NativeFieldInfoPtr_multilineInputWithScrollViewUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, "multilineInputWithScrollViewUssClassName");
			TextInputBaseField<TValueType>.NativeFieldInfoPtr_textInputUssName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, "textInputUssName");
			TextInputBaseField<TValueType>.NativeFieldInfoPtr_onIsReadOnlyChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, "onIsReadOnlyChanged");
			TextInputBaseField<TValueType>.NativeMethodInfoPtr_get_textInputBase_FamOrAssem_get_TextInputBase_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, 100664694);
			TextInputBaseField<TValueType>.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, 100664695);
			TextInputBaseField<TValueType>.NativeMethodInfoPtr_set_text_FamOrAssem_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, 100664696);
			TextInputBaseField<TValueType>.NativeMethodInfoPtr_add_onIsReadOnlyChanged_Protected_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, 100664697);
			TextInputBaseField<TValueType>.NativeMethodInfoPtr_remove_onIsReadOnlyChanged_Protected_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, 100664698);
			TextInputBaseField<TValueType>.NativeMethodInfoPtr_get_isReadOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, 100664699);
			TextInputBaseField<TValueType>.NativeMethodInfoPtr_set_isReadOnly_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, 100664700);
			TextInputBaseField<TValueType>.NativeMethodInfoPtr_set_isPasswordField_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, 100664701);
			TextInputBaseField<TValueType>.NativeMethodInfoPtr_set_autoCorrection_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, 100664702);
			TextInputBaseField<TValueType>.NativeMethodInfoPtr_set_hideMobileInput_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, 100664703);
			TextInputBaseField<TValueType>.NativeMethodInfoPtr_set_keyboardType_Public_set_Void_TouchScreenKeyboardType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, 100664704);
			TextInputBaseField<TValueType>.NativeMethodInfoPtr_get_textEdition_Public_get_ITextEdition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, 100664705);
			TextInputBaseField<TValueType>.NativeMethodInfoPtr_set_maxLength_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, 100664706);
			TextInputBaseField<TValueType>.NativeMethodInfoPtr_get_isDelayed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, 100664707);
			TextInputBaseField<TValueType>.NativeMethodInfoPtr_set_isDelayed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, 100664708);
			TextInputBaseField<TValueType>.NativeMethodInfoPtr_set_maskChar_Public_set_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, 100664709);
			TextInputBaseField<TValueType>.NativeMethodInfoPtr_get_canSwitchToMixedValue_FamAndAssem_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, 100664710);
			TextInputBaseField<TValueType>.NativeMethodInfoPtr_ValueToString_Protected_Abstract_Virtual_New_String_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, 100664711);
			TextInputBaseField<TValueType>.NativeMethodInfoPtr_StringToValue_Protected_Abstract_Virtual_New_TValueType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, 100664712);
			TextInputBaseField<TValueType>.NativeMethodInfoPtr__ctor_Protected_Void_String_Int32_Char_TextInputBase_TValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, 100664713);
			TextInputBaseField<TValueType>.NativeMethodInfoPtr_OnFieldCustomStyleResolved_Private_Void_CustomStyleResolvedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, 100664714);
			TextInputBaseField<TValueType>.NativeMethodInfoPtr_ExecuteDefaultActionAtTarget_Protected_Virtual_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, 100664715);
			TextInputBaseField<TValueType>.NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, 100664716);
			TextInputBaseField<TValueType>.NativeMethodInfoPtr_UpdateValueFromText_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, 100664717);
			TextInputBaseField<TValueType>.NativeMethodInfoPtr_UpdateTextFromValue_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, 100664718);
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x0004017C File Offset: 0x0003E37C
		public unsafe TextInputBaseField<TValueType>.TextInputBase textInputBase
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.NativeMethodInfoPtr_get_textInputBase_FamOrAssem_get_TextInputBase_TValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextInputBaseField<TValueType>.TextInputBase>(intPtr3) : null;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x000401BC File Offset: 0x0003E3BC
		// (set) Token: 0x060009D4 RID: 2516 RVA: 0x000401F4 File Offset: 0x0003E3F4
		public unsafe string text
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 298678, RefRangeEnd = 298681, XrefRangeStart = 298666, XrefRangeEnd = 298678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 298686, RefRangeEnd = 298689, XrefRangeStart = 298681, XrefRangeEnd = 298686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.NativeMethodInfoPtr_set_text_FamOrAssem_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00040238 File Offset: 0x0003E438
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 298694, RefRangeEnd = 298695, XrefRangeStart = 298689, XrefRangeEnd = 298694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_onIsReadOnlyChanged(Action<bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.NativeMethodInfoPtr_add_onIsReadOnlyChanged_Protected_add_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0004027C File Offset: 0x0003E47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298695, XrefRangeEnd = 298700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_onIsReadOnlyChanged(Action<bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.NativeMethodInfoPtr_remove_onIsReadOnlyChanged_Protected_rem_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x000402C0 File Offset: 0x0003E4C0
		// (set) Token: 0x060009D8 RID: 2520 RVA: 0x000402FC File Offset: 0x0003E4FC
		public unsafe bool isReadOnly
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 298725, RefRangeEnd = 298726, XrefRangeStart = 298700, XrefRangeEnd = 298725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.NativeMethodInfoPtr_get_isReadOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 298730, RefRangeEnd = 298731, XrefRangeStart = 298726, XrefRangeEnd = 298730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.NativeMethodInfoPtr_set_isReadOnly_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x0000594D File Offset: 0x00003B4D
		// (set) Token: 0x060009D9 RID: 2521 RVA: 0x0004033C File Offset: 0x0003E53C
		public unsafe bool isPasswordField
		{
			get
			{
				return this.m_TextInputBase.isPasswordField;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 298732, RefRangeEnd = 298734, XrefRangeStart = 298731, XrefRangeEnd = 298732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.NativeMethodInfoPtr_set_isPasswordField_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x0000595A File Offset: 0x00003B5A
		// (set) Token: 0x060009DA RID: 2522 RVA: 0x0004037C File Offset: 0x0003E57C
		public unsafe bool autoCorrection
		{
			get
			{
				return this.textEdition.autoCorrection;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298734, XrefRangeEnd = 298773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.NativeMethodInfoPtr_set_autoCorrection_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x00005967 File Offset: 0x00003B67
		// (set) Token: 0x060009DB RID: 2523 RVA: 0x000403BC File Offset: 0x0003E5BC
		public unsafe bool hideMobileInput
		{
			get
			{
				return this.textEdition.hideMobileInput;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298773, XrefRangeEnd = 298822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.NativeMethodInfoPtr_set_hideMobileInput_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x00005974 File Offset: 0x00003B74
		// (set) Token: 0x060009DC RID: 2524 RVA: 0x000403FC File Offset: 0x0003E5FC
		public unsafe TouchScreenKeyboardType keyboardType
		{
			get
			{
				return this.textEdition.keyboardType;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298822, XrefRangeEnd = 298857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.NativeMethodInfoPtr_set_keyboardType_Public_set_Void_TouchScreenKeyboardType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x0004043C File Offset: 0x0003E63C
		public unsafe ITextEdition textEdition
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 298864, RefRangeEnd = 298867, XrefRangeStart = 298857, XrefRangeEnd = 298864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.NativeMethodInfoPtr_get_textEdition_Public_get_ITextEdition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITextEdition>(intPtr3) : null;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x00005A66 File Offset: 0x00003C66
		// (set) Token: 0x060009DE RID: 2526 RVA: 0x0004047C File Offset: 0x0003E67C
		public unsafe int maxLength
		{
			get
			{
				return this.textEdition.maxLength;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298867, XrefRangeEnd = 298887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.NativeMethodInfoPtr_set_maxLength_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x000404BC File Offset: 0x0003E6BC
		// (set) Token: 0x060009E0 RID: 2528 RVA: 0x000404F8 File Offset: 0x0003E6F8
		public unsafe bool isDelayed
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 298911, RefRangeEnd = 298914, XrefRangeStart = 298887, XrefRangeEnd = 298911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.NativeMethodInfoPtr_get_isDelayed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 298952, RefRangeEnd = 298953, XrefRangeStart = 298914, XrefRangeEnd = 298952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.NativeMethodInfoPtr_set_isDelayed_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x00005AAB File Offset: 0x00003CAB
		// (set) Token: 0x060009E1 RID: 2529 RVA: 0x00040538 File Offset: 0x0003E738
		public unsafe char maskChar
		{
			get
			{
				return this.textEdition.maskChar;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298953, XrefRangeEnd = 298996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.NativeMethodInfoPtr_set_maskChar_Public_set_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x00040578 File Offset: 0x0003E778
		public unsafe override bool canSwitchToMixedValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298996, XrefRangeEnd = 298997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInputBaseField<TValueType>.NativeMethodInfoPtr_get_canSwitchToMixedValue_FamAndAssem_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x000405C0 File Offset: 0x0003E7C0
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInputBaseField<TValueType>.NativeMethodInfoPtr_ValueToString_Protected_Abstract_Virtual_New_String_TValueType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0004064C File Offset: 0x0003E84C
		[CallerCount(0)]
		public unsafe virtual TValueType StringToValue(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInputBaseField<TValueType>.NativeMethodInfoPtr_StringToValue_Protected_Abstract_Virtual_New_TValueType_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TValueType>(intPtr, false, true);
			}
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x000406A4 File Offset: 0x0003E8A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299023, RefRangeEnd = 299024, XrefRangeStart = 298997, XrefRangeEnd = 299023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextInputBaseField(string label, int maxLength, char maskChar, TextInputBaseField<TValueType>.TextInputBase textInputBase)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maskChar;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textInputBase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.NativeMethodInfoPtr__ctor_Protected_Void_String_Int32_Char_TextInputBase_TValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00040720 File Offset: 0x0003E920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299024, XrefRangeEnd = 299052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFieldCustomStyleResolved(CustomStyleResolvedEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.NativeMethodInfoPtr_OnFieldCustomStyleResolved_Private_Void_CustomStyleResolvedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00040764 File Offset: 0x0003E964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299052, XrefRangeEnd = 299070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ExecuteDefaultActionAtTarget(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInputBaseField<TValueType>.NativeMethodInfoPtr_ExecuteDefaultActionAtTarget_Protected_Virtual_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x000407B4 File Offset: 0x0003E9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299070, XrefRangeEnd = 299080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateMixedValueContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInputBaseField<TValueType>.NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x000407F0 File Offset: 0x0003E9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299080, XrefRangeEnd = 299088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateValueFromText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInputBaseField<TValueType>.NativeMethodInfoPtr_UpdateValueFromText_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x0004082C File Offset: 0x0003EA2C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateTextFromValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInputBaseField<TValueType>.NativeMethodInfoPtr_UpdateTextFromValue_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00005812 File Offset: 0x00003A12
		public TextInputBaseField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x00040868 File Offset: 0x0003EA68
		// (set) Token: 0x060009ED RID: 2541 RVA: 0x0000581B File Offset: 0x00003A1B
		public unsafe static CustomStyleProperty<Color> s_SelectionColorProperty
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CustomStyleProperty<Color>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TextInputBaseField<TValueType>.NativeFieldInfoPtr_s_SelectionColorProperty, intPtr);
				return new CustomStyleProperty<Color>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomStyleProperty<Color>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextInputBaseField<TValueType>.NativeFieldInfoPtr_s_SelectionColorProperty, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x000408A4 File Offset: 0x0003EAA4
		// (set) Token: 0x060009EF RID: 2543 RVA: 0x00005832 File Offset: 0x00003A32
		public unsafe static CustomStyleProperty<Color> s_CursorColorProperty
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CustomStyleProperty<Color>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TextInputBaseField<TValueType>.NativeFieldInfoPtr_s_CursorColorProperty, intPtr);
				return new CustomStyleProperty<Color>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomStyleProperty<Color>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextInputBaseField<TValueType>.NativeFieldInfoPtr_s_CursorColorProperty, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x000408E0 File Offset: 0x0003EAE0
		// (set) Token: 0x060009F1 RID: 2545 RVA: 0x00005849 File Offset: 0x00003A49
		public unsafe int m_VisualInputTabIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.NativeFieldInfoPtr_m_VisualInputTabIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.NativeFieldInfoPtr_m_VisualInputTabIndex)) = value;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x00040908 File Offset: 0x0003EB08
		// (set) Token: 0x060009F3 RID: 2547 RVA: 0x00005864 File Offset: 0x00003A64
		public unsafe TextInputBaseField<TValueType>.TextInputBase m_TextInputBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.NativeFieldInfoPtr_m_TextInputBase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextInputBaseField<TValueType>.TextInputBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.NativeFieldInfoPtr_m_TextInputBase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x00040938 File Offset: 0x0003EB38
		// (set) Token: 0x060009F5 RID: 2549 RVA: 0x00005883 File Offset: 0x00003A83
		public unsafe bool m_UpdateTextFromValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.NativeFieldInfoPtr_m_UpdateTextFromValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.NativeFieldInfoPtr_m_UpdateTextFromValue)) = value;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x00040960 File Offset: 0x0003EB60
		// (set) Token: 0x060009F7 RID: 2551 RVA: 0x0000589E File Offset: 0x00003A9E
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextInputBaseField<TValueType>.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextInputBaseField<TValueType>.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x00040980 File Offset: 0x0003EB80
		// (set) Token: 0x060009F9 RID: 2553 RVA: 0x000058B0 File Offset: 0x00003AB0
		public new unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextInputBaseField<TValueType>.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextInputBaseField<TValueType>.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x000409A0 File Offset: 0x0003EBA0
		// (set) Token: 0x060009FB RID: 2555 RVA: 0x000058C2 File Offset: 0x00003AC2
		public new unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextInputBaseField<TValueType>.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextInputBaseField<TValueType>.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x000409C0 File Offset: 0x0003EBC0
		// (set) Token: 0x060009FD RID: 2557 RVA: 0x000058D4 File Offset: 0x00003AD4
		public unsafe static string multilineContainerClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextInputBaseField<TValueType>.NativeFieldInfoPtr_multilineContainerClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextInputBaseField<TValueType>.NativeFieldInfoPtr_multilineContainerClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x000409E0 File Offset: 0x0003EBE0
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x000058E6 File Offset: 0x00003AE6
		public unsafe static string singleLineInputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextInputBaseField<TValueType>.NativeFieldInfoPtr_singleLineInputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextInputBaseField<TValueType>.NativeFieldInfoPtr_singleLineInputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x00040A00 File Offset: 0x0003EC00
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x000058F8 File Offset: 0x00003AF8
		public unsafe static string multilineInputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextInputBaseField<TValueType>.NativeFieldInfoPtr_multilineInputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextInputBaseField<TValueType>.NativeFieldInfoPtr_multilineInputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x00040A20 File Offset: 0x0003EC20
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x0000590A File Offset: 0x00003B0A
		public unsafe static string multilineInputWithScrollViewUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextInputBaseField<TValueType>.NativeFieldInfoPtr_multilineInputWithScrollViewUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextInputBaseField<TValueType>.NativeFieldInfoPtr_multilineInputWithScrollViewUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x00040A40 File Offset: 0x0003EC40
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x0000591C File Offset: 0x00003B1C
		public unsafe static string textInputUssName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextInputBaseField<TValueType>.NativeFieldInfoPtr_textInputUssName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextInputBaseField<TValueType>.NativeFieldInfoPtr_textInputUssName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x00040A60 File Offset: 0x0003EC60
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x0000592E File Offset: 0x00003B2E
		public unsafe Action<bool> onIsReadOnlyChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.NativeFieldInfoPtr_onIsReadOnlyChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.NativeFieldInfoPtr_onIsReadOnlyChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x00005981 File Offset: 0x00003B81
		public TouchScreenKeyboard touchScreenKeyboard
		{
			get
			{
				return this.textEdition.touchScreenKeyboard;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x0000598E File Offset: 0x00003B8E
		public ITextSelection textSelection
		{
			get
			{
				return this.m_TextInputBase.textElement.selection;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x000059A0 File Offset: 0x00003BA0
		public Color selectionColor
		{
			get
			{
				return this.textSelection.selectionColor;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x000059AD File Offset: 0x00003BAD
		public Color cursorColor
		{
			get
			{
				return this.textSelection.cursorColor;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x000059BA File Offset: 0x00003BBA
		// (set) Token: 0x06000A11 RID: 2577 RVA: 0x000059C7 File Offset: 0x00003BC7
		public int cursorIndex
		{
			get
			{
				return this.textSelection.cursorIndex;
			}
			set
			{
				this.textSelection.cursorIndex = value;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x000059D6 File Offset: 0x00003BD6
		public Vector2 cursorPosition
		{
			get
			{
				return this.textSelection.cursorPosition;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x000059E3 File Offset: 0x00003BE3
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x000059F0 File Offset: 0x00003BF0
		public int selectIndex
		{
			get
			{
				return this.textSelection.selectIndex;
			}
			set
			{
				this.textSelection.selectIndex = value;
			}
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x000059FF File Offset: 0x00003BFF
		public void SelectAll()
		{
			this.textSelection.SelectAll();
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00005A0E File Offset: 0x00003C0E
		public void SelectNone()
		{
			this.textSelection.SelectNone();
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00005A1D File Offset: 0x00003C1D
		public void SelectRange(int cursorIndex, int selectionIndex)
		{
			this.textSelection.SelectRange(cursorIndex, selectionIndex);
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x00005A2E File Offset: 0x00003C2E
		// (set) Token: 0x06000A19 RID: 2585 RVA: 0x00005A3B File Offset: 0x00003C3B
		public bool selectAllOnFocus
		{
			get
			{
				return this.textSelection.selectAllOnFocus;
			}
			set
			{
				this.textSelection.selectAllOnFocus = value;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x00005A4A File Offset: 0x00003C4A
		// (set) Token: 0x06000A1B RID: 2587 RVA: 0x00005A57 File Offset: 0x00003C57
		public bool selectAllOnMouseUp
		{
			get
			{
				return this.textSelection.selectAllOnMouseUp;
			}
			set
			{
				this.textSelection.selectAllOnMouseUp = value;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x00005A73 File Offset: 0x00003C73
		// (set) Token: 0x06000A1E RID: 2590 RVA: 0x00005A80 File Offset: 0x00003C80
		public bool doubleClickSelectsWord
		{
			get
			{
				return this.textSelection.doubleClickSelectsWord;
			}
			set
			{
				this.textSelection.doubleClickSelectsWord = value;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x00005A8F File Offset: 0x00003C8F
		// (set) Token: 0x06000A20 RID: 2592 RVA: 0x00005A9C File Offset: 0x00003C9C
		public bool tripleClickSelectsLine
		{
			get
			{
				return this.textSelection.tripleClickSelectsLine;
			}
			set
			{
				this.textSelection.tripleClickSelectsLine = value;
			}
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00040A90 File Offset: 0x0003EC90
		public bool SetVerticalScrollerVisibility(ScrollerVisibility sv)
		{
			return this.textInputBase.SetVerticalScrollerVisibility(sv);
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00040AB0 File Offset: 0x0003ECB0
		public Vector2 MeasureTextSize(string textToMeasure, float width, VisualElement.MeasureMode widthMode, float height, VisualElement.MeasureMode heightMode)
		{
			return TextUtilities.MeasureVisualElementTextSize(this.m_TextInputBase.textElement, textToMeasure, width, widthMode, height, heightMode);
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x00005AB8 File Offset: 0x00003CB8
		public bool hasFocus
		{
			get
			{
				return this.textInputBase.textElement.hasFocus;
			}
		}

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeFieldInfoPtr_s_SelectionColorProperty;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeFieldInfoPtr_s_CursorColorProperty;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeFieldInfoPtr_m_VisualInputTabIndex;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeFieldInfoPtr_m_TextInputBase;

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateTextFromValue;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeFieldInfoPtr_multilineContainerClassName;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeFieldInfoPtr_singleLineInputUssClassName;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeFieldInfoPtr_multilineInputUssClassName;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeFieldInfoPtr_multilineInputWithScrollViewUssClassName;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeFieldInfoPtr_textInputUssName;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeFieldInfoPtr_onIsReadOnlyChanged;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeMethodInfoPtr_get_textInputBase_FamOrAssem_get_TextInputBase_TValueType_0;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeMethodInfoPtr_set_text_FamOrAssem_set_Void_String_0;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeMethodInfoPtr_add_onIsReadOnlyChanged_Protected_add_Void_Action_1_Boolean_0;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeMethodInfoPtr_remove_onIsReadOnlyChanged_Protected_rem_Void_Action_1_Boolean_0;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeMethodInfoPtr_get_isReadOnly_Public_get_Boolean_0;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeMethodInfoPtr_set_isReadOnly_Public_set_Void_Boolean_0;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeMethodInfoPtr_set_isPasswordField_Public_set_Void_Boolean_0;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeMethodInfoPtr_set_autoCorrection_Public_set_Void_Boolean_0;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeMethodInfoPtr_set_hideMobileInput_Public_set_Void_Boolean_0;

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeMethodInfoPtr_set_keyboardType_Public_set_Void_TouchScreenKeyboardType_0;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeMethodInfoPtr_get_textEdition_Public_get_ITextEdition_0;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeMethodInfoPtr_set_maxLength_Public_set_Void_Int32_0;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeMethodInfoPtr_get_isDelayed_Public_get_Boolean_0;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeMethodInfoPtr_set_isDelayed_Public_set_Void_Boolean_0;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeMethodInfoPtr_set_maskChar_Public_set_Void_Char_0;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeMethodInfoPtr_get_canSwitchToMixedValue_FamAndAssem_Virtual_get_Boolean_0;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeMethodInfoPtr_ValueToString_Protected_Abstract_Virtual_New_String_TValueType_0;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeMethodInfoPtr_StringToValue_Protected_Abstract_Virtual_New_TValueType_String_0;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_Int32_Char_TextInputBase_TValueType_0;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeMethodInfoPtr_OnFieldCustomStyleResolved_Private_Void_CustomStyleResolvedEvent_0;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDefaultActionAtTarget_Protected_Virtual_Void_EventBase_0;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMixedValueContent_Protected_Virtual_Void_0;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValueFromText_Internal_Virtual_New_Void_0;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTextFromValue_Internal_Virtual_New_Void_0;

		// Token: 0x040006FC RID: 1788
		public const int kMaxLengthNone = -1;

		// Token: 0x040006FD RID: 1789
		public const char kMaskCharDefault = '*';

		// Token: 0x0200038A RID: 906
		public new class UxmlTraits : BaseFieldTraits<string, UxmlStringAttributeDescription>
		{
			// Token: 0x06003802 RID: 14338 RVA: 0x000E50EC File Offset: 0x000E32EC
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<TextInputBaseField<TValueType>.UxmlTraits>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, "UxmlTraits"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValueType>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextInputBaseField<TValueType>.UxmlTraits>.NativeClassPtr);
				TextInputBaseField<TValueType>.UxmlTraits.NativeFieldInfoPtr_m_MaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>.UxmlTraits>.NativeClassPtr, "m_MaxLength");
				TextInputBaseField<TValueType>.UxmlTraits.NativeFieldInfoPtr_m_Password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>.UxmlTraits>.NativeClassPtr, "m_Password");
				TextInputBaseField<TValueType>.UxmlTraits.NativeFieldInfoPtr_m_MaskCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>.UxmlTraits>.NativeClassPtr, "m_MaskCharacter");
				TextInputBaseField<TValueType>.UxmlTraits.NativeFieldInfoPtr_m_IsReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>.UxmlTraits>.NativeClassPtr, "m_IsReadOnly");
				TextInputBaseField<TValueType>.UxmlTraits.NativeFieldInfoPtr_m_IsDelayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>.UxmlTraits>.NativeClassPtr, "m_IsDelayed");
				TextInputBaseField<TValueType>.UxmlTraits.NativeFieldInfoPtr_m_HideMobileInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>.UxmlTraits>.NativeClassPtr, "m_HideMobileInput");
				TextInputBaseField<TValueType>.UxmlTraits.NativeFieldInfoPtr_m_KeyboardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>.UxmlTraits>.NativeClassPtr, "m_KeyboardType");
				TextInputBaseField<TValueType>.UxmlTraits.NativeFieldInfoPtr_m_AutoCorrection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>.UxmlTraits>.NativeClassPtr, "m_AutoCorrection");
				TextInputBaseField<TValueType>.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.UxmlTraits>.NativeClassPtr, 100664720);
				TextInputBaseField<TValueType>.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.UxmlTraits>.NativeClassPtr, 100664721);
			}

			// Token: 0x06003803 RID: 14339 RVA: 0x000E521C File Offset: 0x000E341C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 297034, RefRangeEnd = 297035, XrefRangeStart = 297001, XrefRangeEnd = 297034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInputBaseField<TValueType>.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003804 RID: 14340 RVA: 0x000E5294 File Offset: 0x000E3494
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 297120, RefRangeEnd = 297121, XrefRangeStart = 297035, XrefRangeEnd = 297120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextInputBaseField<TValueType>.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003805 RID: 14341 RVA: 0x000173E1 File Offset: 0x000155E1
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001141 RID: 4417
			// (get) Token: 0x06003806 RID: 14342 RVA: 0x000E52D0 File Offset: 0x000E34D0
			// (set) Token: 0x06003807 RID: 14343 RVA: 0x000173EA File Offset: 0x000155EA
			public unsafe UxmlIntAttributeDescription m_MaxLength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.UxmlTraits.NativeFieldInfoPtr_m_MaxLength);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlIntAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.UxmlTraits.NativeFieldInfoPtr_m_MaxLength), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001142 RID: 4418
			// (get) Token: 0x06003808 RID: 14344 RVA: 0x000E5300 File Offset: 0x000E3500
			// (set) Token: 0x06003809 RID: 14345 RVA: 0x00017409 File Offset: 0x00015609
			public unsafe UxmlBoolAttributeDescription m_Password
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.UxmlTraits.NativeFieldInfoPtr_m_Password);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.UxmlTraits.NativeFieldInfoPtr_m_Password), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001143 RID: 4419
			// (get) Token: 0x0600380A RID: 14346 RVA: 0x000E5330 File Offset: 0x000E3530
			// (set) Token: 0x0600380B RID: 14347 RVA: 0x00017428 File Offset: 0x00015628
			public unsafe UxmlStringAttributeDescription m_MaskCharacter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.UxmlTraits.NativeFieldInfoPtr_m_MaskCharacter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.UxmlTraits.NativeFieldInfoPtr_m_MaskCharacter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001144 RID: 4420
			// (get) Token: 0x0600380C RID: 14348 RVA: 0x000E5360 File Offset: 0x000E3560
			// (set) Token: 0x0600380D RID: 14349 RVA: 0x00017447 File Offset: 0x00015647
			public unsafe UxmlBoolAttributeDescription m_IsReadOnly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.UxmlTraits.NativeFieldInfoPtr_m_IsReadOnly);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.UxmlTraits.NativeFieldInfoPtr_m_IsReadOnly), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001145 RID: 4421
			// (get) Token: 0x0600380E RID: 14350 RVA: 0x000E5390 File Offset: 0x000E3590
			// (set) Token: 0x0600380F RID: 14351 RVA: 0x00017466 File Offset: 0x00015666
			public unsafe UxmlBoolAttributeDescription m_IsDelayed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.UxmlTraits.NativeFieldInfoPtr_m_IsDelayed);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.UxmlTraits.NativeFieldInfoPtr_m_IsDelayed), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001146 RID: 4422
			// (get) Token: 0x06003810 RID: 14352 RVA: 0x000E53C0 File Offset: 0x000E35C0
			// (set) Token: 0x06003811 RID: 14353 RVA: 0x00017485 File Offset: 0x00015685
			public unsafe UxmlBoolAttributeDescription m_HideMobileInput
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.UxmlTraits.NativeFieldInfoPtr_m_HideMobileInput);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.UxmlTraits.NativeFieldInfoPtr_m_HideMobileInput), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001147 RID: 4423
			// (get) Token: 0x06003812 RID: 14354 RVA: 0x000E53F0 File Offset: 0x000E35F0
			// (set) Token: 0x06003813 RID: 14355 RVA: 0x000174A4 File Offset: 0x000156A4
			public unsafe UxmlEnumAttributeDescription<TouchScreenKeyboardType> m_KeyboardType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.UxmlTraits.NativeFieldInfoPtr_m_KeyboardType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlEnumAttributeDescription<TouchScreenKeyboardType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.UxmlTraits.NativeFieldInfoPtr_m_KeyboardType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001148 RID: 4424
			// (get) Token: 0x06003814 RID: 14356 RVA: 0x000E5420 File Offset: 0x000E3620
			// (set) Token: 0x06003815 RID: 14357 RVA: 0x000174C3 File Offset: 0x000156C3
			public unsafe UxmlBoolAttributeDescription m_AutoCorrection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.UxmlTraits.NativeFieldInfoPtr_m_AutoCorrection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.UxmlTraits.NativeFieldInfoPtr_m_AutoCorrection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040027D3 RID: 10195
			private static readonly IntPtr NativeFieldInfoPtr_m_MaxLength;

			// Token: 0x040027D4 RID: 10196
			private static readonly IntPtr NativeFieldInfoPtr_m_Password;

			// Token: 0x040027D5 RID: 10197
			private static readonly IntPtr NativeFieldInfoPtr_m_MaskCharacter;

			// Token: 0x040027D6 RID: 10198
			private static readonly IntPtr NativeFieldInfoPtr_m_IsReadOnly;

			// Token: 0x040027D7 RID: 10199
			private static readonly IntPtr NativeFieldInfoPtr_m_IsDelayed;

			// Token: 0x040027D8 RID: 10200
			private static readonly IntPtr NativeFieldInfoPtr_m_HideMobileInput;

			// Token: 0x040027D9 RID: 10201
			private static readonly IntPtr NativeFieldInfoPtr_m_KeyboardType;

			// Token: 0x040027DA RID: 10202
			private static readonly IntPtr NativeFieldInfoPtr_m_AutoCorrection;

			// Token: 0x040027DB RID: 10203
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x040027DC RID: 10204
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200038B RID: 907
		public class TextInputBase : VisualElement
		{
			// Token: 0x06003816 RID: 14358 RVA: 0x000E5450 File Offset: 0x000E3650
			// Note: this type is marked as 'beforefieldinit'.
			static TextInputBase()
			{
				Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextInputBaseField<TValueType>>.NativeClassPtr, "TextInputBase"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValueType>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr);
				TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr__textElement_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, "<textElement>k__BackingField");
				TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_scrollView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, "scrollView");
				TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_multilineContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, "multilineContainer");
				TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_innerComponentsModifierName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, "innerComponentsModifierName");
				TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_innerTextElementUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, "innerTextElementUssClassName");
				TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_innerTextElementWithScrollViewUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, "innerTextElementWithScrollViewUssClassName");
				TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_horizontalVariantInnerTextElementUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, "horizontalVariantInnerTextElementUssClassName");
				TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_verticalVariantInnerTextElementUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, "verticalVariantInnerTextElementUssClassName");
				TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_verticalHorizontalVariantInnerTextElementUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, "verticalHorizontalVariantInnerTextElementUssClassName");
				TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_innerScrollviewUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, "innerScrollviewUssClassName");
				TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_innerViewportUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, "innerViewportUssClassName");
				TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_innerContentContainerUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, "innerContentContainerUssClassName");
				TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr__isDragging_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, "<isDragging>k__BackingField");
				TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_scrollOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, "scrollOffset");
				TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_m_ScrollViewWasClamped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, "m_ScrollViewWasClamped");
				TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_lastCursorPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, "lastCursorPos");
				TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_m_VerticalScrollerVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, "m_VerticalScrollerVisibility");
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_get_textElement_Internal_get_TextElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664722);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_set_textElement_Private_set_Void_TextElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664723);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_get_textSelection_Public_get_ITextSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664724);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_get_textEdition_Public_get_ITextEdition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664725);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_SelectAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664726);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_SelectNone_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664727);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_get_originalText_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664728);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_StringToValue_Protected_Virtual_New_TValueType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664729);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_UpdateValueFromText_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664730);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_UpdateTextFromValue_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664731);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_MoveFocusToCompositeRoot_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664732);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_get_isReadOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664733);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_set_maxLength_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664734);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_set_maskChar_Public_set_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664735);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_get_isPasswordField_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664736);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_set_isPasswordField_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664737);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_set_isDragging_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664738);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664739);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664740);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664741);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_MakeSureScrollViewDoesNotLeakEvents_Private_Void_ChangeEvent_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664742);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_SetSingleLine_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664743);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_SetMultiline_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664744);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_ScrollViewOnGeometryChangedEvent_Private_Void_GeometryChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664745);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_TextElementOnGeometryChangedEvent_Private_Void_GeometryChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664746);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_OnInputCustomStyleResolved_Internal_Void_CustomStyleResolvedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664747);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_AcceptCharacter_Internal_Virtual_New_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664748);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_UpdateScrollOffset_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664749);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_UpdateScrollOffset_Internal_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664750);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_GetScrollOffset_Private_Vector2_Single_Single_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664751);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_SetScrollViewMode_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664752);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_SetMultilineContainerStyle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664753);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_RemoveSingleLineComponents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664754);
				TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_RemoveMultilineComponents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr, 100664755);
			}

			// Token: 0x1700115A RID: 4442
			// (get) Token: 0x06003817 RID: 14359 RVA: 0x000E58B4 File Offset: 0x000E3AB4
			// (set) Token: 0x06003818 RID: 14360 RVA: 0x000E58F4 File Offset: 0x000E3AF4
			public unsafe TextElement textElement
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_get_textElement_Internal_get_TextElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextElement>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297121, XrefRangeEnd = 297122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_set_textElement_Private_set_Void_TextElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700115B RID: 4443
			// (get) Token: 0x06003819 RID: 14361 RVA: 0x000E5938 File Offset: 0x000E3B38
			public unsafe ITextSelection textSelection
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 297124, RefRangeEnd = 297130, XrefRangeStart = 297122, XrefRangeEnd = 297124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_get_textSelection_Public_get_ITextSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITextSelection>(intPtr3) : null;
				}
			}

			// Token: 0x1700115C RID: 4444
			// (get) Token: 0x0600381A RID: 14362 RVA: 0x000E5978 File Offset: 0x000E3B78
			public unsafe ITextEdition textEdition
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 297124, RefRangeEnd = 297130, XrefRangeStart = 297124, XrefRangeEnd = 297130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_get_textEdition_Public_get_ITextEdition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITextEdition>(intPtr3) : null;
				}
			}

			// Token: 0x0600381B RID: 14363 RVA: 0x000E59B8 File Offset: 0x000E3BB8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 297160, RefRangeEnd = 297162, XrefRangeStart = 297130, XrefRangeEnd = 297160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SelectAll()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_SelectAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600381C RID: 14364 RVA: 0x000E59EC File Offset: 0x000E3BEC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 297203, RefRangeEnd = 297205, XrefRangeStart = 297162, XrefRangeEnd = 297203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SelectNone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_SelectNone_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700115D RID: 4445
			// (get) Token: 0x0600381D RID: 14365 RVA: 0x000E5A20 File Offset: 0x000E3C20
			public unsafe string originalText
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 297205, RefRangeEnd = 297211, XrefRangeStart = 297205, XrefRangeEnd = 297205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_get_originalText_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600381E RID: 14366 RVA: 0x000E5A58 File Offset: 0x000E3C58
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 297223, RefRangeEnd = 297224, XrefRangeStart = 297211, XrefRangeEnd = 297223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual TValueType StringToValue(string str)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_StringToValue_Protected_Virtual_New_TValueType_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TValueType>(intPtr, false, true);
				}
			}

			// Token: 0x0600381F RID: 14367 RVA: 0x000E5AB0 File Offset: 0x000E3CB0
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 297999, RefRangeEnd = 298012, XrefRangeStart = 297224, XrefRangeEnd = 297999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UpdateValueFromText()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_UpdateValueFromText_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003820 RID: 14368 RVA: 0x000E5AE4 File Offset: 0x000E3CE4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 298016, RefRangeEnd = 298017, XrefRangeStart = 298012, XrefRangeEnd = 298016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UpdateTextFromValue()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_UpdateTextFromValue_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003821 RID: 14369 RVA: 0x000E5B18 File Offset: 0x000E3D18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298017, XrefRangeEnd = 298042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveFocusToCompositeRoot()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_MoveFocusToCompositeRoot_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700115E RID: 4446
			// (get) Token: 0x06003822 RID: 14370 RVA: 0x000E5B4C File Offset: 0x000E3D4C
			public unsafe bool isReadOnly
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298042, XrefRangeEnd = 298077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_get_isReadOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700115F RID: 4447
			// (set) Token: 0x06003823 RID: 14371 RVA: 0x000E5B88 File Offset: 0x000E3D88
			public unsafe int maxLength
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 298082, RefRangeEnd = 298083, XrefRangeStart = 298077, XrefRangeEnd = 298082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_set_maxLength_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001160 RID: 4448
			// (set) Token: 0x06003824 RID: 14372 RVA: 0x000E5BC8 File Offset: 0x000E3DC8
			public unsafe char maskChar
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 298138, RefRangeEnd = 298139, XrefRangeStart = 298083, XrefRangeEnd = 298138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_set_maskChar_Public_set_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001161 RID: 4449
			// (get) Token: 0x06003825 RID: 14373 RVA: 0x000E5C08 File Offset: 0x000E3E08
			// (set) Token: 0x06003826 RID: 14374 RVA: 0x000E5C50 File Offset: 0x000E3E50
			public unsafe virtual bool isPasswordField
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298139, XrefRangeEnd = 298149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_get_isPasswordField_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298149, XrefRangeEnd = 298189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_set_isPasswordField_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001162 RID: 4450
			// (set) Token: 0x06003827 RID: 14375 RVA: 0x000E5C9C File Offset: 0x000E3E9C
			public unsafe bool isDragging
			{
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_set_isDragging_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001163 RID: 4451
			// (get) Token: 0x06003828 RID: 14376 RVA: 0x000E5CDC File Offset: 0x000E3EDC
			// (set) Token: 0x06003829 RID: 14377 RVA: 0x000E5D14 File Offset: 0x000E3F14
			public unsafe string text
			{
				[CallerCount(13)]
				[CachedScanResults(RefRangeStart = 298190, RefRangeEnd = 298203, XrefRangeStart = 298189, XrefRangeEnd = 298190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 298204, RefRangeEnd = 298208, XrefRangeStart = 298203, XrefRangeEnd = 298204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x0600382A RID: 14378 RVA: 0x000E5D58 File Offset: 0x000E3F58
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 298321, RefRangeEnd = 298322, XrefRangeStart = 298208, XrefRangeEnd = 298321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TextInputBase()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextInputBaseField<TValueType>.TextInputBase>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600382B RID: 14379 RVA: 0x000E5D94 File Offset: 0x000E3F94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MakeSureScrollViewDoesNotLeakEvents(ChangeEvent<float> evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_MakeSureScrollViewDoesNotLeakEvents_Private_Void_ChangeEvent_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600382C RID: 14380 RVA: 0x000E5DD8 File Offset: 0x000E3FD8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 298343, RefRangeEnd = 298344, XrefRangeStart = 298322, XrefRangeEnd = 298343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetSingleLine()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_SetSingleLine_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600382D RID: 14381 RVA: 0x000E5E0C File Offset: 0x000E400C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298344, XrefRangeEnd = 298395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetMultiline()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_SetMultiline_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600382E RID: 14382 RVA: 0x000E5E40 File Offset: 0x000E4040
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298395, XrefRangeEnd = 298396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ScrollViewOnGeometryChangedEvent(GeometryChangedEvent e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_ScrollViewOnGeometryChangedEvent_Private_Void_GeometryChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600382F RID: 14383 RVA: 0x000E5E84 File Offset: 0x000E4084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298396, XrefRangeEnd = 298400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void TextElementOnGeometryChangedEvent(GeometryChangedEvent e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_TextElementOnGeometryChangedEvent_Private_Void_GeometryChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003830 RID: 14384 RVA: 0x000E5EC8 File Offset: 0x000E40C8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 298421, RefRangeEnd = 298422, XrefRangeStart = 298400, XrefRangeEnd = 298421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnInputCustomStyleResolved(CustomStyleResolvedEvent e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_OnInputCustomStyleResolved_Internal_Void_CustomStyleResolvedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003831 RID: 14385 RVA: 0x000E5F0C File Offset: 0x000E410C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 298426, RefRangeEnd = 298427, XrefRangeStart = 298422, XrefRangeEnd = 298426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool AcceptCharacter(char c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref c;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_AcceptCharacter_Internal_Virtual_New_Boolean_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003832 RID: 14386 RVA: 0x000E5F60 File Offset: 0x000E4160
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298427, XrefRangeEnd = 298429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UpdateScrollOffset(bool isBackspace = false)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref isBackspace;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_UpdateScrollOffset_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003833 RID: 14387 RVA: 0x000E5FA0 File Offset: 0x000E41A0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 298450, RefRangeEnd = 298454, XrefRangeStart = 298429, XrefRangeEnd = 298450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UpdateScrollOffset(bool isBackspace, bool widthChanged)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref isBackspace;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref widthChanged;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_UpdateScrollOffset_Internal_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003834 RID: 14388 RVA: 0x000E5FEC File Offset: 0x000E41EC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 298488, RefRangeEnd = 298489, XrefRangeStart = 298454, XrefRangeEnd = 298488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 GetScrollOffset(float xOffset, float yOffset, float contentViewportWidth, bool isBackspace, bool widthChanged)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref xOffset;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yOffset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contentViewportWidth;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBackspace;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref widthChanged;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_GetScrollOffset_Private_Vector2_Single_Single_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003835 RID: 14389 RVA: 0x000E6070 File Offset: 0x000E4270
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 298512, RefRangeEnd = 298514, XrefRangeStart = 298489, XrefRangeEnd = 298512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetScrollViewMode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_SetScrollViewMode_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003836 RID: 14390 RVA: 0x000E60A4 File Offset: 0x000E42A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298514, XrefRangeEnd = 298525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetMultilineContainerStyle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_SetMultilineContainerStyle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003837 RID: 14391 RVA: 0x000E60D8 File Offset: 0x000E42D8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 298611, RefRangeEnd = 298612, XrefRangeStart = 298525, XrefRangeEnd = 298611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RemoveSingleLineComponents()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_RemoveSingleLineComponents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003838 RID: 14392 RVA: 0x000E610C File Offset: 0x000E430C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 298664, RefRangeEnd = 298666, XrefRangeStart = 298612, XrefRangeEnd = 298664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RemoveMultilineComponents()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputBaseField<TValueType>.TextInputBase.NativeMethodInfoPtr_RemoveMultilineComponents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003839 RID: 14393 RVA: 0x000174E2 File Offset: 0x000156E2
			public TextInputBase(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001149 RID: 4425
			// (get) Token: 0x0600383A RID: 14394 RVA: 0x000E6140 File Offset: 0x000E4340
			// (set) Token: 0x0600383B RID: 14395 RVA: 0x000174EB File Offset: 0x000156EB
			public unsafe TextElement _textElement_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr__textElement_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr__textElement_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700114A RID: 4426
			// (get) Token: 0x0600383C RID: 14396 RVA: 0x000E6170 File Offset: 0x000E4370
			// (set) Token: 0x0600383D RID: 14397 RVA: 0x0001750A File Offset: 0x0001570A
			public unsafe ScrollView scrollView
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_scrollView);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_scrollView), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700114B RID: 4427
			// (get) Token: 0x0600383E RID: 14398 RVA: 0x000E61A0 File Offset: 0x000E43A0
			// (set) Token: 0x0600383F RID: 14399 RVA: 0x00017529 File Offset: 0x00015729
			public unsafe VisualElement multilineContainer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_multilineContainer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_multilineContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700114C RID: 4428
			// (get) Token: 0x06003840 RID: 14400 RVA: 0x000E61D0 File Offset: 0x000E43D0
			// (set) Token: 0x06003841 RID: 14401 RVA: 0x00017548 File Offset: 0x00015748
			public unsafe static string innerComponentsModifierName
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_innerComponentsModifierName, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_innerComponentsModifierName, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700114D RID: 4429
			// (get) Token: 0x06003842 RID: 14402 RVA: 0x000E61F0 File Offset: 0x000E43F0
			// (set) Token: 0x06003843 RID: 14403 RVA: 0x0001755A File Offset: 0x0001575A
			public unsafe static string innerTextElementUssClassName
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_innerTextElementUssClassName, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_innerTextElementUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700114E RID: 4430
			// (get) Token: 0x06003844 RID: 14404 RVA: 0x000E6210 File Offset: 0x000E4410
			// (set) Token: 0x06003845 RID: 14405 RVA: 0x0001756C File Offset: 0x0001576C
			public unsafe static string innerTextElementWithScrollViewUssClassName
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_innerTextElementWithScrollViewUssClassName, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_innerTextElementWithScrollViewUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700114F RID: 4431
			// (get) Token: 0x06003846 RID: 14406 RVA: 0x000E6230 File Offset: 0x000E4430
			// (set) Token: 0x06003847 RID: 14407 RVA: 0x0001757E File Offset: 0x0001577E
			public unsafe static string horizontalVariantInnerTextElementUssClassName
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_horizontalVariantInnerTextElementUssClassName, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_horizontalVariantInnerTextElementUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001150 RID: 4432
			// (get) Token: 0x06003848 RID: 14408 RVA: 0x000E6250 File Offset: 0x000E4450
			// (set) Token: 0x06003849 RID: 14409 RVA: 0x00017590 File Offset: 0x00015790
			public unsafe static string verticalVariantInnerTextElementUssClassName
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_verticalVariantInnerTextElementUssClassName, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_verticalVariantInnerTextElementUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001151 RID: 4433
			// (get) Token: 0x0600384A RID: 14410 RVA: 0x000E6270 File Offset: 0x000E4470
			// (set) Token: 0x0600384B RID: 14411 RVA: 0x000175A2 File Offset: 0x000157A2
			public unsafe static string verticalHorizontalVariantInnerTextElementUssClassName
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_verticalHorizontalVariantInnerTextElementUssClassName, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_verticalHorizontalVariantInnerTextElementUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001152 RID: 4434
			// (get) Token: 0x0600384C RID: 14412 RVA: 0x000E6290 File Offset: 0x000E4490
			// (set) Token: 0x0600384D RID: 14413 RVA: 0x000175B4 File Offset: 0x000157B4
			public unsafe static string innerScrollviewUssClassName
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_innerScrollviewUssClassName, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_innerScrollviewUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001153 RID: 4435
			// (get) Token: 0x0600384E RID: 14414 RVA: 0x000E62B0 File Offset: 0x000E44B0
			// (set) Token: 0x0600384F RID: 14415 RVA: 0x000175C6 File Offset: 0x000157C6
			public unsafe static string innerViewportUssClassName
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_innerViewportUssClassName, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_innerViewportUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001154 RID: 4436
			// (get) Token: 0x06003850 RID: 14416 RVA: 0x000E62D0 File Offset: 0x000E44D0
			// (set) Token: 0x06003851 RID: 14417 RVA: 0x000175D8 File Offset: 0x000157D8
			public unsafe static string innerContentContainerUssClassName
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_innerContentContainerUssClassName, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_innerContentContainerUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001155 RID: 4437
			// (get) Token: 0x06003852 RID: 14418 RVA: 0x000E62F0 File Offset: 0x000E44F0
			// (set) Token: 0x06003853 RID: 14419 RVA: 0x000175EA File Offset: 0x000157EA
			public unsafe bool _isDragging_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr__isDragging_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr__isDragging_k__BackingField)) = value;
				}
			}

			// Token: 0x17001156 RID: 4438
			// (get) Token: 0x06003854 RID: 14420 RVA: 0x000E6318 File Offset: 0x000E4518
			// (set) Token: 0x06003855 RID: 14421 RVA: 0x00017605 File Offset: 0x00015805
			public unsafe Vector2 scrollOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_scrollOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_scrollOffset)) = value;
				}
			}

			// Token: 0x17001157 RID: 4439
			// (get) Token: 0x06003856 RID: 14422 RVA: 0x000E6340 File Offset: 0x000E4540
			// (set) Token: 0x06003857 RID: 14423 RVA: 0x00017620 File Offset: 0x00015820
			public unsafe bool m_ScrollViewWasClamped
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_m_ScrollViewWasClamped);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_m_ScrollViewWasClamped)) = value;
				}
			}

			// Token: 0x17001158 RID: 4440
			// (get) Token: 0x06003858 RID: 14424 RVA: 0x000E6368 File Offset: 0x000E4568
			// (set) Token: 0x06003859 RID: 14425 RVA: 0x0001763B File Offset: 0x0001583B
			public unsafe Vector2 lastCursorPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_lastCursorPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_lastCursorPos)) = value;
				}
			}

			// Token: 0x17001159 RID: 4441
			// (get) Token: 0x0600385A RID: 14426 RVA: 0x000E6390 File Offset: 0x000E4590
			// (set) Token: 0x0600385B RID: 14427 RVA: 0x00017656 File Offset: 0x00015856
			public unsafe ScrollerVisibility m_VerticalScrollerVisibility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_m_VerticalScrollerVisibility);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputBaseField<TValueType>.TextInputBase.NativeFieldInfoPtr_m_VerticalScrollerVisibility)) = value;
				}
			}

			// Token: 0x040027DD RID: 10205
			private static readonly IntPtr NativeFieldInfoPtr__textElement_k__BackingField;

			// Token: 0x040027DE RID: 10206
			private static readonly IntPtr NativeFieldInfoPtr_scrollView;

			// Token: 0x040027DF RID: 10207
			private static readonly IntPtr NativeFieldInfoPtr_multilineContainer;

			// Token: 0x040027E0 RID: 10208
			private static readonly IntPtr NativeFieldInfoPtr_innerComponentsModifierName;

			// Token: 0x040027E1 RID: 10209
			private static readonly IntPtr NativeFieldInfoPtr_innerTextElementUssClassName;

			// Token: 0x040027E2 RID: 10210
			private static readonly IntPtr NativeFieldInfoPtr_innerTextElementWithScrollViewUssClassName;

			// Token: 0x040027E3 RID: 10211
			private static readonly IntPtr NativeFieldInfoPtr_horizontalVariantInnerTextElementUssClassName;

			// Token: 0x040027E4 RID: 10212
			private static readonly IntPtr NativeFieldInfoPtr_verticalVariantInnerTextElementUssClassName;

			// Token: 0x040027E5 RID: 10213
			private static readonly IntPtr NativeFieldInfoPtr_verticalHorizontalVariantInnerTextElementUssClassName;

			// Token: 0x040027E6 RID: 10214
			private static readonly IntPtr NativeFieldInfoPtr_innerScrollviewUssClassName;

			// Token: 0x040027E7 RID: 10215
			private static readonly IntPtr NativeFieldInfoPtr_innerViewportUssClassName;

			// Token: 0x040027E8 RID: 10216
			private static readonly IntPtr NativeFieldInfoPtr_innerContentContainerUssClassName;

			// Token: 0x040027E9 RID: 10217
			private static readonly IntPtr NativeFieldInfoPtr__isDragging_k__BackingField;

			// Token: 0x040027EA RID: 10218
			private static readonly IntPtr NativeFieldInfoPtr_scrollOffset;

			// Token: 0x040027EB RID: 10219
			private static readonly IntPtr NativeFieldInfoPtr_m_ScrollViewWasClamped;

			// Token: 0x040027EC RID: 10220
			private static readonly IntPtr NativeFieldInfoPtr_lastCursorPos;

			// Token: 0x040027ED RID: 10221
			private static readonly IntPtr NativeFieldInfoPtr_m_VerticalScrollerVisibility;

			// Token: 0x040027EE RID: 10222
			private static readonly IntPtr NativeMethodInfoPtr_get_textElement_Internal_get_TextElement_0;

			// Token: 0x040027EF RID: 10223
			private static readonly IntPtr NativeMethodInfoPtr_set_textElement_Private_set_Void_TextElement_0;

			// Token: 0x040027F0 RID: 10224
			private static readonly IntPtr NativeMethodInfoPtr_get_textSelection_Public_get_ITextSelection_0;

			// Token: 0x040027F1 RID: 10225
			private static readonly IntPtr NativeMethodInfoPtr_get_textEdition_Public_get_ITextEdition_0;

			// Token: 0x040027F2 RID: 10226
			private static readonly IntPtr NativeMethodInfoPtr_SelectAll_Public_Void_0;

			// Token: 0x040027F3 RID: 10227
			private static readonly IntPtr NativeMethodInfoPtr_SelectNone_Internal_Void_0;

			// Token: 0x040027F4 RID: 10228
			private static readonly IntPtr NativeMethodInfoPtr_get_originalText_Internal_get_String_0;

			// Token: 0x040027F5 RID: 10229
			private static readonly IntPtr NativeMethodInfoPtr_StringToValue_Protected_Virtual_New_TValueType_String_0;

			// Token: 0x040027F6 RID: 10230
			private static readonly IntPtr NativeMethodInfoPtr_UpdateValueFromText_Internal_Void_0;

			// Token: 0x040027F7 RID: 10231
			private static readonly IntPtr NativeMethodInfoPtr_UpdateTextFromValue_Internal_Void_0;

			// Token: 0x040027F8 RID: 10232
			private static readonly IntPtr NativeMethodInfoPtr_MoveFocusToCompositeRoot_Internal_Void_0;

			// Token: 0x040027F9 RID: 10233
			private static readonly IntPtr NativeMethodInfoPtr_get_isReadOnly_Public_get_Boolean_0;

			// Token: 0x040027FA RID: 10234
			private static readonly IntPtr NativeMethodInfoPtr_set_maxLength_Public_set_Void_Int32_0;

			// Token: 0x040027FB RID: 10235
			private static readonly IntPtr NativeMethodInfoPtr_set_maskChar_Public_set_Void_Char_0;

			// Token: 0x040027FC RID: 10236
			private static readonly IntPtr NativeMethodInfoPtr_get_isPasswordField_Public_Virtual_New_get_Boolean_0;

			// Token: 0x040027FD RID: 10237
			private static readonly IntPtr NativeMethodInfoPtr_set_isPasswordField_Public_Virtual_New_set_Void_Boolean_0;

			// Token: 0x040027FE RID: 10238
			private static readonly IntPtr NativeMethodInfoPtr_set_isDragging_Internal_set_Void_Boolean_0;

			// Token: 0x040027FF RID: 10239
			private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

			// Token: 0x04002800 RID: 10240
			private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

			// Token: 0x04002801 RID: 10241
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x04002802 RID: 10242
			private static readonly IntPtr NativeMethodInfoPtr_MakeSureScrollViewDoesNotLeakEvents_Private_Void_ChangeEvent_1_Single_0;

			// Token: 0x04002803 RID: 10243
			private static readonly IntPtr NativeMethodInfoPtr_SetSingleLine_Internal_Void_0;

			// Token: 0x04002804 RID: 10244
			private static readonly IntPtr NativeMethodInfoPtr_SetMultiline_Internal_Void_0;

			// Token: 0x04002805 RID: 10245
			private static readonly IntPtr NativeMethodInfoPtr_ScrollViewOnGeometryChangedEvent_Private_Void_GeometryChangedEvent_0;

			// Token: 0x04002806 RID: 10246
			private static readonly IntPtr NativeMethodInfoPtr_TextElementOnGeometryChangedEvent_Private_Void_GeometryChangedEvent_0;

			// Token: 0x04002807 RID: 10247
			private static readonly IntPtr NativeMethodInfoPtr_OnInputCustomStyleResolved_Internal_Void_CustomStyleResolvedEvent_0;

			// Token: 0x04002808 RID: 10248
			private static readonly IntPtr NativeMethodInfoPtr_AcceptCharacter_Internal_Virtual_New_Boolean_Char_0;

			// Token: 0x04002809 RID: 10249
			private static readonly IntPtr NativeMethodInfoPtr_UpdateScrollOffset_Internal_Void_Boolean_0;

			// Token: 0x0400280A RID: 10250
			private static readonly IntPtr NativeMethodInfoPtr_UpdateScrollOffset_Internal_Void_Boolean_Boolean_0;

			// Token: 0x0400280B RID: 10251
			private static readonly IntPtr NativeMethodInfoPtr_GetScrollOffset_Private_Vector2_Single_Single_Single_Boolean_Boolean_0;

			// Token: 0x0400280C RID: 10252
			private static readonly IntPtr NativeMethodInfoPtr_SetScrollViewMode_Internal_Void_0;

			// Token: 0x0400280D RID: 10253
			private static readonly IntPtr NativeMethodInfoPtr_SetMultilineContainerStyle_Private_Void_0;

			// Token: 0x0400280E RID: 10254
			private static readonly IntPtr NativeMethodInfoPtr_RemoveSingleLineComponents_Private_Void_0;

			// Token: 0x0400280F RID: 10255
			private static readonly IntPtr NativeMethodInfoPtr_RemoveMultilineComponents_Private_Void_0;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000082 RID: 130
	public class RadioButtonGroup : BaseField<int>
	{
		// Token: 0x06000CEC RID: 3308 RVA: 0x0004A8B4 File Offset: 0x00048AB4
		// Note: this type is marked as 'beforefieldinit'.
		static RadioButtonGroup()
		{
			Il2CppClassPointerStore<RadioButtonGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "RadioButtonGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RadioButtonGroup>.NativeClassPtr);
			RadioButtonGroup.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadioButtonGroup>.NativeClassPtr, "ussClassName");
			RadioButtonGroup.NativeFieldInfoPtr_containerUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadioButtonGroup>.NativeClassPtr, "containerUssClassName");
			RadioButtonGroup.NativeFieldInfoPtr_m_RadioButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadioButtonGroup>.NativeClassPtr, "m_RadioButtons");
			RadioButtonGroup.NativeFieldInfoPtr_m_RadioButtonValueChangedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadioButtonGroup>.NativeClassPtr, "m_RadioButtonValueChangedCallback");
			RadioButtonGroup.NativeFieldInfoPtr_m_RadioButtonContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadioButtonGroup>.NativeClassPtr, "m_RadioButtonContainer");
			RadioButtonGroup.NativeMethodInfoPtr_set_choices_Public_set_Void_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadioButtonGroup>.NativeClassPtr, 100665154);
			RadioButtonGroup.NativeMethodInfoPtr_get_contentContainer_Public_Virtual_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadioButtonGroup>.NativeClassPtr, 100665155);
			RadioButtonGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadioButtonGroup>.NativeClassPtr, 100665156);
			RadioButtonGroup.NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadioButtonGroup>.NativeClassPtr, 100665157);
			RadioButtonGroup.NativeMethodInfoPtr_RadioButtonValueChangedCallback_Private_Void_ChangeEvent_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadioButtonGroup>.NativeClassPtr, 100665158);
			RadioButtonGroup.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadioButtonGroup>.NativeClassPtr, 100665159);
			RadioButtonGroup.NativeMethodInfoPtr_UpdateRadioButtons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadioButtonGroup>.NativeClassPtr, 100665160);
			RadioButtonGroup.NativeMethodInfoPtr_UnityEngine_UIElements_IGroupBox_OnOptionAdded_Private_Virtual_Final_New_Void_IGroupBoxOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadioButtonGroup>.NativeClassPtr, 100665161);
			RadioButtonGroup.NativeMethodInfoPtr_UnityEngine_UIElements_IGroupBox_OnOptionRemoved_Private_Virtual_Final_New_Void_IGroupBoxOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadioButtonGroup>.NativeClassPtr, 100665162);
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000D01 RID: 3329 RVA: 0x00006D71 File Offset: 0x00004F71
		// (set) Token: 0x06000CED RID: 3309 RVA: 0x0004A9FC File Offset: 0x00048BFC
		public unsafe IEnumerable<string> choices
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 303256, RefRangeEnd = 303258, XrefRangeStart = 303206, XrefRangeEnd = 303256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RadioButtonGroup.NativeMethodInfoPtr_set_choices_Public_set_Void_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x0004AA40 File Offset: 0x00048C40
		public unsafe override VisualElement contentContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RadioButtonGroup.NativeMethodInfoPtr_get_contentContainer_Public_Virtual_get_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x0004AA8C File Offset: 0x00048C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303258, XrefRangeEnd = 303259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RadioButtonGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RadioButtonGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RadioButtonGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x0004AAC8 File Offset: 0x00048CC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 303302, RefRangeEnd = 303303, XrefRangeStart = 303259, XrefRangeEnd = 303302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RadioButtonGroup(string label, List<string> radioButtonChoices = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RadioButtonGroup>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(radioButtonChoices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RadioButtonGroup.NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x0004AB28 File Offset: 0x00048D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303303, XrefRangeEnd = 303313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RadioButtonValueChangedCallback(ChangeEvent<bool> evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RadioButtonGroup.NativeMethodInfoPtr_RadioButtonValueChangedCallback_Private_Void_ChangeEvent_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x0004AB6C File Offset: 0x00048D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303313, XrefRangeEnd = 303317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValueWithoutNotify(int newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RadioButtonGroup.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x0004ABB8 File Offset: 0x00048DB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 303337, RefRangeEnd = 303339, XrefRangeStart = 303317, XrefRangeEnd = 303337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRadioButtons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RadioButtonGroup.NativeMethodInfoPtr_UpdateRadioButtons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x0004ABEC File Offset: 0x00048DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303339, XrefRangeEnd = 303355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_UIElements_IGroupBox_OnOptionAdded(IGroupBoxOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RadioButtonGroup.NativeMethodInfoPtr_UnityEngine_UIElements_IGroupBox_OnOptionAdded_Private_Virtual_Final_New_Void_IGroupBoxOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x0004AC30 File Offset: 0x00048E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303355, XrefRangeEnd = 303367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_UIElements_IGroupBox_OnOptionRemoved(IGroupBoxOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RadioButtonGroup.NativeMethodInfoPtr_UnityEngine_UIElements_IGroupBox_OnOptionRemoved_Private_Virtual_Final_New_Void_IGroupBoxOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00006CE7 File Offset: 0x00004EE7
		public RadioButtonGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x0004AC74 File Offset: 0x00048E74
		// (set) Token: 0x06000CF8 RID: 3320 RVA: 0x00006CF0 File Offset: 0x00004EF0
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RadioButtonGroup.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RadioButtonGroup.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x0004AC94 File Offset: 0x00048E94
		// (set) Token: 0x06000CFA RID: 3322 RVA: 0x00006D02 File Offset: 0x00004F02
		public unsafe static string containerUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RadioButtonGroup.NativeFieldInfoPtr_containerUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RadioButtonGroup.NativeFieldInfoPtr_containerUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x0004ACB4 File Offset: 0x00048EB4
		// (set) Token: 0x06000CFC RID: 3324 RVA: 0x00006D14 File Offset: 0x00004F14
		public unsafe List<RadioButton> m_RadioButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RadioButtonGroup.NativeFieldInfoPtr_m_RadioButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RadioButton>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RadioButtonGroup.NativeFieldInfoPtr_m_RadioButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x0004ACE4 File Offset: 0x00048EE4
		// (set) Token: 0x06000CFE RID: 3326 RVA: 0x00006D33 File Offset: 0x00004F33
		public unsafe EventCallback<ChangeEvent<bool>> m_RadioButtonValueChangedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RadioButtonGroup.NativeFieldInfoPtr_m_RadioButtonValueChangedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCallback<ChangeEvent<bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RadioButtonGroup.NativeFieldInfoPtr_m_RadioButtonValueChangedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000CFF RID: 3327 RVA: 0x0004AD14 File Offset: 0x00048F14
		// (set) Token: 0x06000D00 RID: 3328 RVA: 0x00006D52 File Offset: 0x00004F52
		public unsafe VisualElement m_RadioButtonContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RadioButtonGroup.NativeFieldInfoPtr_m_RadioButtonContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RadioButtonGroup.NativeFieldInfoPtr_m_RadioButtonContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008F4 RID: 2292
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x040008F5 RID: 2293
		private static readonly IntPtr NativeFieldInfoPtr_containerUssClassName;

		// Token: 0x040008F6 RID: 2294
		private static readonly IntPtr NativeFieldInfoPtr_m_RadioButtons;

		// Token: 0x040008F7 RID: 2295
		private static readonly IntPtr NativeFieldInfoPtr_m_RadioButtonValueChangedCallback;

		// Token: 0x040008F8 RID: 2296
		private static readonly IntPtr NativeFieldInfoPtr_m_RadioButtonContainer;

		// Token: 0x040008F9 RID: 2297
		private static readonly IntPtr NativeMethodInfoPtr_set_choices_Public_set_Void_IEnumerable_1_String_0;

		// Token: 0x040008FA RID: 2298
		private static readonly IntPtr NativeMethodInfoPtr_get_contentContainer_Public_Virtual_get_VisualElement_0;

		// Token: 0x040008FB RID: 2299
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040008FC RID: 2300
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_0;

		// Token: 0x040008FD RID: 2301
		private static readonly IntPtr NativeMethodInfoPtr_RadioButtonValueChangedCallback_Private_Void_ChangeEvent_1_Boolean_0;

		// Token: 0x040008FE RID: 2302
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_Int32_0;

		// Token: 0x040008FF RID: 2303
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRadioButtons_Private_Void_0;

		// Token: 0x04000900 RID: 2304
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IGroupBox_OnOptionAdded_Private_Virtual_Final_New_Void_IGroupBoxOption_0;

		// Token: 0x04000901 RID: 2305
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IGroupBox_OnOptionRemoved_Private_Virtual_Final_New_Void_IGroupBoxOption_0;

		// Token: 0x020003B6 RID: 950
		public new class UxmlFactory : UxmlFactory<RadioButtonGroup, RadioButtonGroup.UxmlTraits>
		{
			// Token: 0x06003938 RID: 14648 RVA: 0x00017FE1 File Offset: 0x000161E1
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<RadioButtonGroup.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RadioButtonGroup>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RadioButtonGroup.UxmlFactory>.NativeClassPtr);
				RadioButtonGroup.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadioButtonGroup.UxmlFactory>.NativeClassPtr, 100665164);
			}

			// Token: 0x06003939 RID: 14649 RVA: 0x000E8B64 File Offset: 0x000E6D64
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 303182, RefRangeEnd = 303183, XrefRangeStart = 303179, XrefRangeEnd = 303182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RadioButtonGroup.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RadioButtonGroup.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600393A RID: 14650 RVA: 0x00018015 File Offset: 0x00016215
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002883 RID: 10371
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003B7 RID: 951
		public new class UxmlTraits : BaseFieldTraits<int, UxmlIntAttributeDescription>
		{
			// Token: 0x0600393B RID: 14651 RVA: 0x000E8BA0 File Offset: 0x000E6DA0
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<RadioButtonGroup.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RadioButtonGroup>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RadioButtonGroup.UxmlTraits>.NativeClassPtr);
				RadioButtonGroup.UxmlTraits.NativeFieldInfoPtr_m_Choices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadioButtonGroup.UxmlTraits>.NativeClassPtr, "m_Choices");
				RadioButtonGroup.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadioButtonGroup.UxmlTraits>.NativeClassPtr, 100665165);
				RadioButtonGroup.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadioButtonGroup.UxmlTraits>.NativeClassPtr, 100665166);
			}

			// Token: 0x0600393C RID: 14652 RVA: 0x000E8C08 File Offset: 0x000E6E08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303183, XrefRangeEnd = 303194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RadioButtonGroup.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600393D RID: 14653 RVA: 0x000E8C80 File Offset: 0x000E6E80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303194, XrefRangeEnd = 303206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RadioButtonGroup.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RadioButtonGroup.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600393E RID: 14654 RVA: 0x0001801E File Offset: 0x0001621E
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001195 RID: 4501
			// (get) Token: 0x0600393F RID: 14655 RVA: 0x000E8CBC File Offset: 0x000E6EBC
			// (set) Token: 0x06003940 RID: 14656 RVA: 0x00018027 File Offset: 0x00016227
			public unsafe UxmlStringAttributeDescription m_Choices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RadioButtonGroup.UxmlTraits.NativeFieldInfoPtr_m_Choices);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RadioButtonGroup.UxmlTraits.NativeFieldInfoPtr_m_Choices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002884 RID: 10372
			private static readonly IntPtr NativeFieldInfoPtr_m_Choices;

			// Token: 0x04002885 RID: 10373
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x04002886 RID: 10374
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003B8 RID: 952
		public sealed class <get_choices>d__7
		{
		}
	}
}

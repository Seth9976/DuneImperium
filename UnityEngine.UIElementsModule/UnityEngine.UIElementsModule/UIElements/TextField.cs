using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200006A RID: 106
	public class TextField : TextInputBaseField<string>
	{
		// Token: 0x060009BB RID: 2491 RVA: 0x0003F834 File Offset: 0x0003DA34
		// Note: this type is marked as 'beforefieldinit'.
		static TextField()
		{
			Il2CppClassPointerStore<TextField>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TextField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextField>.NativeClassPtr);
			TextField.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextField>.NativeClassPtr, "ussClassName");
			TextField.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextField>.NativeClassPtr, "labelUssClassName");
			TextField.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextField>.NativeClassPtr, "inputUssClassName");
			TextField.NativeMethodInfoPtr_get_textInput_Private_get_TextInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextField>.NativeClassPtr, 100664672);
			TextField.NativeMethodInfoPtr_set_multiline_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextField>.NativeClassPtr, 100664673);
			TextField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextField>.NativeClassPtr, 100664674);
			TextField.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextField>.NativeClassPtr, 100664675);
			TextField.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Boolean_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextField>.NativeClassPtr, 100664676);
			TextField.NativeMethodInfoPtr_get_value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextField>.NativeClassPtr, 100664677);
			TextField.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextField>.NativeClassPtr, 100664678);
			TextField.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextField>.NativeClassPtr, 100664679);
			TextField.NativeMethodInfoPtr_UpdateTextFromValue_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextField>.NativeClassPtr, 100664680);
			TextField.NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextField>.NativeClassPtr, 100664681);
			TextField.NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextField>.NativeClassPtr, 100664682);
			TextField.NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextField>.NativeClassPtr, 100664683);
			TextField.NativeMethodInfoPtr_StringToValue_Protected_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextField>.NativeClassPtr, 100664684);
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x0003F9A4 File Offset: 0x0003DBA4
		public unsafe TextField.TextInput textInput
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 296871, RefRangeEnd = 296875, XrefRangeStart = 296868, XrefRangeEnd = 296871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextField.NativeMethodInfoPtr_get_textInput_Private_get_TextInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextField.TextInput>(intPtr3) : null;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x0003FDE4 File Offset: 0x0003DFE4
		// (set) Token: 0x060009BD RID: 2493 RVA: 0x0003F9E4 File Offset: 0x0003DBE4
		public unsafe bool multiline
		{
			get
			{
				return this.textInput.multiline;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296875, XrefRangeEnd = 296878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextField.NativeMethodInfoPtr_set_multiline_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0003FA24 File Offset: 0x0003DC24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296878, XrefRangeEnd = 296879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x0003FA60 File Offset: 0x0003DC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296879, XrefRangeEnd = 296880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextField(string label)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextField>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextField.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x0003FAAC File Offset: 0x0003DCAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 296917, RefRangeEnd = 296919, XrefRangeStart = 296880, XrefRangeEnd = 296917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextField(string label, int maxLength, bool multiline, bool isPasswordField, char maskChar)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextField>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiline;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPasswordField;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maskChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextField.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Boolean_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x0003FB30 File Offset: 0x0003DD30
		// (set) Token: 0x060009C2 RID: 2498 RVA: 0x0003FB74 File Offset: 0x0003DD74
		public unsafe override string value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296919, XrefRangeEnd = 296922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextField.NativeMethodInfoPtr_get_value_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296922, XrefRangeEnd = 296935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextField.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x0003FBC4 File Offset: 0x0003DDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296935, XrefRangeEnd = 296947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValueWithoutNotify(string newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextField.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x0003FC14 File Offset: 0x0003DE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296947, XrefRangeEnd = 296971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateTextFromValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextField.NativeMethodInfoPtr_UpdateTextFromValue_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x0003FC50 File Offset: 0x0003DE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296971, XrefRangeEnd = 296990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ExecuteDefaultAction(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextField.NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x0003FCA0 File Offset: 0x0003DEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296990, XrefRangeEnd = 297001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnViewDataReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextField.NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x0003FCDC File Offset: 0x0003DEDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ValueToString(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextField.NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0003FD30 File Offset: 0x0003DF30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string StringToValue(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextField.NativeMethodInfoPtr_StringToValue_Protected_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x000057D3 File Offset: 0x000039D3
		public TextField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x0003FD84 File Offset: 0x0003DF84
		// (set) Token: 0x060009CB RID: 2507 RVA: 0x000057DC File Offset: 0x000039DC
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextField.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextField.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x0003FDA4 File Offset: 0x0003DFA4
		// (set) Token: 0x060009CD RID: 2509 RVA: 0x000057EE File Offset: 0x000039EE
		public new unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextField.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextField.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x0003FDC4 File Offset: 0x0003DFC4
		// (set) Token: 0x060009CF RID: 2511 RVA: 0x00005800 File Offset: 0x00003A00
		public new unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextField.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextField.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeMethodInfoPtr_get_textInput_Private_get_TextInput_0;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeMethodInfoPtr_set_multiline_Public_set_Void_Boolean_0;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Boolean_Boolean_Char_0;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_get_String_0;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_String_0;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_String_0;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTextFromValue_Internal_Virtual_Void_0;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_Void_EventBase_0;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeMethodInfoPtr_OnViewDataReady_Internal_Virtual_Void_0;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_String_0;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeMethodInfoPtr_StringToValue_Protected_Virtual_String_String_0;

		// Token: 0x02000387 RID: 903
		public new class UxmlFactory : UxmlFactory<TextField, TextField.UxmlTraits>
		{
			// Token: 0x060037F1 RID: 14321 RVA: 0x00017361 File Offset: 0x00015561
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<TextField.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextField>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextField.UxmlFactory>.NativeClassPtr);
				TextField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextField.UxmlFactory>.NativeClassPtr, 100664686);
			}

			// Token: 0x060037F2 RID: 14322 RVA: 0x000E4D90 File Offset: 0x000E2F90
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 296801, RefRangeEnd = 296802, XrefRangeStart = 296798, XrefRangeEnd = 296801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextField.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037F3 RID: 14323 RVA: 0x00017395 File Offset: 0x00015595
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040027CA RID: 10186
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000388 RID: 904
		public new class UxmlTraits : TextInputBaseField<string>.UxmlTraits
		{
			// Token: 0x060037F4 RID: 14324 RVA: 0x000E4DCC File Offset: 0x000E2FCC
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<TextField.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextField>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextField.UxmlTraits>.NativeClassPtr);
				TextField.UxmlTraits.NativeFieldInfoPtr_k_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextField.UxmlTraits>.NativeClassPtr, "k_Value");
				TextField.UxmlTraits.NativeFieldInfoPtr_m_Multiline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextField.UxmlTraits>.NativeClassPtr, "m_Multiline");
				TextField.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextField.UxmlTraits>.NativeClassPtr, 100664687);
				TextField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextField.UxmlTraits>.NativeClassPtr, 100664688);
			}

			// Token: 0x060037F5 RID: 14325 RVA: 0x000E4E48 File Offset: 0x000E3048
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296802, XrefRangeEnd = 296817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextField.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037F6 RID: 14326 RVA: 0x000E4EC0 File Offset: 0x000E30C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296817, XrefRangeEnd = 296829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextField.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037F7 RID: 14327 RVA: 0x0001739E File Offset: 0x0001559E
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700113D RID: 4413
			// (get) Token: 0x060037F8 RID: 14328 RVA: 0x000E4EFC File Offset: 0x000E30FC
			// (set) Token: 0x060037F9 RID: 14329 RVA: 0x000173A7 File Offset: 0x000155A7
			public unsafe static UxmlStringAttributeDescription k_Value
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextField.UxmlTraits.NativeFieldInfoPtr_k_Value, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextField.UxmlTraits.NativeFieldInfoPtr_k_Value, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700113E RID: 4414
			// (get) Token: 0x060037FA RID: 14330 RVA: 0x000E4F24 File Offset: 0x000E3124
			// (set) Token: 0x060037FB RID: 14331 RVA: 0x000173B9 File Offset: 0x000155B9
			public unsafe UxmlBoolAttributeDescription m_Multiline
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextField.UxmlTraits.NativeFieldInfoPtr_m_Multiline);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextField.UxmlTraits.NativeFieldInfoPtr_m_Multiline), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040027CB RID: 10187
			private static readonly IntPtr NativeFieldInfoPtr_k_Value;

			// Token: 0x040027CC RID: 10188
			private static readonly IntPtr NativeFieldInfoPtr_m_Multiline;

			// Token: 0x040027CD RID: 10189
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x040027CE RID: 10190
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000389 RID: 905
		public class TextInput : TextInputBaseField<string>.TextInputBase
		{
			// Token: 0x060037FC RID: 14332 RVA: 0x000E4F54 File Offset: 0x000E3154
			// Note: this type is marked as 'beforefieldinit'.
			static TextInput()
			{
				Il2CppClassPointerStore<TextField.TextInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextField>.NativeClassPtr, "TextInput");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextField.TextInput>.NativeClassPtr);
				TextField.TextInput.NativeMethodInfoPtr_set_multiline_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextField.TextInput>.NativeClassPtr, 100664690);
				TextField.TextInput.NativeMethodInfoPtr_set_isPasswordField_Public_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextField.TextInput>.NativeClassPtr, 100664691);
				TextField.TextInput.NativeMethodInfoPtr_StringToValue_Protected_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextField.TextInput>.NativeClassPtr, 100664692);
				TextField.TextInput.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextField.TextInput>.NativeClassPtr, 100664693);
			}

			// Token: 0x1700113F RID: 4415
			// (set) Token: 0x060037FD RID: 14333 RVA: 0x000E4FD0 File Offset: 0x000E31D0
			public unsafe bool multiline
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 296854, RefRangeEnd = 296858, XrefRangeStart = 296829, XrefRangeEnd = 296854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextField.TextInput.NativeMethodInfoPtr_set_multiline_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001140 RID: 4416
			// (set) Token: 0x060037FE RID: 14334 RVA: 0x000E5010 File Offset: 0x000E3210
			public unsafe override bool isPasswordField
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296858, XrefRangeEnd = 296862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextField.TextInput.NativeMethodInfoPtr_set_isPasswordField_Public_Virtual_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060037FF RID: 14335 RVA: 0x000E505C File Offset: 0x000E325C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string StringToValue(string str)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextField.TextInput.NativeMethodInfoPtr_StringToValue_Protected_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06003800 RID: 14336 RVA: 0x000E50B0 File Offset: 0x000E32B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296862, XrefRangeEnd = 296868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TextInput()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextField.TextInput>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextField.TextInput.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003801 RID: 14337 RVA: 0x000173D8 File Offset: 0x000155D8
			public TextInput(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040027CF RID: 10191
			private static readonly IntPtr NativeMethodInfoPtr_set_multiline_Public_set_Void_Boolean_0;

			// Token: 0x040027D0 RID: 10192
			private static readonly IntPtr NativeMethodInfoPtr_set_isPasswordField_Public_Virtual_set_Void_Boolean_0;

			// Token: 0x040027D1 RID: 10193
			private static readonly IntPtr NativeMethodInfoPtr_StringToValue_Protected_Virtual_String_String_0;

			// Token: 0x040027D2 RID: 10194
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

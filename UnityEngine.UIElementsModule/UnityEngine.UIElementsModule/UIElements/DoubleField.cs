using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000056 RID: 86
	public class DoubleField : TextValueField<double>
	{
		// Token: 0x060007E4 RID: 2020 RVA: 0x00039364 File Offset: 0x00037564
		// Note: this type is marked as 'beforefieldinit'.
		static DoubleField()
		{
			Il2CppClassPointerStore<DoubleField>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "DoubleField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleField>.NativeClassPtr);
			DoubleField.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleField>.NativeClassPtr, "ussClassName");
			DoubleField.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleField>.NativeClassPtr, "labelUssClassName");
			DoubleField.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleField>.NativeClassPtr, "inputUssClassName");
			DoubleField.NativeMethodInfoPtr_get_doubleInput_Private_get_DoubleInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleField>.NativeClassPtr, 100664436);
			DoubleField.NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleField>.NativeClassPtr, 100664437);
			DoubleField.NativeMethodInfoPtr_StringToValue_Protected_Virtual_Double_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleField>.NativeClassPtr, 100664438);
			DoubleField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleField>.NativeClassPtr, 100664439);
			DoubleField.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleField>.NativeClassPtr, 100664440);
			DoubleField.NativeMethodInfoPtr_CanTryParse_Internal_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleField>.NativeClassPtr, 100664441);
			DoubleField.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleField>.NativeClassPtr, 100664442);
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x0003945C File Offset: 0x0003765C
		public unsafe DoubleField.DoubleInput doubleInput
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293623, XrefRangeEnd = 293626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleField.NativeMethodInfoPtr_get_doubleInput_Private_get_DoubleInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DoubleField.DoubleInput>(intPtr3) : null;
			}
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x0003949C File Offset: 0x0003769C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293626, XrefRangeEnd = 293634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ValueToString(double v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoubleField.NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x000394EC File Offset: 0x000376EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293634, XrefRangeEnd = 293643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override double StringToValue(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoubleField.NativeMethodInfoPtr_StringToValue_Protected_Virtual_Double_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00039544 File Offset: 0x00037744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293643, XrefRangeEnd = 293675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoubleField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00039580 File Offset: 0x00037780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293675, XrefRangeEnd = 293707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoubleField(string label, int maxLength = 1000)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleField>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleField.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x000395DC File Offset: 0x000377DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293707, XrefRangeEnd = 293708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanTryParse(string textString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(textString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoubleField.NativeMethodInfoPtr_CanTryParse_Internal_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00039634 File Offset: 0x00037834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293708, XrefRangeEnd = 293711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, double startValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delta;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoubleField.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00004BBF File Offset: 0x00002DBF
		public DoubleField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x0003969C File Offset: 0x0003789C
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x00004BC8 File Offset: 0x00002DC8
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DoubleField.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DoubleField.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x000396BC File Offset: 0x000378BC
		// (set) Token: 0x060007F0 RID: 2032 RVA: 0x00004BDA File Offset: 0x00002DDA
		public new unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DoubleField.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DoubleField.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x000396DC File Offset: 0x000378DC
		// (set) Token: 0x060007F2 RID: 2034 RVA: 0x00004BEC File Offset: 0x00002DEC
		public new unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DoubleField.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DoubleField.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeMethodInfoPtr_get_doubleInput_Private_get_DoubleInput_0;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_Double_0;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeMethodInfoPtr_StringToValue_Protected_Virtual_Double_String_0;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeMethodInfoPtr_CanTryParse_Internal_Virtual_Boolean_String_0;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_Double_0;

		// Token: 0x02000367 RID: 871
		public new class UxmlFactory : UxmlFactory<DoubleField, DoubleField.UxmlTraits>
		{
			// Token: 0x06003765 RID: 14181 RVA: 0x00016D9B File Offset: 0x00014F9B
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<DoubleField.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DoubleField>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleField.UxmlFactory>.NativeClassPtr);
				DoubleField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleField.UxmlFactory>.NativeClassPtr, 100664444);
			}

			// Token: 0x06003766 RID: 14182 RVA: 0x000E34B4 File Offset: 0x000E16B4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 293583, RefRangeEnd = 293584, XrefRangeStart = 293580, XrefRangeEnd = 293583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleField.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003767 RID: 14183 RVA: 0x00016DCF File Offset: 0x00014FCF
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002784 RID: 10116
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000368 RID: 872
		public new class UxmlTraits : TextValueFieldTraits<double, UxmlDoubleAttributeDescription>
		{
			// Token: 0x06003768 RID: 14184 RVA: 0x00016DD8 File Offset: 0x00014FD8
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<DoubleField.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DoubleField>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleField.UxmlTraits>.NativeClassPtr);
				DoubleField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleField.UxmlTraits>.NativeClassPtr, 100664445);
			}

			// Token: 0x06003769 RID: 14185 RVA: 0x000E34F0 File Offset: 0x000E16F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293584, XrefRangeEnd = 293587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleField.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600376A RID: 14186 RVA: 0x00016E0C File Offset: 0x0001500C
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002785 RID: 10117
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000369 RID: 873
		public class DoubleInput : TextValueField<double>.TextValueInput
		{
			// Token: 0x0600376B RID: 14187 RVA: 0x000E352C File Offset: 0x000E172C
			// Note: this type is marked as 'beforefieldinit'.
			static DoubleInput()
			{
				Il2CppClassPointerStore<DoubleField.DoubleInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DoubleField>.NativeClassPtr, "DoubleInput");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleField.DoubleInput>.NativeClassPtr);
				DoubleField.DoubleInput.NativeMethodInfoPtr_get_parentDoubleField_Private_get_DoubleField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleField.DoubleInput>.NativeClassPtr, 100664446);
				DoubleField.DoubleInput.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleField.DoubleInput>.NativeClassPtr, 100664447);
				DoubleField.DoubleInput.NativeMethodInfoPtr_get_allowedCharacters_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleField.DoubleInput>.NativeClassPtr, 100664448);
				DoubleField.DoubleInput.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleField.DoubleInput>.NativeClassPtr, 100664449);
				DoubleField.DoubleInput.NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleField.DoubleInput>.NativeClassPtr, 100664450);
				DoubleField.DoubleInput.NativeMethodInfoPtr_StringToValue_Protected_Virtual_Double_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleField.DoubleInput>.NativeClassPtr, 100664451);
			}

			// Token: 0x17001125 RID: 4389
			// (get) Token: 0x0600376C RID: 14188 RVA: 0x000E35D0 File Offset: 0x000E17D0
			public unsafe DoubleField parentDoubleField
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 293590, RefRangeEnd = 293593, XrefRangeStart = 293587, XrefRangeEnd = 293590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleField.DoubleInput.NativeMethodInfoPtr_get_parentDoubleField_Private_get_DoubleField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DoubleField>(intPtr3) : null;
				}
			}

			// Token: 0x0600376D RID: 14189 RVA: 0x000E3610 File Offset: 0x000E1810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293593, XrefRangeEnd = 293602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DoubleInput()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleField.DoubleInput>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoubleField.DoubleInput.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001126 RID: 4390
			// (get) Token: 0x0600376E RID: 14190 RVA: 0x000E364C File Offset: 0x000E184C
			public unsafe override string allowedCharacters
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293602, XrefRangeEnd = 293606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoubleField.DoubleInput.NativeMethodInfoPtr_get_allowedCharacters_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600376F RID: 14191 RVA: 0x000E3690 File Offset: 0x000E1890
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293606, XrefRangeEnd = 293619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, double startValue)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref delta;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoubleField.DoubleInput.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003770 RID: 14192 RVA: 0x000E36F8 File Offset: 0x000E18F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293619, XrefRangeEnd = 293621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ValueToString(double v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoubleField.DoubleInput.NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06003771 RID: 14193 RVA: 0x000E3748 File Offset: 0x000E1948
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293621, XrefRangeEnd = 293623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override double StringToValue(string str)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoubleField.DoubleInput.NativeMethodInfoPtr_StringToValue_Protected_Virtual_Double_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003772 RID: 14194 RVA: 0x00016E15 File Offset: 0x00015015
			public DoubleInput(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002786 RID: 10118
			private static readonly IntPtr NativeMethodInfoPtr_get_parentDoubleField_Private_get_DoubleField_0;

			// Token: 0x04002787 RID: 10119
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x04002788 RID: 10120
			private static readonly IntPtr NativeMethodInfoPtr_get_allowedCharacters_Protected_Virtual_get_String_0;

			// Token: 0x04002789 RID: 10121
			private static readonly IntPtr NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_Double_0;

			// Token: 0x0400278A RID: 10122
			private static readonly IntPtr NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_Double_0;

			// Token: 0x0400278B RID: 10123
			private static readonly IntPtr NativeMethodInfoPtr_StringToValue_Protected_Virtual_Double_String_0;
		}
	}
}

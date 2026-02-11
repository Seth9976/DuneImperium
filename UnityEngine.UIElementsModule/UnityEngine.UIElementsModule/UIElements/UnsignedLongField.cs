using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000098 RID: 152
	public class UnsignedLongField : TextValueField<ulong>
	{
		// Token: 0x06000F45 RID: 3909 RVA: 0x00052B2C File Offset: 0x00050D2C
		// Note: this type is marked as 'beforefieldinit'.
		static UnsignedLongField()
		{
			Il2CppClassPointerStore<UnsignedLongField>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UnsignedLongField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsignedLongField>.NativeClassPtr);
			UnsignedLongField.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsignedLongField>.NativeClassPtr, "ussClassName");
			UnsignedLongField.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsignedLongField>.NativeClassPtr, "labelUssClassName");
			UnsignedLongField.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsignedLongField>.NativeClassPtr, "inputUssClassName");
			UnsignedLongField.NativeMethodInfoPtr_get_unsignedLongInput_Private_get_UnsignedLongInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedLongField>.NativeClassPtr, 100665453);
			UnsignedLongField.NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedLongField>.NativeClassPtr, 100665454);
			UnsignedLongField.NativeMethodInfoPtr_StringToValue_Protected_Virtual_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedLongField>.NativeClassPtr, 100665455);
			UnsignedLongField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedLongField>.NativeClassPtr, 100665456);
			UnsignedLongField.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedLongField>.NativeClassPtr, 100665457);
			UnsignedLongField.NativeMethodInfoPtr_CanTryParse_Internal_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedLongField>.NativeClassPtr, 100665458);
			UnsignedLongField.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedLongField>.NativeClassPtr, 100665459);
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000F46 RID: 3910 RVA: 0x00052C24 File Offset: 0x00050E24
		public unsafe UnsignedLongField.UnsignedLongInput unsignedLongInput
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307659, XrefRangeEnd = 307662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsignedLongField.NativeMethodInfoPtr_get_unsignedLongInput_Private_get_UnsignedLongInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnsignedLongField.UnsignedLongInput>(intPtr3) : null;
			}
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x00052C64 File Offset: 0x00050E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307662, XrefRangeEnd = 307670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ValueToString(ulong v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnsignedLongField.NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x00052CB4 File Offset: 0x00050EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307670, XrefRangeEnd = 307679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ulong StringToValue(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnsignedLongField.NativeMethodInfoPtr_StringToValue_Protected_Virtual_UInt64_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x00052D0C File Offset: 0x00050F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307679, XrefRangeEnd = 307711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnsignedLongField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsignedLongField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsignedLongField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x00052D48 File Offset: 0x00050F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307711, XrefRangeEnd = 307743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnsignedLongField(string label, int maxLength = 1000)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsignedLongField>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsignedLongField.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x00052DA4 File Offset: 0x00050FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307743, XrefRangeEnd = 307744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanTryParse(string textString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(textString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnsignedLongField.NativeMethodInfoPtr_CanTryParse_Internal_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x00052DFC File Offset: 0x00050FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307744, XrefRangeEnd = 307747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, ulong startValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnsignedLongField.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x00007C74 File Offset: 0x00005E74
		public UnsignedLongField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000F4E RID: 3918 RVA: 0x00052E64 File Offset: 0x00051064
		// (set) Token: 0x06000F4F RID: 3919 RVA: 0x00007C7D File Offset: 0x00005E7D
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnsignedLongField.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnsignedLongField.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000F50 RID: 3920 RVA: 0x00052E84 File Offset: 0x00051084
		// (set) Token: 0x06000F51 RID: 3921 RVA: 0x00007C8F File Offset: 0x00005E8F
		public new unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnsignedLongField.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnsignedLongField.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000F52 RID: 3922 RVA: 0x00052EA4 File Offset: 0x000510A4
		// (set) Token: 0x06000F53 RID: 3923 RVA: 0x00007CA1 File Offset: 0x00005EA1
		public new unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnsignedLongField.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnsignedLongField.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A94 RID: 2708
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x04000A95 RID: 2709
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x04000A96 RID: 2710
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeMethodInfoPtr_get_unsignedLongInput_Private_get_UnsignedLongInput_0;

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_UInt64_0;

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeMethodInfoPtr_StringToValue_Protected_Virtual_UInt64_String_0;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeMethodInfoPtr_CanTryParse_Internal_Virtual_Boolean_String_0;

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_UInt64_0;

		// Token: 0x020003D2 RID: 978
		public new class UxmlFactory : UxmlFactory<UnsignedLongField, UnsignedLongField.UxmlTraits>
		{
			// Token: 0x060039E0 RID: 14816 RVA: 0x0001879B File Offset: 0x0001699B
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<UnsignedLongField.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsignedLongField>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsignedLongField.UxmlFactory>.NativeClassPtr);
				UnsignedLongField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedLongField.UxmlFactory>.NativeClassPtr, 100665461);
			}

			// Token: 0x060039E1 RID: 14817 RVA: 0x000EA900 File Offset: 0x000E8B00
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 307606, RefRangeEnd = 307607, XrefRangeStart = 307603, XrefRangeEnd = 307606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsignedLongField.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsignedLongField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039E2 RID: 14818 RVA: 0x000187CF File Offset: 0x000169CF
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040028E4 RID: 10468
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003D3 RID: 979
		public new class UxmlTraits : TextValueFieldTraits<ulong, UxmlUnsignedLongAttributeDescription>
		{
			// Token: 0x060039E3 RID: 14819 RVA: 0x000187D8 File Offset: 0x000169D8
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<UnsignedLongField.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsignedLongField>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsignedLongField.UxmlTraits>.NativeClassPtr);
				UnsignedLongField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedLongField.UxmlTraits>.NativeClassPtr, 100665462);
			}

			// Token: 0x060039E4 RID: 14820 RVA: 0x000EA93C File Offset: 0x000E8B3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307607, XrefRangeEnd = 307610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsignedLongField.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsignedLongField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039E5 RID: 14821 RVA: 0x0001880C File Offset: 0x00016A0C
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040028E5 RID: 10469
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003D4 RID: 980
		public class UnsignedLongInput : TextValueField<ulong>.TextValueInput
		{
			// Token: 0x060039E6 RID: 14822 RVA: 0x000EA978 File Offset: 0x000E8B78
			// Note: this type is marked as 'beforefieldinit'.
			static UnsignedLongInput()
			{
				Il2CppClassPointerStore<UnsignedLongField.UnsignedLongInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsignedLongField>.NativeClassPtr, "UnsignedLongInput");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsignedLongField.UnsignedLongInput>.NativeClassPtr);
				UnsignedLongField.UnsignedLongInput.NativeMethodInfoPtr_get_parentUnsignedLongField_Private_get_UnsignedLongField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedLongField.UnsignedLongInput>.NativeClassPtr, 100665463);
				UnsignedLongField.UnsignedLongInput.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedLongField.UnsignedLongInput>.NativeClassPtr, 100665464);
				UnsignedLongField.UnsignedLongInput.NativeMethodInfoPtr_get_allowedCharacters_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedLongField.UnsignedLongInput>.NativeClassPtr, 100665465);
				UnsignedLongField.UnsignedLongInput.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedLongField.UnsignedLongInput>.NativeClassPtr, 100665466);
				UnsignedLongField.UnsignedLongInput.NativeMethodInfoPtr_ClampToMinMaxULongValue_Private_UInt64_Int64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedLongField.UnsignedLongInput>.NativeClassPtr, 100665467);
				UnsignedLongField.UnsignedLongInput.NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedLongField.UnsignedLongInput>.NativeClassPtr, 100665468);
				UnsignedLongField.UnsignedLongInput.NativeMethodInfoPtr_StringToValue_Protected_Virtual_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedLongField.UnsignedLongInput>.NativeClassPtr, 100665469);
			}

			// Token: 0x170011BF RID: 4543
			// (get) Token: 0x060039E7 RID: 14823 RVA: 0x000EAA30 File Offset: 0x000E8C30
			public unsafe UnsignedLongField parentUnsignedLongField
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 307613, RefRangeEnd = 307616, XrefRangeStart = 307610, XrefRangeEnd = 307613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsignedLongField.UnsignedLongInput.NativeMethodInfoPtr_get_parentUnsignedLongField_Private_get_UnsignedLongField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnsignedLongField>(intPtr3) : null;
				}
			}

			// Token: 0x060039E8 RID: 14824 RVA: 0x000EAA70 File Offset: 0x000E8C70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307616, XrefRangeEnd = 307625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UnsignedLongInput()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsignedLongField.UnsignedLongInput>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsignedLongField.UnsignedLongInput.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170011C0 RID: 4544
			// (get) Token: 0x060039E9 RID: 14825 RVA: 0x000EAAAC File Offset: 0x000E8CAC
			public unsafe override string allowedCharacters
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307625, XrefRangeEnd = 307629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnsignedLongField.UnsignedLongInput.NativeMethodInfoPtr_get_allowedCharacters_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060039EA RID: 14826 RVA: 0x000EAAF0 File Offset: 0x000E8CF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307629, XrefRangeEnd = 307652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, ulong startValue)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnsignedLongField.UnsignedLongInput.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039EB RID: 14827 RVA: 0x000EAB58 File Offset: 0x000E8D58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307652, XrefRangeEnd = 307655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ulong ClampToMinMaxULongValue(long niceDelta, ulong value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref niceDelta;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsignedLongField.UnsignedLongInput.NativeMethodInfoPtr_ClampToMinMaxULongValue_Private_UInt64_Int64_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060039EC RID: 14828 RVA: 0x000EABB0 File Offset: 0x000E8DB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307655, XrefRangeEnd = 307657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ValueToString(ulong v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnsignedLongField.UnsignedLongInput.NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060039ED RID: 14829 RVA: 0x000EAC00 File Offset: 0x000E8E00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307657, XrefRangeEnd = 307659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override ulong StringToValue(string str)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnsignedLongField.UnsignedLongInput.NativeMethodInfoPtr_StringToValue_Protected_Virtual_UInt64_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060039EE RID: 14830 RVA: 0x00018815 File Offset: 0x00016A15
			public UnsignedLongInput(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040028E6 RID: 10470
			private static readonly IntPtr NativeMethodInfoPtr_get_parentUnsignedLongField_Private_get_UnsignedLongField_0;

			// Token: 0x040028E7 RID: 10471
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x040028E8 RID: 10472
			private static readonly IntPtr NativeMethodInfoPtr_get_allowedCharacters_Protected_Virtual_get_String_0;

			// Token: 0x040028E9 RID: 10473
			private static readonly IntPtr NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_UInt64_0;

			// Token: 0x040028EA RID: 10474
			private static readonly IntPtr NativeMethodInfoPtr_ClampToMinMaxULongValue_Private_UInt64_Int64_UInt64_0;

			// Token: 0x040028EB RID: 10475
			private static readonly IntPtr NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_UInt64_0;

			// Token: 0x040028EC RID: 10476
			private static readonly IntPtr NativeMethodInfoPtr_StringToValue_Protected_Virtual_UInt64_String_0;
		}
	}
}

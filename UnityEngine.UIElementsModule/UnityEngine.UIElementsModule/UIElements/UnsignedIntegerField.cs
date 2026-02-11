using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000097 RID: 151
	public class UnsignedIntegerField : TextValueField<uint>
	{
		// Token: 0x06000F36 RID: 3894 RVA: 0x00052794 File Offset: 0x00050994
		// Note: this type is marked as 'beforefieldinit'.
		static UnsignedIntegerField()
		{
			Il2CppClassPointerStore<UnsignedIntegerField>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UnsignedIntegerField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsignedIntegerField>.NativeClassPtr);
			UnsignedIntegerField.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsignedIntegerField>.NativeClassPtr, "ussClassName");
			UnsignedIntegerField.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsignedIntegerField>.NativeClassPtr, "labelUssClassName");
			UnsignedIntegerField.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsignedIntegerField>.NativeClassPtr, "inputUssClassName");
			UnsignedIntegerField.NativeMethodInfoPtr_get_integerInput_Private_get_UnsignedIntegerInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedIntegerField>.NativeClassPtr, 100665437);
			UnsignedIntegerField.NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedIntegerField>.NativeClassPtr, 100665438);
			UnsignedIntegerField.NativeMethodInfoPtr_StringToValue_Protected_Virtual_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedIntegerField>.NativeClassPtr, 100665439);
			UnsignedIntegerField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedIntegerField>.NativeClassPtr, 100665440);
			UnsignedIntegerField.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedIntegerField>.NativeClassPtr, 100665441);
			UnsignedIntegerField.NativeMethodInfoPtr_CanTryParse_Internal_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedIntegerField>.NativeClassPtr, 100665442);
			UnsignedIntegerField.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedIntegerField>.NativeClassPtr, 100665443);
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x0005288C File Offset: 0x00050A8C
		public unsafe UnsignedIntegerField.UnsignedIntegerInput integerInput
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307515, XrefRangeEnd = 307518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsignedIntegerField.NativeMethodInfoPtr_get_integerInput_Private_get_UnsignedIntegerInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnsignedIntegerField.UnsignedIntegerInput>(intPtr3) : null;
			}
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x000528CC File Offset: 0x00050ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307518, XrefRangeEnd = 307526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ValueToString(uint v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnsignedIntegerField.NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x0005291C File Offset: 0x00050B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307526, XrefRangeEnd = 307535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override uint StringToValue(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnsignedIntegerField.NativeMethodInfoPtr_StringToValue_Protected_Virtual_UInt32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00052974 File Offset: 0x00050B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307535, XrefRangeEnd = 307567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnsignedIntegerField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsignedIntegerField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsignedIntegerField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x000529B0 File Offset: 0x00050BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307567, XrefRangeEnd = 307599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnsignedIntegerField(string label, int maxLength = 1000)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsignedIntegerField>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsignedIntegerField.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x00052A0C File Offset: 0x00050C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307599, XrefRangeEnd = 307600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanTryParse(string textString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(textString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnsignedIntegerField.NativeMethodInfoPtr_CanTryParse_Internal_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x00052A64 File Offset: 0x00050C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307600, XrefRangeEnd = 307603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, uint startValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnsignedIntegerField.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x00007C35 File Offset: 0x00005E35
		public UnsignedIntegerField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x00052ACC File Offset: 0x00050CCC
		// (set) Token: 0x06000F40 RID: 3904 RVA: 0x00007C3E File Offset: 0x00005E3E
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnsignedIntegerField.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnsignedIntegerField.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x00052AEC File Offset: 0x00050CEC
		// (set) Token: 0x06000F42 RID: 3906 RVA: 0x00007C50 File Offset: 0x00005E50
		public new unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnsignedIntegerField.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnsignedIntegerField.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x00052B0C File Offset: 0x00050D0C
		// (set) Token: 0x06000F44 RID: 3908 RVA: 0x00007C62 File Offset: 0x00005E62
		public new unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnsignedIntegerField.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnsignedIntegerField.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A8A RID: 2698
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x04000A8B RID: 2699
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x04000A8C RID: 2700
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x04000A8D RID: 2701
		private static readonly IntPtr NativeMethodInfoPtr_get_integerInput_Private_get_UnsignedIntegerInput_0;

		// Token: 0x04000A8E RID: 2702
		private static readonly IntPtr NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_UInt32_0;

		// Token: 0x04000A8F RID: 2703
		private static readonly IntPtr NativeMethodInfoPtr_StringToValue_Protected_Virtual_UInt32_String_0;

		// Token: 0x04000A90 RID: 2704
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000A91 RID: 2705
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

		// Token: 0x04000A92 RID: 2706
		private static readonly IntPtr NativeMethodInfoPtr_CanTryParse_Internal_Virtual_Boolean_String_0;

		// Token: 0x04000A93 RID: 2707
		private static readonly IntPtr NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_UInt32_0;

		// Token: 0x020003CF RID: 975
		public new class UxmlFactory : UxmlFactory<UnsignedIntegerField, UnsignedIntegerField.UxmlTraits>
		{
			// Token: 0x060039D2 RID: 14802 RVA: 0x00018718 File Offset: 0x00016918
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<UnsignedIntegerField.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsignedIntegerField>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsignedIntegerField.UxmlFactory>.NativeClassPtr);
				UnsignedIntegerField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedIntegerField.UxmlFactory>.NativeClassPtr, 100665445);
			}

			// Token: 0x060039D3 RID: 14803 RVA: 0x000EA614 File Offset: 0x000E8814
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 307471, RefRangeEnd = 307472, XrefRangeStart = 307468, XrefRangeEnd = 307471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsignedIntegerField.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsignedIntegerField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039D4 RID: 14804 RVA: 0x0001874C File Offset: 0x0001694C
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040028DC RID: 10460
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003D0 RID: 976
		public new class UxmlTraits : TextValueFieldTraits<uint, UxmlUnsignedIntAttributeDescription>
		{
			// Token: 0x060039D5 RID: 14805 RVA: 0x00018755 File Offset: 0x00016955
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<UnsignedIntegerField.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsignedIntegerField>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsignedIntegerField.UxmlTraits>.NativeClassPtr);
				UnsignedIntegerField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedIntegerField.UxmlTraits>.NativeClassPtr, 100665446);
			}

			// Token: 0x060039D6 RID: 14806 RVA: 0x000EA650 File Offset: 0x000E8850
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307472, XrefRangeEnd = 307475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsignedIntegerField.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsignedIntegerField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039D7 RID: 14807 RVA: 0x00018789 File Offset: 0x00016989
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040028DD RID: 10461
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003D1 RID: 977
		public class UnsignedIntegerInput : TextValueField<uint>.TextValueInput
		{
			// Token: 0x060039D8 RID: 14808 RVA: 0x000EA68C File Offset: 0x000E888C
			// Note: this type is marked as 'beforefieldinit'.
			static UnsignedIntegerInput()
			{
				Il2CppClassPointerStore<UnsignedIntegerField.UnsignedIntegerInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsignedIntegerField>.NativeClassPtr, "UnsignedIntegerInput");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsignedIntegerField.UnsignedIntegerInput>.NativeClassPtr);
				UnsignedIntegerField.UnsignedIntegerInput.NativeMethodInfoPtr_get_parentUnsignedIntegerField_Private_get_UnsignedIntegerField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedIntegerField.UnsignedIntegerInput>.NativeClassPtr, 100665447);
				UnsignedIntegerField.UnsignedIntegerInput.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedIntegerField.UnsignedIntegerInput>.NativeClassPtr, 100665448);
				UnsignedIntegerField.UnsignedIntegerInput.NativeMethodInfoPtr_get_allowedCharacters_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedIntegerField.UnsignedIntegerInput>.NativeClassPtr, 100665449);
				UnsignedIntegerField.UnsignedIntegerInput.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedIntegerField.UnsignedIntegerInput>.NativeClassPtr, 100665450);
				UnsignedIntegerField.UnsignedIntegerInput.NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedIntegerField.UnsignedIntegerInput>.NativeClassPtr, 100665451);
				UnsignedIntegerField.UnsignedIntegerInput.NativeMethodInfoPtr_StringToValue_Protected_Virtual_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsignedIntegerField.UnsignedIntegerInput>.NativeClassPtr, 100665452);
			}

			// Token: 0x170011BD RID: 4541
			// (get) Token: 0x060039D9 RID: 14809 RVA: 0x000EA730 File Offset: 0x000E8930
			public unsafe UnsignedIntegerField parentUnsignedIntegerField
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 307478, RefRangeEnd = 307481, XrefRangeStart = 307475, XrefRangeEnd = 307478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsignedIntegerField.UnsignedIntegerInput.NativeMethodInfoPtr_get_parentUnsignedIntegerField_Private_get_UnsignedIntegerField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnsignedIntegerField>(intPtr3) : null;
				}
			}

			// Token: 0x060039DA RID: 14810 RVA: 0x000EA770 File Offset: 0x000E8970
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307481, XrefRangeEnd = 307490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UnsignedIntegerInput()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsignedIntegerField.UnsignedIntegerInput>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsignedIntegerField.UnsignedIntegerInput.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170011BE RID: 4542
			// (get) Token: 0x060039DB RID: 14811 RVA: 0x000EA7AC File Offset: 0x000E89AC
			public unsafe override string allowedCharacters
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307490, XrefRangeEnd = 307494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnsignedIntegerField.UnsignedIntegerInput.NativeMethodInfoPtr_get_allowedCharacters_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060039DC RID: 14812 RVA: 0x000EA7F0 File Offset: 0x000E89F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307494, XrefRangeEnd = 307511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, uint startValue)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnsignedIntegerField.UnsignedIntegerInput.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039DD RID: 14813 RVA: 0x000EA858 File Offset: 0x000E8A58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307511, XrefRangeEnd = 307513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ValueToString(uint v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnsignedIntegerField.UnsignedIntegerInput.NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060039DE RID: 14814 RVA: 0x000EA8A8 File Offset: 0x000E8AA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307513, XrefRangeEnd = 307515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override uint StringToValue(string str)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnsignedIntegerField.UnsignedIntegerInput.NativeMethodInfoPtr_StringToValue_Protected_Virtual_UInt32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060039DF RID: 14815 RVA: 0x00018792 File Offset: 0x00016992
			public UnsignedIntegerInput(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040028DE RID: 10462
			private static readonly IntPtr NativeMethodInfoPtr_get_parentUnsignedIntegerField_Private_get_UnsignedIntegerField_0;

			// Token: 0x040028DF RID: 10463
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x040028E0 RID: 10464
			private static readonly IntPtr NativeMethodInfoPtr_get_allowedCharacters_Protected_Virtual_get_String_0;

			// Token: 0x040028E1 RID: 10465
			private static readonly IntPtr NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_UInt32_0;

			// Token: 0x040028E2 RID: 10466
			private static readonly IntPtr NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_UInt32_0;

			// Token: 0x040028E3 RID: 10467
			private static readonly IntPtr NativeMethodInfoPtr_StringToValue_Protected_Virtual_UInt32_String_0;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200005A RID: 90
	public class FloatField : TextValueField<float>
	{
		// Token: 0x0600082C RID: 2092 RVA: 0x0003A27C File Offset: 0x0003847C
		// Note: this type is marked as 'beforefieldinit'.
		static FloatField()
		{
			Il2CppClassPointerStore<FloatField>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "FloatField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatField>.NativeClassPtr);
			FloatField.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatField>.NativeClassPtr, "ussClassName");
			FloatField.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatField>.NativeClassPtr, "labelUssClassName");
			FloatField.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatField>.NativeClassPtr, "inputUssClassName");
			FloatField.NativeMethodInfoPtr_get_floatInput_Private_get_FloatInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatField>.NativeClassPtr, 100664484);
			FloatField.NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatField>.NativeClassPtr, 100664485);
			FloatField.NativeMethodInfoPtr_StringToValue_Protected_Virtual_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatField>.NativeClassPtr, 100664486);
			FloatField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatField>.NativeClassPtr, 100664487);
			FloatField.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatField>.NativeClassPtr, 100664488);
			FloatField.NativeMethodInfoPtr_CanTryParse_Internal_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatField>.NativeClassPtr, 100664489);
			FloatField.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatField>.NativeClassPtr, 100664490);
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x0003A374 File Offset: 0x00038574
		public unsafe FloatField.FloatInput floatInput
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294096, XrefRangeEnd = 294099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatField.NativeMethodInfoPtr_get_floatInput_Private_get_FloatInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FloatField.FloatInput>(intPtr3) : null;
			}
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0003A3B4 File Offset: 0x000385B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294099, XrefRangeEnd = 294107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ValueToString(float v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloatField.NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x0003A404 File Offset: 0x00038604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294107, XrefRangeEnd = 294116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float StringToValue(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloatField.NativeMethodInfoPtr_StringToValue_Protected_Virtual_Single_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0003A45C File Offset: 0x0003865C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294116, XrefRangeEnd = 294148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FloatField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x0003A498 File Offset: 0x00038698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294148, XrefRangeEnd = 294180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FloatField(string label, int maxLength = 1000)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatField>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatField.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x0003A4F4 File Offset: 0x000386F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294180, XrefRangeEnd = 294181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanTryParse(string textString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(textString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloatField.NativeMethodInfoPtr_CanTryParse_Internal_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0003A54C File Offset: 0x0003874C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294181, XrefRangeEnd = 294184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloatField.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00004D76 File Offset: 0x00002F76
		public FloatField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000835 RID: 2101 RVA: 0x0003A5B4 File Offset: 0x000387B4
		// (set) Token: 0x06000836 RID: 2102 RVA: 0x00004D7F File Offset: 0x00002F7F
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FloatField.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FloatField.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x0003A5D4 File Offset: 0x000387D4
		// (set) Token: 0x06000838 RID: 2104 RVA: 0x00004D91 File Offset: 0x00002F91
		public new unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FloatField.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FloatField.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x0003A5F4 File Offset: 0x000387F4
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x00004DA3 File Offset: 0x00002FA3
		public new unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FloatField.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FloatField.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeMethodInfoPtr_get_floatInput_Private_get_FloatInput_0;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_Single_0;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeMethodInfoPtr_StringToValue_Protected_Virtual_Single_String_0;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeMethodInfoPtr_CanTryParse_Internal_Virtual_Boolean_String_0;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_Single_0;

		// Token: 0x02000371 RID: 881
		public new class UxmlFactory : UxmlFactory<FloatField, FloatField.UxmlTraits>
		{
			// Token: 0x06003794 RID: 14228 RVA: 0x00016F72 File Offset: 0x00015172
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<FloatField.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatField>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatField.UxmlFactory>.NativeClassPtr);
				FloatField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatField.UxmlFactory>.NativeClassPtr, 100664492);
			}

			// Token: 0x06003795 RID: 14229 RVA: 0x000E3D1C File Offset: 0x000E1F1C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 294055, RefRangeEnd = 294056, XrefRangeStart = 294052, XrefRangeEnd = 294055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatField.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003796 RID: 14230 RVA: 0x00016FA6 File Offset: 0x000151A6
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400279C RID: 10140
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000372 RID: 882
		public new class UxmlTraits : TextValueFieldTraits<float, UxmlFloatAttributeDescription>
		{
			// Token: 0x06003797 RID: 14231 RVA: 0x00016FAF File Offset: 0x000151AF
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<FloatField.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatField>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatField.UxmlTraits>.NativeClassPtr);
				FloatField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatField.UxmlTraits>.NativeClassPtr, 100664493);
			}

			// Token: 0x06003798 RID: 14232 RVA: 0x000E3D58 File Offset: 0x000E1F58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294056, XrefRangeEnd = 294059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatField.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003799 RID: 14233 RVA: 0x00016FE3 File Offset: 0x000151E3
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400279D RID: 10141
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000373 RID: 883
		public class FloatInput : TextValueField<float>.TextValueInput
		{
			// Token: 0x0600379A RID: 14234 RVA: 0x000E3D94 File Offset: 0x000E1F94
			// Note: this type is marked as 'beforefieldinit'.
			static FloatInput()
			{
				Il2CppClassPointerStore<FloatField.FloatInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatField>.NativeClassPtr, "FloatInput");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatField.FloatInput>.NativeClassPtr);
				FloatField.FloatInput.NativeMethodInfoPtr_get_parentFloatField_Private_get_FloatField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatField.FloatInput>.NativeClassPtr, 100664494);
				FloatField.FloatInput.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatField.FloatInput>.NativeClassPtr, 100664495);
				FloatField.FloatInput.NativeMethodInfoPtr_get_allowedCharacters_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatField.FloatInput>.NativeClassPtr, 100664496);
				FloatField.FloatInput.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatField.FloatInput>.NativeClassPtr, 100664497);
				FloatField.FloatInput.NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatField.FloatInput>.NativeClassPtr, 100664498);
				FloatField.FloatInput.NativeMethodInfoPtr_StringToValue_Protected_Virtual_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatField.FloatInput>.NativeClassPtr, 100664499);
			}

			// Token: 0x1700112E RID: 4398
			// (get) Token: 0x0600379B RID: 14235 RVA: 0x000E3E38 File Offset: 0x000E2038
			public unsafe FloatField parentFloatField
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 294062, RefRangeEnd = 294065, XrefRangeStart = 294059, XrefRangeEnd = 294062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatField.FloatInput.NativeMethodInfoPtr_get_parentFloatField_Private_get_FloatField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<FloatField>(intPtr3) : null;
				}
			}

			// Token: 0x0600379C RID: 14236 RVA: 0x000E3E78 File Offset: 0x000E2078
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294065, XrefRangeEnd = 294074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FloatInput()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatField.FloatInput>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatField.FloatInput.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700112F RID: 4399
			// (get) Token: 0x0600379D RID: 14237 RVA: 0x000E3EB4 File Offset: 0x000E20B4
			public unsafe override string allowedCharacters
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294074, XrefRangeEnd = 294078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloatField.FloatInput.NativeMethodInfoPtr_get_allowedCharacters_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600379E RID: 14238 RVA: 0x000E3EF8 File Offset: 0x000E20F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294078, XrefRangeEnd = 294092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloatField.FloatInput.NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600379F RID: 14239 RVA: 0x000E3F60 File Offset: 0x000E2160
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294092, XrefRangeEnd = 294094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ValueToString(float v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloatField.FloatInput.NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060037A0 RID: 14240 RVA: 0x000E3FB0 File Offset: 0x000E21B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294094, XrefRangeEnd = 294096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override float StringToValue(string str)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloatField.FloatInput.NativeMethodInfoPtr_StringToValue_Protected_Virtual_Single_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060037A1 RID: 14241 RVA: 0x00016FEC File Offset: 0x000151EC
			public FloatInput(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400279E RID: 10142
			private static readonly IntPtr NativeMethodInfoPtr_get_parentFloatField_Private_get_FloatField_0;

			// Token: 0x0400279F RID: 10143
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x040027A0 RID: 10144
			private static readonly IntPtr NativeMethodInfoPtr_get_allowedCharacters_Protected_Virtual_get_String_0;

			// Token: 0x040027A1 RID: 10145
			private static readonly IntPtr NativeMethodInfoPtr_ApplyInputDeviceDelta_Public_Virtual_Void_Vector3_DeltaSpeed_Single_0;

			// Token: 0x040027A2 RID: 10146
			private static readonly IntPtr NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_Single_0;

			// Token: 0x040027A3 RID: 10147
			private static readonly IntPtr NativeMethodInfoPtr_StringToValue_Protected_Virtual_Single_String_0;
		}
	}
}

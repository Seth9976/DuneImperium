using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000052 RID: 82
	public class Vector3Field : BaseCompositeField<Vector3, FloatField, float>
	{
		// Token: 0x060007B8 RID: 1976 RVA: 0x00038BF4 File Offset: 0x00036DF4
		// Note: this type is marked as 'beforefieldinit'.
		static Vector3Field()
		{
			Il2CppClassPointerStore<Vector3Field>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Vector3Field");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3Field>.NativeClassPtr);
			Vector3Field.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Field>.NativeClassPtr, "ussClassName");
			Vector3Field.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Field>.NativeClassPtr, "labelUssClassName");
			Vector3Field.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Field>.NativeClassPtr, "inputUssClassName");
			Vector3Field.NativeMethodInfoPtr_DescribeFields_Internal_Virtual_Il2CppReferenceArray_1_FieldDescription_Vector3_FloatField_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Field>.NativeClassPtr, 100664376);
			Vector3Field.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Field>.NativeClassPtr, 100664377);
			Vector3Field.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Field>.NativeClassPtr, 100664378);
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00038C9C File Offset: 0x00036E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292885, XrefRangeEnd = 292991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<BaseCompositeField<Vector3, FloatField, float>.FieldDescription> DescribeFields()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector3Field.NativeMethodInfoPtr_DescribeFields_Internal_Virtual_Il2CppReferenceArray_1_FieldDescription_Vector3_FloatField_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BaseCompositeField<Vector3, FloatField, float>.FieldDescription>>(intPtr3) : null;
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00038CE8 File Offset: 0x00036EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292991, XrefRangeEnd = 292992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3Field()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector3Field>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Field.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00038D24 File Offset: 0x00036F24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 293012, RefRangeEnd = 293015, XrefRangeStart = 292992, XrefRangeEnd = 293012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3Field(string label)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector3Field>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Field.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00004AC3 File Offset: 0x00002CC3
		public Vector3Field(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x00038D70 File Offset: 0x00036F70
		// (set) Token: 0x060007BE RID: 1982 RVA: 0x00004ACC File Offset: 0x00002CCC
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Vector3Field.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3Field.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x00038D90 File Offset: 0x00036F90
		// (set) Token: 0x060007C0 RID: 1984 RVA: 0x00004ADE File Offset: 0x00002CDE
		public new unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Vector3Field.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3Field.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x00038DB0 File Offset: 0x00036FB0
		// (set) Token: 0x060007C2 RID: 1986 RVA: 0x00004AF0 File Offset: 0x00002CF0
		public new unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Vector3Field.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3Field.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeMethodInfoPtr_DescribeFields_Internal_Virtual_Il2CppReferenceArray_1_FieldDescription_Vector3_FloatField_Single_0;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x02000357 RID: 855
		public new class UxmlFactory : UxmlFactory<Vector3Field, Vector3Field.UxmlTraits>
		{
			// Token: 0x060036D5 RID: 14037 RVA: 0x000168F3 File Offset: 0x00014AF3
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<Vector3Field.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector3Field>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3Field.UxmlFactory>.NativeClassPtr);
				Vector3Field.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Field.UxmlFactory>.NativeClassPtr, 100664380);
			}

			// Token: 0x060036D6 RID: 14038 RVA: 0x000E1AF4 File Offset: 0x000DFCF4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 292853, RefRangeEnd = 292854, XrefRangeStart = 292850, XrefRangeEnd = 292853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector3Field.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Field.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036D7 RID: 14039 RVA: 0x00016927 File Offset: 0x00014B27
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002734 RID: 10036
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000358 RID: 856
		public new class UxmlTraits : BaseField<Vector3>.UxmlTraits
		{
			// Token: 0x060036D8 RID: 14040 RVA: 0x000E1B30 File Offset: 0x000DFD30
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<Vector3Field.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector3Field>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3Field.UxmlTraits>.NativeClassPtr);
				Vector3Field.UxmlTraits.NativeFieldInfoPtr_m_XValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Field.UxmlTraits>.NativeClassPtr, "m_XValue");
				Vector3Field.UxmlTraits.NativeFieldInfoPtr_m_YValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Field.UxmlTraits>.NativeClassPtr, "m_YValue");
				Vector3Field.UxmlTraits.NativeFieldInfoPtr_m_ZValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Field.UxmlTraits>.NativeClassPtr, "m_ZValue");
				Vector3Field.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Field.UxmlTraits>.NativeClassPtr, 100664381);
				Vector3Field.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Field.UxmlTraits>.NativeClassPtr, 100664382);
			}

			// Token: 0x060036D9 RID: 14041 RVA: 0x000E1BC0 File Offset: 0x000DFDC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292854, XrefRangeEnd = 292859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector3Field.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036DA RID: 14042 RVA: 0x000E1C38 File Offset: 0x000DFE38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292859, XrefRangeEnd = 292885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector3Field.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Field.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036DB RID: 14043 RVA: 0x00016930 File Offset: 0x00014B30
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010FD RID: 4349
			// (get) Token: 0x060036DC RID: 14044 RVA: 0x000E1C74 File Offset: 0x000DFE74
			// (set) Token: 0x060036DD RID: 14045 RVA: 0x00016939 File Offset: 0x00014B39
			public unsafe UxmlFloatAttributeDescription m_XValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3Field.UxmlTraits.NativeFieldInfoPtr_m_XValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3Field.UxmlTraits.NativeFieldInfoPtr_m_XValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010FE RID: 4350
			// (get) Token: 0x060036DE RID: 14046 RVA: 0x000E1CA4 File Offset: 0x000DFEA4
			// (set) Token: 0x060036DF RID: 14047 RVA: 0x00016958 File Offset: 0x00014B58
			public unsafe UxmlFloatAttributeDescription m_YValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3Field.UxmlTraits.NativeFieldInfoPtr_m_YValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3Field.UxmlTraits.NativeFieldInfoPtr_m_YValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010FF RID: 4351
			// (get) Token: 0x060036E0 RID: 14048 RVA: 0x000E1CD4 File Offset: 0x000DFED4
			// (set) Token: 0x060036E1 RID: 14049 RVA: 0x00016977 File Offset: 0x00014B77
			public unsafe UxmlFloatAttributeDescription m_ZValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3Field.UxmlTraits.NativeFieldInfoPtr_m_ZValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3Field.UxmlTraits.NativeFieldInfoPtr_m_ZValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002735 RID: 10037
			private static readonly IntPtr NativeFieldInfoPtr_m_XValue;

			// Token: 0x04002736 RID: 10038
			private static readonly IntPtr NativeFieldInfoPtr_m_YValue;

			// Token: 0x04002737 RID: 10039
			private static readonly IntPtr NativeFieldInfoPtr_m_ZValue;

			// Token: 0x04002738 RID: 10040
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x04002739 RID: 10041
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000359 RID: 857
		[ObfuscatedName("UnityEngine.UIElements.Vector3Field+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060036E2 RID: 14050 RVA: 0x000E1D04 File Offset: 0x000DFF04
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Vector3Field.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector3Field>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3Field.__c>.NativeClassPtr);
				Vector3Field.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Field.__c>.NativeClassPtr, "<>9");
				Vector3Field.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Field.__c>.NativeClassPtr, "<>9__0_0");
				Vector3Field.__c.NativeFieldInfoPtr___9__0_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Field.__c>.NativeClassPtr, "<>9__0_1");
				Vector3Field.__c.NativeFieldInfoPtr___9__0_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Field.__c>.NativeClassPtr, "<>9__0_2");
				Vector3Field.__c.NativeFieldInfoPtr___9__0_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Field.__c>.NativeClassPtr, "<>9__0_3");
				Vector3Field.__c.NativeFieldInfoPtr___9__0_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Field.__c>.NativeClassPtr, "<>9__0_4");
				Vector3Field.__c.NativeFieldInfoPtr___9__0_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Field.__c>.NativeClassPtr, "<>9__0_5");
				Vector3Field.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Field.__c>.NativeClassPtr, 100664384);
				Vector3Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_0_Internal_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Field.__c>.NativeClassPtr, 100664385);
				Vector3Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_1_Internal_Void_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Field.__c>.NativeClassPtr, 100664386);
				Vector3Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_2_Internal_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Field.__c>.NativeClassPtr, 100664387);
				Vector3Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_3_Internal_Void_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Field.__c>.NativeClassPtr, 100664388);
				Vector3Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_4_Internal_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Field.__c>.NativeClassPtr, 100664389);
				Vector3Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_5_Internal_Void_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Field.__c>.NativeClassPtr, 100664390);
			}

			// Token: 0x060036E3 RID: 14051 RVA: 0x000E1E48 File Offset: 0x000E0048
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector3Field.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Field.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036E4 RID: 14052 RVA: 0x000E1E84 File Offset: 0x000E0084
			[CallerCount(0)]
			public unsafe float _DescribeFields_b__0_0(Vector3 r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_0_Internal_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060036E5 RID: 14053 RVA: 0x000E1ED0 File Offset: 0x000E00D0
			[CallerCount(0)]
			public unsafe void _DescribeFields_b__0_1(ref Vector3 r, float v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_1_Internal_Void_byref_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036E6 RID: 14054 RVA: 0x000E1F1C File Offset: 0x000E011C
			[CallerCount(0)]
			public unsafe float _DescribeFields_b__0_2(Vector3 r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_2_Internal_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060036E7 RID: 14055 RVA: 0x000E1F68 File Offset: 0x000E0168
			[CallerCount(0)]
			public unsafe void _DescribeFields_b__0_3(ref Vector3 r, float v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_3_Internal_Void_byref_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036E8 RID: 14056 RVA: 0x000E1FB4 File Offset: 0x000E01B4
			[CallerCount(0)]
			public unsafe float _DescribeFields_b__0_4(Vector3 r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_4_Internal_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060036E9 RID: 14057 RVA: 0x000E2000 File Offset: 0x000E0200
			[CallerCount(0)]
			public unsafe void _DescribeFields_b__0_5(ref Vector3 r, float v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_5_Internal_Void_byref_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036EA RID: 14058 RVA: 0x00016996 File Offset: 0x00014B96
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001100 RID: 4352
			// (get) Token: 0x060036EB RID: 14059 RVA: 0x000E204C File Offset: 0x000E024C
			// (set) Token: 0x060036EC RID: 14060 RVA: 0x0001699F File Offset: 0x00014B9F
			public unsafe static Vector3Field.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector3Field.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3Field.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector3Field.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001101 RID: 4353
			// (get) Token: 0x060036ED RID: 14061 RVA: 0x000E2074 File Offset: 0x000E0274
			// (set) Token: 0x060036EE RID: 14062 RVA: 0x000169B1 File Offset: 0x00014BB1
			public unsafe static Func<Vector3, float> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector3Field.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector3Field.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001102 RID: 4354
			// (get) Token: 0x060036EF RID: 14063 RVA: 0x000E209C File Offset: 0x000E029C
			// (set) Token: 0x060036F0 RID: 14064 RVA: 0x000169C3 File Offset: 0x00014BC3
			public unsafe static BaseCompositeField<Vector3, FloatField, float>.FieldDescription.WriteDelegate __9__0_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector3Field.__c.NativeFieldInfoPtr___9__0_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseCompositeField<Vector3, FloatField, float>.FieldDescription.WriteDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector3Field.__c.NativeFieldInfoPtr___9__0_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001103 RID: 4355
			// (get) Token: 0x060036F1 RID: 14065 RVA: 0x000E20C4 File Offset: 0x000E02C4
			// (set) Token: 0x060036F2 RID: 14066 RVA: 0x000169D5 File Offset: 0x00014BD5
			public unsafe static Func<Vector3, float> __9__0_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector3Field.__c.NativeFieldInfoPtr___9__0_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector3Field.__c.NativeFieldInfoPtr___9__0_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001104 RID: 4356
			// (get) Token: 0x060036F3 RID: 14067 RVA: 0x000E20EC File Offset: 0x000E02EC
			// (set) Token: 0x060036F4 RID: 14068 RVA: 0x000169E7 File Offset: 0x00014BE7
			public unsafe static BaseCompositeField<Vector3, FloatField, float>.FieldDescription.WriteDelegate __9__0_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector3Field.__c.NativeFieldInfoPtr___9__0_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseCompositeField<Vector3, FloatField, float>.FieldDescription.WriteDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector3Field.__c.NativeFieldInfoPtr___9__0_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001105 RID: 4357
			// (get) Token: 0x060036F5 RID: 14069 RVA: 0x000E2114 File Offset: 0x000E0314
			// (set) Token: 0x060036F6 RID: 14070 RVA: 0x000169F9 File Offset: 0x00014BF9
			public unsafe static Func<Vector3, float> __9__0_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector3Field.__c.NativeFieldInfoPtr___9__0_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector3Field.__c.NativeFieldInfoPtr___9__0_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001106 RID: 4358
			// (get) Token: 0x060036F7 RID: 14071 RVA: 0x000E213C File Offset: 0x000E033C
			// (set) Token: 0x060036F8 RID: 14072 RVA: 0x00016A0B File Offset: 0x00014C0B
			public unsafe static BaseCompositeField<Vector3, FloatField, float>.FieldDescription.WriteDelegate __9__0_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector3Field.__c.NativeFieldInfoPtr___9__0_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseCompositeField<Vector3, FloatField, float>.FieldDescription.WriteDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector3Field.__c.NativeFieldInfoPtr___9__0_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400273A RID: 10042
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400273B RID: 10043
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x0400273C RID: 10044
			private static readonly IntPtr NativeFieldInfoPtr___9__0_1;

			// Token: 0x0400273D RID: 10045
			private static readonly IntPtr NativeFieldInfoPtr___9__0_2;

			// Token: 0x0400273E RID: 10046
			private static readonly IntPtr NativeFieldInfoPtr___9__0_3;

			// Token: 0x0400273F RID: 10047
			private static readonly IntPtr NativeFieldInfoPtr___9__0_4;

			// Token: 0x04002740 RID: 10048
			private static readonly IntPtr NativeFieldInfoPtr___9__0_5;

			// Token: 0x04002741 RID: 10049
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002742 RID: 10050
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_0_Internal_Single_Vector3_0;

			// Token: 0x04002743 RID: 10051
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_1_Internal_Void_byref_Vector3_Single_0;

			// Token: 0x04002744 RID: 10052
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_2_Internal_Single_Vector3_0;

			// Token: 0x04002745 RID: 10053
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_3_Internal_Void_byref_Vector3_Single_0;

			// Token: 0x04002746 RID: 10054
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_4_Internal_Single_Vector3_0;

			// Token: 0x04002747 RID: 10055
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_5_Internal_Void_byref_Vector3_Single_0;
		}

		// Token: 0x0200035A RID: 858
		[Serializable]
		public new sealed class <>c
		{
		}
	}
}

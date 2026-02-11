using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000050 RID: 80
	public class RectIntField : BaseCompositeField<RectInt, IntegerField, int>
	{
		// Token: 0x060007A2 RID: 1954 RVA: 0x0003883C File Offset: 0x00036A3C
		// Note: this type is marked as 'beforefieldinit'.
		static RectIntField()
		{
			Il2CppClassPointerStore<RectIntField>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "RectIntField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectIntField>.NativeClassPtr);
			RectIntField.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectIntField>.NativeClassPtr, "ussClassName");
			RectIntField.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectIntField>.NativeClassPtr, "labelUssClassName");
			RectIntField.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectIntField>.NativeClassPtr, "inputUssClassName");
			RectIntField.NativeMethodInfoPtr_DescribeFields_Internal_Virtual_Il2CppReferenceArray_1_FieldDescription_RectInt_IntegerField_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectIntField>.NativeClassPtr, 100664346);
			RectIntField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectIntField>.NativeClassPtr, 100664347);
			RectIntField.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectIntField>.NativeClassPtr, 100664348);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x000388E4 File Offset: 0x00036AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292524, XrefRangeEnd = 292663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<BaseCompositeField<RectInt, IntegerField, int>.FieldDescription> DescribeFields()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectIntField.NativeMethodInfoPtr_DescribeFields_Internal_Virtual_Il2CppReferenceArray_1_FieldDescription_RectInt_IntegerField_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BaseCompositeField<RectInt, IntegerField, int>.FieldDescription>>(intPtr3) : null;
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00038930 File Offset: 0x00036B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292663, XrefRangeEnd = 292685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectIntField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectIntField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectIntField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0003896C File Offset: 0x00036B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292685, XrefRangeEnd = 292707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectIntField(string label)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectIntField>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectIntField.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00004A45 File Offset: 0x00002C45
		public RectIntField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x000389B8 File Offset: 0x00036BB8
		// (set) Token: 0x060007A8 RID: 1960 RVA: 0x00004A4E File Offset: 0x00002C4E
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RectIntField.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RectIntField.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x000389D8 File Offset: 0x00036BD8
		// (set) Token: 0x060007AA RID: 1962 RVA: 0x00004A60 File Offset: 0x00002C60
		public new unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RectIntField.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RectIntField.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x000389F8 File Offset: 0x00036BF8
		// (set) Token: 0x060007AC RID: 1964 RVA: 0x00004A72 File Offset: 0x00002C72
		public new unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RectIntField.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RectIntField.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeMethodInfoPtr_DescribeFields_Internal_Virtual_Il2CppReferenceArray_1_FieldDescription_RectInt_IntegerField_Int32_0;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0200034F RID: 847
		public new class UxmlFactory : UxmlFactory<RectIntField, RectIntField.UxmlTraits>
		{
			// Token: 0x0600368D RID: 13965 RVA: 0x0001669F File Offset: 0x0001489F
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<RectIntField.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RectIntField>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectIntField.UxmlFactory>.NativeClassPtr);
				RectIntField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectIntField.UxmlFactory>.NativeClassPtr, 100664350);
			}

			// Token: 0x0600368E RID: 13966 RVA: 0x000E0E14 File Offset: 0x000DF014
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 292485, RefRangeEnd = 292486, XrefRangeStart = 292482, XrefRangeEnd = 292485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectIntField.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectIntField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600368F RID: 13967 RVA: 0x000166D3 File Offset: 0x000148D3
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400270C RID: 9996
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000350 RID: 848
		public new class UxmlTraits : BaseField<RectInt>.UxmlTraits
		{
			// Token: 0x06003690 RID: 13968 RVA: 0x000E0E50 File Offset: 0x000DF050
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<RectIntField.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RectIntField>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectIntField.UxmlTraits>.NativeClassPtr);
				RectIntField.UxmlTraits.NativeFieldInfoPtr_m_XValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectIntField.UxmlTraits>.NativeClassPtr, "m_XValue");
				RectIntField.UxmlTraits.NativeFieldInfoPtr_m_YValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectIntField.UxmlTraits>.NativeClassPtr, "m_YValue");
				RectIntField.UxmlTraits.NativeFieldInfoPtr_m_WValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectIntField.UxmlTraits>.NativeClassPtr, "m_WValue");
				RectIntField.UxmlTraits.NativeFieldInfoPtr_m_HValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectIntField.UxmlTraits>.NativeClassPtr, "m_HValue");
				RectIntField.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectIntField.UxmlTraits>.NativeClassPtr, 100664351);
				RectIntField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectIntField.UxmlTraits>.NativeClassPtr, 100664352);
			}

			// Token: 0x06003691 RID: 13969 RVA: 0x000E0EF4 File Offset: 0x000DF0F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292486, XrefRangeEnd = 292491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectIntField.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003692 RID: 13970 RVA: 0x000E0F6C File Offset: 0x000DF16C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292491, XrefRangeEnd = 292524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectIntField.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectIntField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003693 RID: 13971 RVA: 0x000166DC File Offset: 0x000148DC
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010E9 RID: 4329
			// (get) Token: 0x06003694 RID: 13972 RVA: 0x000E0FA8 File Offset: 0x000DF1A8
			// (set) Token: 0x06003695 RID: 13973 RVA: 0x000166E5 File Offset: 0x000148E5
			public unsafe UxmlIntAttributeDescription m_XValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectIntField.UxmlTraits.NativeFieldInfoPtr_m_XValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlIntAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectIntField.UxmlTraits.NativeFieldInfoPtr_m_XValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010EA RID: 4330
			// (get) Token: 0x06003696 RID: 13974 RVA: 0x000E0FD8 File Offset: 0x000DF1D8
			// (set) Token: 0x06003697 RID: 13975 RVA: 0x00016704 File Offset: 0x00014904
			public unsafe UxmlIntAttributeDescription m_YValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectIntField.UxmlTraits.NativeFieldInfoPtr_m_YValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlIntAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectIntField.UxmlTraits.NativeFieldInfoPtr_m_YValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010EB RID: 4331
			// (get) Token: 0x06003698 RID: 13976 RVA: 0x000E1008 File Offset: 0x000DF208
			// (set) Token: 0x06003699 RID: 13977 RVA: 0x00016723 File Offset: 0x00014923
			public unsafe UxmlIntAttributeDescription m_WValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectIntField.UxmlTraits.NativeFieldInfoPtr_m_WValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlIntAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectIntField.UxmlTraits.NativeFieldInfoPtr_m_WValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010EC RID: 4332
			// (get) Token: 0x0600369A RID: 13978 RVA: 0x000E1038 File Offset: 0x000DF238
			// (set) Token: 0x0600369B RID: 13979 RVA: 0x00016742 File Offset: 0x00014942
			public unsafe UxmlIntAttributeDescription m_HValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectIntField.UxmlTraits.NativeFieldInfoPtr_m_HValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlIntAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectIntField.UxmlTraits.NativeFieldInfoPtr_m_HValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400270D RID: 9997
			private static readonly IntPtr NativeFieldInfoPtr_m_XValue;

			// Token: 0x0400270E RID: 9998
			private static readonly IntPtr NativeFieldInfoPtr_m_YValue;

			// Token: 0x0400270F RID: 9999
			private static readonly IntPtr NativeFieldInfoPtr_m_WValue;

			// Token: 0x04002710 RID: 10000
			private static readonly IntPtr NativeFieldInfoPtr_m_HValue;

			// Token: 0x04002711 RID: 10001
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x04002712 RID: 10002
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000351 RID: 849
		[ObfuscatedName("UnityEngine.UIElements.RectIntField+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600369C RID: 13980 RVA: 0x000E1068 File Offset: 0x000DF268
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RectIntField.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RectIntField>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectIntField.__c>.NativeClassPtr);
				RectIntField.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectIntField.__c>.NativeClassPtr, "<>9");
				RectIntField.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectIntField.__c>.NativeClassPtr, "<>9__0_0");
				RectIntField.__c.NativeFieldInfoPtr___9__0_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectIntField.__c>.NativeClassPtr, "<>9__0_1");
				RectIntField.__c.NativeFieldInfoPtr___9__0_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectIntField.__c>.NativeClassPtr, "<>9__0_2");
				RectIntField.__c.NativeFieldInfoPtr___9__0_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectIntField.__c>.NativeClassPtr, "<>9__0_3");
				RectIntField.__c.NativeFieldInfoPtr___9__0_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectIntField.__c>.NativeClassPtr, "<>9__0_4");
				RectIntField.__c.NativeFieldInfoPtr___9__0_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectIntField.__c>.NativeClassPtr, "<>9__0_5");
				RectIntField.__c.NativeFieldInfoPtr___9__0_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectIntField.__c>.NativeClassPtr, "<>9__0_6");
				RectIntField.__c.NativeFieldInfoPtr___9__0_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectIntField.__c>.NativeClassPtr, "<>9__0_7");
				RectIntField.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectIntField.__c>.NativeClassPtr, 100664354);
				RectIntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_0_Internal_Int32_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectIntField.__c>.NativeClassPtr, 100664355);
				RectIntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_1_Internal_Void_byref_RectInt_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectIntField.__c>.NativeClassPtr, 100664356);
				RectIntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_2_Internal_Int32_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectIntField.__c>.NativeClassPtr, 100664357);
				RectIntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_3_Internal_Void_byref_RectInt_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectIntField.__c>.NativeClassPtr, 100664358);
				RectIntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_4_Internal_Int32_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectIntField.__c>.NativeClassPtr, 100664359);
				RectIntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_5_Internal_Void_byref_RectInt_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectIntField.__c>.NativeClassPtr, 100664360);
				RectIntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_6_Internal_Int32_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectIntField.__c>.NativeClassPtr, 100664361);
				RectIntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_7_Internal_Void_byref_RectInt_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectIntField.__c>.NativeClassPtr, 100664362);
			}

			// Token: 0x0600369D RID: 13981 RVA: 0x000E11FC File Offset: 0x000DF3FC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectIntField.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectIntField.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600369E RID: 13982 RVA: 0x000E1238 File Offset: 0x000DF438
			[CallerCount(0)]
			public unsafe int _DescribeFields_b__0_0(RectInt r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectIntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_0_Internal_Int32_RectInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600369F RID: 13983 RVA: 0x000E1284 File Offset: 0x000DF484
			[CallerCount(0)]
			public unsafe void _DescribeFields_b__0_1(ref RectInt r, int v)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectIntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_1_Internal_Void_byref_RectInt_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036A0 RID: 13984 RVA: 0x000E12D0 File Offset: 0x000DF4D0
			[CallerCount(0)]
			public unsafe int _DescribeFields_b__0_2(RectInt r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectIntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_2_Internal_Int32_RectInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060036A1 RID: 13985 RVA: 0x000E131C File Offset: 0x000DF51C
			[CallerCount(0)]
			public unsafe void _DescribeFields_b__0_3(ref RectInt r, int v)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectIntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_3_Internal_Void_byref_RectInt_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036A2 RID: 13986 RVA: 0x000E1368 File Offset: 0x000DF568
			[CallerCount(0)]
			public unsafe int _DescribeFields_b__0_4(RectInt r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectIntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_4_Internal_Int32_RectInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060036A3 RID: 13987 RVA: 0x000E13B4 File Offset: 0x000DF5B4
			[CallerCount(0)]
			public unsafe void _DescribeFields_b__0_5(ref RectInt r, int v)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectIntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_5_Internal_Void_byref_RectInt_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036A4 RID: 13988 RVA: 0x000E1400 File Offset: 0x000DF600
			[CallerCount(0)]
			public unsafe int _DescribeFields_b__0_6(RectInt r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectIntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_6_Internal_Int32_RectInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060036A5 RID: 13989 RVA: 0x000E144C File Offset: 0x000DF64C
			[CallerCount(0)]
			public unsafe void _DescribeFields_b__0_7(ref RectInt r, int v)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectIntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_7_Internal_Void_byref_RectInt_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036A6 RID: 13990 RVA: 0x00016761 File Offset: 0x00014961
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010ED RID: 4333
			// (get) Token: 0x060036A7 RID: 13991 RVA: 0x000E1498 File Offset: 0x000DF698
			// (set) Token: 0x060036A8 RID: 13992 RVA: 0x0001676A File Offset: 0x0001496A
			public unsafe static RectIntField.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RectIntField.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectIntField.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RectIntField.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010EE RID: 4334
			// (get) Token: 0x060036A9 RID: 13993 RVA: 0x000E14C0 File Offset: 0x000DF6C0
			// (set) Token: 0x060036AA RID: 13994 RVA: 0x0001677C File Offset: 0x0001497C
			public unsafe static Func<RectInt, int> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RectIntField.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RectInt, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RectIntField.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010EF RID: 4335
			// (get) Token: 0x060036AB RID: 13995 RVA: 0x000E14E8 File Offset: 0x000DF6E8
			// (set) Token: 0x060036AC RID: 13996 RVA: 0x0001678E File Offset: 0x0001498E
			public unsafe static BaseCompositeField<RectInt, IntegerField, int>.FieldDescription.WriteDelegate __9__0_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RectIntField.__c.NativeFieldInfoPtr___9__0_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseCompositeField<RectInt, IntegerField, int>.FieldDescription.WriteDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RectIntField.__c.NativeFieldInfoPtr___9__0_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010F0 RID: 4336
			// (get) Token: 0x060036AD RID: 13997 RVA: 0x000E1510 File Offset: 0x000DF710
			// (set) Token: 0x060036AE RID: 13998 RVA: 0x000167A0 File Offset: 0x000149A0
			public unsafe static Func<RectInt, int> __9__0_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RectIntField.__c.NativeFieldInfoPtr___9__0_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RectInt, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RectIntField.__c.NativeFieldInfoPtr___9__0_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010F1 RID: 4337
			// (get) Token: 0x060036AF RID: 13999 RVA: 0x000E1538 File Offset: 0x000DF738
			// (set) Token: 0x060036B0 RID: 14000 RVA: 0x000167B2 File Offset: 0x000149B2
			public unsafe static BaseCompositeField<RectInt, IntegerField, int>.FieldDescription.WriteDelegate __9__0_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RectIntField.__c.NativeFieldInfoPtr___9__0_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseCompositeField<RectInt, IntegerField, int>.FieldDescription.WriteDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RectIntField.__c.NativeFieldInfoPtr___9__0_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010F2 RID: 4338
			// (get) Token: 0x060036B1 RID: 14001 RVA: 0x000E1560 File Offset: 0x000DF760
			// (set) Token: 0x060036B2 RID: 14002 RVA: 0x000167C4 File Offset: 0x000149C4
			public unsafe static Func<RectInt, int> __9__0_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RectIntField.__c.NativeFieldInfoPtr___9__0_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RectInt, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RectIntField.__c.NativeFieldInfoPtr___9__0_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010F3 RID: 4339
			// (get) Token: 0x060036B3 RID: 14003 RVA: 0x000E1588 File Offset: 0x000DF788
			// (set) Token: 0x060036B4 RID: 14004 RVA: 0x000167D6 File Offset: 0x000149D6
			public unsafe static BaseCompositeField<RectInt, IntegerField, int>.FieldDescription.WriteDelegate __9__0_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RectIntField.__c.NativeFieldInfoPtr___9__0_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseCompositeField<RectInt, IntegerField, int>.FieldDescription.WriteDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RectIntField.__c.NativeFieldInfoPtr___9__0_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010F4 RID: 4340
			// (get) Token: 0x060036B5 RID: 14005 RVA: 0x000E15B0 File Offset: 0x000DF7B0
			// (set) Token: 0x060036B6 RID: 14006 RVA: 0x000167E8 File Offset: 0x000149E8
			public unsafe static Func<RectInt, int> __9__0_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RectIntField.__c.NativeFieldInfoPtr___9__0_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RectInt, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RectIntField.__c.NativeFieldInfoPtr___9__0_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010F5 RID: 4341
			// (get) Token: 0x060036B7 RID: 14007 RVA: 0x000E15D8 File Offset: 0x000DF7D8
			// (set) Token: 0x060036B8 RID: 14008 RVA: 0x000167FA File Offset: 0x000149FA
			public unsafe static BaseCompositeField<RectInt, IntegerField, int>.FieldDescription.WriteDelegate __9__0_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RectIntField.__c.NativeFieldInfoPtr___9__0_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseCompositeField<RectInt, IntegerField, int>.FieldDescription.WriteDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RectIntField.__c.NativeFieldInfoPtr___9__0_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002713 RID: 10003
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002714 RID: 10004
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x04002715 RID: 10005
			private static readonly IntPtr NativeFieldInfoPtr___9__0_1;

			// Token: 0x04002716 RID: 10006
			private static readonly IntPtr NativeFieldInfoPtr___9__0_2;

			// Token: 0x04002717 RID: 10007
			private static readonly IntPtr NativeFieldInfoPtr___9__0_3;

			// Token: 0x04002718 RID: 10008
			private static readonly IntPtr NativeFieldInfoPtr___9__0_4;

			// Token: 0x04002719 RID: 10009
			private static readonly IntPtr NativeFieldInfoPtr___9__0_5;

			// Token: 0x0400271A RID: 10010
			private static readonly IntPtr NativeFieldInfoPtr___9__0_6;

			// Token: 0x0400271B RID: 10011
			private static readonly IntPtr NativeFieldInfoPtr___9__0_7;

			// Token: 0x0400271C RID: 10012
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400271D RID: 10013
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_0_Internal_Int32_RectInt_0;

			// Token: 0x0400271E RID: 10014
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_1_Internal_Void_byref_RectInt_Int32_0;

			// Token: 0x0400271F RID: 10015
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_2_Internal_Int32_RectInt_0;

			// Token: 0x04002720 RID: 10016
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_3_Internal_Void_byref_RectInt_Int32_0;

			// Token: 0x04002721 RID: 10017
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_4_Internal_Int32_RectInt_0;

			// Token: 0x04002722 RID: 10018
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_5_Internal_Void_byref_RectInt_Int32_0;

			// Token: 0x04002723 RID: 10019
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_6_Internal_Int32_RectInt_0;

			// Token: 0x04002724 RID: 10020
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_7_Internal_Void_byref_RectInt_Int32_0;
		}

		// Token: 0x02000352 RID: 850
		[Serializable]
		public new sealed class <>c
		{
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000055 RID: 85
	public class Vector3IntField : BaseCompositeField<Vector3Int, IntegerField, int>
	{
		// Token: 0x060007D9 RID: 2009 RVA: 0x00039188 File Offset: 0x00037388
		// Note: this type is marked as 'beforefieldinit'.
		static Vector3IntField()
		{
			Il2CppClassPointerStore<Vector3IntField>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Vector3IntField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3IntField>.NativeClassPtr);
			Vector3IntField.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3IntField>.NativeClassPtr, "ussClassName");
			Vector3IntField.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3IntField>.NativeClassPtr, "labelUssClassName");
			Vector3IntField.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3IntField>.NativeClassPtr, "inputUssClassName");
			Vector3IntField.NativeMethodInfoPtr_DescribeFields_Internal_Virtual_Il2CppReferenceArray_1_FieldDescription_Vector3Int_IntegerField_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3IntField>.NativeClassPtr, 100664421);
			Vector3IntField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3IntField>.NativeClassPtr, 100664422);
			Vector3IntField.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3IntField>.NativeClassPtr, 100664423);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00039230 File Offset: 0x00037430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293450, XrefRangeEnd = 293556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<BaseCompositeField<Vector3Int, IntegerField, int>.FieldDescription> DescribeFields()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector3IntField.NativeMethodInfoPtr_DescribeFields_Internal_Virtual_Il2CppReferenceArray_1_FieldDescription_Vector3Int_IntegerField_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BaseCompositeField<Vector3Int, IntegerField, int>.FieldDescription>>(intPtr3) : null;
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x0003927C File Offset: 0x0003747C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293556, XrefRangeEnd = 293557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3IntField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector3IntField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3IntField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x000392B8 File Offset: 0x000374B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 293577, RefRangeEnd = 293580, XrefRangeStart = 293557, XrefRangeEnd = 293577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3IntField(string label)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector3IntField>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3IntField.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00004B80 File Offset: 0x00002D80
		public Vector3IntField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x00039304 File Offset: 0x00037504
		// (set) Token: 0x060007DF RID: 2015 RVA: 0x00004B89 File Offset: 0x00002D89
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Vector3IntField.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3IntField.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x00039324 File Offset: 0x00037524
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x00004B9B File Offset: 0x00002D9B
		public new unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Vector3IntField.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3IntField.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x00039344 File Offset: 0x00037544
		// (set) Token: 0x060007E3 RID: 2019 RVA: 0x00004BAD File Offset: 0x00002DAD
		public new unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Vector3IntField.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3IntField.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeMethodInfoPtr_DescribeFields_Internal_Virtual_Il2CppReferenceArray_1_FieldDescription_Vector3Int_IntegerField_Int32_0;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x02000363 RID: 867
		public new class UxmlFactory : UxmlFactory<Vector3IntField, Vector3IntField.UxmlTraits>
		{
			// Token: 0x06003741 RID: 14145 RVA: 0x00016C71 File Offset: 0x00014E71
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<Vector3IntField.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector3IntField>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3IntField.UxmlFactory>.NativeClassPtr);
				Vector3IntField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3IntField.UxmlFactory>.NativeClassPtr, 100664425);
			}

			// Token: 0x06003742 RID: 14146 RVA: 0x000E2E44 File Offset: 0x000E1044
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 293418, RefRangeEnd = 293419, XrefRangeStart = 293415, XrefRangeEnd = 293418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector3IntField.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3IntField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003743 RID: 14147 RVA: 0x00016CA5 File Offset: 0x00014EA5
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002770 RID: 10096
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000364 RID: 868
		public new class UxmlTraits : BaseField<Vector3Int>.UxmlTraits
		{
			// Token: 0x06003744 RID: 14148 RVA: 0x000E2E80 File Offset: 0x000E1080
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<Vector3IntField.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector3IntField>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3IntField.UxmlTraits>.NativeClassPtr);
				Vector3IntField.UxmlTraits.NativeFieldInfoPtr_m_XValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3IntField.UxmlTraits>.NativeClassPtr, "m_XValue");
				Vector3IntField.UxmlTraits.NativeFieldInfoPtr_m_YValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3IntField.UxmlTraits>.NativeClassPtr, "m_YValue");
				Vector3IntField.UxmlTraits.NativeFieldInfoPtr_m_ZValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3IntField.UxmlTraits>.NativeClassPtr, "m_ZValue");
				Vector3IntField.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3IntField.UxmlTraits>.NativeClassPtr, 100664426);
				Vector3IntField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3IntField.UxmlTraits>.NativeClassPtr, 100664427);
			}

			// Token: 0x06003745 RID: 14149 RVA: 0x000E2F10 File Offset: 0x000E1110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293419, XrefRangeEnd = 293424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector3IntField.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003746 RID: 14150 RVA: 0x000E2F88 File Offset: 0x000E1188
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293424, XrefRangeEnd = 293450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector3IntField.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3IntField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003747 RID: 14151 RVA: 0x00016CAE File Offset: 0x00014EAE
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700111B RID: 4379
			// (get) Token: 0x06003748 RID: 14152 RVA: 0x000E2FC4 File Offset: 0x000E11C4
			// (set) Token: 0x06003749 RID: 14153 RVA: 0x00016CB7 File Offset: 0x00014EB7
			public unsafe UxmlIntAttributeDescription m_XValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3IntField.UxmlTraits.NativeFieldInfoPtr_m_XValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlIntAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3IntField.UxmlTraits.NativeFieldInfoPtr_m_XValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700111C RID: 4380
			// (get) Token: 0x0600374A RID: 14154 RVA: 0x000E2FF4 File Offset: 0x000E11F4
			// (set) Token: 0x0600374B RID: 14155 RVA: 0x00016CD6 File Offset: 0x00014ED6
			public unsafe UxmlIntAttributeDescription m_YValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3IntField.UxmlTraits.NativeFieldInfoPtr_m_YValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlIntAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3IntField.UxmlTraits.NativeFieldInfoPtr_m_YValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700111D RID: 4381
			// (get) Token: 0x0600374C RID: 14156 RVA: 0x000E3024 File Offset: 0x000E1224
			// (set) Token: 0x0600374D RID: 14157 RVA: 0x00016CF5 File Offset: 0x00014EF5
			public unsafe UxmlIntAttributeDescription m_ZValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3IntField.UxmlTraits.NativeFieldInfoPtr_m_ZValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlIntAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector3IntField.UxmlTraits.NativeFieldInfoPtr_m_ZValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002771 RID: 10097
			private static readonly IntPtr NativeFieldInfoPtr_m_XValue;

			// Token: 0x04002772 RID: 10098
			private static readonly IntPtr NativeFieldInfoPtr_m_YValue;

			// Token: 0x04002773 RID: 10099
			private static readonly IntPtr NativeFieldInfoPtr_m_ZValue;

			// Token: 0x04002774 RID: 10100
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x04002775 RID: 10101
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000365 RID: 869
		[ObfuscatedName("UnityEngine.UIElements.Vector3IntField+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600374E RID: 14158 RVA: 0x000E3054 File Offset: 0x000E1254
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Vector3IntField.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector3IntField>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3IntField.__c>.NativeClassPtr);
				Vector3IntField.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3IntField.__c>.NativeClassPtr, "<>9");
				Vector3IntField.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3IntField.__c>.NativeClassPtr, "<>9__0_0");
				Vector3IntField.__c.NativeFieldInfoPtr___9__0_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3IntField.__c>.NativeClassPtr, "<>9__0_1");
				Vector3IntField.__c.NativeFieldInfoPtr___9__0_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3IntField.__c>.NativeClassPtr, "<>9__0_2");
				Vector3IntField.__c.NativeFieldInfoPtr___9__0_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3IntField.__c>.NativeClassPtr, "<>9__0_3");
				Vector3IntField.__c.NativeFieldInfoPtr___9__0_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3IntField.__c>.NativeClassPtr, "<>9__0_4");
				Vector3IntField.__c.NativeFieldInfoPtr___9__0_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3IntField.__c>.NativeClassPtr, "<>9__0_5");
				Vector3IntField.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3IntField.__c>.NativeClassPtr, 100664429);
				Vector3IntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_0_Internal_Int32_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3IntField.__c>.NativeClassPtr, 100664430);
				Vector3IntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_1_Internal_Void_byref_Vector3Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3IntField.__c>.NativeClassPtr, 100664431);
				Vector3IntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_2_Internal_Int32_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3IntField.__c>.NativeClassPtr, 100664432);
				Vector3IntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_3_Internal_Void_byref_Vector3Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3IntField.__c>.NativeClassPtr, 100664433);
				Vector3IntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_4_Internal_Int32_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3IntField.__c>.NativeClassPtr, 100664434);
				Vector3IntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_5_Internal_Void_byref_Vector3Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3IntField.__c>.NativeClassPtr, 100664435);
			}

			// Token: 0x0600374F RID: 14159 RVA: 0x000E3198 File Offset: 0x000E1398
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector3IntField.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3IntField.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003750 RID: 14160 RVA: 0x000E31D4 File Offset: 0x000E13D4
			[CallerCount(0)]
			public unsafe int _DescribeFields_b__0_0(Vector3Int r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3IntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_0_Internal_Int32_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003751 RID: 14161 RVA: 0x000E3220 File Offset: 0x000E1420
			[CallerCount(0)]
			public unsafe void _DescribeFields_b__0_1(ref Vector3Int r, int v)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3IntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_1_Internal_Void_byref_Vector3Int_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003752 RID: 14162 RVA: 0x000E326C File Offset: 0x000E146C
			[CallerCount(0)]
			public unsafe int _DescribeFields_b__0_2(Vector3Int r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3IntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_2_Internal_Int32_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003753 RID: 14163 RVA: 0x000E32B8 File Offset: 0x000E14B8
			[CallerCount(0)]
			public unsafe void _DescribeFields_b__0_3(ref Vector3Int r, int v)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3IntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_3_Internal_Void_byref_Vector3Int_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003754 RID: 14164 RVA: 0x000E3304 File Offset: 0x000E1504
			[CallerCount(0)]
			public unsafe int _DescribeFields_b__0_4(Vector3Int r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3IntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_4_Internal_Int32_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003755 RID: 14165 RVA: 0x000E3350 File Offset: 0x000E1550
			[CallerCount(0)]
			public unsafe void _DescribeFields_b__0_5(ref Vector3Int r, int v)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3IntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_5_Internal_Void_byref_Vector3Int_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003756 RID: 14166 RVA: 0x00016D14 File Offset: 0x00014F14
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700111E RID: 4382
			// (get) Token: 0x06003757 RID: 14167 RVA: 0x000E339C File Offset: 0x000E159C
			// (set) Token: 0x06003758 RID: 14168 RVA: 0x00016D1D File Offset: 0x00014F1D
			public unsafe static Vector3IntField.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector3IntField.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3IntField.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector3IntField.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700111F RID: 4383
			// (get) Token: 0x06003759 RID: 14169 RVA: 0x000E33C4 File Offset: 0x000E15C4
			// (set) Token: 0x0600375A RID: 14170 RVA: 0x00016D2F File Offset: 0x00014F2F
			public unsafe static Func<Vector3Int, int> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector3IntField.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3Int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector3IntField.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001120 RID: 4384
			// (get) Token: 0x0600375B RID: 14171 RVA: 0x000E33EC File Offset: 0x000E15EC
			// (set) Token: 0x0600375C RID: 14172 RVA: 0x00016D41 File Offset: 0x00014F41
			public unsafe static BaseCompositeField<Vector3Int, IntegerField, int>.FieldDescription.WriteDelegate __9__0_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector3IntField.__c.NativeFieldInfoPtr___9__0_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseCompositeField<Vector3Int, IntegerField, int>.FieldDescription.WriteDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector3IntField.__c.NativeFieldInfoPtr___9__0_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001121 RID: 4385
			// (get) Token: 0x0600375D RID: 14173 RVA: 0x000E3414 File Offset: 0x000E1614
			// (set) Token: 0x0600375E RID: 14174 RVA: 0x00016D53 File Offset: 0x00014F53
			public unsafe static Func<Vector3Int, int> __9__0_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector3IntField.__c.NativeFieldInfoPtr___9__0_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3Int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector3IntField.__c.NativeFieldInfoPtr___9__0_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001122 RID: 4386
			// (get) Token: 0x0600375F RID: 14175 RVA: 0x000E343C File Offset: 0x000E163C
			// (set) Token: 0x06003760 RID: 14176 RVA: 0x00016D65 File Offset: 0x00014F65
			public unsafe static BaseCompositeField<Vector3Int, IntegerField, int>.FieldDescription.WriteDelegate __9__0_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector3IntField.__c.NativeFieldInfoPtr___9__0_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseCompositeField<Vector3Int, IntegerField, int>.FieldDescription.WriteDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector3IntField.__c.NativeFieldInfoPtr___9__0_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001123 RID: 4387
			// (get) Token: 0x06003761 RID: 14177 RVA: 0x000E3464 File Offset: 0x000E1664
			// (set) Token: 0x06003762 RID: 14178 RVA: 0x00016D77 File Offset: 0x00014F77
			public unsafe static Func<Vector3Int, int> __9__0_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector3IntField.__c.NativeFieldInfoPtr___9__0_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3Int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector3IntField.__c.NativeFieldInfoPtr___9__0_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001124 RID: 4388
			// (get) Token: 0x06003763 RID: 14179 RVA: 0x000E348C File Offset: 0x000E168C
			// (set) Token: 0x06003764 RID: 14180 RVA: 0x00016D89 File Offset: 0x00014F89
			public unsafe static BaseCompositeField<Vector3Int, IntegerField, int>.FieldDescription.WriteDelegate __9__0_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector3IntField.__c.NativeFieldInfoPtr___9__0_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseCompositeField<Vector3Int, IntegerField, int>.FieldDescription.WriteDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector3IntField.__c.NativeFieldInfoPtr___9__0_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002776 RID: 10102
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002777 RID: 10103
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x04002778 RID: 10104
			private static readonly IntPtr NativeFieldInfoPtr___9__0_1;

			// Token: 0x04002779 RID: 10105
			private static readonly IntPtr NativeFieldInfoPtr___9__0_2;

			// Token: 0x0400277A RID: 10106
			private static readonly IntPtr NativeFieldInfoPtr___9__0_3;

			// Token: 0x0400277B RID: 10107
			private static readonly IntPtr NativeFieldInfoPtr___9__0_4;

			// Token: 0x0400277C RID: 10108
			private static readonly IntPtr NativeFieldInfoPtr___9__0_5;

			// Token: 0x0400277D RID: 10109
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400277E RID: 10110
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_0_Internal_Int32_Vector3Int_0;

			// Token: 0x0400277F RID: 10111
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_1_Internal_Void_byref_Vector3Int_Int32_0;

			// Token: 0x04002780 RID: 10112
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_2_Internal_Int32_Vector3Int_0;

			// Token: 0x04002781 RID: 10113
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_3_Internal_Void_byref_Vector3Int_Int32_0;

			// Token: 0x04002782 RID: 10114
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_4_Internal_Int32_Vector3Int_0;

			// Token: 0x04002783 RID: 10115
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_5_Internal_Void_byref_Vector3Int_Int32_0;
		}

		// Token: 0x02000366 RID: 870
		[Serializable]
		public new sealed class <>c
		{
		}
	}
}

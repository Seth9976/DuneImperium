using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200004F RID: 79
	public class RectField : BaseCompositeField<Rect, FloatField, float>
	{
		// Token: 0x06000797 RID: 1943 RVA: 0x00038660 File Offset: 0x00036860
		// Note: this type is marked as 'beforefieldinit'.
		static RectField()
		{
			Il2CppClassPointerStore<RectField>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "RectField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectField>.NativeClassPtr);
			RectField.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectField>.NativeClassPtr, "ussClassName");
			RectField.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectField>.NativeClassPtr, "labelUssClassName");
			RectField.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectField>.NativeClassPtr, "inputUssClassName");
			RectField.NativeMethodInfoPtr_DescribeFields_Internal_Virtual_Il2CppReferenceArray_1_FieldDescription_Rect_FloatField_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectField>.NativeClassPtr, 100664329);
			RectField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectField>.NativeClassPtr, 100664330);
			RectField.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectField>.NativeClassPtr, 100664331);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00038708 File Offset: 0x00036908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292299, XrefRangeEnd = 292438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<BaseCompositeField<Rect, FloatField, float>.FieldDescription> DescribeFields()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectField.NativeMethodInfoPtr_DescribeFields_Internal_Virtual_Il2CppReferenceArray_1_FieldDescription_Rect_FloatField_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BaseCompositeField<Rect, FloatField, float>.FieldDescription>>(intPtr3) : null;
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00038754 File Offset: 0x00036954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292438, XrefRangeEnd = 292460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00038790 File Offset: 0x00036990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292460, XrefRangeEnd = 292482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectField(string label)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectField>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectField.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00004A06 File Offset: 0x00002C06
		public RectField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x000387DC File Offset: 0x000369DC
		// (set) Token: 0x0600079D RID: 1949 RVA: 0x00004A0F File Offset: 0x00002C0F
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RectField.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RectField.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x000387FC File Offset: 0x000369FC
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x00004A21 File Offset: 0x00002C21
		public new unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RectField.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RectField.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x0003881C File Offset: 0x00036A1C
		// (set) Token: 0x060007A1 RID: 1953 RVA: 0x00004A33 File Offset: 0x00002C33
		public new unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RectField.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RectField.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr_DescribeFields_Internal_Virtual_Il2CppReferenceArray_1_FieldDescription_Rect_FloatField_Single_0;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0200034B RID: 843
		public new class UxmlFactory : UxmlFactory<RectField, RectField.UxmlTraits>
		{
			// Token: 0x06003661 RID: 13921 RVA: 0x00016532 File Offset: 0x00014732
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<RectField.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RectField>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectField.UxmlFactory>.NativeClassPtr);
				RectField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectField.UxmlFactory>.NativeClassPtr, 100664333);
			}

			// Token: 0x06003662 RID: 13922 RVA: 0x000E0628 File Offset: 0x000DE828
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 292260, RefRangeEnd = 292261, XrefRangeStart = 292257, XrefRangeEnd = 292260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectField.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003663 RID: 13923 RVA: 0x00016566 File Offset: 0x00014766
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040026F3 RID: 9971
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200034C RID: 844
		public new class UxmlTraits : BaseField<Rect>.UxmlTraits
		{
			// Token: 0x06003664 RID: 13924 RVA: 0x000E0664 File Offset: 0x000DE864
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<RectField.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RectField>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectField.UxmlTraits>.NativeClassPtr);
				RectField.UxmlTraits.NativeFieldInfoPtr_m_XValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectField.UxmlTraits>.NativeClassPtr, "m_XValue");
				RectField.UxmlTraits.NativeFieldInfoPtr_m_YValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectField.UxmlTraits>.NativeClassPtr, "m_YValue");
				RectField.UxmlTraits.NativeFieldInfoPtr_m_WValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectField.UxmlTraits>.NativeClassPtr, "m_WValue");
				RectField.UxmlTraits.NativeFieldInfoPtr_m_HValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectField.UxmlTraits>.NativeClassPtr, "m_HValue");
				RectField.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectField.UxmlTraits>.NativeClassPtr, 100664334);
				RectField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectField.UxmlTraits>.NativeClassPtr, 100664335);
			}

			// Token: 0x06003665 RID: 13925 RVA: 0x000E0708 File Offset: 0x000DE908
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292261, XrefRangeEnd = 292266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectField.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003666 RID: 13926 RVA: 0x000E0780 File Offset: 0x000DE980
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292266, XrefRangeEnd = 292299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectField.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003667 RID: 13927 RVA: 0x0001656F File Offset: 0x0001476F
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010DC RID: 4316
			// (get) Token: 0x06003668 RID: 13928 RVA: 0x000E07BC File Offset: 0x000DE9BC
			// (set) Token: 0x06003669 RID: 13929 RVA: 0x00016578 File Offset: 0x00014778
			public unsafe UxmlFloatAttributeDescription m_XValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectField.UxmlTraits.NativeFieldInfoPtr_m_XValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectField.UxmlTraits.NativeFieldInfoPtr_m_XValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010DD RID: 4317
			// (get) Token: 0x0600366A RID: 13930 RVA: 0x000E07EC File Offset: 0x000DE9EC
			// (set) Token: 0x0600366B RID: 13931 RVA: 0x00016597 File Offset: 0x00014797
			public unsafe UxmlFloatAttributeDescription m_YValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectField.UxmlTraits.NativeFieldInfoPtr_m_YValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectField.UxmlTraits.NativeFieldInfoPtr_m_YValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010DE RID: 4318
			// (get) Token: 0x0600366C RID: 13932 RVA: 0x000E081C File Offset: 0x000DEA1C
			// (set) Token: 0x0600366D RID: 13933 RVA: 0x000165B6 File Offset: 0x000147B6
			public unsafe UxmlFloatAttributeDescription m_WValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectField.UxmlTraits.NativeFieldInfoPtr_m_WValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectField.UxmlTraits.NativeFieldInfoPtr_m_WValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010DF RID: 4319
			// (get) Token: 0x0600366E RID: 13934 RVA: 0x000E084C File Offset: 0x000DEA4C
			// (set) Token: 0x0600366F RID: 13935 RVA: 0x000165D5 File Offset: 0x000147D5
			public unsafe UxmlFloatAttributeDescription m_HValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectField.UxmlTraits.NativeFieldInfoPtr_m_HValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectField.UxmlTraits.NativeFieldInfoPtr_m_HValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040026F4 RID: 9972
			private static readonly IntPtr NativeFieldInfoPtr_m_XValue;

			// Token: 0x040026F5 RID: 9973
			private static readonly IntPtr NativeFieldInfoPtr_m_YValue;

			// Token: 0x040026F6 RID: 9974
			private static readonly IntPtr NativeFieldInfoPtr_m_WValue;

			// Token: 0x040026F7 RID: 9975
			private static readonly IntPtr NativeFieldInfoPtr_m_HValue;

			// Token: 0x040026F8 RID: 9976
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x040026F9 RID: 9977
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200034D RID: 845
		[ObfuscatedName("UnityEngine.UIElements.RectField+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003670 RID: 13936 RVA: 0x000E087C File Offset: 0x000DEA7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RectField.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RectField>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectField.__c>.NativeClassPtr);
				RectField.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectField.__c>.NativeClassPtr, "<>9");
				RectField.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectField.__c>.NativeClassPtr, "<>9__0_0");
				RectField.__c.NativeFieldInfoPtr___9__0_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectField.__c>.NativeClassPtr, "<>9__0_1");
				RectField.__c.NativeFieldInfoPtr___9__0_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectField.__c>.NativeClassPtr, "<>9__0_2");
				RectField.__c.NativeFieldInfoPtr___9__0_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectField.__c>.NativeClassPtr, "<>9__0_3");
				RectField.__c.NativeFieldInfoPtr___9__0_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectField.__c>.NativeClassPtr, "<>9__0_4");
				RectField.__c.NativeFieldInfoPtr___9__0_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectField.__c>.NativeClassPtr, "<>9__0_5");
				RectField.__c.NativeFieldInfoPtr___9__0_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectField.__c>.NativeClassPtr, "<>9__0_6");
				RectField.__c.NativeFieldInfoPtr___9__0_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectField.__c>.NativeClassPtr, "<>9__0_7");
				RectField.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectField.__c>.NativeClassPtr, 100664337);
				RectField.__c.NativeMethodInfoPtr__DescribeFields_b__0_0_Internal_Single_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectField.__c>.NativeClassPtr, 100664338);
				RectField.__c.NativeMethodInfoPtr__DescribeFields_b__0_1_Internal_Void_byref_Rect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectField.__c>.NativeClassPtr, 100664339);
				RectField.__c.NativeMethodInfoPtr__DescribeFields_b__0_2_Internal_Single_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectField.__c>.NativeClassPtr, 100664340);
				RectField.__c.NativeMethodInfoPtr__DescribeFields_b__0_3_Internal_Void_byref_Rect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectField.__c>.NativeClassPtr, 100664341);
				RectField.__c.NativeMethodInfoPtr__DescribeFields_b__0_4_Internal_Single_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectField.__c>.NativeClassPtr, 100664342);
				RectField.__c.NativeMethodInfoPtr__DescribeFields_b__0_5_Internal_Void_byref_Rect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectField.__c>.NativeClassPtr, 100664343);
				RectField.__c.NativeMethodInfoPtr__DescribeFields_b__0_6_Internal_Single_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectField.__c>.NativeClassPtr, 100664344);
				RectField.__c.NativeMethodInfoPtr__DescribeFields_b__0_7_Internal_Void_byref_Rect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectField.__c>.NativeClassPtr, 100664345);
			}

			// Token: 0x06003671 RID: 13937 RVA: 0x000E0A10 File Offset: 0x000DEC10
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectField.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectField.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003672 RID: 13938 RVA: 0x000E0A4C File Offset: 0x000DEC4C
			[CallerCount(0)]
			public unsafe float _DescribeFields_b__0_0(Rect r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectField.__c.NativeMethodInfoPtr__DescribeFields_b__0_0_Internal_Single_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003673 RID: 13939 RVA: 0x000E0A98 File Offset: 0x000DEC98
			[CallerCount(0)]
			public unsafe void _DescribeFields_b__0_1(ref Rect r, float v)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectField.__c.NativeMethodInfoPtr__DescribeFields_b__0_1_Internal_Void_byref_Rect_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003674 RID: 13940 RVA: 0x000E0AE4 File Offset: 0x000DECE4
			[CallerCount(0)]
			public unsafe float _DescribeFields_b__0_2(Rect r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectField.__c.NativeMethodInfoPtr__DescribeFields_b__0_2_Internal_Single_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003675 RID: 13941 RVA: 0x000E0B30 File Offset: 0x000DED30
			[CallerCount(0)]
			public unsafe void _DescribeFields_b__0_3(ref Rect r, float v)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectField.__c.NativeMethodInfoPtr__DescribeFields_b__0_3_Internal_Void_byref_Rect_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003676 RID: 13942 RVA: 0x000E0B7C File Offset: 0x000DED7C
			[CallerCount(0)]
			public unsafe float _DescribeFields_b__0_4(Rect r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectField.__c.NativeMethodInfoPtr__DescribeFields_b__0_4_Internal_Single_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003677 RID: 13943 RVA: 0x000E0BC8 File Offset: 0x000DEDC8
			[CallerCount(0)]
			public unsafe void _DescribeFields_b__0_5(ref Rect r, float v)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectField.__c.NativeMethodInfoPtr__DescribeFields_b__0_5_Internal_Void_byref_Rect_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003678 RID: 13944 RVA: 0x000E0C14 File Offset: 0x000DEE14
			[CallerCount(0)]
			public unsafe float _DescribeFields_b__0_6(Rect r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectField.__c.NativeMethodInfoPtr__DescribeFields_b__0_6_Internal_Single_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003679 RID: 13945 RVA: 0x000E0C60 File Offset: 0x000DEE60
			[CallerCount(0)]
			public unsafe void _DescribeFields_b__0_7(ref Rect r, float v)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectField.__c.NativeMethodInfoPtr__DescribeFields_b__0_7_Internal_Void_byref_Rect_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600367A RID: 13946 RVA: 0x000165F4 File Offset: 0x000147F4
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010E0 RID: 4320
			// (get) Token: 0x0600367B RID: 13947 RVA: 0x000E0CAC File Offset: 0x000DEEAC
			// (set) Token: 0x0600367C RID: 13948 RVA: 0x000165FD File Offset: 0x000147FD
			public unsafe static RectField.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RectField.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectField.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RectField.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010E1 RID: 4321
			// (get) Token: 0x0600367D RID: 13949 RVA: 0x000E0CD4 File Offset: 0x000DEED4
			// (set) Token: 0x0600367E RID: 13950 RVA: 0x0001660F File Offset: 0x0001480F
			public unsafe static Func<Rect, float> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RectField.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Rect, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RectField.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010E2 RID: 4322
			// (get) Token: 0x0600367F RID: 13951 RVA: 0x000E0CFC File Offset: 0x000DEEFC
			// (set) Token: 0x06003680 RID: 13952 RVA: 0x00016621 File Offset: 0x00014821
			public unsafe static BaseCompositeField<Rect, FloatField, float>.FieldDescription.WriteDelegate __9__0_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RectField.__c.NativeFieldInfoPtr___9__0_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseCompositeField<Rect, FloatField, float>.FieldDescription.WriteDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RectField.__c.NativeFieldInfoPtr___9__0_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010E3 RID: 4323
			// (get) Token: 0x06003681 RID: 13953 RVA: 0x000E0D24 File Offset: 0x000DEF24
			// (set) Token: 0x06003682 RID: 13954 RVA: 0x00016633 File Offset: 0x00014833
			public unsafe static Func<Rect, float> __9__0_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RectField.__c.NativeFieldInfoPtr___9__0_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Rect, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RectField.__c.NativeFieldInfoPtr___9__0_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010E4 RID: 4324
			// (get) Token: 0x06003683 RID: 13955 RVA: 0x000E0D4C File Offset: 0x000DEF4C
			// (set) Token: 0x06003684 RID: 13956 RVA: 0x00016645 File Offset: 0x00014845
			public unsafe static BaseCompositeField<Rect, FloatField, float>.FieldDescription.WriteDelegate __9__0_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RectField.__c.NativeFieldInfoPtr___9__0_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseCompositeField<Rect, FloatField, float>.FieldDescription.WriteDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RectField.__c.NativeFieldInfoPtr___9__0_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010E5 RID: 4325
			// (get) Token: 0x06003685 RID: 13957 RVA: 0x000E0D74 File Offset: 0x000DEF74
			// (set) Token: 0x06003686 RID: 13958 RVA: 0x00016657 File Offset: 0x00014857
			public unsafe static Func<Rect, float> __9__0_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RectField.__c.NativeFieldInfoPtr___9__0_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Rect, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RectField.__c.NativeFieldInfoPtr___9__0_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010E6 RID: 4326
			// (get) Token: 0x06003687 RID: 13959 RVA: 0x000E0D9C File Offset: 0x000DEF9C
			// (set) Token: 0x06003688 RID: 13960 RVA: 0x00016669 File Offset: 0x00014869
			public unsafe static BaseCompositeField<Rect, FloatField, float>.FieldDescription.WriteDelegate __9__0_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RectField.__c.NativeFieldInfoPtr___9__0_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseCompositeField<Rect, FloatField, float>.FieldDescription.WriteDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RectField.__c.NativeFieldInfoPtr___9__0_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010E7 RID: 4327
			// (get) Token: 0x06003689 RID: 13961 RVA: 0x000E0DC4 File Offset: 0x000DEFC4
			// (set) Token: 0x0600368A RID: 13962 RVA: 0x0001667B File Offset: 0x0001487B
			public unsafe static Func<Rect, float> __9__0_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RectField.__c.NativeFieldInfoPtr___9__0_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Rect, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RectField.__c.NativeFieldInfoPtr___9__0_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010E8 RID: 4328
			// (get) Token: 0x0600368B RID: 13963 RVA: 0x000E0DEC File Offset: 0x000DEFEC
			// (set) Token: 0x0600368C RID: 13964 RVA: 0x0001668D File Offset: 0x0001488D
			public unsafe static BaseCompositeField<Rect, FloatField, float>.FieldDescription.WriteDelegate __9__0_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RectField.__c.NativeFieldInfoPtr___9__0_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseCompositeField<Rect, FloatField, float>.FieldDescription.WriteDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RectField.__c.NativeFieldInfoPtr___9__0_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040026FA RID: 9978
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040026FB RID: 9979
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x040026FC RID: 9980
			private static readonly IntPtr NativeFieldInfoPtr___9__0_1;

			// Token: 0x040026FD RID: 9981
			private static readonly IntPtr NativeFieldInfoPtr___9__0_2;

			// Token: 0x040026FE RID: 9982
			private static readonly IntPtr NativeFieldInfoPtr___9__0_3;

			// Token: 0x040026FF RID: 9983
			private static readonly IntPtr NativeFieldInfoPtr___9__0_4;

			// Token: 0x04002700 RID: 9984
			private static readonly IntPtr NativeFieldInfoPtr___9__0_5;

			// Token: 0x04002701 RID: 9985
			private static readonly IntPtr NativeFieldInfoPtr___9__0_6;

			// Token: 0x04002702 RID: 9986
			private static readonly IntPtr NativeFieldInfoPtr___9__0_7;

			// Token: 0x04002703 RID: 9987
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002704 RID: 9988
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_0_Internal_Single_Rect_0;

			// Token: 0x04002705 RID: 9989
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_1_Internal_Void_byref_Rect_Single_0;

			// Token: 0x04002706 RID: 9990
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_2_Internal_Single_Rect_0;

			// Token: 0x04002707 RID: 9991
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_3_Internal_Void_byref_Rect_Single_0;

			// Token: 0x04002708 RID: 9992
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_4_Internal_Single_Rect_0;

			// Token: 0x04002709 RID: 9993
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_5_Internal_Void_byref_Rect_Single_0;

			// Token: 0x0400270A RID: 9994
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_6_Internal_Single_Rect_0;

			// Token: 0x0400270B RID: 9995
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_7_Internal_Void_byref_Rect_Single_0;
		}

		// Token: 0x0200034E RID: 846
		[Serializable]
		public new sealed class <>c
		{
		}
	}
}

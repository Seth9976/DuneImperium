using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000053 RID: 83
	public class Vector4Field : BaseCompositeField<Vector4, FloatField, float>
	{
		// Token: 0x060007C3 RID: 1987 RVA: 0x00038DD0 File Offset: 0x00036FD0
		// Note: this type is marked as 'beforefieldinit'.
		static Vector4Field()
		{
			Il2CppClassPointerStore<Vector4Field>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Vector4Field");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector4Field>.NativeClassPtr);
			Vector4Field.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4Field>.NativeClassPtr, "ussClassName");
			Vector4Field.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4Field>.NativeClassPtr, "labelUssClassName");
			Vector4Field.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4Field>.NativeClassPtr, "inputUssClassName");
			Vector4Field.NativeMethodInfoPtr_DescribeFields_Internal_Virtual_Il2CppReferenceArray_1_FieldDescription_Vector4_FloatField_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4Field>.NativeClassPtr, 100664391);
			Vector4Field.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4Field>.NativeClassPtr, 100664392);
			Vector4Field.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4Field>.NativeClassPtr, 100664393);
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00038E78 File Offset: 0x00037078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293057, XrefRangeEnd = 293196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<BaseCompositeField<Vector4, FloatField, float>.FieldDescription> DescribeFields()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector4Field.NativeMethodInfoPtr_DescribeFields_Internal_Virtual_Il2CppReferenceArray_1_FieldDescription_Vector4_FloatField_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BaseCompositeField<Vector4, FloatField, float>.FieldDescription>>(intPtr3) : null;
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00038EC4 File Offset: 0x000370C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293196, XrefRangeEnd = 293216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4Field()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector4Field>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4Field.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00038F00 File Offset: 0x00037100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293216, XrefRangeEnd = 293267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4Field(string label)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector4Field>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4Field.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00004B02 File Offset: 0x00002D02
		public Vector4Field(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x00038F4C File Offset: 0x0003714C
		// (set) Token: 0x060007C9 RID: 1993 RVA: 0x00004B0B File Offset: 0x00002D0B
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Vector4Field.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector4Field.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x00038F6C File Offset: 0x0003716C
		// (set) Token: 0x060007CB RID: 1995 RVA: 0x00004B1D File Offset: 0x00002D1D
		public new unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Vector4Field.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector4Field.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x00038F8C File Offset: 0x0003718C
		// (set) Token: 0x060007CD RID: 1997 RVA: 0x00004B2F File Offset: 0x00002D2F
		public new unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Vector4Field.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector4Field.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr_DescribeFields_Internal_Virtual_Il2CppReferenceArray_1_FieldDescription_Vector4_FloatField_Single_0;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0200035B RID: 859
		public new class UxmlFactory : UxmlFactory<Vector4Field, Vector4Field.UxmlTraits>
		{
			// Token: 0x060036F9 RID: 14073 RVA: 0x00016A1D File Offset: 0x00014C1D
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<Vector4Field.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector4Field>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector4Field.UxmlFactory>.NativeClassPtr);
				Vector4Field.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4Field.UxmlFactory>.NativeClassPtr, 100664395);
			}

			// Token: 0x060036FA RID: 14074 RVA: 0x000E2164 File Offset: 0x000E0364
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 293018, RefRangeEnd = 293019, XrefRangeStart = 293015, XrefRangeEnd = 293018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector4Field.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4Field.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036FB RID: 14075 RVA: 0x00016A51 File Offset: 0x00014C51
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002748 RID: 10056
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200035C RID: 860
		public new class UxmlTraits : BaseField<Vector4>.UxmlTraits
		{
			// Token: 0x060036FC RID: 14076 RVA: 0x000E21A0 File Offset: 0x000E03A0
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<Vector4Field.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector4Field>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector4Field.UxmlTraits>.NativeClassPtr);
				Vector4Field.UxmlTraits.NativeFieldInfoPtr_m_XValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4Field.UxmlTraits>.NativeClassPtr, "m_XValue");
				Vector4Field.UxmlTraits.NativeFieldInfoPtr_m_YValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4Field.UxmlTraits>.NativeClassPtr, "m_YValue");
				Vector4Field.UxmlTraits.NativeFieldInfoPtr_m_ZValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4Field.UxmlTraits>.NativeClassPtr, "m_ZValue");
				Vector4Field.UxmlTraits.NativeFieldInfoPtr_m_WValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4Field.UxmlTraits>.NativeClassPtr, "m_WValue");
				Vector4Field.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4Field.UxmlTraits>.NativeClassPtr, 100664396);
				Vector4Field.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4Field.UxmlTraits>.NativeClassPtr, 100664397);
			}

			// Token: 0x060036FD RID: 14077 RVA: 0x000E2244 File Offset: 0x000E0444
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293019, XrefRangeEnd = 293024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector4Field.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036FE RID: 14078 RVA: 0x000E22BC File Offset: 0x000E04BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293024, XrefRangeEnd = 293057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector4Field.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4Field.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036FF RID: 14079 RVA: 0x00016A5A File Offset: 0x00014C5A
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001107 RID: 4359
			// (get) Token: 0x06003700 RID: 14080 RVA: 0x000E22F8 File Offset: 0x000E04F8
			// (set) Token: 0x06003701 RID: 14081 RVA: 0x00016A63 File Offset: 0x00014C63
			public unsafe UxmlFloatAttributeDescription m_XValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector4Field.UxmlTraits.NativeFieldInfoPtr_m_XValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector4Field.UxmlTraits.NativeFieldInfoPtr_m_XValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001108 RID: 4360
			// (get) Token: 0x06003702 RID: 14082 RVA: 0x000E2328 File Offset: 0x000E0528
			// (set) Token: 0x06003703 RID: 14083 RVA: 0x00016A82 File Offset: 0x00014C82
			public unsafe UxmlFloatAttributeDescription m_YValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector4Field.UxmlTraits.NativeFieldInfoPtr_m_YValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector4Field.UxmlTraits.NativeFieldInfoPtr_m_YValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001109 RID: 4361
			// (get) Token: 0x06003704 RID: 14084 RVA: 0x000E2358 File Offset: 0x000E0558
			// (set) Token: 0x06003705 RID: 14085 RVA: 0x00016AA1 File Offset: 0x00014CA1
			public unsafe UxmlFloatAttributeDescription m_ZValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector4Field.UxmlTraits.NativeFieldInfoPtr_m_ZValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector4Field.UxmlTraits.NativeFieldInfoPtr_m_ZValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700110A RID: 4362
			// (get) Token: 0x06003706 RID: 14086 RVA: 0x000E2388 File Offset: 0x000E0588
			// (set) Token: 0x06003707 RID: 14087 RVA: 0x00016AC0 File Offset: 0x00014CC0
			public unsafe UxmlFloatAttributeDescription m_WValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector4Field.UxmlTraits.NativeFieldInfoPtr_m_WValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector4Field.UxmlTraits.NativeFieldInfoPtr_m_WValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002749 RID: 10057
			private static readonly IntPtr NativeFieldInfoPtr_m_XValue;

			// Token: 0x0400274A RID: 10058
			private static readonly IntPtr NativeFieldInfoPtr_m_YValue;

			// Token: 0x0400274B RID: 10059
			private static readonly IntPtr NativeFieldInfoPtr_m_ZValue;

			// Token: 0x0400274C RID: 10060
			private static readonly IntPtr NativeFieldInfoPtr_m_WValue;

			// Token: 0x0400274D RID: 10061
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x0400274E RID: 10062
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200035D RID: 861
		[ObfuscatedName("UnityEngine.UIElements.Vector4Field+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003708 RID: 14088 RVA: 0x000E23B8 File Offset: 0x000E05B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Vector4Field.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector4Field>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector4Field.__c>.NativeClassPtr);
				Vector4Field.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4Field.__c>.NativeClassPtr, "<>9");
				Vector4Field.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4Field.__c>.NativeClassPtr, "<>9__0_0");
				Vector4Field.__c.NativeFieldInfoPtr___9__0_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4Field.__c>.NativeClassPtr, "<>9__0_1");
				Vector4Field.__c.NativeFieldInfoPtr___9__0_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4Field.__c>.NativeClassPtr, "<>9__0_2");
				Vector4Field.__c.NativeFieldInfoPtr___9__0_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4Field.__c>.NativeClassPtr, "<>9__0_3");
				Vector4Field.__c.NativeFieldInfoPtr___9__0_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4Field.__c>.NativeClassPtr, "<>9__0_4");
				Vector4Field.__c.NativeFieldInfoPtr___9__0_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4Field.__c>.NativeClassPtr, "<>9__0_5");
				Vector4Field.__c.NativeFieldInfoPtr___9__0_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4Field.__c>.NativeClassPtr, "<>9__0_6");
				Vector4Field.__c.NativeFieldInfoPtr___9__0_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4Field.__c>.NativeClassPtr, "<>9__0_7");
				Vector4Field.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4Field.__c>.NativeClassPtr, 100664399);
				Vector4Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_0_Internal_Single_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4Field.__c>.NativeClassPtr, 100664400);
				Vector4Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_1_Internal_Void_byref_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4Field.__c>.NativeClassPtr, 100664401);
				Vector4Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_2_Internal_Single_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4Field.__c>.NativeClassPtr, 100664402);
				Vector4Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_3_Internal_Void_byref_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4Field.__c>.NativeClassPtr, 100664403);
				Vector4Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_4_Internal_Single_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4Field.__c>.NativeClassPtr, 100664404);
				Vector4Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_5_Internal_Void_byref_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4Field.__c>.NativeClassPtr, 100664405);
				Vector4Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_6_Internal_Single_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4Field.__c>.NativeClassPtr, 100664406);
				Vector4Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_7_Internal_Void_byref_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4Field.__c>.NativeClassPtr, 100664407);
			}

			// Token: 0x06003709 RID: 14089 RVA: 0x000E254C File Offset: 0x000E074C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector4Field.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4Field.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600370A RID: 14090 RVA: 0x000E2588 File Offset: 0x000E0788
			[CallerCount(0)]
			public unsafe float _DescribeFields_b__0_0(Vector4 r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_0_Internal_Single_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600370B RID: 14091 RVA: 0x000E25D4 File Offset: 0x000E07D4
			[CallerCount(0)]
			public unsafe void _DescribeFields_b__0_1(ref Vector4 r, float v)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_1_Internal_Void_byref_Vector4_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600370C RID: 14092 RVA: 0x000E2620 File Offset: 0x000E0820
			[CallerCount(0)]
			public unsafe float _DescribeFields_b__0_2(Vector4 r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_2_Internal_Single_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600370D RID: 14093 RVA: 0x000E266C File Offset: 0x000E086C
			[CallerCount(0)]
			public unsafe void _DescribeFields_b__0_3(ref Vector4 r, float v)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_3_Internal_Void_byref_Vector4_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600370E RID: 14094 RVA: 0x000E26B8 File Offset: 0x000E08B8
			[CallerCount(0)]
			public unsafe float _DescribeFields_b__0_4(Vector4 r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_4_Internal_Single_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600370F RID: 14095 RVA: 0x000E2704 File Offset: 0x000E0904
			[CallerCount(0)]
			public unsafe void _DescribeFields_b__0_5(ref Vector4 r, float v)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_5_Internal_Void_byref_Vector4_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003710 RID: 14096 RVA: 0x000E2750 File Offset: 0x000E0950
			[CallerCount(0)]
			public unsafe float _DescribeFields_b__0_6(Vector4 r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_6_Internal_Single_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003711 RID: 14097 RVA: 0x000E279C File Offset: 0x000E099C
			[CallerCount(0)]
			public unsafe void _DescribeFields_b__0_7(ref Vector4 r, float v)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_7_Internal_Void_byref_Vector4_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003712 RID: 14098 RVA: 0x00016ADF File Offset: 0x00014CDF
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700110B RID: 4363
			// (get) Token: 0x06003713 RID: 14099 RVA: 0x000E27E8 File Offset: 0x000E09E8
			// (set) Token: 0x06003714 RID: 14100 RVA: 0x00016AE8 File Offset: 0x00014CE8
			public unsafe static Vector4Field.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector4Field.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector4Field.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector4Field.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700110C RID: 4364
			// (get) Token: 0x06003715 RID: 14101 RVA: 0x000E2810 File Offset: 0x000E0A10
			// (set) Token: 0x06003716 RID: 14102 RVA: 0x00016AFA File Offset: 0x00014CFA
			public unsafe static Func<Vector4, float> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector4Field.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector4, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector4Field.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700110D RID: 4365
			// (get) Token: 0x06003717 RID: 14103 RVA: 0x000E2838 File Offset: 0x000E0A38
			// (set) Token: 0x06003718 RID: 14104 RVA: 0x00016B0C File Offset: 0x00014D0C
			public unsafe static BaseCompositeField<Vector4, FloatField, float>.FieldDescription.WriteDelegate __9__0_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector4Field.__c.NativeFieldInfoPtr___9__0_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseCompositeField<Vector4, FloatField, float>.FieldDescription.WriteDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector4Field.__c.NativeFieldInfoPtr___9__0_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700110E RID: 4366
			// (get) Token: 0x06003719 RID: 14105 RVA: 0x000E2860 File Offset: 0x000E0A60
			// (set) Token: 0x0600371A RID: 14106 RVA: 0x00016B1E File Offset: 0x00014D1E
			public unsafe static Func<Vector4, float> __9__0_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector4Field.__c.NativeFieldInfoPtr___9__0_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector4, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector4Field.__c.NativeFieldInfoPtr___9__0_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700110F RID: 4367
			// (get) Token: 0x0600371B RID: 14107 RVA: 0x000E2888 File Offset: 0x000E0A88
			// (set) Token: 0x0600371C RID: 14108 RVA: 0x00016B30 File Offset: 0x00014D30
			public unsafe static BaseCompositeField<Vector4, FloatField, float>.FieldDescription.WriteDelegate __9__0_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector4Field.__c.NativeFieldInfoPtr___9__0_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseCompositeField<Vector4, FloatField, float>.FieldDescription.WriteDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector4Field.__c.NativeFieldInfoPtr___9__0_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001110 RID: 4368
			// (get) Token: 0x0600371D RID: 14109 RVA: 0x000E28B0 File Offset: 0x000E0AB0
			// (set) Token: 0x0600371E RID: 14110 RVA: 0x00016B42 File Offset: 0x00014D42
			public unsafe static Func<Vector4, float> __9__0_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector4Field.__c.NativeFieldInfoPtr___9__0_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector4, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector4Field.__c.NativeFieldInfoPtr___9__0_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001111 RID: 4369
			// (get) Token: 0x0600371F RID: 14111 RVA: 0x000E28D8 File Offset: 0x000E0AD8
			// (set) Token: 0x06003720 RID: 14112 RVA: 0x00016B54 File Offset: 0x00014D54
			public unsafe static BaseCompositeField<Vector4, FloatField, float>.FieldDescription.WriteDelegate __9__0_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector4Field.__c.NativeFieldInfoPtr___9__0_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseCompositeField<Vector4, FloatField, float>.FieldDescription.WriteDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector4Field.__c.NativeFieldInfoPtr___9__0_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001112 RID: 4370
			// (get) Token: 0x06003721 RID: 14113 RVA: 0x000E2900 File Offset: 0x000E0B00
			// (set) Token: 0x06003722 RID: 14114 RVA: 0x00016B66 File Offset: 0x00014D66
			public unsafe static Func<Vector4, float> __9__0_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector4Field.__c.NativeFieldInfoPtr___9__0_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector4, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector4Field.__c.NativeFieldInfoPtr___9__0_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001113 RID: 4371
			// (get) Token: 0x06003723 RID: 14115 RVA: 0x000E2928 File Offset: 0x000E0B28
			// (set) Token: 0x06003724 RID: 14116 RVA: 0x00016B78 File Offset: 0x00014D78
			public unsafe static BaseCompositeField<Vector4, FloatField, float>.FieldDescription.WriteDelegate __9__0_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector4Field.__c.NativeFieldInfoPtr___9__0_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseCompositeField<Vector4, FloatField, float>.FieldDescription.WriteDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector4Field.__c.NativeFieldInfoPtr___9__0_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400274F RID: 10063
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002750 RID: 10064
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x04002751 RID: 10065
			private static readonly IntPtr NativeFieldInfoPtr___9__0_1;

			// Token: 0x04002752 RID: 10066
			private static readonly IntPtr NativeFieldInfoPtr___9__0_2;

			// Token: 0x04002753 RID: 10067
			private static readonly IntPtr NativeFieldInfoPtr___9__0_3;

			// Token: 0x04002754 RID: 10068
			private static readonly IntPtr NativeFieldInfoPtr___9__0_4;

			// Token: 0x04002755 RID: 10069
			private static readonly IntPtr NativeFieldInfoPtr___9__0_5;

			// Token: 0x04002756 RID: 10070
			private static readonly IntPtr NativeFieldInfoPtr___9__0_6;

			// Token: 0x04002757 RID: 10071
			private static readonly IntPtr NativeFieldInfoPtr___9__0_7;

			// Token: 0x04002758 RID: 10072
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002759 RID: 10073
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_0_Internal_Single_Vector4_0;

			// Token: 0x0400275A RID: 10074
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_1_Internal_Void_byref_Vector4_Single_0;

			// Token: 0x0400275B RID: 10075
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_2_Internal_Single_Vector4_0;

			// Token: 0x0400275C RID: 10076
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_3_Internal_Void_byref_Vector4_Single_0;

			// Token: 0x0400275D RID: 10077
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_4_Internal_Single_Vector4_0;

			// Token: 0x0400275E RID: 10078
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_5_Internal_Void_byref_Vector4_Single_0;

			// Token: 0x0400275F RID: 10079
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_6_Internal_Single_Vector4_0;

			// Token: 0x04002760 RID: 10080
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_7_Internal_Void_byref_Vector4_Single_0;
		}

		// Token: 0x0200035E RID: 862
		[Serializable]
		public new sealed class <>c
		{
		}
	}
}

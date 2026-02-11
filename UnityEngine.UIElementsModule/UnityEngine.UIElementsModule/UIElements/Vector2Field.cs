using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000051 RID: 81
	public class Vector2Field : BaseCompositeField<Vector2, FloatField, float>
	{
		// Token: 0x060007AD RID: 1965 RVA: 0x00038A18 File Offset: 0x00036C18
		// Note: this type is marked as 'beforefieldinit'.
		static Vector2Field()
		{
			Il2CppClassPointerStore<Vector2Field>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Vector2Field");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2Field>.NativeClassPtr);
			Vector2Field.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Field>.NativeClassPtr, "ussClassName");
			Vector2Field.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Field>.NativeClassPtr, "labelUssClassName");
			Vector2Field.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Field>.NativeClassPtr, "inputUssClassName");
			Vector2Field.NativeMethodInfoPtr_DescribeFields_Internal_Virtual_Il2CppReferenceArray_1_FieldDescription_Vector2_FloatField_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Field>.NativeClassPtr, 100664363);
			Vector2Field.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Field>.NativeClassPtr, 100664364);
			Vector2Field.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Field>.NativeClassPtr, 100664365);
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00038AC0 File Offset: 0x00036CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292737, XrefRangeEnd = 292810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<BaseCompositeField<Vector2, FloatField, float>.FieldDescription> DescribeFields()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector2Field.NativeMethodInfoPtr_DescribeFields_Internal_Virtual_Il2CppReferenceArray_1_FieldDescription_Vector2_FloatField_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BaseCompositeField<Vector2, FloatField, float>.FieldDescription>>(intPtr3) : null;
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00038B0C File Offset: 0x00036D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292810, XrefRangeEnd = 292830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2Field()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector2Field>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Field.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00038B48 File Offset: 0x00036D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292830, XrefRangeEnd = 292850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2Field(string label)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector2Field>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Field.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00004A84 File Offset: 0x00002C84
		public Vector2Field(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060007B2 RID: 1970 RVA: 0x00038B94 File Offset: 0x00036D94
		// (set) Token: 0x060007B3 RID: 1971 RVA: 0x00004A8D File Offset: 0x00002C8D
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Vector2Field.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2Field.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x00038BB4 File Offset: 0x00036DB4
		// (set) Token: 0x060007B5 RID: 1973 RVA: 0x00004A9F File Offset: 0x00002C9F
		public new unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Vector2Field.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2Field.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060007B6 RID: 1974 RVA: 0x00038BD4 File Offset: 0x00036DD4
		// (set) Token: 0x060007B7 RID: 1975 RVA: 0x00004AB1 File Offset: 0x00002CB1
		public new unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Vector2Field.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2Field.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr_DescribeFields_Internal_Virtual_Il2CppReferenceArray_1_FieldDescription_Vector2_FloatField_Single_0;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x02000353 RID: 851
		public new class UxmlFactory : UxmlFactory<Vector2Field, Vector2Field.UxmlTraits>
		{
			// Token: 0x060036B9 RID: 14009 RVA: 0x0001680C File Offset: 0x00014A0C
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<Vector2Field.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector2Field>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2Field.UxmlFactory>.NativeClassPtr);
				Vector2Field.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Field.UxmlFactory>.NativeClassPtr, 100664367);
			}

			// Token: 0x060036BA RID: 14010 RVA: 0x000E1600 File Offset: 0x000DF800
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 292710, RefRangeEnd = 292711, XrefRangeStart = 292707, XrefRangeEnd = 292710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector2Field.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Field.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036BB RID: 14011 RVA: 0x00016840 File Offset: 0x00014A40
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002725 RID: 10021
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000354 RID: 852
		public new class UxmlTraits : BaseField<Vector2>.UxmlTraits
		{
			// Token: 0x060036BC RID: 14012 RVA: 0x000E163C File Offset: 0x000DF83C
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<Vector2Field.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector2Field>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2Field.UxmlTraits>.NativeClassPtr);
				Vector2Field.UxmlTraits.NativeFieldInfoPtr_m_XValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Field.UxmlTraits>.NativeClassPtr, "m_XValue");
				Vector2Field.UxmlTraits.NativeFieldInfoPtr_m_YValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Field.UxmlTraits>.NativeClassPtr, "m_YValue");
				Vector2Field.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Field.UxmlTraits>.NativeClassPtr, 100664368);
				Vector2Field.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Field.UxmlTraits>.NativeClassPtr, 100664369);
			}

			// Token: 0x060036BD RID: 14013 RVA: 0x000E16B8 File Offset: 0x000DF8B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292711, XrefRangeEnd = 292718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector2Field.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036BE RID: 14014 RVA: 0x000E1730 File Offset: 0x000DF930
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292718, XrefRangeEnd = 292737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector2Field.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Field.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036BF RID: 14015 RVA: 0x00016849 File Offset: 0x00014A49
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010F6 RID: 4342
			// (get) Token: 0x060036C0 RID: 14016 RVA: 0x000E176C File Offset: 0x000DF96C
			// (set) Token: 0x060036C1 RID: 14017 RVA: 0x00016852 File Offset: 0x00014A52
			public unsafe UxmlFloatAttributeDescription m_XValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector2Field.UxmlTraits.NativeFieldInfoPtr_m_XValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector2Field.UxmlTraits.NativeFieldInfoPtr_m_XValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010F7 RID: 4343
			// (get) Token: 0x060036C2 RID: 14018 RVA: 0x000E179C File Offset: 0x000DF99C
			// (set) Token: 0x060036C3 RID: 14019 RVA: 0x00016871 File Offset: 0x00014A71
			public unsafe UxmlFloatAttributeDescription m_YValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector2Field.UxmlTraits.NativeFieldInfoPtr_m_YValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector2Field.UxmlTraits.NativeFieldInfoPtr_m_YValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002726 RID: 10022
			private static readonly IntPtr NativeFieldInfoPtr_m_XValue;

			// Token: 0x04002727 RID: 10023
			private static readonly IntPtr NativeFieldInfoPtr_m_YValue;

			// Token: 0x04002728 RID: 10024
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x04002729 RID: 10025
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000355 RID: 853
		[ObfuscatedName("UnityEngine.UIElements.Vector2Field+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060036C4 RID: 14020 RVA: 0x000E17CC File Offset: 0x000DF9CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Vector2Field.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector2Field>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2Field.__c>.NativeClassPtr);
				Vector2Field.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Field.__c>.NativeClassPtr, "<>9");
				Vector2Field.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Field.__c>.NativeClassPtr, "<>9__0_0");
				Vector2Field.__c.NativeFieldInfoPtr___9__0_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Field.__c>.NativeClassPtr, "<>9__0_1");
				Vector2Field.__c.NativeFieldInfoPtr___9__0_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Field.__c>.NativeClassPtr, "<>9__0_2");
				Vector2Field.__c.NativeFieldInfoPtr___9__0_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Field.__c>.NativeClassPtr, "<>9__0_3");
				Vector2Field.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Field.__c>.NativeClassPtr, 100664371);
				Vector2Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_0_Internal_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Field.__c>.NativeClassPtr, 100664372);
				Vector2Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_1_Internal_Void_byref_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Field.__c>.NativeClassPtr, 100664373);
				Vector2Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_2_Internal_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Field.__c>.NativeClassPtr, 100664374);
				Vector2Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_3_Internal_Void_byref_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Field.__c>.NativeClassPtr, 100664375);
			}

			// Token: 0x060036C5 RID: 14021 RVA: 0x000E18C0 File Offset: 0x000DFAC0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector2Field.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Field.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036C6 RID: 14022 RVA: 0x000E18FC File Offset: 0x000DFAFC
			[CallerCount(0)]
			public unsafe float _DescribeFields_b__0_0(Vector2 r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_0_Internal_Single_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060036C7 RID: 14023 RVA: 0x000E1948 File Offset: 0x000DFB48
			[CallerCount(0)]
			public unsafe void _DescribeFields_b__0_1(ref Vector2 r, float v)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_1_Internal_Void_byref_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036C8 RID: 14024 RVA: 0x000E1994 File Offset: 0x000DFB94
			[CallerCount(0)]
			public unsafe float _DescribeFields_b__0_2(Vector2 r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_2_Internal_Single_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060036C9 RID: 14025 RVA: 0x000E19E0 File Offset: 0x000DFBE0
			[CallerCount(0)]
			public unsafe void _DescribeFields_b__0_3(ref Vector2 r, float v)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Field.__c.NativeMethodInfoPtr__DescribeFields_b__0_3_Internal_Void_byref_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036CA RID: 14026 RVA: 0x00016890 File Offset: 0x00014A90
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010F8 RID: 4344
			// (get) Token: 0x060036CB RID: 14027 RVA: 0x000E1A2C File Offset: 0x000DFC2C
			// (set) Token: 0x060036CC RID: 14028 RVA: 0x00016899 File Offset: 0x00014A99
			public unsafe static Vector2Field.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector2Field.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2Field.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector2Field.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010F9 RID: 4345
			// (get) Token: 0x060036CD RID: 14029 RVA: 0x000E1A54 File Offset: 0x000DFC54
			// (set) Token: 0x060036CE RID: 14030 RVA: 0x000168AB File Offset: 0x00014AAB
			public unsafe static Func<Vector2, float> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector2Field.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector2Field.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010FA RID: 4346
			// (get) Token: 0x060036CF RID: 14031 RVA: 0x000E1A7C File Offset: 0x000DFC7C
			// (set) Token: 0x060036D0 RID: 14032 RVA: 0x000168BD File Offset: 0x00014ABD
			public unsafe static BaseCompositeField<Vector2, FloatField, float>.FieldDescription.WriteDelegate __9__0_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector2Field.__c.NativeFieldInfoPtr___9__0_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseCompositeField<Vector2, FloatField, float>.FieldDescription.WriteDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector2Field.__c.NativeFieldInfoPtr___9__0_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010FB RID: 4347
			// (get) Token: 0x060036D1 RID: 14033 RVA: 0x000E1AA4 File Offset: 0x000DFCA4
			// (set) Token: 0x060036D2 RID: 14034 RVA: 0x000168CF File Offset: 0x00014ACF
			public unsafe static Func<Vector2, float> __9__0_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector2Field.__c.NativeFieldInfoPtr___9__0_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector2Field.__c.NativeFieldInfoPtr___9__0_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010FC RID: 4348
			// (get) Token: 0x060036D3 RID: 14035 RVA: 0x000E1ACC File Offset: 0x000DFCCC
			// (set) Token: 0x060036D4 RID: 14036 RVA: 0x000168E1 File Offset: 0x00014AE1
			public unsafe static BaseCompositeField<Vector2, FloatField, float>.FieldDescription.WriteDelegate __9__0_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector2Field.__c.NativeFieldInfoPtr___9__0_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseCompositeField<Vector2, FloatField, float>.FieldDescription.WriteDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector2Field.__c.NativeFieldInfoPtr___9__0_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400272A RID: 10026
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400272B RID: 10027
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x0400272C RID: 10028
			private static readonly IntPtr NativeFieldInfoPtr___9__0_1;

			// Token: 0x0400272D RID: 10029
			private static readonly IntPtr NativeFieldInfoPtr___9__0_2;

			// Token: 0x0400272E RID: 10030
			private static readonly IntPtr NativeFieldInfoPtr___9__0_3;

			// Token: 0x0400272F RID: 10031
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002730 RID: 10032
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_0_Internal_Single_Vector2_0;

			// Token: 0x04002731 RID: 10033
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_1_Internal_Void_byref_Vector2_Single_0;

			// Token: 0x04002732 RID: 10034
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_2_Internal_Single_Vector2_0;

			// Token: 0x04002733 RID: 10035
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_3_Internal_Void_byref_Vector2_Single_0;
		}

		// Token: 0x02000356 RID: 854
		[Serializable]
		public new sealed class <>c
		{
		}
	}
}

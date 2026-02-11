using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000054 RID: 84
	public class Vector2IntField : BaseCompositeField<Vector2Int, IntegerField, int>
	{
		// Token: 0x060007CE RID: 1998 RVA: 0x00038FAC File Offset: 0x000371AC
		// Note: this type is marked as 'beforefieldinit'.
		static Vector2IntField()
		{
			Il2CppClassPointerStore<Vector2IntField>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Vector2IntField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2IntField>.NativeClassPtr);
			Vector2IntField.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2IntField>.NativeClassPtr, "ussClassName");
			Vector2IntField.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2IntField>.NativeClassPtr, "labelUssClassName");
			Vector2IntField.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2IntField>.NativeClassPtr, "inputUssClassName");
			Vector2IntField.NativeMethodInfoPtr_DescribeFields_Internal_Virtual_Il2CppReferenceArray_1_FieldDescription_Vector2Int_IntegerField_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2IntField>.NativeClassPtr, 100664408);
			Vector2IntField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2IntField>.NativeClassPtr, 100664409);
			Vector2IntField.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2IntField>.NativeClassPtr, 100664410);
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00039054 File Offset: 0x00037254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293302, XrefRangeEnd = 293375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<BaseCompositeField<Vector2Int, IntegerField, int>.FieldDescription> DescribeFields()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector2IntField.NativeMethodInfoPtr_DescribeFields_Internal_Virtual_Il2CppReferenceArray_1_FieldDescription_Vector2Int_IntegerField_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BaseCompositeField<Vector2Int, IntegerField, int>.FieldDescription>>(intPtr3) : null;
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x000390A0 File Offset: 0x000372A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293375, XrefRangeEnd = 293395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2IntField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector2IntField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2IntField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x000390DC File Offset: 0x000372DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293395, XrefRangeEnd = 293415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2IntField(string label)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector2IntField>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2IntField.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00004B41 File Offset: 0x00002D41
		public Vector2IntField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x00039128 File Offset: 0x00037328
		// (set) Token: 0x060007D4 RID: 2004 RVA: 0x00004B4A File Offset: 0x00002D4A
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Vector2IntField.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2IntField.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x00039148 File Offset: 0x00037348
		// (set) Token: 0x060007D6 RID: 2006 RVA: 0x00004B5C File Offset: 0x00002D5C
		public new unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Vector2IntField.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2IntField.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x00039168 File Offset: 0x00037368
		// (set) Token: 0x060007D8 RID: 2008 RVA: 0x00004B6E File Offset: 0x00002D6E
		public new unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Vector2IntField.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2IntField.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr_DescribeFields_Internal_Virtual_Il2CppReferenceArray_1_FieldDescription_Vector2Int_IntegerField_Int32_0;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0200035F RID: 863
		public new class UxmlFactory : UxmlFactory<Vector2IntField, Vector2IntField.UxmlTraits>
		{
			// Token: 0x06003725 RID: 14117 RVA: 0x00016B8A File Offset: 0x00014D8A
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<Vector2IntField.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector2IntField>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2IntField.UxmlFactory>.NativeClassPtr);
				Vector2IntField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2IntField.UxmlFactory>.NativeClassPtr, 100664412);
			}

			// Token: 0x06003726 RID: 14118 RVA: 0x000E2950 File Offset: 0x000E0B50
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 293270, RefRangeEnd = 293271, XrefRangeStart = 293267, XrefRangeEnd = 293270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector2IntField.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2IntField.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003727 RID: 14119 RVA: 0x00016BBE File Offset: 0x00014DBE
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002761 RID: 10081
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000360 RID: 864
		public new class UxmlTraits : BaseField<Vector2Int>.UxmlTraits
		{
			// Token: 0x06003728 RID: 14120 RVA: 0x000E298C File Offset: 0x000E0B8C
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<Vector2IntField.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector2IntField>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2IntField.UxmlTraits>.NativeClassPtr);
				Vector2IntField.UxmlTraits.NativeFieldInfoPtr_m_XValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2IntField.UxmlTraits>.NativeClassPtr, "m_XValue");
				Vector2IntField.UxmlTraits.NativeFieldInfoPtr_m_YValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2IntField.UxmlTraits>.NativeClassPtr, "m_YValue");
				Vector2IntField.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2IntField.UxmlTraits>.NativeClassPtr, 100664413);
				Vector2IntField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2IntField.UxmlTraits>.NativeClassPtr, 100664414);
			}

			// Token: 0x06003729 RID: 14121 RVA: 0x000E2A08 File Offset: 0x000E0C08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293271, XrefRangeEnd = 293278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector2IntField.UxmlTraits.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600372A RID: 14122 RVA: 0x000E2A80 File Offset: 0x000E0C80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293278, XrefRangeEnd = 293297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector2IntField.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2IntField.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600372B RID: 14123 RVA: 0x00016BC7 File Offset: 0x00014DC7
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001114 RID: 4372
			// (get) Token: 0x0600372C RID: 14124 RVA: 0x000E2ABC File Offset: 0x000E0CBC
			// (set) Token: 0x0600372D RID: 14125 RVA: 0x00016BD0 File Offset: 0x00014DD0
			public unsafe UxmlIntAttributeDescription m_XValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector2IntField.UxmlTraits.NativeFieldInfoPtr_m_XValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlIntAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector2IntField.UxmlTraits.NativeFieldInfoPtr_m_XValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001115 RID: 4373
			// (get) Token: 0x0600372E RID: 14126 RVA: 0x000E2AEC File Offset: 0x000E0CEC
			// (set) Token: 0x0600372F RID: 14127 RVA: 0x00016BEF File Offset: 0x00014DEF
			public unsafe UxmlIntAttributeDescription m_YValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector2IntField.UxmlTraits.NativeFieldInfoPtr_m_YValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlIntAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vector2IntField.UxmlTraits.NativeFieldInfoPtr_m_YValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002762 RID: 10082
			private static readonly IntPtr NativeFieldInfoPtr_m_XValue;

			// Token: 0x04002763 RID: 10083
			private static readonly IntPtr NativeFieldInfoPtr_m_YValue;

			// Token: 0x04002764 RID: 10084
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

			// Token: 0x04002765 RID: 10085
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000361 RID: 865
		[ObfuscatedName("UnityEngine.UIElements.Vector2IntField+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003730 RID: 14128 RVA: 0x000E2B1C File Offset: 0x000E0D1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Vector2IntField.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector2IntField>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2IntField.__c>.NativeClassPtr);
				Vector2IntField.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2IntField.__c>.NativeClassPtr, "<>9");
				Vector2IntField.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2IntField.__c>.NativeClassPtr, "<>9__0_0");
				Vector2IntField.__c.NativeFieldInfoPtr___9__0_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2IntField.__c>.NativeClassPtr, "<>9__0_1");
				Vector2IntField.__c.NativeFieldInfoPtr___9__0_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2IntField.__c>.NativeClassPtr, "<>9__0_2");
				Vector2IntField.__c.NativeFieldInfoPtr___9__0_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2IntField.__c>.NativeClassPtr, "<>9__0_3");
				Vector2IntField.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2IntField.__c>.NativeClassPtr, 100664416);
				Vector2IntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_0_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2IntField.__c>.NativeClassPtr, 100664417);
				Vector2IntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_1_Internal_Void_byref_Vector2Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2IntField.__c>.NativeClassPtr, 100664418);
				Vector2IntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_2_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2IntField.__c>.NativeClassPtr, 100664419);
				Vector2IntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_3_Internal_Void_byref_Vector2Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2IntField.__c>.NativeClassPtr, 100664420);
			}

			// Token: 0x06003731 RID: 14129 RVA: 0x000E2C10 File Offset: 0x000E0E10
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector2IntField.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2IntField.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003732 RID: 14130 RVA: 0x000E2C4C File Offset: 0x000E0E4C
			[CallerCount(0)]
			public unsafe int _DescribeFields_b__0_0(Vector2Int r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2IntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_0_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003733 RID: 14131 RVA: 0x000E2C98 File Offset: 0x000E0E98
			[CallerCount(0)]
			public unsafe void _DescribeFields_b__0_1(ref Vector2Int r, int v)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2IntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_1_Internal_Void_byref_Vector2Int_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003734 RID: 14132 RVA: 0x000E2CE4 File Offset: 0x000E0EE4
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 293297, RefRangeEnd = 293302, XrefRangeStart = 293297, XrefRangeEnd = 293297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _DescribeFields_b__0_2(Vector2Int r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2IntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_2_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003735 RID: 14133 RVA: 0x000E2D30 File Offset: 0x000E0F30
			[CallerCount(0)]
			public unsafe void _DescribeFields_b__0_3(ref Vector2Int r, int v)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2IntField.__c.NativeMethodInfoPtr__DescribeFields_b__0_3_Internal_Void_byref_Vector2Int_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003736 RID: 14134 RVA: 0x00016C0E File Offset: 0x00014E0E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001116 RID: 4374
			// (get) Token: 0x06003737 RID: 14135 RVA: 0x000E2D7C File Offset: 0x000E0F7C
			// (set) Token: 0x06003738 RID: 14136 RVA: 0x00016C17 File Offset: 0x00014E17
			public unsafe static Vector2IntField.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector2IntField.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2IntField.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector2IntField.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001117 RID: 4375
			// (get) Token: 0x06003739 RID: 14137 RVA: 0x000E2DA4 File Offset: 0x000E0FA4
			// (set) Token: 0x0600373A RID: 14138 RVA: 0x00016C29 File Offset: 0x00014E29
			public unsafe static Func<Vector2Int, int> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector2IntField.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2Int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector2IntField.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001118 RID: 4376
			// (get) Token: 0x0600373B RID: 14139 RVA: 0x000E2DCC File Offset: 0x000E0FCC
			// (set) Token: 0x0600373C RID: 14140 RVA: 0x00016C3B File Offset: 0x00014E3B
			public unsafe static BaseCompositeField<Vector2Int, IntegerField, int>.FieldDescription.WriteDelegate __9__0_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector2IntField.__c.NativeFieldInfoPtr___9__0_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseCompositeField<Vector2Int, IntegerField, int>.FieldDescription.WriteDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector2IntField.__c.NativeFieldInfoPtr___9__0_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001119 RID: 4377
			// (get) Token: 0x0600373D RID: 14141 RVA: 0x000E2DF4 File Offset: 0x000E0FF4
			// (set) Token: 0x0600373E RID: 14142 RVA: 0x00016C4D File Offset: 0x00014E4D
			public unsafe static Func<Vector2Int, int> __9__0_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector2IntField.__c.NativeFieldInfoPtr___9__0_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2Int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector2IntField.__c.NativeFieldInfoPtr___9__0_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700111A RID: 4378
			// (get) Token: 0x0600373F RID: 14143 RVA: 0x000E2E1C File Offset: 0x000E101C
			// (set) Token: 0x06003740 RID: 14144 RVA: 0x00016C5F File Offset: 0x00014E5F
			public unsafe static BaseCompositeField<Vector2Int, IntegerField, int>.FieldDescription.WriteDelegate __9__0_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Vector2IntField.__c.NativeFieldInfoPtr___9__0_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseCompositeField<Vector2Int, IntegerField, int>.FieldDescription.WriteDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Vector2IntField.__c.NativeFieldInfoPtr___9__0_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002766 RID: 10086
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002767 RID: 10087
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x04002768 RID: 10088
			private static readonly IntPtr NativeFieldInfoPtr___9__0_1;

			// Token: 0x04002769 RID: 10089
			private static readonly IntPtr NativeFieldInfoPtr___9__0_2;

			// Token: 0x0400276A RID: 10090
			private static readonly IntPtr NativeFieldInfoPtr___9__0_3;

			// Token: 0x0400276B RID: 10091
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400276C RID: 10092
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_0_Internal_Int32_Vector2Int_0;

			// Token: 0x0400276D RID: 10093
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_1_Internal_Void_byref_Vector2Int_Int32_0;

			// Token: 0x0400276E RID: 10094
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_2_Internal_Int32_Vector2Int_0;

			// Token: 0x0400276F RID: 10095
			private static readonly IntPtr NativeMethodInfoPtr__DescribeFields_b__0_3_Internal_Void_byref_Vector2Int_Int32_0;
		}

		// Token: 0x02000362 RID: 866
		[Serializable]
		public new sealed class <>c
		{
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000D2 RID: 210
	public class XmlElementAttribute : Attribute
	{
		// Token: 0x060013D5 RID: 5077 RVA: 0x0006C104 File Offset: 0x0006A304
		// Note: this type is marked as 'beforefieldinit'.
		static XmlElementAttribute()
		{
			Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlElementAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr);
			XmlElementAttribute.NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr, "dataType");
			XmlElementAttribute.NativeFieldInfoPtr_elementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr, "elementName");
			XmlElementAttribute.NativeFieldInfoPtr_form = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr, "form");
			XmlElementAttribute.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr, "ns");
			XmlElementAttribute.NativeFieldInfoPtr_isNullable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr, "isNullable");
			XmlElementAttribute.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr, "type");
			XmlElementAttribute.NativeFieldInfoPtr_order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr, "order");
			XmlElementAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr, 100666479);
			XmlElementAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr, 100666480);
			XmlElementAttribute.NativeMethodInfoPtr_get_DataType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr, 100666481);
			XmlElementAttribute.NativeMethodInfoPtr_get_ElementName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr, 100666482);
			XmlElementAttribute.NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr, 100666483);
			XmlElementAttribute.NativeMethodInfoPtr_get_Namespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr, 100666484);
			XmlElementAttribute.NativeMethodInfoPtr_get_IsNullable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr, 100666485);
			XmlElementAttribute.NativeMethodInfoPtr_get_Order_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr, 100666486);
			XmlElementAttribute.NativeMethodInfoPtr_get_Type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr, 100666487);
			XmlElementAttribute.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr, 100666488);
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x0006C288 File Offset: 0x0006A488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385741, XrefRangeEnd = 385743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlElementAttribute(string elementName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElementAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x0006C2D4 File Offset: 0x0006A4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385743, XrefRangeEnd = 385746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlElementAttribute(string elementName, Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlElementAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElementAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x060013D8 RID: 5080 RVA: 0x0006C334 File Offset: 0x0006A534
		public unsafe string DataType
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 385747, RefRangeEnd = 385749, XrefRangeStart = 385746, XrefRangeEnd = 385747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElementAttribute.NativeMethodInfoPtr_get_DataType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x060013D9 RID: 5081 RVA: 0x0006C36C File Offset: 0x0006A56C
		public unsafe string ElementName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 385750, RefRangeEnd = 385752, XrefRangeStart = 385749, XrefRangeEnd = 385750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElementAttribute.NativeMethodInfoPtr_get_ElementName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x060013DA RID: 5082 RVA: 0x0006C3A4 File Offset: 0x0006A5A4
		public unsafe XmlSchemaForm Form
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElementAttribute.NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x060013DB RID: 5083 RVA: 0x0006C3E0 File Offset: 0x0006A5E0
		public unsafe string Namespace
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElementAttribute.NativeMethodInfoPtr_get_Namespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x060013DC RID: 5084 RVA: 0x0006C418 File Offset: 0x0006A618
		public unsafe bool IsNullable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElementAttribute.NativeMethodInfoPtr_get_IsNullable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x060013DD RID: 5085 RVA: 0x0006C454 File Offset: 0x0006A654
		public unsafe int Order
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElementAttribute.NativeMethodInfoPtr_get_Order_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x060013DE RID: 5086 RVA: 0x0006C490 File Offset: 0x0006A690
		public unsafe Type Type
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElementAttribute.NativeMethodInfoPtr_get_Type_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x0006C4D0 File Offset: 0x0006A6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385752, XrefRangeEnd = 385767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddKeyHash(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElementAttribute.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00008743 File Offset: 0x00006943
		public XmlElementAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x0006C514 File Offset: 0x0006A714
		// (set) Token: 0x060013E2 RID: 5090 RVA: 0x0000874C File Offset: 0x0000694C
		public unsafe string dataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementAttribute.NativeFieldInfoPtr_dataType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementAttribute.NativeFieldInfoPtr_dataType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x0006C53C File Offset: 0x0006A73C
		// (set) Token: 0x060013E4 RID: 5092 RVA: 0x0000876B File Offset: 0x0000696B
		public unsafe string elementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementAttribute.NativeFieldInfoPtr_elementName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementAttribute.NativeFieldInfoPtr_elementName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x060013E5 RID: 5093 RVA: 0x0006C564 File Offset: 0x0006A764
		// (set) Token: 0x060013E6 RID: 5094 RVA: 0x0000878A File Offset: 0x0000698A
		public unsafe XmlSchemaForm form
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementAttribute.NativeFieldInfoPtr_form);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementAttribute.NativeFieldInfoPtr_form)) = value;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x060013E7 RID: 5095 RVA: 0x0006C58C File Offset: 0x0006A78C
		// (set) Token: 0x060013E8 RID: 5096 RVA: 0x000087A5 File Offset: 0x000069A5
		public unsafe string ns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementAttribute.NativeFieldInfoPtr_ns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementAttribute.NativeFieldInfoPtr_ns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x060013E9 RID: 5097 RVA: 0x0006C5B4 File Offset: 0x0006A7B4
		// (set) Token: 0x060013EA RID: 5098 RVA: 0x000087C4 File Offset: 0x000069C4
		public unsafe bool isNullable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementAttribute.NativeFieldInfoPtr_isNullable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementAttribute.NativeFieldInfoPtr_isNullable)) = value;
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x060013EB RID: 5099 RVA: 0x0006C5DC File Offset: 0x0006A7DC
		// (set) Token: 0x060013EC RID: 5100 RVA: 0x000087DF File Offset: 0x000069DF
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementAttribute.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementAttribute.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x060013ED RID: 5101 RVA: 0x0006C60C File Offset: 0x0006A80C
		// (set) Token: 0x060013EE RID: 5102 RVA: 0x000087FE File Offset: 0x000069FE
		public unsafe int order
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementAttribute.NativeFieldInfoPtr_order);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementAttribute.NativeFieldInfoPtr_order)) = value;
			}
		}

		// Token: 0x04000FF6 RID: 4086
		private static readonly IntPtr NativeFieldInfoPtr_dataType;

		// Token: 0x04000FF7 RID: 4087
		private static readonly IntPtr NativeFieldInfoPtr_elementName;

		// Token: 0x04000FF8 RID: 4088
		private static readonly IntPtr NativeFieldInfoPtr_form;

		// Token: 0x04000FF9 RID: 4089
		private static readonly IntPtr NativeFieldInfoPtr_ns;

		// Token: 0x04000FFA RID: 4090
		private static readonly IntPtr NativeFieldInfoPtr_isNullable;

		// Token: 0x04000FFB RID: 4091
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000FFC RID: 4092
		private static readonly IntPtr NativeFieldInfoPtr_order;

		// Token: 0x04000FFD RID: 4093
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000FFE RID: 4094
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Type_0;

		// Token: 0x04000FFF RID: 4095
		private static readonly IntPtr NativeMethodInfoPtr_get_DataType_Public_get_String_0;

		// Token: 0x04001000 RID: 4096
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementName_Public_get_String_0;

		// Token: 0x04001001 RID: 4097
		private static readonly IntPtr NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0;

		// Token: 0x04001002 RID: 4098
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_String_0;

		// Token: 0x04001003 RID: 4099
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNullable_Public_get_Boolean_0;

		// Token: 0x04001004 RID: 4100
		private static readonly IntPtr NativeMethodInfoPtr_get_Order_Public_get_Int32_0;

		// Token: 0x04001005 RID: 4101
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_Type_0;

		// Token: 0x04001006 RID: 4102
		private static readonly IntPtr NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0;
	}
}

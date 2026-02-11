using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000CB RID: 203
	public class XmlArrayItemAttribute : Attribute
	{
		// Token: 0x06001359 RID: 4953 RVA: 0x0006A740 File Offset: 0x00068940
		// Note: this type is marked as 'beforefieldinit'.
		static XmlArrayItemAttribute()
		{
			Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlArrayItemAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr);
			XmlArrayItemAttribute.NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, "dataType");
			XmlArrayItemAttribute.NativeFieldInfoPtr_elementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, "elementName");
			XmlArrayItemAttribute.NativeFieldInfoPtr_form = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, "form");
			XmlArrayItemAttribute.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, "ns");
			XmlArrayItemAttribute.NativeFieldInfoPtr_isNullable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, "isNullable");
			XmlArrayItemAttribute.NativeFieldInfoPtr_isNullableSpecified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, "isNullableSpecified");
			XmlArrayItemAttribute.NativeFieldInfoPtr_nestingLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, "nestingLevel");
			XmlArrayItemAttribute.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, "type");
			XmlArrayItemAttribute.NativeMethodInfoPtr_get_DataType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, 100666428);
			XmlArrayItemAttribute.NativeMethodInfoPtr_get_ElementName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, 100666429);
			XmlArrayItemAttribute.NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, 100666430);
			XmlArrayItemAttribute.NativeMethodInfoPtr_get_Namespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, 100666431);
			XmlArrayItemAttribute.NativeMethodInfoPtr_get_IsNullable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, 100666432);
			XmlArrayItemAttribute.NativeMethodInfoPtr_get_IsNullableSpecified_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, 100666433);
			XmlArrayItemAttribute.NativeMethodInfoPtr_get_Type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, 100666434);
			XmlArrayItemAttribute.NativeMethodInfoPtr_get_NestingLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, 100666435);
			XmlArrayItemAttribute.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayItemAttribute>.NativeClassPtr, 100666436);
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x0600135A RID: 4954 RVA: 0x0006A8C4 File Offset: 0x00068AC4
		public unsafe string DataType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 385202, RefRangeEnd = 385203, XrefRangeStart = 385201, XrefRangeEnd = 385202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayItemAttribute.NativeMethodInfoPtr_get_DataType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x0600135B RID: 4955 RVA: 0x0006A8FC File Offset: 0x00068AFC
		public unsafe string ElementName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 385204, RefRangeEnd = 385206, XrefRangeStart = 385203, XrefRangeEnd = 385204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayItemAttribute.NativeMethodInfoPtr_get_ElementName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x0006A934 File Offset: 0x00068B34
		public unsafe XmlSchemaForm Form
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayItemAttribute.NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x0600135D RID: 4957 RVA: 0x0006A970 File Offset: 0x00068B70
		public unsafe string Namespace
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayItemAttribute.NativeMethodInfoPtr_get_Namespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x0600135E RID: 4958 RVA: 0x0006A9A8 File Offset: 0x00068BA8
		public unsafe bool IsNullable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayItemAttribute.NativeMethodInfoPtr_get_IsNullable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x0600135F RID: 4959 RVA: 0x0006A9E4 File Offset: 0x00068BE4
		public unsafe bool IsNullableSpecified
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayItemAttribute.NativeMethodInfoPtr_get_IsNullableSpecified_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x0006AA20 File Offset: 0x00068C20
		public unsafe Type Type
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayItemAttribute.NativeMethodInfoPtr_get_Type_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001361 RID: 4961 RVA: 0x0006AA60 File Offset: 0x00068C60
		public unsafe int NestingLevel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 134006, RefRangeEnd = 134007, XrefRangeStart = 134006, XrefRangeEnd = 134007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayItemAttribute.NativeMethodInfoPtr_get_NestingLevel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x0006AA9C File Offset: 0x00068C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385206, XrefRangeEnd = 385222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddKeyHash(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayItemAttribute.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x0000838B File Offset: 0x0000658B
		public XmlArrayItemAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001364 RID: 4964 RVA: 0x0006AAE0 File Offset: 0x00068CE0
		// (set) Token: 0x06001365 RID: 4965 RVA: 0x00008394 File Offset: 0x00006594
		public unsafe string dataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_dataType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_dataType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001366 RID: 4966 RVA: 0x0006AB08 File Offset: 0x00068D08
		// (set) Token: 0x06001367 RID: 4967 RVA: 0x000083B3 File Offset: 0x000065B3
		public unsafe string elementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_elementName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_elementName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001368 RID: 4968 RVA: 0x0006AB30 File Offset: 0x00068D30
		// (set) Token: 0x06001369 RID: 4969 RVA: 0x000083D2 File Offset: 0x000065D2
		public unsafe XmlSchemaForm form
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_form);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_form)) = value;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x0600136A RID: 4970 RVA: 0x0006AB58 File Offset: 0x00068D58
		// (set) Token: 0x0600136B RID: 4971 RVA: 0x000083ED File Offset: 0x000065ED
		public unsafe string ns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_ns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_ns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x0006AB80 File Offset: 0x00068D80
		// (set) Token: 0x0600136D RID: 4973 RVA: 0x0000840C File Offset: 0x0000660C
		public unsafe bool isNullable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_isNullable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_isNullable)) = value;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x0600136E RID: 4974 RVA: 0x0006ABA8 File Offset: 0x00068DA8
		// (set) Token: 0x0600136F RID: 4975 RVA: 0x00008427 File Offset: 0x00006627
		public unsafe bool isNullableSpecified
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_isNullableSpecified);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_isNullableSpecified)) = value;
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001370 RID: 4976 RVA: 0x0006ABD0 File Offset: 0x00068DD0
		// (set) Token: 0x06001371 RID: 4977 RVA: 0x00008442 File Offset: 0x00006642
		public unsafe int nestingLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_nestingLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_nestingLevel)) = value;
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06001372 RID: 4978 RVA: 0x0006ABF8 File Offset: 0x00068DF8
		// (set) Token: 0x06001373 RID: 4979 RVA: 0x0000845D File Offset: 0x0000665D
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlArrayItemAttribute.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FA6 RID: 4006
		private static readonly IntPtr NativeFieldInfoPtr_dataType;

		// Token: 0x04000FA7 RID: 4007
		private static readonly IntPtr NativeFieldInfoPtr_elementName;

		// Token: 0x04000FA8 RID: 4008
		private static readonly IntPtr NativeFieldInfoPtr_form;

		// Token: 0x04000FA9 RID: 4009
		private static readonly IntPtr NativeFieldInfoPtr_ns;

		// Token: 0x04000FAA RID: 4010
		private static readonly IntPtr NativeFieldInfoPtr_isNullable;

		// Token: 0x04000FAB RID: 4011
		private static readonly IntPtr NativeFieldInfoPtr_isNullableSpecified;

		// Token: 0x04000FAC RID: 4012
		private static readonly IntPtr NativeFieldInfoPtr_nestingLevel;

		// Token: 0x04000FAD RID: 4013
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000FAE RID: 4014
		private static readonly IntPtr NativeMethodInfoPtr_get_DataType_Public_get_String_0;

		// Token: 0x04000FAF RID: 4015
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementName_Public_get_String_0;

		// Token: 0x04000FB0 RID: 4016
		private static readonly IntPtr NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0;

		// Token: 0x04000FB1 RID: 4017
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_String_0;

		// Token: 0x04000FB2 RID: 4018
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNullable_Public_get_Boolean_0;

		// Token: 0x04000FB3 RID: 4019
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNullableSpecified_Internal_get_Boolean_0;

		// Token: 0x04000FB4 RID: 4020
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_Type_0;

		// Token: 0x04000FB5 RID: 4021
		private static readonly IntPtr NativeMethodInfoPtr_get_NestingLevel_Public_get_Int32_0;

		// Token: 0x04000FB6 RID: 4022
		private static readonly IntPtr NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0;
	}
}

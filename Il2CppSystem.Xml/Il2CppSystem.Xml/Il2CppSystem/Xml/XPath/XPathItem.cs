using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml.XPath
{
	// Token: 0x020000AD RID: 173
	public class XPathItem : Object
	{
		// Token: 0x06001212 RID: 4626 RVA: 0x00065DF4 File Offset: 0x00063FF4
		// Note: this type is marked as 'beforefieldinit'.
		static XPathItem()
		{
			Il2CppClassPointerStore<XPathItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.XPath", "XPathItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathItem>.NativeClassPtr);
			XPathItem.NativeMethodInfoPtr_get_XmlType_Public_Abstract_Virtual_New_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathItem>.NativeClassPtr, 100666280);
			XPathItem.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathItem>.NativeClassPtr, 100666281);
			XPathItem.NativeMethodInfoPtr_get_TypedValue_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathItem>.NativeClassPtr, 100666282);
			XPathItem.NativeMethodInfoPtr_get_ValueType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathItem>.NativeClassPtr, 100666283);
			XPathItem.NativeMethodInfoPtr_get_ValueAsBoolean_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathItem>.NativeClassPtr, 100666284);
			XPathItem.NativeMethodInfoPtr_get_ValueAsDateTime_Public_Abstract_Virtual_New_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathItem>.NativeClassPtr, 100666285);
			XPathItem.NativeMethodInfoPtr_get_ValueAsDouble_Public_Abstract_Virtual_New_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathItem>.NativeClassPtr, 100666286);
			XPathItem.NativeMethodInfoPtr_get_ValueAsInt_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathItem>.NativeClassPtr, 100666287);
			XPathItem.NativeMethodInfoPtr_get_ValueAsLong_Public_Abstract_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathItem>.NativeClassPtr, 100666288);
			XPathItem.NativeMethodInfoPtr_ValueAs_Public_Virtual_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathItem>.NativeClassPtr, 100666289);
			XPathItem.NativeMethodInfoPtr_ValueAs_Public_Abstract_Virtual_New_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathItem>.NativeClassPtr, 100666290);
			XPathItem.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathItem>.NativeClassPtr, 100666291);
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x00065F14 File Offset: 0x00064114
		public unsafe virtual XmlSchemaType XmlType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathItem.NativeMethodInfoPtr_get_XmlType_Public_Abstract_Virtual_New_get_XmlSchemaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001214 RID: 4628 RVA: 0x00065F60 File Offset: 0x00064160
		public unsafe virtual string Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathItem.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x00065FA4 File Offset: 0x000641A4
		public unsafe virtual Object TypedValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathItem.NativeMethodInfoPtr_get_TypedValue_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001216 RID: 4630 RVA: 0x00065FF0 File Offset: 0x000641F0
		public unsafe virtual Type ValueType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathItem.NativeMethodInfoPtr_get_ValueType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x0006603C File Offset: 0x0006423C
		public unsafe virtual bool ValueAsBoolean
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathItem.NativeMethodInfoPtr_get_ValueAsBoolean_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001218 RID: 4632 RVA: 0x00066084 File Offset: 0x00064284
		public unsafe virtual DateTime ValueAsDateTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathItem.NativeMethodInfoPtr_get_ValueAsDateTime_Public_Abstract_Virtual_New_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001219 RID: 4633 RVA: 0x000660CC File Offset: 0x000642CC
		public unsafe virtual double ValueAsDouble
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathItem.NativeMethodInfoPtr_get_ValueAsDouble_Public_Abstract_Virtual_New_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x0600121A RID: 4634 RVA: 0x00066114 File Offset: 0x00064314
		public unsafe virtual int ValueAsInt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathItem.NativeMethodInfoPtr_get_ValueAsInt_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x0006615C File Offset: 0x0006435C
		public unsafe virtual long ValueAsLong
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathItem.NativeMethodInfoPtr_get_ValueAsLong_Public_Abstract_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x000661A4 File Offset: 0x000643A4
		[CallerCount(0)]
		public unsafe virtual Object ValueAs(Type returnType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(returnType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathItem.NativeMethodInfoPtr_ValueAs_Public_Virtual_New_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x00066200 File Offset: 0x00064400
		[CallerCount(0)]
		public unsafe virtual Object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(returnType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathItem.NativeMethodInfoPtr_ValueAs_Public_Abstract_Virtual_New_Object_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x00066270 File Offset: 0x00064470
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XPathItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathItem.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x00007B65 File Offset: 0x00005D65
		public XPathItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EC4 RID: 3780
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlType_Public_Abstract_Virtual_New_get_XmlSchemaType_0;

		// Token: 0x04000EC5 RID: 3781
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000EC6 RID: 3782
		private static readonly IntPtr NativeMethodInfoPtr_get_TypedValue_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x04000EC7 RID: 3783
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04000EC8 RID: 3784
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsBoolean_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000EC9 RID: 3785
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsDateTime_Public_Abstract_Virtual_New_get_DateTime_0;

		// Token: 0x04000ECA RID: 3786
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsDouble_Public_Abstract_Virtual_New_get_Double_0;

		// Token: 0x04000ECB RID: 3787
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsInt_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000ECC RID: 3788
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsLong_Public_Abstract_Virtual_New_get_Int64_0;

		// Token: 0x04000ECD RID: 3789
		private static readonly IntPtr NativeMethodInfoPtr_ValueAs_Public_Virtual_New_Object_Type_0;

		// Token: 0x04000ECE RID: 3790
		private static readonly IntPtr NativeMethodInfoPtr_ValueAs_Public_Abstract_Virtual_New_Object_Type_IXmlNamespaceResolver_0;

		// Token: 0x04000ECF RID: 3791
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Xml.XPath;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000195 RID: 405
	public sealed class XmlAtomicValue : XPathItem
	{
		// Token: 0x0600230B RID: 8971 RVA: 0x000A75E4 File Offset: 0x000A57E4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAtomicValue()
		{
			Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlAtomicValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr);
			XmlAtomicValue.NativeFieldInfoPtr_xmlType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, "xmlType");
			XmlAtomicValue.NativeFieldInfoPtr_objVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, "objVal");
			XmlAtomicValue.NativeFieldInfoPtr_clrType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, "clrType");
			XmlAtomicValue.NativeFieldInfoPtr_unionVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, "unionVal");
			XmlAtomicValue.NativeFieldInfoPtr_nsPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, "nsPrefix");
			XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100668392);
			XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100668393);
			XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100668394);
			XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100668395);
			XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100668396);
			XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100668397);
			XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_String_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100668398);
			XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100668399);
			XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Object_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100668400);
			XmlAtomicValue.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100668401);
			XmlAtomicValue.NativeMethodInfoPtr_get_XmlType_Public_Virtual_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100668402);
			XmlAtomicValue.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100668403);
			XmlAtomicValue.NativeMethodInfoPtr_get_TypedValue_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100668404);
			XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsBoolean_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100668405);
			XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsDateTime_Public_Virtual_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100668406);
			XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsDouble_Public_Virtual_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100668407);
			XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsInt_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100668408);
			XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsLong_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100668409);
			XmlAtomicValue.NativeMethodInfoPtr_ValueAs_Public_Virtual_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100668410);
			XmlAtomicValue.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100668411);
			XmlAtomicValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100668412);
			XmlAtomicValue.NativeMethodInfoPtr_GetPrefixFromQName_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100668413);
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x000A7830 File Offset: 0x000A5A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410374, XrefRangeEnd = 410376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAtomicValue(XmlSchemaType xmlType, bool value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x000A788C File Offset: 0x000A5A8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 410378, RefRangeEnd = 410380, XrefRangeStart = 410376, XrefRangeEnd = 410378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAtomicValue(XmlSchemaType xmlType, DateTime value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x000A78E8 File Offset: 0x000A5AE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 410382, RefRangeEnd = 410384, XrefRangeStart = 410380, XrefRangeEnd = 410382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAtomicValue(XmlSchemaType xmlType, double value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x000A7944 File Offset: 0x000A5B44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 410386, RefRangeEnd = 410388, XrefRangeStart = 410384, XrefRangeEnd = 410386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAtomicValue(XmlSchemaType xmlType, int value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002310 RID: 8976 RVA: 0x000A79A0 File Offset: 0x000A5BA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 410390, RefRangeEnd = 410392, XrefRangeStart = 410388, XrefRangeEnd = 410390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAtomicValue(XmlSchemaType xmlType, long value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002311 RID: 8977 RVA: 0x000A79FC File Offset: 0x000A5BFC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 410407, RefRangeEnd = 410418, XrefRangeStart = 410392, XrefRangeEnd = 410407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAtomicValue(XmlSchemaType xmlType, string value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002312 RID: 8978 RVA: 0x000A7A5C File Offset: 0x000A5C5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 410439, RefRangeEnd = 410440, XrefRangeStart = 410418, XrefRangeEnd = 410439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAtomicValue(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_String_IXmlNamespaceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x000A7ACC File Offset: 0x000A5CCC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 410455, RefRangeEnd = 410466, XrefRangeStart = 410440, XrefRangeEnd = 410455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAtomicValue(XmlSchemaType xmlType, Object value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002314 RID: 8980 RVA: 0x000A7B2C File Offset: 0x000A5D2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 410481, RefRangeEnd = 410484, XrefRangeStart = 410466, XrefRangeEnd = 410481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAtomicValue(XmlSchemaType xmlType, Object value, IXmlNamespaceResolver nsResolver)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Object_IXmlNamespaceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x000A7B9C File Offset: 0x000A5D9C
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object System_ICloneable_Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06002316 RID: 8982 RVA: 0x000A7BDC File Offset: 0x000A5DDC
		public unsafe override XmlSchemaType XmlType
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_get_XmlType_Public_Virtual_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06002317 RID: 8983 RVA: 0x000A7C1C File Offset: 0x000A5E1C
		public unsafe override Type ValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410484, XrefRangeEnd = 410485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06002318 RID: 8984 RVA: 0x000A7C5C File Offset: 0x000A5E5C
		public unsafe override Object TypedValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410485, XrefRangeEnd = 410486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_get_TypedValue_Public_Virtual_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06002319 RID: 8985 RVA: 0x000A7C9C File Offset: 0x000A5E9C
		public unsafe override bool ValueAsBoolean
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410486, XrefRangeEnd = 410487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsBoolean_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x0600231A RID: 8986 RVA: 0x000A7CD8 File Offset: 0x000A5ED8
		public unsafe override DateTime ValueAsDateTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410487, XrefRangeEnd = 410488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsDateTime_Public_Virtual_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x0600231B RID: 8987 RVA: 0x000A7D14 File Offset: 0x000A5F14
		public unsafe override double ValueAsDouble
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410488, XrefRangeEnd = 410489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsDouble_Public_Virtual_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x0600231C RID: 8988 RVA: 0x000A7D50 File Offset: 0x000A5F50
		public unsafe override int ValueAsInt
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410489, XrefRangeEnd = 410490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsInt_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x0600231D RID: 8989 RVA: 0x000A7D8C File Offset: 0x000A5F8C
		public unsafe override long ValueAsLong
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410490, XrefRangeEnd = 410491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsLong_Public_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x000A7DC8 File Offset: 0x000A5FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410491, XrefRangeEnd = 410505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ValueAs(Type type, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_ValueAs_Public_Virtual_Object_Type_IXmlNamespaceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x0600231F RID: 8991 RVA: 0x000A7E2C File Offset: 0x000A602C
		public unsafe override string Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410505, XrefRangeEnd = 410507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x000A7E64 File Offset: 0x000A6064
		[CallerCount(0)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x000A7E9C File Offset: 0x000A609C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410507, XrefRangeEnd = 410513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPrefixFromQName(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_GetPrefixFromQName_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x0000EDA2 File Offset: 0x0000CFA2
		public XmlAtomicValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06002323 RID: 8995 RVA: 0x000A7EE4 File Offset: 0x000A60E4
		// (set) Token: 0x06002324 RID: 8996 RVA: 0x0000EDAB File Offset: 0x0000CFAB
		public unsafe XmlSchemaType xmlType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_xmlType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_xmlType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06002325 RID: 8997 RVA: 0x000A7F14 File Offset: 0x000A6114
		// (set) Token: 0x06002326 RID: 8998 RVA: 0x0000EDCA File Offset: 0x0000CFCA
		public unsafe Object objVal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_objVal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_objVal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06002327 RID: 8999 RVA: 0x000A7F44 File Offset: 0x000A6144
		// (set) Token: 0x06002328 RID: 9000 RVA: 0x0000EDE9 File Offset: 0x0000CFE9
		public unsafe TypeCode clrType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_clrType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_clrType)) = value;
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06002329 RID: 9001 RVA: 0x000A7F6C File Offset: 0x000A616C
		// (set) Token: 0x0600232A RID: 9002 RVA: 0x0000EE04 File Offset: 0x0000D004
		public unsafe XmlAtomicValue.Union unionVal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_unionVal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_unionVal)) = value;
			}
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x0600232B RID: 9003 RVA: 0x000A7F94 File Offset: 0x000A6194
		// (set) Token: 0x0600232C RID: 9004 RVA: 0x0000EE1F File Offset: 0x0000D01F
		public unsafe XmlAtomicValue.NamespacePrefixForQName nsPrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_nsPrefix);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlAtomicValue.NamespacePrefixForQName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_nsPrefix), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A7D RID: 6781
		private static readonly IntPtr NativeFieldInfoPtr_xmlType;

		// Token: 0x04001A7E RID: 6782
		private static readonly IntPtr NativeFieldInfoPtr_objVal;

		// Token: 0x04001A7F RID: 6783
		private static readonly IntPtr NativeFieldInfoPtr_clrType;

		// Token: 0x04001A80 RID: 6784
		private static readonly IntPtr NativeFieldInfoPtr_unionVal;

		// Token: 0x04001A81 RID: 6785
		private static readonly IntPtr NativeFieldInfoPtr_nsPrefix;

		// Token: 0x04001A82 RID: 6786
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Boolean_0;

		// Token: 0x04001A83 RID: 6787
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_DateTime_0;

		// Token: 0x04001A84 RID: 6788
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Double_0;

		// Token: 0x04001A85 RID: 6789
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Int32_0;

		// Token: 0x04001A86 RID: 6790
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Int64_0;

		// Token: 0x04001A87 RID: 6791
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_String_0;

		// Token: 0x04001A88 RID: 6792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_String_IXmlNamespaceResolver_0;

		// Token: 0x04001A89 RID: 6793
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Object_0;

		// Token: 0x04001A8A RID: 6794
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Object_IXmlNamespaceResolver_0;

		// Token: 0x04001A8B RID: 6795
		private static readonly IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;

		// Token: 0x04001A8C RID: 6796
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlType_Public_Virtual_get_XmlSchemaType_0;

		// Token: 0x04001A8D RID: 6797
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0;

		// Token: 0x04001A8E RID: 6798
		private static readonly IntPtr NativeMethodInfoPtr_get_TypedValue_Public_Virtual_get_Object_0;

		// Token: 0x04001A8F RID: 6799
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsBoolean_Public_Virtual_get_Boolean_0;

		// Token: 0x04001A90 RID: 6800
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsDateTime_Public_Virtual_get_DateTime_0;

		// Token: 0x04001A91 RID: 6801
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsDouble_Public_Virtual_get_Double_0;

		// Token: 0x04001A92 RID: 6802
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsInt_Public_Virtual_get_Int32_0;

		// Token: 0x04001A93 RID: 6803
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsLong_Public_Virtual_get_Int64_0;

		// Token: 0x04001A94 RID: 6804
		private static readonly IntPtr NativeMethodInfoPtr_ValueAs_Public_Virtual_Object_Type_IXmlNamespaceResolver_0;

		// Token: 0x04001A95 RID: 6805
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0;

		// Token: 0x04001A96 RID: 6806
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001A97 RID: 6807
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefixFromQName_Private_String_String_0;

		// Token: 0x0200026A RID: 618
		[StructLayout(2)]
		public struct Union
		{
			// Token: 0x06003240 RID: 12864 RVA: 0x000DF228 File Offset: 0x000DD428
			// Note: this type is marked as 'beforefieldinit'.
			static Union()
			{
				Il2CppClassPointerStore<XmlAtomicValue.Union>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, "Union");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAtomicValue.Union>.NativeClassPtr);
				XmlAtomicValue.Union.NativeFieldInfoPtr_boolVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue.Union>.NativeClassPtr, "boolVal");
				XmlAtomicValue.Union.NativeFieldInfoPtr_dblVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue.Union>.NativeClassPtr, "dblVal");
				XmlAtomicValue.Union.NativeFieldInfoPtr_i64Val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue.Union>.NativeClassPtr, "i64Val");
				XmlAtomicValue.Union.NativeFieldInfoPtr_i32Val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue.Union>.NativeClassPtr, "i32Val");
				XmlAtomicValue.Union.NativeFieldInfoPtr_dtVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue.Union>.NativeClassPtr, "dtVal");
			}

			// Token: 0x06003241 RID: 12865 RVA: 0x0001584B File Offset: 0x00013A4B
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlAtomicValue.Union>.NativeClassPtr, ref this));
			}

			// Token: 0x04002738 RID: 10040
			private static readonly IntPtr NativeFieldInfoPtr_boolVal;

			// Token: 0x04002739 RID: 10041
			private static readonly IntPtr NativeFieldInfoPtr_dblVal;

			// Token: 0x0400273A RID: 10042
			private static readonly IntPtr NativeFieldInfoPtr_i64Val;

			// Token: 0x0400273B RID: 10043
			private static readonly IntPtr NativeFieldInfoPtr_i32Val;

			// Token: 0x0400273C RID: 10044
			private static readonly IntPtr NativeFieldInfoPtr_dtVal;

			// Token: 0x0400273D RID: 10045
			[FieldOffset(0)]
			[MarshalAs(4)]
			public bool boolVal;

			// Token: 0x0400273E RID: 10046
			[FieldOffset(0)]
			public double dblVal;

			// Token: 0x0400273F RID: 10047
			[FieldOffset(0)]
			public long i64Val;

			// Token: 0x04002740 RID: 10048
			[FieldOffset(0)]
			public int i32Val;

			// Token: 0x04002741 RID: 10049
			[FieldOffset(0)]
			public DateTime dtVal;
		}

		// Token: 0x0200026B RID: 619
		public class NamespacePrefixForQName : Object
		{
			// Token: 0x06003242 RID: 12866 RVA: 0x000DF2B8 File Offset: 0x000DD4B8
			// Note: this type is marked as 'beforefieldinit'.
			static NamespacePrefixForQName()
			{
				Il2CppClassPointerStore<XmlAtomicValue.NamespacePrefixForQName>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, "NamespacePrefixForQName");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAtomicValue.NamespacePrefixForQName>.NativeClassPtr);
				XmlAtomicValue.NamespacePrefixForQName.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue.NamespacePrefixForQName>.NativeClassPtr, "prefix");
				XmlAtomicValue.NamespacePrefixForQName.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue.NamespacePrefixForQName>.NativeClassPtr, "ns");
				XmlAtomicValue.NamespacePrefixForQName.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue.NamespacePrefixForQName>.NativeClassPtr, 100668414);
				XmlAtomicValue.NamespacePrefixForQName.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue.NamespacePrefixForQName>.NativeClassPtr, 100668415);
				XmlAtomicValue.NamespacePrefixForQName.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue.NamespacePrefixForQName>.NativeClassPtr, 100668416);
				XmlAtomicValue.NamespacePrefixForQName.NativeMethodInfoPtr_GetNamespacesInScope_Public_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue.NamespacePrefixForQName>.NativeClassPtr, 100668417);
			}

			// Token: 0x06003243 RID: 12867 RVA: 0x000DF35C File Offset: 0x000DD55C
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 410349, RefRangeEnd = 410363, XrefRangeStart = 410346, XrefRangeEnd = 410349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NamespacePrefixForQName(string prefix, string ns)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue.NamespacePrefixForQName>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NamespacePrefixForQName.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003244 RID: 12868 RVA: 0x000DF3BC File Offset: 0x000DD5BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410363, XrefRangeEnd = 410364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual string LookupNamespace(string prefix)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NamespacePrefixForQName.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06003245 RID: 12869 RVA: 0x000DF404 File Offset: 0x000DD604
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410364, XrefRangeEnd = 410365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual string LookupPrefix(string namespaceName)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NamespacePrefixForQName.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06003246 RID: 12870 RVA: 0x000DF44C File Offset: 0x000DD64C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410365, XrefRangeEnd = 410374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref scope;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NamespacePrefixForQName.NativeMethodInfoPtr_GetNamespacesInScope_Public_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
				}
			}

			// Token: 0x06003247 RID: 12871 RVA: 0x0001585D File Offset: 0x00013A5D
			public NamespacePrefixForQName(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010E8 RID: 4328
			// (get) Token: 0x06003248 RID: 12872 RVA: 0x000DF498 File Offset: 0x000DD698
			// (set) Token: 0x06003249 RID: 12873 RVA: 0x00015866 File Offset: 0x00013A66
			public unsafe string prefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NamespacePrefixForQName.NativeFieldInfoPtr_prefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NamespacePrefixForQName.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170010E9 RID: 4329
			// (get) Token: 0x0600324A RID: 12874 RVA: 0x000DF4C0 File Offset: 0x000DD6C0
			// (set) Token: 0x0600324B RID: 12875 RVA: 0x00015885 File Offset: 0x00013A85
			public unsafe string ns
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NamespacePrefixForQName.NativeFieldInfoPtr_ns);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NamespacePrefixForQName.NativeFieldInfoPtr_ns), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04002742 RID: 10050
			private static readonly IntPtr NativeFieldInfoPtr_prefix;

			// Token: 0x04002743 RID: 10051
			private static readonly IntPtr NativeFieldInfoPtr_ns;

			// Token: 0x04002744 RID: 10052
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

			// Token: 0x04002745 RID: 10053
			private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Virtual_Final_New_String_String_0;

			// Token: 0x04002746 RID: 10054
			private static readonly IntPtr NativeMethodInfoPtr_LookupPrefix_Public_Virtual_Final_New_String_String_0;

			// Token: 0x04002747 RID: 10055
			private static readonly IntPtr NativeMethodInfoPtr_GetNamespacesInScope_Public_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0;
		}
	}
}

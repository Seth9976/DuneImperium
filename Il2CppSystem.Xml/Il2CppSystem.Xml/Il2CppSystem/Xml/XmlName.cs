using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000070 RID: 112
	public class XmlName : Object
	{
		// Token: 0x06000D94 RID: 3476 RVA: 0x0005121C File Offset: 0x0004F41C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlName()
		{
			Il2CppClassPointerStore<XmlName>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlName>.NativeClassPtr);
			XmlName.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlName>.NativeClassPtr, "prefix");
			XmlName.NativeFieldInfoPtr_localName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlName>.NativeClassPtr, "localName");
			XmlName.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlName>.NativeClassPtr, "ns");
			XmlName.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlName>.NativeClassPtr, "name");
			XmlName.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlName>.NativeClassPtr, "hashCode");
			XmlName.NativeFieldInfoPtr_ownerDoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlName>.NativeClassPtr, "ownerDoc");
			XmlName.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlName>.NativeClassPtr, "next");
			XmlName.NativeMethodInfoPtr_Create_Public_Static_XmlName_String_String_String_Int32_XmlDocument_XmlName_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100665515);
			XmlName.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_Int32_XmlDocument_XmlName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100665516);
			XmlName.NativeMethodInfoPtr_get_LocalName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100665517);
			XmlName.NativeMethodInfoPtr_get_NamespaceURI_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100665518);
			XmlName.NativeMethodInfoPtr_get_Prefix_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100665519);
			XmlName.NativeMethodInfoPtr_get_HashCode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100665520);
			XmlName.NativeMethodInfoPtr_get_OwnerDocument_Public_get_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100665521);
			XmlName.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100665522);
			XmlName.NativeMethodInfoPtr_get_Validity_Public_Virtual_New_get_XmlSchemaValidity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100665523);
			XmlName.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100665524);
			XmlName.NativeMethodInfoPtr_get_IsNil_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100665525);
			XmlName.NativeMethodInfoPtr_get_MemberType_Public_Virtual_New_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100665526);
			XmlName.NativeMethodInfoPtr_get_SchemaType_Public_Virtual_New_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100665527);
			XmlName.NativeMethodInfoPtr_get_SchemaElement_Public_Virtual_New_get_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100665528);
			XmlName.NativeMethodInfoPtr_get_SchemaAttribute_Public_Virtual_New_get_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100665529);
			XmlName.NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100665530);
			XmlName.NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100665531);
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x0005142C File Offset: 0x0004F62C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 375163, RefRangeEnd = 375164, XrefRangeStart = 375154, XrefRangeEnd = 375163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlName Create(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ownerDoc);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(next);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlName.NativeMethodInfoPtr_Create_Public_Static_XmlName_String_String_String_Int32_XmlDocument_XmlName_IXmlSchemaInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlName>(intPtr3) : null;
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x000514DC File Offset: 0x0004F6DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 375171, RefRangeEnd = 375173, XrefRangeStart = 375164, XrefRangeEnd = 375171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlName(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlName>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ownerDoc);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(next);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlName.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_Int32_XmlDocument_XmlName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x00051580 File Offset: 0x0004F780
		public unsafe string LocalName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlName.NativeMethodInfoPtr_get_LocalName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x000515B8 File Offset: 0x0004F7B8
		public unsafe string NamespaceURI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlName.NativeMethodInfoPtr_get_NamespaceURI_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x000515F0 File Offset: 0x0004F7F0
		public unsafe string Prefix
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlName.NativeMethodInfoPtr_get_Prefix_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000D9A RID: 3482 RVA: 0x00051628 File Offset: 0x0004F828
		public unsafe int HashCode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlName.NativeMethodInfoPtr_get_HashCode_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x00051664 File Offset: 0x0004F864
		public unsafe XmlDocument OwnerDocument
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlName.NativeMethodInfoPtr_get_OwnerDocument_Public_get_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr3) : null;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x000516A4 File Offset: 0x0004F8A4
		public unsafe string Name
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 375175, RefRangeEnd = 375177, XrefRangeStart = 375173, XrefRangeEnd = 375175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlName.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x000516DC File Offset: 0x0004F8DC
		public unsafe virtual XmlSchemaValidity Validity
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlName.NativeMethodInfoPtr_get_Validity_Public_Virtual_New_get_XmlSchemaValidity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x00051724 File Offset: 0x0004F924
		public unsafe virtual bool IsDefault
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlName.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x0005176C File Offset: 0x0004F96C
		public unsafe virtual bool IsNil
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlName.NativeMethodInfoPtr_get_IsNil_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x000517B4 File Offset: 0x0004F9B4
		public unsafe virtual XmlSchemaSimpleType MemberType
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlName.NativeMethodInfoPtr_get_MemberType_Public_Virtual_New_get_XmlSchemaSimpleType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x00051800 File Offset: 0x0004FA00
		public unsafe virtual XmlSchemaType SchemaType
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlName.NativeMethodInfoPtr_get_SchemaType_Public_Virtual_New_get_XmlSchemaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x0005184C File Offset: 0x0004FA4C
		public unsafe virtual XmlSchemaElement SchemaElement
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlName.NativeMethodInfoPtr_get_SchemaElement_Public_Virtual_New_get_XmlSchemaElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr3) : null;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x00051898 File Offset: 0x0004FA98
		public unsafe virtual XmlSchemaAttribute SchemaAttribute
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlName.NativeMethodInfoPtr_get_SchemaAttribute_Public_Virtual_New_get_XmlSchemaAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x000518E4 File Offset: 0x0004FAE4
		[CallerCount(0)]
		public unsafe virtual bool Equals(IXmlSchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlName.NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_IXmlSchemaInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x0005193C File Offset: 0x0004FB3C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 375178, RefRangeEnd = 375184, XrefRangeStart = 375177, XrefRangeEnd = 375178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHashCode(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlName.NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00006839 File Offset: 0x00004A39
		public XmlName(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x00051980 File Offset: 0x0004FB80
		// (set) Token: 0x06000DA8 RID: 3496 RVA: 0x00006842 File Offset: 0x00004A42
		public unsafe string prefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_prefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000DA9 RID: 3497 RVA: 0x000519A8 File Offset: 0x0004FBA8
		// (set) Token: 0x06000DAA RID: 3498 RVA: 0x00006861 File Offset: 0x00004A61
		public unsafe string localName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_localName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_localName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000DAB RID: 3499 RVA: 0x000519D0 File Offset: 0x0004FBD0
		// (set) Token: 0x06000DAC RID: 3500 RVA: 0x00006880 File Offset: 0x00004A80
		public unsafe string ns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_ns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_ns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000DAD RID: 3501 RVA: 0x000519F8 File Offset: 0x0004FBF8
		// (set) Token: 0x06000DAE RID: 3502 RVA: 0x0000689F File Offset: 0x00004A9F
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000DAF RID: 3503 RVA: 0x00051A20 File Offset: 0x0004FC20
		// (set) Token: 0x06000DB0 RID: 3504 RVA: 0x000068BE File Offset: 0x00004ABE
		public unsafe int hashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_hashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_hashCode)) = value;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x00051A48 File Offset: 0x0004FC48
		// (set) Token: 0x06000DB2 RID: 3506 RVA: 0x000068D9 File Offset: 0x00004AD9
		public unsafe XmlDocument ownerDoc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_ownerDoc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_ownerDoc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x00051A78 File Offset: 0x0004FC78
		// (set) Token: 0x06000DB4 RID: 3508 RVA: 0x000068F8 File Offset: 0x00004AF8
		public unsafe XmlName next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B14 RID: 2836
		private static readonly IntPtr NativeFieldInfoPtr_prefix;

		// Token: 0x04000B15 RID: 2837
		private static readonly IntPtr NativeFieldInfoPtr_localName;

		// Token: 0x04000B16 RID: 2838
		private static readonly IntPtr NativeFieldInfoPtr_ns;

		// Token: 0x04000B17 RID: 2839
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000B18 RID: 2840
		private static readonly IntPtr NativeFieldInfoPtr_hashCode;

		// Token: 0x04000B19 RID: 2841
		private static readonly IntPtr NativeFieldInfoPtr_ownerDoc;

		// Token: 0x04000B1A RID: 2842
		private static readonly IntPtr NativeFieldInfoPtr_next;

		// Token: 0x04000B1B RID: 2843
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_XmlName_String_String_String_Int32_XmlDocument_XmlName_IXmlSchemaInfo_0;

		// Token: 0x04000B1C RID: 2844
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_Int32_XmlDocument_XmlName_0;

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_get_String_0;

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceURI_Public_get_String_0;

		// Token: 0x04000B1F RID: 2847
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_get_String_0;

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeMethodInfoPtr_get_HashCode_Public_get_Int32_0;

		// Token: 0x04000B21 RID: 2849
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnerDocument_Public_get_XmlDocument_0;

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000B23 RID: 2851
		private static readonly IntPtr NativeMethodInfoPtr_get_Validity_Public_Virtual_New_get_XmlSchemaValidity_0;

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefault_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNil_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_Virtual_New_get_XmlSchemaSimpleType_0;

		// Token: 0x04000B27 RID: 2855
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaType_Public_Virtual_New_get_XmlSchemaType_0;

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaElement_Public_Virtual_New_get_XmlSchemaElement_0;

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaAttribute_Public_Virtual_New_get_XmlSchemaAttribute_0;

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_IXmlSchemaInfo_0;

		// Token: 0x04000B2B RID: 2859
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_String_0;
	}
}

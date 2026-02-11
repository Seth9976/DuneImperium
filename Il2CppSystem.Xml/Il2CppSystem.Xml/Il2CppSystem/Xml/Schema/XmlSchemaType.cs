using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001E1 RID: 481
	public class XmlSchemaType : XmlSchemaAnnotated
	{
		// Token: 0x06002826 RID: 10278 RVA: 0x000BAB2C File Offset: 0x000B8D2C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaType()
		{
			Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr);
			XmlSchemaType.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, "name");
			XmlSchemaType.NativeFieldInfoPtr_final = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, "final");
			XmlSchemaType.NativeFieldInfoPtr_derivedBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, "derivedBy");
			XmlSchemaType.NativeFieldInfoPtr_baseSchemaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, "baseSchemaType");
			XmlSchemaType.NativeFieldInfoPtr_datatype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, "datatype");
			XmlSchemaType.NativeFieldInfoPtr_finalResolved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, "finalResolved");
			XmlSchemaType.NativeFieldInfoPtr_elementDecl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, "elementDecl");
			XmlSchemaType.NativeFieldInfoPtr_qname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, "qname");
			XmlSchemaType.NativeFieldInfoPtr_redefined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, "redefined");
			XmlSchemaType.NativeFieldInfoPtr_contentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, "contentType");
			XmlSchemaType.NativeMethodInfoPtr_GetBuiltInSimpleType_Public_Static_XmlSchemaSimpleType_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669098);
			XmlSchemaType.NativeMethodInfoPtr_GetBuiltInSimpleType_Public_Static_XmlSchemaSimpleType_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669099);
			XmlSchemaType.NativeMethodInfoPtr_GetBuiltInComplexType_Public_Static_XmlSchemaComplexType_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669100);
			XmlSchemaType.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669101);
			XmlSchemaType.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669102);
			XmlSchemaType.NativeMethodInfoPtr_get_Final_Public_get_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669103);
			XmlSchemaType.NativeMethodInfoPtr_set_Final_Public_set_Void_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669104);
			XmlSchemaType.NativeMethodInfoPtr_get_QualifiedName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669105);
			XmlSchemaType.NativeMethodInfoPtr_get_FinalResolved_Public_get_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669106);
			XmlSchemaType.NativeMethodInfoPtr_get_BaseXmlSchemaType_Public_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669107);
			XmlSchemaType.NativeMethodInfoPtr_get_DerivedBy_Public_get_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669108);
			XmlSchemaType.NativeMethodInfoPtr_get_Datatype_Public_get_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669109);
			XmlSchemaType.NativeMethodInfoPtr_get_IsMixed_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669110);
			XmlSchemaType.NativeMethodInfoPtr_set_IsMixed_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669111);
			XmlSchemaType.NativeMethodInfoPtr_get_TypeCode_Public_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669112);
			XmlSchemaType.NativeMethodInfoPtr_get_ValueConverter_Internal_get_XmlValueConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669113);
			XmlSchemaType.NativeMethodInfoPtr_get_SchemaContentType_Internal_get_XmlSchemaContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669114);
			XmlSchemaType.NativeMethodInfoPtr_SetQualifiedName_Internal_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669115);
			XmlSchemaType.NativeMethodInfoPtr_SetFinalResolved_Internal_Void_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669116);
			XmlSchemaType.NativeMethodInfoPtr_SetBaseSchemaType_Internal_Void_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669117);
			XmlSchemaType.NativeMethodInfoPtr_SetDerivedBy_Internal_Void_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669118);
			XmlSchemaType.NativeMethodInfoPtr_SetDatatype_Internal_Void_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669119);
			XmlSchemaType.NativeMethodInfoPtr_get_ElementDecl_Internal_get_SchemaElementDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669120);
			XmlSchemaType.NativeMethodInfoPtr_set_ElementDecl_Internal_set_Void_SchemaElementDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669121);
			XmlSchemaType.NativeMethodInfoPtr_get_Redefined_Internal_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669122);
			XmlSchemaType.NativeMethodInfoPtr_set_Redefined_Internal_set_Void_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669123);
			XmlSchemaType.NativeMethodInfoPtr_SetContentType_Internal_Void_XmlSchemaContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669124);
			XmlSchemaType.NativeMethodInfoPtr_IsDerivedFrom_Public_Static_Boolean_XmlSchemaType_XmlSchemaType_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669125);
			XmlSchemaType.NativeMethodInfoPtr_IsDerivedFromDatatype_Internal_Static_Boolean_XmlSchemaDatatype_XmlSchemaDatatype_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669126);
			XmlSchemaType.NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669127);
			XmlSchemaType.NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669128);
			XmlSchemaType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr, 100669129);
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x000BAEA4 File Offset: 0x000B90A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 414736, RefRangeEnd = 414738, XrefRangeStart = 414722, XrefRangeEnd = 414736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaSimpleType GetBuiltInSimpleType(XmlQualifiedName qualifiedName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qualifiedName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_GetBuiltInSimpleType_Public_Static_XmlSchemaSimpleType_XmlQualifiedName_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x000BAEE8 File Offset: 0x000B90E8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 414742, RefRangeEnd = 414753, XrefRangeStart = 414738, XrefRangeEnd = 414742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_GetBuiltInSimpleType_Public_Static_XmlSchemaSimpleType_XmlTypeCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x000BAF28 File Offset: 0x000B9128
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 414772, RefRangeEnd = 414775, XrefRangeStart = 414753, XrefRangeEnd = 414772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaComplexType GetBuiltInComplexType(XmlQualifiedName qualifiedName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qualifiedName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_GetBuiltInComplexType_Public_Static_XmlSchemaComplexType_XmlQualifiedName_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr3) : null;
			}
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x0600282A RID: 10282 RVA: 0x000BAF6C File Offset: 0x000B916C
		// (set) Token: 0x0600282B RID: 10283 RVA: 0x000BAFA4 File Offset: 0x000B91A4
		public unsafe string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x0600282C RID: 10284 RVA: 0x000BAFE8 File Offset: 0x000B91E8
		// (set) Token: 0x0600282D RID: 10285 RVA: 0x000BB024 File Offset: 0x000B9224
		public unsafe XmlSchemaDerivationMethod Final
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_get_Final_Public_get_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 403849, RefRangeEnd = 403852, XrefRangeStart = 403849, XrefRangeEnd = 403852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_set_Final_Public_set_Void_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x0600282E RID: 10286 RVA: 0x000BB064 File Offset: 0x000B9264
		public unsafe XmlQualifiedName QualifiedName
		{
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 414776, RefRangeEnd = 414859, XrefRangeStart = 414775, XrefRangeEnd = 414776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_get_QualifiedName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x0600282F RID: 10287 RVA: 0x000BB0A4 File Offset: 0x000B92A4
		public unsafe XmlSchemaDerivationMethod FinalResolved
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 368217, RefRangeEnd = 368218, XrefRangeStart = 368217, XrefRangeEnd = 368218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_get_FinalResolved_Public_get_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x06002830 RID: 10288 RVA: 0x000BB0E0 File Offset: 0x000B92E0
		public unsafe XmlSchemaType BaseXmlSchemaType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_get_BaseXmlSchemaType_Public_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x06002831 RID: 10289 RVA: 0x000BB120 File Offset: 0x000B9320
		public unsafe XmlSchemaDerivationMethod DerivedBy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_get_DerivedBy_Public_get_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x06002832 RID: 10290 RVA: 0x000BB15C File Offset: 0x000B935C
		public unsafe XmlSchemaDatatype Datatype
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_get_Datatype_Public_get_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
			}
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x06002833 RID: 10291 RVA: 0x000BB19C File Offset: 0x000B939C
		// (set) Token: 0x06002834 RID: 10292 RVA: 0x000BB1E4 File Offset: 0x000B93E4
		public unsafe virtual bool IsMixed
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaType.NativeMethodInfoPtr_get_IsMixed_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaType.NativeMethodInfoPtr_set_IsMixed_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x06002835 RID: 10293 RVA: 0x000BB230 File Offset: 0x000B9430
		public unsafe XmlTypeCode TypeCode
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 414866, RefRangeEnd = 414874, XrefRangeStart = 414859, XrefRangeEnd = 414866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_get_TypeCode_Public_get_XmlTypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06002836 RID: 10294 RVA: 0x000BB26C File Offset: 0x000B946C
		public unsafe XmlValueConverter ValueConverter
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 414878, RefRangeEnd = 414905, XrefRangeStart = 414874, XrefRangeEnd = 414878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_get_ValueConverter_Internal_get_XmlValueConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr3) : null;
			}
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x06002837 RID: 10295 RVA: 0x000BB2AC File Offset: 0x000B94AC
		public unsafe XmlSchemaContentType SchemaContentType
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 311826, RefRangeEnd = 311839, XrefRangeStart = 311826, XrefRangeEnd = 311839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_get_SchemaContentType_Internal_get_XmlSchemaContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x000BB2E8 File Offset: 0x000B94E8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 414907, RefRangeEnd = 414913, XrefRangeStart = 414905, XrefRangeEnd = 414907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQualifiedName(XmlQualifiedName value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_SetQualifiedName_Internal_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x000BB32C File Offset: 0x000B952C
		[CallerCount(0)]
		public unsafe void SetFinalResolved(XmlSchemaDerivationMethod value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_SetFinalResolved_Internal_Void_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x000BB36C File Offset: 0x000B956C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBaseSchemaType(XmlSchemaType value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_SetBaseSchemaType_Internal_Void_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x000BB3B0 File Offset: 0x000B95B0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 403825, RefRangeEnd = 403834, XrefRangeStart = 403825, XrefRangeEnd = 403834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDerivedBy(XmlSchemaDerivationMethod value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_SetDerivedBy_Internal_Void_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x000BB3F0 File Offset: 0x000B95F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDatatype(XmlSchemaDatatype value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_SetDatatype_Internal_Void_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x0600283D RID: 10301 RVA: 0x000BB434 File Offset: 0x000B9634
		// (set) Token: 0x0600283E RID: 10302 RVA: 0x000BB474 File Offset: 0x000B9674
		public unsafe SchemaElementDecl ElementDecl
		{
			[CallerCount(30)]
			[CachedScanResults(RefRangeStart = 414914, RefRangeEnd = 414944, XrefRangeStart = 414913, XrefRangeEnd = 414914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_get_ElementDecl_Internal_get_SchemaElementDecl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr3) : null;
			}
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 414946, RefRangeEnd = 414968, XrefRangeStart = 414944, XrefRangeEnd = 414946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_set_ElementDecl_Internal_set_Void_SchemaElementDecl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x0600283F RID: 10303 RVA: 0x000BB4B8 File Offset: 0x000B96B8
		// (set) Token: 0x06002840 RID: 10304 RVA: 0x000BB4F8 File Offset: 0x000B96F8
		public unsafe XmlSchemaType Redefined
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_get_Redefined_Internal_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_set_Redefined_Internal_set_Void_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x000BB53C File Offset: 0x000B973C
		[CallerCount(0)]
		public unsafe void SetContentType(XmlSchemaContentType value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_SetContentType_Internal_Void_XmlSchemaContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x000BB57C File Offset: 0x000B977C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 414976, RefRangeEnd = 414987, XrefRangeStart = 414968, XrefRangeEnd = 414976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDerivedFrom(XmlSchemaType derivedType, XmlSchemaType baseType, XmlSchemaDerivationMethod except)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref except;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_IsDerivedFrom_Public_Static_Boolean_XmlSchemaType_XmlSchemaType_XmlSchemaDerivationMethod_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x000BB5E0 File Offset: 0x000B97E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414987, XrefRangeEnd = 414994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDerivedFromDatatype(XmlSchemaDatatype derivedDataType, XmlSchemaDatatype baseDataType, XmlSchemaDerivationMethod except)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedDataType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseDataType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref except;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr_IsDerivedFromDatatype_Internal_Static_Boolean_XmlSchemaDatatype_XmlSchemaDatatype_XmlSchemaDerivationMethod_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x06002844 RID: 10308 RVA: 0x000BB644 File Offset: 0x000B9844
		// (set) Token: 0x06002845 RID: 10309 RVA: 0x000BB688 File Offset: 0x000B9888
		public unsafe override string NameAttribute
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaType.NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaType.NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x000BB6D8 File Offset: 0x000B98D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 414595, RefRangeEnd = 414599, XrefRangeStart = 414595, XrefRangeEnd = 414599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaType()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaType>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x0001100E File Offset: 0x0000F20E
		public XmlSchemaType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x06002848 RID: 10312 RVA: 0x000BB714 File Offset: 0x000B9914
		// (set) Token: 0x06002849 RID: 10313 RVA: 0x00011017 File Offset: 0x0000F217
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x0600284A RID: 10314 RVA: 0x000BB73C File Offset: 0x000B993C
		// (set) Token: 0x0600284B RID: 10315 RVA: 0x00011036 File Offset: 0x0000F236
		public unsafe XmlSchemaDerivationMethod final
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_final);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_final)) = value;
			}
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x0600284C RID: 10316 RVA: 0x000BB764 File Offset: 0x000B9964
		// (set) Token: 0x0600284D RID: 10317 RVA: 0x00011051 File Offset: 0x0000F251
		public unsafe XmlSchemaDerivationMethod derivedBy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_derivedBy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_derivedBy)) = value;
			}
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x0600284E RID: 10318 RVA: 0x000BB78C File Offset: 0x000B998C
		// (set) Token: 0x0600284F RID: 10319 RVA: 0x0001106C File Offset: 0x0000F26C
		public unsafe XmlSchemaType baseSchemaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_baseSchemaType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_baseSchemaType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x06002850 RID: 10320 RVA: 0x000BB7BC File Offset: 0x000B99BC
		// (set) Token: 0x06002851 RID: 10321 RVA: 0x0001108B File Offset: 0x0000F28B
		public unsafe XmlSchemaDatatype datatype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_datatype);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_datatype), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x06002852 RID: 10322 RVA: 0x000BB7EC File Offset: 0x000B99EC
		// (set) Token: 0x06002853 RID: 10323 RVA: 0x000110AA File Offset: 0x0000F2AA
		public unsafe XmlSchemaDerivationMethod finalResolved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_finalResolved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_finalResolved)) = value;
			}
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x06002854 RID: 10324 RVA: 0x000BB814 File Offset: 0x000B9A14
		// (set) Token: 0x06002855 RID: 10325 RVA: 0x000110C5 File Offset: 0x0000F2C5
		public unsafe SchemaElementDecl elementDecl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_elementDecl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_elementDecl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x06002856 RID: 10326 RVA: 0x000BB844 File Offset: 0x000B9A44
		// (set) Token: 0x06002857 RID: 10327 RVA: 0x000110E4 File Offset: 0x0000F2E4
		public unsafe XmlQualifiedName qname
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_qname);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_qname), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x06002858 RID: 10328 RVA: 0x000BB874 File Offset: 0x000B9A74
		// (set) Token: 0x06002859 RID: 10329 RVA: 0x00011103 File Offset: 0x0000F303
		public unsafe XmlSchemaType redefined
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_redefined);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_redefined), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x0600285A RID: 10330 RVA: 0x000BB8A4 File Offset: 0x000B9AA4
		// (set) Token: 0x0600285B RID: 10331 RVA: 0x00011122 File Offset: 0x0000F322
		public unsafe XmlSchemaContentType contentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_contentType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaType.NativeFieldInfoPtr_contentType)) = value;
			}
		}

		// Token: 0x04001E3D RID: 7741
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001E3E RID: 7742
		private static readonly IntPtr NativeFieldInfoPtr_final;

		// Token: 0x04001E3F RID: 7743
		private static readonly IntPtr NativeFieldInfoPtr_derivedBy;

		// Token: 0x04001E40 RID: 7744
		private static readonly IntPtr NativeFieldInfoPtr_baseSchemaType;

		// Token: 0x04001E41 RID: 7745
		private static readonly IntPtr NativeFieldInfoPtr_datatype;

		// Token: 0x04001E42 RID: 7746
		private static readonly IntPtr NativeFieldInfoPtr_finalResolved;

		// Token: 0x04001E43 RID: 7747
		private static readonly IntPtr NativeFieldInfoPtr_elementDecl;

		// Token: 0x04001E44 RID: 7748
		private static readonly IntPtr NativeFieldInfoPtr_qname;

		// Token: 0x04001E45 RID: 7749
		private static readonly IntPtr NativeFieldInfoPtr_redefined;

		// Token: 0x04001E46 RID: 7750
		private static readonly IntPtr NativeFieldInfoPtr_contentType;

		// Token: 0x04001E47 RID: 7751
		private static readonly IntPtr NativeMethodInfoPtr_GetBuiltInSimpleType_Public_Static_XmlSchemaSimpleType_XmlQualifiedName_0;

		// Token: 0x04001E48 RID: 7752
		private static readonly IntPtr NativeMethodInfoPtr_GetBuiltInSimpleType_Public_Static_XmlSchemaSimpleType_XmlTypeCode_0;

		// Token: 0x04001E49 RID: 7753
		private static readonly IntPtr NativeMethodInfoPtr_GetBuiltInComplexType_Public_Static_XmlSchemaComplexType_XmlQualifiedName_0;

		// Token: 0x04001E4A RID: 7754
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04001E4B RID: 7755
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04001E4C RID: 7756
		private static readonly IntPtr NativeMethodInfoPtr_get_Final_Public_get_XmlSchemaDerivationMethod_0;

		// Token: 0x04001E4D RID: 7757
		private static readonly IntPtr NativeMethodInfoPtr_set_Final_Public_set_Void_XmlSchemaDerivationMethod_0;

		// Token: 0x04001E4E RID: 7758
		private static readonly IntPtr NativeMethodInfoPtr_get_QualifiedName_Public_get_XmlQualifiedName_0;

		// Token: 0x04001E4F RID: 7759
		private static readonly IntPtr NativeMethodInfoPtr_get_FinalResolved_Public_get_XmlSchemaDerivationMethod_0;

		// Token: 0x04001E50 RID: 7760
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseXmlSchemaType_Public_get_XmlSchemaType_0;

		// Token: 0x04001E51 RID: 7761
		private static readonly IntPtr NativeMethodInfoPtr_get_DerivedBy_Public_get_XmlSchemaDerivationMethod_0;

		// Token: 0x04001E52 RID: 7762
		private static readonly IntPtr NativeMethodInfoPtr_get_Datatype_Public_get_XmlSchemaDatatype_0;

		// Token: 0x04001E53 RID: 7763
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMixed_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04001E54 RID: 7764
		private static readonly IntPtr NativeMethodInfoPtr_set_IsMixed_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04001E55 RID: 7765
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_get_XmlTypeCode_0;

		// Token: 0x04001E56 RID: 7766
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueConverter_Internal_get_XmlValueConverter_0;

		// Token: 0x04001E57 RID: 7767
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaContentType_Internal_get_XmlSchemaContentType_0;

		// Token: 0x04001E58 RID: 7768
		private static readonly IntPtr NativeMethodInfoPtr_SetQualifiedName_Internal_Void_XmlQualifiedName_0;

		// Token: 0x04001E59 RID: 7769
		private static readonly IntPtr NativeMethodInfoPtr_SetFinalResolved_Internal_Void_XmlSchemaDerivationMethod_0;

		// Token: 0x04001E5A RID: 7770
		private static readonly IntPtr NativeMethodInfoPtr_SetBaseSchemaType_Internal_Void_XmlSchemaType_0;

		// Token: 0x04001E5B RID: 7771
		private static readonly IntPtr NativeMethodInfoPtr_SetDerivedBy_Internal_Void_XmlSchemaDerivationMethod_0;

		// Token: 0x04001E5C RID: 7772
		private static readonly IntPtr NativeMethodInfoPtr_SetDatatype_Internal_Void_XmlSchemaDatatype_0;

		// Token: 0x04001E5D RID: 7773
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementDecl_Internal_get_SchemaElementDecl_0;

		// Token: 0x04001E5E RID: 7774
		private static readonly IntPtr NativeMethodInfoPtr_set_ElementDecl_Internal_set_Void_SchemaElementDecl_0;

		// Token: 0x04001E5F RID: 7775
		private static readonly IntPtr NativeMethodInfoPtr_get_Redefined_Internal_get_XmlSchemaType_0;

		// Token: 0x04001E60 RID: 7776
		private static readonly IntPtr NativeMethodInfoPtr_set_Redefined_Internal_set_Void_XmlSchemaType_0;

		// Token: 0x04001E61 RID: 7777
		private static readonly IntPtr NativeMethodInfoPtr_SetContentType_Internal_Void_XmlSchemaContentType_0;

		// Token: 0x04001E62 RID: 7778
		private static readonly IntPtr NativeMethodInfoPtr_IsDerivedFrom_Public_Static_Boolean_XmlSchemaType_XmlSchemaType_XmlSchemaDerivationMethod_0;

		// Token: 0x04001E63 RID: 7779
		private static readonly IntPtr NativeMethodInfoPtr_IsDerivedFromDatatype_Internal_Static_Boolean_XmlSchemaDatatype_XmlSchemaDatatype_XmlSchemaDerivationMethod_0;

		// Token: 0x04001E64 RID: 7780
		private static readonly IntPtr NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_get_String_0;

		// Token: 0x04001E65 RID: 7781
		private static readonly IntPtr NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_set_Void_String_0;

		// Token: 0x04001E66 RID: 7782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

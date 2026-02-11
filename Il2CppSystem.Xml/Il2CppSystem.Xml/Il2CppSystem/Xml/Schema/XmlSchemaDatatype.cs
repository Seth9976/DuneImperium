using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001AD RID: 429
	public class XmlSchemaDatatype : Object
	{
		// Token: 0x06002525 RID: 9509 RVA: 0x000AF4C0 File Offset: 0x000AD6C0
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaDatatype()
		{
			Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaDatatype");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_ValueType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668674);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_TokenizedType_Public_Abstract_Virtual_New_get_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668675);
			XmlSchemaDatatype.NativeMethodInfoPtr_ParseValue_Public_Abstract_Virtual_New_Object_String_XmlNameTable_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668676);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_Variety_Public_Virtual_New_get_XmlSchemaDatatypeVariety_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668677);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_New_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668678);
			XmlSchemaDatatype.NativeMethodInfoPtr_IsDerivedFrom_Public_Virtual_New_Boolean_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668679);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_HasLexicalFacets_Internal_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668680);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_HasValueFacets_Internal_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668681);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_ValueConverter_Internal_Abstract_Virtual_New_get_XmlValueConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668682);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_Restriction_Internal_Abstract_Virtual_New_get_RestrictionFacets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668683);
			XmlSchemaDatatype.NativeMethodInfoPtr_Compare_Internal_Abstract_Virtual_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668684);
			XmlSchemaDatatype.NativeMethodInfoPtr_ParseValue_Internal_Abstract_Virtual_New_Object_String_XmlNameTable_IXmlNamespaceResolver_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668685);
			XmlSchemaDatatype.NativeMethodInfoPtr_TryParseValue_Internal_Abstract_Virtual_New_Exception_String_XmlNameTable_IXmlNamespaceResolver_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668686);
			XmlSchemaDatatype.NativeMethodInfoPtr_TryParseValue_Internal_Abstract_Virtual_New_Exception_Object_XmlNameTable_IXmlNamespaceResolver_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668687);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_FacetsChecker_Internal_Abstract_Virtual_New_get_FacetsChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668688);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Abstract_Virtual_New_get_XmlSchemaWhiteSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668689);
			XmlSchemaDatatype.NativeMethodInfoPtr_DeriveByRestriction_Internal_Abstract_Virtual_New_XmlSchemaDatatype_XmlSchemaObjectCollection_XmlNameTable_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668690);
			XmlSchemaDatatype.NativeMethodInfoPtr_DeriveByList_Internal_Abstract_Virtual_New_XmlSchemaDatatype_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668691);
			XmlSchemaDatatype.NativeMethodInfoPtr_VerifySchemaValid_Internal_Abstract_Virtual_New_Void_XmlSchemaObjectTable_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668692);
			XmlSchemaDatatype.NativeMethodInfoPtr_IsEqual_Internal_Abstract_Virtual_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668693);
			XmlSchemaDatatype.NativeMethodInfoPtr_IsComparable_Internal_Abstract_Virtual_New_Boolean_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668694);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_TypeCodeString_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668695);
			XmlSchemaDatatype.NativeMethodInfoPtr_TypeCodeToString_Internal_String_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668696);
			XmlSchemaDatatype.NativeMethodInfoPtr_ConcatenatedToString_Internal_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668697);
			XmlSchemaDatatype.NativeMethodInfoPtr_FromXmlTokenizedType_Internal_Static_XmlSchemaDatatype_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668698);
			XmlSchemaDatatype.NativeMethodInfoPtr_FromXmlTokenizedTypeXsd_Internal_Static_XmlSchemaDatatype_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668699);
			XmlSchemaDatatype.NativeMethodInfoPtr_FromXdrName_Internal_Static_XmlSchemaDatatype_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668700);
			XmlSchemaDatatype.NativeMethodInfoPtr_DeriveByUnion_Internal_Static_XmlSchemaDatatype_Il2CppReferenceArray_1_XmlSchemaSimpleType_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668701);
			XmlSchemaDatatype.NativeMethodInfoPtr_XdrCanonizeUri_Internal_Static_String_String_XmlNameTable_SchemaNames_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668702);
			XmlSchemaDatatype.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100668703);
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x06002526 RID: 9510 RVA: 0x000AF748 File Offset: 0x000AD948
		public unsafe virtual Type ValueType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_ValueType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x06002527 RID: 9511 RVA: 0x000AF794 File Offset: 0x000AD994
		public unsafe virtual XmlTokenizedType TokenizedType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_TokenizedType_Public_Abstract_Virtual_New_get_XmlTokenizedType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x000AF7DC File Offset: 0x000AD9DC
		[CallerCount(0)]
		public unsafe virtual Object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_ParseValue_Public_Abstract_Virtual_New_Object_String_XmlNameTable_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x06002529 RID: 9513 RVA: 0x000AF85C File Offset: 0x000ADA5C
		public unsafe virtual XmlSchemaDatatypeVariety Variety
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_Variety_Public_Virtual_New_get_XmlSchemaDatatypeVariety_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x0600252A RID: 9514 RVA: 0x000AF8A4 File Offset: 0x000ADAA4
		public unsafe virtual XmlTypeCode TypeCode
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_New_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600252B RID: 9515 RVA: 0x000AF8EC File Offset: 0x000ADAEC
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsDerivedFrom(XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(datatype);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_IsDerivedFrom_Public_Virtual_New_Boolean_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x0600252C RID: 9516 RVA: 0x000AF944 File Offset: 0x000ADB44
		public unsafe virtual bool HasLexicalFacets
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_HasLexicalFacets_Internal_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x0600252D RID: 9517 RVA: 0x000AF98C File Offset: 0x000ADB8C
		public unsafe virtual bool HasValueFacets
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_HasValueFacets_Internal_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x0600252E RID: 9518 RVA: 0x000AF9D4 File Offset: 0x000ADBD4
		public unsafe virtual XmlValueConverter ValueConverter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_ValueConverter_Internal_Abstract_Virtual_New_get_XmlValueConverter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr3) : null;
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x0600252F RID: 9519 RVA: 0x000AFA20 File Offset: 0x000ADC20
		public unsafe virtual RestrictionFacets Restriction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_Restriction_Internal_Abstract_Virtual_New_get_RestrictionFacets_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RestrictionFacets>(intPtr3) : null;
			}
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x000AFA6C File Offset: 0x000ADC6C
		[CallerCount(0)]
		public unsafe virtual int Compare(Object value1, Object value2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_Compare_Internal_Abstract_Virtual_New_Int32_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x000AFAD8 File Offset: 0x000ADCD8
		[CallerCount(0)]
		public unsafe virtual Object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createAtomicValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_ParseValue_Internal_Abstract_Virtual_New_Object_String_XmlNameTable_IXmlNamespaceResolver_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x000AFB68 File Offset: 0x000ADD68
		[CallerCount(0)]
		public unsafe virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_TryParseValue_Internal_Abstract_Virtual_New_Exception_String_XmlNameTable_IXmlNamespaceResolver_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			typedValue = ((intPtr4 == 0) ? null : new Object(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr5) : null;
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x000AFC0C File Offset: 0x000ADE0C
		[CallerCount(0)]
		public unsafe virtual Exception TryParseValue(Object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out Object typedValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespaceResolver);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_TryParseValue_Internal_Abstract_Virtual_New_Exception_Object_XmlNameTable_IXmlNamespaceResolver_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			typedValue = ((intPtr4 == 0) ? null : new Object(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr5) : null;
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x06002534 RID: 9524 RVA: 0x000AFCB0 File Offset: 0x000ADEB0
		public unsafe virtual FacetsChecker FacetsChecker
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_FacetsChecker_Internal_Abstract_Virtual_New_get_FacetsChecker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr3) : null;
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06002535 RID: 9525 RVA: 0x000AFCFC File Offset: 0x000ADEFC
		public unsafe virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Abstract_Virtual_New_get_XmlSchemaWhiteSpace_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x000AFD44 File Offset: 0x000ADF44
		[CallerCount(0)]
		public unsafe virtual XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(facets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_DeriveByRestriction_Internal_Abstract_Virtual_New_XmlSchemaDatatype_XmlSchemaObjectCollection_XmlNameTable_XmlSchemaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x000AFDC4 File Offset: 0x000ADFC4
		[CallerCount(0)]
		public unsafe virtual XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_DeriveByList_Internal_Abstract_Virtual_New_XmlSchemaDatatype_XmlSchemaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
			}
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x000AFE20 File Offset: 0x000AE020
		[CallerCount(0)]
		public unsafe virtual void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(notations);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caller);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_VerifySchemaValid_Internal_Abstract_Virtual_New_Void_XmlSchemaObjectTable_XmlSchemaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x000AFE80 File Offset: 0x000AE080
		[CallerCount(0)]
		public unsafe virtual bool IsEqual(Object o1, Object o2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_IsEqual_Internal_Abstract_Virtual_New_Boolean_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x000AFEEC File Offset: 0x000AE0EC
		[CallerCount(0)]
		public unsafe virtual bool IsComparable(XmlSchemaDatatype dtype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtype);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_IsComparable_Internal_Abstract_Virtual_New_Boolean_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x0600253B RID: 9531 RVA: 0x000AFF44 File Offset: 0x000AE144
		public unsafe string TypeCodeString
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 411679, RefRangeEnd = 411684, XrefRangeStart = 411672, XrefRangeEnd = 411679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDatatype.NativeMethodInfoPtr_get_TypeCodeString_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x000AFF7C File Offset: 0x000AE17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411684, XrefRangeEnd = 411730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string TypeCodeToString(XmlTypeCode typeCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDatatype.NativeMethodInfoPtr_TypeCodeToString_Internal_String_XmlTypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x000AFFC0 File Offset: 0x000AE1C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411730, XrefRangeEnd = 411824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ConcatenatedToString(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDatatype.NativeMethodInfoPtr_ConcatenatedToString_Internal_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x000AFFFC File Offset: 0x000AE1FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 411828, RefRangeEnd = 411830, XrefRangeStart = 411824, XrefRangeEnd = 411828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDatatype.NativeMethodInfoPtr_FromXmlTokenizedType_Internal_Static_XmlSchemaDatatype_XmlTokenizedType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
			}
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x000B003C File Offset: 0x000AE23C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 411834, RefRangeEnd = 411836, XrefRangeStart = 411830, XrefRangeEnd = 411834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaDatatype FromXmlTokenizedTypeXsd(XmlTokenizedType token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDatatype.NativeMethodInfoPtr_FromXmlTokenizedTypeXsd_Internal_Static_XmlSchemaDatatype_XmlTokenizedType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
			}
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x000B007C File Offset: 0x000AE27C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 411840, RefRangeEnd = 411841, XrefRangeStart = 411836, XrefRangeEnd = 411840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaDatatype FromXdrName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDatatype.NativeMethodInfoPtr_FromXdrName_Internal_Static_XmlSchemaDatatype_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
			}
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x000B00C0 File Offset: 0x000AE2C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 411845, RefRangeEnd = 411847, XrefRangeStart = 411841, XrefRangeEnd = 411845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaDatatype DeriveByUnion(Il2CppReferenceArray<XmlSchemaSimpleType> types, XmlSchemaType schemaType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(types);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDatatype.NativeMethodInfoPtr_DeriveByUnion_Internal_Static_XmlSchemaDatatype_Il2CppReferenceArray_1_XmlSchemaSimpleType_XmlSchemaType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x000B0118 File Offset: 0x000AE318
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 411865, RefRangeEnd = 411870, XrefRangeStart = 411847, XrefRangeEnd = 411865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string XdrCanonizeUri(string uri, XmlNameTable nameTable, SchemaNames schemaNames)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaNames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDatatype.NativeMethodInfoPtr_XdrCanonizeUri_Internal_Static_String_String_XmlNameTable_SchemaNames_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002543 RID: 9539 RVA: 0x000B0178 File Offset: 0x000AE378
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaDatatype()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDatatype.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002544 RID: 9540 RVA: 0x0000FB34 File Offset: 0x0000DD34
		public XmlSchemaDatatype(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C08 RID: 7176
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04001C09 RID: 7177
		private static readonly IntPtr NativeMethodInfoPtr_get_TokenizedType_Public_Abstract_Virtual_New_get_XmlTokenizedType_0;

		// Token: 0x04001C0A RID: 7178
		private static readonly IntPtr NativeMethodInfoPtr_ParseValue_Public_Abstract_Virtual_New_Object_String_XmlNameTable_IXmlNamespaceResolver_0;

		// Token: 0x04001C0B RID: 7179
		private static readonly IntPtr NativeMethodInfoPtr_get_Variety_Public_Virtual_New_get_XmlSchemaDatatypeVariety_0;

		// Token: 0x04001C0C RID: 7180
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_New_get_XmlTypeCode_0;

		// Token: 0x04001C0D RID: 7181
		private static readonly IntPtr NativeMethodInfoPtr_IsDerivedFrom_Public_Virtual_New_Boolean_XmlSchemaDatatype_0;

		// Token: 0x04001C0E RID: 7182
		private static readonly IntPtr NativeMethodInfoPtr_get_HasLexicalFacets_Internal_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001C0F RID: 7183
		private static readonly IntPtr NativeMethodInfoPtr_get_HasValueFacets_Internal_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001C10 RID: 7184
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueConverter_Internal_Abstract_Virtual_New_get_XmlValueConverter_0;

		// Token: 0x04001C11 RID: 7185
		private static readonly IntPtr NativeMethodInfoPtr_get_Restriction_Internal_Abstract_Virtual_New_get_RestrictionFacets_0;

		// Token: 0x04001C12 RID: 7186
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Internal_Abstract_Virtual_New_Int32_Object_Object_0;

		// Token: 0x04001C13 RID: 7187
		private static readonly IntPtr NativeMethodInfoPtr_ParseValue_Internal_Abstract_Virtual_New_Object_String_XmlNameTable_IXmlNamespaceResolver_Boolean_0;

		// Token: 0x04001C14 RID: 7188
		private static readonly IntPtr NativeMethodInfoPtr_TryParseValue_Internal_Abstract_Virtual_New_Exception_String_XmlNameTable_IXmlNamespaceResolver_byref_Object_0;

		// Token: 0x04001C15 RID: 7189
		private static readonly IntPtr NativeMethodInfoPtr_TryParseValue_Internal_Abstract_Virtual_New_Exception_Object_XmlNameTable_IXmlNamespaceResolver_byref_Object_0;

		// Token: 0x04001C16 RID: 7190
		private static readonly IntPtr NativeMethodInfoPtr_get_FacetsChecker_Internal_Abstract_Virtual_New_get_FacetsChecker_0;

		// Token: 0x04001C17 RID: 7191
		private static readonly IntPtr NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Abstract_Virtual_New_get_XmlSchemaWhiteSpace_0;

		// Token: 0x04001C18 RID: 7192
		private static readonly IntPtr NativeMethodInfoPtr_DeriveByRestriction_Internal_Abstract_Virtual_New_XmlSchemaDatatype_XmlSchemaObjectCollection_XmlNameTable_XmlSchemaType_0;

		// Token: 0x04001C19 RID: 7193
		private static readonly IntPtr NativeMethodInfoPtr_DeriveByList_Internal_Abstract_Virtual_New_XmlSchemaDatatype_XmlSchemaType_0;

		// Token: 0x04001C1A RID: 7194
		private static readonly IntPtr NativeMethodInfoPtr_VerifySchemaValid_Internal_Abstract_Virtual_New_Void_XmlSchemaObjectTable_XmlSchemaObject_0;

		// Token: 0x04001C1B RID: 7195
		private static readonly IntPtr NativeMethodInfoPtr_IsEqual_Internal_Abstract_Virtual_New_Boolean_Object_Object_0;

		// Token: 0x04001C1C RID: 7196
		private static readonly IntPtr NativeMethodInfoPtr_IsComparable_Internal_Abstract_Virtual_New_Boolean_XmlSchemaDatatype_0;

		// Token: 0x04001C1D RID: 7197
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCodeString_Internal_get_String_0;

		// Token: 0x04001C1E RID: 7198
		private static readonly IntPtr NativeMethodInfoPtr_TypeCodeToString_Internal_String_XmlTypeCode_0;

		// Token: 0x04001C1F RID: 7199
		private static readonly IntPtr NativeMethodInfoPtr_ConcatenatedToString_Internal_Static_String_Object_0;

		// Token: 0x04001C20 RID: 7200
		private static readonly IntPtr NativeMethodInfoPtr_FromXmlTokenizedType_Internal_Static_XmlSchemaDatatype_XmlTokenizedType_0;

		// Token: 0x04001C21 RID: 7201
		private static readonly IntPtr NativeMethodInfoPtr_FromXmlTokenizedTypeXsd_Internal_Static_XmlSchemaDatatype_XmlTokenizedType_0;

		// Token: 0x04001C22 RID: 7202
		private static readonly IntPtr NativeMethodInfoPtr_FromXdrName_Internal_Static_XmlSchemaDatatype_String_0;

		// Token: 0x04001C23 RID: 7203
		private static readonly IntPtr NativeMethodInfoPtr_DeriveByUnion_Internal_Static_XmlSchemaDatatype_Il2CppReferenceArray_1_XmlSchemaSimpleType_XmlSchemaType_0;

		// Token: 0x04001C24 RID: 7204
		private static readonly IntPtr NativeMethodInfoPtr_XdrCanonizeUri_Internal_Static_String_String_XmlNameTable_SchemaNames_0;

		// Token: 0x04001C25 RID: 7205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

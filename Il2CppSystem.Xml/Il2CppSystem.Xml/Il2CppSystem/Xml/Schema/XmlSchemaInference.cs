using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000179 RID: 377
	public sealed class XmlSchemaInference : Object
	{
		// Token: 0x06001D99 RID: 7577 RVA: 0x000930EC File Offset: 0x000912EC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaInference()
		{
			Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaInference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr);
			XmlSchemaInference.NativeFieldInfoPtr_ST_boolean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "ST_boolean");
			XmlSchemaInference.NativeFieldInfoPtr_ST_byte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "ST_byte");
			XmlSchemaInference.NativeFieldInfoPtr_ST_unsignedByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "ST_unsignedByte");
			XmlSchemaInference.NativeFieldInfoPtr_ST_short = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "ST_short");
			XmlSchemaInference.NativeFieldInfoPtr_ST_unsignedShort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "ST_unsignedShort");
			XmlSchemaInference.NativeFieldInfoPtr_ST_int = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "ST_int");
			XmlSchemaInference.NativeFieldInfoPtr_ST_unsignedInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "ST_unsignedInt");
			XmlSchemaInference.NativeFieldInfoPtr_ST_long = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "ST_long");
			XmlSchemaInference.NativeFieldInfoPtr_ST_unsignedLong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "ST_unsignedLong");
			XmlSchemaInference.NativeFieldInfoPtr_ST_integer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "ST_integer");
			XmlSchemaInference.NativeFieldInfoPtr_ST_decimal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "ST_decimal");
			XmlSchemaInference.NativeFieldInfoPtr_ST_float = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "ST_float");
			XmlSchemaInference.NativeFieldInfoPtr_ST_double = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "ST_double");
			XmlSchemaInference.NativeFieldInfoPtr_ST_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "ST_duration");
			XmlSchemaInference.NativeFieldInfoPtr_ST_dateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "ST_dateTime");
			XmlSchemaInference.NativeFieldInfoPtr_ST_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "ST_time");
			XmlSchemaInference.NativeFieldInfoPtr_ST_date = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "ST_date");
			XmlSchemaInference.NativeFieldInfoPtr_ST_gYearMonth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "ST_gYearMonth");
			XmlSchemaInference.NativeFieldInfoPtr_ST_string = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "ST_string");
			XmlSchemaInference.NativeFieldInfoPtr_ST_anySimpleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "ST_anySimpleType");
			XmlSchemaInference.NativeFieldInfoPtr_SimpleTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "SimpleTypes");
			XmlSchemaInference.NativeFieldInfoPtr_rootSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "rootSchema");
			XmlSchemaInference.NativeFieldInfoPtr_schemaSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "schemaSet");
			XmlSchemaInference.NativeFieldInfoPtr_xtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "xtr");
			XmlSchemaInference.NativeFieldInfoPtr_nametable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "nametable");
			XmlSchemaInference.NativeFieldInfoPtr_TargetNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "TargetNamespace");
			XmlSchemaInference.NativeFieldInfoPtr_NamespaceManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "NamespaceManager");
			XmlSchemaInference.NativeFieldInfoPtr_schemaList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "schemaList");
			XmlSchemaInference.NativeFieldInfoPtr_occurrence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "occurrence");
			XmlSchemaInference.NativeFieldInfoPtr_typeInference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, "typeInference");
			XmlSchemaInference.NativeMethodInfoPtr_set_Occurrence_Public_set_Void_InferenceOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667777);
			XmlSchemaInference.NativeMethodInfoPtr_get_Occurrence_Public_get_InferenceOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667778);
			XmlSchemaInference.NativeMethodInfoPtr_set_TypeInference_Public_set_Void_InferenceOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667779);
			XmlSchemaInference.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667780);
			XmlSchemaInference.NativeMethodInfoPtr_InferSchema_Public_XmlSchemaSet_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667781);
			XmlSchemaInference.NativeMethodInfoPtr_InferSchema1_Internal_XmlSchemaSet_XmlReader_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667782);
			XmlSchemaInference.NativeMethodInfoPtr_AddAttribute_Private_XmlSchemaAttribute_String_String_String_String_Boolean_XmlSchema_XmlSchemaObjectCollection_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667783);
			XmlSchemaInference.NativeMethodInfoPtr_CreateXmlSchema_Private_XmlSchema_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667784);
			XmlSchemaInference.NativeMethodInfoPtr_AddElement_Private_XmlSchemaElement_String_String_String_XmlSchema_XmlSchemaObjectCollection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667785);
			XmlSchemaInference.NativeMethodInfoPtr_InferElement_Internal_Void_XmlSchemaElement_Boolean_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667786);
			XmlSchemaInference.NativeMethodInfoPtr_CheckSimpleContentExtension_Private_XmlSchemaSimpleContentExtension_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667787);
			XmlSchemaInference.NativeMethodInfoPtr_GetEffectiveSchemaType_Private_XmlSchemaType_XmlSchemaElement_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667788);
			XmlSchemaInference.NativeMethodInfoPtr_FindMatchingElement_Internal_XmlSchemaElement_Boolean_XmlReader_XmlSchemaComplexType_byref_Int32_byref_Boolean_XmlSchema_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667789);
			XmlSchemaInference.NativeMethodInfoPtr_ProcessAttributes_Internal_Void_byref_XmlSchemaElement_XmlSchemaType_Boolean_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667790);
			XmlSchemaInference.NativeMethodInfoPtr_MoveAttributes_Private_Void_XmlSchemaSimpleContentExtension_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667791);
			XmlSchemaInference.NativeMethodInfoPtr_MoveAttributes_Private_Void_XmlSchemaComplexType_XmlSchemaSimpleContentExtension_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667792);
			XmlSchemaInference.NativeMethodInfoPtr_FindAttribute_Internal_XmlSchemaAttribute_ICollection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667793);
			XmlSchemaInference.NativeMethodInfoPtr_FindGlobalElement_Internal_XmlSchemaElement_String_String_byref_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667794);
			XmlSchemaInference.NativeMethodInfoPtr_FindElement_Internal_XmlSchemaElement_XmlSchemaObjectCollection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667795);
			XmlSchemaInference.NativeMethodInfoPtr_FindAttributeRef_Internal_XmlSchemaAttribute_ICollection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667796);
			XmlSchemaInference.NativeMethodInfoPtr_FindElementRef_Internal_XmlSchemaElement_XmlSchemaObjectCollection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667797);
			XmlSchemaInference.NativeMethodInfoPtr_MakeExistingAttributesOptional_Internal_Void_XmlSchemaComplexType_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667798);
			XmlSchemaInference.NativeMethodInfoPtr_SwitchUseToOptional_Private_Void_XmlSchemaObjectCollection_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667799);
			XmlSchemaInference.NativeMethodInfoPtr_RefineSimpleType_Internal_XmlQualifiedName_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667800);
			XmlSchemaInference.NativeMethodInfoPtr_InferSimpleType_Internal_Static_Int32_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667801);
			XmlSchemaInference.NativeMethodInfoPtr_DateTime_Internal_Static_Int32_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667802);
			XmlSchemaInference.NativeMethodInfoPtr_CreateNewElementforChoice_Private_XmlSchemaElement_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667803);
			XmlSchemaInference.NativeMethodInfoPtr_GetSchemaType_Private_Static_Int32_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667804);
			XmlSchemaInference.NativeMethodInfoPtr_SetMinMaxOccurs_Internal_Void_XmlSchemaElement_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr, 100667805);
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06001D9B RID: 7579 RVA: 0x000935F8 File Offset: 0x000917F8
		// (set) Token: 0x06001D9A RID: 7578 RVA: 0x000935B8 File Offset: 0x000917B8
		public unsafe XmlSchemaInference.InferenceOption Occurrence
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 366305, RefRangeEnd = 366308, XrefRangeStart = 366305, XrefRangeEnd = 366308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_get_Occurrence_Public_get_InferenceOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_set_Occurrence_Public_set_Void_InferenceOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009EC RID: 2540
		// (set) Token: 0x06001D9C RID: 7580 RVA: 0x00093634 File Offset: 0x00091834
		public unsafe XmlSchemaInference.InferenceOption TypeInference
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_set_TypeInference_Public_set_Void_InferenceOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x00093674 File Offset: 0x00091874
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 396379, RefRangeEnd = 396380, XrefRangeStart = 396348, XrefRangeEnd = 396379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaInference()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaInference>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x000936B0 File Offset: 0x000918B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 396385, RefRangeEnd = 396386, XrefRangeStart = 396380, XrefRangeEnd = 396385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSet InferSchema(XmlReader instanceDocument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instanceDocument);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_InferSchema_Public_XmlSchemaSet_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSet>(intPtr3) : null;
			}
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x00093700 File Offset: 0x00091900
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 396450, RefRangeEnd = 396451, XrefRangeStart = 396386, XrefRangeEnd = 396450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSet InferSchema1(XmlReader instanceDocument, XmlSchemaSet schemas)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instanceDocument);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemas);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_InferSchema1_Internal_XmlSchemaSet_XmlReader_XmlSchemaSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSet>(intPtr3) : null;
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x00093764 File Offset: 0x00091964
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 396550, RefRangeEnd = 396551, XrefRangeStart = 396451, XrefRangeEnd = 396550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaAttribute AddAttribute(string localName, string prefix, string childURI, string attrValue, bool bCreatingNewType, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, XmlSchemaObjectTable compiledAttributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(childURI);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attrValue);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCreatingNewType;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentSchema);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(addLocation);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compiledAttributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_AddAttribute_Private_XmlSchemaAttribute_String_String_String_String_Boolean_XmlSchema_XmlSchemaObjectCollection_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttribute>(intPtr3) : null;
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x00093834 File Offset: 0x00091A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396551, XrefRangeEnd = 396557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema CreateXmlSchema(string targetNS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetNS);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_CreateXmlSchema_Private_XmlSchema_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
			}
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x00093884 File Offset: 0x00091A84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 396632, RefRangeEnd = 396636, XrefRangeStart = 396557, XrefRangeEnd = 396632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaElement AddElement(string localName, string prefix, string childURI, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, int positionWithinCollection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(childURI);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentSchema);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(addLocation);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positionWithinCollection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_AddElement_Private_XmlSchemaElement_String_String_String_XmlSchema_XmlSchemaObjectCollection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr3) : null;
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x0009392C File Offset: 0x00091B2C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 396831, RefRangeEnd = 396837, XrefRangeStart = 396636, XrefRangeEnd = 396831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InferElement(XmlSchemaElement xse, bool bCreatingNewType, XmlSchema parentSchema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xse);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCreatingNewType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentSchema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_InferElement_Internal_Void_XmlSchemaElement_Boolean_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x00093990 File Offset: 0x00091B90
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 396843, RefRangeEnd = 396848, XrefRangeStart = 396837, XrefRangeEnd = 396843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSimpleContentExtension CheckSimpleContentExtension(XmlSchemaComplexType ct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ct);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_CheckSimpleContentExtension_Private_XmlSchemaSimpleContentExtension_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleContentExtension>(intPtr3) : null;
			}
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x000939E0 File Offset: 0x00091BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396848, XrefRangeEnd = 396862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaType GetEffectiveSchemaType(XmlSchemaElement elem, bool bCreatingNewType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCreatingNewType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_GetEffectiveSchemaType_Private_XmlSchemaType_XmlSchemaElement_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x00093A40 File Offset: 0x00091C40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 396950, RefRangeEnd = 396951, XrefRangeStart = 396862, XrefRangeEnd = 396950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaElement FindMatchingElement(bool bCreatingNewType, XmlReader xtr, XmlSchemaComplexType ct, ref int lastUsedSeqItem, ref bool bParticleChanged, XmlSchema parentSchema, bool setMaxoccurs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bCreatingNewType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xtr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ct);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lastUsedSeqItem;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bParticleChanged;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentSchema);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setMaxoccurs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_FindMatchingElement_Internal_XmlSchemaElement_Boolean_XmlReader_XmlSchemaComplexType_byref_Int32_byref_Boolean_XmlSchema_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr3) : null;
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x00093AF0 File Offset: 0x00091CF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 397021, RefRangeEnd = 397022, XrefRangeStart = 396951, XrefRangeEnd = 397021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessAttributes(ref XmlSchemaElement xse, XmlSchemaType effectiveSchemaType, bool bCreatingNewType, XmlSchema parentSchema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(xse);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(effectiveSchemaType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCreatingNewType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentSchema);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_ProcessAttributes_Internal_Void_byref_XmlSchemaElement_XmlSchemaType_Boolean_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			xse = ((intPtr4 == 0) ? null : new XmlSchemaElement(intPtr4));
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x00093B7C File Offset: 0x00091D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397022, XrefRangeEnd = 397026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveAttributes(XmlSchemaSimpleContentExtension scExtension, XmlSchemaComplexType ct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scExtension);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ct);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_MoveAttributes_Private_Void_XmlSchemaSimpleContentExtension_XmlSchemaComplexType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x00093BD0 File Offset: 0x00091DD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 397055, RefRangeEnd = 397057, XrefRangeStart = 397026, XrefRangeEnd = 397055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveAttributes(XmlSchemaComplexType ct, XmlSchemaSimpleContentExtension simpleContentExtension, bool bCreatingNewType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ct);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(simpleContentExtension);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCreatingNewType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_MoveAttributes_Private_Void_XmlSchemaComplexType_XmlSchemaSimpleContentExtension_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x00093C34 File Offset: 0x00091E34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 397073, RefRangeEnd = 397077, XrefRangeStart = 397057, XrefRangeEnd = 397073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaAttribute FindAttribute(ICollection attributes, string attrName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attrName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_FindAttribute_Internal_XmlSchemaAttribute_ICollection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttribute>(intPtr3) : null;
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x00093C98 File Offset: 0x00091E98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 397093, RefRangeEnd = 397096, XrefRangeStart = 397077, XrefRangeEnd = 397093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaElement FindGlobalElement(string namespaceURI, string localName, out XmlSchema parentSchema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_FindGlobalElement_Internal_XmlSchemaElement_String_String_byref_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parentSchema = ((intPtr4 == 0) ? null : new XmlSchema(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr5) : null;
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x00093D20 File Offset: 0x00091F20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 397106, RefRangeEnd = 397107, XrefRangeStart = 397096, XrefRangeEnd = 397106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaElement FindElement(XmlSchemaObjectCollection elements, string elementName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elements);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(elementName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_FindElement_Internal_XmlSchemaElement_XmlSchemaObjectCollection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr3) : null;
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x00093D84 File Offset: 0x00091F84
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 397124, RefRangeEnd = 397129, XrefRangeStart = 397107, XrefRangeEnd = 397124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaAttribute FindAttributeRef(ICollection attributes, string attributeName, string nsURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(nsURI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_FindAttributeRef_Internal_XmlSchemaAttribute_ICollection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttribute>(intPtr3) : null;
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x00093DF8 File Offset: 0x00091FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397129, XrefRangeEnd = 397140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaElement FindElementRef(XmlSchemaObjectCollection elements, string elementName, string nsURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elements);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(elementName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(nsURI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_FindElementRef_Internal_XmlSchemaElement_XmlSchemaObjectCollection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr3) : null;
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x00093E6C File Offset: 0x0009206C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 397151, RefRangeEnd = 397152, XrefRangeStart = 397140, XrefRangeEnd = 397151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MakeExistingAttributesOptional(XmlSchemaComplexType ct, XmlSchemaObjectCollection attributesInInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ct);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributesInInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_MakeExistingAttributesOptional_Internal_Void_XmlSchemaComplexType_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x00093EC0 File Offset: 0x000920C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 397160, RefRangeEnd = 397162, XrefRangeStart = 397152, XrefRangeEnd = 397160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchUseToOptional(XmlSchemaObjectCollection attributes, XmlSchemaObjectCollection attributesInInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributesInInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_SwitchUseToOptional_Private_Void_XmlSchemaObjectCollection_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x00093F14 File Offset: 0x00092114
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 397289, RefRangeEnd = 397297, XrefRangeStart = 397162, XrefRangeEnd = 397289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlQualifiedName RefineSimpleType(string s, ref int iTypeFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &iTypeFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_RefineSimpleType_Internal_XmlQualifiedName_String_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x00093F74 File Offset: 0x00092174
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 397394, RefRangeEnd = 397395, XrefRangeStart = 397297, XrefRangeEnd = 397394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int InferSimpleType(string s, ref bool bNeedsRangeCheck)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bNeedsRangeCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_InferSimpleType_Internal_Static_Int32_String_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x00093FC4 File Offset: 0x000921C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 397399, RefRangeEnd = 397400, XrefRangeStart = 397395, XrefRangeEnd = 397399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DateTime(string s, bool bDate, bool bTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bDate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_DateTime_Internal_Static_Int32_String_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x00094024 File Offset: 0x00092224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397400, XrefRangeEnd = 397429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaElement CreateNewElementforChoice(XmlSchemaElement copyElement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(copyElement);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_CreateNewElementforChoice_Private_XmlSchemaElement_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr3) : null;
			}
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x00094074 File Offset: 0x00092274
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 397549, RefRangeEnd = 397553, XrefRangeStart = 397429, XrefRangeEnd = 397549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSchemaType(XmlQualifiedName qname)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_GetSchemaType_Private_Static_Int32_XmlQualifiedName_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x000940B8 File Offset: 0x000922B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 397562, RefRangeEnd = 397566, XrefRangeStart = 397553, XrefRangeEnd = 397562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMinMaxOccurs(XmlSchemaElement el, bool setMaxOccurs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(el);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setMaxOccurs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInference.NativeMethodInfoPtr_SetMinMaxOccurs_Internal_Void_XmlSchemaElement_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x0000C20A File Offset: 0x0000A40A
		public XmlSchemaInference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x00094108 File Offset: 0x00092308
		// (set) Token: 0x06001DB9 RID: 7609 RVA: 0x0000C213 File Offset: 0x0000A413
		public unsafe static XmlQualifiedName ST_boolean
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaInference.NativeFieldInfoPtr_ST_boolean, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaInference.NativeFieldInfoPtr_ST_boolean, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06001DBA RID: 7610 RVA: 0x00094130 File Offset: 0x00092330
		// (set) Token: 0x06001DBB RID: 7611 RVA: 0x0000C225 File Offset: 0x0000A425
		public unsafe static XmlQualifiedName ST_byte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaInference.NativeFieldInfoPtr_ST_byte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaInference.NativeFieldInfoPtr_ST_byte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06001DBC RID: 7612 RVA: 0x00094158 File Offset: 0x00092358
		// (set) Token: 0x06001DBD RID: 7613 RVA: 0x0000C237 File Offset: 0x0000A437
		public unsafe static XmlQualifiedName ST_unsignedByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaInference.NativeFieldInfoPtr_ST_unsignedByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaInference.NativeFieldInfoPtr_ST_unsignedByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06001DBE RID: 7614 RVA: 0x00094180 File Offset: 0x00092380
		// (set) Token: 0x06001DBF RID: 7615 RVA: 0x0000C249 File Offset: 0x0000A449
		public unsafe static XmlQualifiedName ST_short
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaInference.NativeFieldInfoPtr_ST_short, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaInference.NativeFieldInfoPtr_ST_short, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06001DC0 RID: 7616 RVA: 0x000941A8 File Offset: 0x000923A8
		// (set) Token: 0x06001DC1 RID: 7617 RVA: 0x0000C25B File Offset: 0x0000A45B
		public unsafe static XmlQualifiedName ST_unsignedShort
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaInference.NativeFieldInfoPtr_ST_unsignedShort, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaInference.NativeFieldInfoPtr_ST_unsignedShort, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x000941D0 File Offset: 0x000923D0
		// (set) Token: 0x06001DC3 RID: 7619 RVA: 0x0000C26D File Offset: 0x0000A46D
		public unsafe static XmlQualifiedName ST_int
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaInference.NativeFieldInfoPtr_ST_int, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaInference.NativeFieldInfoPtr_ST_int, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06001DC4 RID: 7620 RVA: 0x000941F8 File Offset: 0x000923F8
		// (set) Token: 0x06001DC5 RID: 7621 RVA: 0x0000C27F File Offset: 0x0000A47F
		public unsafe static XmlQualifiedName ST_unsignedInt
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaInference.NativeFieldInfoPtr_ST_unsignedInt, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaInference.NativeFieldInfoPtr_ST_unsignedInt, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x00094220 File Offset: 0x00092420
		// (set) Token: 0x06001DC7 RID: 7623 RVA: 0x0000C291 File Offset: 0x0000A491
		public unsafe static XmlQualifiedName ST_long
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaInference.NativeFieldInfoPtr_ST_long, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaInference.NativeFieldInfoPtr_ST_long, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x00094248 File Offset: 0x00092448
		// (set) Token: 0x06001DC9 RID: 7625 RVA: 0x0000C2A3 File Offset: 0x0000A4A3
		public unsafe static XmlQualifiedName ST_unsignedLong
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaInference.NativeFieldInfoPtr_ST_unsignedLong, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaInference.NativeFieldInfoPtr_ST_unsignedLong, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06001DCA RID: 7626 RVA: 0x00094270 File Offset: 0x00092470
		// (set) Token: 0x06001DCB RID: 7627 RVA: 0x0000C2B5 File Offset: 0x0000A4B5
		public unsafe static XmlQualifiedName ST_integer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaInference.NativeFieldInfoPtr_ST_integer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaInference.NativeFieldInfoPtr_ST_integer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06001DCC RID: 7628 RVA: 0x00094298 File Offset: 0x00092498
		// (set) Token: 0x06001DCD RID: 7629 RVA: 0x0000C2C7 File Offset: 0x0000A4C7
		public unsafe static XmlQualifiedName ST_decimal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaInference.NativeFieldInfoPtr_ST_decimal, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaInference.NativeFieldInfoPtr_ST_decimal, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06001DCE RID: 7630 RVA: 0x000942C0 File Offset: 0x000924C0
		// (set) Token: 0x06001DCF RID: 7631 RVA: 0x0000C2D9 File Offset: 0x0000A4D9
		public unsafe static XmlQualifiedName ST_float
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaInference.NativeFieldInfoPtr_ST_float, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaInference.NativeFieldInfoPtr_ST_float, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x000942E8 File Offset: 0x000924E8
		// (set) Token: 0x06001DD1 RID: 7633 RVA: 0x0000C2EB File Offset: 0x0000A4EB
		public unsafe static XmlQualifiedName ST_double
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaInference.NativeFieldInfoPtr_ST_double, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaInference.NativeFieldInfoPtr_ST_double, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x00094310 File Offset: 0x00092510
		// (set) Token: 0x06001DD3 RID: 7635 RVA: 0x0000C2FD File Offset: 0x0000A4FD
		public unsafe static XmlQualifiedName ST_duration
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaInference.NativeFieldInfoPtr_ST_duration, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaInference.NativeFieldInfoPtr_ST_duration, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x00094338 File Offset: 0x00092538
		// (set) Token: 0x06001DD5 RID: 7637 RVA: 0x0000C30F File Offset: 0x0000A50F
		public unsafe static XmlQualifiedName ST_dateTime
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaInference.NativeFieldInfoPtr_ST_dateTime, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaInference.NativeFieldInfoPtr_ST_dateTime, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06001DD6 RID: 7638 RVA: 0x00094360 File Offset: 0x00092560
		// (set) Token: 0x06001DD7 RID: 7639 RVA: 0x0000C321 File Offset: 0x0000A521
		public unsafe static XmlQualifiedName ST_time
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaInference.NativeFieldInfoPtr_ST_time, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaInference.NativeFieldInfoPtr_ST_time, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x00094388 File Offset: 0x00092588
		// (set) Token: 0x06001DD9 RID: 7641 RVA: 0x0000C333 File Offset: 0x0000A533
		public unsafe static XmlQualifiedName ST_date
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaInference.NativeFieldInfoPtr_ST_date, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaInference.NativeFieldInfoPtr_ST_date, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x000943B0 File Offset: 0x000925B0
		// (set) Token: 0x06001DDB RID: 7643 RVA: 0x0000C345 File Offset: 0x0000A545
		public unsafe static XmlQualifiedName ST_gYearMonth
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaInference.NativeFieldInfoPtr_ST_gYearMonth, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaInference.NativeFieldInfoPtr_ST_gYearMonth, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06001DDC RID: 7644 RVA: 0x000943D8 File Offset: 0x000925D8
		// (set) Token: 0x06001DDD RID: 7645 RVA: 0x0000C357 File Offset: 0x0000A557
		public unsafe static XmlQualifiedName ST_string
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaInference.NativeFieldInfoPtr_ST_string, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaInference.NativeFieldInfoPtr_ST_string, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06001DDE RID: 7646 RVA: 0x00094400 File Offset: 0x00092600
		// (set) Token: 0x06001DDF RID: 7647 RVA: 0x0000C369 File Offset: 0x0000A569
		public unsafe static XmlQualifiedName ST_anySimpleType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaInference.NativeFieldInfoPtr_ST_anySimpleType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaInference.NativeFieldInfoPtr_ST_anySimpleType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06001DE0 RID: 7648 RVA: 0x00094428 File Offset: 0x00092628
		// (set) Token: 0x06001DE1 RID: 7649 RVA: 0x0000C37B File Offset: 0x0000A57B
		public unsafe static Il2CppReferenceArray<XmlQualifiedName> SimpleTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaInference.NativeFieldInfoPtr_SimpleTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlQualifiedName>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaInference.NativeFieldInfoPtr_SimpleTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06001DE2 RID: 7650 RVA: 0x00094450 File Offset: 0x00092650
		// (set) Token: 0x06001DE3 RID: 7651 RVA: 0x0000C38D File Offset: 0x0000A58D
		public unsafe XmlSchema rootSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInference.NativeFieldInfoPtr_rootSchema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInference.NativeFieldInfoPtr_rootSchema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x00094480 File Offset: 0x00092680
		// (set) Token: 0x06001DE5 RID: 7653 RVA: 0x0000C3AC File Offset: 0x0000A5AC
		public unsafe XmlSchemaSet schemaSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInference.NativeFieldInfoPtr_schemaSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInference.NativeFieldInfoPtr_schemaSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06001DE6 RID: 7654 RVA: 0x000944B0 File Offset: 0x000926B0
		// (set) Token: 0x06001DE7 RID: 7655 RVA: 0x0000C3CB File Offset: 0x0000A5CB
		public unsafe XmlReader xtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInference.NativeFieldInfoPtr_xtr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInference.NativeFieldInfoPtr_xtr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x000944E0 File Offset: 0x000926E0
		// (set) Token: 0x06001DE9 RID: 7657 RVA: 0x0000C3EA File Offset: 0x0000A5EA
		public unsafe NameTable nametable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInference.NativeFieldInfoPtr_nametable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInference.NativeFieldInfoPtr_nametable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06001DEA RID: 7658 RVA: 0x00094510 File Offset: 0x00092710
		// (set) Token: 0x06001DEB RID: 7659 RVA: 0x0000C409 File Offset: 0x0000A609
		public unsafe string TargetNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInference.NativeFieldInfoPtr_TargetNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInference.NativeFieldInfoPtr_TargetNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06001DEC RID: 7660 RVA: 0x00094538 File Offset: 0x00092738
		// (set) Token: 0x06001DED RID: 7661 RVA: 0x0000C428 File Offset: 0x0000A628
		public unsafe XmlNamespaceManager NamespaceManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInference.NativeFieldInfoPtr_NamespaceManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInference.NativeFieldInfoPtr_NamespaceManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06001DEE RID: 7662 RVA: 0x00094568 File Offset: 0x00092768
		// (set) Token: 0x06001DEF RID: 7663 RVA: 0x0000C447 File Offset: 0x0000A647
		public unsafe ArrayList schemaList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInference.NativeFieldInfoPtr_schemaList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInference.NativeFieldInfoPtr_schemaList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x00094598 File Offset: 0x00092798
		// (set) Token: 0x06001DF1 RID: 7665 RVA: 0x0000C466 File Offset: 0x0000A666
		public unsafe XmlSchemaInference.InferenceOption occurrence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInference.NativeFieldInfoPtr_occurrence);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInference.NativeFieldInfoPtr_occurrence)) = value;
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x000945C0 File Offset: 0x000927C0
		// (set) Token: 0x06001DF3 RID: 7667 RVA: 0x0000C481 File Offset: 0x0000A681
		public unsafe XmlSchemaInference.InferenceOption typeInference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInference.NativeFieldInfoPtr_typeInference);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInference.NativeFieldInfoPtr_typeInference)) = value;
			}
		}

		// Token: 0x04001699 RID: 5785
		private static readonly IntPtr NativeFieldInfoPtr_ST_boolean;

		// Token: 0x0400169A RID: 5786
		private static readonly IntPtr NativeFieldInfoPtr_ST_byte;

		// Token: 0x0400169B RID: 5787
		private static readonly IntPtr NativeFieldInfoPtr_ST_unsignedByte;

		// Token: 0x0400169C RID: 5788
		private static readonly IntPtr NativeFieldInfoPtr_ST_short;

		// Token: 0x0400169D RID: 5789
		private static readonly IntPtr NativeFieldInfoPtr_ST_unsignedShort;

		// Token: 0x0400169E RID: 5790
		private static readonly IntPtr NativeFieldInfoPtr_ST_int;

		// Token: 0x0400169F RID: 5791
		private static readonly IntPtr NativeFieldInfoPtr_ST_unsignedInt;

		// Token: 0x040016A0 RID: 5792
		private static readonly IntPtr NativeFieldInfoPtr_ST_long;

		// Token: 0x040016A1 RID: 5793
		private static readonly IntPtr NativeFieldInfoPtr_ST_unsignedLong;

		// Token: 0x040016A2 RID: 5794
		private static readonly IntPtr NativeFieldInfoPtr_ST_integer;

		// Token: 0x040016A3 RID: 5795
		private static readonly IntPtr NativeFieldInfoPtr_ST_decimal;

		// Token: 0x040016A4 RID: 5796
		private static readonly IntPtr NativeFieldInfoPtr_ST_float;

		// Token: 0x040016A5 RID: 5797
		private static readonly IntPtr NativeFieldInfoPtr_ST_double;

		// Token: 0x040016A6 RID: 5798
		private static readonly IntPtr NativeFieldInfoPtr_ST_duration;

		// Token: 0x040016A7 RID: 5799
		private static readonly IntPtr NativeFieldInfoPtr_ST_dateTime;

		// Token: 0x040016A8 RID: 5800
		private static readonly IntPtr NativeFieldInfoPtr_ST_time;

		// Token: 0x040016A9 RID: 5801
		private static readonly IntPtr NativeFieldInfoPtr_ST_date;

		// Token: 0x040016AA RID: 5802
		private static readonly IntPtr NativeFieldInfoPtr_ST_gYearMonth;

		// Token: 0x040016AB RID: 5803
		private static readonly IntPtr NativeFieldInfoPtr_ST_string;

		// Token: 0x040016AC RID: 5804
		private static readonly IntPtr NativeFieldInfoPtr_ST_anySimpleType;

		// Token: 0x040016AD RID: 5805
		private static readonly IntPtr NativeFieldInfoPtr_SimpleTypes;

		// Token: 0x040016AE RID: 5806
		private static readonly IntPtr NativeFieldInfoPtr_rootSchema;

		// Token: 0x040016AF RID: 5807
		private static readonly IntPtr NativeFieldInfoPtr_schemaSet;

		// Token: 0x040016B0 RID: 5808
		private static readonly IntPtr NativeFieldInfoPtr_xtr;

		// Token: 0x040016B1 RID: 5809
		private static readonly IntPtr NativeFieldInfoPtr_nametable;

		// Token: 0x040016B2 RID: 5810
		private static readonly IntPtr NativeFieldInfoPtr_TargetNamespace;

		// Token: 0x040016B3 RID: 5811
		private static readonly IntPtr NativeFieldInfoPtr_NamespaceManager;

		// Token: 0x040016B4 RID: 5812
		private static readonly IntPtr NativeFieldInfoPtr_schemaList;

		// Token: 0x040016B5 RID: 5813
		private static readonly IntPtr NativeFieldInfoPtr_occurrence;

		// Token: 0x040016B6 RID: 5814
		private static readonly IntPtr NativeFieldInfoPtr_typeInference;

		// Token: 0x040016B7 RID: 5815
		private static readonly IntPtr NativeMethodInfoPtr_set_Occurrence_Public_set_Void_InferenceOption_0;

		// Token: 0x040016B8 RID: 5816
		private static readonly IntPtr NativeMethodInfoPtr_get_Occurrence_Public_get_InferenceOption_0;

		// Token: 0x040016B9 RID: 5817
		private static readonly IntPtr NativeMethodInfoPtr_set_TypeInference_Public_set_Void_InferenceOption_0;

		// Token: 0x040016BA RID: 5818
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040016BB RID: 5819
		private static readonly IntPtr NativeMethodInfoPtr_InferSchema_Public_XmlSchemaSet_XmlReader_0;

		// Token: 0x040016BC RID: 5820
		private static readonly IntPtr NativeMethodInfoPtr_InferSchema1_Internal_XmlSchemaSet_XmlReader_XmlSchemaSet_0;

		// Token: 0x040016BD RID: 5821
		private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Private_XmlSchemaAttribute_String_String_String_String_Boolean_XmlSchema_XmlSchemaObjectCollection_XmlSchemaObjectTable_0;

		// Token: 0x040016BE RID: 5822
		private static readonly IntPtr NativeMethodInfoPtr_CreateXmlSchema_Private_XmlSchema_String_0;

		// Token: 0x040016BF RID: 5823
		private static readonly IntPtr NativeMethodInfoPtr_AddElement_Private_XmlSchemaElement_String_String_String_XmlSchema_XmlSchemaObjectCollection_Int32_0;

		// Token: 0x040016C0 RID: 5824
		private static readonly IntPtr NativeMethodInfoPtr_InferElement_Internal_Void_XmlSchemaElement_Boolean_XmlSchema_0;

		// Token: 0x040016C1 RID: 5825
		private static readonly IntPtr NativeMethodInfoPtr_CheckSimpleContentExtension_Private_XmlSchemaSimpleContentExtension_XmlSchemaComplexType_0;

		// Token: 0x040016C2 RID: 5826
		private static readonly IntPtr NativeMethodInfoPtr_GetEffectiveSchemaType_Private_XmlSchemaType_XmlSchemaElement_Boolean_0;

		// Token: 0x040016C3 RID: 5827
		private static readonly IntPtr NativeMethodInfoPtr_FindMatchingElement_Internal_XmlSchemaElement_Boolean_XmlReader_XmlSchemaComplexType_byref_Int32_byref_Boolean_XmlSchema_Boolean_0;

		// Token: 0x040016C4 RID: 5828
		private static readonly IntPtr NativeMethodInfoPtr_ProcessAttributes_Internal_Void_byref_XmlSchemaElement_XmlSchemaType_Boolean_XmlSchema_0;

		// Token: 0x040016C5 RID: 5829
		private static readonly IntPtr NativeMethodInfoPtr_MoveAttributes_Private_Void_XmlSchemaSimpleContentExtension_XmlSchemaComplexType_0;

		// Token: 0x040016C6 RID: 5830
		private static readonly IntPtr NativeMethodInfoPtr_MoveAttributes_Private_Void_XmlSchemaComplexType_XmlSchemaSimpleContentExtension_Boolean_0;

		// Token: 0x040016C7 RID: 5831
		private static readonly IntPtr NativeMethodInfoPtr_FindAttribute_Internal_XmlSchemaAttribute_ICollection_String_0;

		// Token: 0x040016C8 RID: 5832
		private static readonly IntPtr NativeMethodInfoPtr_FindGlobalElement_Internal_XmlSchemaElement_String_String_byref_XmlSchema_0;

		// Token: 0x040016C9 RID: 5833
		private static readonly IntPtr NativeMethodInfoPtr_FindElement_Internal_XmlSchemaElement_XmlSchemaObjectCollection_String_0;

		// Token: 0x040016CA RID: 5834
		private static readonly IntPtr NativeMethodInfoPtr_FindAttributeRef_Internal_XmlSchemaAttribute_ICollection_String_String_0;

		// Token: 0x040016CB RID: 5835
		private static readonly IntPtr NativeMethodInfoPtr_FindElementRef_Internal_XmlSchemaElement_XmlSchemaObjectCollection_String_String_0;

		// Token: 0x040016CC RID: 5836
		private static readonly IntPtr NativeMethodInfoPtr_MakeExistingAttributesOptional_Internal_Void_XmlSchemaComplexType_XmlSchemaObjectCollection_0;

		// Token: 0x040016CD RID: 5837
		private static readonly IntPtr NativeMethodInfoPtr_SwitchUseToOptional_Private_Void_XmlSchemaObjectCollection_XmlSchemaObjectCollection_0;

		// Token: 0x040016CE RID: 5838
		private static readonly IntPtr NativeMethodInfoPtr_RefineSimpleType_Internal_XmlQualifiedName_String_byref_Int32_0;

		// Token: 0x040016CF RID: 5839
		private static readonly IntPtr NativeMethodInfoPtr_InferSimpleType_Internal_Static_Int32_String_byref_Boolean_0;

		// Token: 0x040016D0 RID: 5840
		private static readonly IntPtr NativeMethodInfoPtr_DateTime_Internal_Static_Int32_String_Boolean_Boolean_0;

		// Token: 0x040016D1 RID: 5841
		private static readonly IntPtr NativeMethodInfoPtr_CreateNewElementforChoice_Private_XmlSchemaElement_XmlSchemaElement_0;

		// Token: 0x040016D2 RID: 5842
		private static readonly IntPtr NativeMethodInfoPtr_GetSchemaType_Private_Static_Int32_XmlQualifiedName_0;

		// Token: 0x040016D3 RID: 5843
		private static readonly IntPtr NativeMethodInfoPtr_SetMinMaxOccurs_Internal_Void_XmlSchemaElement_Boolean_0;

		// Token: 0x0200025A RID: 602
		public enum InferenceOption
		{
			// Token: 0x04002660 RID: 9824
			Restricted,
			// Token: 0x04002661 RID: 9825
			Relaxed
		}
	}
}

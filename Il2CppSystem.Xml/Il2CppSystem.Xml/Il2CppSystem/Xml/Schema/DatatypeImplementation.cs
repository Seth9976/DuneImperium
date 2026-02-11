using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200012D RID: 301
	public class DatatypeImplementation : XmlSchemaDatatype
	{
		// Token: 0x060019E3 RID: 6627 RVA: 0x00083D0C File Offset: 0x00081F0C
		// Note: this type is marked as 'beforefieldinit'.
		static DatatypeImplementation()
		{
			Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "DatatypeImplementation");
			DatatypeImplementation.NativeFieldInfoPtr_variety = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "variety");
			DatatypeImplementation.NativeFieldInfoPtr_restriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "restriction");
			DatatypeImplementation.NativeFieldInfoPtr_baseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "baseType");
			DatatypeImplementation.NativeFieldInfoPtr_valueConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "valueConverter");
			DatatypeImplementation.NativeFieldInfoPtr_parentSchemaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "parentSchemaType");
			DatatypeImplementation.NativeFieldInfoPtr_builtinTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "builtinTypes");
			DatatypeImplementation.NativeFieldInfoPtr_enumToTypeCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "enumToTypeCode");
			DatatypeImplementation.NativeFieldInfoPtr_anySimpleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "anySimpleType");
			DatatypeImplementation.NativeFieldInfoPtr_anyAtomicType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "anyAtomicType");
			DatatypeImplementation.NativeFieldInfoPtr_untypedAtomicType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "untypedAtomicType");
			DatatypeImplementation.NativeFieldInfoPtr_yearMonthDurationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "yearMonthDurationType");
			DatatypeImplementation.NativeFieldInfoPtr_dayTimeDurationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "dayTimeDurationType");
			DatatypeImplementation.NativeFieldInfoPtr_normalizedStringTypeV1Compat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "normalizedStringTypeV1Compat");
			DatatypeImplementation.NativeFieldInfoPtr_tokenTypeV1Compat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "tokenTypeV1Compat");
			DatatypeImplementation.NativeFieldInfoPtr_QnAnySimpleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "QnAnySimpleType");
			DatatypeImplementation.NativeFieldInfoPtr_QnAnyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "QnAnyType");
			DatatypeImplementation.NativeFieldInfoPtr_stringFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "stringFacetsChecker");
			DatatypeImplementation.NativeFieldInfoPtr_miscFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "miscFacetsChecker");
			DatatypeImplementation.NativeFieldInfoPtr_numeric2FacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "numeric2FacetsChecker");
			DatatypeImplementation.NativeFieldInfoPtr_binaryFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "binaryFacetsChecker");
			DatatypeImplementation.NativeFieldInfoPtr_dateTimeFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "dateTimeFacetsChecker");
			DatatypeImplementation.NativeFieldInfoPtr_durationFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "durationFacetsChecker");
			DatatypeImplementation.NativeFieldInfoPtr_listFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "listFacetsChecker");
			DatatypeImplementation.NativeFieldInfoPtr_qnameFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "qnameFacetsChecker");
			DatatypeImplementation.NativeFieldInfoPtr_unionFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "unionFacetsChecker");
			DatatypeImplementation.NativeFieldInfoPtr_c_anySimpleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_anySimpleType");
			DatatypeImplementation.NativeFieldInfoPtr_c_anyURI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_anyURI");
			DatatypeImplementation.NativeFieldInfoPtr_c_base64Binary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_base64Binary");
			DatatypeImplementation.NativeFieldInfoPtr_c_boolean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_boolean");
			DatatypeImplementation.NativeFieldInfoPtr_c_byte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_byte");
			DatatypeImplementation.NativeFieldInfoPtr_c_char = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_char");
			DatatypeImplementation.NativeFieldInfoPtr_c_date = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_date");
			DatatypeImplementation.NativeFieldInfoPtr_c_dateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_dateTime");
			DatatypeImplementation.NativeFieldInfoPtr_c_dateTimeNoTz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_dateTimeNoTz");
			DatatypeImplementation.NativeFieldInfoPtr_c_dateTimeTz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_dateTimeTz");
			DatatypeImplementation.NativeFieldInfoPtr_c_day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_day");
			DatatypeImplementation.NativeFieldInfoPtr_c_decimal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_decimal");
			DatatypeImplementation.NativeFieldInfoPtr_c_double = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_double");
			DatatypeImplementation.NativeFieldInfoPtr_c_doubleXdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_doubleXdr");
			DatatypeImplementation.NativeFieldInfoPtr_c_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_duration");
			DatatypeImplementation.NativeFieldInfoPtr_c_ENTITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_ENTITY");
			DatatypeImplementation.NativeFieldInfoPtr_c_ENTITIES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_ENTITIES");
			DatatypeImplementation.NativeFieldInfoPtr_c_ENUMERATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_ENUMERATION");
			DatatypeImplementation.NativeFieldInfoPtr_c_fixed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_fixed");
			DatatypeImplementation.NativeFieldInfoPtr_c_float = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_float");
			DatatypeImplementation.NativeFieldInfoPtr_c_floatXdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_floatXdr");
			DatatypeImplementation.NativeFieldInfoPtr_c_hexBinary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_hexBinary");
			DatatypeImplementation.NativeFieldInfoPtr_c_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_ID");
			DatatypeImplementation.NativeFieldInfoPtr_c_IDREF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_IDREF");
			DatatypeImplementation.NativeFieldInfoPtr_c_IDREFS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_IDREFS");
			DatatypeImplementation.NativeFieldInfoPtr_c_int = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_int");
			DatatypeImplementation.NativeFieldInfoPtr_c_integer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_integer");
			DatatypeImplementation.NativeFieldInfoPtr_c_language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_language");
			DatatypeImplementation.NativeFieldInfoPtr_c_long = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_long");
			DatatypeImplementation.NativeFieldInfoPtr_c_month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_month");
			DatatypeImplementation.NativeFieldInfoPtr_c_monthDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_monthDay");
			DatatypeImplementation.NativeFieldInfoPtr_c_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_Name");
			DatatypeImplementation.NativeFieldInfoPtr_c_NCName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_NCName");
			DatatypeImplementation.NativeFieldInfoPtr_c_negativeInteger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_negativeInteger");
			DatatypeImplementation.NativeFieldInfoPtr_c_NMTOKEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_NMTOKEN");
			DatatypeImplementation.NativeFieldInfoPtr_c_NMTOKENS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_NMTOKENS");
			DatatypeImplementation.NativeFieldInfoPtr_c_nonNegativeInteger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_nonNegativeInteger");
			DatatypeImplementation.NativeFieldInfoPtr_c_nonPositiveInteger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_nonPositiveInteger");
			DatatypeImplementation.NativeFieldInfoPtr_c_normalizedString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_normalizedString");
			DatatypeImplementation.NativeFieldInfoPtr_c_NOTATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_NOTATION");
			DatatypeImplementation.NativeFieldInfoPtr_c_positiveInteger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_positiveInteger");
			DatatypeImplementation.NativeFieldInfoPtr_c_QName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_QName");
			DatatypeImplementation.NativeFieldInfoPtr_c_QNameXdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_QNameXdr");
			DatatypeImplementation.NativeFieldInfoPtr_c_short = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_short");
			DatatypeImplementation.NativeFieldInfoPtr_c_string = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_string");
			DatatypeImplementation.NativeFieldInfoPtr_c_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_time");
			DatatypeImplementation.NativeFieldInfoPtr_c_timeNoTz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_timeNoTz");
			DatatypeImplementation.NativeFieldInfoPtr_c_timeTz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_timeTz");
			DatatypeImplementation.NativeFieldInfoPtr_c_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_token");
			DatatypeImplementation.NativeFieldInfoPtr_c_unsignedByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_unsignedByte");
			DatatypeImplementation.NativeFieldInfoPtr_c_unsignedInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_unsignedInt");
			DatatypeImplementation.NativeFieldInfoPtr_c_unsignedLong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_unsignedLong");
			DatatypeImplementation.NativeFieldInfoPtr_c_unsignedShort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_unsignedShort");
			DatatypeImplementation.NativeFieldInfoPtr_c_uuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_uuid");
			DatatypeImplementation.NativeFieldInfoPtr_c_year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_year");
			DatatypeImplementation.NativeFieldInfoPtr_c_yearMonth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_yearMonth");
			DatatypeImplementation.NativeFieldInfoPtr_c_normalizedStringV1Compat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_normalizedStringV1Compat");
			DatatypeImplementation.NativeFieldInfoPtr_c_tokenV1Compat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_tokenV1Compat");
			DatatypeImplementation.NativeFieldInfoPtr_c_anyAtomicType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_anyAtomicType");
			DatatypeImplementation.NativeFieldInfoPtr_c_dayTimeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_dayTimeDuration");
			DatatypeImplementation.NativeFieldInfoPtr_c_untypedAtomicType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_untypedAtomicType");
			DatatypeImplementation.NativeFieldInfoPtr_c_yearMonthDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_yearMonthDuration");
			DatatypeImplementation.NativeFieldInfoPtr_c_tokenizedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_tokenizedTypes");
			DatatypeImplementation.NativeFieldInfoPtr_c_tokenizedTypesXsd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_tokenizedTypesXsd");
			DatatypeImplementation.NativeFieldInfoPtr_c_XdrTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_XdrTypes");
			DatatypeImplementation.NativeFieldInfoPtr_c_XsdTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_XsdTypes");
			DatatypeImplementation.NativeMethodInfoPtr_get_AnySimpleType_Internal_Static_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667250);
			DatatypeImplementation.NativeMethodInfoPtr_get_UntypedAtomicType_Internal_Static_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667251);
			DatatypeImplementation.NativeMethodInfoPtr_FromXmlTokenizedType_Internal_Static_DatatypeImplementation_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667252);
			DatatypeImplementation.NativeMethodInfoPtr_FromXmlTokenizedTypeXsd_Internal_Static_DatatypeImplementation_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667253);
			DatatypeImplementation.NativeMethodInfoPtr_FromXdrName_Internal_Static_DatatypeImplementation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667254);
			DatatypeImplementation.NativeMethodInfoPtr_FromTypeName_Private_Static_DatatypeImplementation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667255);
			DatatypeImplementation.NativeMethodInfoPtr_StartBuiltinType_Internal_Static_XmlSchemaSimpleType_XmlQualifiedName_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667256);
			DatatypeImplementation.NativeMethodInfoPtr_FinishBuiltinType_Internal_Static_Void_XmlSchemaSimpleType_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667257);
			DatatypeImplementation.NativeMethodInfoPtr_CreateBuiltinTypes_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667258);
			DatatypeImplementation.NativeMethodInfoPtr_GetSimpleTypeFromTypeCode_Internal_Static_XmlSchemaSimpleType_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667259);
			DatatypeImplementation.NativeMethodInfoPtr_GetSimpleTypeFromXsdType_Internal_Static_XmlSchemaSimpleType_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667260);
			DatatypeImplementation.NativeMethodInfoPtr_GetNormalizedStringTypeV1Compat_Internal_Static_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667261);
			DatatypeImplementation.NativeMethodInfoPtr_GetTokenTypeV1Compat_Internal_Static_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667262);
			DatatypeImplementation.NativeMethodInfoPtr_GetBuiltInTypes_Internal_Static_Il2CppReferenceArray_1_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667263);
			DatatypeImplementation.NativeMethodInfoPtr_GetPrimitiveTypeCode_Internal_Static_XmlTypeCode_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667264);
			DatatypeImplementation.NativeMethodInfoPtr_DeriveByRestriction_Internal_Virtual_XmlSchemaDatatype_XmlSchemaObjectCollection_XmlNameTable_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667265);
			DatatypeImplementation.NativeMethodInfoPtr_DeriveByList_Internal_Virtual_XmlSchemaDatatype_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667266);
			DatatypeImplementation.NativeMethodInfoPtr_DeriveByList_Internal_XmlSchemaDatatype_Int32_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667267);
			DatatypeImplementation.NativeMethodInfoPtr_DeriveByUnion_Internal_Static_DatatypeImplementation_Il2CppReferenceArray_1_XmlSchemaSimpleType_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667268);
			DatatypeImplementation.NativeMethodInfoPtr_VerifySchemaValid_Internal_Virtual_Void_XmlSchemaObjectTable_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667269);
			DatatypeImplementation.NativeMethodInfoPtr_IsDerivedFrom_Public_Virtual_Boolean_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667270);
			DatatypeImplementation.NativeMethodInfoPtr_IsEqual_Internal_Virtual_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667271);
			DatatypeImplementation.NativeMethodInfoPtr_IsComparable_Internal_Virtual_Boolean_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667272);
			DatatypeImplementation.NativeMethodInfoPtr_CreateValueConverter_Internal_Virtual_New_XmlValueConverter_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667273);
			DatatypeImplementation.NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667274);
			DatatypeImplementation.NativeMethodInfoPtr_get_ValueConverter_Internal_Virtual_get_XmlValueConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667275);
			DatatypeImplementation.NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667276);
			DatatypeImplementation.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667277);
			DatatypeImplementation.NativeMethodInfoPtr_get_Variety_Public_Virtual_get_XmlSchemaDatatypeVariety_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667278);
			DatatypeImplementation.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667279);
			DatatypeImplementation.NativeMethodInfoPtr_get_Restriction_Internal_Virtual_get_RestrictionFacets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667280);
			DatatypeImplementation.NativeMethodInfoPtr_get_HasLexicalFacets_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667281);
			DatatypeImplementation.NativeMethodInfoPtr_get_HasValueFacets_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667282);
			DatatypeImplementation.NativeMethodInfoPtr_get_Base_Protected_get_DatatypeImplementation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667283);
			DatatypeImplementation.NativeMethodInfoPtr_get_ListValueType_Internal_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667284);
			DatatypeImplementation.NativeMethodInfoPtr_get_ValidRestrictionFlags_Internal_Abstract_Virtual_New_get_RestrictionFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667285);
			DatatypeImplementation.NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Virtual_get_XmlSchemaWhiteSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667286);
			DatatypeImplementation.NativeMethodInfoPtr_ParseValue_Public_Virtual_Object_String_XmlNameTable_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667287);
			DatatypeImplementation.NativeMethodInfoPtr_ParseValue_Internal_Virtual_Object_String_XmlNameTable_IXmlNamespaceResolver_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667288);
			DatatypeImplementation.NativeMethodInfoPtr_TryParseValue_Internal_Virtual_Exception_Object_XmlNameTable_IXmlNamespaceResolver_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667289);
			DatatypeImplementation.NativeMethodInfoPtr_GetTypeName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667290);
			DatatypeImplementation.NativeMethodInfoPtr_Compare_Protected_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667291);
			DatatypeImplementation.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100667292);
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x060019E4 RID: 6628 RVA: 0x000847AC File Offset: 0x000829AC
		public unsafe static XmlSchemaSimpleType AnySimpleType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393277, XrefRangeEnd = 393281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_get_AnySimpleType_Internal_Static_get_XmlSchemaSimpleType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x060019E5 RID: 6629 RVA: 0x000847E0 File Offset: 0x000829E0
		public unsafe static XmlSchemaSimpleType UntypedAtomicType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393281, XrefRangeEnd = 393285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_get_UntypedAtomicType_Internal_Static_get_XmlSchemaSimpleType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x00084814 File Offset: 0x00082A14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 393289, RefRangeEnd = 393292, XrefRangeStart = 393285, XrefRangeEnd = 393289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_FromXmlTokenizedType_Internal_Static_DatatypeImplementation_XmlTokenizedType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr3) : null;
			}
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x00084854 File Offset: 0x00082A54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 393296, RefRangeEnd = 393297, XrefRangeStart = 393292, XrefRangeEnd = 393296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static DatatypeImplementation FromXmlTokenizedTypeXsd(XmlTokenizedType token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_FromXmlTokenizedTypeXsd_Internal_Static_DatatypeImplementation_XmlTokenizedType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr3) : null;
			}
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x00084894 File Offset: 0x00082A94
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 393302, RefRangeEnd = 393307, XrefRangeStart = 393297, XrefRangeEnd = 393302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static DatatypeImplementation FromXdrName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_FromXdrName_Internal_Static_DatatypeImplementation_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr3) : null;
			}
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x000848D8 File Offset: 0x00082AD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 393312, RefRangeEnd = 393314, XrefRangeStart = 393307, XrefRangeEnd = 393312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DatatypeImplementation FromTypeName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_FromTypeName_Private_Static_DatatypeImplementation_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr3) : null;
			}
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x0008491C File Offset: 0x00082B1C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 393327, RefRangeEnd = 393333, XrefRangeStart = 393314, XrefRangeEnd = 393327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_StartBuiltinType_Internal_Static_XmlSchemaSimpleType_XmlQualifiedName_XmlSchemaDatatype_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x00084974 File Offset: 0x00082B74
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 393360, RefRangeEnd = 393365, XrefRangeStart = 393333, XrefRangeEnd = 393360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_FinishBuiltinType_Internal_Static_Void_XmlSchemaSimpleType_XmlSchemaSimpleType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x000849BC File Offset: 0x00082BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393365, XrefRangeEnd = 393522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateBuiltinTypes()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_CreateBuiltinTypes_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x000849E4 File Offset: 0x00082BE4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 393526, RefRangeEnd = 393533, XrefRangeStart = 393522, XrefRangeEnd = 393526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_GetSimpleTypeFromTypeCode_Internal_Static_XmlSchemaSimpleType_XmlTypeCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x00084A24 File Offset: 0x00082C24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 393539, RefRangeEnd = 393542, XrefRangeStart = 393533, XrefRangeEnd = 393539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaSimpleType GetSimpleTypeFromXsdType(XmlQualifiedName qname)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_GetSimpleTypeFromXsdType_Internal_Static_XmlSchemaSimpleType_XmlQualifiedName_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x00084A68 File Offset: 0x00082C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393542, XrefRangeEnd = 393571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaSimpleType GetNormalizedStringTypeV1Compat()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_GetNormalizedStringTypeV1Compat_Internal_Static_XmlSchemaSimpleType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x00084A9C File Offset: 0x00082C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393571, XrefRangeEnd = 393600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaSimpleType GetTokenTypeV1Compat()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_GetTokenTypeV1Compat_Internal_Static_XmlSchemaSimpleType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x00084AD0 File Offset: 0x00082CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393600, XrefRangeEnd = 393604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<XmlSchemaSimpleType> GetBuiltInTypes()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_GetBuiltInTypes_Internal_Static_Il2CppReferenceArray_1_XmlSchemaSimpleType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlSchemaSimpleType>>(intPtr3) : null;
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x00084B04 File Offset: 0x00082D04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 393621, RefRangeEnd = 393623, XrefRangeStart = 393604, XrefRangeEnd = 393621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlTypeCode GetPrimitiveTypeCode(XmlTypeCode typeCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_GetPrimitiveTypeCode_Internal_Static_XmlTypeCode_XmlTypeCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x00084B44 File Offset: 0x00082D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393623, XrefRangeEnd = 393630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_DeriveByRestriction_Internal_Virtual_XmlSchemaDatatype_XmlSchemaObjectCollection_XmlNameTable_XmlSchemaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x00084BC4 File Offset: 0x00082DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393630, XrefRangeEnd = 393631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_DeriveByList_Internal_Virtual_XmlSchemaDatatype_XmlSchemaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
			}
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x00084C20 File Offset: 0x00082E20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 393652, RefRangeEnd = 393653, XrefRangeStart = 393631, XrefRangeEnd = 393652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_DeriveByList_Internal_XmlSchemaDatatype_Int32_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x00084C80 File Offset: 0x00082E80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 393670, RefRangeEnd = 393671, XrefRangeStart = 393653, XrefRangeEnd = 393670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static DatatypeImplementation DeriveByUnion(Il2CppReferenceArray<XmlSchemaSimpleType> types, XmlSchemaType schemaType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(types);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_DeriveByUnion_Internal_Static_DatatypeImplementation_Il2CppReferenceArray_1_XmlSchemaSimpleType_XmlSchemaType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr3) : null;
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x00084CD8 File Offset: 0x00082ED8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_VerifySchemaValid_Internal_Virtual_Void_XmlSchemaObjectTable_XmlSchemaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x00084D38 File Offset: 0x00082F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393671, XrefRangeEnd = 393677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsDerivedFrom(XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(datatype);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_IsDerivedFrom_Public_Virtual_Boolean_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x00084D90 File Offset: 0x00082F90
		[CallerCount(0)]
		public unsafe override bool IsEqual(Object o1, Object o2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_IsEqual_Internal_Virtual_Boolean_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x00084DFC File Offset: 0x00082FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393677, XrefRangeEnd = 393682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsComparable(XmlSchemaDatatype dtype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtype);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_IsComparable_Internal_Virtual_Boolean_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x00084E54 File Offset: 0x00083054
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_CreateValueConverter_Internal_Virtual_New_XmlValueConverter_XmlSchemaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr3) : null;
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x060019FC RID: 6652 RVA: 0x00084EB0 File Offset: 0x000830B0
		public unsafe override FacetsChecker FacetsChecker
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393682, XrefRangeEnd = 393686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr3) : null;
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x060019FD RID: 6653 RVA: 0x00084EFC File Offset: 0x000830FC
		public unsafe override XmlValueConverter ValueConverter
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393686, XrefRangeEnd = 393687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_ValueConverter_Internal_Virtual_get_XmlValueConverter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr3) : null;
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x060019FE RID: 6654 RVA: 0x00084F48 File Offset: 0x00083148
		public unsafe override XmlTokenizedType TokenizedType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x060019FF RID: 6655 RVA: 0x00084F90 File Offset: 0x00083190
		public unsafe override Type ValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393687, XrefRangeEnd = 393693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06001A00 RID: 6656 RVA: 0x00084FDC File Offset: 0x000831DC
		public unsafe override XmlSchemaDatatypeVariety Variety
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_Variety_Public_Virtual_get_XmlSchemaDatatypeVariety_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06001A01 RID: 6657 RVA: 0x00085024 File Offset: 0x00083224
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06001A02 RID: 6658 RVA: 0x0008506C File Offset: 0x0008326C
		public unsafe override RestrictionFacets Restriction
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_Restriction_Internal_Virtual_get_RestrictionFacets_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RestrictionFacets>(intPtr3) : null;
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06001A03 RID: 6659 RVA: 0x000850B8 File Offset: 0x000832B8
		public unsafe override bool HasLexicalFacets
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_HasLexicalFacets_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06001A04 RID: 6660 RVA: 0x00085100 File Offset: 0x00083300
		public unsafe override bool HasValueFacets
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_HasValueFacets_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06001A05 RID: 6661 RVA: 0x00085148 File Offset: 0x00083348
		public unsafe DatatypeImplementation Base
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_get_Base_Protected_get_DatatypeImplementation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr3) : null;
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06001A06 RID: 6662 RVA: 0x00085188 File Offset: 0x00083388
		public unsafe virtual Type ListValueType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_ListValueType_Internal_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06001A07 RID: 6663 RVA: 0x000851D4 File Offset: 0x000833D4
		public unsafe virtual RestrictionFlags ValidRestrictionFlags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_ValidRestrictionFlags_Internal_Abstract_Virtual_New_get_RestrictionFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06001A08 RID: 6664 RVA: 0x0008521C File Offset: 0x0008341C
		public unsafe override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Virtual_get_XmlSchemaWhiteSpace_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x00085264 File Offset: 0x00083464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393693, XrefRangeEnd = 393694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_ParseValue_Public_Virtual_Object_String_XmlNameTable_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x000852E4 File Offset: 0x000834E4
		[CallerCount(0)]
		public unsafe override Object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_ParseValue_Internal_Virtual_Object_String_XmlNameTable_IXmlNamespaceResolver_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x00085374 File Offset: 0x00083574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393694, XrefRangeEnd = 393722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Exception TryParseValue(Object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out Object typedValue)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_TryParseValue_Internal_Virtual_Exception_Object_XmlNameTable_IXmlNamespaceResolver_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			typedValue = ((intPtr4 == 0) ? null : new Object(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr5) : null;
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x00085418 File Offset: 0x00083618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393722, XrefRangeEnd = 393726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTypeName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_GetTypeName_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x00085450 File Offset: 0x00083650
		[CallerCount(0)]
		public unsafe int Compare(Il2CppStructArray<byte> value1, Il2CppStructArray<byte> value2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_Compare_Protected_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x000854B0 File Offset: 0x000836B0
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DatatypeImplementation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x0000B185 File Offset: 0x00009385
		public DatatypeImplementation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06001A10 RID: 6672 RVA: 0x000854EC File Offset: 0x000836EC
		// (set) Token: 0x06001A11 RID: 6673 RVA: 0x0000B18E File Offset: 0x0000938E
		public unsafe XmlSchemaDatatypeVariety variety
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_variety);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_variety)) = value;
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06001A12 RID: 6674 RVA: 0x00085514 File Offset: 0x00083714
		// (set) Token: 0x06001A13 RID: 6675 RVA: 0x0000B1A9 File Offset: 0x000093A9
		public unsafe RestrictionFacets restriction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_restriction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RestrictionFacets>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_restriction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06001A14 RID: 6676 RVA: 0x00085544 File Offset: 0x00083744
		// (set) Token: 0x06001A15 RID: 6677 RVA: 0x0000B1C8 File Offset: 0x000093C8
		public unsafe DatatypeImplementation baseType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_baseType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_baseType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06001A16 RID: 6678 RVA: 0x00085574 File Offset: 0x00083774
		// (set) Token: 0x06001A17 RID: 6679 RVA: 0x0000B1E7 File Offset: 0x000093E7
		public unsafe XmlValueConverter valueConverter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_valueConverter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_valueConverter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06001A18 RID: 6680 RVA: 0x000855A4 File Offset: 0x000837A4
		// (set) Token: 0x06001A19 RID: 6681 RVA: 0x0000B206 File Offset: 0x00009406
		public unsafe XmlSchemaType parentSchemaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_parentSchemaType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_parentSchemaType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06001A1A RID: 6682 RVA: 0x000855D4 File Offset: 0x000837D4
		// (set) Token: 0x06001A1B RID: 6683 RVA: 0x0000B225 File Offset: 0x00009425
		public unsafe static Hashtable builtinTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_builtinTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_builtinTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06001A1C RID: 6684 RVA: 0x000855FC File Offset: 0x000837FC
		// (set) Token: 0x06001A1D RID: 6685 RVA: 0x0000B237 File Offset: 0x00009437
		public unsafe static Il2CppReferenceArray<XmlSchemaSimpleType> enumToTypeCode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_enumToTypeCode, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlSchemaSimpleType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_enumToTypeCode, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06001A1E RID: 6686 RVA: 0x00085624 File Offset: 0x00083824
		// (set) Token: 0x06001A1F RID: 6687 RVA: 0x0000B249 File Offset: 0x00009449
		public unsafe static XmlSchemaSimpleType anySimpleType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_anySimpleType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_anySimpleType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06001A20 RID: 6688 RVA: 0x0008564C File Offset: 0x0008384C
		// (set) Token: 0x06001A21 RID: 6689 RVA: 0x0000B25B File Offset: 0x0000945B
		public unsafe static XmlSchemaSimpleType anyAtomicType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_anyAtomicType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_anyAtomicType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06001A22 RID: 6690 RVA: 0x00085674 File Offset: 0x00083874
		// (set) Token: 0x06001A23 RID: 6691 RVA: 0x0000B26D File Offset: 0x0000946D
		public unsafe static XmlSchemaSimpleType untypedAtomicType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_untypedAtomicType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_untypedAtomicType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06001A24 RID: 6692 RVA: 0x0008569C File Offset: 0x0008389C
		// (set) Token: 0x06001A25 RID: 6693 RVA: 0x0000B27F File Offset: 0x0000947F
		public unsafe static XmlSchemaSimpleType yearMonthDurationType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_yearMonthDurationType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_yearMonthDurationType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06001A26 RID: 6694 RVA: 0x000856C4 File Offset: 0x000838C4
		// (set) Token: 0x06001A27 RID: 6695 RVA: 0x0000B291 File Offset: 0x00009491
		public unsafe static XmlSchemaSimpleType dayTimeDurationType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_dayTimeDurationType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_dayTimeDurationType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06001A28 RID: 6696 RVA: 0x000856EC File Offset: 0x000838EC
		// (set) Token: 0x06001A29 RID: 6697 RVA: 0x0000B2A3 File Offset: 0x000094A3
		public unsafe static XmlSchemaSimpleType normalizedStringTypeV1Compat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_normalizedStringTypeV1Compat, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_normalizedStringTypeV1Compat, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06001A2A RID: 6698 RVA: 0x00085714 File Offset: 0x00083914
		// (set) Token: 0x06001A2B RID: 6699 RVA: 0x0000B2B5 File Offset: 0x000094B5
		public unsafe static XmlSchemaSimpleType tokenTypeV1Compat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_tokenTypeV1Compat, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_tokenTypeV1Compat, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06001A2C RID: 6700 RVA: 0x0008573C File Offset: 0x0008393C
		// (set) Token: 0x06001A2D RID: 6701 RVA: 0x0000B2C7 File Offset: 0x000094C7
		public unsafe static XmlQualifiedName QnAnySimpleType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_QnAnySimpleType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_QnAnySimpleType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06001A2E RID: 6702 RVA: 0x00085764 File Offset: 0x00083964
		// (set) Token: 0x06001A2F RID: 6703 RVA: 0x0000B2D9 File Offset: 0x000094D9
		public unsafe static XmlQualifiedName QnAnyType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_QnAnyType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_QnAnyType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06001A30 RID: 6704 RVA: 0x0008578C File Offset: 0x0008398C
		// (set) Token: 0x06001A31 RID: 6705 RVA: 0x0000B2EB File Offset: 0x000094EB
		public unsafe static FacetsChecker stringFacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_stringFacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_stringFacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06001A32 RID: 6706 RVA: 0x000857B4 File Offset: 0x000839B4
		// (set) Token: 0x06001A33 RID: 6707 RVA: 0x0000B2FD File Offset: 0x000094FD
		public unsafe static FacetsChecker miscFacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_miscFacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_miscFacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x000857DC File Offset: 0x000839DC
		// (set) Token: 0x06001A35 RID: 6709 RVA: 0x0000B30F File Offset: 0x0000950F
		public unsafe static FacetsChecker numeric2FacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_numeric2FacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_numeric2FacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06001A36 RID: 6710 RVA: 0x00085804 File Offset: 0x00083A04
		// (set) Token: 0x06001A37 RID: 6711 RVA: 0x0000B321 File Offset: 0x00009521
		public unsafe static FacetsChecker binaryFacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_binaryFacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_binaryFacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06001A38 RID: 6712 RVA: 0x0008582C File Offset: 0x00083A2C
		// (set) Token: 0x06001A39 RID: 6713 RVA: 0x0000B333 File Offset: 0x00009533
		public unsafe static FacetsChecker dateTimeFacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_dateTimeFacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_dateTimeFacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06001A3A RID: 6714 RVA: 0x00085854 File Offset: 0x00083A54
		// (set) Token: 0x06001A3B RID: 6715 RVA: 0x0000B345 File Offset: 0x00009545
		public unsafe static FacetsChecker durationFacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_durationFacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_durationFacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06001A3C RID: 6716 RVA: 0x0008587C File Offset: 0x00083A7C
		// (set) Token: 0x06001A3D RID: 6717 RVA: 0x0000B357 File Offset: 0x00009557
		public unsafe static FacetsChecker listFacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_listFacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_listFacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06001A3E RID: 6718 RVA: 0x000858A4 File Offset: 0x00083AA4
		// (set) Token: 0x06001A3F RID: 6719 RVA: 0x0000B369 File Offset: 0x00009569
		public unsafe static FacetsChecker qnameFacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_qnameFacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_qnameFacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06001A40 RID: 6720 RVA: 0x000858CC File Offset: 0x00083ACC
		// (set) Token: 0x06001A41 RID: 6721 RVA: 0x0000B37B File Offset: 0x0000957B
		public unsafe static FacetsChecker unionFacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_unionFacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_unionFacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06001A42 RID: 6722 RVA: 0x000858F4 File Offset: 0x00083AF4
		// (set) Token: 0x06001A43 RID: 6723 RVA: 0x0000B38D File Offset: 0x0000958D
		public unsafe static DatatypeImplementation c_anySimpleType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_anySimpleType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_anySimpleType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06001A44 RID: 6724 RVA: 0x0008591C File Offset: 0x00083B1C
		// (set) Token: 0x06001A45 RID: 6725 RVA: 0x0000B39F File Offset: 0x0000959F
		public unsafe static DatatypeImplementation c_anyURI
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_anyURI, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_anyURI, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06001A46 RID: 6726 RVA: 0x00085944 File Offset: 0x00083B44
		// (set) Token: 0x06001A47 RID: 6727 RVA: 0x0000B3B1 File Offset: 0x000095B1
		public unsafe static DatatypeImplementation c_base64Binary
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_base64Binary, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_base64Binary, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06001A48 RID: 6728 RVA: 0x0008596C File Offset: 0x00083B6C
		// (set) Token: 0x06001A49 RID: 6729 RVA: 0x0000B3C3 File Offset: 0x000095C3
		public unsafe static DatatypeImplementation c_boolean
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_boolean, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_boolean, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06001A4A RID: 6730 RVA: 0x00085994 File Offset: 0x00083B94
		// (set) Token: 0x06001A4B RID: 6731 RVA: 0x0000B3D5 File Offset: 0x000095D5
		public unsafe static DatatypeImplementation c_byte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_byte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_byte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06001A4C RID: 6732 RVA: 0x000859BC File Offset: 0x00083BBC
		// (set) Token: 0x06001A4D RID: 6733 RVA: 0x0000B3E7 File Offset: 0x000095E7
		public unsafe static DatatypeImplementation c_char
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_char, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_char, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06001A4E RID: 6734 RVA: 0x000859E4 File Offset: 0x00083BE4
		// (set) Token: 0x06001A4F RID: 6735 RVA: 0x0000B3F9 File Offset: 0x000095F9
		public unsafe static DatatypeImplementation c_date
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_date, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_date, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06001A50 RID: 6736 RVA: 0x00085A0C File Offset: 0x00083C0C
		// (set) Token: 0x06001A51 RID: 6737 RVA: 0x0000B40B File Offset: 0x0000960B
		public unsafe static DatatypeImplementation c_dateTime
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_dateTime, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_dateTime, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06001A52 RID: 6738 RVA: 0x00085A34 File Offset: 0x00083C34
		// (set) Token: 0x06001A53 RID: 6739 RVA: 0x0000B41D File Offset: 0x0000961D
		public unsafe static DatatypeImplementation c_dateTimeNoTz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_dateTimeNoTz, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_dateTimeNoTz, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06001A54 RID: 6740 RVA: 0x00085A5C File Offset: 0x00083C5C
		// (set) Token: 0x06001A55 RID: 6741 RVA: 0x0000B42F File Offset: 0x0000962F
		public unsafe static DatatypeImplementation c_dateTimeTz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_dateTimeTz, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_dateTimeTz, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06001A56 RID: 6742 RVA: 0x00085A84 File Offset: 0x00083C84
		// (set) Token: 0x06001A57 RID: 6743 RVA: 0x0000B441 File Offset: 0x00009641
		public unsafe static DatatypeImplementation c_day
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_day, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_day, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06001A58 RID: 6744 RVA: 0x00085AAC File Offset: 0x00083CAC
		// (set) Token: 0x06001A59 RID: 6745 RVA: 0x0000B453 File Offset: 0x00009653
		public unsafe static DatatypeImplementation c_decimal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_decimal, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_decimal, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06001A5A RID: 6746 RVA: 0x00085AD4 File Offset: 0x00083CD4
		// (set) Token: 0x06001A5B RID: 6747 RVA: 0x0000B465 File Offset: 0x00009665
		public unsafe static DatatypeImplementation c_double
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_double, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_double, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06001A5C RID: 6748 RVA: 0x00085AFC File Offset: 0x00083CFC
		// (set) Token: 0x06001A5D RID: 6749 RVA: 0x0000B477 File Offset: 0x00009677
		public unsafe static DatatypeImplementation c_doubleXdr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_doubleXdr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_doubleXdr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06001A5E RID: 6750 RVA: 0x00085B24 File Offset: 0x00083D24
		// (set) Token: 0x06001A5F RID: 6751 RVA: 0x0000B489 File Offset: 0x00009689
		public unsafe static DatatypeImplementation c_duration
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_duration, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_duration, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06001A60 RID: 6752 RVA: 0x00085B4C File Offset: 0x00083D4C
		// (set) Token: 0x06001A61 RID: 6753 RVA: 0x0000B49B File Offset: 0x0000969B
		public unsafe static DatatypeImplementation c_ENTITY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_ENTITY, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_ENTITY, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06001A62 RID: 6754 RVA: 0x00085B74 File Offset: 0x00083D74
		// (set) Token: 0x06001A63 RID: 6755 RVA: 0x0000B4AD File Offset: 0x000096AD
		public unsafe static DatatypeImplementation c_ENTITIES
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_ENTITIES, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_ENTITIES, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06001A64 RID: 6756 RVA: 0x00085B9C File Offset: 0x00083D9C
		// (set) Token: 0x06001A65 RID: 6757 RVA: 0x0000B4BF File Offset: 0x000096BF
		public unsafe static DatatypeImplementation c_ENUMERATION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_ENUMERATION, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_ENUMERATION, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06001A66 RID: 6758 RVA: 0x00085BC4 File Offset: 0x00083DC4
		// (set) Token: 0x06001A67 RID: 6759 RVA: 0x0000B4D1 File Offset: 0x000096D1
		public unsafe static DatatypeImplementation c_fixed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_fixed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_fixed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x00085BEC File Offset: 0x00083DEC
		// (set) Token: 0x06001A69 RID: 6761 RVA: 0x0000B4E3 File Offset: 0x000096E3
		public unsafe static DatatypeImplementation c_float
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_float, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_float, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06001A6A RID: 6762 RVA: 0x00085C14 File Offset: 0x00083E14
		// (set) Token: 0x06001A6B RID: 6763 RVA: 0x0000B4F5 File Offset: 0x000096F5
		public unsafe static DatatypeImplementation c_floatXdr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_floatXdr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_floatXdr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06001A6C RID: 6764 RVA: 0x00085C3C File Offset: 0x00083E3C
		// (set) Token: 0x06001A6D RID: 6765 RVA: 0x0000B507 File Offset: 0x00009707
		public unsafe static DatatypeImplementation c_hexBinary
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_hexBinary, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_hexBinary, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06001A6E RID: 6766 RVA: 0x00085C64 File Offset: 0x00083E64
		// (set) Token: 0x06001A6F RID: 6767 RVA: 0x0000B519 File Offset: 0x00009719
		public unsafe static DatatypeImplementation c_ID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_ID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_ID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06001A70 RID: 6768 RVA: 0x00085C8C File Offset: 0x00083E8C
		// (set) Token: 0x06001A71 RID: 6769 RVA: 0x0000B52B File Offset: 0x0000972B
		public unsafe static DatatypeImplementation c_IDREF
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_IDREF, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_IDREF, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06001A72 RID: 6770 RVA: 0x00085CB4 File Offset: 0x00083EB4
		// (set) Token: 0x06001A73 RID: 6771 RVA: 0x0000B53D File Offset: 0x0000973D
		public unsafe static DatatypeImplementation c_IDREFS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_IDREFS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_IDREFS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06001A74 RID: 6772 RVA: 0x00085CDC File Offset: 0x00083EDC
		// (set) Token: 0x06001A75 RID: 6773 RVA: 0x0000B54F File Offset: 0x0000974F
		public unsafe static DatatypeImplementation c_int
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_int, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_int, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06001A76 RID: 6774 RVA: 0x00085D04 File Offset: 0x00083F04
		// (set) Token: 0x06001A77 RID: 6775 RVA: 0x0000B561 File Offset: 0x00009761
		public unsafe static DatatypeImplementation c_integer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_integer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_integer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06001A78 RID: 6776 RVA: 0x00085D2C File Offset: 0x00083F2C
		// (set) Token: 0x06001A79 RID: 6777 RVA: 0x0000B573 File Offset: 0x00009773
		public unsafe static DatatypeImplementation c_language
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_language, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_language, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06001A7A RID: 6778 RVA: 0x00085D54 File Offset: 0x00083F54
		// (set) Token: 0x06001A7B RID: 6779 RVA: 0x0000B585 File Offset: 0x00009785
		public unsafe static DatatypeImplementation c_long
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_long, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_long, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06001A7C RID: 6780 RVA: 0x00085D7C File Offset: 0x00083F7C
		// (set) Token: 0x06001A7D RID: 6781 RVA: 0x0000B597 File Offset: 0x00009797
		public unsafe static DatatypeImplementation c_month
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_month, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_month, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06001A7E RID: 6782 RVA: 0x00085DA4 File Offset: 0x00083FA4
		// (set) Token: 0x06001A7F RID: 6783 RVA: 0x0000B5A9 File Offset: 0x000097A9
		public unsafe static DatatypeImplementation c_monthDay
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_monthDay, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_monthDay, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06001A80 RID: 6784 RVA: 0x00085DCC File Offset: 0x00083FCC
		// (set) Token: 0x06001A81 RID: 6785 RVA: 0x0000B5BB File Offset: 0x000097BB
		public unsafe static DatatypeImplementation c_Name
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_Name, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_Name, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06001A82 RID: 6786 RVA: 0x00085DF4 File Offset: 0x00083FF4
		// (set) Token: 0x06001A83 RID: 6787 RVA: 0x0000B5CD File Offset: 0x000097CD
		public unsafe static DatatypeImplementation c_NCName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_NCName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_NCName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06001A84 RID: 6788 RVA: 0x00085E1C File Offset: 0x0008401C
		// (set) Token: 0x06001A85 RID: 6789 RVA: 0x0000B5DF File Offset: 0x000097DF
		public unsafe static DatatypeImplementation c_negativeInteger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_negativeInteger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_negativeInteger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06001A86 RID: 6790 RVA: 0x00085E44 File Offset: 0x00084044
		// (set) Token: 0x06001A87 RID: 6791 RVA: 0x0000B5F1 File Offset: 0x000097F1
		public unsafe static DatatypeImplementation c_NMTOKEN
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_NMTOKEN, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_NMTOKEN, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06001A88 RID: 6792 RVA: 0x00085E6C File Offset: 0x0008406C
		// (set) Token: 0x06001A89 RID: 6793 RVA: 0x0000B603 File Offset: 0x00009803
		public unsafe static DatatypeImplementation c_NMTOKENS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_NMTOKENS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_NMTOKENS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06001A8A RID: 6794 RVA: 0x00085E94 File Offset: 0x00084094
		// (set) Token: 0x06001A8B RID: 6795 RVA: 0x0000B615 File Offset: 0x00009815
		public unsafe static DatatypeImplementation c_nonNegativeInteger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_nonNegativeInteger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_nonNegativeInteger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06001A8C RID: 6796 RVA: 0x00085EBC File Offset: 0x000840BC
		// (set) Token: 0x06001A8D RID: 6797 RVA: 0x0000B627 File Offset: 0x00009827
		public unsafe static DatatypeImplementation c_nonPositiveInteger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_nonPositiveInteger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_nonPositiveInteger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06001A8E RID: 6798 RVA: 0x00085EE4 File Offset: 0x000840E4
		// (set) Token: 0x06001A8F RID: 6799 RVA: 0x0000B639 File Offset: 0x00009839
		public unsafe static DatatypeImplementation c_normalizedString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_normalizedString, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_normalizedString, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06001A90 RID: 6800 RVA: 0x00085F0C File Offset: 0x0008410C
		// (set) Token: 0x06001A91 RID: 6801 RVA: 0x0000B64B File Offset: 0x0000984B
		public unsafe static DatatypeImplementation c_NOTATION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_NOTATION, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_NOTATION, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06001A92 RID: 6802 RVA: 0x00085F34 File Offset: 0x00084134
		// (set) Token: 0x06001A93 RID: 6803 RVA: 0x0000B65D File Offset: 0x0000985D
		public unsafe static DatatypeImplementation c_positiveInteger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_positiveInteger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_positiveInteger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06001A94 RID: 6804 RVA: 0x00085F5C File Offset: 0x0008415C
		// (set) Token: 0x06001A95 RID: 6805 RVA: 0x0000B66F File Offset: 0x0000986F
		public unsafe static DatatypeImplementation c_QName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_QName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_QName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06001A96 RID: 6806 RVA: 0x00085F84 File Offset: 0x00084184
		// (set) Token: 0x06001A97 RID: 6807 RVA: 0x0000B681 File Offset: 0x00009881
		public unsafe static DatatypeImplementation c_QNameXdr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_QNameXdr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_QNameXdr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06001A98 RID: 6808 RVA: 0x00085FAC File Offset: 0x000841AC
		// (set) Token: 0x06001A99 RID: 6809 RVA: 0x0000B693 File Offset: 0x00009893
		public unsafe static DatatypeImplementation c_short
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_short, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_short, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06001A9A RID: 6810 RVA: 0x00085FD4 File Offset: 0x000841D4
		// (set) Token: 0x06001A9B RID: 6811 RVA: 0x0000B6A5 File Offset: 0x000098A5
		public unsafe static DatatypeImplementation c_string
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_string, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_string, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06001A9C RID: 6812 RVA: 0x00085FFC File Offset: 0x000841FC
		// (set) Token: 0x06001A9D RID: 6813 RVA: 0x0000B6B7 File Offset: 0x000098B7
		public unsafe static DatatypeImplementation c_time
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_time, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_time, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06001A9E RID: 6814 RVA: 0x00086024 File Offset: 0x00084224
		// (set) Token: 0x06001A9F RID: 6815 RVA: 0x0000B6C9 File Offset: 0x000098C9
		public unsafe static DatatypeImplementation c_timeNoTz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_timeNoTz, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_timeNoTz, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x0008604C File Offset: 0x0008424C
		// (set) Token: 0x06001AA1 RID: 6817 RVA: 0x0000B6DB File Offset: 0x000098DB
		public unsafe static DatatypeImplementation c_timeTz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_timeTz, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_timeTz, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06001AA2 RID: 6818 RVA: 0x00086074 File Offset: 0x00084274
		// (set) Token: 0x06001AA3 RID: 6819 RVA: 0x0000B6ED File Offset: 0x000098ED
		public unsafe static DatatypeImplementation c_token
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_token, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_token, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06001AA4 RID: 6820 RVA: 0x0008609C File Offset: 0x0008429C
		// (set) Token: 0x06001AA5 RID: 6821 RVA: 0x0000B6FF File Offset: 0x000098FF
		public unsafe static DatatypeImplementation c_unsignedByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_unsignedByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_unsignedByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06001AA6 RID: 6822 RVA: 0x000860C4 File Offset: 0x000842C4
		// (set) Token: 0x06001AA7 RID: 6823 RVA: 0x0000B711 File Offset: 0x00009911
		public unsafe static DatatypeImplementation c_unsignedInt
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_unsignedInt, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_unsignedInt, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06001AA8 RID: 6824 RVA: 0x000860EC File Offset: 0x000842EC
		// (set) Token: 0x06001AA9 RID: 6825 RVA: 0x0000B723 File Offset: 0x00009923
		public unsafe static DatatypeImplementation c_unsignedLong
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_unsignedLong, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_unsignedLong, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06001AAA RID: 6826 RVA: 0x00086114 File Offset: 0x00084314
		// (set) Token: 0x06001AAB RID: 6827 RVA: 0x0000B735 File Offset: 0x00009935
		public unsafe static DatatypeImplementation c_unsignedShort
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_unsignedShort, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_unsignedShort, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06001AAC RID: 6828 RVA: 0x0008613C File Offset: 0x0008433C
		// (set) Token: 0x06001AAD RID: 6829 RVA: 0x0000B747 File Offset: 0x00009947
		public unsafe static DatatypeImplementation c_uuid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_uuid, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_uuid, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06001AAE RID: 6830 RVA: 0x00086164 File Offset: 0x00084364
		// (set) Token: 0x06001AAF RID: 6831 RVA: 0x0000B759 File Offset: 0x00009959
		public unsafe static DatatypeImplementation c_year
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_year, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_year, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x0008618C File Offset: 0x0008438C
		// (set) Token: 0x06001AB1 RID: 6833 RVA: 0x0000B76B File Offset: 0x0000996B
		public unsafe static DatatypeImplementation c_yearMonth
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_yearMonth, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_yearMonth, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x000861B4 File Offset: 0x000843B4
		// (set) Token: 0x06001AB3 RID: 6835 RVA: 0x0000B77D File Offset: 0x0000997D
		public unsafe static DatatypeImplementation c_normalizedStringV1Compat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_normalizedStringV1Compat, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_normalizedStringV1Compat, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x000861DC File Offset: 0x000843DC
		// (set) Token: 0x06001AB5 RID: 6837 RVA: 0x0000B78F File Offset: 0x0000998F
		public unsafe static DatatypeImplementation c_tokenV1Compat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_tokenV1Compat, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_tokenV1Compat, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06001AB6 RID: 6838 RVA: 0x00086204 File Offset: 0x00084404
		// (set) Token: 0x06001AB7 RID: 6839 RVA: 0x0000B7A1 File Offset: 0x000099A1
		public unsafe static DatatypeImplementation c_anyAtomicType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_anyAtomicType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_anyAtomicType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06001AB8 RID: 6840 RVA: 0x0008622C File Offset: 0x0008442C
		// (set) Token: 0x06001AB9 RID: 6841 RVA: 0x0000B7B3 File Offset: 0x000099B3
		public unsafe static DatatypeImplementation c_dayTimeDuration
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_dayTimeDuration, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_dayTimeDuration, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06001ABA RID: 6842 RVA: 0x00086254 File Offset: 0x00084454
		// (set) Token: 0x06001ABB RID: 6843 RVA: 0x0000B7C5 File Offset: 0x000099C5
		public unsafe static DatatypeImplementation c_untypedAtomicType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_untypedAtomicType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_untypedAtomicType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06001ABC RID: 6844 RVA: 0x0008627C File Offset: 0x0008447C
		// (set) Token: 0x06001ABD RID: 6845 RVA: 0x0000B7D7 File Offset: 0x000099D7
		public unsafe static DatatypeImplementation c_yearMonthDuration
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_yearMonthDuration, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_yearMonthDuration, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06001ABE RID: 6846 RVA: 0x000862A4 File Offset: 0x000844A4
		// (set) Token: 0x06001ABF RID: 6847 RVA: 0x0000B7E9 File Offset: 0x000099E9
		public unsafe static Il2CppReferenceArray<DatatypeImplementation> c_tokenizedTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_tokenizedTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DatatypeImplementation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_tokenizedTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06001AC0 RID: 6848 RVA: 0x000862CC File Offset: 0x000844CC
		// (set) Token: 0x06001AC1 RID: 6849 RVA: 0x0000B7FB File Offset: 0x000099FB
		public unsafe static Il2CppReferenceArray<DatatypeImplementation> c_tokenizedTypesXsd
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_tokenizedTypesXsd, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DatatypeImplementation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_tokenizedTypesXsd, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06001AC2 RID: 6850 RVA: 0x000862F4 File Offset: 0x000844F4
		// (set) Token: 0x06001AC3 RID: 6851 RVA: 0x0000B80D File Offset: 0x00009A0D
		public unsafe static Il2CppReferenceArray<DatatypeImplementation.SchemaDatatypeMap> c_XdrTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_XdrTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DatatypeImplementation.SchemaDatatypeMap>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_XdrTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06001AC4 RID: 6852 RVA: 0x0008631C File Offset: 0x0008451C
		// (set) Token: 0x06001AC5 RID: 6853 RVA: 0x0000B81F File Offset: 0x00009A1F
		public unsafe static Il2CppReferenceArray<DatatypeImplementation.SchemaDatatypeMap> c_XsdTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_XsdTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DatatypeImplementation.SchemaDatatypeMap>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_XsdTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001422 RID: 5154
		private static readonly IntPtr NativeFieldInfoPtr_variety;

		// Token: 0x04001423 RID: 5155
		private static readonly IntPtr NativeFieldInfoPtr_restriction;

		// Token: 0x04001424 RID: 5156
		private static readonly IntPtr NativeFieldInfoPtr_baseType;

		// Token: 0x04001425 RID: 5157
		private static readonly IntPtr NativeFieldInfoPtr_valueConverter;

		// Token: 0x04001426 RID: 5158
		private static readonly IntPtr NativeFieldInfoPtr_parentSchemaType;

		// Token: 0x04001427 RID: 5159
		private static readonly IntPtr NativeFieldInfoPtr_builtinTypes;

		// Token: 0x04001428 RID: 5160
		private static readonly IntPtr NativeFieldInfoPtr_enumToTypeCode;

		// Token: 0x04001429 RID: 5161
		private static readonly IntPtr NativeFieldInfoPtr_anySimpleType;

		// Token: 0x0400142A RID: 5162
		private static readonly IntPtr NativeFieldInfoPtr_anyAtomicType;

		// Token: 0x0400142B RID: 5163
		private static readonly IntPtr NativeFieldInfoPtr_untypedAtomicType;

		// Token: 0x0400142C RID: 5164
		private static readonly IntPtr NativeFieldInfoPtr_yearMonthDurationType;

		// Token: 0x0400142D RID: 5165
		private static readonly IntPtr NativeFieldInfoPtr_dayTimeDurationType;

		// Token: 0x0400142E RID: 5166
		private static readonly IntPtr NativeFieldInfoPtr_normalizedStringTypeV1Compat;

		// Token: 0x0400142F RID: 5167
		private static readonly IntPtr NativeFieldInfoPtr_tokenTypeV1Compat;

		// Token: 0x04001430 RID: 5168
		private static readonly IntPtr NativeFieldInfoPtr_QnAnySimpleType;

		// Token: 0x04001431 RID: 5169
		private static readonly IntPtr NativeFieldInfoPtr_QnAnyType;

		// Token: 0x04001432 RID: 5170
		private static readonly IntPtr NativeFieldInfoPtr_stringFacetsChecker;

		// Token: 0x04001433 RID: 5171
		private static readonly IntPtr NativeFieldInfoPtr_miscFacetsChecker;

		// Token: 0x04001434 RID: 5172
		private static readonly IntPtr NativeFieldInfoPtr_numeric2FacetsChecker;

		// Token: 0x04001435 RID: 5173
		private static readonly IntPtr NativeFieldInfoPtr_binaryFacetsChecker;

		// Token: 0x04001436 RID: 5174
		private static readonly IntPtr NativeFieldInfoPtr_dateTimeFacetsChecker;

		// Token: 0x04001437 RID: 5175
		private static readonly IntPtr NativeFieldInfoPtr_durationFacetsChecker;

		// Token: 0x04001438 RID: 5176
		private static readonly IntPtr NativeFieldInfoPtr_listFacetsChecker;

		// Token: 0x04001439 RID: 5177
		private static readonly IntPtr NativeFieldInfoPtr_qnameFacetsChecker;

		// Token: 0x0400143A RID: 5178
		private static readonly IntPtr NativeFieldInfoPtr_unionFacetsChecker;

		// Token: 0x0400143B RID: 5179
		private static readonly IntPtr NativeFieldInfoPtr_c_anySimpleType;

		// Token: 0x0400143C RID: 5180
		private static readonly IntPtr NativeFieldInfoPtr_c_anyURI;

		// Token: 0x0400143D RID: 5181
		private static readonly IntPtr NativeFieldInfoPtr_c_base64Binary;

		// Token: 0x0400143E RID: 5182
		private static readonly IntPtr NativeFieldInfoPtr_c_boolean;

		// Token: 0x0400143F RID: 5183
		private static readonly IntPtr NativeFieldInfoPtr_c_byte;

		// Token: 0x04001440 RID: 5184
		private static readonly IntPtr NativeFieldInfoPtr_c_char;

		// Token: 0x04001441 RID: 5185
		private static readonly IntPtr NativeFieldInfoPtr_c_date;

		// Token: 0x04001442 RID: 5186
		private static readonly IntPtr NativeFieldInfoPtr_c_dateTime;

		// Token: 0x04001443 RID: 5187
		private static readonly IntPtr NativeFieldInfoPtr_c_dateTimeNoTz;

		// Token: 0x04001444 RID: 5188
		private static readonly IntPtr NativeFieldInfoPtr_c_dateTimeTz;

		// Token: 0x04001445 RID: 5189
		private static readonly IntPtr NativeFieldInfoPtr_c_day;

		// Token: 0x04001446 RID: 5190
		private static readonly IntPtr NativeFieldInfoPtr_c_decimal;

		// Token: 0x04001447 RID: 5191
		private static readonly IntPtr NativeFieldInfoPtr_c_double;

		// Token: 0x04001448 RID: 5192
		private static readonly IntPtr NativeFieldInfoPtr_c_doubleXdr;

		// Token: 0x04001449 RID: 5193
		private static readonly IntPtr NativeFieldInfoPtr_c_duration;

		// Token: 0x0400144A RID: 5194
		private static readonly IntPtr NativeFieldInfoPtr_c_ENTITY;

		// Token: 0x0400144B RID: 5195
		private static readonly IntPtr NativeFieldInfoPtr_c_ENTITIES;

		// Token: 0x0400144C RID: 5196
		private static readonly IntPtr NativeFieldInfoPtr_c_ENUMERATION;

		// Token: 0x0400144D RID: 5197
		private static readonly IntPtr NativeFieldInfoPtr_c_fixed;

		// Token: 0x0400144E RID: 5198
		private static readonly IntPtr NativeFieldInfoPtr_c_float;

		// Token: 0x0400144F RID: 5199
		private static readonly IntPtr NativeFieldInfoPtr_c_floatXdr;

		// Token: 0x04001450 RID: 5200
		private static readonly IntPtr NativeFieldInfoPtr_c_hexBinary;

		// Token: 0x04001451 RID: 5201
		private static readonly IntPtr NativeFieldInfoPtr_c_ID;

		// Token: 0x04001452 RID: 5202
		private static readonly IntPtr NativeFieldInfoPtr_c_IDREF;

		// Token: 0x04001453 RID: 5203
		private static readonly IntPtr NativeFieldInfoPtr_c_IDREFS;

		// Token: 0x04001454 RID: 5204
		private static readonly IntPtr NativeFieldInfoPtr_c_int;

		// Token: 0x04001455 RID: 5205
		private static readonly IntPtr NativeFieldInfoPtr_c_integer;

		// Token: 0x04001456 RID: 5206
		private static readonly IntPtr NativeFieldInfoPtr_c_language;

		// Token: 0x04001457 RID: 5207
		private static readonly IntPtr NativeFieldInfoPtr_c_long;

		// Token: 0x04001458 RID: 5208
		private static readonly IntPtr NativeFieldInfoPtr_c_month;

		// Token: 0x04001459 RID: 5209
		private static readonly IntPtr NativeFieldInfoPtr_c_monthDay;

		// Token: 0x0400145A RID: 5210
		private static readonly IntPtr NativeFieldInfoPtr_c_Name;

		// Token: 0x0400145B RID: 5211
		private static readonly IntPtr NativeFieldInfoPtr_c_NCName;

		// Token: 0x0400145C RID: 5212
		private static readonly IntPtr NativeFieldInfoPtr_c_negativeInteger;

		// Token: 0x0400145D RID: 5213
		private static readonly IntPtr NativeFieldInfoPtr_c_NMTOKEN;

		// Token: 0x0400145E RID: 5214
		private static readonly IntPtr NativeFieldInfoPtr_c_NMTOKENS;

		// Token: 0x0400145F RID: 5215
		private static readonly IntPtr NativeFieldInfoPtr_c_nonNegativeInteger;

		// Token: 0x04001460 RID: 5216
		private static readonly IntPtr NativeFieldInfoPtr_c_nonPositiveInteger;

		// Token: 0x04001461 RID: 5217
		private static readonly IntPtr NativeFieldInfoPtr_c_normalizedString;

		// Token: 0x04001462 RID: 5218
		private static readonly IntPtr NativeFieldInfoPtr_c_NOTATION;

		// Token: 0x04001463 RID: 5219
		private static readonly IntPtr NativeFieldInfoPtr_c_positiveInteger;

		// Token: 0x04001464 RID: 5220
		private static readonly IntPtr NativeFieldInfoPtr_c_QName;

		// Token: 0x04001465 RID: 5221
		private static readonly IntPtr NativeFieldInfoPtr_c_QNameXdr;

		// Token: 0x04001466 RID: 5222
		private static readonly IntPtr NativeFieldInfoPtr_c_short;

		// Token: 0x04001467 RID: 5223
		private static readonly IntPtr NativeFieldInfoPtr_c_string;

		// Token: 0x04001468 RID: 5224
		private static readonly IntPtr NativeFieldInfoPtr_c_time;

		// Token: 0x04001469 RID: 5225
		private static readonly IntPtr NativeFieldInfoPtr_c_timeNoTz;

		// Token: 0x0400146A RID: 5226
		private static readonly IntPtr NativeFieldInfoPtr_c_timeTz;

		// Token: 0x0400146B RID: 5227
		private static readonly IntPtr NativeFieldInfoPtr_c_token;

		// Token: 0x0400146C RID: 5228
		private static readonly IntPtr NativeFieldInfoPtr_c_unsignedByte;

		// Token: 0x0400146D RID: 5229
		private static readonly IntPtr NativeFieldInfoPtr_c_unsignedInt;

		// Token: 0x0400146E RID: 5230
		private static readonly IntPtr NativeFieldInfoPtr_c_unsignedLong;

		// Token: 0x0400146F RID: 5231
		private static readonly IntPtr NativeFieldInfoPtr_c_unsignedShort;

		// Token: 0x04001470 RID: 5232
		private static readonly IntPtr NativeFieldInfoPtr_c_uuid;

		// Token: 0x04001471 RID: 5233
		private static readonly IntPtr NativeFieldInfoPtr_c_year;

		// Token: 0x04001472 RID: 5234
		private static readonly IntPtr NativeFieldInfoPtr_c_yearMonth;

		// Token: 0x04001473 RID: 5235
		private static readonly IntPtr NativeFieldInfoPtr_c_normalizedStringV1Compat;

		// Token: 0x04001474 RID: 5236
		private static readonly IntPtr NativeFieldInfoPtr_c_tokenV1Compat;

		// Token: 0x04001475 RID: 5237
		private static readonly IntPtr NativeFieldInfoPtr_c_anyAtomicType;

		// Token: 0x04001476 RID: 5238
		private static readonly IntPtr NativeFieldInfoPtr_c_dayTimeDuration;

		// Token: 0x04001477 RID: 5239
		private static readonly IntPtr NativeFieldInfoPtr_c_untypedAtomicType;

		// Token: 0x04001478 RID: 5240
		private static readonly IntPtr NativeFieldInfoPtr_c_yearMonthDuration;

		// Token: 0x04001479 RID: 5241
		private static readonly IntPtr NativeFieldInfoPtr_c_tokenizedTypes;

		// Token: 0x0400147A RID: 5242
		private static readonly IntPtr NativeFieldInfoPtr_c_tokenizedTypesXsd;

		// Token: 0x0400147B RID: 5243
		private static readonly IntPtr NativeFieldInfoPtr_c_XdrTypes;

		// Token: 0x0400147C RID: 5244
		private static readonly IntPtr NativeFieldInfoPtr_c_XsdTypes;

		// Token: 0x0400147D RID: 5245
		private static readonly IntPtr NativeMethodInfoPtr_get_AnySimpleType_Internal_Static_get_XmlSchemaSimpleType_0;

		// Token: 0x0400147E RID: 5246
		private static readonly IntPtr NativeMethodInfoPtr_get_UntypedAtomicType_Internal_Static_get_XmlSchemaSimpleType_0;

		// Token: 0x0400147F RID: 5247
		private static readonly IntPtr NativeMethodInfoPtr_FromXmlTokenizedType_Internal_Static_DatatypeImplementation_XmlTokenizedType_0;

		// Token: 0x04001480 RID: 5248
		private static readonly IntPtr NativeMethodInfoPtr_FromXmlTokenizedTypeXsd_Internal_Static_DatatypeImplementation_XmlTokenizedType_0;

		// Token: 0x04001481 RID: 5249
		private static readonly IntPtr NativeMethodInfoPtr_FromXdrName_Internal_Static_DatatypeImplementation_String_0;

		// Token: 0x04001482 RID: 5250
		private static readonly IntPtr NativeMethodInfoPtr_FromTypeName_Private_Static_DatatypeImplementation_String_0;

		// Token: 0x04001483 RID: 5251
		private static readonly IntPtr NativeMethodInfoPtr_StartBuiltinType_Internal_Static_XmlSchemaSimpleType_XmlQualifiedName_XmlSchemaDatatype_0;

		// Token: 0x04001484 RID: 5252
		private static readonly IntPtr NativeMethodInfoPtr_FinishBuiltinType_Internal_Static_Void_XmlSchemaSimpleType_XmlSchemaSimpleType_0;

		// Token: 0x04001485 RID: 5253
		private static readonly IntPtr NativeMethodInfoPtr_CreateBuiltinTypes_Internal_Static_Void_0;

		// Token: 0x04001486 RID: 5254
		private static readonly IntPtr NativeMethodInfoPtr_GetSimpleTypeFromTypeCode_Internal_Static_XmlSchemaSimpleType_XmlTypeCode_0;

		// Token: 0x04001487 RID: 5255
		private static readonly IntPtr NativeMethodInfoPtr_GetSimpleTypeFromXsdType_Internal_Static_XmlSchemaSimpleType_XmlQualifiedName_0;

		// Token: 0x04001488 RID: 5256
		private static readonly IntPtr NativeMethodInfoPtr_GetNormalizedStringTypeV1Compat_Internal_Static_XmlSchemaSimpleType_0;

		// Token: 0x04001489 RID: 5257
		private static readonly IntPtr NativeMethodInfoPtr_GetTokenTypeV1Compat_Internal_Static_XmlSchemaSimpleType_0;

		// Token: 0x0400148A RID: 5258
		private static readonly IntPtr NativeMethodInfoPtr_GetBuiltInTypes_Internal_Static_Il2CppReferenceArray_1_XmlSchemaSimpleType_0;

		// Token: 0x0400148B RID: 5259
		private static readonly IntPtr NativeMethodInfoPtr_GetPrimitiveTypeCode_Internal_Static_XmlTypeCode_XmlTypeCode_0;

		// Token: 0x0400148C RID: 5260
		private static readonly IntPtr NativeMethodInfoPtr_DeriveByRestriction_Internal_Virtual_XmlSchemaDatatype_XmlSchemaObjectCollection_XmlNameTable_XmlSchemaType_0;

		// Token: 0x0400148D RID: 5261
		private static readonly IntPtr NativeMethodInfoPtr_DeriveByList_Internal_Virtual_XmlSchemaDatatype_XmlSchemaType_0;

		// Token: 0x0400148E RID: 5262
		private static readonly IntPtr NativeMethodInfoPtr_DeriveByList_Internal_XmlSchemaDatatype_Int32_XmlSchemaType_0;

		// Token: 0x0400148F RID: 5263
		private static readonly IntPtr NativeMethodInfoPtr_DeriveByUnion_Internal_Static_DatatypeImplementation_Il2CppReferenceArray_1_XmlSchemaSimpleType_XmlSchemaType_0;

		// Token: 0x04001490 RID: 5264
		private static readonly IntPtr NativeMethodInfoPtr_VerifySchemaValid_Internal_Virtual_Void_XmlSchemaObjectTable_XmlSchemaObject_0;

		// Token: 0x04001491 RID: 5265
		private static readonly IntPtr NativeMethodInfoPtr_IsDerivedFrom_Public_Virtual_Boolean_XmlSchemaDatatype_0;

		// Token: 0x04001492 RID: 5266
		private static readonly IntPtr NativeMethodInfoPtr_IsEqual_Internal_Virtual_Boolean_Object_Object_0;

		// Token: 0x04001493 RID: 5267
		private static readonly IntPtr NativeMethodInfoPtr_IsComparable_Internal_Virtual_Boolean_XmlSchemaDatatype_0;

		// Token: 0x04001494 RID: 5268
		private static readonly IntPtr NativeMethodInfoPtr_CreateValueConverter_Internal_Virtual_New_XmlValueConverter_XmlSchemaType_0;

		// Token: 0x04001495 RID: 5269
		private static readonly IntPtr NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0;

		// Token: 0x04001496 RID: 5270
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueConverter_Internal_Virtual_get_XmlValueConverter_0;

		// Token: 0x04001497 RID: 5271
		private static readonly IntPtr NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0;

		// Token: 0x04001498 RID: 5272
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0;

		// Token: 0x04001499 RID: 5273
		private static readonly IntPtr NativeMethodInfoPtr_get_Variety_Public_Virtual_get_XmlSchemaDatatypeVariety_0;

		// Token: 0x0400149A RID: 5274
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x0400149B RID: 5275
		private static readonly IntPtr NativeMethodInfoPtr_get_Restriction_Internal_Virtual_get_RestrictionFacets_0;

		// Token: 0x0400149C RID: 5276
		private static readonly IntPtr NativeMethodInfoPtr_get_HasLexicalFacets_Internal_Virtual_get_Boolean_0;

		// Token: 0x0400149D RID: 5277
		private static readonly IntPtr NativeMethodInfoPtr_get_HasValueFacets_Internal_Virtual_get_Boolean_0;

		// Token: 0x0400149E RID: 5278
		private static readonly IntPtr NativeMethodInfoPtr_get_Base_Protected_get_DatatypeImplementation_0;

		// Token: 0x0400149F RID: 5279
		private static readonly IntPtr NativeMethodInfoPtr_get_ListValueType_Internal_Abstract_Virtual_New_get_Type_0;

		// Token: 0x040014A0 RID: 5280
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidRestrictionFlags_Internal_Abstract_Virtual_New_get_RestrictionFlags_0;

		// Token: 0x040014A1 RID: 5281
		private static readonly IntPtr NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Virtual_get_XmlSchemaWhiteSpace_0;

		// Token: 0x040014A2 RID: 5282
		private static readonly IntPtr NativeMethodInfoPtr_ParseValue_Public_Virtual_Object_String_XmlNameTable_IXmlNamespaceResolver_0;

		// Token: 0x040014A3 RID: 5283
		private static readonly IntPtr NativeMethodInfoPtr_ParseValue_Internal_Virtual_Object_String_XmlNameTable_IXmlNamespaceResolver_Boolean_0;

		// Token: 0x040014A4 RID: 5284
		private static readonly IntPtr NativeMethodInfoPtr_TryParseValue_Internal_Virtual_Exception_Object_XmlNameTable_IXmlNamespaceResolver_byref_Object_0;

		// Token: 0x040014A5 RID: 5285
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeName_Internal_String_0;

		// Token: 0x040014A6 RID: 5286
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Protected_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040014A7 RID: 5287
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000257 RID: 599
		public class SchemaDatatypeMap : Object
		{
			// Token: 0x0600315E RID: 12638 RVA: 0x000DCCDC File Offset: 0x000DAEDC
			// Note: this type is marked as 'beforefieldinit'.
			static SchemaDatatypeMap()
			{
				Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "SchemaDatatypeMap");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr);
				DatatypeImplementation.SchemaDatatypeMap.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr, "name");
				DatatypeImplementation.SchemaDatatypeMap.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr, "type");
				DatatypeImplementation.SchemaDatatypeMap.NativeFieldInfoPtr_parentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr, "parentIndex");
				DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr__ctor_Internal_Void_String_DatatypeImplementation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr, 100667293);
				DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr__ctor_Internal_Void_String_DatatypeImplementation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr, 100667294);
				DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr_op_Explicit_Public_Static_DatatypeImplementation_SchemaDatatypeMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr, 100667295);
				DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr, 100667296);
				DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr_get_ParentIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr, 100667297);
				DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr, 100667298);
			}

			// Token: 0x0600315F RID: 12639 RVA: 0x000DCDBC File Offset: 0x000DAFBC
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SchemaDatatypeMap(string name, DatatypeImplementation type)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr__ctor_Internal_Void_String_DatatypeImplementation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003160 RID: 12640 RVA: 0x000DCE1C File Offset: 0x000DB01C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393219, XrefRangeEnd = 393222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SchemaDatatypeMap(string name, DatatypeImplementation type, int parentIndex)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parentIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr__ctor_Internal_Void_String_DatatypeImplementation_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003161 RID: 12641 RVA: 0x000DCE88 File Offset: 0x000DB088
			[CallerCount(51)]
			[CachedScanResults(RefRangeStart = 393222, RefRangeEnd = 393273, XrefRangeStart = 393222, XrefRangeEnd = 393222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static explicit operator DatatypeImplementation(DatatypeImplementation.SchemaDatatypeMap sdm)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sdm);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr_op_Explicit_Public_Static_DatatypeImplementation_SchemaDatatypeMap_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr3) : null;
				}
			}

			// Token: 0x170010A4 RID: 4260
			// (get) Token: 0x06003162 RID: 12642 RVA: 0x000DCECC File Offset: 0x000DB0CC
			public unsafe string Name
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170010A5 RID: 4261
			// (get) Token: 0x06003163 RID: 12643 RVA: 0x000DCF04 File Offset: 0x000DB104
			public unsafe int ParentIndex
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr_get_ParentIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003164 RID: 12644 RVA: 0x000DCF40 File Offset: 0x000DB140
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393273, XrefRangeEnd = 393277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int CompareTo(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003165 RID: 12645 RVA: 0x00014E7A File Offset: 0x0001307A
			public SchemaDatatypeMap(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010A1 RID: 4257
			// (get) Token: 0x06003166 RID: 12646 RVA: 0x000DCF90 File Offset: 0x000DB190
			// (set) Token: 0x06003167 RID: 12647 RVA: 0x00014E83 File Offset: 0x00013083
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.SchemaDatatypeMap.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.SchemaDatatypeMap.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170010A2 RID: 4258
			// (get) Token: 0x06003168 RID: 12648 RVA: 0x000DCFB8 File Offset: 0x000DB1B8
			// (set) Token: 0x06003169 RID: 12649 RVA: 0x00014EA2 File Offset: 0x000130A2
			public unsafe DatatypeImplementation type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.SchemaDatatypeMap.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.SchemaDatatypeMap.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010A3 RID: 4259
			// (get) Token: 0x0600316A RID: 12650 RVA: 0x000DCFE8 File Offset: 0x000DB1E8
			// (set) Token: 0x0600316B RID: 12651 RVA: 0x00014EC1 File Offset: 0x000130C1
			public unsafe int parentIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.SchemaDatatypeMap.NativeFieldInfoPtr_parentIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.SchemaDatatypeMap.NativeFieldInfoPtr_parentIndex)) = value;
				}
			}

			// Token: 0x04002631 RID: 9777
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04002632 RID: 9778
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04002633 RID: 9779
			private static readonly IntPtr NativeFieldInfoPtr_parentIndex;

			// Token: 0x04002634 RID: 9780
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_DatatypeImplementation_0;

			// Token: 0x04002635 RID: 9781
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_DatatypeImplementation_Int32_0;

			// Token: 0x04002636 RID: 9782
			private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_DatatypeImplementation_SchemaDatatypeMap_0;

			// Token: 0x04002637 RID: 9783
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

			// Token: 0x04002638 RID: 9784
			private static readonly IntPtr NativeMethodInfoPtr_get_ParentIndex_Public_get_Int32_0;

			// Token: 0x04002639 RID: 9785
			private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;
		}
	}
}

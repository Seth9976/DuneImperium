using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001ED RID: 493
	public class XmlBaseConverter : XmlValueConverter
	{
		// Token: 0x0600296C RID: 10604 RVA: 0x000C075C File Offset: 0x000BE95C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlBaseConverter()
		{
			Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlBaseConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr);
			XmlBaseConverter.NativeFieldInfoPtr_schemaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "schemaType");
			XmlBaseConverter.NativeFieldInfoPtr_typeCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "typeCode");
			XmlBaseConverter.NativeFieldInfoPtr_clrTypeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "clrTypeDefault");
			XmlBaseConverter.NativeFieldInfoPtr_ICollectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "ICollectionType");
			XmlBaseConverter.NativeFieldInfoPtr_IEnumerableType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "IEnumerableType");
			XmlBaseConverter.NativeFieldInfoPtr_IListType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "IListType");
			XmlBaseConverter.NativeFieldInfoPtr_ObjectArrayType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "ObjectArrayType");
			XmlBaseConverter.NativeFieldInfoPtr_StringArrayType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "StringArrayType");
			XmlBaseConverter.NativeFieldInfoPtr_XmlAtomicValueArrayType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "XmlAtomicValueArrayType");
			XmlBaseConverter.NativeFieldInfoPtr_DecimalType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "DecimalType");
			XmlBaseConverter.NativeFieldInfoPtr_Int32Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "Int32Type");
			XmlBaseConverter.NativeFieldInfoPtr_Int64Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "Int64Type");
			XmlBaseConverter.NativeFieldInfoPtr_StringType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "StringType");
			XmlBaseConverter.NativeFieldInfoPtr_XmlAtomicValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "XmlAtomicValueType");
			XmlBaseConverter.NativeFieldInfoPtr_ObjectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "ObjectType");
			XmlBaseConverter.NativeFieldInfoPtr_ByteType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "ByteType");
			XmlBaseConverter.NativeFieldInfoPtr_Int16Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "Int16Type");
			XmlBaseConverter.NativeFieldInfoPtr_SByteType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "SByteType");
			XmlBaseConverter.NativeFieldInfoPtr_UInt16Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "UInt16Type");
			XmlBaseConverter.NativeFieldInfoPtr_UInt32Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "UInt32Type");
			XmlBaseConverter.NativeFieldInfoPtr_UInt64Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "UInt64Type");
			XmlBaseConverter.NativeFieldInfoPtr_XPathItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "XPathItemType");
			XmlBaseConverter.NativeFieldInfoPtr_DoubleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "DoubleType");
			XmlBaseConverter.NativeFieldInfoPtr_SingleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "SingleType");
			XmlBaseConverter.NativeFieldInfoPtr_DateTimeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "DateTimeType");
			XmlBaseConverter.NativeFieldInfoPtr_DateTimeOffsetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "DateTimeOffsetType");
			XmlBaseConverter.NativeFieldInfoPtr_BooleanType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "BooleanType");
			XmlBaseConverter.NativeFieldInfoPtr_ByteArrayType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "ByteArrayType");
			XmlBaseConverter.NativeFieldInfoPtr_XmlQualifiedNameType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "XmlQualifiedNameType");
			XmlBaseConverter.NativeFieldInfoPtr_UriType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "UriType");
			XmlBaseConverter.NativeFieldInfoPtr_TimeSpanType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "TimeSpanType");
			XmlBaseConverter.NativeFieldInfoPtr_XPathNavigatorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "XPathNavigatorType");
			XmlBaseConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669290);
			XmlBaseConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669291);
			XmlBaseConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669292);
			XmlBaseConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669293);
			XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669294);
			XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669295);
			XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669296);
			XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669297);
			XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669298);
			XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669299);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669300);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669301);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669302);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669303);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669304);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669305);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669306);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669307);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669308);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669309);
			XmlBaseConverter.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669310);
			XmlBaseConverter.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669311);
			XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669312);
			XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669313);
			XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669314);
			XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669315);
			XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669316);
			XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669317);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669318);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669319);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669320);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669321);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669322);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669323);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669324);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669325);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669326);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669327);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669328);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669329);
			XmlBaseConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669330);
			XmlBaseConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669331);
			XmlBaseConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669332);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669333);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669334);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669335);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669336);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669337);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669338);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669339);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669340);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669341);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669342);
			XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669343);
			XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_DateTime_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669344);
			XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Decimal_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669345);
			XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Double_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669346);
			XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669347);
			XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int64_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669348);
			XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_String_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669349);
			XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669350);
			XmlBaseConverter.NativeMethodInfoPtr_get_SchemaType_Protected_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669351);
			XmlBaseConverter.NativeMethodInfoPtr_get_TypeCode_Protected_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669352);
			XmlBaseConverter.NativeMethodInfoPtr_get_XmlTypeName_Protected_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669353);
			XmlBaseConverter.NativeMethodInfoPtr_get_DefaultClrType_Protected_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669354);
			XmlBaseConverter.NativeMethodInfoPtr_IsDerivedFrom_Protected_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669355);
			XmlBaseConverter.NativeMethodInfoPtr_CreateInvalidClrMappingException_Protected_Exception_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669356);
			XmlBaseConverter.NativeMethodInfoPtr_QNameToString_Protected_Static_String_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669357);
			XmlBaseConverter.NativeMethodInfoPtr_ChangeListType_Protected_Virtual_New_Object_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669358);
			XmlBaseConverter.NativeMethodInfoPtr_StringToBase64Binary_Protected_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669359);
			XmlBaseConverter.NativeMethodInfoPtr_StringToDate_Protected_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669360);
			XmlBaseConverter.NativeMethodInfoPtr_StringToDateTime_Protected_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669361);
			XmlBaseConverter.NativeMethodInfoPtr_StringToDayTimeDuration_Protected_Static_TimeSpan_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669362);
			XmlBaseConverter.NativeMethodInfoPtr_StringToDuration_Protected_Static_TimeSpan_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669363);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGDay_Protected_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669364);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGMonth_Protected_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669365);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGMonthDay_Protected_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669366);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGYear_Protected_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669367);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGYearMonth_Protected_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669368);
			XmlBaseConverter.NativeMethodInfoPtr_StringToDateOffset_Protected_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669369);
			XmlBaseConverter.NativeMethodInfoPtr_StringToDateTimeOffset_Protected_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669370);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGDayOffset_Protected_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669371);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGMonthOffset_Protected_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669372);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGMonthDayOffset_Protected_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669373);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGYearOffset_Protected_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669374);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGYearMonthOffset_Protected_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669375);
			XmlBaseConverter.NativeMethodInfoPtr_StringToHexBinary_Protected_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669376);
			XmlBaseConverter.NativeMethodInfoPtr_StringToQName_Protected_Static_XmlQualifiedName_String_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669377);
			XmlBaseConverter.NativeMethodInfoPtr_StringToTime_Protected_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669378);
			XmlBaseConverter.NativeMethodInfoPtr_StringToTimeOffset_Protected_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669379);
			XmlBaseConverter.NativeMethodInfoPtr_StringToYearMonthDuration_Protected_Static_TimeSpan_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669380);
			XmlBaseConverter.NativeMethodInfoPtr_AnyUriToString_Protected_Static_String_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669381);
			XmlBaseConverter.NativeMethodInfoPtr_Base64BinaryToString_Protected_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669382);
			XmlBaseConverter.NativeMethodInfoPtr_DateToString_Protected_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669383);
			XmlBaseConverter.NativeMethodInfoPtr_DateTimeToString_Protected_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669384);
			XmlBaseConverter.NativeMethodInfoPtr_DayTimeDurationToString_Protected_Static_String_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669385);
			XmlBaseConverter.NativeMethodInfoPtr_DurationToString_Protected_Static_String_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669386);
			XmlBaseConverter.NativeMethodInfoPtr_GDayToString_Protected_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669387);
			XmlBaseConverter.NativeMethodInfoPtr_GMonthToString_Protected_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669388);
			XmlBaseConverter.NativeMethodInfoPtr_GMonthDayToString_Protected_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669389);
			XmlBaseConverter.NativeMethodInfoPtr_GYearToString_Protected_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669390);
			XmlBaseConverter.NativeMethodInfoPtr_GYearMonthToString_Protected_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669391);
			XmlBaseConverter.NativeMethodInfoPtr_DateOffsetToString_Protected_Static_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669392);
			XmlBaseConverter.NativeMethodInfoPtr_DateTimeOffsetToString_Protected_Static_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669393);
			XmlBaseConverter.NativeMethodInfoPtr_GDayOffsetToString_Protected_Static_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669394);
			XmlBaseConverter.NativeMethodInfoPtr_GMonthOffsetToString_Protected_Static_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669395);
			XmlBaseConverter.NativeMethodInfoPtr_GMonthDayOffsetToString_Protected_Static_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669396);
			XmlBaseConverter.NativeMethodInfoPtr_GYearOffsetToString_Protected_Static_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669397);
			XmlBaseConverter.NativeMethodInfoPtr_GYearMonthOffsetToString_Protected_Static_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669398);
			XmlBaseConverter.NativeMethodInfoPtr_QNameToString_Protected_Static_String_XmlQualifiedName_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669399);
			XmlBaseConverter.NativeMethodInfoPtr_TimeToString_Protected_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669400);
			XmlBaseConverter.NativeMethodInfoPtr_TimeOffsetToString_Protected_Static_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669401);
			XmlBaseConverter.NativeMethodInfoPtr_YearMonthDurationToString_Protected_Static_String_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669402);
			XmlBaseConverter.NativeMethodInfoPtr_DateTimeOffsetToDateTime_Internal_Static_DateTime_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669403);
			XmlBaseConverter.NativeMethodInfoPtr_DecimalToInt32_Internal_Static_Int32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669404);
			XmlBaseConverter.NativeMethodInfoPtr_DecimalToInt64_Protected_Static_Int64_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669405);
			XmlBaseConverter.NativeMethodInfoPtr_DecimalToUInt64_Protected_Static_UInt64_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669406);
			XmlBaseConverter.NativeMethodInfoPtr_Int32ToByte_Protected_Static_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669407);
			XmlBaseConverter.NativeMethodInfoPtr_Int32ToInt16_Protected_Static_Int16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669408);
			XmlBaseConverter.NativeMethodInfoPtr_Int32ToSByte_Protected_Static_SByte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669409);
			XmlBaseConverter.NativeMethodInfoPtr_Int32ToUInt16_Protected_Static_UInt16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669410);
			XmlBaseConverter.NativeMethodInfoPtr_Int64ToInt32_Protected_Static_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669411);
			XmlBaseConverter.NativeMethodInfoPtr_Int64ToUInt32_Protected_Static_UInt32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669412);
			XmlBaseConverter.NativeMethodInfoPtr_UntypedAtomicToDateTime_Protected_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669413);
			XmlBaseConverter.NativeMethodInfoPtr_UntypedAtomicToDateTimeOffset_Protected_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100669414);
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x000C13D0 File Offset: 0x000BF5D0
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 416777, RefRangeEnd = 416792, XrefRangeStart = 416756, XrefRangeEnd = 416777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlBaseConverter(XmlSchemaType schemaType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x000C141C File Offset: 0x000BF61C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 416806, RefRangeEnd = 416807, XrefRangeStart = 416792, XrefRangeEnd = 416806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlBaseConverter(XmlTypeCode typeCode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlTypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x000C1464 File Offset: 0x000BF664
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 416813, RefRangeEnd = 416817, XrefRangeStart = 416807, XrefRangeEnd = 416813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlBaseConverter(XmlBaseConverter converterAtomic)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(converterAtomic);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x000C14B0 File Offset: 0x000BF6B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 416821, RefRangeEnd = 416823, XrefRangeStart = 416817, XrefRangeEnd = 416821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlBaseConverter(XmlBaseConverter converterAtomic, Type clrTypeDefault)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(converterAtomic);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clrTypeDefault);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x000C1510 File Offset: 0x000BF710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416823, XrefRangeEnd = 416833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ToBoolean(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002972 RID: 10610 RVA: 0x000C1564 File Offset: 0x000BF764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416833, XrefRangeEnd = 416843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ToBoolean(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x000C15B8 File Offset: 0x000BF7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416843, XrefRangeEnd = 416853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ToBoolean(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x000C160C File Offset: 0x000BF80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416853, XrefRangeEnd = 416863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ToBoolean(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x000C1660 File Offset: 0x000BF860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416863, XrefRangeEnd = 416870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ToBoolean(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x000C16B8 File Offset: 0x000BF8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416870, XrefRangeEnd = 416877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ToBoolean(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x000C1710 File Offset: 0x000BF910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416877, XrefRangeEnd = 416887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x000C1764 File Offset: 0x000BF964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416887, XrefRangeEnd = 416897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(DateTimeOffset value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_DateTimeOffset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x000C17B8 File Offset: 0x000BF9B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416897, XrefRangeEnd = 416907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x000C180C File Offset: 0x000BFA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416907, XrefRangeEnd = 416917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x000C1860 File Offset: 0x000BFA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416917, XrefRangeEnd = 416927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x000C18B4 File Offset: 0x000BFAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416927, XrefRangeEnd = 416934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x000C190C File Offset: 0x000BFB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416934, XrefRangeEnd = 416941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x000C1964 File Offset: 0x000BFB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416941, XrefRangeEnd = 416951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTimeOffset ToDateTimeOffset(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x000C19B8 File Offset: 0x000BFBB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416951, XrefRangeEnd = 416958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTimeOffset ToDateTimeOffset(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x000C1A10 File Offset: 0x000BFC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416958, XrefRangeEnd = 416965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTimeOffset ToDateTimeOffset(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x000C1A68 File Offset: 0x000BFC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416965, XrefRangeEnd = 416972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Decimal ToDecimal(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x000C1AC0 File Offset: 0x000BFCC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416972, XrefRangeEnd = 416979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Decimal ToDecimal(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x000C1B18 File Offset: 0x000BFD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416979, XrefRangeEnd = 416989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override double ToDouble(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x000C1B6C File Offset: 0x000BFD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416989, XrefRangeEnd = 416999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override double ToDouble(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x000C1BC0 File Offset: 0x000BFDC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 416999, XrefRangeEnd = 417009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override double ToDouble(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x000C1C14 File Offset: 0x000BFE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417009, XrefRangeEnd = 417019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override double ToDouble(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x000C1C68 File Offset: 0x000BFE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417019, XrefRangeEnd = 417026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override double ToDouble(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x000C1CC0 File Offset: 0x000BFEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417026, XrefRangeEnd = 417033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override double ToDouble(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002989 RID: 10633 RVA: 0x000C1D18 File Offset: 0x000BFF18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417033, XrefRangeEnd = 417043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ToInt32(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x000C1D6C File Offset: 0x000BFF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417043, XrefRangeEnd = 417053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ToInt32(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600298B RID: 10635 RVA: 0x000C1DC0 File Offset: 0x000BFFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417053, XrefRangeEnd = 417063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ToInt32(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x000C1E14 File Offset: 0x000C0014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417063, XrefRangeEnd = 417073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ToInt32(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x000C1E68 File Offset: 0x000C0068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417073, XrefRangeEnd = 417080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ToInt32(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x000C1EC0 File Offset: 0x000C00C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417080, XrefRangeEnd = 417087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ToInt32(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x000C1F18 File Offset: 0x000C0118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417087, XrefRangeEnd = 417097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long ToInt64(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x000C1F6C File Offset: 0x000C016C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417097, XrefRangeEnd = 417107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long ToInt64(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x000C1FC0 File Offset: 0x000C01C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417107, XrefRangeEnd = 417117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long ToInt64(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x000C2014 File Offset: 0x000C0214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417117, XrefRangeEnd = 417127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long ToInt64(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x000C2068 File Offset: 0x000C0268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417127, XrefRangeEnd = 417134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long ToInt64(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x000C20C0 File Offset: 0x000C02C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417134, XrefRangeEnd = 417141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long ToInt64(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x000C2118 File Offset: 0x000C0318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417141, XrefRangeEnd = 417151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float ToSingle(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x000C216C File Offset: 0x000C036C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417151, XrefRangeEnd = 417158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float ToSingle(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x000C21C4 File Offset: 0x000C03C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417158, XrefRangeEnd = 417165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float ToSingle(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x000C221C File Offset: 0x000C041C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417165, XrefRangeEnd = 417174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x000C226C File Offset: 0x000C046C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417174, XrefRangeEnd = 417183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x000C22BC File Offset: 0x000C04BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417183, XrefRangeEnd = 417192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(DateTimeOffset value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTimeOffset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x000C230C File Offset: 0x000C050C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417192, XrefRangeEnd = 417201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(Decimal value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Decimal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x000C235C File Offset: 0x000C055C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417201, XrefRangeEnd = 417210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600299D RID: 10653 RVA: 0x000C23AC File Offset: 0x000C05AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417210, XrefRangeEnd = 417219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x000C23FC File Offset: 0x000C05FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417219, XrefRangeEnd = 417228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x000C244C File Offset: 0x000C064C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417228, XrefRangeEnd = 417237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x000C249C File Offset: 0x000C069C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417237, XrefRangeEnd = 417243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(Object value, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x000C2504 File Offset: 0x000C0704
		[CallerCount(0)]
		public unsafe override string ToString(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x000C2558 File Offset: 0x000C0758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417243, XrefRangeEnd = 417246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(bool value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x000C25C4 File Offset: 0x000C07C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417246, XrefRangeEnd = 417249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(DateTime value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_DateTime_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x000C2630 File Offset: 0x000C0830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417249, XrefRangeEnd = 417252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(Decimal value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Decimal_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x000C269C File Offset: 0x000C089C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417252, XrefRangeEnd = 417255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(double value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Double_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x000C2708 File Offset: 0x000C0908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417255, XrefRangeEnd = 417258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(int value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int32_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x000C2774 File Offset: 0x000C0974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417258, XrefRangeEnd = 417261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(long value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int64_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x000C27E0 File Offset: 0x000C09E0
		[CallerCount(0)]
		public unsafe override Object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_String_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x000C2860 File Offset: 0x000C0A60
		[CallerCount(0)]
		public unsafe override Object ChangeType(Object value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x060029AA RID: 10666 RVA: 0x000C28D0 File Offset: 0x000C0AD0
		public unsafe XmlSchemaType SchemaType
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_get_SchemaType_Protected_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x060029AB RID: 10667 RVA: 0x000C2910 File Offset: 0x000C0B10
		public unsafe XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_get_TypeCode_Protected_get_XmlTypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x060029AC RID: 10668 RVA: 0x000C294C File Offset: 0x000C0B4C
		public unsafe string XmlTypeName
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 417267, RefRangeEnd = 417271, XrefRangeStart = 417261, XrefRangeEnd = 417267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_get_XmlTypeName_Protected_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x060029AD RID: 10669 RVA: 0x000C2984 File Offset: 0x000C0B84
		public unsafe Type DefaultClrType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_get_DefaultClrType_Protected_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x000C29C4 File Offset: 0x000C0BC4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 417279, RefRangeEnd = 417289, XrefRangeStart = 417271, XrefRangeEnd = 417279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDerivedFrom(Type derivedType, Type baseType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_IsDerivedFrom_Protected_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x000C2A18 File Offset: 0x000C0C18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 417311, RefRangeEnd = 417313, XrefRangeStart = 417289, XrefRangeEnd = 417311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_CreateInvalidClrMappingException_Protected_Exception_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x000C2A7C File Offset: 0x000C0C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417313, XrefRangeEnd = 417326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string QNameToString(XmlQualifiedName name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_QNameToString_Protected_Static_String_XmlQualifiedName_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x000C2AB8 File Offset: 0x000C0CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417326, XrefRangeEnd = 417331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object ChangeListType(Object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ChangeListType_Protected_Virtual_New_Object_Object_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x000C2B38 File Offset: 0x000C0D38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 417339, RefRangeEnd = 417342, XrefRangeStart = 417331, XrefRangeEnd = 417339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> StringToBase64Binary(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToBase64Binary_Protected_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x000C2B7C File Offset: 0x000C0D7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 417347, RefRangeEnd = 417348, XrefRangeStart = 417342, XrefRangeEnd = 417347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime StringToDate(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToDate_Protected_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x000C2BC0 File Offset: 0x000C0DC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 417353, RefRangeEnd = 417354, XrefRangeStart = 417348, XrefRangeEnd = 417353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime StringToDateTime(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToDateTime_Protected_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x000C2C04 File Offset: 0x000C0E04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 417356, RefRangeEnd = 417357, XrefRangeStart = 417354, XrefRangeEnd = 417356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan StringToDayTimeDuration(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToDayTimeDuration_Protected_Static_TimeSpan_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x000C2C48 File Offset: 0x000C0E48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 417359, RefRangeEnd = 417362, XrefRangeStart = 417357, XrefRangeEnd = 417359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan StringToDuration(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToDuration_Protected_Static_TimeSpan_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x000C2C8C File Offset: 0x000C0E8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 417367, RefRangeEnd = 417368, XrefRangeStart = 417362, XrefRangeEnd = 417367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime StringToGDay(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGDay_Protected_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x000C2CD0 File Offset: 0x000C0ED0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 417373, RefRangeEnd = 417374, XrefRangeStart = 417368, XrefRangeEnd = 417373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime StringToGMonth(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGMonth_Protected_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x000C2D14 File Offset: 0x000C0F14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 417379, RefRangeEnd = 417380, XrefRangeStart = 417374, XrefRangeEnd = 417379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime StringToGMonthDay(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGMonthDay_Protected_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x000C2D58 File Offset: 0x000C0F58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 417385, RefRangeEnd = 417386, XrefRangeStart = 417380, XrefRangeEnd = 417385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime StringToGYear(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGYear_Protected_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029BB RID: 10683 RVA: 0x000C2D9C File Offset: 0x000C0F9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 417391, RefRangeEnd = 417392, XrefRangeStart = 417386, XrefRangeEnd = 417391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime StringToGYearMonth(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGYearMonth_Protected_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x000C2DE0 File Offset: 0x000C0FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417392, XrefRangeEnd = 417397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset StringToDateOffset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToDateOffset_Protected_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x000C2E24 File Offset: 0x000C1024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417397, XrefRangeEnd = 417402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset StringToDateTimeOffset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToDateTimeOffset_Protected_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x000C2E68 File Offset: 0x000C1068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417402, XrefRangeEnd = 417407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset StringToGDayOffset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGDayOffset_Protected_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x000C2EAC File Offset: 0x000C10AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417407, XrefRangeEnd = 417412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset StringToGMonthOffset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGMonthOffset_Protected_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x000C2EF0 File Offset: 0x000C10F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417412, XrefRangeEnd = 417417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset StringToGMonthDayOffset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGMonthDayOffset_Protected_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x000C2F34 File Offset: 0x000C1134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417417, XrefRangeEnd = 417422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset StringToGYearOffset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGYearOffset_Protected_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x000C2F78 File Offset: 0x000C1178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417422, XrefRangeEnd = 417427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset StringToGYearMonthOffset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGYearMonthOffset_Protected_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x000C2FBC File Offset: 0x000C11BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 417432, RefRangeEnd = 417434, XrefRangeStart = 417427, XrefRangeEnd = 417432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> StringToHexBinary(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToHexBinary_Protected_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060029C4 RID: 10692 RVA: 0x000C3000 File Offset: 0x000C1200
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 417446, RefRangeEnd = 417450, XrefRangeStart = 417434, XrefRangeEnd = 417446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlQualifiedName StringToQName(string value, IXmlNamespaceResolver nsResolver)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToQName_Protected_Static_XmlQualifiedName_String_IXmlNamespaceResolver_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x000C3058 File Offset: 0x000C1258
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 417455, RefRangeEnd = 417456, XrefRangeStart = 417450, XrefRangeEnd = 417455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime StringToTime(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToTime_Protected_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x000C309C File Offset: 0x000C129C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 417461, RefRangeEnd = 417462, XrefRangeStart = 417456, XrefRangeEnd = 417461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset StringToTimeOffset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToTimeOffset_Protected_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029C7 RID: 10695 RVA: 0x000C30E0 File Offset: 0x000C12E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 417464, RefRangeEnd = 417465, XrefRangeStart = 417462, XrefRangeEnd = 417464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan StringToYearMonthDuration(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToYearMonthDuration_Protected_Static_TimeSpan_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x000C3124 File Offset: 0x000C1324
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 417467, RefRangeEnd = 417468, XrefRangeStart = 417465, XrefRangeEnd = 417467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string AnyUriToString(Uri value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_AnyUriToString_Protected_Static_String_Uri_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x000C3160 File Offset: 0x000C1360
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 417472, RefRangeEnd = 417473, XrefRangeStart = 417468, XrefRangeEnd = 417472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Base64BinaryToString(Il2CppStructArray<byte> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_Base64BinaryToString_Protected_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x000C319C File Offset: 0x000C139C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 417478, RefRangeEnd = 417479, XrefRangeStart = 417473, XrefRangeEnd = 417478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DateToString(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DateToString_Protected_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x000C31D4 File Offset: 0x000C13D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 417484, RefRangeEnd = 417486, XrefRangeStart = 417479, XrefRangeEnd = 417484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DateTimeToString(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DateTimeToString_Protected_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x000C320C File Offset: 0x000C140C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 417488, RefRangeEnd = 417489, XrefRangeStart = 417486, XrefRangeEnd = 417488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DayTimeDurationToString(TimeSpan value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DayTimeDurationToString_Protected_Static_String_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x000C3244 File Offset: 0x000C1444
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 417491, RefRangeEnd = 417492, XrefRangeStart = 417489, XrefRangeEnd = 417491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DurationToString(TimeSpan value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DurationToString_Protected_Static_String_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x000C327C File Offset: 0x000C147C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 417497, RefRangeEnd = 417498, XrefRangeStart = 417492, XrefRangeEnd = 417497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GDayToString(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GDayToString_Protected_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x000C32B4 File Offset: 0x000C14B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 417503, RefRangeEnd = 417504, XrefRangeStart = 417498, XrefRangeEnd = 417503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GMonthToString(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GMonthToString_Protected_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x000C32EC File Offset: 0x000C14EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 417509, RefRangeEnd = 417510, XrefRangeStart = 417504, XrefRangeEnd = 417509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GMonthDayToString(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GMonthDayToString_Protected_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x000C3324 File Offset: 0x000C1524
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 417515, RefRangeEnd = 417516, XrefRangeStart = 417510, XrefRangeEnd = 417515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GYearToString(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GYearToString_Protected_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x000C335C File Offset: 0x000C155C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 417521, RefRangeEnd = 417522, XrefRangeStart = 417516, XrefRangeEnd = 417521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GYearMonthToString(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GYearMonthToString_Protected_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x000C3394 File Offset: 0x000C1594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417522, XrefRangeEnd = 417527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DateOffsetToString(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DateOffsetToString_Protected_Static_String_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x000C33CC File Offset: 0x000C15CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 417532, RefRangeEnd = 417533, XrefRangeStart = 417527, XrefRangeEnd = 417532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DateTimeOffsetToString(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DateTimeOffsetToString_Protected_Static_String_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x000C3404 File Offset: 0x000C1604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417533, XrefRangeEnd = 417538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GDayOffsetToString(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GDayOffsetToString_Protected_Static_String_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x000C343C File Offset: 0x000C163C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417538, XrefRangeEnd = 417543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GMonthOffsetToString(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GMonthOffsetToString_Protected_Static_String_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029D7 RID: 10711 RVA: 0x000C3474 File Offset: 0x000C1674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417543, XrefRangeEnd = 417548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GMonthDayOffsetToString(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GMonthDayOffsetToString_Protected_Static_String_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x000C34AC File Offset: 0x000C16AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417548, XrefRangeEnd = 417553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GYearOffsetToString(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GYearOffsetToString_Protected_Static_String_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029D9 RID: 10713 RVA: 0x000C34E4 File Offset: 0x000C16E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417553, XrefRangeEnd = 417558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GYearMonthOffsetToString(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GYearMonthOffsetToString_Protected_Static_String_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029DA RID: 10714 RVA: 0x000C351C File Offset: 0x000C171C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 417566, RefRangeEnd = 417568, XrefRangeStart = 417558, XrefRangeEnd = 417566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_QNameToString_Protected_Static_String_XmlQualifiedName_IXmlNamespaceResolver_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x000C356C File Offset: 0x000C176C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 417573, RefRangeEnd = 417574, XrefRangeStart = 417568, XrefRangeEnd = 417573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TimeToString(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_TimeToString_Protected_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x000C35A4 File Offset: 0x000C17A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 417579, RefRangeEnd = 417580, XrefRangeStart = 417574, XrefRangeEnd = 417579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TimeOffsetToString(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_TimeOffsetToString_Protected_Static_String_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x000C35DC File Offset: 0x000C17DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 417582, RefRangeEnd = 417583, XrefRangeStart = 417580, XrefRangeEnd = 417582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string YearMonthDurationToString(TimeSpan value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_YearMonthDurationToString_Protected_Static_String_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x000C3614 File Offset: 0x000C1814
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 417587, RefRangeEnd = 417588, XrefRangeStart = 417583, XrefRangeEnd = 417587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime DateTimeOffsetToDateTime(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DateTimeOffsetToDateTime_Internal_Static_DateTime_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x000C3654 File Offset: 0x000C1854
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 417600, RefRangeEnd = 417606, XrefRangeStart = 417588, XrefRangeEnd = 417600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DecimalToInt32(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DecimalToInt32_Internal_Static_Int32_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029E0 RID: 10720 RVA: 0x000C3694 File Offset: 0x000C1894
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 417618, RefRangeEnd = 417620, XrefRangeStart = 417606, XrefRangeEnd = 417618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long DecimalToInt64(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DecimalToInt64_Protected_Static_Int64_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029E1 RID: 10721 RVA: 0x000C36D4 File Offset: 0x000C18D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 417632, RefRangeEnd = 417636, XrefRangeStart = 417620, XrefRangeEnd = 417632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong DecimalToUInt64(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DecimalToUInt64_Protected_Static_UInt64_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029E2 RID: 10722 RVA: 0x000C3714 File Offset: 0x000C1914
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 417636, RefRangeEnd = 417638, XrefRangeStart = 417636, XrefRangeEnd = 417636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte Int32ToByte(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_Int32ToByte_Protected_Static_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x000C3754 File Offset: 0x000C1954
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 417638, RefRangeEnd = 417640, XrefRangeStart = 417638, XrefRangeEnd = 417638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short Int32ToInt16(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_Int32ToInt16_Protected_Static_Int16_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x000C3794 File Offset: 0x000C1994
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 417640, RefRangeEnd = 417642, XrefRangeStart = 417640, XrefRangeEnd = 417640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte Int32ToSByte(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_Int32ToSByte_Protected_Static_SByte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x000C37D4 File Offset: 0x000C19D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 417642, RefRangeEnd = 417644, XrefRangeStart = 417642, XrefRangeEnd = 417642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort Int32ToUInt16(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_Int32ToUInt16_Protected_Static_UInt16_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029E6 RID: 10726 RVA: 0x000C3814 File Offset: 0x000C1A14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 417644, RefRangeEnd = 417645, XrefRangeStart = 417644, XrefRangeEnd = 417644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Int64ToInt32(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_Int64ToInt32_Protected_Static_Int32_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029E7 RID: 10727 RVA: 0x000C3854 File Offset: 0x000C1A54
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 417645, RefRangeEnd = 417649, XrefRangeStart = 417645, XrefRangeEnd = 417645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint Int64ToUInt32(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_Int64ToUInt32_Protected_Static_UInt32_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029E8 RID: 10728 RVA: 0x000C3894 File Offset: 0x000C1A94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 417654, RefRangeEnd = 417656, XrefRangeStart = 417649, XrefRangeEnd = 417654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime UntypedAtomicToDateTime(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_UntypedAtomicToDateTime_Protected_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029E9 RID: 10729 RVA: 0x000C38D8 File Offset: 0x000C1AD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 417661, RefRangeEnd = 417663, XrefRangeStart = 417656, XrefRangeEnd = 417661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset UntypedAtomicToDateTimeOffset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_UntypedAtomicToDateTimeOffset_Protected_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029EA RID: 10730 RVA: 0x0001172B File Offset: 0x0000F92B
		public XmlBaseConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x060029EB RID: 10731 RVA: 0x000C391C File Offset: 0x000C1B1C
		// (set) Token: 0x060029EC RID: 10732 RVA: 0x00011734 File Offset: 0x0000F934
		public unsafe XmlSchemaType schemaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlBaseConverter.NativeFieldInfoPtr_schemaType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlBaseConverter.NativeFieldInfoPtr_schemaType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x060029ED RID: 10733 RVA: 0x000C394C File Offset: 0x000C1B4C
		// (set) Token: 0x060029EE RID: 10734 RVA: 0x00011753 File Offset: 0x0000F953
		public unsafe XmlTypeCode typeCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlBaseConverter.NativeFieldInfoPtr_typeCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlBaseConverter.NativeFieldInfoPtr_typeCode)) = value;
			}
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x060029EF RID: 10735 RVA: 0x000C3974 File Offset: 0x000C1B74
		// (set) Token: 0x060029F0 RID: 10736 RVA: 0x0001176E File Offset: 0x0000F96E
		public unsafe Type clrTypeDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlBaseConverter.NativeFieldInfoPtr_clrTypeDefault);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlBaseConverter.NativeFieldInfoPtr_clrTypeDefault), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x060029F1 RID: 10737 RVA: 0x000C39A4 File Offset: 0x000C1BA4
		// (set) Token: 0x060029F2 RID: 10738 RVA: 0x0001178D File Offset: 0x0000F98D
		public unsafe static Type ICollectionType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_ICollectionType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_ICollectionType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x060029F3 RID: 10739 RVA: 0x000C39CC File Offset: 0x000C1BCC
		// (set) Token: 0x060029F4 RID: 10740 RVA: 0x0001179F File Offset: 0x0000F99F
		public unsafe static Type IEnumerableType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_IEnumerableType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_IEnumerableType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x060029F5 RID: 10741 RVA: 0x000C39F4 File Offset: 0x000C1BF4
		// (set) Token: 0x060029F6 RID: 10742 RVA: 0x000117B1 File Offset: 0x0000F9B1
		public unsafe static Type IListType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_IListType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_IListType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x060029F7 RID: 10743 RVA: 0x000C3A1C File Offset: 0x000C1C1C
		// (set) Token: 0x060029F8 RID: 10744 RVA: 0x000117C3 File Offset: 0x0000F9C3
		public unsafe static Type ObjectArrayType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_ObjectArrayType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_ObjectArrayType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x060029F9 RID: 10745 RVA: 0x000C3A44 File Offset: 0x000C1C44
		// (set) Token: 0x060029FA RID: 10746 RVA: 0x000117D5 File Offset: 0x0000F9D5
		public unsafe static Type StringArrayType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_StringArrayType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_StringArrayType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x060029FB RID: 10747 RVA: 0x000C3A6C File Offset: 0x000C1C6C
		// (set) Token: 0x060029FC RID: 10748 RVA: 0x000117E7 File Offset: 0x0000F9E7
		public unsafe static Type XmlAtomicValueArrayType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_XmlAtomicValueArrayType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_XmlAtomicValueArrayType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x060029FD RID: 10749 RVA: 0x000C3A94 File Offset: 0x000C1C94
		// (set) Token: 0x060029FE RID: 10750 RVA: 0x000117F9 File Offset: 0x0000F9F9
		public unsafe static Type DecimalType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_DecimalType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_DecimalType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x060029FF RID: 10751 RVA: 0x000C3ABC File Offset: 0x000C1CBC
		// (set) Token: 0x06002A00 RID: 10752 RVA: 0x0001180B File Offset: 0x0000FA0B
		public unsafe static Type Int32Type
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_Int32Type, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_Int32Type, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06002A01 RID: 10753 RVA: 0x000C3AE4 File Offset: 0x000C1CE4
		// (set) Token: 0x06002A02 RID: 10754 RVA: 0x0001181D File Offset: 0x0000FA1D
		public unsafe static Type Int64Type
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_Int64Type, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_Int64Type, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06002A03 RID: 10755 RVA: 0x000C3B0C File Offset: 0x000C1D0C
		// (set) Token: 0x06002A04 RID: 10756 RVA: 0x0001182F File Offset: 0x0000FA2F
		public unsafe static Type StringType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_StringType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_StringType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06002A05 RID: 10757 RVA: 0x000C3B34 File Offset: 0x000C1D34
		// (set) Token: 0x06002A06 RID: 10758 RVA: 0x00011841 File Offset: 0x0000FA41
		public unsafe static Type XmlAtomicValueType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_XmlAtomicValueType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_XmlAtomicValueType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06002A07 RID: 10759 RVA: 0x000C3B5C File Offset: 0x000C1D5C
		// (set) Token: 0x06002A08 RID: 10760 RVA: 0x00011853 File Offset: 0x0000FA53
		public unsafe static Type ObjectType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_ObjectType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_ObjectType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06002A09 RID: 10761 RVA: 0x000C3B84 File Offset: 0x000C1D84
		// (set) Token: 0x06002A0A RID: 10762 RVA: 0x00011865 File Offset: 0x0000FA65
		public unsafe static Type ByteType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_ByteType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_ByteType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06002A0B RID: 10763 RVA: 0x000C3BAC File Offset: 0x000C1DAC
		// (set) Token: 0x06002A0C RID: 10764 RVA: 0x00011877 File Offset: 0x0000FA77
		public unsafe static Type Int16Type
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_Int16Type, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_Int16Type, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06002A0D RID: 10765 RVA: 0x000C3BD4 File Offset: 0x000C1DD4
		// (set) Token: 0x06002A0E RID: 10766 RVA: 0x00011889 File Offset: 0x0000FA89
		public unsafe static Type SByteType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_SByteType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_SByteType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06002A0F RID: 10767 RVA: 0x000C3BFC File Offset: 0x000C1DFC
		// (set) Token: 0x06002A10 RID: 10768 RVA: 0x0001189B File Offset: 0x0000FA9B
		public unsafe static Type UInt16Type
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_UInt16Type, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_UInt16Type, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06002A11 RID: 10769 RVA: 0x000C3C24 File Offset: 0x000C1E24
		// (set) Token: 0x06002A12 RID: 10770 RVA: 0x000118AD File Offset: 0x0000FAAD
		public unsafe static Type UInt32Type
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_UInt32Type, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_UInt32Type, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06002A13 RID: 10771 RVA: 0x000C3C4C File Offset: 0x000C1E4C
		// (set) Token: 0x06002A14 RID: 10772 RVA: 0x000118BF File Offset: 0x0000FABF
		public unsafe static Type UInt64Type
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_UInt64Type, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_UInt64Type, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06002A15 RID: 10773 RVA: 0x000C3C74 File Offset: 0x000C1E74
		// (set) Token: 0x06002A16 RID: 10774 RVA: 0x000118D1 File Offset: 0x0000FAD1
		public unsafe static Type XPathItemType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_XPathItemType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_XPathItemType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06002A17 RID: 10775 RVA: 0x000C3C9C File Offset: 0x000C1E9C
		// (set) Token: 0x06002A18 RID: 10776 RVA: 0x000118E3 File Offset: 0x0000FAE3
		public unsafe static Type DoubleType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_DoubleType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_DoubleType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06002A19 RID: 10777 RVA: 0x000C3CC4 File Offset: 0x000C1EC4
		// (set) Token: 0x06002A1A RID: 10778 RVA: 0x000118F5 File Offset: 0x0000FAF5
		public unsafe static Type SingleType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_SingleType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_SingleType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06002A1B RID: 10779 RVA: 0x000C3CEC File Offset: 0x000C1EEC
		// (set) Token: 0x06002A1C RID: 10780 RVA: 0x00011907 File Offset: 0x0000FB07
		public unsafe static Type DateTimeType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_DateTimeType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_DateTimeType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06002A1D RID: 10781 RVA: 0x000C3D14 File Offset: 0x000C1F14
		// (set) Token: 0x06002A1E RID: 10782 RVA: 0x00011919 File Offset: 0x0000FB19
		public unsafe static Type DateTimeOffsetType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_DateTimeOffsetType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_DateTimeOffsetType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06002A1F RID: 10783 RVA: 0x000C3D3C File Offset: 0x000C1F3C
		// (set) Token: 0x06002A20 RID: 10784 RVA: 0x0001192B File Offset: 0x0000FB2B
		public unsafe static Type BooleanType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_BooleanType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_BooleanType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06002A21 RID: 10785 RVA: 0x000C3D64 File Offset: 0x000C1F64
		// (set) Token: 0x06002A22 RID: 10786 RVA: 0x0001193D File Offset: 0x0000FB3D
		public unsafe static Type ByteArrayType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_ByteArrayType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_ByteArrayType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x06002A23 RID: 10787 RVA: 0x000C3D8C File Offset: 0x000C1F8C
		// (set) Token: 0x06002A24 RID: 10788 RVA: 0x0001194F File Offset: 0x0000FB4F
		public unsafe static Type XmlQualifiedNameType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_XmlQualifiedNameType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_XmlQualifiedNameType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x06002A25 RID: 10789 RVA: 0x000C3DB4 File Offset: 0x000C1FB4
		// (set) Token: 0x06002A26 RID: 10790 RVA: 0x00011961 File Offset: 0x0000FB61
		public unsafe static Type UriType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_UriType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_UriType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06002A27 RID: 10791 RVA: 0x000C3DDC File Offset: 0x000C1FDC
		// (set) Token: 0x06002A28 RID: 10792 RVA: 0x00011973 File Offset: 0x0000FB73
		public unsafe static Type TimeSpanType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_TimeSpanType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_TimeSpanType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06002A29 RID: 10793 RVA: 0x000C3E04 File Offset: 0x000C2004
		// (set) Token: 0x06002A2A RID: 10794 RVA: 0x00011985 File Offset: 0x0000FB85
		public unsafe static Type XPathNavigatorType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_XPathNavigatorType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_XPathNavigatorType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F90 RID: 8080
		private static readonly IntPtr NativeFieldInfoPtr_schemaType;

		// Token: 0x04001F91 RID: 8081
		private static readonly IntPtr NativeFieldInfoPtr_typeCode;

		// Token: 0x04001F92 RID: 8082
		private static readonly IntPtr NativeFieldInfoPtr_clrTypeDefault;

		// Token: 0x04001F93 RID: 8083
		private static readonly IntPtr NativeFieldInfoPtr_ICollectionType;

		// Token: 0x04001F94 RID: 8084
		private static readonly IntPtr NativeFieldInfoPtr_IEnumerableType;

		// Token: 0x04001F95 RID: 8085
		private static readonly IntPtr NativeFieldInfoPtr_IListType;

		// Token: 0x04001F96 RID: 8086
		private static readonly IntPtr NativeFieldInfoPtr_ObjectArrayType;

		// Token: 0x04001F97 RID: 8087
		private static readonly IntPtr NativeFieldInfoPtr_StringArrayType;

		// Token: 0x04001F98 RID: 8088
		private static readonly IntPtr NativeFieldInfoPtr_XmlAtomicValueArrayType;

		// Token: 0x04001F99 RID: 8089
		private static readonly IntPtr NativeFieldInfoPtr_DecimalType;

		// Token: 0x04001F9A RID: 8090
		private static readonly IntPtr NativeFieldInfoPtr_Int32Type;

		// Token: 0x04001F9B RID: 8091
		private static readonly IntPtr NativeFieldInfoPtr_Int64Type;

		// Token: 0x04001F9C RID: 8092
		private static readonly IntPtr NativeFieldInfoPtr_StringType;

		// Token: 0x04001F9D RID: 8093
		private static readonly IntPtr NativeFieldInfoPtr_XmlAtomicValueType;

		// Token: 0x04001F9E RID: 8094
		private static readonly IntPtr NativeFieldInfoPtr_ObjectType;

		// Token: 0x04001F9F RID: 8095
		private static readonly IntPtr NativeFieldInfoPtr_ByteType;

		// Token: 0x04001FA0 RID: 8096
		private static readonly IntPtr NativeFieldInfoPtr_Int16Type;

		// Token: 0x04001FA1 RID: 8097
		private static readonly IntPtr NativeFieldInfoPtr_SByteType;

		// Token: 0x04001FA2 RID: 8098
		private static readonly IntPtr NativeFieldInfoPtr_UInt16Type;

		// Token: 0x04001FA3 RID: 8099
		private static readonly IntPtr NativeFieldInfoPtr_UInt32Type;

		// Token: 0x04001FA4 RID: 8100
		private static readonly IntPtr NativeFieldInfoPtr_UInt64Type;

		// Token: 0x04001FA5 RID: 8101
		private static readonly IntPtr NativeFieldInfoPtr_XPathItemType;

		// Token: 0x04001FA6 RID: 8102
		private static readonly IntPtr NativeFieldInfoPtr_DoubleType;

		// Token: 0x04001FA7 RID: 8103
		private static readonly IntPtr NativeFieldInfoPtr_SingleType;

		// Token: 0x04001FA8 RID: 8104
		private static readonly IntPtr NativeFieldInfoPtr_DateTimeType;

		// Token: 0x04001FA9 RID: 8105
		private static readonly IntPtr NativeFieldInfoPtr_DateTimeOffsetType;

		// Token: 0x04001FAA RID: 8106
		private static readonly IntPtr NativeFieldInfoPtr_BooleanType;

		// Token: 0x04001FAB RID: 8107
		private static readonly IntPtr NativeFieldInfoPtr_ByteArrayType;

		// Token: 0x04001FAC RID: 8108
		private static readonly IntPtr NativeFieldInfoPtr_XmlQualifiedNameType;

		// Token: 0x04001FAD RID: 8109
		private static readonly IntPtr NativeFieldInfoPtr_UriType;

		// Token: 0x04001FAE RID: 8110
		private static readonly IntPtr NativeFieldInfoPtr_TimeSpanType;

		// Token: 0x04001FAF RID: 8111
		private static readonly IntPtr NativeFieldInfoPtr_XPathNavigatorType;

		// Token: 0x04001FB0 RID: 8112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0;

		// Token: 0x04001FB1 RID: 8113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlTypeCode_0;

		// Token: 0x04001FB2 RID: 8114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_0;

		// Token: 0x04001FB3 RID: 8115
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_Type_0;

		// Token: 0x04001FB4 RID: 8116
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_DateTime_0;

		// Token: 0x04001FB5 RID: 8117
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Double_0;

		// Token: 0x04001FB6 RID: 8118
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Int32_0;

		// Token: 0x04001FB7 RID: 8119
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Int64_0;

		// Token: 0x04001FB8 RID: 8120
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_String_0;

		// Token: 0x04001FB9 RID: 8121
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001FBA RID: 8122
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Boolean_0;

		// Token: 0x04001FBB RID: 8123
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_DateTimeOffset_0;

		// Token: 0x04001FBC RID: 8124
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Double_0;

		// Token: 0x04001FBD RID: 8125
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_0;

		// Token: 0x04001FBE RID: 8126
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int64_0;

		// Token: 0x04001FBF RID: 8127
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_String_0;

		// Token: 0x04001FC0 RID: 8128
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Object_0;

		// Token: 0x04001FC1 RID: 8129
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_DateTime_0;

		// Token: 0x04001FC2 RID: 8130
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_String_0;

		// Token: 0x04001FC3 RID: 8131
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_Object_0;

		// Token: 0x04001FC4 RID: 8132
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_String_0;

		// Token: 0x04001FC5 RID: 8133
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_Object_0;

		// Token: 0x04001FC6 RID: 8134
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Boolean_0;

		// Token: 0x04001FC7 RID: 8135
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_DateTime_0;

		// Token: 0x04001FC8 RID: 8136
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Int32_0;

		// Token: 0x04001FC9 RID: 8137
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Int64_0;

		// Token: 0x04001FCA RID: 8138
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_String_0;

		// Token: 0x04001FCB RID: 8139
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Object_0;

		// Token: 0x04001FCC RID: 8140
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Boolean_0;

		// Token: 0x04001FCD RID: 8141
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_DateTime_0;

		// Token: 0x04001FCE RID: 8142
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Double_0;

		// Token: 0x04001FCF RID: 8143
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Int64_0;

		// Token: 0x04001FD0 RID: 8144
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_String_0;

		// Token: 0x04001FD1 RID: 8145
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Object_0;

		// Token: 0x04001FD2 RID: 8146
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Boolean_0;

		// Token: 0x04001FD3 RID: 8147
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_DateTime_0;

		// Token: 0x04001FD4 RID: 8148
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Double_0;

		// Token: 0x04001FD5 RID: 8149
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Int32_0;

		// Token: 0x04001FD6 RID: 8150
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_String_0;

		// Token: 0x04001FD7 RID: 8151
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Object_0;

		// Token: 0x04001FD8 RID: 8152
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_Double_0;

		// Token: 0x04001FD9 RID: 8153
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_String_0;

		// Token: 0x04001FDA RID: 8154
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_Object_0;

		// Token: 0x04001FDB RID: 8155
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Boolean_0;

		// Token: 0x04001FDC RID: 8156
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTime_0;

		// Token: 0x04001FDD RID: 8157
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTimeOffset_0;

		// Token: 0x04001FDE RID: 8158
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Decimal_0;

		// Token: 0x04001FDF RID: 8159
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Double_0;

		// Token: 0x04001FE0 RID: 8160
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Int32_0;

		// Token: 0x04001FE1 RID: 8161
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Int64_0;

		// Token: 0x04001FE2 RID: 8162
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Single_0;

		// Token: 0x04001FE3 RID: 8163
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_IXmlNamespaceResolver_0;

		// Token: 0x04001FE4 RID: 8164
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_0;

		// Token: 0x04001FE5 RID: 8165
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Boolean_Type_0;

		// Token: 0x04001FE6 RID: 8166
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_DateTime_Type_0;

		// Token: 0x04001FE7 RID: 8167
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Decimal_Type_0;

		// Token: 0x04001FE8 RID: 8168
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Double_Type_0;

		// Token: 0x04001FE9 RID: 8169
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int32_Type_0;

		// Token: 0x04001FEA RID: 8170
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int64_Type_0;

		// Token: 0x04001FEB RID: 8171
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_String_Type_IXmlNamespaceResolver_0;

		// Token: 0x04001FEC RID: 8172
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_0;

		// Token: 0x04001FED RID: 8173
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaType_Protected_get_XmlSchemaType_0;

		// Token: 0x04001FEE RID: 8174
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Protected_get_XmlTypeCode_0;

		// Token: 0x04001FEF RID: 8175
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlTypeName_Protected_get_String_0;

		// Token: 0x04001FF0 RID: 8176
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultClrType_Protected_get_Type_0;

		// Token: 0x04001FF1 RID: 8177
		private static readonly IntPtr NativeMethodInfoPtr_IsDerivedFrom_Protected_Static_Boolean_Type_Type_0;

		// Token: 0x04001FF2 RID: 8178
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidClrMappingException_Protected_Exception_Type_Type_0;

		// Token: 0x04001FF3 RID: 8179
		private static readonly IntPtr NativeMethodInfoPtr_QNameToString_Protected_Static_String_XmlQualifiedName_0;

		// Token: 0x04001FF4 RID: 8180
		private static readonly IntPtr NativeMethodInfoPtr_ChangeListType_Protected_Virtual_New_Object_Object_Type_IXmlNamespaceResolver_0;

		// Token: 0x04001FF5 RID: 8181
		private static readonly IntPtr NativeMethodInfoPtr_StringToBase64Binary_Protected_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04001FF6 RID: 8182
		private static readonly IntPtr NativeMethodInfoPtr_StringToDate_Protected_Static_DateTime_String_0;

		// Token: 0x04001FF7 RID: 8183
		private static readonly IntPtr NativeMethodInfoPtr_StringToDateTime_Protected_Static_DateTime_String_0;

		// Token: 0x04001FF8 RID: 8184
		private static readonly IntPtr NativeMethodInfoPtr_StringToDayTimeDuration_Protected_Static_TimeSpan_String_0;

		// Token: 0x04001FF9 RID: 8185
		private static readonly IntPtr NativeMethodInfoPtr_StringToDuration_Protected_Static_TimeSpan_String_0;

		// Token: 0x04001FFA RID: 8186
		private static readonly IntPtr NativeMethodInfoPtr_StringToGDay_Protected_Static_DateTime_String_0;

		// Token: 0x04001FFB RID: 8187
		private static readonly IntPtr NativeMethodInfoPtr_StringToGMonth_Protected_Static_DateTime_String_0;

		// Token: 0x04001FFC RID: 8188
		private static readonly IntPtr NativeMethodInfoPtr_StringToGMonthDay_Protected_Static_DateTime_String_0;

		// Token: 0x04001FFD RID: 8189
		private static readonly IntPtr NativeMethodInfoPtr_StringToGYear_Protected_Static_DateTime_String_0;

		// Token: 0x04001FFE RID: 8190
		private static readonly IntPtr NativeMethodInfoPtr_StringToGYearMonth_Protected_Static_DateTime_String_0;

		// Token: 0x04001FFF RID: 8191
		private static readonly IntPtr NativeMethodInfoPtr_StringToDateOffset_Protected_Static_DateTimeOffset_String_0;

		// Token: 0x04002000 RID: 8192
		private static readonly IntPtr NativeMethodInfoPtr_StringToDateTimeOffset_Protected_Static_DateTimeOffset_String_0;

		// Token: 0x04002001 RID: 8193
		private static readonly IntPtr NativeMethodInfoPtr_StringToGDayOffset_Protected_Static_DateTimeOffset_String_0;

		// Token: 0x04002002 RID: 8194
		private static readonly IntPtr NativeMethodInfoPtr_StringToGMonthOffset_Protected_Static_DateTimeOffset_String_0;

		// Token: 0x04002003 RID: 8195
		private static readonly IntPtr NativeMethodInfoPtr_StringToGMonthDayOffset_Protected_Static_DateTimeOffset_String_0;

		// Token: 0x04002004 RID: 8196
		private static readonly IntPtr NativeMethodInfoPtr_StringToGYearOffset_Protected_Static_DateTimeOffset_String_0;

		// Token: 0x04002005 RID: 8197
		private static readonly IntPtr NativeMethodInfoPtr_StringToGYearMonthOffset_Protected_Static_DateTimeOffset_String_0;

		// Token: 0x04002006 RID: 8198
		private static readonly IntPtr NativeMethodInfoPtr_StringToHexBinary_Protected_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04002007 RID: 8199
		private static readonly IntPtr NativeMethodInfoPtr_StringToQName_Protected_Static_XmlQualifiedName_String_IXmlNamespaceResolver_0;

		// Token: 0x04002008 RID: 8200
		private static readonly IntPtr NativeMethodInfoPtr_StringToTime_Protected_Static_DateTime_String_0;

		// Token: 0x04002009 RID: 8201
		private static readonly IntPtr NativeMethodInfoPtr_StringToTimeOffset_Protected_Static_DateTimeOffset_String_0;

		// Token: 0x0400200A RID: 8202
		private static readonly IntPtr NativeMethodInfoPtr_StringToYearMonthDuration_Protected_Static_TimeSpan_String_0;

		// Token: 0x0400200B RID: 8203
		private static readonly IntPtr NativeMethodInfoPtr_AnyUriToString_Protected_Static_String_Uri_0;

		// Token: 0x0400200C RID: 8204
		private static readonly IntPtr NativeMethodInfoPtr_Base64BinaryToString_Protected_Static_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400200D RID: 8205
		private static readonly IntPtr NativeMethodInfoPtr_DateToString_Protected_Static_String_DateTime_0;

		// Token: 0x0400200E RID: 8206
		private static readonly IntPtr NativeMethodInfoPtr_DateTimeToString_Protected_Static_String_DateTime_0;

		// Token: 0x0400200F RID: 8207
		private static readonly IntPtr NativeMethodInfoPtr_DayTimeDurationToString_Protected_Static_String_TimeSpan_0;

		// Token: 0x04002010 RID: 8208
		private static readonly IntPtr NativeMethodInfoPtr_DurationToString_Protected_Static_String_TimeSpan_0;

		// Token: 0x04002011 RID: 8209
		private static readonly IntPtr NativeMethodInfoPtr_GDayToString_Protected_Static_String_DateTime_0;

		// Token: 0x04002012 RID: 8210
		private static readonly IntPtr NativeMethodInfoPtr_GMonthToString_Protected_Static_String_DateTime_0;

		// Token: 0x04002013 RID: 8211
		private static readonly IntPtr NativeMethodInfoPtr_GMonthDayToString_Protected_Static_String_DateTime_0;

		// Token: 0x04002014 RID: 8212
		private static readonly IntPtr NativeMethodInfoPtr_GYearToString_Protected_Static_String_DateTime_0;

		// Token: 0x04002015 RID: 8213
		private static readonly IntPtr NativeMethodInfoPtr_GYearMonthToString_Protected_Static_String_DateTime_0;

		// Token: 0x04002016 RID: 8214
		private static readonly IntPtr NativeMethodInfoPtr_DateOffsetToString_Protected_Static_String_DateTimeOffset_0;

		// Token: 0x04002017 RID: 8215
		private static readonly IntPtr NativeMethodInfoPtr_DateTimeOffsetToString_Protected_Static_String_DateTimeOffset_0;

		// Token: 0x04002018 RID: 8216
		private static readonly IntPtr NativeMethodInfoPtr_GDayOffsetToString_Protected_Static_String_DateTimeOffset_0;

		// Token: 0x04002019 RID: 8217
		private static readonly IntPtr NativeMethodInfoPtr_GMonthOffsetToString_Protected_Static_String_DateTimeOffset_0;

		// Token: 0x0400201A RID: 8218
		private static readonly IntPtr NativeMethodInfoPtr_GMonthDayOffsetToString_Protected_Static_String_DateTimeOffset_0;

		// Token: 0x0400201B RID: 8219
		private static readonly IntPtr NativeMethodInfoPtr_GYearOffsetToString_Protected_Static_String_DateTimeOffset_0;

		// Token: 0x0400201C RID: 8220
		private static readonly IntPtr NativeMethodInfoPtr_GYearMonthOffsetToString_Protected_Static_String_DateTimeOffset_0;

		// Token: 0x0400201D RID: 8221
		private static readonly IntPtr NativeMethodInfoPtr_QNameToString_Protected_Static_String_XmlQualifiedName_IXmlNamespaceResolver_0;

		// Token: 0x0400201E RID: 8222
		private static readonly IntPtr NativeMethodInfoPtr_TimeToString_Protected_Static_String_DateTime_0;

		// Token: 0x0400201F RID: 8223
		private static readonly IntPtr NativeMethodInfoPtr_TimeOffsetToString_Protected_Static_String_DateTimeOffset_0;

		// Token: 0x04002020 RID: 8224
		private static readonly IntPtr NativeMethodInfoPtr_YearMonthDurationToString_Protected_Static_String_TimeSpan_0;

		// Token: 0x04002021 RID: 8225
		private static readonly IntPtr NativeMethodInfoPtr_DateTimeOffsetToDateTime_Internal_Static_DateTime_DateTimeOffset_0;

		// Token: 0x04002022 RID: 8226
		private static readonly IntPtr NativeMethodInfoPtr_DecimalToInt32_Internal_Static_Int32_Decimal_0;

		// Token: 0x04002023 RID: 8227
		private static readonly IntPtr NativeMethodInfoPtr_DecimalToInt64_Protected_Static_Int64_Decimal_0;

		// Token: 0x04002024 RID: 8228
		private static readonly IntPtr NativeMethodInfoPtr_DecimalToUInt64_Protected_Static_UInt64_Decimal_0;

		// Token: 0x04002025 RID: 8229
		private static readonly IntPtr NativeMethodInfoPtr_Int32ToByte_Protected_Static_Byte_Int32_0;

		// Token: 0x04002026 RID: 8230
		private static readonly IntPtr NativeMethodInfoPtr_Int32ToInt16_Protected_Static_Int16_Int32_0;

		// Token: 0x04002027 RID: 8231
		private static readonly IntPtr NativeMethodInfoPtr_Int32ToSByte_Protected_Static_SByte_Int32_0;

		// Token: 0x04002028 RID: 8232
		private static readonly IntPtr NativeMethodInfoPtr_Int32ToUInt16_Protected_Static_UInt16_Int32_0;

		// Token: 0x04002029 RID: 8233
		private static readonly IntPtr NativeMethodInfoPtr_Int64ToInt32_Protected_Static_Int32_Int64_0;

		// Token: 0x0400202A RID: 8234
		private static readonly IntPtr NativeMethodInfoPtr_Int64ToUInt32_Protected_Static_UInt32_Int64_0;

		// Token: 0x0400202B RID: 8235
		private static readonly IntPtr NativeMethodInfoPtr_UntypedAtomicToDateTime_Protected_Static_DateTime_String_0;

		// Token: 0x0400202C RID: 8236
		private static readonly IntPtr NativeMethodInfoPtr_UntypedAtomicToDateTimeOffset_Protected_Static_DateTimeOffset_String_0;
	}
}

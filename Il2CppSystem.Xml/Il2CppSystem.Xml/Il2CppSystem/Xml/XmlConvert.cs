using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text.RegularExpressions;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200008F RID: 143
	public class XmlConvert : Object
	{
		// Token: 0x06001066 RID: 4198 RVA: 0x0005DC0C File Offset: 0x0005BE0C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlConvert()
		{
			Il2CppClassPointerStore<XmlConvert>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlConvert");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr);
			XmlConvert.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, "xmlCharType");
			XmlConvert.NativeFieldInfoPtr_crt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, "crt");
			XmlConvert.NativeFieldInfoPtr_c_EncodedCharLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, "c_EncodedCharLength");
			XmlConvert.NativeFieldInfoPtr_c_EncodeCharPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, "c_EncodeCharPattern");
			XmlConvert.NativeFieldInfoPtr_c_DecodeCharPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, "c_DecodeCharPattern");
			XmlConvert.NativeFieldInfoPtr_s_allDateTimeFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, "s_allDateTimeFormats");
			XmlConvert.NativeFieldInfoPtr_WhitespaceChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, "WhitespaceChars");
			XmlConvert.NativeMethodInfoPtr_EncodeName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665994);
			XmlConvert.NativeMethodInfoPtr_EncodeLocalName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665995);
			XmlConvert.NativeMethodInfoPtr_DecodeName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665996);
			XmlConvert.NativeMethodInfoPtr_EncodeName_Private_Static_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665997);
			XmlConvert.NativeMethodInfoPtr_FromHex_Private_Static_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665998);
			XmlConvert.NativeMethodInfoPtr_FromBinHexString_Internal_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100665999);
			XmlConvert.NativeMethodInfoPtr_FromBinHexString_Internal_Static_Il2CppStructArray_1_Byte_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666000);
			XmlConvert.NativeMethodInfoPtr_ToBinHexString_Internal_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666001);
			XmlConvert.NativeMethodInfoPtr_VerifyName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666002);
			XmlConvert.NativeMethodInfoPtr_TryVerifyName_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666003);
			XmlConvert.NativeMethodInfoPtr_VerifyQName_Internal_Static_String_String_ExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666004);
			XmlConvert.NativeMethodInfoPtr_VerifyNCName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666005);
			XmlConvert.NativeMethodInfoPtr_VerifyNCName_Internal_Static_String_String_ExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666006);
			XmlConvert.NativeMethodInfoPtr_TryVerifyNCName_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666007);
			XmlConvert.NativeMethodInfoPtr_VerifyTOKEN_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666008);
			XmlConvert.NativeMethodInfoPtr_TryVerifyTOKEN_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666009);
			XmlConvert.NativeMethodInfoPtr_TryVerifyNMTOKEN_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666010);
			XmlConvert.NativeMethodInfoPtr_TryVerifyNormalizedString_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666011);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666012);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666013);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666014);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666015);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666016);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666017);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666018);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666019);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666020);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666021);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666022);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666023);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666024);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666025);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666026);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_DateTime_XmlDateTimeSerializationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666027);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666028);
			XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666029);
			XmlConvert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666030);
			XmlConvert.NativeMethodInfoPtr_TryToBoolean_Internal_Static_Exception_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666031);
			XmlConvert.NativeMethodInfoPtr_ToChar_Public_Static_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666032);
			XmlConvert.NativeMethodInfoPtr_TryToChar_Internal_Static_Exception_String_byref_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666033);
			XmlConvert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666034);
			XmlConvert.NativeMethodInfoPtr_TryToDecimal_Internal_Static_Exception_String_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666035);
			XmlConvert.NativeMethodInfoPtr_ToInteger_Internal_Static_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666036);
			XmlConvert.NativeMethodInfoPtr_TryToInteger_Internal_Static_Exception_String_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666037);
			XmlConvert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666038);
			XmlConvert.NativeMethodInfoPtr_TryToSByte_Internal_Static_Exception_String_byref_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666039);
			XmlConvert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666040);
			XmlConvert.NativeMethodInfoPtr_TryToInt16_Internal_Static_Exception_String_byref_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666041);
			XmlConvert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666042);
			XmlConvert.NativeMethodInfoPtr_TryToInt32_Internal_Static_Exception_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666043);
			XmlConvert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666044);
			XmlConvert.NativeMethodInfoPtr_TryToInt64_Internal_Static_Exception_String_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666045);
			XmlConvert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666046);
			XmlConvert.NativeMethodInfoPtr_TryToByte_Internal_Static_Exception_String_byref_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666047);
			XmlConvert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666048);
			XmlConvert.NativeMethodInfoPtr_TryToUInt16_Internal_Static_Exception_String_byref_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666049);
			XmlConvert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666050);
			XmlConvert.NativeMethodInfoPtr_TryToUInt32_Internal_Static_Exception_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666051);
			XmlConvert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666052);
			XmlConvert.NativeMethodInfoPtr_TryToUInt64_Internal_Static_Exception_String_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666053);
			XmlConvert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666054);
			XmlConvert.NativeMethodInfoPtr_TryToSingle_Internal_Static_Exception_String_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666055);
			XmlConvert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666056);
			XmlConvert.NativeMethodInfoPtr_TryToDouble_Internal_Static_Exception_String_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666057);
			XmlConvert.NativeMethodInfoPtr_ToXPathDouble_Internal_Static_Double_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666058);
			XmlConvert.NativeMethodInfoPtr_ToTimeSpan_Public_Static_TimeSpan_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666059);
			XmlConvert.NativeMethodInfoPtr_TryToTimeSpan_Internal_Static_Exception_String_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666060);
			XmlConvert.NativeMethodInfoPtr_get_AllDateTimeFormats_Private_Static_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666061);
			XmlConvert.NativeMethodInfoPtr_CreateAllDateTimeFormats_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666062);
			XmlConvert.NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666063);
			XmlConvert.NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666064);
			XmlConvert.NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_XmlDateTimeSerializationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666065);
			XmlConvert.NativeMethodInfoPtr_ToDateTimeOffset_Public_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666066);
			XmlConvert.NativeMethodInfoPtr_ToGuid_Public_Static_Guid_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666067);
			XmlConvert.NativeMethodInfoPtr_TryToGuid_Internal_Static_Exception_String_byref_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666068);
			XmlConvert.NativeMethodInfoPtr_SwitchToLocalTime_Private_Static_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666069);
			XmlConvert.NativeMethodInfoPtr_SwitchToUtcTime_Private_Static_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666070);
			XmlConvert.NativeMethodInfoPtr_ToUri_Internal_Static_Uri_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666071);
			XmlConvert.NativeMethodInfoPtr_TryToUri_Internal_Static_Exception_String_byref_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666072);
			XmlConvert.NativeMethodInfoPtr_StrEqual_Internal_Static_Boolean_Il2CppStructArray_1_Char_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666073);
			XmlConvert.NativeMethodInfoPtr_TrimString_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666074);
			XmlConvert.NativeMethodInfoPtr_TrimStringStart_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666075);
			XmlConvert.NativeMethodInfoPtr_TrimStringEnd_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666076);
			XmlConvert.NativeMethodInfoPtr_SplitString_Internal_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666077);
			XmlConvert.NativeMethodInfoPtr_IsNegativeZero_Internal_Static_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666078);
			XmlConvert.NativeMethodInfoPtr_DoubleToInt64Bits_Private_Static_Int64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666079);
			XmlConvert.NativeMethodInfoPtr_VerifyCharData_Internal_Static_Void_String_ExceptionType_ExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666080);
			XmlConvert.NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_ExceptionType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666081);
			XmlConvert.NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_String_ExceptionType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666082);
			XmlConvert.NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_Il2CppStringArray_ExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666083);
			XmlConvert.NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_Il2CppStringArray_ExceptionType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666084);
			XmlConvert.NativeMethodInfoPtr_CreateInvalidSurrogatePairException_Internal_Static_Exception_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666085);
			XmlConvert.NativeMethodInfoPtr_CreateInvalidSurrogatePairException_Internal_Static_Exception_Char_Char_ExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666086);
			XmlConvert.NativeMethodInfoPtr_CreateInvalidSurrogatePairException_Internal_Static_Exception_Char_Char_ExceptionType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666087);
			XmlConvert.NativeMethodInfoPtr_CreateInvalidHighSurrogateCharException_Internal_Static_Exception_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666088);
			XmlConvert.NativeMethodInfoPtr_CreateInvalidHighSurrogateCharException_Internal_Static_Exception_Char_ExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666089);
			XmlConvert.NativeMethodInfoPtr_CreateInvalidHighSurrogateCharException_Internal_Static_Exception_Char_ExceptionType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666090);
			XmlConvert.NativeMethodInfoPtr_CreateInvalidCharException_Internal_Static_Exception_String_Int32_ExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666091);
			XmlConvert.NativeMethodInfoPtr_CreateInvalidCharException_Internal_Static_Exception_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666092);
			XmlConvert.NativeMethodInfoPtr_CreateInvalidCharException_Internal_Static_Exception_Char_Char_ExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666093);
			XmlConvert.NativeMethodInfoPtr_CreateInvalidNameCharException_Internal_Static_Exception_String_Int32_ExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666094);
			XmlConvert.NativeMethodInfoPtr_CreateInvalidNameArgumentException_Internal_Static_ArgumentException_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlConvert>.NativeClassPtr, 100666095);
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x0005E4C0 File Offset: 0x0005C6C0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 380252, RefRangeEnd = 380263, XrefRangeStart = 380248, XrefRangeEnd = 380252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncodeName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_EncodeName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x0005E4FC File Offset: 0x0005C6FC
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 380267, RefRangeEnd = 380292, XrefRangeStart = 380263, XrefRangeEnd = 380267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncodeLocalName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_EncodeLocalName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x0005E538 File Offset: 0x0005C738
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 380385, RefRangeEnd = 380429, XrefRangeStart = 380292, XrefRangeEnd = 380385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DecodeName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_DecodeName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x0005E574 File Offset: 0x0005C774
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 380542, RefRangeEnd = 380544, XrefRangeStart = 380429, XrefRangeEnd = 380542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncodeName(string name, bool first, bool local)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref first;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref local;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_EncodeName_Private_Static_String_String_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x0005E5CC File Offset: 0x0005C7CC
		[CallerCount(0)]
		public unsafe static int FromHex(char digit)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref digit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_FromHex_Private_Static_Int32_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x0005E60C File Offset: 0x0005C80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380544, XrefRangeEnd = 380555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> FromBinHexString(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_FromBinHexString_Internal_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x0005E650 File Offset: 0x0005C850
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 380563, RefRangeEnd = 380565, XrefRangeStart = 380555, XrefRangeEnd = 380563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> FromBinHexString(string s, bool allowOddCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowOddCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_FromBinHexString_Internal_Static_Il2CppStructArray_1_Byte_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x0005E6A4 File Offset: 0x0005C8A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380572, RefRangeEnd = 380573, XrefRangeStart = 380565, XrefRangeEnd = 380572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToBinHexString(Il2CppStructArray<byte> inArray)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToBinHexString_Internal_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x0005E6E0 File Offset: 0x0005C8E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 380577, RefRangeEnd = 380579, XrefRangeStart = 380573, XrefRangeEnd = 380577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string VerifyName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_VerifyName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x0005E71C File Offset: 0x0005C91C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380588, RefRangeEnd = 380589, XrefRangeStart = 380579, XrefRangeEnd = 380588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryVerifyName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryVerifyName_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x0005E760 File Offset: 0x0005C960
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380600, RefRangeEnd = 380601, XrefRangeStart = 380589, XrefRangeEnd = 380600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string VerifyQName(string name, ExceptionType exceptionType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_VerifyQName_Internal_Static_String_String_ExceptionType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x0005E7AC File Offset: 0x0005C9AC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 380608, RefRangeEnd = 380616, XrefRangeStart = 380601, XrefRangeEnd = 380608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string VerifyNCName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_VerifyNCName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x0005E7E8 File Offset: 0x0005C9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380616, XrefRangeEnd = 380620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string VerifyNCName(string name, ExceptionType exceptionType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_VerifyNCName_Internal_Static_String_String_ExceptionType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x0005E834 File Offset: 0x0005CA34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380627, RefRangeEnd = 380628, XrefRangeStart = 380620, XrefRangeEnd = 380627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryVerifyNCName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryVerifyNCName_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x0005E878 File Offset: 0x0005CA78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 380638, RefRangeEnd = 380640, XrefRangeStart = 380628, XrefRangeEnd = 380638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string VerifyTOKEN(string token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_VerifyTOKEN_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x0005E8B4 File Offset: 0x0005CAB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380656, RefRangeEnd = 380657, XrefRangeStart = 380640, XrefRangeEnd = 380656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryVerifyTOKEN(string token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryVerifyTOKEN_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x0005E8F8 File Offset: 0x0005CAF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380671, RefRangeEnd = 380672, XrefRangeStart = 380657, XrefRangeEnd = 380671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryVerifyNMTOKEN(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryVerifyNMTOKEN_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x0005E93C File Offset: 0x0005CB3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380679, RefRangeEnd = 380680, XrefRangeStart = 380672, XrefRangeEnd = 380679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryVerifyNormalizedString(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryVerifyNormalizedString_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x0005E980 File Offset: 0x0005CB80
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 380684, RefRangeEnd = 380688, XrefRangeStart = 380680, XrefRangeEnd = 380684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x0005E9B8 File Offset: 0x0005CBB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380692, RefRangeEnd = 380693, XrefRangeStart = 380688, XrefRangeEnd = 380692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x0005E9F0 File Offset: 0x0005CBF0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 380698, RefRangeEnd = 380703, XrefRangeStart = 380693, XrefRangeEnd = 380698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x0005EA28 File Offset: 0x0005CC28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380705, RefRangeEnd = 380706, XrefRangeStart = 380703, XrefRangeEnd = 380705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x0005EA60 File Offset: 0x0005CC60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 380708, RefRangeEnd = 380710, XrefRangeStart = 380706, XrefRangeEnd = 380708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x0005EA98 File Offset: 0x0005CC98
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 380712, RefRangeEnd = 380723, XrefRangeStart = 380710, XrefRangeEnd = 380712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x0005EAD0 File Offset: 0x0005CCD0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 380725, RefRangeEnd = 380731, XrefRangeStart = 380723, XrefRangeEnd = 380725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x0005EB08 File Offset: 0x0005CD08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 380733, RefRangeEnd = 380735, XrefRangeStart = 380731, XrefRangeEnd = 380733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x0005EB40 File Offset: 0x0005CD40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380737, RefRangeEnd = 380738, XrefRangeStart = 380735, XrefRangeEnd = 380737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x0005EB78 File Offset: 0x0005CD78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380740, RefRangeEnd = 380741, XrefRangeStart = 380738, XrefRangeEnd = 380740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x0005EBB0 File Offset: 0x0005CDB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380743, RefRangeEnd = 380744, XrefRangeStart = 380741, XrefRangeEnd = 380743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x0005EBE8 File Offset: 0x0005CDE8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 380750, RefRangeEnd = 380758, XrefRangeStart = 380744, XrefRangeEnd = 380750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x0005EC20 File Offset: 0x0005CE20
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 380764, RefRangeEnd = 380772, XrefRangeStart = 380758, XrefRangeEnd = 380764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x0005EC58 File Offset: 0x0005CE58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 380774, RefRangeEnd = 380776, XrefRangeStart = 380772, XrefRangeEnd = 380774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(TimeSpan value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x0005EC90 File Offset: 0x0005CE90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380784, RefRangeEnd = 380785, XrefRangeStart = 380776, XrefRangeEnd = 380784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(DateTime value, string format)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x0005ECDC File Offset: 0x0005CEDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 380805, RefRangeEnd = 380807, XrefRangeStart = 380785, XrefRangeEnd = 380805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(DateTime value, XmlDateTimeSerializationMode dateTimeOption)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateTimeOption;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_DateTime_XmlDateTimeSerializationMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x0005ED24 File Offset: 0x0005CF24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 380812, RefRangeEnd = 380814, XrefRangeStart = 380807, XrefRangeEnd = 380812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x0005ED5C File Offset: 0x0005CF5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380815, RefRangeEnd = 380816, XrefRangeStart = 380814, XrefRangeEnd = 380815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Guid value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Guid_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x0005ED94 File Offset: 0x0005CF94
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 380836, RefRangeEnd = 380863, XrefRangeStart = 380816, XrefRangeEnd = 380836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x0005EDD8 File Offset: 0x0005CFD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380900, RefRangeEnd = 380901, XrefRangeStart = 380863, XrefRangeEnd = 380900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToBoolean(string s, out bool result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToBoolean_Internal_Static_Exception_String_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x0005EE2C File Offset: 0x0005D02C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 380915, RefRangeEnd = 380917, XrefRangeStart = 380901, XrefRangeEnd = 380915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToChar(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToChar_Public_Static_Char_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x0005EE70 File Offset: 0x0005D070
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380925, RefRangeEnd = 380926, XrefRangeStart = 380917, XrefRangeEnd = 380925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToChar(string s, out char result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToChar_Internal_Static_Exception_String_byref_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x0005EEC4 File Offset: 0x0005D0C4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 380931, RefRangeEnd = 380939, XrefRangeStart = 380926, XrefRangeEnd = 380931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x0005EF08 File Offset: 0x0005D108
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 380948, RefRangeEnd = 380950, XrefRangeStart = 380939, XrefRangeEnd = 380948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToDecimal(string s, out Decimal result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToDecimal_Internal_Static_Exception_String_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x0005EF5C File Offset: 0x0005D15C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 380955, RefRangeEnd = 380958, XrefRangeStart = 380950, XrefRangeEnd = 380955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToInteger(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToInteger_Internal_Static_Decimal_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x0005EFA0 File Offset: 0x0005D1A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380967, RefRangeEnd = 380968, XrefRangeStart = 380958, XrefRangeEnd = 380967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToInteger(string s, out Decimal result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToInteger_Internal_Static_Exception_String_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x0005EFF4 File Offset: 0x0005D1F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 380970, RefRangeEnd = 380972, XrefRangeStart = 380968, XrefRangeEnd = 380970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x0005F038 File Offset: 0x0005D238
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380978, RefRangeEnd = 380979, XrefRangeStart = 380972, XrefRangeEnd = 380978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToSByte(string s, out sbyte result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToSByte_Internal_Static_Exception_String_byref_SByte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x0005F08C File Offset: 0x0005D28C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 380981, RefRangeEnd = 380983, XrefRangeStart = 380979, XrefRangeEnd = 380981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x0005F0D0 File Offset: 0x0005D2D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 380989, RefRangeEnd = 380990, XrefRangeStart = 380983, XrefRangeEnd = 380989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToInt16(string s, out short result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToInt16_Internal_Static_Exception_String_byref_Int16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x0005F124 File Offset: 0x0005D324
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 380992, RefRangeEnd = 381001, XrefRangeStart = 380990, XrefRangeEnd = 380992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x0005F168 File Offset: 0x0005D368
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381007, RefRangeEnd = 381008, XrefRangeStart = 381001, XrefRangeEnd = 381007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToInt32(string s, out int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToInt32_Internal_Static_Exception_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x0005F1BC File Offset: 0x0005D3BC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 381010, RefRangeEnd = 381018, XrefRangeStart = 381008, XrefRangeEnd = 381010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x0005F200 File Offset: 0x0005D400
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381024, RefRangeEnd = 381025, XrefRangeStart = 381018, XrefRangeEnd = 381024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToInt64(string s, out long result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToInt64_Internal_Static_Exception_String_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x0005F254 File Offset: 0x0005D454
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 381027, RefRangeEnd = 381029, XrefRangeStart = 381025, XrefRangeEnd = 381027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x0005F298 File Offset: 0x0005D498
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381035, RefRangeEnd = 381036, XrefRangeStart = 381029, XrefRangeEnd = 381035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToByte(string s, out byte result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToByte_Internal_Static_Exception_String_byref_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x0005F2EC File Offset: 0x0005D4EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 381038, RefRangeEnd = 381040, XrefRangeStart = 381036, XrefRangeEnd = 381038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x0005F330 File Offset: 0x0005D530
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381046, RefRangeEnd = 381047, XrefRangeStart = 381040, XrefRangeEnd = 381046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToUInt16(string s, out ushort result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToUInt16_Internal_Static_Exception_String_byref_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x0005F384 File Offset: 0x0005D584
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 381049, RefRangeEnd = 381051, XrefRangeStart = 381047, XrefRangeEnd = 381049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x0005F3C8 File Offset: 0x0005D5C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381057, RefRangeEnd = 381058, XrefRangeStart = 381051, XrefRangeEnd = 381057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToUInt32(string s, out uint result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToUInt32_Internal_Static_Exception_String_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x0005F41C File Offset: 0x0005D61C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 381060, RefRangeEnd = 381062, XrefRangeStart = 381058, XrefRangeEnd = 381060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x0005F460 File Offset: 0x0005D660
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381068, RefRangeEnd = 381069, XrefRangeStart = 381062, XrefRangeEnd = 381068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToUInt64(string s, out ulong result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToUInt64_Internal_Static_Exception_String_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x0005F4B4 File Offset: 0x0005D6B4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 381086, RefRangeEnd = 381093, XrefRangeStart = 381069, XrefRangeEnd = 381086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x0005F4F8 File Offset: 0x0005D6F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381114, RefRangeEnd = 381115, XrefRangeStart = 381093, XrefRangeEnd = 381114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToSingle(string s, out float result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToSingle_Internal_Static_Exception_String_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x0005F54C File Offset: 0x0005D74C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 381132, RefRangeEnd = 381139, XrefRangeStart = 381115, XrefRangeEnd = 381132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x0005F590 File Offset: 0x0005D790
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381160, RefRangeEnd = 381161, XrefRangeStart = 381139, XrefRangeEnd = 381160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToDouble(string s, out double result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToDouble_Internal_Static_Exception_String_byref_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0005F5E4 File Offset: 0x0005D7E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 381170, RefRangeEnd = 381173, XrefRangeStart = 381161, XrefRangeEnd = 381170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToXPathDouble(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToXPathDouble_Internal_Static_Double_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x0005F628 File Offset: 0x0005D828
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 381175, RefRangeEnd = 381177, XrefRangeStart = 381173, XrefRangeEnd = 381175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan ToTimeSpan(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToTimeSpan_Public_Static_TimeSpan_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x0005F66C File Offset: 0x0005D86C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381180, RefRangeEnd = 381181, XrefRangeStart = 381177, XrefRangeEnd = 381180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToTimeSpan(string s, out TimeSpan result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToTimeSpan_Internal_Static_Exception_String_byref_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x060010AA RID: 4266 RVA: 0x0005F6C0 File Offset: 0x0005D8C0
		public unsafe static Il2CppStringArray AllDateTimeFormats
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381181, XrefRangeEnd = 381193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_get_AllDateTimeFormats_Private_Static_get_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x0005F6F4 File Offset: 0x0005D8F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 381279, RefRangeEnd = 381281, XrefRangeStart = 381193, XrefRangeEnd = 381279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateAllDateTimeFormats()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateAllDateTimeFormats_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x0005F71C File Offset: 0x0005D91C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381304, RefRangeEnd = 381305, XrefRangeStart = 381281, XrefRangeEnd = 381304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ToDateTime(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x0005F760 File Offset: 0x0005D960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381305, XrefRangeEnd = 381313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ToDateTime(string s, Il2CppStringArray formats)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formats);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x0005F7B4 File Offset: 0x0005D9B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 381325, RefRangeEnd = 381327, XrefRangeStart = 381313, XrefRangeEnd = 381325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ToDateTime(string s, XmlDateTimeSerializationMode dateTimeOption)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateTimeOption;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_XmlDateTimeSerializationMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x0005F804 File Offset: 0x0005DA04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381332, RefRangeEnd = 381333, XrefRangeStart = 381327, XrefRangeEnd = 381332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset ToDateTimeOffset(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToDateTimeOffset_Public_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x0005F848 File Offset: 0x0005DA48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 381334, RefRangeEnd = 381336, XrefRangeStart = 381333, XrefRangeEnd = 381334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Guid ToGuid(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToGuid_Public_Static_Guid_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x0005F88C File Offset: 0x0005DA8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381360, RefRangeEnd = 381361, XrefRangeStart = 381336, XrefRangeEnd = 381360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToGuid(string s, out Guid result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToGuid_Internal_Static_Exception_String_byref_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x0005F8E0 File Offset: 0x0005DAE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381365, RefRangeEnd = 381366, XrefRangeStart = 381361, XrefRangeEnd = 381365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime SwitchToLocalTime(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_SwitchToLocalTime_Private_Static_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x0005F920 File Offset: 0x0005DB20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381373, RefRangeEnd = 381374, XrefRangeStart = 381366, XrefRangeEnd = 381373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime SwitchToUtcTime(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_SwitchToUtcTime_Private_Static_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x0005F960 File Offset: 0x0005DB60
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 381389, RefRangeEnd = 381402, XrefRangeStart = 381374, XrefRangeEnd = 381389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Uri ToUri(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_ToUri_Internal_Static_Uri_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x0005F9A4 File Offset: 0x0005DBA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 381432, RefRangeEnd = 381434, XrefRangeStart = 381402, XrefRangeEnd = 381432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryToUri(string s, out Uri result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TryToUri_Internal_Static_Exception_String_byref_Uri_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new Uri(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr5) : null;
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x0005FA0C File Offset: 0x0005DC0C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 381435, RefRangeEnd = 381451, XrefRangeStart = 381434, XrefRangeEnd = 381435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StrEqual(Il2CppStructArray<char> chars, int strPos1, int strLen1, string str2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strPos1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strLen1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_StrEqual_Internal_Static_Boolean_Il2CppStructArray_1_Char_Int32_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x0005FA7C File Offset: 0x0005DC7C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 381457, RefRangeEnd = 381462, XrefRangeStart = 381451, XrefRangeEnd = 381457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TrimString(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TrimString_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x0005FAB8 File Offset: 0x0005DCB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381468, RefRangeEnd = 381469, XrefRangeStart = 381462, XrefRangeEnd = 381468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TrimStringStart(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TrimStringStart_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x0005FAF4 File Offset: 0x0005DCF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381475, RefRangeEnd = 381476, XrefRangeStart = 381469, XrefRangeEnd = 381475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TrimStringEnd(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_TrimStringEnd_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x0005FB30 File Offset: 0x0005DD30
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 381482, RefRangeEnd = 381489, XrefRangeStart = 381476, XrefRangeEnd = 381482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray SplitString(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_SplitString_Internal_Static_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x0005FB74 File Offset: 0x0005DD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381489, XrefRangeEnd = 381492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNegativeZero(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_IsNegativeZero_Internal_Static_Boolean_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x0005FBB4 File Offset: 0x0005DDB4
		[CallerCount(0)]
		public unsafe static long DoubleToInt64Bits(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_DoubleToInt64Bits_Private_Static_Int64_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x0005FBF4 File Offset: 0x0005DDF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381501, RefRangeEnd = 381502, XrefRangeStart = 381492, XrefRangeEnd = 381501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void VerifyCharData(string data, ExceptionType invCharExceptionType, ExceptionType invSurrogateExceptionType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invCharExceptionType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invSurrogateExceptionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_VerifyCharData_Internal_Static_Void_String_ExceptionType_ExceptionType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x0005FC48 File Offset: 0x0005DE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381502, XrefRangeEnd = 381513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateException(string res, ExceptionType exceptionType, int lineNo, int linePos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptionType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_ExceptionType_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x0005FCB8 File Offset: 0x0005DEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381513, XrefRangeEnd = 381528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateException(string res, string arg, ExceptionType exceptionType, int lineNo, int linePos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptionType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_String_ExceptionType_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x0005FD38 File Offset: 0x0005DF38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381528, XrefRangeEnd = 381532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateException(string res, Il2CppStringArray args, ExceptionType exceptionType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_Il2CppStringArray_ExceptionType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x0005FD9C File Offset: 0x0005DF9C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 381542, RefRangeEnd = 381547, XrefRangeStart = 381532, XrefRangeEnd = 381542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateException(string res, Il2CppStringArray args, ExceptionType exceptionType, int lineNo, int linePos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptionType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_Il2CppStringArray_ExceptionType_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x0005FE1C File Offset: 0x0005E01C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381554, RefRangeEnd = 381555, XrefRangeStart = 381547, XrefRangeEnd = 381554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateInvalidSurrogatePairException(char low, char hi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref low;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateInvalidSurrogatePairException_Internal_Static_Exception_Char_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x0005FE6C File Offset: 0x0005E06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381555, XrefRangeEnd = 381559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref low;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateInvalidSurrogatePairException_Internal_Static_Exception_Char_Char_ExceptionType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x0005FEC8 File Offset: 0x0005E0C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 381580, RefRangeEnd = 381582, XrefRangeStart = 381559, XrefRangeEnd = 381580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType, int lineNo, int linePos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref low;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptionType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateInvalidSurrogatePairException_Internal_Static_Exception_Char_Char_ExceptionType_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x0005FF40 File Offset: 0x0005E140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381582, XrefRangeEnd = 381586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateInvalidHighSurrogateCharException(char hi)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hi;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateInvalidHighSurrogateCharException_Internal_Static_Exception_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x0005FF80 File Offset: 0x0005E180
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 381616, RefRangeEnd = 381617, XrefRangeStart = 381586, XrefRangeEnd = 381616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hi;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateInvalidHighSurrogateCharException_Internal_Static_Exception_Char_ExceptionType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x0005FFD0 File Offset: 0x0005E1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381617, XrefRangeEnd = 381644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType, int lineNo, int linePos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hi;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptionType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateInvalidHighSurrogateCharException_Internal_Static_Exception_Char_ExceptionType_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x0006003C File Offset: 0x0005E23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381644, XrefRangeEnd = 381654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateInvalidCharException(string data, int invCharPos, ExceptionType exceptionType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invCharPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateInvalidCharException_Internal_Static_Exception_String_Int32_ExceptionType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x0006009C File Offset: 0x0005E29C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381654, XrefRangeEnd = 381672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateInvalidCharException(char invChar, char nextChar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref invChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateInvalidCharException_Internal_Static_Exception_Char_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x000600EC File Offset: 0x0005E2EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381672, XrefRangeEnd = 381682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateInvalidCharException(char invChar, char nextChar, ExceptionType exceptionType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref invChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextChar;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateInvalidCharException_Internal_Static_Exception_Char_Char_ExceptionType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x00060148 File Offset: 0x0005E348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381682, XrefRangeEnd = 381694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateInvalidNameCharException(string name, int index, ExceptionType exceptionType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateInvalidNameCharException_Internal_Static_Exception_String_Int32_ExceptionType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x000601A8 File Offset: 0x0005E3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381694, XrefRangeEnd = 381700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArgumentException CreateInvalidNameArgumentException(string name, string argumentName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(argumentName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlConvert.NativeMethodInfoPtr_CreateInvalidNameArgumentException_Internal_Static_ArgumentException_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArgumentException>(intPtr3) : null;
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x000074ED File Offset: 0x000056ED
		public XmlConvert(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x060010CE RID: 4302 RVA: 0x00060200 File Offset: 0x0005E400
		// (set) Token: 0x060010CF RID: 4303 RVA: 0x000074F6 File Offset: 0x000056F6
		public unsafe static XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(XmlConvert.NativeFieldInfoPtr_xmlCharType, intPtr);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlConvert.NativeFieldInfoPtr_xmlCharType, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x060010D0 RID: 4304 RVA: 0x0006023C File Offset: 0x0005E43C
		// (set) Token: 0x060010D1 RID: 4305 RVA: 0x0000750D File Offset: 0x0000570D
		public unsafe static Il2CppStructArray<char> crt
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlConvert.NativeFieldInfoPtr_crt, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlConvert.NativeFieldInfoPtr_crt, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x060010D2 RID: 4306 RVA: 0x00060264 File Offset: 0x0005E464
		// (set) Token: 0x060010D3 RID: 4307 RVA: 0x0000751F File Offset: 0x0000571F
		public unsafe static int c_EncodedCharLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XmlConvert.NativeFieldInfoPtr_c_EncodedCharLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlConvert.NativeFieldInfoPtr_c_EncodedCharLength, (void*)(&value));
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x060010D4 RID: 4308 RVA: 0x00060280 File Offset: 0x0005E480
		// (set) Token: 0x060010D5 RID: 4309 RVA: 0x0000752D File Offset: 0x0000572D
		public unsafe static Regex c_EncodeCharPattern
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlConvert.NativeFieldInfoPtr_c_EncodeCharPattern, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlConvert.NativeFieldInfoPtr_c_EncodeCharPattern, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x060010D6 RID: 4310 RVA: 0x000602A8 File Offset: 0x0005E4A8
		// (set) Token: 0x060010D7 RID: 4311 RVA: 0x0000753F File Offset: 0x0000573F
		public unsafe static Regex c_DecodeCharPattern
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlConvert.NativeFieldInfoPtr_c_DecodeCharPattern, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlConvert.NativeFieldInfoPtr_c_DecodeCharPattern, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x060010D8 RID: 4312 RVA: 0x000602D0 File Offset: 0x0005E4D0
		// (set) Token: 0x060010D9 RID: 4313 RVA: 0x00007551 File Offset: 0x00005751
		public unsafe static Il2CppStringArray s_allDateTimeFormats
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlConvert.NativeFieldInfoPtr_s_allDateTimeFormats, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlConvert.NativeFieldInfoPtr_s_allDateTimeFormats, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x060010DA RID: 4314 RVA: 0x000602F8 File Offset: 0x0005E4F8
		// (set) Token: 0x060010DB RID: 4315 RVA: 0x00007563 File Offset: 0x00005763
		public unsafe static Il2CppStructArray<char> WhitespaceChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlConvert.NativeFieldInfoPtr_WhitespaceChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlConvert.NativeFieldInfoPtr_WhitespaceChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D61 RID: 3425
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x04000D62 RID: 3426
		private static readonly IntPtr NativeFieldInfoPtr_crt;

		// Token: 0x04000D63 RID: 3427
		private static readonly IntPtr NativeFieldInfoPtr_c_EncodedCharLength;

		// Token: 0x04000D64 RID: 3428
		private static readonly IntPtr NativeFieldInfoPtr_c_EncodeCharPattern;

		// Token: 0x04000D65 RID: 3429
		private static readonly IntPtr NativeFieldInfoPtr_c_DecodeCharPattern;

		// Token: 0x04000D66 RID: 3430
		private static readonly IntPtr NativeFieldInfoPtr_s_allDateTimeFormats;

		// Token: 0x04000D67 RID: 3431
		private static readonly IntPtr NativeFieldInfoPtr_WhitespaceChars;

		// Token: 0x04000D68 RID: 3432
		private static readonly IntPtr NativeMethodInfoPtr_EncodeName_Public_Static_String_String_0;

		// Token: 0x04000D69 RID: 3433
		private static readonly IntPtr NativeMethodInfoPtr_EncodeLocalName_Public_Static_String_String_0;

		// Token: 0x04000D6A RID: 3434
		private static readonly IntPtr NativeMethodInfoPtr_DecodeName_Public_Static_String_String_0;

		// Token: 0x04000D6B RID: 3435
		private static readonly IntPtr NativeMethodInfoPtr_EncodeName_Private_Static_String_String_Boolean_Boolean_0;

		// Token: 0x04000D6C RID: 3436
		private static readonly IntPtr NativeMethodInfoPtr_FromHex_Private_Static_Int32_Char_0;

		// Token: 0x04000D6D RID: 3437
		private static readonly IntPtr NativeMethodInfoPtr_FromBinHexString_Internal_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04000D6E RID: 3438
		private static readonly IntPtr NativeMethodInfoPtr_FromBinHexString_Internal_Static_Il2CppStructArray_1_Byte_String_Boolean_0;

		// Token: 0x04000D6F RID: 3439
		private static readonly IntPtr NativeMethodInfoPtr_ToBinHexString_Internal_Static_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000D70 RID: 3440
		private static readonly IntPtr NativeMethodInfoPtr_VerifyName_Public_Static_String_String_0;

		// Token: 0x04000D71 RID: 3441
		private static readonly IntPtr NativeMethodInfoPtr_TryVerifyName_Internal_Static_Exception_String_0;

		// Token: 0x04000D72 RID: 3442
		private static readonly IntPtr NativeMethodInfoPtr_VerifyQName_Internal_Static_String_String_ExceptionType_0;

		// Token: 0x04000D73 RID: 3443
		private static readonly IntPtr NativeMethodInfoPtr_VerifyNCName_Public_Static_String_String_0;

		// Token: 0x04000D74 RID: 3444
		private static readonly IntPtr NativeMethodInfoPtr_VerifyNCName_Internal_Static_String_String_ExceptionType_0;

		// Token: 0x04000D75 RID: 3445
		private static readonly IntPtr NativeMethodInfoPtr_TryVerifyNCName_Internal_Static_Exception_String_0;

		// Token: 0x04000D76 RID: 3446
		private static readonly IntPtr NativeMethodInfoPtr_VerifyTOKEN_Public_Static_String_String_0;

		// Token: 0x04000D77 RID: 3447
		private static readonly IntPtr NativeMethodInfoPtr_TryVerifyTOKEN_Internal_Static_Exception_String_0;

		// Token: 0x04000D78 RID: 3448
		private static readonly IntPtr NativeMethodInfoPtr_TryVerifyNMTOKEN_Internal_Static_Exception_String_0;

		// Token: 0x04000D79 RID: 3449
		private static readonly IntPtr NativeMethodInfoPtr_TryVerifyNormalizedString_Internal_Static_Exception_String_0;

		// Token: 0x04000D7A RID: 3450
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Boolean_0;

		// Token: 0x04000D7B RID: 3451
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Char_0;

		// Token: 0x04000D7C RID: 3452
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Decimal_0;

		// Token: 0x04000D7D RID: 3453
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_SByte_0;

		// Token: 0x04000D7E RID: 3454
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int16_0;

		// Token: 0x04000D7F RID: 3455
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int32_0;

		// Token: 0x04000D80 RID: 3456
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int64_0;

		// Token: 0x04000D81 RID: 3457
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Byte_0;

		// Token: 0x04000D82 RID: 3458
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_UInt16_0;

		// Token: 0x04000D83 RID: 3459
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_UInt32_0;

		// Token: 0x04000D84 RID: 3460
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_UInt64_0;

		// Token: 0x04000D85 RID: 3461
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Single_0;

		// Token: 0x04000D86 RID: 3462
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Double_0;

		// Token: 0x04000D87 RID: 3463
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_TimeSpan_0;

		// Token: 0x04000D88 RID: 3464
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_DateTime_String_0;

		// Token: 0x04000D89 RID: 3465
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_DateTime_XmlDateTimeSerializationMode_0;

		// Token: 0x04000D8A RID: 3466
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_DateTimeOffset_0;

		// Token: 0x04000D8B RID: 3467
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Guid_0;

		// Token: 0x04000D8C RID: 3468
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_0;

		// Token: 0x04000D8D RID: 3469
		private static readonly IntPtr NativeMethodInfoPtr_TryToBoolean_Internal_Static_Exception_String_byref_Boolean_0;

		// Token: 0x04000D8E RID: 3470
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_String_0;

		// Token: 0x04000D8F RID: 3471
		private static readonly IntPtr NativeMethodInfoPtr_TryToChar_Internal_Static_Exception_String_byref_Char_0;

		// Token: 0x04000D90 RID: 3472
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_String_0;

		// Token: 0x04000D91 RID: 3473
		private static readonly IntPtr NativeMethodInfoPtr_TryToDecimal_Internal_Static_Exception_String_byref_Decimal_0;

		// Token: 0x04000D92 RID: 3474
		private static readonly IntPtr NativeMethodInfoPtr_ToInteger_Internal_Static_Decimal_String_0;

		// Token: 0x04000D93 RID: 3475
		private static readonly IntPtr NativeMethodInfoPtr_TryToInteger_Internal_Static_Exception_String_byref_Decimal_0;

		// Token: 0x04000D94 RID: 3476
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_String_0;

		// Token: 0x04000D95 RID: 3477
		private static readonly IntPtr NativeMethodInfoPtr_TryToSByte_Internal_Static_Exception_String_byref_SByte_0;

		// Token: 0x04000D96 RID: 3478
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_String_0;

		// Token: 0x04000D97 RID: 3479
		private static readonly IntPtr NativeMethodInfoPtr_TryToInt16_Internal_Static_Exception_String_byref_Int16_0;

		// Token: 0x04000D98 RID: 3480
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_0;

		// Token: 0x04000D99 RID: 3481
		private static readonly IntPtr NativeMethodInfoPtr_TryToInt32_Internal_Static_Exception_String_byref_Int32_0;

		// Token: 0x04000D9A RID: 3482
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_0;

		// Token: 0x04000D9B RID: 3483
		private static readonly IntPtr NativeMethodInfoPtr_TryToInt64_Internal_Static_Exception_String_byref_Int64_0;

		// Token: 0x04000D9C RID: 3484
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_0;

		// Token: 0x04000D9D RID: 3485
		private static readonly IntPtr NativeMethodInfoPtr_TryToByte_Internal_Static_Exception_String_byref_Byte_0;

		// Token: 0x04000D9E RID: 3486
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_String_0;

		// Token: 0x04000D9F RID: 3487
		private static readonly IntPtr NativeMethodInfoPtr_TryToUInt16_Internal_Static_Exception_String_byref_UInt16_0;

		// Token: 0x04000DA0 RID: 3488
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_String_0;

		// Token: 0x04000DA1 RID: 3489
		private static readonly IntPtr NativeMethodInfoPtr_TryToUInt32_Internal_Static_Exception_String_byref_UInt32_0;

		// Token: 0x04000DA2 RID: 3490
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_String_0;

		// Token: 0x04000DA3 RID: 3491
		private static readonly IntPtr NativeMethodInfoPtr_TryToUInt64_Internal_Static_Exception_String_byref_UInt64_0;

		// Token: 0x04000DA4 RID: 3492
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_String_0;

		// Token: 0x04000DA5 RID: 3493
		private static readonly IntPtr NativeMethodInfoPtr_TryToSingle_Internal_Static_Exception_String_byref_Single_0;

		// Token: 0x04000DA6 RID: 3494
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_String_0;

		// Token: 0x04000DA7 RID: 3495
		private static readonly IntPtr NativeMethodInfoPtr_TryToDouble_Internal_Static_Exception_String_byref_Double_0;

		// Token: 0x04000DA8 RID: 3496
		private static readonly IntPtr NativeMethodInfoPtr_ToXPathDouble_Internal_Static_Double_Object_0;

		// Token: 0x04000DA9 RID: 3497
		private static readonly IntPtr NativeMethodInfoPtr_ToTimeSpan_Public_Static_TimeSpan_String_0;

		// Token: 0x04000DAA RID: 3498
		private static readonly IntPtr NativeMethodInfoPtr_TryToTimeSpan_Internal_Static_Exception_String_byref_TimeSpan_0;

		// Token: 0x04000DAB RID: 3499
		private static readonly IntPtr NativeMethodInfoPtr_get_AllDateTimeFormats_Private_Static_get_Il2CppStringArray_0;

		// Token: 0x04000DAC RID: 3500
		private static readonly IntPtr NativeMethodInfoPtr_CreateAllDateTimeFormats_Private_Static_Void_0;

		// Token: 0x04000DAD RID: 3501
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_0;

		// Token: 0x04000DAE RID: 3502
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_Il2CppStringArray_0;

		// Token: 0x04000DAF RID: 3503
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_XmlDateTimeSerializationMode_0;

		// Token: 0x04000DB0 RID: 3504
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTimeOffset_Public_Static_DateTimeOffset_String_0;

		// Token: 0x04000DB1 RID: 3505
		private static readonly IntPtr NativeMethodInfoPtr_ToGuid_Public_Static_Guid_String_0;

		// Token: 0x04000DB2 RID: 3506
		private static readonly IntPtr NativeMethodInfoPtr_TryToGuid_Internal_Static_Exception_String_byref_Guid_0;

		// Token: 0x04000DB3 RID: 3507
		private static readonly IntPtr NativeMethodInfoPtr_SwitchToLocalTime_Private_Static_DateTime_DateTime_0;

		// Token: 0x04000DB4 RID: 3508
		private static readonly IntPtr NativeMethodInfoPtr_SwitchToUtcTime_Private_Static_DateTime_DateTime_0;

		// Token: 0x04000DB5 RID: 3509
		private static readonly IntPtr NativeMethodInfoPtr_ToUri_Internal_Static_Uri_String_0;

		// Token: 0x04000DB6 RID: 3510
		private static readonly IntPtr NativeMethodInfoPtr_TryToUri_Internal_Static_Exception_String_byref_Uri_0;

		// Token: 0x04000DB7 RID: 3511
		private static readonly IntPtr NativeMethodInfoPtr_StrEqual_Internal_Static_Boolean_Il2CppStructArray_1_Char_Int32_Int32_String_0;

		// Token: 0x04000DB8 RID: 3512
		private static readonly IntPtr NativeMethodInfoPtr_TrimString_Internal_Static_String_String_0;

		// Token: 0x04000DB9 RID: 3513
		private static readonly IntPtr NativeMethodInfoPtr_TrimStringStart_Internal_Static_String_String_0;

		// Token: 0x04000DBA RID: 3514
		private static readonly IntPtr NativeMethodInfoPtr_TrimStringEnd_Internal_Static_String_String_0;

		// Token: 0x04000DBB RID: 3515
		private static readonly IntPtr NativeMethodInfoPtr_SplitString_Internal_Static_Il2CppStringArray_String_0;

		// Token: 0x04000DBC RID: 3516
		private static readonly IntPtr NativeMethodInfoPtr_IsNegativeZero_Internal_Static_Boolean_Double_0;

		// Token: 0x04000DBD RID: 3517
		private static readonly IntPtr NativeMethodInfoPtr_DoubleToInt64Bits_Private_Static_Int64_Double_0;

		// Token: 0x04000DBE RID: 3518
		private static readonly IntPtr NativeMethodInfoPtr_VerifyCharData_Internal_Static_Void_String_ExceptionType_ExceptionType_0;

		// Token: 0x04000DBF RID: 3519
		private static readonly IntPtr NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_ExceptionType_Int32_Int32_0;

		// Token: 0x04000DC0 RID: 3520
		private static readonly IntPtr NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_String_ExceptionType_Int32_Int32_0;

		// Token: 0x04000DC1 RID: 3521
		private static readonly IntPtr NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_Il2CppStringArray_ExceptionType_0;

		// Token: 0x04000DC2 RID: 3522
		private static readonly IntPtr NativeMethodInfoPtr_CreateException_Internal_Static_Exception_String_Il2CppStringArray_ExceptionType_Int32_Int32_0;

		// Token: 0x04000DC3 RID: 3523
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidSurrogatePairException_Internal_Static_Exception_Char_Char_0;

		// Token: 0x04000DC4 RID: 3524
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidSurrogatePairException_Internal_Static_Exception_Char_Char_ExceptionType_0;

		// Token: 0x04000DC5 RID: 3525
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidSurrogatePairException_Internal_Static_Exception_Char_Char_ExceptionType_Int32_Int32_0;

		// Token: 0x04000DC6 RID: 3526
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidHighSurrogateCharException_Internal_Static_Exception_Char_0;

		// Token: 0x04000DC7 RID: 3527
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidHighSurrogateCharException_Internal_Static_Exception_Char_ExceptionType_0;

		// Token: 0x04000DC8 RID: 3528
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidHighSurrogateCharException_Internal_Static_Exception_Char_ExceptionType_Int32_Int32_0;

		// Token: 0x04000DC9 RID: 3529
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidCharException_Internal_Static_Exception_String_Int32_ExceptionType_0;

		// Token: 0x04000DCA RID: 3530
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidCharException_Internal_Static_Exception_Char_Char_0;

		// Token: 0x04000DCB RID: 3531
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidCharException_Internal_Static_Exception_Char_Char_ExceptionType_0;

		// Token: 0x04000DCC RID: 3532
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidNameCharException_Internal_Static_Exception_String_Int32_ExceptionType_0;

		// Token: 0x04000DCD RID: 3533
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidNameArgumentException_Internal_Static_ArgumentException_String_String_0;
	}
}

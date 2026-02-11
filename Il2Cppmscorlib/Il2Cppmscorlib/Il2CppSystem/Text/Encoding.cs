using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Text
{
	// Token: 0x02000215 RID: 533
	[Serializable]
	public class Encoding : Object
	{
		// Token: 0x060022D4 RID: 8916 RVA: 0x000C56FC File Offset: 0x000C38FC
		// Note: this type is marked as 'beforefieldinit'.
		static Encoding()
		{
			Il2CppClassPointerStore<Encoding>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "Encoding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Encoding>.NativeClassPtr);
			Encoding.NativeFieldInfoPtr_defaultEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "defaultEncoding");
			Encoding.NativeFieldInfoPtr_unicodeEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "unicodeEncoding");
			Encoding.NativeFieldInfoPtr_bigEndianUnicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "bigEndianUnicode");
			Encoding.NativeFieldInfoPtr_utf7Encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "utf7Encoding");
			Encoding.NativeFieldInfoPtr_utf8Encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "utf8Encoding");
			Encoding.NativeFieldInfoPtr_utf32Encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "utf32Encoding");
			Encoding.NativeFieldInfoPtr_asciiEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "asciiEncoding");
			Encoding.NativeFieldInfoPtr_latin1Encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "latin1Encoding");
			Encoding.NativeFieldInfoPtr_encodings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "encodings");
			Encoding.NativeFieldInfoPtr_MIMECONTF_MAILNEWS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "MIMECONTF_MAILNEWS");
			Encoding.NativeFieldInfoPtr_MIMECONTF_BROWSER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "MIMECONTF_BROWSER");
			Encoding.NativeFieldInfoPtr_MIMECONTF_SAVABLE_MAILNEWS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "MIMECONTF_SAVABLE_MAILNEWS");
			Encoding.NativeFieldInfoPtr_MIMECONTF_SAVABLE_BROWSER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "MIMECONTF_SAVABLE_BROWSER");
			Encoding.NativeFieldInfoPtr_CodePageDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "CodePageDefault");
			Encoding.NativeFieldInfoPtr_CodePageNoOEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "CodePageNoOEM");
			Encoding.NativeFieldInfoPtr_CodePageNoMac = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "CodePageNoMac");
			Encoding.NativeFieldInfoPtr_CodePageNoThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "CodePageNoThread");
			Encoding.NativeFieldInfoPtr_CodePageNoSymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "CodePageNoSymbol");
			Encoding.NativeFieldInfoPtr_CodePageUnicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "CodePageUnicode");
			Encoding.NativeFieldInfoPtr_CodePageBigEndian = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "CodePageBigEndian");
			Encoding.NativeFieldInfoPtr_CodePageWindows1252 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "CodePageWindows1252");
			Encoding.NativeFieldInfoPtr_CodePageMacGB2312 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "CodePageMacGB2312");
			Encoding.NativeFieldInfoPtr_CodePageGB2312 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "CodePageGB2312");
			Encoding.NativeFieldInfoPtr_CodePageMacKorean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "CodePageMacKorean");
			Encoding.NativeFieldInfoPtr_CodePageDLLKorean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "CodePageDLLKorean");
			Encoding.NativeFieldInfoPtr_ISO2022JP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "ISO2022JP");
			Encoding.NativeFieldInfoPtr_ISO2022JPESC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "ISO2022JPESC");
			Encoding.NativeFieldInfoPtr_ISO2022JPSISO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "ISO2022JPSISO");
			Encoding.NativeFieldInfoPtr_ISOKorean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "ISOKorean");
			Encoding.NativeFieldInfoPtr_ISOSimplifiedCN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "ISOSimplifiedCN");
			Encoding.NativeFieldInfoPtr_EUCJP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "EUCJP");
			Encoding.NativeFieldInfoPtr_ChineseHZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "ChineseHZ");
			Encoding.NativeFieldInfoPtr_DuplicateEUCCN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "DuplicateEUCCN");
			Encoding.NativeFieldInfoPtr_EUCCN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "EUCCN");
			Encoding.NativeFieldInfoPtr_EUCKR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "EUCKR");
			Encoding.NativeFieldInfoPtr_CodePageASCII = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "CodePageASCII");
			Encoding.NativeFieldInfoPtr_ISO_8859_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "ISO_8859_1");
			Encoding.NativeFieldInfoPtr_ISCIIAssemese = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "ISCIIAssemese");
			Encoding.NativeFieldInfoPtr_ISCIIBengali = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "ISCIIBengali");
			Encoding.NativeFieldInfoPtr_ISCIIDevanagari = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "ISCIIDevanagari");
			Encoding.NativeFieldInfoPtr_ISCIIGujarathi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "ISCIIGujarathi");
			Encoding.NativeFieldInfoPtr_ISCIIKannada = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "ISCIIKannada");
			Encoding.NativeFieldInfoPtr_ISCIIMalayalam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "ISCIIMalayalam");
			Encoding.NativeFieldInfoPtr_ISCIIOriya = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "ISCIIOriya");
			Encoding.NativeFieldInfoPtr_ISCIIPanjabi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "ISCIIPanjabi");
			Encoding.NativeFieldInfoPtr_ISCIITamil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "ISCIITamil");
			Encoding.NativeFieldInfoPtr_ISCIITelugu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "ISCIITelugu");
			Encoding.NativeFieldInfoPtr_GB18030 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "GB18030");
			Encoding.NativeFieldInfoPtr_ISO_8859_8I = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "ISO_8859_8I");
			Encoding.NativeFieldInfoPtr_ISO_8859_8_Visual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "ISO_8859_8_Visual");
			Encoding.NativeFieldInfoPtr_ENC50229 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "ENC50229");
			Encoding.NativeFieldInfoPtr_CodePageUTF7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "CodePageUTF7");
			Encoding.NativeFieldInfoPtr_CodePageUTF8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "CodePageUTF8");
			Encoding.NativeFieldInfoPtr_CodePageUTF32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "CodePageUTF32");
			Encoding.NativeFieldInfoPtr_CodePageUTF32BE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "CodePageUTF32BE");
			Encoding.NativeFieldInfoPtr_m_codePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "m_codePage");
			Encoding.NativeFieldInfoPtr_dataItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "dataItem");
			Encoding.NativeFieldInfoPtr_m_deserializedFromEverett = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "m_deserializedFromEverett");
			Encoding.NativeFieldInfoPtr_m_isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "m_isReadOnly");
			Encoding.NativeFieldInfoPtr_encoderFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "encoderFallback");
			Encoding.NativeFieldInfoPtr_decoderFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "decoderFallback");
			Encoding.NativeFieldInfoPtr_s_InternalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "s_InternalSyncObject");
			Encoding.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669209);
			Encoding.NativeMethodInfoPtr__ctor_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669210);
			Encoding.NativeMethodInfoPtr_SetDefaultFallbacks_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669211);
			Encoding.NativeMethodInfoPtr_OnDeserializing_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669212);
			Encoding.NativeMethodInfoPtr_OnDeserialized_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669213);
			Encoding.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669214);
			Encoding.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669215);
			Encoding.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669216);
			Encoding.NativeMethodInfoPtr_DeserializeEncoding_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669217);
			Encoding.NativeMethodInfoPtr_SerializeEncoding_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669218);
			Encoding.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669219);
			Encoding.NativeMethodInfoPtr_GetEncoding_Public_Static_Encoding_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669220);
			Encoding.NativeMethodInfoPtr_GetEncoding_Public_Static_Encoding_Int32_EncoderFallback_DecoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669221);
			Encoding.NativeMethodInfoPtr_GetEncoding_Public_Static_Encoding_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669222);
			Encoding.NativeMethodInfoPtr_GetPreamble_Public_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669223);
			Encoding.NativeMethodInfoPtr_get_Preamble_Public_Virtual_New_get_ReadOnlySpan_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669224);
			Encoding.NativeMethodInfoPtr_GetDataItem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669225);
			Encoding.NativeMethodInfoPtr_get_EncodingName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669226);
			Encoding.NativeMethodInfoPtr_get_HeaderName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669227);
			Encoding.NativeMethodInfoPtr_get_WebName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669228);
			Encoding.NativeMethodInfoPtr_get_EncoderFallback_Public_get_EncoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669229);
			Encoding.NativeMethodInfoPtr_set_EncoderFallback_Public_set_Void_EncoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669230);
			Encoding.NativeMethodInfoPtr_get_DecoderFallback_Public_get_DecoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669231);
			Encoding.NativeMethodInfoPtr_set_DecoderFallback_Public_set_Void_DecoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669232);
			Encoding.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669233);
			Encoding.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669234);
			Encoding.NativeMethodInfoPtr_get_ASCII_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669235);
			Encoding.NativeMethodInfoPtr_get_Latin1_Private_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669236);
			Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669237);
			Encoding.NativeMethodInfoPtr_GetByteCount_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669238);
			Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_New_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669239);
			Encoding.NativeMethodInfoPtr_GetByteCount_Internal_Virtual_New_Int32_ptr_Char_Int32_EncoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669240);
			Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669241);
			Encoding.NativeMethodInfoPtr_GetBytes_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669242);
			Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669243);
			Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Int32_String_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669244);
			Encoding.NativeMethodInfoPtr_GetBytes_Internal_Virtual_New_Int32_ptr_Char_Int32_ptr_Byte_Int32_EncoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669245);
			Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Int32_ptr_Char_Int32_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669246);
			Encoding.NativeMethodInfoPtr_GetCharCount_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669247);
			Encoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_New_Int32_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669248);
			Encoding.NativeMethodInfoPtr_GetCharCount_Internal_Virtual_New_Int32_ptr_Byte_Int32_DecoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669249);
			Encoding.NativeMethodInfoPtr_GetChars_Public_Virtual_New_Il2CppStructArray_1_Char_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669250);
			Encoding.NativeMethodInfoPtr_GetChars_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669251);
			Encoding.NativeMethodInfoPtr_GetChars_Public_Virtual_New_Int32_ptr_Byte_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669252);
			Encoding.NativeMethodInfoPtr_GetChars_Internal_Virtual_New_Int32_ptr_Byte_Int32_ptr_Char_Int32_DecoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669253);
			Encoding.NativeMethodInfoPtr_GetString_Public_String_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669254);
			Encoding.NativeMethodInfoPtr_GetString_Public_String_ReadOnlySpan_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669255);
			Encoding.NativeMethodInfoPtr_get_CodePage_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669256);
			Encoding.NativeMethodInfoPtr_GetDecoder_Public_Virtual_New_Decoder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669257);
			Encoding.NativeMethodInfoPtr_CreateDefaultEncoding_Private_Static_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669258);
			Encoding.NativeMethodInfoPtr_setReadOnly_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669259);
			Encoding.NativeMethodInfoPtr_get_Default_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669260);
			Encoding.NativeMethodInfoPtr_GetEncoder_Public_Virtual_New_Encoder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669261);
			Encoding.NativeMethodInfoPtr_GetMaxByteCount_Public_Abstract_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669262);
			Encoding.NativeMethodInfoPtr_GetMaxCharCount_Public_Abstract_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669263);
			Encoding.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669264);
			Encoding.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669265);
			Encoding.NativeMethodInfoPtr_get_Unicode_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669266);
			Encoding.NativeMethodInfoPtr_get_BigEndianUnicode_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669267);
			Encoding.NativeMethodInfoPtr_get_UTF7_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669268);
			Encoding.NativeMethodInfoPtr_get_UTF8_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669269);
			Encoding.NativeMethodInfoPtr_get_UTF32_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669270);
			Encoding.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669271);
			Encoding.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669272);
			Encoding.NativeMethodInfoPtr_GetBestFitUnicodeToBytesData_Internal_Virtual_New_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669273);
			Encoding.NativeMethodInfoPtr_GetBestFitBytesToUnicodeData_Internal_Virtual_New_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669274);
			Encoding.NativeMethodInfoPtr_ThrowBytesOverflow_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669275);
			Encoding.NativeMethodInfoPtr_ThrowBytesOverflow_Internal_Void_EncoderNLS_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669276);
			Encoding.NativeMethodInfoPtr_ThrowCharsOverflow_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669277);
			Encoding.NativeMethodInfoPtr_ThrowCharsOverflow_Internal_Void_DecoderNLS_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100669278);
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x000C617C File Offset: 0x000C437C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1368046, RefRangeEnd = 1368055, XrefRangeStart = 1368045, XrefRangeEnd = 1368046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Encoding()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Encoding>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x000C61B8 File Offset: 0x000C43B8
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1368062, RefRangeEnd = 1368088, XrefRangeStart = 1368055, XrefRangeEnd = 1368062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Encoding(int codePage)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Encoding>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codePage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr__ctor_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x000C6200 File Offset: 0x000C4400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368088, XrefRangeEnd = 1368098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetDefaultFallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_SetDefaultFallbacks_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x000C623C File Offset: 0x000C443C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368098, XrefRangeEnd = 1368100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserializing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_OnDeserializing_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x000C6270 File Offset: 0x000C4470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368100, XrefRangeEnd = 1368101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_OnDeserialized_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x000C62A4 File Offset: 0x000C44A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x000C62EC File Offset: 0x000C44EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x000C6334 File Offset: 0x000C4534
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342312, RefRangeEnd = 342313, XrefRangeStart = 342312, XrefRangeEnd = 342313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSerializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022DD RID: 8925 RVA: 0x000C637C File Offset: 0x000C457C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1368148, RefRangeEnd = 1368149, XrefRangeStart = 1368101, XrefRangeEnd = 1368148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeserializeEncoding(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_DeserializeEncoding_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x000C63D8 File Offset: 0x000C45D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1368176, RefRangeEnd = 1368177, XrefRangeStart = 1368149, XrefRangeEnd = 1368176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SerializeEncoding(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_SerializeEncoding_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x060022DF RID: 8927 RVA: 0x000C6434 File Offset: 0x000C4634
		public unsafe static Object InternalSyncObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368177, XrefRangeEnd = 1368186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x000C6468 File Offset: 0x000C4668
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1368324, RefRangeEnd = 1368330, XrefRangeStart = 1368186, XrefRangeEnd = 1368324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Encoding GetEncoding(int codepage)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codepage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_GetEncoding_Public_Static_Encoding_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x000C64A8 File Offset: 0x000C46A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1368339, RefRangeEnd = 1368340, XrefRangeStart = 1368330, XrefRangeEnd = 1368339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codepage;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoderFallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decoderFallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_GetEncoding_Public_Static_Encoding_Int32_EncoderFallback_DecoderFallback_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x000C650C File Offset: 0x000C470C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1368349, RefRangeEnd = 1368358, XrefRangeStart = 1368340, XrefRangeEnd = 1368349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Encoding GetEncoding(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_GetEncoding_Public_Static_Encoding_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x000C6550 File Offset: 0x000C4750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368358, XrefRangeEnd = 1368362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> GetPreamble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetPreamble_Public_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x060022E4 RID: 8932 RVA: 0x000C659C File Offset: 0x000C479C
		public unsafe virtual ReadOnlySpan<byte> Preamble
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368362, XrefRangeEnd = 1368365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_get_Preamble_Public_Virtual_New_get_ReadOnlySpan_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ReadOnlySpan<byte>(intPtr);
			}
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x000C65E0 File Offset: 0x000C47E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1368370, RefRangeEnd = 1368372, XrefRangeStart = 1368365, XrefRangeEnd = 1368370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetDataItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_GetDataItem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x060022E6 RID: 8934 RVA: 0x000C6614 File Offset: 0x000C4814
		public unsafe virtual string EncodingName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368372, XrefRangeEnd = 1368373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_get_EncodingName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x060022E7 RID: 8935 RVA: 0x000C6658 File Offset: 0x000C4858
		public unsafe virtual string HeaderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368373, XrefRangeEnd = 1368376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_get_HeaderName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x060022E8 RID: 8936 RVA: 0x000C669C File Offset: 0x000C489C
		public unsafe virtual string WebName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368376, XrefRangeEnd = 1368379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_get_WebName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x060022E9 RID: 8937 RVA: 0x000C66E0 File Offset: 0x000C48E0
		// (set) Token: 0x060022EA RID: 8938 RVA: 0x000C6720 File Offset: 0x000C4920
		public unsafe EncoderFallback EncoderFallback
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_EncoderFallback_Public_get_EncoderFallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EncoderFallback>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1368393, RefRangeEnd = 1368397, XrefRangeStart = 1368379, XrefRangeEnd = 1368393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_set_EncoderFallback_Public_set_Void_EncoderFallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x060022EB RID: 8939 RVA: 0x000C6764 File Offset: 0x000C4964
		// (set) Token: 0x060022EC RID: 8940 RVA: 0x000C67A4 File Offset: 0x000C49A4
		public unsafe DecoderFallback DecoderFallback
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_DecoderFallback_Public_get_DecoderFallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DecoderFallback>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1368411, RefRangeEnd = 1368414, XrefRangeStart = 1368397, XrefRangeEnd = 1368411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_set_DecoderFallback_Public_set_Void_DecoderFallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x000C67E8 File Offset: 0x000C49E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368414, XrefRangeEnd = 1368417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x060022EE RID: 8942 RVA: 0x000C6834 File Offset: 0x000C4A34
		public unsafe bool IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x060022EF RID: 8943 RVA: 0x000C6870 File Offset: 0x000C4A70
		public unsafe static Encoding ASCII
		{
			[CallerCount(69)]
			[CachedScanResults(RefRangeStart = 1368430, RefRangeEnd = 1368499, XrefRangeStart = 1368417, XrefRangeEnd = 1368430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_ASCII_Public_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x060022F0 RID: 8944 RVA: 0x000C68A4 File Offset: 0x000C4AA4
		public unsafe static Encoding Latin1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368499, XrefRangeEnd = 1368512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_Latin1_Private_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x000C68D8 File Offset: 0x000C4AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368512, XrefRangeEnd = 1368513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetByteCount(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_New_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x000C6930 File Offset: 0x000C4B30
		[CallerCount(0)]
		public unsafe virtual int GetByteCount(Il2CppStructArray<char> chars, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetByteCount_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022F3 RID: 8947 RVA: 0x000C69A4 File Offset: 0x000C4BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368513, XrefRangeEnd = 1368516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetByteCount(char* chars, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = chars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_New_Int32_ptr_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x000C6A08 File Offset: 0x000C4C08
		[CallerCount(0)]
		public unsafe virtual int GetByteCount(char* chars, int count, EncoderNLS encoder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = chars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetByteCount_Internal_Virtual_New_Int32_ptr_Char_Int32_EncoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x000C6A7C File Offset: 0x000C4C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368516, XrefRangeEnd = 1368519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> GetBytes(Il2CppStructArray<char> chars, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x000C6AF4 File Offset: 0x000C4CF4
		[CallerCount(0)]
		public unsafe virtual int GetBytes(Il2CppStructArray<char> chars, int charIndex, int charCount, Il2CppStructArray<byte> bytes, int byteIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetBytes_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x000C6B8C File Offset: 0x000C4D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368519, XrefRangeEnd = 1368522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> GetBytes(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x000C6BE8 File Offset: 0x000C4DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368522, XrefRangeEnd = 1368529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetBytes(string s, int charIndex, int charCount, Il2CppStructArray<byte> bytes, int byteIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Int32_String_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x000C6C80 File Offset: 0x000C4E80
		[CallerCount(0)]
		public unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = chars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bytes;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetBytes_Internal_Virtual_New_Int32_ptr_Char_Int32_ptr_Byte_Int32_EncoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x000C6D10 File Offset: 0x000C4F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368529, XrefRangeEnd = 1368535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = chars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bytes;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Int32_ptr_Char_Int32_ptr_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x000C6D8C File Offset: 0x000C4F8C
		[CallerCount(0)]
		public unsafe virtual int GetCharCount(Il2CppStructArray<byte> bytes, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetCharCount_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x000C6E00 File Offset: 0x000C5000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368535, XrefRangeEnd = 1368538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetCharCount(byte* bytes, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bytes;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_New_Int32_ptr_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x000C6E64 File Offset: 0x000C5064
		[CallerCount(0)]
		public unsafe virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bytes;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decoder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetCharCount_Internal_Virtual_New_Int32_ptr_Byte_Int32_DecoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x000C6ED8 File Offset: 0x000C50D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368538, XrefRangeEnd = 1368541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<char> GetChars(Il2CppStructArray<byte> bytes, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetChars_Public_Virtual_New_Il2CppStructArray_1_Char_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x000C6F50 File Offset: 0x000C5150
		[CallerCount(0)]
		public unsafe virtual int GetChars(Il2CppStructArray<byte> bytes, int byteIndex, int byteCount, Il2CppStructArray<char> chars, int charIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chars);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetChars_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x000C6FE8 File Offset: 0x000C51E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368541, XrefRangeEnd = 1368547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bytes;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = chars;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetChars_Public_Virtual_New_Int32_ptr_Byte_Int32_ptr_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x000C7064 File Offset: 0x000C5264
		[CallerCount(0)]
		public unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bytes;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = chars;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decoder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetChars_Internal_Virtual_New_Int32_ptr_Byte_Int32_ptr_Char_Int32_DecoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x000C70F4 File Offset: 0x000C52F4
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1368564, RefRangeEnd = 1368583, XrefRangeStart = 1368547, XrefRangeEnd = 1368564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetString(byte* bytes, int byteCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bytes;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_GetString_Public_String_ptr_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x000C7148 File Offset: 0x000C5348
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1368605, RefRangeEnd = 1368607, XrefRangeStart = 1368583, XrefRangeEnd = 1368605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetString(ReadOnlySpan<byte> bytes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bytes));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_GetString_Public_String_ReadOnlySpan_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06002304 RID: 8964 RVA: 0x000C7198 File Offset: 0x000C5398
		public unsafe virtual int CodePage
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_get_CodePage_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x000C71E0 File Offset: 0x000C53E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368607, XrefRangeEnd = 1368612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Decoder GetDecoder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetDecoder_Public_Virtual_New_Decoder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Decoder>(intPtr3) : null;
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x000C722C File Offset: 0x000C542C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368612, XrefRangeEnd = 1368616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Encoding CreateDefaultEncoding()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_CreateDefaultEncoding_Private_Static_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
		}

		// Token: 0x06002307 RID: 8967 RVA: 0x000C7260 File Offset: 0x000C5460
		[CallerCount(0)]
		public unsafe void setReadOnly(bool value = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_setReadOnly_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06002308 RID: 8968 RVA: 0x000C72A0 File Offset: 0x000C54A0
		public unsafe static Encoding Default
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 1368629, RefRangeEnd = 1368642, XrefRangeStart = 1368616, XrefRangeEnd = 1368629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_Default_Public_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x000C72D4 File Offset: 0x000C54D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368642, XrefRangeEnd = 1368647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Encoder GetEncoder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetEncoder_Public_Virtual_New_Encoder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoder>(intPtr3) : null;
		}

		// Token: 0x0600230A RID: 8970 RVA: 0x000C7320 File Offset: 0x000C5520
		[CallerCount(0)]
		public unsafe virtual int GetMaxByteCount(int charCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetMaxByteCount_Public_Abstract_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x000C7374 File Offset: 0x000C5574
		[CallerCount(0)]
		public unsafe virtual int GetMaxCharCount(int byteCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref byteCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetMaxCharCount_Public_Abstract_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x000C73C8 File Offset: 0x000C55C8
		[CallerCount(0)]
		public unsafe virtual string GetString(Il2CppStructArray<byte> bytes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x000C741C File Offset: 0x000C561C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368647, XrefRangeEnd = 1368648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetString(Il2CppStructArray<byte> bytes, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x0600230E RID: 8974 RVA: 0x000C748C File Offset: 0x000C568C
		public unsafe static Encoding Unicode
		{
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 1368661, RefRangeEnd = 1368703, XrefRangeStart = 1368648, XrefRangeEnd = 1368661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_Unicode_Public_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x0600230F RID: 8975 RVA: 0x000C74C0 File Offset: 0x000C56C0
		public unsafe static Encoding BigEndianUnicode
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1368716, RefRangeEnd = 1368725, XrefRangeStart = 1368703, XrefRangeEnd = 1368716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_BigEndianUnicode_Public_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06002310 RID: 8976 RVA: 0x000C74F4 File Offset: 0x000C56F4
		public unsafe static Encoding UTF7
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1368738, RefRangeEnd = 1368739, XrefRangeStart = 1368725, XrefRangeEnd = 1368738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_UTF7_Public_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06002311 RID: 8977 RVA: 0x000C7528 File Offset: 0x000C5728
		public unsafe static Encoding UTF8
		{
			[CallerCount(168)]
			[CachedScanResults(RefRangeStart = 1368752, RefRangeEnd = 1368920, XrefRangeStart = 1368739, XrefRangeEnd = 1368752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_UTF8_Public_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06002312 RID: 8978 RVA: 0x000C755C File Offset: 0x000C575C
		public unsafe static Encoding UTF32
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1368933, RefRangeEnd = 1368940, XrefRangeStart = 1368920, XrefRangeEnd = 1368933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_UTF32_Public_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x000C7590 File Offset: 0x000C5790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368940, XrefRangeEnd = 1368943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002314 RID: 8980 RVA: 0x000C75E8 File Offset: 0x000C57E8
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x000C7630 File Offset: 0x000C5830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368943, XrefRangeEnd = 1368947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<char> GetBestFitUnicodeToBytesData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetBestFitUnicodeToBytesData_Internal_Virtual_New_Il2CppStructArray_1_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x06002316 RID: 8982 RVA: 0x000C767C File Offset: 0x000C587C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368947, XrefRangeEnd = 1368951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<char> GetBestFitBytesToUnicodeData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetBestFitBytesToUnicodeData_Internal_Virtual_New_Il2CppStructArray_1_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x06002317 RID: 8983 RVA: 0x000C76C8 File Offset: 0x000C58C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1368971, RefRangeEnd = 1368972, XrefRangeStart = 1368951, XrefRangeEnd = 1368971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowBytesOverflow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_ThrowBytesOverflow_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x000C76FC File Offset: 0x000C58FC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1368982, RefRangeEnd = 1368991, XrefRangeStart = 1368972, XrefRangeEnd = 1368982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nothingEncoded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_ThrowBytesOverflow_Internal_Void_EncoderNLS_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x000C774C File Offset: 0x000C594C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1369011, RefRangeEnd = 1369012, XrefRangeStart = 1368991, XrefRangeEnd = 1369011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowCharsOverflow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_ThrowCharsOverflow_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x000C7780 File Offset: 0x000C5980
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1369022, RefRangeEnd = 1369029, XrefRangeStart = 1369012, XrefRangeEnd = 1369022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(decoder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nothingDecoded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_ThrowCharsOverflow_Internal_Void_DecoderNLS_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x0000B226 File Offset: 0x00009426
		public Encoding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x0600231C RID: 8988 RVA: 0x000C77D0 File Offset: 0x000C59D0
		// (set) Token: 0x0600231D RID: 8989 RVA: 0x0000B22F File Offset: 0x0000942F
		public unsafe static Encoding defaultEncoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_defaultEncoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_defaultEncoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x0600231E RID: 8990 RVA: 0x000C77F8 File Offset: 0x000C59F8
		// (set) Token: 0x0600231F RID: 8991 RVA: 0x0000B241 File Offset: 0x00009441
		public unsafe static Encoding unicodeEncoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_unicodeEncoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_unicodeEncoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06002320 RID: 8992 RVA: 0x000C7820 File Offset: 0x000C5A20
		// (set) Token: 0x06002321 RID: 8993 RVA: 0x0000B253 File Offset: 0x00009453
		public unsafe static Encoding bigEndianUnicode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_bigEndianUnicode, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_bigEndianUnicode, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06002322 RID: 8994 RVA: 0x000C7848 File Offset: 0x000C5A48
		// (set) Token: 0x06002323 RID: 8995 RVA: 0x0000B265 File Offset: 0x00009465
		public unsafe static Encoding utf7Encoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_utf7Encoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_utf7Encoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06002324 RID: 8996 RVA: 0x000C7870 File Offset: 0x000C5A70
		// (set) Token: 0x06002325 RID: 8997 RVA: 0x0000B277 File Offset: 0x00009477
		public unsafe static Encoding utf8Encoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_utf8Encoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_utf8Encoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06002326 RID: 8998 RVA: 0x000C7898 File Offset: 0x000C5A98
		// (set) Token: 0x06002327 RID: 8999 RVA: 0x0000B289 File Offset: 0x00009489
		public unsafe static Encoding utf32Encoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_utf32Encoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_utf32Encoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06002328 RID: 9000 RVA: 0x000C78C0 File Offset: 0x000C5AC0
		// (set) Token: 0x06002329 RID: 9001 RVA: 0x0000B29B File Offset: 0x0000949B
		public unsafe static Encoding asciiEncoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_asciiEncoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_asciiEncoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x0600232A RID: 9002 RVA: 0x000C78E8 File Offset: 0x000C5AE8
		// (set) Token: 0x0600232B RID: 9003 RVA: 0x0000B2AD File Offset: 0x000094AD
		public unsafe static Encoding latin1Encoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_latin1Encoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_latin1Encoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x0600232C RID: 9004 RVA: 0x000C7910 File Offset: 0x000C5B10
		// (set) Token: 0x0600232D RID: 9005 RVA: 0x0000B2BF File Offset: 0x000094BF
		public unsafe static Dictionary<int, Encoding> encodings
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_encodings, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Encoding>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_encodings, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x0600232E RID: 9006 RVA: 0x000C7938 File Offset: 0x000C5B38
		// (set) Token: 0x0600232F RID: 9007 RVA: 0x0000B2D1 File Offset: 0x000094D1
		public unsafe static int MIMECONTF_MAILNEWS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_MIMECONTF_MAILNEWS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_MIMECONTF_MAILNEWS, (void*)(&value));
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06002330 RID: 9008 RVA: 0x000C7954 File Offset: 0x000C5B54
		// (set) Token: 0x06002331 RID: 9009 RVA: 0x0000B2DF File Offset: 0x000094DF
		public unsafe static int MIMECONTF_BROWSER
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_MIMECONTF_BROWSER, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_MIMECONTF_BROWSER, (void*)(&value));
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06002332 RID: 9010 RVA: 0x000C7970 File Offset: 0x000C5B70
		// (set) Token: 0x06002333 RID: 9011 RVA: 0x0000B2ED File Offset: 0x000094ED
		public unsafe static int MIMECONTF_SAVABLE_MAILNEWS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_MIMECONTF_SAVABLE_MAILNEWS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_MIMECONTF_SAVABLE_MAILNEWS, (void*)(&value));
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06002334 RID: 9012 RVA: 0x000C798C File Offset: 0x000C5B8C
		// (set) Token: 0x06002335 RID: 9013 RVA: 0x0000B2FB File Offset: 0x000094FB
		public unsafe static int MIMECONTF_SAVABLE_BROWSER
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_MIMECONTF_SAVABLE_BROWSER, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_MIMECONTF_SAVABLE_BROWSER, (void*)(&value));
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06002336 RID: 9014 RVA: 0x000C79A8 File Offset: 0x000C5BA8
		// (set) Token: 0x06002337 RID: 9015 RVA: 0x0000B309 File Offset: 0x00009509
		public unsafe static int CodePageDefault
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_CodePageDefault, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_CodePageDefault, (void*)(&value));
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06002338 RID: 9016 RVA: 0x000C79C4 File Offset: 0x000C5BC4
		// (set) Token: 0x06002339 RID: 9017 RVA: 0x0000B317 File Offset: 0x00009517
		public unsafe static int CodePageNoOEM
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_CodePageNoOEM, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_CodePageNoOEM, (void*)(&value));
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x0600233A RID: 9018 RVA: 0x000C79E0 File Offset: 0x000C5BE0
		// (set) Token: 0x0600233B RID: 9019 RVA: 0x0000B325 File Offset: 0x00009525
		public unsafe static int CodePageNoMac
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_CodePageNoMac, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_CodePageNoMac, (void*)(&value));
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x0600233C RID: 9020 RVA: 0x000C79FC File Offset: 0x000C5BFC
		// (set) Token: 0x0600233D RID: 9021 RVA: 0x0000B333 File Offset: 0x00009533
		public unsafe static int CodePageNoThread
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_CodePageNoThread, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_CodePageNoThread, (void*)(&value));
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x0600233E RID: 9022 RVA: 0x000C7A18 File Offset: 0x000C5C18
		// (set) Token: 0x0600233F RID: 9023 RVA: 0x0000B341 File Offset: 0x00009541
		public unsafe static int CodePageNoSymbol
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_CodePageNoSymbol, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_CodePageNoSymbol, (void*)(&value));
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06002340 RID: 9024 RVA: 0x000C7A34 File Offset: 0x000C5C34
		// (set) Token: 0x06002341 RID: 9025 RVA: 0x0000B34F File Offset: 0x0000954F
		public unsafe static int CodePageUnicode
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_CodePageUnicode, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_CodePageUnicode, (void*)(&value));
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06002342 RID: 9026 RVA: 0x000C7A50 File Offset: 0x000C5C50
		// (set) Token: 0x06002343 RID: 9027 RVA: 0x0000B35D File Offset: 0x0000955D
		public unsafe static int CodePageBigEndian
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_CodePageBigEndian, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_CodePageBigEndian, (void*)(&value));
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06002344 RID: 9028 RVA: 0x000C7A6C File Offset: 0x000C5C6C
		// (set) Token: 0x06002345 RID: 9029 RVA: 0x0000B36B File Offset: 0x0000956B
		public unsafe static int CodePageWindows1252
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_CodePageWindows1252, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_CodePageWindows1252, (void*)(&value));
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06002346 RID: 9030 RVA: 0x000C7A88 File Offset: 0x000C5C88
		// (set) Token: 0x06002347 RID: 9031 RVA: 0x0000B379 File Offset: 0x00009579
		public unsafe static int CodePageMacGB2312
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_CodePageMacGB2312, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_CodePageMacGB2312, (void*)(&value));
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06002348 RID: 9032 RVA: 0x000C7AA4 File Offset: 0x000C5CA4
		// (set) Token: 0x06002349 RID: 9033 RVA: 0x0000B387 File Offset: 0x00009587
		public unsafe static int CodePageGB2312
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_CodePageGB2312, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_CodePageGB2312, (void*)(&value));
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x0600234A RID: 9034 RVA: 0x000C7AC0 File Offset: 0x000C5CC0
		// (set) Token: 0x0600234B RID: 9035 RVA: 0x0000B395 File Offset: 0x00009595
		public unsafe static int CodePageMacKorean
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_CodePageMacKorean, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_CodePageMacKorean, (void*)(&value));
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x0600234C RID: 9036 RVA: 0x000C7ADC File Offset: 0x000C5CDC
		// (set) Token: 0x0600234D RID: 9037 RVA: 0x0000B3A3 File Offset: 0x000095A3
		public unsafe static int CodePageDLLKorean
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_CodePageDLLKorean, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_CodePageDLLKorean, (void*)(&value));
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x0600234E RID: 9038 RVA: 0x000C7AF8 File Offset: 0x000C5CF8
		// (set) Token: 0x0600234F RID: 9039 RVA: 0x0000B3B1 File Offset: 0x000095B1
		public unsafe static int ISO2022JP
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_ISO2022JP, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_ISO2022JP, (void*)(&value));
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06002350 RID: 9040 RVA: 0x000C7B14 File Offset: 0x000C5D14
		// (set) Token: 0x06002351 RID: 9041 RVA: 0x0000B3BF File Offset: 0x000095BF
		public unsafe static int ISO2022JPESC
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_ISO2022JPESC, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_ISO2022JPESC, (void*)(&value));
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06002352 RID: 9042 RVA: 0x000C7B30 File Offset: 0x000C5D30
		// (set) Token: 0x06002353 RID: 9043 RVA: 0x0000B3CD File Offset: 0x000095CD
		public unsafe static int ISO2022JPSISO
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_ISO2022JPSISO, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_ISO2022JPSISO, (void*)(&value));
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06002354 RID: 9044 RVA: 0x000C7B4C File Offset: 0x000C5D4C
		// (set) Token: 0x06002355 RID: 9045 RVA: 0x0000B3DB File Offset: 0x000095DB
		public unsafe static int ISOKorean
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_ISOKorean, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_ISOKorean, (void*)(&value));
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06002356 RID: 9046 RVA: 0x000C7B68 File Offset: 0x000C5D68
		// (set) Token: 0x06002357 RID: 9047 RVA: 0x0000B3E9 File Offset: 0x000095E9
		public unsafe static int ISOSimplifiedCN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_ISOSimplifiedCN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_ISOSimplifiedCN, (void*)(&value));
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06002358 RID: 9048 RVA: 0x000C7B84 File Offset: 0x000C5D84
		// (set) Token: 0x06002359 RID: 9049 RVA: 0x0000B3F7 File Offset: 0x000095F7
		public unsafe static int EUCJP
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_EUCJP, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_EUCJP, (void*)(&value));
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x0600235A RID: 9050 RVA: 0x000C7BA0 File Offset: 0x000C5DA0
		// (set) Token: 0x0600235B RID: 9051 RVA: 0x0000B405 File Offset: 0x00009605
		public unsafe static int ChineseHZ
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_ChineseHZ, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_ChineseHZ, (void*)(&value));
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x0600235C RID: 9052 RVA: 0x000C7BBC File Offset: 0x000C5DBC
		// (set) Token: 0x0600235D RID: 9053 RVA: 0x0000B413 File Offset: 0x00009613
		public unsafe static int DuplicateEUCCN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_DuplicateEUCCN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_DuplicateEUCCN, (void*)(&value));
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x0600235E RID: 9054 RVA: 0x000C7BD8 File Offset: 0x000C5DD8
		// (set) Token: 0x0600235F RID: 9055 RVA: 0x0000B421 File Offset: 0x00009621
		public unsafe static int EUCCN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_EUCCN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_EUCCN, (void*)(&value));
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06002360 RID: 9056 RVA: 0x000C7BF4 File Offset: 0x000C5DF4
		// (set) Token: 0x06002361 RID: 9057 RVA: 0x0000B42F File Offset: 0x0000962F
		public unsafe static int EUCKR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_EUCKR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_EUCKR, (void*)(&value));
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06002362 RID: 9058 RVA: 0x000C7C10 File Offset: 0x000C5E10
		// (set) Token: 0x06002363 RID: 9059 RVA: 0x0000B43D File Offset: 0x0000963D
		public unsafe static int CodePageASCII
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_CodePageASCII, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_CodePageASCII, (void*)(&value));
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06002364 RID: 9060 RVA: 0x000C7C2C File Offset: 0x000C5E2C
		// (set) Token: 0x06002365 RID: 9061 RVA: 0x0000B44B File Offset: 0x0000964B
		public unsafe static int ISO_8859_1
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_ISO_8859_1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_ISO_8859_1, (void*)(&value));
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06002366 RID: 9062 RVA: 0x000C7C48 File Offset: 0x000C5E48
		// (set) Token: 0x06002367 RID: 9063 RVA: 0x0000B459 File Offset: 0x00009659
		public unsafe static int ISCIIAssemese
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_ISCIIAssemese, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_ISCIIAssemese, (void*)(&value));
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06002368 RID: 9064 RVA: 0x000C7C64 File Offset: 0x000C5E64
		// (set) Token: 0x06002369 RID: 9065 RVA: 0x0000B467 File Offset: 0x00009667
		public unsafe static int ISCIIBengali
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_ISCIIBengali, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_ISCIIBengali, (void*)(&value));
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x0600236A RID: 9066 RVA: 0x000C7C80 File Offset: 0x000C5E80
		// (set) Token: 0x0600236B RID: 9067 RVA: 0x0000B475 File Offset: 0x00009675
		public unsafe static int ISCIIDevanagari
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_ISCIIDevanagari, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_ISCIIDevanagari, (void*)(&value));
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x0600236C RID: 9068 RVA: 0x000C7C9C File Offset: 0x000C5E9C
		// (set) Token: 0x0600236D RID: 9069 RVA: 0x0000B483 File Offset: 0x00009683
		public unsafe static int ISCIIGujarathi
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_ISCIIGujarathi, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_ISCIIGujarathi, (void*)(&value));
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x0600236E RID: 9070 RVA: 0x000C7CB8 File Offset: 0x000C5EB8
		// (set) Token: 0x0600236F RID: 9071 RVA: 0x0000B491 File Offset: 0x00009691
		public unsafe static int ISCIIKannada
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_ISCIIKannada, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_ISCIIKannada, (void*)(&value));
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06002370 RID: 9072 RVA: 0x000C7CD4 File Offset: 0x000C5ED4
		// (set) Token: 0x06002371 RID: 9073 RVA: 0x0000B49F File Offset: 0x0000969F
		public unsafe static int ISCIIMalayalam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_ISCIIMalayalam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_ISCIIMalayalam, (void*)(&value));
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06002372 RID: 9074 RVA: 0x000C7CF0 File Offset: 0x000C5EF0
		// (set) Token: 0x06002373 RID: 9075 RVA: 0x0000B4AD File Offset: 0x000096AD
		public unsafe static int ISCIIOriya
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_ISCIIOriya, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_ISCIIOriya, (void*)(&value));
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06002374 RID: 9076 RVA: 0x000C7D0C File Offset: 0x000C5F0C
		// (set) Token: 0x06002375 RID: 9077 RVA: 0x0000B4BB File Offset: 0x000096BB
		public unsafe static int ISCIIPanjabi
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_ISCIIPanjabi, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_ISCIIPanjabi, (void*)(&value));
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06002376 RID: 9078 RVA: 0x000C7D28 File Offset: 0x000C5F28
		// (set) Token: 0x06002377 RID: 9079 RVA: 0x0000B4C9 File Offset: 0x000096C9
		public unsafe static int ISCIITamil
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_ISCIITamil, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_ISCIITamil, (void*)(&value));
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06002378 RID: 9080 RVA: 0x000C7D44 File Offset: 0x000C5F44
		// (set) Token: 0x06002379 RID: 9081 RVA: 0x0000B4D7 File Offset: 0x000096D7
		public unsafe static int ISCIITelugu
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_ISCIITelugu, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_ISCIITelugu, (void*)(&value));
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x0600237A RID: 9082 RVA: 0x000C7D60 File Offset: 0x000C5F60
		// (set) Token: 0x0600237B RID: 9083 RVA: 0x0000B4E5 File Offset: 0x000096E5
		public unsafe static int GB18030
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_GB18030, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_GB18030, (void*)(&value));
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x0600237C RID: 9084 RVA: 0x000C7D7C File Offset: 0x000C5F7C
		// (set) Token: 0x0600237D RID: 9085 RVA: 0x0000B4F3 File Offset: 0x000096F3
		public unsafe static int ISO_8859_8I
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_ISO_8859_8I, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_ISO_8859_8I, (void*)(&value));
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x0600237E RID: 9086 RVA: 0x000C7D98 File Offset: 0x000C5F98
		// (set) Token: 0x0600237F RID: 9087 RVA: 0x0000B501 File Offset: 0x00009701
		public unsafe static int ISO_8859_8_Visual
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_ISO_8859_8_Visual, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_ISO_8859_8_Visual, (void*)(&value));
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06002380 RID: 9088 RVA: 0x000C7DB4 File Offset: 0x000C5FB4
		// (set) Token: 0x06002381 RID: 9089 RVA: 0x0000B50F File Offset: 0x0000970F
		public unsafe static int ENC50229
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_ENC50229, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_ENC50229, (void*)(&value));
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06002382 RID: 9090 RVA: 0x000C7DD0 File Offset: 0x000C5FD0
		// (set) Token: 0x06002383 RID: 9091 RVA: 0x0000B51D File Offset: 0x0000971D
		public unsafe static int CodePageUTF7
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_CodePageUTF7, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_CodePageUTF7, (void*)(&value));
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06002384 RID: 9092 RVA: 0x000C7DEC File Offset: 0x000C5FEC
		// (set) Token: 0x06002385 RID: 9093 RVA: 0x0000B52B File Offset: 0x0000972B
		public unsafe static int CodePageUTF8
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_CodePageUTF8, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_CodePageUTF8, (void*)(&value));
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06002386 RID: 9094 RVA: 0x000C7E08 File Offset: 0x000C6008
		// (set) Token: 0x06002387 RID: 9095 RVA: 0x0000B539 File Offset: 0x00009739
		public unsafe static int CodePageUTF32
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_CodePageUTF32, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_CodePageUTF32, (void*)(&value));
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06002388 RID: 9096 RVA: 0x000C7E24 File Offset: 0x000C6024
		// (set) Token: 0x06002389 RID: 9097 RVA: 0x0000B547 File Offset: 0x00009747
		public unsafe static int CodePageUTF32BE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_CodePageUTF32BE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_CodePageUTF32BE, (void*)(&value));
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x0600238A RID: 9098 RVA: 0x000C7E40 File Offset: 0x000C6040
		// (set) Token: 0x0600238B RID: 9099 RVA: 0x0000B555 File Offset: 0x00009755
		public unsafe int m_codePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_m_codePage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_m_codePage)) = value;
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x0600238C RID: 9100 RVA: 0x000C7E68 File Offset: 0x000C6068
		// (set) Token: 0x0600238D RID: 9101 RVA: 0x0000B570 File Offset: 0x00009770
		public unsafe CodePageDataItem dataItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_dataItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePageDataItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_dataItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x0600238E RID: 9102 RVA: 0x000C7E98 File Offset: 0x000C6098
		// (set) Token: 0x0600238F RID: 9103 RVA: 0x0000B58F File Offset: 0x0000978F
		public unsafe bool m_deserializedFromEverett
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_m_deserializedFromEverett);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_m_deserializedFromEverett)) = value;
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06002390 RID: 9104 RVA: 0x000C7EC0 File Offset: 0x000C60C0
		// (set) Token: 0x06002391 RID: 9105 RVA: 0x0000B5AA File Offset: 0x000097AA
		public unsafe bool m_isReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_m_isReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_m_isReadOnly)) = value;
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06002392 RID: 9106 RVA: 0x000C7EE8 File Offset: 0x000C60E8
		// (set) Token: 0x06002393 RID: 9107 RVA: 0x0000B5C5 File Offset: 0x000097C5
		public unsafe EncoderFallback encoderFallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_encoderFallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EncoderFallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_encoderFallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06002394 RID: 9108 RVA: 0x000C7F18 File Offset: 0x000C6118
		// (set) Token: 0x06002395 RID: 9109 RVA: 0x0000B5E4 File Offset: 0x000097E4
		public unsafe DecoderFallback decoderFallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_decoderFallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecoderFallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_decoderFallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06002396 RID: 9110 RVA: 0x000C7F48 File Offset: 0x000C6148
		// (set) Token: 0x06002397 RID: 9111 RVA: 0x0000B603 File Offset: 0x00009803
		public unsafe static Object s_InternalSyncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_s_InternalSyncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_s_InternalSyncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001EAF RID: 7855
		private static readonly IntPtr NativeFieldInfoPtr_defaultEncoding;

		// Token: 0x04001EB0 RID: 7856
		private static readonly IntPtr NativeFieldInfoPtr_unicodeEncoding;

		// Token: 0x04001EB1 RID: 7857
		private static readonly IntPtr NativeFieldInfoPtr_bigEndianUnicode;

		// Token: 0x04001EB2 RID: 7858
		private static readonly IntPtr NativeFieldInfoPtr_utf7Encoding;

		// Token: 0x04001EB3 RID: 7859
		private static readonly IntPtr NativeFieldInfoPtr_utf8Encoding;

		// Token: 0x04001EB4 RID: 7860
		private static readonly IntPtr NativeFieldInfoPtr_utf32Encoding;

		// Token: 0x04001EB5 RID: 7861
		private static readonly IntPtr NativeFieldInfoPtr_asciiEncoding;

		// Token: 0x04001EB6 RID: 7862
		private static readonly IntPtr NativeFieldInfoPtr_latin1Encoding;

		// Token: 0x04001EB7 RID: 7863
		private static readonly IntPtr NativeFieldInfoPtr_encodings;

		// Token: 0x04001EB8 RID: 7864
		private static readonly IntPtr NativeFieldInfoPtr_MIMECONTF_MAILNEWS;

		// Token: 0x04001EB9 RID: 7865
		private static readonly IntPtr NativeFieldInfoPtr_MIMECONTF_BROWSER;

		// Token: 0x04001EBA RID: 7866
		private static readonly IntPtr NativeFieldInfoPtr_MIMECONTF_SAVABLE_MAILNEWS;

		// Token: 0x04001EBB RID: 7867
		private static readonly IntPtr NativeFieldInfoPtr_MIMECONTF_SAVABLE_BROWSER;

		// Token: 0x04001EBC RID: 7868
		private static readonly IntPtr NativeFieldInfoPtr_CodePageDefault;

		// Token: 0x04001EBD RID: 7869
		private static readonly IntPtr NativeFieldInfoPtr_CodePageNoOEM;

		// Token: 0x04001EBE RID: 7870
		private static readonly IntPtr NativeFieldInfoPtr_CodePageNoMac;

		// Token: 0x04001EBF RID: 7871
		private static readonly IntPtr NativeFieldInfoPtr_CodePageNoThread;

		// Token: 0x04001EC0 RID: 7872
		private static readonly IntPtr NativeFieldInfoPtr_CodePageNoSymbol;

		// Token: 0x04001EC1 RID: 7873
		private static readonly IntPtr NativeFieldInfoPtr_CodePageUnicode;

		// Token: 0x04001EC2 RID: 7874
		private static readonly IntPtr NativeFieldInfoPtr_CodePageBigEndian;

		// Token: 0x04001EC3 RID: 7875
		private static readonly IntPtr NativeFieldInfoPtr_CodePageWindows1252;

		// Token: 0x04001EC4 RID: 7876
		private static readonly IntPtr NativeFieldInfoPtr_CodePageMacGB2312;

		// Token: 0x04001EC5 RID: 7877
		private static readonly IntPtr NativeFieldInfoPtr_CodePageGB2312;

		// Token: 0x04001EC6 RID: 7878
		private static readonly IntPtr NativeFieldInfoPtr_CodePageMacKorean;

		// Token: 0x04001EC7 RID: 7879
		private static readonly IntPtr NativeFieldInfoPtr_CodePageDLLKorean;

		// Token: 0x04001EC8 RID: 7880
		private static readonly IntPtr NativeFieldInfoPtr_ISO2022JP;

		// Token: 0x04001EC9 RID: 7881
		private static readonly IntPtr NativeFieldInfoPtr_ISO2022JPESC;

		// Token: 0x04001ECA RID: 7882
		private static readonly IntPtr NativeFieldInfoPtr_ISO2022JPSISO;

		// Token: 0x04001ECB RID: 7883
		private static readonly IntPtr NativeFieldInfoPtr_ISOKorean;

		// Token: 0x04001ECC RID: 7884
		private static readonly IntPtr NativeFieldInfoPtr_ISOSimplifiedCN;

		// Token: 0x04001ECD RID: 7885
		private static readonly IntPtr NativeFieldInfoPtr_EUCJP;

		// Token: 0x04001ECE RID: 7886
		private static readonly IntPtr NativeFieldInfoPtr_ChineseHZ;

		// Token: 0x04001ECF RID: 7887
		private static readonly IntPtr NativeFieldInfoPtr_DuplicateEUCCN;

		// Token: 0x04001ED0 RID: 7888
		private static readonly IntPtr NativeFieldInfoPtr_EUCCN;

		// Token: 0x04001ED1 RID: 7889
		private static readonly IntPtr NativeFieldInfoPtr_EUCKR;

		// Token: 0x04001ED2 RID: 7890
		private static readonly IntPtr NativeFieldInfoPtr_CodePageASCII;

		// Token: 0x04001ED3 RID: 7891
		private static readonly IntPtr NativeFieldInfoPtr_ISO_8859_1;

		// Token: 0x04001ED4 RID: 7892
		private static readonly IntPtr NativeFieldInfoPtr_ISCIIAssemese;

		// Token: 0x04001ED5 RID: 7893
		private static readonly IntPtr NativeFieldInfoPtr_ISCIIBengali;

		// Token: 0x04001ED6 RID: 7894
		private static readonly IntPtr NativeFieldInfoPtr_ISCIIDevanagari;

		// Token: 0x04001ED7 RID: 7895
		private static readonly IntPtr NativeFieldInfoPtr_ISCIIGujarathi;

		// Token: 0x04001ED8 RID: 7896
		private static readonly IntPtr NativeFieldInfoPtr_ISCIIKannada;

		// Token: 0x04001ED9 RID: 7897
		private static readonly IntPtr NativeFieldInfoPtr_ISCIIMalayalam;

		// Token: 0x04001EDA RID: 7898
		private static readonly IntPtr NativeFieldInfoPtr_ISCIIOriya;

		// Token: 0x04001EDB RID: 7899
		private static readonly IntPtr NativeFieldInfoPtr_ISCIIPanjabi;

		// Token: 0x04001EDC RID: 7900
		private static readonly IntPtr NativeFieldInfoPtr_ISCIITamil;

		// Token: 0x04001EDD RID: 7901
		private static readonly IntPtr NativeFieldInfoPtr_ISCIITelugu;

		// Token: 0x04001EDE RID: 7902
		private static readonly IntPtr NativeFieldInfoPtr_GB18030;

		// Token: 0x04001EDF RID: 7903
		private static readonly IntPtr NativeFieldInfoPtr_ISO_8859_8I;

		// Token: 0x04001EE0 RID: 7904
		private static readonly IntPtr NativeFieldInfoPtr_ISO_8859_8_Visual;

		// Token: 0x04001EE1 RID: 7905
		private static readonly IntPtr NativeFieldInfoPtr_ENC50229;

		// Token: 0x04001EE2 RID: 7906
		private static readonly IntPtr NativeFieldInfoPtr_CodePageUTF7;

		// Token: 0x04001EE3 RID: 7907
		private static readonly IntPtr NativeFieldInfoPtr_CodePageUTF8;

		// Token: 0x04001EE4 RID: 7908
		private static readonly IntPtr NativeFieldInfoPtr_CodePageUTF32;

		// Token: 0x04001EE5 RID: 7909
		private static readonly IntPtr NativeFieldInfoPtr_CodePageUTF32BE;

		// Token: 0x04001EE6 RID: 7910
		private static readonly IntPtr NativeFieldInfoPtr_m_codePage;

		// Token: 0x04001EE7 RID: 7911
		private static readonly IntPtr NativeFieldInfoPtr_dataItem;

		// Token: 0x04001EE8 RID: 7912
		private static readonly IntPtr NativeFieldInfoPtr_m_deserializedFromEverett;

		// Token: 0x04001EE9 RID: 7913
		private static readonly IntPtr NativeFieldInfoPtr_m_isReadOnly;

		// Token: 0x04001EEA RID: 7914
		private static readonly IntPtr NativeFieldInfoPtr_encoderFallback;

		// Token: 0x04001EEB RID: 7915
		private static readonly IntPtr NativeFieldInfoPtr_decoderFallback;

		// Token: 0x04001EEC RID: 7916
		private static readonly IntPtr NativeFieldInfoPtr_s_InternalSyncObject;

		// Token: 0x04001EED RID: 7917
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001EEE RID: 7918
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Int32_0;

		// Token: 0x04001EEF RID: 7919
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultFallbacks_Internal_Virtual_New_Void_0;

		// Token: 0x04001EF0 RID: 7920
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializing_Internal_Void_0;

		// Token: 0x04001EF1 RID: 7921
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Internal_Void_0;

		// Token: 0x04001EF2 RID: 7922
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0;

		// Token: 0x04001EF3 RID: 7923
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0;

		// Token: 0x04001EF4 RID: 7924
		private static readonly IntPtr NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0;

		// Token: 0x04001EF5 RID: 7925
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeEncoding_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001EF6 RID: 7926
		private static readonly IntPtr NativeMethodInfoPtr_SerializeEncoding_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001EF7 RID: 7927
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0;

		// Token: 0x04001EF8 RID: 7928
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoding_Public_Static_Encoding_Int32_0;

		// Token: 0x04001EF9 RID: 7929
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoding_Public_Static_Encoding_Int32_EncoderFallback_DecoderFallback_0;

		// Token: 0x04001EFA RID: 7930
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoding_Public_Static_Encoding_String_0;

		// Token: 0x04001EFB RID: 7931
		private static readonly IntPtr NativeMethodInfoPtr_GetPreamble_Public_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001EFC RID: 7932
		private static readonly IntPtr NativeMethodInfoPtr_get_Preamble_Public_Virtual_New_get_ReadOnlySpan_1_Byte_0;

		// Token: 0x04001EFD RID: 7933
		private static readonly IntPtr NativeMethodInfoPtr_GetDataItem_Private_Void_0;

		// Token: 0x04001EFE RID: 7934
		private static readonly IntPtr NativeMethodInfoPtr_get_EncodingName_Public_Virtual_New_get_String_0;

		// Token: 0x04001EFF RID: 7935
		private static readonly IntPtr NativeMethodInfoPtr_get_HeaderName_Public_Virtual_New_get_String_0;

		// Token: 0x04001F00 RID: 7936
		private static readonly IntPtr NativeMethodInfoPtr_get_WebName_Public_Virtual_New_get_String_0;

		// Token: 0x04001F01 RID: 7937
		private static readonly IntPtr NativeMethodInfoPtr_get_EncoderFallback_Public_get_EncoderFallback_0;

		// Token: 0x04001F02 RID: 7938
		private static readonly IntPtr NativeMethodInfoPtr_set_EncoderFallback_Public_set_Void_EncoderFallback_0;

		// Token: 0x04001F03 RID: 7939
		private static readonly IntPtr NativeMethodInfoPtr_get_DecoderFallback_Public_get_DecoderFallback_0;

		// Token: 0x04001F04 RID: 7940
		private static readonly IntPtr NativeMethodInfoPtr_set_DecoderFallback_Public_set_Void_DecoderFallback_0;

		// Token: 0x04001F05 RID: 7941
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

		// Token: 0x04001F06 RID: 7942
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0;

		// Token: 0x04001F07 RID: 7943
		private static readonly IntPtr NativeMethodInfoPtr_get_ASCII_Public_Static_get_Encoding_0;

		// Token: 0x04001F08 RID: 7944
		private static readonly IntPtr NativeMethodInfoPtr_get_Latin1_Private_Static_get_Encoding_0;

		// Token: 0x04001F09 RID: 7945
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_New_Int32_String_0;

		// Token: 0x04001F0A RID: 7946
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04001F0B RID: 7947
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_New_Int32_ptr_Char_Int32_0;

		// Token: 0x04001F0C RID: 7948
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Internal_Virtual_New_Int32_ptr_Char_Int32_EncoderNLS_0;

		// Token: 0x04001F0D RID: 7949
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04001F0E RID: 7950
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001F0F RID: 7951
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04001F10 RID: 7952
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Int32_String_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001F11 RID: 7953
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Internal_Virtual_New_Int32_ptr_Char_Int32_ptr_Byte_Int32_EncoderNLS_0;

		// Token: 0x04001F12 RID: 7954
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Int32_ptr_Char_Int32_ptr_Byte_Int32_0;

		// Token: 0x04001F13 RID: 7955
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001F14 RID: 7956
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_New_Int32_ptr_Byte_Int32_0;

		// Token: 0x04001F15 RID: 7957
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Internal_Virtual_New_Int32_ptr_Byte_Int32_DecoderNLS_0;

		// Token: 0x04001F16 RID: 7958
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_New_Il2CppStructArray_1_Char_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001F17 RID: 7959
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04001F18 RID: 7960
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_New_Int32_ptr_Byte_Int32_ptr_Char_Int32_0;

		// Token: 0x04001F19 RID: 7961
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Internal_Virtual_New_Int32_ptr_Byte_Int32_ptr_Char_Int32_DecoderNLS_0;

		// Token: 0x04001F1A RID: 7962
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_String_ptr_Byte_Int32_0;

		// Token: 0x04001F1B RID: 7963
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_String_ReadOnlySpan_1_Byte_0;

		// Token: 0x04001F1C RID: 7964
		private static readonly IntPtr NativeMethodInfoPtr_get_CodePage_Public_Virtual_New_get_Int32_0;

		// Token: 0x04001F1D RID: 7965
		private static readonly IntPtr NativeMethodInfoPtr_GetDecoder_Public_Virtual_New_Decoder_0;

		// Token: 0x04001F1E RID: 7966
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultEncoding_Private_Static_Encoding_0;

		// Token: 0x04001F1F RID: 7967
		private static readonly IntPtr NativeMethodInfoPtr_setReadOnly_Internal_Void_Boolean_0;

		// Token: 0x04001F20 RID: 7968
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_Encoding_0;

		// Token: 0x04001F21 RID: 7969
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoder_Public_Virtual_New_Encoder_0;

		// Token: 0x04001F22 RID: 7970
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxByteCount_Public_Abstract_Virtual_New_Int32_Int32_0;

		// Token: 0x04001F23 RID: 7971
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxCharCount_Public_Abstract_Virtual_New_Int32_Int32_0;

		// Token: 0x04001F24 RID: 7972
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Virtual_New_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001F25 RID: 7973
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Virtual_New_String_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001F26 RID: 7974
		private static readonly IntPtr NativeMethodInfoPtr_get_Unicode_Public_Static_get_Encoding_0;

		// Token: 0x04001F27 RID: 7975
		private static readonly IntPtr NativeMethodInfoPtr_get_BigEndianUnicode_Public_Static_get_Encoding_0;

		// Token: 0x04001F28 RID: 7976
		private static readonly IntPtr NativeMethodInfoPtr_get_UTF7_Public_Static_get_Encoding_0;

		// Token: 0x04001F29 RID: 7977
		private static readonly IntPtr NativeMethodInfoPtr_get_UTF8_Public_Static_get_Encoding_0;

		// Token: 0x04001F2A RID: 7978
		private static readonly IntPtr NativeMethodInfoPtr_get_UTF32_Public_Static_get_Encoding_0;

		// Token: 0x04001F2B RID: 7979
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001F2C RID: 7980
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001F2D RID: 7981
		private static readonly IntPtr NativeMethodInfoPtr_GetBestFitUnicodeToBytesData_Internal_Virtual_New_Il2CppStructArray_1_Char_0;

		// Token: 0x04001F2E RID: 7982
		private static readonly IntPtr NativeMethodInfoPtr_GetBestFitBytesToUnicodeData_Internal_Virtual_New_Il2CppStructArray_1_Char_0;

		// Token: 0x04001F2F RID: 7983
		private static readonly IntPtr NativeMethodInfoPtr_ThrowBytesOverflow_Internal_Void_0;

		// Token: 0x04001F30 RID: 7984
		private static readonly IntPtr NativeMethodInfoPtr_ThrowBytesOverflow_Internal_Void_EncoderNLS_Boolean_0;

		// Token: 0x04001F31 RID: 7985
		private static readonly IntPtr NativeMethodInfoPtr_ThrowCharsOverflow_Internal_Void_0;

		// Token: 0x04001F32 RID: 7986
		private static readonly IntPtr NativeMethodInfoPtr_ThrowCharsOverflow_Internal_Void_DecoderNLS_Boolean_0;

		// Token: 0x02000656 RID: 1622
		[Serializable]
		public class DefaultEncoder : Encoder
		{
			// Token: 0x060059F0 RID: 23024 RVA: 0x0019B828 File Offset: 0x00199A28
			// Note: this type is marked as 'beforefieldinit'.
			static DefaultEncoder()
			{
				Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "DefaultEncoder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr);
				Encoding.DefaultEncoder.NativeFieldInfoPtr_m_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, "m_encoding");
				Encoding.DefaultEncoder.NativeFieldInfoPtr_m_hasInitializedEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, "m_hasInitializedEncoding");
				Encoding.DefaultEncoder.NativeFieldInfoPtr_charLeftOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, "charLeftOver");
				Encoding.DefaultEncoder.NativeMethodInfoPtr__ctor_Public_Void_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, 100669279);
				Encoding.DefaultEncoder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, 100669280);
				Encoding.DefaultEncoder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, 100669281);
				Encoding.DefaultEncoder.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, 100669282);
				Encoding.DefaultEncoder.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, 100669283);
				Encoding.DefaultEncoder.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_ptr_Char_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, 100669284);
				Encoding.DefaultEncoder.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, 100669285);
				Encoding.DefaultEncoder.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, 100669286);
			}

			// Token: 0x060059F1 RID: 23025 RVA: 0x0019B930 File Offset: 0x00199B30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367864, XrefRangeEnd = 1367866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DefaultEncoder(Encoding encoding)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.DefaultEncoder.NativeMethodInfoPtr__ctor_Public_Void_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060059F2 RID: 23026 RVA: 0x0019B97C File Offset: 0x00199B7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367866, XrefRangeEnd = 1367904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DefaultEncoder(SerializationInfo info, StreamingContext context)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.DefaultEncoder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060059F3 RID: 23027 RVA: 0x0019B9E0 File Offset: 0x00199BE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367904, XrefRangeEnd = 1367908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Object GetRealObject(StreamingContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.DefaultEncoder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060059F4 RID: 23028 RVA: 0x0019BA38 File Offset: 0x00199C38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367908, XrefRangeEnd = 1367917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.DefaultEncoder.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060059F5 RID: 23029 RVA: 0x0019BA94 File Offset: 0x00199C94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367917, XrefRangeEnd = 1367918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetByteCount(Il2CppStructArray<char> chars, int index, int count, bool flush)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultEncoder.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060059F6 RID: 23030 RVA: 0x0019BB18 File Offset: 0x00199D18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367918, XrefRangeEnd = 1367919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetByteCount(char* chars, int count, bool flush)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = chars;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultEncoder.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_ptr_Char_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060059F7 RID: 23031 RVA: 0x0019BB88 File Offset: 0x00199D88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367919, XrefRangeEnd = 1367920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetBytes(Il2CppStructArray<char> chars, int charIndex, int charCount, Il2CppStructArray<byte> bytes, int byteIndex, bool flush)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteIndex;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultEncoder.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060059F8 RID: 23032 RVA: 0x0019BC2C File Offset: 0x00199E2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367920, XrefRangeEnd = 1367921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = chars;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bytes;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultEncoder.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060059F9 RID: 23033 RVA: 0x00020339 File Offset: 0x0001E539
			public DefaultEncoder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016ED RID: 5869
			// (get) Token: 0x060059FA RID: 23034 RVA: 0x0019BCB8 File Offset: 0x00199EB8
			// (set) Token: 0x060059FB RID: 23035 RVA: 0x00020342 File Offset: 0x0001E542
			public unsafe Encoding m_encoding
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultEncoder.NativeFieldInfoPtr_m_encoding);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultEncoder.NativeFieldInfoPtr_m_encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016EE RID: 5870
			// (get) Token: 0x060059FC RID: 23036 RVA: 0x0019BCE8 File Offset: 0x00199EE8
			// (set) Token: 0x060059FD RID: 23037 RVA: 0x00020361 File Offset: 0x0001E561
			public unsafe bool m_hasInitializedEncoding
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultEncoder.NativeFieldInfoPtr_m_hasInitializedEncoding);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultEncoder.NativeFieldInfoPtr_m_hasInitializedEncoding)) = value;
				}
			}

			// Token: 0x170016EF RID: 5871
			// (get) Token: 0x060059FE RID: 23038 RVA: 0x0019BD10 File Offset: 0x00199F10
			// (set) Token: 0x060059FF RID: 23039 RVA: 0x0002037C File Offset: 0x0001E57C
			public unsafe char charLeftOver
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultEncoder.NativeFieldInfoPtr_charLeftOver);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultEncoder.NativeFieldInfoPtr_charLeftOver)) = value;
				}
			}

			// Token: 0x040049A0 RID: 18848
			private static readonly IntPtr NativeFieldInfoPtr_m_encoding;

			// Token: 0x040049A1 RID: 18849
			private static readonly IntPtr NativeFieldInfoPtr_m_hasInitializedEncoding;

			// Token: 0x040049A2 RID: 18850
			private static readonly IntPtr NativeFieldInfoPtr_charLeftOver;

			// Token: 0x040049A3 RID: 18851
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Encoding_0;

			// Token: 0x040049A4 RID: 18852
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x040049A5 RID: 18853
			private static readonly IntPtr NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0;

			// Token: 0x040049A6 RID: 18854
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x040049A7 RID: 18855
			private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Boolean_0;

			// Token: 0x040049A8 RID: 18856
			private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_ptr_Char_Int32_Boolean_0;

			// Token: 0x040049A9 RID: 18857
			private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Boolean_0;

			// Token: 0x040049AA RID: 18858
			private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_Boolean_0;
		}

		// Token: 0x02000657 RID: 1623
		[Serializable]
		public class DefaultDecoder : Decoder
		{
			// Token: 0x06005A00 RID: 23040 RVA: 0x0019BD38 File Offset: 0x00199F38
			// Note: this type is marked as 'beforefieldinit'.
			static DefaultDecoder()
			{
				Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "DefaultDecoder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr);
				Encoding.DefaultDecoder.NativeFieldInfoPtr_m_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, "m_encoding");
				Encoding.DefaultDecoder.NativeFieldInfoPtr_m_hasInitializedEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, "m_hasInitializedEncoding");
				Encoding.DefaultDecoder.NativeMethodInfoPtr__ctor_Public_Void_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100669287);
				Encoding.DefaultDecoder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100669288);
				Encoding.DefaultDecoder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100669289);
				Encoding.DefaultDecoder.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100669290);
				Encoding.DefaultDecoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100669291);
				Encoding.DefaultDecoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100669292);
				Encoding.DefaultDecoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_ptr_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100669293);
				Encoding.DefaultDecoder.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100669294);
				Encoding.DefaultDecoder.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100669295);
				Encoding.DefaultDecoder.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100669296);
			}

			// Token: 0x06005A01 RID: 23041 RVA: 0x0019BE54 File Offset: 0x0019A054
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DefaultDecoder(Encoding encoding)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.DefaultDecoder.NativeMethodInfoPtr__ctor_Public_Void_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005A02 RID: 23042 RVA: 0x0019BEA0 File Offset: 0x0019A0A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367921, XrefRangeEnd = 1367951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DefaultDecoder(SerializationInfo info, StreamingContext context)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.DefaultDecoder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A03 RID: 23043 RVA: 0x0019BF04 File Offset: 0x0019A104
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367951, XrefRangeEnd = 1367952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Object GetRealObject(StreamingContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.DefaultDecoder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005A04 RID: 23044 RVA: 0x0019BF5C File Offset: 0x0019A15C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367952, XrefRangeEnd = 1367961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.DefaultDecoder.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A05 RID: 23045 RVA: 0x0019BFB8 File Offset: 0x0019A1B8
			[CallerCount(0)]
			public unsafe override int GetCharCount(Il2CppStructArray<byte> bytes, int index, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultDecoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005A06 RID: 23046 RVA: 0x0019C02C File Offset: 0x0019A22C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367961, XrefRangeEnd = 1367962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetCharCount(Il2CppStructArray<byte> bytes, int index, int count, bool flush)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultDecoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005A07 RID: 23047 RVA: 0x0019C0B0 File Offset: 0x0019A2B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367962, XrefRangeEnd = 1367963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetCharCount(byte* bytes, int count, bool flush)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = bytes;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultDecoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_ptr_Byte_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005A08 RID: 23048 RVA: 0x0019C120 File Offset: 0x0019A320
			[CallerCount(0)]
			public unsafe override int GetChars(Il2CppStructArray<byte> bytes, int byteIndex, int byteCount, Il2CppStructArray<char> chars, int charIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteIndex;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chars);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultDecoder.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005A09 RID: 23049 RVA: 0x0019C1B8 File Offset: 0x0019A3B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367963, XrefRangeEnd = 1367964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetChars(Il2CppStructArray<byte> bytes, int byteIndex, int byteCount, Il2CppStructArray<char> chars, int charIndex, bool flush)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteIndex;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chars);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultDecoder.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005A0A RID: 23050 RVA: 0x0019C25C File Offset: 0x0019A45C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367964, XrefRangeEnd = 1367965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = bytes;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = chars;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultDecoder.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005A0B RID: 23051 RVA: 0x00020397 File Offset: 0x0001E597
			public DefaultDecoder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016F0 RID: 5872
			// (get) Token: 0x06005A0C RID: 23052 RVA: 0x0019C2E8 File Offset: 0x0019A4E8
			// (set) Token: 0x06005A0D RID: 23053 RVA: 0x000203A0 File Offset: 0x0001E5A0
			public unsafe Encoding m_encoding
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultDecoder.NativeFieldInfoPtr_m_encoding);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultDecoder.NativeFieldInfoPtr_m_encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016F1 RID: 5873
			// (get) Token: 0x06005A0E RID: 23054 RVA: 0x0019C318 File Offset: 0x0019A518
			// (set) Token: 0x06005A0F RID: 23055 RVA: 0x000203BF File Offset: 0x0001E5BF
			public unsafe bool m_hasInitializedEncoding
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultDecoder.NativeFieldInfoPtr_m_hasInitializedEncoding);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultDecoder.NativeFieldInfoPtr_m_hasInitializedEncoding)) = value;
				}
			}

			// Token: 0x040049AB RID: 18859
			private static readonly IntPtr NativeFieldInfoPtr_m_encoding;

			// Token: 0x040049AC RID: 18860
			private static readonly IntPtr NativeFieldInfoPtr_m_hasInitializedEncoding;

			// Token: 0x040049AD RID: 18861
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Encoding_0;

			// Token: 0x040049AE RID: 18862
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x040049AF RID: 18863
			private static readonly IntPtr NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0;

			// Token: 0x040049B0 RID: 18864
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x040049B1 RID: 18865
			private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

			// Token: 0x040049B2 RID: 18866
			private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0;

			// Token: 0x040049B3 RID: 18867
			private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_ptr_Byte_Int32_Boolean_0;

			// Token: 0x040049B4 RID: 18868
			private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0;

			// Token: 0x040049B5 RID: 18869
			private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Boolean_0;

			// Token: 0x040049B6 RID: 18870
			private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_Boolean_0;
		}

		// Token: 0x02000658 RID: 1624
		public class EncodingCharBuffer : Object
		{
			// Token: 0x06005A10 RID: 23056 RVA: 0x0019C340 File Offset: 0x0019A540
			// Note: this type is marked as 'beforefieldinit'.
			static EncodingCharBuffer()
			{
				Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "EncodingCharBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr);
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "chars");
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_charStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "charStart");
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_charEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "charEnd");
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_charCountResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "charCountResult");
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_enc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "enc");
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_decoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "decoder");
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_byteStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "byteStart");
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_byteEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "byteEnd");
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_bytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "bytes");
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_fallbackBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "fallbackBuffer");
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr__ctor_Internal_Void_Encoding_DecoderNLS_ptr_Char_Int32_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100669297);
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr_AddChar_Internal_Boolean_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100669298);
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr_AddChar_Internal_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100669299);
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr_AdjustBytes_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100669300);
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr_get_MoreData_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100669301);
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr_GetNextByte_Internal_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100669302);
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr_get_BytesUsed_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100669303);
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr_Fallback_Internal_Boolean_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100669304);
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr_Fallback_Internal_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100669305);
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100669306);
			}

			// Token: 0x06005A11 RID: 23057 RVA: 0x0019C4FC File Offset: 0x0019A6FC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1367973, RefRangeEnd = 1367974, XrefRangeStart = 1367965, XrefRangeEnd = 1367973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EncodingCharBuffer(Encoding enc, DecoderNLS decoder, char* charStart, int charCount, byte* byteStart, int byteCount)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(enc);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decoder);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = charStart;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = byteStart;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr__ctor_Internal_Void_Encoding_DecoderNLS_ptr_Char_Int32_ptr_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A12 RID: 23058 RVA: 0x0019C590 File Offset: 0x0019A790
			[CallerCount(0)]
			public unsafe bool AddChar(char ch, int numBytes)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref ch;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numBytes;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr_AddChar_Internal_Boolean_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005A13 RID: 23059 RVA: 0x0019C5E8 File Offset: 0x0019A7E8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1367974, RefRangeEnd = 1367976, XrefRangeStart = 1367974, XrefRangeEnd = 1367974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool AddChar(char ch)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref ch;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr_AddChar_Internal_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005A14 RID: 23060 RVA: 0x0019C634 File Offset: 0x0019A834
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1367976, RefRangeEnd = 1367977, XrefRangeStart = 1367976, XrefRangeEnd = 1367976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AdjustBytes(int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref count;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr_AdjustBytes_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170016FC RID: 5884
			// (get) Token: 0x06005A15 RID: 23061 RVA: 0x0019C674 File Offset: 0x0019A874
			public unsafe bool MoreData
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1367977, RefRangeEnd = 1367978, XrefRangeStart = 1367977, XrefRangeEnd = 1367977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr_get_MoreData_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005A16 RID: 23062 RVA: 0x0019C6B0 File Offset: 0x0019A8B0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1367978, RefRangeEnd = 1367979, XrefRangeStart = 1367978, XrefRangeEnd = 1367978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe byte GetNextByte()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr_GetNextByte_Internal_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170016FD RID: 5885
			// (get) Token: 0x06005A17 RID: 23063 RVA: 0x0019C6EC File Offset: 0x0019A8EC
			public unsafe int BytesUsed
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1367979, RefRangeEnd = 1367980, XrefRangeStart = 1367979, XrefRangeEnd = 1367979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr_get_BytesUsed_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005A18 RID: 23064 RVA: 0x0019C728 File Offset: 0x0019A928
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1367986, RefRangeEnd = 1367987, XrefRangeStart = 1367980, XrefRangeEnd = 1367986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Fallback(byte fallbackByte)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref fallbackByte;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr_Fallback_Internal_Boolean_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005A19 RID: 23065 RVA: 0x0019C774 File Offset: 0x0019A974
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1367987, RefRangeEnd = 1367988, XrefRangeStart = 1367987, XrefRangeEnd = 1367987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Fallback(Il2CppStructArray<byte> byteBuffer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(byteBuffer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr_Fallback_Internal_Boolean_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170016FE RID: 5886
			// (get) Token: 0x06005A1A RID: 23066 RVA: 0x0019C7C4 File Offset: 0x0019A9C4
			public unsafe int Count
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005A1B RID: 23067 RVA: 0x000203DA File Offset: 0x0001E5DA
			public EncodingCharBuffer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016F2 RID: 5874
			// (get) Token: 0x06005A1C RID: 23068 RVA: 0x0019C800 File Offset: 0x0019AA00
			// (set) Token: 0x06005A1D RID: 23069 RVA: 0x000203E3 File Offset: 0x0001E5E3
			public unsafe char* chars
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_chars);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_chars)) = value;
				}
			}

			// Token: 0x170016F3 RID: 5875
			// (get) Token: 0x06005A1E RID: 23070 RVA: 0x0019C824 File Offset: 0x0019AA24
			// (set) Token: 0x06005A1F RID: 23071 RVA: 0x000203FE File Offset: 0x0001E5FE
			public unsafe char* charStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_charStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_charStart)) = value;
				}
			}

			// Token: 0x170016F4 RID: 5876
			// (get) Token: 0x06005A20 RID: 23072 RVA: 0x0019C848 File Offset: 0x0019AA48
			// (set) Token: 0x06005A21 RID: 23073 RVA: 0x00020419 File Offset: 0x0001E619
			public unsafe char* charEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_charEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_charEnd)) = value;
				}
			}

			// Token: 0x170016F5 RID: 5877
			// (get) Token: 0x06005A22 RID: 23074 RVA: 0x0019C86C File Offset: 0x0019AA6C
			// (set) Token: 0x06005A23 RID: 23075 RVA: 0x00020434 File Offset: 0x0001E634
			public unsafe int charCountResult
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_charCountResult);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_charCountResult)) = value;
				}
			}

			// Token: 0x170016F6 RID: 5878
			// (get) Token: 0x06005A24 RID: 23076 RVA: 0x0019C894 File Offset: 0x0019AA94
			// (set) Token: 0x06005A25 RID: 23077 RVA: 0x0002044F File Offset: 0x0001E64F
			public unsafe Encoding enc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_enc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_enc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016F7 RID: 5879
			// (get) Token: 0x06005A26 RID: 23078 RVA: 0x0019C8C4 File Offset: 0x0019AAC4
			// (set) Token: 0x06005A27 RID: 23079 RVA: 0x0002046E File Offset: 0x0001E66E
			public unsafe DecoderNLS decoder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_decoder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecoderNLS>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_decoder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016F8 RID: 5880
			// (get) Token: 0x06005A28 RID: 23080 RVA: 0x0019C8F4 File Offset: 0x0019AAF4
			// (set) Token: 0x06005A29 RID: 23081 RVA: 0x0002048D File Offset: 0x0001E68D
			public unsafe byte* byteStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_byteStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_byteStart)) = value;
				}
			}

			// Token: 0x170016F9 RID: 5881
			// (get) Token: 0x06005A2A RID: 23082 RVA: 0x0019C918 File Offset: 0x0019AB18
			// (set) Token: 0x06005A2B RID: 23083 RVA: 0x000204A8 File Offset: 0x0001E6A8
			public unsafe byte* byteEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_byteEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_byteEnd)) = value;
				}
			}

			// Token: 0x170016FA RID: 5882
			// (get) Token: 0x06005A2C RID: 23084 RVA: 0x0019C93C File Offset: 0x0019AB3C
			// (set) Token: 0x06005A2D RID: 23085 RVA: 0x000204C3 File Offset: 0x0001E6C3
			public unsafe byte* bytes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_bytes);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_bytes)) = value;
				}
			}

			// Token: 0x170016FB RID: 5883
			// (get) Token: 0x06005A2E RID: 23086 RVA: 0x0019C960 File Offset: 0x0019AB60
			// (set) Token: 0x06005A2F RID: 23087 RVA: 0x000204DE File Offset: 0x0001E6DE
			public unsafe DecoderFallbackBuffer fallbackBuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_fallbackBuffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecoderFallbackBuffer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_fallbackBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040049B7 RID: 18871
			private static readonly IntPtr NativeFieldInfoPtr_chars;

			// Token: 0x040049B8 RID: 18872
			private static readonly IntPtr NativeFieldInfoPtr_charStart;

			// Token: 0x040049B9 RID: 18873
			private static readonly IntPtr NativeFieldInfoPtr_charEnd;

			// Token: 0x040049BA RID: 18874
			private static readonly IntPtr NativeFieldInfoPtr_charCountResult;

			// Token: 0x040049BB RID: 18875
			private static readonly IntPtr NativeFieldInfoPtr_enc;

			// Token: 0x040049BC RID: 18876
			private static readonly IntPtr NativeFieldInfoPtr_decoder;

			// Token: 0x040049BD RID: 18877
			private static readonly IntPtr NativeFieldInfoPtr_byteStart;

			// Token: 0x040049BE RID: 18878
			private static readonly IntPtr NativeFieldInfoPtr_byteEnd;

			// Token: 0x040049BF RID: 18879
			private static readonly IntPtr NativeFieldInfoPtr_bytes;

			// Token: 0x040049C0 RID: 18880
			private static readonly IntPtr NativeFieldInfoPtr_fallbackBuffer;

			// Token: 0x040049C1 RID: 18881
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Encoding_DecoderNLS_ptr_Char_Int32_ptr_Byte_Int32_0;

			// Token: 0x040049C2 RID: 18882
			private static readonly IntPtr NativeMethodInfoPtr_AddChar_Internal_Boolean_Char_Int32_0;

			// Token: 0x040049C3 RID: 18883
			private static readonly IntPtr NativeMethodInfoPtr_AddChar_Internal_Boolean_Char_0;

			// Token: 0x040049C4 RID: 18884
			private static readonly IntPtr NativeMethodInfoPtr_AdjustBytes_Internal_Void_Int32_0;

			// Token: 0x040049C5 RID: 18885
			private static readonly IntPtr NativeMethodInfoPtr_get_MoreData_Internal_get_Boolean_0;

			// Token: 0x040049C6 RID: 18886
			private static readonly IntPtr NativeMethodInfoPtr_GetNextByte_Internal_Byte_0;

			// Token: 0x040049C7 RID: 18887
			private static readonly IntPtr NativeMethodInfoPtr_get_BytesUsed_Internal_get_Int32_0;

			// Token: 0x040049C8 RID: 18888
			private static readonly IntPtr NativeMethodInfoPtr_Fallback_Internal_Boolean_Byte_0;

			// Token: 0x040049C9 RID: 18889
			private static readonly IntPtr NativeMethodInfoPtr_Fallback_Internal_Boolean_Il2CppStructArray_1_Byte_0;

			// Token: 0x040049CA RID: 18890
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Internal_get_Int32_0;
		}

		// Token: 0x02000659 RID: 1625
		public class EncodingByteBuffer : Object
		{
			// Token: 0x06005A30 RID: 23088 RVA: 0x0019C990 File Offset: 0x0019AB90
			// Note: this type is marked as 'beforefieldinit'.
			static EncodingByteBuffer()
			{
				Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "EncodingByteBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr);
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_bytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "bytes");
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_byteStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "byteStart");
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_byteEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "byteEnd");
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "chars");
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_charStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "charStart");
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_charEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "charEnd");
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_byteCountResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "byteCountResult");
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_enc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "enc");
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_encoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "encoder");
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_fallbackBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "fallbackBuffer");
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr__ctor_Internal_Void_Encoding_EncoderNLS_ptr_Byte_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100669307);
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100669308);
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100669309);
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100669310);
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100669311);
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr_MovePrevious_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100669312);
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr_get_MoreData_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100669313);
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr_GetNextChar_Internal_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100669314);
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr_get_CharsUsed_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100669315);
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100669316);
			}

			// Token: 0x06005A31 RID: 23089 RVA: 0x0019CB4C File Offset: 0x0019AD4C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1368021, RefRangeEnd = 1368022, XrefRangeStart = 1367988, XrefRangeEnd = 1368021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EncodingByteBuffer(Encoding inEncoding, EncoderNLS inEncoder, byte* inByteStart, int inByteCount, char* inCharStart, int inCharCount)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(inEncoding);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inEncoder);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = inByteStart;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inByteCount;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = inCharStart;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inCharCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr__ctor_Internal_Void_Encoding_EncoderNLS_ptr_Byte_Int32_ptr_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A32 RID: 23090 RVA: 0x0019CBE0 File Offset: 0x0019ADE0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1368022, RefRangeEnd = 1368025, XrefRangeStart = 1368022, XrefRangeEnd = 1368022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool AddByte(byte b, int moreBytesExpected)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref b;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moreBytesExpected;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005A33 RID: 23091 RVA: 0x0019CC38 File Offset: 0x0019AE38
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1368026, RefRangeEnd = 1368034, XrefRangeStart = 1368025, XrefRangeEnd = 1368026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool AddByte(byte b1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref b1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005A34 RID: 23092 RVA: 0x0019CC84 File Offset: 0x0019AE84
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1368035, RefRangeEnd = 1368036, XrefRangeStart = 1368034, XrefRangeEnd = 1368035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool AddByte(byte b1, byte b2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref b1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005A35 RID: 23093 RVA: 0x0019CCDC File Offset: 0x0019AEDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368036, XrefRangeEnd = 1368037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool AddByte(byte b1, byte b2, int moreBytesExpected)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref b1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moreBytesExpected;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005A36 RID: 23094 RVA: 0x0019CD44 File Offset: 0x0019AF44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368037, XrefRangeEnd = 1368039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MovePrevious(bool bThrow)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref bThrow;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr_MovePrevious_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001709 RID: 5897
			// (get) Token: 0x06005A37 RID: 23095 RVA: 0x0019CD84 File Offset: 0x0019AF84
			public unsafe bool MoreData
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1368039, RefRangeEnd = 1368040, XrefRangeStart = 1368039, XrefRangeEnd = 1368039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr_get_MoreData_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005A38 RID: 23096 RVA: 0x0019CDC0 File Offset: 0x0019AFC0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1368041, RefRangeEnd = 1368044, XrefRangeStart = 1368040, XrefRangeEnd = 1368041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe char GetNextChar()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr_GetNextChar_Internal_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700170A RID: 5898
			// (get) Token: 0x06005A39 RID: 23097 RVA: 0x0019CDFC File Offset: 0x0019AFFC
			public unsafe int CharsUsed
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1368044, RefRangeEnd = 1368045, XrefRangeStart = 1368044, XrefRangeEnd = 1368044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr_get_CharsUsed_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700170B RID: 5899
			// (get) Token: 0x06005A3A RID: 23098 RVA: 0x0019CE38 File Offset: 0x0019B038
			public unsafe int Count
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005A3B RID: 23099 RVA: 0x000204FD File Offset: 0x0001E6FD
			public EncodingByteBuffer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016FF RID: 5887
			// (get) Token: 0x06005A3C RID: 23100 RVA: 0x0019CE74 File Offset: 0x0019B074
			// (set) Token: 0x06005A3D RID: 23101 RVA: 0x00020506 File Offset: 0x0001E706
			public unsafe byte* bytes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_bytes);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_bytes)) = value;
				}
			}

			// Token: 0x17001700 RID: 5888
			// (get) Token: 0x06005A3E RID: 23102 RVA: 0x0019CE98 File Offset: 0x0019B098
			// (set) Token: 0x06005A3F RID: 23103 RVA: 0x00020521 File Offset: 0x0001E721
			public unsafe byte* byteStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_byteStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_byteStart)) = value;
				}
			}

			// Token: 0x17001701 RID: 5889
			// (get) Token: 0x06005A40 RID: 23104 RVA: 0x0019CEBC File Offset: 0x0019B0BC
			// (set) Token: 0x06005A41 RID: 23105 RVA: 0x0002053C File Offset: 0x0001E73C
			public unsafe byte* byteEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_byteEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_byteEnd)) = value;
				}
			}

			// Token: 0x17001702 RID: 5890
			// (get) Token: 0x06005A42 RID: 23106 RVA: 0x0019CEE0 File Offset: 0x0019B0E0
			// (set) Token: 0x06005A43 RID: 23107 RVA: 0x00020557 File Offset: 0x0001E757
			public unsafe char* chars
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_chars);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_chars)) = value;
				}
			}

			// Token: 0x17001703 RID: 5891
			// (get) Token: 0x06005A44 RID: 23108 RVA: 0x0019CF04 File Offset: 0x0019B104
			// (set) Token: 0x06005A45 RID: 23109 RVA: 0x00020572 File Offset: 0x0001E772
			public unsafe char* charStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_charStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_charStart)) = value;
				}
			}

			// Token: 0x17001704 RID: 5892
			// (get) Token: 0x06005A46 RID: 23110 RVA: 0x0019CF28 File Offset: 0x0019B128
			// (set) Token: 0x06005A47 RID: 23111 RVA: 0x0002058D File Offset: 0x0001E78D
			public unsafe char* charEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_charEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_charEnd)) = value;
				}
			}

			// Token: 0x17001705 RID: 5893
			// (get) Token: 0x06005A48 RID: 23112 RVA: 0x0019CF4C File Offset: 0x0019B14C
			// (set) Token: 0x06005A49 RID: 23113 RVA: 0x000205A8 File Offset: 0x0001E7A8
			public unsafe int byteCountResult
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_byteCountResult);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_byteCountResult)) = value;
				}
			}

			// Token: 0x17001706 RID: 5894
			// (get) Token: 0x06005A4A RID: 23114 RVA: 0x0019CF74 File Offset: 0x0019B174
			// (set) Token: 0x06005A4B RID: 23115 RVA: 0x000205C3 File Offset: 0x0001E7C3
			public unsafe Encoding enc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_enc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_enc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001707 RID: 5895
			// (get) Token: 0x06005A4C RID: 23116 RVA: 0x0019CFA4 File Offset: 0x0019B1A4
			// (set) Token: 0x06005A4D RID: 23117 RVA: 0x000205E2 File Offset: 0x0001E7E2
			public unsafe EncoderNLS encoder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_encoder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EncoderNLS>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_encoder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001708 RID: 5896
			// (get) Token: 0x06005A4E RID: 23118 RVA: 0x0019CFD4 File Offset: 0x0019B1D4
			// (set) Token: 0x06005A4F RID: 23119 RVA: 0x00020601 File Offset: 0x0001E801
			public unsafe EncoderFallbackBuffer fallbackBuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_fallbackBuffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EncoderFallbackBuffer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_fallbackBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040049CB RID: 18891
			private static readonly IntPtr NativeFieldInfoPtr_bytes;

			// Token: 0x040049CC RID: 18892
			private static readonly IntPtr NativeFieldInfoPtr_byteStart;

			// Token: 0x040049CD RID: 18893
			private static readonly IntPtr NativeFieldInfoPtr_byteEnd;

			// Token: 0x040049CE RID: 18894
			private static readonly IntPtr NativeFieldInfoPtr_chars;

			// Token: 0x040049CF RID: 18895
			private static readonly IntPtr NativeFieldInfoPtr_charStart;

			// Token: 0x040049D0 RID: 18896
			private static readonly IntPtr NativeFieldInfoPtr_charEnd;

			// Token: 0x040049D1 RID: 18897
			private static readonly IntPtr NativeFieldInfoPtr_byteCountResult;

			// Token: 0x040049D2 RID: 18898
			private static readonly IntPtr NativeFieldInfoPtr_enc;

			// Token: 0x040049D3 RID: 18899
			private static readonly IntPtr NativeFieldInfoPtr_encoder;

			// Token: 0x040049D4 RID: 18900
			private static readonly IntPtr NativeFieldInfoPtr_fallbackBuffer;

			// Token: 0x040049D5 RID: 18901
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Encoding_EncoderNLS_ptr_Byte_Int32_ptr_Char_Int32_0;

			// Token: 0x040049D6 RID: 18902
			private static readonly IntPtr NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_Int32_0;

			// Token: 0x040049D7 RID: 18903
			private static readonly IntPtr NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_0;

			// Token: 0x040049D8 RID: 18904
			private static readonly IntPtr NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_Byte_0;

			// Token: 0x040049D9 RID: 18905
			private static readonly IntPtr NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_Byte_Int32_0;

			// Token: 0x040049DA RID: 18906
			private static readonly IntPtr NativeMethodInfoPtr_MovePrevious_Internal_Void_Boolean_0;

			// Token: 0x040049DB RID: 18907
			private static readonly IntPtr NativeMethodInfoPtr_get_MoreData_Internal_get_Boolean_0;

			// Token: 0x040049DC RID: 18908
			private static readonly IntPtr NativeMethodInfoPtr_GetNextChar_Internal_Char_0;

			// Token: 0x040049DD RID: 18909
			private static readonly IntPtr NativeMethodInfoPtr_get_CharsUsed_Internal_get_Int32_0;

			// Token: 0x040049DE RID: 18910
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Internal_get_Int32_0;
		}
	}
}

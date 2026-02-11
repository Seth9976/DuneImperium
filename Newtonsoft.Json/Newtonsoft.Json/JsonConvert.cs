using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Numerics;
using Il2CppSystem.Reflection;
using Il2CppSystem.Xml;
using Il2CppSystem.Xml.Linq;

namespace Newtonsoft.Json
{
	// Token: 0x02000019 RID: 25
	public static class JsonConvert : Object
	{
		// Token: 0x06000080 RID: 128 RVA: 0x00013828 File Offset: 0x00011A28
		// Note: this type is marked as 'beforefieldinit'.
		static JsonConvert()
		{
			Il2CppClassPointerStore<JsonConvert>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json", "JsonConvert");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr);
			JsonConvert.NativeFieldInfoPtr__DefaultSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, "<DefaultSettings>k__BackingField");
			JsonConvert.NativeFieldInfoPtr_True = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, "True");
			JsonConvert.NativeFieldInfoPtr_False = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, "False");
			JsonConvert.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, "Null");
			JsonConvert.NativeFieldInfoPtr_Undefined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, "Undefined");
			JsonConvert.NativeFieldInfoPtr_PositiveInfinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, "PositiveInfinity");
			JsonConvert.NativeFieldInfoPtr_NegativeInfinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, "NegativeInfinity");
			JsonConvert.NativeFieldInfoPtr_NaN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, "NaN");
			JsonConvert.NativeMethodInfoPtr_get_DefaultSettings_Public_Static_get_Func_1_JsonSerializerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663354);
			JsonConvert.NativeMethodInfoPtr_set_DefaultSettings_Public_Static_set_Void_Func_1_JsonSerializerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663355);
			JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663356);
			JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_DateTime_DateFormatHandling_DateTimeZoneHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663357);
			JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663358);
			JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_DateTimeOffset_DateFormatHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663359);
			JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663360);
			JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663361);
			JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663362);
			JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663363);
			JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663364);
			JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663365);
			JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663366);
			JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663367);
			JsonConvert.NativeMethodInfoPtr_ToStringInternal_Private_Static_String_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663368);
			JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663369);
			JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663370);
			JsonConvert.NativeMethodInfoPtr_ToString_Internal_Static_String_Single_FloatFormatHandling_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663371);
			JsonConvert.NativeMethodInfoPtr_EnsureFloatFormat_Private_Static_String_Double_String_FloatFormatHandling_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663372);
			JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663373);
			JsonConvert.NativeMethodInfoPtr_ToString_Internal_Static_String_Double_FloatFormatHandling_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663374);
			JsonConvert.NativeMethodInfoPtr_EnsureDecimalPlace_Private_Static_String_Double_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663375);
			JsonConvert.NativeMethodInfoPtr_EnsureDecimalPlace_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663376);
			JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663377);
			JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663378);
			JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663379);
			JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663380);
			JsonConvert.NativeMethodInfoPtr_ToString_Internal_Static_String_Guid_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663381);
			JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663382);
			JsonConvert.NativeMethodInfoPtr_ToString_Internal_Static_String_TimeSpan_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663383);
			JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663384);
			JsonConvert.NativeMethodInfoPtr_ToString_Internal_Static_String_Uri_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663385);
			JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663386);
			JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663387);
			JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_String_Char_StringEscapeHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663388);
			JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663389);
			JsonConvert.NativeMethodInfoPtr_SerializeObject_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663390);
			JsonConvert.NativeMethodInfoPtr_SerializeObject_Public_Static_String_Object_Formatting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663391);
			JsonConvert.NativeMethodInfoPtr_SerializeObject_Public_Static_String_Object_Il2CppReferenceArray_1_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663392);
			JsonConvert.NativeMethodInfoPtr_SerializeObject_Public_Static_String_Object_Formatting_Il2CppReferenceArray_1_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663393);
			JsonConvert.NativeMethodInfoPtr_SerializeObject_Public_Static_String_Object_JsonSerializerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663394);
			JsonConvert.NativeMethodInfoPtr_SerializeObject_Public_Static_String_Object_Type_JsonSerializerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663395);
			JsonConvert.NativeMethodInfoPtr_SerializeObject_Public_Static_String_Object_Formatting_JsonSerializerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663396);
			JsonConvert.NativeMethodInfoPtr_SerializeObject_Public_Static_String_Object_Type_Formatting_JsonSerializerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663397);
			JsonConvert.NativeMethodInfoPtr_SerializeObjectInternal_Private_Static_String_Object_Type_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663398);
			JsonConvert.NativeMethodInfoPtr_DeserializeObject_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663399);
			JsonConvert.NativeMethodInfoPtr_DeserializeObject_Public_Static_Object_String_JsonSerializerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663400);
			JsonConvert.NativeMethodInfoPtr_DeserializeObject_Public_Static_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663401);
			JsonConvert.NativeMethodInfoPtr_DeserializeObject_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663402);
			JsonConvert.NativeMethodInfoPtr_DeserializeAnonymousType_Public_Static_T_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663403);
			JsonConvert.NativeMethodInfoPtr_DeserializeAnonymousType_Public_Static_T_String_T_JsonSerializerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663404);
			JsonConvert.NativeMethodInfoPtr_DeserializeObject_Public_Static_T_String_Il2CppReferenceArray_1_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663405);
			JsonConvert.NativeMethodInfoPtr_DeserializeObject_Public_Static_T_String_JsonSerializerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663406);
			JsonConvert.NativeMethodInfoPtr_DeserializeObject_Public_Static_Object_String_Type_Il2CppReferenceArray_1_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663407);
			JsonConvert.NativeMethodInfoPtr_DeserializeObject_Public_Static_Object_String_Type_JsonSerializerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663408);
			JsonConvert.NativeMethodInfoPtr_PopulateObject_Public_Static_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663409);
			JsonConvert.NativeMethodInfoPtr_PopulateObject_Public_Static_Void_String_Object_JsonSerializerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663410);
			JsonConvert.NativeMethodInfoPtr_SerializeXmlNode_Public_Static_String_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663411);
			JsonConvert.NativeMethodInfoPtr_SerializeXmlNode_Public_Static_String_XmlNode_Formatting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663412);
			JsonConvert.NativeMethodInfoPtr_SerializeXmlNode_Public_Static_String_XmlNode_Formatting_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663413);
			JsonConvert.NativeMethodInfoPtr_DeserializeXmlNode_Public_Static_XmlDocument_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663414);
			JsonConvert.NativeMethodInfoPtr_DeserializeXmlNode_Public_Static_XmlDocument_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663415);
			JsonConvert.NativeMethodInfoPtr_DeserializeXmlNode_Public_Static_XmlDocument_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663416);
			JsonConvert.NativeMethodInfoPtr_DeserializeXmlNode_Public_Static_XmlDocument_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663417);
			JsonConvert.NativeMethodInfoPtr_SerializeXNode_Public_Static_String_XObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663418);
			JsonConvert.NativeMethodInfoPtr_SerializeXNode_Public_Static_String_XObject_Formatting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663419);
			JsonConvert.NativeMethodInfoPtr_SerializeXNode_Public_Static_String_XObject_Formatting_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663420);
			JsonConvert.NativeMethodInfoPtr_DeserializeXNode_Public_Static_XDocument_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663421);
			JsonConvert.NativeMethodInfoPtr_DeserializeXNode_Public_Static_XDocument_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663422);
			JsonConvert.NativeMethodInfoPtr_DeserializeXNode_Public_Static_XDocument_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663423);
			JsonConvert.NativeMethodInfoPtr_DeserializeXNode_Public_Static_XDocument_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonConvert>.NativeClassPtr, 100663424);
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00013E84 File Offset: 0x00012084
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00013EB8 File Offset: 0x000120B8
		public unsafe static Func<JsonSerializerSettings> DefaultSettings
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727012, XrefRangeEnd = 727016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_get_DefaultSettings_Public_Static_get_Func_1_JsonSerializerSettings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<JsonSerializerSettings>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727016, XrefRangeEnd = 727022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_set_DefaultSettings_Public_Static_set_Void_Func_1_JsonSerializerSettings_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00013EF0 File Offset: 0x000120F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727022, XrefRangeEnd = 727026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00013F28 File Offset: 0x00012128
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 727044, RefRangeEnd = 727045, XrefRangeStart = 727026, XrefRangeEnd = 727044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(DateTime value, DateFormatHandling format, DateTimeZoneHandling timeZoneHandling)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeZoneHandling;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_DateTime_DateFormatHandling_DateTimeZoneHandling_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00013F7C File Offset: 0x0001217C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727045, XrefRangeEnd = 727049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00013FB4 File Offset: 0x000121B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 727064, RefRangeEnd = 727065, XrefRangeStart = 727049, XrefRangeEnd = 727064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(DateTimeOffset value, DateFormatHandling format)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_DateTimeOffset_DateFormatHandling_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00013FFC File Offset: 0x000121FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 727069, RefRangeEnd = 727071, XrefRangeStart = 727065, XrefRangeEnd = 727069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00014034 File Offset: 0x00012234
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 727079, RefRangeEnd = 727081, XrefRangeStart = 727071, XrefRangeEnd = 727079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0001406C File Offset: 0x0001226C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727081, XrefRangeEnd = 727128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Enum value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Enum_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000140A4 File Offset: 0x000122A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727128, XrefRangeEnd = 727133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000140DC File Offset: 0x000122DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727133, XrefRangeEnd = 727138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00014114 File Offset: 0x00012314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727138, XrefRangeEnd = 727143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0001414C File Offset: 0x0001234C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727143, XrefRangeEnd = 727148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00014184 File Offset: 0x00012384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727148, XrefRangeEnd = 727153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000141BC File Offset: 0x000123BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727153, XrefRangeEnd = 727161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToStringInternal(BigInteger value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToStringInternal_Private_Static_String_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00014200 File Offset: 0x00012400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727161, XrefRangeEnd = 727166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00014238 File Offset: 0x00012438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727166, XrefRangeEnd = 727177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00014270 File Offset: 0x00012470
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 727189, RefRangeEnd = 727192, XrefRangeStart = 727177, XrefRangeEnd = 727189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref floatFormatHandling;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quoteChar;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nullable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Internal_Static_String_Single_FloatFormatHandling_Char_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000142D4 File Offset: 0x000124D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 727200, RefRangeEnd = 727202, XrefRangeStart = 727192, XrefRangeEnd = 727200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref floatFormatHandling;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quoteChar;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nullable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_EnsureFloatFormat_Private_Static_String_Double_String_FloatFormatHandling_Char_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00014348 File Offset: 0x00012548
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 727213, RefRangeEnd = 727218, XrefRangeStart = 727202, XrefRangeEnd = 727213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00014380 File Offset: 0x00012580
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 727230, RefRangeEnd = 727233, XrefRangeStart = 727218, XrefRangeEnd = 727230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref floatFormatHandling;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quoteChar;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nullable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Internal_Static_String_Double_FloatFormatHandling_Char_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000143E4 File Offset: 0x000125E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 727239, RefRangeEnd = 727243, XrefRangeStart = 727233, XrefRangeEnd = 727239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EnsureDecimalPlace(double value, string text)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_EnsureDecimalPlace_Private_Static_String_Double_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00014430 File Offset: 0x00012630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727243, XrefRangeEnd = 727247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EnsureDecimalPlace(string text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_EnsureDecimalPlace_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0001446C File Offset: 0x0001266C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727247, XrefRangeEnd = 727252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000144A4 File Offset: 0x000126A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727252, XrefRangeEnd = 727257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000144DC File Offset: 0x000126DC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 727272, RefRangeEnd = 727277, XrefRangeStart = 727257, XrefRangeEnd = 727272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00014514 File Offset: 0x00012714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727277, XrefRangeEnd = 727293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Guid value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Guid_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0001454C File Offset: 0x0001274C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727293, XrefRangeEnd = 727306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Guid value, char quoteChar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quoteChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Internal_Static_String_Guid_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00014594 File Offset: 0x00012794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727306, XrefRangeEnd = 727323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(TimeSpan value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000145CC File Offset: 0x000127CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727323, XrefRangeEnd = 727331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(TimeSpan value, char quoteChar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quoteChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Internal_Static_String_TimeSpan_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00014614 File Offset: 0x00012814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727331, XrefRangeEnd = 727349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Uri value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Uri_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00014650 File Offset: 0x00012850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727349, XrefRangeEnd = 727355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Uri value, char quoteChar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quoteChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Internal_Static_String_Uri_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0001469C File Offset: 0x0001289C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 727365, RefRangeEnd = 727367, XrefRangeStart = 727355, XrefRangeEnd = 727365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000146D8 File Offset: 0x000128D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 727374, RefRangeEnd = 727376, XrefRangeStart = 727367, XrefRangeEnd = 727374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(string value, char delimiter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delimiter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_String_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00014724 File Offset: 0x00012924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727376, XrefRangeEnd = 727380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delimiter;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stringEscapeHandling;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_String_Char_StringEscapeHandling_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0001477C File Offset: 0x0001297C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 727418, RefRangeEnd = 727419, XrefRangeStart = 727380, XrefRangeEnd = 727418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_ToString_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000147B8 File Offset: 0x000129B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727419, XrefRangeEnd = 727427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SerializeObject(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_SerializeObject_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000147F4 File Offset: 0x000129F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727427, XrefRangeEnd = 727439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SerializeObject(Object value, Formatting formatting)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatting;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_SerializeObject_Public_Static_String_Object_Formatting_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00014840 File Offset: 0x00012A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727439, XrefRangeEnd = 727455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SerializeObject(Object value, [Optional] Il2CppReferenceArray<JsonConverter> converters)
		{
			if (converters == null)
			{
				converters = new Il2CppReferenceArray<JsonConverter>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_SerializeObject_Public_Static_String_Object_Il2CppReferenceArray_1_JsonConverter_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0001489C File Offset: 0x00012A9C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 727465, RefRangeEnd = 727471, XrefRangeStart = 727455, XrefRangeEnd = 727465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SerializeObject(Object value, Formatting formatting, [Optional] Il2CppReferenceArray<JsonConverter> converters)
		{
			if (converters == null)
			{
				converters = new Il2CppReferenceArray<JsonConverter>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatting;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_SerializeObject_Public_Static_String_Object_Formatting_Il2CppReferenceArray_1_JsonConverter_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00014908 File Offset: 0x00012B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727471, XrefRangeEnd = 727480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SerializeObject(Object value, JsonSerializerSettings settings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_SerializeObject_Public_Static_String_Object_JsonSerializerSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00014958 File Offset: 0x00012B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727480, XrefRangeEnd = 727486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SerializeObject(Object value, Type type, JsonSerializerSettings settings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_SerializeObject_Public_Static_String_Object_Type_JsonSerializerSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000149B8 File Offset: 0x00012BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727486, XrefRangeEnd = 727490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SerializeObject(Object value, Formatting formatting, JsonSerializerSettings settings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatting;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_SerializeObject_Public_Static_String_Object_Formatting_JsonSerializerSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00014A14 File Offset: 0x00012C14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 727497, RefRangeEnd = 727499, XrefRangeStart = 727490, XrefRangeEnd = 727497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SerializeObject(Object value, Type type, Formatting formatting, JsonSerializerSettings settings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatting;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_SerializeObject_Public_Static_String_Object_Type_Formatting_JsonSerializerSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00014A84 File Offset: 0x00012C84
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 727522, RefRangeEnd = 727528, XrefRangeStart = 727499, XrefRangeEnd = 727522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SerializeObjectInternal(Object value, Type type, JsonSerializer jsonSerializer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(jsonSerializer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_SerializeObjectInternal_Private_Static_String_Object_Type_JsonSerializer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00014AE4 File Offset: 0x00012CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727528, XrefRangeEnd = 727532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object DeserializeObject(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_DeserializeObject_Public_Static_Object_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00014B28 File Offset: 0x00012D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727532, XrefRangeEnd = 727536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object DeserializeObject(string value, JsonSerializerSettings settings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_DeserializeObject_Public_Static_Object_String_JsonSerializerSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00014B80 File Offset: 0x00012D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727536, XrefRangeEnd = 727540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object DeserializeObject(string value, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_DeserializeObject_Public_Static_Object_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00014BD8 File Offset: 0x00012DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727540, XrefRangeEnd = 727546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T DeserializeObject<T>(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.MethodInfoStoreGeneric_DeserializeObject_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00014C18 File Offset: 0x00012E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727546, XrefRangeEnd = 727552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = anonymousTypeObject;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref anonymousTypeObject;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(JsonConvert.MethodInfoStoreGeneric_DeserializeAnonymousType_Public_Static_T_String_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00014CA0 File Offset: 0x00012EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727552, XrefRangeEnd = 727558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject, JsonSerializerSettings settings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = anonymousTypeObject;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref anonymousTypeObject;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(JsonConvert.MethodInfoStoreGeneric_DeserializeAnonymousType_Public_Static_T_String_T_JsonSerializerSettings_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00014D38 File Offset: 0x00012F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727558, XrefRangeEnd = 727571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T DeserializeObject<T>(string value, [Optional] Il2CppReferenceArray<JsonConverter> converters)
		{
			if (converters == null)
			{
				converters = new Il2CppReferenceArray<JsonConverter>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.MethodInfoStoreGeneric_DeserializeObject_Public_Static_T_String_Il2CppReferenceArray_1_JsonConverter_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00014D98 File Offset: 0x00012F98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 727581, RefRangeEnd = 727582, XrefRangeStart = 727571, XrefRangeEnd = 727581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T DeserializeObject<T>(string value, JsonSerializerSettings settings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.MethodInfoStoreGeneric_DeserializeObject_Public_Static_T_String_JsonSerializerSettings_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00014DE8 File Offset: 0x00012FE8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 727593, RefRangeEnd = 727598, XrefRangeStart = 727582, XrefRangeEnd = 727593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object DeserializeObject(string value, Type type, [Optional] Il2CppReferenceArray<JsonConverter> converters)
		{
			if (converters == null)
			{
				converters = new Il2CppReferenceArray<JsonConverter>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_DeserializeObject_Public_Static_Object_String_Type_Il2CppReferenceArray_1_JsonConverter_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00014E60 File Offset: 0x00013060
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 727618, RefRangeEnd = 727624, XrefRangeStart = 727598, XrefRangeEnd = 727618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object DeserializeObject(string value, Type type, JsonSerializerSettings settings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_DeserializeObject_Public_Static_Object_String_Type_JsonSerializerSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00014EC8 File Offset: 0x000130C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727624, XrefRangeEnd = 727628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PopulateObject(string value, Object target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_PopulateObject_Public_Static_Void_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00014F10 File Offset: 0x00013110
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 727646, RefRangeEnd = 727647, XrefRangeStart = 727628, XrefRangeEnd = 727646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PopulateObject(string value, Object target, JsonSerializerSettings settings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_PopulateObject_Public_Static_Void_String_Object_JsonSerializerSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00014F6C File Offset: 0x0001316C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727647, XrefRangeEnd = 727667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SerializeXmlNode(XmlNode node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_SerializeXmlNode_Public_Static_String_XmlNode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00014FA8 File Offset: 0x000131A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727667, XrefRangeEnd = 727684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SerializeXmlNode(XmlNode node, Formatting formatting)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatting;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_SerializeXmlNode_Public_Static_String_XmlNode_Formatting_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00014FF4 File Offset: 0x000131F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727684, XrefRangeEnd = 727701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SerializeXmlNode(XmlNode node, Formatting formatting, bool omitRootObject)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatting;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref omitRootObject;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_SerializeXmlNode_Public_Static_String_XmlNode_Formatting_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0001504C File Offset: 0x0001324C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727701, XrefRangeEnd = 727708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlDocument DeserializeXmlNode(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_DeserializeXmlNode_Public_Static_XmlDocument_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr3) : null;
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00015090 File Offset: 0x00013290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727708, XrefRangeEnd = 727712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deserializeRootElementName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_DeserializeXmlNode_Public_Static_XmlDocument_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr3) : null;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000150E8 File Offset: 0x000132E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 727737, RefRangeEnd = 727739, XrefRangeStart = 727712, XrefRangeEnd = 727737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName, bool writeArrayAttribute)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deserializeRootElementName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeArrayAttribute;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_DeserializeXmlNode_Public_Static_XmlDocument_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr3) : null;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0001514C File Offset: 0x0001334C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727739, XrefRangeEnd = 727761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName, bool writeArrayAttribute, bool encodeSpecialCharacters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deserializeRootElementName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeArrayAttribute;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref encodeSpecialCharacters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_DeserializeXmlNode_Public_Static_XmlDocument_String_String_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr3) : null;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000151C0 File Offset: 0x000133C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727761, XrefRangeEnd = 727784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SerializeXNode(XObject node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_SerializeXNode_Public_Static_String_XObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000151FC File Offset: 0x000133FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727784, XrefRangeEnd = 727804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SerializeXNode(XObject node, Formatting formatting)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatting;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_SerializeXNode_Public_Static_String_XObject_Formatting_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00015248 File Offset: 0x00013448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727804, XrefRangeEnd = 727821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SerializeXNode(XObject node, Formatting formatting, bool omitRootObject)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatting;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref omitRootObject;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_SerializeXNode_Public_Static_String_XObject_Formatting_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000152A0 File Offset: 0x000134A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727821, XrefRangeEnd = 727828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XDocument DeserializeXNode(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_DeserializeXNode_Public_Static_XDocument_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XDocument>(intPtr3) : null;
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000152E4 File Offset: 0x000134E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727828, XrefRangeEnd = 727832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XDocument DeserializeXNode(string value, string deserializeRootElementName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deserializeRootElementName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_DeserializeXNode_Public_Static_XDocument_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XDocument>(intPtr3) : null;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0001533C File Offset: 0x0001353C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 727857, RefRangeEnd = 727859, XrefRangeStart = 727832, XrefRangeEnd = 727857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XDocument DeserializeXNode(string value, string deserializeRootElementName, bool writeArrayAttribute)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deserializeRootElementName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeArrayAttribute;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_DeserializeXNode_Public_Static_XDocument_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XDocument>(intPtr3) : null;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000153A0 File Offset: 0x000135A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727859, XrefRangeEnd = 727881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XDocument DeserializeXNode(string value, string deserializeRootElementName, bool writeArrayAttribute, bool encodeSpecialCharacters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deserializeRootElementName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeArrayAttribute;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref encodeSpecialCharacters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonConvert.NativeMethodInfoPtr_DeserializeXNode_Public_Static_XDocument_String_String_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XDocument>(intPtr3) : null;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000024CB File Offset: 0x000006CB
		public static string SerializeObject(Object value, params JsonConverter[] converters)
		{
			return JsonConvert.SerializeObject(value, new Il2CppReferenceArray<JsonConverter>(converters));
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000024D9 File Offset: 0x000006D9
		public static string SerializeObject(Object value, Formatting formatting, params JsonConverter[] converters)
		{
			return JsonConvert.SerializeObject(value, formatting, new Il2CppReferenceArray<JsonConverter>(converters));
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000024E8 File Offset: 0x000006E8
		public static T DeserializeObject<T>(string value, params JsonConverter[] converters)
		{
			return JsonConvert.DeserializeObject(value, new Il2CppReferenceArray<JsonConverter>(converters));
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000024F6 File Offset: 0x000006F6
		public static Object DeserializeObject(string value, Type type, params JsonConverter[] converters)
		{
			return JsonConvert.DeserializeObject(value, type, new Il2CppReferenceArray<JsonConverter>(converters));
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002505 File Offset: 0x00000705
		public JsonConvert(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00015414 File Offset: 0x00013614
		// (set) Token: 0x060000CE RID: 206 RVA: 0x0000250E File Offset: 0x0000070E
		public unsafe static Func<JsonSerializerSettings> _DefaultSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonConvert.NativeFieldInfoPtr__DefaultSettings_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<JsonSerializerSettings>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonConvert.NativeFieldInfoPtr__DefaultSettings_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000CF RID: 207 RVA: 0x0001543C File Offset: 0x0001363C
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00002520 File Offset: 0x00000720
		public unsafe static string True
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonConvert.NativeFieldInfoPtr_True, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonConvert.NativeFieldInfoPtr_True, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x0001545C File Offset: 0x0001365C
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00002532 File Offset: 0x00000732
		public unsafe static string False
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonConvert.NativeFieldInfoPtr_False, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonConvert.NativeFieldInfoPtr_False, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x0001547C File Offset: 0x0001367C
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00002544 File Offset: 0x00000744
		public unsafe static string Null
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonConvert.NativeFieldInfoPtr_Null, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonConvert.NativeFieldInfoPtr_Null, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x0001549C File Offset: 0x0001369C
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00002556 File Offset: 0x00000756
		public unsafe static string Undefined
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonConvert.NativeFieldInfoPtr_Undefined, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonConvert.NativeFieldInfoPtr_Undefined, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x000154BC File Offset: 0x000136BC
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00002568 File Offset: 0x00000768
		public unsafe static string PositiveInfinity
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonConvert.NativeFieldInfoPtr_PositiveInfinity, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonConvert.NativeFieldInfoPtr_PositiveInfinity, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x000154DC File Offset: 0x000136DC
		// (set) Token: 0x060000DA RID: 218 RVA: 0x0000257A File Offset: 0x0000077A
		public unsafe static string NegativeInfinity
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonConvert.NativeFieldInfoPtr_NegativeInfinity, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonConvert.NativeFieldInfoPtr_NegativeInfinity, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000DB RID: 219 RVA: 0x000154FC File Offset: 0x000136FC
		// (set) Token: 0x060000DC RID: 220 RVA: 0x0000258C File Offset: 0x0000078C
		public unsafe static string NaN
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonConvert.NativeFieldInfoPtr_NaN, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonConvert.NativeFieldInfoPtr_NaN, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr__DefaultSettings_k__BackingField;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_True;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_False;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_Undefined;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_PositiveInfinity;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_NegativeInfinity;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_NaN;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultSettings_Public_Static_get_Func_1_JsonSerializerSettings_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultSettings_Public_Static_set_Void_Func_1_JsonSerializerSettings_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_DateTime_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_DateTime_DateFormatHandling_DateTimeZoneHandling_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_DateTimeOffset_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_DateTimeOffset_DateFormatHandling_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Boolean_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Char_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Enum_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int32_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int16_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_UInt16_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_UInt32_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int64_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_ToStringInternal_Private_Static_String_BigInteger_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_UInt64_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Single_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Static_String_Single_FloatFormatHandling_Char_Boolean_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_EnsureFloatFormat_Private_Static_String_Double_String_FloatFormatHandling_Char_Boolean_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Double_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Static_String_Double_FloatFormatHandling_Char_Boolean_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_EnsureDecimalPlace_Private_Static_String_Double_String_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_EnsureDecimalPlace_Private_Static_String_String_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Byte_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_SByte_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Decimal_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Guid_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Static_String_Guid_Char_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_TimeSpan_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Static_String_TimeSpan_Char_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Uri_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_Static_String_Uri_Char_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_String_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_String_Char_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_String_Char_StringEscapeHandling_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Object_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_SerializeObject_Public_Static_String_Object_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_SerializeObject_Public_Static_String_Object_Formatting_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_SerializeObject_Public_Static_String_Object_Il2CppReferenceArray_1_JsonConverter_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_SerializeObject_Public_Static_String_Object_Formatting_Il2CppReferenceArray_1_JsonConverter_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_SerializeObject_Public_Static_String_Object_JsonSerializerSettings_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_SerializeObject_Public_Static_String_Object_Type_JsonSerializerSettings_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_SerializeObject_Public_Static_String_Object_Formatting_JsonSerializerSettings_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_SerializeObject_Public_Static_String_Object_Type_Formatting_JsonSerializerSettings_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_SerializeObjectInternal_Private_Static_String_Object_Type_JsonSerializer_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeObject_Public_Static_Object_String_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeObject_Public_Static_Object_String_JsonSerializerSettings_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeObject_Public_Static_Object_String_Type_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeObject_Public_Static_T_String_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeAnonymousType_Public_Static_T_String_T_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeAnonymousType_Public_Static_T_String_T_JsonSerializerSettings_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeObject_Public_Static_T_String_Il2CppReferenceArray_1_JsonConverter_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeObject_Public_Static_T_String_JsonSerializerSettings_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeObject_Public_Static_Object_String_Type_Il2CppReferenceArray_1_JsonConverter_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeObject_Public_Static_Object_String_Type_JsonSerializerSettings_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_PopulateObject_Public_Static_Void_String_Object_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_PopulateObject_Public_Static_Void_String_Object_JsonSerializerSettings_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_SerializeXmlNode_Public_Static_String_XmlNode_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_SerializeXmlNode_Public_Static_String_XmlNode_Formatting_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_SerializeXmlNode_Public_Static_String_XmlNode_Formatting_Boolean_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeXmlNode_Public_Static_XmlDocument_String_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeXmlNode_Public_Static_XmlDocument_String_String_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeXmlNode_Public_Static_XmlDocument_String_String_Boolean_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeXmlNode_Public_Static_XmlDocument_String_String_Boolean_Boolean_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_SerializeXNode_Public_Static_String_XObject_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_SerializeXNode_Public_Static_String_XObject_Formatting_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_SerializeXNode_Public_Static_String_XObject_Formatting_Boolean_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeXNode_Public_Static_XDocument_String_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeXNode_Public_Static_XDocument_String_String_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeXNode_Public_Static_XDocument_String_String_Boolean_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeXNode_Public_Static_XDocument_String_String_Boolean_Boolean_0;

		// Token: 0x02000113 RID: 275
		private sealed class MethodInfoStoreGeneric_DeserializeObject_Public_Static_T_String_0<T>
		{
			// Token: 0x0400121F RID: 4639
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonConvert.NativeMethodInfoPtr_DeserializeObject_Public_Static_T_String_0, Il2CppClassPointerStore<JsonConvert>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000114 RID: 276
		private sealed class MethodInfoStoreGeneric_DeserializeAnonymousType_Public_Static_T_String_T_0<T>
		{
			// Token: 0x04001220 RID: 4640
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonConvert.NativeMethodInfoPtr_DeserializeAnonymousType_Public_Static_T_String_T_0, Il2CppClassPointerStore<JsonConvert>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000115 RID: 277
		private sealed class MethodInfoStoreGeneric_DeserializeAnonymousType_Public_Static_T_String_T_JsonSerializerSettings_0<T>
		{
			// Token: 0x04001221 RID: 4641
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonConvert.NativeMethodInfoPtr_DeserializeAnonymousType_Public_Static_T_String_T_JsonSerializerSettings_0, Il2CppClassPointerStore<JsonConvert>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000116 RID: 278
		private sealed class MethodInfoStoreGeneric_DeserializeObject_Public_Static_T_String_Il2CppReferenceArray_1_JsonConverter_0<T>
		{
			// Token: 0x04001222 RID: 4642
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonConvert.NativeMethodInfoPtr_DeserializeObject_Public_Static_T_String_Il2CppReferenceArray_1_JsonConverter_0, Il2CppClassPointerStore<JsonConvert>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000117 RID: 279
		private sealed class MethodInfoStoreGeneric_DeserializeObject_Public_Static_T_String_JsonSerializerSettings_0<T>
		{
			// Token: 0x04001223 RID: 4643
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonConvert.NativeMethodInfoPtr_DeserializeObject_Public_Static_T_String_JsonSerializerSettings_0, Il2CppClassPointerStore<JsonConvert>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

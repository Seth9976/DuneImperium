using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace Newtonsoft.Json
{
	// Token: 0x02000031 RID: 49
	public class JsonValidatingReader : JsonReader
	{
		// Token: 0x060004E2 RID: 1250 RVA: 0x000286D0 File Offset: 0x000268D0
		// Note: this type is marked as 'beforefieldinit'.
		static JsonValidatingReader()
		{
			Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json", "JsonValidatingReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr);
			JsonValidatingReader.NativeFieldInfoPtr__reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, "_reader");
			JsonValidatingReader.NativeFieldInfoPtr__stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, "_stack");
			JsonValidatingReader.NativeFieldInfoPtr__schema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, "_schema");
			JsonValidatingReader.NativeFieldInfoPtr__model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, "_model");
			JsonValidatingReader.NativeFieldInfoPtr__currentScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, "_currentScope");
			JsonValidatingReader.NativeFieldInfoPtr_ValidationEventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, "ValidationEventHandler");
			JsonValidatingReader.NativeFieldInfoPtr_EmptySchemaList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, "EmptySchemaList");
			JsonValidatingReader.NativeMethodInfoPtr_add_ValidationEventHandler_Public_add_Void_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664221);
			JsonValidatingReader.NativeMethodInfoPtr_remove_ValidationEventHandler_Public_rem_Void_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664222);
			JsonValidatingReader.NativeMethodInfoPtr_get_Value_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664223);
			JsonValidatingReader.NativeMethodInfoPtr_get_Depth_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664224);
			JsonValidatingReader.NativeMethodInfoPtr_get_Path_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664225);
			JsonValidatingReader.NativeMethodInfoPtr_get_QuoteChar_Public_Virtual_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664226);
			JsonValidatingReader.NativeMethodInfoPtr_set_QuoteChar_FamOrAssem_Virtual_set_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664227);
			JsonValidatingReader.NativeMethodInfoPtr_get_TokenType_Public_Virtual_get_JsonToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664228);
			JsonValidatingReader.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664229);
			JsonValidatingReader.NativeMethodInfoPtr_Push_Private_Void_SchemaScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664230);
			JsonValidatingReader.NativeMethodInfoPtr_Pop_Private_SchemaScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664231);
			JsonValidatingReader.NativeMethodInfoPtr_get_CurrentSchemas_Private_get_IList_1_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664232);
			JsonValidatingReader.NativeMethodInfoPtr_get_CurrentMemberSchemas_Private_get_IList_1_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664233);
			JsonValidatingReader.NativeMethodInfoPtr_RaiseError_Private_Void_String_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664234);
			JsonValidatingReader.NativeMethodInfoPtr_OnValidationEvent_Private_Void_JsonSchemaException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664235);
			JsonValidatingReader.NativeMethodInfoPtr__ctor_Public_Void_JsonReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664236);
			JsonValidatingReader.NativeMethodInfoPtr_get_Schema_Public_get_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664237);
			JsonValidatingReader.NativeMethodInfoPtr_set_Schema_Public_set_Void_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664238);
			JsonValidatingReader.NativeMethodInfoPtr_get_Reader_Public_get_JsonReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664239);
			JsonValidatingReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664240);
			JsonValidatingReader.NativeMethodInfoPtr_ValidateNotDisallowed_Private_Void_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664241);
			JsonValidatingReader.NativeMethodInfoPtr_GetCurrentNodeSchemaType_Private_Nullable_1_JsonSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664242);
			JsonValidatingReader.NativeMethodInfoPtr_ReadAsInt32_Public_Virtual_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664243);
			JsonValidatingReader.NativeMethodInfoPtr_ReadAsBytes_Public_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664244);
			JsonValidatingReader.NativeMethodInfoPtr_ReadAsDecimal_Public_Virtual_Nullable_1_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664245);
			JsonValidatingReader.NativeMethodInfoPtr_ReadAsDouble_Public_Virtual_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664246);
			JsonValidatingReader.NativeMethodInfoPtr_ReadAsBoolean_Public_Virtual_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664247);
			JsonValidatingReader.NativeMethodInfoPtr_ReadAsString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664248);
			JsonValidatingReader.NativeMethodInfoPtr_ReadAsDateTime_Public_Virtual_Nullable_1_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664249);
			JsonValidatingReader.NativeMethodInfoPtr_ReadAsDateTimeOffset_Public_Virtual_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664250);
			JsonValidatingReader.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664251);
			JsonValidatingReader.NativeMethodInfoPtr_ValidateCurrentToken_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664252);
			JsonValidatingReader.NativeMethodInfoPtr_WriteToken_Private_Void_IList_1_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664253);
			JsonValidatingReader.NativeMethodInfoPtr_ValidateEndObject_Private_Void_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664254);
			JsonValidatingReader.NativeMethodInfoPtr_ValidateEndArray_Private_Void_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664255);
			JsonValidatingReader.NativeMethodInfoPtr_ValidateNull_Private_Void_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664256);
			JsonValidatingReader.NativeMethodInfoPtr_ValidateBoolean_Private_Void_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664257);
			JsonValidatingReader.NativeMethodInfoPtr_ValidateString_Private_Void_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664258);
			JsonValidatingReader.NativeMethodInfoPtr_ValidateInteger_Private_Void_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664259);
			JsonValidatingReader.NativeMethodInfoPtr_ProcessValue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664260);
			JsonValidatingReader.NativeMethodInfoPtr_ValidateFloat_Private_Void_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664261);
			JsonValidatingReader.NativeMethodInfoPtr_FloatingPointRemainder_Private_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664262);
			JsonValidatingReader.NativeMethodInfoPtr_IsZero_Private_Static_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664263);
			JsonValidatingReader.NativeMethodInfoPtr_ValidatePropertyName_Private_Void_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664264);
			JsonValidatingReader.NativeMethodInfoPtr_IsPropertyDefinied_Private_Boolean_JsonSchemaModel_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664265);
			JsonValidatingReader.NativeMethodInfoPtr_ValidateArray_Private_Boolean_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664266);
			JsonValidatingReader.NativeMethodInfoPtr_ValidateObject_Private_Boolean_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664267);
			JsonValidatingReader.NativeMethodInfoPtr_TestType_Private_Boolean_JsonSchemaModel_JsonSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664268);
			JsonValidatingReader.NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_HasLineInfo_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664269);
			JsonValidatingReader.NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664270);
			JsonValidatingReader.NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, 100664271);
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00028B88 File Offset: 0x00026D88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 736348, RefRangeEnd = 736349, XrefRangeStart = 736344, XrefRangeEnd = 736348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ValidationEventHandler(ValidationEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_add_ValidationEventHandler_Public_add_Void_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00028BCC File Offset: 0x00026DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736349, XrefRangeEnd = 736353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ValidationEventHandler(ValidationEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_remove_ValidationEventHandler_Public_rem_Void_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00028C10 File Offset: 0x00026E10
		public unsafe override Object Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736353, XrefRangeEnd = 736354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonValidatingReader.NativeMethodInfoPtr_get_Value_Public_Virtual_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x00028C5C File Offset: 0x00026E5C
		public unsafe override int Depth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736354, XrefRangeEnd = 736355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonValidatingReader.NativeMethodInfoPtr_get_Depth_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00028CA4 File Offset: 0x00026EA4
		public unsafe override string Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736355, XrefRangeEnd = 736356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonValidatingReader.NativeMethodInfoPtr_get_Path_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x00028CE8 File Offset: 0x00026EE8
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x00028D30 File Offset: 0x00026F30
		public unsafe override char QuoteChar
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736356, XrefRangeEnd = 736357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonValidatingReader.NativeMethodInfoPtr_get_QuoteChar_Public_Virtual_get_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonValidatingReader.NativeMethodInfoPtr_set_QuoteChar_FamOrAssem_Virtual_set_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x00028D7C File Offset: 0x00026F7C
		public unsafe override JsonToken TokenType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736357, XrefRangeEnd = 736358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonValidatingReader.NativeMethodInfoPtr_get_TokenType_Public_Virtual_get_JsonToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x00028DC4 File Offset: 0x00026FC4
		public unsafe override Type ValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736358, XrefRangeEnd = 736359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonValidatingReader.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00028E10 File Offset: 0x00027010
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 736364, RefRangeEnd = 736366, XrefRangeStart = 736359, XrefRangeEnd = 736364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(JsonValidatingReader.SchemaScope scope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scope);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_Push_Private_Void_SchemaScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00028E54 File Offset: 0x00027054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736366, XrefRangeEnd = 736375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe JsonValidatingReader.SchemaScope Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_Pop_Private_SchemaScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonValidatingReader.SchemaScope>(intPtr3) : null;
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x00028E94 File Offset: 0x00027094
		public unsafe IList<JsonSchemaModel> CurrentSchemas
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_get_CurrentSchemas_Private_get_IList_1_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<JsonSchemaModel>>(intPtr3) : null;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x00028ED4 File Offset: 0x000270D4
		public unsafe IList<JsonSchemaModel> CurrentMemberSchemas
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 736428, RefRangeEnd = 736430, XrefRangeStart = 736375, XrefRangeEnd = 736428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_get_CurrentMemberSchemas_Private_get_IList_1_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<JsonSchemaModel>>(intPtr3) : null;
			}
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00028F14 File Offset: 0x00027114
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 736465, RefRangeEnd = 736486, XrefRangeStart = 736430, XrefRangeEnd = 736465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RaiseError(string message, JsonSchemaModel schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_RaiseError_Private_Void_String_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00028F68 File Offset: 0x00027168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736486, XrefRangeEnd = 736492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidationEvent(JsonSchemaException exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_OnValidationEvent_Private_Void_JsonSchemaException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00028FAC File Offset: 0x000271AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 736504, RefRangeEnd = 736505, XrefRangeStart = 736492, XrefRangeEnd = 736504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonValidatingReader(JsonReader reader)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr__ctor_Public_Void_JsonReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00028FF8 File Offset: 0x000271F8
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x00029038 File Offset: 0x00027238
		public unsafe JsonSchema Schema
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_get_Schema_Public_get_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchema>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 736513, RefRangeEnd = 736514, XrefRangeStart = 736505, XrefRangeEnd = 736513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_set_Schema_Public_set_Void_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x0002907C File Offset: 0x0002727C
		public unsafe JsonReader Reader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_get_Reader_Public_get_JsonReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonReader>(intPtr3) : null;
			}
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x000290BC File Offset: 0x000272BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736514, XrefRangeEnd = 736515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonValidatingReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x000290F8 File Offset: 0x000272F8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 736554, RefRangeEnd = 736559, XrefRangeStart = 736515, XrefRangeEnd = 736554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateNotDisallowed(JsonSchemaModel schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_ValidateNotDisallowed_Private_Void_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0002913C File Offset: 0x0002733C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736559, XrefRangeEnd = 736562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<JsonSchemaType> GetCurrentNodeSchemaType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_GetCurrentNodeSchemaType_Private_Nullable_1_JsonSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<JsonSchemaType>(intPtr);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00029174 File Offset: 0x00027374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736562, XrefRangeEnd = 736563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<int> ReadAsInt32()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonValidatingReader.NativeMethodInfoPtr_ReadAsInt32_Public_Virtual_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<int>(intPtr);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x000291B8 File Offset: 0x000273B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736563, XrefRangeEnd = 736564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> ReadAsBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonValidatingReader.NativeMethodInfoPtr_ReadAsBytes_Public_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00029204 File Offset: 0x00027404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736564, XrefRangeEnd = 736565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<Decimal> ReadAsDecimal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonValidatingReader.NativeMethodInfoPtr_ReadAsDecimal_Public_Virtual_Nullable_1_Decimal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<Decimal>(intPtr);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00029248 File Offset: 0x00027448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736565, XrefRangeEnd = 736566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<double> ReadAsDouble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonValidatingReader.NativeMethodInfoPtr_ReadAsDouble_Public_Virtual_Nullable_1_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<double>(intPtr);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0002928C File Offset: 0x0002748C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736566, XrefRangeEnd = 736567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<bool> ReadAsBoolean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonValidatingReader.NativeMethodInfoPtr_ReadAsBoolean_Public_Virtual_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<bool>(intPtr);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x000292D0 File Offset: 0x000274D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736567, XrefRangeEnd = 736568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ReadAsString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonValidatingReader.NativeMethodInfoPtr_ReadAsString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00029314 File Offset: 0x00027514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736568, XrefRangeEnd = 736569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<DateTime> ReadAsDateTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonValidatingReader.NativeMethodInfoPtr_ReadAsDateTime_Public_Virtual_Nullable_1_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<DateTime>(intPtr);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00029358 File Offset: 0x00027558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736569, XrefRangeEnd = 736570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<DateTimeOffset> ReadAsDateTimeOffset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonValidatingReader.NativeMethodInfoPtr_ReadAsDateTimeOffset_Public_Virtual_Nullable_1_DateTimeOffset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<DateTimeOffset>(intPtr);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0002939C File Offset: 0x0002759C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736570, XrefRangeEnd = 736571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonValidatingReader.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x000293E4 File Offset: 0x000275E4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 736608, RefRangeEnd = 736617, XrefRangeStart = 736571, XrefRangeEnd = 736608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateCurrentToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_ValidateCurrentToken_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00029418 File Offset: 0x00027618
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 736756, RefRangeEnd = 736757, XrefRangeStart = 736617, XrefRangeEnd = 736756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteToken(IList<JsonSchemaModel> schemas)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_WriteToken_Private_Void_IList_1_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0002945C File Offset: 0x0002765C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736757, XrefRangeEnd = 736823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateEndObject(JsonSchemaModel schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_ValidateEndObject_Private_Void_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x000294A0 File Offset: 0x000276A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736823, XrefRangeEnd = 736850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateEndArray(JsonSchemaModel schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_ValidateEndArray_Private_Void_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x000294E4 File Offset: 0x000276E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736850, XrefRangeEnd = 736852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateNull(JsonSchemaModel schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_ValidateNull_Private_Void_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00029528 File Offset: 0x00027728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736852, XrefRangeEnd = 736854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateBoolean(JsonSchemaModel schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_ValidateBoolean_Private_Void_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0002956C File Offset: 0x0002776C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736854, XrefRangeEnd = 736906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateString(JsonSchemaModel schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_ValidateString_Private_Void_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x000295B0 File Offset: 0x000277B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736906, XrefRangeEnd = 737010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateInteger(JsonSchemaModel schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_ValidateInteger_Private_Void_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x000295F4 File Offset: 0x000277F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 737041, RefRangeEnd = 737042, XrefRangeStart = 737010, XrefRangeEnd = 737041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_ProcessValue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00029628 File Offset: 0x00027828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737042, XrefRangeEnd = 737124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateFloat(JsonSchemaModel schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_ValidateFloat_Private_Void_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0002966C File Offset: 0x0002786C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737124, XrefRangeEnd = 737128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double FloatingPointRemainder(double dividend, double divisor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dividend;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref divisor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_FloatingPointRemainder_Private_Static_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x000296B8 File Offset: 0x000278B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 737131, RefRangeEnd = 737133, XrefRangeStart = 737128, XrefRangeEnd = 737131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsZero(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_IsZero_Private_Static_Boolean_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x000296F8 File Offset: 0x000278F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737133, XrefRangeEnd = 737156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidatePropertyName(JsonSchemaModel schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_ValidatePropertyName_Private_Void_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0002973C File Offset: 0x0002793C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 737164, RefRangeEnd = 737165, XrefRangeStart = 737156, XrefRangeEnd = 737164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPropertyDefinied(JsonSchemaModel schema, string propertyName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_IsPropertyDefinied_Private_Boolean_JsonSchemaModel_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0002979C File Offset: 0x0002799C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737165, XrefRangeEnd = 737166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateArray(JsonSchemaModel schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_ValidateArray_Private_Boolean_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x000297EC File Offset: 0x000279EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737166, XrefRangeEnd = 737167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateObject(JsonSchemaModel schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_ValidateObject_Private_Boolean_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0002983C File Offset: 0x00027A3C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 737174, RefRangeEnd = 737181, XrefRangeStart = 737167, XrefRangeEnd = 737174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TestType(JsonSchemaModel currentSchema, JsonSchemaType currentType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentSchema);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_TestType_Private_Boolean_JsonSchemaModel_JsonSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00029898 File Offset: 0x00027A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737181, XrefRangeEnd = 737184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Newtonsoft_Json_IJsonLineInfo_HasLineInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_HasLineInfo_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x000298D4 File Offset: 0x00027AD4
		public unsafe virtual int Newtonsoft.Json.IJsonLineInfo.LineNumber
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737184, XrefRangeEnd = 737189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x00029910 File Offset: 0x00027B10
		public unsafe virtual int Newtonsoft.Json.IJsonLineInfo.LinePosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737189, XrefRangeEnd = 737194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00003B07 File Offset: 0x00001D07
		public JsonValidatingReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x0002994C File Offset: 0x00027B4C
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x00003B10 File Offset: 0x00001D10
		public unsafe JsonReader _reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.NativeFieldInfoPtr__reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.NativeFieldInfoPtr__reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x0002997C File Offset: 0x00027B7C
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x00003B2F File Offset: 0x00001D2F
		public new unsafe Stack<JsonValidatingReader.SchemaScope> _stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.NativeFieldInfoPtr__stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<JsonValidatingReader.SchemaScope>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.NativeFieldInfoPtr__stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x000299AC File Offset: 0x00027BAC
		// (set) Token: 0x0600051C RID: 1308 RVA: 0x00003B4E File Offset: 0x00001D4E
		public unsafe JsonSchema _schema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.NativeFieldInfoPtr__schema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.NativeFieldInfoPtr__schema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x000299DC File Offset: 0x00027BDC
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x00003B6D File Offset: 0x00001D6D
		public unsafe JsonSchemaModel _model
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.NativeFieldInfoPtr__model);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSchemaModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.NativeFieldInfoPtr__model), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x00029A0C File Offset: 0x00027C0C
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x00003B8C File Offset: 0x00001D8C
		public unsafe JsonValidatingReader.SchemaScope _currentScope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.NativeFieldInfoPtr__currentScope);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonValidatingReader.SchemaScope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.NativeFieldInfoPtr__currentScope), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x00029A3C File Offset: 0x00027C3C
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x00003BAB File Offset: 0x00001DAB
		public unsafe ValidationEventHandler ValidationEventHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.NativeFieldInfoPtr_ValidationEventHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.NativeFieldInfoPtr_ValidationEventHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x00029A6C File Offset: 0x00027C6C
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x00003BCA File Offset: 0x00001DCA
		public unsafe static IList<JsonSchemaModel> EmptySchemaList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonValidatingReader.NativeFieldInfoPtr_EmptySchemaList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<JsonSchemaModel>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonValidatingReader.NativeFieldInfoPtr_EmptySchemaList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeFieldInfoPtr__reader;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeFieldInfoPtr__stack;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeFieldInfoPtr__schema;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeFieldInfoPtr__model;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeFieldInfoPtr__currentScope;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeFieldInfoPtr_ValidationEventHandler;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeFieldInfoPtr_EmptySchemaList;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeMethodInfoPtr_add_ValidationEventHandler_Public_add_Void_ValidationEventHandler_0;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr_remove_ValidationEventHandler_Public_rem_Void_ValidationEventHandler_0;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_Object_0;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeMethodInfoPtr_get_Depth_Public_Virtual_get_Int32_0;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeMethodInfoPtr_get_Path_Public_Virtual_get_String_0;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeMethodInfoPtr_get_QuoteChar_Public_Virtual_get_Char_0;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeMethodInfoPtr_set_QuoteChar_FamOrAssem_Virtual_set_Void_Char_0;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeMethodInfoPtr_get_TokenType_Public_Virtual_get_JsonToken_0;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeMethodInfoPtr_Push_Private_Void_SchemaScope_0;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Private_SchemaScope_0;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSchemas_Private_get_IList_1_JsonSchemaModel_0;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentMemberSchemas_Private_get_IList_1_JsonSchemaModel_0;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeMethodInfoPtr_RaiseError_Private_Void_String_JsonSchemaModel_0;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeMethodInfoPtr_OnValidationEvent_Private_Void_JsonSchemaException_0;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_JsonReader_0;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeMethodInfoPtr_get_Schema_Public_get_JsonSchema_0;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeMethodInfoPtr_set_Schema_Public_set_Void_JsonSchema_0;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr_get_Reader_Public_get_JsonReader_0;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeMethodInfoPtr_ValidateNotDisallowed_Private_Void_JsonSchemaModel_0;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentNodeSchemaType_Private_Nullable_1_JsonSchemaType_0;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsInt32_Public_Virtual_Nullable_1_Int32_0;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsBytes_Public_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsDecimal_Public_Virtual_Nullable_1_Decimal_0;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsDouble_Public_Virtual_Nullable_1_Double_0;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsBoolean_Public_Virtual_Nullable_1_Boolean_0;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsString_Public_Virtual_String_0;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsDateTime_Public_Virtual_Nullable_1_DateTime_0;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsDateTimeOffset_Public_Virtual_Nullable_1_DateTimeOffset_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeMethodInfoPtr_ValidateCurrentToken_Private_Void_0;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeMethodInfoPtr_WriteToken_Private_Void_IList_1_JsonSchemaModel_0;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEndObject_Private_Void_JsonSchemaModel_0;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEndArray_Private_Void_JsonSchemaModel_0;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr_ValidateNull_Private_Void_JsonSchemaModel_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr_ValidateBoolean_Private_Void_JsonSchemaModel_0;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeMethodInfoPtr_ValidateString_Private_Void_JsonSchemaModel_0;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr_ValidateInteger_Private_Void_JsonSchemaModel_0;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeMethodInfoPtr_ProcessValue_Private_Void_0;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFloat_Private_Void_JsonSchemaModel_0;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeMethodInfoPtr_FloatingPointRemainder_Private_Static_Double_Double_Double_0;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeMethodInfoPtr_IsZero_Private_Static_Boolean_Double_0;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeMethodInfoPtr_ValidatePropertyName_Private_Void_JsonSchemaModel_0;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeMethodInfoPtr_IsPropertyDefinied_Private_Boolean_JsonSchemaModel_String_0;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr_ValidateArray_Private_Boolean_JsonSchemaModel_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr_ValidateObject_Private_Boolean_JsonSchemaModel_0;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeMethodInfoPtr_TestType_Private_Boolean_JsonSchemaModel_JsonSchemaType_0;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_HasLineInfo_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x0200015A RID: 346
		public class SchemaScope : Object
		{
			// Token: 0x06001B04 RID: 6916 RVA: 0x000826A0 File Offset: 0x000808A0
			// Note: this type is marked as 'beforefieldinit'.
			static SchemaScope()
			{
				Il2CppClassPointerStore<JsonValidatingReader.SchemaScope>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, "SchemaScope");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope>.NativeClassPtr);
				JsonValidatingReader.SchemaScope.NativeFieldInfoPtr__tokenType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope>.NativeClassPtr, "_tokenType");
				JsonValidatingReader.SchemaScope.NativeFieldInfoPtr__schemas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope>.NativeClassPtr, "_schemas");
				JsonValidatingReader.SchemaScope.NativeFieldInfoPtr__requiredProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope>.NativeClassPtr, "_requiredProperties");
				JsonValidatingReader.SchemaScope.NativeFieldInfoPtr__CurrentPropertyName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope>.NativeClassPtr, "<CurrentPropertyName>k__BackingField");
				JsonValidatingReader.SchemaScope.NativeFieldInfoPtr__ArrayItemCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope>.NativeClassPtr, "<ArrayItemCount>k__BackingField");
				JsonValidatingReader.SchemaScope.NativeFieldInfoPtr__IsUniqueArray_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope>.NativeClassPtr, "<IsUniqueArray>k__BackingField");
				JsonValidatingReader.SchemaScope.NativeFieldInfoPtr__UniqueArrayItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope>.NativeClassPtr, "<UniqueArrayItems>k__BackingField");
				JsonValidatingReader.SchemaScope.NativeFieldInfoPtr__CurrentItemWriter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope>.NativeClassPtr, "<CurrentItemWriter>k__BackingField");
				JsonValidatingReader.SchemaScope.NativeMethodInfoPtr_get_CurrentPropertyName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope>.NativeClassPtr, 100664273);
				JsonValidatingReader.SchemaScope.NativeMethodInfoPtr_set_CurrentPropertyName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope>.NativeClassPtr, 100664274);
				JsonValidatingReader.SchemaScope.NativeMethodInfoPtr_get_ArrayItemCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope>.NativeClassPtr, 100664275);
				JsonValidatingReader.SchemaScope.NativeMethodInfoPtr_set_ArrayItemCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope>.NativeClassPtr, 100664276);
				JsonValidatingReader.SchemaScope.NativeMethodInfoPtr_get_IsUniqueArray_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope>.NativeClassPtr, 100664277);
				JsonValidatingReader.SchemaScope.NativeMethodInfoPtr_get_UniqueArrayItems_Public_get_IList_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope>.NativeClassPtr, 100664278);
				JsonValidatingReader.SchemaScope.NativeMethodInfoPtr_get_CurrentItemWriter_Public_get_JTokenWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope>.NativeClassPtr, 100664279);
				JsonValidatingReader.SchemaScope.NativeMethodInfoPtr_set_CurrentItemWriter_Public_set_Void_JTokenWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope>.NativeClassPtr, 100664280);
				JsonValidatingReader.SchemaScope.NativeMethodInfoPtr_get_Schemas_Public_get_IList_1_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope>.NativeClassPtr, 100664281);
				JsonValidatingReader.SchemaScope.NativeMethodInfoPtr_get_RequiredProperties_Public_get_Dictionary_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope>.NativeClassPtr, 100664282);
				JsonValidatingReader.SchemaScope.NativeMethodInfoPtr_get_TokenType_Public_get_JTokenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope>.NativeClassPtr, 100664283);
				JsonValidatingReader.SchemaScope.NativeMethodInfoPtr__ctor_Public_Void_JTokenType_IList_1_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope>.NativeClassPtr, 100664284);
				JsonValidatingReader.SchemaScope.NativeMethodInfoPtr_GetRequiredProperties_Private_IEnumerable_1_String_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope>.NativeClassPtr, 100664285);
			}

			// Token: 0x17000791 RID: 1937
			// (get) Token: 0x06001B05 RID: 6917 RVA: 0x00082870 File Offset: 0x00080A70
			// (set) Token: 0x06001B06 RID: 6918 RVA: 0x000828A8 File Offset: 0x00080AA8
			public unsafe string CurrentPropertyName
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.SchemaScope.NativeMethodInfoPtr_get_CurrentPropertyName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.SchemaScope.NativeMethodInfoPtr_set_CurrentPropertyName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000792 RID: 1938
			// (get) Token: 0x06001B07 RID: 6919 RVA: 0x000828EC File Offset: 0x00080AEC
			// (set) Token: 0x06001B08 RID: 6920 RVA: 0x00082928 File Offset: 0x00080B28
			public unsafe int ArrayItemCount
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.SchemaScope.NativeMethodInfoPtr_get_ArrayItemCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 137951, RefRangeEnd = 137952, XrefRangeStart = 137951, XrefRangeEnd = 137952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.SchemaScope.NativeMethodInfoPtr_set_ArrayItemCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000793 RID: 1939
			// (get) Token: 0x06001B09 RID: 6921 RVA: 0x00082968 File Offset: 0x00080B68
			public unsafe bool IsUniqueArray
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.SchemaScope.NativeMethodInfoPtr_get_IsUniqueArray_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000794 RID: 1940
			// (get) Token: 0x06001B0A RID: 6922 RVA: 0x000829A4 File Offset: 0x00080BA4
			public unsafe IList<JToken> UniqueArrayItems
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.SchemaScope.NativeMethodInfoPtr_get_UniqueArrayItems_Public_get_IList_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<JToken>>(intPtr3) : null;
				}
			}

			// Token: 0x17000795 RID: 1941
			// (get) Token: 0x06001B0B RID: 6923 RVA: 0x000829E4 File Offset: 0x00080BE4
			// (set) Token: 0x06001B0C RID: 6924 RVA: 0x00082A24 File Offset: 0x00080C24
			public unsafe JTokenWriter CurrentItemWriter
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.SchemaScope.NativeMethodInfoPtr_get_CurrentItemWriter_Public_get_JTokenWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JTokenWriter>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.SchemaScope.NativeMethodInfoPtr_set_CurrentItemWriter_Public_set_Void_JTokenWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000796 RID: 1942
			// (get) Token: 0x06001B0D RID: 6925 RVA: 0x00082A68 File Offset: 0x00080C68
			public unsafe IList<JsonSchemaModel> Schemas
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.SchemaScope.NativeMethodInfoPtr_get_Schemas_Public_get_IList_1_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<JsonSchemaModel>>(intPtr3) : null;
				}
			}

			// Token: 0x17000797 RID: 1943
			// (get) Token: 0x06001B0E RID: 6926 RVA: 0x00082AA8 File Offset: 0x00080CA8
			public unsafe Dictionary<string, bool> RequiredProperties
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.SchemaScope.NativeMethodInfoPtr_get_RequiredProperties_Public_get_Dictionary_2_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, bool>>(intPtr3) : null;
				}
			}

			// Token: 0x17000798 RID: 1944
			// (get) Token: 0x06001B0F RID: 6927 RVA: 0x00082AE8 File Offset: 0x00080CE8
			public unsafe JTokenType TokenType
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.SchemaScope.NativeMethodInfoPtr_get_TokenType_Public_get_JTokenType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B10 RID: 6928 RVA: 0x00082B24 File Offset: 0x00080D24
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 736299, RefRangeEnd = 736301, XrefRangeStart = 736228, XrefRangeEnd = 736299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SchemaScope(JTokenType tokenType, IList<JsonSchemaModel> schemas)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref tokenType;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.SchemaScope.NativeMethodInfoPtr__ctor_Public_Void_JTokenType_IList_1_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B11 RID: 6929 RVA: 0x00082B80 File Offset: 0x00080D80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736301, XrefRangeEnd = 736342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<string> GetRequiredProperties(JsonSchemaModel schema)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.SchemaScope.NativeMethodInfoPtr_GetRequiredProperties_Private_IEnumerable_1_String_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
				}
			}

			// Token: 0x06001B12 RID: 6930 RVA: 0x0000D03C File Offset: 0x0000B23C
			public SchemaScope(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000789 RID: 1929
			// (get) Token: 0x06001B13 RID: 6931 RVA: 0x00082BD0 File Offset: 0x00080DD0
			// (set) Token: 0x06001B14 RID: 6932 RVA: 0x0000D045 File Offset: 0x0000B245
			public unsafe JTokenType _tokenType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.SchemaScope.NativeFieldInfoPtr__tokenType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.SchemaScope.NativeFieldInfoPtr__tokenType)) = value;
				}
			}

			// Token: 0x1700078A RID: 1930
			// (get) Token: 0x06001B15 RID: 6933 RVA: 0x00082BF8 File Offset: 0x00080DF8
			// (set) Token: 0x06001B16 RID: 6934 RVA: 0x0000D060 File Offset: 0x0000B260
			public unsafe IList<JsonSchemaModel> _schemas
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.SchemaScope.NativeFieldInfoPtr__schemas);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<JsonSchemaModel>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.SchemaScope.NativeFieldInfoPtr__schemas), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700078B RID: 1931
			// (get) Token: 0x06001B17 RID: 6935 RVA: 0x00082C28 File Offset: 0x00080E28
			// (set) Token: 0x06001B18 RID: 6936 RVA: 0x0000D07F File Offset: 0x0000B27F
			public unsafe Dictionary<string, bool> _requiredProperties
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.SchemaScope.NativeFieldInfoPtr__requiredProperties);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.SchemaScope.NativeFieldInfoPtr__requiredProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700078C RID: 1932
			// (get) Token: 0x06001B19 RID: 6937 RVA: 0x00082C58 File Offset: 0x00080E58
			// (set) Token: 0x06001B1A RID: 6938 RVA: 0x0000D09E File Offset: 0x0000B29E
			public unsafe string _CurrentPropertyName_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.SchemaScope.NativeFieldInfoPtr__CurrentPropertyName_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.SchemaScope.NativeFieldInfoPtr__CurrentPropertyName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700078D RID: 1933
			// (get) Token: 0x06001B1B RID: 6939 RVA: 0x00082C80 File Offset: 0x00080E80
			// (set) Token: 0x06001B1C RID: 6940 RVA: 0x0000D0BD File Offset: 0x0000B2BD
			public unsafe int _ArrayItemCount_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.SchemaScope.NativeFieldInfoPtr__ArrayItemCount_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.SchemaScope.NativeFieldInfoPtr__ArrayItemCount_k__BackingField)) = value;
				}
			}

			// Token: 0x1700078E RID: 1934
			// (get) Token: 0x06001B1D RID: 6941 RVA: 0x00082CA8 File Offset: 0x00080EA8
			// (set) Token: 0x06001B1E RID: 6942 RVA: 0x0000D0D8 File Offset: 0x0000B2D8
			public unsafe bool _IsUniqueArray_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.SchemaScope.NativeFieldInfoPtr__IsUniqueArray_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.SchemaScope.NativeFieldInfoPtr__IsUniqueArray_k__BackingField)) = value;
				}
			}

			// Token: 0x1700078F RID: 1935
			// (get) Token: 0x06001B1F RID: 6943 RVA: 0x00082CD0 File Offset: 0x00080ED0
			// (set) Token: 0x06001B20 RID: 6944 RVA: 0x0000D0F3 File Offset: 0x0000B2F3
			public unsafe IList<JToken> _UniqueArrayItems_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.SchemaScope.NativeFieldInfoPtr__UniqueArrayItems_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.SchemaScope.NativeFieldInfoPtr__UniqueArrayItems_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000790 RID: 1936
			// (get) Token: 0x06001B21 RID: 6945 RVA: 0x00082D00 File Offset: 0x00080F00
			// (set) Token: 0x06001B22 RID: 6946 RVA: 0x0000D112 File Offset: 0x0000B312
			public unsafe JTokenWriter _CurrentItemWriter_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.SchemaScope.NativeFieldInfoPtr__CurrentItemWriter_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JTokenWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonValidatingReader.SchemaScope.NativeFieldInfoPtr__CurrentItemWriter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001453 RID: 5203
			private static readonly IntPtr NativeFieldInfoPtr__tokenType;

			// Token: 0x04001454 RID: 5204
			private static readonly IntPtr NativeFieldInfoPtr__schemas;

			// Token: 0x04001455 RID: 5205
			private static readonly IntPtr NativeFieldInfoPtr__requiredProperties;

			// Token: 0x04001456 RID: 5206
			private static readonly IntPtr NativeFieldInfoPtr__CurrentPropertyName_k__BackingField;

			// Token: 0x04001457 RID: 5207
			private static readonly IntPtr NativeFieldInfoPtr__ArrayItemCount_k__BackingField;

			// Token: 0x04001458 RID: 5208
			private static readonly IntPtr NativeFieldInfoPtr__IsUniqueArray_k__BackingField;

			// Token: 0x04001459 RID: 5209
			private static readonly IntPtr NativeFieldInfoPtr__UniqueArrayItems_k__BackingField;

			// Token: 0x0400145A RID: 5210
			private static readonly IntPtr NativeFieldInfoPtr__CurrentItemWriter_k__BackingField;

			// Token: 0x0400145B RID: 5211
			private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPropertyName_Public_get_String_0;

			// Token: 0x0400145C RID: 5212
			private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPropertyName_Public_set_Void_String_0;

			// Token: 0x0400145D RID: 5213
			private static readonly IntPtr NativeMethodInfoPtr_get_ArrayItemCount_Public_get_Int32_0;

			// Token: 0x0400145E RID: 5214
			private static readonly IntPtr NativeMethodInfoPtr_set_ArrayItemCount_Public_set_Void_Int32_0;

			// Token: 0x0400145F RID: 5215
			private static readonly IntPtr NativeMethodInfoPtr_get_IsUniqueArray_Public_get_Boolean_0;

			// Token: 0x04001460 RID: 5216
			private static readonly IntPtr NativeMethodInfoPtr_get_UniqueArrayItems_Public_get_IList_1_JToken_0;

			// Token: 0x04001461 RID: 5217
			private static readonly IntPtr NativeMethodInfoPtr_get_CurrentItemWriter_Public_get_JTokenWriter_0;

			// Token: 0x04001462 RID: 5218
			private static readonly IntPtr NativeMethodInfoPtr_set_CurrentItemWriter_Public_set_Void_JTokenWriter_0;

			// Token: 0x04001463 RID: 5219
			private static readonly IntPtr NativeMethodInfoPtr_get_Schemas_Public_get_IList_1_JsonSchemaModel_0;

			// Token: 0x04001464 RID: 5220
			private static readonly IntPtr NativeMethodInfoPtr_get_RequiredProperties_Public_get_Dictionary_2_String_Boolean_0;

			// Token: 0x04001465 RID: 5221
			private static readonly IntPtr NativeMethodInfoPtr_get_TokenType_Public_get_JTokenType_0;

			// Token: 0x04001466 RID: 5222
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_JTokenType_IList_1_JsonSchemaModel_0;

			// Token: 0x04001467 RID: 5223
			private static readonly IntPtr NativeMethodInfoPtr_GetRequiredProperties_Private_IEnumerable_1_String_JsonSchemaModel_0;

			// Token: 0x02000233 RID: 563
			[ObfuscatedName("Newtonsoft.Json.JsonValidatingReader+SchemaScope+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x060022D7 RID: 8919 RVA: 0x00099328 File Offset: 0x00097528
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<JsonValidatingReader.SchemaScope.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope.__c>.NativeClassPtr);
					JsonValidatingReader.SchemaScope.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope.__c>.NativeClassPtr, "<>9");
					JsonValidatingReader.SchemaScope.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope.__c>.NativeClassPtr, "<>9__27_0");
					JsonValidatingReader.SchemaScope.__c.NativeFieldInfoPtr___9__27_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope.__c>.NativeClassPtr, "<>9__27_1");
					JsonValidatingReader.SchemaScope.__c.NativeFieldInfoPtr___9__27_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope.__c>.NativeClassPtr, "<>9__27_2");
					JsonValidatingReader.SchemaScope.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope.__c>.NativeClassPtr, "<>9__28_0");
					JsonValidatingReader.SchemaScope.__c.NativeFieldInfoPtr___9__28_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope.__c>.NativeClassPtr, "<>9__28_1");
					JsonValidatingReader.SchemaScope.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope.__c>.NativeClassPtr, 100664287);
					JsonValidatingReader.SchemaScope.__c.NativeMethodInfoPtr___ctor_b__27_0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope.__c>.NativeClassPtr, 100664288);
					JsonValidatingReader.SchemaScope.__c.NativeMethodInfoPtr___ctor_b__27_1_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope.__c>.NativeClassPtr, 100664289);
					JsonValidatingReader.SchemaScope.__c.NativeMethodInfoPtr___ctor_b__27_2_Internal_Boolean_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope.__c>.NativeClassPtr, 100664290);
					JsonValidatingReader.SchemaScope.__c.NativeMethodInfoPtr__GetRequiredProperties_b__28_0_Internal_Boolean_KeyValuePair_2_String_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope.__c>.NativeClassPtr, 100664291);
					JsonValidatingReader.SchemaScope.__c.NativeMethodInfoPtr__GetRequiredProperties_b__28_1_Internal_String_KeyValuePair_2_String_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope.__c>.NativeClassPtr, 100664292);
				}

				// Token: 0x060022D8 RID: 8920 RVA: 0x00099444 File Offset: 0x00097644
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonValidatingReader.SchemaScope.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.SchemaScope.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060022D9 RID: 8921 RVA: 0x00099480 File Offset: 0x00097680
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string __ctor_b__27_0(string p)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(p);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.SchemaScope.__c.NativeMethodInfoPtr___ctor_b__27_0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x060022DA RID: 8922 RVA: 0x000994C8 File Offset: 0x000976C8
				[CallerCount(184)]
				[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool __ctor_b__27_1(string p)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(p);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.SchemaScope.__c.NativeMethodInfoPtr___ctor_b__27_1_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060022DB RID: 8923 RVA: 0x00099518 File Offset: 0x00097718
				[CallerCount(0)]
				public unsafe bool __ctor_b__27_2(JsonSchemaModel s)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.SchemaScope.__c.NativeMethodInfoPtr___ctor_b__27_2_Internal_Boolean_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060022DC RID: 8924 RVA: 0x00099568 File Offset: 0x00097768
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736226, XrefRangeEnd = 736227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _GetRequiredProperties_b__28_0(KeyValuePair<string, JsonSchemaModel> p)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(p));
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.SchemaScope.__c.NativeMethodInfoPtr__GetRequiredProperties_b__28_0_Internal_Boolean_KeyValuePair_2_String_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060022DD RID: 8925 RVA: 0x000995BC File Offset: 0x000977BC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736227, XrefRangeEnd = 736228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _GetRequiredProperties_b__28_1(KeyValuePair<string, JsonSchemaModel> p)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(p));
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.SchemaScope.__c.NativeMethodInfoPtr__GetRequiredProperties_b__28_1_Internal_String_KeyValuePair_2_String_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x060022DE RID: 8926 RVA: 0x00011D33 File Offset: 0x0000FF33
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170009FE RID: 2558
				// (get) Token: 0x060022DF RID: 8927 RVA: 0x0009960C File Offset: 0x0009780C
				// (set) Token: 0x060022E0 RID: 8928 RVA: 0x00011D3C File Offset: 0x0000FF3C
				public unsafe static JsonValidatingReader.SchemaScope.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(JsonValidatingReader.SchemaScope.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonValidatingReader.SchemaScope.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(JsonValidatingReader.SchemaScope.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170009FF RID: 2559
				// (get) Token: 0x060022E1 RID: 8929 RVA: 0x00099634 File Offset: 0x00097834
				// (set) Token: 0x060022E2 RID: 8930 RVA: 0x00011D4E File Offset: 0x0000FF4E
				public unsafe static Func<string, string> __9__27_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(JsonValidatingReader.SchemaScope.__c.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(JsonValidatingReader.SchemaScope.__c.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000A00 RID: 2560
				// (get) Token: 0x060022E3 RID: 8931 RVA: 0x0009965C File Offset: 0x0009785C
				// (set) Token: 0x060022E4 RID: 8932 RVA: 0x00011D60 File Offset: 0x0000FF60
				public unsafe static Func<string, bool> __9__27_1
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(JsonValidatingReader.SchemaScope.__c.NativeFieldInfoPtr___9__27_1, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(JsonValidatingReader.SchemaScope.__c.NativeFieldInfoPtr___9__27_1, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000A01 RID: 2561
				// (get) Token: 0x060022E5 RID: 8933 RVA: 0x00099684 File Offset: 0x00097884
				// (set) Token: 0x060022E6 RID: 8934 RVA: 0x00011D72 File Offset: 0x0000FF72
				public unsafe static Func<JsonSchemaModel, bool> __9__27_2
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(JsonValidatingReader.SchemaScope.__c.NativeFieldInfoPtr___9__27_2, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<JsonSchemaModel, bool>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(JsonValidatingReader.SchemaScope.__c.NativeFieldInfoPtr___9__27_2, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000A02 RID: 2562
				// (get) Token: 0x060022E7 RID: 8935 RVA: 0x000996AC File Offset: 0x000978AC
				// (set) Token: 0x060022E8 RID: 8936 RVA: 0x00011D84 File Offset: 0x0000FF84
				public unsafe static Func<KeyValuePair<string, JsonSchemaModel>, bool> __9__28_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(JsonValidatingReader.SchemaScope.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, JsonSchemaModel>, bool>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(JsonValidatingReader.SchemaScope.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000A03 RID: 2563
				// (get) Token: 0x060022E9 RID: 8937 RVA: 0x000996D4 File Offset: 0x000978D4
				// (set) Token: 0x060022EA RID: 8938 RVA: 0x00011D96 File Offset: 0x0000FF96
				public unsafe static Func<KeyValuePair<string, JsonSchemaModel>, string> __9__28_1
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(JsonValidatingReader.SchemaScope.__c.NativeFieldInfoPtr___9__28_1, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, JsonSchemaModel>, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(JsonValidatingReader.SchemaScope.__c.NativeFieldInfoPtr___9__28_1, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040018C6 RID: 6342
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x040018C7 RID: 6343
				private static readonly IntPtr NativeFieldInfoPtr___9__27_0;

				// Token: 0x040018C8 RID: 6344
				private static readonly IntPtr NativeFieldInfoPtr___9__27_1;

				// Token: 0x040018C9 RID: 6345
				private static readonly IntPtr NativeFieldInfoPtr___9__27_2;

				// Token: 0x040018CA RID: 6346
				private static readonly IntPtr NativeFieldInfoPtr___9__28_0;

				// Token: 0x040018CB RID: 6347
				private static readonly IntPtr NativeFieldInfoPtr___9__28_1;

				// Token: 0x040018CC RID: 6348
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040018CD RID: 6349
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__27_0_Internal_String_String_0;

				// Token: 0x040018CE RID: 6350
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__27_1_Internal_Boolean_String_0;

				// Token: 0x040018CF RID: 6351
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__27_2_Internal_Boolean_JsonSchemaModel_0;

				// Token: 0x040018D0 RID: 6352
				private static readonly IntPtr NativeMethodInfoPtr__GetRequiredProperties_b__28_0_Internal_Boolean_KeyValuePair_2_String_JsonSchemaModel_0;

				// Token: 0x040018D1 RID: 6353
				private static readonly IntPtr NativeMethodInfoPtr__GetRequiredProperties_b__28_1_Internal_String_KeyValuePair_2_String_JsonSchemaModel_0;
			}
		}

		// Token: 0x0200015B RID: 347
		[ObfuscatedName("Newtonsoft.Json.JsonValidatingReader+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001B23 RID: 6947 RVA: 0x00082D30 File Offset: 0x00080F30
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<JsonValidatingReader.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonValidatingReader>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonValidatingReader.__c>.NativeClassPtr);
				JsonValidatingReader.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader.__c>.NativeClassPtr, "<>9");
				JsonValidatingReader.__c.NativeFieldInfoPtr___9__50_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader.__c>.NativeClassPtr, "<>9__50_0");
				JsonValidatingReader.__c.NativeFieldInfoPtr___9__50_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader.__c>.NativeClassPtr, "<>9__50_1");
				JsonValidatingReader.__c.NativeFieldInfoPtr___9__50_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader.__c>.NativeClassPtr, "<>9__50_2");
				JsonValidatingReader.__c.NativeFieldInfoPtr___9__51_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader.__c>.NativeClassPtr, "<>9__51_0");
				JsonValidatingReader.__c.NativeFieldInfoPtr___9__51_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader.__c>.NativeClassPtr, "<>9__51_1");
				JsonValidatingReader.__c.NativeFieldInfoPtr___9__51_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonValidatingReader.__c>.NativeClassPtr, "<>9__51_2");
				JsonValidatingReader.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader.__c>.NativeClassPtr, 100664294);
				JsonValidatingReader.__c.NativeMethodInfoPtr__WriteToken_b__50_0_Internal_Boolean_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader.__c>.NativeClassPtr, 100664295);
				JsonValidatingReader.__c.NativeMethodInfoPtr__WriteToken_b__50_1_Internal_Boolean_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader.__c>.NativeClassPtr, 100664296);
				JsonValidatingReader.__c.NativeMethodInfoPtr__WriteToken_b__50_2_Internal_Boolean_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader.__c>.NativeClassPtr, 100664297);
				JsonValidatingReader.__c.NativeMethodInfoPtr__ValidateEndObject_b__51_0_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader.__c>.NativeClassPtr, 100664298);
				JsonValidatingReader.__c.NativeMethodInfoPtr__ValidateEndObject_b__51_1_Internal_Boolean_KeyValuePair_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader.__c>.NativeClassPtr, 100664299);
				JsonValidatingReader.__c.NativeMethodInfoPtr__ValidateEndObject_b__51_2_Internal_String_KeyValuePair_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonValidatingReader.__c>.NativeClassPtr, 100664300);
			}

			// Token: 0x06001B24 RID: 6948 RVA: 0x00082E74 File Offset: 0x00081074
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonValidatingReader.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B25 RID: 6949 RVA: 0x00082EB0 File Offset: 0x000810B0
			[CallerCount(0)]
			public unsafe bool _WriteToken_b__50_0(JsonSchemaModel s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.__c.NativeMethodInfoPtr__WriteToken_b__50_0_Internal_Boolean_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B26 RID: 6950 RVA: 0x00082F00 File Offset: 0x00081100
			[CallerCount(0)]
			public unsafe bool _WriteToken_b__50_1(JsonSchemaModel s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.__c.NativeMethodInfoPtr__WriteToken_b__50_1_Internal_Boolean_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B27 RID: 6951 RVA: 0x00082F50 File Offset: 0x00081150
			[CallerCount(0)]
			public unsafe bool _WriteToken_b__50_2(JsonSchemaModel s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.__c.NativeMethodInfoPtr__WriteToken_b__50_2_Internal_Boolean_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B28 RID: 6952 RVA: 0x00082FA0 File Offset: 0x000811A0
			[CallerCount(0)]
			public unsafe bool _ValidateEndObject_b__51_0(bool v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.__c.NativeMethodInfoPtr__ValidateEndObject_b__51_0_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B29 RID: 6953 RVA: 0x00082FEC File Offset: 0x000811EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736342, XrefRangeEnd = 736343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ValidateEndObject_b__51_1(KeyValuePair<string, bool> kv)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kv));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.__c.NativeMethodInfoPtr__ValidateEndObject_b__51_1_Internal_Boolean_KeyValuePair_2_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B2A RID: 6954 RVA: 0x00083040 File Offset: 0x00081240
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736343, XrefRangeEnd = 736344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ValidateEndObject_b__51_2(KeyValuePair<string, bool> kv)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kv));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonValidatingReader.__c.NativeMethodInfoPtr__ValidateEndObject_b__51_2_Internal_String_KeyValuePair_2_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001B2B RID: 6955 RVA: 0x0000D131 File Offset: 0x0000B331
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000799 RID: 1945
			// (get) Token: 0x06001B2C RID: 6956 RVA: 0x00083090 File Offset: 0x00081290
			// (set) Token: 0x06001B2D RID: 6957 RVA: 0x0000D13A File Offset: 0x0000B33A
			public unsafe static JsonValidatingReader.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JsonValidatingReader.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonValidatingReader.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JsonValidatingReader.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700079A RID: 1946
			// (get) Token: 0x06001B2E RID: 6958 RVA: 0x000830B8 File Offset: 0x000812B8
			// (set) Token: 0x06001B2F RID: 6959 RVA: 0x0000D14C File Offset: 0x0000B34C
			public unsafe static Func<JsonSchemaModel, bool> __9__50_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JsonValidatingReader.__c.NativeFieldInfoPtr___9__50_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<JsonSchemaModel, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JsonValidatingReader.__c.NativeFieldInfoPtr___9__50_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700079B RID: 1947
			// (get) Token: 0x06001B30 RID: 6960 RVA: 0x000830E0 File Offset: 0x000812E0
			// (set) Token: 0x06001B31 RID: 6961 RVA: 0x0000D15E File Offset: 0x0000B35E
			public unsafe static Func<JsonSchemaModel, bool> __9__50_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JsonValidatingReader.__c.NativeFieldInfoPtr___9__50_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<JsonSchemaModel, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JsonValidatingReader.__c.NativeFieldInfoPtr___9__50_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700079C RID: 1948
			// (get) Token: 0x06001B32 RID: 6962 RVA: 0x00083108 File Offset: 0x00081308
			// (set) Token: 0x06001B33 RID: 6963 RVA: 0x0000D170 File Offset: 0x0000B370
			public unsafe static Func<JsonSchemaModel, bool> __9__50_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JsonValidatingReader.__c.NativeFieldInfoPtr___9__50_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<JsonSchemaModel, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JsonValidatingReader.__c.NativeFieldInfoPtr___9__50_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700079D RID: 1949
			// (get) Token: 0x06001B34 RID: 6964 RVA: 0x00083130 File Offset: 0x00081330
			// (set) Token: 0x06001B35 RID: 6965 RVA: 0x0000D182 File Offset: 0x0000B382
			public unsafe static Func<bool, bool> __9__51_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JsonValidatingReader.__c.NativeFieldInfoPtr___9__51_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JsonValidatingReader.__c.NativeFieldInfoPtr___9__51_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700079E RID: 1950
			// (get) Token: 0x06001B36 RID: 6966 RVA: 0x00083158 File Offset: 0x00081358
			// (set) Token: 0x06001B37 RID: 6967 RVA: 0x0000D194 File Offset: 0x0000B394
			public unsafe static Func<KeyValuePair<string, bool>, bool> __9__51_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JsonValidatingReader.__c.NativeFieldInfoPtr___9__51_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, bool>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JsonValidatingReader.__c.NativeFieldInfoPtr___9__51_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700079F RID: 1951
			// (get) Token: 0x06001B38 RID: 6968 RVA: 0x00083180 File Offset: 0x00081380
			// (set) Token: 0x06001B39 RID: 6969 RVA: 0x0000D1A6 File Offset: 0x0000B3A6
			public unsafe static Func<KeyValuePair<string, bool>, string> __9__51_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JsonValidatingReader.__c.NativeFieldInfoPtr___9__51_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, bool>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JsonValidatingReader.__c.NativeFieldInfoPtr___9__51_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001468 RID: 5224
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001469 RID: 5225
			private static readonly IntPtr NativeFieldInfoPtr___9__50_0;

			// Token: 0x0400146A RID: 5226
			private static readonly IntPtr NativeFieldInfoPtr___9__50_1;

			// Token: 0x0400146B RID: 5227
			private static readonly IntPtr NativeFieldInfoPtr___9__50_2;

			// Token: 0x0400146C RID: 5228
			private static readonly IntPtr NativeFieldInfoPtr___9__51_0;

			// Token: 0x0400146D RID: 5229
			private static readonly IntPtr NativeFieldInfoPtr___9__51_1;

			// Token: 0x0400146E RID: 5230
			private static readonly IntPtr NativeFieldInfoPtr___9__51_2;

			// Token: 0x0400146F RID: 5231
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001470 RID: 5232
			private static readonly IntPtr NativeMethodInfoPtr__WriteToken_b__50_0_Internal_Boolean_JsonSchemaModel_0;

			// Token: 0x04001471 RID: 5233
			private static readonly IntPtr NativeMethodInfoPtr__WriteToken_b__50_1_Internal_Boolean_JsonSchemaModel_0;

			// Token: 0x04001472 RID: 5234
			private static readonly IntPtr NativeMethodInfoPtr__WriteToken_b__50_2_Internal_Boolean_JsonSchemaModel_0;

			// Token: 0x04001473 RID: 5235
			private static readonly IntPtr NativeMethodInfoPtr__ValidateEndObject_b__51_0_Internal_Boolean_Boolean_0;

			// Token: 0x04001474 RID: 5236
			private static readonly IntPtr NativeMethodInfoPtr__ValidateEndObject_b__51_1_Internal_Boolean_KeyValuePair_2_String_Boolean_0;

			// Token: 0x04001475 RID: 5237
			private static readonly IntPtr NativeMethodInfoPtr__ValidateEndObject_b__51_2_Internal_String_KeyValuePair_2_String_Boolean_0;
		}
	}
}

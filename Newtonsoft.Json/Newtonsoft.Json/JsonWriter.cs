using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x02000032 RID: 50
	public class JsonWriter : Object
	{
		// Token: 0x06000525 RID: 1317 RVA: 0x00029A94 File Offset: 0x00027C94
		// Note: this type is marked as 'beforefieldinit'.
		static JsonWriter()
		{
			Il2CppClassPointerStore<JsonWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json", "JsonWriter");
			JsonWriter.NativeFieldInfoPtr_StateArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "StateArray");
			JsonWriter.NativeFieldInfoPtr_StateArrayTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "StateArrayTemplate");
			JsonWriter.NativeFieldInfoPtr__stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "_stack");
			JsonWriter.NativeFieldInfoPtr__currentPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "_currentPosition");
			JsonWriter.NativeFieldInfoPtr__currentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "_currentState");
			JsonWriter.NativeFieldInfoPtr__formatting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "_formatting");
			JsonWriter.NativeFieldInfoPtr__CloseOutput_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "<CloseOutput>k__BackingField");
			JsonWriter.NativeFieldInfoPtr__AutoCompleteOnClose_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "<AutoCompleteOnClose>k__BackingField");
			JsonWriter.NativeFieldInfoPtr__dateFormatHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "_dateFormatHandling");
			JsonWriter.NativeFieldInfoPtr__dateTimeZoneHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "_dateTimeZoneHandling");
			JsonWriter.NativeFieldInfoPtr__stringEscapeHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "_stringEscapeHandling");
			JsonWriter.NativeFieldInfoPtr__floatFormatHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "_floatFormatHandling");
			JsonWriter.NativeFieldInfoPtr__dateFormatString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "_dateFormatString");
			JsonWriter.NativeFieldInfoPtr__culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "_culture");
			JsonWriter.NativeMethodInfoPtr_AutoCompleteAsync_Internal_Task_JsonToken_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664301);
			JsonWriter.NativeMethodInfoPtr_AutoCompleteAsync_Private_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664302);
			JsonWriter.NativeMethodInfoPtr_CloseAsync_Public_Virtual_New_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664303);
			JsonWriter.NativeMethodInfoPtr_FlushAsync_Public_Virtual_New_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664304);
			JsonWriter.NativeMethodInfoPtr_WriteEndAsync_Protected_Virtual_New_Task_JsonToken_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664305);
			JsonWriter.NativeMethodInfoPtr_WriteIndentAsync_Protected_Virtual_New_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664306);
			JsonWriter.NativeMethodInfoPtr_WriteValueDelimiterAsync_Protected_Virtual_New_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664307);
			JsonWriter.NativeMethodInfoPtr_WriteIndentSpaceAsync_Protected_Virtual_New_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664308);
			JsonWriter.NativeMethodInfoPtr_WriteRawAsync_Public_Virtual_New_Task_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664309);
			JsonWriter.NativeMethodInfoPtr_WriteEndAsync_Public_Virtual_New_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664310);
			JsonWriter.NativeMethodInfoPtr_WriteEndInternalAsync_Internal_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664311);
			JsonWriter.NativeMethodInfoPtr_InternalWriteEndAsync_Internal_Task_JsonContainerType_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664312);
			JsonWriter.NativeMethodInfoPtr_WriteEndArrayAsync_Public_Virtual_New_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664313);
			JsonWriter.NativeMethodInfoPtr_WriteEndConstructorAsync_Public_Virtual_New_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664314);
			JsonWriter.NativeMethodInfoPtr_WriteEndObjectAsync_Public_Virtual_New_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664315);
			JsonWriter.NativeMethodInfoPtr_WriteNullAsync_Public_Virtual_New_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664316);
			JsonWriter.NativeMethodInfoPtr_WritePropertyNameAsync_Public_Virtual_New_Task_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664317);
			JsonWriter.NativeMethodInfoPtr_WritePropertyNameAsync_Public_Virtual_New_Task_String_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664318);
			JsonWriter.NativeMethodInfoPtr_InternalWritePropertyNameAsync_Internal_Task_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664319);
			JsonWriter.NativeMethodInfoPtr_WriteStartArrayAsync_Public_Virtual_New_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664320);
			JsonWriter.NativeMethodInfoPtr_InternalWriteStartAsync_Internal_Task_JsonToken_JsonContainerType_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664321);
			JsonWriter.NativeMethodInfoPtr_WriteCommentAsync_Public_Virtual_New_Task_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664322);
			JsonWriter.NativeMethodInfoPtr_InternalWriteCommentAsync_Internal_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664323);
			JsonWriter.NativeMethodInfoPtr_WriteRawValueAsync_Public_Virtual_New_Task_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664324);
			JsonWriter.NativeMethodInfoPtr_WriteStartConstructorAsync_Public_Virtual_New_Task_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664325);
			JsonWriter.NativeMethodInfoPtr_WriteStartObjectAsync_Public_Virtual_New_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664326);
			JsonWriter.NativeMethodInfoPtr_WriteTokenAsync_Public_Task_JsonReader_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664327);
			JsonWriter.NativeMethodInfoPtr_WriteTokenAsync_Public_Task_JsonReader_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664328);
			JsonWriter.NativeMethodInfoPtr_WriteTokenAsync_Public_Task_JsonToken_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664329);
			JsonWriter.NativeMethodInfoPtr_WriteTokenAsync_Public_Task_JsonToken_Object_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664330);
			JsonWriter.NativeMethodInfoPtr_WriteTokenAsync_Internal_Virtual_New_Task_JsonReader_Boolean_Boolean_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664331);
			JsonWriter.NativeMethodInfoPtr_WriteTokenSyncReadingAsync_Internal_Task_JsonReader_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664332);
			JsonWriter.NativeMethodInfoPtr_WriteConstructorDateAsync_Private_Task_JsonReader_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664333);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664334);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664335);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Byte_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664336);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Byte_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664337);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Il2CppStructArray_1_Byte_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664338);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Char_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664339);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Char_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664340);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_DateTime_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664341);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_DateTime_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664342);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_DateTimeOffset_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664343);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_DateTimeOffset_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664344);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Decimal_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664345);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Decimal_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664346);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Double_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664347);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Double_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664348);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Single_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664349);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Single_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664350);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Guid_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664351);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Guid_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664352);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664353);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664354);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Int64_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664355);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Int64_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664356);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Object_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664357);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_SByte_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664358);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_SByte_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664359);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Int16_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664360);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Int16_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664361);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664362);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_TimeSpan_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664363);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_TimeSpan_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664364);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_UInt32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664365);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_UInt32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664366);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_UInt64_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664367);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_UInt64_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664368);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Uri_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664369);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_UInt16_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664370);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_UInt16_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664371);
			JsonWriter.NativeMethodInfoPtr_WriteUndefinedAsync_Public_Virtual_New_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664372);
			JsonWriter.NativeMethodInfoPtr_WriteWhitespaceAsync_Public_Virtual_New_Task_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664373);
			JsonWriter.NativeMethodInfoPtr_InternalWriteValueAsync_Internal_Task_JsonToken_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664374);
			JsonWriter.NativeMethodInfoPtr_SetWriteStateAsync_Protected_Task_JsonToken_Object_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664375);
			JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Internal_Static_Task_JsonWriter_PrimitiveTypeCode_Object_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664376);
			JsonWriter.NativeMethodInfoPtr_BuildStateArray_Internal_Static_Il2CppReferenceArray_1_Il2CppStructArray_1_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664377);
			JsonWriter.NativeMethodInfoPtr_get_CloseOutput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664379);
			JsonWriter.NativeMethodInfoPtr_set_CloseOutput_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664380);
			JsonWriter.NativeMethodInfoPtr_get_AutoCompleteOnClose_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664381);
			JsonWriter.NativeMethodInfoPtr_set_AutoCompleteOnClose_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664382);
			JsonWriter.NativeMethodInfoPtr_get_Top_FamOrAssem_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664383);
			JsonWriter.NativeMethodInfoPtr_get_WriteState_Public_get_WriteState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664384);
			JsonWriter.NativeMethodInfoPtr_get_ContainerPath_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664385);
			JsonWriter.NativeMethodInfoPtr_get_Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664386);
			JsonWriter.NativeMethodInfoPtr_get_Formatting_Public_get_Formatting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664387);
			JsonWriter.NativeMethodInfoPtr_set_Formatting_Public_set_Void_Formatting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664388);
			JsonWriter.NativeMethodInfoPtr_get_DateFormatHandling_Public_get_DateFormatHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664389);
			JsonWriter.NativeMethodInfoPtr_set_DateFormatHandling_Public_set_Void_DateFormatHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664390);
			JsonWriter.NativeMethodInfoPtr_get_DateTimeZoneHandling_Public_get_DateTimeZoneHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664391);
			JsonWriter.NativeMethodInfoPtr_set_DateTimeZoneHandling_Public_set_Void_DateTimeZoneHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664392);
			JsonWriter.NativeMethodInfoPtr_get_StringEscapeHandling_Public_get_StringEscapeHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664393);
			JsonWriter.NativeMethodInfoPtr_set_StringEscapeHandling_Public_set_Void_StringEscapeHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664394);
			JsonWriter.NativeMethodInfoPtr_OnStringEscapeHandlingChanged_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664395);
			JsonWriter.NativeMethodInfoPtr_get_FloatFormatHandling_Public_get_FloatFormatHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664396);
			JsonWriter.NativeMethodInfoPtr_set_FloatFormatHandling_Public_set_Void_FloatFormatHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664397);
			JsonWriter.NativeMethodInfoPtr_get_DateFormatString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664398);
			JsonWriter.NativeMethodInfoPtr_set_DateFormatString_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664399);
			JsonWriter.NativeMethodInfoPtr_get_Culture_Public_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664400);
			JsonWriter.NativeMethodInfoPtr_set_Culture_Public_set_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664401);
			JsonWriter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664402);
			JsonWriter.NativeMethodInfoPtr_UpdateScopeWithFinishedValue_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664403);
			JsonWriter.NativeMethodInfoPtr_Push_Private_Void_JsonContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664404);
			JsonWriter.NativeMethodInfoPtr_Pop_Private_JsonContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664405);
			JsonWriter.NativeMethodInfoPtr_Peek_Private_JsonContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664406);
			JsonWriter.NativeMethodInfoPtr_Flush_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664407);
			JsonWriter.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664408);
			JsonWriter.NativeMethodInfoPtr_WriteStartObject_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664409);
			JsonWriter.NativeMethodInfoPtr_WriteEndObject_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664410);
			JsonWriter.NativeMethodInfoPtr_WriteStartArray_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664411);
			JsonWriter.NativeMethodInfoPtr_WriteEndArray_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664412);
			JsonWriter.NativeMethodInfoPtr_WriteStartConstructor_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664413);
			JsonWriter.NativeMethodInfoPtr_WriteEndConstructor_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664414);
			JsonWriter.NativeMethodInfoPtr_WritePropertyName_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664415);
			JsonWriter.NativeMethodInfoPtr_WritePropertyName_Public_Virtual_New_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664416);
			JsonWriter.NativeMethodInfoPtr_WriteEnd_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664417);
			JsonWriter.NativeMethodInfoPtr_WriteToken_Public_Void_JsonReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664418);
			JsonWriter.NativeMethodInfoPtr_WriteToken_Public_Void_JsonReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664419);
			JsonWriter.NativeMethodInfoPtr_WriteToken_Public_Void_JsonToken_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664420);
			JsonWriter.NativeMethodInfoPtr_WriteToken_Public_Void_JsonToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664421);
			JsonWriter.NativeMethodInfoPtr_WriteToken_Internal_Virtual_New_Void_JsonReader_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664422);
			JsonWriter.NativeMethodInfoPtr_IsWriteTokenIncomplete_Private_Boolean_JsonReader_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664423);
			JsonWriter.NativeMethodInfoPtr_CalculateWriteTokenInitialDepth_Private_Int32_JsonReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664424);
			JsonWriter.NativeMethodInfoPtr_CalculateWriteTokenFinalDepth_Private_Int32_JsonReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664425);
			JsonWriter.NativeMethodInfoPtr_WriteConstructorDate_Private_Void_JsonReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664426);
			JsonWriter.NativeMethodInfoPtr_WriteEnd_Private_Void_JsonContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664427);
			JsonWriter.NativeMethodInfoPtr_AutoCompleteAll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664428);
			JsonWriter.NativeMethodInfoPtr_GetCloseTokenForType_Private_JsonToken_JsonContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664429);
			JsonWriter.NativeMethodInfoPtr_AutoCompleteClose_Private_Void_JsonContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664430);
			JsonWriter.NativeMethodInfoPtr_CalculateLevelsToComplete_Private_Int32_JsonContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664431);
			JsonWriter.NativeMethodInfoPtr_UpdateCurrentState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664432);
			JsonWriter.NativeMethodInfoPtr_WriteEnd_Protected_Virtual_New_Void_JsonToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664433);
			JsonWriter.NativeMethodInfoPtr_WriteIndent_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664434);
			JsonWriter.NativeMethodInfoPtr_WriteValueDelimiter_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664435);
			JsonWriter.NativeMethodInfoPtr_WriteIndentSpace_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664436);
			JsonWriter.NativeMethodInfoPtr_AutoComplete_Internal_Void_JsonToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664437);
			JsonWriter.NativeMethodInfoPtr_WriteNull_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664438);
			JsonWriter.NativeMethodInfoPtr_WriteUndefined_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664439);
			JsonWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664440);
			JsonWriter.NativeMethodInfoPtr_WriteRawValue_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664441);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664442);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664443);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664444);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664445);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664446);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664447);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664448);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664449);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664450);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664451);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664452);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664453);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664454);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664455);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664456);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664457);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664458);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664459);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664460);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664461);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664462);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664463);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664464);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664465);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664466);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664467);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664468);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664469);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664470);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664471);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664472);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664473);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664474);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664475);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664476);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664477);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664478);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664479);
			JsonWriter.NativeMethodInfoPtr_WriteComment_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664480);
			JsonWriter.NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664481);
			JsonWriter.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664482);
			JsonWriter.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664483);
			JsonWriter.NativeMethodInfoPtr_WriteValue_Internal_Static_Void_JsonWriter_PrimitiveTypeCode_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664484);
			JsonWriter.NativeMethodInfoPtr_ResolveConvertibleValue_Private_Static_Void_IConvertible_byref_PrimitiveTypeCode_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664485);
			JsonWriter.NativeMethodInfoPtr_CreateUnsupportedTypeException_Private_Static_JsonWriterException_JsonWriter_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664486);
			JsonWriter.NativeMethodInfoPtr_SetWriteState_Protected_Void_JsonToken_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664487);
			JsonWriter.NativeMethodInfoPtr_InternalWriteEnd_Internal_Void_JsonContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664488);
			JsonWriter.NativeMethodInfoPtr_InternalWritePropertyName_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664489);
			JsonWriter.NativeMethodInfoPtr_InternalWriteRaw_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664490);
			JsonWriter.NativeMethodInfoPtr_InternalWriteStart_Internal_Void_JsonToken_JsonContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664491);
			JsonWriter.NativeMethodInfoPtr_InternalWriteValue_Internal_Void_JsonToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664492);
			JsonWriter.NativeMethodInfoPtr_InternalWriteWhitespace_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664493);
			JsonWriter.NativeMethodInfoPtr_InternalWriteComment_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664494);
			JsonWriter.NativeMethodInfoPtr_Method_Private_Task_Task_Int32_JsonToken_CancellationToken_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664495);
			JsonWriter.NativeMethodInfoPtr_Method_Private_Task_Task_Int32_JsonToken_CancellationToken_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664496);
			JsonWriter.NativeMethodInfoPtr_Method_Private_Task_Task_Int32_CancellationToken_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664497);
			JsonWriter.NativeMethodInfoPtr_Method_Private_Task_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, 100664498);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0002AB38 File Offset: 0x00028D38
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 737489, RefRangeEnd = 737496, XrefRangeStart = 737475, XrefRangeEnd = 737489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task AutoCompleteAsync(JsonToken tokenBeingWritten, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tokenBeingWritten;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_AutoCompleteAsync_Internal_Task_JsonToken_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0002AB9C File Offset: 0x00028D9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 737507, RefRangeEnd = 737509, XrefRangeStart = 737496, XrefRangeEnd = 737507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task AutoCompleteAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_AutoCompleteAsync_Private_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x0002ABF4 File Offset: 0x00028DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737509, XrefRangeEnd = 737517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task CloseAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_CloseAsync_Public_Virtual_New_Task_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0002AC54 File Offset: 0x00028E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737517, XrefRangeEnd = 737525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task FlushAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_FlushAsync_Public_Virtual_New_Task_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0002ACB4 File Offset: 0x00028EB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 737533, RefRangeEnd = 737534, XrefRangeStart = 737525, XrefRangeEnd = 737533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteEndAsync(JsonToken token, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteEndAsync_Protected_Virtual_New_Task_JsonToken_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x0002AD24 File Offset: 0x00028F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737534, XrefRangeEnd = 737542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteIndentAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteIndentAsync_Protected_Virtual_New_Task_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0002AD84 File Offset: 0x00028F84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 737550, RefRangeEnd = 737551, XrefRangeStart = 737542, XrefRangeEnd = 737550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueDelimiterAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueDelimiterAsync_Protected_Virtual_New_Task_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0002ADE4 File Offset: 0x00028FE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 737559, RefRangeEnd = 737560, XrefRangeStart = 737551, XrefRangeEnd = 737559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteIndentSpaceAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteIndentSpaceAsync_Protected_Virtual_New_Task_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0002AE44 File Offset: 0x00029044
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 737568, RefRangeEnd = 737569, XrefRangeStart = 737560, XrefRangeEnd = 737568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteRawAsync(string json, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteRawAsync_Public_Virtual_New_Task_String_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x0002AEB8 File Offset: 0x000290B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 737577, RefRangeEnd = 737578, XrefRangeStart = 737569, XrefRangeEnd = 737577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteEndAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteEndAsync_Public_Virtual_New_Task_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0002AF18 File Offset: 0x00029118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737578, XrefRangeEnd = 737586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WriteEndInternalAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_WriteEndInternalAsync_Internal_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0002AF70 File Offset: 0x00029170
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 737607, RefRangeEnd = 737610, XrefRangeStart = 737586, XrefRangeEnd = 737607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task InternalWriteEndAsync(JsonContainerType type, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_InternalWriteEndAsync_Internal_Task_JsonContainerType_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0002AFD4 File Offset: 0x000291D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 737618, RefRangeEnd = 737619, XrefRangeStart = 737610, XrefRangeEnd = 737618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteEndArrayAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteEndArrayAsync_Public_Virtual_New_Task_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0002B034 File Offset: 0x00029234
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 737627, RefRangeEnd = 737628, XrefRangeStart = 737619, XrefRangeEnd = 737627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteEndConstructorAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteEndConstructorAsync_Public_Virtual_New_Task_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0002B094 File Offset: 0x00029294
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 737636, RefRangeEnd = 737637, XrefRangeStart = 737628, XrefRangeEnd = 737636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteEndObjectAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteEndObjectAsync_Public_Virtual_New_Task_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x0002B0F4 File Offset: 0x000292F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 737645, RefRangeEnd = 737646, XrefRangeStart = 737637, XrefRangeEnd = 737645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteNullAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteNullAsync_Public_Virtual_New_Task_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0002B154 File Offset: 0x00029354
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 737654, RefRangeEnd = 737655, XrefRangeStart = 737646, XrefRangeEnd = 737654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WritePropertyNameAsync(string name, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WritePropertyNameAsync_Public_Virtual_New_Task_String_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0002B1C8 File Offset: 0x000293C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 737663, RefRangeEnd = 737664, XrefRangeStart = 737655, XrefRangeEnd = 737663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WritePropertyNameAsync(string name, bool escape, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref escape;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WritePropertyNameAsync_Public_Virtual_New_Task_String_Boolean_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0002B248 File Offset: 0x00029448
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 737671, RefRangeEnd = 737673, XrefRangeStart = 737664, XrefRangeEnd = 737671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task InternalWritePropertyNameAsync(string name, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_InternalWritePropertyNameAsync_Internal_Task_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0002B2B0 File Offset: 0x000294B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737673, XrefRangeEnd = 737681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteStartArrayAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteStartArrayAsync_Public_Virtual_New_Task_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0002B310 File Offset: 0x00029510
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 737692, RefRangeEnd = 737698, XrefRangeStart = 737681, XrefRangeEnd = 737692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task InternalWriteStartAsync(JsonToken token, JsonContainerType container, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref container;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_InternalWriteStartAsync_Internal_Task_JsonToken_JsonContainerType_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x0002B384 File Offset: 0x00029584
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 737706, RefRangeEnd = 737707, XrefRangeStart = 737698, XrefRangeEnd = 737706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteCommentAsync(string text, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteCommentAsync_Public_Virtual_New_Task_String_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0002B3F8 File Offset: 0x000295F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737707, XrefRangeEnd = 737708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task InternalWriteCommentAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_InternalWriteCommentAsync_Internal_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0002B450 File Offset: 0x00029650
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 737716, RefRangeEnd = 737717, XrefRangeStart = 737708, XrefRangeEnd = 737716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteRawValueAsync(string json, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteRawValueAsync_Public_Virtual_New_Task_String_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0002B4C4 File Offset: 0x000296C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 737725, RefRangeEnd = 737726, XrefRangeStart = 737717, XrefRangeEnd = 737725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteStartConstructorAsync(string name, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteStartConstructorAsync_Public_Virtual_New_Task_String_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0002B538 File Offset: 0x00029738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737726, XrefRangeEnd = 737734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteStartObjectAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteStartObjectAsync_Public_Virtual_New_Task_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0002B598 File Offset: 0x00029798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737734, XrefRangeEnd = 737737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WriteTokenAsync(JsonReader reader, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_WriteTokenAsync_Public_Task_JsonReader_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0002B600 File Offset: 0x00029800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737737, XrefRangeEnd = 737740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WriteTokenAsync(JsonReader reader, bool writeChildren, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeChildren;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_WriteTokenAsync_Public_Task_JsonReader_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0002B678 File Offset: 0x00029878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737740, XrefRangeEnd = 737741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WriteTokenAsync(JsonToken token, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_WriteTokenAsync_Public_Task_JsonToken_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0002B6DC File Offset: 0x000298DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 737759, RefRangeEnd = 737761, XrefRangeStart = 737741, XrefRangeEnd = 737759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WriteTokenAsync(JsonToken token, Object value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_WriteTokenAsync_Public_Task_JsonToken_Object_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0002B754 File Offset: 0x00029954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737761, XrefRangeEnd = 737773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteTokenAsync(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeChildren;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeDateConstructorAsDate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeComments;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteTokenAsync_Internal_Virtual_New_Task_JsonReader_Boolean_Boolean_Boolean_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0002B7F4 File Offset: 0x000299F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 737785, RefRangeEnd = 737787, XrefRangeStart = 737773, XrefRangeEnd = 737785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WriteTokenSyncReadingAsync(JsonReader reader, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_WriteTokenSyncReadingAsync_Internal_Task_JsonReader_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0002B85C File Offset: 0x00029A5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 737799, RefRangeEnd = 737800, XrefRangeStart = 737787, XrefRangeEnd = 737799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WriteConstructorDateAsync(JsonReader reader, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_WriteConstructorDateAsync_Private_Task_JsonReader_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0002B8C4 File Offset: 0x00029AC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 737808, RefRangeEnd = 737809, XrefRangeStart = 737800, XrefRangeEnd = 737808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(bool value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Boolean_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0002B934 File Offset: 0x00029B34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 737817, RefRangeEnd = 737818, XrefRangeStart = 737809, XrefRangeEnd = 737817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(Nullable<bool> value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Boolean_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0002B9AC File Offset: 0x00029BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737818, XrefRangeEnd = 737826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(byte value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Byte_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0002BA1C File Offset: 0x00029C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737826, XrefRangeEnd = 737834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(Nullable<byte> value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Byte_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0002BA94 File Offset: 0x00029C94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 737842, RefRangeEnd = 737843, XrefRangeStart = 737834, XrefRangeEnd = 737842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(Il2CppStructArray<byte> value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Il2CppStructArray_1_Byte_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0002BB08 File Offset: 0x00029D08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 737851, RefRangeEnd = 737852, XrefRangeStart = 737843, XrefRangeEnd = 737851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(char value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Char_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0002BB78 File Offset: 0x00029D78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 737860, RefRangeEnd = 737861, XrefRangeStart = 737852, XrefRangeEnd = 737860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(Nullable<char> value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Char_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x0002BBF0 File Offset: 0x00029DF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 737869, RefRangeEnd = 737870, XrefRangeStart = 737861, XrefRangeEnd = 737869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(DateTime value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_DateTime_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0002BC60 File Offset: 0x00029E60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 737878, RefRangeEnd = 737879, XrefRangeStart = 737870, XrefRangeEnd = 737878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(Nullable<DateTime> value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_DateTime_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0002BCD8 File Offset: 0x00029ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737879, XrefRangeEnd = 737887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(DateTimeOffset value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_DateTimeOffset_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0002BD48 File Offset: 0x00029F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737887, XrefRangeEnd = 737895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(Nullable<DateTimeOffset> value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_DateTimeOffset_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0002BDC0 File Offset: 0x00029FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737895, XrefRangeEnd = 737903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(Decimal value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Decimal_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0002BE30 File Offset: 0x0002A030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737903, XrefRangeEnd = 737911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(Nullable<Decimal> value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Decimal_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0002BEA8 File Offset: 0x0002A0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737911, XrefRangeEnd = 737919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(double value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Double_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0002BF18 File Offset: 0x0002A118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737919, XrefRangeEnd = 737927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(Nullable<double> value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Double_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0002BF90 File Offset: 0x0002A190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737927, XrefRangeEnd = 737935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(float value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Single_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0002C000 File Offset: 0x0002A200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737935, XrefRangeEnd = 737943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(Nullable<float> value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Single_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0002C078 File Offset: 0x0002A278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737943, XrefRangeEnd = 737951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(Guid value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Guid_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0002C0E8 File Offset: 0x0002A2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737951, XrefRangeEnd = 737959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(Nullable<Guid> value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Guid_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0002C160 File Offset: 0x0002A360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737959, XrefRangeEnd = 737967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(int value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0002C1D0 File Offset: 0x0002A3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737967, XrefRangeEnd = 737975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(Nullable<int> value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0002C248 File Offset: 0x0002A448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737975, XrefRangeEnd = 737983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(long value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Int64_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0002C2B8 File Offset: 0x0002A4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737983, XrefRangeEnd = 737991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(Nullable<long> value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Int64_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0002C330 File Offset: 0x0002A530
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 737999, RefRangeEnd = 738000, XrefRangeStart = 737991, XrefRangeEnd = 737999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(Object value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Object_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0002C3A4 File Offset: 0x0002A5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738000, XrefRangeEnd = 738008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(sbyte value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_SByte_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0002C414 File Offset: 0x0002A614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738008, XrefRangeEnd = 738016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(Nullable<sbyte> value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_SByte_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0002C48C File Offset: 0x0002A68C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738016, XrefRangeEnd = 738024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(short value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Int16_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0002C4FC File Offset: 0x0002A6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738024, XrefRangeEnd = 738032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(Nullable<short> value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Int16_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0002C574 File Offset: 0x0002A774
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 738040, RefRangeEnd = 738041, XrefRangeStart = 738032, XrefRangeEnd = 738040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(string value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_String_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0002C5E8 File Offset: 0x0002A7E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 738049, RefRangeEnd = 738050, XrefRangeStart = 738041, XrefRangeEnd = 738049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(TimeSpan value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_TimeSpan_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0002C658 File Offset: 0x0002A858
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 738058, RefRangeEnd = 738059, XrefRangeStart = 738050, XrefRangeEnd = 738058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(Nullable<TimeSpan> value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_TimeSpan_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0002C6D0 File Offset: 0x0002A8D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738059, XrefRangeEnd = 738067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(uint value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_UInt32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0002C740 File Offset: 0x0002A940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738067, XrefRangeEnd = 738075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(Nullable<uint> value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_UInt32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0002C7B8 File Offset: 0x0002A9B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738075, XrefRangeEnd = 738083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(ulong value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_UInt64_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0002C828 File Offset: 0x0002AA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738083, XrefRangeEnd = 738091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(Nullable<ulong> value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_UInt64_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0002C8A0 File Offset: 0x0002AAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738091, XrefRangeEnd = 738099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(Uri value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Uri_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0002C914 File Offset: 0x0002AB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738099, XrefRangeEnd = 738107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(ushort value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_UInt16_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0002C984 File Offset: 0x0002AB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738107, XrefRangeEnd = 738115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteValueAsync(Nullable<ushort> value, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_UInt16_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0002C9FC File Offset: 0x0002ABFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738115, XrefRangeEnd = 738123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteUndefinedAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteUndefinedAsync_Public_Virtual_New_Task_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0002CA5C File Offset: 0x0002AC5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 738131, RefRangeEnd = 738132, XrefRangeStart = 738123, XrefRangeEnd = 738131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteWhitespaceAsync(string ws, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ws);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteWhitespaceAsync_Public_Virtual_New_Task_String_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0002CAD0 File Offset: 0x0002ACD0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 738138, RefRangeEnd = 738151, XrefRangeStart = 738132, XrefRangeEnd = 738138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task InternalWriteValueAsync(JsonToken token, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_InternalWriteValueAsync_Internal_Task_JsonToken_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0002CB34 File Offset: 0x0002AD34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738151, XrefRangeEnd = 738158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task SetWriteStateAsync(JsonToken token, Object value, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_SetWriteStateAsync_Protected_Task_JsonToken_Object_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0002CBAC File Offset: 0x0002ADAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 738208, RefRangeEnd = 738209, XrefRangeStart = 738158, XrefRangeEnd = 738208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task WriteValueAsync(JsonWriter writer, PrimitiveTypeCode typeCode, Object value, CancellationToken cancellationToken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref typeCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_WriteValueAsync_Internal_Static_Task_JsonWriter_PrimitiveTypeCode_Object_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0002CC28 File Offset: 0x0002AE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738209, XrefRangeEnd = 738237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Il2CppStructArray<JsonWriter.State>> BuildStateArray()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_BuildStateArray_Internal_Static_Il2CppReferenceArray_1_Il2CppStructArray_1_State_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<JsonWriter.State>>>(intPtr3) : null;
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x0002CC5C File Offset: 0x0002AE5C
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x0002CC98 File Offset: 0x0002AE98
		public unsafe bool CloseOutput
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_get_CloseOutput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_set_CloseOutput_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x0002CCD8 File Offset: 0x0002AED8
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x0002CD14 File Offset: 0x0002AF14
		public unsafe bool AutoCompleteOnClose
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_get_AutoCompleteOnClose_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_set_AutoCompleteOnClose_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x0002CD54 File Offset: 0x0002AF54
		public unsafe int Top
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 738238, RefRangeEnd = 738256, XrefRangeStart = 738237, XrefRangeEnd = 738238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_get_Top_FamOrAssem_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x0002CD90 File Offset: 0x0002AF90
		public unsafe WriteState WriteState
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 738256, RefRangeEnd = 738264, XrefRangeStart = 738256, XrefRangeEnd = 738256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_get_WriteState_Public_get_WriteState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0002CDCC File Offset: 0x0002AFCC
		public unsafe string ContainerPath
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 738269, RefRangeEnd = 738277, XrefRangeStart = 738264, XrefRangeEnd = 738269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_get_ContainerPath_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x0002CE04 File Offset: 0x0002B004
		public unsafe string Path
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 738286, RefRangeEnd = 738301, XrefRangeStart = 738277, XrefRangeEnd = 738286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_get_Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x0002CE3C File Offset: 0x0002B03C
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x0002CE78 File Offset: 0x0002B078
		public unsafe Formatting Formatting
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 134006, RefRangeEnd = 134007, XrefRangeStart = 134006, XrefRangeEnd = 134007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_get_Formatting_Public_get_Formatting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 738301, RefRangeEnd = 738308, XrefRangeStart = 738301, XrefRangeEnd = 738301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_set_Formatting_Public_set_Void_Formatting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x0002CEB8 File Offset: 0x0002B0B8
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x0002CEF4 File Offset: 0x0002B0F4
		public unsafe DateFormatHandling DateFormatHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_get_DateFormatHandling_Public_get_DateFormatHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 738308, RefRangeEnd = 738311, XrefRangeStart = 738308, XrefRangeEnd = 738308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_set_DateFormatHandling_Public_set_Void_DateFormatHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x0002CF34 File Offset: 0x0002B134
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x0002CF70 File Offset: 0x0002B170
		public unsafe DateTimeZoneHandling DateTimeZoneHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_get_DateTimeZoneHandling_Public_get_DateTimeZoneHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 738311, RefRangeEnd = 738314, XrefRangeStart = 738311, XrefRangeEnd = 738311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_set_DateTimeZoneHandling_Public_set_Void_DateTimeZoneHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x0002CFB0 File Offset: 0x0002B1B0
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x0002CFEC File Offset: 0x0002B1EC
		public unsafe StringEscapeHandling StringEscapeHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_get_StringEscapeHandling_Public_get_StringEscapeHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 738320, RefRangeEnd = 738322, XrefRangeStart = 738314, XrefRangeEnd = 738320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_set_StringEscapeHandling_Public_set_Void_StringEscapeHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0002D02C File Offset: 0x0002B22C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnStringEscapeHandlingChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_OnStringEscapeHandlingChanged_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x0002D068 File Offset: 0x0002B268
		// (set) Token: 0x06000585 RID: 1413 RVA: 0x0002D0A4 File Offset: 0x0002B2A4
		public unsafe FloatFormatHandling FloatFormatHandling
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 366305, RefRangeEnd = 366308, XrefRangeStart = 366305, XrefRangeEnd = 366308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_get_FloatFormatHandling_Public_get_FloatFormatHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 738322, RefRangeEnd = 738325, XrefRangeStart = 738322, XrefRangeEnd = 738322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_set_FloatFormatHandling_Public_set_Void_FloatFormatHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x0002D0E4 File Offset: 0x0002B2E4
		// (set) Token: 0x06000587 RID: 1415 RVA: 0x0002D11C File Offset: 0x0002B31C
		public unsafe string DateFormatString
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_get_DateFormatString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_set_DateFormatString_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x0002D160 File Offset: 0x0002B360
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x0002D1A0 File Offset: 0x0002B3A0
		public unsafe CultureInfo Culture
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 738329, RefRangeEnd = 738334, XrefRangeStart = 738325, XrefRangeEnd = 738329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_get_Culture_Public_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_set_Culture_Public_set_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0002D1E4 File Offset: 0x0002B3E4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 738335, RefRangeEnd = 738341, XrefRangeStart = 738334, XrefRangeEnd = 738335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonWriter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0002D220 File Offset: 0x0002B420
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 738341, RefRangeEnd = 738344, XrefRangeStart = 738341, XrefRangeEnd = 738341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScopeWithFinishedValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_UpdateScopeWithFinishedValue_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x0002D254 File Offset: 0x0002B454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 738356, RefRangeEnd = 738357, XrefRangeStart = 738344, XrefRangeEnd = 738356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(JsonContainerType value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_Push_Private_Void_JsonContainerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0002D294 File Offset: 0x0002B494
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 738360, RefRangeEnd = 738364, XrefRangeStart = 738357, XrefRangeEnd = 738360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonContainerType Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_Pop_Private_JsonContainerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x0002D2D0 File Offset: 0x0002B4D0
		[CallerCount(0)]
		public unsafe JsonContainerType Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_Peek_Private_JsonContainerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x0002D30C File Offset: 0x0002B50C
		[CallerCount(0)]
		public unsafe virtual void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_Flush_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x0002D348 File Offset: 0x0002B548
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 738366, RefRangeEnd = 738370, XrefRangeStart = 738364, XrefRangeEnd = 738366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0002D384 File Offset: 0x0002B584
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 738371, RefRangeEnd = 738374, XrefRangeStart = 738370, XrefRangeEnd = 738371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteStartObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteStartObject_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0002D3C0 File Offset: 0x0002B5C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 738375, RefRangeEnd = 738376, XrefRangeStart = 738374, XrefRangeEnd = 738375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteEndObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteEndObject_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0002D3FC File Offset: 0x0002B5FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 738377, RefRangeEnd = 738380, XrefRangeStart = 738376, XrefRangeEnd = 738377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteStartArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteStartArray_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0002D438 File Offset: 0x0002B638
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 738381, RefRangeEnd = 738382, XrefRangeStart = 738380, XrefRangeEnd = 738381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteEndArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteEndArray_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0002D474 File Offset: 0x0002B674
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 738383, RefRangeEnd = 738385, XrefRangeStart = 738382, XrefRangeEnd = 738383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteStartConstructor(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteStartConstructor_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0002D4C4 File Offset: 0x0002B6C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 738386, RefRangeEnd = 738387, XrefRangeStart = 738385, XrefRangeEnd = 738386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteEndConstructor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteEndConstructor_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0002D500 File Offset: 0x0002B700
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 738389, RefRangeEnd = 738395, XrefRangeStart = 738387, XrefRangeEnd = 738389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WritePropertyName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WritePropertyName_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0002D550 File Offset: 0x0002B750
		[CallerCount(0)]
		public unsafe virtual void WritePropertyName(string name, bool escape)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref escape;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WritePropertyName_Public_Virtual_New_Void_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0002D5AC File Offset: 0x0002B7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738395, XrefRangeEnd = 738403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteEnd_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0002D5E8 File Offset: 0x0002B7E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 738406, RefRangeEnd = 738407, XrefRangeStart = 738403, XrefRangeEnd = 738406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteToken(JsonReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_WriteToken_Public_Void_JsonReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0002D62C File Offset: 0x0002B82C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 738410, RefRangeEnd = 738411, XrefRangeStart = 738407, XrefRangeEnd = 738410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteToken(JsonReader reader, bool writeChildren)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeChildren;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_WriteToken_Public_Void_JsonReader_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0002D67C File Offset: 0x0002B87C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 738421, RefRangeEnd = 738424, XrefRangeStart = 738411, XrefRangeEnd = 738421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteToken(JsonToken token, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_WriteToken_Public_Void_JsonToken_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0002D6CC File Offset: 0x0002B8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738424, XrefRangeEnd = 738425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteToken(JsonToken token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_WriteToken_Public_Void_JsonToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0002D70C File Offset: 0x0002B90C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 738442, RefRangeEnd = 738443, XrefRangeStart = 738425, XrefRangeEnd = 738442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeChildren;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeDateConstructorAsDate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeComments;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteToken_Internal_Virtual_New_Void_JsonReader_Boolean_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0002D784 File Offset: 0x0002B984
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 738446, RefRangeEnd = 738447, XrefRangeStart = 738443, XrefRangeEnd = 738446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsWriteTokenIncomplete(JsonReader reader, bool writeChildren, int initialDepth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeChildren;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_IsWriteTokenIncomplete_Private_Boolean_JsonReader_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0002D7F0 File Offset: 0x0002B9F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 738448, RefRangeEnd = 738450, XrefRangeStart = 738447, XrefRangeEnd = 738448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CalculateWriteTokenInitialDepth(JsonReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_CalculateWriteTokenInitialDepth_Private_Int32_JsonReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0002D840 File Offset: 0x0002BA40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 738451, RefRangeEnd = 738452, XrefRangeStart = 738450, XrefRangeEnd = 738451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CalculateWriteTokenFinalDepth(JsonReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_CalculateWriteTokenFinalDepth_Private_Int32_JsonReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0002D890 File Offset: 0x0002BA90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 738456, RefRangeEnd = 738457, XrefRangeStart = 738452, XrefRangeEnd = 738456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteConstructorDate(JsonReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_WriteConstructorDate_Private_Void_JsonReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0002D8D4 File Offset: 0x0002BAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738457, XrefRangeEnd = 738465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEnd(JsonContainerType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_WriteEnd_Private_Void_JsonContainerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0002D914 File Offset: 0x0002BB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738465, XrefRangeEnd = 738467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AutoCompleteAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_AutoCompleteAll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0002D948 File Offset: 0x0002BB48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 738467, RefRangeEnd = 738471, XrefRangeStart = 738467, XrefRangeEnd = 738467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonToken GetCloseTokenForType(JsonContainerType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_GetCloseTokenForType_Private_JsonToken_JsonContainerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0002D994 File Offset: 0x0002BB94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 738475, RefRangeEnd = 738478, XrefRangeStart = 738471, XrefRangeEnd = 738475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AutoCompleteClose(JsonContainerType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_AutoCompleteClose_Private_Void_JsonContainerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0002D9D4 File Offset: 0x0002BBD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 738485, RefRangeEnd = 738488, XrefRangeStart = 738478, XrefRangeEnd = 738485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CalculateLevelsToComplete(JsonContainerType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_CalculateLevelsToComplete_Private_Int32_JsonContainerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0002DA20 File Offset: 0x0002BC20
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 738488, RefRangeEnd = 738495, XrefRangeStart = 738488, XrefRangeEnd = 738488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCurrentState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_UpdateCurrentState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0002DA54 File Offset: 0x0002BC54
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteEnd(JsonToken token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteEnd_Protected_Virtual_New_Void_JsonToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0002DAA0 File Offset: 0x0002BCA0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteIndent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteIndent_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0002DADC File Offset: 0x0002BCDC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValueDelimiter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValueDelimiter_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0002DB18 File Offset: 0x0002BD18
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteIndentSpace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteIndentSpace_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0002DB54 File Offset: 0x0002BD54
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 738499, RefRangeEnd = 738528, XrefRangeStart = 738495, XrefRangeEnd = 738499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AutoComplete(JsonToken tokenBeingWritten)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tokenBeingWritten;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_AutoComplete_Internal_Void_JsonToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0002DB94 File Offset: 0x0002BD94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 738529, RefRangeEnd = 738531, XrefRangeStart = 738528, XrefRangeEnd = 738529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteNull_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0002DBD0 File Offset: 0x0002BDD0
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 738532, RefRangeEnd = 738556, XrefRangeStart = 738531, XrefRangeEnd = 738532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteUndefined()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteUndefined_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0002DC0C File Offset: 0x0002BE0C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteRaw(string json)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteRaw_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0002DC5C File Offset: 0x0002BE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738556, XrefRangeEnd = 738557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteRawValue(string json)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteRawValue_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0002DCAC File Offset: 0x0002BEAC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 738558, RefRangeEnd = 738573, XrefRangeStart = 738557, XrefRangeEnd = 738558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0002DCFC File Offset: 0x0002BEFC
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 738574, RefRangeEnd = 738606, XrefRangeStart = 738573, XrefRangeEnd = 738574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0002DD48 File Offset: 0x0002BF48
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 738574, RefRangeEnd = 738606, XrefRangeStart = 738574, XrefRangeEnd = 738606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(uint value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0002DD94 File Offset: 0x0002BF94
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 738574, RefRangeEnd = 738606, XrefRangeStart = 738574, XrefRangeEnd = 738606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0002DDE0 File Offset: 0x0002BFE0
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 738574, RefRangeEnd = 738606, XrefRangeStart = 738574, XrefRangeEnd = 738606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(ulong value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0002DE2C File Offset: 0x0002C02C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 738607, RefRangeEnd = 738619, XrefRangeStart = 738606, XrefRangeEnd = 738607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0002DE78 File Offset: 0x0002C078
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 738607, RefRangeEnd = 738619, XrefRangeStart = 738607, XrefRangeEnd = 738619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0002DEC4 File Offset: 0x0002C0C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 738620, RefRangeEnd = 738624, XrefRangeStart = 738619, XrefRangeEnd = 738620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0002DF10 File Offset: 0x0002C110
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 738574, RefRangeEnd = 738606, XrefRangeStart = 738574, XrefRangeEnd = 738606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(short value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Int16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0002DF5C File Offset: 0x0002C15C
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 738574, RefRangeEnd = 738606, XrefRangeStart = 738574, XrefRangeEnd = 738606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(ushort value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_UInt16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0002DFA8 File Offset: 0x0002C1A8
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 738558, RefRangeEnd = 738573, XrefRangeStart = 738558, XrefRangeEnd = 738573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0002DFF4 File Offset: 0x0002C1F4
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 738574, RefRangeEnd = 738606, XrefRangeStart = 738574, XrefRangeEnd = 738606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(byte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0002E040 File Offset: 0x0002C240
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 738574, RefRangeEnd = 738606, XrefRangeStart = 738574, XrefRangeEnd = 738606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(sbyte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_SByte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0002E08C File Offset: 0x0002C28C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 738607, RefRangeEnd = 738619, XrefRangeStart = 738607, XrefRangeEnd = 738619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(Decimal value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Decimal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0002E0D8 File Offset: 0x0002C2D8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 738625, RefRangeEnd = 738633, XrefRangeStart = 738624, XrefRangeEnd = 738625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0002E124 File Offset: 0x0002C324
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 738625, RefRangeEnd = 738633, XrefRangeStart = 738625, XrefRangeEnd = 738633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(DateTimeOffset value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_DateTimeOffset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0002E170 File Offset: 0x0002C370
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 738558, RefRangeEnd = 738573, XrefRangeStart = 738558, XrefRangeEnd = 738573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(Guid value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x0002E1BC File Offset: 0x0002C3BC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 738558, RefRangeEnd = 738573, XrefRangeStart = 738558, XrefRangeEnd = 738573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(TimeSpan value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_TimeSpan_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0002E208 File Offset: 0x0002C408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738633, XrefRangeEnd = 738635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(Nullable<int> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0002E25C File Offset: 0x0002C45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738635, XrefRangeEnd = 738637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(Nullable<uint> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0002E2B0 File Offset: 0x0002C4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738637, XrefRangeEnd = 738639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(Nullable<long> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0002E304 File Offset: 0x0002C504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738639, XrefRangeEnd = 738641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(Nullable<ulong> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0002E358 File Offset: 0x0002C558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738641, XrefRangeEnd = 738643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(Nullable<float> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0002E3AC File Offset: 0x0002C5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738643, XrefRangeEnd = 738645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(Nullable<double> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x0002E400 File Offset: 0x0002C600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738645, XrefRangeEnd = 738647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(Nullable<bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x0002E454 File Offset: 0x0002C654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738647, XrefRangeEnd = 738649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(Nullable<short> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Int16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x0002E4A8 File Offset: 0x0002C6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738649, XrefRangeEnd = 738651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(Nullable<ushort> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_UInt16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x0002E4FC File Offset: 0x0002C6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738651, XrefRangeEnd = 738653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(Nullable<char> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0002E550 File Offset: 0x0002C750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738653, XrefRangeEnd = 738655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(Nullable<byte> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0002E5A4 File Offset: 0x0002C7A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738655, XrefRangeEnd = 738657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(Nullable<sbyte> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_SByte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0002E5F8 File Offset: 0x0002C7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738657, XrefRangeEnd = 738659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(Nullable<Decimal> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Decimal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0002E64C File Offset: 0x0002C84C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738659, XrefRangeEnd = 738661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(Nullable<DateTime> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0002E6A0 File Offset: 0x0002C8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738661, XrefRangeEnd = 738663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(Nullable<DateTimeOffset> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_DateTimeOffset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x0002E6F4 File Offset: 0x0002C8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738663, XrefRangeEnd = 738665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(Nullable<Guid> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x0002E748 File Offset: 0x0002C948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738665, XrefRangeEnd = 738667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(Nullable<TimeSpan> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_TimeSpan_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0002E79C File Offset: 0x0002C99C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 738668, RefRangeEnd = 738671, XrefRangeStart = 738667, XrefRangeEnd = 738668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(Il2CppStructArray<byte> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0002E7EC File Offset: 0x0002C9EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 738676, RefRangeEnd = 738679, XrefRangeStart = 738671, XrefRangeEnd = 738676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(Uri value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0002E83C File Offset: 0x0002CA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738679, XrefRangeEnd = 738695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0002E88C File Offset: 0x0002CA8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 738696, RefRangeEnd = 738699, XrefRangeStart = 738695, XrefRangeEnd = 738696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteComment(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteComment_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0002E8DC File Offset: 0x0002CADC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 738700, RefRangeEnd = 738704, XrefRangeStart = 738699, XrefRangeEnd = 738700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteWhitespace(string ws)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ws);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0002E92C File Offset: 0x0002CB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738704, XrefRangeEnd = 738708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0002E960 File Offset: 0x0002CB60
		[CallerCount(0)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonWriter.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0002E9AC File Offset: 0x0002CBAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 738758, RefRangeEnd = 738760, XrefRangeStart = 738708, XrefRangeEnd = 738758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref typeCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_WriteValue_Internal_Static_Void_JsonWriter_PrimitiveTypeCode_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0002EA04 File Offset: 0x0002CC04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 738781, RefRangeEnd = 738783, XrefRangeStart = 738760, XrefRangeEnd = 738781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResolveConvertibleValue(IConvertible convertible, out PrimitiveTypeCode typeCode, out Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(convertible);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &typeCode;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_ResolveConvertibleValue_Private_Static_Void_IConvertible_byref_PrimitiveTypeCode_byref_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new Object(intPtr4));
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0002EA6C File Offset: 0x0002CC6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 738793, RefRangeEnd = 738794, XrefRangeStart = 738783, XrefRangeEnd = 738793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_CreateUnsupportedTypeException_Private_Static_JsonWriterException_JsonWriter_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonWriterException>(intPtr3) : null;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0002EAC4 File Offset: 0x0002CCC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 738796, RefRangeEnd = 738799, XrefRangeStart = 738794, XrefRangeEnd = 738796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWriteState(JsonToken token, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_SetWriteState_Protected_Void_JsonToken_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0002EB14 File Offset: 0x0002CD14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 738475, RefRangeEnd = 738478, XrefRangeStart = 738475, XrefRangeEnd = 738478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalWriteEnd(JsonContainerType container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref container;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_InternalWriteEnd_Internal_Void_JsonContainerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0002EB54 File Offset: 0x0002CD54
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 738389, RefRangeEnd = 738395, XrefRangeStart = 738389, XrefRangeEnd = 738395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalWritePropertyName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_InternalWritePropertyName_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x0002EB98 File Offset: 0x0002CD98
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalWriteRaw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_InternalWriteRaw_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0002EBCC File Offset: 0x0002CDCC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 738812, RefRangeEnd = 738819, XrefRangeStart = 738799, XrefRangeEnd = 738812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalWriteStart(JsonToken token, JsonContainerType container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref container;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_InternalWriteStart_Internal_Void_JsonToken_JsonContainerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0002EC18 File Offset: 0x0002CE18
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 738820, RefRangeEnd = 738850, XrefRangeStart = 738819, XrefRangeEnd = 738820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalWriteValue(JsonToken token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_InternalWriteValue_Internal_Void_JsonToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x0002EC58 File Offset: 0x0002CE58
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 738700, RefRangeEnd = 738704, XrefRangeStart = 738700, XrefRangeEnd = 738704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalWriteWhitespace(string ws)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ws);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_InternalWriteWhitespace_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0002EC9C File Offset: 0x0002CE9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 738696, RefRangeEnd = 738699, XrefRangeStart = 738696, XrefRangeEnd = 738699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalWriteComment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_InternalWriteComment_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x0002ECD0 File Offset: 0x0002CED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738850, XrefRangeEnd = 738862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task Method_Private_Task_Task_Int32_JsonToken_CancellationToken_PDM_0(Task task, int LevelsToComplete, JsonToken token, CancellationToken CancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref LevelsToComplete;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref token;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(CancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_Method_Private_Task_Task_Int32_JsonToken_CancellationToken_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0002ED54 File Offset: 0x0002CF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738862, XrefRangeEnd = 738874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task Method_Private_Task_Task_Int32_JsonToken_CancellationToken_PDM_1(Task task, int LevelsToComplete, JsonToken token, CancellationToken CancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref LevelsToComplete;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref token;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(CancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_Method_Private_Task_Task_Int32_JsonToken_CancellationToken_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0002EDD8 File Offset: 0x0002CFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 738874, XrefRangeEnd = 738886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task Method_Private_Task_Task_Int32_CancellationToken_PDM_0(Task task, int LevelsToComplete, CancellationToken CancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref LevelsToComplete;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(CancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_Method_Private_Task_Task_Int32_CancellationToken_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0002EE50 File Offset: 0x0002D050
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 738897, RefRangeEnd = 738900, XrefRangeStart = 738886, XrefRangeEnd = 738897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task Method_Private_Task_Int32_CancellationToken_0(int LevelsToComplete, CancellationToken CancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref LevelsToComplete;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(CancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.NativeMethodInfoPtr_Method_Private_Task_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00003BDC File Offset: 0x00001DDC
		public JsonWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x0002EEB4 File Offset: 0x0002D0B4
		// (set) Token: 0x060005ED RID: 1517 RVA: 0x00003BE5 File Offset: 0x00001DE5
		public unsafe static Il2CppReferenceArray<Il2CppStructArray<JsonWriter.State>> StateArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonWriter.NativeFieldInfoPtr_StateArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<JsonWriter.State>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonWriter.NativeFieldInfoPtr_StateArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x0002EEDC File Offset: 0x0002D0DC
		// (set) Token: 0x060005EF RID: 1519 RVA: 0x00003BF7 File Offset: 0x00001DF7
		public unsafe static Il2CppReferenceArray<Il2CppStructArray<JsonWriter.State>> StateArrayTemplate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonWriter.NativeFieldInfoPtr_StateArrayTemplate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<JsonWriter.State>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonWriter.NativeFieldInfoPtr_StateArrayTemplate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x0002EF04 File Offset: 0x0002D104
		// (set) Token: 0x060005F1 RID: 1521 RVA: 0x00003C09 File Offset: 0x00001E09
		public unsafe List<JsonPosition> _stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.NativeFieldInfoPtr__stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<JsonPosition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.NativeFieldInfoPtr__stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x0002EF34 File Offset: 0x0002D134
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x00003C28 File Offset: 0x00001E28
		public JsonPosition _currentPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.NativeFieldInfoPtr__currentPosition);
				return new JsonPosition(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JsonPosition>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.NativeFieldInfoPtr__currentPosition), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<JsonPosition>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x0002EF64 File Offset: 0x0002D164
		// (set) Token: 0x060005F5 RID: 1525 RVA: 0x00003C56 File Offset: 0x00001E56
		public unsafe JsonWriter.State _currentState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.NativeFieldInfoPtr__currentState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.NativeFieldInfoPtr__currentState)) = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x0002EF8C File Offset: 0x0002D18C
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x00003C71 File Offset: 0x00001E71
		public unsafe Formatting _formatting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.NativeFieldInfoPtr__formatting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.NativeFieldInfoPtr__formatting)) = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x0002EFB4 File Offset: 0x0002D1B4
		// (set) Token: 0x060005F9 RID: 1529 RVA: 0x00003C8C File Offset: 0x00001E8C
		public unsafe bool _CloseOutput_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.NativeFieldInfoPtr__CloseOutput_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.NativeFieldInfoPtr__CloseOutput_k__BackingField)) = value;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x0002EFDC File Offset: 0x0002D1DC
		// (set) Token: 0x060005FB RID: 1531 RVA: 0x00003CA7 File Offset: 0x00001EA7
		public unsafe bool _AutoCompleteOnClose_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.NativeFieldInfoPtr__AutoCompleteOnClose_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.NativeFieldInfoPtr__AutoCompleteOnClose_k__BackingField)) = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x0002F004 File Offset: 0x0002D204
		// (set) Token: 0x060005FD RID: 1533 RVA: 0x00003CC2 File Offset: 0x00001EC2
		public unsafe DateFormatHandling _dateFormatHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.NativeFieldInfoPtr__dateFormatHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.NativeFieldInfoPtr__dateFormatHandling)) = value;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x0002F02C File Offset: 0x0002D22C
		// (set) Token: 0x060005FF RID: 1535 RVA: 0x00003CDD File Offset: 0x00001EDD
		public unsafe DateTimeZoneHandling _dateTimeZoneHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.NativeFieldInfoPtr__dateTimeZoneHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.NativeFieldInfoPtr__dateTimeZoneHandling)) = value;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x0002F054 File Offset: 0x0002D254
		// (set) Token: 0x06000601 RID: 1537 RVA: 0x00003CF8 File Offset: 0x00001EF8
		public unsafe StringEscapeHandling _stringEscapeHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.NativeFieldInfoPtr__stringEscapeHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.NativeFieldInfoPtr__stringEscapeHandling)) = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x0002F07C File Offset: 0x0002D27C
		// (set) Token: 0x06000603 RID: 1539 RVA: 0x00003D13 File Offset: 0x00001F13
		public unsafe FloatFormatHandling _floatFormatHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.NativeFieldInfoPtr__floatFormatHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.NativeFieldInfoPtr__floatFormatHandling)) = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x0002F0A4 File Offset: 0x0002D2A4
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x00003D2E File Offset: 0x00001F2E
		public unsafe string _dateFormatString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.NativeFieldInfoPtr__dateFormatString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.NativeFieldInfoPtr__dateFormatString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x0002F0CC File Offset: 0x0002D2CC
		// (set) Token: 0x06000607 RID: 1543 RVA: 0x00003D4D File Offset: 0x00001F4D
		public unsafe CultureInfo _culture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.NativeFieldInfoPtr__culture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.NativeFieldInfoPtr__culture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeFieldInfoPtr_StateArray;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeFieldInfoPtr_StateArrayTemplate;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeFieldInfoPtr__stack;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeFieldInfoPtr__currentPosition;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeFieldInfoPtr__currentState;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeFieldInfoPtr__formatting;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeFieldInfoPtr__CloseOutput_k__BackingField;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeFieldInfoPtr__AutoCompleteOnClose_k__BackingField;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeFieldInfoPtr__dateFormatHandling;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeFieldInfoPtr__dateTimeZoneHandling;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeFieldInfoPtr__stringEscapeHandling;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeFieldInfoPtr__floatFormatHandling;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeFieldInfoPtr__dateFormatString;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeFieldInfoPtr__culture;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr_AutoCompleteAsync_Internal_Task_JsonToken_CancellationToken_0;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr_AutoCompleteAsync_Private_Task_CancellationToken_0;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr_CloseAsync_Public_Virtual_New_Task_CancellationToken_0;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeMethodInfoPtr_FlushAsync_Public_Virtual_New_Task_CancellationToken_0;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndAsync_Protected_Virtual_New_Task_JsonToken_CancellationToken_0;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeMethodInfoPtr_WriteIndentAsync_Protected_Virtual_New_Task_CancellationToken_0;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueDelimiterAsync_Protected_Virtual_New_Task_CancellationToken_0;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeMethodInfoPtr_WriteIndentSpaceAsync_Protected_Virtual_New_Task_CancellationToken_0;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeMethodInfoPtr_WriteRawAsync_Public_Virtual_New_Task_String_CancellationToken_0;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndAsync_Public_Virtual_New_Task_CancellationToken_0;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndInternalAsync_Internal_Task_CancellationToken_0;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeMethodInfoPtr_InternalWriteEndAsync_Internal_Task_JsonContainerType_CancellationToken_0;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndArrayAsync_Public_Virtual_New_Task_CancellationToken_0;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndConstructorAsync_Public_Virtual_New_Task_CancellationToken_0;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndObjectAsync_Public_Virtual_New_Task_CancellationToken_0;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeMethodInfoPtr_WriteNullAsync_Public_Virtual_New_Task_CancellationToken_0;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeMethodInfoPtr_WritePropertyNameAsync_Public_Virtual_New_Task_String_CancellationToken_0;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeMethodInfoPtr_WritePropertyNameAsync_Public_Virtual_New_Task_String_Boolean_CancellationToken_0;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeMethodInfoPtr_InternalWritePropertyNameAsync_Internal_Task_String_CancellationToken_0;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartArrayAsync_Public_Virtual_New_Task_CancellationToken_0;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeMethodInfoPtr_InternalWriteStartAsync_Internal_Task_JsonToken_JsonContainerType_CancellationToken_0;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeMethodInfoPtr_WriteCommentAsync_Public_Virtual_New_Task_String_CancellationToken_0;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeMethodInfoPtr_InternalWriteCommentAsync_Internal_Task_CancellationToken_0;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeMethodInfoPtr_WriteRawValueAsync_Public_Virtual_New_Task_String_CancellationToken_0;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartConstructorAsync_Public_Virtual_New_Task_String_CancellationToken_0;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartObjectAsync_Public_Virtual_New_Task_CancellationToken_0;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeMethodInfoPtr_WriteTokenAsync_Public_Task_JsonReader_CancellationToken_0;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeMethodInfoPtr_WriteTokenAsync_Public_Task_JsonReader_Boolean_CancellationToken_0;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeMethodInfoPtr_WriteTokenAsync_Public_Task_JsonToken_CancellationToken_0;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeMethodInfoPtr_WriteTokenAsync_Public_Task_JsonToken_Object_CancellationToken_0;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeMethodInfoPtr_WriteTokenAsync_Internal_Virtual_New_Task_JsonReader_Boolean_Boolean_Boolean_CancellationToken_0;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeMethodInfoPtr_WriteTokenSyncReadingAsync_Internal_Task_JsonReader_CancellationToken_0;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeMethodInfoPtr_WriteConstructorDateAsync_Private_Task_JsonReader_CancellationToken_0;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Boolean_CancellationToken_0;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Boolean_CancellationToken_0;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Byte_CancellationToken_0;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Byte_CancellationToken_0;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Il2CppStructArray_1_Byte_CancellationToken_0;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Char_CancellationToken_0;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Char_CancellationToken_0;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_DateTime_CancellationToken_0;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_DateTime_CancellationToken_0;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_DateTimeOffset_CancellationToken_0;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_DateTimeOffset_CancellationToken_0;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Decimal_CancellationToken_0;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Decimal_CancellationToken_0;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Double_CancellationToken_0;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Double_CancellationToken_0;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Single_CancellationToken_0;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Single_CancellationToken_0;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Guid_CancellationToken_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Guid_CancellationToken_0;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Int32_CancellationToken_0;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Int32_CancellationToken_0;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Int64_CancellationToken_0;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Int64_CancellationToken_0;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Object_CancellationToken_0;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_SByte_CancellationToken_0;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_SByte_CancellationToken_0;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Int16_CancellationToken_0;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_Int16_CancellationToken_0;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_String_CancellationToken_0;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_TimeSpan_CancellationToken_0;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_TimeSpan_CancellationToken_0;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_UInt32_CancellationToken_0;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_UInt32_CancellationToken_0;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_UInt64_CancellationToken_0;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_UInt64_CancellationToken_0;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Uri_CancellationToken_0;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_UInt16_CancellationToken_0;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Public_Virtual_New_Task_Nullable_1_UInt16_CancellationToken_0;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeMethodInfoPtr_WriteUndefinedAsync_Public_Virtual_New_Task_CancellationToken_0;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeMethodInfoPtr_WriteWhitespaceAsync_Public_Virtual_New_Task_String_CancellationToken_0;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeMethodInfoPtr_InternalWriteValueAsync_Internal_Task_JsonToken_CancellationToken_0;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr_SetWriteStateAsync_Protected_Task_JsonToken_Object_CancellationToken_0;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueAsync_Internal_Static_Task_JsonWriter_PrimitiveTypeCode_Object_CancellationToken_0;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr_BuildStateArray_Internal_Static_Il2CppReferenceArray_1_Il2CppStructArray_1_State_0;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeMethodInfoPtr_get_CloseOutput_Public_get_Boolean_0;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeMethodInfoPtr_set_CloseOutput_Public_set_Void_Boolean_0;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr_get_AutoCompleteOnClose_Public_get_Boolean_0;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeMethodInfoPtr_set_AutoCompleteOnClose_Public_set_Void_Boolean_0;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr_get_Top_FamOrAssem_get_Int32_0;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr_get_WriteState_Public_get_WriteState_0;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr_get_ContainerPath_Internal_get_String_0;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeMethodInfoPtr_get_Path_Public_get_String_0;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeMethodInfoPtr_get_Formatting_Public_get_Formatting_0;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeMethodInfoPtr_set_Formatting_Public_set_Void_Formatting_0;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeMethodInfoPtr_get_DateFormatHandling_Public_get_DateFormatHandling_0;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeMethodInfoPtr_set_DateFormatHandling_Public_set_Void_DateFormatHandling_0;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeMethodInfoPtr_get_DateTimeZoneHandling_Public_get_DateTimeZoneHandling_0;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeMethodInfoPtr_set_DateTimeZoneHandling_Public_set_Void_DateTimeZoneHandling_0;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeMethodInfoPtr_get_StringEscapeHandling_Public_get_StringEscapeHandling_0;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeMethodInfoPtr_set_StringEscapeHandling_Public_set_Void_StringEscapeHandling_0;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeMethodInfoPtr_OnStringEscapeHandlingChanged_Internal_Virtual_New_Void_0;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeMethodInfoPtr_get_FloatFormatHandling_Public_get_FloatFormatHandling_0;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeMethodInfoPtr_set_FloatFormatHandling_Public_set_Void_FloatFormatHandling_0;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeMethodInfoPtr_get_DateFormatString_Public_get_String_0;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeMethodInfoPtr_set_DateFormatString_Public_set_Void_String_0;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeMethodInfoPtr_get_Culture_Public_get_CultureInfo_0;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeMethodInfoPtr_set_Culture_Public_set_Void_CultureInfo_0;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScopeWithFinishedValue_Internal_Void_0;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeMethodInfoPtr_Push_Private_Void_JsonContainerType_0;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Private_JsonContainerType_0;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Private_JsonContainerType_0;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartObject_Public_Virtual_New_Void_0;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndObject_Public_Virtual_New_Void_0;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartArray_Public_Virtual_New_Void_0;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndArray_Public_Virtual_New_Void_0;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartConstructor_Public_Virtual_New_Void_String_0;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeMethodInfoPtr_WriteEndConstructor_Public_Virtual_New_Void_0;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr_WritePropertyName_Public_Virtual_New_Void_String_0;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr_WritePropertyName_Public_Virtual_New_Void_String_Boolean_0;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeMethodInfoPtr_WriteEnd_Public_Virtual_New_Void_0;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeMethodInfoPtr_WriteToken_Public_Void_JsonReader_0;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeMethodInfoPtr_WriteToken_Public_Void_JsonReader_Boolean_0;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeMethodInfoPtr_WriteToken_Public_Void_JsonToken_Object_0;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeMethodInfoPtr_WriteToken_Public_Void_JsonToken_0;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeMethodInfoPtr_WriteToken_Internal_Virtual_New_Void_JsonReader_Boolean_Boolean_Boolean_0;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeMethodInfoPtr_IsWriteTokenIncomplete_Private_Boolean_JsonReader_Boolean_Int32_0;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeMethodInfoPtr_CalculateWriteTokenInitialDepth_Private_Int32_JsonReader_0;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeMethodInfoPtr_CalculateWriteTokenFinalDepth_Private_Int32_JsonReader_0;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeMethodInfoPtr_WriteConstructorDate_Private_Void_JsonReader_0;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeMethodInfoPtr_WriteEnd_Private_Void_JsonContainerType_0;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeMethodInfoPtr_AutoCompleteAll_Private_Void_0;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeMethodInfoPtr_GetCloseTokenForType_Private_JsonToken_JsonContainerType_0;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeMethodInfoPtr_AutoCompleteClose_Private_Void_JsonContainerType_0;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLevelsToComplete_Private_Int32_JsonContainerType_0;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrentState_Private_Void_0;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeMethodInfoPtr_WriteEnd_Protected_Virtual_New_Void_JsonToken_0;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeMethodInfoPtr_WriteIndent_Protected_Virtual_New_Void_0;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeMethodInfoPtr_WriteValueDelimiter_Protected_Virtual_New_Void_0;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeMethodInfoPtr_WriteIndentSpace_Protected_Virtual_New_Void_0;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeMethodInfoPtr_AutoComplete_Internal_Void_JsonToken_0;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeMethodInfoPtr_WriteNull_Public_Virtual_New_Void_0;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeMethodInfoPtr_WriteUndefined_Public_Virtual_New_Void_0;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeMethodInfoPtr_WriteRaw_Public_Virtual_New_Void_String_0;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeMethodInfoPtr_WriteRawValue_Public_Virtual_New_Void_String_0;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_String_0;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Int32_0;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_UInt32_0;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Int64_0;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_UInt64_0;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Single_0;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Double_0;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Int16_0;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_UInt16_0;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Char_0;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Byte_0;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_SByte_0;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Decimal_0;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_DateTime_0;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_DateTimeOffset_0;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Guid_0;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_TimeSpan_0;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Int32_0;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_UInt32_0;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Int64_0;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_UInt64_0;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Single_0;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Double_0;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Boolean_0;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Int16_0;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_UInt16_0;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Char_0;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Byte_0;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_SByte_0;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Decimal_0;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_DateTime_0;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_DateTimeOffset_0;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_Guid_0;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Nullable_1_TimeSpan_0;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Uri_0;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Object_0;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeMethodInfoPtr_WriteComment_Public_Virtual_New_Void_String_0;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr_WriteWhitespace_Public_Virtual_New_Void_String_0;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Internal_Static_Void_JsonWriter_PrimitiveTypeCode_Object_0;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeMethodInfoPtr_ResolveConvertibleValue_Private_Static_Void_IConvertible_byref_PrimitiveTypeCode_byref_Object_0;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeMethodInfoPtr_CreateUnsupportedTypeException_Private_Static_JsonWriterException_JsonWriter_Object_0;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeMethodInfoPtr_SetWriteState_Protected_Void_JsonToken_Object_0;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr_InternalWriteEnd_Internal_Void_JsonContainerType_0;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr_InternalWritePropertyName_Internal_Void_String_0;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr_InternalWriteRaw_Internal_Void_0;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeMethodInfoPtr_InternalWriteStart_Internal_Void_JsonToken_JsonContainerType_0;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeMethodInfoPtr_InternalWriteValue_Internal_Void_JsonToken_0;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeMethodInfoPtr_InternalWriteWhitespace_Internal_Void_String_0;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeMethodInfoPtr_InternalWriteComment_Internal_Void_0;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Task_Task_Int32_JsonToken_CancellationToken_PDM_0;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Task_Task_Int32_JsonToken_CancellationToken_PDM_1;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Task_Task_Int32_CancellationToken_PDM_0;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Task_Int32_CancellationToken_0;

		// Token: 0x0200015C RID: 348
		public enum State
		{
			// Token: 0x04001477 RID: 5239
			Start,
			// Token: 0x04001478 RID: 5240
			Property,
			// Token: 0x04001479 RID: 5241
			ObjectStart,
			// Token: 0x0400147A RID: 5242
			Object,
			// Token: 0x0400147B RID: 5243
			ArrayStart,
			// Token: 0x0400147C RID: 5244
			Array,
			// Token: 0x0400147D RID: 5245
			ConstructorStart,
			// Token: 0x0400147E RID: 5246
			Constructor,
			// Token: 0x0400147F RID: 5247
			Closed,
			// Token: 0x04001480 RID: 5248
			Error
		}

		// Token: 0x0200015D RID: 349
		[ObfuscatedName("Newtonsoft.Json.JsonWriter+<<InternalWriteEndAsync>g__AwaitEnd|11_2>d")]
		public sealed class ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique : ValueType
		{
			// Token: 0x06001B3A RID: 6970 RVA: 0x000831A8 File Offset: 0x000813A8
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique()
			{
				Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "<<InternalWriteEndAsync>g__AwaitEnd|11_2>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique>.NativeClassPtr);
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique>.NativeClassPtr, "<>1__state");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique>.NativeClassPtr, "<>t__builder");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique.NativeFieldInfoPtr_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique>.NativeClassPtr, "task");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique>.NativeClassPtr, "<>4__this");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique.NativeFieldInfoPtr_LevelsToComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique>.NativeClassPtr, "LevelsToComplete");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique.NativeFieldInfoPtr_CancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique>.NativeClassPtr, "CancellationToken");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique>.NativeClassPtr, "<>u__1");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique>.NativeClassPtr, 100664499);
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique>.NativeClassPtr, 100664500);
			}

			// Token: 0x06001B3B RID: 6971 RVA: 0x00083288 File Offset: 0x00081488
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737194, XrefRangeEnd = 737209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B3C RID: 6972 RVA: 0x000832C0 File Offset: 0x000814C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737209, XrefRangeEnd = 737213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B3D RID: 6973 RVA: 0x0000D1B8 File Offset: 0x0000B3B8
			public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B3E RID: 6974 RVA: 0x0000D1C1 File Offset: 0x0000B3C1
			public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique>.NativeClassPtr))
			{
			}

			// Token: 0x170007A0 RID: 1952
			// (get) Token: 0x06001B3F RID: 6975 RVA: 0x00083308 File Offset: 0x00081508
			// (set) Token: 0x06001B40 RID: 6976 RVA: 0x0000D1D3 File Offset: 0x0000B3D3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007A1 RID: 1953
			// (get) Token: 0x06001B41 RID: 6977 RVA: 0x00083330 File Offset: 0x00081530
			// (set) Token: 0x06001B42 RID: 6978 RVA: 0x0000D1EE File Offset: 0x0000B3EE
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007A2 RID: 1954
			// (get) Token: 0x06001B43 RID: 6979 RVA: 0x00083360 File Offset: 0x00081560
			// (set) Token: 0x06001B44 RID: 6980 RVA: 0x0000D21C File Offset: 0x0000B41C
			public unsafe Task task
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique.NativeFieldInfoPtr_task);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique.NativeFieldInfoPtr_task), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A3 RID: 1955
			// (get) Token: 0x06001B45 RID: 6981 RVA: 0x00083390 File Offset: 0x00081590
			// (set) Token: 0x06001B46 RID: 6982 RVA: 0x0000D23B File Offset: 0x0000B43B
			public unsafe JsonWriter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A4 RID: 1956
			// (get) Token: 0x06001B47 RID: 6983 RVA: 0x000833C0 File Offset: 0x000815C0
			// (set) Token: 0x06001B48 RID: 6984 RVA: 0x0000D25A File Offset: 0x0000B45A
			public unsafe int LevelsToComplete
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique.NativeFieldInfoPtr_LevelsToComplete);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique.NativeFieldInfoPtr_LevelsToComplete)) = value;
				}
			}

			// Token: 0x170007A5 RID: 1957
			// (get) Token: 0x06001B49 RID: 6985 RVA: 0x000833E8 File Offset: 0x000815E8
			// (set) Token: 0x06001B4A RID: 6986 RVA: 0x0000D275 File Offset: 0x0000B475
			public CancellationToken CancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique.NativeFieldInfoPtr_CancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique.NativeFieldInfoPtr_CancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007A6 RID: 1958
			// (get) Token: 0x06001B4B RID: 6987 RVA: 0x00083418 File Offset: 0x00081618
			// (set) Token: 0x06001B4C RID: 6988 RVA: 0x0000D2A3 File Offset: 0x0000B4A3
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsLeInCaCoCaUnique.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001481 RID: 5249
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001482 RID: 5250
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001483 RID: 5251
			private static readonly IntPtr NativeFieldInfoPtr_task;

			// Token: 0x04001484 RID: 5252
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001485 RID: 5253
			private static readonly IntPtr NativeFieldInfoPtr_LevelsToComplete;

			// Token: 0x04001486 RID: 5254
			private static readonly IntPtr NativeFieldInfoPtr_CancellationToken;

			// Token: 0x04001487 RID: 5255
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001488 RID: 5256
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001489 RID: 5257
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200015E RID: 350
		[ObfuscatedName("Newtonsoft.Json.JsonWriter+<<InternalWriteEndAsync>g__AwaitIndent|11_1>d")]
		public sealed class ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique : ValueType
		{
			// Token: 0x06001B4D RID: 6989 RVA: 0x00083448 File Offset: 0x00081648
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique()
			{
				Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "<<InternalWriteEndAsync>g__AwaitIndent|11_1>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique>.NativeClassPtr);
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique>.NativeClassPtr, "<>1__state");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique>.NativeClassPtr, "<>t__builder");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeFieldInfoPtr_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique>.NativeClassPtr, "task");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique>.NativeClassPtr, "<>4__this");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeFieldInfoPtr_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique>.NativeClassPtr, "token");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeFieldInfoPtr_CancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique>.NativeClassPtr, "CancellationToken");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeFieldInfoPtr_LevelsToComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique>.NativeClassPtr, "LevelsToComplete");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique>.NativeClassPtr, "<>u__1");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique>.NativeClassPtr, 100664501);
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique>.NativeClassPtr, 100664502);
			}

			// Token: 0x06001B4E RID: 6990 RVA: 0x0008353C File Offset: 0x0008173C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737213, XrefRangeEnd = 737237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B4F RID: 6991 RVA: 0x00083574 File Offset: 0x00081774
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737237, XrefRangeEnd = 737241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B50 RID: 6992 RVA: 0x0000D2D1 File Offset: 0x0000B4D1
			public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B51 RID: 6993 RVA: 0x0000D2DA File Offset: 0x0000B4DA
			public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique>.NativeClassPtr))
			{
			}

			// Token: 0x170007A7 RID: 1959
			// (get) Token: 0x06001B52 RID: 6994 RVA: 0x000835BC File Offset: 0x000817BC
			// (set) Token: 0x06001B53 RID: 6995 RVA: 0x0000D2EC File Offset: 0x0000B4EC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007A8 RID: 1960
			// (get) Token: 0x06001B54 RID: 6996 RVA: 0x000835E4 File Offset: 0x000817E4
			// (set) Token: 0x06001B55 RID: 6997 RVA: 0x0000D307 File Offset: 0x0000B507
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007A9 RID: 1961
			// (get) Token: 0x06001B56 RID: 6998 RVA: 0x00083614 File Offset: 0x00081814
			// (set) Token: 0x06001B57 RID: 6999 RVA: 0x0000D335 File Offset: 0x0000B535
			public unsafe Task task
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeFieldInfoPtr_task);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeFieldInfoPtr_task), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007AA RID: 1962
			// (get) Token: 0x06001B58 RID: 7000 RVA: 0x00083644 File Offset: 0x00081844
			// (set) Token: 0x06001B59 RID: 7001 RVA: 0x0000D354 File Offset: 0x0000B554
			public unsafe JsonWriter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007AB RID: 1963
			// (get) Token: 0x06001B5A RID: 7002 RVA: 0x00083674 File Offset: 0x00081874
			// (set) Token: 0x06001B5B RID: 7003 RVA: 0x0000D373 File Offset: 0x0000B573
			public unsafe JsonToken token
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeFieldInfoPtr_token);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeFieldInfoPtr_token)) = value;
				}
			}

			// Token: 0x170007AC RID: 1964
			// (get) Token: 0x06001B5C RID: 7004 RVA: 0x0008369C File Offset: 0x0008189C
			// (set) Token: 0x06001B5D RID: 7005 RVA: 0x0000D38E File Offset: 0x0000B58E
			public CancellationToken CancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeFieldInfoPtr_CancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeFieldInfoPtr_CancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007AD RID: 1965
			// (get) Token: 0x06001B5E RID: 7006 RVA: 0x000836CC File Offset: 0x000818CC
			// (set) Token: 0x06001B5F RID: 7007 RVA: 0x0000D3BC File Offset: 0x0000B5BC
			public unsafe int LevelsToComplete
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeFieldInfoPtr_LevelsToComplete);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeFieldInfoPtr_LevelsToComplete)) = value;
				}
			}

			// Token: 0x170007AE RID: 1966
			// (get) Token: 0x06001B60 RID: 7008 RVA: 0x000836F4 File Offset: 0x000818F4
			// (set) Token: 0x06001B61 RID: 7009 RVA: 0x0000D3D7 File Offset: 0x0000B5D7
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJstoJsCaLeCaUnique.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400148A RID: 5258
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400148B RID: 5259
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400148C RID: 5260
			private static readonly IntPtr NativeFieldInfoPtr_task;

			// Token: 0x0400148D RID: 5261
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400148E RID: 5262
			private static readonly IntPtr NativeFieldInfoPtr_token;

			// Token: 0x0400148F RID: 5263
			private static readonly IntPtr NativeFieldInfoPtr_CancellationToken;

			// Token: 0x04001490 RID: 5264
			private static readonly IntPtr NativeFieldInfoPtr_LevelsToComplete;

			// Token: 0x04001491 RID: 5265
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001492 RID: 5266
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001493 RID: 5267
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200015F RID: 351
		[ObfuscatedName("Newtonsoft.Json.JsonWriter+<<InternalWriteEndAsync>g__AwaitProperty|11_0>d")]
		public sealed class ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique : ValueType
		{
			// Token: 0x06001B62 RID: 7010 RVA: 0x00083724 File Offset: 0x00081924
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique()
			{
				Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "<<InternalWriteEndAsync>g__AwaitProperty|11_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique>.NativeClassPtr);
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique>.NativeClassPtr, "<>1__state");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique>.NativeClassPtr, "<>t__builder");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeFieldInfoPtr_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique>.NativeClassPtr, "task");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique>.NativeClassPtr, "<>4__this");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeFieldInfoPtr_CancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique>.NativeClassPtr, "CancellationToken");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeFieldInfoPtr_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique>.NativeClassPtr, "token");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeFieldInfoPtr_LevelsToComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique>.NativeClassPtr, "LevelsToComplete");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique>.NativeClassPtr, "<>u__1");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique>.NativeClassPtr, 100664503);
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique>.NativeClassPtr, 100664504);
			}

			// Token: 0x06001B63 RID: 7011 RVA: 0x00083818 File Offset: 0x00081A18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737241, XrefRangeEnd = 737269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B64 RID: 7012 RVA: 0x00083850 File Offset: 0x00081A50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737269, XrefRangeEnd = 737273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B65 RID: 7013 RVA: 0x0000D405 File Offset: 0x0000B605
			public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B66 RID: 7014 RVA: 0x0000D40E File Offset: 0x0000B60E
			public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique>.NativeClassPtr))
			{
			}

			// Token: 0x170007AF RID: 1967
			// (get) Token: 0x06001B67 RID: 7015 RVA: 0x00083898 File Offset: 0x00081A98
			// (set) Token: 0x06001B68 RID: 7016 RVA: 0x0000D420 File Offset: 0x0000B620
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007B0 RID: 1968
			// (get) Token: 0x06001B69 RID: 7017 RVA: 0x000838C0 File Offset: 0x00081AC0
			// (set) Token: 0x06001B6A RID: 7018 RVA: 0x0000D43B File Offset: 0x0000B63B
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007B1 RID: 1969
			// (get) Token: 0x06001B6B RID: 7019 RVA: 0x000838F0 File Offset: 0x00081AF0
			// (set) Token: 0x06001B6C RID: 7020 RVA: 0x0000D469 File Offset: 0x0000B669
			public unsafe Task task
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeFieldInfoPtr_task);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeFieldInfoPtr_task), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007B2 RID: 1970
			// (get) Token: 0x06001B6D RID: 7021 RVA: 0x00083920 File Offset: 0x00081B20
			// (set) Token: 0x06001B6E RID: 7022 RVA: 0x0000D488 File Offset: 0x0000B688
			public unsafe JsonWriter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007B3 RID: 1971
			// (get) Token: 0x06001B6F RID: 7023 RVA: 0x00083950 File Offset: 0x00081B50
			// (set) Token: 0x06001B70 RID: 7024 RVA: 0x0000D4A7 File Offset: 0x0000B6A7
			public CancellationToken CancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeFieldInfoPtr_CancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeFieldInfoPtr_CancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007B4 RID: 1972
			// (get) Token: 0x06001B71 RID: 7025 RVA: 0x00083980 File Offset: 0x00081B80
			// (set) Token: 0x06001B72 RID: 7026 RVA: 0x0000D4D5 File Offset: 0x0000B6D5
			public unsafe JsonToken token
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeFieldInfoPtr_token);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeFieldInfoPtr_token)) = value;
				}
			}

			// Token: 0x170007B5 RID: 1973
			// (get) Token: 0x06001B73 RID: 7027 RVA: 0x000839A8 File Offset: 0x00081BA8
			// (set) Token: 0x06001B74 RID: 7028 RVA: 0x0000D4F0 File Offset: 0x0000B6F0
			public unsafe int LevelsToComplete
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeFieldInfoPtr_LevelsToComplete);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeFieldInfoPtr_LevelsToComplete)) = value;
				}
			}

			// Token: 0x170007B6 RID: 1974
			// (get) Token: 0x06001B75 RID: 7029 RVA: 0x000839D0 File Offset: 0x00081BD0
			// (set) Token: 0x06001B76 RID: 7030 RVA: 0x0000D50B File Offset: 0x0000B70B
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJsCatoCaJsLeUnique.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001494 RID: 5268
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001495 RID: 5269
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001496 RID: 5270
			private static readonly IntPtr NativeFieldInfoPtr_task;

			// Token: 0x04001497 RID: 5271
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001498 RID: 5272
			private static readonly IntPtr NativeFieldInfoPtr_CancellationToken;

			// Token: 0x04001499 RID: 5273
			private static readonly IntPtr NativeFieldInfoPtr_token;

			// Token: 0x0400149A RID: 5274
			private static readonly IntPtr NativeFieldInfoPtr_LevelsToComplete;

			// Token: 0x0400149B RID: 5275
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400149C RID: 5276
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400149D RID: 5277
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000160 RID: 352
		[ObfuscatedName("Newtonsoft.Json.JsonWriter+<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d")]
		public sealed class ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique : ValueType
		{
			// Token: 0x06001B77 RID: 7031 RVA: 0x00083A00 File Offset: 0x00081C00
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique()
			{
				Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique>.NativeClassPtr);
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique>.NativeClassPtr, "<>1__state");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique>.NativeClassPtr, "<>t__builder");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique>.NativeClassPtr, "<>4__this");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique.NativeFieldInfoPtr_CancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique>.NativeClassPtr, "CancellationToken");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique.NativeFieldInfoPtr_LevelsToComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique>.NativeClassPtr, "LevelsToComplete");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique.NativeFieldInfoPtr__token_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique>.NativeClassPtr, "<token>5__2");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique>.NativeClassPtr, "<>u__1");
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique>.NativeClassPtr, 100664505);
				JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique>.NativeClassPtr, 100664506);
			}

			// Token: 0x06001B78 RID: 7032 RVA: 0x00083AE0 File Offset: 0x00081CE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737273, XrefRangeEnd = 737304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B79 RID: 7033 RVA: 0x00083B18 File Offset: 0x00081D18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737304, XrefRangeEnd = 737308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B7A RID: 7034 RVA: 0x0000D539 File Offset: 0x0000B739
			public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B7B RID: 7035 RVA: 0x0000D542 File Offset: 0x0000B742
			public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique>.NativeClassPtr))
			{
			}

			// Token: 0x170007B7 RID: 1975
			// (get) Token: 0x06001B7C RID: 7036 RVA: 0x00083B60 File Offset: 0x00081D60
			// (set) Token: 0x06001B7D RID: 7037 RVA: 0x0000D554 File Offset: 0x0000B754
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007B8 RID: 1976
			// (get) Token: 0x06001B7E RID: 7038 RVA: 0x00083B88 File Offset: 0x00081D88
			// (set) Token: 0x06001B7F RID: 7039 RVA: 0x0000D56F File Offset: 0x0000B76F
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007B9 RID: 1977
			// (get) Token: 0x06001B80 RID: 7040 RVA: 0x00083BB8 File Offset: 0x00081DB8
			// (set) Token: 0x06001B81 RID: 7041 RVA: 0x0000D59D File Offset: 0x0000B79D
			public unsafe JsonWriter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007BA RID: 1978
			// (get) Token: 0x06001B82 RID: 7042 RVA: 0x00083BE8 File Offset: 0x00081DE8
			// (set) Token: 0x06001B83 RID: 7043 RVA: 0x0000D5BC File Offset: 0x0000B7BC
			public CancellationToken CancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique.NativeFieldInfoPtr_CancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique.NativeFieldInfoPtr_CancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007BB RID: 1979
			// (get) Token: 0x06001B84 RID: 7044 RVA: 0x00083C18 File Offset: 0x00081E18
			// (set) Token: 0x06001B85 RID: 7045 RVA: 0x0000D5EA File Offset: 0x0000B7EA
			public unsafe int LevelsToComplete
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique.NativeFieldInfoPtr_LevelsToComplete);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique.NativeFieldInfoPtr_LevelsToComplete)) = value;
				}
			}

			// Token: 0x170007BC RID: 1980
			// (get) Token: 0x06001B86 RID: 7046 RVA: 0x00083C40 File Offset: 0x00081E40
			// (set) Token: 0x06001B87 RID: 7047 RVA: 0x0000D605 File Offset: 0x0000B805
			public unsafe JsonToken _token_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique.NativeFieldInfoPtr__token_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique.NativeFieldInfoPtr__token_5__2)) = value;
				}
			}

			// Token: 0x170007BD RID: 1981
			// (get) Token: 0x06001B88 RID: 7048 RVA: 0x00083C68 File Offset: 0x00081E68
			// (set) Token: 0x06001B89 RID: 7049 RVA: 0x0000D620 File Offset: 0x0000B820
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsJsCaLeCaInCoJsUnique.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400149E RID: 5278
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400149F RID: 5279
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040014A0 RID: 5280
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014A1 RID: 5281
			private static readonly IntPtr NativeFieldInfoPtr_CancellationToken;

			// Token: 0x040014A2 RID: 5282
			private static readonly IntPtr NativeFieldInfoPtr_LevelsToComplete;

			// Token: 0x040014A3 RID: 5283
			private static readonly IntPtr NativeFieldInfoPtr__token_5__2;

			// Token: 0x040014A4 RID: 5284
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040014A5 RID: 5285
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014A6 RID: 5286
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000161 RID: 353
		[ObfuscatedName("Newtonsoft.Json.JsonWriter+<AutoCompleteAsync>d__1")]
		public sealed class _AutoCompleteAsync_d__1 : ValueType
		{
			// Token: 0x06001B8A RID: 7050 RVA: 0x00083C98 File Offset: 0x00081E98
			// Note: this type is marked as 'beforefieldinit'.
			static _AutoCompleteAsync_d__1()
			{
				Il2CppClassPointerStore<JsonWriter._AutoCompleteAsync_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "<AutoCompleteAsync>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonWriter._AutoCompleteAsync_d__1>.NativeClassPtr);
				JsonWriter._AutoCompleteAsync_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._AutoCompleteAsync_d__1>.NativeClassPtr, "<>1__state");
				JsonWriter._AutoCompleteAsync_d__1.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._AutoCompleteAsync_d__1>.NativeClassPtr, "<>t__builder");
				JsonWriter._AutoCompleteAsync_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._AutoCompleteAsync_d__1>.NativeClassPtr, "<>4__this");
				JsonWriter._AutoCompleteAsync_d__1.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._AutoCompleteAsync_d__1>.NativeClassPtr, "cancellationToken");
				JsonWriter._AutoCompleteAsync_d__1.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._AutoCompleteAsync_d__1>.NativeClassPtr, "<>u__1");
				JsonWriter._AutoCompleteAsync_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter._AutoCompleteAsync_d__1>.NativeClassPtr, 100664507);
				JsonWriter._AutoCompleteAsync_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter._AutoCompleteAsync_d__1>.NativeClassPtr, 100664508);
			}

			// Token: 0x06001B8B RID: 7051 RVA: 0x00083D50 File Offset: 0x00081F50
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 737321, RefRangeEnd = 737322, XrefRangeStart = 737308, XrefRangeEnd = 737321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter._AutoCompleteAsync_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B8C RID: 7052 RVA: 0x00083D88 File Offset: 0x00081F88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737322, XrefRangeEnd = 737326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter._AutoCompleteAsync_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B8D RID: 7053 RVA: 0x0000D64E File Offset: 0x0000B84E
			public _AutoCompleteAsync_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B8E RID: 7054 RVA: 0x0000D657 File Offset: 0x0000B857
			public _AutoCompleteAsync_d__1()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWriter._AutoCompleteAsync_d__1>.NativeClassPtr))
			{
			}

			// Token: 0x170007BE RID: 1982
			// (get) Token: 0x06001B8F RID: 7055 RVA: 0x00083DD0 File Offset: 0x00081FD0
			// (set) Token: 0x06001B90 RID: 7056 RVA: 0x0000D669 File Offset: 0x0000B869
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._AutoCompleteAsync_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._AutoCompleteAsync_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007BF RID: 1983
			// (get) Token: 0x06001B91 RID: 7057 RVA: 0x00083DF8 File Offset: 0x00081FF8
			// (set) Token: 0x06001B92 RID: 7058 RVA: 0x0000D684 File Offset: 0x0000B884
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._AutoCompleteAsync_d__1.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._AutoCompleteAsync_d__1.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007C0 RID: 1984
			// (get) Token: 0x06001B93 RID: 7059 RVA: 0x00083E28 File Offset: 0x00082028
			// (set) Token: 0x06001B94 RID: 7060 RVA: 0x0000D6B2 File Offset: 0x0000B8B2
			public unsafe JsonWriter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._AutoCompleteAsync_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._AutoCompleteAsync_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007C1 RID: 1985
			// (get) Token: 0x06001B95 RID: 7061 RVA: 0x00083E58 File Offset: 0x00082058
			// (set) Token: 0x06001B96 RID: 7062 RVA: 0x0000D6D1 File Offset: 0x0000B8D1
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._AutoCompleteAsync_d__1.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._AutoCompleteAsync_d__1.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007C2 RID: 1986
			// (get) Token: 0x06001B97 RID: 7063 RVA: 0x00083E88 File Offset: 0x00082088
			// (set) Token: 0x06001B98 RID: 7064 RVA: 0x0000D6FF File Offset: 0x0000B8FF
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._AutoCompleteAsync_d__1.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._AutoCompleteAsync_d__1.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040014A7 RID: 5287
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014A8 RID: 5288
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040014A9 RID: 5289
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014AA RID: 5290
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040014AB RID: 5291
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040014AC RID: 5292
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014AD RID: 5293
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000162 RID: 354
		[ObfuscatedName("Newtonsoft.Json.JsonWriter+<InternalWriteStartAsync>d__20")]
		public sealed class _InternalWriteStartAsync_d__20 : ValueType
		{
			// Token: 0x06001B99 RID: 7065 RVA: 0x00083EB8 File Offset: 0x000820B8
			// Note: this type is marked as 'beforefieldinit'.
			static _InternalWriteStartAsync_d__20()
			{
				Il2CppClassPointerStore<JsonWriter._InternalWriteStartAsync_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "<InternalWriteStartAsync>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonWriter._InternalWriteStartAsync_d__20>.NativeClassPtr);
				JsonWriter._InternalWriteStartAsync_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._InternalWriteStartAsync_d__20>.NativeClassPtr, "<>1__state");
				JsonWriter._InternalWriteStartAsync_d__20.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._InternalWriteStartAsync_d__20>.NativeClassPtr, "<>t__builder");
				JsonWriter._InternalWriteStartAsync_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._InternalWriteStartAsync_d__20>.NativeClassPtr, "<>4__this");
				JsonWriter._InternalWriteStartAsync_d__20.NativeFieldInfoPtr_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._InternalWriteStartAsync_d__20>.NativeClassPtr, "token");
				JsonWriter._InternalWriteStartAsync_d__20.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._InternalWriteStartAsync_d__20>.NativeClassPtr, "cancellationToken");
				JsonWriter._InternalWriteStartAsync_d__20.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._InternalWriteStartAsync_d__20>.NativeClassPtr, "container");
				JsonWriter._InternalWriteStartAsync_d__20.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._InternalWriteStartAsync_d__20>.NativeClassPtr, "<>u__1");
				JsonWriter._InternalWriteStartAsync_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter._InternalWriteStartAsync_d__20>.NativeClassPtr, 100664509);
				JsonWriter._InternalWriteStartAsync_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter._InternalWriteStartAsync_d__20>.NativeClassPtr, 100664510);
			}

			// Token: 0x06001B9A RID: 7066 RVA: 0x00083F98 File Offset: 0x00082198
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737326, XrefRangeEnd = 737338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter._InternalWriteStartAsync_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B9B RID: 7067 RVA: 0x00083FD0 File Offset: 0x000821D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737338, XrefRangeEnd = 737342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter._InternalWriteStartAsync_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B9C RID: 7068 RVA: 0x0000D72D File Offset: 0x0000B92D
			public _InternalWriteStartAsync_d__20(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001B9D RID: 7069 RVA: 0x0000D736 File Offset: 0x0000B936
			public _InternalWriteStartAsync_d__20()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWriter._InternalWriteStartAsync_d__20>.NativeClassPtr))
			{
			}

			// Token: 0x170007C3 RID: 1987
			// (get) Token: 0x06001B9E RID: 7070 RVA: 0x00084018 File Offset: 0x00082218
			// (set) Token: 0x06001B9F RID: 7071 RVA: 0x0000D748 File Offset: 0x0000B948
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._InternalWriteStartAsync_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._InternalWriteStartAsync_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007C4 RID: 1988
			// (get) Token: 0x06001BA0 RID: 7072 RVA: 0x00084040 File Offset: 0x00082240
			// (set) Token: 0x06001BA1 RID: 7073 RVA: 0x0000D763 File Offset: 0x0000B963
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._InternalWriteStartAsync_d__20.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._InternalWriteStartAsync_d__20.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007C5 RID: 1989
			// (get) Token: 0x06001BA2 RID: 7074 RVA: 0x00084070 File Offset: 0x00082270
			// (set) Token: 0x06001BA3 RID: 7075 RVA: 0x0000D791 File Offset: 0x0000B991
			public unsafe JsonWriter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._InternalWriteStartAsync_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._InternalWriteStartAsync_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007C6 RID: 1990
			// (get) Token: 0x06001BA4 RID: 7076 RVA: 0x000840A0 File Offset: 0x000822A0
			// (set) Token: 0x06001BA5 RID: 7077 RVA: 0x0000D7B0 File Offset: 0x0000B9B0
			public unsafe JsonToken token
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._InternalWriteStartAsync_d__20.NativeFieldInfoPtr_token);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._InternalWriteStartAsync_d__20.NativeFieldInfoPtr_token)) = value;
				}
			}

			// Token: 0x170007C7 RID: 1991
			// (get) Token: 0x06001BA6 RID: 7078 RVA: 0x000840C8 File Offset: 0x000822C8
			// (set) Token: 0x06001BA7 RID: 7079 RVA: 0x0000D7CB File Offset: 0x0000B9CB
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._InternalWriteStartAsync_d__20.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._InternalWriteStartAsync_d__20.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007C8 RID: 1992
			// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x000840F8 File Offset: 0x000822F8
			// (set) Token: 0x06001BA9 RID: 7081 RVA: 0x0000D7F9 File Offset: 0x0000B9F9
			public unsafe JsonContainerType container
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._InternalWriteStartAsync_d__20.NativeFieldInfoPtr_container);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._InternalWriteStartAsync_d__20.NativeFieldInfoPtr_container)) = value;
				}
			}

			// Token: 0x170007C9 RID: 1993
			// (get) Token: 0x06001BAA RID: 7082 RVA: 0x00084120 File Offset: 0x00082320
			// (set) Token: 0x06001BAB RID: 7083 RVA: 0x0000D814 File Offset: 0x0000BA14
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._InternalWriteStartAsync_d__20.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._InternalWriteStartAsync_d__20.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040014AE RID: 5294
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014AF RID: 5295
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040014B0 RID: 5296
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014B1 RID: 5297
			private static readonly IntPtr NativeFieldInfoPtr_token;

			// Token: 0x040014B2 RID: 5298
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040014B3 RID: 5299
			private static readonly IntPtr NativeFieldInfoPtr_container;

			// Token: 0x040014B4 RID: 5300
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040014B5 RID: 5301
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014B6 RID: 5302
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000163 RID: 355
		[ObfuscatedName("Newtonsoft.Json.JsonWriter+<WriteConstructorDateAsync>d__32")]
		public sealed class _WriteConstructorDateAsync_d__32 : ValueType
		{
			// Token: 0x06001BAC RID: 7084 RVA: 0x00084150 File Offset: 0x00082350
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteConstructorDateAsync_d__32()
			{
				Il2CppClassPointerStore<JsonWriter._WriteConstructorDateAsync_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "<WriteConstructorDateAsync>d__32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonWriter._WriteConstructorDateAsync_d__32>.NativeClassPtr);
				JsonWriter._WriteConstructorDateAsync_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._WriteConstructorDateAsync_d__32>.NativeClassPtr, "<>1__state");
				JsonWriter._WriteConstructorDateAsync_d__32.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._WriteConstructorDateAsync_d__32>.NativeClassPtr, "<>t__builder");
				JsonWriter._WriteConstructorDateAsync_d__32.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._WriteConstructorDateAsync_d__32>.NativeClassPtr, "reader");
				JsonWriter._WriteConstructorDateAsync_d__32.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._WriteConstructorDateAsync_d__32>.NativeClassPtr, "cancellationToken");
				JsonWriter._WriteConstructorDateAsync_d__32.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._WriteConstructorDateAsync_d__32>.NativeClassPtr, "<>4__this");
				JsonWriter._WriteConstructorDateAsync_d__32.NativeFieldInfoPtr__date_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._WriteConstructorDateAsync_d__32>.NativeClassPtr, "<date>5__2");
				JsonWriter._WriteConstructorDateAsync_d__32.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._WriteConstructorDateAsync_d__32>.NativeClassPtr, "<>u__1");
				JsonWriter._WriteConstructorDateAsync_d__32.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._WriteConstructorDateAsync_d__32>.NativeClassPtr, "<>u__2");
				JsonWriter._WriteConstructorDateAsync_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter._WriteConstructorDateAsync_d__32>.NativeClassPtr, 100664511);
				JsonWriter._WriteConstructorDateAsync_d__32.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter._WriteConstructorDateAsync_d__32>.NativeClassPtr, 100664512);
			}

			// Token: 0x06001BAD RID: 7085 RVA: 0x00084244 File Offset: 0x00082444
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737342, XrefRangeEnd = 737382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter._WriteConstructorDateAsync_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BAE RID: 7086 RVA: 0x0008427C File Offset: 0x0008247C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737382, XrefRangeEnd = 737386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter._WriteConstructorDateAsync_d__32.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BAF RID: 7087 RVA: 0x0000D842 File Offset: 0x0000BA42
			public _WriteConstructorDateAsync_d__32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001BB0 RID: 7088 RVA: 0x0000D84B File Offset: 0x0000BA4B
			public _WriteConstructorDateAsync_d__32()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWriter._WriteConstructorDateAsync_d__32>.NativeClassPtr))
			{
			}

			// Token: 0x170007CA RID: 1994
			// (get) Token: 0x06001BB1 RID: 7089 RVA: 0x000842C4 File Offset: 0x000824C4
			// (set) Token: 0x06001BB2 RID: 7090 RVA: 0x0000D85D File Offset: 0x0000BA5D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteConstructorDateAsync_d__32.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteConstructorDateAsync_d__32.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007CB RID: 1995
			// (get) Token: 0x06001BB3 RID: 7091 RVA: 0x000842EC File Offset: 0x000824EC
			// (set) Token: 0x06001BB4 RID: 7092 RVA: 0x0000D878 File Offset: 0x0000BA78
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteConstructorDateAsync_d__32.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteConstructorDateAsync_d__32.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007CC RID: 1996
			// (get) Token: 0x06001BB5 RID: 7093 RVA: 0x0008431C File Offset: 0x0008251C
			// (set) Token: 0x06001BB6 RID: 7094 RVA: 0x0000D8A6 File Offset: 0x0000BAA6
			public unsafe JsonReader reader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteConstructorDateAsync_d__32.NativeFieldInfoPtr_reader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteConstructorDateAsync_d__32.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007CD RID: 1997
			// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x0008434C File Offset: 0x0008254C
			// (set) Token: 0x06001BB8 RID: 7096 RVA: 0x0000D8C5 File Offset: 0x0000BAC5
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteConstructorDateAsync_d__32.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteConstructorDateAsync_d__32.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007CE RID: 1998
			// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x0008437C File Offset: 0x0008257C
			// (set) Token: 0x06001BBA RID: 7098 RVA: 0x0000D8F3 File Offset: 0x0000BAF3
			public unsafe JsonWriter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteConstructorDateAsync_d__32.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteConstructorDateAsync_d__32.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007CF RID: 1999
			// (get) Token: 0x06001BBB RID: 7099 RVA: 0x000843AC File Offset: 0x000825AC
			// (set) Token: 0x06001BBC RID: 7100 RVA: 0x0000D912 File Offset: 0x0000BB12
			public unsafe DateTime _date_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteConstructorDateAsync_d__32.NativeFieldInfoPtr__date_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteConstructorDateAsync_d__32.NativeFieldInfoPtr__date_5__2)) = value;
				}
			}

			// Token: 0x170007D0 RID: 2000
			// (get) Token: 0x06001BBD RID: 7101 RVA: 0x000843D4 File Offset: 0x000825D4
			// (set) Token: 0x06001BBE RID: 7102 RVA: 0x0000D92D File Offset: 0x0000BB2D
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteConstructorDateAsync_d__32.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteConstructorDateAsync_d__32.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007D1 RID: 2001
			// (get) Token: 0x06001BBF RID: 7103 RVA: 0x00084404 File Offset: 0x00082604
			// (set) Token: 0x06001BC0 RID: 7104 RVA: 0x0000D95B File Offset: 0x0000BB5B
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteConstructorDateAsync_d__32.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteConstructorDateAsync_d__32.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040014B7 RID: 5303
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014B8 RID: 5304
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040014B9 RID: 5305
			private static readonly IntPtr NativeFieldInfoPtr_reader;

			// Token: 0x040014BA RID: 5306
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040014BB RID: 5307
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014BC RID: 5308
			private static readonly IntPtr NativeFieldInfoPtr__date_5__2;

			// Token: 0x040014BD RID: 5309
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040014BE RID: 5310
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040014BF RID: 5311
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014C0 RID: 5312
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000164 RID: 356
		[ObfuscatedName("Newtonsoft.Json.JsonWriter+<WriteTokenAsync>d__30")]
		public sealed class _WriteTokenAsync_d__30 : ValueType
		{
			// Token: 0x06001BC1 RID: 7105 RVA: 0x00084434 File Offset: 0x00082634
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteTokenAsync_d__30()
			{
				Il2CppClassPointerStore<JsonWriter._WriteTokenAsync_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "<WriteTokenAsync>d__30");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonWriter._WriteTokenAsync_d__30>.NativeClassPtr);
				JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._WriteTokenAsync_d__30>.NativeClassPtr, "<>1__state");
				JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._WriteTokenAsync_d__30>.NativeClassPtr, "<>t__builder");
				JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._WriteTokenAsync_d__30>.NativeClassPtr, "<>4__this");
				JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._WriteTokenAsync_d__30>.NativeClassPtr, "reader");
				JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr_writeDateConstructorAsDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._WriteTokenAsync_d__30>.NativeClassPtr, "writeDateConstructorAsDate");
				JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._WriteTokenAsync_d__30>.NativeClassPtr, "cancellationToken");
				JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr_writeComments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._WriteTokenAsync_d__30>.NativeClassPtr, "writeComments");
				JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr_writeChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._WriteTokenAsync_d__30>.NativeClassPtr, "writeChildren");
				JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr__initialDepth_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._WriteTokenAsync_d__30>.NativeClassPtr, "<initialDepth>5__2");
				JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._WriteTokenAsync_d__30>.NativeClassPtr, "<>u__1");
				JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._WriteTokenAsync_d__30>.NativeClassPtr, "<>u__2");
				JsonWriter._WriteTokenAsync_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter._WriteTokenAsync_d__30>.NativeClassPtr, 100664513);
				JsonWriter._WriteTokenAsync_d__30.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter._WriteTokenAsync_d__30>.NativeClassPtr, 100664514);
			}

			// Token: 0x06001BC2 RID: 7106 RVA: 0x00084564 File Offset: 0x00082764
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737386, XrefRangeEnd = 737438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter._WriteTokenAsync_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BC3 RID: 7107 RVA: 0x0008459C File Offset: 0x0008279C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737438, XrefRangeEnd = 737442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter._WriteTokenAsync_d__30.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BC4 RID: 7108 RVA: 0x0000D989 File Offset: 0x0000BB89
			public _WriteTokenAsync_d__30(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001BC5 RID: 7109 RVA: 0x0000D992 File Offset: 0x0000BB92
			public _WriteTokenAsync_d__30()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWriter._WriteTokenAsync_d__30>.NativeClassPtr))
			{
			}

			// Token: 0x170007D2 RID: 2002
			// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x000845E4 File Offset: 0x000827E4
			// (set) Token: 0x06001BC7 RID: 7111 RVA: 0x0000D9A4 File Offset: 0x0000BBA4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007D3 RID: 2003
			// (get) Token: 0x06001BC8 RID: 7112 RVA: 0x0008460C File Offset: 0x0008280C
			// (set) Token: 0x06001BC9 RID: 7113 RVA: 0x0000D9BF File Offset: 0x0000BBBF
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007D4 RID: 2004
			// (get) Token: 0x06001BCA RID: 7114 RVA: 0x0008463C File Offset: 0x0008283C
			// (set) Token: 0x06001BCB RID: 7115 RVA: 0x0000D9ED File Offset: 0x0000BBED
			public unsafe JsonWriter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007D5 RID: 2005
			// (get) Token: 0x06001BCC RID: 7116 RVA: 0x0008466C File Offset: 0x0008286C
			// (set) Token: 0x06001BCD RID: 7117 RVA: 0x0000DA0C File Offset: 0x0000BC0C
			public unsafe JsonReader reader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr_reader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007D6 RID: 2006
			// (get) Token: 0x06001BCE RID: 7118 RVA: 0x0008469C File Offset: 0x0008289C
			// (set) Token: 0x06001BCF RID: 7119 RVA: 0x0000DA2B File Offset: 0x0000BC2B
			public unsafe bool writeDateConstructorAsDate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr_writeDateConstructorAsDate);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr_writeDateConstructorAsDate)) = value;
				}
			}

			// Token: 0x170007D7 RID: 2007
			// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x000846C4 File Offset: 0x000828C4
			// (set) Token: 0x06001BD1 RID: 7121 RVA: 0x0000DA46 File Offset: 0x0000BC46
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007D8 RID: 2008
			// (get) Token: 0x06001BD2 RID: 7122 RVA: 0x000846F4 File Offset: 0x000828F4
			// (set) Token: 0x06001BD3 RID: 7123 RVA: 0x0000DA74 File Offset: 0x0000BC74
			public unsafe bool writeComments
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr_writeComments);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr_writeComments)) = value;
				}
			}

			// Token: 0x170007D9 RID: 2009
			// (get) Token: 0x06001BD4 RID: 7124 RVA: 0x0008471C File Offset: 0x0008291C
			// (set) Token: 0x06001BD5 RID: 7125 RVA: 0x0000DA8F File Offset: 0x0000BC8F
			public unsafe bool writeChildren
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr_writeChildren);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr_writeChildren)) = value;
				}
			}

			// Token: 0x170007DA RID: 2010
			// (get) Token: 0x06001BD6 RID: 7126 RVA: 0x00084744 File Offset: 0x00082944
			// (set) Token: 0x06001BD7 RID: 7127 RVA: 0x0000DAAA File Offset: 0x0000BCAA
			public unsafe int _initialDepth_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr__initialDepth_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr__initialDepth_5__2)) = value;
				}
			}

			// Token: 0x170007DB RID: 2011
			// (get) Token: 0x06001BD8 RID: 7128 RVA: 0x0008476C File Offset: 0x0008296C
			// (set) Token: 0x06001BD9 RID: 7129 RVA: 0x0000DAC5 File Offset: 0x0000BCC5
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007DC RID: 2012
			// (get) Token: 0x06001BDA RID: 7130 RVA: 0x0008479C File Offset: 0x0008299C
			// (set) Token: 0x06001BDB RID: 7131 RVA: 0x0000DAF3 File Offset: 0x0000BCF3
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenAsync_d__30.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040014C1 RID: 5313
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014C2 RID: 5314
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040014C3 RID: 5315
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014C4 RID: 5316
			private static readonly IntPtr NativeFieldInfoPtr_reader;

			// Token: 0x040014C5 RID: 5317
			private static readonly IntPtr NativeFieldInfoPtr_writeDateConstructorAsDate;

			// Token: 0x040014C6 RID: 5318
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040014C7 RID: 5319
			private static readonly IntPtr NativeFieldInfoPtr_writeComments;

			// Token: 0x040014C8 RID: 5320
			private static readonly IntPtr NativeFieldInfoPtr_writeChildren;

			// Token: 0x040014C9 RID: 5321
			private static readonly IntPtr NativeFieldInfoPtr__initialDepth_5__2;

			// Token: 0x040014CA RID: 5322
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040014CB RID: 5323
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040014CC RID: 5324
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014CD RID: 5325
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000165 RID: 357
		[ObfuscatedName("Newtonsoft.Json.JsonWriter+<WriteTokenSyncReadingAsync>d__31")]
		public sealed class _WriteTokenSyncReadingAsync_d__31 : ValueType
		{
			// Token: 0x06001BDC RID: 7132 RVA: 0x000847CC File Offset: 0x000829CC
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteTokenSyncReadingAsync_d__31()
			{
				Il2CppClassPointerStore<JsonWriter._WriteTokenSyncReadingAsync_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonWriter>.NativeClassPtr, "<WriteTokenSyncReadingAsync>d__31");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonWriter._WriteTokenSyncReadingAsync_d__31>.NativeClassPtr);
				JsonWriter._WriteTokenSyncReadingAsync_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._WriteTokenSyncReadingAsync_d__31>.NativeClassPtr, "<>1__state");
				JsonWriter._WriteTokenSyncReadingAsync_d__31.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._WriteTokenSyncReadingAsync_d__31>.NativeClassPtr, "<>t__builder");
				JsonWriter._WriteTokenSyncReadingAsync_d__31.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._WriteTokenSyncReadingAsync_d__31>.NativeClassPtr, "<>4__this");
				JsonWriter._WriteTokenSyncReadingAsync_d__31.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._WriteTokenSyncReadingAsync_d__31>.NativeClassPtr, "reader");
				JsonWriter._WriteTokenSyncReadingAsync_d__31.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._WriteTokenSyncReadingAsync_d__31>.NativeClassPtr, "cancellationToken");
				JsonWriter._WriteTokenSyncReadingAsync_d__31.NativeFieldInfoPtr__initialDepth_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._WriteTokenSyncReadingAsync_d__31>.NativeClassPtr, "<initialDepth>5__2");
				JsonWriter._WriteTokenSyncReadingAsync_d__31.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWriter._WriteTokenSyncReadingAsync_d__31>.NativeClassPtr, "<>u__1");
				JsonWriter._WriteTokenSyncReadingAsync_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter._WriteTokenSyncReadingAsync_d__31>.NativeClassPtr, 100664515);
				JsonWriter._WriteTokenSyncReadingAsync_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriter._WriteTokenSyncReadingAsync_d__31>.NativeClassPtr, 100664516);
			}

			// Token: 0x06001BDD RID: 7133 RVA: 0x000848AC File Offset: 0x00082AAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737442, XrefRangeEnd = 737467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter._WriteTokenSyncReadingAsync_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BDE RID: 7134 RVA: 0x000848E4 File Offset: 0x00082AE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 737467, XrefRangeEnd = 737475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriter._WriteTokenSyncReadingAsync_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BDF RID: 7135 RVA: 0x0000DB21 File Offset: 0x0000BD21
			public _WriteTokenSyncReadingAsync_d__31(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001BE0 RID: 7136 RVA: 0x0000DB2A File Offset: 0x0000BD2A
			public _WriteTokenSyncReadingAsync_d__31()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWriter._WriteTokenSyncReadingAsync_d__31>.NativeClassPtr))
			{
			}

			// Token: 0x170007DD RID: 2013
			// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x0008492C File Offset: 0x00082B2C
			// (set) Token: 0x06001BE2 RID: 7138 RVA: 0x0000DB3C File Offset: 0x0000BD3C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenSyncReadingAsync_d__31.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenSyncReadingAsync_d__31.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007DE RID: 2014
			// (get) Token: 0x06001BE3 RID: 7139 RVA: 0x00084954 File Offset: 0x00082B54
			// (set) Token: 0x06001BE4 RID: 7140 RVA: 0x0000DB57 File Offset: 0x0000BD57
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenSyncReadingAsync_d__31.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenSyncReadingAsync_d__31.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007DF RID: 2015
			// (get) Token: 0x06001BE5 RID: 7141 RVA: 0x00084984 File Offset: 0x00082B84
			// (set) Token: 0x06001BE6 RID: 7142 RVA: 0x0000DB85 File Offset: 0x0000BD85
			public unsafe JsonWriter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenSyncReadingAsync_d__31.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenSyncReadingAsync_d__31.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007E0 RID: 2016
			// (get) Token: 0x06001BE7 RID: 7143 RVA: 0x000849B4 File Offset: 0x00082BB4
			// (set) Token: 0x06001BE8 RID: 7144 RVA: 0x0000DBA4 File Offset: 0x0000BDA4
			public unsafe JsonReader reader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenSyncReadingAsync_d__31.NativeFieldInfoPtr_reader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenSyncReadingAsync_d__31.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007E1 RID: 2017
			// (get) Token: 0x06001BE9 RID: 7145 RVA: 0x000849E4 File Offset: 0x00082BE4
			// (set) Token: 0x06001BEA RID: 7146 RVA: 0x0000DBC3 File Offset: 0x0000BDC3
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenSyncReadingAsync_d__31.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenSyncReadingAsync_d__31.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007E2 RID: 2018
			// (get) Token: 0x06001BEB RID: 7147 RVA: 0x00084A14 File Offset: 0x00082C14
			// (set) Token: 0x06001BEC RID: 7148 RVA: 0x0000DBF1 File Offset: 0x0000BDF1
			public unsafe int _initialDepth_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenSyncReadingAsync_d__31.NativeFieldInfoPtr__initialDepth_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenSyncReadingAsync_d__31.NativeFieldInfoPtr__initialDepth_5__2)) = value;
				}
			}

			// Token: 0x170007E3 RID: 2019
			// (get) Token: 0x06001BED RID: 7149 RVA: 0x00084A3C File Offset: 0x00082C3C
			// (set) Token: 0x06001BEE RID: 7150 RVA: 0x0000DC0C File Offset: 0x0000BE0C
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenSyncReadingAsync_d__31.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWriter._WriteTokenSyncReadingAsync_d__31.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040014CE RID: 5326
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014CF RID: 5327
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040014D0 RID: 5328
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014D1 RID: 5329
			private static readonly IntPtr NativeFieldInfoPtr_reader;

			// Token: 0x040014D2 RID: 5330
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040014D3 RID: 5331
			private static readonly IntPtr NativeFieldInfoPtr__initialDepth_5__2;

			// Token: 0x040014D4 RID: 5332
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040014D5 RID: 5333
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014D6 RID: 5334
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}

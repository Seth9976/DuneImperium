using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Globalization;
using Il2CppSystem.IO;
using Il2CppSystem.Numerics;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x0200002D RID: 45
	public class JsonTextReader : JsonReader
	{
		// Token: 0x06000366 RID: 870 RVA: 0x0001F68C File Offset: 0x0001D88C
		// Note: this type is marked as 'beforefieldinit'.
		static JsonTextReader()
		{
			Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json", "JsonTextReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr);
			JsonTextReader.NativeFieldInfoPtr__safeAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "_safeAsync");
			JsonTextReader.NativeFieldInfoPtr_UnicodeReplacementChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "UnicodeReplacementChar");
			JsonTextReader.NativeFieldInfoPtr_MaximumJavascriptIntegerCharacterLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "MaximumJavascriptIntegerCharacterLength");
			JsonTextReader.NativeFieldInfoPtr_LargeBufferLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "LargeBufferLength");
			JsonTextReader.NativeFieldInfoPtr__reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "_reader");
			JsonTextReader.NativeFieldInfoPtr__chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "_chars");
			JsonTextReader.NativeFieldInfoPtr__charsUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "_charsUsed");
			JsonTextReader.NativeFieldInfoPtr__charPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "_charPos");
			JsonTextReader.NativeFieldInfoPtr__lineStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "_lineStartPos");
			JsonTextReader.NativeFieldInfoPtr__lineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "_lineNumber");
			JsonTextReader.NativeFieldInfoPtr__isEndOfFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "_isEndOfFile");
			JsonTextReader.NativeFieldInfoPtr__stringBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "_stringBuffer");
			JsonTextReader.NativeFieldInfoPtr__stringReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "_stringReference");
			JsonTextReader.NativeFieldInfoPtr__arrayPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "_arrayPool");
			JsonTextReader.NativeFieldInfoPtr__PropertyNameTable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<PropertyNameTable>k__BackingField");
			JsonTextReader.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663783);
			JsonTextReader.NativeMethodInfoPtr_DoReadAsync_Internal_Task_1_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663784);
			JsonTextReader.NativeMethodInfoPtr_DoReadAsync_Private_Task_1_Boolean_Task_1_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663785);
			JsonTextReader.NativeMethodInfoPtr_ParsePostValueAsync_Private_Task_1_Boolean_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663786);
			JsonTextReader.NativeMethodInfoPtr_ReadFromFinishedAsync_Private_Task_1_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663787);
			JsonTextReader.NativeMethodInfoPtr_ReadDataAsync_Private_Task_1_Int32_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663788);
			JsonTextReader.NativeMethodInfoPtr_ReadDataAsync_Private_Task_1_Int32_Boolean_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663789);
			JsonTextReader.NativeMethodInfoPtr_ParseValueAsync_Private_Task_1_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663790);
			JsonTextReader.NativeMethodInfoPtr_ReadStringIntoBufferAsync_Private_Task_Char_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663791);
			JsonTextReader.NativeMethodInfoPtr_ProcessCarriageReturnAsync_Private_Task_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663792);
			JsonTextReader.NativeMethodInfoPtr_ProcessCarriageReturnAsync_Private_Task_Task_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663793);
			JsonTextReader.NativeMethodInfoPtr_ParseUnicodeAsync_Private_Task_1_Char_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663794);
			JsonTextReader.NativeMethodInfoPtr_EnsureCharsAsync_Private_Task_1_Boolean_Int32_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663795);
			JsonTextReader.NativeMethodInfoPtr_ReadCharsAsync_Private_Task_1_Boolean_Int32_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663796);
			JsonTextReader.NativeMethodInfoPtr_ParseObjectAsync_Private_Task_1_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663797);
			JsonTextReader.NativeMethodInfoPtr_ParseCommentAsync_Private_Task_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663798);
			JsonTextReader.NativeMethodInfoPtr_EatWhitespaceAsync_Private_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663799);
			JsonTextReader.NativeMethodInfoPtr_ParseStringAsync_Private_Task_Char_ReadType_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663800);
			JsonTextReader.NativeMethodInfoPtr_MatchValueAsync_Private_Task_1_Boolean_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663801);
			JsonTextReader.NativeMethodInfoPtr_MatchValueWithTrailingSeparatorAsync_Private_Task_1_Boolean_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663802);
			JsonTextReader.NativeMethodInfoPtr_MatchAndSetAsync_Private_Task_String_JsonToken_Object_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663803);
			JsonTextReader.NativeMethodInfoPtr_ParseTrueAsync_Private_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663804);
			JsonTextReader.NativeMethodInfoPtr_ParseFalseAsync_Private_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663805);
			JsonTextReader.NativeMethodInfoPtr_ParseNullAsync_Private_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663806);
			JsonTextReader.NativeMethodInfoPtr_ParseConstructorAsync_Private_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663807);
			JsonTextReader.NativeMethodInfoPtr_ParseNumberNaNAsync_Private_Task_1_Object_ReadType_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663808);
			JsonTextReader.NativeMethodInfoPtr_ParseNumberPositiveInfinityAsync_Private_Task_1_Object_ReadType_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663809);
			JsonTextReader.NativeMethodInfoPtr_ParseNumberNegativeInfinityAsync_Private_Task_1_Object_ReadType_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663810);
			JsonTextReader.NativeMethodInfoPtr_ParseNumberAsync_Private_Task_ReadType_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663811);
			JsonTextReader.NativeMethodInfoPtr_ParseUndefinedAsync_Private_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663812);
			JsonTextReader.NativeMethodInfoPtr_ParsePropertyAsync_Private_Task_1_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663813);
			JsonTextReader.NativeMethodInfoPtr_ReadNumberIntoBufferAsync_Private_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663814);
			JsonTextReader.NativeMethodInfoPtr_ParseUnquotedPropertyAsync_Private_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663815);
			JsonTextReader.NativeMethodInfoPtr_ReadNullCharAsync_Private_Task_1_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663816);
			JsonTextReader.NativeMethodInfoPtr_HandleNullAsync_Private_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663817);
			JsonTextReader.NativeMethodInfoPtr_ReadFinishedAsync_Private_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663818);
			JsonTextReader.NativeMethodInfoPtr_ReadStringValueAsync_Private_Task_1_Object_ReadType_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663819);
			JsonTextReader.NativeMethodInfoPtr_ReadNumberValueAsync_Private_Task_1_Object_ReadType_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663820);
			JsonTextReader.NativeMethodInfoPtr_ReadAsBooleanAsync_Public_Virtual_Task_1_Nullable_1_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663821);
			JsonTextReader.NativeMethodInfoPtr_DoReadAsBooleanAsync_Internal_Task_1_Nullable_1_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663822);
			JsonTextReader.NativeMethodInfoPtr_ReadAsBytesAsync_Public_Virtual_Task_1_Il2CppStructArray_1_Byte_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663823);
			JsonTextReader.NativeMethodInfoPtr_DoReadAsBytesAsync_Internal_Task_1_Il2CppStructArray_1_Byte_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663824);
			JsonTextReader.NativeMethodInfoPtr_ReadIntoWrappedTypeObjectAsync_Private_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663825);
			JsonTextReader.NativeMethodInfoPtr_ReadAsDateTimeAsync_Public_Virtual_Task_1_Nullable_1_DateTime_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663826);
			JsonTextReader.NativeMethodInfoPtr_DoReadAsDateTimeAsync_Internal_Task_1_Nullable_1_DateTime_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663827);
			JsonTextReader.NativeMethodInfoPtr_ReadAsDateTimeOffsetAsync_Public_Virtual_Task_1_Nullable_1_DateTimeOffset_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663828);
			JsonTextReader.NativeMethodInfoPtr_DoReadAsDateTimeOffsetAsync_Internal_Task_1_Nullable_1_DateTimeOffset_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663829);
			JsonTextReader.NativeMethodInfoPtr_ReadAsDecimalAsync_Public_Virtual_Task_1_Nullable_1_Decimal_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663830);
			JsonTextReader.NativeMethodInfoPtr_DoReadAsDecimalAsync_Internal_Task_1_Nullable_1_Decimal_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663831);
			JsonTextReader.NativeMethodInfoPtr_ReadAsDoubleAsync_Public_Virtual_Task_1_Nullable_1_Double_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663832);
			JsonTextReader.NativeMethodInfoPtr_DoReadAsDoubleAsync_Internal_Task_1_Nullable_1_Double_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663833);
			JsonTextReader.NativeMethodInfoPtr_ReadAsInt32Async_Public_Virtual_Task_1_Nullable_1_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663834);
			JsonTextReader.NativeMethodInfoPtr_DoReadAsInt32Async_Internal_Task_1_Nullable_1_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663835);
			JsonTextReader.NativeMethodInfoPtr_ReadAsStringAsync_Public_Virtual_Task_1_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663836);
			JsonTextReader.NativeMethodInfoPtr_DoReadAsStringAsync_Internal_Task_1_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663837);
			JsonTextReader.NativeMethodInfoPtr__ctor_Public_Void_TextReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663838);
			JsonTextReader.NativeMethodInfoPtr_get_PropertyNameTable_Public_get_JsonNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663839);
			JsonTextReader.NativeMethodInfoPtr_set_PropertyNameTable_Public_set_Void_JsonNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663840);
			JsonTextReader.NativeMethodInfoPtr_get_ArrayPool_Public_get_IArrayPool_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663841);
			JsonTextReader.NativeMethodInfoPtr_set_ArrayPool_Public_set_Void_IArrayPool_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663842);
			JsonTextReader.NativeMethodInfoPtr_EnsureBufferNotEmpty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663843);
			JsonTextReader.NativeMethodInfoPtr_SetNewLine_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663844);
			JsonTextReader.NativeMethodInfoPtr_OnNewLine_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663845);
			JsonTextReader.NativeMethodInfoPtr_ParseString_Private_Void_Char_ReadType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663846);
			JsonTextReader.NativeMethodInfoPtr_ParseReadString_Private_Void_Char_ReadType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663847);
			JsonTextReader.NativeMethodInfoPtr_BlockCopyChars_Private_Static_Void_Il2CppStructArray_1_Char_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663848);
			JsonTextReader.NativeMethodInfoPtr_ShiftBufferIfNeeded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663849);
			JsonTextReader.NativeMethodInfoPtr_ReadData_Private_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663850);
			JsonTextReader.NativeMethodInfoPtr_PrepareBufferForReadData_Private_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663851);
			JsonTextReader.NativeMethodInfoPtr_ReadData_Private_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663852);
			JsonTextReader.NativeMethodInfoPtr_EnsureChars_Private_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663853);
			JsonTextReader.NativeMethodInfoPtr_ReadChars_Private_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663854);
			JsonTextReader.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663855);
			JsonTextReader.NativeMethodInfoPtr_ReadAsInt32_Public_Virtual_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663856);
			JsonTextReader.NativeMethodInfoPtr_ReadAsDateTime_Public_Virtual_Nullable_1_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663857);
			JsonTextReader.NativeMethodInfoPtr_ReadAsString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663858);
			JsonTextReader.NativeMethodInfoPtr_ReadAsBytes_Public_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663859);
			JsonTextReader.NativeMethodInfoPtr_ReadStringValue_Private_Object_ReadType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663860);
			JsonTextReader.NativeMethodInfoPtr_FinishReadQuotedStringValue_Private_Object_ReadType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663861);
			JsonTextReader.NativeMethodInfoPtr_CreateUnexpectedCharacterException_Private_JsonReaderException_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663862);
			JsonTextReader.NativeMethodInfoPtr_ReadAsBoolean_Public_Virtual_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663863);
			JsonTextReader.NativeMethodInfoPtr_ProcessValueComma_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663864);
			JsonTextReader.NativeMethodInfoPtr_ReadNumberValue_Private_Object_ReadType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663865);
			JsonTextReader.NativeMethodInfoPtr_FinishReadQuotedNumber_Private_Object_ReadType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663866);
			JsonTextReader.NativeMethodInfoPtr_ReadAsDateTimeOffset_Public_Virtual_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663867);
			JsonTextReader.NativeMethodInfoPtr_ReadAsDecimal_Public_Virtual_Nullable_1_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663868);
			JsonTextReader.NativeMethodInfoPtr_ReadAsDouble_Public_Virtual_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663869);
			JsonTextReader.NativeMethodInfoPtr_HandleNull_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663870);
			JsonTextReader.NativeMethodInfoPtr_ReadFinished_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663871);
			JsonTextReader.NativeMethodInfoPtr_ReadNullChar_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663872);
			JsonTextReader.NativeMethodInfoPtr_EnsureBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663873);
			JsonTextReader.NativeMethodInfoPtr_ReadStringIntoBuffer_Private_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663874);
			JsonTextReader.NativeMethodInfoPtr_FinishReadStringIntoBuffer_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663875);
			JsonTextReader.NativeMethodInfoPtr_WriteCharToBuffer_Private_Void_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663876);
			JsonTextReader.NativeMethodInfoPtr_ConvertUnicode_Private_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663877);
			JsonTextReader.NativeMethodInfoPtr_ParseUnicode_Private_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663878);
			JsonTextReader.NativeMethodInfoPtr_ReadNumberIntoBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663879);
			JsonTextReader.NativeMethodInfoPtr_ReadNumberCharIntoBuffer_Private_Boolean_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663880);
			JsonTextReader.NativeMethodInfoPtr_ClearRecentString_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663881);
			JsonTextReader.NativeMethodInfoPtr_ParsePostValue_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663882);
			JsonTextReader.NativeMethodInfoPtr_ParseObject_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663883);
			JsonTextReader.NativeMethodInfoPtr_ParseProperty_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663884);
			JsonTextReader.NativeMethodInfoPtr_ValidIdentifierChar_Private_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663885);
			JsonTextReader.NativeMethodInfoPtr_ParseUnquotedProperty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663886);
			JsonTextReader.NativeMethodInfoPtr_ReadUnquotedPropertyReportIfDone_Private_Boolean_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663887);
			JsonTextReader.NativeMethodInfoPtr_ParseValue_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663888);
			JsonTextReader.NativeMethodInfoPtr_ProcessLineFeed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663889);
			JsonTextReader.NativeMethodInfoPtr_ProcessCarriageReturn_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663890);
			JsonTextReader.NativeMethodInfoPtr_EatWhitespace_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663891);
			JsonTextReader.NativeMethodInfoPtr_ParseConstructor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663892);
			JsonTextReader.NativeMethodInfoPtr_ParseNumber_Private_Void_ReadType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663893);
			JsonTextReader.NativeMethodInfoPtr_ParseReadNumber_Private_Void_ReadType_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663894);
			JsonTextReader.NativeMethodInfoPtr_ThrowReaderError_Private_JsonReaderException_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663895);
			JsonTextReader.NativeMethodInfoPtr_BigIntegerParse_Private_Static_Object_String_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663896);
			JsonTextReader.NativeMethodInfoPtr_ParseComment_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663897);
			JsonTextReader.NativeMethodInfoPtr_EndComment_Private_Void_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663898);
			JsonTextReader.NativeMethodInfoPtr_MatchValue_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663899);
			JsonTextReader.NativeMethodInfoPtr_MatchValue_Private_Boolean_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663900);
			JsonTextReader.NativeMethodInfoPtr_MatchValueWithTrailingSeparator_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663901);
			JsonTextReader.NativeMethodInfoPtr_IsSeparator_Private_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663902);
			JsonTextReader.NativeMethodInfoPtr_ParseTrue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663903);
			JsonTextReader.NativeMethodInfoPtr_ParseNull_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663904);
			JsonTextReader.NativeMethodInfoPtr_ParseUndefined_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663905);
			JsonTextReader.NativeMethodInfoPtr_ParseFalse_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663906);
			JsonTextReader.NativeMethodInfoPtr_ParseNumberNegativeInfinity_Private_Object_ReadType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663907);
			JsonTextReader.NativeMethodInfoPtr_ParseNumberNegativeInfinity_Private_Object_ReadType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663908);
			JsonTextReader.NativeMethodInfoPtr_ParseNumberPositiveInfinity_Private_Object_ReadType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663909);
			JsonTextReader.NativeMethodInfoPtr_ParseNumberPositiveInfinity_Private_Object_ReadType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663910);
			JsonTextReader.NativeMethodInfoPtr_ParseNumberNaN_Private_Object_ReadType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663911);
			JsonTextReader.NativeMethodInfoPtr_ParseNumberNaN_Private_Object_ReadType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663912);
			JsonTextReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663913);
			JsonTextReader.NativeMethodInfoPtr_HasLineInfo_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663914);
			JsonTextReader.NativeMethodInfoPtr_get_LineNumber_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663915);
			JsonTextReader.NativeMethodInfoPtr_get_LinePosition_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, 100663916);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00020260 File Offset: 0x0001E460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732337, XrefRangeEnd = 732347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<bool> ReadAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonTextReader.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Boolean_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x000202C0 File Offset: 0x0001E4C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 732374, RefRangeEnd = 732376, XrefRangeStart = 732347, XrefRangeEnd = 732374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> DoReadAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_DoReadAsync_Internal_Task_1_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00020318 File Offset: 0x0001E518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732376, XrefRangeEnd = 732392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> DoReadAsync(Task<bool> task, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_DoReadAsync_Private_Task_1_Boolean_Task_1_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00020380 File Offset: 0x0001E580
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 732407, RefRangeEnd = 732411, XrefRangeStart = 732392, XrefRangeEnd = 732407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> ParsePostValueAsync(bool ignoreComments, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ignoreComments;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParsePostValueAsync_Private_Task_1_Boolean_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x000203E4 File Offset: 0x0001E5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732411, XrefRangeEnd = 732426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> ReadFromFinishedAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ReadFromFinishedAsync_Private_Task_1_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0002043C File Offset: 0x0001E63C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 732441, RefRangeEnd = 732448, XrefRangeStart = 732426, XrefRangeEnd = 732441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<int> ReadDataAsync(bool append, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref append;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ReadDataAsync_Private_Task_1_Int32_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x000204A0 File Offset: 0x0001E6A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 732463, RefRangeEnd = 732464, XrefRangeStart = 732448, XrefRangeEnd = 732463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<int> ReadDataAsync(bool append, int charsRequired, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref append;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charsRequired;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ReadDataAsync_Private_Task_1_Int32_Boolean_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00020514 File Offset: 0x0001E714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732464, XrefRangeEnd = 732479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> ParseValueAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseValueAsync_Private_Task_1_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0002056C File Offset: 0x0001E76C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 732490, RefRangeEnd = 732492, XrefRangeStart = 732479, XrefRangeEnd = 732490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ReadStringIntoBufferAsync(char quote, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref quote;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ReadStringIntoBufferAsync_Private_Task_Char_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x000205D0 File Offset: 0x0001E7D0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 732532, RefRangeEnd = 732542, XrefRangeStart = 732492, XrefRangeEnd = 732532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ProcessCarriageReturnAsync(bool append, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref append;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ProcessCarriageReturnAsync_Private_Task_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00020634 File Offset: 0x0001E834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732542, XrefRangeEnd = 732553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ProcessCarriageReturnAsync(Task<bool> task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ProcessCarriageReturnAsync_Private_Task_Task_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00020684 File Offset: 0x0001E884
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 732568, RefRangeEnd = 732570, XrefRangeStart = 732553, XrefRangeEnd = 732568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<char> ParseUnicodeAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseUnicodeAsync_Private_Task_1_Char_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<char>>(intPtr3) : null;
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x000206DC File Offset: 0x0001E8DC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 732594, RefRangeEnd = 732608, XrefRangeStart = 732570, XrefRangeEnd = 732594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> EnsureCharsAsync(int relativePosition, bool append, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref relativePosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref append;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_EnsureCharsAsync_Private_Task_1_Boolean_Int32_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00020750 File Offset: 0x0001E950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732608, XrefRangeEnd = 732623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> ReadCharsAsync(int relativePosition, bool append, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref relativePosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref append;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ReadCharsAsync_Private_Task_1_Boolean_Int32_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x000207C4 File Offset: 0x0001E9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732623, XrefRangeEnd = 732638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> ParseObjectAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseObjectAsync_Private_Task_1_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0002081C File Offset: 0x0001EA1C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 732649, RefRangeEnd = 732658, XrefRangeStart = 732638, XrefRangeEnd = 732649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ParseCommentAsync(bool setToken, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref setToken;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseCommentAsync_Private_Task_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00020880 File Offset: 0x0001EA80
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 732669, RefRangeEnd = 732674, XrefRangeStart = 732658, XrefRangeEnd = 732669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task EatWhitespaceAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_EatWhitespaceAsync_Private_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06000378 RID: 888 RVA: 0x000208D8 File Offset: 0x0001EAD8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 732685, RefRangeEnd = 732690, XrefRangeStart = 732674, XrefRangeEnd = 732685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ParseStringAsync(char quote, ReadType readType, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref quote;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseStringAsync_Private_Task_Char_ReadType_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0002094C File Offset: 0x0001EB4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 732706, RefRangeEnd = 732707, XrefRangeStart = 732690, XrefRangeEnd = 732706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> MatchValueAsync(string value, CancellationToken cancellationToken)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_MatchValueAsync_Private_Task_1_Boolean_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x000209B4 File Offset: 0x0001EBB4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 732723, RefRangeEnd = 732730, XrefRangeStart = 732707, XrefRangeEnd = 732723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> MatchValueWithTrailingSeparatorAsync(string value, CancellationToken cancellationToken)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_MatchValueWithTrailingSeparatorAsync_Private_Task_1_Boolean_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00020A1C File Offset: 0x0001EC1C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 732743, RefRangeEnd = 732747, XrefRangeStart = 732730, XrefRangeEnd = 732743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task MatchAndSetAsync(string value, JsonToken newToken, Object tokenValue, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newToken;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tokenValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_MatchAndSetAsync_Private_Task_String_JsonToken_Object_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00020AA4 File Offset: 0x0001ECA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 732755, RefRangeEnd = 732756, XrefRangeStart = 732747, XrefRangeEnd = 732755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ParseTrueAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseTrueAsync_Private_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00020AFC File Offset: 0x0001ECFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 732764, RefRangeEnd = 732765, XrefRangeStart = 732756, XrefRangeEnd = 732764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ParseFalseAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseFalseAsync_Private_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00020B54 File Offset: 0x0001ED54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 732770, RefRangeEnd = 732772, XrefRangeStart = 732765, XrefRangeEnd = 732770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ParseNullAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseNullAsync_Private_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00020BAC File Offset: 0x0001EDAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 732783, RefRangeEnd = 732784, XrefRangeStart = 732772, XrefRangeEnd = 732783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ParseConstructorAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseConstructorAsync_Private_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00020C04 File Offset: 0x0001EE04
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 732799, RefRangeEnd = 732802, XrefRangeStart = 732784, XrefRangeEnd = 732799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Object> ParseNumberNaNAsync(ReadType readType, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseNumberNaNAsync_Private_Task_1_Object_ReadType_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Object>>(intPtr3) : null;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00020C68 File Offset: 0x0001EE68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 732817, RefRangeEnd = 732820, XrefRangeStart = 732802, XrefRangeEnd = 732817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Object> ParseNumberPositiveInfinityAsync(ReadType readType, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseNumberPositiveInfinityAsync_Private_Task_1_Object_ReadType_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Object>>(intPtr3) : null;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00020CCC File Offset: 0x0001EECC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 732835, RefRangeEnd = 732837, XrefRangeStart = 732820, XrefRangeEnd = 732835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Object> ParseNumberNegativeInfinityAsync(ReadType readType, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseNumberNegativeInfinityAsync_Private_Task_1_Object_ReadType_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Object>>(intPtr3) : null;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00020D30 File Offset: 0x0001EF30
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 732848, RefRangeEnd = 732855, XrefRangeStart = 732837, XrefRangeEnd = 732848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ParseNumberAsync(ReadType readType, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseNumberAsync_Private_Task_ReadType_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00020D94 File Offset: 0x0001EF94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 732860, RefRangeEnd = 732861, XrefRangeStart = 732855, XrefRangeEnd = 732860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ParseUndefinedAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseUndefinedAsync_Private_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00020DEC File Offset: 0x0001EFEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 732876, RefRangeEnd = 732877, XrefRangeStart = 732861, XrefRangeEnd = 732876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> ParsePropertyAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParsePropertyAsync_Private_Task_1_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00020E44 File Offset: 0x0001F044
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 732888, RefRangeEnd = 732889, XrefRangeStart = 732877, XrefRangeEnd = 732888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ReadNumberIntoBufferAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ReadNumberIntoBufferAsync_Private_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00020E9C File Offset: 0x0001F09C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 732900, RefRangeEnd = 732901, XrefRangeStart = 732889, XrefRangeEnd = 732900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ParseUnquotedPropertyAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseUnquotedPropertyAsync_Private_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00020EF4 File Offset: 0x0001F0F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 732916, RefRangeEnd = 732920, XrefRangeStart = 732901, XrefRangeEnd = 732916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> ReadNullCharAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ReadNullCharAsync_Private_Task_1_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00020F4C File Offset: 0x0001F14C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 732931, RefRangeEnd = 732935, XrefRangeStart = 732920, XrefRangeEnd = 732931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task HandleNullAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_HandleNullAsync_Private_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00020FA4 File Offset: 0x0001F1A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 732946, RefRangeEnd = 732950, XrefRangeStart = 732935, XrefRangeEnd = 732946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ReadFinishedAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ReadFinishedAsync_Private_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00020FFC File Offset: 0x0001F1FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 732965, RefRangeEnd = 732968, XrefRangeStart = 732950, XrefRangeEnd = 732965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Object> ReadStringValueAsync(ReadType readType, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ReadStringValueAsync_Private_Task_1_Object_ReadType_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Object>>(intPtr3) : null;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00021060 File Offset: 0x0001F260
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 732983, RefRangeEnd = 732986, XrefRangeStart = 732968, XrefRangeEnd = 732983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Object> ReadNumberValueAsync(ReadType readType, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ReadNumberValueAsync_Private_Task_1_Object_ReadType_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Object>>(intPtr3) : null;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x000210C4 File Offset: 0x0001F2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732986, XrefRangeEnd = 733001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<Nullable<bool>> ReadAsBooleanAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonTextReader.NativeMethodInfoPtr_ReadAsBooleanAsync_Public_Virtual_Task_1_Nullable_1_Boolean_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<bool>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00021124 File Offset: 0x0001F324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733001, XrefRangeEnd = 733016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Nullable<bool>> DoReadAsBooleanAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_DoReadAsBooleanAsync_Internal_Task_1_Nullable_1_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<bool>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0002117C File Offset: 0x0001F37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733016, XrefRangeEnd = 733031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<Il2CppStructArray<byte>> ReadAsBytesAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonTextReader.NativeMethodInfoPtr_ReadAsBytesAsync_Public_Virtual_Task_1_Il2CppStructArray_1_Byte_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Il2CppStructArray<byte>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000390 RID: 912 RVA: 0x000211DC File Offset: 0x0001F3DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733031, XrefRangeEnd = 733046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Il2CppStructArray<byte>> DoReadAsBytesAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_DoReadAsBytesAsync_Internal_Task_1_Il2CppStructArray_1_Byte_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Il2CppStructArray<byte>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00021234 File Offset: 0x0001F434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 733057, RefRangeEnd = 733058, XrefRangeStart = 733046, XrefRangeEnd = 733057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ReadIntoWrappedTypeObjectAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ReadIntoWrappedTypeObjectAsync_Private_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0002128C File Offset: 0x0001F48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733058, XrefRangeEnd = 733073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<Nullable<DateTime>> ReadAsDateTimeAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonTextReader.NativeMethodInfoPtr_ReadAsDateTimeAsync_Public_Virtual_Task_1_Nullable_1_DateTime_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<DateTime>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000393 RID: 915 RVA: 0x000212EC File Offset: 0x0001F4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733073, XrefRangeEnd = 733088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Nullable<DateTime>> DoReadAsDateTimeAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_DoReadAsDateTimeAsync_Internal_Task_1_Nullable_1_DateTime_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<DateTime>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00021344 File Offset: 0x0001F544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733088, XrefRangeEnd = 733103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<Nullable<DateTimeOffset>> ReadAsDateTimeOffsetAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonTextReader.NativeMethodInfoPtr_ReadAsDateTimeOffsetAsync_Public_Virtual_Task_1_Nullable_1_DateTimeOffset_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<DateTimeOffset>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x000213A4 File Offset: 0x0001F5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733103, XrefRangeEnd = 733118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Nullable<DateTimeOffset>> DoReadAsDateTimeOffsetAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_DoReadAsDateTimeOffsetAsync_Internal_Task_1_Nullable_1_DateTimeOffset_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<DateTimeOffset>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000396 RID: 918 RVA: 0x000213FC File Offset: 0x0001F5FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733118, XrefRangeEnd = 733133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<Nullable<Decimal>> ReadAsDecimalAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonTextReader.NativeMethodInfoPtr_ReadAsDecimalAsync_Public_Virtual_Task_1_Nullable_1_Decimal_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<Decimal>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0002145C File Offset: 0x0001F65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733133, XrefRangeEnd = 733148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Nullable<Decimal>> DoReadAsDecimalAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_DoReadAsDecimalAsync_Internal_Task_1_Nullable_1_Decimal_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<Decimal>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000398 RID: 920 RVA: 0x000214B4 File Offset: 0x0001F6B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733148, XrefRangeEnd = 733163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<Nullable<double>> ReadAsDoubleAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonTextReader.NativeMethodInfoPtr_ReadAsDoubleAsync_Public_Virtual_Task_1_Nullable_1_Double_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<double>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00021514 File Offset: 0x0001F714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733163, XrefRangeEnd = 733178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Nullable<double>> DoReadAsDoubleAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_DoReadAsDoubleAsync_Internal_Task_1_Nullable_1_Double_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<double>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0002156C File Offset: 0x0001F76C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733178, XrefRangeEnd = 733193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<Nullable<int>> ReadAsInt32Async(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonTextReader.NativeMethodInfoPtr_ReadAsInt32Async_Public_Virtual_Task_1_Nullable_1_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<int>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600039B RID: 923 RVA: 0x000215CC File Offset: 0x0001F7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733193, XrefRangeEnd = 733208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Nullable<int>> DoReadAsInt32Async(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_DoReadAsInt32Async_Internal_Task_1_Nullable_1_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<int>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00021624 File Offset: 0x0001F824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733208, XrefRangeEnd = 733223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<string> ReadAsStringAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonTextReader.NativeMethodInfoPtr_ReadAsStringAsync_Public_Virtual_Task_1_String_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<string>>(intPtr3) : null;
			}
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00021684 File Offset: 0x0001F884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733223, XrefRangeEnd = 733238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<string> DoReadAsStringAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_DoReadAsStringAsync_Internal_Task_1_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<string>>(intPtr3) : null;
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x000216DC File Offset: 0x0001F8DC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 733251, RefRangeEnd = 733259, XrefRangeStart = 733238, XrefRangeEnd = 733251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonTextReader(TextReader reader)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr__ctor_Public_Void_TextReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600039F RID: 927 RVA: 0x00021728 File Offset: 0x0001F928
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x00021768 File Offset: 0x0001F968
		public unsafe JsonNameTable PropertyNameTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_get_PropertyNameTable_Public_get_JsonNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonNameTable>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_set_PropertyNameTable_Public_set_Void_JsonNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x000217AC File Offset: 0x0001F9AC
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x000217EC File Offset: 0x0001F9EC
		public unsafe IArrayPool<char> ArrayPool
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_get_ArrayPool_Public_get_IArrayPool_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IArrayPool<char>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733259, XrefRangeEnd = 733266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_set_ArrayPool_Public_set_Void_IArrayPool_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00021830 File Offset: 0x0001FA30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 733269, RefRangeEnd = 733272, XrefRangeStart = 733266, XrefRangeEnd = 733269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureBufferNotEmpty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_EnsureBufferNotEmpty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00021864 File Offset: 0x0001FA64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 733272, RefRangeEnd = 733273, XrefRangeStart = 733272, XrefRangeEnd = 733272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNewLine(bool hasNextChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hasNextChar;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_SetNewLine_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x000218A4 File Offset: 0x0001FAA4
		[CallerCount(0)]
		public unsafe void OnNewLine(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_OnNewLine_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x000218E4 File Offset: 0x0001FAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733273, XrefRangeEnd = 733276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseString(char quote, ReadType readType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref quote;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseString_Private_Void_Char_ReadType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00021930 File Offset: 0x0001FB30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 733319, RefRangeEnd = 733322, XrefRangeStart = 733276, XrefRangeEnd = 733319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseReadString(char quote, ReadType readType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref quote;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseReadString_Private_Void_Char_ReadType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0002197C File Offset: 0x0001FB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlockCopyChars(Il2CppStructArray<char> src, int srcOffset, Il2CppStructArray<char> dst, int dstOffset, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstOffset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_BlockCopyChars_Private_Static_Void_Il2CppStructArray_1_Char_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x000219F0 File Offset: 0x0001FBF0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 733323, RefRangeEnd = 733332, XrefRangeStart = 733322, XrefRangeEnd = 733323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShiftBufferIfNeeded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ShiftBufferIfNeeded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00021A24 File Offset: 0x0001FC24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733332, XrefRangeEnd = 733333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadData(bool append)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref append;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ReadData_Private_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00021A70 File Offset: 0x0001FC70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 733340, RefRangeEnd = 733343, XrefRangeStart = 733333, XrefRangeEnd = 733340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepareBufferForReadData(bool append, int charsRequired)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref append;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charsRequired;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_PrepareBufferForReadData_Private_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00021ABC File Offset: 0x0001FCBC
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 733344, RefRangeEnd = 733357, XrefRangeStart = 733343, XrefRangeEnd = 733344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadData(bool append, int charsRequired)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref append;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charsRequired;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ReadData_Private_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00021B14 File Offset: 0x0001FD14
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 733357, RefRangeEnd = 733370, XrefRangeStart = 733357, XrefRangeEnd = 733357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EnsureChars(int relativePosition, bool append)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref relativePosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref append;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_EnsureChars_Private_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00021B6C File Offset: 0x0001FD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733370, XrefRangeEnd = 733373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadChars(int relativePosition, bool append)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref relativePosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref append;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ReadChars_Private_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00021BC4 File Offset: 0x0001FDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733373, XrefRangeEnd = 733376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonTextReader.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00021C0C File Offset: 0x0001FE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733376, XrefRangeEnd = 733380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<int> ReadAsInt32()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonTextReader.NativeMethodInfoPtr_ReadAsInt32_Public_Virtual_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<int>(intPtr);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00021C50 File Offset: 0x0001FE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733380, XrefRangeEnd = 733384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<DateTime> ReadAsDateTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonTextReader.NativeMethodInfoPtr_ReadAsDateTime_Public_Virtual_Nullable_1_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<DateTime>(intPtr);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00021C94 File Offset: 0x0001FE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733384, XrefRangeEnd = 733387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ReadAsString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonTextReader.NativeMethodInfoPtr_ReadAsString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00021CD8 File Offset: 0x0001FED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733387, XrefRangeEnd = 733417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> ReadAsBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonTextReader.NativeMethodInfoPtr_ReadAsBytes_Public_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00021D24 File Offset: 0x0001FF24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 733436, RefRangeEnd = 733439, XrefRangeStart = 733417, XrefRangeEnd = 733436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadStringValue(ReadType readType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ReadStringValue_Private_Object_ReadType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00021D70 File Offset: 0x0001FF70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 733448, RefRangeEnd = 733449, XrefRangeStart = 733439, XrefRangeEnd = 733448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object FinishReadQuotedStringValue(ReadType readType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_FinishReadQuotedStringValue_Private_Object_ReadType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00021DBC File Offset: 0x0001FFBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 733460, RefRangeEnd = 733462, XrefRangeStart = 733449, XrefRangeEnd = 733460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonReaderException CreateUnexpectedCharacterException(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_CreateUnexpectedCharacterException_Private_JsonReaderException_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonReaderException>(intPtr3) : null;
			}
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00021E08 File Offset: 0x00020008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733462, XrefRangeEnd = 733492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<bool> ReadAsBoolean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonTextReader.NativeMethodInfoPtr_ReadAsBoolean_Public_Virtual_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<bool>(intPtr);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00021E4C File Offset: 0x0002004C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 733498, RefRangeEnd = 733502, XrefRangeStart = 733492, XrefRangeEnd = 733498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessValueComma()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ProcessValueComma_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00021E80 File Offset: 0x00020080
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 733515, RefRangeEnd = 733518, XrefRangeStart = 733502, XrefRangeEnd = 733515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadNumberValue(ReadType readType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ReadNumberValue_Private_Object_ReadType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00021ECC File Offset: 0x000200CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 733525, RefRangeEnd = 733526, XrefRangeStart = 733518, XrefRangeEnd = 733525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object FinishReadQuotedNumber(ReadType readType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_FinishReadQuotedNumber_Private_Object_ReadType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00021F18 File Offset: 0x00020118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733526, XrefRangeEnd = 733530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<DateTimeOffset> ReadAsDateTimeOffset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonTextReader.NativeMethodInfoPtr_ReadAsDateTimeOffset_Public_Virtual_Nullable_1_DateTimeOffset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<DateTimeOffset>(intPtr);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00021F5C File Offset: 0x0002015C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733530, XrefRangeEnd = 733534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<Decimal> ReadAsDecimal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonTextReader.NativeMethodInfoPtr_ReadAsDecimal_Public_Virtual_Nullable_1_Decimal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<Decimal>(intPtr);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00021FA0 File Offset: 0x000201A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733534, XrefRangeEnd = 733538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<double> ReadAsDouble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonTextReader.NativeMethodInfoPtr_ReadAsDouble_Public_Virtual_Nullable_1_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<double>(intPtr);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00021FE4 File Offset: 0x000201E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733538, XrefRangeEnd = 733552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_HandleNull_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00022018 File Offset: 0x00020218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733552, XrefRangeEnd = 733557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadFinished()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ReadFinished_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0002204C File Offset: 0x0002024C
		[CallerCount(0)]
		public unsafe bool ReadNullChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ReadNullChar_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00022088 File Offset: 0x00020288
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 733559, RefRangeEnd = 733563, XrefRangeStart = 733557, XrefRangeEnd = 733559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_EnsureBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x000220BC File Offset: 0x000202BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 733601, RefRangeEnd = 733604, XrefRangeStart = 733563, XrefRangeEnd = 733601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadStringIntoBuffer(char quote)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref quote;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ReadStringIntoBuffer_Private_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x000220FC File Offset: 0x000202FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 733611, RefRangeEnd = 733612, XrefRangeStart = 733604, XrefRangeEnd = 733611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lastWritePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_FinishReadStringIntoBuffer_Private_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00022158 File Offset: 0x00020358
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 733614, RefRangeEnd = 733616, XrefRangeStart = 733612, XrefRangeEnd = 733614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref writeChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lastWritePosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeToPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_WriteCharToBuffer_Private_Void_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x000221B4 File Offset: 0x000203B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 733624, RefRangeEnd = 733625, XrefRangeStart = 733616, XrefRangeEnd = 733624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char ConvertUnicode(bool enoughChars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enoughChars;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ConvertUnicode_Private_Char_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00022200 File Offset: 0x00020400
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 733634, RefRangeEnd = 733636, XrefRangeStart = 733625, XrefRangeEnd = 733634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char ParseUnicode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseUnicode_Private_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0002223C File Offset: 0x0002043C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 733640, RefRangeEnd = 733641, XrefRangeStart = 733636, XrefRangeEnd = 733640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadNumberIntoBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ReadNumberIntoBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00022270 File Offset: 0x00020470
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 733643, RefRangeEnd = 733644, XrefRangeStart = 733641, XrefRangeEnd = 733643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadNumberCharIntoBuffer(char currentChar, int charPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ReadNumberCharIntoBuffer_Private_Boolean_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x000222C8 File Offset: 0x000204C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 733644, RefRangeEnd = 733646, XrefRangeStart = 733644, XrefRangeEnd = 733644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearRecentString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ClearRecentString_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x000222FC File Offset: 0x000204FC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 733656, RefRangeEnd = 733661, XrefRangeStart = 733646, XrefRangeEnd = 733656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParsePostValue(bool ignoreComments)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ignoreComments;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParsePostValue_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00022348 File Offset: 0x00020548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733661, XrefRangeEnd = 733667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseObject_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00022384 File Offset: 0x00020584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733667, XrefRangeEnd = 733681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseProperty_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003CD RID: 973 RVA: 0x000223C0 File Offset: 0x000205C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 733685, RefRangeEnd = 733687, XrefRangeStart = 733681, XrefRangeEnd = 733685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidIdentifierChar(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ValidIdentifierChar_Private_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0002240C File Offset: 0x0002060C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 733701, RefRangeEnd = 733702, XrefRangeStart = 733687, XrefRangeEnd = 733701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseUnquotedProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseUnquotedProperty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00022440 File Offset: 0x00020640
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 733712, RefRangeEnd = 733713, XrefRangeStart = 733702, XrefRangeEnd = 733712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadUnquotedPropertyReportIfDone(char currentChar, int initialPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ReadUnquotedPropertyReportIfDone_Private_Boolean_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00022498 File Offset: 0x00020698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733713, XrefRangeEnd = 733735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseValue_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x000224D4 File Offset: 0x000206D4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 733735, RefRangeEnd = 733744, XrefRangeStart = 733735, XrefRangeEnd = 733735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessLineFeed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ProcessLineFeed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00022508 File Offset: 0x00020708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733744, XrefRangeEnd = 733745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessCarriageReturn(bool append)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref append;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ProcessCarriageReturn_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00022548 File Offset: 0x00020748
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 733747, RefRangeEnd = 733751, XrefRangeStart = 733745, XrefRangeEnd = 733747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EatWhitespace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_EatWhitespace_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0002257C File Offset: 0x0002077C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733751, XrefRangeEnd = 733777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseConstructor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseConstructor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x000225B0 File Offset: 0x000207B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733777, XrefRangeEnd = 733780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseNumber(ReadType readType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseNumber_Private_Void_ReadType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x000225F0 File Offset: 0x000207F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 733939, RefRangeEnd = 733941, XrefRangeStart = 733780, XrefRangeEnd = 733939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseReadNumber(ReadType readType, char firstChar, int initialPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref firstChar;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseReadNumber_Private_Void_ReadType_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0002264C File Offset: 0x0002084C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733941, XrefRangeEnd = 733944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonReaderException ThrowReaderError(string message, Exception ex = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ThrowReaderError_Private_JsonReaderException_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonReaderException>(intPtr3) : null;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x000226B0 File Offset: 0x000208B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 733950, RefRangeEnd = 733951, XrefRangeStart = 733944, XrefRangeEnd = 733950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object BigIntegerParse(string number, CultureInfo culture)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(number);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_BigIntegerParse_Private_Static_Object_String_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00022708 File Offset: 0x00020908
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 733962, RefRangeEnd = 733966, XrefRangeStart = 733951, XrefRangeEnd = 733962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseComment(bool setToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref setToken;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseComment_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00022748 File Offset: 0x00020948
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 733969, RefRangeEnd = 733974, XrefRangeStart = 733966, XrefRangeEnd = 733969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndComment(bool setToken, int initialPosition, int endPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref setToken;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_EndComment_Private_Void_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x000227A4 File Offset: 0x000209A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733974, XrefRangeEnd = 733977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchValue(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_MatchValue_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x000227F4 File Offset: 0x000209F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 733979, RefRangeEnd = 733980, XrefRangeStart = 733977, XrefRangeEnd = 733979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchValue(bool enoughChars, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enoughChars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_MatchValue_Private_Boolean_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00022850 File Offset: 0x00020A50
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 733983, RefRangeEnd = 733994, XrefRangeStart = 733980, XrefRangeEnd = 733983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchValueWithTrailingSeparator(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_MatchValueWithTrailingSeparator_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x000228A0 File Offset: 0x00020AA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 733998, RefRangeEnd = 733999, XrefRangeStart = 733994, XrefRangeEnd = 733998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSeparator(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_IsSeparator_Private_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003DF RID: 991 RVA: 0x000228EC File Offset: 0x00020AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733999, XrefRangeEnd = 734010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseTrue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseTrue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00022920 File Offset: 0x00020B20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 734017, RefRangeEnd = 734018, XrefRangeStart = 734010, XrefRangeEnd = 734017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseNull_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00022954 File Offset: 0x00020B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 734018, XrefRangeEnd = 734025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseUndefined()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseUndefined_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00022988 File Offset: 0x00020B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 734025, XrefRangeEnd = 734036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseFalse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseFalse_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x000229BC File Offset: 0x00020BBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 734042, RefRangeEnd = 734043, XrefRangeStart = 734036, XrefRangeEnd = 734042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ParseNumberNegativeInfinity(ReadType readType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseNumberNegativeInfinity_Private_Object_ReadType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00022A08 File Offset: 0x00020C08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 734052, RefRangeEnd = 734054, XrefRangeStart = 734043, XrefRangeEnd = 734052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ParseNumberNegativeInfinity(ReadType readType, bool matched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matched;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseNumberNegativeInfinity_Private_Object_ReadType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00022A64 File Offset: 0x00020C64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 734060, RefRangeEnd = 734061, XrefRangeStart = 734054, XrefRangeEnd = 734060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ParseNumberPositiveInfinity(ReadType readType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseNumberPositiveInfinity_Private_Object_ReadType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00022AB0 File Offset: 0x00020CB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 734070, RefRangeEnd = 734072, XrefRangeStart = 734061, XrefRangeEnd = 734070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ParseNumberPositiveInfinity(ReadType readType, bool matched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matched;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseNumberPositiveInfinity_Private_Object_ReadType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00022B0C File Offset: 0x00020D0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 734078, RefRangeEnd = 734080, XrefRangeStart = 734072, XrefRangeEnd = 734078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ParseNumberNaN(ReadType readType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseNumberNaN_Private_Object_ReadType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00022B58 File Offset: 0x00020D58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 734089, RefRangeEnd = 734091, XrefRangeStart = 734080, XrefRangeEnd = 734089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ParseNumberNaN(ReadType readType, bool matched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matched;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_ParseNumberNaN_Private_Object_ReadType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00022BB4 File Offset: 0x00020DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 734091, XrefRangeEnd = 734095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonTextReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00022BF0 File Offset: 0x00020DF0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HasLineInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_HasLineInfo_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x00022C2C File Offset: 0x00020E2C
		public unsafe virtual int LineNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_get_LineNumber_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x00022C68 File Offset: 0x00020E68
		public unsafe virtual int LinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader.NativeMethodInfoPtr_get_LinePosition_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00003802 File Offset: 0x00001A02
		public JsonTextReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x00022CA4 File Offset: 0x00020EA4
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x0000380B File Offset: 0x00001A0B
		public unsafe bool _safeAsync
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader.NativeFieldInfoPtr__safeAsync);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader.NativeFieldInfoPtr__safeAsync)) = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00022CCC File Offset: 0x00020ECC
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x00003826 File Offset: 0x00001A26
		public unsafe static char UnicodeReplacementChar
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(JsonTextReader.NativeFieldInfoPtr_UnicodeReplacementChar, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonTextReader.NativeFieldInfoPtr_UnicodeReplacementChar, (void*)(&value));
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00022CE8 File Offset: 0x00020EE8
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x00003834 File Offset: 0x00001A34
		public unsafe static int MaximumJavascriptIntegerCharacterLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(JsonTextReader.NativeFieldInfoPtr_MaximumJavascriptIntegerCharacterLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonTextReader.NativeFieldInfoPtr_MaximumJavascriptIntegerCharacterLength, (void*)(&value));
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00022D04 File Offset: 0x00020F04
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x00003842 File Offset: 0x00001A42
		public unsafe static int LargeBufferLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(JsonTextReader.NativeFieldInfoPtr_LargeBufferLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonTextReader.NativeFieldInfoPtr_LargeBufferLength, (void*)(&value));
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00022D20 File Offset: 0x00020F20
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x00003850 File Offset: 0x00001A50
		public unsafe TextReader _reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader.NativeFieldInfoPtr__reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader.NativeFieldInfoPtr__reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x00022D50 File Offset: 0x00020F50
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x0000386F File Offset: 0x00001A6F
		public unsafe Il2CppStructArray<char> _chars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader.NativeFieldInfoPtr__chars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader.NativeFieldInfoPtr__chars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x00022D80 File Offset: 0x00020F80
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x0000388E File Offset: 0x00001A8E
		public unsafe int _charsUsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader.NativeFieldInfoPtr__charsUsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader.NativeFieldInfoPtr__charsUsed)) = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x00022DA8 File Offset: 0x00020FA8
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x000038A9 File Offset: 0x00001AA9
		public unsafe int _charPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader.NativeFieldInfoPtr__charPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader.NativeFieldInfoPtr__charPos)) = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00022DD0 File Offset: 0x00020FD0
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x000038C4 File Offset: 0x00001AC4
		public unsafe int _lineStartPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader.NativeFieldInfoPtr__lineStartPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader.NativeFieldInfoPtr__lineStartPos)) = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x00022DF8 File Offset: 0x00020FF8
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x000038DF File Offset: 0x00001ADF
		public unsafe int _lineNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader.NativeFieldInfoPtr__lineNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader.NativeFieldInfoPtr__lineNumber)) = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x00022E20 File Offset: 0x00021020
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x000038FA File Offset: 0x00001AFA
		public unsafe bool _isEndOfFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader.NativeFieldInfoPtr__isEndOfFile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader.NativeFieldInfoPtr__isEndOfFile)) = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00022E48 File Offset: 0x00021048
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x00003915 File Offset: 0x00001B15
		public StringBuffer _stringBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader.NativeFieldInfoPtr__stringBuffer);
				return new StringBuffer(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StringBuffer>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader.NativeFieldInfoPtr__stringBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StringBuffer>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00022E78 File Offset: 0x00021078
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x00003943 File Offset: 0x00001B43
		public StringReference _stringReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader.NativeFieldInfoPtr__stringReference);
				return new StringReference(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StringReference>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader.NativeFieldInfoPtr__stringReference), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StringReference>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x00022EA8 File Offset: 0x000210A8
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x00003971 File Offset: 0x00001B71
		public unsafe IArrayPool<char> _arrayPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader.NativeFieldInfoPtr__arrayPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IArrayPool<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader.NativeFieldInfoPtr__arrayPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x00022ED8 File Offset: 0x000210D8
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x00003990 File Offset: 0x00001B90
		public unsafe JsonNameTable _PropertyNameTable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader.NativeFieldInfoPtr__PropertyNameTable_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader.NativeFieldInfoPtr__PropertyNameTable_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeFieldInfoPtr__safeAsync;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeFieldInfoPtr_UnicodeReplacementChar;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeFieldInfoPtr_MaximumJavascriptIntegerCharacterLength;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeFieldInfoPtr_LargeBufferLength;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeFieldInfoPtr__reader;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeFieldInfoPtr__chars;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeFieldInfoPtr__charsUsed;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeFieldInfoPtr__charPos;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeFieldInfoPtr__lineStartPos;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeFieldInfoPtr__lineNumber;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeFieldInfoPtr__isEndOfFile;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeFieldInfoPtr__stringBuffer;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeFieldInfoPtr__stringReference;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeFieldInfoPtr__arrayPool;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeFieldInfoPtr__PropertyNameTable_k__BackingField;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Boolean_CancellationToken_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_DoReadAsync_Internal_Task_1_Boolean_CancellationToken_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_DoReadAsync_Private_Task_1_Boolean_Task_1_Boolean_CancellationToken_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_ParsePostValueAsync_Private_Task_1_Boolean_Boolean_CancellationToken_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_ReadFromFinishedAsync_Private_Task_1_Boolean_CancellationToken_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr_ReadDataAsync_Private_Task_1_Int32_Boolean_CancellationToken_0;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr_ReadDataAsync_Private_Task_1_Int32_Boolean_Int32_CancellationToken_0;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr_ParseValueAsync_Private_Task_1_Boolean_CancellationToken_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr_ReadStringIntoBufferAsync_Private_Task_Char_CancellationToken_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCarriageReturnAsync_Private_Task_Boolean_CancellationToken_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCarriageReturnAsync_Private_Task_Task_1_Boolean_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_ParseUnicodeAsync_Private_Task_1_Char_CancellationToken_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_EnsureCharsAsync_Private_Task_1_Boolean_Int32_Boolean_CancellationToken_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_ReadCharsAsync_Private_Task_1_Boolean_Int32_Boolean_CancellationToken_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_ParseObjectAsync_Private_Task_1_Boolean_CancellationToken_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_ParseCommentAsync_Private_Task_Boolean_CancellationToken_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_EatWhitespaceAsync_Private_Task_CancellationToken_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr_ParseStringAsync_Private_Task_Char_ReadType_CancellationToken_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_MatchValueAsync_Private_Task_1_Boolean_String_CancellationToken_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr_MatchValueWithTrailingSeparatorAsync_Private_Task_1_Boolean_String_CancellationToken_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_MatchAndSetAsync_Private_Task_String_JsonToken_Object_CancellationToken_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_ParseTrueAsync_Private_Task_CancellationToken_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_ParseFalseAsync_Private_Task_CancellationToken_0;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_ParseNullAsync_Private_Task_CancellationToken_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr_ParseConstructorAsync_Private_Task_CancellationToken_0;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr_ParseNumberNaNAsync_Private_Task_1_Object_ReadType_CancellationToken_0;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr_ParseNumberPositiveInfinityAsync_Private_Task_1_Object_ReadType_CancellationToken_0;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr_ParseNumberNegativeInfinityAsync_Private_Task_1_Object_ReadType_CancellationToken_0;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeMethodInfoPtr_ParseNumberAsync_Private_Task_ReadType_CancellationToken_0;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr_ParseUndefinedAsync_Private_Task_CancellationToken_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr_ParsePropertyAsync_Private_Task_1_Boolean_CancellationToken_0;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_ReadNumberIntoBufferAsync_Private_Task_CancellationToken_0;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr_ParseUnquotedPropertyAsync_Private_Task_CancellationToken_0;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr_ReadNullCharAsync_Private_Task_1_Boolean_CancellationToken_0;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeMethodInfoPtr_HandleNullAsync_Private_Task_CancellationToken_0;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeMethodInfoPtr_ReadFinishedAsync_Private_Task_CancellationToken_0;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeMethodInfoPtr_ReadStringValueAsync_Private_Task_1_Object_ReadType_CancellationToken_0;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeMethodInfoPtr_ReadNumberValueAsync_Private_Task_1_Object_ReadType_CancellationToken_0;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsBooleanAsync_Public_Virtual_Task_1_Nullable_1_Boolean_CancellationToken_0;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeMethodInfoPtr_DoReadAsBooleanAsync_Internal_Task_1_Nullable_1_Boolean_CancellationToken_0;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsBytesAsync_Public_Virtual_Task_1_Il2CppStructArray_1_Byte_CancellationToken_0;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeMethodInfoPtr_DoReadAsBytesAsync_Internal_Task_1_Il2CppStructArray_1_Byte_CancellationToken_0;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeMethodInfoPtr_ReadIntoWrappedTypeObjectAsync_Private_Task_CancellationToken_0;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsDateTimeAsync_Public_Virtual_Task_1_Nullable_1_DateTime_CancellationToken_0;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeMethodInfoPtr_DoReadAsDateTimeAsync_Internal_Task_1_Nullable_1_DateTime_CancellationToken_0;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsDateTimeOffsetAsync_Public_Virtual_Task_1_Nullable_1_DateTimeOffset_CancellationToken_0;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeMethodInfoPtr_DoReadAsDateTimeOffsetAsync_Internal_Task_1_Nullable_1_DateTimeOffset_CancellationToken_0;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsDecimalAsync_Public_Virtual_Task_1_Nullable_1_Decimal_CancellationToken_0;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeMethodInfoPtr_DoReadAsDecimalAsync_Internal_Task_1_Nullable_1_Decimal_CancellationToken_0;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsDoubleAsync_Public_Virtual_Task_1_Nullable_1_Double_CancellationToken_0;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeMethodInfoPtr_DoReadAsDoubleAsync_Internal_Task_1_Nullable_1_Double_CancellationToken_0;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsInt32Async_Public_Virtual_Task_1_Nullable_1_Int32_CancellationToken_0;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_DoReadAsInt32Async_Internal_Task_1_Nullable_1_Int32_CancellationToken_0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsStringAsync_Public_Virtual_Task_1_String_CancellationToken_0;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_DoReadAsStringAsync_Internal_Task_1_String_CancellationToken_0;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextReader_0;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyNameTable_Public_get_JsonNameTable_0;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr_set_PropertyNameTable_Public_set_Void_JsonNameTable_0;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeMethodInfoPtr_get_ArrayPool_Public_get_IArrayPool_1_Char_0;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeMethodInfoPtr_set_ArrayPool_Public_set_Void_IArrayPool_1_Char_0;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeMethodInfoPtr_EnsureBufferNotEmpty_Private_Void_0;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr_SetNewLine_Private_Void_Boolean_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr_OnNewLine_Private_Void_Int32_0;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr_ParseString_Private_Void_Char_ReadType_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_ParseReadString_Private_Void_Char_ReadType_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr_BlockCopyChars_Private_Static_Void_Il2CppStructArray_1_Char_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr_ShiftBufferIfNeeded_Private_Void_0;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr_ReadData_Private_Int32_Boolean_0;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr_PrepareBufferForReadData_Private_Void_Boolean_Int32_0;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr_ReadData_Private_Int32_Boolean_Int32_0;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr_EnsureChars_Private_Boolean_Int32_Boolean_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_ReadChars_Private_Boolean_Int32_Boolean_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsInt32_Public_Virtual_Nullable_1_Int32_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsDateTime_Public_Virtual_Nullable_1_DateTime_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsString_Public_Virtual_String_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsBytes_Public_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_ReadStringValue_Private_Object_ReadType_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_FinishReadQuotedStringValue_Private_Object_ReadType_0;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr_CreateUnexpectedCharacterException_Private_JsonReaderException_Char_0;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsBoolean_Public_Virtual_Nullable_1_Boolean_0;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr_ProcessValueComma_Private_Void_0;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr_ReadNumberValue_Private_Object_ReadType_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_FinishReadQuotedNumber_Private_Object_ReadType_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsDateTimeOffset_Public_Virtual_Nullable_1_DateTimeOffset_0;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsDecimal_Public_Virtual_Nullable_1_Decimal_0;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsDouble_Public_Virtual_Nullable_1_Double_0;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeMethodInfoPtr_HandleNull_Private_Void_0;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeMethodInfoPtr_ReadFinished_Private_Void_0;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeMethodInfoPtr_ReadNullChar_Private_Boolean_0;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeMethodInfoPtr_EnsureBuffer_Private_Void_0;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeMethodInfoPtr_ReadStringIntoBuffer_Private_Void_Char_0;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr_FinishReadStringIntoBuffer_Private_Void_Int32_Int32_Int32_0;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr_WriteCharToBuffer_Private_Void_Char_Int32_Int32_0;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr_ConvertUnicode_Private_Char_Boolean_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr_ParseUnicode_Private_Char_0;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_ReadNumberIntoBuffer_Private_Void_0;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_ReadNumberCharIntoBuffer_Private_Boolean_Char_Int32_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_ClearRecentString_Private_Void_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr_ParsePostValue_Private_Boolean_Boolean_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_ParseObject_Private_Boolean_0;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr_ParseProperty_Private_Boolean_0;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr_ValidIdentifierChar_Private_Boolean_Char_0;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr_ParseUnquotedProperty_Private_Void_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_ReadUnquotedPropertyReportIfDone_Private_Boolean_Char_Int32_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_ParseValue_Private_Boolean_0;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_ProcessLineFeed_Private_Void_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCarriageReturn_Private_Void_Boolean_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_EatWhitespace_Private_Void_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_ParseConstructor_Private_Void_0;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_ParseNumber_Private_Void_ReadType_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr_ParseReadNumber_Private_Void_ReadType_Char_Int32_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_ThrowReaderError_Private_JsonReaderException_String_Exception_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr_BigIntegerParse_Private_Static_Object_String_CultureInfo_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_ParseComment_Private_Void_Boolean_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_EndComment_Private_Void_Boolean_Int32_Int32_0;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeMethodInfoPtr_MatchValue_Private_Boolean_String_0;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeMethodInfoPtr_MatchValue_Private_Boolean_Boolean_String_0;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeMethodInfoPtr_MatchValueWithTrailingSeparator_Private_Boolean_String_0;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeMethodInfoPtr_IsSeparator_Private_Boolean_Char_0;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeMethodInfoPtr_ParseTrue_Private_Void_0;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr_ParseNull_Private_Void_0;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr_ParseUndefined_Private_Void_0;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeMethodInfoPtr_ParseFalse_Private_Void_0;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr_ParseNumberNegativeInfinity_Private_Object_ReadType_0;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr_ParseNumberNegativeInfinity_Private_Object_ReadType_Boolean_0;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr_ParseNumberPositiveInfinity_Private_Object_ReadType_0;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr_ParseNumberPositiveInfinity_Private_Object_ReadType_Boolean_0;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr_ParseNumberNaN_Private_Object_ReadType_0;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr_ParseNumberNaN_Private_Object_ReadType_Boolean_0;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr_HasLineInfo_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x02000120 RID: 288
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<DoReadAsBooleanAsync>d__40")]
		public sealed class _DoReadAsBooleanAsync_d__40 : ValueType
		{
			// Token: 0x060016DA RID: 5850 RVA: 0x00079338 File Offset: 0x00077538
			// Note: this type is marked as 'beforefieldinit'.
			static _DoReadAsBooleanAsync_d__40()
			{
				Il2CppClassPointerStore<JsonTextReader._DoReadAsBooleanAsync_d__40>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<DoReadAsBooleanAsync>d__40");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._DoReadAsBooleanAsync_d__40>.NativeClassPtr);
				JsonTextReader._DoReadAsBooleanAsync_d__40.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsBooleanAsync_d__40>.NativeClassPtr, "<>1__state");
				JsonTextReader._DoReadAsBooleanAsync_d__40.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsBooleanAsync_d__40>.NativeClassPtr, "<>t__builder");
				JsonTextReader._DoReadAsBooleanAsync_d__40.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsBooleanAsync_d__40>.NativeClassPtr, "<>4__this");
				JsonTextReader._DoReadAsBooleanAsync_d__40.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsBooleanAsync_d__40>.NativeClassPtr, "cancellationToken");
				JsonTextReader._DoReadAsBooleanAsync_d__40.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsBooleanAsync_d__40>.NativeClassPtr, "<>u__1");
				JsonTextReader._DoReadAsBooleanAsync_d__40.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsBooleanAsync_d__40>.NativeClassPtr, "<i>5__2");
				JsonTextReader._DoReadAsBooleanAsync_d__40.NativeFieldInfoPtr__isTrue_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsBooleanAsync_d__40>.NativeClassPtr, "<isTrue>5__3");
				JsonTextReader._DoReadAsBooleanAsync_d__40.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsBooleanAsync_d__40>.NativeClassPtr, "<>u__2");
				JsonTextReader._DoReadAsBooleanAsync_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._DoReadAsBooleanAsync_d__40>.NativeClassPtr, 100663917);
				JsonTextReader._DoReadAsBooleanAsync_d__40.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._DoReadAsBooleanAsync_d__40>.NativeClassPtr, 100663918);
			}

			// Token: 0x060016DB RID: 5851 RVA: 0x0007942C File Offset: 0x0007762C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 730223, RefRangeEnd = 730224, XrefRangeStart = 730050, XrefRangeEnd = 730223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._DoReadAsBooleanAsync_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016DC RID: 5852 RVA: 0x00079464 File Offset: 0x00077664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730224, XrefRangeEnd = 730230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._DoReadAsBooleanAsync_d__40.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060016DD RID: 5853 RVA: 0x0000913B File Offset: 0x0000733B
			public _DoReadAsBooleanAsync_d__40(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060016DE RID: 5854 RVA: 0x00009144 File Offset: 0x00007344
			public _DoReadAsBooleanAsync_d__40()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._DoReadAsBooleanAsync_d__40>.NativeClassPtr))
			{
			}

			// Token: 0x17000605 RID: 1541
			// (get) Token: 0x060016DF RID: 5855 RVA: 0x000794AC File Offset: 0x000776AC
			// (set) Token: 0x060016E0 RID: 5856 RVA: 0x00009156 File Offset: 0x00007356
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBooleanAsync_d__40.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBooleanAsync_d__40.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000606 RID: 1542
			// (get) Token: 0x060016E1 RID: 5857 RVA: 0x000794D4 File Offset: 0x000776D4
			// (set) Token: 0x060016E2 RID: 5858 RVA: 0x00009171 File Offset: 0x00007371
			public AsyncTaskMethodBuilder<Nullable<bool>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBooleanAsync_d__40.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<bool>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<bool>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBooleanAsync_d__40.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<bool>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000607 RID: 1543
			// (get) Token: 0x060016E3 RID: 5859 RVA: 0x00079504 File Offset: 0x00077704
			// (set) Token: 0x060016E4 RID: 5860 RVA: 0x0000919F File Offset: 0x0000739F
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBooleanAsync_d__40.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBooleanAsync_d__40.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000608 RID: 1544
			// (get) Token: 0x060016E5 RID: 5861 RVA: 0x00079534 File Offset: 0x00077734
			// (set) Token: 0x060016E6 RID: 5862 RVA: 0x000091BE File Offset: 0x000073BE
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBooleanAsync_d__40.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBooleanAsync_d__40.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000609 RID: 1545
			// (get) Token: 0x060016E7 RID: 5863 RVA: 0x00079564 File Offset: 0x00077764
			// (set) Token: 0x060016E8 RID: 5864 RVA: 0x000091EC File Offset: 0x000073EC
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBooleanAsync_d__40.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBooleanAsync_d__40.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700060A RID: 1546
			// (get) Token: 0x060016E9 RID: 5865 RVA: 0x00079594 File Offset: 0x00077794
			// (set) Token: 0x060016EA RID: 5866 RVA: 0x0000921A File Offset: 0x0000741A
			public BigInteger _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBooleanAsync_d__40.NativeFieldInfoPtr__i_5__2);
					return new BigInteger(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBooleanAsync_d__40.NativeFieldInfoPtr__i_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700060B RID: 1547
			// (get) Token: 0x060016EB RID: 5867 RVA: 0x000795C4 File Offset: 0x000777C4
			// (set) Token: 0x060016EC RID: 5868 RVA: 0x00009248 File Offset: 0x00007448
			public unsafe bool _isTrue_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBooleanAsync_d__40.NativeFieldInfoPtr__isTrue_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBooleanAsync_d__40.NativeFieldInfoPtr__isTrue_5__3)) = value;
				}
			}

			// Token: 0x1700060C RID: 1548
			// (get) Token: 0x060016ED RID: 5869 RVA: 0x000795EC File Offset: 0x000777EC
			// (set) Token: 0x060016EE RID: 5870 RVA: 0x00009263 File Offset: 0x00007463
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBooleanAsync_d__40.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBooleanAsync_d__40.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400125B RID: 4699
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400125C RID: 4700
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400125D RID: 4701
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400125E RID: 4702
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400125F RID: 4703
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001260 RID: 4704
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04001261 RID: 4705
			private static readonly IntPtr NativeFieldInfoPtr__isTrue_5__3;

			// Token: 0x04001262 RID: 4706
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04001263 RID: 4707
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001264 RID: 4708
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000121 RID: 289
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<DoReadAsBytesAsync>d__42")]
		public sealed class _DoReadAsBytesAsync_d__42 : ValueType
		{
			// Token: 0x060016EF RID: 5871 RVA: 0x0007961C File Offset: 0x0007781C
			// Note: this type is marked as 'beforefieldinit'.
			static _DoReadAsBytesAsync_d__42()
			{
				Il2CppClassPointerStore<JsonTextReader._DoReadAsBytesAsync_d__42>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<DoReadAsBytesAsync>d__42");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._DoReadAsBytesAsync_d__42>.NativeClassPtr);
				JsonTextReader._DoReadAsBytesAsync_d__42.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsBytesAsync_d__42>.NativeClassPtr, "<>1__state");
				JsonTextReader._DoReadAsBytesAsync_d__42.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsBytesAsync_d__42>.NativeClassPtr, "<>t__builder");
				JsonTextReader._DoReadAsBytesAsync_d__42.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsBytesAsync_d__42>.NativeClassPtr, "<>4__this");
				JsonTextReader._DoReadAsBytesAsync_d__42.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsBytesAsync_d__42>.NativeClassPtr, "cancellationToken");
				JsonTextReader._DoReadAsBytesAsync_d__42.NativeFieldInfoPtr__isWrapped_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsBytesAsync_d__42>.NativeClassPtr, "<isWrapped>5__2");
				JsonTextReader._DoReadAsBytesAsync_d__42.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsBytesAsync_d__42>.NativeClassPtr, "<>u__1");
				JsonTextReader._DoReadAsBytesAsync_d__42.NativeFieldInfoPtr__data_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsBytesAsync_d__42>.NativeClassPtr, "<data>5__3");
				JsonTextReader._DoReadAsBytesAsync_d__42.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsBytesAsync_d__42>.NativeClassPtr, "<>u__2");
				JsonTextReader._DoReadAsBytesAsync_d__42.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsBytesAsync_d__42>.NativeClassPtr, "<>u__3");
				JsonTextReader._DoReadAsBytesAsync_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._DoReadAsBytesAsync_d__42>.NativeClassPtr, 100663919);
				JsonTextReader._DoReadAsBytesAsync_d__42.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._DoReadAsBytesAsync_d__42>.NativeClassPtr, 100663920);
			}

			// Token: 0x060016F0 RID: 5872 RVA: 0x00079724 File Offset: 0x00077924
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730230, XrefRangeEnd = 730393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._DoReadAsBytesAsync_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016F1 RID: 5873 RVA: 0x0007975C File Offset: 0x0007795C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730393, XrefRangeEnd = 730399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._DoReadAsBytesAsync_d__42.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060016F2 RID: 5874 RVA: 0x00009291 File Offset: 0x00007491
			public _DoReadAsBytesAsync_d__42(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060016F3 RID: 5875 RVA: 0x0000929A File Offset: 0x0000749A
			public _DoReadAsBytesAsync_d__42()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._DoReadAsBytesAsync_d__42>.NativeClassPtr))
			{
			}

			// Token: 0x1700060D RID: 1549
			// (get) Token: 0x060016F4 RID: 5876 RVA: 0x000797A4 File Offset: 0x000779A4
			// (set) Token: 0x060016F5 RID: 5877 RVA: 0x000092AC File Offset: 0x000074AC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBytesAsync_d__42.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBytesAsync_d__42.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700060E RID: 1550
			// (get) Token: 0x060016F6 RID: 5878 RVA: 0x000797CC File Offset: 0x000779CC
			// (set) Token: 0x060016F7 RID: 5879 RVA: 0x000092C7 File Offset: 0x000074C7
			public AsyncTaskMethodBuilder<Il2CppStructArray<byte>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBytesAsync_d__42.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Il2CppStructArray<byte>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppStructArray<byte>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBytesAsync_d__42.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppStructArray<byte>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700060F RID: 1551
			// (get) Token: 0x060016F8 RID: 5880 RVA: 0x000797FC File Offset: 0x000779FC
			// (set) Token: 0x060016F9 RID: 5881 RVA: 0x000092F5 File Offset: 0x000074F5
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBytesAsync_d__42.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBytesAsync_d__42.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000610 RID: 1552
			// (get) Token: 0x060016FA RID: 5882 RVA: 0x0007982C File Offset: 0x00077A2C
			// (set) Token: 0x060016FB RID: 5883 RVA: 0x00009314 File Offset: 0x00007514
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBytesAsync_d__42.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBytesAsync_d__42.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000611 RID: 1553
			// (get) Token: 0x060016FC RID: 5884 RVA: 0x0007985C File Offset: 0x00077A5C
			// (set) Token: 0x060016FD RID: 5885 RVA: 0x00009342 File Offset: 0x00007542
			public unsafe bool _isWrapped_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBytesAsync_d__42.NativeFieldInfoPtr__isWrapped_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBytesAsync_d__42.NativeFieldInfoPtr__isWrapped_5__2)) = value;
				}
			}

			// Token: 0x17000612 RID: 1554
			// (get) Token: 0x060016FE RID: 5886 RVA: 0x00079884 File Offset: 0x00077A84
			// (set) Token: 0x060016FF RID: 5887 RVA: 0x0000935D File Offset: 0x0000755D
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBytesAsync_d__42.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBytesAsync_d__42.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000613 RID: 1555
			// (get) Token: 0x06001700 RID: 5888 RVA: 0x000798B4 File Offset: 0x00077AB4
			// (set) Token: 0x06001701 RID: 5889 RVA: 0x0000938B File Offset: 0x0000758B
			public unsafe Il2CppStructArray<byte> _data_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBytesAsync_d__42.NativeFieldInfoPtr__data_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBytesAsync_d__42.NativeFieldInfoPtr__data_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000614 RID: 1556
			// (get) Token: 0x06001702 RID: 5890 RVA: 0x000798E4 File Offset: 0x00077AE4
			// (set) Token: 0x06001703 RID: 5891 RVA: 0x000093AA File Offset: 0x000075AA
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBytesAsync_d__42.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBytesAsync_d__42.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000615 RID: 1557
			// (get) Token: 0x06001704 RID: 5892 RVA: 0x00079914 File Offset: 0x00077B14
			// (set) Token: 0x06001705 RID: 5893 RVA: 0x000093D8 File Offset: 0x000075D8
			public ConfiguredTaskAwaitable<Il2CppStructArray<byte>>.ConfiguredTaskAwaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBytesAsync_d__42.NativeFieldInfoPtr___u__3);
					return new ConfiguredTaskAwaitable<Il2CppStructArray<byte>>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Il2CppStructArray<byte>>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsBytesAsync_d__42.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Il2CppStructArray<byte>>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001265 RID: 4709
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001266 RID: 4710
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001267 RID: 4711
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001268 RID: 4712
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001269 RID: 4713
			private static readonly IntPtr NativeFieldInfoPtr__isWrapped_5__2;

			// Token: 0x0400126A RID: 4714
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400126B RID: 4715
			private static readonly IntPtr NativeFieldInfoPtr__data_5__3;

			// Token: 0x0400126C RID: 4716
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400126D RID: 4717
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x0400126E RID: 4718
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400126F RID: 4719
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000122 RID: 290
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<DoReadAsDateTimeAsync>d__45")]
		public sealed class _DoReadAsDateTimeAsync_d__45 : ValueType
		{
			// Token: 0x06001706 RID: 5894 RVA: 0x00079944 File Offset: 0x00077B44
			// Note: this type is marked as 'beforefieldinit'.
			static _DoReadAsDateTimeAsync_d__45()
			{
				Il2CppClassPointerStore<JsonTextReader._DoReadAsDateTimeAsync_d__45>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<DoReadAsDateTimeAsync>d__45");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._DoReadAsDateTimeAsync_d__45>.NativeClassPtr);
				JsonTextReader._DoReadAsDateTimeAsync_d__45.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsDateTimeAsync_d__45>.NativeClassPtr, "<>1__state");
				JsonTextReader._DoReadAsDateTimeAsync_d__45.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsDateTimeAsync_d__45>.NativeClassPtr, "<>t__builder");
				JsonTextReader._DoReadAsDateTimeAsync_d__45.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsDateTimeAsync_d__45>.NativeClassPtr, "<>4__this");
				JsonTextReader._DoReadAsDateTimeAsync_d__45.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsDateTimeAsync_d__45>.NativeClassPtr, "cancellationToken");
				JsonTextReader._DoReadAsDateTimeAsync_d__45.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsDateTimeAsync_d__45>.NativeClassPtr, "<>u__1");
				JsonTextReader._DoReadAsDateTimeAsync_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._DoReadAsDateTimeAsync_d__45>.NativeClassPtr, 100663921);
				JsonTextReader._DoReadAsDateTimeAsync_d__45.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._DoReadAsDateTimeAsync_d__45>.NativeClassPtr, 100663922);
			}

			// Token: 0x06001707 RID: 5895 RVA: 0x000799FC File Offset: 0x00077BFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730399, XrefRangeEnd = 730421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._DoReadAsDateTimeAsync_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001708 RID: 5896 RVA: 0x00079A34 File Offset: 0x00077C34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730421, XrefRangeEnd = 730427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._DoReadAsDateTimeAsync_d__45.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001709 RID: 5897 RVA: 0x00009406 File Offset: 0x00007606
			public _DoReadAsDateTimeAsync_d__45(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600170A RID: 5898 RVA: 0x0000940F File Offset: 0x0000760F
			public _DoReadAsDateTimeAsync_d__45()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._DoReadAsDateTimeAsync_d__45>.NativeClassPtr))
			{
			}

			// Token: 0x17000616 RID: 1558
			// (get) Token: 0x0600170B RID: 5899 RVA: 0x00079A7C File Offset: 0x00077C7C
			// (set) Token: 0x0600170C RID: 5900 RVA: 0x00009421 File Offset: 0x00007621
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDateTimeAsync_d__45.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDateTimeAsync_d__45.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000617 RID: 1559
			// (get) Token: 0x0600170D RID: 5901 RVA: 0x00079AA4 File Offset: 0x00077CA4
			// (set) Token: 0x0600170E RID: 5902 RVA: 0x0000943C File Offset: 0x0000763C
			public AsyncTaskMethodBuilder<Nullable<DateTime>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDateTimeAsync_d__45.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<DateTime>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<DateTime>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDateTimeAsync_d__45.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<DateTime>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000618 RID: 1560
			// (get) Token: 0x0600170F RID: 5903 RVA: 0x00079AD4 File Offset: 0x00077CD4
			// (set) Token: 0x06001710 RID: 5904 RVA: 0x0000946A File Offset: 0x0000766A
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDateTimeAsync_d__45.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDateTimeAsync_d__45.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000619 RID: 1561
			// (get) Token: 0x06001711 RID: 5905 RVA: 0x00079B04 File Offset: 0x00077D04
			// (set) Token: 0x06001712 RID: 5906 RVA: 0x00009489 File Offset: 0x00007689
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDateTimeAsync_d__45.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDateTimeAsync_d__45.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700061A RID: 1562
			// (get) Token: 0x06001713 RID: 5907 RVA: 0x00079B34 File Offset: 0x00077D34
			// (set) Token: 0x06001714 RID: 5908 RVA: 0x000094B7 File Offset: 0x000076B7
			public ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDateTimeAsync_d__45.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDateTimeAsync_d__45.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001270 RID: 4720
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001271 RID: 4721
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001272 RID: 4722
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001273 RID: 4723
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001274 RID: 4724
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001275 RID: 4725
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001276 RID: 4726
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000123 RID: 291
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<DoReadAsDateTimeOffsetAsync>d__47")]
		public sealed class _DoReadAsDateTimeOffsetAsync_d__47 : ValueType
		{
			// Token: 0x06001715 RID: 5909 RVA: 0x00079B64 File Offset: 0x00077D64
			// Note: this type is marked as 'beforefieldinit'.
			static _DoReadAsDateTimeOffsetAsync_d__47()
			{
				Il2CppClassPointerStore<JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<DoReadAsDateTimeOffsetAsync>d__47");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47>.NativeClassPtr);
				JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47>.NativeClassPtr, "<>1__state");
				JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47>.NativeClassPtr, "<>t__builder");
				JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47>.NativeClassPtr, "<>4__this");
				JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47>.NativeClassPtr, "cancellationToken");
				JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47>.NativeClassPtr, "<>u__1");
				JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47>.NativeClassPtr, 100663923);
				JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47>.NativeClassPtr, 100663924);
			}

			// Token: 0x06001716 RID: 5910 RVA: 0x00079C1C File Offset: 0x00077E1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730427, XrefRangeEnd = 730449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001717 RID: 5911 RVA: 0x00079C54 File Offset: 0x00077E54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730449, XrefRangeEnd = 730455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001718 RID: 5912 RVA: 0x000094E5 File Offset: 0x000076E5
			public _DoReadAsDateTimeOffsetAsync_d__47(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001719 RID: 5913 RVA: 0x000094EE File Offset: 0x000076EE
			public _DoReadAsDateTimeOffsetAsync_d__47()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47>.NativeClassPtr))
			{
			}

			// Token: 0x1700061B RID: 1563
			// (get) Token: 0x0600171A RID: 5914 RVA: 0x00079C9C File Offset: 0x00077E9C
			// (set) Token: 0x0600171B RID: 5915 RVA: 0x00009500 File Offset: 0x00007700
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700061C RID: 1564
			// (get) Token: 0x0600171C RID: 5916 RVA: 0x00079CC4 File Offset: 0x00077EC4
			// (set) Token: 0x0600171D RID: 5917 RVA: 0x0000951B File Offset: 0x0000771B
			public AsyncTaskMethodBuilder<Nullable<DateTimeOffset>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<DateTimeOffset>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<DateTimeOffset>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<DateTimeOffset>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700061D RID: 1565
			// (get) Token: 0x0600171E RID: 5918 RVA: 0x00079CF4 File Offset: 0x00077EF4
			// (set) Token: 0x0600171F RID: 5919 RVA: 0x00009549 File Offset: 0x00007749
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700061E RID: 1566
			// (get) Token: 0x06001720 RID: 5920 RVA: 0x00079D24 File Offset: 0x00077F24
			// (set) Token: 0x06001721 RID: 5921 RVA: 0x00009568 File Offset: 0x00007768
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700061F RID: 1567
			// (get) Token: 0x06001722 RID: 5922 RVA: 0x00079D54 File Offset: 0x00077F54
			// (set) Token: 0x06001723 RID: 5923 RVA: 0x00009596 File Offset: 0x00007796
			public ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDateTimeOffsetAsync_d__47.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001277 RID: 4727
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001278 RID: 4728
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001279 RID: 4729
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400127A RID: 4730
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400127B RID: 4731
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400127C RID: 4732
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400127D RID: 4733
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000124 RID: 292
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<DoReadAsDecimalAsync>d__49")]
		public sealed class _DoReadAsDecimalAsync_d__49 : ValueType
		{
			// Token: 0x06001724 RID: 5924 RVA: 0x00079D84 File Offset: 0x00077F84
			// Note: this type is marked as 'beforefieldinit'.
			static _DoReadAsDecimalAsync_d__49()
			{
				Il2CppClassPointerStore<JsonTextReader._DoReadAsDecimalAsync_d__49>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<DoReadAsDecimalAsync>d__49");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._DoReadAsDecimalAsync_d__49>.NativeClassPtr);
				JsonTextReader._DoReadAsDecimalAsync_d__49.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsDecimalAsync_d__49>.NativeClassPtr, "<>1__state");
				JsonTextReader._DoReadAsDecimalAsync_d__49.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsDecimalAsync_d__49>.NativeClassPtr, "<>t__builder");
				JsonTextReader._DoReadAsDecimalAsync_d__49.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsDecimalAsync_d__49>.NativeClassPtr, "<>4__this");
				JsonTextReader._DoReadAsDecimalAsync_d__49.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsDecimalAsync_d__49>.NativeClassPtr, "cancellationToken");
				JsonTextReader._DoReadAsDecimalAsync_d__49.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsDecimalAsync_d__49>.NativeClassPtr, "<>u__1");
				JsonTextReader._DoReadAsDecimalAsync_d__49.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._DoReadAsDecimalAsync_d__49>.NativeClassPtr, 100663925);
				JsonTextReader._DoReadAsDecimalAsync_d__49.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._DoReadAsDecimalAsync_d__49>.NativeClassPtr, 100663926);
			}

			// Token: 0x06001725 RID: 5925 RVA: 0x00079E3C File Offset: 0x0007803C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730455, XrefRangeEnd = 730477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._DoReadAsDecimalAsync_d__49.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001726 RID: 5926 RVA: 0x00079E74 File Offset: 0x00078074
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730477, XrefRangeEnd = 730483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._DoReadAsDecimalAsync_d__49.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001727 RID: 5927 RVA: 0x000095C4 File Offset: 0x000077C4
			public _DoReadAsDecimalAsync_d__49(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001728 RID: 5928 RVA: 0x000095CD File Offset: 0x000077CD
			public _DoReadAsDecimalAsync_d__49()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._DoReadAsDecimalAsync_d__49>.NativeClassPtr))
			{
			}

			// Token: 0x17000620 RID: 1568
			// (get) Token: 0x06001729 RID: 5929 RVA: 0x00079EBC File Offset: 0x000780BC
			// (set) Token: 0x0600172A RID: 5930 RVA: 0x000095DF File Offset: 0x000077DF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDecimalAsync_d__49.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDecimalAsync_d__49.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000621 RID: 1569
			// (get) Token: 0x0600172B RID: 5931 RVA: 0x00079EE4 File Offset: 0x000780E4
			// (set) Token: 0x0600172C RID: 5932 RVA: 0x000095FA File Offset: 0x000077FA
			public AsyncTaskMethodBuilder<Nullable<Decimal>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDecimalAsync_d__49.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<Decimal>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Decimal>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDecimalAsync_d__49.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Decimal>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000622 RID: 1570
			// (get) Token: 0x0600172D RID: 5933 RVA: 0x00079F14 File Offset: 0x00078114
			// (set) Token: 0x0600172E RID: 5934 RVA: 0x00009628 File Offset: 0x00007828
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDecimalAsync_d__49.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDecimalAsync_d__49.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000623 RID: 1571
			// (get) Token: 0x0600172F RID: 5935 RVA: 0x00079F44 File Offset: 0x00078144
			// (set) Token: 0x06001730 RID: 5936 RVA: 0x00009647 File Offset: 0x00007847
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDecimalAsync_d__49.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDecimalAsync_d__49.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000624 RID: 1572
			// (get) Token: 0x06001731 RID: 5937 RVA: 0x00079F74 File Offset: 0x00078174
			// (set) Token: 0x06001732 RID: 5938 RVA: 0x00009675 File Offset: 0x00007875
			public ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDecimalAsync_d__49.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDecimalAsync_d__49.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400127E RID: 4734
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400127F RID: 4735
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001280 RID: 4736
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001281 RID: 4737
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001282 RID: 4738
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001283 RID: 4739
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001284 RID: 4740
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000125 RID: 293
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<DoReadAsDoubleAsync>d__51")]
		public sealed class _DoReadAsDoubleAsync_d__51 : ValueType
		{
			// Token: 0x06001733 RID: 5939 RVA: 0x00079FA4 File Offset: 0x000781A4
			// Note: this type is marked as 'beforefieldinit'.
			static _DoReadAsDoubleAsync_d__51()
			{
				Il2CppClassPointerStore<JsonTextReader._DoReadAsDoubleAsync_d__51>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<DoReadAsDoubleAsync>d__51");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._DoReadAsDoubleAsync_d__51>.NativeClassPtr);
				JsonTextReader._DoReadAsDoubleAsync_d__51.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsDoubleAsync_d__51>.NativeClassPtr, "<>1__state");
				JsonTextReader._DoReadAsDoubleAsync_d__51.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsDoubleAsync_d__51>.NativeClassPtr, "<>t__builder");
				JsonTextReader._DoReadAsDoubleAsync_d__51.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsDoubleAsync_d__51>.NativeClassPtr, "<>4__this");
				JsonTextReader._DoReadAsDoubleAsync_d__51.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsDoubleAsync_d__51>.NativeClassPtr, "cancellationToken");
				JsonTextReader._DoReadAsDoubleAsync_d__51.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsDoubleAsync_d__51>.NativeClassPtr, "<>u__1");
				JsonTextReader._DoReadAsDoubleAsync_d__51.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._DoReadAsDoubleAsync_d__51>.NativeClassPtr, 100663927);
				JsonTextReader._DoReadAsDoubleAsync_d__51.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._DoReadAsDoubleAsync_d__51>.NativeClassPtr, 100663928);
			}

			// Token: 0x06001734 RID: 5940 RVA: 0x0007A05C File Offset: 0x0007825C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730483, XrefRangeEnd = 730505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._DoReadAsDoubleAsync_d__51.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001735 RID: 5941 RVA: 0x0007A094 File Offset: 0x00078294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730505, XrefRangeEnd = 730511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._DoReadAsDoubleAsync_d__51.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001736 RID: 5942 RVA: 0x000096A3 File Offset: 0x000078A3
			public _DoReadAsDoubleAsync_d__51(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001737 RID: 5943 RVA: 0x000096AC File Offset: 0x000078AC
			public _DoReadAsDoubleAsync_d__51()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._DoReadAsDoubleAsync_d__51>.NativeClassPtr))
			{
			}

			// Token: 0x17000625 RID: 1573
			// (get) Token: 0x06001738 RID: 5944 RVA: 0x0007A0DC File Offset: 0x000782DC
			// (set) Token: 0x06001739 RID: 5945 RVA: 0x000096BE File Offset: 0x000078BE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDoubleAsync_d__51.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDoubleAsync_d__51.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000626 RID: 1574
			// (get) Token: 0x0600173A RID: 5946 RVA: 0x0007A104 File Offset: 0x00078304
			// (set) Token: 0x0600173B RID: 5947 RVA: 0x000096D9 File Offset: 0x000078D9
			public AsyncTaskMethodBuilder<Nullable<double>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDoubleAsync_d__51.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<double>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<double>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDoubleAsync_d__51.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<double>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000627 RID: 1575
			// (get) Token: 0x0600173C RID: 5948 RVA: 0x0007A134 File Offset: 0x00078334
			// (set) Token: 0x0600173D RID: 5949 RVA: 0x00009707 File Offset: 0x00007907
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDoubleAsync_d__51.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDoubleAsync_d__51.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000628 RID: 1576
			// (get) Token: 0x0600173E RID: 5950 RVA: 0x0007A164 File Offset: 0x00078364
			// (set) Token: 0x0600173F RID: 5951 RVA: 0x00009726 File Offset: 0x00007926
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDoubleAsync_d__51.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDoubleAsync_d__51.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000629 RID: 1577
			// (get) Token: 0x06001740 RID: 5952 RVA: 0x0007A194 File Offset: 0x00078394
			// (set) Token: 0x06001741 RID: 5953 RVA: 0x00009754 File Offset: 0x00007954
			public ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDoubleAsync_d__51.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsDoubleAsync_d__51.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001285 RID: 4741
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001286 RID: 4742
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001287 RID: 4743
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001288 RID: 4744
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001289 RID: 4745
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400128A RID: 4746
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400128B RID: 4747
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000126 RID: 294
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<DoReadAsInt32Async>d__53")]
		public sealed class _DoReadAsInt32Async_d__53 : ValueType
		{
			// Token: 0x06001742 RID: 5954 RVA: 0x0007A1C4 File Offset: 0x000783C4
			// Note: this type is marked as 'beforefieldinit'.
			static _DoReadAsInt32Async_d__53()
			{
				Il2CppClassPointerStore<JsonTextReader._DoReadAsInt32Async_d__53>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<DoReadAsInt32Async>d__53");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._DoReadAsInt32Async_d__53>.NativeClassPtr);
				JsonTextReader._DoReadAsInt32Async_d__53.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsInt32Async_d__53>.NativeClassPtr, "<>1__state");
				JsonTextReader._DoReadAsInt32Async_d__53.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsInt32Async_d__53>.NativeClassPtr, "<>t__builder");
				JsonTextReader._DoReadAsInt32Async_d__53.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsInt32Async_d__53>.NativeClassPtr, "<>4__this");
				JsonTextReader._DoReadAsInt32Async_d__53.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsInt32Async_d__53>.NativeClassPtr, "cancellationToken");
				JsonTextReader._DoReadAsInt32Async_d__53.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsInt32Async_d__53>.NativeClassPtr, "<>u__1");
				JsonTextReader._DoReadAsInt32Async_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._DoReadAsInt32Async_d__53>.NativeClassPtr, 100663929);
				JsonTextReader._DoReadAsInt32Async_d__53.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._DoReadAsInt32Async_d__53>.NativeClassPtr, 100663930);
			}

			// Token: 0x06001743 RID: 5955 RVA: 0x0007A27C File Offset: 0x0007847C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730511, XrefRangeEnd = 730533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._DoReadAsInt32Async_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001744 RID: 5956 RVA: 0x0007A2B4 File Offset: 0x000784B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730533, XrefRangeEnd = 730539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._DoReadAsInt32Async_d__53.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001745 RID: 5957 RVA: 0x00009782 File Offset: 0x00007982
			public _DoReadAsInt32Async_d__53(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001746 RID: 5958 RVA: 0x0000978B File Offset: 0x0000798B
			public _DoReadAsInt32Async_d__53()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._DoReadAsInt32Async_d__53>.NativeClassPtr))
			{
			}

			// Token: 0x1700062A RID: 1578
			// (get) Token: 0x06001747 RID: 5959 RVA: 0x0007A2FC File Offset: 0x000784FC
			// (set) Token: 0x06001748 RID: 5960 RVA: 0x0000979D File Offset: 0x0000799D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsInt32Async_d__53.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsInt32Async_d__53.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700062B RID: 1579
			// (get) Token: 0x06001749 RID: 5961 RVA: 0x0007A324 File Offset: 0x00078524
			// (set) Token: 0x0600174A RID: 5962 RVA: 0x000097B8 File Offset: 0x000079B8
			public AsyncTaskMethodBuilder<Nullable<int>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsInt32Async_d__53.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<int>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<int>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsInt32Async_d__53.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<int>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700062C RID: 1580
			// (get) Token: 0x0600174B RID: 5963 RVA: 0x0007A354 File Offset: 0x00078554
			// (set) Token: 0x0600174C RID: 5964 RVA: 0x000097E6 File Offset: 0x000079E6
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsInt32Async_d__53.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsInt32Async_d__53.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700062D RID: 1581
			// (get) Token: 0x0600174D RID: 5965 RVA: 0x0007A384 File Offset: 0x00078584
			// (set) Token: 0x0600174E RID: 5966 RVA: 0x00009805 File Offset: 0x00007A05
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsInt32Async_d__53.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsInt32Async_d__53.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700062E RID: 1582
			// (get) Token: 0x0600174F RID: 5967 RVA: 0x0007A3B4 File Offset: 0x000785B4
			// (set) Token: 0x06001750 RID: 5968 RVA: 0x00009833 File Offset: 0x00007A33
			public ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsInt32Async_d__53.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsInt32Async_d__53.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400128C RID: 4748
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400128D RID: 4749
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400128E RID: 4750
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400128F RID: 4751
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001290 RID: 4752
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001291 RID: 4753
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001292 RID: 4754
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000127 RID: 295
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<DoReadAsStringAsync>d__55")]
		public sealed class _DoReadAsStringAsync_d__55 : ValueType
		{
			// Token: 0x06001751 RID: 5969 RVA: 0x0007A3E4 File Offset: 0x000785E4
			// Note: this type is marked as 'beforefieldinit'.
			static _DoReadAsStringAsync_d__55()
			{
				Il2CppClassPointerStore<JsonTextReader._DoReadAsStringAsync_d__55>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<DoReadAsStringAsync>d__55");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._DoReadAsStringAsync_d__55>.NativeClassPtr);
				JsonTextReader._DoReadAsStringAsync_d__55.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsStringAsync_d__55>.NativeClassPtr, "<>1__state");
				JsonTextReader._DoReadAsStringAsync_d__55.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsStringAsync_d__55>.NativeClassPtr, "<>t__builder");
				JsonTextReader._DoReadAsStringAsync_d__55.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsStringAsync_d__55>.NativeClassPtr, "<>4__this");
				JsonTextReader._DoReadAsStringAsync_d__55.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsStringAsync_d__55>.NativeClassPtr, "cancellationToken");
				JsonTextReader._DoReadAsStringAsync_d__55.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsStringAsync_d__55>.NativeClassPtr, "<>u__1");
				JsonTextReader._DoReadAsStringAsync_d__55.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._DoReadAsStringAsync_d__55>.NativeClassPtr, 100663931);
				JsonTextReader._DoReadAsStringAsync_d__55.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._DoReadAsStringAsync_d__55>.NativeClassPtr, 100663932);
			}

			// Token: 0x06001752 RID: 5970 RVA: 0x0007A49C File Offset: 0x0007869C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730539, XrefRangeEnd = 730560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._DoReadAsStringAsync_d__55.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001753 RID: 5971 RVA: 0x0007A4D4 File Offset: 0x000786D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730560, XrefRangeEnd = 730566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._DoReadAsStringAsync_d__55.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001754 RID: 5972 RVA: 0x00009861 File Offset: 0x00007A61
			public _DoReadAsStringAsync_d__55(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001755 RID: 5973 RVA: 0x0000986A File Offset: 0x00007A6A
			public _DoReadAsStringAsync_d__55()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._DoReadAsStringAsync_d__55>.NativeClassPtr))
			{
			}

			// Token: 0x1700062F RID: 1583
			// (get) Token: 0x06001756 RID: 5974 RVA: 0x0007A51C File Offset: 0x0007871C
			// (set) Token: 0x06001757 RID: 5975 RVA: 0x0000987C File Offset: 0x00007A7C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsStringAsync_d__55.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsStringAsync_d__55.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000630 RID: 1584
			// (get) Token: 0x06001758 RID: 5976 RVA: 0x0007A544 File Offset: 0x00078744
			// (set) Token: 0x06001759 RID: 5977 RVA: 0x00009897 File Offset: 0x00007A97
			public AsyncTaskMethodBuilder<string> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsStringAsync_d__55.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<string>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsStringAsync_d__55.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<string>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000631 RID: 1585
			// (get) Token: 0x0600175A RID: 5978 RVA: 0x0007A574 File Offset: 0x00078774
			// (set) Token: 0x0600175B RID: 5979 RVA: 0x000098C5 File Offset: 0x00007AC5
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsStringAsync_d__55.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsStringAsync_d__55.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000632 RID: 1586
			// (get) Token: 0x0600175C RID: 5980 RVA: 0x0007A5A4 File Offset: 0x000787A4
			// (set) Token: 0x0600175D RID: 5981 RVA: 0x000098E4 File Offset: 0x00007AE4
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsStringAsync_d__55.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsStringAsync_d__55.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000633 RID: 1587
			// (get) Token: 0x0600175E RID: 5982 RVA: 0x0007A5D4 File Offset: 0x000787D4
			// (set) Token: 0x0600175F RID: 5983 RVA: 0x00009912 File Offset: 0x00007B12
			public ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsStringAsync_d__55.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsStringAsync_d__55.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001293 RID: 4755
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001294 RID: 4756
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001295 RID: 4757
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001296 RID: 4758
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001297 RID: 4759
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001298 RID: 4760
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001299 RID: 4761
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000128 RID: 296
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<DoReadAsync>d__3")]
		public sealed class _DoReadAsync_d__3 : ValueType
		{
			// Token: 0x06001760 RID: 5984 RVA: 0x0007A604 File Offset: 0x00078804
			// Note: this type is marked as 'beforefieldinit'.
			static _DoReadAsync_d__3()
			{
				Il2CppClassPointerStore<JsonTextReader._DoReadAsync_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<DoReadAsync>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._DoReadAsync_d__3>.NativeClassPtr);
				JsonTextReader._DoReadAsync_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsync_d__3>.NativeClassPtr, "<>1__state");
				JsonTextReader._DoReadAsync_d__3.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsync_d__3>.NativeClassPtr, "<>t__builder");
				JsonTextReader._DoReadAsync_d__3.NativeFieldInfoPtr_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsync_d__3>.NativeClassPtr, "task");
				JsonTextReader._DoReadAsync_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsync_d__3>.NativeClassPtr, "<>4__this");
				JsonTextReader._DoReadAsync_d__3.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsync_d__3>.NativeClassPtr, "cancellationToken");
				JsonTextReader._DoReadAsync_d__3.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._DoReadAsync_d__3>.NativeClassPtr, "<>u__1");
				JsonTextReader._DoReadAsync_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._DoReadAsync_d__3>.NativeClassPtr, 100663933);
				JsonTextReader._DoReadAsync_d__3.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._DoReadAsync_d__3>.NativeClassPtr, 100663934);
			}

			// Token: 0x06001761 RID: 5985 RVA: 0x0007A6D0 File Offset: 0x000788D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730566, XrefRangeEnd = 730599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._DoReadAsync_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001762 RID: 5986 RVA: 0x0007A708 File Offset: 0x00078908
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730599, XrefRangeEnd = 730605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._DoReadAsync_d__3.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001763 RID: 5987 RVA: 0x00009940 File Offset: 0x00007B40
			public _DoReadAsync_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001764 RID: 5988 RVA: 0x00009949 File Offset: 0x00007B49
			public _DoReadAsync_d__3()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._DoReadAsync_d__3>.NativeClassPtr))
			{
			}

			// Token: 0x17000634 RID: 1588
			// (get) Token: 0x06001765 RID: 5989 RVA: 0x0007A750 File Offset: 0x00078950
			// (set) Token: 0x06001766 RID: 5990 RVA: 0x0000995B File Offset: 0x00007B5B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsync_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsync_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000635 RID: 1589
			// (get) Token: 0x06001767 RID: 5991 RVA: 0x0007A778 File Offset: 0x00078978
			// (set) Token: 0x06001768 RID: 5992 RVA: 0x00009976 File Offset: 0x00007B76
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsync_d__3.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsync_d__3.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000636 RID: 1590
			// (get) Token: 0x06001769 RID: 5993 RVA: 0x0007A7A8 File Offset: 0x000789A8
			// (set) Token: 0x0600176A RID: 5994 RVA: 0x000099A4 File Offset: 0x00007BA4
			public unsafe Task<bool> task
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsync_d__3.NativeFieldInfoPtr_task);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsync_d__3.NativeFieldInfoPtr_task), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000637 RID: 1591
			// (get) Token: 0x0600176B RID: 5995 RVA: 0x0007A7D8 File Offset: 0x000789D8
			// (set) Token: 0x0600176C RID: 5996 RVA: 0x000099C3 File Offset: 0x00007BC3
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsync_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsync_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000638 RID: 1592
			// (get) Token: 0x0600176D RID: 5997 RVA: 0x0007A808 File Offset: 0x00078A08
			// (set) Token: 0x0600176E RID: 5998 RVA: 0x000099E2 File Offset: 0x00007BE2
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsync_d__3.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsync_d__3.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000639 RID: 1593
			// (get) Token: 0x0600176F RID: 5999 RVA: 0x0007A838 File Offset: 0x00078A38
			// (set) Token: 0x06001770 RID: 6000 RVA: 0x00009A10 File Offset: 0x00007C10
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsync_d__3.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._DoReadAsync_d__3.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400129A RID: 4762
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400129B RID: 4763
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400129C RID: 4764
			private static readonly IntPtr NativeFieldInfoPtr_task;

			// Token: 0x0400129D RID: 4765
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400129E RID: 4766
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400129F RID: 4767
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040012A0 RID: 4768
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040012A1 RID: 4769
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000129 RID: 297
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<EatWhitespaceAsync>d__17")]
		public sealed class _EatWhitespaceAsync_d__17 : ValueType
		{
			// Token: 0x06001771 RID: 6001 RVA: 0x0007A868 File Offset: 0x00078A68
			// Note: this type is marked as 'beforefieldinit'.
			static _EatWhitespaceAsync_d__17()
			{
				Il2CppClassPointerStore<JsonTextReader._EatWhitespaceAsync_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<EatWhitespaceAsync>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._EatWhitespaceAsync_d__17>.NativeClassPtr);
				JsonTextReader._EatWhitespaceAsync_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._EatWhitespaceAsync_d__17>.NativeClassPtr, "<>1__state");
				JsonTextReader._EatWhitespaceAsync_d__17.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._EatWhitespaceAsync_d__17>.NativeClassPtr, "<>t__builder");
				JsonTextReader._EatWhitespaceAsync_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._EatWhitespaceAsync_d__17>.NativeClassPtr, "<>4__this");
				JsonTextReader._EatWhitespaceAsync_d__17.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._EatWhitespaceAsync_d__17>.NativeClassPtr, "cancellationToken");
				JsonTextReader._EatWhitespaceAsync_d__17.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._EatWhitespaceAsync_d__17>.NativeClassPtr, "<>u__1");
				JsonTextReader._EatWhitespaceAsync_d__17.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._EatWhitespaceAsync_d__17>.NativeClassPtr, "<>u__2");
				JsonTextReader._EatWhitespaceAsync_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._EatWhitespaceAsync_d__17>.NativeClassPtr, 100663935);
				JsonTextReader._EatWhitespaceAsync_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._EatWhitespaceAsync_d__17>.NativeClassPtr, 100663936);
			}

			// Token: 0x06001772 RID: 6002 RVA: 0x0007A934 File Offset: 0x00078B34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730605, XrefRangeEnd = 730649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._EatWhitespaceAsync_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001773 RID: 6003 RVA: 0x0007A96C File Offset: 0x00078B6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730649, XrefRangeEnd = 730653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._EatWhitespaceAsync_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001774 RID: 6004 RVA: 0x00009A3E File Offset: 0x00007C3E
			public _EatWhitespaceAsync_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001775 RID: 6005 RVA: 0x00009A47 File Offset: 0x00007C47
			public _EatWhitespaceAsync_d__17()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._EatWhitespaceAsync_d__17>.NativeClassPtr))
			{
			}

			// Token: 0x1700063A RID: 1594
			// (get) Token: 0x06001776 RID: 6006 RVA: 0x0007A9B4 File Offset: 0x00078BB4
			// (set) Token: 0x06001777 RID: 6007 RVA: 0x00009A59 File Offset: 0x00007C59
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._EatWhitespaceAsync_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._EatWhitespaceAsync_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700063B RID: 1595
			// (get) Token: 0x06001778 RID: 6008 RVA: 0x0007A9DC File Offset: 0x00078BDC
			// (set) Token: 0x06001779 RID: 6009 RVA: 0x00009A74 File Offset: 0x00007C74
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._EatWhitespaceAsync_d__17.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._EatWhitespaceAsync_d__17.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700063C RID: 1596
			// (get) Token: 0x0600177A RID: 6010 RVA: 0x0007AA0C File Offset: 0x00078C0C
			// (set) Token: 0x0600177B RID: 6011 RVA: 0x00009AA2 File Offset: 0x00007CA2
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._EatWhitespaceAsync_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._EatWhitespaceAsync_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700063D RID: 1597
			// (get) Token: 0x0600177C RID: 6012 RVA: 0x0007AA3C File Offset: 0x00078C3C
			// (set) Token: 0x0600177D RID: 6013 RVA: 0x00009AC1 File Offset: 0x00007CC1
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._EatWhitespaceAsync_d__17.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._EatWhitespaceAsync_d__17.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700063E RID: 1598
			// (get) Token: 0x0600177E RID: 6014 RVA: 0x0007AA6C File Offset: 0x00078C6C
			// (set) Token: 0x0600177F RID: 6015 RVA: 0x00009AEF File Offset: 0x00007CEF
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._EatWhitespaceAsync_d__17.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._EatWhitespaceAsync_d__17.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700063F RID: 1599
			// (get) Token: 0x06001780 RID: 6016 RVA: 0x0007AA9C File Offset: 0x00078C9C
			// (set) Token: 0x06001781 RID: 6017 RVA: 0x00009B1D File Offset: 0x00007D1D
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._EatWhitespaceAsync_d__17.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._EatWhitespaceAsync_d__17.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040012A2 RID: 4770
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040012A3 RID: 4771
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040012A4 RID: 4772
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040012A5 RID: 4773
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040012A6 RID: 4774
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040012A7 RID: 4775
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040012A8 RID: 4776
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040012A9 RID: 4777
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200012A RID: 298
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<HandleNullAsync>d__35")]
		public sealed class _HandleNullAsync_d__35 : ValueType
		{
			// Token: 0x06001782 RID: 6018 RVA: 0x0007AACC File Offset: 0x00078CCC
			// Note: this type is marked as 'beforefieldinit'.
			static _HandleNullAsync_d__35()
			{
				Il2CppClassPointerStore<JsonTextReader._HandleNullAsync_d__35>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<HandleNullAsync>d__35");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._HandleNullAsync_d__35>.NativeClassPtr);
				JsonTextReader._HandleNullAsync_d__35.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._HandleNullAsync_d__35>.NativeClassPtr, "<>1__state");
				JsonTextReader._HandleNullAsync_d__35.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._HandleNullAsync_d__35>.NativeClassPtr, "<>t__builder");
				JsonTextReader._HandleNullAsync_d__35.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._HandleNullAsync_d__35>.NativeClassPtr, "<>4__this");
				JsonTextReader._HandleNullAsync_d__35.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._HandleNullAsync_d__35>.NativeClassPtr, "cancellationToken");
				JsonTextReader._HandleNullAsync_d__35.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._HandleNullAsync_d__35>.NativeClassPtr, "<>u__1");
				JsonTextReader._HandleNullAsync_d__35.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._HandleNullAsync_d__35>.NativeClassPtr, "<>u__2");
				JsonTextReader._HandleNullAsync_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._HandleNullAsync_d__35>.NativeClassPtr, 100663937);
				JsonTextReader._HandleNullAsync_d__35.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._HandleNullAsync_d__35>.NativeClassPtr, 100663938);
			}

			// Token: 0x06001783 RID: 6019 RVA: 0x0007AB98 File Offset: 0x00078D98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730653, XrefRangeEnd = 730676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._HandleNullAsync_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001784 RID: 6020 RVA: 0x0007ABD0 File Offset: 0x00078DD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730676, XrefRangeEnd = 730680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._HandleNullAsync_d__35.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001785 RID: 6021 RVA: 0x00009B4B File Offset: 0x00007D4B
			public _HandleNullAsync_d__35(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001786 RID: 6022 RVA: 0x00009B54 File Offset: 0x00007D54
			public _HandleNullAsync_d__35()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._HandleNullAsync_d__35>.NativeClassPtr))
			{
			}

			// Token: 0x17000640 RID: 1600
			// (get) Token: 0x06001787 RID: 6023 RVA: 0x0007AC18 File Offset: 0x00078E18
			// (set) Token: 0x06001788 RID: 6024 RVA: 0x00009B66 File Offset: 0x00007D66
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._HandleNullAsync_d__35.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._HandleNullAsync_d__35.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000641 RID: 1601
			// (get) Token: 0x06001789 RID: 6025 RVA: 0x0007AC40 File Offset: 0x00078E40
			// (set) Token: 0x0600178A RID: 6026 RVA: 0x00009B81 File Offset: 0x00007D81
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._HandleNullAsync_d__35.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._HandleNullAsync_d__35.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000642 RID: 1602
			// (get) Token: 0x0600178B RID: 6027 RVA: 0x0007AC70 File Offset: 0x00078E70
			// (set) Token: 0x0600178C RID: 6028 RVA: 0x00009BAF File Offset: 0x00007DAF
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._HandleNullAsync_d__35.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._HandleNullAsync_d__35.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000643 RID: 1603
			// (get) Token: 0x0600178D RID: 6029 RVA: 0x0007ACA0 File Offset: 0x00078EA0
			// (set) Token: 0x0600178E RID: 6030 RVA: 0x00009BCE File Offset: 0x00007DCE
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._HandleNullAsync_d__35.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._HandleNullAsync_d__35.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000644 RID: 1604
			// (get) Token: 0x0600178F RID: 6031 RVA: 0x0007ACD0 File Offset: 0x00078ED0
			// (set) Token: 0x06001790 RID: 6032 RVA: 0x00009BFC File Offset: 0x00007DFC
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._HandleNullAsync_d__35.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._HandleNullAsync_d__35.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000645 RID: 1605
			// (get) Token: 0x06001791 RID: 6033 RVA: 0x0007AD00 File Offset: 0x00078F00
			// (set) Token: 0x06001792 RID: 6034 RVA: 0x00009C2A File Offset: 0x00007E2A
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._HandleNullAsync_d__35.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._HandleNullAsync_d__35.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040012AA RID: 4778
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040012AB RID: 4779
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040012AC RID: 4780
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040012AD RID: 4781
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040012AE RID: 4782
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040012AF RID: 4783
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040012B0 RID: 4784
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040012B1 RID: 4785
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200012B RID: 299
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<MatchAndSetAsync>d__21")]
		public sealed class _MatchAndSetAsync_d__21 : ValueType
		{
			// Token: 0x06001793 RID: 6035 RVA: 0x0007AD30 File Offset: 0x00078F30
			// Note: this type is marked as 'beforefieldinit'.
			static _MatchAndSetAsync_d__21()
			{
				Il2CppClassPointerStore<JsonTextReader._MatchAndSetAsync_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<MatchAndSetAsync>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._MatchAndSetAsync_d__21>.NativeClassPtr);
				JsonTextReader._MatchAndSetAsync_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._MatchAndSetAsync_d__21>.NativeClassPtr, "<>1__state");
				JsonTextReader._MatchAndSetAsync_d__21.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._MatchAndSetAsync_d__21>.NativeClassPtr, "<>t__builder");
				JsonTextReader._MatchAndSetAsync_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._MatchAndSetAsync_d__21>.NativeClassPtr, "<>4__this");
				JsonTextReader._MatchAndSetAsync_d__21.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._MatchAndSetAsync_d__21>.NativeClassPtr, "value");
				JsonTextReader._MatchAndSetAsync_d__21.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._MatchAndSetAsync_d__21>.NativeClassPtr, "cancellationToken");
				JsonTextReader._MatchAndSetAsync_d__21.NativeFieldInfoPtr_newToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._MatchAndSetAsync_d__21>.NativeClassPtr, "newToken");
				JsonTextReader._MatchAndSetAsync_d__21.NativeFieldInfoPtr_tokenValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._MatchAndSetAsync_d__21>.NativeClassPtr, "tokenValue");
				JsonTextReader._MatchAndSetAsync_d__21.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._MatchAndSetAsync_d__21>.NativeClassPtr, "<>u__1");
				JsonTextReader._MatchAndSetAsync_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._MatchAndSetAsync_d__21>.NativeClassPtr, 100663939);
				JsonTextReader._MatchAndSetAsync_d__21.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._MatchAndSetAsync_d__21>.NativeClassPtr, 100663940);
			}

			// Token: 0x06001794 RID: 6036 RVA: 0x0007AE24 File Offset: 0x00079024
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730680, XrefRangeEnd = 730698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._MatchAndSetAsync_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001795 RID: 6037 RVA: 0x0007AE5C File Offset: 0x0007905C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730698, XrefRangeEnd = 730702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._MatchAndSetAsync_d__21.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001796 RID: 6038 RVA: 0x00009C58 File Offset: 0x00007E58
			public _MatchAndSetAsync_d__21(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001797 RID: 6039 RVA: 0x00009C61 File Offset: 0x00007E61
			public _MatchAndSetAsync_d__21()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._MatchAndSetAsync_d__21>.NativeClassPtr))
			{
			}

			// Token: 0x17000646 RID: 1606
			// (get) Token: 0x06001798 RID: 6040 RVA: 0x0007AEA4 File Offset: 0x000790A4
			// (set) Token: 0x06001799 RID: 6041 RVA: 0x00009C73 File Offset: 0x00007E73
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchAndSetAsync_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchAndSetAsync_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000647 RID: 1607
			// (get) Token: 0x0600179A RID: 6042 RVA: 0x0007AECC File Offset: 0x000790CC
			// (set) Token: 0x0600179B RID: 6043 RVA: 0x00009C8E File Offset: 0x00007E8E
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchAndSetAsync_d__21.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchAndSetAsync_d__21.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000648 RID: 1608
			// (get) Token: 0x0600179C RID: 6044 RVA: 0x0007AEFC File Offset: 0x000790FC
			// (set) Token: 0x0600179D RID: 6045 RVA: 0x00009CBC File Offset: 0x00007EBC
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchAndSetAsync_d__21.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchAndSetAsync_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000649 RID: 1609
			// (get) Token: 0x0600179E RID: 6046 RVA: 0x0007AF2C File Offset: 0x0007912C
			// (set) Token: 0x0600179F RID: 6047 RVA: 0x00009CDB File Offset: 0x00007EDB
			public unsafe string value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchAndSetAsync_d__21.NativeFieldInfoPtr_value);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchAndSetAsync_d__21.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700064A RID: 1610
			// (get) Token: 0x060017A0 RID: 6048 RVA: 0x0007AF54 File Offset: 0x00079154
			// (set) Token: 0x060017A1 RID: 6049 RVA: 0x00009CFA File Offset: 0x00007EFA
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchAndSetAsync_d__21.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchAndSetAsync_d__21.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700064B RID: 1611
			// (get) Token: 0x060017A2 RID: 6050 RVA: 0x0007AF84 File Offset: 0x00079184
			// (set) Token: 0x060017A3 RID: 6051 RVA: 0x00009D28 File Offset: 0x00007F28
			public unsafe JsonToken newToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchAndSetAsync_d__21.NativeFieldInfoPtr_newToken);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchAndSetAsync_d__21.NativeFieldInfoPtr_newToken)) = value;
				}
			}

			// Token: 0x1700064C RID: 1612
			// (get) Token: 0x060017A4 RID: 6052 RVA: 0x0007AFAC File Offset: 0x000791AC
			// (set) Token: 0x060017A5 RID: 6053 RVA: 0x00009D43 File Offset: 0x00007F43
			public unsafe Object tokenValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchAndSetAsync_d__21.NativeFieldInfoPtr_tokenValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchAndSetAsync_d__21.NativeFieldInfoPtr_tokenValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700064D RID: 1613
			// (get) Token: 0x060017A6 RID: 6054 RVA: 0x0007AFDC File Offset: 0x000791DC
			// (set) Token: 0x060017A7 RID: 6055 RVA: 0x00009D62 File Offset: 0x00007F62
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchAndSetAsync_d__21.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchAndSetAsync_d__21.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040012B2 RID: 4786
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040012B3 RID: 4787
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040012B4 RID: 4788
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040012B5 RID: 4789
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040012B6 RID: 4790
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040012B7 RID: 4791
			private static readonly IntPtr NativeFieldInfoPtr_newToken;

			// Token: 0x040012B8 RID: 4792
			private static readonly IntPtr NativeFieldInfoPtr_tokenValue;

			// Token: 0x040012B9 RID: 4793
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040012BA RID: 4794
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040012BB RID: 4795
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200012C RID: 300
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<MatchValueAsync>d__19")]
		public sealed class _MatchValueAsync_d__19 : ValueType
		{
			// Token: 0x060017A8 RID: 6056 RVA: 0x0007B00C File Offset: 0x0007920C
			// Note: this type is marked as 'beforefieldinit'.
			static _MatchValueAsync_d__19()
			{
				Il2CppClassPointerStore<JsonTextReader._MatchValueAsync_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<MatchValueAsync>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._MatchValueAsync_d__19>.NativeClassPtr);
				JsonTextReader._MatchValueAsync_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._MatchValueAsync_d__19>.NativeClassPtr, "<>1__state");
				JsonTextReader._MatchValueAsync_d__19.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._MatchValueAsync_d__19>.NativeClassPtr, "<>t__builder");
				JsonTextReader._MatchValueAsync_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._MatchValueAsync_d__19>.NativeClassPtr, "<>4__this");
				JsonTextReader._MatchValueAsync_d__19.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._MatchValueAsync_d__19>.NativeClassPtr, "value");
				JsonTextReader._MatchValueAsync_d__19.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._MatchValueAsync_d__19>.NativeClassPtr, "cancellationToken");
				JsonTextReader._MatchValueAsync_d__19.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._MatchValueAsync_d__19>.NativeClassPtr, "<>u__1");
				JsonTextReader._MatchValueAsync_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._MatchValueAsync_d__19>.NativeClassPtr, 100663941);
				JsonTextReader._MatchValueAsync_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._MatchValueAsync_d__19>.NativeClassPtr, 100663942);
			}

			// Token: 0x060017A9 RID: 6057 RVA: 0x0007B0D8 File Offset: 0x000792D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730702, XrefRangeEnd = 730722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._MatchValueAsync_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017AA RID: 6058 RVA: 0x0007B110 File Offset: 0x00079310
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730722, XrefRangeEnd = 730728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._MatchValueAsync_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017AB RID: 6059 RVA: 0x00009D90 File Offset: 0x00007F90
			public _MatchValueAsync_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060017AC RID: 6060 RVA: 0x00009D99 File Offset: 0x00007F99
			public _MatchValueAsync_d__19()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._MatchValueAsync_d__19>.NativeClassPtr))
			{
			}

			// Token: 0x1700064E RID: 1614
			// (get) Token: 0x060017AD RID: 6061 RVA: 0x0007B158 File Offset: 0x00079358
			// (set) Token: 0x060017AE RID: 6062 RVA: 0x00009DAB File Offset: 0x00007FAB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchValueAsync_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchValueAsync_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700064F RID: 1615
			// (get) Token: 0x060017AF RID: 6063 RVA: 0x0007B180 File Offset: 0x00079380
			// (set) Token: 0x060017B0 RID: 6064 RVA: 0x00009DC6 File Offset: 0x00007FC6
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchValueAsync_d__19.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchValueAsync_d__19.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000650 RID: 1616
			// (get) Token: 0x060017B1 RID: 6065 RVA: 0x0007B1B0 File Offset: 0x000793B0
			// (set) Token: 0x060017B2 RID: 6066 RVA: 0x00009DF4 File Offset: 0x00007FF4
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchValueAsync_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchValueAsync_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000651 RID: 1617
			// (get) Token: 0x060017B3 RID: 6067 RVA: 0x0007B1E0 File Offset: 0x000793E0
			// (set) Token: 0x060017B4 RID: 6068 RVA: 0x00009E13 File Offset: 0x00008013
			public unsafe string value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchValueAsync_d__19.NativeFieldInfoPtr_value);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchValueAsync_d__19.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000652 RID: 1618
			// (get) Token: 0x060017B5 RID: 6069 RVA: 0x0007B208 File Offset: 0x00079408
			// (set) Token: 0x060017B6 RID: 6070 RVA: 0x00009E32 File Offset: 0x00008032
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchValueAsync_d__19.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchValueAsync_d__19.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000653 RID: 1619
			// (get) Token: 0x060017B7 RID: 6071 RVA: 0x0007B238 File Offset: 0x00079438
			// (set) Token: 0x060017B8 RID: 6072 RVA: 0x00009E60 File Offset: 0x00008060
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchValueAsync_d__19.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchValueAsync_d__19.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040012BC RID: 4796
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040012BD RID: 4797
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040012BE RID: 4798
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040012BF RID: 4799
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040012C0 RID: 4800
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040012C1 RID: 4801
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040012C2 RID: 4802
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040012C3 RID: 4803
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200012D RID: 301
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<MatchValueWithTrailingSeparatorAsync>d__20")]
		public sealed class _MatchValueWithTrailingSeparatorAsync_d__20 : ValueType
		{
			// Token: 0x060017B9 RID: 6073 RVA: 0x0007B268 File Offset: 0x00079468
			// Note: this type is marked as 'beforefieldinit'.
			static _MatchValueWithTrailingSeparatorAsync_d__20()
			{
				Il2CppClassPointerStore<JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<MatchValueWithTrailingSeparatorAsync>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20>.NativeClassPtr);
				JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20>.NativeClassPtr, "<>1__state");
				JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20>.NativeClassPtr, "<>t__builder");
				JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20>.NativeClassPtr, "<>4__this");
				JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20>.NativeClassPtr, "value");
				JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20>.NativeClassPtr, "cancellationToken");
				JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20>.NativeClassPtr, "<>u__1");
				JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20>.NativeClassPtr, 100663943);
				JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20>.NativeClassPtr, 100663944);
			}

			// Token: 0x060017BA RID: 6074 RVA: 0x0007B334 File Offset: 0x00079534
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730728, XrefRangeEnd = 730765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017BB RID: 6075 RVA: 0x0007B36C File Offset: 0x0007956C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730765, XrefRangeEnd = 730771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017BC RID: 6076 RVA: 0x00009E8E File Offset: 0x0000808E
			public _MatchValueWithTrailingSeparatorAsync_d__20(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060017BD RID: 6077 RVA: 0x00009E97 File Offset: 0x00008097
			public _MatchValueWithTrailingSeparatorAsync_d__20()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20>.NativeClassPtr))
			{
			}

			// Token: 0x17000654 RID: 1620
			// (get) Token: 0x060017BE RID: 6078 RVA: 0x0007B3B4 File Offset: 0x000795B4
			// (set) Token: 0x060017BF RID: 6079 RVA: 0x00009EA9 File Offset: 0x000080A9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000655 RID: 1621
			// (get) Token: 0x060017C0 RID: 6080 RVA: 0x0007B3DC File Offset: 0x000795DC
			// (set) Token: 0x060017C1 RID: 6081 RVA: 0x00009EC4 File Offset: 0x000080C4
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000656 RID: 1622
			// (get) Token: 0x060017C2 RID: 6082 RVA: 0x0007B40C File Offset: 0x0007960C
			// (set) Token: 0x060017C3 RID: 6083 RVA: 0x00009EF2 File Offset: 0x000080F2
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000657 RID: 1623
			// (get) Token: 0x060017C4 RID: 6084 RVA: 0x0007B43C File Offset: 0x0007963C
			// (set) Token: 0x060017C5 RID: 6085 RVA: 0x00009F11 File Offset: 0x00008111
			public unsafe string value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20.NativeFieldInfoPtr_value);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000658 RID: 1624
			// (get) Token: 0x060017C6 RID: 6086 RVA: 0x0007B464 File Offset: 0x00079664
			// (set) Token: 0x060017C7 RID: 6087 RVA: 0x00009F30 File Offset: 0x00008130
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000659 RID: 1625
			// (get) Token: 0x060017C8 RID: 6088 RVA: 0x0007B494 File Offset: 0x00079694
			// (set) Token: 0x060017C9 RID: 6089 RVA: 0x00009F5E File Offset: 0x0000815E
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._MatchValueWithTrailingSeparatorAsync_d__20.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040012C4 RID: 4804
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040012C5 RID: 4805
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040012C6 RID: 4806
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040012C7 RID: 4807
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040012C8 RID: 4808
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040012C9 RID: 4809
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040012CA RID: 4810
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040012CB RID: 4811
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200012E RID: 302
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<ParseCommentAsync>d__16")]
		public sealed class _ParseCommentAsync_d__16 : ValueType
		{
			// Token: 0x060017CA RID: 6090 RVA: 0x0007B4C4 File Offset: 0x000796C4
			// Note: this type is marked as 'beforefieldinit'.
			static _ParseCommentAsync_d__16()
			{
				Il2CppClassPointerStore<JsonTextReader._ParseCommentAsync_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<ParseCommentAsync>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._ParseCommentAsync_d__16>.NativeClassPtr);
				JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseCommentAsync_d__16>.NativeClassPtr, "<>1__state");
				JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseCommentAsync_d__16>.NativeClassPtr, "<>t__builder");
				JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseCommentAsync_d__16>.NativeClassPtr, "<>4__this");
				JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseCommentAsync_d__16>.NativeClassPtr, "cancellationToken");
				JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr_setToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseCommentAsync_d__16>.NativeClassPtr, "setToken");
				JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr__singlelineComment_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseCommentAsync_d__16>.NativeClassPtr, "<singlelineComment>5__2");
				JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr__initialPosition_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseCommentAsync_d__16>.NativeClassPtr, "<initialPosition>5__3");
				JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseCommentAsync_d__16>.NativeClassPtr, "<>u__1");
				JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseCommentAsync_d__16>.NativeClassPtr, "<>u__2");
				JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseCommentAsync_d__16>.NativeClassPtr, "<>u__3");
				JsonTextReader._ParseCommentAsync_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ParseCommentAsync_d__16>.NativeClassPtr, 100663945);
				JsonTextReader._ParseCommentAsync_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ParseCommentAsync_d__16>.NativeClassPtr, 100663946);
			}

			// Token: 0x060017CB RID: 6091 RVA: 0x0007B5E0 File Offset: 0x000797E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730771, XrefRangeEnd = 730850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ParseCommentAsync_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017CC RID: 6092 RVA: 0x0007B618 File Offset: 0x00079818
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730850, XrefRangeEnd = 730854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ParseCommentAsync_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017CD RID: 6093 RVA: 0x00009F8C File Offset: 0x0000818C
			public _ParseCommentAsync_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060017CE RID: 6094 RVA: 0x00009F95 File Offset: 0x00008195
			public _ParseCommentAsync_d__16()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._ParseCommentAsync_d__16>.NativeClassPtr))
			{
			}

			// Token: 0x1700065A RID: 1626
			// (get) Token: 0x060017CF RID: 6095 RVA: 0x0007B660 File Offset: 0x00079860
			// (set) Token: 0x060017D0 RID: 6096 RVA: 0x00009FA7 File Offset: 0x000081A7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700065B RID: 1627
			// (get) Token: 0x060017D1 RID: 6097 RVA: 0x0007B688 File Offset: 0x00079888
			// (set) Token: 0x060017D2 RID: 6098 RVA: 0x00009FC2 File Offset: 0x000081C2
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700065C RID: 1628
			// (get) Token: 0x060017D3 RID: 6099 RVA: 0x0007B6B8 File Offset: 0x000798B8
			// (set) Token: 0x060017D4 RID: 6100 RVA: 0x00009FF0 File Offset: 0x000081F0
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700065D RID: 1629
			// (get) Token: 0x060017D5 RID: 6101 RVA: 0x0007B6E8 File Offset: 0x000798E8
			// (set) Token: 0x060017D6 RID: 6102 RVA: 0x0000A00F File Offset: 0x0000820F
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700065E RID: 1630
			// (get) Token: 0x060017D7 RID: 6103 RVA: 0x0007B718 File Offset: 0x00079918
			// (set) Token: 0x060017D8 RID: 6104 RVA: 0x0000A03D File Offset: 0x0000823D
			public unsafe bool setToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr_setToken);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr_setToken)) = value;
				}
			}

			// Token: 0x1700065F RID: 1631
			// (get) Token: 0x060017D9 RID: 6105 RVA: 0x0007B740 File Offset: 0x00079940
			// (set) Token: 0x060017DA RID: 6106 RVA: 0x0000A058 File Offset: 0x00008258
			public unsafe bool _singlelineComment_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr__singlelineComment_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr__singlelineComment_5__2)) = value;
				}
			}

			// Token: 0x17000660 RID: 1632
			// (get) Token: 0x060017DB RID: 6107 RVA: 0x0007B768 File Offset: 0x00079968
			// (set) Token: 0x060017DC RID: 6108 RVA: 0x0000A073 File Offset: 0x00008273
			public unsafe int _initialPosition_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr__initialPosition_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr__initialPosition_5__3)) = value;
				}
			}

			// Token: 0x17000661 RID: 1633
			// (get) Token: 0x060017DD RID: 6109 RVA: 0x0007B790 File Offset: 0x00079990
			// (set) Token: 0x060017DE RID: 6110 RVA: 0x0000A08E File Offset: 0x0000828E
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000662 RID: 1634
			// (get) Token: 0x060017DF RID: 6111 RVA: 0x0007B7C0 File Offset: 0x000799C0
			// (set) Token: 0x060017E0 RID: 6112 RVA: 0x0000A0BC File Offset: 0x000082BC
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000663 RID: 1635
			// (get) Token: 0x060017E1 RID: 6113 RVA: 0x0007B7F0 File Offset: 0x000799F0
			// (set) Token: 0x060017E2 RID: 6114 RVA: 0x0000A0EA File Offset: 0x000082EA
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr___u__3);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseCommentAsync_d__16.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040012CC RID: 4812
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040012CD RID: 4813
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040012CE RID: 4814
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040012CF RID: 4815
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040012D0 RID: 4816
			private static readonly IntPtr NativeFieldInfoPtr_setToken;

			// Token: 0x040012D1 RID: 4817
			private static readonly IntPtr NativeFieldInfoPtr__singlelineComment_5__2;

			// Token: 0x040012D2 RID: 4818
			private static readonly IntPtr NativeFieldInfoPtr__initialPosition_5__3;

			// Token: 0x040012D3 RID: 4819
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040012D4 RID: 4820
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040012D5 RID: 4821
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x040012D6 RID: 4822
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040012D7 RID: 4823
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200012F RID: 303
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<ParseConstructorAsync>d__25")]
		public sealed class _ParseConstructorAsync_d__25 : ValueType
		{
			// Token: 0x060017E3 RID: 6115 RVA: 0x0007B820 File Offset: 0x00079A20
			// Note: this type is marked as 'beforefieldinit'.
			static _ParseConstructorAsync_d__25()
			{
				Il2CppClassPointerStore<JsonTextReader._ParseConstructorAsync_d__25>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<ParseConstructorAsync>d__25");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._ParseConstructorAsync_d__25>.NativeClassPtr);
				JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseConstructorAsync_d__25>.NativeClassPtr, "<>1__state");
				JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseConstructorAsync_d__25>.NativeClassPtr, "<>t__builder");
				JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseConstructorAsync_d__25>.NativeClassPtr, "<>4__this");
				JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseConstructorAsync_d__25>.NativeClassPtr, "cancellationToken");
				JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseConstructorAsync_d__25>.NativeClassPtr, "<>u__1");
				JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr__initialPosition_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseConstructorAsync_d__25>.NativeClassPtr, "<initialPosition>5__2");
				JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr__endPosition_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseConstructorAsync_d__25>.NativeClassPtr, "<endPosition>5__3");
				JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr__constructorName_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseConstructorAsync_d__25>.NativeClassPtr, "<constructorName>5__4");
				JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseConstructorAsync_d__25>.NativeClassPtr, "<>u__2");
				JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseConstructorAsync_d__25>.NativeClassPtr, "<>u__3");
				JsonTextReader._ParseConstructorAsync_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ParseConstructorAsync_d__25>.NativeClassPtr, 100663947);
				JsonTextReader._ParseConstructorAsync_d__25.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ParseConstructorAsync_d__25>.NativeClassPtr, 100663948);
			}

			// Token: 0x060017E4 RID: 6116 RVA: 0x0007B93C File Offset: 0x00079B3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730854, XrefRangeEnd = 730925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ParseConstructorAsync_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017E5 RID: 6117 RVA: 0x0007B974 File Offset: 0x00079B74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730925, XrefRangeEnd = 730929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ParseConstructorAsync_d__25.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017E6 RID: 6118 RVA: 0x0000A118 File Offset: 0x00008318
			public _ParseConstructorAsync_d__25(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060017E7 RID: 6119 RVA: 0x0000A121 File Offset: 0x00008321
			public _ParseConstructorAsync_d__25()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._ParseConstructorAsync_d__25>.NativeClassPtr))
			{
			}

			// Token: 0x17000664 RID: 1636
			// (get) Token: 0x060017E8 RID: 6120 RVA: 0x0007B9BC File Offset: 0x00079BBC
			// (set) Token: 0x060017E9 RID: 6121 RVA: 0x0000A133 File Offset: 0x00008333
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000665 RID: 1637
			// (get) Token: 0x060017EA RID: 6122 RVA: 0x0007B9E4 File Offset: 0x00079BE4
			// (set) Token: 0x060017EB RID: 6123 RVA: 0x0000A14E File Offset: 0x0000834E
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000666 RID: 1638
			// (get) Token: 0x060017EC RID: 6124 RVA: 0x0007BA14 File Offset: 0x00079C14
			// (set) Token: 0x060017ED RID: 6125 RVA: 0x0000A17C File Offset: 0x0000837C
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000667 RID: 1639
			// (get) Token: 0x060017EE RID: 6126 RVA: 0x0007BA44 File Offset: 0x00079C44
			// (set) Token: 0x060017EF RID: 6127 RVA: 0x0000A19B File Offset: 0x0000839B
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000668 RID: 1640
			// (get) Token: 0x060017F0 RID: 6128 RVA: 0x0007BA74 File Offset: 0x00079C74
			// (set) Token: 0x060017F1 RID: 6129 RVA: 0x0000A1C9 File Offset: 0x000083C9
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000669 RID: 1641
			// (get) Token: 0x060017F2 RID: 6130 RVA: 0x0007BAA4 File Offset: 0x00079CA4
			// (set) Token: 0x060017F3 RID: 6131 RVA: 0x0000A1F7 File Offset: 0x000083F7
			public unsafe int _initialPosition_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr__initialPosition_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr__initialPosition_5__2)) = value;
				}
			}

			// Token: 0x1700066A RID: 1642
			// (get) Token: 0x060017F4 RID: 6132 RVA: 0x0007BACC File Offset: 0x00079CCC
			// (set) Token: 0x060017F5 RID: 6133 RVA: 0x0000A212 File Offset: 0x00008412
			public unsafe int _endPosition_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr__endPosition_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr__endPosition_5__3)) = value;
				}
			}

			// Token: 0x1700066B RID: 1643
			// (get) Token: 0x060017F6 RID: 6134 RVA: 0x0007BAF4 File Offset: 0x00079CF4
			// (set) Token: 0x060017F7 RID: 6135 RVA: 0x0000A22D File Offset: 0x0000842D
			public unsafe string _constructorName_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr__constructorName_5__4);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr__constructorName_5__4), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700066C RID: 1644
			// (get) Token: 0x060017F8 RID: 6136 RVA: 0x0007BB1C File Offset: 0x00079D1C
			// (set) Token: 0x060017F9 RID: 6137 RVA: 0x0000A24C File Offset: 0x0000844C
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700066D RID: 1645
			// (get) Token: 0x060017FA RID: 6138 RVA: 0x0007BB4C File Offset: 0x00079D4C
			// (set) Token: 0x060017FB RID: 6139 RVA: 0x0000A27A File Offset: 0x0000847A
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr___u__3);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseConstructorAsync_d__25.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040012D8 RID: 4824
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040012D9 RID: 4825
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040012DA RID: 4826
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040012DB RID: 4827
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040012DC RID: 4828
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040012DD RID: 4829
			private static readonly IntPtr NativeFieldInfoPtr__initialPosition_5__2;

			// Token: 0x040012DE RID: 4830
			private static readonly IntPtr NativeFieldInfoPtr__endPosition_5__3;

			// Token: 0x040012DF RID: 4831
			private static readonly IntPtr NativeFieldInfoPtr__constructorName_5__4;

			// Token: 0x040012E0 RID: 4832
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040012E1 RID: 4833
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x040012E2 RID: 4834
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040012E3 RID: 4835
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000130 RID: 304
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<ParseNumberAsync>d__29")]
		public sealed class _ParseNumberAsync_d__29 : ValueType
		{
			// Token: 0x060017FC RID: 6140 RVA: 0x0007BB7C File Offset: 0x00079D7C
			// Note: this type is marked as 'beforefieldinit'.
			static _ParseNumberAsync_d__29()
			{
				Il2CppClassPointerStore<JsonTextReader._ParseNumberAsync_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<ParseNumberAsync>d__29");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._ParseNumberAsync_d__29>.NativeClassPtr);
				JsonTextReader._ParseNumberAsync_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberAsync_d__29>.NativeClassPtr, "<>1__state");
				JsonTextReader._ParseNumberAsync_d__29.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberAsync_d__29>.NativeClassPtr, "<>t__builder");
				JsonTextReader._ParseNumberAsync_d__29.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberAsync_d__29>.NativeClassPtr, "<>4__this");
				JsonTextReader._ParseNumberAsync_d__29.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberAsync_d__29>.NativeClassPtr, "cancellationToken");
				JsonTextReader._ParseNumberAsync_d__29.NativeFieldInfoPtr_readType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberAsync_d__29>.NativeClassPtr, "readType");
				JsonTextReader._ParseNumberAsync_d__29.NativeFieldInfoPtr__firstChar_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberAsync_d__29>.NativeClassPtr, "<firstChar>5__2");
				JsonTextReader._ParseNumberAsync_d__29.NativeFieldInfoPtr__initialPosition_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberAsync_d__29>.NativeClassPtr, "<initialPosition>5__3");
				JsonTextReader._ParseNumberAsync_d__29.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberAsync_d__29>.NativeClassPtr, "<>u__1");
				JsonTextReader._ParseNumberAsync_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ParseNumberAsync_d__29>.NativeClassPtr, 100663949);
				JsonTextReader._ParseNumberAsync_d__29.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ParseNumberAsync_d__29>.NativeClassPtr, 100663950);
			}

			// Token: 0x060017FD RID: 6141 RVA: 0x0007BC70 File Offset: 0x00079E70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730929, XrefRangeEnd = 730941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ParseNumberAsync_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017FE RID: 6142 RVA: 0x0007BCA8 File Offset: 0x00079EA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730941, XrefRangeEnd = 730945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ParseNumberAsync_d__29.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017FF RID: 6143 RVA: 0x0000A2A8 File Offset: 0x000084A8
			public _ParseNumberAsync_d__29(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001800 RID: 6144 RVA: 0x0000A2B1 File Offset: 0x000084B1
			public _ParseNumberAsync_d__29()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._ParseNumberAsync_d__29>.NativeClassPtr))
			{
			}

			// Token: 0x1700066E RID: 1646
			// (get) Token: 0x06001801 RID: 6145 RVA: 0x0007BCF0 File Offset: 0x00079EF0
			// (set) Token: 0x06001802 RID: 6146 RVA: 0x0000A2C3 File Offset: 0x000084C3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberAsync_d__29.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberAsync_d__29.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700066F RID: 1647
			// (get) Token: 0x06001803 RID: 6147 RVA: 0x0007BD18 File Offset: 0x00079F18
			// (set) Token: 0x06001804 RID: 6148 RVA: 0x0000A2DE File Offset: 0x000084DE
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberAsync_d__29.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberAsync_d__29.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000670 RID: 1648
			// (get) Token: 0x06001805 RID: 6149 RVA: 0x0007BD48 File Offset: 0x00079F48
			// (set) Token: 0x06001806 RID: 6150 RVA: 0x0000A30C File Offset: 0x0000850C
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberAsync_d__29.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberAsync_d__29.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000671 RID: 1649
			// (get) Token: 0x06001807 RID: 6151 RVA: 0x0007BD78 File Offset: 0x00079F78
			// (set) Token: 0x06001808 RID: 6152 RVA: 0x0000A32B File Offset: 0x0000852B
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberAsync_d__29.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberAsync_d__29.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000672 RID: 1650
			// (get) Token: 0x06001809 RID: 6153 RVA: 0x0007BDA8 File Offset: 0x00079FA8
			// (set) Token: 0x0600180A RID: 6154 RVA: 0x0000A359 File Offset: 0x00008559
			public unsafe ReadType readType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberAsync_d__29.NativeFieldInfoPtr_readType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberAsync_d__29.NativeFieldInfoPtr_readType)) = value;
				}
			}

			// Token: 0x17000673 RID: 1651
			// (get) Token: 0x0600180B RID: 6155 RVA: 0x0007BDD0 File Offset: 0x00079FD0
			// (set) Token: 0x0600180C RID: 6156 RVA: 0x0000A374 File Offset: 0x00008574
			public unsafe char _firstChar_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberAsync_d__29.NativeFieldInfoPtr__firstChar_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberAsync_d__29.NativeFieldInfoPtr__firstChar_5__2)) = value;
				}
			}

			// Token: 0x17000674 RID: 1652
			// (get) Token: 0x0600180D RID: 6157 RVA: 0x0007BDF8 File Offset: 0x00079FF8
			// (set) Token: 0x0600180E RID: 6158 RVA: 0x0000A38F File Offset: 0x0000858F
			public unsafe int _initialPosition_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberAsync_d__29.NativeFieldInfoPtr__initialPosition_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberAsync_d__29.NativeFieldInfoPtr__initialPosition_5__3)) = value;
				}
			}

			// Token: 0x17000675 RID: 1653
			// (get) Token: 0x0600180F RID: 6159 RVA: 0x0007BE20 File Offset: 0x0007A020
			// (set) Token: 0x06001810 RID: 6160 RVA: 0x0000A3AA File Offset: 0x000085AA
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberAsync_d__29.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberAsync_d__29.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040012E4 RID: 4836
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040012E5 RID: 4837
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040012E6 RID: 4838
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040012E7 RID: 4839
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040012E8 RID: 4840
			private static readonly IntPtr NativeFieldInfoPtr_readType;

			// Token: 0x040012E9 RID: 4841
			private static readonly IntPtr NativeFieldInfoPtr__firstChar_5__2;

			// Token: 0x040012EA RID: 4842
			private static readonly IntPtr NativeFieldInfoPtr__initialPosition_5__3;

			// Token: 0x040012EB RID: 4843
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040012EC RID: 4844
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040012ED RID: 4845
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000131 RID: 305
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<ParseNumberNaNAsync>d__26")]
		public sealed class _ParseNumberNaNAsync_d__26 : ValueType
		{
			// Token: 0x06001811 RID: 6161 RVA: 0x0007BE50 File Offset: 0x0007A050
			// Note: this type is marked as 'beforefieldinit'.
			static _ParseNumberNaNAsync_d__26()
			{
				Il2CppClassPointerStore<JsonTextReader._ParseNumberNaNAsync_d__26>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<ParseNumberNaNAsync>d__26");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._ParseNumberNaNAsync_d__26>.NativeClassPtr);
				JsonTextReader._ParseNumberNaNAsync_d__26.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberNaNAsync_d__26>.NativeClassPtr, "<>1__state");
				JsonTextReader._ParseNumberNaNAsync_d__26.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberNaNAsync_d__26>.NativeClassPtr, "<>t__builder");
				JsonTextReader._ParseNumberNaNAsync_d__26.NativeFieldInfoPtr_readType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberNaNAsync_d__26>.NativeClassPtr, "readType");
				JsonTextReader._ParseNumberNaNAsync_d__26.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberNaNAsync_d__26>.NativeClassPtr, "<>4__this");
				JsonTextReader._ParseNumberNaNAsync_d__26.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberNaNAsync_d__26>.NativeClassPtr, "cancellationToken");
				JsonTextReader._ParseNumberNaNAsync_d__26.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberNaNAsync_d__26>.NativeClassPtr, "<>7__wrap1");
				JsonTextReader._ParseNumberNaNAsync_d__26.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberNaNAsync_d__26>.NativeClassPtr, "<>u__1");
				JsonTextReader._ParseNumberNaNAsync_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ParseNumberNaNAsync_d__26>.NativeClassPtr, 100663951);
				JsonTextReader._ParseNumberNaNAsync_d__26.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ParseNumberNaNAsync_d__26>.NativeClassPtr, 100663952);
			}

			// Token: 0x06001812 RID: 6162 RVA: 0x0007BF30 File Offset: 0x0007A130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730945, XrefRangeEnd = 730969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ParseNumberNaNAsync_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001813 RID: 6163 RVA: 0x0007BF68 File Offset: 0x0007A168
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730969, XrefRangeEnd = 730975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ParseNumberNaNAsync_d__26.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001814 RID: 6164 RVA: 0x0000A3D8 File Offset: 0x000085D8
			public _ParseNumberNaNAsync_d__26(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001815 RID: 6165 RVA: 0x0000A3E1 File Offset: 0x000085E1
			public _ParseNumberNaNAsync_d__26()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._ParseNumberNaNAsync_d__26>.NativeClassPtr))
			{
			}

			// Token: 0x17000676 RID: 1654
			// (get) Token: 0x06001816 RID: 6166 RVA: 0x0007BFB0 File Offset: 0x0007A1B0
			// (set) Token: 0x06001817 RID: 6167 RVA: 0x0000A3F3 File Offset: 0x000085F3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNaNAsync_d__26.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNaNAsync_d__26.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000677 RID: 1655
			// (get) Token: 0x06001818 RID: 6168 RVA: 0x0007BFD8 File Offset: 0x0007A1D8
			// (set) Token: 0x06001819 RID: 6169 RVA: 0x0000A40E File Offset: 0x0000860E
			public AsyncTaskMethodBuilder<Object> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNaNAsync_d__26.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNaNAsync_d__26.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000678 RID: 1656
			// (get) Token: 0x0600181A RID: 6170 RVA: 0x0007C008 File Offset: 0x0007A208
			// (set) Token: 0x0600181B RID: 6171 RVA: 0x0000A43C File Offset: 0x0000863C
			public unsafe ReadType readType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNaNAsync_d__26.NativeFieldInfoPtr_readType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNaNAsync_d__26.NativeFieldInfoPtr_readType)) = value;
				}
			}

			// Token: 0x17000679 RID: 1657
			// (get) Token: 0x0600181C RID: 6172 RVA: 0x0007C030 File Offset: 0x0007A230
			// (set) Token: 0x0600181D RID: 6173 RVA: 0x0000A457 File Offset: 0x00008657
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNaNAsync_d__26.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNaNAsync_d__26.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700067A RID: 1658
			// (get) Token: 0x0600181E RID: 6174 RVA: 0x0007C060 File Offset: 0x0007A260
			// (set) Token: 0x0600181F RID: 6175 RVA: 0x0000A476 File Offset: 0x00008676
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNaNAsync_d__26.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNaNAsync_d__26.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700067B RID: 1659
			// (get) Token: 0x06001820 RID: 6176 RVA: 0x0007C090 File Offset: 0x0007A290
			// (set) Token: 0x06001821 RID: 6177 RVA: 0x0000A4A4 File Offset: 0x000086A4
			public unsafe ReadType __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNaNAsync_d__26.NativeFieldInfoPtr___7__wrap1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNaNAsync_d__26.NativeFieldInfoPtr___7__wrap1)) = value;
				}
			}

			// Token: 0x1700067C RID: 1660
			// (get) Token: 0x06001822 RID: 6178 RVA: 0x0007C0B8 File Offset: 0x0007A2B8
			// (set) Token: 0x06001823 RID: 6179 RVA: 0x0000A4BF File Offset: 0x000086BF
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNaNAsync_d__26.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNaNAsync_d__26.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040012EE RID: 4846
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040012EF RID: 4847
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040012F0 RID: 4848
			private static readonly IntPtr NativeFieldInfoPtr_readType;

			// Token: 0x040012F1 RID: 4849
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040012F2 RID: 4850
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040012F3 RID: 4851
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040012F4 RID: 4852
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040012F5 RID: 4853
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040012F6 RID: 4854
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000132 RID: 306
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<ParseNumberNegativeInfinityAsync>d__28")]
		public sealed class _ParseNumberNegativeInfinityAsync_d__28 : ValueType
		{
			// Token: 0x06001824 RID: 6180 RVA: 0x0007C0E8 File Offset: 0x0007A2E8
			// Note: this type is marked as 'beforefieldinit'.
			static _ParseNumberNegativeInfinityAsync_d__28()
			{
				Il2CppClassPointerStore<JsonTextReader._ParseNumberNegativeInfinityAsync_d__28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<ParseNumberNegativeInfinityAsync>d__28");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._ParseNumberNegativeInfinityAsync_d__28>.NativeClassPtr);
				JsonTextReader._ParseNumberNegativeInfinityAsync_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberNegativeInfinityAsync_d__28>.NativeClassPtr, "<>1__state");
				JsonTextReader._ParseNumberNegativeInfinityAsync_d__28.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberNegativeInfinityAsync_d__28>.NativeClassPtr, "<>t__builder");
				JsonTextReader._ParseNumberNegativeInfinityAsync_d__28.NativeFieldInfoPtr_readType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberNegativeInfinityAsync_d__28>.NativeClassPtr, "readType");
				JsonTextReader._ParseNumberNegativeInfinityAsync_d__28.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberNegativeInfinityAsync_d__28>.NativeClassPtr, "<>4__this");
				JsonTextReader._ParseNumberNegativeInfinityAsync_d__28.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberNegativeInfinityAsync_d__28>.NativeClassPtr, "cancellationToken");
				JsonTextReader._ParseNumberNegativeInfinityAsync_d__28.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberNegativeInfinityAsync_d__28>.NativeClassPtr, "<>7__wrap1");
				JsonTextReader._ParseNumberNegativeInfinityAsync_d__28.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberNegativeInfinityAsync_d__28>.NativeClassPtr, "<>u__1");
				JsonTextReader._ParseNumberNegativeInfinityAsync_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ParseNumberNegativeInfinityAsync_d__28>.NativeClassPtr, 100663953);
				JsonTextReader._ParseNumberNegativeInfinityAsync_d__28.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ParseNumberNegativeInfinityAsync_d__28>.NativeClassPtr, 100663954);
			}

			// Token: 0x06001825 RID: 6181 RVA: 0x0007C1C8 File Offset: 0x0007A3C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730975, XrefRangeEnd = 730999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ParseNumberNegativeInfinityAsync_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001826 RID: 6182 RVA: 0x0007C200 File Offset: 0x0007A400
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730999, XrefRangeEnd = 731005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ParseNumberNegativeInfinityAsync_d__28.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001827 RID: 6183 RVA: 0x0000A4ED File Offset: 0x000086ED
			public _ParseNumberNegativeInfinityAsync_d__28(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001828 RID: 6184 RVA: 0x0000A4F6 File Offset: 0x000086F6
			public _ParseNumberNegativeInfinityAsync_d__28()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._ParseNumberNegativeInfinityAsync_d__28>.NativeClassPtr))
			{
			}

			// Token: 0x1700067D RID: 1661
			// (get) Token: 0x06001829 RID: 6185 RVA: 0x0007C248 File Offset: 0x0007A448
			// (set) Token: 0x0600182A RID: 6186 RVA: 0x0000A508 File Offset: 0x00008708
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNegativeInfinityAsync_d__28.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNegativeInfinityAsync_d__28.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700067E RID: 1662
			// (get) Token: 0x0600182B RID: 6187 RVA: 0x0007C270 File Offset: 0x0007A470
			// (set) Token: 0x0600182C RID: 6188 RVA: 0x0000A523 File Offset: 0x00008723
			public AsyncTaskMethodBuilder<Object> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNegativeInfinityAsync_d__28.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNegativeInfinityAsync_d__28.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700067F RID: 1663
			// (get) Token: 0x0600182D RID: 6189 RVA: 0x0007C2A0 File Offset: 0x0007A4A0
			// (set) Token: 0x0600182E RID: 6190 RVA: 0x0000A551 File Offset: 0x00008751
			public unsafe ReadType readType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNegativeInfinityAsync_d__28.NativeFieldInfoPtr_readType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNegativeInfinityAsync_d__28.NativeFieldInfoPtr_readType)) = value;
				}
			}

			// Token: 0x17000680 RID: 1664
			// (get) Token: 0x0600182F RID: 6191 RVA: 0x0007C2C8 File Offset: 0x0007A4C8
			// (set) Token: 0x06001830 RID: 6192 RVA: 0x0000A56C File Offset: 0x0000876C
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNegativeInfinityAsync_d__28.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNegativeInfinityAsync_d__28.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000681 RID: 1665
			// (get) Token: 0x06001831 RID: 6193 RVA: 0x0007C2F8 File Offset: 0x0007A4F8
			// (set) Token: 0x06001832 RID: 6194 RVA: 0x0000A58B File Offset: 0x0000878B
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNegativeInfinityAsync_d__28.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNegativeInfinityAsync_d__28.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000682 RID: 1666
			// (get) Token: 0x06001833 RID: 6195 RVA: 0x0007C328 File Offset: 0x0007A528
			// (set) Token: 0x06001834 RID: 6196 RVA: 0x0000A5B9 File Offset: 0x000087B9
			public unsafe ReadType __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNegativeInfinityAsync_d__28.NativeFieldInfoPtr___7__wrap1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNegativeInfinityAsync_d__28.NativeFieldInfoPtr___7__wrap1)) = value;
				}
			}

			// Token: 0x17000683 RID: 1667
			// (get) Token: 0x06001835 RID: 6197 RVA: 0x0007C350 File Offset: 0x0007A550
			// (set) Token: 0x06001836 RID: 6198 RVA: 0x0000A5D4 File Offset: 0x000087D4
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNegativeInfinityAsync_d__28.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberNegativeInfinityAsync_d__28.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040012F7 RID: 4855
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040012F8 RID: 4856
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040012F9 RID: 4857
			private static readonly IntPtr NativeFieldInfoPtr_readType;

			// Token: 0x040012FA RID: 4858
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040012FB RID: 4859
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040012FC RID: 4860
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040012FD RID: 4861
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040012FE RID: 4862
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040012FF RID: 4863
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000133 RID: 307
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<ParseNumberPositiveInfinityAsync>d__27")]
		public sealed class _ParseNumberPositiveInfinityAsync_d__27 : ValueType
		{
			// Token: 0x06001837 RID: 6199 RVA: 0x0007C380 File Offset: 0x0007A580
			// Note: this type is marked as 'beforefieldinit'.
			static _ParseNumberPositiveInfinityAsync_d__27()
			{
				Il2CppClassPointerStore<JsonTextReader._ParseNumberPositiveInfinityAsync_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<ParseNumberPositiveInfinityAsync>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._ParseNumberPositiveInfinityAsync_d__27>.NativeClassPtr);
				JsonTextReader._ParseNumberPositiveInfinityAsync_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberPositiveInfinityAsync_d__27>.NativeClassPtr, "<>1__state");
				JsonTextReader._ParseNumberPositiveInfinityAsync_d__27.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberPositiveInfinityAsync_d__27>.NativeClassPtr, "<>t__builder");
				JsonTextReader._ParseNumberPositiveInfinityAsync_d__27.NativeFieldInfoPtr_readType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberPositiveInfinityAsync_d__27>.NativeClassPtr, "readType");
				JsonTextReader._ParseNumberPositiveInfinityAsync_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberPositiveInfinityAsync_d__27>.NativeClassPtr, "<>4__this");
				JsonTextReader._ParseNumberPositiveInfinityAsync_d__27.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberPositiveInfinityAsync_d__27>.NativeClassPtr, "cancellationToken");
				JsonTextReader._ParseNumberPositiveInfinityAsync_d__27.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberPositiveInfinityAsync_d__27>.NativeClassPtr, "<>7__wrap1");
				JsonTextReader._ParseNumberPositiveInfinityAsync_d__27.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseNumberPositiveInfinityAsync_d__27>.NativeClassPtr, "<>u__1");
				JsonTextReader._ParseNumberPositiveInfinityAsync_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ParseNumberPositiveInfinityAsync_d__27>.NativeClassPtr, 100663955);
				JsonTextReader._ParseNumberPositiveInfinityAsync_d__27.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ParseNumberPositiveInfinityAsync_d__27>.NativeClassPtr, 100663956);
			}

			// Token: 0x06001838 RID: 6200 RVA: 0x0007C460 File Offset: 0x0007A660
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731005, XrefRangeEnd = 731029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ParseNumberPositiveInfinityAsync_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001839 RID: 6201 RVA: 0x0007C498 File Offset: 0x0007A698
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731029, XrefRangeEnd = 731035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ParseNumberPositiveInfinityAsync_d__27.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600183A RID: 6202 RVA: 0x0000A602 File Offset: 0x00008802
			public _ParseNumberPositiveInfinityAsync_d__27(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600183B RID: 6203 RVA: 0x0000A60B File Offset: 0x0000880B
			public _ParseNumberPositiveInfinityAsync_d__27()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._ParseNumberPositiveInfinityAsync_d__27>.NativeClassPtr))
			{
			}

			// Token: 0x17000684 RID: 1668
			// (get) Token: 0x0600183C RID: 6204 RVA: 0x0007C4E0 File Offset: 0x0007A6E0
			// (set) Token: 0x0600183D RID: 6205 RVA: 0x0000A61D File Offset: 0x0000881D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberPositiveInfinityAsync_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberPositiveInfinityAsync_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000685 RID: 1669
			// (get) Token: 0x0600183E RID: 6206 RVA: 0x0007C508 File Offset: 0x0007A708
			// (set) Token: 0x0600183F RID: 6207 RVA: 0x0000A638 File Offset: 0x00008838
			public AsyncTaskMethodBuilder<Object> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberPositiveInfinityAsync_d__27.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberPositiveInfinityAsync_d__27.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000686 RID: 1670
			// (get) Token: 0x06001840 RID: 6208 RVA: 0x0007C538 File Offset: 0x0007A738
			// (set) Token: 0x06001841 RID: 6209 RVA: 0x0000A666 File Offset: 0x00008866
			public unsafe ReadType readType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberPositiveInfinityAsync_d__27.NativeFieldInfoPtr_readType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberPositiveInfinityAsync_d__27.NativeFieldInfoPtr_readType)) = value;
				}
			}

			// Token: 0x17000687 RID: 1671
			// (get) Token: 0x06001842 RID: 6210 RVA: 0x0007C560 File Offset: 0x0007A760
			// (set) Token: 0x06001843 RID: 6211 RVA: 0x0000A681 File Offset: 0x00008881
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberPositiveInfinityAsync_d__27.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberPositiveInfinityAsync_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000688 RID: 1672
			// (get) Token: 0x06001844 RID: 6212 RVA: 0x0007C590 File Offset: 0x0007A790
			// (set) Token: 0x06001845 RID: 6213 RVA: 0x0000A6A0 File Offset: 0x000088A0
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberPositiveInfinityAsync_d__27.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberPositiveInfinityAsync_d__27.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000689 RID: 1673
			// (get) Token: 0x06001846 RID: 6214 RVA: 0x0007C5C0 File Offset: 0x0007A7C0
			// (set) Token: 0x06001847 RID: 6215 RVA: 0x0000A6CE File Offset: 0x000088CE
			public unsafe ReadType __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberPositiveInfinityAsync_d__27.NativeFieldInfoPtr___7__wrap1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberPositiveInfinityAsync_d__27.NativeFieldInfoPtr___7__wrap1)) = value;
				}
			}

			// Token: 0x1700068A RID: 1674
			// (get) Token: 0x06001848 RID: 6216 RVA: 0x0007C5E8 File Offset: 0x0007A7E8
			// (set) Token: 0x06001849 RID: 6217 RVA: 0x0000A6E9 File Offset: 0x000088E9
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberPositiveInfinityAsync_d__27.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseNumberPositiveInfinityAsync_d__27.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001300 RID: 4864
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001301 RID: 4865
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001302 RID: 4866
			private static readonly IntPtr NativeFieldInfoPtr_readType;

			// Token: 0x04001303 RID: 4867
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001304 RID: 4868
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001305 RID: 4869
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001306 RID: 4870
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001307 RID: 4871
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001308 RID: 4872
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000134 RID: 308
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<ParseObjectAsync>d__15")]
		public sealed class _ParseObjectAsync_d__15 : ValueType
		{
			// Token: 0x0600184A RID: 6218 RVA: 0x0007C618 File Offset: 0x0007A818
			// Note: this type is marked as 'beforefieldinit'.
			static _ParseObjectAsync_d__15()
			{
				Il2CppClassPointerStore<JsonTextReader._ParseObjectAsync_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<ParseObjectAsync>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._ParseObjectAsync_d__15>.NativeClassPtr);
				JsonTextReader._ParseObjectAsync_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseObjectAsync_d__15>.NativeClassPtr, "<>1__state");
				JsonTextReader._ParseObjectAsync_d__15.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseObjectAsync_d__15>.NativeClassPtr, "<>t__builder");
				JsonTextReader._ParseObjectAsync_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseObjectAsync_d__15>.NativeClassPtr, "<>4__this");
				JsonTextReader._ParseObjectAsync_d__15.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseObjectAsync_d__15>.NativeClassPtr, "cancellationToken");
				JsonTextReader._ParseObjectAsync_d__15.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseObjectAsync_d__15>.NativeClassPtr, "<>u__1");
				JsonTextReader._ParseObjectAsync_d__15.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseObjectAsync_d__15>.NativeClassPtr, "<>u__2");
				JsonTextReader._ParseObjectAsync_d__15.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseObjectAsync_d__15>.NativeClassPtr, "<>u__3");
				JsonTextReader._ParseObjectAsync_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ParseObjectAsync_d__15>.NativeClassPtr, 100663957);
				JsonTextReader._ParseObjectAsync_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ParseObjectAsync_d__15>.NativeClassPtr, 100663958);
			}

			// Token: 0x0600184B RID: 6219 RVA: 0x0007C6F8 File Offset: 0x0007A8F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731035, XrefRangeEnd = 731113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ParseObjectAsync_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600184C RID: 6220 RVA: 0x0007C730 File Offset: 0x0007A930
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731113, XrefRangeEnd = 731119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ParseObjectAsync_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600184D RID: 6221 RVA: 0x0000A717 File Offset: 0x00008917
			public _ParseObjectAsync_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600184E RID: 6222 RVA: 0x0000A720 File Offset: 0x00008920
			public _ParseObjectAsync_d__15()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._ParseObjectAsync_d__15>.NativeClassPtr))
			{
			}

			// Token: 0x1700068B RID: 1675
			// (get) Token: 0x0600184F RID: 6223 RVA: 0x0007C778 File Offset: 0x0007A978
			// (set) Token: 0x06001850 RID: 6224 RVA: 0x0000A732 File Offset: 0x00008932
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseObjectAsync_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseObjectAsync_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700068C RID: 1676
			// (get) Token: 0x06001851 RID: 6225 RVA: 0x0007C7A0 File Offset: 0x0007A9A0
			// (set) Token: 0x06001852 RID: 6226 RVA: 0x0000A74D File Offset: 0x0000894D
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseObjectAsync_d__15.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseObjectAsync_d__15.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700068D RID: 1677
			// (get) Token: 0x06001853 RID: 6227 RVA: 0x0007C7D0 File Offset: 0x0007A9D0
			// (set) Token: 0x06001854 RID: 6228 RVA: 0x0000A77B File Offset: 0x0000897B
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseObjectAsync_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseObjectAsync_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700068E RID: 1678
			// (get) Token: 0x06001855 RID: 6229 RVA: 0x0007C800 File Offset: 0x0007AA00
			// (set) Token: 0x06001856 RID: 6230 RVA: 0x0000A79A File Offset: 0x0000899A
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseObjectAsync_d__15.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseObjectAsync_d__15.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700068F RID: 1679
			// (get) Token: 0x06001857 RID: 6231 RVA: 0x0007C830 File Offset: 0x0007AA30
			// (set) Token: 0x06001858 RID: 6232 RVA: 0x0000A7C8 File Offset: 0x000089C8
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseObjectAsync_d__15.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseObjectAsync_d__15.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000690 RID: 1680
			// (get) Token: 0x06001859 RID: 6233 RVA: 0x0007C860 File Offset: 0x0007AA60
			// (set) Token: 0x0600185A RID: 6234 RVA: 0x0000A7F6 File Offset: 0x000089F6
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseObjectAsync_d__15.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseObjectAsync_d__15.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000691 RID: 1681
			// (get) Token: 0x0600185B RID: 6235 RVA: 0x0007C890 File Offset: 0x0007AA90
			// (set) Token: 0x0600185C RID: 6236 RVA: 0x0000A824 File Offset: 0x00008A24
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseObjectAsync_d__15.NativeFieldInfoPtr___u__3);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseObjectAsync_d__15.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001309 RID: 4873
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400130A RID: 4874
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400130B RID: 4875
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400130C RID: 4876
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400130D RID: 4877
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400130E RID: 4878
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400130F RID: 4879
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x04001310 RID: 4880
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001311 RID: 4881
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000135 RID: 309
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<ParsePostValueAsync>d__4")]
		public sealed class _ParsePostValueAsync_d__4 : ValueType
		{
			// Token: 0x0600185D RID: 6237 RVA: 0x0007C8C0 File Offset: 0x0007AAC0
			// Note: this type is marked as 'beforefieldinit'.
			static _ParsePostValueAsync_d__4()
			{
				Il2CppClassPointerStore<JsonTextReader._ParsePostValueAsync_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<ParsePostValueAsync>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._ParsePostValueAsync_d__4>.NativeClassPtr);
				JsonTextReader._ParsePostValueAsync_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParsePostValueAsync_d__4>.NativeClassPtr, "<>1__state");
				JsonTextReader._ParsePostValueAsync_d__4.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParsePostValueAsync_d__4>.NativeClassPtr, "<>t__builder");
				JsonTextReader._ParsePostValueAsync_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParsePostValueAsync_d__4>.NativeClassPtr, "<>4__this");
				JsonTextReader._ParsePostValueAsync_d__4.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParsePostValueAsync_d__4>.NativeClassPtr, "cancellationToken");
				JsonTextReader._ParsePostValueAsync_d__4.NativeFieldInfoPtr_ignoreComments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParsePostValueAsync_d__4>.NativeClassPtr, "ignoreComments");
				JsonTextReader._ParsePostValueAsync_d__4.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParsePostValueAsync_d__4>.NativeClassPtr, "<>u__1");
				JsonTextReader._ParsePostValueAsync_d__4.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParsePostValueAsync_d__4>.NativeClassPtr, "<>u__2");
				JsonTextReader._ParsePostValueAsync_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ParsePostValueAsync_d__4>.NativeClassPtr, 100663959);
				JsonTextReader._ParsePostValueAsync_d__4.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ParsePostValueAsync_d__4>.NativeClassPtr, 100663960);
			}

			// Token: 0x0600185E RID: 6238 RVA: 0x0007C9A0 File Offset: 0x0007ABA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731119, XrefRangeEnd = 731185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ParsePostValueAsync_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600185F RID: 6239 RVA: 0x0007C9D8 File Offset: 0x0007ABD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731185, XrefRangeEnd = 731191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ParsePostValueAsync_d__4.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001860 RID: 6240 RVA: 0x0000A852 File Offset: 0x00008A52
			public _ParsePostValueAsync_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001861 RID: 6241 RVA: 0x0000A85B File Offset: 0x00008A5B
			public _ParsePostValueAsync_d__4()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._ParsePostValueAsync_d__4>.NativeClassPtr))
			{
			}

			// Token: 0x17000692 RID: 1682
			// (get) Token: 0x06001862 RID: 6242 RVA: 0x0007CA20 File Offset: 0x0007AC20
			// (set) Token: 0x06001863 RID: 6243 RVA: 0x0000A86D File Offset: 0x00008A6D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePostValueAsync_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePostValueAsync_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000693 RID: 1683
			// (get) Token: 0x06001864 RID: 6244 RVA: 0x0007CA48 File Offset: 0x0007AC48
			// (set) Token: 0x06001865 RID: 6245 RVA: 0x0000A888 File Offset: 0x00008A88
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePostValueAsync_d__4.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePostValueAsync_d__4.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000694 RID: 1684
			// (get) Token: 0x06001866 RID: 6246 RVA: 0x0007CA78 File Offset: 0x0007AC78
			// (set) Token: 0x06001867 RID: 6247 RVA: 0x0000A8B6 File Offset: 0x00008AB6
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePostValueAsync_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePostValueAsync_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000695 RID: 1685
			// (get) Token: 0x06001868 RID: 6248 RVA: 0x0007CAA8 File Offset: 0x0007ACA8
			// (set) Token: 0x06001869 RID: 6249 RVA: 0x0000A8D5 File Offset: 0x00008AD5
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePostValueAsync_d__4.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePostValueAsync_d__4.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000696 RID: 1686
			// (get) Token: 0x0600186A RID: 6250 RVA: 0x0007CAD8 File Offset: 0x0007ACD8
			// (set) Token: 0x0600186B RID: 6251 RVA: 0x0000A903 File Offset: 0x00008B03
			public unsafe bool ignoreComments
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePostValueAsync_d__4.NativeFieldInfoPtr_ignoreComments);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePostValueAsync_d__4.NativeFieldInfoPtr_ignoreComments)) = value;
				}
			}

			// Token: 0x17000697 RID: 1687
			// (get) Token: 0x0600186C RID: 6252 RVA: 0x0007CB00 File Offset: 0x0007AD00
			// (set) Token: 0x0600186D RID: 6253 RVA: 0x0000A91E File Offset: 0x00008B1E
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePostValueAsync_d__4.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePostValueAsync_d__4.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000698 RID: 1688
			// (get) Token: 0x0600186E RID: 6254 RVA: 0x0007CB30 File Offset: 0x0007AD30
			// (set) Token: 0x0600186F RID: 6255 RVA: 0x0000A94C File Offset: 0x00008B4C
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePostValueAsync_d__4.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePostValueAsync_d__4.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001312 RID: 4882
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001313 RID: 4883
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001314 RID: 4884
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001315 RID: 4885
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001316 RID: 4886
			private static readonly IntPtr NativeFieldInfoPtr_ignoreComments;

			// Token: 0x04001317 RID: 4887
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001318 RID: 4888
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04001319 RID: 4889
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400131A RID: 4890
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000136 RID: 310
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<ParsePropertyAsync>d__31")]
		public sealed class _ParsePropertyAsync_d__31 : ValueType
		{
			// Token: 0x06001870 RID: 6256 RVA: 0x0007CB60 File Offset: 0x0007AD60
			// Note: this type is marked as 'beforefieldinit'.
			static _ParsePropertyAsync_d__31()
			{
				Il2CppClassPointerStore<JsonTextReader._ParsePropertyAsync_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<ParsePropertyAsync>d__31");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._ParsePropertyAsync_d__31>.NativeClassPtr);
				JsonTextReader._ParsePropertyAsync_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParsePropertyAsync_d__31>.NativeClassPtr, "<>1__state");
				JsonTextReader._ParsePropertyAsync_d__31.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParsePropertyAsync_d__31>.NativeClassPtr, "<>t__builder");
				JsonTextReader._ParsePropertyAsync_d__31.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParsePropertyAsync_d__31>.NativeClassPtr, "<>4__this");
				JsonTextReader._ParsePropertyAsync_d__31.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParsePropertyAsync_d__31>.NativeClassPtr, "cancellationToken");
				JsonTextReader._ParsePropertyAsync_d__31.NativeFieldInfoPtr__quoteChar_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParsePropertyAsync_d__31>.NativeClassPtr, "<quoteChar>5__2");
				JsonTextReader._ParsePropertyAsync_d__31.NativeFieldInfoPtr__propertyName_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParsePropertyAsync_d__31>.NativeClassPtr, "<propertyName>5__3");
				JsonTextReader._ParsePropertyAsync_d__31.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParsePropertyAsync_d__31>.NativeClassPtr, "<>u__1");
				JsonTextReader._ParsePropertyAsync_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ParsePropertyAsync_d__31>.NativeClassPtr, 100663961);
				JsonTextReader._ParsePropertyAsync_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ParsePropertyAsync_d__31>.NativeClassPtr, 100663962);
			}

			// Token: 0x06001871 RID: 6257 RVA: 0x0007CC40 File Offset: 0x0007AE40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731191, XrefRangeEnd = 731235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ParsePropertyAsync_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001872 RID: 6258 RVA: 0x0007CC78 File Offset: 0x0007AE78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731235, XrefRangeEnd = 731241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ParsePropertyAsync_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001873 RID: 6259 RVA: 0x0000A97A File Offset: 0x00008B7A
			public _ParsePropertyAsync_d__31(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001874 RID: 6260 RVA: 0x0000A983 File Offset: 0x00008B83
			public _ParsePropertyAsync_d__31()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._ParsePropertyAsync_d__31>.NativeClassPtr))
			{
			}

			// Token: 0x17000699 RID: 1689
			// (get) Token: 0x06001875 RID: 6261 RVA: 0x0007CCC0 File Offset: 0x0007AEC0
			// (set) Token: 0x06001876 RID: 6262 RVA: 0x0000A995 File Offset: 0x00008B95
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePropertyAsync_d__31.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePropertyAsync_d__31.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700069A RID: 1690
			// (get) Token: 0x06001877 RID: 6263 RVA: 0x0007CCE8 File Offset: 0x0007AEE8
			// (set) Token: 0x06001878 RID: 6264 RVA: 0x0000A9B0 File Offset: 0x00008BB0
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePropertyAsync_d__31.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePropertyAsync_d__31.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700069B RID: 1691
			// (get) Token: 0x06001879 RID: 6265 RVA: 0x0007CD18 File Offset: 0x0007AF18
			// (set) Token: 0x0600187A RID: 6266 RVA: 0x0000A9DE File Offset: 0x00008BDE
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePropertyAsync_d__31.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePropertyAsync_d__31.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700069C RID: 1692
			// (get) Token: 0x0600187B RID: 6267 RVA: 0x0007CD48 File Offset: 0x0007AF48
			// (set) Token: 0x0600187C RID: 6268 RVA: 0x0000A9FD File Offset: 0x00008BFD
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePropertyAsync_d__31.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePropertyAsync_d__31.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700069D RID: 1693
			// (get) Token: 0x0600187D RID: 6269 RVA: 0x0007CD78 File Offset: 0x0007AF78
			// (set) Token: 0x0600187E RID: 6270 RVA: 0x0000AA2B File Offset: 0x00008C2B
			public unsafe char _quoteChar_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePropertyAsync_d__31.NativeFieldInfoPtr__quoteChar_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePropertyAsync_d__31.NativeFieldInfoPtr__quoteChar_5__2)) = value;
				}
			}

			// Token: 0x1700069E RID: 1694
			// (get) Token: 0x0600187F RID: 6271 RVA: 0x0007CDA0 File Offset: 0x0007AFA0
			// (set) Token: 0x06001880 RID: 6272 RVA: 0x0000AA46 File Offset: 0x00008C46
			public unsafe string _propertyName_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePropertyAsync_d__31.NativeFieldInfoPtr__propertyName_5__3);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePropertyAsync_d__31.NativeFieldInfoPtr__propertyName_5__3), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700069F RID: 1695
			// (get) Token: 0x06001881 RID: 6273 RVA: 0x0007CDC8 File Offset: 0x0007AFC8
			// (set) Token: 0x06001882 RID: 6274 RVA: 0x0000AA65 File Offset: 0x00008C65
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePropertyAsync_d__31.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParsePropertyAsync_d__31.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400131B RID: 4891
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400131C RID: 4892
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400131D RID: 4893
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400131E RID: 4894
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400131F RID: 4895
			private static readonly IntPtr NativeFieldInfoPtr__quoteChar_5__2;

			// Token: 0x04001320 RID: 4896
			private static readonly IntPtr NativeFieldInfoPtr__propertyName_5__3;

			// Token: 0x04001321 RID: 4897
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001322 RID: 4898
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001323 RID: 4899
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000137 RID: 311
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<ParseStringAsync>d__18")]
		public sealed class _ParseStringAsync_d__18 : ValueType
		{
			// Token: 0x06001883 RID: 6275 RVA: 0x0007CDF8 File Offset: 0x0007AFF8
			// Note: this type is marked as 'beforefieldinit'.
			static _ParseStringAsync_d__18()
			{
				Il2CppClassPointerStore<JsonTextReader._ParseStringAsync_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<ParseStringAsync>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._ParseStringAsync_d__18>.NativeClassPtr);
				JsonTextReader._ParseStringAsync_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseStringAsync_d__18>.NativeClassPtr, "<>1__state");
				JsonTextReader._ParseStringAsync_d__18.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseStringAsync_d__18>.NativeClassPtr, "<>t__builder");
				JsonTextReader._ParseStringAsync_d__18.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseStringAsync_d__18>.NativeClassPtr, "cancellationToken");
				JsonTextReader._ParseStringAsync_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseStringAsync_d__18>.NativeClassPtr, "<>4__this");
				JsonTextReader._ParseStringAsync_d__18.NativeFieldInfoPtr_quote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseStringAsync_d__18>.NativeClassPtr, "quote");
				JsonTextReader._ParseStringAsync_d__18.NativeFieldInfoPtr_readType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseStringAsync_d__18>.NativeClassPtr, "readType");
				JsonTextReader._ParseStringAsync_d__18.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseStringAsync_d__18>.NativeClassPtr, "<>u__1");
				JsonTextReader._ParseStringAsync_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ParseStringAsync_d__18>.NativeClassPtr, 100663963);
				JsonTextReader._ParseStringAsync_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ParseStringAsync_d__18>.NativeClassPtr, 100663964);
			}

			// Token: 0x06001884 RID: 6276 RVA: 0x0007CED8 File Offset: 0x0007B0D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731241, XrefRangeEnd = 731257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ParseStringAsync_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001885 RID: 6277 RVA: 0x0007CF10 File Offset: 0x0007B110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731257, XrefRangeEnd = 731261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ParseStringAsync_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001886 RID: 6278 RVA: 0x0000AA93 File Offset: 0x00008C93
			public _ParseStringAsync_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001887 RID: 6279 RVA: 0x0000AA9C File Offset: 0x00008C9C
			public _ParseStringAsync_d__18()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._ParseStringAsync_d__18>.NativeClassPtr))
			{
			}

			// Token: 0x170006A0 RID: 1696
			// (get) Token: 0x06001888 RID: 6280 RVA: 0x0007CF58 File Offset: 0x0007B158
			// (set) Token: 0x06001889 RID: 6281 RVA: 0x0000AAAE File Offset: 0x00008CAE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseStringAsync_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseStringAsync_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006A1 RID: 1697
			// (get) Token: 0x0600188A RID: 6282 RVA: 0x0007CF80 File Offset: 0x0007B180
			// (set) Token: 0x0600188B RID: 6283 RVA: 0x0000AAC9 File Offset: 0x00008CC9
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseStringAsync_d__18.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseStringAsync_d__18.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006A2 RID: 1698
			// (get) Token: 0x0600188C RID: 6284 RVA: 0x0007CFB0 File Offset: 0x0007B1B0
			// (set) Token: 0x0600188D RID: 6285 RVA: 0x0000AAF7 File Offset: 0x00008CF7
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseStringAsync_d__18.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseStringAsync_d__18.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006A3 RID: 1699
			// (get) Token: 0x0600188E RID: 6286 RVA: 0x0007CFE0 File Offset: 0x0007B1E0
			// (set) Token: 0x0600188F RID: 6287 RVA: 0x0000AB25 File Offset: 0x00008D25
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseStringAsync_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseStringAsync_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006A4 RID: 1700
			// (get) Token: 0x06001890 RID: 6288 RVA: 0x0007D010 File Offset: 0x0007B210
			// (set) Token: 0x06001891 RID: 6289 RVA: 0x0000AB44 File Offset: 0x00008D44
			public unsafe char quote
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseStringAsync_d__18.NativeFieldInfoPtr_quote);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseStringAsync_d__18.NativeFieldInfoPtr_quote)) = value;
				}
			}

			// Token: 0x170006A5 RID: 1701
			// (get) Token: 0x06001892 RID: 6290 RVA: 0x0007D038 File Offset: 0x0007B238
			// (set) Token: 0x06001893 RID: 6291 RVA: 0x0000AB5F File Offset: 0x00008D5F
			public unsafe ReadType readType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseStringAsync_d__18.NativeFieldInfoPtr_readType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseStringAsync_d__18.NativeFieldInfoPtr_readType)) = value;
				}
			}

			// Token: 0x170006A6 RID: 1702
			// (get) Token: 0x06001894 RID: 6292 RVA: 0x0007D060 File Offset: 0x0007B260
			// (set) Token: 0x06001895 RID: 6293 RVA: 0x0000AB7A File Offset: 0x00008D7A
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseStringAsync_d__18.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseStringAsync_d__18.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001324 RID: 4900
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001325 RID: 4901
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001326 RID: 4902
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001327 RID: 4903
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001328 RID: 4904
			private static readonly IntPtr NativeFieldInfoPtr_quote;

			// Token: 0x04001329 RID: 4905
			private static readonly IntPtr NativeFieldInfoPtr_readType;

			// Token: 0x0400132A RID: 4906
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400132B RID: 4907
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400132C RID: 4908
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000138 RID: 312
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<ParseUnicodeAsync>d__12")]
		public sealed class _ParseUnicodeAsync_d__12 : ValueType
		{
			// Token: 0x06001896 RID: 6294 RVA: 0x0007D090 File Offset: 0x0007B290
			// Note: this type is marked as 'beforefieldinit'.
			static _ParseUnicodeAsync_d__12()
			{
				Il2CppClassPointerStore<JsonTextReader._ParseUnicodeAsync_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<ParseUnicodeAsync>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._ParseUnicodeAsync_d__12>.NativeClassPtr);
				JsonTextReader._ParseUnicodeAsync_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseUnicodeAsync_d__12>.NativeClassPtr, "<>1__state");
				JsonTextReader._ParseUnicodeAsync_d__12.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseUnicodeAsync_d__12>.NativeClassPtr, "<>t__builder");
				JsonTextReader._ParseUnicodeAsync_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseUnicodeAsync_d__12>.NativeClassPtr, "<>4__this");
				JsonTextReader._ParseUnicodeAsync_d__12.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseUnicodeAsync_d__12>.NativeClassPtr, "cancellationToken");
				JsonTextReader._ParseUnicodeAsync_d__12.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseUnicodeAsync_d__12>.NativeClassPtr, "<>u__1");
				JsonTextReader._ParseUnicodeAsync_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ParseUnicodeAsync_d__12>.NativeClassPtr, 100663965);
				JsonTextReader._ParseUnicodeAsync_d__12.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ParseUnicodeAsync_d__12>.NativeClassPtr, 100663966);
			}

			// Token: 0x06001897 RID: 6295 RVA: 0x0007D148 File Offset: 0x0007B348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731261, XrefRangeEnd = 731281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ParseUnicodeAsync_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001898 RID: 6296 RVA: 0x0007D180 File Offset: 0x0007B380
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731281, XrefRangeEnd = 731287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ParseUnicodeAsync_d__12.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001899 RID: 6297 RVA: 0x0000ABA8 File Offset: 0x00008DA8
			public _ParseUnicodeAsync_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600189A RID: 6298 RVA: 0x0000ABB1 File Offset: 0x00008DB1
			public _ParseUnicodeAsync_d__12()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._ParseUnicodeAsync_d__12>.NativeClassPtr))
			{
			}

			// Token: 0x170006A7 RID: 1703
			// (get) Token: 0x0600189B RID: 6299 RVA: 0x0007D1C8 File Offset: 0x0007B3C8
			// (set) Token: 0x0600189C RID: 6300 RVA: 0x0000ABC3 File Offset: 0x00008DC3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseUnicodeAsync_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseUnicodeAsync_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006A8 RID: 1704
			// (get) Token: 0x0600189D RID: 6301 RVA: 0x0007D1F0 File Offset: 0x0007B3F0
			// (set) Token: 0x0600189E RID: 6302 RVA: 0x0000ABDE File Offset: 0x00008DDE
			public AsyncTaskMethodBuilder<char> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseUnicodeAsync_d__12.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<char>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<char>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseUnicodeAsync_d__12.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<char>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006A9 RID: 1705
			// (get) Token: 0x0600189F RID: 6303 RVA: 0x0007D220 File Offset: 0x0007B420
			// (set) Token: 0x060018A0 RID: 6304 RVA: 0x0000AC0C File Offset: 0x00008E0C
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseUnicodeAsync_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseUnicodeAsync_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006AA RID: 1706
			// (get) Token: 0x060018A1 RID: 6305 RVA: 0x0007D250 File Offset: 0x0007B450
			// (set) Token: 0x060018A2 RID: 6306 RVA: 0x0000AC2B File Offset: 0x00008E2B
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseUnicodeAsync_d__12.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseUnicodeAsync_d__12.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006AB RID: 1707
			// (get) Token: 0x060018A3 RID: 6307 RVA: 0x0007D280 File Offset: 0x0007B480
			// (set) Token: 0x060018A4 RID: 6308 RVA: 0x0000AC59 File Offset: 0x00008E59
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseUnicodeAsync_d__12.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseUnicodeAsync_d__12.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400132D RID: 4909
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400132E RID: 4910
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400132F RID: 4911
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001330 RID: 4912
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001331 RID: 4913
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001332 RID: 4914
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001333 RID: 4915
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000139 RID: 313
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<ParseUnquotedPropertyAsync>d__33")]
		public sealed class _ParseUnquotedPropertyAsync_d__33 : ValueType
		{
			// Token: 0x060018A5 RID: 6309 RVA: 0x0007D2B0 File Offset: 0x0007B4B0
			// Note: this type is marked as 'beforefieldinit'.
			static _ParseUnquotedPropertyAsync_d__33()
			{
				Il2CppClassPointerStore<JsonTextReader._ParseUnquotedPropertyAsync_d__33>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<ParseUnquotedPropertyAsync>d__33");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._ParseUnquotedPropertyAsync_d__33>.NativeClassPtr);
				JsonTextReader._ParseUnquotedPropertyAsync_d__33.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseUnquotedPropertyAsync_d__33>.NativeClassPtr, "<>1__state");
				JsonTextReader._ParseUnquotedPropertyAsync_d__33.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseUnquotedPropertyAsync_d__33>.NativeClassPtr, "<>t__builder");
				JsonTextReader._ParseUnquotedPropertyAsync_d__33.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseUnquotedPropertyAsync_d__33>.NativeClassPtr, "<>4__this");
				JsonTextReader._ParseUnquotedPropertyAsync_d__33.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseUnquotedPropertyAsync_d__33>.NativeClassPtr, "cancellationToken");
				JsonTextReader._ParseUnquotedPropertyAsync_d__33.NativeFieldInfoPtr__initialPosition_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseUnquotedPropertyAsync_d__33>.NativeClassPtr, "<initialPosition>5__2");
				JsonTextReader._ParseUnquotedPropertyAsync_d__33.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseUnquotedPropertyAsync_d__33>.NativeClassPtr, "<>u__1");
				JsonTextReader._ParseUnquotedPropertyAsync_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ParseUnquotedPropertyAsync_d__33>.NativeClassPtr, 100663967);
				JsonTextReader._ParseUnquotedPropertyAsync_d__33.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ParseUnquotedPropertyAsync_d__33>.NativeClassPtr, 100663968);
			}

			// Token: 0x060018A6 RID: 6310 RVA: 0x0007D37C File Offset: 0x0007B57C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731287, XrefRangeEnd = 731301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ParseUnquotedPropertyAsync_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018A7 RID: 6311 RVA: 0x0007D3B4 File Offset: 0x0007B5B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731301, XrefRangeEnd = 731305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ParseUnquotedPropertyAsync_d__33.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060018A8 RID: 6312 RVA: 0x0000AC87 File Offset: 0x00008E87
			public _ParseUnquotedPropertyAsync_d__33(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060018A9 RID: 6313 RVA: 0x0000AC90 File Offset: 0x00008E90
			public _ParseUnquotedPropertyAsync_d__33()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._ParseUnquotedPropertyAsync_d__33>.NativeClassPtr))
			{
			}

			// Token: 0x170006AC RID: 1708
			// (get) Token: 0x060018AA RID: 6314 RVA: 0x0007D3FC File Offset: 0x0007B5FC
			// (set) Token: 0x060018AB RID: 6315 RVA: 0x0000ACA2 File Offset: 0x00008EA2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseUnquotedPropertyAsync_d__33.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseUnquotedPropertyAsync_d__33.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006AD RID: 1709
			// (get) Token: 0x060018AC RID: 6316 RVA: 0x0007D424 File Offset: 0x0007B624
			// (set) Token: 0x060018AD RID: 6317 RVA: 0x0000ACBD File Offset: 0x00008EBD
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseUnquotedPropertyAsync_d__33.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseUnquotedPropertyAsync_d__33.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006AE RID: 1710
			// (get) Token: 0x060018AE RID: 6318 RVA: 0x0007D454 File Offset: 0x0007B654
			// (set) Token: 0x060018AF RID: 6319 RVA: 0x0000ACEB File Offset: 0x00008EEB
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseUnquotedPropertyAsync_d__33.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseUnquotedPropertyAsync_d__33.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006AF RID: 1711
			// (get) Token: 0x060018B0 RID: 6320 RVA: 0x0007D484 File Offset: 0x0007B684
			// (set) Token: 0x060018B1 RID: 6321 RVA: 0x0000AD0A File Offset: 0x00008F0A
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseUnquotedPropertyAsync_d__33.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseUnquotedPropertyAsync_d__33.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006B0 RID: 1712
			// (get) Token: 0x060018B2 RID: 6322 RVA: 0x0007D4B4 File Offset: 0x0007B6B4
			// (set) Token: 0x060018B3 RID: 6323 RVA: 0x0000AD38 File Offset: 0x00008F38
			public unsafe int _initialPosition_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseUnquotedPropertyAsync_d__33.NativeFieldInfoPtr__initialPosition_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseUnquotedPropertyAsync_d__33.NativeFieldInfoPtr__initialPosition_5__2)) = value;
				}
			}

			// Token: 0x170006B1 RID: 1713
			// (get) Token: 0x060018B4 RID: 6324 RVA: 0x0007D4DC File Offset: 0x0007B6DC
			// (set) Token: 0x060018B5 RID: 6325 RVA: 0x0000AD53 File Offset: 0x00008F53
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseUnquotedPropertyAsync_d__33.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseUnquotedPropertyAsync_d__33.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001334 RID: 4916
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001335 RID: 4917
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001336 RID: 4918
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001337 RID: 4919
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001338 RID: 4920
			private static readonly IntPtr NativeFieldInfoPtr__initialPosition_5__2;

			// Token: 0x04001339 RID: 4921
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400133A RID: 4922
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400133B RID: 4923
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200013A RID: 314
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<ParseValueAsync>d__8")]
		public sealed class _ParseValueAsync_d__8 : ValueType
		{
			// Token: 0x060018B6 RID: 6326 RVA: 0x0007D50C File Offset: 0x0007B70C
			// Note: this type is marked as 'beforefieldinit'.
			static _ParseValueAsync_d__8()
			{
				Il2CppClassPointerStore<JsonTextReader._ParseValueAsync_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<ParseValueAsync>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._ParseValueAsync_d__8>.NativeClassPtr);
				JsonTextReader._ParseValueAsync_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseValueAsync_d__8>.NativeClassPtr, "<>1__state");
				JsonTextReader._ParseValueAsync_d__8.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseValueAsync_d__8>.NativeClassPtr, "<>t__builder");
				JsonTextReader._ParseValueAsync_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseValueAsync_d__8>.NativeClassPtr, "<>4__this");
				JsonTextReader._ParseValueAsync_d__8.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseValueAsync_d__8>.NativeClassPtr, "cancellationToken");
				JsonTextReader._ParseValueAsync_d__8.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseValueAsync_d__8>.NativeClassPtr, "<>u__1");
				JsonTextReader._ParseValueAsync_d__8.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseValueAsync_d__8>.NativeClassPtr, "<>u__2");
				JsonTextReader._ParseValueAsync_d__8.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseValueAsync_d__8>.NativeClassPtr, "<>u__3");
				JsonTextReader._ParseValueAsync_d__8.NativeFieldInfoPtr___u__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ParseValueAsync_d__8>.NativeClassPtr, "<>u__4");
				JsonTextReader._ParseValueAsync_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ParseValueAsync_d__8>.NativeClassPtr, 100663969);
				JsonTextReader._ParseValueAsync_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ParseValueAsync_d__8>.NativeClassPtr, 100663970);
			}

			// Token: 0x060018B7 RID: 6327 RVA: 0x0007D600 File Offset: 0x0007B800
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731305, XrefRangeEnd = 731548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ParseValueAsync_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018B8 RID: 6328 RVA: 0x0007D638 File Offset: 0x0007B838
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731548, XrefRangeEnd = 731554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ParseValueAsync_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060018B9 RID: 6329 RVA: 0x0000AD81 File Offset: 0x00008F81
			public _ParseValueAsync_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060018BA RID: 6330 RVA: 0x0000AD8A File Offset: 0x00008F8A
			public _ParseValueAsync_d__8()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._ParseValueAsync_d__8>.NativeClassPtr))
			{
			}

			// Token: 0x170006B2 RID: 1714
			// (get) Token: 0x060018BB RID: 6331 RVA: 0x0007D680 File Offset: 0x0007B880
			// (set) Token: 0x060018BC RID: 6332 RVA: 0x0000AD9C File Offset: 0x00008F9C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseValueAsync_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseValueAsync_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006B3 RID: 1715
			// (get) Token: 0x060018BD RID: 6333 RVA: 0x0007D6A8 File Offset: 0x0007B8A8
			// (set) Token: 0x060018BE RID: 6334 RVA: 0x0000ADB7 File Offset: 0x00008FB7
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseValueAsync_d__8.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseValueAsync_d__8.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006B4 RID: 1716
			// (get) Token: 0x060018BF RID: 6335 RVA: 0x0007D6D8 File Offset: 0x0007B8D8
			// (set) Token: 0x060018C0 RID: 6336 RVA: 0x0000ADE5 File Offset: 0x00008FE5
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseValueAsync_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseValueAsync_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006B5 RID: 1717
			// (get) Token: 0x060018C1 RID: 6337 RVA: 0x0007D708 File Offset: 0x0007B908
			// (set) Token: 0x060018C2 RID: 6338 RVA: 0x0000AE04 File Offset: 0x00009004
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseValueAsync_d__8.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseValueAsync_d__8.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006B6 RID: 1718
			// (get) Token: 0x060018C3 RID: 6339 RVA: 0x0007D738 File Offset: 0x0007B938
			// (set) Token: 0x060018C4 RID: 6340 RVA: 0x0000AE32 File Offset: 0x00009032
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseValueAsync_d__8.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseValueAsync_d__8.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006B7 RID: 1719
			// (get) Token: 0x060018C5 RID: 6341 RVA: 0x0007D768 File Offset: 0x0007B968
			// (set) Token: 0x060018C6 RID: 6342 RVA: 0x0000AE60 File Offset: 0x00009060
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseValueAsync_d__8.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseValueAsync_d__8.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006B8 RID: 1720
			// (get) Token: 0x060018C7 RID: 6343 RVA: 0x0007D798 File Offset: 0x0007B998
			// (set) Token: 0x060018C8 RID: 6344 RVA: 0x0000AE8E File Offset: 0x0000908E
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseValueAsync_d__8.NativeFieldInfoPtr___u__3);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseValueAsync_d__8.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006B9 RID: 1721
			// (get) Token: 0x060018C9 RID: 6345 RVA: 0x0007D7C8 File Offset: 0x0007B9C8
			// (set) Token: 0x060018CA RID: 6346 RVA: 0x0000AEBC File Offset: 0x000090BC
			public ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter __u__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseValueAsync_d__8.NativeFieldInfoPtr___u__4);
					return new ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ParseValueAsync_d__8.NativeFieldInfoPtr___u__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400133C RID: 4924
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400133D RID: 4925
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400133E RID: 4926
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400133F RID: 4927
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001340 RID: 4928
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001341 RID: 4929
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04001342 RID: 4930
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x04001343 RID: 4931
			private static readonly IntPtr NativeFieldInfoPtr___u__4;

			// Token: 0x04001344 RID: 4932
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001345 RID: 4933
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200013B RID: 315
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<ProcessCarriageReturnAsync>d__11")]
		public sealed class _ProcessCarriageReturnAsync_d__11 : ValueType
		{
			// Token: 0x060018CB RID: 6347 RVA: 0x0007D7F8 File Offset: 0x0007B9F8
			// Note: this type is marked as 'beforefieldinit'.
			static _ProcessCarriageReturnAsync_d__11()
			{
				Il2CppClassPointerStore<JsonTextReader._ProcessCarriageReturnAsync_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<ProcessCarriageReturnAsync>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._ProcessCarriageReturnAsync_d__11>.NativeClassPtr);
				JsonTextReader._ProcessCarriageReturnAsync_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ProcessCarriageReturnAsync_d__11>.NativeClassPtr, "<>1__state");
				JsonTextReader._ProcessCarriageReturnAsync_d__11.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ProcessCarriageReturnAsync_d__11>.NativeClassPtr, "<>t__builder");
				JsonTextReader._ProcessCarriageReturnAsync_d__11.NativeFieldInfoPtr_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ProcessCarriageReturnAsync_d__11>.NativeClassPtr, "task");
				JsonTextReader._ProcessCarriageReturnAsync_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ProcessCarriageReturnAsync_d__11>.NativeClassPtr, "<>4__this");
				JsonTextReader._ProcessCarriageReturnAsync_d__11.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ProcessCarriageReturnAsync_d__11>.NativeClassPtr, "<>u__1");
				JsonTextReader._ProcessCarriageReturnAsync_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ProcessCarriageReturnAsync_d__11>.NativeClassPtr, 100663971);
				JsonTextReader._ProcessCarriageReturnAsync_d__11.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ProcessCarriageReturnAsync_d__11>.NativeClassPtr, 100663972);
			}

			// Token: 0x060018CC RID: 6348 RVA: 0x0007D8B0 File Offset: 0x0007BAB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731554, XrefRangeEnd = 731571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ProcessCarriageReturnAsync_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018CD RID: 6349 RVA: 0x0007D8E8 File Offset: 0x0007BAE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731571, XrefRangeEnd = 731575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ProcessCarriageReturnAsync_d__11.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060018CE RID: 6350 RVA: 0x0000AEEA File Offset: 0x000090EA
			public _ProcessCarriageReturnAsync_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060018CF RID: 6351 RVA: 0x0000AEF3 File Offset: 0x000090F3
			public _ProcessCarriageReturnAsync_d__11()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._ProcessCarriageReturnAsync_d__11>.NativeClassPtr))
			{
			}

			// Token: 0x170006BA RID: 1722
			// (get) Token: 0x060018D0 RID: 6352 RVA: 0x0007D930 File Offset: 0x0007BB30
			// (set) Token: 0x060018D1 RID: 6353 RVA: 0x0000AF05 File Offset: 0x00009105
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ProcessCarriageReturnAsync_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ProcessCarriageReturnAsync_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006BB RID: 1723
			// (get) Token: 0x060018D2 RID: 6354 RVA: 0x0007D958 File Offset: 0x0007BB58
			// (set) Token: 0x060018D3 RID: 6355 RVA: 0x0000AF20 File Offset: 0x00009120
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ProcessCarriageReturnAsync_d__11.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ProcessCarriageReturnAsync_d__11.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006BC RID: 1724
			// (get) Token: 0x060018D4 RID: 6356 RVA: 0x0007D988 File Offset: 0x0007BB88
			// (set) Token: 0x060018D5 RID: 6357 RVA: 0x0000AF4E File Offset: 0x0000914E
			public unsafe Task<bool> task
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ProcessCarriageReturnAsync_d__11.NativeFieldInfoPtr_task);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ProcessCarriageReturnAsync_d__11.NativeFieldInfoPtr_task), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006BD RID: 1725
			// (get) Token: 0x060018D6 RID: 6358 RVA: 0x0007D9B8 File Offset: 0x0007BBB8
			// (set) Token: 0x060018D7 RID: 6359 RVA: 0x0000AF6D File Offset: 0x0000916D
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ProcessCarriageReturnAsync_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ProcessCarriageReturnAsync_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006BE RID: 1726
			// (get) Token: 0x060018D8 RID: 6360 RVA: 0x0007D9E8 File Offset: 0x0007BBE8
			// (set) Token: 0x060018D9 RID: 6361 RVA: 0x0000AF8C File Offset: 0x0000918C
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ProcessCarriageReturnAsync_d__11.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ProcessCarriageReturnAsync_d__11.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001346 RID: 4934
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001347 RID: 4935
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001348 RID: 4936
			private static readonly IntPtr NativeFieldInfoPtr_task;

			// Token: 0x04001349 RID: 4937
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400134A RID: 4938
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400134B RID: 4939
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400134C RID: 4940
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200013C RID: 316
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<ReadCharsAsync>d__14")]
		public sealed class _ReadCharsAsync_d__14 : ValueType
		{
			// Token: 0x060018DA RID: 6362 RVA: 0x0007DA18 File Offset: 0x0007BC18
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadCharsAsync_d__14()
			{
				Il2CppClassPointerStore<JsonTextReader._ReadCharsAsync_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<ReadCharsAsync>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._ReadCharsAsync_d__14>.NativeClassPtr);
				JsonTextReader._ReadCharsAsync_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadCharsAsync_d__14>.NativeClassPtr, "<>1__state");
				JsonTextReader._ReadCharsAsync_d__14.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadCharsAsync_d__14>.NativeClassPtr, "<>t__builder");
				JsonTextReader._ReadCharsAsync_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadCharsAsync_d__14>.NativeClassPtr, "<>4__this");
				JsonTextReader._ReadCharsAsync_d__14.NativeFieldInfoPtr_relativePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadCharsAsync_d__14>.NativeClassPtr, "relativePosition");
				JsonTextReader._ReadCharsAsync_d__14.NativeFieldInfoPtr_append = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadCharsAsync_d__14>.NativeClassPtr, "append");
				JsonTextReader._ReadCharsAsync_d__14.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadCharsAsync_d__14>.NativeClassPtr, "cancellationToken");
				JsonTextReader._ReadCharsAsync_d__14.NativeFieldInfoPtr__charsRequired_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadCharsAsync_d__14>.NativeClassPtr, "<charsRequired>5__2");
				JsonTextReader._ReadCharsAsync_d__14.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadCharsAsync_d__14>.NativeClassPtr, "<>u__1");
				JsonTextReader._ReadCharsAsync_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ReadCharsAsync_d__14>.NativeClassPtr, 100663973);
				JsonTextReader._ReadCharsAsync_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ReadCharsAsync_d__14>.NativeClassPtr, 100663974);
			}

			// Token: 0x060018DB RID: 6363 RVA: 0x0007DB0C File Offset: 0x0007BD0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731575, XrefRangeEnd = 731595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ReadCharsAsync_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018DC RID: 6364 RVA: 0x0007DB44 File Offset: 0x0007BD44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731595, XrefRangeEnd = 731601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ReadCharsAsync_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060018DD RID: 6365 RVA: 0x0000AFBA File Offset: 0x000091BA
			public _ReadCharsAsync_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060018DE RID: 6366 RVA: 0x0000AFC3 File Offset: 0x000091C3
			public _ReadCharsAsync_d__14()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._ReadCharsAsync_d__14>.NativeClassPtr))
			{
			}

			// Token: 0x170006BF RID: 1727
			// (get) Token: 0x060018DF RID: 6367 RVA: 0x0007DB8C File Offset: 0x0007BD8C
			// (set) Token: 0x060018E0 RID: 6368 RVA: 0x0000AFD5 File Offset: 0x000091D5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadCharsAsync_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadCharsAsync_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006C0 RID: 1728
			// (get) Token: 0x060018E1 RID: 6369 RVA: 0x0007DBB4 File Offset: 0x0007BDB4
			// (set) Token: 0x060018E2 RID: 6370 RVA: 0x0000AFF0 File Offset: 0x000091F0
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadCharsAsync_d__14.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadCharsAsync_d__14.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006C1 RID: 1729
			// (get) Token: 0x060018E3 RID: 6371 RVA: 0x0007DBE4 File Offset: 0x0007BDE4
			// (set) Token: 0x060018E4 RID: 6372 RVA: 0x0000B01E File Offset: 0x0000921E
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadCharsAsync_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadCharsAsync_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006C2 RID: 1730
			// (get) Token: 0x060018E5 RID: 6373 RVA: 0x0007DC14 File Offset: 0x0007BE14
			// (set) Token: 0x060018E6 RID: 6374 RVA: 0x0000B03D File Offset: 0x0000923D
			public unsafe int relativePosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadCharsAsync_d__14.NativeFieldInfoPtr_relativePosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadCharsAsync_d__14.NativeFieldInfoPtr_relativePosition)) = value;
				}
			}

			// Token: 0x170006C3 RID: 1731
			// (get) Token: 0x060018E7 RID: 6375 RVA: 0x0007DC3C File Offset: 0x0007BE3C
			// (set) Token: 0x060018E8 RID: 6376 RVA: 0x0000B058 File Offset: 0x00009258
			public unsafe bool append
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadCharsAsync_d__14.NativeFieldInfoPtr_append);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadCharsAsync_d__14.NativeFieldInfoPtr_append)) = value;
				}
			}

			// Token: 0x170006C4 RID: 1732
			// (get) Token: 0x060018E9 RID: 6377 RVA: 0x0007DC64 File Offset: 0x0007BE64
			// (set) Token: 0x060018EA RID: 6378 RVA: 0x0000B073 File Offset: 0x00009273
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadCharsAsync_d__14.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadCharsAsync_d__14.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006C5 RID: 1733
			// (get) Token: 0x060018EB RID: 6379 RVA: 0x0007DC94 File Offset: 0x0007BE94
			// (set) Token: 0x060018EC RID: 6380 RVA: 0x0000B0A1 File Offset: 0x000092A1
			public unsafe int _charsRequired_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadCharsAsync_d__14.NativeFieldInfoPtr__charsRequired_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadCharsAsync_d__14.NativeFieldInfoPtr__charsRequired_5__2)) = value;
				}
			}

			// Token: 0x170006C6 RID: 1734
			// (get) Token: 0x060018ED RID: 6381 RVA: 0x0007DCBC File Offset: 0x0007BEBC
			// (set) Token: 0x060018EE RID: 6382 RVA: 0x0000B0BC File Offset: 0x000092BC
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadCharsAsync_d__14.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadCharsAsync_d__14.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400134D RID: 4941
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400134E RID: 4942
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400134F RID: 4943
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001350 RID: 4944
			private static readonly IntPtr NativeFieldInfoPtr_relativePosition;

			// Token: 0x04001351 RID: 4945
			private static readonly IntPtr NativeFieldInfoPtr_append;

			// Token: 0x04001352 RID: 4946
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001353 RID: 4947
			private static readonly IntPtr NativeFieldInfoPtr__charsRequired_5__2;

			// Token: 0x04001354 RID: 4948
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001355 RID: 4949
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001356 RID: 4950
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200013D RID: 317
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<ReadDataAsync>d__7")]
		public sealed class _ReadDataAsync_d__7 : ValueType
		{
			// Token: 0x060018EF RID: 6383 RVA: 0x0007DCEC File Offset: 0x0007BEEC
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadDataAsync_d__7()
			{
				Il2CppClassPointerStore<JsonTextReader._ReadDataAsync_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<ReadDataAsync>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._ReadDataAsync_d__7>.NativeClassPtr);
				JsonTextReader._ReadDataAsync_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadDataAsync_d__7>.NativeClassPtr, "<>1__state");
				JsonTextReader._ReadDataAsync_d__7.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadDataAsync_d__7>.NativeClassPtr, "<>t__builder");
				JsonTextReader._ReadDataAsync_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadDataAsync_d__7>.NativeClassPtr, "<>4__this");
				JsonTextReader._ReadDataAsync_d__7.NativeFieldInfoPtr_append = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadDataAsync_d__7>.NativeClassPtr, "append");
				JsonTextReader._ReadDataAsync_d__7.NativeFieldInfoPtr_charsRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadDataAsync_d__7>.NativeClassPtr, "charsRequired");
				JsonTextReader._ReadDataAsync_d__7.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadDataAsync_d__7>.NativeClassPtr, "cancellationToken");
				JsonTextReader._ReadDataAsync_d__7.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadDataAsync_d__7>.NativeClassPtr, "<>u__1");
				JsonTextReader._ReadDataAsync_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ReadDataAsync_d__7>.NativeClassPtr, 100663975);
				JsonTextReader._ReadDataAsync_d__7.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ReadDataAsync_d__7>.NativeClassPtr, 100663976);
			}

			// Token: 0x060018F0 RID: 6384 RVA: 0x0007DDCC File Offset: 0x0007BFCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731601, XrefRangeEnd = 731631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ReadDataAsync_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018F1 RID: 6385 RVA: 0x0007DE04 File Offset: 0x0007C004
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731631, XrefRangeEnd = 731637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ReadDataAsync_d__7.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060018F2 RID: 6386 RVA: 0x0000B0EA File Offset: 0x000092EA
			public _ReadDataAsync_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060018F3 RID: 6387 RVA: 0x0000B0F3 File Offset: 0x000092F3
			public _ReadDataAsync_d__7()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._ReadDataAsync_d__7>.NativeClassPtr))
			{
			}

			// Token: 0x170006C7 RID: 1735
			// (get) Token: 0x060018F4 RID: 6388 RVA: 0x0007DE4C File Offset: 0x0007C04C
			// (set) Token: 0x060018F5 RID: 6389 RVA: 0x0000B105 File Offset: 0x00009305
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadDataAsync_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadDataAsync_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006C8 RID: 1736
			// (get) Token: 0x060018F6 RID: 6390 RVA: 0x0007DE74 File Offset: 0x0007C074
			// (set) Token: 0x060018F7 RID: 6391 RVA: 0x0000B120 File Offset: 0x00009320
			public AsyncTaskMethodBuilder<int> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadDataAsync_d__7.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadDataAsync_d__7.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006C9 RID: 1737
			// (get) Token: 0x060018F8 RID: 6392 RVA: 0x0007DEA4 File Offset: 0x0007C0A4
			// (set) Token: 0x060018F9 RID: 6393 RVA: 0x0000B14E File Offset: 0x0000934E
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadDataAsync_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadDataAsync_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006CA RID: 1738
			// (get) Token: 0x060018FA RID: 6394 RVA: 0x0007DED4 File Offset: 0x0007C0D4
			// (set) Token: 0x060018FB RID: 6395 RVA: 0x0000B16D File Offset: 0x0000936D
			public unsafe bool append
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadDataAsync_d__7.NativeFieldInfoPtr_append);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadDataAsync_d__7.NativeFieldInfoPtr_append)) = value;
				}
			}

			// Token: 0x170006CB RID: 1739
			// (get) Token: 0x060018FC RID: 6396 RVA: 0x0007DEFC File Offset: 0x0007C0FC
			// (set) Token: 0x060018FD RID: 6397 RVA: 0x0000B188 File Offset: 0x00009388
			public unsafe int charsRequired
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadDataAsync_d__7.NativeFieldInfoPtr_charsRequired);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadDataAsync_d__7.NativeFieldInfoPtr_charsRequired)) = value;
				}
			}

			// Token: 0x170006CC RID: 1740
			// (get) Token: 0x060018FE RID: 6398 RVA: 0x0007DF24 File Offset: 0x0007C124
			// (set) Token: 0x060018FF RID: 6399 RVA: 0x0000B1A3 File Offset: 0x000093A3
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadDataAsync_d__7.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadDataAsync_d__7.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006CD RID: 1741
			// (get) Token: 0x06001900 RID: 6400 RVA: 0x0007DF54 File Offset: 0x0007C154
			// (set) Token: 0x06001901 RID: 6401 RVA: 0x0000B1D1 File Offset: 0x000093D1
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadDataAsync_d__7.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadDataAsync_d__7.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001357 RID: 4951
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001358 RID: 4952
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001359 RID: 4953
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400135A RID: 4954
			private static readonly IntPtr NativeFieldInfoPtr_append;

			// Token: 0x0400135B RID: 4955
			private static readonly IntPtr NativeFieldInfoPtr_charsRequired;

			// Token: 0x0400135C RID: 4956
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400135D RID: 4957
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400135E RID: 4958
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400135F RID: 4959
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200013E RID: 318
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<ReadFinishedAsync>d__36")]
		public sealed class _ReadFinishedAsync_d__36 : ValueType
		{
			// Token: 0x06001902 RID: 6402 RVA: 0x0007DF84 File Offset: 0x0007C184
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadFinishedAsync_d__36()
			{
				Il2CppClassPointerStore<JsonTextReader._ReadFinishedAsync_d__36>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<ReadFinishedAsync>d__36");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._ReadFinishedAsync_d__36>.NativeClassPtr);
				JsonTextReader._ReadFinishedAsync_d__36.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadFinishedAsync_d__36>.NativeClassPtr, "<>1__state");
				JsonTextReader._ReadFinishedAsync_d__36.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadFinishedAsync_d__36>.NativeClassPtr, "<>t__builder");
				JsonTextReader._ReadFinishedAsync_d__36.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadFinishedAsync_d__36>.NativeClassPtr, "<>4__this");
				JsonTextReader._ReadFinishedAsync_d__36.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadFinishedAsync_d__36>.NativeClassPtr, "cancellationToken");
				JsonTextReader._ReadFinishedAsync_d__36.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadFinishedAsync_d__36>.NativeClassPtr, "<>u__1");
				JsonTextReader._ReadFinishedAsync_d__36.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadFinishedAsync_d__36>.NativeClassPtr, "<>u__2");
				JsonTextReader._ReadFinishedAsync_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ReadFinishedAsync_d__36>.NativeClassPtr, 100663977);
				JsonTextReader._ReadFinishedAsync_d__36.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ReadFinishedAsync_d__36>.NativeClassPtr, 100663978);
			}

			// Token: 0x06001903 RID: 6403 RVA: 0x0007E050 File Offset: 0x0007C250
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731637, XrefRangeEnd = 731671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ReadFinishedAsync_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001904 RID: 6404 RVA: 0x0007E088 File Offset: 0x0007C288
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731671, XrefRangeEnd = 731675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ReadFinishedAsync_d__36.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001905 RID: 6405 RVA: 0x0000B1FF File Offset: 0x000093FF
			public _ReadFinishedAsync_d__36(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001906 RID: 6406 RVA: 0x0000B208 File Offset: 0x00009408
			public _ReadFinishedAsync_d__36()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._ReadFinishedAsync_d__36>.NativeClassPtr))
			{
			}

			// Token: 0x170006CE RID: 1742
			// (get) Token: 0x06001907 RID: 6407 RVA: 0x0007E0D0 File Offset: 0x0007C2D0
			// (set) Token: 0x06001908 RID: 6408 RVA: 0x0000B21A File Offset: 0x0000941A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadFinishedAsync_d__36.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadFinishedAsync_d__36.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006CF RID: 1743
			// (get) Token: 0x06001909 RID: 6409 RVA: 0x0007E0F8 File Offset: 0x0007C2F8
			// (set) Token: 0x0600190A RID: 6410 RVA: 0x0000B235 File Offset: 0x00009435
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadFinishedAsync_d__36.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadFinishedAsync_d__36.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006D0 RID: 1744
			// (get) Token: 0x0600190B RID: 6411 RVA: 0x0007E128 File Offset: 0x0007C328
			// (set) Token: 0x0600190C RID: 6412 RVA: 0x0000B263 File Offset: 0x00009463
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadFinishedAsync_d__36.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadFinishedAsync_d__36.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006D1 RID: 1745
			// (get) Token: 0x0600190D RID: 6413 RVA: 0x0007E158 File Offset: 0x0007C358
			// (set) Token: 0x0600190E RID: 6414 RVA: 0x0000B282 File Offset: 0x00009482
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadFinishedAsync_d__36.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadFinishedAsync_d__36.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006D2 RID: 1746
			// (get) Token: 0x0600190F RID: 6415 RVA: 0x0007E188 File Offset: 0x0007C388
			// (set) Token: 0x06001910 RID: 6416 RVA: 0x0000B2B0 File Offset: 0x000094B0
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadFinishedAsync_d__36.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadFinishedAsync_d__36.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006D3 RID: 1747
			// (get) Token: 0x06001911 RID: 6417 RVA: 0x0007E1B8 File Offset: 0x0007C3B8
			// (set) Token: 0x06001912 RID: 6418 RVA: 0x0000B2DE File Offset: 0x000094DE
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadFinishedAsync_d__36.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadFinishedAsync_d__36.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001360 RID: 4960
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001361 RID: 4961
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001362 RID: 4962
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001363 RID: 4963
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001364 RID: 4964
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001365 RID: 4965
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04001366 RID: 4966
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001367 RID: 4967
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200013F RID: 319
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<ReadFromFinishedAsync>d__5")]
		public sealed class _ReadFromFinishedAsync_d__5 : ValueType
		{
			// Token: 0x06001913 RID: 6419 RVA: 0x0007E1E8 File Offset: 0x0007C3E8
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadFromFinishedAsync_d__5()
			{
				Il2CppClassPointerStore<JsonTextReader._ReadFromFinishedAsync_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<ReadFromFinishedAsync>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._ReadFromFinishedAsync_d__5>.NativeClassPtr);
				JsonTextReader._ReadFromFinishedAsync_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadFromFinishedAsync_d__5>.NativeClassPtr, "<>1__state");
				JsonTextReader._ReadFromFinishedAsync_d__5.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadFromFinishedAsync_d__5>.NativeClassPtr, "<>t__builder");
				JsonTextReader._ReadFromFinishedAsync_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadFromFinishedAsync_d__5>.NativeClassPtr, "<>4__this");
				JsonTextReader._ReadFromFinishedAsync_d__5.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadFromFinishedAsync_d__5>.NativeClassPtr, "cancellationToken");
				JsonTextReader._ReadFromFinishedAsync_d__5.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadFromFinishedAsync_d__5>.NativeClassPtr, "<>u__1");
				JsonTextReader._ReadFromFinishedAsync_d__5.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadFromFinishedAsync_d__5>.NativeClassPtr, "<>u__2");
				JsonTextReader._ReadFromFinishedAsync_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ReadFromFinishedAsync_d__5>.NativeClassPtr, 100663979);
				JsonTextReader._ReadFromFinishedAsync_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ReadFromFinishedAsync_d__5>.NativeClassPtr, 100663980);
			}

			// Token: 0x06001914 RID: 6420 RVA: 0x0007E2B4 File Offset: 0x0007C4B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731675, XrefRangeEnd = 731720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ReadFromFinishedAsync_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001915 RID: 6421 RVA: 0x0007E2EC File Offset: 0x0007C4EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731720, XrefRangeEnd = 731726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ReadFromFinishedAsync_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001916 RID: 6422 RVA: 0x0000B30C File Offset: 0x0000950C
			public _ReadFromFinishedAsync_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001917 RID: 6423 RVA: 0x0000B315 File Offset: 0x00009515
			public _ReadFromFinishedAsync_d__5()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._ReadFromFinishedAsync_d__5>.NativeClassPtr))
			{
			}

			// Token: 0x170006D4 RID: 1748
			// (get) Token: 0x06001918 RID: 6424 RVA: 0x0007E334 File Offset: 0x0007C534
			// (set) Token: 0x06001919 RID: 6425 RVA: 0x0000B327 File Offset: 0x00009527
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadFromFinishedAsync_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadFromFinishedAsync_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006D5 RID: 1749
			// (get) Token: 0x0600191A RID: 6426 RVA: 0x0007E35C File Offset: 0x0007C55C
			// (set) Token: 0x0600191B RID: 6427 RVA: 0x0000B342 File Offset: 0x00009542
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadFromFinishedAsync_d__5.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadFromFinishedAsync_d__5.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006D6 RID: 1750
			// (get) Token: 0x0600191C RID: 6428 RVA: 0x0007E38C File Offset: 0x0007C58C
			// (set) Token: 0x0600191D RID: 6429 RVA: 0x0000B370 File Offset: 0x00009570
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadFromFinishedAsync_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadFromFinishedAsync_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006D7 RID: 1751
			// (get) Token: 0x0600191E RID: 6430 RVA: 0x0007E3BC File Offset: 0x0007C5BC
			// (set) Token: 0x0600191F RID: 6431 RVA: 0x0000B38F File Offset: 0x0000958F
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadFromFinishedAsync_d__5.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadFromFinishedAsync_d__5.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006D8 RID: 1752
			// (get) Token: 0x06001920 RID: 6432 RVA: 0x0007E3EC File Offset: 0x0007C5EC
			// (set) Token: 0x06001921 RID: 6433 RVA: 0x0000B3BD File Offset: 0x000095BD
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadFromFinishedAsync_d__5.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadFromFinishedAsync_d__5.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006D9 RID: 1753
			// (get) Token: 0x06001922 RID: 6434 RVA: 0x0007E41C File Offset: 0x0007C61C
			// (set) Token: 0x06001923 RID: 6435 RVA: 0x0000B3EB File Offset: 0x000095EB
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadFromFinishedAsync_d__5.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadFromFinishedAsync_d__5.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001368 RID: 4968
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001369 RID: 4969
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400136A RID: 4970
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400136B RID: 4971
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400136C RID: 4972
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400136D RID: 4973
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400136E RID: 4974
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400136F RID: 4975
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000140 RID: 320
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<ReadIntoWrappedTypeObjectAsync>d__43")]
		public sealed class _ReadIntoWrappedTypeObjectAsync_d__43 : ValueType
		{
			// Token: 0x06001924 RID: 6436 RVA: 0x0007E44C File Offset: 0x0007C64C
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadIntoWrappedTypeObjectAsync_d__43()
			{
				Il2CppClassPointerStore<JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<ReadIntoWrappedTypeObjectAsync>d__43");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43>.NativeClassPtr);
				JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43>.NativeClassPtr, "<>1__state");
				JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43>.NativeClassPtr, "<>t__builder");
				JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43>.NativeClassPtr, "<>4__this");
				JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43>.NativeClassPtr, "cancellationToken");
				JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43>.NativeClassPtr, "<>u__1");
				JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43>.NativeClassPtr, 100663981);
				JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43>.NativeClassPtr, 100663982);
			}

			// Token: 0x06001925 RID: 6437 RVA: 0x0007E504 File Offset: 0x0007C704
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731726, XrefRangeEnd = 731760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001926 RID: 6438 RVA: 0x0007E53C File Offset: 0x0007C73C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731760, XrefRangeEnd = 731764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001927 RID: 6439 RVA: 0x0000B419 File Offset: 0x00009619
			public _ReadIntoWrappedTypeObjectAsync_d__43(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001928 RID: 6440 RVA: 0x0000B422 File Offset: 0x00009622
			public _ReadIntoWrappedTypeObjectAsync_d__43()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43>.NativeClassPtr))
			{
			}

			// Token: 0x170006DA RID: 1754
			// (get) Token: 0x06001929 RID: 6441 RVA: 0x0007E584 File Offset: 0x0007C784
			// (set) Token: 0x0600192A RID: 6442 RVA: 0x0000B434 File Offset: 0x00009634
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006DB RID: 1755
			// (get) Token: 0x0600192B RID: 6443 RVA: 0x0007E5AC File Offset: 0x0007C7AC
			// (set) Token: 0x0600192C RID: 6444 RVA: 0x0000B44F File Offset: 0x0000964F
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006DC RID: 1756
			// (get) Token: 0x0600192D RID: 6445 RVA: 0x0007E5DC File Offset: 0x0007C7DC
			// (set) Token: 0x0600192E RID: 6446 RVA: 0x0000B47D File Offset: 0x0000967D
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006DD RID: 1757
			// (get) Token: 0x0600192F RID: 6447 RVA: 0x0007E60C File Offset: 0x0007C80C
			// (set) Token: 0x06001930 RID: 6448 RVA: 0x0000B49C File Offset: 0x0000969C
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006DE RID: 1758
			// (get) Token: 0x06001931 RID: 6449 RVA: 0x0007E63C File Offset: 0x0007C83C
			// (set) Token: 0x06001932 RID: 6450 RVA: 0x0000B4CA File Offset: 0x000096CA
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadIntoWrappedTypeObjectAsync_d__43.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001370 RID: 4976
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001371 RID: 4977
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001372 RID: 4978
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001373 RID: 4979
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001374 RID: 4980
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001375 RID: 4981
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001376 RID: 4982
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000141 RID: 321
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<ReadNullCharAsync>d__34")]
		public sealed class _ReadNullCharAsync_d__34 : ValueType
		{
			// Token: 0x06001933 RID: 6451 RVA: 0x0007E66C File Offset: 0x0007C86C
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadNullCharAsync_d__34()
			{
				Il2CppClassPointerStore<JsonTextReader._ReadNullCharAsync_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<ReadNullCharAsync>d__34");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._ReadNullCharAsync_d__34>.NativeClassPtr);
				JsonTextReader._ReadNullCharAsync_d__34.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadNullCharAsync_d__34>.NativeClassPtr, "<>1__state");
				JsonTextReader._ReadNullCharAsync_d__34.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadNullCharAsync_d__34>.NativeClassPtr, "<>t__builder");
				JsonTextReader._ReadNullCharAsync_d__34.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadNullCharAsync_d__34>.NativeClassPtr, "<>4__this");
				JsonTextReader._ReadNullCharAsync_d__34.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadNullCharAsync_d__34>.NativeClassPtr, "cancellationToken");
				JsonTextReader._ReadNullCharAsync_d__34.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadNullCharAsync_d__34>.NativeClassPtr, "<>u__1");
				JsonTextReader._ReadNullCharAsync_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ReadNullCharAsync_d__34>.NativeClassPtr, 100663983);
				JsonTextReader._ReadNullCharAsync_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ReadNullCharAsync_d__34>.NativeClassPtr, 100663984);
			}

			// Token: 0x06001934 RID: 6452 RVA: 0x0007E724 File Offset: 0x0007C924
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731764, XrefRangeEnd = 731785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ReadNullCharAsync_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001935 RID: 6453 RVA: 0x0007E75C File Offset: 0x0007C95C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731785, XrefRangeEnd = 731791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ReadNullCharAsync_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001936 RID: 6454 RVA: 0x0000B4F8 File Offset: 0x000096F8
			public _ReadNullCharAsync_d__34(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001937 RID: 6455 RVA: 0x0000B501 File Offset: 0x00009701
			public _ReadNullCharAsync_d__34()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._ReadNullCharAsync_d__34>.NativeClassPtr))
			{
			}

			// Token: 0x170006DF RID: 1759
			// (get) Token: 0x06001938 RID: 6456 RVA: 0x0007E7A4 File Offset: 0x0007C9A4
			// (set) Token: 0x06001939 RID: 6457 RVA: 0x0000B513 File Offset: 0x00009713
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNullCharAsync_d__34.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNullCharAsync_d__34.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006E0 RID: 1760
			// (get) Token: 0x0600193A RID: 6458 RVA: 0x0007E7CC File Offset: 0x0007C9CC
			// (set) Token: 0x0600193B RID: 6459 RVA: 0x0000B52E File Offset: 0x0000972E
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNullCharAsync_d__34.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNullCharAsync_d__34.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006E1 RID: 1761
			// (get) Token: 0x0600193C RID: 6460 RVA: 0x0007E7FC File Offset: 0x0007C9FC
			// (set) Token: 0x0600193D RID: 6461 RVA: 0x0000B55C File Offset: 0x0000975C
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNullCharAsync_d__34.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNullCharAsync_d__34.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E2 RID: 1762
			// (get) Token: 0x0600193E RID: 6462 RVA: 0x0007E82C File Offset: 0x0007CA2C
			// (set) Token: 0x0600193F RID: 6463 RVA: 0x0000B57B File Offset: 0x0000977B
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNullCharAsync_d__34.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNullCharAsync_d__34.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006E3 RID: 1763
			// (get) Token: 0x06001940 RID: 6464 RVA: 0x0007E85C File Offset: 0x0007CA5C
			// (set) Token: 0x06001941 RID: 6465 RVA: 0x0000B5A9 File Offset: 0x000097A9
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNullCharAsync_d__34.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNullCharAsync_d__34.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001377 RID: 4983
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001378 RID: 4984
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001379 RID: 4985
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400137A RID: 4986
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400137B RID: 4987
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400137C RID: 4988
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400137D RID: 4989
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000142 RID: 322
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<ReadNumberIntoBufferAsync>d__32")]
		public sealed class _ReadNumberIntoBufferAsync_d__32 : ValueType
		{
			// Token: 0x06001942 RID: 6466 RVA: 0x0007E88C File Offset: 0x0007CA8C
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadNumberIntoBufferAsync_d__32()
			{
				Il2CppClassPointerStore<JsonTextReader._ReadNumberIntoBufferAsync_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<ReadNumberIntoBufferAsync>d__32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._ReadNumberIntoBufferAsync_d__32>.NativeClassPtr);
				JsonTextReader._ReadNumberIntoBufferAsync_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadNumberIntoBufferAsync_d__32>.NativeClassPtr, "<>1__state");
				JsonTextReader._ReadNumberIntoBufferAsync_d__32.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadNumberIntoBufferAsync_d__32>.NativeClassPtr, "<>t__builder");
				JsonTextReader._ReadNumberIntoBufferAsync_d__32.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadNumberIntoBufferAsync_d__32>.NativeClassPtr, "<>4__this");
				JsonTextReader._ReadNumberIntoBufferAsync_d__32.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadNumberIntoBufferAsync_d__32>.NativeClassPtr, "cancellationToken");
				JsonTextReader._ReadNumberIntoBufferAsync_d__32.NativeFieldInfoPtr__charPos_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadNumberIntoBufferAsync_d__32>.NativeClassPtr, "<charPos>5__2");
				JsonTextReader._ReadNumberIntoBufferAsync_d__32.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadNumberIntoBufferAsync_d__32>.NativeClassPtr, "<>u__1");
				JsonTextReader._ReadNumberIntoBufferAsync_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ReadNumberIntoBufferAsync_d__32>.NativeClassPtr, 100663985);
				JsonTextReader._ReadNumberIntoBufferAsync_d__32.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ReadNumberIntoBufferAsync_d__32>.NativeClassPtr, 100663986);
			}

			// Token: 0x06001943 RID: 6467 RVA: 0x0007E958 File Offset: 0x0007CB58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731791, XrefRangeEnd = 731811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ReadNumberIntoBufferAsync_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001944 RID: 6468 RVA: 0x0007E990 File Offset: 0x0007CB90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731811, XrefRangeEnd = 731815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ReadNumberIntoBufferAsync_d__32.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001945 RID: 6469 RVA: 0x0000B5D7 File Offset: 0x000097D7
			public _ReadNumberIntoBufferAsync_d__32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001946 RID: 6470 RVA: 0x0000B5E0 File Offset: 0x000097E0
			public _ReadNumberIntoBufferAsync_d__32()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._ReadNumberIntoBufferAsync_d__32>.NativeClassPtr))
			{
			}

			// Token: 0x170006E4 RID: 1764
			// (get) Token: 0x06001947 RID: 6471 RVA: 0x0007E9D8 File Offset: 0x0007CBD8
			// (set) Token: 0x06001948 RID: 6472 RVA: 0x0000B5F2 File Offset: 0x000097F2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberIntoBufferAsync_d__32.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberIntoBufferAsync_d__32.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006E5 RID: 1765
			// (get) Token: 0x06001949 RID: 6473 RVA: 0x0007EA00 File Offset: 0x0007CC00
			// (set) Token: 0x0600194A RID: 6474 RVA: 0x0000B60D File Offset: 0x0000980D
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberIntoBufferAsync_d__32.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberIntoBufferAsync_d__32.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006E6 RID: 1766
			// (get) Token: 0x0600194B RID: 6475 RVA: 0x0007EA30 File Offset: 0x0007CC30
			// (set) Token: 0x0600194C RID: 6476 RVA: 0x0000B63B File Offset: 0x0000983B
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberIntoBufferAsync_d__32.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberIntoBufferAsync_d__32.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E7 RID: 1767
			// (get) Token: 0x0600194D RID: 6477 RVA: 0x0007EA60 File Offset: 0x0007CC60
			// (set) Token: 0x0600194E RID: 6478 RVA: 0x0000B65A File Offset: 0x0000985A
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberIntoBufferAsync_d__32.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberIntoBufferAsync_d__32.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006E8 RID: 1768
			// (get) Token: 0x0600194F RID: 6479 RVA: 0x0007EA90 File Offset: 0x0007CC90
			// (set) Token: 0x06001950 RID: 6480 RVA: 0x0000B688 File Offset: 0x00009888
			public unsafe int _charPos_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberIntoBufferAsync_d__32.NativeFieldInfoPtr__charPos_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberIntoBufferAsync_d__32.NativeFieldInfoPtr__charPos_5__2)) = value;
				}
			}

			// Token: 0x170006E9 RID: 1769
			// (get) Token: 0x06001951 RID: 6481 RVA: 0x0007EAB8 File Offset: 0x0007CCB8
			// (set) Token: 0x06001952 RID: 6482 RVA: 0x0000B6A3 File Offset: 0x000098A3
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberIntoBufferAsync_d__32.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberIntoBufferAsync_d__32.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400137E RID: 4990
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400137F RID: 4991
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001380 RID: 4992
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001381 RID: 4993
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001382 RID: 4994
			private static readonly IntPtr NativeFieldInfoPtr__charPos_5__2;

			// Token: 0x04001383 RID: 4995
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001384 RID: 4996
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001385 RID: 4997
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000143 RID: 323
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<ReadNumberValueAsync>d__38")]
		public sealed class _ReadNumberValueAsync_d__38 : ValueType
		{
			// Token: 0x06001953 RID: 6483 RVA: 0x0007EAE8 File Offset: 0x0007CCE8
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadNumberValueAsync_d__38()
			{
				Il2CppClassPointerStore<JsonTextReader._ReadNumberValueAsync_d__38>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<ReadNumberValueAsync>d__38");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._ReadNumberValueAsync_d__38>.NativeClassPtr);
				JsonTextReader._ReadNumberValueAsync_d__38.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadNumberValueAsync_d__38>.NativeClassPtr, "<>1__state");
				JsonTextReader._ReadNumberValueAsync_d__38.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadNumberValueAsync_d__38>.NativeClassPtr, "<>t__builder");
				JsonTextReader._ReadNumberValueAsync_d__38.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadNumberValueAsync_d__38>.NativeClassPtr, "<>4__this");
				JsonTextReader._ReadNumberValueAsync_d__38.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadNumberValueAsync_d__38>.NativeClassPtr, "cancellationToken");
				JsonTextReader._ReadNumberValueAsync_d__38.NativeFieldInfoPtr_readType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadNumberValueAsync_d__38>.NativeClassPtr, "readType");
				JsonTextReader._ReadNumberValueAsync_d__38.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadNumberValueAsync_d__38>.NativeClassPtr, "<>u__1");
				JsonTextReader._ReadNumberValueAsync_d__38.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadNumberValueAsync_d__38>.NativeClassPtr, "<>u__2");
				JsonTextReader._ReadNumberValueAsync_d__38.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadNumberValueAsync_d__38>.NativeClassPtr, "<>u__3");
				JsonTextReader._ReadNumberValueAsync_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ReadNumberValueAsync_d__38>.NativeClassPtr, 100663987);
				JsonTextReader._ReadNumberValueAsync_d__38.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ReadNumberValueAsync_d__38>.NativeClassPtr, 100663988);
			}

			// Token: 0x06001954 RID: 6484 RVA: 0x0007EBDC File Offset: 0x0007CDDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731815, XrefRangeEnd = 732014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ReadNumberValueAsync_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001955 RID: 6485 RVA: 0x0007EC14 File Offset: 0x0007CE14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732014, XrefRangeEnd = 732020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ReadNumberValueAsync_d__38.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001956 RID: 6486 RVA: 0x0000B6D1 File Offset: 0x000098D1
			public _ReadNumberValueAsync_d__38(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001957 RID: 6487 RVA: 0x0000B6DA File Offset: 0x000098DA
			public _ReadNumberValueAsync_d__38()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._ReadNumberValueAsync_d__38>.NativeClassPtr))
			{
			}

			// Token: 0x170006EA RID: 1770
			// (get) Token: 0x06001958 RID: 6488 RVA: 0x0007EC5C File Offset: 0x0007CE5C
			// (set) Token: 0x06001959 RID: 6489 RVA: 0x0000B6EC File Offset: 0x000098EC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberValueAsync_d__38.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberValueAsync_d__38.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006EB RID: 1771
			// (get) Token: 0x0600195A RID: 6490 RVA: 0x0007EC84 File Offset: 0x0007CE84
			// (set) Token: 0x0600195B RID: 6491 RVA: 0x0000B707 File Offset: 0x00009907
			public AsyncTaskMethodBuilder<Object> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberValueAsync_d__38.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberValueAsync_d__38.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006EC RID: 1772
			// (get) Token: 0x0600195C RID: 6492 RVA: 0x0007ECB4 File Offset: 0x0007CEB4
			// (set) Token: 0x0600195D RID: 6493 RVA: 0x0000B735 File Offset: 0x00009935
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberValueAsync_d__38.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberValueAsync_d__38.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006ED RID: 1773
			// (get) Token: 0x0600195E RID: 6494 RVA: 0x0007ECE4 File Offset: 0x0007CEE4
			// (set) Token: 0x0600195F RID: 6495 RVA: 0x0000B754 File Offset: 0x00009954
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberValueAsync_d__38.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberValueAsync_d__38.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006EE RID: 1774
			// (get) Token: 0x06001960 RID: 6496 RVA: 0x0007ED14 File Offset: 0x0007CF14
			// (set) Token: 0x06001961 RID: 6497 RVA: 0x0000B782 File Offset: 0x00009982
			public unsafe ReadType readType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberValueAsync_d__38.NativeFieldInfoPtr_readType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberValueAsync_d__38.NativeFieldInfoPtr_readType)) = value;
				}
			}

			// Token: 0x170006EF RID: 1775
			// (get) Token: 0x06001962 RID: 6498 RVA: 0x0007ED3C File Offset: 0x0007CF3C
			// (set) Token: 0x06001963 RID: 6499 RVA: 0x0000B79D File Offset: 0x0000999D
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberValueAsync_d__38.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberValueAsync_d__38.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006F0 RID: 1776
			// (get) Token: 0x06001964 RID: 6500 RVA: 0x0007ED6C File Offset: 0x0007CF6C
			// (set) Token: 0x06001965 RID: 6501 RVA: 0x0000B7CB File Offset: 0x000099CB
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberValueAsync_d__38.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberValueAsync_d__38.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006F1 RID: 1777
			// (get) Token: 0x06001966 RID: 6502 RVA: 0x0007ED9C File Offset: 0x0007CF9C
			// (set) Token: 0x06001967 RID: 6503 RVA: 0x0000B7F9 File Offset: 0x000099F9
			public ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberValueAsync_d__38.NativeFieldInfoPtr___u__3);
					return new ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadNumberValueAsync_d__38.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001386 RID: 4998
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001387 RID: 4999
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001388 RID: 5000
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001389 RID: 5001
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400138A RID: 5002
			private static readonly IntPtr NativeFieldInfoPtr_readType;

			// Token: 0x0400138B RID: 5003
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400138C RID: 5004
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400138D RID: 5005
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x0400138E RID: 5006
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400138F RID: 5007
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000144 RID: 324
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<ReadStringIntoBufferAsync>d__9")]
		public sealed class _ReadStringIntoBufferAsync_d__9 : ValueType
		{
			// Token: 0x06001968 RID: 6504 RVA: 0x0007EDCC File Offset: 0x0007CFCC
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadStringIntoBufferAsync_d__9()
			{
				Il2CppClassPointerStore<JsonTextReader._ReadStringIntoBufferAsync_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<ReadStringIntoBufferAsync>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._ReadStringIntoBufferAsync_d__9>.NativeClassPtr);
				JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadStringIntoBufferAsync_d__9>.NativeClassPtr, "<>1__state");
				JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadStringIntoBufferAsync_d__9>.NativeClassPtr, "<>t__builder");
				JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadStringIntoBufferAsync_d__9>.NativeClassPtr, "<>4__this");
				JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadStringIntoBufferAsync_d__9>.NativeClassPtr, "cancellationToken");
				JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr_quote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadStringIntoBufferAsync_d__9>.NativeClassPtr, "quote");
				JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr__charPos_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadStringIntoBufferAsync_d__9>.NativeClassPtr, "<charPos>5__2");
				JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr__initialPosition_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadStringIntoBufferAsync_d__9>.NativeClassPtr, "<initialPosition>5__3");
				JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr__lastWritePosition_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadStringIntoBufferAsync_d__9>.NativeClassPtr, "<lastWritePosition>5__4");
				JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr__escapeStartPos_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadStringIntoBufferAsync_d__9>.NativeClassPtr, "<escapeStartPos>5__5");
				JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr__writeChar_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadStringIntoBufferAsync_d__9>.NativeClassPtr, "<writeChar>5__6");
				JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadStringIntoBufferAsync_d__9>.NativeClassPtr, "<>u__1");
				JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadStringIntoBufferAsync_d__9>.NativeClassPtr, "<>u__2");
				JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadStringIntoBufferAsync_d__9>.NativeClassPtr, "<>u__3");
				JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr__anotherHighSurrogate_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadStringIntoBufferAsync_d__9>.NativeClassPtr, "<anotherHighSurrogate>5__7");
				JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr__highSurrogate_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadStringIntoBufferAsync_d__9>.NativeClassPtr, "<highSurrogate>5__8");
				JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr___u__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadStringIntoBufferAsync_d__9>.NativeClassPtr, "<>u__4");
				JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ReadStringIntoBufferAsync_d__9>.NativeClassPtr, 100663989);
				JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ReadStringIntoBufferAsync_d__9>.NativeClassPtr, 100663990);
			}

			// Token: 0x06001969 RID: 6505 RVA: 0x0007EF60 File Offset: 0x0007D160
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732020, XrefRangeEnd = 732117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600196A RID: 6506 RVA: 0x0007EF98 File Offset: 0x0007D198
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732117, XrefRangeEnd = 732121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600196B RID: 6507 RVA: 0x0000B827 File Offset: 0x00009A27
			public _ReadStringIntoBufferAsync_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600196C RID: 6508 RVA: 0x0000B830 File Offset: 0x00009A30
			public _ReadStringIntoBufferAsync_d__9()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._ReadStringIntoBufferAsync_d__9>.NativeClassPtr))
			{
			}

			// Token: 0x170006F2 RID: 1778
			// (get) Token: 0x0600196D RID: 6509 RVA: 0x0007EFE0 File Offset: 0x0007D1E0
			// (set) Token: 0x0600196E RID: 6510 RVA: 0x0000B842 File Offset: 0x00009A42
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006F3 RID: 1779
			// (get) Token: 0x0600196F RID: 6511 RVA: 0x0007F008 File Offset: 0x0007D208
			// (set) Token: 0x06001970 RID: 6512 RVA: 0x0000B85D File Offset: 0x00009A5D
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006F4 RID: 1780
			// (get) Token: 0x06001971 RID: 6513 RVA: 0x0007F038 File Offset: 0x0007D238
			// (set) Token: 0x06001972 RID: 6514 RVA: 0x0000B88B File Offset: 0x00009A8B
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006F5 RID: 1781
			// (get) Token: 0x06001973 RID: 6515 RVA: 0x0007F068 File Offset: 0x0007D268
			// (set) Token: 0x06001974 RID: 6516 RVA: 0x0000B8AA File Offset: 0x00009AAA
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006F6 RID: 1782
			// (get) Token: 0x06001975 RID: 6517 RVA: 0x0007F098 File Offset: 0x0007D298
			// (set) Token: 0x06001976 RID: 6518 RVA: 0x0000B8D8 File Offset: 0x00009AD8
			public unsafe char quote
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr_quote);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr_quote)) = value;
				}
			}

			// Token: 0x170006F7 RID: 1783
			// (get) Token: 0x06001977 RID: 6519 RVA: 0x0007F0C0 File Offset: 0x0007D2C0
			// (set) Token: 0x06001978 RID: 6520 RVA: 0x0000B8F3 File Offset: 0x00009AF3
			public unsafe int _charPos_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr__charPos_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr__charPos_5__2)) = value;
				}
			}

			// Token: 0x170006F8 RID: 1784
			// (get) Token: 0x06001979 RID: 6521 RVA: 0x0007F0E8 File Offset: 0x0007D2E8
			// (set) Token: 0x0600197A RID: 6522 RVA: 0x0000B90E File Offset: 0x00009B0E
			public unsafe int _initialPosition_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr__initialPosition_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr__initialPosition_5__3)) = value;
				}
			}

			// Token: 0x170006F9 RID: 1785
			// (get) Token: 0x0600197B RID: 6523 RVA: 0x0007F110 File Offset: 0x0007D310
			// (set) Token: 0x0600197C RID: 6524 RVA: 0x0000B929 File Offset: 0x00009B29
			public unsafe int _lastWritePosition_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr__lastWritePosition_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr__lastWritePosition_5__4)) = value;
				}
			}

			// Token: 0x170006FA RID: 1786
			// (get) Token: 0x0600197D RID: 6525 RVA: 0x0007F138 File Offset: 0x0007D338
			// (set) Token: 0x0600197E RID: 6526 RVA: 0x0000B944 File Offset: 0x00009B44
			public unsafe int _escapeStartPos_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr__escapeStartPos_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr__escapeStartPos_5__5)) = value;
				}
			}

			// Token: 0x170006FB RID: 1787
			// (get) Token: 0x0600197F RID: 6527 RVA: 0x0007F160 File Offset: 0x0007D360
			// (set) Token: 0x06001980 RID: 6528 RVA: 0x0000B95F File Offset: 0x00009B5F
			public unsafe char _writeChar_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr__writeChar_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr__writeChar_5__6)) = value;
				}
			}

			// Token: 0x170006FC RID: 1788
			// (get) Token: 0x06001981 RID: 6529 RVA: 0x0007F188 File Offset: 0x0007D388
			// (set) Token: 0x06001982 RID: 6530 RVA: 0x0000B97A File Offset: 0x00009B7A
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006FD RID: 1789
			// (get) Token: 0x06001983 RID: 6531 RVA: 0x0007F1B8 File Offset: 0x0007D3B8
			// (set) Token: 0x06001984 RID: 6532 RVA: 0x0000B9A8 File Offset: 0x00009BA8
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006FE RID: 1790
			// (get) Token: 0x06001985 RID: 6533 RVA: 0x0007F1E8 File Offset: 0x0007D3E8
			// (set) Token: 0x06001986 RID: 6534 RVA: 0x0000B9D6 File Offset: 0x00009BD6
			public ConfiguredTaskAwaitable<char>.ConfiguredTaskAwaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr___u__3);
					return new ConfiguredTaskAwaitable<char>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<char>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<char>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006FF RID: 1791
			// (get) Token: 0x06001987 RID: 6535 RVA: 0x0007F218 File Offset: 0x0007D418
			// (set) Token: 0x06001988 RID: 6536 RVA: 0x0000BA04 File Offset: 0x00009C04
			public unsafe bool _anotherHighSurrogate_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr__anotherHighSurrogate_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr__anotherHighSurrogate_5__7)) = value;
				}
			}

			// Token: 0x17000700 RID: 1792
			// (get) Token: 0x06001989 RID: 6537 RVA: 0x0007F240 File Offset: 0x0007D440
			// (set) Token: 0x0600198A RID: 6538 RVA: 0x0000BA1F File Offset: 0x00009C1F
			public unsafe char _highSurrogate_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr__highSurrogate_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr__highSurrogate_5__8)) = value;
				}
			}

			// Token: 0x17000701 RID: 1793
			// (get) Token: 0x0600198B RID: 6539 RVA: 0x0007F268 File Offset: 0x0007D468
			// (set) Token: 0x0600198C RID: 6540 RVA: 0x0000BA3A File Offset: 0x00009C3A
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr___u__4);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringIntoBufferAsync_d__9.NativeFieldInfoPtr___u__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001390 RID: 5008
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001391 RID: 5009
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001392 RID: 5010
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001393 RID: 5011
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001394 RID: 5012
			private static readonly IntPtr NativeFieldInfoPtr_quote;

			// Token: 0x04001395 RID: 5013
			private static readonly IntPtr NativeFieldInfoPtr__charPos_5__2;

			// Token: 0x04001396 RID: 5014
			private static readonly IntPtr NativeFieldInfoPtr__initialPosition_5__3;

			// Token: 0x04001397 RID: 5015
			private static readonly IntPtr NativeFieldInfoPtr__lastWritePosition_5__4;

			// Token: 0x04001398 RID: 5016
			private static readonly IntPtr NativeFieldInfoPtr__escapeStartPos_5__5;

			// Token: 0x04001399 RID: 5017
			private static readonly IntPtr NativeFieldInfoPtr__writeChar_5__6;

			// Token: 0x0400139A RID: 5018
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400139B RID: 5019
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400139C RID: 5020
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x0400139D RID: 5021
			private static readonly IntPtr NativeFieldInfoPtr__anotherHighSurrogate_5__7;

			// Token: 0x0400139E RID: 5022
			private static readonly IntPtr NativeFieldInfoPtr__highSurrogate_5__8;

			// Token: 0x0400139F RID: 5023
			private static readonly IntPtr NativeFieldInfoPtr___u__4;

			// Token: 0x040013A0 RID: 5024
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040013A1 RID: 5025
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000145 RID: 325
		[ObfuscatedName("Newtonsoft.Json.JsonTextReader+<ReadStringValueAsync>d__37")]
		public sealed class _ReadStringValueAsync_d__37 : ValueType
		{
			// Token: 0x0600198D RID: 6541 RVA: 0x0007F298 File Offset: 0x0007D498
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadStringValueAsync_d__37()
			{
				Il2CppClassPointerStore<JsonTextReader._ReadStringValueAsync_d__37>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTextReader>.NativeClassPtr, "<ReadStringValueAsync>d__37");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTextReader._ReadStringValueAsync_d__37>.NativeClassPtr);
				JsonTextReader._ReadStringValueAsync_d__37.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadStringValueAsync_d__37>.NativeClassPtr, "<>1__state");
				JsonTextReader._ReadStringValueAsync_d__37.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadStringValueAsync_d__37>.NativeClassPtr, "<>t__builder");
				JsonTextReader._ReadStringValueAsync_d__37.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadStringValueAsync_d__37>.NativeClassPtr, "<>4__this");
				JsonTextReader._ReadStringValueAsync_d__37.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadStringValueAsync_d__37>.NativeClassPtr, "cancellationToken");
				JsonTextReader._ReadStringValueAsync_d__37.NativeFieldInfoPtr_readType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadStringValueAsync_d__37>.NativeClassPtr, "readType");
				JsonTextReader._ReadStringValueAsync_d__37.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadStringValueAsync_d__37>.NativeClassPtr, "<>u__1");
				JsonTextReader._ReadStringValueAsync_d__37.NativeFieldInfoPtr__expected_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadStringValueAsync_d__37>.NativeClassPtr, "<expected>5__2");
				JsonTextReader._ReadStringValueAsync_d__37.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadStringValueAsync_d__37>.NativeClassPtr, "<>u__2");
				JsonTextReader._ReadStringValueAsync_d__37.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTextReader._ReadStringValueAsync_d__37>.NativeClassPtr, "<>u__3");
				JsonTextReader._ReadStringValueAsync_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ReadStringValueAsync_d__37>.NativeClassPtr, 100663991);
				JsonTextReader._ReadStringValueAsync_d__37.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTextReader._ReadStringValueAsync_d__37>.NativeClassPtr, 100663992);
			}

			// Token: 0x0600198E RID: 6542 RVA: 0x0007F3A0 File Offset: 0x0007D5A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732121, XrefRangeEnd = 732331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ReadStringValueAsync_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600198F RID: 6543 RVA: 0x0007F3D8 File Offset: 0x0007D5D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732331, XrefRangeEnd = 732337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTextReader._ReadStringValueAsync_d__37.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001990 RID: 6544 RVA: 0x0000BA68 File Offset: 0x00009C68
			public _ReadStringValueAsync_d__37(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001991 RID: 6545 RVA: 0x0000BA71 File Offset: 0x00009C71
			public _ReadStringValueAsync_d__37()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTextReader._ReadStringValueAsync_d__37>.NativeClassPtr))
			{
			}

			// Token: 0x17000702 RID: 1794
			// (get) Token: 0x06001992 RID: 6546 RVA: 0x0007F420 File Offset: 0x0007D620
			// (set) Token: 0x06001993 RID: 6547 RVA: 0x0000BA83 File Offset: 0x00009C83
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringValueAsync_d__37.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringValueAsync_d__37.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000703 RID: 1795
			// (get) Token: 0x06001994 RID: 6548 RVA: 0x0007F448 File Offset: 0x0007D648
			// (set) Token: 0x06001995 RID: 6549 RVA: 0x0000BA9E File Offset: 0x00009C9E
			public AsyncTaskMethodBuilder<Object> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringValueAsync_d__37.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringValueAsync_d__37.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000704 RID: 1796
			// (get) Token: 0x06001996 RID: 6550 RVA: 0x0007F478 File Offset: 0x0007D678
			// (set) Token: 0x06001997 RID: 6551 RVA: 0x0000BACC File Offset: 0x00009CCC
			public unsafe JsonTextReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringValueAsync_d__37.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringValueAsync_d__37.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000705 RID: 1797
			// (get) Token: 0x06001998 RID: 6552 RVA: 0x0007F4A8 File Offset: 0x0007D6A8
			// (set) Token: 0x06001999 RID: 6553 RVA: 0x0000BAEB File Offset: 0x00009CEB
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringValueAsync_d__37.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringValueAsync_d__37.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000706 RID: 1798
			// (get) Token: 0x0600199A RID: 6554 RVA: 0x0007F4D8 File Offset: 0x0007D6D8
			// (set) Token: 0x0600199B RID: 6555 RVA: 0x0000BB19 File Offset: 0x00009D19
			public unsafe ReadType readType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringValueAsync_d__37.NativeFieldInfoPtr_readType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringValueAsync_d__37.NativeFieldInfoPtr_readType)) = value;
				}
			}

			// Token: 0x17000707 RID: 1799
			// (get) Token: 0x0600199C RID: 6556 RVA: 0x0007F500 File Offset: 0x0007D700
			// (set) Token: 0x0600199D RID: 6557 RVA: 0x0000BB34 File Offset: 0x00009D34
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringValueAsync_d__37.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringValueAsync_d__37.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000708 RID: 1800
			// (get) Token: 0x0600199E RID: 6558 RVA: 0x0007F530 File Offset: 0x0007D730
			// (set) Token: 0x0600199F RID: 6559 RVA: 0x0000BB62 File Offset: 0x00009D62
			public unsafe string _expected_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringValueAsync_d__37.NativeFieldInfoPtr__expected_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringValueAsync_d__37.NativeFieldInfoPtr__expected_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000709 RID: 1801
			// (get) Token: 0x060019A0 RID: 6560 RVA: 0x0007F558 File Offset: 0x0007D758
			// (set) Token: 0x060019A1 RID: 6561 RVA: 0x0000BB81 File Offset: 0x00009D81
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringValueAsync_d__37.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringValueAsync_d__37.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700070A RID: 1802
			// (get) Token: 0x060019A2 RID: 6562 RVA: 0x0007F588 File Offset: 0x0007D788
			// (set) Token: 0x060019A3 RID: 6563 RVA: 0x0000BBAF File Offset: 0x00009DAF
			public ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringValueAsync_d__37.NativeFieldInfoPtr___u__3);
					return new ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTextReader._ReadStringValueAsync_d__37.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Object>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040013A2 RID: 5026
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040013A3 RID: 5027
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040013A4 RID: 5028
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040013A5 RID: 5029
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040013A6 RID: 5030
			private static readonly IntPtr NativeFieldInfoPtr_readType;

			// Token: 0x040013A7 RID: 5031
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040013A8 RID: 5032
			private static readonly IntPtr NativeFieldInfoPtr__expected_5__2;

			// Token: 0x040013A9 RID: 5033
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040013AA RID: 5034
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x040013AB RID: 5035
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040013AC RID: 5036
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}

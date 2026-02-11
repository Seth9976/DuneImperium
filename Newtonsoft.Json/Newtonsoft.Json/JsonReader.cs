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
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x02000027 RID: 39
	public class JsonReader : Object
	{
		// Token: 0x06000184 RID: 388 RVA: 0x00017D28 File Offset: 0x00015F28
		// Note: this type is marked as 'beforefieldinit'.
		static JsonReader()
		{
			Il2CppClassPointerStore<JsonReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json", "JsonReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonReader>.NativeClassPtr);
			JsonReader.NativeFieldInfoPtr__tokenType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, "_tokenType");
			JsonReader.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, "_value");
			JsonReader.NativeFieldInfoPtr__quoteChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, "_quoteChar");
			JsonReader.NativeFieldInfoPtr__currentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, "_currentState");
			JsonReader.NativeFieldInfoPtr__currentPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, "_currentPosition");
			JsonReader.NativeFieldInfoPtr__culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, "_culture");
			JsonReader.NativeFieldInfoPtr__dateTimeZoneHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, "_dateTimeZoneHandling");
			JsonReader.NativeFieldInfoPtr__maxDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, "_maxDepth");
			JsonReader.NativeFieldInfoPtr__hasExceededMaxDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, "_hasExceededMaxDepth");
			JsonReader.NativeFieldInfoPtr__dateParseHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, "_dateParseHandling");
			JsonReader.NativeFieldInfoPtr__floatParseHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, "_floatParseHandling");
			JsonReader.NativeFieldInfoPtr__dateFormatString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, "_dateFormatString");
			JsonReader.NativeFieldInfoPtr__stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, "_stack");
			JsonReader.NativeFieldInfoPtr__CloseInput_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, "<CloseInput>k__BackingField");
			JsonReader.NativeFieldInfoPtr__SupportMultipleContent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, "<SupportMultipleContent>k__BackingField");
			JsonReader.NativeMethodInfoPtr_ReadAsync_Public_Virtual_New_Task_1_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663510);
			JsonReader.NativeMethodInfoPtr_SkipAsync_Public_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663511);
			JsonReader.NativeMethodInfoPtr_ReaderReadAndAssertAsync_Internal_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663512);
			JsonReader.NativeMethodInfoPtr_ReadAsBooleanAsync_Public_Virtual_New_Task_1_Nullable_1_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663513);
			JsonReader.NativeMethodInfoPtr_ReadAsBytesAsync_Public_Virtual_New_Task_1_Il2CppStructArray_1_Byte_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663514);
			JsonReader.NativeMethodInfoPtr_ReadArrayIntoByteArrayAsync_Internal_Task_1_Il2CppStructArray_1_Byte_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663515);
			JsonReader.NativeMethodInfoPtr_ReadAsDateTimeAsync_Public_Virtual_New_Task_1_Nullable_1_DateTime_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663516);
			JsonReader.NativeMethodInfoPtr_ReadAsDateTimeOffsetAsync_Public_Virtual_New_Task_1_Nullable_1_DateTimeOffset_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663517);
			JsonReader.NativeMethodInfoPtr_ReadAsDecimalAsync_Public_Virtual_New_Task_1_Nullable_1_Decimal_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663518);
			JsonReader.NativeMethodInfoPtr_ReadAsDoubleAsync_Public_Virtual_New_Task_1_Nullable_1_Double_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663519);
			JsonReader.NativeMethodInfoPtr_ReadAsInt32Async_Public_Virtual_New_Task_1_Nullable_1_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663520);
			JsonReader.NativeMethodInfoPtr_ReadAsStringAsync_Public_Virtual_New_Task_1_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663521);
			JsonReader.NativeMethodInfoPtr_ReadAndMoveToContentAsync_Internal_Task_1_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663522);
			JsonReader.NativeMethodInfoPtr_MoveToContentAsync_Internal_Task_1_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663523);
			JsonReader.NativeMethodInfoPtr_MoveToContentFromNonContentAsync_Private_Task_1_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663524);
			JsonReader.NativeMethodInfoPtr_get_CurrentState_Protected_get_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663525);
			JsonReader.NativeMethodInfoPtr_get_CloseInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663526);
			JsonReader.NativeMethodInfoPtr_set_CloseInput_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663527);
			JsonReader.NativeMethodInfoPtr_get_SupportMultipleContent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663528);
			JsonReader.NativeMethodInfoPtr_set_SupportMultipleContent_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663529);
			JsonReader.NativeMethodInfoPtr_get_QuoteChar_Public_Virtual_New_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663530);
			JsonReader.NativeMethodInfoPtr_set_QuoteChar_FamOrAssem_Virtual_New_set_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663531);
			JsonReader.NativeMethodInfoPtr_get_DateTimeZoneHandling_Public_get_DateTimeZoneHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663532);
			JsonReader.NativeMethodInfoPtr_set_DateTimeZoneHandling_Public_set_Void_DateTimeZoneHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663533);
			JsonReader.NativeMethodInfoPtr_get_DateParseHandling_Public_get_DateParseHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663534);
			JsonReader.NativeMethodInfoPtr_set_DateParseHandling_Public_set_Void_DateParseHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663535);
			JsonReader.NativeMethodInfoPtr_get_FloatParseHandling_Public_get_FloatParseHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663536);
			JsonReader.NativeMethodInfoPtr_set_FloatParseHandling_Public_set_Void_FloatParseHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663537);
			JsonReader.NativeMethodInfoPtr_get_DateFormatString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663538);
			JsonReader.NativeMethodInfoPtr_set_DateFormatString_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663539);
			JsonReader.NativeMethodInfoPtr_get_MaxDepth_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663540);
			JsonReader.NativeMethodInfoPtr_set_MaxDepth_Public_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663541);
			JsonReader.NativeMethodInfoPtr_get_TokenType_Public_Virtual_New_get_JsonToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663542);
			JsonReader.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663543);
			JsonReader.NativeMethodInfoPtr_get_ValueType_Public_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663544);
			JsonReader.NativeMethodInfoPtr_get_Depth_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663545);
			JsonReader.NativeMethodInfoPtr_get_Path_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663546);
			JsonReader.NativeMethodInfoPtr_get_Culture_Public_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663547);
			JsonReader.NativeMethodInfoPtr_set_Culture_Public_set_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663548);
			JsonReader.NativeMethodInfoPtr_GetPosition_Internal_JsonPosition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663549);
			JsonReader.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663550);
			JsonReader.NativeMethodInfoPtr_Push_Private_Void_JsonContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663551);
			JsonReader.NativeMethodInfoPtr_Pop_Private_JsonContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663552);
			JsonReader.NativeMethodInfoPtr_Peek_Private_JsonContainerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663553);
			JsonReader.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663554);
			JsonReader.NativeMethodInfoPtr_ReadAsInt32_Public_Virtual_New_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663555);
			JsonReader.NativeMethodInfoPtr_ReadInt32String_Internal_Nullable_1_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663556);
			JsonReader.NativeMethodInfoPtr_ReadAsString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663557);
			JsonReader.NativeMethodInfoPtr_ReadAsBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663558);
			JsonReader.NativeMethodInfoPtr_ReadArrayIntoByteArray_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663559);
			JsonReader.NativeMethodInfoPtr_ReadArrayElementIntoByteArrayReportDone_Private_Boolean_List_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663560);
			JsonReader.NativeMethodInfoPtr_ReadAsDouble_Public_Virtual_New_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663561);
			JsonReader.NativeMethodInfoPtr_ReadDoubleString_Internal_Nullable_1_Double_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663562);
			JsonReader.NativeMethodInfoPtr_ReadAsBoolean_Public_Virtual_New_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663563);
			JsonReader.NativeMethodInfoPtr_ReadBooleanString_Internal_Nullable_1_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663564);
			JsonReader.NativeMethodInfoPtr_ReadAsDecimal_Public_Virtual_New_Nullable_1_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663565);
			JsonReader.NativeMethodInfoPtr_ReadDecimalString_Internal_Nullable_1_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663566);
			JsonReader.NativeMethodInfoPtr_ReadAsDateTime_Public_Virtual_New_Nullable_1_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663567);
			JsonReader.NativeMethodInfoPtr_ReadDateTimeString_Internal_Nullable_1_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663568);
			JsonReader.NativeMethodInfoPtr_ReadAsDateTimeOffset_Public_Virtual_New_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663569);
			JsonReader.NativeMethodInfoPtr_ReadDateTimeOffsetString_Internal_Nullable_1_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663570);
			JsonReader.NativeMethodInfoPtr_ReaderReadAndAssert_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663571);
			JsonReader.NativeMethodInfoPtr_CreateUnexpectedEndException_Internal_JsonReaderException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663572);
			JsonReader.NativeMethodInfoPtr_ReadIntoWrappedTypeObject_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663573);
			JsonReader.NativeMethodInfoPtr_Skip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663574);
			JsonReader.NativeMethodInfoPtr_SetToken_Protected_Void_JsonToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663575);
			JsonReader.NativeMethodInfoPtr_SetToken_Protected_Void_JsonToken_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663576);
			JsonReader.NativeMethodInfoPtr_SetToken_Protected_Void_JsonToken_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663577);
			JsonReader.NativeMethodInfoPtr_SetPostValueState_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663578);
			JsonReader.NativeMethodInfoPtr_UpdateScopeWithFinishedValue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663579);
			JsonReader.NativeMethodInfoPtr_ValidateEnd_Private_Void_JsonToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663580);
			JsonReader.NativeMethodInfoPtr_SetStateBasedOnCurrent_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663581);
			JsonReader.NativeMethodInfoPtr_SetFinished_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663582);
			JsonReader.NativeMethodInfoPtr_GetTypeForCloseToken_Private_JsonContainerType_JsonToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663583);
			JsonReader.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663584);
			JsonReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663585);
			JsonReader.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663586);
			JsonReader.NativeMethodInfoPtr_ReadAndAssert_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663587);
			JsonReader.NativeMethodInfoPtr_ReadForTypeAndAssert_Internal_Void_JsonContract_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663588);
			JsonReader.NativeMethodInfoPtr_ReadForType_Internal_Boolean_JsonContract_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663589);
			JsonReader.NativeMethodInfoPtr_ReadAndMoveToContent_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663590);
			JsonReader.NativeMethodInfoPtr_MoveToContent_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663591);
			JsonReader.NativeMethodInfoPtr_GetContentToken_Private_JsonToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663592);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00018500 File Offset: 0x00016700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728367, XrefRangeEnd = 728376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<bool> ReadAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonReader.NativeMethodInfoPtr_ReadAsync_Public_Virtual_New_Task_1_Boolean_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00018560 File Offset: 0x00016760
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 728387, RefRangeEnd = 728388, XrefRangeStart = 728376, XrefRangeEnd = 728387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task SkipAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_SkipAsync_Public_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000185B8 File Offset: 0x000167B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 728399, RefRangeEnd = 728403, XrefRangeStart = 728388, XrefRangeEnd = 728399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ReaderReadAndAssertAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_ReaderReadAndAssertAsync_Internal_Task_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00018610 File Offset: 0x00016810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728403, XrefRangeEnd = 728415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<Nullable<bool>> ReadAsBooleanAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonReader.NativeMethodInfoPtr_ReadAsBooleanAsync_Public_Virtual_New_Task_1_Nullable_1_Boolean_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<bool>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00018670 File Offset: 0x00016870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728415, XrefRangeEnd = 728427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<Il2CppStructArray<byte>> ReadAsBytesAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonReader.NativeMethodInfoPtr_ReadAsBytesAsync_Public_Virtual_New_Task_1_Il2CppStructArray_1_Byte_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Il2CppStructArray<byte>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000186D0 File Offset: 0x000168D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 728442, RefRangeEnd = 728443, XrefRangeStart = 728427, XrefRangeEnd = 728442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Il2CppStructArray<byte>> ReadArrayIntoByteArrayAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_ReadArrayIntoByteArrayAsync_Internal_Task_1_Il2CppStructArray_1_Byte_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Il2CppStructArray<byte>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00018728 File Offset: 0x00016928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728443, XrefRangeEnd = 728455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<Nullable<DateTime>> ReadAsDateTimeAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonReader.NativeMethodInfoPtr_ReadAsDateTimeAsync_Public_Virtual_New_Task_1_Nullable_1_DateTime_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<DateTime>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00018788 File Offset: 0x00016988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728455, XrefRangeEnd = 728467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<Nullable<DateTimeOffset>> ReadAsDateTimeOffsetAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonReader.NativeMethodInfoPtr_ReadAsDateTimeOffsetAsync_Public_Virtual_New_Task_1_Nullable_1_DateTimeOffset_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<DateTimeOffset>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000187E8 File Offset: 0x000169E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728467, XrefRangeEnd = 728479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<Nullable<Decimal>> ReadAsDecimalAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonReader.NativeMethodInfoPtr_ReadAsDecimalAsync_Public_Virtual_New_Task_1_Nullable_1_Decimal_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<Decimal>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00018848 File Offset: 0x00016A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728479, XrefRangeEnd = 728485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<Nullable<double>> ReadAsDoubleAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonReader.NativeMethodInfoPtr_ReadAsDoubleAsync_Public_Virtual_New_Task_1_Nullable_1_Double_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<double>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000188A8 File Offset: 0x00016AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728485, XrefRangeEnd = 728497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<Nullable<int>> ReadAsInt32Async(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonReader.NativeMethodInfoPtr_ReadAsInt32Async_Public_Virtual_New_Task_1_Nullable_1_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<int>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00018908 File Offset: 0x00016B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728497, XrefRangeEnd = 728509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<string> ReadAsStringAsync(CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonReader.NativeMethodInfoPtr_ReadAsStringAsync_Public_Virtual_New_Task_1_String_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00018968 File Offset: 0x00016B68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 728524, RefRangeEnd = 728525, XrefRangeStart = 728509, XrefRangeEnd = 728524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> ReadAndMoveToContentAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_ReadAndMoveToContentAsync_Internal_Task_1_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000189C0 File Offset: 0x00016BC0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 728529, RefRangeEnd = 728533, XrefRangeStart = 728525, XrefRangeEnd = 728529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> MoveToContentAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_MoveToContentAsync_Internal_Task_1_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00018A18 File Offset: 0x00016C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728533, XrefRangeEnd = 728548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> MoveToContentFromNonContentAsync(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_MoveToContentFromNonContentAsync_Private_Task_1_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00018A70 File Offset: 0x00016C70
		public unsafe JsonReader.State CurrentState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_get_CurrentState_Protected_get_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00018AAC File Offset: 0x00016CAC
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00018AE8 File Offset: 0x00016CE8
		public unsafe bool CloseInput
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_get_CloseInput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_set_CloseInput_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00018B28 File Offset: 0x00016D28
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00018B64 File Offset: 0x00016D64
		public unsafe bool SupportMultipleContent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_get_SupportMultipleContent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_set_SupportMultipleContent_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00018BA4 File Offset: 0x00016DA4
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00018BEC File Offset: 0x00016DEC
		public unsafe virtual char QuoteChar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonReader.NativeMethodInfoPtr_get_QuoteChar_Public_Virtual_New_get_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonReader.NativeMethodInfoPtr_set_QuoteChar_FamOrAssem_Virtual_New_set_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00018C38 File Offset: 0x00016E38
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00018C74 File Offset: 0x00016E74
		public unsafe DateTimeZoneHandling DateTimeZoneHandling
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 366305, RefRangeEnd = 366308, XrefRangeStart = 366305, XrefRangeEnd = 366308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_get_DateTimeZoneHandling_Public_get_DateTimeZoneHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 728548, RefRangeEnd = 728549, XrefRangeStart = 728548, XrefRangeEnd = 728548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_set_DateTimeZoneHandling_Public_set_Void_DateTimeZoneHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00018CB4 File Offset: 0x00016EB4
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00018CF0 File Offset: 0x00016EF0
		public unsafe DateParseHandling DateParseHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_get_DateParseHandling_Public_get_DateParseHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 728549, RefRangeEnd = 728550, XrefRangeStart = 728549, XrefRangeEnd = 728549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_set_DateParseHandling_Public_set_Void_DateParseHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00018D30 File Offset: 0x00016F30
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00018D6C File Offset: 0x00016F6C
		public unsafe FloatParseHandling FloatParseHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_get_FloatParseHandling_Public_get_FloatParseHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 728550, RefRangeEnd = 728551, XrefRangeStart = 728550, XrefRangeEnd = 728550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_set_FloatParseHandling_Public_set_Void_FloatParseHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00018DAC File Offset: 0x00016FAC
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00018DE4 File Offset: 0x00016FE4
		public unsafe string DateFormatString
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_get_DateFormatString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_set_DateFormatString_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00018E28 File Offset: 0x00017028
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00018E60 File Offset: 0x00017060
		public unsafe Nullable<int> MaxDepth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_get_MaxDepth_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 728553, RefRangeEnd = 728556, XrefRangeStart = 728551, XrefRangeEnd = 728553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_set_MaxDepth_Public_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00018EA8 File Offset: 0x000170A8
		public unsafe virtual JsonToken TokenType
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonReader.NativeMethodInfoPtr_get_TokenType_Public_Virtual_New_get_JsonToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00018EF0 File Offset: 0x000170F0
		public unsafe virtual Object Value
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonReader.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00018F3C File Offset: 0x0001713C
		public unsafe virtual Type ValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728556, XrefRangeEnd = 728557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonReader.NativeMethodInfoPtr_get_ValueType_Public_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00018F88 File Offset: 0x00017188
		public unsafe virtual int Depth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728557, XrefRangeEnd = 728559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonReader.NativeMethodInfoPtr_get_Depth_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00018FD0 File Offset: 0x000171D0
		public unsafe virtual string Path
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 728568, RefRangeEnd = 728569, XrefRangeStart = 728559, XrefRangeEnd = 728568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonReader.NativeMethodInfoPtr_get_Path_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00019014 File Offset: 0x00017214
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00019054 File Offset: 0x00017254
		public unsafe CultureInfo Culture
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 728573, RefRangeEnd = 728578, XrefRangeStart = 728569, XrefRangeEnd = 728573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_get_Culture_Public_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_set_Culture_Public_set_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00019098 File Offset: 0x00017298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 728583, RefRangeEnd = 728584, XrefRangeStart = 728578, XrefRangeEnd = 728583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonPosition GetPosition(int depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_GetPosition_Internal_JsonPosition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new JsonPosition(intPtr);
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000190DC File Offset: 0x000172DC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 728588, RefRangeEnd = 728596, XrefRangeStart = 728584, XrefRangeEnd = 728588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonReader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonReader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00019118 File Offset: 0x00017318
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 728623, RefRangeEnd = 728628, XrefRangeStart = 728596, XrefRangeEnd = 728623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(JsonContainerType value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_Push_Private_Void_JsonContainerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00019158 File Offset: 0x00017358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728628, XrefRangeEnd = 728639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonContainerType Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_Pop_Private_JsonContainerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00019194 File Offset: 0x00017394
		[CallerCount(0)]
		public unsafe JsonContainerType Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_Peek_Private_JsonContainerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000191D0 File Offset: 0x000173D0
		[CallerCount(0)]
		public unsafe virtual bool Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonReader.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00019218 File Offset: 0x00017418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728639, XrefRangeEnd = 728673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Nullable<int> ReadAsInt32()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonReader.NativeMethodInfoPtr_ReadAsInt32_Public_Virtual_New_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<int>(intPtr);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0001925C File Offset: 0x0001745C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 728687, RefRangeEnd = 728689, XrefRangeStart = 728673, XrefRangeEnd = 728687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<int> ReadInt32String(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_ReadInt32String_Internal_Nullable_1_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000192A4 File Offset: 0x000174A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728689, XrefRangeEnd = 728699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ReadAsString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonReader.NativeMethodInfoPtr_ReadAsString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000192E8 File Offset: 0x000174E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728699, XrefRangeEnd = 728727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> ReadAsBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonReader.NativeMethodInfoPtr_ReadAsBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00019334 File Offset: 0x00017534
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 728741, RefRangeEnd = 728742, XrefRangeStart = 728727, XrefRangeEnd = 728741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> ReadArrayIntoByteArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_ReadArrayIntoByteArray_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00019374 File Offset: 0x00017574
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 728753, RefRangeEnd = 728755, XrefRangeStart = 728742, XrefRangeEnd = 728753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadArrayElementIntoByteArrayReportDone(List<byte> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_ReadArrayElementIntoByteArrayReportDone_Private_Boolean_List_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000193C4 File Offset: 0x000175C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728755, XrefRangeEnd = 728783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Nullable<double> ReadAsDouble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonReader.NativeMethodInfoPtr_ReadAsDouble_Public_Virtual_New_Nullable_1_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<double>(intPtr);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00019408 File Offset: 0x00017608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728783, XrefRangeEnd = 728800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<double> ReadDoubleString(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_ReadDoubleString_Internal_Nullable_1_Double_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<double>(intPtr);
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00019450 File Offset: 0x00017650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728800, XrefRangeEnd = 728825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Nullable<bool> ReadAsBoolean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonReader.NativeMethodInfoPtr_ReadAsBoolean_Public_Virtual_New_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<bool>(intPtr);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00019494 File Offset: 0x00017694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 728837, RefRangeEnd = 728838, XrefRangeStart = 728825, XrefRangeEnd = 728837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<bool> ReadBooleanString(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_ReadBooleanString_Internal_Nullable_1_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000194DC File Offset: 0x000176DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728838, XrefRangeEnd = 728872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Nullable<Decimal> ReadAsDecimal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonReader.NativeMethodInfoPtr_ReadAsDecimal_Public_Virtual_New_Nullable_1_Decimal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<Decimal>(intPtr);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00019520 File Offset: 0x00017720
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 728898, RefRangeEnd = 728899, XrefRangeStart = 728872, XrefRangeEnd = 728898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<Decimal> ReadDecimalString(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_ReadDecimalString_Internal_Nullable_1_Decimal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<Decimal>(intPtr);
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00019568 File Offset: 0x00017768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728899, XrefRangeEnd = 728917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Nullable<DateTime> ReadAsDateTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonReader.NativeMethodInfoPtr_ReadAsDateTime_Public_Virtual_New_Nullable_1_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<DateTime>(intPtr);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000195AC File Offset: 0x000177AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728917, XrefRangeEnd = 728944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<DateTime> ReadDateTimeString(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_ReadDateTimeString_Internal_Nullable_1_DateTime_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<DateTime>(intPtr);
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000195F4 File Offset: 0x000177F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728944, XrefRangeEnd = 728960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Nullable<DateTimeOffset> ReadAsDateTimeOffset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonReader.NativeMethodInfoPtr_ReadAsDateTimeOffset_Public_Virtual_New_Nullable_1_DateTimeOffset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<DateTimeOffset>(intPtr);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00019638 File Offset: 0x00017838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728960, XrefRangeEnd = 728989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<DateTimeOffset> ReadDateTimeOffsetString(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_ReadDateTimeOffsetString_Internal_Nullable_1_DateTimeOffset_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<DateTimeOffset>(intPtr);
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00019680 File Offset: 0x00017880
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 728989, RefRangeEnd = 728991, XrefRangeStart = 728989, XrefRangeEnd = 728989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReaderReadAndAssert()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_ReaderReadAndAssert_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000196B4 File Offset: 0x000178B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 728994, RefRangeEnd = 728995, XrefRangeStart = 728991, XrefRangeEnd = 728994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonReaderException CreateUnexpectedEndException()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_CreateUnexpectedEndException_Internal_JsonReaderException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonReaderException>(intPtr3) : null;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000196F4 File Offset: 0x000178F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 729005, RefRangeEnd = 729006, XrefRangeStart = 728995, XrefRangeEnd = 729005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadIntoWrappedTypeObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_ReadIntoWrappedTypeObject_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00019728 File Offset: 0x00017928
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 729007, RefRangeEnd = 729024, XrefRangeStart = 729006, XrefRangeEnd = 729007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Skip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_Skip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0001975C File Offset: 0x0001795C
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 729025, RefRangeEnd = 729051, XrefRangeStart = 729024, XrefRangeEnd = 729025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToken(JsonToken newToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newToken;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_SetToken_Protected_Void_JsonToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0001979C File Offset: 0x0001799C
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 729052, RefRangeEnd = 729069, XrefRangeStart = 729051, XrefRangeEnd = 729052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToken(JsonToken newToken, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newToken;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_SetToken_Protected_Void_JsonToken_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000197EC File Offset: 0x000179EC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 729089, RefRangeEnd = 729098, XrefRangeStart = 729069, XrefRangeEnd = 729089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToken(JsonToken newToken, Object value, bool updateIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newToken;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_SetToken_Protected_Void_JsonToken_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0001984C File Offset: 0x00017A4C
		[CallerCount(0)]
		public unsafe void SetPostValueState(bool updateIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_SetPostValueState_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0001988C File Offset: 0x00017A8C
		[CallerCount(0)]
		public unsafe void UpdateScopeWithFinishedValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_UpdateScopeWithFinishedValue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000198C0 File Offset: 0x00017AC0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 729111, RefRangeEnd = 729115, XrefRangeStart = 729098, XrefRangeEnd = 729111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateEnd(JsonToken endToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref endToken;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_ValidateEnd_Private_Void_JsonToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00019900 File Offset: 0x00017B00
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 729115, RefRangeEnd = 729120, XrefRangeStart = 729115, XrefRangeEnd = 729115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStateBasedOnCurrent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_SetStateBasedOnCurrent_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00019934 File Offset: 0x00017B34
		[CallerCount(0)]
		public unsafe void SetFinished()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_SetFinished_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00019968 File Offset: 0x00017B68
		[CallerCount(0)]
		public unsafe JsonContainerType GetTypeForCloseToken(JsonToken token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_GetTypeForCloseToken_Private_JsonContainerType_JsonToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000199B4 File Offset: 0x00017BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729120, XrefRangeEnd = 729124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000199E8 File Offset: 0x00017BE8
		[CallerCount(0)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00019A34 File Offset: 0x00017C34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 729125, RefRangeEnd = 729127, XrefRangeStart = 729124, XrefRangeEnd = 729125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonReader.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00019A70 File Offset: 0x00017C70
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 729127, RefRangeEnd = 729171, XrefRangeStart = 729127, XrefRangeEnd = 729127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadAndAssert()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_ReadAndAssert_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00019AA4 File Offset: 0x00017CA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 729172, RefRangeEnd = 729174, XrefRangeStart = 729171, XrefRangeEnd = 729172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadForTypeAndAssert(JsonContract contract, bool hasConverter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasConverter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_ReadForTypeAndAssert_Internal_Void_JsonContract_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00019AF4 File Offset: 0x00017CF4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 729176, RefRangeEnd = 729183, XrefRangeStart = 729174, XrefRangeEnd = 729176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadForType(JsonContract contract, bool hasConverter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasConverter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_ReadForType_Internal_Boolean_JsonContract_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00019B50 File Offset: 0x00017D50
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 729184, RefRangeEnd = 729188, XrefRangeStart = 729183, XrefRangeEnd = 729184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadAndMoveToContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_ReadAndMoveToContent_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00019B8C File Offset: 0x00017D8C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 729189, RefRangeEnd = 729195, XrefRangeStart = 729188, XrefRangeEnd = 729189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveToContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_MoveToContent_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00019BC8 File Offset: 0x00017DC8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 729195, RefRangeEnd = 729203, XrefRangeStart = 729195, XrefRangeEnd = 729195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonToken GetContentToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_GetContentToken_Private_JsonToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002ACD File Offset: 0x00000CCD
		public JsonReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00019C04 File Offset: 0x00017E04
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00002AD6 File Offset: 0x00000CD6
		public unsafe JsonToken _tokenType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__tokenType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__tokenType)) = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00019C2C File Offset: 0x00017E2C
		// (set) Token: 0x060001DC RID: 476 RVA: 0x00002AF1 File Offset: 0x00000CF1
		public unsafe Object _value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00019C5C File Offset: 0x00017E5C
		// (set) Token: 0x060001DE RID: 478 RVA: 0x00002B10 File Offset: 0x00000D10
		public unsafe char _quoteChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__quoteChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__quoteChar)) = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001DF RID: 479 RVA: 0x00019C84 File Offset: 0x00017E84
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x00002B2B File Offset: 0x00000D2B
		public unsafe JsonReader.State _currentState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__currentState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__currentState)) = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x00019CAC File Offset: 0x00017EAC
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x00002B46 File Offset: 0x00000D46
		public JsonPosition _currentPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__currentPosition);
				return new JsonPosition(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JsonPosition>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__currentPosition), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<JsonPosition>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00019CDC File Offset: 0x00017EDC
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x00002B74 File Offset: 0x00000D74
		public unsafe CultureInfo _culture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__culture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__culture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00019D0C File Offset: 0x00017F0C
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x00002B93 File Offset: 0x00000D93
		public unsafe DateTimeZoneHandling _dateTimeZoneHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__dateTimeZoneHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__dateTimeZoneHandling)) = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00019D34 File Offset: 0x00017F34
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x00002BAE File Offset: 0x00000DAE
		public Nullable<int> _maxDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__maxDepth);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__maxDepth), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00019D64 File Offset: 0x00017F64
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00002BDC File Offset: 0x00000DDC
		public unsafe bool _hasExceededMaxDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__hasExceededMaxDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__hasExceededMaxDepth)) = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00019D8C File Offset: 0x00017F8C
		// (set) Token: 0x060001EC RID: 492 RVA: 0x00002BF7 File Offset: 0x00000DF7
		public unsafe DateParseHandling _dateParseHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__dateParseHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__dateParseHandling)) = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00019DB4 File Offset: 0x00017FB4
		// (set) Token: 0x060001EE RID: 494 RVA: 0x00002C12 File Offset: 0x00000E12
		public unsafe FloatParseHandling _floatParseHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__floatParseHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__floatParseHandling)) = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00019DDC File Offset: 0x00017FDC
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x00002C2D File Offset: 0x00000E2D
		public unsafe string _dateFormatString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__dateFormatString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__dateFormatString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x00019E04 File Offset: 0x00018004
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00002C4C File Offset: 0x00000E4C
		public unsafe List<JsonPosition> _stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<JsonPosition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00019E34 File Offset: 0x00018034
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x00002C6B File Offset: 0x00000E6B
		public unsafe bool _CloseInput_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__CloseInput_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__CloseInput_k__BackingField)) = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00019E5C File Offset: 0x0001805C
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x00002C86 File Offset: 0x00000E86
		public unsafe bool _SupportMultipleContent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__SupportMultipleContent_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr__SupportMultipleContent_k__BackingField)) = value;
			}
		}

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeFieldInfoPtr__tokenType;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeFieldInfoPtr__quoteChar;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeFieldInfoPtr__currentState;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeFieldInfoPtr__currentPosition;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeFieldInfoPtr__culture;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeFieldInfoPtr__dateTimeZoneHandling;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeFieldInfoPtr__maxDepth;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeFieldInfoPtr__hasExceededMaxDepth;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeFieldInfoPtr__dateParseHandling;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeFieldInfoPtr__floatParseHandling;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeFieldInfoPtr__dateFormatString;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeFieldInfoPtr__stack;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeFieldInfoPtr__CloseInput_k__BackingField;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeFieldInfoPtr__SupportMultipleContent_k__BackingField;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_New_Task_1_Boolean_CancellationToken_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_SkipAsync_Public_Task_CancellationToken_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_ReaderReadAndAssertAsync_Internal_Task_CancellationToken_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsBooleanAsync_Public_Virtual_New_Task_1_Nullable_1_Boolean_CancellationToken_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsBytesAsync_Public_Virtual_New_Task_1_Il2CppStructArray_1_Byte_CancellationToken_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_ReadArrayIntoByteArrayAsync_Internal_Task_1_Il2CppStructArray_1_Byte_CancellationToken_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsDateTimeAsync_Public_Virtual_New_Task_1_Nullable_1_DateTime_CancellationToken_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsDateTimeOffsetAsync_Public_Virtual_New_Task_1_Nullable_1_DateTimeOffset_CancellationToken_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsDecimalAsync_Public_Virtual_New_Task_1_Nullable_1_Decimal_CancellationToken_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsDoubleAsync_Public_Virtual_New_Task_1_Nullable_1_Double_CancellationToken_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsInt32Async_Public_Virtual_New_Task_1_Nullable_1_Int32_CancellationToken_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsStringAsync_Public_Virtual_New_Task_1_String_CancellationToken_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_ReadAndMoveToContentAsync_Internal_Task_1_Boolean_CancellationToken_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_MoveToContentAsync_Internal_Task_1_Boolean_CancellationToken_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_MoveToContentFromNonContentAsync_Private_Task_1_Boolean_CancellationToken_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentState_Protected_get_State_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_get_CloseInput_Public_get_Boolean_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_set_CloseInput_Public_set_Void_Boolean_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportMultipleContent_Public_get_Boolean_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_set_SupportMultipleContent_Public_set_Void_Boolean_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_get_QuoteChar_Public_Virtual_New_get_Char_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_set_QuoteChar_FamOrAssem_Virtual_New_set_Void_Char_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_get_DateTimeZoneHandling_Public_get_DateTimeZoneHandling_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_set_DateTimeZoneHandling_Public_set_Void_DateTimeZoneHandling_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_get_DateParseHandling_Public_get_DateParseHandling_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_set_DateParseHandling_Public_set_Void_DateParseHandling_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_get_FloatParseHandling_Public_get_FloatParseHandling_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_set_FloatParseHandling_Public_set_Void_FloatParseHandling_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_get_DateFormatString_Public_get_String_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_set_DateFormatString_Public_set_Void_String_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxDepth_Public_get_Nullable_1_Int32_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxDepth_Public_set_Void_Nullable_1_Int32_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_get_TokenType_Public_Virtual_New_get_JsonToken_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_Object_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_New_get_Type_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_get_Depth_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_get_Path_Public_Virtual_New_get_String_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_get_Culture_Public_get_CultureInfo_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_set_Culture_Public_set_Void_CultureInfo_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_GetPosition_Internal_JsonPosition_Int32_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_Push_Private_Void_JsonContainerType_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Private_JsonContainerType_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Private_JsonContainerType_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsInt32_Public_Virtual_New_Nullable_1_Int32_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt32String_Internal_Nullable_1_Int32_String_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsString_Public_Virtual_New_String_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_ReadArrayIntoByteArray_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_ReadArrayElementIntoByteArrayReportDone_Private_Boolean_List_1_Byte_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsDouble_Public_Virtual_New_Nullable_1_Double_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_ReadDoubleString_Internal_Nullable_1_Double_String_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsBoolean_Public_Virtual_New_Nullable_1_Boolean_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_ReadBooleanString_Internal_Nullable_1_Boolean_String_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsDecimal_Public_Virtual_New_Nullable_1_Decimal_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_ReadDecimalString_Internal_Nullable_1_Decimal_String_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsDateTime_Public_Virtual_New_Nullable_1_DateTime_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_ReadDateTimeString_Internal_Nullable_1_DateTime_String_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsDateTimeOffset_Public_Virtual_New_Nullable_1_DateTimeOffset_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_ReadDateTimeOffsetString_Internal_Nullable_1_DateTimeOffset_String_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_ReaderReadAndAssert_Internal_Void_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_CreateUnexpectedEndException_Internal_JsonReaderException_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_ReadIntoWrappedTypeObject_Internal_Void_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_Skip_Public_Void_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_SetToken_Protected_Void_JsonToken_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_SetToken_Protected_Void_JsonToken_Object_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_SetToken_Protected_Void_JsonToken_Object_Boolean_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_SetPostValueState_Internal_Void_Boolean_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScopeWithFinishedValue_Private_Void_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEnd_Private_Void_JsonToken_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_SetStateBasedOnCurrent_Protected_Void_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_SetFinished_Private_Void_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeForCloseToken_Private_JsonContainerType_JsonToken_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_ReadAndAssert_Internal_Void_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr_ReadForTypeAndAssert_Internal_Void_JsonContract_Boolean_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_ReadForType_Internal_Boolean_JsonContract_Boolean_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_ReadAndMoveToContent_Internal_Boolean_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_MoveToContent_Internal_Boolean_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_GetContentToken_Private_JsonToken_0;

		// Token: 0x02000118 RID: 280
		public enum State
		{
			// Token: 0x04001225 RID: 4645
			Start,
			// Token: 0x04001226 RID: 4646
			Complete,
			// Token: 0x04001227 RID: 4647
			Property,
			// Token: 0x04001228 RID: 4648
			ObjectStart,
			// Token: 0x04001229 RID: 4649
			Object,
			// Token: 0x0400122A RID: 4650
			ArrayStart,
			// Token: 0x0400122B RID: 4651
			Array,
			// Token: 0x0400122C RID: 4652
			Closed,
			// Token: 0x0400122D RID: 4653
			PostValue,
			// Token: 0x0400122E RID: 4654
			ConstructorStart,
			// Token: 0x0400122F RID: 4655
			Constructor,
			// Token: 0x04001230 RID: 4656
			Error,
			// Token: 0x04001231 RID: 4657
			Finished
		}

		// Token: 0x02000119 RID: 281
		[ObfuscatedName("Newtonsoft.Json.JsonReader+<MoveToContentFromNonContentAsync>d__14")]
		public sealed class _MoveToContentFromNonContentAsync_d__14 : ValueType
		{
			// Token: 0x06001684 RID: 5764 RVA: 0x000786B0 File Offset: 0x000768B0
			// Note: this type is marked as 'beforefieldinit'.
			static _MoveToContentFromNonContentAsync_d__14()
			{
				Il2CppClassPointerStore<JsonReader._MoveToContentFromNonContentAsync_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, "<MoveToContentFromNonContentAsync>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonReader._MoveToContentFromNonContentAsync_d__14>.NativeClassPtr);
				JsonReader._MoveToContentFromNonContentAsync_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._MoveToContentFromNonContentAsync_d__14>.NativeClassPtr, "<>1__state");
				JsonReader._MoveToContentFromNonContentAsync_d__14.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._MoveToContentFromNonContentAsync_d__14>.NativeClassPtr, "<>t__builder");
				JsonReader._MoveToContentFromNonContentAsync_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._MoveToContentFromNonContentAsync_d__14>.NativeClassPtr, "<>4__this");
				JsonReader._MoveToContentFromNonContentAsync_d__14.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._MoveToContentFromNonContentAsync_d__14>.NativeClassPtr, "cancellationToken");
				JsonReader._MoveToContentFromNonContentAsync_d__14.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._MoveToContentFromNonContentAsync_d__14>.NativeClassPtr, "<>u__1");
				JsonReader._MoveToContentFromNonContentAsync_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader._MoveToContentFromNonContentAsync_d__14>.NativeClassPtr, 100663593);
				JsonReader._MoveToContentFromNonContentAsync_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader._MoveToContentFromNonContentAsync_d__14>.NativeClassPtr, 100663594);
			}

			// Token: 0x06001685 RID: 5765 RVA: 0x00078768 File Offset: 0x00076968
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728195, XrefRangeEnd = 728214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader._MoveToContentFromNonContentAsync_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001686 RID: 5766 RVA: 0x000787A0 File Offset: 0x000769A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728214, XrefRangeEnd = 728220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader._MoveToContentFromNonContentAsync_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001687 RID: 5767 RVA: 0x00008C7E File Offset: 0x00006E7E
			public _MoveToContentFromNonContentAsync_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001688 RID: 5768 RVA: 0x00008C87 File Offset: 0x00006E87
			public _MoveToContentFromNonContentAsync_d__14()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonReader._MoveToContentFromNonContentAsync_d__14>.NativeClassPtr))
			{
			}

			// Token: 0x170005E9 RID: 1513
			// (get) Token: 0x06001689 RID: 5769 RVA: 0x000787E8 File Offset: 0x000769E8
			// (set) Token: 0x0600168A RID: 5770 RVA: 0x00008C99 File Offset: 0x00006E99
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._MoveToContentFromNonContentAsync_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._MoveToContentFromNonContentAsync_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005EA RID: 1514
			// (get) Token: 0x0600168B RID: 5771 RVA: 0x00078810 File Offset: 0x00076A10
			// (set) Token: 0x0600168C RID: 5772 RVA: 0x00008CB4 File Offset: 0x00006EB4
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._MoveToContentFromNonContentAsync_d__14.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._MoveToContentFromNonContentAsync_d__14.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170005EB RID: 1515
			// (get) Token: 0x0600168D RID: 5773 RVA: 0x00078840 File Offset: 0x00076A40
			// (set) Token: 0x0600168E RID: 5774 RVA: 0x00008CE2 File Offset: 0x00006EE2
			public unsafe JsonReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._MoveToContentFromNonContentAsync_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._MoveToContentFromNonContentAsync_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005EC RID: 1516
			// (get) Token: 0x0600168F RID: 5775 RVA: 0x00078870 File Offset: 0x00076A70
			// (set) Token: 0x06001690 RID: 5776 RVA: 0x00008D01 File Offset: 0x00006F01
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._MoveToContentFromNonContentAsync_d__14.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._MoveToContentFromNonContentAsync_d__14.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170005ED RID: 1517
			// (get) Token: 0x06001691 RID: 5777 RVA: 0x000788A0 File Offset: 0x00076AA0
			// (set) Token: 0x06001692 RID: 5778 RVA: 0x00008D2F File Offset: 0x00006F2F
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._MoveToContentFromNonContentAsync_d__14.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._MoveToContentFromNonContentAsync_d__14.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001232 RID: 4658
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001233 RID: 4659
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001234 RID: 4660
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001235 RID: 4661
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001236 RID: 4662
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001237 RID: 4663
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001238 RID: 4664
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200011A RID: 282
		[ObfuscatedName("Newtonsoft.Json.JsonReader+<ReadAndMoveToContentAsync>d__12")]
		public sealed class _ReadAndMoveToContentAsync_d__12 : ValueType
		{
			// Token: 0x06001693 RID: 5779 RVA: 0x000788D0 File Offset: 0x00076AD0
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadAndMoveToContentAsync_d__12()
			{
				Il2CppClassPointerStore<JsonReader._ReadAndMoveToContentAsync_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, "<ReadAndMoveToContentAsync>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonReader._ReadAndMoveToContentAsync_d__12>.NativeClassPtr);
				JsonReader._ReadAndMoveToContentAsync_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._ReadAndMoveToContentAsync_d__12>.NativeClassPtr, "<>1__state");
				JsonReader._ReadAndMoveToContentAsync_d__12.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._ReadAndMoveToContentAsync_d__12>.NativeClassPtr, "<>t__builder");
				JsonReader._ReadAndMoveToContentAsync_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._ReadAndMoveToContentAsync_d__12>.NativeClassPtr, "<>4__this");
				JsonReader._ReadAndMoveToContentAsync_d__12.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._ReadAndMoveToContentAsync_d__12>.NativeClassPtr, "cancellationToken");
				JsonReader._ReadAndMoveToContentAsync_d__12.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._ReadAndMoveToContentAsync_d__12>.NativeClassPtr, "<>u__1");
				JsonReader._ReadAndMoveToContentAsync_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader._ReadAndMoveToContentAsync_d__12>.NativeClassPtr, 100663595);
				JsonReader._ReadAndMoveToContentAsync_d__12.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader._ReadAndMoveToContentAsync_d__12>.NativeClassPtr, 100663596);
			}

			// Token: 0x06001694 RID: 5780 RVA: 0x00078988 File Offset: 0x00076B88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728220, XrefRangeEnd = 728265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader._ReadAndMoveToContentAsync_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001695 RID: 5781 RVA: 0x000789C0 File Offset: 0x00076BC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728265, XrefRangeEnd = 728271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader._ReadAndMoveToContentAsync_d__12.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001696 RID: 5782 RVA: 0x00008D5D File Offset: 0x00006F5D
			public _ReadAndMoveToContentAsync_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001697 RID: 5783 RVA: 0x00008D66 File Offset: 0x00006F66
			public _ReadAndMoveToContentAsync_d__12()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonReader._ReadAndMoveToContentAsync_d__12>.NativeClassPtr))
			{
			}

			// Token: 0x170005EE RID: 1518
			// (get) Token: 0x06001698 RID: 5784 RVA: 0x00078A08 File Offset: 0x00076C08
			// (set) Token: 0x06001699 RID: 5785 RVA: 0x00008D78 File Offset: 0x00006F78
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReadAndMoveToContentAsync_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReadAndMoveToContentAsync_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005EF RID: 1519
			// (get) Token: 0x0600169A RID: 5786 RVA: 0x00078A30 File Offset: 0x00076C30
			// (set) Token: 0x0600169B RID: 5787 RVA: 0x00008D93 File Offset: 0x00006F93
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReadAndMoveToContentAsync_d__12.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReadAndMoveToContentAsync_d__12.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170005F0 RID: 1520
			// (get) Token: 0x0600169C RID: 5788 RVA: 0x00078A60 File Offset: 0x00076C60
			// (set) Token: 0x0600169D RID: 5789 RVA: 0x00008DC1 File Offset: 0x00006FC1
			public unsafe JsonReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReadAndMoveToContentAsync_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReadAndMoveToContentAsync_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005F1 RID: 1521
			// (get) Token: 0x0600169E RID: 5790 RVA: 0x00078A90 File Offset: 0x00076C90
			// (set) Token: 0x0600169F RID: 5791 RVA: 0x00008DE0 File Offset: 0x00006FE0
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReadAndMoveToContentAsync_d__12.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReadAndMoveToContentAsync_d__12.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170005F2 RID: 1522
			// (get) Token: 0x060016A0 RID: 5792 RVA: 0x00078AC0 File Offset: 0x00076CC0
			// (set) Token: 0x060016A1 RID: 5793 RVA: 0x00008E0E File Offset: 0x0000700E
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReadAndMoveToContentAsync_d__12.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReadAndMoveToContentAsync_d__12.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001239 RID: 4665
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400123A RID: 4666
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400123B RID: 4667
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400123C RID: 4668
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400123D RID: 4669
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400123E RID: 4670
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400123F RID: 4671
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200011B RID: 283
		[ObfuscatedName("Newtonsoft.Json.JsonReader+<ReadArrayIntoByteArrayAsync>d__5")]
		public sealed class _ReadArrayIntoByteArrayAsync_d__5 : ValueType
		{
			// Token: 0x060016A2 RID: 5794 RVA: 0x00078AF0 File Offset: 0x00076CF0
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadArrayIntoByteArrayAsync_d__5()
			{
				Il2CppClassPointerStore<JsonReader._ReadArrayIntoByteArrayAsync_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, "<ReadArrayIntoByteArrayAsync>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonReader._ReadArrayIntoByteArrayAsync_d__5>.NativeClassPtr);
				JsonReader._ReadArrayIntoByteArrayAsync_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._ReadArrayIntoByteArrayAsync_d__5>.NativeClassPtr, "<>1__state");
				JsonReader._ReadArrayIntoByteArrayAsync_d__5.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._ReadArrayIntoByteArrayAsync_d__5>.NativeClassPtr, "<>t__builder");
				JsonReader._ReadArrayIntoByteArrayAsync_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._ReadArrayIntoByteArrayAsync_d__5>.NativeClassPtr, "<>4__this");
				JsonReader._ReadArrayIntoByteArrayAsync_d__5.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._ReadArrayIntoByteArrayAsync_d__5>.NativeClassPtr, "cancellationToken");
				JsonReader._ReadArrayIntoByteArrayAsync_d__5.NativeFieldInfoPtr__buffer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._ReadArrayIntoByteArrayAsync_d__5>.NativeClassPtr, "<buffer>5__2");
				JsonReader._ReadArrayIntoByteArrayAsync_d__5.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._ReadArrayIntoByteArrayAsync_d__5>.NativeClassPtr, "<>u__1");
				JsonReader._ReadArrayIntoByteArrayAsync_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader._ReadArrayIntoByteArrayAsync_d__5>.NativeClassPtr, 100663597);
				JsonReader._ReadArrayIntoByteArrayAsync_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader._ReadArrayIntoByteArrayAsync_d__5>.NativeClassPtr, 100663598);
			}

			// Token: 0x060016A3 RID: 5795 RVA: 0x00078BBC File Offset: 0x00076DBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728271, XrefRangeEnd = 728306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader._ReadArrayIntoByteArrayAsync_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016A4 RID: 5796 RVA: 0x00078BF4 File Offset: 0x00076DF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728306, XrefRangeEnd = 728312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader._ReadArrayIntoByteArrayAsync_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060016A5 RID: 5797 RVA: 0x00008E3C File Offset: 0x0000703C
			public _ReadArrayIntoByteArrayAsync_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060016A6 RID: 5798 RVA: 0x00008E45 File Offset: 0x00007045
			public _ReadArrayIntoByteArrayAsync_d__5()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonReader._ReadArrayIntoByteArrayAsync_d__5>.NativeClassPtr))
			{
			}

			// Token: 0x170005F3 RID: 1523
			// (get) Token: 0x060016A7 RID: 5799 RVA: 0x00078C3C File Offset: 0x00076E3C
			// (set) Token: 0x060016A8 RID: 5800 RVA: 0x00008E57 File Offset: 0x00007057
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReadArrayIntoByteArrayAsync_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReadArrayIntoByteArrayAsync_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005F4 RID: 1524
			// (get) Token: 0x060016A9 RID: 5801 RVA: 0x00078C64 File Offset: 0x00076E64
			// (set) Token: 0x060016AA RID: 5802 RVA: 0x00008E72 File Offset: 0x00007072
			public AsyncTaskMethodBuilder<Il2CppStructArray<byte>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReadArrayIntoByteArrayAsync_d__5.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Il2CppStructArray<byte>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppStructArray<byte>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReadArrayIntoByteArrayAsync_d__5.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppStructArray<byte>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170005F5 RID: 1525
			// (get) Token: 0x060016AB RID: 5803 RVA: 0x00078C94 File Offset: 0x00076E94
			// (set) Token: 0x060016AC RID: 5804 RVA: 0x00008EA0 File Offset: 0x000070A0
			public unsafe JsonReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReadArrayIntoByteArrayAsync_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReadArrayIntoByteArrayAsync_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005F6 RID: 1526
			// (get) Token: 0x060016AD RID: 5805 RVA: 0x00078CC4 File Offset: 0x00076EC4
			// (set) Token: 0x060016AE RID: 5806 RVA: 0x00008EBF File Offset: 0x000070BF
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReadArrayIntoByteArrayAsync_d__5.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReadArrayIntoByteArrayAsync_d__5.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170005F7 RID: 1527
			// (get) Token: 0x060016AF RID: 5807 RVA: 0x00078CF4 File Offset: 0x00076EF4
			// (set) Token: 0x060016B0 RID: 5808 RVA: 0x00008EED File Offset: 0x000070ED
			public unsafe List<byte> _buffer_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReadArrayIntoByteArrayAsync_d__5.NativeFieldInfoPtr__buffer_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReadArrayIntoByteArrayAsync_d__5.NativeFieldInfoPtr__buffer_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005F8 RID: 1528
			// (get) Token: 0x060016B1 RID: 5809 RVA: 0x00078D24 File Offset: 0x00076F24
			// (set) Token: 0x060016B2 RID: 5810 RVA: 0x00008F0C File Offset: 0x0000710C
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReadArrayIntoByteArrayAsync_d__5.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReadArrayIntoByteArrayAsync_d__5.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001240 RID: 4672
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001241 RID: 4673
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001242 RID: 4674
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001243 RID: 4675
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001244 RID: 4676
			private static readonly IntPtr NativeFieldInfoPtr__buffer_5__2;

			// Token: 0x04001245 RID: 4677
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001246 RID: 4678
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001247 RID: 4679
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200011C RID: 284
		[ObfuscatedName("Newtonsoft.Json.JsonReader+<ReaderReadAndAssertAsync>d__2")]
		public sealed class _ReaderReadAndAssertAsync_d__2 : ValueType
		{
			// Token: 0x060016B3 RID: 5811 RVA: 0x00078D54 File Offset: 0x00076F54
			// Note: this type is marked as 'beforefieldinit'.
			static _ReaderReadAndAssertAsync_d__2()
			{
				Il2CppClassPointerStore<JsonReader._ReaderReadAndAssertAsync_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, "<ReaderReadAndAssertAsync>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonReader._ReaderReadAndAssertAsync_d__2>.NativeClassPtr);
				JsonReader._ReaderReadAndAssertAsync_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._ReaderReadAndAssertAsync_d__2>.NativeClassPtr, "<>1__state");
				JsonReader._ReaderReadAndAssertAsync_d__2.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._ReaderReadAndAssertAsync_d__2>.NativeClassPtr, "<>t__builder");
				JsonReader._ReaderReadAndAssertAsync_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._ReaderReadAndAssertAsync_d__2>.NativeClassPtr, "<>4__this");
				JsonReader._ReaderReadAndAssertAsync_d__2.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._ReaderReadAndAssertAsync_d__2>.NativeClassPtr, "cancellationToken");
				JsonReader._ReaderReadAndAssertAsync_d__2.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._ReaderReadAndAssertAsync_d__2>.NativeClassPtr, "<>u__1");
				JsonReader._ReaderReadAndAssertAsync_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader._ReaderReadAndAssertAsync_d__2>.NativeClassPtr, 100663599);
				JsonReader._ReaderReadAndAssertAsync_d__2.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader._ReaderReadAndAssertAsync_d__2>.NativeClassPtr, 100663600);
			}

			// Token: 0x060016B4 RID: 5812 RVA: 0x00078E0C File Offset: 0x0007700C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728312, XrefRangeEnd = 728328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader._ReaderReadAndAssertAsync_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016B5 RID: 5813 RVA: 0x00078E44 File Offset: 0x00077044
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728328, XrefRangeEnd = 728332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader._ReaderReadAndAssertAsync_d__2.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060016B6 RID: 5814 RVA: 0x00008F3A File Offset: 0x0000713A
			public _ReaderReadAndAssertAsync_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060016B7 RID: 5815 RVA: 0x00008F43 File Offset: 0x00007143
			public _ReaderReadAndAssertAsync_d__2()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonReader._ReaderReadAndAssertAsync_d__2>.NativeClassPtr))
			{
			}

			// Token: 0x170005F9 RID: 1529
			// (get) Token: 0x060016B8 RID: 5816 RVA: 0x00078E8C File Offset: 0x0007708C
			// (set) Token: 0x060016B9 RID: 5817 RVA: 0x00008F55 File Offset: 0x00007155
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReaderReadAndAssertAsync_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReaderReadAndAssertAsync_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005FA RID: 1530
			// (get) Token: 0x060016BA RID: 5818 RVA: 0x00078EB4 File Offset: 0x000770B4
			// (set) Token: 0x060016BB RID: 5819 RVA: 0x00008F70 File Offset: 0x00007170
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReaderReadAndAssertAsync_d__2.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReaderReadAndAssertAsync_d__2.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170005FB RID: 1531
			// (get) Token: 0x060016BC RID: 5820 RVA: 0x00078EE4 File Offset: 0x000770E4
			// (set) Token: 0x060016BD RID: 5821 RVA: 0x00008F9E File Offset: 0x0000719E
			public unsafe JsonReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReaderReadAndAssertAsync_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReaderReadAndAssertAsync_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005FC RID: 1532
			// (get) Token: 0x060016BE RID: 5822 RVA: 0x00078F14 File Offset: 0x00077114
			// (set) Token: 0x060016BF RID: 5823 RVA: 0x00008FBD File Offset: 0x000071BD
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReaderReadAndAssertAsync_d__2.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReaderReadAndAssertAsync_d__2.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170005FD RID: 1533
			// (get) Token: 0x060016C0 RID: 5824 RVA: 0x00078F44 File Offset: 0x00077144
			// (set) Token: 0x060016C1 RID: 5825 RVA: 0x00008FEB File Offset: 0x000071EB
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReaderReadAndAssertAsync_d__2.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._ReaderReadAndAssertAsync_d__2.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001248 RID: 4680
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001249 RID: 4681
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400124A RID: 4682
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400124B RID: 4683
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400124C RID: 4684
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400124D RID: 4685
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400124E RID: 4686
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200011D RID: 285
		[ObfuscatedName("Newtonsoft.Json.JsonReader+<SkipAsync>d__1")]
		public sealed class _SkipAsync_d__1 : ValueType
		{
			// Token: 0x060016C2 RID: 5826 RVA: 0x00078F74 File Offset: 0x00077174
			// Note: this type is marked as 'beforefieldinit'.
			static _SkipAsync_d__1()
			{
				Il2CppClassPointerStore<JsonReader._SkipAsync_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, "<SkipAsync>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonReader._SkipAsync_d__1>.NativeClassPtr);
				JsonReader._SkipAsync_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._SkipAsync_d__1>.NativeClassPtr, "<>1__state");
				JsonReader._SkipAsync_d__1.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._SkipAsync_d__1>.NativeClassPtr, "<>t__builder");
				JsonReader._SkipAsync_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._SkipAsync_d__1>.NativeClassPtr, "<>4__this");
				JsonReader._SkipAsync_d__1.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._SkipAsync_d__1>.NativeClassPtr, "cancellationToken");
				JsonReader._SkipAsync_d__1.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._SkipAsync_d__1>.NativeClassPtr, "<>u__1");
				JsonReader._SkipAsync_d__1.NativeFieldInfoPtr__depth_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._SkipAsync_d__1>.NativeClassPtr, "<depth>5__2");
				JsonReader._SkipAsync_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader._SkipAsync_d__1>.NativeClassPtr, 100663601);
				JsonReader._SkipAsync_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader._SkipAsync_d__1>.NativeClassPtr, 100663602);
			}

			// Token: 0x060016C3 RID: 5827 RVA: 0x00079040 File Offset: 0x00077240
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728332, XrefRangeEnd = 728363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader._SkipAsync_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016C4 RID: 5828 RVA: 0x00079078 File Offset: 0x00077278
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728363, XrefRangeEnd = 728367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader._SkipAsync_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060016C5 RID: 5829 RVA: 0x00009019 File Offset: 0x00007219
			public _SkipAsync_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060016C6 RID: 5830 RVA: 0x00009022 File Offset: 0x00007222
			public _SkipAsync_d__1()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonReader._SkipAsync_d__1>.NativeClassPtr))
			{
			}

			// Token: 0x170005FE RID: 1534
			// (get) Token: 0x060016C7 RID: 5831 RVA: 0x000790C0 File Offset: 0x000772C0
			// (set) Token: 0x060016C8 RID: 5832 RVA: 0x00009034 File Offset: 0x00007234
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._SkipAsync_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._SkipAsync_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005FF RID: 1535
			// (get) Token: 0x060016C9 RID: 5833 RVA: 0x000790E8 File Offset: 0x000772E8
			// (set) Token: 0x060016CA RID: 5834 RVA: 0x0000904F File Offset: 0x0000724F
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._SkipAsync_d__1.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._SkipAsync_d__1.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000600 RID: 1536
			// (get) Token: 0x060016CB RID: 5835 RVA: 0x00079118 File Offset: 0x00077318
			// (set) Token: 0x060016CC RID: 5836 RVA: 0x0000907D File Offset: 0x0000727D
			public unsafe JsonReader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._SkipAsync_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._SkipAsync_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000601 RID: 1537
			// (get) Token: 0x060016CD RID: 5837 RVA: 0x00079148 File Offset: 0x00077348
			// (set) Token: 0x060016CE RID: 5838 RVA: 0x0000909C File Offset: 0x0000729C
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._SkipAsync_d__1.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._SkipAsync_d__1.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000602 RID: 1538
			// (get) Token: 0x060016CF RID: 5839 RVA: 0x00079178 File Offset: 0x00077378
			// (set) Token: 0x060016D0 RID: 5840 RVA: 0x000090CA File Offset: 0x000072CA
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._SkipAsync_d__1.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._SkipAsync_d__1.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000603 RID: 1539
			// (get) Token: 0x060016D1 RID: 5841 RVA: 0x000791A8 File Offset: 0x000773A8
			// (set) Token: 0x060016D2 RID: 5842 RVA: 0x000090F8 File Offset: 0x000072F8
			public unsafe int _depth_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._SkipAsync_d__1.NativeFieldInfoPtr__depth_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._SkipAsync_d__1.NativeFieldInfoPtr__depth_5__2)) = value;
				}
			}

			// Token: 0x0400124F RID: 4687
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001250 RID: 4688
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001251 RID: 4689
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001252 RID: 4690
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001253 RID: 4691
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001254 RID: 4692
			private static readonly IntPtr NativeFieldInfoPtr__depth_5__2;

			// Token: 0x04001255 RID: 4693
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001256 RID: 4694
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000A0 RID: 160
	public class TraceJsonReader : JsonReader
	{
		// Token: 0x06000D88 RID: 3464 RVA: 0x000504A4 File Offset: 0x0004E6A4
		// Note: this type is marked as 'beforefieldinit'.
		static TraceJsonReader()
		{
			Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "TraceJsonReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr);
			TraceJsonReader.NativeFieldInfoPtr__innerReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr, "_innerReader");
			TraceJsonReader.NativeFieldInfoPtr__textWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr, "_textWriter");
			TraceJsonReader.NativeFieldInfoPtr__sw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr, "_sw");
			TraceJsonReader.NativeMethodInfoPtr__ctor_Public_Void_JsonReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr, 100665755);
			TraceJsonReader.NativeMethodInfoPtr_GetDeserializedJsonMessage_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr, 100665756);
			TraceJsonReader.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr, 100665757);
			TraceJsonReader.NativeMethodInfoPtr_ReadAsInt32_Public_Virtual_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr, 100665758);
			TraceJsonReader.NativeMethodInfoPtr_ReadAsString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr, 100665759);
			TraceJsonReader.NativeMethodInfoPtr_ReadAsBytes_Public_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr, 100665760);
			TraceJsonReader.NativeMethodInfoPtr_ReadAsDecimal_Public_Virtual_Nullable_1_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr, 100665761);
			TraceJsonReader.NativeMethodInfoPtr_ReadAsDouble_Public_Virtual_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr, 100665762);
			TraceJsonReader.NativeMethodInfoPtr_ReadAsBoolean_Public_Virtual_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr, 100665763);
			TraceJsonReader.NativeMethodInfoPtr_ReadAsDateTime_Public_Virtual_Nullable_1_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr, 100665764);
			TraceJsonReader.NativeMethodInfoPtr_ReadAsDateTimeOffset_Public_Virtual_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr, 100665765);
			TraceJsonReader.NativeMethodInfoPtr_WriteCurrentToken_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr, 100665766);
			TraceJsonReader.NativeMethodInfoPtr_get_Depth_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr, 100665767);
			TraceJsonReader.NativeMethodInfoPtr_get_Path_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr, 100665768);
			TraceJsonReader.NativeMethodInfoPtr_get_QuoteChar_Public_Virtual_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr, 100665769);
			TraceJsonReader.NativeMethodInfoPtr_set_QuoteChar_FamOrAssem_Virtual_set_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr, 100665770);
			TraceJsonReader.NativeMethodInfoPtr_get_TokenType_Public_Virtual_get_JsonToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr, 100665771);
			TraceJsonReader.NativeMethodInfoPtr_get_Value_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr, 100665772);
			TraceJsonReader.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr, 100665773);
			TraceJsonReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr, 100665774);
			TraceJsonReader.NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_HasLineInfo_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr, 100665775);
			TraceJsonReader.NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr, 100665776);
			TraceJsonReader.NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr, 100665777);
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x000506DC File Offset: 0x0004E8DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 753789, RefRangeEnd = 753792, XrefRangeStart = 753767, XrefRangeEnd = 753789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraceJsonReader(JsonReader innerReader)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraceJsonReader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerReader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceJsonReader.NativeMethodInfoPtr__ctor_Public_Void_JsonReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00050728 File Offset: 0x0004E928
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 753793, RefRangeEnd = 753795, XrefRangeStart = 753792, XrefRangeEnd = 753793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDeserializedJsonMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceJsonReader.NativeMethodInfoPtr_GetDeserializedJsonMessage_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00050760 File Offset: 0x0004E960
		[CallerCount(0)]
		public unsafe override bool Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceJsonReader.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x000507A8 File Offset: 0x0004E9A8
		[CallerCount(0)]
		public unsafe override Nullable<int> ReadAsInt32()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceJsonReader.NativeMethodInfoPtr_ReadAsInt32_Public_Virtual_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<int>(intPtr);
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x000507EC File Offset: 0x0004E9EC
		[CallerCount(0)]
		public unsafe override string ReadAsString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceJsonReader.NativeMethodInfoPtr_ReadAsString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00050830 File Offset: 0x0004EA30
		[CallerCount(0)]
		public unsafe override Il2CppStructArray<byte> ReadAsBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceJsonReader.NativeMethodInfoPtr_ReadAsBytes_Public_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x0005087C File Offset: 0x0004EA7C
		[CallerCount(0)]
		public unsafe override Nullable<Decimal> ReadAsDecimal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceJsonReader.NativeMethodInfoPtr_ReadAsDecimal_Public_Virtual_Nullable_1_Decimal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<Decimal>(intPtr);
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x000508C0 File Offset: 0x0004EAC0
		[CallerCount(0)]
		public unsafe override Nullable<double> ReadAsDouble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceJsonReader.NativeMethodInfoPtr_ReadAsDouble_Public_Virtual_Nullable_1_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<double>(intPtr);
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x00050904 File Offset: 0x0004EB04
		[CallerCount(0)]
		public unsafe override Nullable<bool> ReadAsBoolean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceJsonReader.NativeMethodInfoPtr_ReadAsBoolean_Public_Virtual_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<bool>(intPtr);
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x00050948 File Offset: 0x0004EB48
		[CallerCount(0)]
		public unsafe override Nullable<DateTime> ReadAsDateTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceJsonReader.NativeMethodInfoPtr_ReadAsDateTime_Public_Virtual_Nullable_1_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<DateTime>(intPtr);
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x0005098C File Offset: 0x0004EB8C
		[CallerCount(0)]
		public unsafe override Nullable<DateTimeOffset> ReadAsDateTimeOffset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceJsonReader.NativeMethodInfoPtr_ReadAsDateTimeOffset_Public_Virtual_Nullable_1_DateTimeOffset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<DateTimeOffset>(intPtr);
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x000509D0 File Offset: 0x0004EBD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 753795, RefRangeEnd = 753798, XrefRangeStart = 753795, XrefRangeEnd = 753795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteCurrentToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceJsonReader.NativeMethodInfoPtr_WriteCurrentToken_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x00050A04 File Offset: 0x0004EC04
		public unsafe override int Depth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceJsonReader.NativeMethodInfoPtr_get_Depth_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x00050A4C File Offset: 0x0004EC4C
		public unsafe override string Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceJsonReader.NativeMethodInfoPtr_get_Path_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x00050A90 File Offset: 0x0004EC90
		// (set) Token: 0x06000D98 RID: 3480 RVA: 0x00050AD8 File Offset: 0x0004ECD8
		public unsafe override char QuoteChar
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceJsonReader.NativeMethodInfoPtr_get_QuoteChar_Public_Virtual_get_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753798, XrefRangeEnd = 753799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceJsonReader.NativeMethodInfoPtr_set_QuoteChar_FamOrAssem_Virtual_set_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x00050B24 File Offset: 0x0004ED24
		public unsafe override JsonToken TokenType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceJsonReader.NativeMethodInfoPtr_get_TokenType_Public_Virtual_get_JsonToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000D9A RID: 3482 RVA: 0x00050B6C File Offset: 0x0004ED6C
		public unsafe override Object Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceJsonReader.NativeMethodInfoPtr_get_Value_Public_Virtual_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x00050BB8 File Offset: 0x0004EDB8
		public unsafe override Type ValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceJsonReader.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x00050C04 File Offset: 0x0004EE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753799, XrefRangeEnd = 753800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TraceJsonReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x00050C40 File Offset: 0x0004EE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753800, XrefRangeEnd = 753803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Newtonsoft_Json_IJsonLineInfo_HasLineInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceJsonReader.NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_HasLineInfo_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x00050C7C File Offset: 0x0004EE7C
		public unsafe virtual int Newtonsoft.Json.IJsonLineInfo.LineNumber
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753803, XrefRangeEnd = 753808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceJsonReader.NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x00050CB8 File Offset: 0x0004EEB8
		public unsafe virtual int Newtonsoft.Json.IJsonLineInfo.LinePosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753808, XrefRangeEnd = 753813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceJsonReader.NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00006675 File Offset: 0x00004875
		public TraceJsonReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x00050CF4 File Offset: 0x0004EEF4
		// (set) Token: 0x06000DA2 RID: 3490 RVA: 0x0000667E File Offset: 0x0000487E
		public unsafe JsonReader _innerReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceJsonReader.NativeFieldInfoPtr__innerReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceJsonReader.NativeFieldInfoPtr__innerReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x00050D24 File Offset: 0x0004EF24
		// (set) Token: 0x06000DA4 RID: 3492 RVA: 0x0000669D File Offset: 0x0000489D
		public unsafe JsonTextWriter _textWriter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceJsonReader.NativeFieldInfoPtr__textWriter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTextWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceJsonReader.NativeFieldInfoPtr__textWriter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x00050D54 File Offset: 0x0004EF54
		// (set) Token: 0x06000DA6 RID: 3494 RVA: 0x000066BC File Offset: 0x000048BC
		public unsafe StringWriter _sw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceJsonReader.NativeFieldInfoPtr__sw);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TraceJsonReader.NativeFieldInfoPtr__sw), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AEB RID: 2795
		private static readonly IntPtr NativeFieldInfoPtr__innerReader;

		// Token: 0x04000AEC RID: 2796
		private static readonly IntPtr NativeFieldInfoPtr__textWriter;

		// Token: 0x04000AED RID: 2797
		private static readonly IntPtr NativeFieldInfoPtr__sw;

		// Token: 0x04000AEE RID: 2798
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_JsonReader_0;

		// Token: 0x04000AEF RID: 2799
		private static readonly IntPtr NativeMethodInfoPtr_GetDeserializedJsonMessage_Public_String_0;

		// Token: 0x04000AF0 RID: 2800
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0;

		// Token: 0x04000AF1 RID: 2801
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsInt32_Public_Virtual_Nullable_1_Int32_0;

		// Token: 0x04000AF2 RID: 2802
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsString_Public_Virtual_String_0;

		// Token: 0x04000AF3 RID: 2803
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsBytes_Public_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000AF4 RID: 2804
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsDecimal_Public_Virtual_Nullable_1_Decimal_0;

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsDouble_Public_Virtual_Nullable_1_Double_0;

		// Token: 0x04000AF6 RID: 2806
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsBoolean_Public_Virtual_Nullable_1_Boolean_0;

		// Token: 0x04000AF7 RID: 2807
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsDateTime_Public_Virtual_Nullable_1_DateTime_0;

		// Token: 0x04000AF8 RID: 2808
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsDateTimeOffset_Public_Virtual_Nullable_1_DateTimeOffset_0;

		// Token: 0x04000AF9 RID: 2809
		private static readonly IntPtr NativeMethodInfoPtr_WriteCurrentToken_Public_Void_0;

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeMethodInfoPtr_get_Depth_Public_Virtual_get_Int32_0;

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeMethodInfoPtr_get_Path_Public_Virtual_get_String_0;

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeMethodInfoPtr_get_QuoteChar_Public_Virtual_get_Char_0;

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeMethodInfoPtr_set_QuoteChar_FamOrAssem_Virtual_set_Void_Char_0;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeMethodInfoPtr_get_TokenType_Public_Virtual_get_JsonToken_0;

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_Object_0;

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0;

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_HasLineInfo_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04000B03 RID: 2819
		private static readonly IntPtr NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;
using JsonFx.Serialization;

namespace JsonFx.Json
{
	// Token: 0x02000029 RID: 41
	public class JsonReader : Object
	{
		// Token: 0x06000204 RID: 516 RVA: 0x0000AC70 File Offset: 0x00008E70
		// Note: this type is marked as 'beforefieldinit'.
		static JsonReader()
		{
			Il2CppClassPointerStore<JsonReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Json", "JsonReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonReader>.NativeClassPtr);
			JsonReader.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, "settings");
			JsonReader.NativeFieldInfoPtr_jsonTokenizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, "jsonTokenizer");
			JsonReader.NativeFieldInfoPtr_modelAnalyzer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, "modelAnalyzer");
			JsonReader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663581);
			JsonReader.NativeMethodInfoPtr__ctor_Public_Void_DataReaderSettings_ITokenAnalyzer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663582);
			JsonReader.NativeMethodInfoPtr_get_ContentType_Public_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663583);
			JsonReader.NativeMethodInfoPtr_get_Settings_Public_get_DataReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663584);
			JsonReader.NativeMethodInfoPtr_Read_Public_TResult_TextReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663585);
			JsonReader.NativeMethodInfoPtr_Read_Public_Object_TextReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663586);
			JsonReader.NativeMethodInfoPtr_Read_Public_Object_TextReader_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663587);
			JsonReader.NativeMethodInfoPtr_Read_Public_TResult_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663588);
			JsonReader.NativeMethodInfoPtr_Read_Public_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663589);
			JsonReader.NativeMethodInfoPtr_Read_Public_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663590);
			JsonReader.NativeMethodInfoPtr_ReadSingle_Private_Object_JsonTokenizer_IEnumerable_1_Token_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, 100663591);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000ADB8 File Offset: 0x00008FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192637, XrefRangeEnd = 1192642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonReader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonReader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000ADF4 File Offset: 0x00008FF4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1192683, RefRangeEnd = 1192687, XrefRangeStart = 1192642, XrefRangeEnd = 1192683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonReader(DataReaderSettings settings, ITokenAnalyzer analyzer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(analyzer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr__ctor_Public_Void_DataReaderSettings_ITokenAnalyzer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0000AE54 File Offset: 0x00009054
		public unsafe IEnumerable<string> ContentType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192687, XrefRangeEnd = 1192692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_get_ContentType_Public_get_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000208 RID: 520 RVA: 0x0000AE94 File Offset: 0x00009094
		public unsafe DataReaderSettings Settings
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_get_Settings_Public_get_DataReaderSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataReaderSettings>(intPtr3) : null;
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000AED4 File Offset: 0x000090D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192692, XrefRangeEnd = 1192701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TResult Read<TResult>(TextReader input) where TResult : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.MethodInfoStoreGeneric_Read_Public_TResult_TextReader_0<TResult>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000AF20 File Offset: 0x00009120
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1192708, RefRangeEnd = 1192709, XrefRangeStart = 1192701, XrefRangeEnd = 1192708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Read(TextReader input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_Read_Public_Object_TextReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000AF70 File Offset: 0x00009170
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1192716, RefRangeEnd = 1192717, XrefRangeStart = 1192709, XrefRangeEnd = 1192716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Read(TextReader input, Type targetType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_Read_Public_Object_TextReader_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000AFD4 File Offset: 0x000091D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192717, XrefRangeEnd = 1192726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TResult Read<TResult>(string input) where TResult : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.MethodInfoStoreGeneric_Read_Public_TResult_String_0<TResult>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000B020 File Offset: 0x00009220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192726, XrefRangeEnd = 1192732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Read(string input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_Read_Public_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000B070 File Offset: 0x00009270
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1192738, RefRangeEnd = 1192743, XrefRangeStart = 1192732, XrefRangeEnd = 1192738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Read(string input, Type targetType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_Read_Public_Object_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000B0D4 File Offset: 0x000092D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1192746, RefRangeEnd = 1192750, XrefRangeStart = 1192743, XrefRangeEnd = 1192746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadSingle(JsonTokenizer tokenizer, IEnumerable<Token> tokens, Type targetType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokenizer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader.NativeMethodInfoPtr_ReadSingle_Private_Object_JsonTokenizer_IEnumerable_1_Token_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002D29 File Offset: 0x00000F29
		public JsonReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0000B148 File Offset: 0x00009348
		// (set) Token: 0x06000212 RID: 530 RVA: 0x00002D32 File Offset: 0x00000F32
		public unsafe DataReaderSettings settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr_settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataReaderSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000213 RID: 531 RVA: 0x0000B178 File Offset: 0x00009378
		// (set) Token: 0x06000214 RID: 532 RVA: 0x00002D51 File Offset: 0x00000F51
		public unsafe JsonTokenizer jsonTokenizer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr_jsonTokenizer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTokenizer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr_jsonTokenizer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000215 RID: 533 RVA: 0x0000B1A8 File Offset: 0x000093A8
		// (set) Token: 0x06000216 RID: 534 RVA: 0x00002D70 File Offset: 0x00000F70
		public unsafe ITokenAnalyzer modelAnalyzer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr_modelAnalyzer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITokenAnalyzer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader.NativeFieldInfoPtr_modelAnalyzer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeFieldInfoPtr_settings;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeFieldInfoPtr_jsonTokenizer;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeFieldInfoPtr_modelAnalyzer;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataReaderSettings_ITokenAnalyzer_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentType_Public_get_IEnumerable_1_String_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_get_DataReaderSettings_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_TResult_TextReader_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Object_TextReader_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Object_TextReader_Type_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_TResult_String_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Object_String_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Object_String_Type_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_ReadSingle_Private_Object_JsonTokenizer_IEnumerable_1_Token_Type_0;

		// Token: 0x02000049 RID: 73
		[ObfuscatedName("JsonFx.Json.JsonReader+<get_ContentType>d__6")]
		public sealed class _get_ContentType_d__6 : Object
		{
			// Token: 0x06000404 RID: 1028 RVA: 0x000122F0 File Offset: 0x000104F0
			// Note: this type is marked as 'beforefieldinit'.
			static _get_ContentType_d__6()
			{
				Il2CppClassPointerStore<JsonReader._get_ContentType_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonReader>.NativeClassPtr, "<get_ContentType>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonReader._get_ContentType_d__6>.NativeClassPtr);
				JsonReader._get_ContentType_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._get_ContentType_d__6>.NativeClassPtr, "<>1__state");
				JsonReader._get_ContentType_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._get_ContentType_d__6>.NativeClassPtr, "<>2__current");
				JsonReader._get_ContentType_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonReader._get_ContentType_d__6>.NativeClassPtr, "<>l__initialThreadId");
				JsonReader._get_ContentType_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader._get_ContentType_d__6>.NativeClassPtr, 100663592);
				JsonReader._get_ContentType_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader._get_ContentType_d__6>.NativeClassPtr, 100663593);
				JsonReader._get_ContentType_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader._get_ContentType_d__6>.NativeClassPtr, 100663594);
				JsonReader._get_ContentType_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader._get_ContentType_d__6>.NativeClassPtr, 100663595);
				JsonReader._get_ContentType_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader._get_ContentType_d__6>.NativeClassPtr, 100663596);
				JsonReader._get_ContentType_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader._get_ContentType_d__6>.NativeClassPtr, 100663597);
				JsonReader._get_ContentType_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader._get_ContentType_d__6>.NativeClassPtr, 100663598);
				JsonReader._get_ContentType_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonReader._get_ContentType_d__6>.NativeClassPtr, 100663599);
			}

			// Token: 0x06000405 RID: 1029 RVA: 0x000123F8 File Offset: 0x000105F8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_ContentType_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonReader._get_ContentType_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader._get_ContentType_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000406 RID: 1030 RVA: 0x00012440 File Offset: 0x00010640
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader._get_ContentType_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000407 RID: 1031 RVA: 0x00012474 File Offset: 0x00010674
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192627, XrefRangeEnd = 1192630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader._get_ContentType_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x06000408 RID: 1032 RVA: 0x000124B0 File Offset: 0x000106B0
			public unsafe string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader._get_ContentType_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000409 RID: 1033 RVA: 0x000124E8 File Offset: 0x000106E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192630, XrefRangeEnd = 1192635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader._get_ContentType_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x0600040A RID: 1034 RVA: 0x0001251C File Offset: 0x0001071C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader._get_ContentType_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600040B RID: 1035 RVA: 0x0001255C File Offset: 0x0001075C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192635, XrefRangeEnd = 1192637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<string> System_Collections_Generic_IEnumerable_System_String__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader._get_ContentType_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr3) : null;
			}

			// Token: 0x0600040C RID: 1036 RVA: 0x0001259C File Offset: 0x0001079C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonReader._get_ContentType_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600040D RID: 1037 RVA: 0x000039CE File Offset: 0x00001BCE
			public _get_ContentType_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000123 RID: 291
			// (get) Token: 0x0600040E RID: 1038 RVA: 0x000125DC File Offset: 0x000107DC
			// (set) Token: 0x0600040F RID: 1039 RVA: 0x000039D7 File Offset: 0x00001BD7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._get_ContentType_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._get_ContentType_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000124 RID: 292
			// (get) Token: 0x06000410 RID: 1040 RVA: 0x00012604 File Offset: 0x00010804
			// (set) Token: 0x06000411 RID: 1041 RVA: 0x000039F2 File Offset: 0x00001BF2
			public unsafe string __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._get_ContentType_d__6.NativeFieldInfoPtr___2__current);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._get_ContentType_d__6.NativeFieldInfoPtr___2__current), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x06000412 RID: 1042 RVA: 0x0001262C File Offset: 0x0001082C
			// (set) Token: 0x06000413 RID: 1043 RVA: 0x00003A11 File Offset: 0x00001C11
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._get_ContentType_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonReader._get_ContentType_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x040002A4 RID: 676
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002A5 RID: 677
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040002A6 RID: 678
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040002A7 RID: 679
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040002A8 RID: 680
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002A9 RID: 681
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040002AA RID: 682
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0;

			// Token: 0x040002AB RID: 683
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002AC RID: 684
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040002AD RID: 685
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0;

			// Token: 0x040002AE RID: 686
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200004A RID: 74
		private sealed class MethodInfoStoreGeneric_Read_Public_TResult_TextReader_0<TResult>
		{
			// Token: 0x040002AF RID: 687
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonReader.NativeMethodInfoPtr_Read_Public_TResult_TextReader_0, Il2CppClassPointerStore<JsonReader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x0200004B RID: 75
		private sealed class MethodInfoStoreGeneric_Read_Public_TResult_String_0<TResult>
		{
			// Token: 0x040002B0 RID: 688
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonReader.NativeMethodInfoPtr_Read_Public_TResult_String_0, Il2CppClassPointerStore<JsonReader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}
	}
}

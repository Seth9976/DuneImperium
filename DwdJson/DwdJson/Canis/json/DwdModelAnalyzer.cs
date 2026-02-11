using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using JsonFx.Serialization;

namespace Canis.json
{
	// Token: 0x02000007 RID: 7
	public sealed class DwdModelAnalyzer : Object
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002CE4 File Offset: 0x00000EE4
		// Note: this type is marked as 'beforefieldinit'.
		static DwdModelAnalyzer()
		{
			Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr = IL2CPP.GetIl2CppClass("DwdJson.dll", "Canis.json", "DwdModelAnalyzer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr);
			DwdModelAnalyzer.NativeFieldInfoPtr_ErrorUnexpectedToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, "ErrorUnexpectedToken");
			DwdModelAnalyzer.NativeFieldInfoPtr_ErrorExpectedArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, "ErrorExpectedArray");
			DwdModelAnalyzer.NativeFieldInfoPtr_ErrorExpectedArrayItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, "ErrorExpectedArrayItem");
			DwdModelAnalyzer.NativeFieldInfoPtr_ErrorUnterminatedArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, "ErrorUnterminatedArray");
			DwdModelAnalyzer.NativeFieldInfoPtr_ErrorExpectedObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, "ErrorExpectedObject");
			DwdModelAnalyzer.NativeFieldInfoPtr_ErrorExpectedPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, "ErrorExpectedPropertyName");
			DwdModelAnalyzer.NativeFieldInfoPtr_ErrorUnterminatedObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, "ErrorUnterminatedObject");
			DwdModelAnalyzer.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, "Settings");
			DwdModelAnalyzer.NativeFieldInfoPtr_Coercion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, "Coercion");
			DwdModelAnalyzer.NativeFieldInfoPtr_DwdJsonMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, "DwdJsonMessages");
			DwdModelAnalyzer.NativeFieldInfoPtr_Analyzers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, "Analyzers");
			DwdModelAnalyzer.NativeFieldInfoPtr_TypeHintedClasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, "TypeHintedClasses");
			DwdModelAnalyzer.NativeFieldInfoPtr_DwdJsonMessageAttributeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, "DwdJsonMessageAttributeType");
			DwdModelAnalyzer.NativeFieldInfoPtr_TypeHintingAttributeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, "TypeHintingAttributeType");
			DwdModelAnalyzer.NativeFieldInfoPtr_TypedIDType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, "TypedIDType");
			DwdModelAnalyzer.NativeFieldInfoPtr__TwoObjectArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, "_TwoObjectArray");
			DwdModelAnalyzer.NativeMethodInfoPtr_get_TwoObjectArray_Private_Static_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, 100663305);
			DwdModelAnalyzer.NativeMethodInfoPtr__ctor_Public_Void_DataReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, 100663306);
			DwdModelAnalyzer.NativeMethodInfoPtr_JsonFx_Serialization_ITokenAnalyzer_get_Settings_Private_Virtual_Final_New_get_DataReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, 100663307);
			DwdModelAnalyzer.NativeMethodInfoPtr_RegisterJSONMessage_Public_Static_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, 100663308);
			DwdModelAnalyzer.NativeMethodInfoPtr_RegisterTypeHintedClass_Public_Static_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, 100663309);
			DwdModelAnalyzer.NativeMethodInfoPtr_RegisterTypeAnalyzer_Public_Static_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, 100663310);
			DwdModelAnalyzer.NativeMethodInfoPtr_RegisterTypeAnalyzerAdditionalTypes_Public_Static_Void_Type_List_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, 100663311);
			DwdModelAnalyzer.NativeMethodInfoPtr_Analyze_Public_Virtual_Final_New_Object_IEnumerable_1_Token_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, 100663312);
			DwdModelAnalyzer.NativeMethodInfoPtr_Analyze_Public_Virtual_Final_New_TResult_IEnumerable_1_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, 100663313);
			DwdModelAnalyzer.NativeMethodInfoPtr_ConsumeValue_Public_Object_MorePeekableStream_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, 100663314);
			DwdModelAnalyzer.NativeMethodInfoPtr_ConsumeServerHintedValue_Public_Object_MorePeekableStream_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, 100663315);
			DwdModelAnalyzer.NativeMethodInfoPtr_ConsumeObject_Public_Object_MorePeekableStream_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, 100663316);
			DwdModelAnalyzer.NativeMethodInfoPtr_setDictionaryValue_Private_Void_IDictionary_Type_Type_Type_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, 100663317);
			DwdModelAnalyzer.NativeMethodInfoPtr_ConsumeArray_Public_Object_MorePeekableStream_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, 100663318);
			DwdModelAnalyzer.NativeMethodInfoPtr_TryAnalyzers_Private_Boolean_MorePeekableStream_byref_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, 100663319);
			DwdModelAnalyzer.NativeMethodInfoPtr_GetDictionaryTypes_Public_Static_Void_Type_byref_Type_byref_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr, 100663320);
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002F94 File Offset: 0x00001194
		public unsafe static Il2CppReferenceArray<Object> TwoObjectArray
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247874, XrefRangeEnd = 1247889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdModelAnalyzer.NativeMethodInfoPtr_get_TwoObjectArray_Private_Static_get_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002FC8 File Offset: 0x000011C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247889, XrefRangeEnd = 1247902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DwdModelAnalyzer(DataReaderSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdModelAnalyzer.NativeMethodInfoPtr__ctor_Public_Void_DataReaderSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00003014 File Offset: 0x00001214
		public unsafe DataReaderSettings JsonFx.Serialization.ITokenAnalyzer.Settings
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdModelAnalyzer.NativeMethodInfoPtr_JsonFx_Serialization_ITokenAnalyzer_get_Settings_Private_Virtual_Final_New_get_DataReaderSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataReaderSettings>(intPtr3) : null;
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003054 File Offset: 0x00001254
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1247937, RefRangeEnd = 1247938, XrefRangeStart = 1247902, XrefRangeEnd = 1247937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterJSONMessage(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdModelAnalyzer.NativeMethodInfoPtr_RegisterJSONMessage_Public_Static_Void_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000308C File Offset: 0x0000128C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1247946, RefRangeEnd = 1247947, XrefRangeStart = 1247938, XrefRangeEnd = 1247946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterTypeHintedClass(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdModelAnalyzer.NativeMethodInfoPtr_RegisterTypeHintedClass_Public_Static_Void_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000030C4 File Offset: 0x000012C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1247963, RefRangeEnd = 1247964, XrefRangeStart = 1247947, XrefRangeEnd = 1247963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterTypeAnalyzer(Type analyzerType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(analyzerType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdModelAnalyzer.NativeMethodInfoPtr_RegisterTypeAnalyzer_Public_Static_Void_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000030FC File Offset: 0x000012FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1248001, RefRangeEnd = 1248002, XrefRangeStart = 1247964, XrefRangeEnd = 1248001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterTypeAnalyzerAdditionalTypes(Type analyzedType, List<Type> additionalTypes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(analyzedType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdModelAnalyzer.NativeMethodInfoPtr_RegisterTypeAnalyzerAdditionalTypes_Public_Static_Void_Type_List_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003144 File Offset: 0x00001344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248002, XrefRangeEnd = 1248008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Analyze(IEnumerable<Token> tokens, Type targetType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdModelAnalyzer.NativeMethodInfoPtr_Analyze_Public_Virtual_Final_New_Object_IEnumerable_1_Token_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000031A8 File Offset: 0x000013A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248008, XrefRangeEnd = 1248031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TResult Analyze<TResult>(IEnumerable<Token> tokens)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdModelAnalyzer.MethodInfoStoreGeneric_Analyze_Public_Virtual_Final_New_TResult_IEnumerable_1_Token_0<TResult>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000031F4 File Offset: 0x000013F4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1248086, RefRangeEnd = 1248099, XrefRangeStart = 1248031, XrefRangeEnd = 1248086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ConsumeValue(MorePeekableStream tokens, Type targetType, bool useTypeHinting = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useTypeHinting;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdModelAnalyzer.NativeMethodInfoPtr_ConsumeValue_Public_Object_MorePeekableStream_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003264 File Offset: 0x00001464
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1248108, RefRangeEnd = 1248109, XrefRangeStart = 1248099, XrefRangeEnd = 1248108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ConsumeServerHintedValue(MorePeekableStream tokens, Type targetType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdModelAnalyzer.NativeMethodInfoPtr_ConsumeServerHintedValue_Public_Object_MorePeekableStream_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000032C8 File Offset: 0x000014C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1248165, RefRangeEnd = 1248166, XrefRangeStart = 1248109, XrefRangeEnd = 1248165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ConsumeObject(MorePeekableStream tokens, Type targetType, bool useTypeHinting = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useTypeHinting;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdModelAnalyzer.NativeMethodInfoPtr_ConsumeObject_Public_Object_MorePeekableStream_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003338 File Offset: 0x00001538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248166, XrefRangeEnd = 1248231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void setDictionaryValue(IDictionary dict, Type dictType, Type keyType, Type propertyType, string propertyName, Object propertyValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dict);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dictType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(propertyType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyName);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(propertyValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdModelAnalyzer.NativeMethodInfoPtr_setDictionaryValue_Private_Void_IDictionary_Type_Type_Type_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000033D8 File Offset: 0x000015D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1248278, RefRangeEnd = 1248279, XrefRangeStart = 1248231, XrefRangeEnd = 1248278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ConsumeArray(MorePeekableStream tokens, Type arrayType, bool useTypeHinting = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useTypeHinting;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdModelAnalyzer.NativeMethodInfoPtr_ConsumeArray_Public_Object_MorePeekableStream_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003448 File Offset: 0x00001648
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1248297, RefRangeEnd = 1248299, XrefRangeStart = 1248279, XrefRangeEnd = 1248297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAnalyzers(MorePeekableStream tokens, out Object result, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DwdModelAnalyzer.NativeMethodInfoPtr_TryAnalyzers_Private_Boolean_MorePeekableStream_byref_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000034CC File Offset: 0x000016CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1248316, RefRangeEnd = 1248317, XrefRangeStart = 1248299, XrefRangeEnd = 1248316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetDictionaryTypes(Type targetType, out Type keyType, out Type valueType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DwdModelAnalyzer.NativeMethodInfoPtr_GetDictionaryTypes_Public_Static_Void_Type_byref_Type_byref_Type_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			keyType = ((intPtr5 == 0) ? null : new Type(intPtr5));
			IntPtr intPtr6 = intPtr2;
			valueType = ((intPtr6 == 0) ? null : new Type(intPtr6));
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000020F0 File Offset: 0x000002F0
		public DwdModelAnalyzer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00003548 File Offset: 0x00001748
		// (set) Token: 0x0600002A RID: 42 RVA: 0x000020F9 File Offset: 0x000002F9
		public unsafe static string ErrorUnexpectedToken
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DwdModelAnalyzer.NativeFieldInfoPtr_ErrorUnexpectedToken, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DwdModelAnalyzer.NativeFieldInfoPtr_ErrorUnexpectedToken, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00003568 File Offset: 0x00001768
		// (set) Token: 0x0600002C RID: 44 RVA: 0x0000210B File Offset: 0x0000030B
		public unsafe static string ErrorExpectedArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DwdModelAnalyzer.NativeFieldInfoPtr_ErrorExpectedArray, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DwdModelAnalyzer.NativeFieldInfoPtr_ErrorExpectedArray, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00003588 File Offset: 0x00001788
		// (set) Token: 0x0600002E RID: 46 RVA: 0x0000211D File Offset: 0x0000031D
		public unsafe static string ErrorExpectedArrayItem
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DwdModelAnalyzer.NativeFieldInfoPtr_ErrorExpectedArrayItem, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DwdModelAnalyzer.NativeFieldInfoPtr_ErrorExpectedArrayItem, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000035A8 File Offset: 0x000017A8
		// (set) Token: 0x06000030 RID: 48 RVA: 0x0000212F File Offset: 0x0000032F
		public unsafe static string ErrorUnterminatedArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DwdModelAnalyzer.NativeFieldInfoPtr_ErrorUnterminatedArray, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DwdModelAnalyzer.NativeFieldInfoPtr_ErrorUnterminatedArray, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000031 RID: 49 RVA: 0x000035C8 File Offset: 0x000017C8
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00002141 File Offset: 0x00000341
		public unsafe static string ErrorExpectedObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DwdModelAnalyzer.NativeFieldInfoPtr_ErrorExpectedObject, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DwdModelAnalyzer.NativeFieldInfoPtr_ErrorExpectedObject, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000035E8 File Offset: 0x000017E8
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00002153 File Offset: 0x00000353
		public unsafe static string ErrorExpectedPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DwdModelAnalyzer.NativeFieldInfoPtr_ErrorExpectedPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DwdModelAnalyzer.NativeFieldInfoPtr_ErrorExpectedPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00003608 File Offset: 0x00001808
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00002165 File Offset: 0x00000365
		public unsafe static string ErrorUnterminatedObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DwdModelAnalyzer.NativeFieldInfoPtr_ErrorUnterminatedObject, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DwdModelAnalyzer.NativeFieldInfoPtr_ErrorUnterminatedObject, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00003628 File Offset: 0x00001828
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00002177 File Offset: 0x00000377
		public unsafe DataReaderSettings Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdModelAnalyzer.NativeFieldInfoPtr_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataReaderSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdModelAnalyzer.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00003658 File Offset: 0x00001858
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002196 File Offset: 0x00000396
		public unsafe TypeCoercionUtility Coercion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdModelAnalyzer.NativeFieldInfoPtr_Coercion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeCoercionUtility>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdModelAnalyzer.NativeFieldInfoPtr_Coercion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00003688 File Offset: 0x00001888
		// (set) Token: 0x0600003C RID: 60 RVA: 0x000021B5 File Offset: 0x000003B5
		public unsafe static Dictionary<string, Type> DwdJsonMessages
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DwdModelAnalyzer.NativeFieldInfoPtr_DwdJsonMessages, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DwdModelAnalyzer.NativeFieldInfoPtr_DwdJsonMessages, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003D RID: 61 RVA: 0x000036B0 File Offset: 0x000018B0
		// (set) Token: 0x0600003E RID: 62 RVA: 0x000021C7 File Offset: 0x000003C7
		public unsafe static Dictionary<Type, DwdTypeAnalyzer> Analyzers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DwdModelAnalyzer.NativeFieldInfoPtr_Analyzers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, DwdTypeAnalyzer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DwdModelAnalyzer.NativeFieldInfoPtr_Analyzers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000036D8 File Offset: 0x000018D8
		// (set) Token: 0x06000040 RID: 64 RVA: 0x000021D9 File Offset: 0x000003D9
		public unsafe static Dictionary<string, Type> TypeHintedClasses
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DwdModelAnalyzer.NativeFieldInfoPtr_TypeHintedClasses, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DwdModelAnalyzer.NativeFieldInfoPtr_TypeHintedClasses, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00003700 File Offset: 0x00001900
		// (set) Token: 0x06000042 RID: 66 RVA: 0x000021EB File Offset: 0x000003EB
		public unsafe static Type DwdJsonMessageAttributeType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DwdModelAnalyzer.NativeFieldInfoPtr_DwdJsonMessageAttributeType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DwdModelAnalyzer.NativeFieldInfoPtr_DwdJsonMessageAttributeType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00003728 File Offset: 0x00001928
		// (set) Token: 0x06000044 RID: 68 RVA: 0x000021FD File Offset: 0x000003FD
		public unsafe static Type TypeHintingAttributeType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DwdModelAnalyzer.NativeFieldInfoPtr_TypeHintingAttributeType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DwdModelAnalyzer.NativeFieldInfoPtr_TypeHintingAttributeType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00003750 File Offset: 0x00001950
		// (set) Token: 0x06000046 RID: 70 RVA: 0x0000220F File Offset: 0x0000040F
		public unsafe static Type TypedIDType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DwdModelAnalyzer.NativeFieldInfoPtr_TypedIDType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DwdModelAnalyzer.NativeFieldInfoPtr_TypedIDType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00003778 File Offset: 0x00001978
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002221 File Offset: 0x00000421
		public unsafe static Il2CppReferenceArray<Object> _TwoObjectArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DwdModelAnalyzer.NativeFieldInfoPtr__TwoObjectArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DwdModelAnalyzer.NativeFieldInfoPtr__TwoObjectArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_ErrorUnexpectedToken;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_ErrorExpectedArray;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_ErrorExpectedArrayItem;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_ErrorUnterminatedArray;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr_ErrorExpectedObject;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr_ErrorExpectedPropertyName;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_ErrorUnterminatedObject;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_Settings;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_Coercion;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_DwdJsonMessages;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_Analyzers;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_TypeHintedClasses;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_DwdJsonMessageAttributeType;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_TypeHintingAttributeType;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_TypedIDType;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr__TwoObjectArray;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_get_TwoObjectArray_Private_Static_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataReaderSettings_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_JsonFx_Serialization_ITokenAnalyzer_get_Settings_Private_Virtual_Final_New_get_DataReaderSettings_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_RegisterJSONMessage_Public_Static_Void_Type_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTypeHintedClass_Public_Static_Void_Type_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTypeAnalyzer_Public_Static_Void_Type_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTypeAnalyzerAdditionalTypes_Public_Static_Void_Type_List_1_Type_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_Analyze_Public_Virtual_Final_New_Object_IEnumerable_1_Token_Type_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_Analyze_Public_Virtual_Final_New_TResult_IEnumerable_1_Token_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeValue_Public_Object_MorePeekableStream_Type_Boolean_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeServerHintedValue_Public_Object_MorePeekableStream_Type_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeObject_Public_Object_MorePeekableStream_Type_Boolean_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_setDictionaryValue_Private_Void_IDictionary_Type_Type_Type_String_Object_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeArray_Public_Object_MorePeekableStream_Type_Boolean_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_TryAnalyzers_Private_Boolean_MorePeekableStream_byref_Object_Type_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_GetDictionaryTypes_Public_Static_Void_Type_byref_Type_byref_Type_0;

		// Token: 0x02000022 RID: 34
		private sealed class MethodInfoStoreGeneric_Analyze_Public_Virtual_Final_New_TResult_IEnumerable_1_Token_0<TResult>
		{
			// Token: 0x040000A1 RID: 161
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DwdModelAnalyzer.NativeMethodInfoPtr_Analyze_Public_Virtual_Final_New_TResult_IEnumerable_1_Token_0, Il2CppClassPointerStore<DwdModelAnalyzer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}
	}
}

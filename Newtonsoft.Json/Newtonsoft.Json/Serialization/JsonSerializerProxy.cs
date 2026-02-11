using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Globalization;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Runtime.Serialization.Formatters;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000094 RID: 148
	public class JsonSerializerProxy : JsonSerializer
	{
		// Token: 0x06000CB9 RID: 3257 RVA: 0x0004CBD4 File Offset: 0x0004ADD4
		// Note: this type is marked as 'beforefieldinit'.
		static JsonSerializerProxy()
		{
			Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "JsonSerializerProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr);
			JsonSerializerProxy.NativeFieldInfoPtr__serializerReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, "_serializerReader");
			JsonSerializerProxy.NativeFieldInfoPtr__serializerWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, "_serializerWriter");
			JsonSerializerProxy.NativeFieldInfoPtr__serializer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, "_serializer");
			JsonSerializerProxy.NativeMethodInfoPtr_add_Error_Public_Virtual_add_Void_EventHandler_1_ErrorEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665619);
			JsonSerializerProxy.NativeMethodInfoPtr_remove_Error_Public_Virtual_rem_Void_EventHandler_1_ErrorEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665620);
			JsonSerializerProxy.NativeMethodInfoPtr_get_ReferenceResolver_Public_Virtual_get_IReferenceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665621);
			JsonSerializerProxy.NativeMethodInfoPtr_set_ReferenceResolver_Public_Virtual_set_Void_IReferenceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665622);
			JsonSerializerProxy.NativeMethodInfoPtr_get_TraceWriter_Public_Virtual_get_ITraceWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665623);
			JsonSerializerProxy.NativeMethodInfoPtr_set_TraceWriter_Public_Virtual_set_Void_ITraceWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665624);
			JsonSerializerProxy.NativeMethodInfoPtr_get_EqualityComparer_Public_Virtual_get_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665625);
			JsonSerializerProxy.NativeMethodInfoPtr_set_EqualityComparer_Public_Virtual_set_Void_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665626);
			JsonSerializerProxy.NativeMethodInfoPtr_get_Converters_Public_Virtual_get_JsonConverterCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665627);
			JsonSerializerProxy.NativeMethodInfoPtr_get_DefaultValueHandling_Public_Virtual_get_DefaultValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665628);
			JsonSerializerProxy.NativeMethodInfoPtr_set_DefaultValueHandling_Public_Virtual_set_Void_DefaultValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665629);
			JsonSerializerProxy.NativeMethodInfoPtr_get_ContractResolver_Public_Virtual_get_IContractResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665630);
			JsonSerializerProxy.NativeMethodInfoPtr_set_ContractResolver_Public_Virtual_set_Void_IContractResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665631);
			JsonSerializerProxy.NativeMethodInfoPtr_get_MissingMemberHandling_Public_Virtual_get_MissingMemberHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665632);
			JsonSerializerProxy.NativeMethodInfoPtr_set_MissingMemberHandling_Public_Virtual_set_Void_MissingMemberHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665633);
			JsonSerializerProxy.NativeMethodInfoPtr_get_NullValueHandling_Public_Virtual_get_NullValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665634);
			JsonSerializerProxy.NativeMethodInfoPtr_set_NullValueHandling_Public_Virtual_set_Void_NullValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665635);
			JsonSerializerProxy.NativeMethodInfoPtr_get_ObjectCreationHandling_Public_Virtual_get_ObjectCreationHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665636);
			JsonSerializerProxy.NativeMethodInfoPtr_set_ObjectCreationHandling_Public_Virtual_set_Void_ObjectCreationHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665637);
			JsonSerializerProxy.NativeMethodInfoPtr_get_ReferenceLoopHandling_Public_Virtual_get_ReferenceLoopHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665638);
			JsonSerializerProxy.NativeMethodInfoPtr_set_ReferenceLoopHandling_Public_Virtual_set_Void_ReferenceLoopHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665639);
			JsonSerializerProxy.NativeMethodInfoPtr_get_PreserveReferencesHandling_Public_Virtual_get_PreserveReferencesHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665640);
			JsonSerializerProxy.NativeMethodInfoPtr_set_PreserveReferencesHandling_Public_Virtual_set_Void_PreserveReferencesHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665641);
			JsonSerializerProxy.NativeMethodInfoPtr_get_TypeNameHandling_Public_Virtual_get_TypeNameHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665642);
			JsonSerializerProxy.NativeMethodInfoPtr_set_TypeNameHandling_Public_Virtual_set_Void_TypeNameHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665643);
			JsonSerializerProxy.NativeMethodInfoPtr_get_MetadataPropertyHandling_Public_Virtual_get_MetadataPropertyHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665644);
			JsonSerializerProxy.NativeMethodInfoPtr_set_MetadataPropertyHandling_Public_Virtual_set_Void_MetadataPropertyHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665645);
			JsonSerializerProxy.NativeMethodInfoPtr_get_TypeNameAssemblyFormat_Public_Virtual_get_FormatterAssemblyStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665646);
			JsonSerializerProxy.NativeMethodInfoPtr_set_TypeNameAssemblyFormat_Public_Virtual_set_Void_FormatterAssemblyStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665647);
			JsonSerializerProxy.NativeMethodInfoPtr_get_TypeNameAssemblyFormatHandling_Public_Virtual_get_TypeNameAssemblyFormatHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665648);
			JsonSerializerProxy.NativeMethodInfoPtr_set_TypeNameAssemblyFormatHandling_Public_Virtual_set_Void_TypeNameAssemblyFormatHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665649);
			JsonSerializerProxy.NativeMethodInfoPtr_get_ConstructorHandling_Public_Virtual_get_ConstructorHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665650);
			JsonSerializerProxy.NativeMethodInfoPtr_set_ConstructorHandling_Public_Virtual_set_Void_ConstructorHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665651);
			JsonSerializerProxy.NativeMethodInfoPtr_get_Binder_Public_Virtual_get_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665652);
			JsonSerializerProxy.NativeMethodInfoPtr_set_Binder_Public_Virtual_set_Void_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665653);
			JsonSerializerProxy.NativeMethodInfoPtr_get_SerializationBinder_Public_Virtual_get_ISerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665654);
			JsonSerializerProxy.NativeMethodInfoPtr_set_SerializationBinder_Public_Virtual_set_Void_ISerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665655);
			JsonSerializerProxy.NativeMethodInfoPtr_get_Context_Public_Virtual_get_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665656);
			JsonSerializerProxy.NativeMethodInfoPtr_set_Context_Public_Virtual_set_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665657);
			JsonSerializerProxy.NativeMethodInfoPtr_get_Formatting_Public_Virtual_get_Formatting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665658);
			JsonSerializerProxy.NativeMethodInfoPtr_set_Formatting_Public_Virtual_set_Void_Formatting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665659);
			JsonSerializerProxy.NativeMethodInfoPtr_get_DateFormatHandling_Public_Virtual_get_DateFormatHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665660);
			JsonSerializerProxy.NativeMethodInfoPtr_set_DateFormatHandling_Public_Virtual_set_Void_DateFormatHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665661);
			JsonSerializerProxy.NativeMethodInfoPtr_get_DateTimeZoneHandling_Public_Virtual_get_DateTimeZoneHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665662);
			JsonSerializerProxy.NativeMethodInfoPtr_set_DateTimeZoneHandling_Public_Virtual_set_Void_DateTimeZoneHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665663);
			JsonSerializerProxy.NativeMethodInfoPtr_get_DateParseHandling_Public_Virtual_get_DateParseHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665664);
			JsonSerializerProxy.NativeMethodInfoPtr_set_DateParseHandling_Public_Virtual_set_Void_DateParseHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665665);
			JsonSerializerProxy.NativeMethodInfoPtr_get_FloatFormatHandling_Public_Virtual_get_FloatFormatHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665666);
			JsonSerializerProxy.NativeMethodInfoPtr_set_FloatFormatHandling_Public_Virtual_set_Void_FloatFormatHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665667);
			JsonSerializerProxy.NativeMethodInfoPtr_get_FloatParseHandling_Public_Virtual_get_FloatParseHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665668);
			JsonSerializerProxy.NativeMethodInfoPtr_set_FloatParseHandling_Public_Virtual_set_Void_FloatParseHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665669);
			JsonSerializerProxy.NativeMethodInfoPtr_get_StringEscapeHandling_Public_Virtual_get_StringEscapeHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665670);
			JsonSerializerProxy.NativeMethodInfoPtr_set_StringEscapeHandling_Public_Virtual_set_Void_StringEscapeHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665671);
			JsonSerializerProxy.NativeMethodInfoPtr_get_DateFormatString_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665672);
			JsonSerializerProxy.NativeMethodInfoPtr_set_DateFormatString_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665673);
			JsonSerializerProxy.NativeMethodInfoPtr_get_Culture_Public_Virtual_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665674);
			JsonSerializerProxy.NativeMethodInfoPtr_set_Culture_Public_Virtual_set_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665675);
			JsonSerializerProxy.NativeMethodInfoPtr_get_MaxDepth_Public_Virtual_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665676);
			JsonSerializerProxy.NativeMethodInfoPtr_set_MaxDepth_Public_Virtual_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665677);
			JsonSerializerProxy.NativeMethodInfoPtr_get_CheckAdditionalContent_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665678);
			JsonSerializerProxy.NativeMethodInfoPtr_set_CheckAdditionalContent_Public_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665679);
			JsonSerializerProxy.NativeMethodInfoPtr_GetInternalSerializer_Internal_JsonSerializerInternalBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665680);
			JsonSerializerProxy.NativeMethodInfoPtr__ctor_Public_Void_JsonSerializerInternalReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665681);
			JsonSerializerProxy.NativeMethodInfoPtr__ctor_Public_Void_JsonSerializerInternalWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665682);
			JsonSerializerProxy.NativeMethodInfoPtr_DeserializeInternal_Internal_Virtual_Object_JsonReader_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665683);
			JsonSerializerProxy.NativeMethodInfoPtr_PopulateInternal_Internal_Virtual_Void_JsonReader_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665684);
			JsonSerializerProxy.NativeMethodInfoPtr_SerializeInternal_Internal_Virtual_Void_JsonWriter_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr, 100665685);
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x0004D17C File Offset: 0x0004B37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753075, XrefRangeEnd = 753076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void add_Error(EventHandler<ErrorEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_add_Error_Public_Virtual_add_Void_EventHandler_1_ErrorEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x0004D1CC File Offset: 0x0004B3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753076, XrefRangeEnd = 753077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void remove_Error(EventHandler<ErrorEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_remove_Error_Public_Virtual_rem_Void_EventHandler_1_ErrorEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x0004D21C File Offset: 0x0004B41C
		// (set) Token: 0x06000CBD RID: 3261 RVA: 0x0004D268 File Offset: 0x0004B468
		public unsafe override IReferenceResolver ReferenceResolver
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753077, XrefRangeEnd = 753078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_ReferenceResolver_Public_Virtual_get_IReferenceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReferenceResolver>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753078, XrefRangeEnd = 753079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_ReferenceResolver_Public_Virtual_set_Void_IReferenceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x0004D2B8 File Offset: 0x0004B4B8
		// (set) Token: 0x06000CBF RID: 3263 RVA: 0x0004D304 File Offset: 0x0004B504
		public unsafe override ITraceWriter TraceWriter
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753079, XrefRangeEnd = 753080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_TraceWriter_Public_Virtual_get_ITraceWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITraceWriter>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753080, XrefRangeEnd = 753081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_TraceWriter_Public_Virtual_set_Void_ITraceWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x0004D354 File Offset: 0x0004B554
		// (set) Token: 0x06000CC1 RID: 3265 RVA: 0x0004D3A0 File Offset: 0x0004B5A0
		public unsafe override IEqualityComparer EqualityComparer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753081, XrefRangeEnd = 753082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_EqualityComparer_Public_Virtual_get_IEqualityComparer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEqualityComparer>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753082, XrefRangeEnd = 753083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_EqualityComparer_Public_Virtual_set_Void_IEqualityComparer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x0004D3F0 File Offset: 0x0004B5F0
		public unsafe override JsonConverterCollection Converters
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753083, XrefRangeEnd = 753084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_Converters_Public_Virtual_get_JsonConverterCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonConverterCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x0004D43C File Offset: 0x0004B63C
		// (set) Token: 0x06000CC4 RID: 3268 RVA: 0x0004D484 File Offset: 0x0004B684
		public unsafe override DefaultValueHandling DefaultValueHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753084, XrefRangeEnd = 753085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_DefaultValueHandling_Public_Virtual_get_DefaultValueHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753085, XrefRangeEnd = 753086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_DefaultValueHandling_Public_Virtual_set_Void_DefaultValueHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x0004D4D0 File Offset: 0x0004B6D0
		// (set) Token: 0x06000CC6 RID: 3270 RVA: 0x0004D51C File Offset: 0x0004B71C
		public unsafe override IContractResolver ContractResolver
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753086, XrefRangeEnd = 753087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_ContractResolver_Public_Virtual_get_IContractResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IContractResolver>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753087, XrefRangeEnd = 753088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_ContractResolver_Public_Virtual_set_Void_IContractResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x0004D56C File Offset: 0x0004B76C
		// (set) Token: 0x06000CC8 RID: 3272 RVA: 0x0004D5B4 File Offset: 0x0004B7B4
		public unsafe override MissingMemberHandling MissingMemberHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753088, XrefRangeEnd = 753089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_MissingMemberHandling_Public_Virtual_get_MissingMemberHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753089, XrefRangeEnd = 753090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_MissingMemberHandling_Public_Virtual_set_Void_MissingMemberHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x0004D600 File Offset: 0x0004B800
		// (set) Token: 0x06000CCA RID: 3274 RVA: 0x0004D648 File Offset: 0x0004B848
		public unsafe override NullValueHandling NullValueHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753090, XrefRangeEnd = 753091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_NullValueHandling_Public_Virtual_get_NullValueHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753091, XrefRangeEnd = 753092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_NullValueHandling_Public_Virtual_set_Void_NullValueHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x0004D694 File Offset: 0x0004B894
		// (set) Token: 0x06000CCC RID: 3276 RVA: 0x0004D6DC File Offset: 0x0004B8DC
		public unsafe override ObjectCreationHandling ObjectCreationHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753092, XrefRangeEnd = 753093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_ObjectCreationHandling_Public_Virtual_get_ObjectCreationHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753093, XrefRangeEnd = 753094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_ObjectCreationHandling_Public_Virtual_set_Void_ObjectCreationHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x0004D728 File Offset: 0x0004B928
		// (set) Token: 0x06000CCE RID: 3278 RVA: 0x0004D770 File Offset: 0x0004B970
		public unsafe override ReferenceLoopHandling ReferenceLoopHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753094, XrefRangeEnd = 753095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_ReferenceLoopHandling_Public_Virtual_get_ReferenceLoopHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753095, XrefRangeEnd = 753096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_ReferenceLoopHandling_Public_Virtual_set_Void_ReferenceLoopHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x0004D7BC File Offset: 0x0004B9BC
		// (set) Token: 0x06000CD0 RID: 3280 RVA: 0x0004D804 File Offset: 0x0004BA04
		public unsafe override PreserveReferencesHandling PreserveReferencesHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753096, XrefRangeEnd = 753097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_PreserveReferencesHandling_Public_Virtual_get_PreserveReferencesHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753097, XrefRangeEnd = 753098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_PreserveReferencesHandling_Public_Virtual_set_Void_PreserveReferencesHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x0004D850 File Offset: 0x0004BA50
		// (set) Token: 0x06000CD2 RID: 3282 RVA: 0x0004D898 File Offset: 0x0004BA98
		public unsafe override TypeNameHandling TypeNameHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753098, XrefRangeEnd = 753099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_TypeNameHandling_Public_Virtual_get_TypeNameHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753099, XrefRangeEnd = 753100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_TypeNameHandling_Public_Virtual_set_Void_TypeNameHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x0004D8E4 File Offset: 0x0004BAE4
		// (set) Token: 0x06000CD4 RID: 3284 RVA: 0x0004D92C File Offset: 0x0004BB2C
		public unsafe override MetadataPropertyHandling MetadataPropertyHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753100, XrefRangeEnd = 753101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_MetadataPropertyHandling_Public_Virtual_get_MetadataPropertyHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753101, XrefRangeEnd = 753102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_MetadataPropertyHandling_Public_Virtual_set_Void_MetadataPropertyHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x0004D978 File Offset: 0x0004BB78
		// (set) Token: 0x06000CD6 RID: 3286 RVA: 0x0004D9C0 File Offset: 0x0004BBC0
		public unsafe override FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753102, XrefRangeEnd = 753103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_TypeNameAssemblyFormat_Public_Virtual_get_FormatterAssemblyStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753103, XrefRangeEnd = 753104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_TypeNameAssemblyFormat_Public_Virtual_set_Void_FormatterAssemblyStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000CD7 RID: 3287 RVA: 0x0004DA0C File Offset: 0x0004BC0C
		// (set) Token: 0x06000CD8 RID: 3288 RVA: 0x0004DA54 File Offset: 0x0004BC54
		public unsafe override TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753104, XrefRangeEnd = 753105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_TypeNameAssemblyFormatHandling_Public_Virtual_get_TypeNameAssemblyFormatHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753105, XrefRangeEnd = 753106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_TypeNameAssemblyFormatHandling_Public_Virtual_set_Void_TypeNameAssemblyFormatHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x0004DAA0 File Offset: 0x0004BCA0
		// (set) Token: 0x06000CDA RID: 3290 RVA: 0x0004DAE8 File Offset: 0x0004BCE8
		public unsafe override ConstructorHandling ConstructorHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753106, XrefRangeEnd = 753107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_ConstructorHandling_Public_Virtual_get_ConstructorHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753107, XrefRangeEnd = 753108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_ConstructorHandling_Public_Virtual_set_Void_ConstructorHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x0004DB34 File Offset: 0x0004BD34
		// (set) Token: 0x06000CDC RID: 3292 RVA: 0x0004DB80 File Offset: 0x0004BD80
		public unsafe override SerializationBinder Binder
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753108, XrefRangeEnd = 753109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_Binder_Public_Virtual_get_SerializationBinder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationBinder>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753109, XrefRangeEnd = 753110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_Binder_Public_Virtual_set_Void_SerializationBinder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x0004DBD0 File Offset: 0x0004BDD0
		// (set) Token: 0x06000CDE RID: 3294 RVA: 0x0004DC1C File Offset: 0x0004BE1C
		public unsafe override ISerializationBinder SerializationBinder
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753110, XrefRangeEnd = 753111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_SerializationBinder_Public_Virtual_get_ISerializationBinder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISerializationBinder>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753111, XrefRangeEnd = 753112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_SerializationBinder_Public_Virtual_set_Void_ISerializationBinder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x0004DC6C File Offset: 0x0004BE6C
		// (set) Token: 0x06000CE0 RID: 3296 RVA: 0x0004DCB0 File Offset: 0x0004BEB0
		public unsafe override StreamingContext Context
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_Context_Public_Virtual_get_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new StreamingContext(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_Context_Public_Virtual_set_Void_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x0004DD04 File Offset: 0x0004BF04
		// (set) Token: 0x06000CE2 RID: 3298 RVA: 0x0004DD4C File Offset: 0x0004BF4C
		public unsafe override Formatting Formatting
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753112, XrefRangeEnd = 753113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_Formatting_Public_Virtual_get_Formatting_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753113, XrefRangeEnd = 753114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_Formatting_Public_Virtual_set_Void_Formatting_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x0004DD98 File Offset: 0x0004BF98
		// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x0004DDE0 File Offset: 0x0004BFE0
		public unsafe override DateFormatHandling DateFormatHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753114, XrefRangeEnd = 753115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_DateFormatHandling_Public_Virtual_get_DateFormatHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753115, XrefRangeEnd = 753116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_DateFormatHandling_Public_Virtual_set_Void_DateFormatHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x0004DE2C File Offset: 0x0004C02C
		// (set) Token: 0x06000CE6 RID: 3302 RVA: 0x0004DE74 File Offset: 0x0004C074
		public unsafe override DateTimeZoneHandling DateTimeZoneHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753116, XrefRangeEnd = 753117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_DateTimeZoneHandling_Public_Virtual_get_DateTimeZoneHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753117, XrefRangeEnd = 753118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_DateTimeZoneHandling_Public_Virtual_set_Void_DateTimeZoneHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x0004DEC0 File Offset: 0x0004C0C0
		// (set) Token: 0x06000CE8 RID: 3304 RVA: 0x0004DF08 File Offset: 0x0004C108
		public unsafe override DateParseHandling DateParseHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753118, XrefRangeEnd = 753119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_DateParseHandling_Public_Virtual_get_DateParseHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753119, XrefRangeEnd = 753120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_DateParseHandling_Public_Virtual_set_Void_DateParseHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x0004DF54 File Offset: 0x0004C154
		// (set) Token: 0x06000CEA RID: 3306 RVA: 0x0004DF9C File Offset: 0x0004C19C
		public unsafe override FloatFormatHandling FloatFormatHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753120, XrefRangeEnd = 753121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_FloatFormatHandling_Public_Virtual_get_FloatFormatHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753121, XrefRangeEnd = 753122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_FloatFormatHandling_Public_Virtual_set_Void_FloatFormatHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000CEB RID: 3307 RVA: 0x0004DFE8 File Offset: 0x0004C1E8
		// (set) Token: 0x06000CEC RID: 3308 RVA: 0x0004E030 File Offset: 0x0004C230
		public unsafe override FloatParseHandling FloatParseHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753122, XrefRangeEnd = 753123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_FloatParseHandling_Public_Virtual_get_FloatParseHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753123, XrefRangeEnd = 753124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_FloatParseHandling_Public_Virtual_set_Void_FloatParseHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x0004E07C File Offset: 0x0004C27C
		// (set) Token: 0x06000CEE RID: 3310 RVA: 0x0004E0C4 File Offset: 0x0004C2C4
		public unsafe override StringEscapeHandling StringEscapeHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753124, XrefRangeEnd = 753125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_StringEscapeHandling_Public_Virtual_get_StringEscapeHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753125, XrefRangeEnd = 753126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_StringEscapeHandling_Public_Virtual_set_Void_StringEscapeHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000CEF RID: 3311 RVA: 0x0004E110 File Offset: 0x0004C310
		// (set) Token: 0x06000CF0 RID: 3312 RVA: 0x0004E154 File Offset: 0x0004C354
		public unsafe override string DateFormatString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753126, XrefRangeEnd = 753127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_DateFormatString_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753127, XrefRangeEnd = 753128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_DateFormatString_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x0004E1A4 File Offset: 0x0004C3A4
		// (set) Token: 0x06000CF2 RID: 3314 RVA: 0x0004E1F0 File Offset: 0x0004C3F0
		public unsafe override CultureInfo Culture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753128, XrefRangeEnd = 753129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_Culture_Public_Virtual_get_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753129, XrefRangeEnd = 753130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_Culture_Public_Virtual_set_Void_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x0004E240 File Offset: 0x0004C440
		// (set) Token: 0x06000CF4 RID: 3316 RVA: 0x0004E284 File Offset: 0x0004C484
		public unsafe override Nullable<int> MaxDepth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753130, XrefRangeEnd = 753131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_MaxDepth_Public_Virtual_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753131, XrefRangeEnd = 753132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_MaxDepth_Public_Virtual_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x0004E2D8 File Offset: 0x0004C4D8
		// (set) Token: 0x06000CF6 RID: 3318 RVA: 0x0004E320 File Offset: 0x0004C520
		public unsafe override bool CheckAdditionalContent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753132, XrefRangeEnd = 753133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_get_CheckAdditionalContent_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753133, XrefRangeEnd = 753134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_set_CheckAdditionalContent_Public_Virtual_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x0004E36C File Offset: 0x0004C56C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 753134, RefRangeEnd = 753135, XrefRangeStart = 753134, XrefRangeEnd = 753134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSerializerInternalBase GetInternalSerializer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerProxy.NativeMethodInfoPtr_GetInternalSerializer_Internal_JsonSerializerInternalBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSerializerInternalBase>(intPtr3) : null;
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x0004E3AC File Offset: 0x0004C5AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 753142, RefRangeEnd = 753144, XrefRangeStart = 753135, XrefRangeEnd = 753142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSerializerProxy(JsonSerializerInternalReader serializerReader)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializerReader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerProxy.NativeMethodInfoPtr__ctor_Public_Void_JsonSerializerInternalReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x0004E3F8 File Offset: 0x0004C5F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753144, XrefRangeEnd = 753151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSerializerProxy(JsonSerializerInternalWriter serializerWriter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSerializerProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializerWriter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerProxy.NativeMethodInfoPtr__ctor_Public_Void_JsonSerializerInternalWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x0004E444 File Offset: 0x0004C644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753151, XrefRangeEnd = 753153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object DeserializeInternal(JsonReader reader, Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_DeserializeInternal_Internal_Virtual_Object_JsonReader_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x0004E4B4 File Offset: 0x0004C6B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753153, XrefRangeEnd = 753156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PopulateInternal(JsonReader reader, Object target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_PopulateInternal_Internal_Virtual_Void_JsonReader_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x0004E514 File Offset: 0x0004C714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753156, XrefRangeEnd = 753159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SerializeInternal(JsonWriter jsonWriter, Object value, Type rootType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(jsonWriter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rootType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializerProxy.NativeMethodInfoPtr_SerializeInternal_Internal_Virtual_Void_JsonWriter_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00006318 File Offset: 0x00004518
		public JsonSerializerProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x0004E588 File Offset: 0x0004C788
		// (set) Token: 0x06000CFF RID: 3327 RVA: 0x00006321 File Offset: 0x00004521
		public unsafe JsonSerializerInternalReader _serializerReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerProxy.NativeFieldInfoPtr__serializerReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSerializerInternalReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerProxy.NativeFieldInfoPtr__serializerReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000D00 RID: 3328 RVA: 0x0004E5B8 File Offset: 0x0004C7B8
		// (set) Token: 0x06000D01 RID: 3329 RVA: 0x00006340 File Offset: 0x00004540
		public unsafe JsonSerializerInternalWriter _serializerWriter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerProxy.NativeFieldInfoPtr__serializerWriter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSerializerInternalWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerProxy.NativeFieldInfoPtr__serializerWriter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x0004E5E8 File Offset: 0x0004C7E8
		// (set) Token: 0x06000D03 RID: 3331 RVA: 0x0000635F File Offset: 0x0000455F
		public unsafe JsonSerializer _serializer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerProxy.NativeFieldInfoPtr__serializer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSerializer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerProxy.NativeFieldInfoPtr__serializer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeFieldInfoPtr__serializerReader;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeFieldInfoPtr__serializerWriter;

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeFieldInfoPtr__serializer;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeMethodInfoPtr_add_Error_Public_Virtual_add_Void_EventHandler_1_ErrorEventArgs_0;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeMethodInfoPtr_remove_Error_Public_Virtual_rem_Void_EventHandler_1_ErrorEventArgs_0;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeMethodInfoPtr_get_ReferenceResolver_Public_Virtual_get_IReferenceResolver_0;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeMethodInfoPtr_set_ReferenceResolver_Public_Virtual_set_Void_IReferenceResolver_0;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeMethodInfoPtr_get_TraceWriter_Public_Virtual_get_ITraceWriter_0;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeMethodInfoPtr_set_TraceWriter_Public_Virtual_set_Void_ITraceWriter_0;

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeMethodInfoPtr_get_EqualityComparer_Public_Virtual_get_IEqualityComparer_0;

		// Token: 0x04000A5A RID: 2650
		private static readonly IntPtr NativeMethodInfoPtr_set_EqualityComparer_Public_Virtual_set_Void_IEqualityComparer_0;

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeMethodInfoPtr_get_Converters_Public_Virtual_get_JsonConverterCollection_0;

		// Token: 0x04000A5C RID: 2652
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValueHandling_Public_Virtual_get_DefaultValueHandling_0;

		// Token: 0x04000A5D RID: 2653
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultValueHandling_Public_Virtual_set_Void_DefaultValueHandling_0;

		// Token: 0x04000A5E RID: 2654
		private static readonly IntPtr NativeMethodInfoPtr_get_ContractResolver_Public_Virtual_get_IContractResolver_0;

		// Token: 0x04000A5F RID: 2655
		private static readonly IntPtr NativeMethodInfoPtr_set_ContractResolver_Public_Virtual_set_Void_IContractResolver_0;

		// Token: 0x04000A60 RID: 2656
		private static readonly IntPtr NativeMethodInfoPtr_get_MissingMemberHandling_Public_Virtual_get_MissingMemberHandling_0;

		// Token: 0x04000A61 RID: 2657
		private static readonly IntPtr NativeMethodInfoPtr_set_MissingMemberHandling_Public_Virtual_set_Void_MissingMemberHandling_0;

		// Token: 0x04000A62 RID: 2658
		private static readonly IntPtr NativeMethodInfoPtr_get_NullValueHandling_Public_Virtual_get_NullValueHandling_0;

		// Token: 0x04000A63 RID: 2659
		private static readonly IntPtr NativeMethodInfoPtr_set_NullValueHandling_Public_Virtual_set_Void_NullValueHandling_0;

		// Token: 0x04000A64 RID: 2660
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectCreationHandling_Public_Virtual_get_ObjectCreationHandling_0;

		// Token: 0x04000A65 RID: 2661
		private static readonly IntPtr NativeMethodInfoPtr_set_ObjectCreationHandling_Public_Virtual_set_Void_ObjectCreationHandling_0;

		// Token: 0x04000A66 RID: 2662
		private static readonly IntPtr NativeMethodInfoPtr_get_ReferenceLoopHandling_Public_Virtual_get_ReferenceLoopHandling_0;

		// Token: 0x04000A67 RID: 2663
		private static readonly IntPtr NativeMethodInfoPtr_set_ReferenceLoopHandling_Public_Virtual_set_Void_ReferenceLoopHandling_0;

		// Token: 0x04000A68 RID: 2664
		private static readonly IntPtr NativeMethodInfoPtr_get_PreserveReferencesHandling_Public_Virtual_get_PreserveReferencesHandling_0;

		// Token: 0x04000A69 RID: 2665
		private static readonly IntPtr NativeMethodInfoPtr_set_PreserveReferencesHandling_Public_Virtual_set_Void_PreserveReferencesHandling_0;

		// Token: 0x04000A6A RID: 2666
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeNameHandling_Public_Virtual_get_TypeNameHandling_0;

		// Token: 0x04000A6B RID: 2667
		private static readonly IntPtr NativeMethodInfoPtr_set_TypeNameHandling_Public_Virtual_set_Void_TypeNameHandling_0;

		// Token: 0x04000A6C RID: 2668
		private static readonly IntPtr NativeMethodInfoPtr_get_MetadataPropertyHandling_Public_Virtual_get_MetadataPropertyHandling_0;

		// Token: 0x04000A6D RID: 2669
		private static readonly IntPtr NativeMethodInfoPtr_set_MetadataPropertyHandling_Public_Virtual_set_Void_MetadataPropertyHandling_0;

		// Token: 0x04000A6E RID: 2670
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeNameAssemblyFormat_Public_Virtual_get_FormatterAssemblyStyle_0;

		// Token: 0x04000A6F RID: 2671
		private static readonly IntPtr NativeMethodInfoPtr_set_TypeNameAssemblyFormat_Public_Virtual_set_Void_FormatterAssemblyStyle_0;

		// Token: 0x04000A70 RID: 2672
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeNameAssemblyFormatHandling_Public_Virtual_get_TypeNameAssemblyFormatHandling_0;

		// Token: 0x04000A71 RID: 2673
		private static readonly IntPtr NativeMethodInfoPtr_set_TypeNameAssemblyFormatHandling_Public_Virtual_set_Void_TypeNameAssemblyFormatHandling_0;

		// Token: 0x04000A72 RID: 2674
		private static readonly IntPtr NativeMethodInfoPtr_get_ConstructorHandling_Public_Virtual_get_ConstructorHandling_0;

		// Token: 0x04000A73 RID: 2675
		private static readonly IntPtr NativeMethodInfoPtr_set_ConstructorHandling_Public_Virtual_set_Void_ConstructorHandling_0;

		// Token: 0x04000A74 RID: 2676
		private static readonly IntPtr NativeMethodInfoPtr_get_Binder_Public_Virtual_get_SerializationBinder_0;

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeMethodInfoPtr_set_Binder_Public_Virtual_set_Void_SerializationBinder_0;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeMethodInfoPtr_get_SerializationBinder_Public_Virtual_get_ISerializationBinder_0;

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeMethodInfoPtr_set_SerializationBinder_Public_Virtual_set_Void_ISerializationBinder_0;

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeMethodInfoPtr_get_Context_Public_Virtual_get_StreamingContext_0;

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeMethodInfoPtr_set_Context_Public_Virtual_set_Void_StreamingContext_0;

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeMethodInfoPtr_get_Formatting_Public_Virtual_get_Formatting_0;

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeMethodInfoPtr_set_Formatting_Public_Virtual_set_Void_Formatting_0;

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeMethodInfoPtr_get_DateFormatHandling_Public_Virtual_get_DateFormatHandling_0;

		// Token: 0x04000A7D RID: 2685
		private static readonly IntPtr NativeMethodInfoPtr_set_DateFormatHandling_Public_Virtual_set_Void_DateFormatHandling_0;

		// Token: 0x04000A7E RID: 2686
		private static readonly IntPtr NativeMethodInfoPtr_get_DateTimeZoneHandling_Public_Virtual_get_DateTimeZoneHandling_0;

		// Token: 0x04000A7F RID: 2687
		private static readonly IntPtr NativeMethodInfoPtr_set_DateTimeZoneHandling_Public_Virtual_set_Void_DateTimeZoneHandling_0;

		// Token: 0x04000A80 RID: 2688
		private static readonly IntPtr NativeMethodInfoPtr_get_DateParseHandling_Public_Virtual_get_DateParseHandling_0;

		// Token: 0x04000A81 RID: 2689
		private static readonly IntPtr NativeMethodInfoPtr_set_DateParseHandling_Public_Virtual_set_Void_DateParseHandling_0;

		// Token: 0x04000A82 RID: 2690
		private static readonly IntPtr NativeMethodInfoPtr_get_FloatFormatHandling_Public_Virtual_get_FloatFormatHandling_0;

		// Token: 0x04000A83 RID: 2691
		private static readonly IntPtr NativeMethodInfoPtr_set_FloatFormatHandling_Public_Virtual_set_Void_FloatFormatHandling_0;

		// Token: 0x04000A84 RID: 2692
		private static readonly IntPtr NativeMethodInfoPtr_get_FloatParseHandling_Public_Virtual_get_FloatParseHandling_0;

		// Token: 0x04000A85 RID: 2693
		private static readonly IntPtr NativeMethodInfoPtr_set_FloatParseHandling_Public_Virtual_set_Void_FloatParseHandling_0;

		// Token: 0x04000A86 RID: 2694
		private static readonly IntPtr NativeMethodInfoPtr_get_StringEscapeHandling_Public_Virtual_get_StringEscapeHandling_0;

		// Token: 0x04000A87 RID: 2695
		private static readonly IntPtr NativeMethodInfoPtr_set_StringEscapeHandling_Public_Virtual_set_Void_StringEscapeHandling_0;

		// Token: 0x04000A88 RID: 2696
		private static readonly IntPtr NativeMethodInfoPtr_get_DateFormatString_Public_Virtual_get_String_0;

		// Token: 0x04000A89 RID: 2697
		private static readonly IntPtr NativeMethodInfoPtr_set_DateFormatString_Public_Virtual_set_Void_String_0;

		// Token: 0x04000A8A RID: 2698
		private static readonly IntPtr NativeMethodInfoPtr_get_Culture_Public_Virtual_get_CultureInfo_0;

		// Token: 0x04000A8B RID: 2699
		private static readonly IntPtr NativeMethodInfoPtr_set_Culture_Public_Virtual_set_Void_CultureInfo_0;

		// Token: 0x04000A8C RID: 2700
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxDepth_Public_Virtual_get_Nullable_1_Int32_0;

		// Token: 0x04000A8D RID: 2701
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxDepth_Public_Virtual_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000A8E RID: 2702
		private static readonly IntPtr NativeMethodInfoPtr_get_CheckAdditionalContent_Public_Virtual_get_Boolean_0;

		// Token: 0x04000A8F RID: 2703
		private static readonly IntPtr NativeMethodInfoPtr_set_CheckAdditionalContent_Public_Virtual_set_Void_Boolean_0;

		// Token: 0x04000A90 RID: 2704
		private static readonly IntPtr NativeMethodInfoPtr_GetInternalSerializer_Internal_JsonSerializerInternalBase_0;

		// Token: 0x04000A91 RID: 2705
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_JsonSerializerInternalReader_0;

		// Token: 0x04000A92 RID: 2706
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_JsonSerializerInternalWriter_0;

		// Token: 0x04000A93 RID: 2707
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeInternal_Internal_Virtual_Object_JsonReader_Type_0;

		// Token: 0x04000A94 RID: 2708
		private static readonly IntPtr NativeMethodInfoPtr_PopulateInternal_Internal_Virtual_Void_JsonReader_Object_0;

		// Token: 0x04000A95 RID: 2709
		private static readonly IntPtr NativeMethodInfoPtr_SerializeInternal_Internal_Virtual_Void_JsonWriter_Object_Type_0;
	}
}

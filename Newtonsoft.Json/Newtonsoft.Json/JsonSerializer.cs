using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Runtime.Serialization.Formatters;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x0200002B RID: 43
	public class JsonSerializer : Object
	{
		// Token: 0x06000220 RID: 544 RVA: 0x0001A9C8 File Offset: 0x00018BC8
		// Note: this type is marked as 'beforefieldinit'.
		static JsonSerializer()
		{
			Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json", "JsonSerializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr);
			JsonSerializer.NativeFieldInfoPtr__typeNameHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_typeNameHandling");
			JsonSerializer.NativeFieldInfoPtr__typeNameAssemblyFormatHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_typeNameAssemblyFormatHandling");
			JsonSerializer.NativeFieldInfoPtr__preserveReferencesHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_preserveReferencesHandling");
			JsonSerializer.NativeFieldInfoPtr__referenceLoopHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_referenceLoopHandling");
			JsonSerializer.NativeFieldInfoPtr__missingMemberHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_missingMemberHandling");
			JsonSerializer.NativeFieldInfoPtr__objectCreationHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_objectCreationHandling");
			JsonSerializer.NativeFieldInfoPtr__nullValueHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_nullValueHandling");
			JsonSerializer.NativeFieldInfoPtr__defaultValueHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_defaultValueHandling");
			JsonSerializer.NativeFieldInfoPtr__constructorHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_constructorHandling");
			JsonSerializer.NativeFieldInfoPtr__metadataPropertyHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_metadataPropertyHandling");
			JsonSerializer.NativeFieldInfoPtr__converters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_converters");
			JsonSerializer.NativeFieldInfoPtr__contractResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_contractResolver");
			JsonSerializer.NativeFieldInfoPtr__traceWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_traceWriter");
			JsonSerializer.NativeFieldInfoPtr__equalityComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_equalityComparer");
			JsonSerializer.NativeFieldInfoPtr__serializationBinder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_serializationBinder");
			JsonSerializer.NativeFieldInfoPtr__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_context");
			JsonSerializer.NativeFieldInfoPtr__referenceResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_referenceResolver");
			JsonSerializer.NativeFieldInfoPtr__formatting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_formatting");
			JsonSerializer.NativeFieldInfoPtr__dateFormatHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_dateFormatHandling");
			JsonSerializer.NativeFieldInfoPtr__dateTimeZoneHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_dateTimeZoneHandling");
			JsonSerializer.NativeFieldInfoPtr__dateParseHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_dateParseHandling");
			JsonSerializer.NativeFieldInfoPtr__floatFormatHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_floatFormatHandling");
			JsonSerializer.NativeFieldInfoPtr__floatParseHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_floatParseHandling");
			JsonSerializer.NativeFieldInfoPtr__stringEscapeHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_stringEscapeHandling");
			JsonSerializer.NativeFieldInfoPtr__culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_culture");
			JsonSerializer.NativeFieldInfoPtr__maxDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_maxDepth");
			JsonSerializer.NativeFieldInfoPtr__maxDepthSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_maxDepthSet");
			JsonSerializer.NativeFieldInfoPtr__checkAdditionalContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_checkAdditionalContent");
			JsonSerializer.NativeFieldInfoPtr__dateFormatString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_dateFormatString");
			JsonSerializer.NativeFieldInfoPtr__dateFormatStringSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "_dateFormatStringSet");
			JsonSerializer.NativeFieldInfoPtr_Error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, "Error");
			JsonSerializer.NativeMethodInfoPtr_add_Error_Public_Virtual_New_add_Void_EventHandler_1_ErrorEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663626);
			JsonSerializer.NativeMethodInfoPtr_remove_Error_Public_Virtual_New_rem_Void_EventHandler_1_ErrorEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663627);
			JsonSerializer.NativeMethodInfoPtr_get_ReferenceResolver_Public_Virtual_New_get_IReferenceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663628);
			JsonSerializer.NativeMethodInfoPtr_set_ReferenceResolver_Public_Virtual_New_set_Void_IReferenceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663629);
			JsonSerializer.NativeMethodInfoPtr_get_Binder_Public_Virtual_New_get_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663630);
			JsonSerializer.NativeMethodInfoPtr_set_Binder_Public_Virtual_New_set_Void_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663631);
			JsonSerializer.NativeMethodInfoPtr_get_SerializationBinder_Public_Virtual_New_get_ISerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663632);
			JsonSerializer.NativeMethodInfoPtr_set_SerializationBinder_Public_Virtual_New_set_Void_ISerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663633);
			JsonSerializer.NativeMethodInfoPtr_get_TraceWriter_Public_Virtual_New_get_ITraceWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663634);
			JsonSerializer.NativeMethodInfoPtr_set_TraceWriter_Public_Virtual_New_set_Void_ITraceWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663635);
			JsonSerializer.NativeMethodInfoPtr_get_EqualityComparer_Public_Virtual_New_get_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663636);
			JsonSerializer.NativeMethodInfoPtr_set_EqualityComparer_Public_Virtual_New_set_Void_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663637);
			JsonSerializer.NativeMethodInfoPtr_get_TypeNameHandling_Public_Virtual_New_get_TypeNameHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663638);
			JsonSerializer.NativeMethodInfoPtr_set_TypeNameHandling_Public_Virtual_New_set_Void_TypeNameHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663639);
			JsonSerializer.NativeMethodInfoPtr_get_TypeNameAssemblyFormat_Public_Virtual_New_get_FormatterAssemblyStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663640);
			JsonSerializer.NativeMethodInfoPtr_set_TypeNameAssemblyFormat_Public_Virtual_New_set_Void_FormatterAssemblyStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663641);
			JsonSerializer.NativeMethodInfoPtr_get_TypeNameAssemblyFormatHandling_Public_Virtual_New_get_TypeNameAssemblyFormatHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663642);
			JsonSerializer.NativeMethodInfoPtr_set_TypeNameAssemblyFormatHandling_Public_Virtual_New_set_Void_TypeNameAssemblyFormatHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663643);
			JsonSerializer.NativeMethodInfoPtr_get_PreserveReferencesHandling_Public_Virtual_New_get_PreserveReferencesHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663644);
			JsonSerializer.NativeMethodInfoPtr_set_PreserveReferencesHandling_Public_Virtual_New_set_Void_PreserveReferencesHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663645);
			JsonSerializer.NativeMethodInfoPtr_get_ReferenceLoopHandling_Public_Virtual_New_get_ReferenceLoopHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663646);
			JsonSerializer.NativeMethodInfoPtr_set_ReferenceLoopHandling_Public_Virtual_New_set_Void_ReferenceLoopHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663647);
			JsonSerializer.NativeMethodInfoPtr_get_MissingMemberHandling_Public_Virtual_New_get_MissingMemberHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663648);
			JsonSerializer.NativeMethodInfoPtr_set_MissingMemberHandling_Public_Virtual_New_set_Void_MissingMemberHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663649);
			JsonSerializer.NativeMethodInfoPtr_get_NullValueHandling_Public_Virtual_New_get_NullValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663650);
			JsonSerializer.NativeMethodInfoPtr_set_NullValueHandling_Public_Virtual_New_set_Void_NullValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663651);
			JsonSerializer.NativeMethodInfoPtr_get_DefaultValueHandling_Public_Virtual_New_get_DefaultValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663652);
			JsonSerializer.NativeMethodInfoPtr_set_DefaultValueHandling_Public_Virtual_New_set_Void_DefaultValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663653);
			JsonSerializer.NativeMethodInfoPtr_get_ObjectCreationHandling_Public_Virtual_New_get_ObjectCreationHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663654);
			JsonSerializer.NativeMethodInfoPtr_set_ObjectCreationHandling_Public_Virtual_New_set_Void_ObjectCreationHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663655);
			JsonSerializer.NativeMethodInfoPtr_get_ConstructorHandling_Public_Virtual_New_get_ConstructorHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663656);
			JsonSerializer.NativeMethodInfoPtr_set_ConstructorHandling_Public_Virtual_New_set_Void_ConstructorHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663657);
			JsonSerializer.NativeMethodInfoPtr_get_MetadataPropertyHandling_Public_Virtual_New_get_MetadataPropertyHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663658);
			JsonSerializer.NativeMethodInfoPtr_set_MetadataPropertyHandling_Public_Virtual_New_set_Void_MetadataPropertyHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663659);
			JsonSerializer.NativeMethodInfoPtr_get_Converters_Public_Virtual_New_get_JsonConverterCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663660);
			JsonSerializer.NativeMethodInfoPtr_get_ContractResolver_Public_Virtual_New_get_IContractResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663661);
			JsonSerializer.NativeMethodInfoPtr_set_ContractResolver_Public_Virtual_New_set_Void_IContractResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663662);
			JsonSerializer.NativeMethodInfoPtr_get_Context_Public_Virtual_New_get_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663663);
			JsonSerializer.NativeMethodInfoPtr_set_Context_Public_Virtual_New_set_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663664);
			JsonSerializer.NativeMethodInfoPtr_get_Formatting_Public_Virtual_New_get_Formatting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663665);
			JsonSerializer.NativeMethodInfoPtr_set_Formatting_Public_Virtual_New_set_Void_Formatting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663666);
			JsonSerializer.NativeMethodInfoPtr_get_DateFormatHandling_Public_Virtual_New_get_DateFormatHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663667);
			JsonSerializer.NativeMethodInfoPtr_set_DateFormatHandling_Public_Virtual_New_set_Void_DateFormatHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663668);
			JsonSerializer.NativeMethodInfoPtr_get_DateTimeZoneHandling_Public_Virtual_New_get_DateTimeZoneHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663669);
			JsonSerializer.NativeMethodInfoPtr_set_DateTimeZoneHandling_Public_Virtual_New_set_Void_DateTimeZoneHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663670);
			JsonSerializer.NativeMethodInfoPtr_get_DateParseHandling_Public_Virtual_New_get_DateParseHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663671);
			JsonSerializer.NativeMethodInfoPtr_set_DateParseHandling_Public_Virtual_New_set_Void_DateParseHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663672);
			JsonSerializer.NativeMethodInfoPtr_get_FloatParseHandling_Public_Virtual_New_get_FloatParseHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663673);
			JsonSerializer.NativeMethodInfoPtr_set_FloatParseHandling_Public_Virtual_New_set_Void_FloatParseHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663674);
			JsonSerializer.NativeMethodInfoPtr_get_FloatFormatHandling_Public_Virtual_New_get_FloatFormatHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663675);
			JsonSerializer.NativeMethodInfoPtr_set_FloatFormatHandling_Public_Virtual_New_set_Void_FloatFormatHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663676);
			JsonSerializer.NativeMethodInfoPtr_get_StringEscapeHandling_Public_Virtual_New_get_StringEscapeHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663677);
			JsonSerializer.NativeMethodInfoPtr_set_StringEscapeHandling_Public_Virtual_New_set_Void_StringEscapeHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663678);
			JsonSerializer.NativeMethodInfoPtr_get_DateFormatString_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663679);
			JsonSerializer.NativeMethodInfoPtr_set_DateFormatString_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663680);
			JsonSerializer.NativeMethodInfoPtr_get_Culture_Public_Virtual_New_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663681);
			JsonSerializer.NativeMethodInfoPtr_set_Culture_Public_Virtual_New_set_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663682);
			JsonSerializer.NativeMethodInfoPtr_get_MaxDepth_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663683);
			JsonSerializer.NativeMethodInfoPtr_set_MaxDepth_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663684);
			JsonSerializer.NativeMethodInfoPtr_get_CheckAdditionalContent_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663685);
			JsonSerializer.NativeMethodInfoPtr_set_CheckAdditionalContent_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663686);
			JsonSerializer.NativeMethodInfoPtr_IsCheckAdditionalContentSet_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663687);
			JsonSerializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663688);
			JsonSerializer.NativeMethodInfoPtr_Create_Public_Static_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663689);
			JsonSerializer.NativeMethodInfoPtr_Create_Public_Static_JsonSerializer_JsonSerializerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663690);
			JsonSerializer.NativeMethodInfoPtr_CreateDefault_Public_Static_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663691);
			JsonSerializer.NativeMethodInfoPtr_CreateDefault_Public_Static_JsonSerializer_JsonSerializerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663692);
			JsonSerializer.NativeMethodInfoPtr_ApplySerializerSettings_Private_Static_Void_JsonSerializer_JsonSerializerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663693);
			JsonSerializer.NativeMethodInfoPtr_Populate_Public_Void_TextReader_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663694);
			JsonSerializer.NativeMethodInfoPtr_Populate_Public_Void_JsonReader_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663695);
			JsonSerializer.NativeMethodInfoPtr_PopulateInternal_Internal_Virtual_New_Void_JsonReader_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663696);
			JsonSerializer.NativeMethodInfoPtr_Deserialize_Public_Object_JsonReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663697);
			JsonSerializer.NativeMethodInfoPtr_Deserialize_Public_Object_TextReader_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663698);
			JsonSerializer.NativeMethodInfoPtr_Deserialize_Public_T_JsonReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663699);
			JsonSerializer.NativeMethodInfoPtr_Deserialize_Public_Object_JsonReader_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663700);
			JsonSerializer.NativeMethodInfoPtr_DeserializeInternal_Internal_Virtual_New_Object_JsonReader_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663701);
			JsonSerializer.NativeMethodInfoPtr_SetupReader_Internal_Void_JsonReader_byref_CultureInfo_byref_Nullable_1_DateTimeZoneHandling_byref_Nullable_1_DateParseHandling_byref_Nullable_1_FloatParseHandling_byref_Nullable_1_Int32_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663702);
			JsonSerializer.NativeMethodInfoPtr_ResetReader_Private_Void_JsonReader_CultureInfo_Nullable_1_DateTimeZoneHandling_Nullable_1_DateParseHandling_Nullable_1_FloatParseHandling_Nullable_1_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663703);
			JsonSerializer.NativeMethodInfoPtr_Serialize_Public_Void_TextWriter_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663704);
			JsonSerializer.NativeMethodInfoPtr_Serialize_Public_Void_JsonWriter_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663705);
			JsonSerializer.NativeMethodInfoPtr_Serialize_Public_Void_TextWriter_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663706);
			JsonSerializer.NativeMethodInfoPtr_Serialize_Public_Void_JsonWriter_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663707);
			JsonSerializer.NativeMethodInfoPtr_CreateTraceJsonReader_Private_TraceJsonReader_JsonReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663708);
			JsonSerializer.NativeMethodInfoPtr_SerializeInternal_Internal_Virtual_New_Void_JsonWriter_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663709);
			JsonSerializer.NativeMethodInfoPtr_GetReferenceResolver_Internal_IReferenceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663710);
			JsonSerializer.NativeMethodInfoPtr_GetMatchingConverter_Internal_JsonConverter_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663711);
			JsonSerializer.NativeMethodInfoPtr_GetMatchingConverter_Internal_Static_JsonConverter_IList_1_JsonConverter_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663712);
			JsonSerializer.NativeMethodInfoPtr_OnError_Internal_Void_ErrorEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr, 100663713);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0001B344 File Offset: 0x00019544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729332, XrefRangeEnd = 729337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_Error(EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_add_Error_Public_Virtual_New_add_Void_EventHandler_1_ErrorEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0001B394 File Offset: 0x00019594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729337, XrefRangeEnd = 729342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_Error(EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_remove_Error_Public_Virtual_New_rem_Void_EventHandler_1_ErrorEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0001B3E4 File Offset: 0x000195E4
		// (set) Token: 0x06000224 RID: 548 RVA: 0x0001B430 File Offset: 0x00019630
		public unsafe virtual IReferenceResolver ReferenceResolver
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 729347, RefRangeEnd = 729352, XrefRangeStart = 729342, XrefRangeEnd = 729347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_ReferenceResolver_Public_Virtual_New_get_IReferenceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReferenceResolver>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729352, XrefRangeEnd = 729360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_ReferenceResolver_Public_Virtual_New_set_Void_IReferenceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0001B480 File Offset: 0x00019680
		// (set) Token: 0x06000226 RID: 550 RVA: 0x0001B4CC File Offset: 0x000196CC
		public unsafe virtual SerializationBinder Binder
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729360, XrefRangeEnd = 729366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_Binder_Public_Virtual_New_get_SerializationBinder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationBinder>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729366, XrefRangeEnd = 729382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_Binder_Public_Virtual_New_set_Void_SerializationBinder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0001B51C File Offset: 0x0001971C
		// (set) Token: 0x06000228 RID: 552 RVA: 0x0001B568 File Offset: 0x00019768
		public unsafe virtual ISerializationBinder SerializationBinder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_SerializationBinder_Public_Virtual_New_get_ISerializationBinder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISerializationBinder>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729382, XrefRangeEnd = 729390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_SerializationBinder_Public_Virtual_New_set_Void_ISerializationBinder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0001B5B8 File Offset: 0x000197B8
		// (set) Token: 0x0600022A RID: 554 RVA: 0x0001B604 File Offset: 0x00019804
		public unsafe virtual ITraceWriter TraceWriter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_TraceWriter_Public_Virtual_New_get_ITraceWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITraceWriter>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_TraceWriter_Public_Virtual_New_set_Void_ITraceWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600022B RID: 555 RVA: 0x0001B654 File Offset: 0x00019854
		// (set) Token: 0x0600022C RID: 556 RVA: 0x0001B6A0 File Offset: 0x000198A0
		public unsafe virtual IEqualityComparer EqualityComparer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_EqualityComparer_Public_Virtual_New_get_IEqualityComparer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEqualityComparer>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_EqualityComparer_Public_Virtual_New_set_Void_IEqualityComparer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0001B6F0 File Offset: 0x000198F0
		// (set) Token: 0x0600022E RID: 558 RVA: 0x0001B738 File Offset: 0x00019938
		public unsafe virtual TypeNameHandling TypeNameHandling
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_TypeNameHandling_Public_Virtual_New_get_TypeNameHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_TypeNameHandling_Public_Virtual_New_set_Void_TypeNameHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600022F RID: 559 RVA: 0x0001B784 File Offset: 0x00019984
		// (set) Token: 0x06000230 RID: 560 RVA: 0x0001B7CC File Offset: 0x000199CC
		public unsafe virtual FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_TypeNameAssemblyFormat_Public_Virtual_New_get_FormatterAssemblyStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_TypeNameAssemblyFormat_Public_Virtual_New_set_Void_FormatterAssemblyStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000231 RID: 561 RVA: 0x0001B818 File Offset: 0x00019A18
		// (set) Token: 0x06000232 RID: 562 RVA: 0x0001B860 File Offset: 0x00019A60
		public unsafe virtual TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_TypeNameAssemblyFormatHandling_Public_Virtual_New_get_TypeNameAssemblyFormatHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_TypeNameAssemblyFormatHandling_Public_Virtual_New_set_Void_TypeNameAssemblyFormatHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0001B8AC File Offset: 0x00019AAC
		// (set) Token: 0x06000234 RID: 564 RVA: 0x0001B8F4 File Offset: 0x00019AF4
		public unsafe virtual PreserveReferencesHandling PreserveReferencesHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_PreserveReferencesHandling_Public_Virtual_New_get_PreserveReferencesHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_PreserveReferencesHandling_Public_Virtual_New_set_Void_PreserveReferencesHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000235 RID: 565 RVA: 0x0001B940 File Offset: 0x00019B40
		// (set) Token: 0x06000236 RID: 566 RVA: 0x0001B988 File Offset: 0x00019B88
		public unsafe virtual ReferenceLoopHandling ReferenceLoopHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_ReferenceLoopHandling_Public_Virtual_New_get_ReferenceLoopHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_ReferenceLoopHandling_Public_Virtual_New_set_Void_ReferenceLoopHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0001B9D4 File Offset: 0x00019BD4
		// (set) Token: 0x06000238 RID: 568 RVA: 0x0001BA1C File Offset: 0x00019C1C
		public unsafe virtual MissingMemberHandling MissingMemberHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_MissingMemberHandling_Public_Virtual_New_get_MissingMemberHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_MissingMemberHandling_Public_Virtual_New_set_Void_MissingMemberHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0001BA68 File Offset: 0x00019C68
		// (set) Token: 0x0600023A RID: 570 RVA: 0x0001BAB0 File Offset: 0x00019CB0
		public unsafe virtual NullValueHandling NullValueHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_NullValueHandling_Public_Virtual_New_get_NullValueHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_NullValueHandling_Public_Virtual_New_set_Void_NullValueHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0001BAFC File Offset: 0x00019CFC
		// (set) Token: 0x0600023C RID: 572 RVA: 0x0001BB44 File Offset: 0x00019D44
		public unsafe virtual DefaultValueHandling DefaultValueHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_DefaultValueHandling_Public_Virtual_New_get_DefaultValueHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_DefaultValueHandling_Public_Virtual_New_set_Void_DefaultValueHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600023D RID: 573 RVA: 0x0001BB90 File Offset: 0x00019D90
		// (set) Token: 0x0600023E RID: 574 RVA: 0x0001BBD8 File Offset: 0x00019DD8
		public unsafe virtual ObjectCreationHandling ObjectCreationHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_ObjectCreationHandling_Public_Virtual_New_get_ObjectCreationHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_ObjectCreationHandling_Public_Virtual_New_set_Void_ObjectCreationHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600023F RID: 575 RVA: 0x0001BC24 File Offset: 0x00019E24
		// (set) Token: 0x06000240 RID: 576 RVA: 0x0001BC6C File Offset: 0x00019E6C
		public unsafe virtual ConstructorHandling ConstructorHandling
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_ConstructorHandling_Public_Virtual_New_get_ConstructorHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_ConstructorHandling_Public_Virtual_New_set_Void_ConstructorHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000241 RID: 577 RVA: 0x0001BCB8 File Offset: 0x00019EB8
		// (set) Token: 0x06000242 RID: 578 RVA: 0x0001BD00 File Offset: 0x00019F00
		public unsafe virtual MetadataPropertyHandling MetadataPropertyHandling
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 134006, RefRangeEnd = 134007, XrefRangeStart = 134006, XrefRangeEnd = 134007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_MetadataPropertyHandling_Public_Virtual_New_get_MetadataPropertyHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_MetadataPropertyHandling_Public_Virtual_New_set_Void_MetadataPropertyHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000243 RID: 579 RVA: 0x0001BD4C File Offset: 0x00019F4C
		public unsafe virtual JsonConverterCollection Converters
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729390, XrefRangeEnd = 729397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_Converters_Public_Virtual_New_get_JsonConverterCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonConverterCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0001BD98 File Offset: 0x00019F98
		// (set) Token: 0x06000245 RID: 581 RVA: 0x0001BDE4 File Offset: 0x00019FE4
		public unsafe virtual IContractResolver ContractResolver
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_ContractResolver_Public_Virtual_New_get_IContractResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IContractResolver>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729397, XrefRangeEnd = 729406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_ContractResolver_Public_Virtual_New_set_Void_IContractResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000246 RID: 582 RVA: 0x0001BE34 File Offset: 0x0001A034
		// (set) Token: 0x06000247 RID: 583 RVA: 0x0001BE78 File Offset: 0x0001A078
		public unsafe virtual StreamingContext Context
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_Context_Public_Virtual_New_get_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new StreamingContext(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729406, XrefRangeEnd = 729407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_Context_Public_Virtual_New_set_Void_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000248 RID: 584 RVA: 0x0001BECC File Offset: 0x0001A0CC
		// (set) Token: 0x06000249 RID: 585 RVA: 0x0001BF14 File Offset: 0x0001A114
		public unsafe virtual Formatting Formatting
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729407, XrefRangeEnd = 729408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_Formatting_Public_Virtual_New_get_Formatting_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729408, XrefRangeEnd = 729411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_Formatting_Public_Virtual_New_set_Void_Formatting_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600024A RID: 586 RVA: 0x0001BF60 File Offset: 0x0001A160
		// (set) Token: 0x0600024B RID: 587 RVA: 0x0001BFA8 File Offset: 0x0001A1A8
		public unsafe virtual DateFormatHandling DateFormatHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729411, XrefRangeEnd = 729412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_DateFormatHandling_Public_Virtual_New_get_DateFormatHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729412, XrefRangeEnd = 729415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_DateFormatHandling_Public_Virtual_New_set_Void_DateFormatHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600024C RID: 588 RVA: 0x0001BFF4 File Offset: 0x0001A1F4
		// (set) Token: 0x0600024D RID: 589 RVA: 0x0001C03C File Offset: 0x0001A23C
		public unsafe virtual DateTimeZoneHandling DateTimeZoneHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729415, XrefRangeEnd = 729417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_DateTimeZoneHandling_Public_Virtual_New_get_DateTimeZoneHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729417, XrefRangeEnd = 729420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_DateTimeZoneHandling_Public_Virtual_New_set_Void_DateTimeZoneHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600024E RID: 590 RVA: 0x0001C088 File Offset: 0x0001A288
		// (set) Token: 0x0600024F RID: 591 RVA: 0x0001C0D0 File Offset: 0x0001A2D0
		public unsafe virtual DateParseHandling DateParseHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729420, XrefRangeEnd = 729422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_DateParseHandling_Public_Virtual_New_get_DateParseHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729422, XrefRangeEnd = 729425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_DateParseHandling_Public_Virtual_New_set_Void_DateParseHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0001C11C File Offset: 0x0001A31C
		// (set) Token: 0x06000251 RID: 593 RVA: 0x0001C164 File Offset: 0x0001A364
		public unsafe virtual FloatParseHandling FloatParseHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729425, XrefRangeEnd = 729426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_FloatParseHandling_Public_Virtual_New_get_FloatParseHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729426, XrefRangeEnd = 729429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_FloatParseHandling_Public_Virtual_New_set_Void_FloatParseHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0001C1B0 File Offset: 0x0001A3B0
		// (set) Token: 0x06000253 RID: 595 RVA: 0x0001C1F8 File Offset: 0x0001A3F8
		public unsafe virtual FloatFormatHandling FloatFormatHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729429, XrefRangeEnd = 729430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_FloatFormatHandling_Public_Virtual_New_get_FloatFormatHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729430, XrefRangeEnd = 729433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_FloatFormatHandling_Public_Virtual_New_set_Void_FloatFormatHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0001C244 File Offset: 0x0001A444
		// (set) Token: 0x06000255 RID: 597 RVA: 0x0001C28C File Offset: 0x0001A48C
		public unsafe virtual StringEscapeHandling StringEscapeHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729433, XrefRangeEnd = 729434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_StringEscapeHandling_Public_Virtual_New_get_StringEscapeHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729434, XrefRangeEnd = 729437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_StringEscapeHandling_Public_Virtual_New_set_Void_StringEscapeHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000256 RID: 598 RVA: 0x0001C2D8 File Offset: 0x0001A4D8
		// (set) Token: 0x06000257 RID: 599 RVA: 0x0001C31C File Offset: 0x0001A51C
		public unsafe virtual string DateFormatString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729437, XrefRangeEnd = 729439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_DateFormatString_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729439, XrefRangeEnd = 729440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_DateFormatString_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000258 RID: 600 RVA: 0x0001C36C File Offset: 0x0001A56C
		// (set) Token: 0x06000259 RID: 601 RVA: 0x0001C3B8 File Offset: 0x0001A5B8
		public unsafe virtual CultureInfo Culture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729440, XrefRangeEnd = 729444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_Culture_Public_Virtual_New_get_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_Culture_Public_Virtual_New_set_Void_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600025A RID: 602 RVA: 0x0001C408 File Offset: 0x0001A608
		// (set) Token: 0x0600025B RID: 603 RVA: 0x0001C44C File Offset: 0x0001A64C
		public unsafe virtual Nullable<int> MaxDepth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_MaxDepth_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729444, XrefRangeEnd = 729446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_MaxDepth_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0001C4A0 File Offset: 0x0001A6A0
		// (set) Token: 0x0600025D RID: 605 RVA: 0x0001C4E8 File Offset: 0x0001A6E8
		public unsafe virtual bool CheckAdditionalContent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729446, XrefRangeEnd = 729447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_get_CheckAdditionalContent_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729447, XrefRangeEnd = 729450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_set_CheckAdditionalContent_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0001C534 File Offset: 0x0001A734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729450, XrefRangeEnd = 729451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCheckAdditionalContentSet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializer.NativeMethodInfoPtr_IsCheckAdditionalContentSet_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0001C570 File Offset: 0x0001A770
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 729472, RefRangeEnd = 729476, XrefRangeStart = 729451, XrefRangeEnd = 729472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSerializer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0001C5AC File Offset: 0x0001A7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729476, XrefRangeEnd = 729500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JsonSerializer Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializer.NativeMethodInfoPtr_Create_Public_Static_JsonSerializer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSerializer>(intPtr3) : null;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0001C5E0 File Offset: 0x0001A7E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 729525, RefRangeEnd = 729527, XrefRangeStart = 729500, XrefRangeEnd = 729525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JsonSerializer Create(JsonSerializerSettings settings)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializer.NativeMethodInfoPtr_Create_Public_Static_JsonSerializer_JsonSerializerSettings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSerializer>(intPtr3) : null;
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0001C624 File Offset: 0x0001A824
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 729560, RefRangeEnd = 729574, XrefRangeStart = 729527, XrefRangeEnd = 729560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JsonSerializer CreateDefault()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializer.NativeMethodInfoPtr_CreateDefault_Public_Static_JsonSerializer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSerializer>(intPtr3) : null;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0001C658 File Offset: 0x0001A858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729574, XrefRangeEnd = 729576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JsonSerializer CreateDefault(JsonSerializerSettings settings)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializer.NativeMethodInfoPtr_CreateDefault_Public_Static_JsonSerializer_JsonSerializerSettings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSerializer>(intPtr3) : null;
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0001C69C File Offset: 0x0001A89C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 729629, RefRangeEnd = 729638, XrefRangeStart = 729576, XrefRangeEnd = 729629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializer.NativeMethodInfoPtr_ApplySerializerSettings_Private_Static_Void_JsonSerializer_JsonSerializerSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0001C6E4 File Offset: 0x0001A8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729638, XrefRangeEnd = 729642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Populate(TextReader reader, Object target)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializer.NativeMethodInfoPtr_Populate_Public_Void_TextReader_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0001C738 File Offset: 0x0001A938
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 729642, RefRangeEnd = 729644, XrefRangeStart = 729642, XrefRangeEnd = 729642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Populate(JsonReader reader, Object target)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializer.NativeMethodInfoPtr_Populate_Public_Void_JsonReader_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0001C78C File Offset: 0x0001A98C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729644, XrefRangeEnd = 729672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PopulateInternal(JsonReader reader, Object target)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_PopulateInternal_Internal_Virtual_New_Void_JsonReader_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0001C7EC File Offset: 0x0001A9EC
		[CallerCount(0)]
		public unsafe Object Deserialize(JsonReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializer.NativeMethodInfoPtr_Deserialize_Public_Object_JsonReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0001C83C File Offset: 0x0001AA3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 729676, RefRangeEnd = 729677, XrefRangeStart = 729672, XrefRangeEnd = 729676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Deserialize(TextReader reader, Type objectType)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializer.NativeMethodInfoPtr_Deserialize_Public_Object_TextReader_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0001C8A0 File Offset: 0x0001AAA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 729685, RefRangeEnd = 729686, XrefRangeStart = 729677, XrefRangeEnd = 729685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Deserialize<T>(JsonReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializer.MethodInfoStoreGeneric_Deserialize_Public_T_JsonReader_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0001C8EC File Offset: 0x0001AAEC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 729686, RefRangeEnd = 729693, XrefRangeStart = 729686, XrefRangeEnd = 729686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Deserialize(JsonReader reader, Type objectType)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializer.NativeMethodInfoPtr_Deserialize_Public_Object_JsonReader_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0001C950 File Offset: 0x0001AB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729693, XrefRangeEnd = 729718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object DeserializeInternal(JsonReader reader, Type objectType)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_DeserializeInternal_Internal_Virtual_New_Object_JsonReader_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0001C9C0 File Offset: 0x0001ABC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 729766, RefRangeEnd = 729769, XrefRangeStart = 729718, XrefRangeEnd = 729766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupReader(JsonReader reader, out CultureInfo previousCulture, out Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, out Nullable<DateParseHandling> previousDateParseHandling, out Nullable<FloatParseHandling> previousFloatParseHandling, out Nullable<int> previousMaxDepth, out string previousDateFormatString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = 0;
			ptr5 = &intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5 = 0;
			ptr6 = &intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6 = 0;
			ptr7 = &intPtr6;
			IntPtr intPtr8;
			IntPtr intPtr7 = IL2CPP.il2cpp_runtime_invoke(JsonSerializer.NativeMethodInfoPtr_SetupReader_Internal_Void_JsonReader_byref_CultureInfo_byref_Nullable_1_DateTimeZoneHandling_byref_Nullable_1_DateParseHandling_byref_Nullable_1_FloatParseHandling_byref_Nullable_1_Int32_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr8);
			Il2CppException.RaiseExceptionIfNecessary(intPtr8);
			IntPtr intPtr9 = intPtr;
			previousCulture = ((intPtr9 == 0) ? null : new CultureInfo(intPtr9));
			IntPtr intPtr10 = intPtr2;
			previousDateTimeZoneHandling = ((intPtr10 == 0) ? null : new Nullable<DateTimeZoneHandling>(intPtr10));
			IntPtr intPtr11 = intPtr3;
			previousDateParseHandling = ((intPtr11 == 0) ? null : new Nullable<DateParseHandling>(intPtr11));
			IntPtr intPtr12 = intPtr4;
			previousFloatParseHandling = ((intPtr12 == 0) ? null : new Nullable<FloatParseHandling>(intPtr12));
			IntPtr intPtr13 = intPtr5;
			previousMaxDepth = ((intPtr13 == 0) ? null : new Nullable<int>(intPtr13));
			previousDateFormatString = IL2CPP.Il2CppStringToManaged(intPtr6);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0001CAD0 File Offset: 0x0001ACD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 729786, RefRangeEnd = 729788, XrefRangeStart = 729769, XrefRangeEnd = 729786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetReader(JsonReader reader, CultureInfo previousCulture, Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, Nullable<DateParseHandling> previousDateParseHandling, Nullable<FloatParseHandling> previousFloatParseHandling, Nullable<int> previousMaxDepth, string previousDateFormatString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(previousCulture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(previousDateTimeZoneHandling));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(previousDateParseHandling));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(previousFloatParseHandling));
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(previousMaxDepth));
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(previousDateFormatString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializer.NativeMethodInfoPtr_ResetReader_Private_Void_JsonReader_CultureInfo_Nullable_1_DateTimeZoneHandling_Nullable_1_DateParseHandling_Nullable_1_FloatParseHandling_Nullable_1_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0001CB98 File Offset: 0x0001AD98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 729792, RefRangeEnd = 729794, XrefRangeStart = 729788, XrefRangeEnd = 729792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Serialize(TextWriter textWriter, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textWriter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializer.NativeMethodInfoPtr_Serialize_Public_Void_TextWriter_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0001CBEC File Offset: 0x0001ADEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 729794, RefRangeEnd = 729796, XrefRangeStart = 729794, XrefRangeEnd = 729794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Serialize(JsonWriter jsonWriter, Object value, Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(jsonWriter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializer.NativeMethodInfoPtr_Serialize_Public_Void_JsonWriter_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0001CC54 File Offset: 0x0001AE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729796, XrefRangeEnd = 729800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Serialize(TextWriter textWriter, Object value, Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textWriter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializer.NativeMethodInfoPtr_Serialize_Public_Void_TextWriter_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0001CCBC File Offset: 0x0001AEBC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 729800, RefRangeEnd = 729806, XrefRangeStart = 729800, XrefRangeEnd = 729800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Serialize(JsonWriter jsonWriter, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(jsonWriter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializer.NativeMethodInfoPtr_Serialize_Public_Void_JsonWriter_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0001CD10 File Offset: 0x0001AF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729806, XrefRangeEnd = 729811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraceJsonReader CreateTraceJsonReader(JsonReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializer.NativeMethodInfoPtr_CreateTraceJsonReader_Private_TraceJsonReader_JsonReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TraceJsonReader>(intPtr3) : null;
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0001CD60 File Offset: 0x0001AF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729811, XrefRangeEnd = 729875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SerializeInternal(JsonWriter jsonWriter, Object value, Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(jsonWriter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSerializer.NativeMethodInfoPtr_SerializeInternal_Internal_Virtual_New_Void_JsonWriter_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0001CDD4 File Offset: 0x0001AFD4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 729347, RefRangeEnd = 729352, XrefRangeStart = 729347, XrefRangeEnd = 729352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IReferenceResolver GetReferenceResolver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializer.NativeMethodInfoPtr_GetReferenceResolver_Internal_IReferenceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReferenceResolver>(intPtr3) : null;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0001CE14 File Offset: 0x0001B014
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 729882, RefRangeEnd = 729892, XrefRangeStart = 729875, XrefRangeEnd = 729882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonConverter GetMatchingConverter(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializer.NativeMethodInfoPtr_GetMatchingConverter_Internal_JsonConverter_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonConverter>(intPtr3) : null;
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0001CE64 File Offset: 0x0001B064
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 729900, RefRangeEnd = 729903, XrefRangeStart = 729892, XrefRangeEnd = 729900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, Type objectType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(converters);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializer.NativeMethodInfoPtr_GetMatchingConverter_Internal_Static_JsonConverter_IList_1_JsonConverter_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonConverter>(intPtr3) : null;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0001CEBC File Offset: 0x0001B0BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 729903, RefRangeEnd = 729904, XrefRangeStart = 729903, XrefRangeEnd = 729903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnError(Newtonsoft.Json.Serialization.ErrorEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializer.NativeMethodInfoPtr_OnError_Internal_Void_ErrorEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002D9F File Offset: 0x00000F9F
		public JsonSerializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0001CF00 File Offset: 0x0001B100
		// (set) Token: 0x0600027B RID: 635 RVA: 0x00002DA8 File Offset: 0x00000FA8
		public unsafe TypeNameHandling _typeNameHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__typeNameHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__typeNameHandling)) = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0001CF28 File Offset: 0x0001B128
		// (set) Token: 0x0600027D RID: 637 RVA: 0x00002DC3 File Offset: 0x00000FC3
		public unsafe TypeNameAssemblyFormatHandling _typeNameAssemblyFormatHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__typeNameAssemblyFormatHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__typeNameAssemblyFormatHandling)) = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0001CF50 File Offset: 0x0001B150
		// (set) Token: 0x0600027F RID: 639 RVA: 0x00002DDE File Offset: 0x00000FDE
		public unsafe PreserveReferencesHandling _preserveReferencesHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__preserveReferencesHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__preserveReferencesHandling)) = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0001CF78 File Offset: 0x0001B178
		// (set) Token: 0x06000281 RID: 641 RVA: 0x00002DF9 File Offset: 0x00000FF9
		public unsafe ReferenceLoopHandling _referenceLoopHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__referenceLoopHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__referenceLoopHandling)) = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0001CFA0 File Offset: 0x0001B1A0
		// (set) Token: 0x06000283 RID: 643 RVA: 0x00002E14 File Offset: 0x00001014
		public unsafe MissingMemberHandling _missingMemberHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__missingMemberHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__missingMemberHandling)) = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0001CFC8 File Offset: 0x0001B1C8
		// (set) Token: 0x06000285 RID: 645 RVA: 0x00002E2F File Offset: 0x0000102F
		public unsafe ObjectCreationHandling _objectCreationHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__objectCreationHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__objectCreationHandling)) = value;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0001CFF0 File Offset: 0x0001B1F0
		// (set) Token: 0x06000287 RID: 647 RVA: 0x00002E4A File Offset: 0x0000104A
		public unsafe NullValueHandling _nullValueHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__nullValueHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__nullValueHandling)) = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0001D018 File Offset: 0x0001B218
		// (set) Token: 0x06000289 RID: 649 RVA: 0x00002E65 File Offset: 0x00001065
		public unsafe DefaultValueHandling _defaultValueHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__defaultValueHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__defaultValueHandling)) = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0001D040 File Offset: 0x0001B240
		// (set) Token: 0x0600028B RID: 651 RVA: 0x00002E80 File Offset: 0x00001080
		public unsafe ConstructorHandling _constructorHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__constructorHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__constructorHandling)) = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0001D068 File Offset: 0x0001B268
		// (set) Token: 0x0600028D RID: 653 RVA: 0x00002E9B File Offset: 0x0000109B
		public unsafe MetadataPropertyHandling _metadataPropertyHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__metadataPropertyHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__metadataPropertyHandling)) = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0001D090 File Offset: 0x0001B290
		// (set) Token: 0x0600028F RID: 655 RVA: 0x00002EB6 File Offset: 0x000010B6
		public unsafe JsonConverterCollection _converters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__converters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonConverterCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__converters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0001D0C0 File Offset: 0x0001B2C0
		// (set) Token: 0x06000291 RID: 657 RVA: 0x00002ED5 File Offset: 0x000010D5
		public unsafe IContractResolver _contractResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__contractResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IContractResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__contractResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0001D0F0 File Offset: 0x0001B2F0
		// (set) Token: 0x06000293 RID: 659 RVA: 0x00002EF4 File Offset: 0x000010F4
		public unsafe ITraceWriter _traceWriter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__traceWriter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITraceWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__traceWriter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0001D120 File Offset: 0x0001B320
		// (set) Token: 0x06000295 RID: 661 RVA: 0x00002F13 File Offset: 0x00001113
		public unsafe IEqualityComparer _equalityComparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__equalityComparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__equalityComparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0001D150 File Offset: 0x0001B350
		// (set) Token: 0x06000297 RID: 663 RVA: 0x00002F32 File Offset: 0x00001132
		public unsafe ISerializationBinder _serializationBinder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__serializationBinder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISerializationBinder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__serializationBinder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0001D180 File Offset: 0x0001B380
		// (set) Token: 0x06000299 RID: 665 RVA: 0x00002F51 File Offset: 0x00001151
		public StreamingContext _context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__context);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__context), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0001D1B0 File Offset: 0x0001B3B0
		// (set) Token: 0x0600029B RID: 667 RVA: 0x00002F7F File Offset: 0x0000117F
		public unsafe IReferenceResolver _referenceResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__referenceResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReferenceResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__referenceResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0001D1E0 File Offset: 0x0001B3E0
		// (set) Token: 0x0600029D RID: 669 RVA: 0x00002F9E File Offset: 0x0000119E
		public Nullable<Formatting> _formatting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__formatting);
				return new Nullable<Formatting>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Formatting>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__formatting), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Formatting>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0001D210 File Offset: 0x0001B410
		// (set) Token: 0x0600029F RID: 671 RVA: 0x00002FCC File Offset: 0x000011CC
		public Nullable<DateFormatHandling> _dateFormatHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__dateFormatHandling);
				return new Nullable<DateFormatHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<DateFormatHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__dateFormatHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<DateFormatHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x0001D240 File Offset: 0x0001B440
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x00002FFA File Offset: 0x000011FA
		public Nullable<DateTimeZoneHandling> _dateTimeZoneHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__dateTimeZoneHandling);
				return new Nullable<DateTimeZoneHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<DateTimeZoneHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__dateTimeZoneHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<DateTimeZoneHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0001D270 File Offset: 0x0001B470
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x00003028 File Offset: 0x00001228
		public Nullable<DateParseHandling> _dateParseHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__dateParseHandling);
				return new Nullable<DateParseHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<DateParseHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__dateParseHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<DateParseHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x0001D2A0 File Offset: 0x0001B4A0
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x00003056 File Offset: 0x00001256
		public Nullable<FloatFormatHandling> _floatFormatHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__floatFormatHandling);
				return new Nullable<FloatFormatHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<FloatFormatHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__floatFormatHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<FloatFormatHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0001D2D0 File Offset: 0x0001B4D0
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x00003084 File Offset: 0x00001284
		public Nullable<FloatParseHandling> _floatParseHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__floatParseHandling);
				return new Nullable<FloatParseHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<FloatParseHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__floatParseHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<FloatParseHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0001D300 File Offset: 0x0001B500
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x000030B2 File Offset: 0x000012B2
		public Nullable<StringEscapeHandling> _stringEscapeHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__stringEscapeHandling);
				return new Nullable<StringEscapeHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<StringEscapeHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__stringEscapeHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<StringEscapeHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0001D330 File Offset: 0x0001B530
		// (set) Token: 0x060002AB RID: 683 RVA: 0x000030E0 File Offset: 0x000012E0
		public unsafe CultureInfo _culture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__culture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__culture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0001D360 File Offset: 0x0001B560
		// (set) Token: 0x060002AD RID: 685 RVA: 0x000030FF File Offset: 0x000012FF
		public Nullable<int> _maxDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__maxDepth);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__maxDepth), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0001D390 File Offset: 0x0001B590
		// (set) Token: 0x060002AF RID: 687 RVA: 0x0000312D File Offset: 0x0000132D
		public unsafe bool _maxDepthSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__maxDepthSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__maxDepthSet)) = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x0001D3B8 File Offset: 0x0001B5B8
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x00003148 File Offset: 0x00001348
		public Nullable<bool> _checkAdditionalContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__checkAdditionalContent);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__checkAdditionalContent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0001D3E8 File Offset: 0x0001B5E8
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x00003176 File Offset: 0x00001376
		public unsafe string _dateFormatString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__dateFormatString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__dateFormatString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0001D410 File Offset: 0x0001B610
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x00003195 File Offset: 0x00001395
		public unsafe bool _dateFormatStringSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__dateFormatStringSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr__dateFormatStringSet)) = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x0001D438 File Offset: 0x0001B638
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x000031B0 File Offset: 0x000013B0
		public unsafe EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> Error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr_Error);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializer.NativeFieldInfoPtr_Error), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeFieldInfoPtr__typeNameHandling;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeFieldInfoPtr__typeNameAssemblyFormatHandling;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeFieldInfoPtr__preserveReferencesHandling;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeFieldInfoPtr__referenceLoopHandling;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeFieldInfoPtr__missingMemberHandling;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeFieldInfoPtr__objectCreationHandling;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeFieldInfoPtr__nullValueHandling;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeFieldInfoPtr__defaultValueHandling;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeFieldInfoPtr__constructorHandling;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeFieldInfoPtr__metadataPropertyHandling;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeFieldInfoPtr__converters;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeFieldInfoPtr__contractResolver;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeFieldInfoPtr__traceWriter;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeFieldInfoPtr__equalityComparer;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeFieldInfoPtr__serializationBinder;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeFieldInfoPtr__context;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeFieldInfoPtr__referenceResolver;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeFieldInfoPtr__formatting;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeFieldInfoPtr__dateFormatHandling;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeFieldInfoPtr__dateTimeZoneHandling;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeFieldInfoPtr__dateParseHandling;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeFieldInfoPtr__floatFormatHandling;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeFieldInfoPtr__floatParseHandling;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeFieldInfoPtr__stringEscapeHandling;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeFieldInfoPtr__culture;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeFieldInfoPtr__maxDepth;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeFieldInfoPtr__maxDepthSet;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeFieldInfoPtr__checkAdditionalContent;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeFieldInfoPtr__dateFormatString;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeFieldInfoPtr__dateFormatStringSet;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeFieldInfoPtr_Error;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_add_Error_Public_Virtual_New_add_Void_EventHandler_1_ErrorEventArgs_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_remove_Error_Public_Virtual_New_rem_Void_EventHandler_1_ErrorEventArgs_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_get_ReferenceResolver_Public_Virtual_New_get_IReferenceResolver_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_set_ReferenceResolver_Public_Virtual_New_set_Void_IReferenceResolver_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr_get_Binder_Public_Virtual_New_get_SerializationBinder_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_set_Binder_Public_Virtual_New_set_Void_SerializationBinder_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_get_SerializationBinder_Public_Virtual_New_get_ISerializationBinder_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_set_SerializationBinder_Public_Virtual_New_set_Void_ISerializationBinder_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_get_TraceWriter_Public_Virtual_New_get_ITraceWriter_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_set_TraceWriter_Public_Virtual_New_set_Void_ITraceWriter_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_get_EqualityComparer_Public_Virtual_New_get_IEqualityComparer_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_set_EqualityComparer_Public_Virtual_New_set_Void_IEqualityComparer_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeNameHandling_Public_Virtual_New_get_TypeNameHandling_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_set_TypeNameHandling_Public_Virtual_New_set_Void_TypeNameHandling_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeNameAssemblyFormat_Public_Virtual_New_get_FormatterAssemblyStyle_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_set_TypeNameAssemblyFormat_Public_Virtual_New_set_Void_FormatterAssemblyStyle_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeNameAssemblyFormatHandling_Public_Virtual_New_get_TypeNameAssemblyFormatHandling_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_set_TypeNameAssemblyFormatHandling_Public_Virtual_New_set_Void_TypeNameAssemblyFormatHandling_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_get_PreserveReferencesHandling_Public_Virtual_New_get_PreserveReferencesHandling_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_set_PreserveReferencesHandling_Public_Virtual_New_set_Void_PreserveReferencesHandling_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_get_ReferenceLoopHandling_Public_Virtual_New_get_ReferenceLoopHandling_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_set_ReferenceLoopHandling_Public_Virtual_New_set_Void_ReferenceLoopHandling_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_get_MissingMemberHandling_Public_Virtual_New_get_MissingMemberHandling_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr_set_MissingMemberHandling_Public_Virtual_New_set_Void_MissingMemberHandling_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_get_NullValueHandling_Public_Virtual_New_get_NullValueHandling_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_set_NullValueHandling_Public_Virtual_New_set_Void_NullValueHandling_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValueHandling_Public_Virtual_New_get_DefaultValueHandling_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultValueHandling_Public_Virtual_New_set_Void_DefaultValueHandling_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectCreationHandling_Public_Virtual_New_get_ObjectCreationHandling_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_set_ObjectCreationHandling_Public_Virtual_New_set_Void_ObjectCreationHandling_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_get_ConstructorHandling_Public_Virtual_New_get_ConstructorHandling_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_set_ConstructorHandling_Public_Virtual_New_set_Void_ConstructorHandling_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_get_MetadataPropertyHandling_Public_Virtual_New_get_MetadataPropertyHandling_0;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_set_MetadataPropertyHandling_Public_Virtual_New_set_Void_MetadataPropertyHandling_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_get_Converters_Public_Virtual_New_get_JsonConverterCollection_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr_get_ContractResolver_Public_Virtual_New_get_IContractResolver_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr_set_ContractResolver_Public_Virtual_New_set_Void_IContractResolver_0;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr_get_Context_Public_Virtual_New_get_StreamingContext_0;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_set_Context_Public_Virtual_New_set_Void_StreamingContext_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr_get_Formatting_Public_Virtual_New_get_Formatting_0;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeMethodInfoPtr_set_Formatting_Public_Virtual_New_set_Void_Formatting_0;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeMethodInfoPtr_get_DateFormatHandling_Public_Virtual_New_get_DateFormatHandling_0;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr_set_DateFormatHandling_Public_Virtual_New_set_Void_DateFormatHandling_0;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr_get_DateTimeZoneHandling_Public_Virtual_New_get_DateTimeZoneHandling_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_set_DateTimeZoneHandling_Public_Virtual_New_set_Void_DateTimeZoneHandling_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr_get_DateParseHandling_Public_Virtual_New_get_DateParseHandling_0;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr_set_DateParseHandling_Public_Virtual_New_set_Void_DateParseHandling_0;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr_get_FloatParseHandling_Public_Virtual_New_get_FloatParseHandling_0;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_set_FloatParseHandling_Public_Virtual_New_set_Void_FloatParseHandling_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr_get_FloatFormatHandling_Public_Virtual_New_get_FloatFormatHandling_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_set_FloatFormatHandling_Public_Virtual_New_set_Void_FloatFormatHandling_0;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr_get_StringEscapeHandling_Public_Virtual_New_get_StringEscapeHandling_0;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr_set_StringEscapeHandling_Public_Virtual_New_set_Void_StringEscapeHandling_0;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeMethodInfoPtr_get_DateFormatString_Public_Virtual_New_get_String_0;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr_set_DateFormatString_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr_get_Culture_Public_Virtual_New_get_CultureInfo_0;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr_set_Culture_Public_Virtual_New_set_Void_CultureInfo_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxDepth_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxDepth_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeMethodInfoPtr_get_CheckAdditionalContent_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr_set_CheckAdditionalContent_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr_IsCheckAdditionalContentSet_Internal_Boolean_0;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_JsonSerializer_0;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_JsonSerializer_JsonSerializerSettings_0;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefault_Public_Static_JsonSerializer_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefault_Public_Static_JsonSerializer_JsonSerializerSettings_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr_ApplySerializerSettings_Private_Static_Void_JsonSerializer_JsonSerializerSettings_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr_Populate_Public_Void_TextReader_Object_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr_Populate_Public_Void_JsonReader_Object_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_PopulateInternal_Internal_Virtual_New_Void_JsonReader_Object_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Object_JsonReader_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Object_TextReader_Type_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_T_JsonReader_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Object_JsonReader_Type_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeInternal_Internal_Virtual_New_Object_JsonReader_Type_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_SetupReader_Internal_Void_JsonReader_byref_CultureInfo_byref_Nullable_1_DateTimeZoneHandling_byref_Nullable_1_DateParseHandling_byref_Nullable_1_FloatParseHandling_byref_Nullable_1_Int32_byref_String_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_ResetReader_Private_Void_JsonReader_CultureInfo_Nullable_1_DateTimeZoneHandling_Nullable_1_DateParseHandling_Nullable_1_FloatParseHandling_Nullable_1_Int32_String_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Void_TextWriter_Object_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Void_JsonWriter_Object_Type_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Void_TextWriter_Object_Type_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Void_JsonWriter_Object_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_CreateTraceJsonReader_Private_TraceJsonReader_JsonReader_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_SerializeInternal_Internal_Virtual_New_Void_JsonWriter_Object_Type_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_GetReferenceResolver_Internal_IReferenceResolver_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_GetMatchingConverter_Internal_JsonConverter_Type_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_GetMatchingConverter_Internal_Static_JsonConverter_IList_1_JsonConverter_Type_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_OnError_Internal_Void_ErrorEventArgs_0;

		// Token: 0x0200011E RID: 286
		private sealed class MethodInfoStoreGeneric_Deserialize_Public_T_JsonReader_0<T>
		{
			// Token: 0x04001257 RID: 4695
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonSerializer.NativeMethodInfoPtr_Deserialize_Public_T_JsonReader_0, Il2CppClassPointerStore<JsonSerializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

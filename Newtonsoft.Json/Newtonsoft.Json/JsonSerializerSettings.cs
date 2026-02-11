using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Runtime.Serialization.Formatters;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x0200002C RID: 44
	public class JsonSerializerSettings : Object
	{
		// Token: 0x060002B8 RID: 696 RVA: 0x0001D468 File Offset: 0x0001B668
		// Note: this type is marked as 'beforefieldinit'.
		static JsonSerializerSettings()
		{
			Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json", "JsonSerializerSettings");
			JsonSerializerSettings.NativeFieldInfoPtr_DefaultReferenceLoopHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "DefaultReferenceLoopHandling");
			JsonSerializerSettings.NativeFieldInfoPtr_DefaultMissingMemberHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "DefaultMissingMemberHandling");
			JsonSerializerSettings.NativeFieldInfoPtr_DefaultNullValueHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "DefaultNullValueHandling");
			JsonSerializerSettings.NativeFieldInfoPtr_DefaultDefaultValueHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "DefaultDefaultValueHandling");
			JsonSerializerSettings.NativeFieldInfoPtr_DefaultObjectCreationHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "DefaultObjectCreationHandling");
			JsonSerializerSettings.NativeFieldInfoPtr_DefaultPreserveReferencesHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "DefaultPreserveReferencesHandling");
			JsonSerializerSettings.NativeFieldInfoPtr_DefaultConstructorHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "DefaultConstructorHandling");
			JsonSerializerSettings.NativeFieldInfoPtr_DefaultTypeNameHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "DefaultTypeNameHandling");
			JsonSerializerSettings.NativeFieldInfoPtr_DefaultMetadataPropertyHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "DefaultMetadataPropertyHandling");
			JsonSerializerSettings.NativeFieldInfoPtr_DefaultContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "DefaultContext");
			JsonSerializerSettings.NativeFieldInfoPtr_DefaultFormatting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "DefaultFormatting");
			JsonSerializerSettings.NativeFieldInfoPtr_DefaultDateFormatHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "DefaultDateFormatHandling");
			JsonSerializerSettings.NativeFieldInfoPtr_DefaultDateTimeZoneHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "DefaultDateTimeZoneHandling");
			JsonSerializerSettings.NativeFieldInfoPtr_DefaultDateParseHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "DefaultDateParseHandling");
			JsonSerializerSettings.NativeFieldInfoPtr_DefaultFloatParseHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "DefaultFloatParseHandling");
			JsonSerializerSettings.NativeFieldInfoPtr_DefaultFloatFormatHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "DefaultFloatFormatHandling");
			JsonSerializerSettings.NativeFieldInfoPtr_DefaultStringEscapeHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "DefaultStringEscapeHandling");
			JsonSerializerSettings.NativeFieldInfoPtr_DefaultTypeNameAssemblyFormatHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "DefaultTypeNameAssemblyFormatHandling");
			JsonSerializerSettings.NativeFieldInfoPtr_DefaultCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "DefaultCulture");
			JsonSerializerSettings.NativeFieldInfoPtr_DefaultCheckAdditionalContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "DefaultCheckAdditionalContent");
			JsonSerializerSettings.NativeFieldInfoPtr_DefaultDateFormatString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "DefaultDateFormatString");
			JsonSerializerSettings.NativeFieldInfoPtr_DefaultMaxDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "DefaultMaxDepth");
			JsonSerializerSettings.NativeFieldInfoPtr__formatting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "_formatting");
			JsonSerializerSettings.NativeFieldInfoPtr__dateFormatHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "_dateFormatHandling");
			JsonSerializerSettings.NativeFieldInfoPtr__dateTimeZoneHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "_dateTimeZoneHandling");
			JsonSerializerSettings.NativeFieldInfoPtr__dateParseHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "_dateParseHandling");
			JsonSerializerSettings.NativeFieldInfoPtr__floatFormatHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "_floatFormatHandling");
			JsonSerializerSettings.NativeFieldInfoPtr__floatParseHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "_floatParseHandling");
			JsonSerializerSettings.NativeFieldInfoPtr__stringEscapeHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "_stringEscapeHandling");
			JsonSerializerSettings.NativeFieldInfoPtr__culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "_culture");
			JsonSerializerSettings.NativeFieldInfoPtr__checkAdditionalContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "_checkAdditionalContent");
			JsonSerializerSettings.NativeFieldInfoPtr__maxDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "_maxDepth");
			JsonSerializerSettings.NativeFieldInfoPtr__maxDepthSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "_maxDepthSet");
			JsonSerializerSettings.NativeFieldInfoPtr__dateFormatString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "_dateFormatString");
			JsonSerializerSettings.NativeFieldInfoPtr__dateFormatStringSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "_dateFormatStringSet");
			JsonSerializerSettings.NativeFieldInfoPtr__typeNameAssemblyFormatHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "_typeNameAssemblyFormatHandling");
			JsonSerializerSettings.NativeFieldInfoPtr__defaultValueHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "_defaultValueHandling");
			JsonSerializerSettings.NativeFieldInfoPtr__preserveReferencesHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "_preserveReferencesHandling");
			JsonSerializerSettings.NativeFieldInfoPtr__nullValueHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "_nullValueHandling");
			JsonSerializerSettings.NativeFieldInfoPtr__objectCreationHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "_objectCreationHandling");
			JsonSerializerSettings.NativeFieldInfoPtr__missingMemberHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "_missingMemberHandling");
			JsonSerializerSettings.NativeFieldInfoPtr__referenceLoopHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "_referenceLoopHandling");
			JsonSerializerSettings.NativeFieldInfoPtr__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "_context");
			JsonSerializerSettings.NativeFieldInfoPtr__constructorHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "_constructorHandling");
			JsonSerializerSettings.NativeFieldInfoPtr__typeNameHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "_typeNameHandling");
			JsonSerializerSettings.NativeFieldInfoPtr__metadataPropertyHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "_metadataPropertyHandling");
			JsonSerializerSettings.NativeFieldInfoPtr__Converters_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "<Converters>k__BackingField");
			JsonSerializerSettings.NativeFieldInfoPtr__ContractResolver_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "<ContractResolver>k__BackingField");
			JsonSerializerSettings.NativeFieldInfoPtr__EqualityComparer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "<EqualityComparer>k__BackingField");
			JsonSerializerSettings.NativeFieldInfoPtr__ReferenceResolverProvider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "<ReferenceResolverProvider>k__BackingField");
			JsonSerializerSettings.NativeFieldInfoPtr__TraceWriter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "<TraceWriter>k__BackingField");
			JsonSerializerSettings.NativeFieldInfoPtr__SerializationBinder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "<SerializationBinder>k__BackingField");
			JsonSerializerSettings.NativeFieldInfoPtr__Error_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "<Error>k__BackingField");
			JsonSerializerSettings.NativeMethodInfoPtr_get_ReferenceLoopHandling_Public_get_ReferenceLoopHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663714);
			JsonSerializerSettings.NativeMethodInfoPtr_set_ReferenceLoopHandling_Public_set_Void_ReferenceLoopHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663715);
			JsonSerializerSettings.NativeMethodInfoPtr_get_MissingMemberHandling_Public_get_MissingMemberHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663716);
			JsonSerializerSettings.NativeMethodInfoPtr_set_MissingMemberHandling_Public_set_Void_MissingMemberHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663717);
			JsonSerializerSettings.NativeMethodInfoPtr_get_ObjectCreationHandling_Public_get_ObjectCreationHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663718);
			JsonSerializerSettings.NativeMethodInfoPtr_set_ObjectCreationHandling_Public_set_Void_ObjectCreationHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663719);
			JsonSerializerSettings.NativeMethodInfoPtr_get_NullValueHandling_Public_get_NullValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663720);
			JsonSerializerSettings.NativeMethodInfoPtr_set_NullValueHandling_Public_set_Void_NullValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663721);
			JsonSerializerSettings.NativeMethodInfoPtr_get_DefaultValueHandling_Public_get_DefaultValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663722);
			JsonSerializerSettings.NativeMethodInfoPtr_set_DefaultValueHandling_Public_set_Void_DefaultValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663723);
			JsonSerializerSettings.NativeMethodInfoPtr_get_Converters_Public_get_IList_1_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663724);
			JsonSerializerSettings.NativeMethodInfoPtr_set_Converters_Public_set_Void_IList_1_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663725);
			JsonSerializerSettings.NativeMethodInfoPtr_get_PreserveReferencesHandling_Public_get_PreserveReferencesHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663726);
			JsonSerializerSettings.NativeMethodInfoPtr_set_PreserveReferencesHandling_Public_set_Void_PreserveReferencesHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663727);
			JsonSerializerSettings.NativeMethodInfoPtr_get_TypeNameHandling_Public_get_TypeNameHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663728);
			JsonSerializerSettings.NativeMethodInfoPtr_set_TypeNameHandling_Public_set_Void_TypeNameHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663729);
			JsonSerializerSettings.NativeMethodInfoPtr_get_MetadataPropertyHandling_Public_get_MetadataPropertyHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663730);
			JsonSerializerSettings.NativeMethodInfoPtr_set_MetadataPropertyHandling_Public_set_Void_MetadataPropertyHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663731);
			JsonSerializerSettings.NativeMethodInfoPtr_get_TypeNameAssemblyFormat_Public_get_FormatterAssemblyStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663732);
			JsonSerializerSettings.NativeMethodInfoPtr_set_TypeNameAssemblyFormat_Public_set_Void_FormatterAssemblyStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663733);
			JsonSerializerSettings.NativeMethodInfoPtr_get_TypeNameAssemblyFormatHandling_Public_get_TypeNameAssemblyFormatHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663734);
			JsonSerializerSettings.NativeMethodInfoPtr_set_TypeNameAssemblyFormatHandling_Public_set_Void_TypeNameAssemblyFormatHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663735);
			JsonSerializerSettings.NativeMethodInfoPtr_get_ConstructorHandling_Public_get_ConstructorHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663736);
			JsonSerializerSettings.NativeMethodInfoPtr_set_ConstructorHandling_Public_set_Void_ConstructorHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663737);
			JsonSerializerSettings.NativeMethodInfoPtr_get_ContractResolver_Public_get_IContractResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663738);
			JsonSerializerSettings.NativeMethodInfoPtr_set_ContractResolver_Public_set_Void_IContractResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663739);
			JsonSerializerSettings.NativeMethodInfoPtr_get_EqualityComparer_Public_get_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663740);
			JsonSerializerSettings.NativeMethodInfoPtr_set_EqualityComparer_Public_set_Void_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663741);
			JsonSerializerSettings.NativeMethodInfoPtr_get_ReferenceResolver_Public_get_IReferenceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663742);
			JsonSerializerSettings.NativeMethodInfoPtr_set_ReferenceResolver_Public_set_Void_IReferenceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663743);
			JsonSerializerSettings.NativeMethodInfoPtr_get_ReferenceResolverProvider_Public_get_Func_1_IReferenceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663744);
			JsonSerializerSettings.NativeMethodInfoPtr_set_ReferenceResolverProvider_Public_set_Void_Func_1_IReferenceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663745);
			JsonSerializerSettings.NativeMethodInfoPtr_get_TraceWriter_Public_get_ITraceWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663746);
			JsonSerializerSettings.NativeMethodInfoPtr_set_TraceWriter_Public_set_Void_ITraceWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663747);
			JsonSerializerSettings.NativeMethodInfoPtr_get_Binder_Public_get_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663748);
			JsonSerializerSettings.NativeMethodInfoPtr_set_Binder_Public_set_Void_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663749);
			JsonSerializerSettings.NativeMethodInfoPtr_get_SerializationBinder_Public_get_ISerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663750);
			JsonSerializerSettings.NativeMethodInfoPtr_set_SerializationBinder_Public_set_Void_ISerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663751);
			JsonSerializerSettings.NativeMethodInfoPtr_get_Error_Public_get_EventHandler_1_ErrorEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663752);
			JsonSerializerSettings.NativeMethodInfoPtr_set_Error_Public_set_Void_EventHandler_1_ErrorEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663753);
			JsonSerializerSettings.NativeMethodInfoPtr_get_Context_Public_get_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663754);
			JsonSerializerSettings.NativeMethodInfoPtr_set_Context_Public_set_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663755);
			JsonSerializerSettings.NativeMethodInfoPtr_get_DateFormatString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663756);
			JsonSerializerSettings.NativeMethodInfoPtr_set_DateFormatString_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663757);
			JsonSerializerSettings.NativeMethodInfoPtr_get_MaxDepth_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663758);
			JsonSerializerSettings.NativeMethodInfoPtr_set_MaxDepth_Public_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663759);
			JsonSerializerSettings.NativeMethodInfoPtr_get_Formatting_Public_get_Formatting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663760);
			JsonSerializerSettings.NativeMethodInfoPtr_set_Formatting_Public_set_Void_Formatting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663761);
			JsonSerializerSettings.NativeMethodInfoPtr_get_DateFormatHandling_Public_get_DateFormatHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663762);
			JsonSerializerSettings.NativeMethodInfoPtr_set_DateFormatHandling_Public_set_Void_DateFormatHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663763);
			JsonSerializerSettings.NativeMethodInfoPtr_get_DateTimeZoneHandling_Public_get_DateTimeZoneHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663764);
			JsonSerializerSettings.NativeMethodInfoPtr_set_DateTimeZoneHandling_Public_set_Void_DateTimeZoneHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663765);
			JsonSerializerSettings.NativeMethodInfoPtr_get_DateParseHandling_Public_get_DateParseHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663766);
			JsonSerializerSettings.NativeMethodInfoPtr_set_DateParseHandling_Public_set_Void_DateParseHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663767);
			JsonSerializerSettings.NativeMethodInfoPtr_get_FloatFormatHandling_Public_get_FloatFormatHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663768);
			JsonSerializerSettings.NativeMethodInfoPtr_set_FloatFormatHandling_Public_set_Void_FloatFormatHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663769);
			JsonSerializerSettings.NativeMethodInfoPtr_get_FloatParseHandling_Public_get_FloatParseHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663770);
			JsonSerializerSettings.NativeMethodInfoPtr_set_FloatParseHandling_Public_set_Void_FloatParseHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663771);
			JsonSerializerSettings.NativeMethodInfoPtr_get_StringEscapeHandling_Public_get_StringEscapeHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663772);
			JsonSerializerSettings.NativeMethodInfoPtr_set_StringEscapeHandling_Public_set_Void_StringEscapeHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663773);
			JsonSerializerSettings.NativeMethodInfoPtr_get_Culture_Public_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663774);
			JsonSerializerSettings.NativeMethodInfoPtr_set_Culture_Public_set_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663775);
			JsonSerializerSettings.NativeMethodInfoPtr_get_CheckAdditionalContent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663776);
			JsonSerializerSettings.NativeMethodInfoPtr_set_CheckAdditionalContent_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663777);
			JsonSerializerSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663779);
			JsonSerializerSettings.NativeMethodInfoPtr__ctor_Public_Void_JsonSerializerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, 100663780);
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x0001DDDC File Offset: 0x0001BFDC
		// (set) Token: 0x060002BA RID: 698 RVA: 0x0001DE18 File Offset: 0x0001C018
		public unsafe ReferenceLoopHandling ReferenceLoopHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729904, XrefRangeEnd = 729905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_ReferenceLoopHandling_Public_get_ReferenceLoopHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729905, XrefRangeEnd = 729908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_ReferenceLoopHandling_Public_set_Void_ReferenceLoopHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060002BB RID: 699 RVA: 0x0001DE58 File Offset: 0x0001C058
		// (set) Token: 0x060002BC RID: 700 RVA: 0x0001DE94 File Offset: 0x0001C094
		public unsafe MissingMemberHandling MissingMemberHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729908, XrefRangeEnd = 729909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_MissingMemberHandling_Public_get_MissingMemberHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729909, XrefRangeEnd = 729912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_MissingMemberHandling_Public_set_Void_MissingMemberHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060002BD RID: 701 RVA: 0x0001DED4 File Offset: 0x0001C0D4
		// (set) Token: 0x060002BE RID: 702 RVA: 0x0001DF10 File Offset: 0x0001C110
		public unsafe ObjectCreationHandling ObjectCreationHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729912, XrefRangeEnd = 729913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_ObjectCreationHandling_Public_get_ObjectCreationHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729913, XrefRangeEnd = 729916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_ObjectCreationHandling_Public_set_Void_ObjectCreationHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060002BF RID: 703 RVA: 0x0001DF50 File Offset: 0x0001C150
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x0001DF8C File Offset: 0x0001C18C
		public unsafe NullValueHandling NullValueHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729916, XrefRangeEnd = 729917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_NullValueHandling_Public_get_NullValueHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 729920, RefRangeEnd = 729922, XrefRangeStart = 729917, XrefRangeEnd = 729920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_NullValueHandling_Public_set_Void_NullValueHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x0001DFCC File Offset: 0x0001C1CC
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x0001E008 File Offset: 0x0001C208
		public unsafe DefaultValueHandling DefaultValueHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729922, XrefRangeEnd = 729923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_DefaultValueHandling_Public_get_DefaultValueHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729923, XrefRangeEnd = 729926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_DefaultValueHandling_Public_set_Void_DefaultValueHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x0001E048 File Offset: 0x0001C248
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x0001E088 File Offset: 0x0001C288
		public unsafe IList<JsonConverter> Converters
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 39587, RefRangeEnd = 39588, XrefRangeStart = 39587, XrefRangeEnd = 39588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_Converters_Public_get_IList_1_JsonConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<JsonConverter>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_Converters_Public_set_Void_IList_1_JsonConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x0001E0CC File Offset: 0x0001C2CC
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x0001E108 File Offset: 0x0001C308
		public unsafe PreserveReferencesHandling PreserveReferencesHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729926, XrefRangeEnd = 729927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_PreserveReferencesHandling_Public_get_PreserveReferencesHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729927, XrefRangeEnd = 729930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_PreserveReferencesHandling_Public_set_Void_PreserveReferencesHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x0001E148 File Offset: 0x0001C348
		// (set) Token: 0x060002C8 RID: 712 RVA: 0x0001E184 File Offset: 0x0001C384
		public unsafe TypeNameHandling TypeNameHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729930, XrefRangeEnd = 729931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_TypeNameHandling_Public_get_TypeNameHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729931, XrefRangeEnd = 729934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_TypeNameHandling_Public_set_Void_TypeNameHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x0001E1C4 File Offset: 0x0001C3C4
		// (set) Token: 0x060002CA RID: 714 RVA: 0x0001E200 File Offset: 0x0001C400
		public unsafe MetadataPropertyHandling MetadataPropertyHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729934, XrefRangeEnd = 729935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_MetadataPropertyHandling_Public_get_MetadataPropertyHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 729938, RefRangeEnd = 729940, XrefRangeStart = 729935, XrefRangeEnd = 729938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_MetadataPropertyHandling_Public_set_Void_MetadataPropertyHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060002CB RID: 715 RVA: 0x0001E240 File Offset: 0x0001C440
		// (set) Token: 0x060002CC RID: 716 RVA: 0x0001E27C File Offset: 0x0001C47C
		public unsafe FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729940, XrefRangeEnd = 729941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_TypeNameAssemblyFormat_Public_get_FormatterAssemblyStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729941, XrefRangeEnd = 729944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_TypeNameAssemblyFormat_Public_set_Void_FormatterAssemblyStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060002CD RID: 717 RVA: 0x0001E2BC File Offset: 0x0001C4BC
		// (set) Token: 0x060002CE RID: 718 RVA: 0x0001E2F8 File Offset: 0x0001C4F8
		public unsafe TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_TypeNameAssemblyFormatHandling_Public_get_TypeNameAssemblyFormatHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_TypeNameAssemblyFormatHandling_Public_set_Void_TypeNameAssemblyFormatHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060002CF RID: 719 RVA: 0x0001E338 File Offset: 0x0001C538
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x0001E374 File Offset: 0x0001C574
		public unsafe ConstructorHandling ConstructorHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729944, XrefRangeEnd = 729945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_ConstructorHandling_Public_get_ConstructorHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729945, XrefRangeEnd = 729948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_ConstructorHandling_Public_set_Void_ConstructorHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x0001E3B4 File Offset: 0x0001C5B4
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x0001E3F4 File Offset: 0x0001C5F4
		public unsafe IContractResolver ContractResolver
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_ContractResolver_Public_get_IContractResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IContractResolver>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_ContractResolver_Public_set_Void_IContractResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x0001E438 File Offset: 0x0001C638
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x0001E478 File Offset: 0x0001C678
		public unsafe IEqualityComparer EqualityComparer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_EqualityComparer_Public_get_IEqualityComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_EqualityComparer_Public_set_Void_IEqualityComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x0001E4BC File Offset: 0x0001C6BC
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x0001E4FC File Offset: 0x0001C6FC
		public unsafe IReferenceResolver ReferenceResolver
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_ReferenceResolver_Public_get_IReferenceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReferenceResolver>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729948, XrefRangeEnd = 729962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_ReferenceResolver_Public_set_Void_IReferenceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x0001E540 File Offset: 0x0001C740
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x0001E580 File Offset: 0x0001C780
		public unsafe Func<IReferenceResolver> ReferenceResolverProvider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_ReferenceResolverProvider_Public_get_Func_1_IReferenceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<IReferenceResolver>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_ReferenceResolverProvider_Public_set_Void_Func_1_IReferenceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x0001E5C4 File Offset: 0x0001C7C4
		// (set) Token: 0x060002DA RID: 730 RVA: 0x0001E604 File Offset: 0x0001C804
		public unsafe ITraceWriter TraceWriter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_TraceWriter_Public_get_ITraceWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_TraceWriter_Public_set_Void_ITraceWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060002DB RID: 731 RVA: 0x0001E648 File Offset: 0x0001C848
		// (set) Token: 0x060002DC RID: 732 RVA: 0x0001E688 File Offset: 0x0001C888
		public unsafe SerializationBinder Binder
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729962, XrefRangeEnd = 729965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_Binder_Public_get_SerializationBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationBinder>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729965, XrefRangeEnd = 729972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_Binder_Public_set_Void_SerializationBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060002DD RID: 733 RVA: 0x0001E6CC File Offset: 0x0001C8CC
		// (set) Token: 0x060002DE RID: 734 RVA: 0x0001E70C File Offset: 0x0001C90C
		public unsafe ISerializationBinder SerializationBinder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_SerializationBinder_Public_get_ISerializationBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISerializationBinder>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_SerializationBinder_Public_set_Void_ISerializationBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060002DF RID: 735 RVA: 0x0001E750 File Offset: 0x0001C950
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x0001E790 File Offset: 0x0001C990
		public unsafe EventHandler<ErrorEventArgs> Error
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_Error_Public_get_EventHandler_1_ErrorEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventHandler<ErrorEventArgs>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_Error_Public_set_Void_EventHandler_1_ErrorEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x0001E7D4 File Offset: 0x0001C9D4
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x0001E80C File Offset: 0x0001CA0C
		public unsafe StreamingContext Context
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729972, XrefRangeEnd = 729975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_Context_Public_get_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new StreamingContext(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729975, XrefRangeEnd = 729979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_Context_Public_set_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x0001E854 File Offset: 0x0001CA54
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x0001E88C File Offset: 0x0001CA8C
		public unsafe string DateFormatString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729979, XrefRangeEnd = 729981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_DateFormatString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729981, XrefRangeEnd = 729982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_DateFormatString_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x0001E8D0 File Offset: 0x0001CAD0
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x0001E908 File Offset: 0x0001CB08
		public unsafe Nullable<int> MaxDepth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729982, XrefRangeEnd = 729983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_MaxDepth_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729983, XrefRangeEnd = 729985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_MaxDepth_Public_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x0001E950 File Offset: 0x0001CB50
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x0001E98C File Offset: 0x0001CB8C
		public unsafe Formatting Formatting
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729985, XrefRangeEnd = 729986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_Formatting_Public_get_Formatting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729986, XrefRangeEnd = 729989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_Formatting_Public_set_Void_Formatting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x0001E9CC File Offset: 0x0001CBCC
		// (set) Token: 0x060002EA RID: 746 RVA: 0x0001EA08 File Offset: 0x0001CC08
		public unsafe DateFormatHandling DateFormatHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729989, XrefRangeEnd = 729990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_DateFormatHandling_Public_get_DateFormatHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729990, XrefRangeEnd = 729993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_DateFormatHandling_Public_set_Void_DateFormatHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060002EB RID: 747 RVA: 0x0001EA48 File Offset: 0x0001CC48
		// (set) Token: 0x060002EC RID: 748 RVA: 0x0001EA84 File Offset: 0x0001CC84
		public unsafe DateTimeZoneHandling DateTimeZoneHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729993, XrefRangeEnd = 729995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_DateTimeZoneHandling_Public_get_DateTimeZoneHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729995, XrefRangeEnd = 729998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_DateTimeZoneHandling_Public_set_Void_DateTimeZoneHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060002ED RID: 749 RVA: 0x0001EAC4 File Offset: 0x0001CCC4
		// (set) Token: 0x060002EE RID: 750 RVA: 0x0001EB00 File Offset: 0x0001CD00
		public unsafe DateParseHandling DateParseHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 729998, XrefRangeEnd = 730000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_DateParseHandling_Public_get_DateParseHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730000, XrefRangeEnd = 730003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_DateParseHandling_Public_set_Void_DateParseHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060002EF RID: 751 RVA: 0x0001EB40 File Offset: 0x0001CD40
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x0001EB7C File Offset: 0x0001CD7C
		public unsafe FloatFormatHandling FloatFormatHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730003, XrefRangeEnd = 730004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_FloatFormatHandling_Public_get_FloatFormatHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730004, XrefRangeEnd = 730007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_FloatFormatHandling_Public_set_Void_FloatFormatHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x0001EBBC File Offset: 0x0001CDBC
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x0001EBF8 File Offset: 0x0001CDF8
		public unsafe FloatParseHandling FloatParseHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730007, XrefRangeEnd = 730008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_FloatParseHandling_Public_get_FloatParseHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730008, XrefRangeEnd = 730011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_FloatParseHandling_Public_set_Void_FloatParseHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x0001EC38 File Offset: 0x0001CE38
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x0001EC74 File Offset: 0x0001CE74
		public unsafe StringEscapeHandling StringEscapeHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730011, XrefRangeEnd = 730012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_StringEscapeHandling_Public_get_StringEscapeHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730012, XrefRangeEnd = 730015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_StringEscapeHandling_Public_set_Void_StringEscapeHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x0001ECB4 File Offset: 0x0001CEB4
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x0001ECF4 File Offset: 0x0001CEF4
		public unsafe CultureInfo Culture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730015, XrefRangeEnd = 730019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_Culture_Public_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_Culture_Public_set_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x0001ED38 File Offset: 0x0001CF38
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x0001ED74 File Offset: 0x0001CF74
		public unsafe bool CheckAdditionalContent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730019, XrefRangeEnd = 730020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_get_CheckAdditionalContent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730020, XrefRangeEnd = 730023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr_set_CheckAdditionalContent_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0001EDB4 File Offset: 0x0001CFB4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 730031, RefRangeEnd = 730036, XrefRangeStart = 730023, XrefRangeEnd = 730031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSerializerSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0001EDF0 File Offset: 0x0001CFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 730036, XrefRangeEnd = 730050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSerializerSettings(JsonSerializerSettings original)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.NativeMethodInfoPtr__ctor_Public_Void_JsonSerializerSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x000031CF File Offset: 0x000013CF
		public JsonSerializerSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002FC RID: 764 RVA: 0x0001EE3C File Offset: 0x0001D03C
		// (set) Token: 0x060002FD RID: 765 RVA: 0x000031D8 File Offset: 0x000013D8
		public unsafe static ReferenceLoopHandling DefaultReferenceLoopHandling
		{
			get
			{
				ReferenceLoopHandling referenceLoopHandling;
				IL2CPP.il2cpp_field_static_get_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultReferenceLoopHandling, (void*)(&referenceLoopHandling));
				return referenceLoopHandling;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultReferenceLoopHandling, (void*)(&value));
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002FE RID: 766 RVA: 0x0001EE58 File Offset: 0x0001D058
		// (set) Token: 0x060002FF RID: 767 RVA: 0x000031E6 File Offset: 0x000013E6
		public unsafe static MissingMemberHandling DefaultMissingMemberHandling
		{
			get
			{
				MissingMemberHandling missingMemberHandling;
				IL2CPP.il2cpp_field_static_get_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultMissingMemberHandling, (void*)(&missingMemberHandling));
				return missingMemberHandling;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultMissingMemberHandling, (void*)(&value));
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0001EE74 File Offset: 0x0001D074
		// (set) Token: 0x06000301 RID: 769 RVA: 0x000031F4 File Offset: 0x000013F4
		public unsafe static NullValueHandling DefaultNullValueHandling
		{
			get
			{
				NullValueHandling nullValueHandling;
				IL2CPP.il2cpp_field_static_get_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultNullValueHandling, (void*)(&nullValueHandling));
				return nullValueHandling;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultNullValueHandling, (void*)(&value));
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0001EE90 File Offset: 0x0001D090
		// (set) Token: 0x06000303 RID: 771 RVA: 0x00003202 File Offset: 0x00001402
		public unsafe static DefaultValueHandling DefaultDefaultValueHandling
		{
			get
			{
				DefaultValueHandling defaultValueHandling;
				IL2CPP.il2cpp_field_static_get_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultDefaultValueHandling, (void*)(&defaultValueHandling));
				return defaultValueHandling;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultDefaultValueHandling, (void*)(&value));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000304 RID: 772 RVA: 0x0001EEAC File Offset: 0x0001D0AC
		// (set) Token: 0x06000305 RID: 773 RVA: 0x00003210 File Offset: 0x00001410
		public unsafe static ObjectCreationHandling DefaultObjectCreationHandling
		{
			get
			{
				ObjectCreationHandling objectCreationHandling;
				IL2CPP.il2cpp_field_static_get_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultObjectCreationHandling, (void*)(&objectCreationHandling));
				return objectCreationHandling;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultObjectCreationHandling, (void*)(&value));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000306 RID: 774 RVA: 0x0001EEC8 File Offset: 0x0001D0C8
		// (set) Token: 0x06000307 RID: 775 RVA: 0x0000321E File Offset: 0x0000141E
		public unsafe static PreserveReferencesHandling DefaultPreserveReferencesHandling
		{
			get
			{
				PreserveReferencesHandling preserveReferencesHandling;
				IL2CPP.il2cpp_field_static_get_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultPreserveReferencesHandling, (void*)(&preserveReferencesHandling));
				return preserveReferencesHandling;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultPreserveReferencesHandling, (void*)(&value));
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000308 RID: 776 RVA: 0x0001EEE4 File Offset: 0x0001D0E4
		// (set) Token: 0x06000309 RID: 777 RVA: 0x0000322C File Offset: 0x0000142C
		public unsafe static ConstructorHandling DefaultConstructorHandling
		{
			get
			{
				ConstructorHandling constructorHandling;
				IL2CPP.il2cpp_field_static_get_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultConstructorHandling, (void*)(&constructorHandling));
				return constructorHandling;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultConstructorHandling, (void*)(&value));
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600030A RID: 778 RVA: 0x0001EF00 File Offset: 0x0001D100
		// (set) Token: 0x0600030B RID: 779 RVA: 0x0000323A File Offset: 0x0000143A
		public unsafe static TypeNameHandling DefaultTypeNameHandling
		{
			get
			{
				TypeNameHandling typeNameHandling;
				IL2CPP.il2cpp_field_static_get_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultTypeNameHandling, (void*)(&typeNameHandling));
				return typeNameHandling;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultTypeNameHandling, (void*)(&value));
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600030C RID: 780 RVA: 0x0001EF1C File Offset: 0x0001D11C
		// (set) Token: 0x0600030D RID: 781 RVA: 0x00003248 File Offset: 0x00001448
		public unsafe static MetadataPropertyHandling DefaultMetadataPropertyHandling
		{
			get
			{
				MetadataPropertyHandling metadataPropertyHandling;
				IL2CPP.il2cpp_field_static_get_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultMetadataPropertyHandling, (void*)(&metadataPropertyHandling));
				return metadataPropertyHandling;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultMetadataPropertyHandling, (void*)(&value));
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600030E RID: 782 RVA: 0x0001EF38 File Offset: 0x0001D138
		// (set) Token: 0x0600030F RID: 783 RVA: 0x00003256 File Offset: 0x00001456
		public unsafe static StreamingContext DefaultContext
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultContext, intPtr);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultContext, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000310 RID: 784 RVA: 0x0001EF74 File Offset: 0x0001D174
		// (set) Token: 0x06000311 RID: 785 RVA: 0x0000326D File Offset: 0x0000146D
		public unsafe static Formatting DefaultFormatting
		{
			get
			{
				Formatting formatting;
				IL2CPP.il2cpp_field_static_get_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultFormatting, (void*)(&formatting));
				return formatting;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultFormatting, (void*)(&value));
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000312 RID: 786 RVA: 0x0001EF90 File Offset: 0x0001D190
		// (set) Token: 0x06000313 RID: 787 RVA: 0x0000327B File Offset: 0x0000147B
		public unsafe static DateFormatHandling DefaultDateFormatHandling
		{
			get
			{
				DateFormatHandling dateFormatHandling;
				IL2CPP.il2cpp_field_static_get_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultDateFormatHandling, (void*)(&dateFormatHandling));
				return dateFormatHandling;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultDateFormatHandling, (void*)(&value));
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000314 RID: 788 RVA: 0x0001EFAC File Offset: 0x0001D1AC
		// (set) Token: 0x06000315 RID: 789 RVA: 0x00003289 File Offset: 0x00001489
		public unsafe static DateTimeZoneHandling DefaultDateTimeZoneHandling
		{
			get
			{
				DateTimeZoneHandling dateTimeZoneHandling;
				IL2CPP.il2cpp_field_static_get_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultDateTimeZoneHandling, (void*)(&dateTimeZoneHandling));
				return dateTimeZoneHandling;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultDateTimeZoneHandling, (void*)(&value));
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000316 RID: 790 RVA: 0x0001EFC8 File Offset: 0x0001D1C8
		// (set) Token: 0x06000317 RID: 791 RVA: 0x00003297 File Offset: 0x00001497
		public unsafe static DateParseHandling DefaultDateParseHandling
		{
			get
			{
				DateParseHandling dateParseHandling;
				IL2CPP.il2cpp_field_static_get_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultDateParseHandling, (void*)(&dateParseHandling));
				return dateParseHandling;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultDateParseHandling, (void*)(&value));
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000318 RID: 792 RVA: 0x0001EFE4 File Offset: 0x0001D1E4
		// (set) Token: 0x06000319 RID: 793 RVA: 0x000032A5 File Offset: 0x000014A5
		public unsafe static FloatParseHandling DefaultFloatParseHandling
		{
			get
			{
				FloatParseHandling floatParseHandling;
				IL2CPP.il2cpp_field_static_get_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultFloatParseHandling, (void*)(&floatParseHandling));
				return floatParseHandling;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultFloatParseHandling, (void*)(&value));
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0001F000 File Offset: 0x0001D200
		// (set) Token: 0x0600031B RID: 795 RVA: 0x000032B3 File Offset: 0x000014B3
		public unsafe static FloatFormatHandling DefaultFloatFormatHandling
		{
			get
			{
				FloatFormatHandling floatFormatHandling;
				IL2CPP.il2cpp_field_static_get_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultFloatFormatHandling, (void*)(&floatFormatHandling));
				return floatFormatHandling;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultFloatFormatHandling, (void*)(&value));
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600031C RID: 796 RVA: 0x0001F01C File Offset: 0x0001D21C
		// (set) Token: 0x0600031D RID: 797 RVA: 0x000032C1 File Offset: 0x000014C1
		public unsafe static StringEscapeHandling DefaultStringEscapeHandling
		{
			get
			{
				StringEscapeHandling stringEscapeHandling;
				IL2CPP.il2cpp_field_static_get_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultStringEscapeHandling, (void*)(&stringEscapeHandling));
				return stringEscapeHandling;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultStringEscapeHandling, (void*)(&value));
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0001F038 File Offset: 0x0001D238
		// (set) Token: 0x0600031F RID: 799 RVA: 0x000032CF File Offset: 0x000014CF
		public unsafe static TypeNameAssemblyFormatHandling DefaultTypeNameAssemblyFormatHandling
		{
			get
			{
				TypeNameAssemblyFormatHandling typeNameAssemblyFormatHandling;
				IL2CPP.il2cpp_field_static_get_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultTypeNameAssemblyFormatHandling, (void*)(&typeNameAssemblyFormatHandling));
				return typeNameAssemblyFormatHandling;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultTypeNameAssemblyFormatHandling, (void*)(&value));
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0001F054 File Offset: 0x0001D254
		// (set) Token: 0x06000321 RID: 801 RVA: 0x000032DD File Offset: 0x000014DD
		public unsafe static CultureInfo DefaultCulture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultCulture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultCulture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0001F07C File Offset: 0x0001D27C
		// (set) Token: 0x06000323 RID: 803 RVA: 0x000032EF File Offset: 0x000014EF
		public unsafe static bool DefaultCheckAdditionalContent
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultCheckAdditionalContent, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultCheckAdditionalContent, (void*)(&value));
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000324 RID: 804 RVA: 0x0001F098 File Offset: 0x0001D298
		// (set) Token: 0x06000325 RID: 805 RVA: 0x000032FD File Offset: 0x000014FD
		public unsafe static string DefaultDateFormatString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultDateFormatString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultDateFormatString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0001F0B8 File Offset: 0x0001D2B8
		// (set) Token: 0x06000327 RID: 807 RVA: 0x0000330F File Offset: 0x0000150F
		public unsafe static int DefaultMaxDepth
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultMaxDepth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSerializerSettings.NativeFieldInfoPtr_DefaultMaxDepth, (void*)(&value));
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000328 RID: 808 RVA: 0x0001F0D4 File Offset: 0x0001D2D4
		// (set) Token: 0x06000329 RID: 809 RVA: 0x0000331D File Offset: 0x0000151D
		public Nullable<Formatting> _formatting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__formatting);
				return new Nullable<Formatting>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Formatting>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__formatting), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Formatting>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0001F104 File Offset: 0x0001D304
		// (set) Token: 0x0600032B RID: 811 RVA: 0x0000334B File Offset: 0x0000154B
		public Nullable<DateFormatHandling> _dateFormatHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__dateFormatHandling);
				return new Nullable<DateFormatHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<DateFormatHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__dateFormatHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<DateFormatHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0001F134 File Offset: 0x0001D334
		// (set) Token: 0x0600032D RID: 813 RVA: 0x00003379 File Offset: 0x00001579
		public Nullable<DateTimeZoneHandling> _dateTimeZoneHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__dateTimeZoneHandling);
				return new Nullable<DateTimeZoneHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<DateTimeZoneHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__dateTimeZoneHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<DateTimeZoneHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0001F164 File Offset: 0x0001D364
		// (set) Token: 0x0600032F RID: 815 RVA: 0x000033A7 File Offset: 0x000015A7
		public Nullable<DateParseHandling> _dateParseHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__dateParseHandling);
				return new Nullable<DateParseHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<DateParseHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__dateParseHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<DateParseHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0001F194 File Offset: 0x0001D394
		// (set) Token: 0x06000331 RID: 817 RVA: 0x000033D5 File Offset: 0x000015D5
		public Nullable<FloatFormatHandling> _floatFormatHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__floatFormatHandling);
				return new Nullable<FloatFormatHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<FloatFormatHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__floatFormatHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<FloatFormatHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0001F1C4 File Offset: 0x0001D3C4
		// (set) Token: 0x06000333 RID: 819 RVA: 0x00003403 File Offset: 0x00001603
		public Nullable<FloatParseHandling> _floatParseHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__floatParseHandling);
				return new Nullable<FloatParseHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<FloatParseHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__floatParseHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<FloatParseHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000334 RID: 820 RVA: 0x0001F1F4 File Offset: 0x0001D3F4
		// (set) Token: 0x06000335 RID: 821 RVA: 0x00003431 File Offset: 0x00001631
		public Nullable<StringEscapeHandling> _stringEscapeHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__stringEscapeHandling);
				return new Nullable<StringEscapeHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<StringEscapeHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__stringEscapeHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<StringEscapeHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0001F224 File Offset: 0x0001D424
		// (set) Token: 0x06000337 RID: 823 RVA: 0x0000345F File Offset: 0x0000165F
		public unsafe CultureInfo _culture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__culture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__culture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0001F254 File Offset: 0x0001D454
		// (set) Token: 0x06000339 RID: 825 RVA: 0x0000347E File Offset: 0x0000167E
		public Nullable<bool> _checkAdditionalContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__checkAdditionalContent);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__checkAdditionalContent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0001F284 File Offset: 0x0001D484
		// (set) Token: 0x0600033B RID: 827 RVA: 0x000034AC File Offset: 0x000016AC
		public Nullable<int> _maxDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__maxDepth);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__maxDepth), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600033C RID: 828 RVA: 0x0001F2B4 File Offset: 0x0001D4B4
		// (set) Token: 0x0600033D RID: 829 RVA: 0x000034DA File Offset: 0x000016DA
		public unsafe bool _maxDepthSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__maxDepthSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__maxDepthSet)) = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0001F2DC File Offset: 0x0001D4DC
		// (set) Token: 0x0600033F RID: 831 RVA: 0x000034F5 File Offset: 0x000016F5
		public unsafe string _dateFormatString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__dateFormatString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__dateFormatString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0001F304 File Offset: 0x0001D504
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00003514 File Offset: 0x00001714
		public unsafe bool _dateFormatStringSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__dateFormatStringSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__dateFormatStringSet)) = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000342 RID: 834 RVA: 0x0001F32C File Offset: 0x0001D52C
		// (set) Token: 0x06000343 RID: 835 RVA: 0x0000352F File Offset: 0x0000172F
		public Nullable<TypeNameAssemblyFormatHandling> _typeNameAssemblyFormatHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__typeNameAssemblyFormatHandling);
				return new Nullable<TypeNameAssemblyFormatHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<TypeNameAssemblyFormatHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__typeNameAssemblyFormatHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<TypeNameAssemblyFormatHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000344 RID: 836 RVA: 0x0001F35C File Offset: 0x0001D55C
		// (set) Token: 0x06000345 RID: 837 RVA: 0x0000355D File Offset: 0x0000175D
		public Nullable<DefaultValueHandling> _defaultValueHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__defaultValueHandling);
				return new Nullable<DefaultValueHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<DefaultValueHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__defaultValueHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<DefaultValueHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000346 RID: 838 RVA: 0x0001F38C File Offset: 0x0001D58C
		// (set) Token: 0x06000347 RID: 839 RVA: 0x0000358B File Offset: 0x0000178B
		public Nullable<PreserveReferencesHandling> _preserveReferencesHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__preserveReferencesHandling);
				return new Nullable<PreserveReferencesHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<PreserveReferencesHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__preserveReferencesHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<PreserveReferencesHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000348 RID: 840 RVA: 0x0001F3BC File Offset: 0x0001D5BC
		// (set) Token: 0x06000349 RID: 841 RVA: 0x000035B9 File Offset: 0x000017B9
		public Nullable<NullValueHandling> _nullValueHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__nullValueHandling);
				return new Nullable<NullValueHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<NullValueHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__nullValueHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<NullValueHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0001F3EC File Offset: 0x0001D5EC
		// (set) Token: 0x0600034B RID: 843 RVA: 0x000035E7 File Offset: 0x000017E7
		public Nullable<ObjectCreationHandling> _objectCreationHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__objectCreationHandling);
				return new Nullable<ObjectCreationHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<ObjectCreationHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__objectCreationHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<ObjectCreationHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600034C RID: 844 RVA: 0x0001F41C File Offset: 0x0001D61C
		// (set) Token: 0x0600034D RID: 845 RVA: 0x00003615 File Offset: 0x00001815
		public Nullable<MissingMemberHandling> _missingMemberHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__missingMemberHandling);
				return new Nullable<MissingMemberHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<MissingMemberHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__missingMemberHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<MissingMemberHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0001F44C File Offset: 0x0001D64C
		// (set) Token: 0x0600034F RID: 847 RVA: 0x00003643 File Offset: 0x00001843
		public Nullable<ReferenceLoopHandling> _referenceLoopHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__referenceLoopHandling);
				return new Nullable<ReferenceLoopHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<ReferenceLoopHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__referenceLoopHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<ReferenceLoopHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000350 RID: 848 RVA: 0x0001F47C File Offset: 0x0001D67C
		// (set) Token: 0x06000351 RID: 849 RVA: 0x00003671 File Offset: 0x00001871
		public Nullable<StreamingContext> _context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__context);
				return new Nullable<StreamingContext>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<StreamingContext>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__context), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<StreamingContext>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000352 RID: 850 RVA: 0x0001F4AC File Offset: 0x0001D6AC
		// (set) Token: 0x06000353 RID: 851 RVA: 0x0000369F File Offset: 0x0000189F
		public Nullable<ConstructorHandling> _constructorHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__constructorHandling);
				return new Nullable<ConstructorHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<ConstructorHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__constructorHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<ConstructorHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000354 RID: 852 RVA: 0x0001F4DC File Offset: 0x0001D6DC
		// (set) Token: 0x06000355 RID: 853 RVA: 0x000036CD File Offset: 0x000018CD
		public Nullable<TypeNameHandling> _typeNameHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__typeNameHandling);
				return new Nullable<TypeNameHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<TypeNameHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__typeNameHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<TypeNameHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000356 RID: 854 RVA: 0x0001F50C File Offset: 0x0001D70C
		// (set) Token: 0x06000357 RID: 855 RVA: 0x000036FB File Offset: 0x000018FB
		public Nullable<MetadataPropertyHandling> _metadataPropertyHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__metadataPropertyHandling);
				return new Nullable<MetadataPropertyHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<MetadataPropertyHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__metadataPropertyHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<MetadataPropertyHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000358 RID: 856 RVA: 0x0001F53C File Offset: 0x0001D73C
		// (set) Token: 0x06000359 RID: 857 RVA: 0x00003729 File Offset: 0x00001929
		public unsafe IList<JsonConverter> _Converters_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__Converters_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<JsonConverter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__Converters_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600035A RID: 858 RVA: 0x0001F56C File Offset: 0x0001D76C
		// (set) Token: 0x0600035B RID: 859 RVA: 0x00003748 File Offset: 0x00001948
		public unsafe IContractResolver _ContractResolver_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__ContractResolver_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IContractResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__ContractResolver_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600035C RID: 860 RVA: 0x0001F59C File Offset: 0x0001D79C
		// (set) Token: 0x0600035D RID: 861 RVA: 0x00003767 File Offset: 0x00001967
		public unsafe IEqualityComparer _EqualityComparer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__EqualityComparer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__EqualityComparer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600035E RID: 862 RVA: 0x0001F5CC File Offset: 0x0001D7CC
		// (set) Token: 0x0600035F RID: 863 RVA: 0x00003786 File Offset: 0x00001986
		public unsafe Func<IReferenceResolver> _ReferenceResolverProvider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__ReferenceResolverProvider_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IReferenceResolver>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__ReferenceResolverProvider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000360 RID: 864 RVA: 0x0001F5FC File Offset: 0x0001D7FC
		// (set) Token: 0x06000361 RID: 865 RVA: 0x000037A5 File Offset: 0x000019A5
		public unsafe ITraceWriter _TraceWriter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__TraceWriter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITraceWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__TraceWriter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000362 RID: 866 RVA: 0x0001F62C File Offset: 0x0001D82C
		// (set) Token: 0x06000363 RID: 867 RVA: 0x000037C4 File Offset: 0x000019C4
		public unsafe ISerializationBinder _SerializationBinder_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__SerializationBinder_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISerializationBinder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__SerializationBinder_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000364 RID: 868 RVA: 0x0001F65C File Offset: 0x0001D85C
		// (set) Token: 0x06000365 RID: 869 RVA: 0x000037E3 File Offset: 0x000019E3
		public unsafe EventHandler<ErrorEventArgs> _Error_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__Error_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<ErrorEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.NativeFieldInfoPtr__Error_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeFieldInfoPtr_DefaultReferenceLoopHandling;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeFieldInfoPtr_DefaultMissingMemberHandling;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeFieldInfoPtr_DefaultNullValueHandling;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeFieldInfoPtr_DefaultDefaultValueHandling;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeFieldInfoPtr_DefaultObjectCreationHandling;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeFieldInfoPtr_DefaultPreserveReferencesHandling;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeFieldInfoPtr_DefaultConstructorHandling;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeFieldInfoPtr_DefaultTypeNameHandling;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeFieldInfoPtr_DefaultMetadataPropertyHandling;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeFieldInfoPtr_DefaultContext;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeFieldInfoPtr_DefaultFormatting;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeFieldInfoPtr_DefaultDateFormatHandling;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeFieldInfoPtr_DefaultDateTimeZoneHandling;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeFieldInfoPtr_DefaultDateParseHandling;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeFieldInfoPtr_DefaultFloatParseHandling;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeFieldInfoPtr_DefaultFloatFormatHandling;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeFieldInfoPtr_DefaultStringEscapeHandling;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeFieldInfoPtr_DefaultTypeNameAssemblyFormatHandling;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeFieldInfoPtr_DefaultCulture;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeFieldInfoPtr_DefaultCheckAdditionalContent;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeFieldInfoPtr_DefaultDateFormatString;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeFieldInfoPtr_DefaultMaxDepth;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeFieldInfoPtr__formatting;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeFieldInfoPtr__dateFormatHandling;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeFieldInfoPtr__dateTimeZoneHandling;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeFieldInfoPtr__dateParseHandling;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeFieldInfoPtr__floatFormatHandling;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeFieldInfoPtr__floatParseHandling;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeFieldInfoPtr__stringEscapeHandling;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeFieldInfoPtr__culture;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeFieldInfoPtr__checkAdditionalContent;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeFieldInfoPtr__maxDepth;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeFieldInfoPtr__maxDepthSet;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeFieldInfoPtr__dateFormatString;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeFieldInfoPtr__dateFormatStringSet;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeFieldInfoPtr__typeNameAssemblyFormatHandling;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeFieldInfoPtr__defaultValueHandling;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeFieldInfoPtr__preserveReferencesHandling;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeFieldInfoPtr__nullValueHandling;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeFieldInfoPtr__objectCreationHandling;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeFieldInfoPtr__missingMemberHandling;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeFieldInfoPtr__referenceLoopHandling;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeFieldInfoPtr__context;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeFieldInfoPtr__constructorHandling;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeFieldInfoPtr__typeNameHandling;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeFieldInfoPtr__metadataPropertyHandling;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeFieldInfoPtr__Converters_k__BackingField;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeFieldInfoPtr__ContractResolver_k__BackingField;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeFieldInfoPtr__EqualityComparer_k__BackingField;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeFieldInfoPtr__ReferenceResolverProvider_k__BackingField;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeFieldInfoPtr__TraceWriter_k__BackingField;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeFieldInfoPtr__SerializationBinder_k__BackingField;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeFieldInfoPtr__Error_k__BackingField;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_get_ReferenceLoopHandling_Public_get_ReferenceLoopHandling_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_set_ReferenceLoopHandling_Public_set_Void_ReferenceLoopHandling_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_get_MissingMemberHandling_Public_get_MissingMemberHandling_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_set_MissingMemberHandling_Public_set_Void_MissingMemberHandling_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectCreationHandling_Public_get_ObjectCreationHandling_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_set_ObjectCreationHandling_Public_set_Void_ObjectCreationHandling_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_get_NullValueHandling_Public_get_NullValueHandling_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_set_NullValueHandling_Public_set_Void_NullValueHandling_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValueHandling_Public_get_DefaultValueHandling_0;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultValueHandling_Public_set_Void_DefaultValueHandling_0;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_get_Converters_Public_get_IList_1_JsonConverter_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr_set_Converters_Public_set_Void_IList_1_JsonConverter_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr_get_PreserveReferencesHandling_Public_get_PreserveReferencesHandling_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr_set_PreserveReferencesHandling_Public_set_Void_PreserveReferencesHandling_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeNameHandling_Public_get_TypeNameHandling_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr_set_TypeNameHandling_Public_set_Void_TypeNameHandling_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr_get_MetadataPropertyHandling_Public_get_MetadataPropertyHandling_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_set_MetadataPropertyHandling_Public_set_Void_MetadataPropertyHandling_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeNameAssemblyFormat_Public_get_FormatterAssemblyStyle_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr_set_TypeNameAssemblyFormat_Public_set_Void_FormatterAssemblyStyle_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeNameAssemblyFormatHandling_Public_get_TypeNameAssemblyFormatHandling_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr_set_TypeNameAssemblyFormatHandling_Public_set_Void_TypeNameAssemblyFormatHandling_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr_get_ConstructorHandling_Public_get_ConstructorHandling_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_set_ConstructorHandling_Public_set_Void_ConstructorHandling_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_get_ContractResolver_Public_get_IContractResolver_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_set_ContractResolver_Public_set_Void_IContractResolver_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_get_EqualityComparer_Public_get_IEqualityComparer_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_set_EqualityComparer_Public_set_Void_IEqualityComparer_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_get_ReferenceResolver_Public_get_IReferenceResolver_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr_set_ReferenceResolver_Public_set_Void_IReferenceResolver_0;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_get_ReferenceResolverProvider_Public_get_Func_1_IReferenceResolver_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_set_ReferenceResolverProvider_Public_set_Void_Func_1_IReferenceResolver_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr_get_TraceWriter_Public_get_ITraceWriter_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr_set_TraceWriter_Public_set_Void_ITraceWriter_0;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeMethodInfoPtr_get_Binder_Public_get_SerializationBinder_0;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr_set_Binder_Public_set_Void_SerializationBinder_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_get_SerializationBinder_Public_get_ISerializationBinder_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_set_SerializationBinder_Public_set_Void_ISerializationBinder_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_get_EventHandler_1_ErrorEventArgs_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr_set_Error_Public_set_Void_EventHandler_1_ErrorEventArgs_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr_get_Context_Public_get_StreamingContext_0;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr_set_Context_Public_set_Void_StreamingContext_0;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeMethodInfoPtr_get_DateFormatString_Public_get_String_0;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeMethodInfoPtr_set_DateFormatString_Public_set_Void_String_0;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxDepth_Public_get_Nullable_1_Int32_0;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxDepth_Public_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeMethodInfoPtr_get_Formatting_Public_get_Formatting_0;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeMethodInfoPtr_set_Formatting_Public_set_Void_Formatting_0;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeMethodInfoPtr_get_DateFormatHandling_Public_get_DateFormatHandling_0;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr_set_DateFormatHandling_Public_set_Void_DateFormatHandling_0;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeMethodInfoPtr_get_DateTimeZoneHandling_Public_get_DateTimeZoneHandling_0;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeMethodInfoPtr_set_DateTimeZoneHandling_Public_set_Void_DateTimeZoneHandling_0;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr_get_DateParseHandling_Public_get_DateParseHandling_0;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeMethodInfoPtr_set_DateParseHandling_Public_set_Void_DateParseHandling_0;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr_get_FloatFormatHandling_Public_get_FloatFormatHandling_0;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr_set_FloatFormatHandling_Public_set_Void_FloatFormatHandling_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr_get_FloatParseHandling_Public_get_FloatParseHandling_0;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr_set_FloatParseHandling_Public_set_Void_FloatParseHandling_0;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeMethodInfoPtr_get_StringEscapeHandling_Public_get_StringEscapeHandling_0;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeMethodInfoPtr_set_StringEscapeHandling_Public_set_Void_StringEscapeHandling_0;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeMethodInfoPtr_get_Culture_Public_get_CultureInfo_0;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeMethodInfoPtr_set_Culture_Public_set_Void_CultureInfo_0;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeMethodInfoPtr_get_CheckAdditionalContent_Public_get_Boolean_0;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeMethodInfoPtr_set_CheckAdditionalContent_Public_set_Void_Boolean_0;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_JsonSerializerSettings_0;

		// Token: 0x0200011F RID: 287
		[ObfuscatedName("Newtonsoft.Json.JsonSerializerSettings+<>c__DisplayClass93_0")]
		public sealed class __c__DisplayClass93_0 : Object
		{
			// Token: 0x060016D4 RID: 5844 RVA: 0x00079224 File Offset: 0x00077424
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass93_0()
			{
				Il2CppClassPointerStore<JsonSerializerSettings.__c__DisplayClass93_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonSerializerSettings>.NativeClassPtr, "<>c__DisplayClass93_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSerializerSettings.__c__DisplayClass93_0>.NativeClassPtr);
				JsonSerializerSettings.__c__DisplayClass93_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerSettings.__c__DisplayClass93_0>.NativeClassPtr, "value");
				JsonSerializerSettings.__c__DisplayClass93_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings.__c__DisplayClass93_0>.NativeClassPtr, 100663781);
				JsonSerializerSettings.__c__DisplayClass93_0.NativeMethodInfoPtr__set_ReferenceResolver_b__0_Internal_IReferenceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerSettings.__c__DisplayClass93_0>.NativeClassPtr, 100663782);
			}

			// Token: 0x060016D5 RID: 5845 RVA: 0x0007928C File Offset: 0x0007748C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass93_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSerializerSettings.__c__DisplayClass93_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.__c__DisplayClass93_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016D6 RID: 5846 RVA: 0x000792C8 File Offset: 0x000774C8
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IReferenceResolver _set_ReferenceResolver_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerSettings.__c__DisplayClass93_0.NativeMethodInfoPtr__set_ReferenceResolver_b__0_Internal_IReferenceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReferenceResolver>(intPtr3) : null;
			}

			// Token: 0x060016D7 RID: 5847 RVA: 0x00009113 File Offset: 0x00007313
			public __c__DisplayClass93_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000604 RID: 1540
			// (get) Token: 0x060016D8 RID: 5848 RVA: 0x00079308 File Offset: 0x00077508
			// (set) Token: 0x060016D9 RID: 5849 RVA: 0x0000911C File Offset: 0x0000731C
			public unsafe IReferenceResolver value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.__c__DisplayClass93_0.NativeFieldInfoPtr_value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReferenceResolver>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerSettings.__c__DisplayClass93_0.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001258 RID: 4696
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04001259 RID: 4697
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400125A RID: 4698
			private static readonly IntPtr NativeMethodInfoPtr__set_ReferenceResolver_b__0_Internal_IReferenceResolver_0;
		}
	}
}

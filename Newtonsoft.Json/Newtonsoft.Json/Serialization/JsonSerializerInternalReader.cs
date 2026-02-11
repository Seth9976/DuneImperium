using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000092 RID: 146
	public class JsonSerializerInternalReader : JsonSerializerInternalBase
	{
		// Token: 0x06000C57 RID: 3159 RVA: 0x000496FC File Offset: 0x000478FC
		// Note: this type is marked as 'beforefieldinit'.
		static JsonSerializerInternalReader()
		{
			Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "JsonSerializerInternalReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr);
			JsonSerializerInternalReader.NativeMethodInfoPtr__ctor_Public_Void_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665522);
			JsonSerializerInternalReader.NativeMethodInfoPtr_Populate_Public_Void_JsonReader_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665523);
			JsonSerializerInternalReader.NativeMethodInfoPtr_GetContractSafe_Private_JsonContract_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665524);
			JsonSerializerInternalReader.NativeMethodInfoPtr_GetContract_Private_JsonContract_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665525);
			JsonSerializerInternalReader.NativeMethodInfoPtr_Deserialize_Public_Object_JsonReader_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665526);
			JsonSerializerInternalReader.NativeMethodInfoPtr_GetInternalSerializer_Private_JsonSerializerProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665527);
			JsonSerializerInternalReader.NativeMethodInfoPtr_CreateJToken_Private_JToken_JsonReader_JsonContract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665528);
			JsonSerializerInternalReader.NativeMethodInfoPtr_CreateJObject_Private_JToken_JsonReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665529);
			JsonSerializerInternalReader.NativeMethodInfoPtr_CreateValueInternal_Private_Object_JsonReader_Type_JsonContract_JsonProperty_JsonContainerContract_JsonProperty_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665530);
			JsonSerializerInternalReader.NativeMethodInfoPtr_CoerceEmptyStringToNull_Private_Static_Boolean_Type_JsonContract_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665531);
			JsonSerializerInternalReader.NativeMethodInfoPtr_GetExpectedDescription_Internal_String_JsonContract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665532);
			JsonSerializerInternalReader.NativeMethodInfoPtr_GetConverter_Private_JsonConverter_JsonContract_JsonConverter_JsonContainerContract_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665533);
			JsonSerializerInternalReader.NativeMethodInfoPtr_CreateObject_Private_Object_JsonReader_Type_JsonContract_JsonProperty_JsonContainerContract_JsonProperty_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665534);
			JsonSerializerInternalReader.NativeMethodInfoPtr_ReadMetadataPropertiesToken_Private_Boolean_JTokenReader_byref_Type_byref_JsonContract_JsonProperty_JsonContainerContract_JsonProperty_Object_byref_Object_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665535);
			JsonSerializerInternalReader.NativeMethodInfoPtr_ReadMetadataProperties_Private_Boolean_JsonReader_byref_Type_byref_JsonContract_JsonProperty_JsonContainerContract_JsonProperty_Object_byref_Object_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665536);
			JsonSerializerInternalReader.NativeMethodInfoPtr_ResolveTypeName_Private_Void_JsonReader_byref_Type_byref_JsonContract_JsonProperty_JsonContainerContract_JsonProperty_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665537);
			JsonSerializerInternalReader.NativeMethodInfoPtr_EnsureArrayContract_Private_JsonArrayContract_JsonReader_Type_JsonContract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665538);
			JsonSerializerInternalReader.NativeMethodInfoPtr_CreateList_Private_Object_JsonReader_Type_JsonContract_JsonProperty_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665539);
			JsonSerializerInternalReader.NativeMethodInfoPtr_HasNoDefinedType_Private_Boolean_JsonContract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665540);
			JsonSerializerInternalReader.NativeMethodInfoPtr_EnsureType_Private_Object_JsonReader_Object_CultureInfo_JsonContract_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665541);
			JsonSerializerInternalReader.NativeMethodInfoPtr_SetPropertyValue_Private_Boolean_JsonProperty_JsonConverter_JsonContainerContract_JsonProperty_JsonReader_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665542);
			JsonSerializerInternalReader.NativeMethodInfoPtr_CalculatePropertyDetails_Private_Boolean_JsonProperty_byref_JsonConverter_JsonContainerContract_JsonProperty_JsonReader_Object_byref_Boolean_byref_Object_byref_JsonContract_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665543);
			JsonSerializerInternalReader.NativeMethodInfoPtr_AddReference_Private_Void_JsonReader_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665544);
			JsonSerializerInternalReader.NativeMethodInfoPtr_HasFlag_Private_Boolean_DefaultValueHandling_DefaultValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665545);
			JsonSerializerInternalReader.NativeMethodInfoPtr_ShouldSetPropertyValue_Private_Boolean_JsonProperty_JsonObjectContract_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665546);
			JsonSerializerInternalReader.NativeMethodInfoPtr_CreateNewList_Private_IList_JsonReader_JsonArrayContract_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665547);
			JsonSerializerInternalReader.NativeMethodInfoPtr_CreateNewDictionary_Private_IDictionary_JsonReader_JsonDictionaryContract_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665548);
			JsonSerializerInternalReader.NativeMethodInfoPtr_OnDeserializing_Private_Void_JsonReader_JsonContract_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665549);
			JsonSerializerInternalReader.NativeMethodInfoPtr_OnDeserialized_Private_Void_JsonReader_JsonContract_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665550);
			JsonSerializerInternalReader.NativeMethodInfoPtr_PopulateDictionary_Private_Object_IDictionary_JsonReader_JsonDictionaryContract_JsonProperty_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665551);
			JsonSerializerInternalReader.NativeMethodInfoPtr_PopulateMultidimensionalArray_Private_Object_IList_JsonReader_JsonArrayContract_JsonProperty_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665552);
			JsonSerializerInternalReader.NativeMethodInfoPtr_ThrowUnexpectedEndException_Private_Void_JsonReader_JsonContract_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665553);
			JsonSerializerInternalReader.NativeMethodInfoPtr_PopulateList_Private_Object_IList_JsonReader_JsonArrayContract_JsonProperty_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665554);
			JsonSerializerInternalReader.NativeMethodInfoPtr_CreateISerializable_Private_Object_JsonReader_JsonISerializableContract_JsonProperty_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665555);
			JsonSerializerInternalReader.NativeMethodInfoPtr_CreateISerializableItem_Internal_Object_JToken_Type_JsonISerializableContract_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665556);
			JsonSerializerInternalReader.NativeMethodInfoPtr_CreateDynamic_Private_Object_JsonReader_JsonDynamicContract_JsonProperty_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665557);
			JsonSerializerInternalReader.NativeMethodInfoPtr_CreateObjectUsingCreatorWithParameters_Private_Object_JsonReader_JsonObjectContract_JsonProperty_ObjectConstructor_1_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665558);
			JsonSerializerInternalReader.NativeMethodInfoPtr_DeserializeConvertable_Private_Object_JsonConverter_JsonReader_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665559);
			JsonSerializerInternalReader.NativeMethodInfoPtr_ResolvePropertyAndCreatorValues_Private_List_1_CreatorPropertyContext_JsonObjectContract_JsonProperty_JsonReader_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665560);
			JsonSerializerInternalReader.NativeMethodInfoPtr_CreateNewObject_Public_Object_JsonReader_JsonObjectContract_JsonProperty_JsonProperty_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665561);
			JsonSerializerInternalReader.NativeMethodInfoPtr_PopulateObject_Private_Object_Object_JsonReader_JsonObjectContract_JsonProperty_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665562);
			JsonSerializerInternalReader.NativeMethodInfoPtr_ShouldDeserialize_Private_Boolean_JsonReader_JsonProperty_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665563);
			JsonSerializerInternalReader.NativeMethodInfoPtr_CheckPropertyName_Private_Boolean_JsonReader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665564);
			JsonSerializerInternalReader.NativeMethodInfoPtr_SetExtensionData_Private_Void_JsonObjectContract_JsonProperty_JsonReader_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665565);
			JsonSerializerInternalReader.NativeMethodInfoPtr_ReadExtensionDataValue_Private_Object_JsonObjectContract_JsonProperty_JsonReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665566);
			JsonSerializerInternalReader.NativeMethodInfoPtr_EndProcessProperty_Private_Void_Object_JsonReader_JsonObjectContract_Int32_JsonProperty_PropertyPresence_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665567);
			JsonSerializerInternalReader.NativeMethodInfoPtr_SetPropertyPresence_Private_Void_JsonReader_JsonProperty_Dictionary_2_JsonProperty_PropertyPresence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665568);
			JsonSerializerInternalReader.NativeMethodInfoPtr_HandleError_Private_Void_JsonReader_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, 100665569);
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x00049AEC File Offset: 0x00047CEC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 750158, RefRangeEnd = 750163, XrefRangeStart = 750158, XrefRangeEnd = 750163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSerializerInternalReader(JsonSerializer serializer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr__ctor_Public_Void_JsonSerializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x00049B38 File Offset: 0x00047D38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 750313, RefRangeEnd = 750315, XrefRangeStart = 750293, XrefRangeEnd = 750313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_Populate_Public_Void_JsonReader_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x00049B8C File Offset: 0x00047D8C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 750322, RefRangeEnd = 750335, XrefRangeStart = 750315, XrefRangeEnd = 750322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonContract GetContractSafe(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_GetContractSafe_Private_JsonContract_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonContract>(intPtr3) : null;
			}
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x00049BDC File Offset: 0x00047DDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 750339, RefRangeEnd = 750342, XrefRangeStart = 750335, XrefRangeEnd = 750339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonContract GetContract(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_GetContract_Private_JsonContract_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonContract>(intPtr3) : null;
			}
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x00049C2C File Offset: 0x00047E2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 750357, RefRangeEnd = 750359, XrefRangeStart = 750342, XrefRangeEnd = 750357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkAdditionalContent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_Deserialize_Public_Object_JsonReader_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x00049C9C File Offset: 0x00047E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750359, XrefRangeEnd = 750364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSerializerProxy GetInternalSerializer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_GetInternalSerializer_Private_JsonSerializerProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSerializerProxy>(intPtr3) : null;
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00049CDC File Offset: 0x00047EDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 750387, RefRangeEnd = 750388, XrefRangeStart = 750364, XrefRangeEnd = 750387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JToken CreateJToken(JsonReader reader, JsonContract contract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_CreateJToken_Private_JToken_JsonReader_JsonContract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00049D40 File Offset: 0x00047F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750388, XrefRangeEnd = 750406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JToken CreateJObject(JsonReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_CreateJObject_Private_JToken_JsonReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x00049D90 File Offset: 0x00047F90
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 750437, RefRangeEnd = 750445, XrefRangeStart = 750406, XrefRangeEnd = 750437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, Object existingValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerContract);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerMember);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(existingValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_CreateValueInternal_Private_Object_JsonReader_Type_JsonContract_JsonProperty_JsonContainerContract_JsonProperty_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x00049E50 File Offset: 0x00048050
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 750462, RefRangeEnd = 750465, XrefRangeStart = 750445, XrefRangeEnd = 750462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, string s)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_CoerceEmptyStringToNull_Private_Static_Boolean_Type_JsonContract_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x00049EB8 File Offset: 0x000480B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750465, XrefRangeEnd = 750470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetExpectedDescription(JsonContract contract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_GetExpectedDescription_Internal_String_JsonContract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00049F00 File Offset: 0x00048100
		[CallerCount(0)]
		public unsafe JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberConverter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerContract);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerProperty);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_GetConverter_Private_JsonConverter_JsonContract_JsonConverter_JsonContainerContract_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonConverter>(intPtr3) : null;
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x00049F88 File Offset: 0x00048188
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 750486, RefRangeEnd = 750487, XrefRangeStart = 750470, XrefRangeEnd = 750486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, Object existingValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerContract);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerMember);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(existingValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_CreateObject_Private_Object_JsonReader_Type_JsonContract_JsonProperty_JsonContainerContract_JsonProperty_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x0004A048 File Offset: 0x00048248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750487, XrefRangeEnd = 750527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadMetadataPropertiesToken(JTokenReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, Object existingValue, out Object newValue, out string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerContract);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerMember);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(existingValue);
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = 0;
			ptr5 = &intPtr4;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_ReadMetadataPropertiesToken_Private_Boolean_JTokenReader_byref_Type_byref_JsonContract_JsonProperty_JsonContainerContract_JsonProperty_Object_byref_Object_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			IntPtr intPtr7 = intPtr;
			objectType = ((intPtr7 == 0) ? null : new Type(intPtr7));
			IntPtr intPtr8 = intPtr2;
			contract = ((intPtr8 == 0) ? null : new JsonContract(intPtr8));
			IntPtr intPtr9 = intPtr3;
			newValue = ((intPtr9 == 0) ? null : new Object(intPtr9));
			id = IL2CPP.Il2CppStringToManaged(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr5);
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x0004A174 File Offset: 0x00048374
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 750574, RefRangeEnd = 750575, XrefRangeStart = 750527, XrefRangeEnd = 750574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadMetadataProperties(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, Object existingValue, out Object newValue, out string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerContract);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerMember);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(existingValue);
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = 0;
			ptr5 = &intPtr4;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_ReadMetadataProperties_Private_Boolean_JsonReader_byref_Type_byref_JsonContract_JsonProperty_JsonContainerContract_JsonProperty_Object_byref_Object_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			IntPtr intPtr7 = intPtr;
			objectType = ((intPtr7 == 0) ? null : new Type(intPtr7));
			IntPtr intPtr8 = intPtr2;
			contract = ((intPtr8 == 0) ? null : new JsonContract(intPtr8));
			IntPtr intPtr9 = intPtr3;
			newValue = ((intPtr9 == 0) ? null : new Object(intPtr9));
			id = IL2CPP.Il2CppStringToManaged(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr5);
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0004A2A0 File Offset: 0x000484A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 750627, RefRangeEnd = 750628, XrefRangeStart = 750575, XrefRangeEnd = 750627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResolveTypeName(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerContract);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerMember);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(qualifiedTypeName);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_ResolveTypeName_Private_Void_JsonReader_byref_Type_byref_JsonContract_JsonProperty_JsonContainerContract_JsonProperty_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			objectType = ((intPtr5 == 0) ? null : new Type(intPtr5));
			IntPtr intPtr6 = intPtr2;
			contract = ((intPtr6 == 0) ? null : new JsonContract(intPtr6));
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x0004A380 File Offset: 0x00048580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750628, XrefRangeEnd = 750630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_EnsureArrayContract_Private_JsonArrayContract_JsonReader_Type_JsonContract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonArrayContract>(intPtr3) : null;
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x0004A3F4 File Offset: 0x000485F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 750659, RefRangeEnd = 750660, XrefRangeStart = 750630, XrefRangeEnd = 750659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, Object existingValue, string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(existingValue);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_CreateList_Private_Object_JsonReader_Type_JsonContract_JsonProperty_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x0004A4A4 File Offset: 0x000486A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 750673, RefRangeEnd = 750674, XrefRangeStart = 750660, XrefRangeEnd = 750673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasNoDefinedType(JsonContract contract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_HasNoDefinedType_Private_Boolean_JsonContract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0004A4F4 File Offset: 0x000486F4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 750743, RefRangeEnd = 750748, XrefRangeStart = 750674, XrefRangeEnd = 750743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object EnsureType(JsonReader reader, Object value, CultureInfo culture, JsonContract contract, Type targetType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_EnsureType_Private_Object_JsonReader_Object_CultureInfo_JsonContract_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0004A590 File Offset: 0x00048790
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 750767, RefRangeEnd = 750769, XrefRangeStart = 750748, XrefRangeEnd = 750767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, Object target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(propertyConverter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerContract);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerProperty);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_SetPropertyValue_Private_Boolean_JsonProperty_JsonConverter_JsonContainerContract_JsonProperty_JsonReader_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x0004A63C File Offset: 0x0004883C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 750822, RefRangeEnd = 750823, XrefRangeStart = 750769, XrefRangeEnd = 750822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CalculatePropertyDetails(JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, Object target, out bool useExistingValue, out Object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue, out bool ignoredValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(propertyConverter);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerContract);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerProperty);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &useExistingValue;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &gottenCurrentValue;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ignoredValue;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_CalculatePropertyDetails_Private_Boolean_JsonProperty_byref_JsonConverter_JsonContainerContract_JsonProperty_JsonReader_Object_byref_Boolean_byref_Object_byref_JsonContract_byref_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			propertyConverter = ((intPtr6 == 0) ? null : new JsonConverter(intPtr6));
			IntPtr intPtr7 = intPtr2;
			currentValue = ((intPtr7 == 0) ? null : new Object(intPtr7));
			IntPtr intPtr8 = intPtr3;
			propertyContract = ((intPtr8 == 0) ? null : new JsonContract(intPtr8));
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x0004A778 File Offset: 0x00048978
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 750849, RefRangeEnd = 750856, XrefRangeStart = 750823, XrefRangeEnd = 750849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddReference(JsonReader reader, string id, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_AddReference_Private_Void_JsonReader_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x0004A7E0 File Offset: 0x000489E0
		[CallerCount(0)]
		public unsafe bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_HasFlag_Private_Boolean_DefaultValueHandling_DefaultValueHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x0004A838 File Offset: 0x00048A38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 750868, RefRangeEnd = 750870, XrefRangeStart = 750856, XrefRangeEnd = 750868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldSetPropertyValue(JsonProperty property, JsonObjectContract contract, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_ShouldSetPropertyValue_Private_Boolean_JsonProperty_JsonObjectContract_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x0004A8AC File Offset: 0x00048AAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 750874, RefRangeEnd = 750875, XrefRangeStart = 750870, XrefRangeEnd = 750874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &createdFromNonDefaultCreator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_CreateNewList_Private_IList_JsonReader_JsonArrayContract_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x0004A91C File Offset: 0x00048B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750875, XrefRangeEnd = 750879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &createdFromNonDefaultCreator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_CreateNewDictionary_Private_IDictionary_JsonReader_JsonDictionaryContract_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x0004A98C File Offset: 0x00048B8C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 750899, RefRangeEnd = 750906, XrefRangeStart = 750879, XrefRangeEnd = 750899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserializing(JsonReader reader, JsonContract contract, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_OnDeserializing_Private_Void_JsonReader_JsonContract_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x0004A9F4 File Offset: 0x00048BF4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 750926, RefRangeEnd = 750933, XrefRangeStart = 750906, XrefRangeEnd = 750926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized(JsonReader reader, JsonContract contract, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_OnDeserialized_Private_Void_JsonReader_JsonContract_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x0004AA5C File Offset: 0x00048C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750933, XrefRangeEnd = 751015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerProperty);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_PopulateDictionary_Private_Object_IDictionary_JsonReader_JsonDictionaryContract_JsonProperty_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x0004AAF8 File Offset: 0x00048CF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 751059, RefRangeEnd = 751060, XrefRangeStart = 751015, XrefRangeEnd = 751059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerProperty);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_PopulateMultidimensionalArray_Private_Object_IList_JsonReader_JsonArrayContract_JsonProperty_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x0004AB94 File Offset: 0x00048D94
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 751068, RefRangeEnd = 751075, XrefRangeStart = 751060, XrefRangeEnd = 751068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, Object currentObject, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentObject);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_ThrowUnexpectedEndException_Private_Void_JsonReader_JsonContract_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x0004AC10 File Offset: 0x00048E10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 751121, RefRangeEnd = 751123, XrefRangeStart = 751075, XrefRangeEnd = 751121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerProperty);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_PopulateList_Private_Object_IList_JsonReader_JsonArrayContract_JsonProperty_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x0004ACAC File Offset: 0x00048EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751123, XrefRangeEnd = 751182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_CreateISerializable_Private_Object_JsonReader_JsonISerializableContract_JsonProperty_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0004AD34 File Offset: 0x00048F34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 751192, RefRangeEnd = 751193, XrefRangeStart = 751182, XrefRangeEnd = 751192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(token);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_CreateISerializableItem_Internal_Object_JToken_Type_JsonISerializableContract_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x0004ADBC File Offset: 0x00048FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751193, XrefRangeEnd = 751243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CreateDynamic(JsonReader reader, JsonDynamicContract contract, JsonProperty member, string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_CreateDynamic_Private_Object_JsonReader_JsonDynamicContract_JsonProperty_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x0004AE44 File Offset: 0x00049044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751243, XrefRangeEnd = 751499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, ObjectConstructor<Object> creator, string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerProperty);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(creator);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_CreateObjectUsingCreatorWithParameters_Private_Object_JsonReader_JsonObjectContract_JsonProperty_ObjectConstructor_1_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x0004AEE0 File Offset: 0x000490E0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 751540, RefRangeEnd = 751547, XrefRangeStart = 751499, XrefRangeEnd = 751540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, Object existingValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(converter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(existingValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_DeserializeConvertable_Private_Object_JsonConverter_JsonReader_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x0004AF68 File Offset: 0x00049168
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 751625, RefRangeEnd = 751626, XrefRangeStart = 751547, XrefRangeEnd = 751625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerProperty);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_ResolvePropertyAndCreatorValues_Private_List_1_CreatorPropertyContext_JsonObjectContract_JsonProperty_JsonReader_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<JsonSerializerInternalReader.CreatorPropertyContext>>(intPtr3) : null;
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x0004AFF0 File Offset: 0x000491F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751626, XrefRangeEnd = 751638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, out bool createdFromNonDefaultCreator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectContract);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerMember);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerProperty);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &createdFromNonDefaultCreator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_CreateNewObject_Public_Object_JsonReader_JsonObjectContract_JsonProperty_JsonProperty_String_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x0004B09C File Offset: 0x0004929C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 751766, RefRangeEnd = 751767, XrefRangeStart = 751638, XrefRangeEnd = 751766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object PopulateObject(Object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_PopulateObject_Private_Object_Object_JsonReader_JsonObjectContract_JsonProperty_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x0004B138 File Offset: 0x00049338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751767, XrefRangeEnd = 751786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldDeserialize(JsonReader reader, JsonProperty property, Object target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_ShouldDeserialize_Private_Boolean_JsonReader_JsonProperty_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x0004B1AC File Offset: 0x000493AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 751799, RefRangeEnd = 751802, XrefRangeStart = 751786, XrefRangeEnd = 751799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckPropertyName(JsonReader reader, string memberName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_CheckPropertyName_Private_Boolean_JsonReader_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x0004B20C File Offset: 0x0004940C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 751803, RefRangeEnd = 751806, XrefRangeStart = 751802, XrefRangeEnd = 751803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_SetExtensionData_Private_Void_JsonObjectContract_JsonProperty_JsonReader_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x0004B298 File Offset: 0x00049498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751806, XrefRangeEnd = 751808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_ReadExtensionDataValue_Private_Object_JsonObjectContract_JsonProperty_JsonReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x0004B30C File Offset: 0x0004950C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 751832, RefRangeEnd = 751834, XrefRangeStart = 751808, XrefRangeEnd = 751832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndProcessProperty(Object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, JsonSerializerInternalReader.PropertyPresence presence, bool setDefaultValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialDepth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref presence;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setDefaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_EndProcessProperty_Private_Void_Object_JsonReader_JsonObjectContract_Int32_JsonProperty_PropertyPresence_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x0004B3B0 File Offset: 0x000495B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 751841, RefRangeEnd = 751843, XrefRangeStart = 751834, XrefRangeEnd = 751841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> requiredProperties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requiredProperties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_SetPropertyPresence_Private_Void_JsonReader_JsonProperty_Dictionary_2_JsonProperty_PropertyPresence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x0004B418 File Offset: 0x00049618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751843, XrefRangeEnd = 751845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleError(JsonReader reader, bool readPastError, int initialDepth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readPastError;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.NativeMethodInfoPtr_HandleError_Private_Void_JsonReader_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x000062AD File Offset: 0x000044AD
		public JsonSerializerInternalReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_JsonSerializer_0;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeMethodInfoPtr_Populate_Public_Void_JsonReader_Object_0;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeMethodInfoPtr_GetContractSafe_Private_JsonContract_Type_0;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeMethodInfoPtr_GetContract_Private_JsonContract_Type_0;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Object_JsonReader_Type_Boolean_0;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeMethodInfoPtr_GetInternalSerializer_Private_JsonSerializerProxy_0;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeMethodInfoPtr_CreateJToken_Private_JToken_JsonReader_JsonContract_0;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeMethodInfoPtr_CreateJObject_Private_JToken_JsonReader_0;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeMethodInfoPtr_CreateValueInternal_Private_Object_JsonReader_Type_JsonContract_JsonProperty_JsonContainerContract_JsonProperty_Object_0;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeMethodInfoPtr_CoerceEmptyStringToNull_Private_Static_Boolean_Type_JsonContract_String_0;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeMethodInfoPtr_GetExpectedDescription_Internal_String_JsonContract_0;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeMethodInfoPtr_GetConverter_Private_JsonConverter_JsonContract_JsonConverter_JsonContainerContract_JsonProperty_0;

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeMethodInfoPtr_CreateObject_Private_Object_JsonReader_Type_JsonContract_JsonProperty_JsonContainerContract_JsonProperty_Object_0;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeMethodInfoPtr_ReadMetadataPropertiesToken_Private_Boolean_JTokenReader_byref_Type_byref_JsonContract_JsonProperty_JsonContainerContract_JsonProperty_Object_byref_Object_byref_String_0;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeMethodInfoPtr_ReadMetadataProperties_Private_Boolean_JsonReader_byref_Type_byref_JsonContract_JsonProperty_JsonContainerContract_JsonProperty_Object_byref_Object_byref_String_0;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeMethodInfoPtr_ResolveTypeName_Private_Void_JsonReader_byref_Type_byref_JsonContract_JsonProperty_JsonContainerContract_JsonProperty_String_0;

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeMethodInfoPtr_EnsureArrayContract_Private_JsonArrayContract_JsonReader_Type_JsonContract_0;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeMethodInfoPtr_CreateList_Private_Object_JsonReader_Type_JsonContract_JsonProperty_Object_String_0;

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeMethodInfoPtr_HasNoDefinedType_Private_Boolean_JsonContract_0;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeMethodInfoPtr_EnsureType_Private_Object_JsonReader_Object_CultureInfo_JsonContract_Type_0;

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeMethodInfoPtr_SetPropertyValue_Private_Boolean_JsonProperty_JsonConverter_JsonContainerContract_JsonProperty_JsonReader_Object_0;

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeMethodInfoPtr_CalculatePropertyDetails_Private_Boolean_JsonProperty_byref_JsonConverter_JsonContainerContract_JsonProperty_JsonReader_Object_byref_Boolean_byref_Object_byref_JsonContract_byref_Boolean_byref_Boolean_0;

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeMethodInfoPtr_AddReference_Private_Void_JsonReader_String_Object_0;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeMethodInfoPtr_HasFlag_Private_Boolean_DefaultValueHandling_DefaultValueHandling_0;

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSetPropertyValue_Private_Boolean_JsonProperty_JsonObjectContract_Object_0;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeMethodInfoPtr_CreateNewList_Private_IList_JsonReader_JsonArrayContract_byref_Boolean_0;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeMethodInfoPtr_CreateNewDictionary_Private_IDictionary_JsonReader_JsonDictionaryContract_byref_Boolean_0;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializing_Private_Void_JsonReader_JsonContract_Object_0;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_JsonReader_JsonContract_Object_0;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeMethodInfoPtr_PopulateDictionary_Private_Object_IDictionary_JsonReader_JsonDictionaryContract_JsonProperty_String_0;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeMethodInfoPtr_PopulateMultidimensionalArray_Private_Object_IList_JsonReader_JsonArrayContract_JsonProperty_String_0;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeMethodInfoPtr_ThrowUnexpectedEndException_Private_Void_JsonReader_JsonContract_Object_String_0;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeMethodInfoPtr_PopulateList_Private_Object_IList_JsonReader_JsonArrayContract_JsonProperty_String_0;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeMethodInfoPtr_CreateISerializable_Private_Object_JsonReader_JsonISerializableContract_JsonProperty_String_0;

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeMethodInfoPtr_CreateISerializableItem_Internal_Object_JToken_Type_JsonISerializableContract_JsonProperty_0;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeMethodInfoPtr_CreateDynamic_Private_Object_JsonReader_JsonDynamicContract_JsonProperty_String_0;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeMethodInfoPtr_CreateObjectUsingCreatorWithParameters_Private_Object_JsonReader_JsonObjectContract_JsonProperty_ObjectConstructor_1_Object_String_0;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeConvertable_Private_Object_JsonConverter_JsonReader_Type_Object_0;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeMethodInfoPtr_ResolvePropertyAndCreatorValues_Private_List_1_CreatorPropertyContext_JsonObjectContract_JsonProperty_JsonReader_Type_0;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeMethodInfoPtr_CreateNewObject_Public_Object_JsonReader_JsonObjectContract_JsonProperty_JsonProperty_String_byref_Boolean_0;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeMethodInfoPtr_PopulateObject_Private_Object_Object_JsonReader_JsonObjectContract_JsonProperty_String_0;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeMethodInfoPtr_ShouldDeserialize_Private_Boolean_JsonReader_JsonProperty_Object_0;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeMethodInfoPtr_CheckPropertyName_Private_Boolean_JsonReader_String_0;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeMethodInfoPtr_SetExtensionData_Private_Void_JsonObjectContract_JsonProperty_JsonReader_String_Object_0;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeMethodInfoPtr_ReadExtensionDataValue_Private_Object_JsonObjectContract_JsonProperty_JsonReader_0;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeMethodInfoPtr_EndProcessProperty_Private_Void_Object_JsonReader_JsonObjectContract_Int32_JsonProperty_PropertyPresence_Boolean_0;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeMethodInfoPtr_SetPropertyPresence_Private_Void_JsonReader_JsonProperty_Dictionary_2_JsonProperty_PropertyPresence_0;

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeMethodInfoPtr_HandleError_Private_Void_JsonReader_Boolean_Int32_0;

		// Token: 0x020001D0 RID: 464
		public enum PropertyPresence
		{
			// Token: 0x04001653 RID: 5715
			None,
			// Token: 0x04001654 RID: 5716
			Null,
			// Token: 0x04001655 RID: 5717
			Value
		}

		// Token: 0x020001D1 RID: 465
		public class CreatorPropertyContext : Object
		{
			// Token: 0x06001E98 RID: 7832 RVA: 0x0008D054 File Offset: 0x0008B254
			// Note: this type is marked as 'beforefieldinit'.
			static CreatorPropertyContext()
			{
				Il2CppClassPointerStore<JsonSerializerInternalReader.CreatorPropertyContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, "CreatorPropertyContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSerializerInternalReader.CreatorPropertyContext>.NativeClassPtr);
				JsonSerializerInternalReader.CreatorPropertyContext.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerInternalReader.CreatorPropertyContext>.NativeClassPtr, "Name");
				JsonSerializerInternalReader.CreatorPropertyContext.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerInternalReader.CreatorPropertyContext>.NativeClassPtr, "Property");
				JsonSerializerInternalReader.CreatorPropertyContext.NativeFieldInfoPtr_ConstructorProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerInternalReader.CreatorPropertyContext>.NativeClassPtr, "ConstructorProperty");
				JsonSerializerInternalReader.CreatorPropertyContext.NativeFieldInfoPtr_Presence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerInternalReader.CreatorPropertyContext>.NativeClassPtr, "Presence");
				JsonSerializerInternalReader.CreatorPropertyContext.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerInternalReader.CreatorPropertyContext>.NativeClassPtr, "Value");
				JsonSerializerInternalReader.CreatorPropertyContext.NativeFieldInfoPtr_Used = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerInternalReader.CreatorPropertyContext>.NativeClassPtr, "Used");
				JsonSerializerInternalReader.CreatorPropertyContext.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader.CreatorPropertyContext>.NativeClassPtr, 100665570);
			}

			// Token: 0x06001E99 RID: 7833 RVA: 0x0008D10C File Offset: 0x0008B30C
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CreatorPropertyContext(string name)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSerializerInternalReader.CreatorPropertyContext>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.CreatorPropertyContext.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E9A RID: 7834 RVA: 0x0000F1B8 File Offset: 0x0000D3B8
			public CreatorPropertyContext(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000894 RID: 2196
			// (get) Token: 0x06001E9B RID: 7835 RVA: 0x0008D158 File Offset: 0x0008B358
			// (set) Token: 0x06001E9C RID: 7836 RVA: 0x0000F1C1 File Offset: 0x0000D3C1
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalReader.CreatorPropertyContext.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalReader.CreatorPropertyContext.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000895 RID: 2197
			// (get) Token: 0x06001E9D RID: 7837 RVA: 0x0008D180 File Offset: 0x0008B380
			// (set) Token: 0x06001E9E RID: 7838 RVA: 0x0000F1E0 File Offset: 0x0000D3E0
			public unsafe JsonProperty Property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalReader.CreatorPropertyContext.NativeFieldInfoPtr_Property);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonProperty>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalReader.CreatorPropertyContext.NativeFieldInfoPtr_Property), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000896 RID: 2198
			// (get) Token: 0x06001E9F RID: 7839 RVA: 0x0008D1B0 File Offset: 0x0008B3B0
			// (set) Token: 0x06001EA0 RID: 7840 RVA: 0x0000F1FF File Offset: 0x0000D3FF
			public unsafe JsonProperty ConstructorProperty
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalReader.CreatorPropertyContext.NativeFieldInfoPtr_ConstructorProperty);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonProperty>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalReader.CreatorPropertyContext.NativeFieldInfoPtr_ConstructorProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000897 RID: 2199
			// (get) Token: 0x06001EA1 RID: 7841 RVA: 0x0008D1E0 File Offset: 0x0008B3E0
			// (set) Token: 0x06001EA2 RID: 7842 RVA: 0x0000F21E File Offset: 0x0000D41E
			public Nullable<JsonSerializerInternalReader.PropertyPresence> Presence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalReader.CreatorPropertyContext.NativeFieldInfoPtr_Presence);
					return new Nullable<JsonSerializerInternalReader.PropertyPresence>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<JsonSerializerInternalReader.PropertyPresence>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalReader.CreatorPropertyContext.NativeFieldInfoPtr_Presence), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<JsonSerializerInternalReader.PropertyPresence>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000898 RID: 2200
			// (get) Token: 0x06001EA3 RID: 7843 RVA: 0x0008D210 File Offset: 0x0008B410
			// (set) Token: 0x06001EA4 RID: 7844 RVA: 0x0000F24C File Offset: 0x0000D44C
			public unsafe Object Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalReader.CreatorPropertyContext.NativeFieldInfoPtr_Value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalReader.CreatorPropertyContext.NativeFieldInfoPtr_Value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000899 RID: 2201
			// (get) Token: 0x06001EA5 RID: 7845 RVA: 0x0008D240 File Offset: 0x0008B440
			// (set) Token: 0x06001EA6 RID: 7846 RVA: 0x0000F26B File Offset: 0x0000D46B
			public unsafe bool Used
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalReader.CreatorPropertyContext.NativeFieldInfoPtr_Used);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalReader.CreatorPropertyContext.NativeFieldInfoPtr_Used)) = value;
				}
			}

			// Token: 0x04001656 RID: 5718
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04001657 RID: 5719
			private static readonly IntPtr NativeFieldInfoPtr_Property;

			// Token: 0x04001658 RID: 5720
			private static readonly IntPtr NativeFieldInfoPtr_ConstructorProperty;

			// Token: 0x04001659 RID: 5721
			private static readonly IntPtr NativeFieldInfoPtr_Presence;

			// Token: 0x0400165A RID: 5722
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x0400165B RID: 5723
			private static readonly IntPtr NativeFieldInfoPtr_Used;

			// Token: 0x0400165C RID: 5724
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
		}

		// Token: 0x020001D2 RID: 466
		[ObfuscatedName("Newtonsoft.Json.Serialization.JsonSerializerInternalReader+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001EA7 RID: 7847 RVA: 0x0008D268 File Offset: 0x0008B468
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<JsonSerializerInternalReader.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSerializerInternalReader.__c>.NativeClassPtr);
				JsonSerializerInternalReader.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerInternalReader.__c>.NativeClassPtr, "<>9");
				JsonSerializerInternalReader.__c.NativeFieldInfoPtr___9__38_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerInternalReader.__c>.NativeClassPtr, "<>9__38_0");
				JsonSerializerInternalReader.__c.NativeFieldInfoPtr___9__38_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerInternalReader.__c>.NativeClassPtr, "<>9__38_2");
				JsonSerializerInternalReader.__c.NativeFieldInfoPtr___9__42_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerInternalReader.__c>.NativeClassPtr, "<>9__42_0");
				JsonSerializerInternalReader.__c.NativeFieldInfoPtr___9__42_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerInternalReader.__c>.NativeClassPtr, "<>9__42_1");
				JsonSerializerInternalReader.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader.__c>.NativeClassPtr, 100665572);
				JsonSerializerInternalReader.__c.NativeMethodInfoPtr__CreateObjectUsingCreatorWithParameters_b__38_0_Internal_String_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader.__c>.NativeClassPtr, 100665573);
				JsonSerializerInternalReader.__c.NativeMethodInfoPtr__CreateObjectUsingCreatorWithParameters_b__38_2_Internal_String_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader.__c>.NativeClassPtr, 100665574);
				JsonSerializerInternalReader.__c.NativeMethodInfoPtr__PopulateObject_b__42_0_Internal_JsonProperty_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader.__c>.NativeClassPtr, 100665575);
				JsonSerializerInternalReader.__c.NativeMethodInfoPtr__PopulateObject_b__42_1_Internal_PropertyPresence_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader.__c>.NativeClassPtr, 100665576);
			}

			// Token: 0x06001EA8 RID: 7848 RVA: 0x0008D35C File Offset: 0x0008B55C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSerializerInternalReader.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EA9 RID: 7849 RVA: 0x0008D398 File Offset: 0x0008B598
			[CallerCount(0)]
			public unsafe string _CreateObjectUsingCreatorWithParameters_b__38_0(JsonProperty p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.__c.NativeMethodInfoPtr__CreateObjectUsingCreatorWithParameters_b__38_0_Internal_String_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001EAA RID: 7850 RVA: 0x0008D3E0 File Offset: 0x0008B5E0
			[CallerCount(0)]
			public unsafe string _CreateObjectUsingCreatorWithParameters_b__38_2(JsonProperty p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.__c.NativeMethodInfoPtr__CreateObjectUsingCreatorWithParameters_b__38_2_Internal_String_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001EAB RID: 7851 RVA: 0x0008D428 File Offset: 0x0008B628
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe JsonProperty _PopulateObject_b__42_0(JsonProperty m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.__c.NativeMethodInfoPtr__PopulateObject_b__42_0_Internal_JsonProperty_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonProperty>(intPtr3) : null;
				}
			}

			// Token: 0x06001EAC RID: 7852 RVA: 0x0008D478 File Offset: 0x0008B678
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe JsonSerializerInternalReader.PropertyPresence _PopulateObject_b__42_1(JsonProperty m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.__c.NativeMethodInfoPtr__PopulateObject_b__42_1_Internal_PropertyPresence_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001EAD RID: 7853 RVA: 0x0000F286 File Offset: 0x0000D486
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700089A RID: 2202
			// (get) Token: 0x06001EAE RID: 7854 RVA: 0x0008D4C8 File Offset: 0x0008B6C8
			// (set) Token: 0x06001EAF RID: 7855 RVA: 0x0000F28F File Offset: 0x0000D48F
			public unsafe static JsonSerializerInternalReader.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JsonSerializerInternalReader.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSerializerInternalReader.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JsonSerializerInternalReader.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700089B RID: 2203
			// (get) Token: 0x06001EB0 RID: 7856 RVA: 0x0008D4F0 File Offset: 0x0008B6F0
			// (set) Token: 0x06001EB1 RID: 7857 RVA: 0x0000F2A1 File Offset: 0x0000D4A1
			public unsafe static Func<JsonProperty, string> __9__38_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JsonSerializerInternalReader.__c.NativeFieldInfoPtr___9__38_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<JsonProperty, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JsonSerializerInternalReader.__c.NativeFieldInfoPtr___9__38_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700089C RID: 2204
			// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x0008D518 File Offset: 0x0008B718
			// (set) Token: 0x06001EB3 RID: 7859 RVA: 0x0000F2B3 File Offset: 0x0000D4B3
			public unsafe static Func<JsonProperty, string> __9__38_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JsonSerializerInternalReader.__c.NativeFieldInfoPtr___9__38_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<JsonProperty, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JsonSerializerInternalReader.__c.NativeFieldInfoPtr___9__38_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700089D RID: 2205
			// (get) Token: 0x06001EB4 RID: 7860 RVA: 0x0008D540 File Offset: 0x0008B740
			// (set) Token: 0x06001EB5 RID: 7861 RVA: 0x0000F2C5 File Offset: 0x0000D4C5
			public unsafe static Func<JsonProperty, JsonProperty> __9__42_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JsonSerializerInternalReader.__c.NativeFieldInfoPtr___9__42_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<JsonProperty, JsonProperty>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JsonSerializerInternalReader.__c.NativeFieldInfoPtr___9__42_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700089E RID: 2206
			// (get) Token: 0x06001EB6 RID: 7862 RVA: 0x0008D568 File Offset: 0x0008B768
			// (set) Token: 0x06001EB7 RID: 7863 RVA: 0x0000F2D7 File Offset: 0x0000D4D7
			public unsafe static Func<JsonProperty, JsonSerializerInternalReader.PropertyPresence> __9__42_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JsonSerializerInternalReader.__c.NativeFieldInfoPtr___9__42_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<JsonProperty, JsonSerializerInternalReader.PropertyPresence>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JsonSerializerInternalReader.__c.NativeFieldInfoPtr___9__42_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400165D RID: 5725
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400165E RID: 5726
			private static readonly IntPtr NativeFieldInfoPtr___9__38_0;

			// Token: 0x0400165F RID: 5727
			private static readonly IntPtr NativeFieldInfoPtr___9__38_2;

			// Token: 0x04001660 RID: 5728
			private static readonly IntPtr NativeFieldInfoPtr___9__42_0;

			// Token: 0x04001661 RID: 5729
			private static readonly IntPtr NativeFieldInfoPtr___9__42_1;

			// Token: 0x04001662 RID: 5730
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001663 RID: 5731
			private static readonly IntPtr NativeMethodInfoPtr__CreateObjectUsingCreatorWithParameters_b__38_0_Internal_String_JsonProperty_0;

			// Token: 0x04001664 RID: 5732
			private static readonly IntPtr NativeMethodInfoPtr__CreateObjectUsingCreatorWithParameters_b__38_2_Internal_String_JsonProperty_0;

			// Token: 0x04001665 RID: 5733
			private static readonly IntPtr NativeMethodInfoPtr__PopulateObject_b__42_0_Internal_JsonProperty_JsonProperty_0;

			// Token: 0x04001666 RID: 5734
			private static readonly IntPtr NativeMethodInfoPtr__PopulateObject_b__42_1_Internal_PropertyPresence_JsonProperty_0;
		}

		// Token: 0x020001D3 RID: 467
		[ObfuscatedName("Newtonsoft.Json.Serialization.JsonSerializerInternalReader+<>c__DisplayClass38_0")]
		public sealed class __c__DisplayClass38_0 : Object
		{
			// Token: 0x06001EB8 RID: 7864 RVA: 0x0008D590 File Offset: 0x0008B790
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_0()
			{
				Il2CppClassPointerStore<JsonSerializerInternalReader.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonSerializerInternalReader>.NativeClassPtr, "<>c__DisplayClass38_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSerializerInternalReader.__c__DisplayClass38_0>.NativeClassPtr);
				JsonSerializerInternalReader.__c__DisplayClass38_0.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerInternalReader.__c__DisplayClass38_0>.NativeClassPtr, "property");
				JsonSerializerInternalReader.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader.__c__DisplayClass38_0>.NativeClassPtr, 100665577);
				JsonSerializerInternalReader.__c__DisplayClass38_0.NativeMethodInfoPtr__CreateObjectUsingCreatorWithParameters_b__1_Internal_Boolean_CreatorPropertyContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalReader.__c__DisplayClass38_0>.NativeClassPtr, 100665578);
			}

			// Token: 0x06001EB9 RID: 7865 RVA: 0x0008D5F8 File Offset: 0x0008B7F8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass38_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSerializerInternalReader.__c__DisplayClass38_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EBA RID: 7866 RVA: 0x0008D634 File Offset: 0x0008B834
			[CallerCount(0)]
			public unsafe bool _CreateObjectUsingCreatorWithParameters_b__1(JsonSerializerInternalReader.CreatorPropertyContext p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalReader.__c__DisplayClass38_0.NativeMethodInfoPtr__CreateObjectUsingCreatorWithParameters_b__1_Internal_Boolean_CreatorPropertyContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001EBB RID: 7867 RVA: 0x0000F2E9 File Offset: 0x0000D4E9
			public __c__DisplayClass38_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700089F RID: 2207
			// (get) Token: 0x06001EBC RID: 7868 RVA: 0x0008D684 File Offset: 0x0008B884
			// (set) Token: 0x06001EBD RID: 7869 RVA: 0x0000F2F2 File Offset: 0x0000D4F2
			public unsafe JsonProperty property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalReader.__c__DisplayClass38_0.NativeFieldInfoPtr_property);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonProperty>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalReader.__c__DisplayClass38_0.NativeFieldInfoPtr_property), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001667 RID: 5735
			private static readonly IntPtr NativeFieldInfoPtr_property;

			// Token: 0x04001668 RID: 5736
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001669 RID: 5737
			private static readonly IntPtr NativeMethodInfoPtr__CreateObjectUsingCreatorWithParameters_b__1_Internal_Boolean_CreatorPropertyContext_0;
		}
	}
}

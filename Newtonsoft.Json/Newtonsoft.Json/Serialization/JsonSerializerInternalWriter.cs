using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Dynamic;
using Il2CppSystem.Runtime.Serialization;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000093 RID: 147
	public class JsonSerializerInternalWriter : JsonSerializerInternalBase
	{
		// Token: 0x06000C89 RID: 3209 RVA: 0x0004B478 File Offset: 0x00049678
		// Note: this type is marked as 'beforefieldinit'.
		static JsonSerializerInternalWriter()
		{
			Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "JsonSerializerInternalWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr);
			JsonSerializerInternalWriter.NativeFieldInfoPtr__rootType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, "_rootType");
			JsonSerializerInternalWriter.NativeFieldInfoPtr__rootLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, "_rootLevel");
			JsonSerializerInternalWriter.NativeFieldInfoPtr__serializeStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, "_serializeStack");
			JsonSerializerInternalWriter.NativeMethodInfoPtr__ctor_Public_Void_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665579);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_Serialize_Public_Void_JsonWriter_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665580);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_GetInternalSerializer_Private_JsonSerializerProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665581);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_GetContractSafe_Private_JsonContract_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665582);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_GetContract_Private_JsonContract_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665583);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_SerializePrimitive_Private_Void_JsonWriter_Object_JsonPrimitiveContract_JsonProperty_JsonContainerContract_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665584);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_SerializeValue_Private_Void_JsonWriter_Object_JsonContract_JsonProperty_JsonContainerContract_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665585);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_ResolveIsReference_Private_Nullable_1_Boolean_JsonContract_JsonProperty_JsonContainerContract_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665586);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_ShouldWriteReference_Private_Boolean_Object_JsonProperty_JsonContract_JsonContainerContract_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665587);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_ShouldWriteProperty_Private_Boolean_Object_JsonObjectContract_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665588);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_CheckForCircularReference_Private_Boolean_JsonWriter_Object_JsonProperty_JsonContract_JsonContainerContract_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665589);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_WriteReference_Private_Void_JsonWriter_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665590);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_GetReference_Private_String_JsonWriter_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665591);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_TryConvertToString_Internal_Static_Boolean_Object_Type_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665592);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_SerializeString_Private_Void_JsonWriter_Object_JsonStringContract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665593);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_OnSerializing_Private_Void_JsonWriter_JsonContract_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665594);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_OnSerialized_Private_Void_JsonWriter_JsonContract_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665595);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_SerializeObject_Private_Void_JsonWriter_Object_JsonObjectContract_JsonProperty_JsonContainerContract_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665596);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_CalculatePropertyValues_Private_Boolean_JsonWriter_Object_JsonContainerContract_JsonProperty_JsonProperty_byref_JsonContract_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665597);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_WriteObjectStart_Private_Void_JsonWriter_Object_JsonContract_JsonProperty_JsonContainerContract_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665598);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_HasCreatorParameter_Private_Boolean_JsonContainerContract_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665599);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_WriteReferenceIdProperty_Private_Void_JsonWriter_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665600);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_WriteTypeProperty_Private_Void_JsonWriter_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665601);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_HasFlag_Private_Boolean_DefaultValueHandling_DefaultValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665602);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_HasFlag_Private_Boolean_PreserveReferencesHandling_PreserveReferencesHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665603);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_HasFlag_Private_Boolean_TypeNameHandling_TypeNameHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665604);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_SerializeConvertable_Private_Void_JsonWriter_JsonConverter_Object_JsonContract_JsonContainerContract_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665605);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_SerializeList_Private_Void_JsonWriter_IEnumerable_JsonArrayContract_JsonProperty_JsonContainerContract_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665606);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_SerializeMultidimensionalArray_Private_Void_JsonWriter_Array_JsonArrayContract_JsonProperty_JsonContainerContract_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665607);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_SerializeMultidimensionalArray_Private_Void_JsonWriter_Array_JsonArrayContract_JsonProperty_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665608);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_WriteStartArray_Private_Boolean_JsonWriter_Object_JsonArrayContract_JsonProperty_JsonContainerContract_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665609);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_SerializeISerializable_Private_Void_JsonWriter_ISerializable_JsonISerializableContract_JsonProperty_JsonContainerContract_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665610);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_SerializeDynamic_Private_Void_JsonWriter_IDynamicMetaObjectProvider_JsonDynamicContract_JsonProperty_JsonContainerContract_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665611);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_ShouldWriteDynamicProperty_Private_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665612);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_ShouldWriteType_Private_Boolean_TypeNameHandling_JsonContract_JsonProperty_JsonContainerContract_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665613);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_SerializeDictionary_Private_Void_JsonWriter_IDictionary_JsonDictionaryContract_JsonProperty_JsonContainerContract_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665614);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_GetPropertyName_Private_String_JsonWriter_Object_JsonContract_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665615);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_HandleError_Private_Void_JsonWriter_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665616);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_ShouldSerialize_Private_Boolean_JsonWriter_JsonProperty_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665617);
			JsonSerializerInternalWriter.NativeMethodInfoPtr_IsSpecified_Private_Boolean_JsonWriter_JsonProperty_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr, 100665618);
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x0004B804 File Offset: 0x00049A04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 751853, RefRangeEnd = 751855, XrefRangeStart = 751845, XrefRangeEnd = 751853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSerializerInternalWriter(JsonSerializer serializer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSerializerInternalWriter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr__ctor_Public_Void_JsonSerializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x0004B850 File Offset: 0x00049A50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 751877, RefRangeEnd = 751879, XrefRangeStart = 751855, XrefRangeEnd = 751877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_Serialize_Public_Void_JsonWriter_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x0004B8B8 File Offset: 0x00049AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751879, XrefRangeEnd = 751889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSerializerProxy GetInternalSerializer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_GetInternalSerializer_Private_JsonSerializerProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSerializerProxy>(intPtr3) : null;
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x0004B8F8 File Offset: 0x00049AF8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 751893, RefRangeEnd = 751897, XrefRangeStart = 751889, XrefRangeEnd = 751893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonContract GetContractSafe(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_GetContractSafe_Private_JsonContract_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonContract>(intPtr3) : null;
			}
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x0004B948 File Offset: 0x00049B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751897, XrefRangeEnd = 751902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonContract GetContract(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_GetContract_Private_JsonContract_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonContract>(intPtr3) : null;
			}
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x0004B998 File Offset: 0x00049B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751902, XrefRangeEnd = 751931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SerializePrimitive(JsonWriter writer, Object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerContract);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerProperty);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_SerializePrimitive_Private_Void_JsonWriter_Object_JsonPrimitiveContract_JsonProperty_JsonContainerContract_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x0004BA38 File Offset: 0x00049C38
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 751947, RefRangeEnd = 751956, XrefRangeStart = 751931, XrefRangeEnd = 751947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SerializeValue(JsonWriter writer, Object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueContract);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerContract);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerProperty);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_SerializeValue_Private_Void_JsonWriter_Object_JsonContract_JsonProperty_JsonContainerContract_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x0004BAD8 File Offset: 0x00049CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751956, XrefRangeEnd = 751957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<bool> ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collectionContract);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerProperty);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_ResolveIsReference_Private_Nullable_1_Boolean_JsonContract_JsonProperty_JsonContainerContract_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<bool>(intPtr);
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x0004BB58 File Offset: 0x00049D58
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 751970, RefRangeEnd = 751978, XrefRangeStart = 751957, XrefRangeEnd = 751970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldWriteReference(Object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueContract);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collectionContract);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerProperty);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_ShouldWriteReference_Private_Boolean_Object_JsonProperty_JsonContract_JsonContainerContract_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x0004BBF0 File Offset: 0x00049DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 751978, XrefRangeEnd = 751984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldWriteProperty(Object memberValue, JsonObjectContract containerContract, JsonProperty property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerContract);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_ShouldWriteProperty_Private_Boolean_Object_JsonObjectContract_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x0004BC64 File Offset: 0x00049E64
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 752027, RefRangeEnd = 752034, XrefRangeStart = 751984, XrefRangeEnd = 752027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckForCircularReference(JsonWriter writer, Object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerContract);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerProperty);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_CheckForCircularReference_Private_Boolean_JsonWriter_Object_JsonProperty_JsonContract_JsonContainerContract_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x0004BD10 File Offset: 0x00049F10
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 752057, RefRangeEnd = 752065, XrefRangeStart = 752034, XrefRangeEnd = 752057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteReference(JsonWriter writer, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_WriteReference_Private_Void_JsonWriter_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x0004BD64 File Offset: 0x00049F64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 752069, RefRangeEnd = 752071, XrefRangeStart = 752065, XrefRangeEnd = 752069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetReference(JsonWriter writer, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_GetReference_Private_String_JsonWriter_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x0004BDC0 File Offset: 0x00049FC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 752110, RefRangeEnd = 752113, XrefRangeStart = 752071, XrefRangeEnd = 752110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryConvertToString(Object value, Type type, out string s)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_TryConvertToString_Internal_Static_Boolean_Object_Type_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			s = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x0004BE30 File Offset: 0x0004A030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752113, XrefRangeEnd = 752116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SerializeString(JsonWriter writer, Object value, JsonStringContract contract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_SerializeString_Private_Void_JsonWriter_Object_JsonStringContract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x0004BE98 File Offset: 0x0004A098
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 752134, RefRangeEnd = 752141, XrefRangeStart = 752116, XrefRangeEnd = 752134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSerializing(JsonWriter writer, JsonContract contract, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_OnSerializing_Private_Void_JsonWriter_JsonContract_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x0004BF00 File Offset: 0x0004A100
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 752159, RefRangeEnd = 752166, XrefRangeStart = 752141, XrefRangeEnd = 752159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSerialized(JsonWriter writer, JsonContract contract, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_OnSerialized_Private_Void_JsonWriter_JsonContract_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x0004BF68 File Offset: 0x0004A168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752166, XrefRangeEnd = 752262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SerializeObject(JsonWriter writer, Object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collectionContract);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerProperty);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_SerializeObject_Private_Void_JsonWriter_Object_JsonObjectContract_JsonProperty_JsonContainerContract_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x0004C008 File Offset: 0x0004A208
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 752334, RefRangeEnd = 752336, XrefRangeStart = 752262, XrefRangeEnd = 752334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CalculatePropertyValues(JsonWriter writer, Object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, out JsonContract memberContract, out Object memberValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(property);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_CalculatePropertyValues_Private_Boolean_JsonWriter_Object_JsonContainerContract_JsonProperty_JsonProperty_byref_JsonContract_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			memberContract = ((intPtr5 == 0) ? null : new JsonContract(intPtr5));
			IntPtr intPtr6 = intPtr2;
			memberValue = ((intPtr6 == 0) ? null : new Object(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x0004C0E8 File Offset: 0x0004A2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752336, XrefRangeEnd = 752359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteObjectStart(JsonWriter writer, Object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collectionContract);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerProperty);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_WriteObjectStart_Private_Void_JsonWriter_Object_JsonContract_JsonProperty_JsonContainerContract_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x0004C188 File Offset: 0x0004A388
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 752366, RefRangeEnd = 752372, XrefRangeStart = 752359, XrefRangeEnd = 752366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCreatorParameter(JsonContainerContract contract, JsonProperty property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_HasCreatorParameter_Private_Boolean_JsonContainerContract_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x0004C1E8 File Offset: 0x0004A3E8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 752394, RefRangeEnd = 752400, XrefRangeStart = 752372, XrefRangeEnd = 752394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteReferenceIdProperty(JsonWriter writer, Type type, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_WriteReferenceIdProperty_Private_Void_JsonWriter_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x0004C250 File Offset: 0x0004A450
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 752425, RefRangeEnd = 752431, XrefRangeStart = 752400, XrefRangeEnd = 752425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteTypeProperty(JsonWriter writer, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_WriteTypeProperty_Private_Void_JsonWriter_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x0004C2A4 File Offset: 0x0004A4A4
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_HasFlag_Private_Boolean_DefaultValueHandling_DefaultValueHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x0004C2FC File Offset: 0x0004A4FC
		[CallerCount(0)]
		public unsafe bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_HasFlag_Private_Boolean_PreserveReferencesHandling_PreserveReferencesHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x0004C354 File Offset: 0x0004A554
		[CallerCount(0)]
		public unsafe bool HasFlag(TypeNameHandling value, TypeNameHandling flag)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_HasFlag_Private_Boolean_TypeNameHandling_TypeNameHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x0004C3AC File Offset: 0x0004A5AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 752487, RefRangeEnd = 752488, XrefRangeStart = 752431, XrefRangeEnd = 752487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SerializeConvertable(JsonWriter writer, JsonConverter converter, Object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collectionContract);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerProperty);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_SerializeConvertable_Private_Void_JsonWriter_JsonConverter_Object_JsonContract_JsonContainerContract_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x0004C44C File Offset: 0x0004A64C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752488, XrefRangeEnd = 752539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collectionContract);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerProperty);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_SerializeList_Private_Void_JsonWriter_IEnumerable_JsonArrayContract_JsonProperty_JsonContainerContract_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x0004C4EC File Offset: 0x0004A6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752539, XrefRangeEnd = 752561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collectionContract);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerProperty);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_SerializeMultidimensionalArray_Private_Void_JsonWriter_Array_JsonArrayContract_JsonProperty_JsonContainerContract_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x0004C58C File Offset: 0x0004A78C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 752591, RefRangeEnd = 752593, XrefRangeStart = 752561, XrefRangeEnd = 752591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, Il2CppStructArray<int> indices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialDepth;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_SerializeMultidimensionalArray_Private_Void_JsonWriter_Array_JsonArrayContract_JsonProperty_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x0004C628 File Offset: 0x0004A828
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 752633, RefRangeEnd = 752635, XrefRangeStart = 752593, XrefRangeEnd = 752633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WriteStartArray(JsonWriter writer, Object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerContract);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerProperty);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_WriteStartArray_Private_Boolean_JsonWriter_Object_JsonArrayContract_JsonProperty_JsonContainerContract_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x0004C6D4 File Offset: 0x0004A8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752635, XrefRangeEnd = 752740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collectionContract);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerProperty);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_SerializeISerializable_Private_Void_JsonWriter_ISerializable_JsonISerializableContract_JsonProperty_JsonContainerContract_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x0004C774 File Offset: 0x0004A974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752740, XrefRangeEnd = 752889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SerializeDynamic(JsonWriter writer, IDynamicMetaObjectProvider value, JsonDynamicContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collectionContract);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerProperty);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_SerializeDynamic_Private_Void_JsonWriter_IDynamicMetaObjectProvider_JsonDynamicContract_JsonProperty_JsonContainerContract_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x0004C814 File Offset: 0x0004AA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752889, XrefRangeEnd = 752895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldWriteDynamicProperty(Object memberValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_ShouldWriteDynamicProperty_Private_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x0004C864 File Offset: 0x0004AA64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752895, XrefRangeEnd = 752917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeNameHandlingFlag;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerContract);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerProperty);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_ShouldWriteType_Private_Boolean_TypeNameHandling_JsonContract_JsonProperty_JsonContainerContract_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x0004C8F8 File Offset: 0x0004AAF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 752917, XrefRangeEnd = 753016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collectionContract);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containerProperty);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_SerializeDictionary_Private_Void_JsonWriter_IDictionary_JsonDictionaryContract_JsonProperty_JsonContainerContract_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x0004C998 File Offset: 0x0004AB98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 753029, RefRangeEnd = 753031, XrefRangeStart = 753016, XrefRangeEnd = 753029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPropertyName(JsonWriter writer, Object name, JsonContract contract, out bool escape)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &escape;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_GetPropertyName_Private_String_JsonWriter_Object_JsonContract_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x0004CA14 File Offset: 0x0004AC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753031, XrefRangeEnd = 753035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleError(JsonWriter writer, int initialDepth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_HandleError_Private_Void_JsonWriter_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x0004CA64 File Offset: 0x0004AC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753035, XrefRangeEnd = 753055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldSerialize(JsonWriter writer, JsonProperty property, Object target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_ShouldSerialize_Private_Boolean_JsonWriter_JsonProperty_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x0004CAD8 File Offset: 0x0004ACD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753055, XrefRangeEnd = 753075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSpecified(JsonWriter writer, JsonProperty property, Object target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSerializerInternalWriter.NativeMethodInfoPtr_IsSpecified_Private_Boolean_JsonWriter_JsonProperty_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x000062B6 File Offset: 0x000044B6
		public JsonSerializerInternalWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x0004CB4C File Offset: 0x0004AD4C
		// (set) Token: 0x06000CB4 RID: 3252 RVA: 0x000062BF File Offset: 0x000044BF
		public unsafe Type _rootType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalWriter.NativeFieldInfoPtr__rootType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalWriter.NativeFieldInfoPtr__rootType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x0004CB7C File Offset: 0x0004AD7C
		// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x000062DE File Offset: 0x000044DE
		public unsafe int _rootLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalWriter.NativeFieldInfoPtr__rootLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalWriter.NativeFieldInfoPtr__rootLevel)) = value;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x0004CBA4 File Offset: 0x0004ADA4
		// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x000062F9 File Offset: 0x000044F9
		public unsafe List<Object> _serializeStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalWriter.NativeFieldInfoPtr__serializeStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSerializerInternalWriter.NativeFieldInfoPtr__serializeStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeFieldInfoPtr__rootType;

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeFieldInfoPtr__rootLevel;

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeFieldInfoPtr__serializeStack;

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_JsonSerializer_0;

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Void_JsonWriter_Object_Type_0;

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeMethodInfoPtr_GetInternalSerializer_Private_JsonSerializerProxy_0;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeMethodInfoPtr_GetContractSafe_Private_JsonContract_Object_0;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeMethodInfoPtr_GetContract_Private_JsonContract_Object_0;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeMethodInfoPtr_SerializePrimitive_Private_Void_JsonWriter_Object_JsonPrimitiveContract_JsonProperty_JsonContainerContract_JsonProperty_0;

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeMethodInfoPtr_SerializeValue_Private_Void_JsonWriter_Object_JsonContract_JsonProperty_JsonContainerContract_JsonProperty_0;

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeMethodInfoPtr_ResolveIsReference_Private_Nullable_1_Boolean_JsonContract_JsonProperty_JsonContainerContract_JsonProperty_0;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeMethodInfoPtr_ShouldWriteReference_Private_Boolean_Object_JsonProperty_JsonContract_JsonContainerContract_JsonProperty_0;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeMethodInfoPtr_ShouldWriteProperty_Private_Boolean_Object_JsonObjectContract_JsonProperty_0;

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeMethodInfoPtr_CheckForCircularReference_Private_Boolean_JsonWriter_Object_JsonProperty_JsonContract_JsonContainerContract_JsonProperty_0;

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeMethodInfoPtr_WriteReference_Private_Void_JsonWriter_Object_0;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeMethodInfoPtr_GetReference_Private_String_JsonWriter_Object_0;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeMethodInfoPtr_TryConvertToString_Internal_Static_Boolean_Object_Type_byref_String_0;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeMethodInfoPtr_SerializeString_Private_Void_JsonWriter_Object_JsonStringContract_0;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeMethodInfoPtr_OnSerializing_Private_Void_JsonWriter_JsonContract_Object_0;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeMethodInfoPtr_OnSerialized_Private_Void_JsonWriter_JsonContract_Object_0;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeMethodInfoPtr_SerializeObject_Private_Void_JsonWriter_Object_JsonObjectContract_JsonProperty_JsonContainerContract_JsonProperty_0;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeMethodInfoPtr_CalculatePropertyValues_Private_Boolean_JsonWriter_Object_JsonContainerContract_JsonProperty_JsonProperty_byref_JsonContract_byref_Object_0;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeMethodInfoPtr_WriteObjectStart_Private_Void_JsonWriter_Object_JsonContract_JsonProperty_JsonContainerContract_JsonProperty_0;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeMethodInfoPtr_HasCreatorParameter_Private_Boolean_JsonContainerContract_JsonProperty_0;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeMethodInfoPtr_WriteReferenceIdProperty_Private_Void_JsonWriter_Type_Object_0;

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeMethodInfoPtr_WriteTypeProperty_Private_Void_JsonWriter_Type_0;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeMethodInfoPtr_HasFlag_Private_Boolean_DefaultValueHandling_DefaultValueHandling_0;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeMethodInfoPtr_HasFlag_Private_Boolean_PreserveReferencesHandling_PreserveReferencesHandling_0;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeMethodInfoPtr_HasFlag_Private_Boolean_TypeNameHandling_TypeNameHandling_0;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeMethodInfoPtr_SerializeConvertable_Private_Void_JsonWriter_JsonConverter_Object_JsonContract_JsonContainerContract_JsonProperty_0;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeMethodInfoPtr_SerializeList_Private_Void_JsonWriter_IEnumerable_JsonArrayContract_JsonProperty_JsonContainerContract_JsonProperty_0;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeMethodInfoPtr_SerializeMultidimensionalArray_Private_Void_JsonWriter_Array_JsonArrayContract_JsonProperty_JsonContainerContract_JsonProperty_0;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeMethodInfoPtr_SerializeMultidimensionalArray_Private_Void_JsonWriter_Array_JsonArrayContract_JsonProperty_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeMethodInfoPtr_WriteStartArray_Private_Boolean_JsonWriter_Object_JsonArrayContract_JsonProperty_JsonContainerContract_JsonProperty_0;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeMethodInfoPtr_SerializeISerializable_Private_Void_JsonWriter_ISerializable_JsonISerializableContract_JsonProperty_JsonContainerContract_JsonProperty_0;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeMethodInfoPtr_SerializeDynamic_Private_Void_JsonWriter_IDynamicMetaObjectProvider_JsonDynamicContract_JsonProperty_JsonContainerContract_JsonProperty_0;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeMethodInfoPtr_ShouldWriteDynamicProperty_Private_Boolean_Object_0;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeMethodInfoPtr_ShouldWriteType_Private_Boolean_TypeNameHandling_JsonContract_JsonProperty_JsonContainerContract_JsonProperty_0;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeMethodInfoPtr_SerializeDictionary_Private_Void_JsonWriter_IDictionary_JsonDictionaryContract_JsonProperty_JsonContainerContract_JsonProperty_0;

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyName_Private_String_JsonWriter_Object_JsonContract_byref_Boolean_0;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeMethodInfoPtr_HandleError_Private_Void_JsonWriter_Int32_0;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSerialize_Private_Boolean_JsonWriter_JsonProperty_Object_0;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeMethodInfoPtr_IsSpecified_Private_Boolean_JsonWriter_JsonProperty_Object_0;
	}
}

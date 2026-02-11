using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.ComponentModel;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000096 RID: 150
	public static class JsonTypeReflector : Object
	{
		// Token: 0x06000D07 RID: 3335 RVA: 0x0004E664 File Offset: 0x0004C864
		// Note: this type is marked as 'beforefieldinit'.
		static JsonTypeReflector()
		{
			Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "JsonTypeReflector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr);
			JsonTypeReflector.NativeFieldInfoPtr__dynamicCodeGeneration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, "_dynamicCodeGeneration");
			JsonTypeReflector.NativeFieldInfoPtr__fullyTrusted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, "_fullyTrusted");
			JsonTypeReflector.NativeFieldInfoPtr_IdPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, "IdPropertyName");
			JsonTypeReflector.NativeFieldInfoPtr_RefPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, "RefPropertyName");
			JsonTypeReflector.NativeFieldInfoPtr_TypePropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, "TypePropertyName");
			JsonTypeReflector.NativeFieldInfoPtr_ValuePropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, "ValuePropertyName");
			JsonTypeReflector.NativeFieldInfoPtr_ArrayValuesPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, "ArrayValuesPropertyName");
			JsonTypeReflector.NativeFieldInfoPtr_ShouldSerializePrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, "ShouldSerializePrefix");
			JsonTypeReflector.NativeFieldInfoPtr_SpecifiedPostfix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, "SpecifiedPostfix");
			JsonTypeReflector.NativeFieldInfoPtr_ConcurrentDictionaryTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, "ConcurrentDictionaryTypeName");
			JsonTypeReflector.NativeFieldInfoPtr_CreatorCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, "CreatorCache");
			JsonTypeReflector.NativeFieldInfoPtr_AssociatedMetadataTypesCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, "AssociatedMetadataTypesCache");
			JsonTypeReflector.NativeFieldInfoPtr__metadataTypeAttributeReflectionObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, "_metadataTypeAttributeReflectionObject");
			JsonTypeReflector.NativeMethodInfoPtr_GetCachedAttribute_Public_Static_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, 100665687);
			JsonTypeReflector.NativeMethodInfoPtr_CanTypeDescriptorConvertString_Public_Static_Boolean_Type_byref_TypeConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, 100665688);
			JsonTypeReflector.NativeMethodInfoPtr_GetDataContractAttribute_Public_Static_DataContractAttribute_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, 100665689);
			JsonTypeReflector.NativeMethodInfoPtr_GetDataMemberAttribute_Public_Static_DataMemberAttribute_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, 100665690);
			JsonTypeReflector.NativeMethodInfoPtr_GetObjectMemberSerialization_Public_Static_MemberSerialization_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, 100665691);
			JsonTypeReflector.NativeMethodInfoPtr_GetJsonConverter_Public_Static_JsonConverter_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, 100665692);
			JsonTypeReflector.NativeMethodInfoPtr_CreateJsonConverterInstance_Public_Static_JsonConverter_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, 100665693);
			JsonTypeReflector.NativeMethodInfoPtr_CreateNamingStrategyInstance_Public_Static_NamingStrategy_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, 100665694);
			JsonTypeReflector.NativeMethodInfoPtr_GetContainerNamingStrategy_Public_Static_NamingStrategy_JsonContainerAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, 100665695);
			JsonTypeReflector.NativeMethodInfoPtr_GetCreator_Private_Static_Func_2_Il2CppReferenceArray_1_Object_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, 100665696);
			JsonTypeReflector.NativeMethodInfoPtr_GetAssociatedMetadataType_Private_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, 100665697);
			JsonTypeReflector.NativeMethodInfoPtr_GetAssociateMetadataTypeFromAttribute_Private_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, 100665698);
			JsonTypeReflector.NativeMethodInfoPtr_GetAttribute_Private_Static_T_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, 100665699);
			JsonTypeReflector.NativeMethodInfoPtr_GetAttribute_Private_Static_T_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, 100665700);
			JsonTypeReflector.NativeMethodInfoPtr_IsNonSerializable_Public_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, 100665701);
			JsonTypeReflector.NativeMethodInfoPtr_IsSerializable_Public_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, 100665702);
			JsonTypeReflector.NativeMethodInfoPtr_GetAttribute_Public_Static_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, 100665703);
			JsonTypeReflector.NativeMethodInfoPtr_get_DynamicCodeGeneration_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, 100665704);
			JsonTypeReflector.NativeMethodInfoPtr_get_FullyTrusted_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, 100665705);
			JsonTypeReflector.NativeMethodInfoPtr_get_ReflectionDelegateFactory_Public_Static_get_ReflectionDelegateFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, 100665706);
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x0004E928 File Offset: 0x0004CB28
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 753206, RefRangeEnd = 753217, XrefRangeStart = 753202, XrefRangeEnd = 753206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetCachedAttribute<T>(Object attributeProvider) where T : Attribute
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeProvider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTypeReflector.MethodInfoStoreGeneric_GetCachedAttribute_Public_Static_T_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x0004E968 File Offset: 0x0004CB68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 753245, RefRangeEnd = 753247, XrefRangeStart = 753217, XrefRangeEnd = 753245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanTypeDescriptorConvertString(Type type, out TypeConverter typeConverter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(JsonTypeReflector.NativeMethodInfoPtr_CanTypeDescriptorConvertString_Public_Static_Boolean_Type_byref_TypeConverter_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			typeConverter = ((intPtr4 == 0) ? null : new TypeConverter(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x0004E9CC File Offset: 0x0004CBCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 753259, RefRangeEnd = 753262, XrefRangeStart = 753247, XrefRangeEnd = 753259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DataContractAttribute GetDataContractAttribute(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTypeReflector.NativeMethodInfoPtr_GetDataContractAttribute_Public_Static_DataContractAttribute_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataContractAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x0004EA10 File Offset: 0x0004CC10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 753292, RefRangeEnd = 753293, XrefRangeStart = 753262, XrefRangeEnd = 753292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTypeReflector.NativeMethodInfoPtr_GetDataMemberAttribute_Public_Static_DataMemberAttribute_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataMemberAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x0004EA54 File Offset: 0x0004CC54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 753313, RefRangeEnd = 753315, XrefRangeStart = 753293, XrefRangeEnd = 753313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreSerializableAttribute;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTypeReflector.NativeMethodInfoPtr_GetObjectMemberSerialization_Public_Static_MemberSerialization_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x0004EAA4 File Offset: 0x0004CCA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 753330, RefRangeEnd = 753332, XrefRangeStart = 753315, XrefRangeEnd = 753330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JsonConverter GetJsonConverter(Object attributeProvider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeProvider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTypeReflector.NativeMethodInfoPtr_GetJsonConverter_Public_Static_JsonConverter_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonConverter>(intPtr3) : null;
			}
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x0004EAE8 File Offset: 0x0004CCE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 753341, RefRangeEnd = 753343, XrefRangeStart = 753332, XrefRangeEnd = 753341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JsonConverter CreateJsonConverterInstance(Type converterType, Il2CppReferenceArray<Object> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(converterType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTypeReflector.NativeMethodInfoPtr_CreateJsonConverterInstance_Public_Static_JsonConverter_Type_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonConverter>(intPtr3) : null;
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x0004EB40 File Offset: 0x0004CD40
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 753352, RefRangeEnd = 753356, XrefRangeStart = 753343, XrefRangeEnd = 753352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NamingStrategy CreateNamingStrategyInstance(Type namingStrategyType, Il2CppReferenceArray<Object> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(namingStrategyType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTypeReflector.NativeMethodInfoPtr_CreateNamingStrategyInstance_Public_Static_NamingStrategy_Type_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NamingStrategy>(intPtr3) : null;
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x0004EB98 File Offset: 0x0004CD98
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 753373, RefRangeEnd = 753377, XrefRangeStart = 753356, XrefRangeEnd = 753373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NamingStrategy GetContainerNamingStrategy(JsonContainerAttribute containerAttribute)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(containerAttribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTypeReflector.NativeMethodInfoPtr_GetContainerNamingStrategy_Public_Static_NamingStrategy_JsonContainerAttribute_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NamingStrategy>(intPtr3) : null;
			}
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x0004EBDC File Offset: 0x0004CDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753377, XrefRangeEnd = 753401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<Il2CppReferenceArray<Object>, Object> GetCreator(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTypeReflector.NativeMethodInfoPtr_GetCreator_Private_Static_Func_2_Il2CppReferenceArray_1_Object_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Il2CppReferenceArray<Object>, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x0004EC20 File Offset: 0x0004CE20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 753409, RefRangeEnd = 753411, XrefRangeStart = 753401, XrefRangeEnd = 753409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetAssociatedMetadataType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTypeReflector.NativeMethodInfoPtr_GetAssociatedMetadataType_Private_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x0004EC64 File Offset: 0x0004CE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753411, XrefRangeEnd = 753443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetAssociateMetadataTypeFromAttribute(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTypeReflector.NativeMethodInfoPtr_GetAssociateMetadataTypeFromAttribute_Private_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x0004ECA8 File Offset: 0x0004CEA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 753463, RefRangeEnd = 753464, XrefRangeStart = 753443, XrefRangeEnd = 753463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetAttribute<T>(Type type) where T : Attribute
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTypeReflector.MethodInfoStoreGeneric_GetAttribute_Private_Static_T_Type_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x0004ECE8 File Offset: 0x0004CEE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 753495, RefRangeEnd = 753496, XrefRangeStart = 753464, XrefRangeEnd = 753495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetAttribute<T>(MemberInfo memberInfo) where T : Attribute
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTypeReflector.MethodInfoStoreGeneric_GetAttribute_Private_Static_T_MemberInfo_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x0004ED28 File Offset: 0x0004CF28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 753502, RefRangeEnd = 753503, XrefRangeStart = 753496, XrefRangeEnd = 753502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNonSerializable(Object provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTypeReflector.NativeMethodInfoPtr_IsNonSerializable_Public_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x0004ED6C File Offset: 0x0004CF6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 753509, RefRangeEnd = 753510, XrefRangeStart = 753503, XrefRangeEnd = 753509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSerializable(Object provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTypeReflector.NativeMethodInfoPtr_IsSerializable_Public_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x0004EDB0 File Offset: 0x0004CFB0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 753530, RefRangeEnd = 753542, XrefRangeStart = 753510, XrefRangeEnd = 753530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetAttribute<T>(Object provider) where T : Attribute
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTypeReflector.MethodInfoStoreGeneric_GetAttribute_Public_Static_T_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000D19 RID: 3353 RVA: 0x0004EDF0 File Offset: 0x0004CFF0
		public unsafe static bool DynamicCodeGeneration
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 753557, RefRangeEnd = 753558, XrefRangeStart = 753542, XrefRangeEnd = 753557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTypeReflector.NativeMethodInfoPtr_get_DynamicCodeGeneration_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000D1A RID: 3354 RVA: 0x0004EE20 File Offset: 0x0004D020
		public unsafe static bool FullyTrusted
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 753577, RefRangeEnd = 753579, XrefRangeStart = 753558, XrefRangeEnd = 753577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTypeReflector.NativeMethodInfoPtr_get_FullyTrusted_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000D1B RID: 3355 RVA: 0x0004EE50 File Offset: 0x0004D050
		public unsafe static ReflectionDelegateFactory ReflectionDelegateFactory
		{
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 753587, RefRangeEnd = 753625, XrefRangeStart = 753579, XrefRangeEnd = 753587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTypeReflector.NativeMethodInfoPtr_get_ReflectionDelegateFactory_Public_Static_get_ReflectionDelegateFactory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReflectionDelegateFactory>(intPtr3) : null;
			}
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x000063C0 File Offset: 0x000045C0
		public JsonTypeReflector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x0004EE84 File Offset: 0x0004D084
		// (set) Token: 0x06000D1E RID: 3358 RVA: 0x000063C9 File Offset: 0x000045C9
		public unsafe static Nullable<bool> _dynamicCodeGeneration
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(JsonTypeReflector.NativeFieldInfoPtr__dynamicCodeGeneration, intPtr);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonTypeReflector.NativeFieldInfoPtr__dynamicCodeGeneration, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x0004EEC0 File Offset: 0x0004D0C0
		// (set) Token: 0x06000D20 RID: 3360 RVA: 0x000063E0 File Offset: 0x000045E0
		public unsafe static Nullable<bool> _fullyTrusted
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(JsonTypeReflector.NativeFieldInfoPtr__fullyTrusted, intPtr);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonTypeReflector.NativeFieldInfoPtr__fullyTrusted, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000D21 RID: 3361 RVA: 0x0004EEFC File Offset: 0x0004D0FC
		// (set) Token: 0x06000D22 RID: 3362 RVA: 0x000063F7 File Offset: 0x000045F7
		public unsafe static string IdPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonTypeReflector.NativeFieldInfoPtr_IdPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonTypeReflector.NativeFieldInfoPtr_IdPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000D23 RID: 3363 RVA: 0x0004EF1C File Offset: 0x0004D11C
		// (set) Token: 0x06000D24 RID: 3364 RVA: 0x00006409 File Offset: 0x00004609
		public unsafe static string RefPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonTypeReflector.NativeFieldInfoPtr_RefPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonTypeReflector.NativeFieldInfoPtr_RefPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x0004EF3C File Offset: 0x0004D13C
		// (set) Token: 0x06000D26 RID: 3366 RVA: 0x0000641B File Offset: 0x0000461B
		public unsafe static string TypePropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonTypeReflector.NativeFieldInfoPtr_TypePropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonTypeReflector.NativeFieldInfoPtr_TypePropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000D27 RID: 3367 RVA: 0x0004EF5C File Offset: 0x0004D15C
		// (set) Token: 0x06000D28 RID: 3368 RVA: 0x0000642D File Offset: 0x0000462D
		public unsafe static string ValuePropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonTypeReflector.NativeFieldInfoPtr_ValuePropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonTypeReflector.NativeFieldInfoPtr_ValuePropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000D29 RID: 3369 RVA: 0x0004EF7C File Offset: 0x0004D17C
		// (set) Token: 0x06000D2A RID: 3370 RVA: 0x0000643F File Offset: 0x0000463F
		public unsafe static string ArrayValuesPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonTypeReflector.NativeFieldInfoPtr_ArrayValuesPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonTypeReflector.NativeFieldInfoPtr_ArrayValuesPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x0004EF9C File Offset: 0x0004D19C
		// (set) Token: 0x06000D2C RID: 3372 RVA: 0x00006451 File Offset: 0x00004651
		public unsafe static string ShouldSerializePrefix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonTypeReflector.NativeFieldInfoPtr_ShouldSerializePrefix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonTypeReflector.NativeFieldInfoPtr_ShouldSerializePrefix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000D2D RID: 3373 RVA: 0x0004EFBC File Offset: 0x0004D1BC
		// (set) Token: 0x06000D2E RID: 3374 RVA: 0x00006463 File Offset: 0x00004663
		public unsafe static string SpecifiedPostfix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonTypeReflector.NativeFieldInfoPtr_SpecifiedPostfix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonTypeReflector.NativeFieldInfoPtr_SpecifiedPostfix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x0004EFDC File Offset: 0x0004D1DC
		// (set) Token: 0x06000D30 RID: 3376 RVA: 0x00006475 File Offset: 0x00004675
		public unsafe static string ConcurrentDictionaryTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonTypeReflector.NativeFieldInfoPtr_ConcurrentDictionaryTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonTypeReflector.NativeFieldInfoPtr_ConcurrentDictionaryTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000D31 RID: 3377 RVA: 0x0004EFFC File Offset: 0x0004D1FC
		// (set) Token: 0x06000D32 RID: 3378 RVA: 0x00006487 File Offset: 0x00004687
		public unsafe static ThreadSafeStore<Type, Func<Il2CppReferenceArray<Object>, Object>> CreatorCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonTypeReflector.NativeFieldInfoPtr_CreatorCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadSafeStore<Type, Func<Il2CppReferenceArray<Object>, Object>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonTypeReflector.NativeFieldInfoPtr_CreatorCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000D33 RID: 3379 RVA: 0x0004F024 File Offset: 0x0004D224
		// (set) Token: 0x06000D34 RID: 3380 RVA: 0x00006499 File Offset: 0x00004699
		public unsafe static ThreadSafeStore<Type, Type> AssociatedMetadataTypesCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonTypeReflector.NativeFieldInfoPtr_AssociatedMetadataTypesCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadSafeStore<Type, Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonTypeReflector.NativeFieldInfoPtr_AssociatedMetadataTypesCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000D35 RID: 3381 RVA: 0x0004F04C File Offset: 0x0004D24C
		// (set) Token: 0x06000D36 RID: 3382 RVA: 0x000064AB File Offset: 0x000046AB
		public unsafe static ReflectionObject _metadataTypeAttributeReflectionObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonTypeReflector.NativeFieldInfoPtr__metadataTypeAttributeReflectionObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionObject>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonTypeReflector.NativeFieldInfoPtr__metadataTypeAttributeReflectionObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeFieldInfoPtr__dynamicCodeGeneration;

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeFieldInfoPtr__fullyTrusted;

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeFieldInfoPtr_IdPropertyName;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeFieldInfoPtr_RefPropertyName;

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeFieldInfoPtr_TypePropertyName;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeFieldInfoPtr_ValuePropertyName;

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeFieldInfoPtr_ArrayValuesPropertyName;

		// Token: 0x04000A9E RID: 2718
		private static readonly IntPtr NativeFieldInfoPtr_ShouldSerializePrefix;

		// Token: 0x04000A9F RID: 2719
		private static readonly IntPtr NativeFieldInfoPtr_SpecifiedPostfix;

		// Token: 0x04000AA0 RID: 2720
		private static readonly IntPtr NativeFieldInfoPtr_ConcurrentDictionaryTypeName;

		// Token: 0x04000AA1 RID: 2721
		private static readonly IntPtr NativeFieldInfoPtr_CreatorCache;

		// Token: 0x04000AA2 RID: 2722
		private static readonly IntPtr NativeFieldInfoPtr_AssociatedMetadataTypesCache;

		// Token: 0x04000AA3 RID: 2723
		private static readonly IntPtr NativeFieldInfoPtr__metadataTypeAttributeReflectionObject;

		// Token: 0x04000AA4 RID: 2724
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedAttribute_Public_Static_T_Object_0;

		// Token: 0x04000AA5 RID: 2725
		private static readonly IntPtr NativeMethodInfoPtr_CanTypeDescriptorConvertString_Public_Static_Boolean_Type_byref_TypeConverter_0;

		// Token: 0x04000AA6 RID: 2726
		private static readonly IntPtr NativeMethodInfoPtr_GetDataContractAttribute_Public_Static_DataContractAttribute_Type_0;

		// Token: 0x04000AA7 RID: 2727
		private static readonly IntPtr NativeMethodInfoPtr_GetDataMemberAttribute_Public_Static_DataMemberAttribute_MemberInfo_0;

		// Token: 0x04000AA8 RID: 2728
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectMemberSerialization_Public_Static_MemberSerialization_Type_Boolean_0;

		// Token: 0x04000AA9 RID: 2729
		private static readonly IntPtr NativeMethodInfoPtr_GetJsonConverter_Public_Static_JsonConverter_Object_0;

		// Token: 0x04000AAA RID: 2730
		private static readonly IntPtr NativeMethodInfoPtr_CreateJsonConverterInstance_Public_Static_JsonConverter_Type_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000AAB RID: 2731
		private static readonly IntPtr NativeMethodInfoPtr_CreateNamingStrategyInstance_Public_Static_NamingStrategy_Type_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000AAC RID: 2732
		private static readonly IntPtr NativeMethodInfoPtr_GetContainerNamingStrategy_Public_Static_NamingStrategy_JsonContainerAttribute_0;

		// Token: 0x04000AAD RID: 2733
		private static readonly IntPtr NativeMethodInfoPtr_GetCreator_Private_Static_Func_2_Il2CppReferenceArray_1_Object_Object_Type_0;

		// Token: 0x04000AAE RID: 2734
		private static readonly IntPtr NativeMethodInfoPtr_GetAssociatedMetadataType_Private_Static_Type_Type_0;

		// Token: 0x04000AAF RID: 2735
		private static readonly IntPtr NativeMethodInfoPtr_GetAssociateMetadataTypeFromAttribute_Private_Static_Type_Type_0;

		// Token: 0x04000AB0 RID: 2736
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Private_Static_T_Type_0;

		// Token: 0x04000AB1 RID: 2737
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Private_Static_T_MemberInfo_0;

		// Token: 0x04000AB2 RID: 2738
		private static readonly IntPtr NativeMethodInfoPtr_IsNonSerializable_Public_Static_Boolean_Object_0;

		// Token: 0x04000AB3 RID: 2739
		private static readonly IntPtr NativeMethodInfoPtr_IsSerializable_Public_Static_Boolean_Object_0;

		// Token: 0x04000AB4 RID: 2740
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Static_T_Object_0;

		// Token: 0x04000AB5 RID: 2741
		private static readonly IntPtr NativeMethodInfoPtr_get_DynamicCodeGeneration_Public_Static_get_Boolean_0;

		// Token: 0x04000AB6 RID: 2742
		private static readonly IntPtr NativeMethodInfoPtr_get_FullyTrusted_Public_Static_get_Boolean_0;

		// Token: 0x04000AB7 RID: 2743
		private static readonly IntPtr NativeMethodInfoPtr_get_ReflectionDelegateFactory_Public_Static_get_ReflectionDelegateFactory_0;

		// Token: 0x020001D4 RID: 468
		[ObfuscatedName("Newtonsoft.Json.Serialization.JsonTypeReflector+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001EBE RID: 7870 RVA: 0x0008D6B4 File Offset: 0x0008B8B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<JsonTypeReflector.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTypeReflector.__c>.NativeClassPtr);
				JsonTypeReflector.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTypeReflector.__c>.NativeClassPtr, "<>9");
				JsonTypeReflector.__c.NativeFieldInfoPtr___9__22_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTypeReflector.__c>.NativeClassPtr, "<>9__22_1");
				JsonTypeReflector.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTypeReflector.__c>.NativeClassPtr, 100665709);
				JsonTypeReflector.__c.NativeMethodInfoPtr__GetCreator_b__22_1_Internal_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTypeReflector.__c>.NativeClassPtr, 100665710);
			}

			// Token: 0x06001EBF RID: 7871 RVA: 0x0008D730 File Offset: 0x0008B930
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTypeReflector.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTypeReflector.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EC0 RID: 7872 RVA: 0x0008D76C File Offset: 0x0008B96C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753164, XrefRangeEnd = 753171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Type _GetCreator_b__22_1(Object param)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(param);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTypeReflector.__c.NativeMethodInfoPtr__GetCreator_b__22_1_Internal_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
			}

			// Token: 0x06001EC1 RID: 7873 RVA: 0x0000F311 File Offset: 0x0000D511
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008A0 RID: 2208
			// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x0008D7BC File Offset: 0x0008B9BC
			// (set) Token: 0x06001EC3 RID: 7875 RVA: 0x0000F31A File Offset: 0x0000D51A
			public unsafe static JsonTypeReflector.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JsonTypeReflector.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonTypeReflector.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JsonTypeReflector.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008A1 RID: 2209
			// (get) Token: 0x06001EC4 RID: 7876 RVA: 0x0008D7E4 File Offset: 0x0008B9E4
			// (set) Token: 0x06001EC5 RID: 7877 RVA: 0x0000F32C File Offset: 0x0000D52C
			public unsafe static Func<Object, Type> __9__22_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JsonTypeReflector.__c.NativeFieldInfoPtr___9__22_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, Type>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JsonTypeReflector.__c.NativeFieldInfoPtr___9__22_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400166A RID: 5738
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400166B RID: 5739
			private static readonly IntPtr NativeFieldInfoPtr___9__22_1;

			// Token: 0x0400166C RID: 5740
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400166D RID: 5741
			private static readonly IntPtr NativeMethodInfoPtr__GetCreator_b__22_1_Internal_Type_Object_0;
		}

		// Token: 0x020001D5 RID: 469
		[ObfuscatedName("Newtonsoft.Json.Serialization.JsonTypeReflector+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Object
		{
			// Token: 0x06001EC6 RID: 7878 RVA: 0x0008D80C File Offset: 0x0008BA0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<JsonTypeReflector.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonTypeReflector.__c__DisplayClass22_0>.NativeClassPtr);
				JsonTypeReflector.__c__DisplayClass22_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTypeReflector.__c__DisplayClass22_0>.NativeClassPtr, "type");
				JsonTypeReflector.__c__DisplayClass22_0.NativeFieldInfoPtr_defaultConstructor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonTypeReflector.__c__DisplayClass22_0>.NativeClassPtr, "defaultConstructor");
				JsonTypeReflector.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTypeReflector.__c__DisplayClass22_0>.NativeClassPtr, 100665711);
				JsonTypeReflector.__c__DisplayClass22_0.NativeMethodInfoPtr__GetCreator_b__0_Internal_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonTypeReflector.__c__DisplayClass22_0>.NativeClassPtr, 100665712);
			}

			// Token: 0x06001EC7 RID: 7879 RVA: 0x0008D888 File Offset: 0x0008BA88
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonTypeReflector.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTypeReflector.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EC8 RID: 7880 RVA: 0x0008D8C4 File Offset: 0x0008BAC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753171, XrefRangeEnd = 753202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _GetCreator_b__0(Il2CppReferenceArray<Object> parameters)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameters);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonTypeReflector.__c__DisplayClass22_0.NativeMethodInfoPtr__GetCreator_b__0_Internal_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001EC9 RID: 7881 RVA: 0x0000F33E File Offset: 0x0000D53E
			public __c__DisplayClass22_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008A2 RID: 2210
			// (get) Token: 0x06001ECA RID: 7882 RVA: 0x0008D914 File Offset: 0x0008BB14
			// (set) Token: 0x06001ECB RID: 7883 RVA: 0x0000F347 File Offset: 0x0000D547
			public unsafe Type type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTypeReflector.__c__DisplayClass22_0.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTypeReflector.__c__DisplayClass22_0.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008A3 RID: 2211
			// (get) Token: 0x06001ECC RID: 7884 RVA: 0x0008D944 File Offset: 0x0008BB44
			// (set) Token: 0x06001ECD RID: 7885 RVA: 0x0000F366 File Offset: 0x0000D566
			public unsafe Func<Object> defaultConstructor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTypeReflector.__c__DisplayClass22_0.NativeFieldInfoPtr_defaultConstructor);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonTypeReflector.__c__DisplayClass22_0.NativeFieldInfoPtr_defaultConstructor), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400166E RID: 5742
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x0400166F RID: 5743
			private static readonly IntPtr NativeFieldInfoPtr_defaultConstructor;

			// Token: 0x04001670 RID: 5744
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001671 RID: 5745
			private static readonly IntPtr NativeMethodInfoPtr__GetCreator_b__0_Internal_Object_Il2CppReferenceArray_1_Object_0;
		}

		// Token: 0x020001D6 RID: 470
		private sealed class MethodInfoStoreGeneric_GetCachedAttribute_Public_Static_T_Object_0<T>
		{
			// Token: 0x04001672 RID: 5746
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonTypeReflector.NativeMethodInfoPtr_GetCachedAttribute_Public_Static_T_Object_0, Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001D7 RID: 471
		private sealed class MethodInfoStoreGeneric_GetAttribute_Private_Static_T_Type_0<T>
		{
			// Token: 0x04001673 RID: 5747
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonTypeReflector.NativeMethodInfoPtr_GetAttribute_Private_Static_T_Type_0, Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001D8 RID: 472
		private sealed class MethodInfoStoreGeneric_GetAttribute_Private_Static_T_MemberInfo_0<T>
		{
			// Token: 0x04001674 RID: 5748
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonTypeReflector.NativeMethodInfoPtr_GetAttribute_Private_Static_T_MemberInfo_0, Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001D9 RID: 473
		private sealed class MethodInfoStoreGeneric_GetAttribute_Public_Static_T_Object_0<T>
		{
			// Token: 0x04001675 RID: 5749
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonTypeReflector.NativeMethodInfoPtr_GetAttribute_Public_Static_T_Object_0, Il2CppClassPointerStore<JsonTypeReflector>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

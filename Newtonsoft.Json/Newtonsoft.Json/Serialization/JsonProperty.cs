using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200008F RID: 143
	public class JsonProperty : Object
	{
		// Token: 0x06000BB6 RID: 2998 RVA: 0x000471A4 File Offset: 0x000453A4
		// Note: this type is marked as 'beforefieldinit'.
		static JsonProperty()
		{
			Il2CppClassPointerStore<JsonProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "JsonProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr);
			JsonProperty.NativeFieldInfoPtr__required = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "_required");
			JsonProperty.NativeFieldInfoPtr__hasExplicitDefaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "_hasExplicitDefaultValue");
			JsonProperty.NativeFieldInfoPtr__defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "_defaultValue");
			JsonProperty.NativeFieldInfoPtr__hasGeneratedDefaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "_hasGeneratedDefaultValue");
			JsonProperty.NativeFieldInfoPtr__propertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "_propertyName");
			JsonProperty.NativeFieldInfoPtr__skipPropertyNameEscape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "_skipPropertyNameEscape");
			JsonProperty.NativeFieldInfoPtr__propertyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "_propertyType");
			JsonProperty.NativeFieldInfoPtr__PropertyContract_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "<PropertyContract>k__BackingField");
			JsonProperty.NativeFieldInfoPtr__DeclaringType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "<DeclaringType>k__BackingField");
			JsonProperty.NativeFieldInfoPtr__Order_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "<Order>k__BackingField");
			JsonProperty.NativeFieldInfoPtr__UnderlyingName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "<UnderlyingName>k__BackingField");
			JsonProperty.NativeFieldInfoPtr__ValueProvider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "<ValueProvider>k__BackingField");
			JsonProperty.NativeFieldInfoPtr__AttributeProvider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "<AttributeProvider>k__BackingField");
			JsonProperty.NativeFieldInfoPtr__Converter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "<Converter>k__BackingField");
			JsonProperty.NativeFieldInfoPtr__Ignored_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "<Ignored>k__BackingField");
			JsonProperty.NativeFieldInfoPtr__Readable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "<Readable>k__BackingField");
			JsonProperty.NativeFieldInfoPtr__Writable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "<Writable>k__BackingField");
			JsonProperty.NativeFieldInfoPtr__HasMemberAttribute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "<HasMemberAttribute>k__BackingField");
			JsonProperty.NativeFieldInfoPtr__IsReference_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "<IsReference>k__BackingField");
			JsonProperty.NativeFieldInfoPtr__NullValueHandling_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "<NullValueHandling>k__BackingField");
			JsonProperty.NativeFieldInfoPtr__DefaultValueHandling_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "<DefaultValueHandling>k__BackingField");
			JsonProperty.NativeFieldInfoPtr__ReferenceLoopHandling_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "<ReferenceLoopHandling>k__BackingField");
			JsonProperty.NativeFieldInfoPtr__ObjectCreationHandling_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "<ObjectCreationHandling>k__BackingField");
			JsonProperty.NativeFieldInfoPtr__TypeNameHandling_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "<TypeNameHandling>k__BackingField");
			JsonProperty.NativeFieldInfoPtr__ShouldSerialize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "<ShouldSerialize>k__BackingField");
			JsonProperty.NativeFieldInfoPtr__ShouldDeserialize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "<ShouldDeserialize>k__BackingField");
			JsonProperty.NativeFieldInfoPtr__GetIsSpecified_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "<GetIsSpecified>k__BackingField");
			JsonProperty.NativeFieldInfoPtr__SetIsSpecified_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "<SetIsSpecified>k__BackingField");
			JsonProperty.NativeFieldInfoPtr__ItemConverter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "<ItemConverter>k__BackingField");
			JsonProperty.NativeFieldInfoPtr__ItemIsReference_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "<ItemIsReference>k__BackingField");
			JsonProperty.NativeFieldInfoPtr__ItemTypeNameHandling_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "<ItemTypeNameHandling>k__BackingField");
			JsonProperty.NativeFieldInfoPtr__ItemReferenceLoopHandling_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, "<ItemReferenceLoopHandling>k__BackingField");
			JsonProperty.NativeMethodInfoPtr_get_PropertyContract_Internal_get_JsonContract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665442);
			JsonProperty.NativeMethodInfoPtr_set_PropertyContract_Internal_set_Void_JsonContract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665443);
			JsonProperty.NativeMethodInfoPtr_get_PropertyName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665444);
			JsonProperty.NativeMethodInfoPtr_set_PropertyName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665445);
			JsonProperty.NativeMethodInfoPtr_get_DeclaringType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665446);
			JsonProperty.NativeMethodInfoPtr_set_DeclaringType_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665447);
			JsonProperty.NativeMethodInfoPtr_get_Order_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665448);
			JsonProperty.NativeMethodInfoPtr_set_Order_Public_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665449);
			JsonProperty.NativeMethodInfoPtr_get_UnderlyingName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665450);
			JsonProperty.NativeMethodInfoPtr_set_UnderlyingName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665451);
			JsonProperty.NativeMethodInfoPtr_get_ValueProvider_Public_get_IValueProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665452);
			JsonProperty.NativeMethodInfoPtr_set_ValueProvider_Public_set_Void_IValueProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665453);
			JsonProperty.NativeMethodInfoPtr_get_AttributeProvider_Public_get_IAttributeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665454);
			JsonProperty.NativeMethodInfoPtr_set_AttributeProvider_Public_set_Void_IAttributeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665455);
			JsonProperty.NativeMethodInfoPtr_get_PropertyType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665456);
			JsonProperty.NativeMethodInfoPtr_set_PropertyType_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665457);
			JsonProperty.NativeMethodInfoPtr_get_Converter_Public_get_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665458);
			JsonProperty.NativeMethodInfoPtr_set_Converter_Public_set_Void_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665459);
			JsonProperty.NativeMethodInfoPtr_get_MemberConverter_Public_get_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665460);
			JsonProperty.NativeMethodInfoPtr_set_MemberConverter_Public_set_Void_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665461);
			JsonProperty.NativeMethodInfoPtr_get_Ignored_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665462);
			JsonProperty.NativeMethodInfoPtr_set_Ignored_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665463);
			JsonProperty.NativeMethodInfoPtr_get_Readable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665464);
			JsonProperty.NativeMethodInfoPtr_set_Readable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665465);
			JsonProperty.NativeMethodInfoPtr_get_Writable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665466);
			JsonProperty.NativeMethodInfoPtr_set_Writable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665467);
			JsonProperty.NativeMethodInfoPtr_get_HasMemberAttribute_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665468);
			JsonProperty.NativeMethodInfoPtr_set_HasMemberAttribute_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665469);
			JsonProperty.NativeMethodInfoPtr_get_DefaultValue_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665470);
			JsonProperty.NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665471);
			JsonProperty.NativeMethodInfoPtr_GetResolvedDefaultValue_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665472);
			JsonProperty.NativeMethodInfoPtr_get_Required_Public_get_Required_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665473);
			JsonProperty.NativeMethodInfoPtr_set_Required_Public_set_Void_Required_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665474);
			JsonProperty.NativeMethodInfoPtr_get_IsRequiredSpecified_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665475);
			JsonProperty.NativeMethodInfoPtr_get_IsReference_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665476);
			JsonProperty.NativeMethodInfoPtr_set_IsReference_Public_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665477);
			JsonProperty.NativeMethodInfoPtr_get_NullValueHandling_Public_get_Nullable_1_NullValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665478);
			JsonProperty.NativeMethodInfoPtr_set_NullValueHandling_Public_set_Void_Nullable_1_NullValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665479);
			JsonProperty.NativeMethodInfoPtr_get_DefaultValueHandling_Public_get_Nullable_1_DefaultValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665480);
			JsonProperty.NativeMethodInfoPtr_set_DefaultValueHandling_Public_set_Void_Nullable_1_DefaultValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665481);
			JsonProperty.NativeMethodInfoPtr_get_ReferenceLoopHandling_Public_get_Nullable_1_ReferenceLoopHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665482);
			JsonProperty.NativeMethodInfoPtr_set_ReferenceLoopHandling_Public_set_Void_Nullable_1_ReferenceLoopHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665483);
			JsonProperty.NativeMethodInfoPtr_get_ObjectCreationHandling_Public_get_Nullable_1_ObjectCreationHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665484);
			JsonProperty.NativeMethodInfoPtr_set_ObjectCreationHandling_Public_set_Void_Nullable_1_ObjectCreationHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665485);
			JsonProperty.NativeMethodInfoPtr_get_TypeNameHandling_Public_get_Nullable_1_TypeNameHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665486);
			JsonProperty.NativeMethodInfoPtr_set_TypeNameHandling_Public_set_Void_Nullable_1_TypeNameHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665487);
			JsonProperty.NativeMethodInfoPtr_get_ShouldSerialize_Public_get_Predicate_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665488);
			JsonProperty.NativeMethodInfoPtr_set_ShouldSerialize_Public_set_Void_Predicate_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665489);
			JsonProperty.NativeMethodInfoPtr_get_ShouldDeserialize_Public_get_Predicate_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665490);
			JsonProperty.NativeMethodInfoPtr_set_ShouldDeserialize_Public_set_Void_Predicate_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665491);
			JsonProperty.NativeMethodInfoPtr_get_GetIsSpecified_Public_get_Predicate_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665492);
			JsonProperty.NativeMethodInfoPtr_set_GetIsSpecified_Public_set_Void_Predicate_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665493);
			JsonProperty.NativeMethodInfoPtr_get_SetIsSpecified_Public_get_Action_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665494);
			JsonProperty.NativeMethodInfoPtr_set_SetIsSpecified_Public_set_Void_Action_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665495);
			JsonProperty.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665496);
			JsonProperty.NativeMethodInfoPtr_get_ItemConverter_Public_get_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665497);
			JsonProperty.NativeMethodInfoPtr_set_ItemConverter_Public_set_Void_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665498);
			JsonProperty.NativeMethodInfoPtr_get_ItemIsReference_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665499);
			JsonProperty.NativeMethodInfoPtr_set_ItemIsReference_Public_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665500);
			JsonProperty.NativeMethodInfoPtr_get_ItemTypeNameHandling_Public_get_Nullable_1_TypeNameHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665501);
			JsonProperty.NativeMethodInfoPtr_set_ItemTypeNameHandling_Public_set_Void_Nullable_1_TypeNameHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665502);
			JsonProperty.NativeMethodInfoPtr_get_ItemReferenceLoopHandling_Public_get_Nullable_1_ReferenceLoopHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665503);
			JsonProperty.NativeMethodInfoPtr_set_ItemReferenceLoopHandling_Public_set_Void_Nullable_1_ReferenceLoopHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665504);
			JsonProperty.NativeMethodInfoPtr_WritePropertyName_Internal_Void_JsonWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665505);
			JsonProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr, 100665506);
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x00047968 File Offset: 0x00045B68
		// (set) Token: 0x06000BB8 RID: 3000 RVA: 0x000479A8 File Offset: 0x00045BA8
		public unsafe JsonContract PropertyContract
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_PropertyContract_Internal_get_JsonContract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonContract>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_PropertyContract_Internal_set_Void_JsonContract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x000479EC File Offset: 0x00045BEC
		// (set) Token: 0x06000BBA RID: 3002 RVA: 0x00047A24 File Offset: 0x00045C24
		public unsafe string PropertyName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_PropertyName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 750014, RefRangeEnd = 750017, XrefRangeStart = 750008, XrefRangeEnd = 750014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_PropertyName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x00047A68 File Offset: 0x00045C68
		// (set) Token: 0x06000BBC RID: 3004 RVA: 0x00047AA8 File Offset: 0x00045CA8
		public unsafe Type DeclaringType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_DeclaringType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_DeclaringType_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x00047AEC File Offset: 0x00045CEC
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x00047B24 File Offset: 0x00045D24
		public unsafe Nullable<int> Order
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_Order_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_Order_Public_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x00047B6C File Offset: 0x00045D6C
		// (set) Token: 0x06000BC0 RID: 3008 RVA: 0x00047BA4 File Offset: 0x00045DA4
		public unsafe string UnderlyingName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_UnderlyingName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_UnderlyingName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x00047BE8 File Offset: 0x00045DE8
		// (set) Token: 0x06000BC2 RID: 3010 RVA: 0x00047C28 File Offset: 0x00045E28
		public unsafe IValueProvider ValueProvider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_ValueProvider_Public_get_IValueProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IValueProvider>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_ValueProvider_Public_set_Void_IValueProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x00047C6C File Offset: 0x00045E6C
		// (set) Token: 0x06000BC4 RID: 3012 RVA: 0x00047CAC File Offset: 0x00045EAC
		public unsafe IAttributeProvider AttributeProvider
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_AttributeProvider_Public_get_IAttributeProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttributeProvider>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_AttributeProvider_Public_set_Void_IAttributeProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x00047CF0 File Offset: 0x00045EF0
		// (set) Token: 0x06000BC6 RID: 3014 RVA: 0x00047D30 File Offset: 0x00045F30
		public unsafe Type PropertyType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_PropertyType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 750022, RefRangeEnd = 750024, XrefRangeStart = 750017, XrefRangeEnd = 750022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_PropertyType_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x00047D74 File Offset: 0x00045F74
		// (set) Token: 0x06000BC8 RID: 3016 RVA: 0x00047DB4 File Offset: 0x00045FB4
		public unsafe JsonConverter Converter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_Converter_Public_get_JsonConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonConverter>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_Converter_Public_set_Void_JsonConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x00047DF8 File Offset: 0x00045FF8
		// (set) Token: 0x06000BCA RID: 3018 RVA: 0x00047E38 File Offset: 0x00046038
		public unsafe JsonConverter MemberConverter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_MemberConverter_Public_get_JsonConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonConverter>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_MemberConverter_Public_set_Void_JsonConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x00047E7C File Offset: 0x0004607C
		// (set) Token: 0x06000BCC RID: 3020 RVA: 0x00047EB8 File Offset: 0x000460B8
		public unsafe bool Ignored
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_Ignored_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_Ignored_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x00047EF8 File Offset: 0x000460F8
		// (set) Token: 0x06000BCE RID: 3022 RVA: 0x00047F34 File Offset: 0x00046134
		public unsafe bool Readable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_Readable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_Readable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x00047F74 File Offset: 0x00046174
		// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x00047FB0 File Offset: 0x000461B0
		public unsafe bool Writable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_Writable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_Writable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x00047FF0 File Offset: 0x000461F0
		// (set) Token: 0x06000BD2 RID: 3026 RVA: 0x0004802C File Offset: 0x0004622C
		public unsafe bool HasMemberAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_HasMemberAttribute_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_HasMemberAttribute_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x0004806C File Offset: 0x0004626C
		// (set) Token: 0x06000BD4 RID: 3028 RVA: 0x000480AC File Offset: 0x000462AC
		public unsafe Object DefaultValue
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 750024, RefRangeEnd = 750026, XrefRangeStart = 750024, XrefRangeEnd = 750024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_DefaultValue_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750026, XrefRangeEnd = 750027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x000480F0 File Offset: 0x000462F0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 750036, RefRangeEnd = 750042, XrefRangeStart = 750027, XrefRangeEnd = 750036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetResolvedDefaultValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_GetResolvedDefaultValue_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x00048130 File Offset: 0x00046330
		// (set) Token: 0x06000BD7 RID: 3031 RVA: 0x0004816C File Offset: 0x0004636C
		public unsafe Required Required
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 750043, RefRangeEnd = 750044, XrefRangeStart = 750042, XrefRangeEnd = 750043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_Required_Public_get_Required_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750044, XrefRangeEnd = 750047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_Required_Public_set_Void_Required_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x000481AC File Offset: 0x000463AC
		public unsafe bool IsRequiredSpecified
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750047, XrefRangeEnd = 750048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_IsRequiredSpecified_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x000481E8 File Offset: 0x000463E8
		// (set) Token: 0x06000BDA RID: 3034 RVA: 0x00048220 File Offset: 0x00046420
		public unsafe Nullable<bool> IsReference
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_IsReference_Public_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_IsReference_Public_set_Void_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x00048268 File Offset: 0x00046468
		// (set) Token: 0x06000BDC RID: 3036 RVA: 0x000482A0 File Offset: 0x000464A0
		public unsafe Nullable<NullValueHandling> NullValueHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_NullValueHandling_Public_get_Nullable_1_NullValueHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<NullValueHandling>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_NullValueHandling_Public_set_Void_Nullable_1_NullValueHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x000482E8 File Offset: 0x000464E8
		// (set) Token: 0x06000BDE RID: 3038 RVA: 0x00048320 File Offset: 0x00046520
		public unsafe Nullable<DefaultValueHandling> DefaultValueHandling
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_DefaultValueHandling_Public_get_Nullable_1_DefaultValueHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<DefaultValueHandling>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_DefaultValueHandling_Public_set_Void_Nullable_1_DefaultValueHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x00048368 File Offset: 0x00046568
		// (set) Token: 0x06000BE0 RID: 3040 RVA: 0x000483A0 File Offset: 0x000465A0
		public unsafe Nullable<ReferenceLoopHandling> ReferenceLoopHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_ReferenceLoopHandling_Public_get_Nullable_1_ReferenceLoopHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<ReferenceLoopHandling>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_ReferenceLoopHandling_Public_set_Void_Nullable_1_ReferenceLoopHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x000483E8 File Offset: 0x000465E8
		// (set) Token: 0x06000BE2 RID: 3042 RVA: 0x00048420 File Offset: 0x00046620
		public unsafe Nullable<ObjectCreationHandling> ObjectCreationHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_ObjectCreationHandling_Public_get_Nullable_1_ObjectCreationHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<ObjectCreationHandling>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_ObjectCreationHandling_Public_set_Void_Nullable_1_ObjectCreationHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x00048468 File Offset: 0x00046668
		// (set) Token: 0x06000BE4 RID: 3044 RVA: 0x000484A0 File Offset: 0x000466A0
		public unsafe Nullable<TypeNameHandling> TypeNameHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_TypeNameHandling_Public_get_Nullable_1_TypeNameHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<TypeNameHandling>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_TypeNameHandling_Public_set_Void_Nullable_1_TypeNameHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x000484E8 File Offset: 0x000466E8
		// (set) Token: 0x06000BE6 RID: 3046 RVA: 0x00048528 File Offset: 0x00046728
		public unsafe Predicate<Object> ShouldSerialize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_ShouldSerialize_Public_get_Predicate_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Predicate<Object>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_ShouldSerialize_Public_set_Void_Predicate_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x0004856C File Offset: 0x0004676C
		// (set) Token: 0x06000BE8 RID: 3048 RVA: 0x000485AC File Offset: 0x000467AC
		public unsafe Predicate<Object> ShouldDeserialize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_ShouldDeserialize_Public_get_Predicate_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Predicate<Object>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_ShouldDeserialize_Public_set_Void_Predicate_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x000485F0 File Offset: 0x000467F0
		// (set) Token: 0x06000BEA RID: 3050 RVA: 0x00048630 File Offset: 0x00046830
		public unsafe Predicate<Object> GetIsSpecified
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_GetIsSpecified_Public_get_Predicate_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Predicate<Object>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_GetIsSpecified_Public_set_Void_Predicate_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000BEB RID: 3051 RVA: 0x00048674 File Offset: 0x00046874
		// (set) Token: 0x06000BEC RID: 3052 RVA: 0x000486B4 File Offset: 0x000468B4
		public unsafe Action<Object, Object> SetIsSpecified
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_SetIsSpecified_Public_get_Action_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<Object, Object>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_SetIsSpecified_Public_set_Void_Action_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x000486F8 File Offset: 0x000468F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 750048, XrefRangeEnd = 750050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonProperty.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x0004873C File Offset: 0x0004693C
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x0004877C File Offset: 0x0004697C
		public unsafe JsonConverter ItemConverter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_ItemConverter_Public_get_JsonConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonConverter>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_ItemConverter_Public_set_Void_JsonConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x000487C0 File Offset: 0x000469C0
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x000487F8 File Offset: 0x000469F8
		public unsafe Nullable<bool> ItemIsReference
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_ItemIsReference_Public_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_ItemIsReference_Public_set_Void_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x00048840 File Offset: 0x00046A40
		// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x00048878 File Offset: 0x00046A78
		public unsafe Nullable<TypeNameHandling> ItemTypeNameHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_ItemTypeNameHandling_Public_get_Nullable_1_TypeNameHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<TypeNameHandling>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_ItemTypeNameHandling_Public_set_Void_Nullable_1_TypeNameHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x000488C0 File Offset: 0x00046AC0
		// (set) Token: 0x06000BF5 RID: 3061 RVA: 0x000488F8 File Offset: 0x00046AF8
		public unsafe Nullable<ReferenceLoopHandling> ItemReferenceLoopHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_get_ItemReferenceLoopHandling_Public_get_Nullable_1_ReferenceLoopHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<ReferenceLoopHandling>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_set_ItemReferenceLoopHandling_Public_set_Void_Nullable_1_ReferenceLoopHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00048940 File Offset: 0x00046B40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 750051, RefRangeEnd = 750054, XrefRangeStart = 750050, XrefRangeEnd = 750051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WritePropertyName(JsonWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr_WritePropertyName_Internal_Void_JsonWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00048984 File Offset: 0x00046B84
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonProperty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonProperty>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00005D50 File Offset: 0x00003F50
		public JsonProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x000489C0 File Offset: 0x00046BC0
		// (set) Token: 0x06000BFA RID: 3066 RVA: 0x00005D59 File Offset: 0x00003F59
		public Nullable<Required> _required
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__required);
				return new Nullable<Required>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Required>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__required), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Required>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000BFB RID: 3067 RVA: 0x000489F0 File Offset: 0x00046BF0
		// (set) Token: 0x06000BFC RID: 3068 RVA: 0x00005D87 File Offset: 0x00003F87
		public unsafe bool _hasExplicitDefaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__hasExplicitDefaultValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__hasExplicitDefaultValue)) = value;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x00048A18 File Offset: 0x00046C18
		// (set) Token: 0x06000BFE RID: 3070 RVA: 0x00005DA2 File Offset: 0x00003FA2
		public unsafe Object _defaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__defaultValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__defaultValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x00048A48 File Offset: 0x00046C48
		// (set) Token: 0x06000C00 RID: 3072 RVA: 0x00005DC1 File Offset: 0x00003FC1
		public unsafe bool _hasGeneratedDefaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__hasGeneratedDefaultValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__hasGeneratedDefaultValue)) = value;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000C01 RID: 3073 RVA: 0x00048A70 File Offset: 0x00046C70
		// (set) Token: 0x06000C02 RID: 3074 RVA: 0x00005DDC File Offset: 0x00003FDC
		public unsafe string _propertyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__propertyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__propertyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000C03 RID: 3075 RVA: 0x00048A98 File Offset: 0x00046C98
		// (set) Token: 0x06000C04 RID: 3076 RVA: 0x00005DFB File Offset: 0x00003FFB
		public unsafe bool _skipPropertyNameEscape
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__skipPropertyNameEscape);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__skipPropertyNameEscape)) = value;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000C05 RID: 3077 RVA: 0x00048AC0 File Offset: 0x00046CC0
		// (set) Token: 0x06000C06 RID: 3078 RVA: 0x00005E16 File Offset: 0x00004016
		public unsafe Type _propertyType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__propertyType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__propertyType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000C07 RID: 3079 RVA: 0x00048AF0 File Offset: 0x00046CF0
		// (set) Token: 0x06000C08 RID: 3080 RVA: 0x00005E35 File Offset: 0x00004035
		public unsafe JsonContract _PropertyContract_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__PropertyContract_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonContract>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__PropertyContract_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000C09 RID: 3081 RVA: 0x00048B20 File Offset: 0x00046D20
		// (set) Token: 0x06000C0A RID: 3082 RVA: 0x00005E54 File Offset: 0x00004054
		public unsafe Type _DeclaringType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__DeclaringType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__DeclaringType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000C0B RID: 3083 RVA: 0x00048B50 File Offset: 0x00046D50
		// (set) Token: 0x06000C0C RID: 3084 RVA: 0x00005E73 File Offset: 0x00004073
		public Nullable<int> _Order_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__Order_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__Order_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x00048B80 File Offset: 0x00046D80
		// (set) Token: 0x06000C0E RID: 3086 RVA: 0x00005EA1 File Offset: 0x000040A1
		public unsafe string _UnderlyingName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__UnderlyingName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__UnderlyingName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x00048BA8 File Offset: 0x00046DA8
		// (set) Token: 0x06000C10 RID: 3088 RVA: 0x00005EC0 File Offset: 0x000040C0
		public unsafe IValueProvider _ValueProvider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__ValueProvider_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IValueProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__ValueProvider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x00048BD8 File Offset: 0x00046DD8
		// (set) Token: 0x06000C12 RID: 3090 RVA: 0x00005EDF File Offset: 0x000040DF
		public unsafe IAttributeProvider _AttributeProvider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__AttributeProvider_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttributeProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__AttributeProvider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000C13 RID: 3091 RVA: 0x00048C08 File Offset: 0x00046E08
		// (set) Token: 0x06000C14 RID: 3092 RVA: 0x00005EFE File Offset: 0x000040FE
		public unsafe JsonConverter _Converter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__Converter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonConverter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__Converter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x00048C38 File Offset: 0x00046E38
		// (set) Token: 0x06000C16 RID: 3094 RVA: 0x00005F1D File Offset: 0x0000411D
		public unsafe bool _Ignored_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__Ignored_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__Ignored_k__BackingField)) = value;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x00048C60 File Offset: 0x00046E60
		// (set) Token: 0x06000C18 RID: 3096 RVA: 0x00005F38 File Offset: 0x00004138
		public unsafe bool _Readable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__Readable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__Readable_k__BackingField)) = value;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x00048C88 File Offset: 0x00046E88
		// (set) Token: 0x06000C1A RID: 3098 RVA: 0x00005F53 File Offset: 0x00004153
		public unsafe bool _Writable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__Writable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__Writable_k__BackingField)) = value;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x00048CB0 File Offset: 0x00046EB0
		// (set) Token: 0x06000C1C RID: 3100 RVA: 0x00005F6E File Offset: 0x0000416E
		public unsafe bool _HasMemberAttribute_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__HasMemberAttribute_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__HasMemberAttribute_k__BackingField)) = value;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x00048CD8 File Offset: 0x00046ED8
		// (set) Token: 0x06000C1E RID: 3102 RVA: 0x00005F89 File Offset: 0x00004189
		public Nullable<bool> _IsReference_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__IsReference_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__IsReference_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x00048D08 File Offset: 0x00046F08
		// (set) Token: 0x06000C20 RID: 3104 RVA: 0x00005FB7 File Offset: 0x000041B7
		public Nullable<NullValueHandling> _NullValueHandling_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__NullValueHandling_k__BackingField);
				return new Nullable<NullValueHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Newtonsoft.Json.NullValueHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__NullValueHandling_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Newtonsoft.Json.NullValueHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000C21 RID: 3105 RVA: 0x00048D38 File Offset: 0x00046F38
		// (set) Token: 0x06000C22 RID: 3106 RVA: 0x00005FE5 File Offset: 0x000041E5
		public Nullable<DefaultValueHandling> _DefaultValueHandling_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__DefaultValueHandling_k__BackingField);
				return new Nullable<DefaultValueHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Newtonsoft.Json.DefaultValueHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__DefaultValueHandling_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Newtonsoft.Json.DefaultValueHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x00048D68 File Offset: 0x00046F68
		// (set) Token: 0x06000C24 RID: 3108 RVA: 0x00006013 File Offset: 0x00004213
		public Nullable<ReferenceLoopHandling> _ReferenceLoopHandling_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__ReferenceLoopHandling_k__BackingField);
				return new Nullable<ReferenceLoopHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Newtonsoft.Json.ReferenceLoopHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__ReferenceLoopHandling_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Newtonsoft.Json.ReferenceLoopHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x00048D98 File Offset: 0x00046F98
		// (set) Token: 0x06000C26 RID: 3110 RVA: 0x00006041 File Offset: 0x00004241
		public Nullable<ObjectCreationHandling> _ObjectCreationHandling_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__ObjectCreationHandling_k__BackingField);
				return new Nullable<ObjectCreationHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Newtonsoft.Json.ObjectCreationHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__ObjectCreationHandling_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Newtonsoft.Json.ObjectCreationHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x00048DC8 File Offset: 0x00046FC8
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x0000606F File Offset: 0x0000426F
		public Nullable<TypeNameHandling> _TypeNameHandling_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__TypeNameHandling_k__BackingField);
				return new Nullable<TypeNameHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Newtonsoft.Json.TypeNameHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__TypeNameHandling_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Newtonsoft.Json.TypeNameHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x00048DF8 File Offset: 0x00046FF8
		// (set) Token: 0x06000C2A RID: 3114 RVA: 0x0000609D File Offset: 0x0000429D
		public unsafe Predicate<Object> _ShouldSerialize_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__ShouldSerialize_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__ShouldSerialize_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x00048E28 File Offset: 0x00047028
		// (set) Token: 0x06000C2C RID: 3116 RVA: 0x000060BC File Offset: 0x000042BC
		public unsafe Predicate<Object> _ShouldDeserialize_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__ShouldDeserialize_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__ShouldDeserialize_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x00048E58 File Offset: 0x00047058
		// (set) Token: 0x06000C2E RID: 3118 RVA: 0x000060DB File Offset: 0x000042DB
		public unsafe Predicate<Object> _GetIsSpecified_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__GetIsSpecified_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__GetIsSpecified_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x00048E88 File Offset: 0x00047088
		// (set) Token: 0x06000C30 RID: 3120 RVA: 0x000060FA File Offset: 0x000042FA
		public unsafe Action<Object, Object> _SetIsSpecified_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__SetIsSpecified_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__SetIsSpecified_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x00048EB8 File Offset: 0x000470B8
		// (set) Token: 0x06000C32 RID: 3122 RVA: 0x00006119 File Offset: 0x00004319
		public unsafe JsonConverter _ItemConverter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__ItemConverter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonConverter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__ItemConverter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x00048EE8 File Offset: 0x000470E8
		// (set) Token: 0x06000C34 RID: 3124 RVA: 0x00006138 File Offset: 0x00004338
		public Nullable<bool> _ItemIsReference_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__ItemIsReference_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__ItemIsReference_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x00048F18 File Offset: 0x00047118
		// (set) Token: 0x06000C36 RID: 3126 RVA: 0x00006166 File Offset: 0x00004366
		public Nullable<TypeNameHandling> _ItemTypeNameHandling_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__ItemTypeNameHandling_k__BackingField);
				return new Nullable<TypeNameHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Newtonsoft.Json.TypeNameHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__ItemTypeNameHandling_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Newtonsoft.Json.TypeNameHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x00048F48 File Offset: 0x00047148
		// (set) Token: 0x06000C38 RID: 3128 RVA: 0x00006194 File Offset: 0x00004394
		public Nullable<ReferenceLoopHandling> _ItemReferenceLoopHandling_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__ItemReferenceLoopHandling_k__BackingField);
				return new Nullable<ReferenceLoopHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Newtonsoft.Json.ReferenceLoopHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonProperty.NativeFieldInfoPtr__ItemReferenceLoopHandling_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Newtonsoft.Json.ReferenceLoopHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000981 RID: 2433
		private static readonly IntPtr NativeFieldInfoPtr__required;

		// Token: 0x04000982 RID: 2434
		private static readonly IntPtr NativeFieldInfoPtr__hasExplicitDefaultValue;

		// Token: 0x04000983 RID: 2435
		private static readonly IntPtr NativeFieldInfoPtr__defaultValue;

		// Token: 0x04000984 RID: 2436
		private static readonly IntPtr NativeFieldInfoPtr__hasGeneratedDefaultValue;

		// Token: 0x04000985 RID: 2437
		private static readonly IntPtr NativeFieldInfoPtr__propertyName;

		// Token: 0x04000986 RID: 2438
		private static readonly IntPtr NativeFieldInfoPtr__skipPropertyNameEscape;

		// Token: 0x04000987 RID: 2439
		private static readonly IntPtr NativeFieldInfoPtr__propertyType;

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeFieldInfoPtr__PropertyContract_k__BackingField;

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeFieldInfoPtr__DeclaringType_k__BackingField;

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeFieldInfoPtr__Order_k__BackingField;

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeFieldInfoPtr__UnderlyingName_k__BackingField;

		// Token: 0x0400098C RID: 2444
		private static readonly IntPtr NativeFieldInfoPtr__ValueProvider_k__BackingField;

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeFieldInfoPtr__AttributeProvider_k__BackingField;

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeFieldInfoPtr__Converter_k__BackingField;

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeFieldInfoPtr__Ignored_k__BackingField;

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeFieldInfoPtr__Readable_k__BackingField;

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeFieldInfoPtr__Writable_k__BackingField;

		// Token: 0x04000992 RID: 2450
		private static readonly IntPtr NativeFieldInfoPtr__HasMemberAttribute_k__BackingField;

		// Token: 0x04000993 RID: 2451
		private static readonly IntPtr NativeFieldInfoPtr__IsReference_k__BackingField;

		// Token: 0x04000994 RID: 2452
		private static readonly IntPtr NativeFieldInfoPtr__NullValueHandling_k__BackingField;

		// Token: 0x04000995 RID: 2453
		private static readonly IntPtr NativeFieldInfoPtr__DefaultValueHandling_k__BackingField;

		// Token: 0x04000996 RID: 2454
		private static readonly IntPtr NativeFieldInfoPtr__ReferenceLoopHandling_k__BackingField;

		// Token: 0x04000997 RID: 2455
		private static readonly IntPtr NativeFieldInfoPtr__ObjectCreationHandling_k__BackingField;

		// Token: 0x04000998 RID: 2456
		private static readonly IntPtr NativeFieldInfoPtr__TypeNameHandling_k__BackingField;

		// Token: 0x04000999 RID: 2457
		private static readonly IntPtr NativeFieldInfoPtr__ShouldSerialize_k__BackingField;

		// Token: 0x0400099A RID: 2458
		private static readonly IntPtr NativeFieldInfoPtr__ShouldDeserialize_k__BackingField;

		// Token: 0x0400099B RID: 2459
		private static readonly IntPtr NativeFieldInfoPtr__GetIsSpecified_k__BackingField;

		// Token: 0x0400099C RID: 2460
		private static readonly IntPtr NativeFieldInfoPtr__SetIsSpecified_k__BackingField;

		// Token: 0x0400099D RID: 2461
		private static readonly IntPtr NativeFieldInfoPtr__ItemConverter_k__BackingField;

		// Token: 0x0400099E RID: 2462
		private static readonly IntPtr NativeFieldInfoPtr__ItemIsReference_k__BackingField;

		// Token: 0x0400099F RID: 2463
		private static readonly IntPtr NativeFieldInfoPtr__ItemTypeNameHandling_k__BackingField;

		// Token: 0x040009A0 RID: 2464
		private static readonly IntPtr NativeFieldInfoPtr__ItemReferenceLoopHandling_k__BackingField;

		// Token: 0x040009A1 RID: 2465
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyContract_Internal_get_JsonContract_0;

		// Token: 0x040009A2 RID: 2466
		private static readonly IntPtr NativeMethodInfoPtr_set_PropertyContract_Internal_set_Void_JsonContract_0;

		// Token: 0x040009A3 RID: 2467
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyName_Public_get_String_0;

		// Token: 0x040009A4 RID: 2468
		private static readonly IntPtr NativeMethodInfoPtr_set_PropertyName_Public_set_Void_String_0;

		// Token: 0x040009A5 RID: 2469
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaringType_Public_get_Type_0;

		// Token: 0x040009A6 RID: 2470
		private static readonly IntPtr NativeMethodInfoPtr_set_DeclaringType_Public_set_Void_Type_0;

		// Token: 0x040009A7 RID: 2471
		private static readonly IntPtr NativeMethodInfoPtr_get_Order_Public_get_Nullable_1_Int32_0;

		// Token: 0x040009A8 RID: 2472
		private static readonly IntPtr NativeMethodInfoPtr_set_Order_Public_set_Void_Nullable_1_Int32_0;

		// Token: 0x040009A9 RID: 2473
		private static readonly IntPtr NativeMethodInfoPtr_get_UnderlyingName_Public_get_String_0;

		// Token: 0x040009AA RID: 2474
		private static readonly IntPtr NativeMethodInfoPtr_set_UnderlyingName_Public_set_Void_String_0;

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueProvider_Public_get_IValueProvider_0;

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeMethodInfoPtr_set_ValueProvider_Public_set_Void_IValueProvider_0;

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeProvider_Public_get_IAttributeProvider_0;

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeMethodInfoPtr_set_AttributeProvider_Public_set_Void_IAttributeProvider_0;

		// Token: 0x040009AF RID: 2479
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyType_Public_get_Type_0;

		// Token: 0x040009B0 RID: 2480
		private static readonly IntPtr NativeMethodInfoPtr_set_PropertyType_Public_set_Void_Type_0;

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeMethodInfoPtr_get_Converter_Public_get_JsonConverter_0;

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeMethodInfoPtr_set_Converter_Public_set_Void_JsonConverter_0;

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberConverter_Public_get_JsonConverter_0;

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeMethodInfoPtr_set_MemberConverter_Public_set_Void_JsonConverter_0;

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeMethodInfoPtr_get_Ignored_Public_get_Boolean_0;

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeMethodInfoPtr_set_Ignored_Public_set_Void_Boolean_0;

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeMethodInfoPtr_get_Readable_Public_get_Boolean_0;

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeMethodInfoPtr_set_Readable_Public_set_Void_Boolean_0;

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeMethodInfoPtr_get_Writable_Public_get_Boolean_0;

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeMethodInfoPtr_set_Writable_Public_set_Void_Boolean_0;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeMethodInfoPtr_get_HasMemberAttribute_Public_get_Boolean_0;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeMethodInfoPtr_set_HasMemberAttribute_Public_set_Void_Boolean_0;

		// Token: 0x040009BD RID: 2493
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValue_Public_get_Object_0;

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_Object_0;

		// Token: 0x040009BF RID: 2495
		private static readonly IntPtr NativeMethodInfoPtr_GetResolvedDefaultValue_Internal_Object_0;

		// Token: 0x040009C0 RID: 2496
		private static readonly IntPtr NativeMethodInfoPtr_get_Required_Public_get_Required_0;

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeMethodInfoPtr_set_Required_Public_set_Void_Required_0;

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRequiredSpecified_Public_get_Boolean_0;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReference_Public_get_Nullable_1_Boolean_0;

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeMethodInfoPtr_set_IsReference_Public_set_Void_Nullable_1_Boolean_0;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeMethodInfoPtr_get_NullValueHandling_Public_get_Nullable_1_NullValueHandling_0;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeMethodInfoPtr_set_NullValueHandling_Public_set_Void_Nullable_1_NullValueHandling_0;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValueHandling_Public_get_Nullable_1_DefaultValueHandling_0;

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultValueHandling_Public_set_Void_Nullable_1_DefaultValueHandling_0;

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeMethodInfoPtr_get_ReferenceLoopHandling_Public_get_Nullable_1_ReferenceLoopHandling_0;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeMethodInfoPtr_set_ReferenceLoopHandling_Public_set_Void_Nullable_1_ReferenceLoopHandling_0;

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectCreationHandling_Public_get_Nullable_1_ObjectCreationHandling_0;

		// Token: 0x040009CC RID: 2508
		private static readonly IntPtr NativeMethodInfoPtr_set_ObjectCreationHandling_Public_set_Void_Nullable_1_ObjectCreationHandling_0;

		// Token: 0x040009CD RID: 2509
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeNameHandling_Public_get_Nullable_1_TypeNameHandling_0;

		// Token: 0x040009CE RID: 2510
		private static readonly IntPtr NativeMethodInfoPtr_set_TypeNameHandling_Public_set_Void_Nullable_1_TypeNameHandling_0;

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSerialize_Public_get_Predicate_1_Object_0;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeMethodInfoPtr_set_ShouldSerialize_Public_set_Void_Predicate_1_Object_0;

		// Token: 0x040009D1 RID: 2513
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldDeserialize_Public_get_Predicate_1_Object_0;

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeMethodInfoPtr_set_ShouldDeserialize_Public_set_Void_Predicate_1_Object_0;

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeMethodInfoPtr_get_GetIsSpecified_Public_get_Predicate_1_Object_0;

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeMethodInfoPtr_set_GetIsSpecified_Public_set_Void_Predicate_1_Object_0;

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeMethodInfoPtr_get_SetIsSpecified_Public_get_Action_2_Object_Object_0;

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeMethodInfoPtr_set_SetIsSpecified_Public_set_Void_Action_2_Object_Object_0;

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemConverter_Public_get_JsonConverter_0;

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemConverter_Public_set_Void_JsonConverter_0;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemIsReference_Public_get_Nullable_1_Boolean_0;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemIsReference_Public_set_Void_Nullable_1_Boolean_0;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemTypeNameHandling_Public_get_Nullable_1_TypeNameHandling_0;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemTypeNameHandling_Public_set_Void_Nullable_1_TypeNameHandling_0;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemReferenceLoopHandling_Public_get_Nullable_1_ReferenceLoopHandling_0;

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemReferenceLoopHandling_Public_set_Void_Nullable_1_ReferenceLoopHandling_0;

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeMethodInfoPtr_WritePropertyName_Internal_Void_JsonWriter_0;

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

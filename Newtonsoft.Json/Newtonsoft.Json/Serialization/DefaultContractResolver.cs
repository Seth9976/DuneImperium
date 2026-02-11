using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000073 RID: 115
	public class DefaultContractResolver : Object
	{
		// Token: 0x060009AD RID: 2477 RVA: 0x0003F258 File Offset: 0x0003D458
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultContractResolver()
		{
			Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "DefaultContractResolver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr);
			DefaultContractResolver.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, "_instance");
			DefaultContractResolver.NativeFieldInfoPtr_BlacklistedTypeNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, "BlacklistedTypeNames");
			DefaultContractResolver.NativeFieldInfoPtr_BuiltInConverters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, "BuiltInConverters");
			DefaultContractResolver.NativeFieldInfoPtr__nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, "_nameTable");
			DefaultContractResolver.NativeFieldInfoPtr__contractCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, "_contractCache");
			DefaultContractResolver.NativeFieldInfoPtr__DefaultMembersSearchFlags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, "<DefaultMembersSearchFlags>k__BackingField");
			DefaultContractResolver.NativeFieldInfoPtr__SerializeCompilerGeneratedMembers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, "<SerializeCompilerGeneratedMembers>k__BackingField");
			DefaultContractResolver.NativeFieldInfoPtr__IgnoreSerializableInterface_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, "<IgnoreSerializableInterface>k__BackingField");
			DefaultContractResolver.NativeFieldInfoPtr__IgnoreSerializableAttribute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, "<IgnoreSerializableAttribute>k__BackingField");
			DefaultContractResolver.NativeFieldInfoPtr__IgnoreIsSpecifiedMembers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, "<IgnoreIsSpecifiedMembers>k__BackingField");
			DefaultContractResolver.NativeFieldInfoPtr__IgnoreShouldSerializeMembers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, "<IgnoreShouldSerializeMembers>k__BackingField");
			DefaultContractResolver.NativeFieldInfoPtr__NamingStrategy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, "<NamingStrategy>k__BackingField");
			DefaultContractResolver.NativeMethodInfoPtr_get_Instance_Internal_Static_get_IContractResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665149);
			DefaultContractResolver.NativeMethodInfoPtr_get_DynamicCodeGeneration_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665150);
			DefaultContractResolver.NativeMethodInfoPtr_get_DefaultMembersSearchFlags_Public_get_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665151);
			DefaultContractResolver.NativeMethodInfoPtr_set_DefaultMembersSearchFlags_Public_set_Void_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665152);
			DefaultContractResolver.NativeMethodInfoPtr_get_SerializeCompilerGeneratedMembers_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665153);
			DefaultContractResolver.NativeMethodInfoPtr_set_SerializeCompilerGeneratedMembers_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665154);
			DefaultContractResolver.NativeMethodInfoPtr_get_IgnoreSerializableInterface_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665155);
			DefaultContractResolver.NativeMethodInfoPtr_set_IgnoreSerializableInterface_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665156);
			DefaultContractResolver.NativeMethodInfoPtr_get_IgnoreSerializableAttribute_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665157);
			DefaultContractResolver.NativeMethodInfoPtr_set_IgnoreSerializableAttribute_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665158);
			DefaultContractResolver.NativeMethodInfoPtr_get_IgnoreIsSpecifiedMembers_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665159);
			DefaultContractResolver.NativeMethodInfoPtr_set_IgnoreIsSpecifiedMembers_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665160);
			DefaultContractResolver.NativeMethodInfoPtr_get_IgnoreShouldSerializeMembers_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665161);
			DefaultContractResolver.NativeMethodInfoPtr_set_IgnoreShouldSerializeMembers_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665162);
			DefaultContractResolver.NativeMethodInfoPtr_get_NamingStrategy_Public_get_NamingStrategy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665163);
			DefaultContractResolver.NativeMethodInfoPtr_set_NamingStrategy_Public_set_Void_NamingStrategy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665164);
			DefaultContractResolver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665165);
			DefaultContractResolver.NativeMethodInfoPtr_ResolveContract_Public_Virtual_New_JsonContract_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665166);
			DefaultContractResolver.NativeMethodInfoPtr_FilterMembers_Private_Static_Boolean_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665167);
			DefaultContractResolver.NativeMethodInfoPtr_GetSerializableMembers_Protected_Virtual_New_List_1_MemberInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665168);
			DefaultContractResolver.NativeMethodInfoPtr_ShouldSerializeEntityMember_Private_Boolean_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665169);
			DefaultContractResolver.NativeMethodInfoPtr_CreateObjectContract_Protected_Virtual_New_JsonObjectContract_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665170);
			DefaultContractResolver.NativeMethodInfoPtr_ThrowUnableToSerializeError_Private_Static_Void_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665171);
			DefaultContractResolver.NativeMethodInfoPtr_GetExtensionDataMemberForType_Private_MemberInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665172);
			DefaultContractResolver.NativeMethodInfoPtr_SetExtensionDataDelegates_Private_Static_Void_JsonObjectContract_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665173);
			DefaultContractResolver.NativeMethodInfoPtr_GetAttributeConstructor_Private_ConstructorInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665174);
			DefaultContractResolver.NativeMethodInfoPtr_GetImmutableConstructor_Private_ConstructorInfo_Type_JsonPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665175);
			DefaultContractResolver.NativeMethodInfoPtr_GetParameterizedConstructor_Private_ConstructorInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665176);
			DefaultContractResolver.NativeMethodInfoPtr_CreateConstructorParameters_Protected_Virtual_New_IList_1_JsonProperty_ConstructorInfo_JsonPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665177);
			DefaultContractResolver.NativeMethodInfoPtr_MatchProperty_Private_JsonProperty_JsonPropertyCollection_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665178);
			DefaultContractResolver.NativeMethodInfoPtr_CreatePropertyFromConstructorParameter_Protected_Virtual_New_JsonProperty_JsonProperty_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665179);
			DefaultContractResolver.NativeMethodInfoPtr_ResolveContractConverter_Protected_Virtual_New_JsonConverter_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665180);
			DefaultContractResolver.NativeMethodInfoPtr_GetDefaultCreator_Private_Func_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665181);
			DefaultContractResolver.NativeMethodInfoPtr_InitializeContract_Private_Void_JsonContract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665182);
			DefaultContractResolver.NativeMethodInfoPtr_ResolveCallbackMethods_Private_Void_JsonContract_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665183);
			DefaultContractResolver.NativeMethodInfoPtr_GetCallbackMethodsForType_Private_Void_Type_byref_List_1_SerializationCallback_byref_List_1_SerializationCallback_byref_List_1_SerializationCallback_byref_List_1_SerializationCallback_byref_List_1_SerializationErrorCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665184);
			DefaultContractResolver.NativeMethodInfoPtr_IsConcurrentOrObservableCollection_Private_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665185);
			DefaultContractResolver.NativeMethodInfoPtr_ShouldSkipDeserialized_Private_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665186);
			DefaultContractResolver.NativeMethodInfoPtr_ShouldSkipSerializing_Private_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665187);
			DefaultContractResolver.NativeMethodInfoPtr_GetClassHierarchyForType_Private_List_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665188);
			DefaultContractResolver.NativeMethodInfoPtr_CreateDictionaryContract_Protected_Virtual_New_JsonDictionaryContract_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665189);
			DefaultContractResolver.NativeMethodInfoPtr_CreateArrayContract_Protected_Virtual_New_JsonArrayContract_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665190);
			DefaultContractResolver.NativeMethodInfoPtr_CreatePrimitiveContract_Protected_Virtual_New_JsonPrimitiveContract_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665191);
			DefaultContractResolver.NativeMethodInfoPtr_CreateLinqContract_Protected_Virtual_New_JsonLinqContract_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665192);
			DefaultContractResolver.NativeMethodInfoPtr_CreateISerializableContract_Protected_Virtual_New_JsonISerializableContract_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665193);
			DefaultContractResolver.NativeMethodInfoPtr_CreateDynamicContract_Protected_Virtual_New_JsonDynamicContract_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665194);
			DefaultContractResolver.NativeMethodInfoPtr_CreateStringContract_Protected_Virtual_New_JsonStringContract_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665195);
			DefaultContractResolver.NativeMethodInfoPtr_CreateContract_Protected_Virtual_New_JsonContract_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665196);
			DefaultContractResolver.NativeMethodInfoPtr_IsJsonPrimitiveType_Internal_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665197);
			DefaultContractResolver.NativeMethodInfoPtr_IsIConvertible_Internal_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665198);
			DefaultContractResolver.NativeMethodInfoPtr_CanConvertToString_Internal_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665199);
			DefaultContractResolver.NativeMethodInfoPtr_IsValidCallback_Private_Static_Boolean_MethodInfo_Il2CppReferenceArray_1_ParameterInfo_Type_MethodInfo_byref_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665200);
			DefaultContractResolver.NativeMethodInfoPtr_GetClrTypeFullName_Internal_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665201);
			DefaultContractResolver.NativeMethodInfoPtr_CreateProperties_Protected_Virtual_New_IList_1_JsonProperty_Type_MemberSerialization_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665202);
			DefaultContractResolver.NativeMethodInfoPtr_GetNameTable_Internal_Virtual_New_DefaultJsonNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665203);
			DefaultContractResolver.NativeMethodInfoPtr_CreateMemberValueProvider_Protected_Virtual_New_IValueProvider_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665204);
			DefaultContractResolver.NativeMethodInfoPtr_CreateProperty_Protected_Virtual_New_JsonProperty_MemberInfo_MemberSerialization_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665205);
			DefaultContractResolver.NativeMethodInfoPtr_SetPropertySettingsFromAttributes_Private_Void_JsonProperty_Object_String_Type_MemberSerialization_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665206);
			DefaultContractResolver.NativeMethodInfoPtr_CreateShouldSerializeTest_Private_Predicate_1_Object_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665207);
			DefaultContractResolver.NativeMethodInfoPtr_SetIsSpecifiedActions_Private_Void_JsonProperty_MemberInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665208);
			DefaultContractResolver.NativeMethodInfoPtr_ResolvePropertyName_Protected_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665209);
			DefaultContractResolver.NativeMethodInfoPtr_ResolveExtensionDataName_Protected_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665210);
			DefaultContractResolver.NativeMethodInfoPtr_ResolveDictionaryKey_Protected_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665211);
			DefaultContractResolver.NativeMethodInfoPtr_GetResolvedPropertyName_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, 100665212);
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x0003F878 File Offset: 0x0003DA78
		public unsafe static IContractResolver Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746960, XrefRangeEnd = 746964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_get_Instance_Internal_Static_get_IContractResolver_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IContractResolver>(intPtr3) : null;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x0003F8AC File Offset: 0x0003DAAC
		public unsafe bool DynamicCodeGeneration
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746964, XrefRangeEnd = 746968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_get_DynamicCodeGeneration_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x0003F8E8 File Offset: 0x0003DAE8
		// (set) Token: 0x060009B1 RID: 2481 RVA: 0x0003F924 File Offset: 0x0003DB24
		public unsafe BindingFlags DefaultMembersSearchFlags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_get_DefaultMembersSearchFlags_Public_get_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_set_DefaultMembersSearchFlags_Public_set_Void_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060009B2 RID: 2482 RVA: 0x0003F964 File Offset: 0x0003DB64
		// (set) Token: 0x060009B3 RID: 2483 RVA: 0x0003F9A0 File Offset: 0x0003DBA0
		public unsafe bool SerializeCompilerGeneratedMembers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_get_SerializeCompilerGeneratedMembers_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_set_SerializeCompilerGeneratedMembers_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x0003F9E0 File Offset: 0x0003DBE0
		// (set) Token: 0x060009B5 RID: 2485 RVA: 0x0003FA1C File Offset: 0x0003DC1C
		public unsafe bool IgnoreSerializableInterface
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_get_IgnoreSerializableInterface_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_set_IgnoreSerializableInterface_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060009B6 RID: 2486 RVA: 0x0003FA5C File Offset: 0x0003DC5C
		// (set) Token: 0x060009B7 RID: 2487 RVA: 0x0003FA98 File Offset: 0x0003DC98
		public unsafe bool IgnoreSerializableAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_get_IgnoreSerializableAttribute_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_set_IgnoreSerializableAttribute_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060009B8 RID: 2488 RVA: 0x0003FAD8 File Offset: 0x0003DCD8
		// (set) Token: 0x060009B9 RID: 2489 RVA: 0x0003FB14 File Offset: 0x0003DD14
		public unsafe bool IgnoreIsSpecifiedMembers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_get_IgnoreIsSpecifiedMembers_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_set_IgnoreIsSpecifiedMembers_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x0003FB54 File Offset: 0x0003DD54
		// (set) Token: 0x060009BB RID: 2491 RVA: 0x0003FB90 File Offset: 0x0003DD90
		public unsafe bool IgnoreShouldSerializeMembers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_get_IgnoreShouldSerializeMembers_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 287297, RefRangeEnd = 287316, XrefRangeStart = 287297, XrefRangeEnd = 287316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_set_IgnoreShouldSerializeMembers_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x0003FBD0 File Offset: 0x0003DDD0
		// (set) Token: 0x060009BD RID: 2493 RVA: 0x0003FC10 File Offset: 0x0003DE10
		public unsafe NamingStrategy NamingStrategy
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_get_NamingStrategy_Public_get_NamingStrategy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NamingStrategy>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_set_NamingStrategy_Public_set_Void_NamingStrategy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0003FC54 File Offset: 0x0003DE54
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 746985, RefRangeEnd = 746990, XrefRangeStart = 746968, XrefRangeEnd = 746985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultContractResolver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x0003FC90 File Offset: 0x0003DE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746990, XrefRangeEnd = 747001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual JsonContract ResolveContract(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultContractResolver.NativeMethodInfoPtr_ResolveContract_Public_Virtual_New_JsonContract_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonContract>(intPtr3) : null;
			}
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x0003FCEC File Offset: 0x0003DEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747001, XrefRangeEnd = 747015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FilterMembers(MemberInfo member)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_FilterMembers_Private_Static_Boolean_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x0003FD30 File Offset: 0x0003DF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747015, XrefRangeEnd = 747172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<MemberInfo> GetSerializableMembers(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultContractResolver.NativeMethodInfoPtr_GetSerializableMembers_Protected_Virtual_New_List_1_MemberInfo_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<MemberInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x0003FD8C File Offset: 0x0003DF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747172, XrefRangeEnd = 747178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldSerializeEntityMember(MemberInfo memberInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_ShouldSerializeEntityMember_Private_Boolean_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x0003FDDC File Offset: 0x0003DFDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747178, XrefRangeEnd = 747261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual JsonObjectContract CreateObjectContract(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultContractResolver.NativeMethodInfoPtr_CreateObjectContract_Protected_Virtual_New_JsonObjectContract_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonObjectContract>(intPtr3) : null;
			}
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x0003FE38 File Offset: 0x0003E038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747261, XrefRangeEnd = 747383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowUnableToSerializeError(Object o, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_ThrowUnableToSerializeError_Private_Static_Void_Object_StreamingContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x0003FE88 File Offset: 0x0003E088
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 747419, RefRangeEnd = 747420, XrefRangeStart = 747383, XrefRangeEnd = 747419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberInfo GetExtensionDataMemberForType(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_GetExtensionDataMemberForType_Private_MemberInfo_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x0003FED8 File Offset: 0x0003E0D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 747582, RefRangeEnd = 747583, XrefRangeStart = 747420, XrefRangeEnd = 747582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_SetExtensionDataDelegates_Private_Static_Void_JsonObjectContract_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x0003FF20 File Offset: 0x0003E120
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 747617, RefRangeEnd = 747620, XrefRangeStart = 747583, XrefRangeEnd = 747617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructorInfo GetAttributeConstructor(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_GetAttributeConstructor_Private_ConstructorInfo_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0003FF70 File Offset: 0x0003E170
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 747639, RefRangeEnd = 747640, XrefRangeStart = 747620, XrefRangeEnd = 747639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructorInfo GetImmutableConstructor(Type objectType, JsonPropertyCollection memberProperties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberProperties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_GetImmutableConstructor_Private_ConstructorInfo_Type_JsonPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr3) : null;
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x0003FFD4 File Offset: 0x0003E1D4
		[CallerCount(0)]
		public unsafe ConstructorInfo GetParameterizedConstructor(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_GetParameterizedConstructor_Private_ConstructorInfo_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00040024 File Offset: 0x0003E224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747640, XrefRangeEnd = 747647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constructor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberProperties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultContractResolver.NativeMethodInfoPtr_CreateConstructorParameters_Protected_Virtual_New_IList_1_JsonProperty_ConstructorInfo_JsonPropertyCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<JsonProperty>>(intPtr3) : null;
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00040094 File Offset: 0x0003E294
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 747654, RefRangeEnd = 747655, XrefRangeStart = 747647, XrefRangeEnd = 747654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonProperty MatchProperty(JsonPropertyCollection properties, string name, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_MatchProperty_Private_JsonProperty_JsonPropertyCollection_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonProperty>(intPtr3) : null;
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00040108 File Offset: 0x0003E308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747655, XrefRangeEnd = 747678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchingMemberProperty);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameterInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultContractResolver.NativeMethodInfoPtr_CreatePropertyFromConstructorParameter_Protected_Virtual_New_JsonProperty_JsonProperty_ParameterInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonProperty>(intPtr3) : null;
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00040178 File Offset: 0x0003E378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747678, XrefRangeEnd = 747682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual JsonConverter ResolveContractConverter(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultContractResolver.NativeMethodInfoPtr_ResolveContractConverter_Protected_Virtual_New_JsonConverter_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonConverter>(intPtr3) : null;
			}
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x000401D4 File Offset: 0x0003E3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747682, XrefRangeEnd = 747690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func<Object> GetDefaultCreator(Type createdType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(createdType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_GetDefaultCreator_Private_Func_1_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00040224 File Offset: 0x0003E424
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 747734, RefRangeEnd = 747742, XrefRangeStart = 747690, XrefRangeEnd = 747734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeContract(JsonContract contract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_InitializeContract_Private_Void_JsonContract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00040268 File Offset: 0x0003E468
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 747778, RefRangeEnd = 747779, XrefRangeStart = 747742, XrefRangeEnd = 747778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResolveCallbackMethods(JsonContract contract, Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_ResolveCallbackMethods_Private_Void_JsonContract_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x000402BC File Offset: 0x0003E4BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 747912, RefRangeEnd = 747913, XrefRangeStart = 747779, XrefRangeEnd = 747912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetCallbackMethodsForType(Type type, out List<SerializationCallback> onSerializing, out List<SerializationCallback> onSerialized, out List<SerializationCallback> onDeserializing, out List<SerializationCallback> onDeserialized, out List<SerializationErrorCallback> onError)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
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
			IntPtr intPtr7;
			IntPtr intPtr6 = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_GetCallbackMethodsForType_Private_Void_Type_byref_List_1_SerializationCallback_byref_List_1_SerializationCallback_byref_List_1_SerializationCallback_byref_List_1_SerializationCallback_byref_List_1_SerializationErrorCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr7);
			Il2CppException.RaiseExceptionIfNecessary(intPtr7);
			IntPtr intPtr8 = intPtr;
			onSerializing = ((intPtr8 == 0) ? null : new List<SerializationCallback>(intPtr8));
			IntPtr intPtr9 = intPtr2;
			onSerialized = ((intPtr9 == 0) ? null : new List<SerializationCallback>(intPtr9));
			IntPtr intPtr10 = intPtr3;
			onDeserializing = ((intPtr10 == 0) ? null : new List<SerializationCallback>(intPtr10));
			IntPtr intPtr11 = intPtr4;
			onDeserialized = ((intPtr11 == 0) ? null : new List<SerializationCallback>(intPtr11));
			IntPtr intPtr12 = intPtr5;
			onError = ((intPtr12 == 0) ? null : new List<SerializationErrorCallback>(intPtr12));
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x000403B0 File Offset: 0x0003E5B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 747928, RefRangeEnd = 747932, XrefRangeStart = 747913, XrefRangeEnd = 747928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsConcurrentOrObservableCollection(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_IsConcurrentOrObservableCollection_Private_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x000403F4 File Offset: 0x0003E5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747932, XrefRangeEnd = 747942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldSkipDeserialized(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_ShouldSkipDeserialized_Private_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00040438 File Offset: 0x0003E638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747942, XrefRangeEnd = 747952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldSkipSerializing(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_ShouldSkipSerializing_Private_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0004047C File Offset: 0x0003E67C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 747977, RefRangeEnd = 747979, XrefRangeStart = 747952, XrefRangeEnd = 747977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Type> GetClassHierarchyForType(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_GetClassHierarchyForType_Private_List_1_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x000404CC File Offset: 0x0003E6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 747979, XrefRangeEnd = 748054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual JsonDictionaryContract CreateDictionaryContract(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultContractResolver.NativeMethodInfoPtr_CreateDictionaryContract_Protected_Virtual_New_JsonDictionaryContract_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonDictionaryContract>(intPtr3) : null;
			}
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00040528 File Offset: 0x0003E728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748054, XrefRangeEnd = 748089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual JsonArrayContract CreateArrayContract(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultContractResolver.NativeMethodInfoPtr_CreateArrayContract_Protected_Virtual_New_JsonArrayContract_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonArrayContract>(intPtr3) : null;
			}
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00040584 File Offset: 0x0003E784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748089, XrefRangeEnd = 748105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultContractResolver.NativeMethodInfoPtr_CreatePrimitiveContract_Protected_Virtual_New_JsonPrimitiveContract_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonPrimitiveContract>(intPtr3) : null;
			}
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x000405E0 File Offset: 0x0003E7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748105, XrefRangeEnd = 748110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual JsonLinqContract CreateLinqContract(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultContractResolver.NativeMethodInfoPtr_CreateLinqContract_Protected_Virtual_New_JsonLinqContract_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonLinqContract>(intPtr3) : null;
			}
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x0004063C File Offset: 0x0003E83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748110, XrefRangeEnd = 748141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual JsonISerializableContract CreateISerializableContract(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultContractResolver.NativeMethodInfoPtr_CreateISerializableContract_Protected_Virtual_New_JsonISerializableContract_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonISerializableContract>(intPtr3) : null;
			}
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00040698 File Offset: 0x0003E898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748141, XrefRangeEnd = 748209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual JsonDynamicContract CreateDynamicContract(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultContractResolver.NativeMethodInfoPtr_CreateDynamicContract_Protected_Virtual_New_JsonDynamicContract_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonDynamicContract>(intPtr3) : null;
			}
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x000406F4 File Offset: 0x0003E8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748209, XrefRangeEnd = 748214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual JsonStringContract CreateStringContract(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultContractResolver.NativeMethodInfoPtr_CreateStringContract_Protected_Virtual_New_JsonStringContract_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonStringContract>(intPtr3) : null;
			}
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00040750 File Offset: 0x0003E950
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 748317, RefRangeEnd = 748318, XrefRangeStart = 748214, XrefRangeEnd = 748317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual JsonContract CreateContract(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultContractResolver.NativeMethodInfoPtr_CreateContract_Protected_Virtual_New_JsonContract_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonContract>(intPtr3) : null;
			}
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x000407AC File Offset: 0x0003E9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748318, XrefRangeEnd = 748322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsJsonPrimitiveType(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_IsJsonPrimitiveType_Internal_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x000407F0 File Offset: 0x0003E9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748322, XrefRangeEnd = 748338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsIConvertible(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_IsIConvertible_Internal_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00040834 File Offset: 0x0003EA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748338, XrefRangeEnd = 748353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanConvertToString(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_CanConvertToString_Internal_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00040878 File Offset: 0x0003EA78
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 748390, RefRangeEnd = 748395, XrefRangeStart = 748353, XrefRangeEnd = 748390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidCallback(MethodInfo method, Il2CppReferenceArray<ParameterInfo> parameters, Type attributeType, MethodInfo currentCallback, ref Type prevAttributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentCallback);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(prevAttributeType);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_IsValidCallback_Private_Static_Boolean_MethodInfo_Il2CppReferenceArray_1_ParameterInfo_Type_MethodInfo_byref_Type_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			prevAttributeType = ((intPtr4 == 0) ? null : new Type(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0004091C File Offset: 0x0003EB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748395, XrefRangeEnd = 748402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetClrTypeFullName(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_GetClrTypeFullName_Internal_Static_String_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00040958 File Offset: 0x0003EB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748402, XrefRangeEnd = 748448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref memberSerialization;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultContractResolver.NativeMethodInfoPtr_CreateProperties_Protected_Virtual_New_IList_1_JsonProperty_Type_MemberSerialization_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<JsonProperty>>(intPtr3) : null;
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x000409C4 File Offset: 0x0003EBC4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DefaultJsonNameTable GetNameTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultContractResolver.NativeMethodInfoPtr_GetNameTable_Internal_Virtual_New_DefaultJsonNameTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DefaultJsonNameTable>(intPtr3) : null;
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00040A10 File Offset: 0x0003EC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748448, XrefRangeEnd = 748452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IValueProvider CreateMemberValueProvider(MemberInfo member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultContractResolver.NativeMethodInfoPtr_CreateMemberValueProvider_Protected_Virtual_New_IValueProvider_MemberInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IValueProvider>(intPtr3) : null;
			}
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00040A6C File Offset: 0x0003EC6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748452, XrefRangeEnd = 748477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref memberSerialization;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultContractResolver.NativeMethodInfoPtr_CreateProperty_Protected_Virtual_New_JsonProperty_MemberInfo_MemberSerialization_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonProperty>(intPtr3) : null;
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00040AD8 File Offset: 0x0003ECD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 748576, RefRangeEnd = 748578, XrefRangeStart = 748477, XrefRangeEnd = 748576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPropertySettingsFromAttributes(JsonProperty property, Object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeProvider);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(declaringType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref memberSerialization;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &allowNonPublicAccess;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_SetPropertySettingsFromAttributes_Private_Void_JsonProperty_Object_String_Type_MemberSerialization_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00040B70 File Offset: 0x0003ED70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 748612, RefRangeEnd = 748613, XrefRangeStart = 748578, XrefRangeEnd = 748612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Predicate<Object> CreateShouldSerializeTest(MemberInfo member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_CreateShouldSerializeTest_Private_Predicate_1_Object_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Predicate<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00040BC0 File Offset: 0x0003EDC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 748661, RefRangeEnd = 748662, XrefRangeStart = 748613, XrefRangeEnd = 748661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowNonPublicAccess;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_SetIsSpecifiedActions_Private_Void_JsonProperty_MemberInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00040C24 File Offset: 0x0003EE24
		[CallerCount(0)]
		public unsafe virtual string ResolvePropertyName(string propertyName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultContractResolver.NativeMethodInfoPtr_ResolvePropertyName_Protected_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00040C78 File Offset: 0x0003EE78
		[CallerCount(0)]
		public unsafe virtual string ResolveExtensionDataName(string extensionDataName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(extensionDataName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultContractResolver.NativeMethodInfoPtr_ResolveExtensionDataName_Protected_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00040CCC File Offset: 0x0003EECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748662, XrefRangeEnd = 748663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ResolveDictionaryKey(string dictionaryKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(dictionaryKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultContractResolver.NativeMethodInfoPtr_ResolveDictionaryKey_Protected_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00040D20 File Offset: 0x0003EF20
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 748663, RefRangeEnd = 748674, XrefRangeStart = 748663, XrefRangeEnd = 748663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetResolvedPropertyName(string propertyName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.NativeMethodInfoPtr_GetResolvedPropertyName_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00004F5B File Offset: 0x0000315B
		public DefaultContractResolver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x00040D68 File Offset: 0x0003EF68
		// (set) Token: 0x060009F0 RID: 2544 RVA: 0x00004F64 File Offset: 0x00003164
		public unsafe static IContractResolver _instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultContractResolver.NativeFieldInfoPtr__instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IContractResolver>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultContractResolver.NativeFieldInfoPtr__instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x00040D90 File Offset: 0x0003EF90
		// (set) Token: 0x060009F2 RID: 2546 RVA: 0x00004F76 File Offset: 0x00003176
		public unsafe static Il2CppStringArray BlacklistedTypeNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultContractResolver.NativeFieldInfoPtr_BlacklistedTypeNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultContractResolver.NativeFieldInfoPtr_BlacklistedTypeNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x00040DB8 File Offset: 0x0003EFB8
		// (set) Token: 0x060009F4 RID: 2548 RVA: 0x00004F88 File Offset: 0x00003188
		public unsafe static Il2CppReferenceArray<JsonConverter> BuiltInConverters
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultContractResolver.NativeFieldInfoPtr_BuiltInConverters, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<JsonConverter>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultContractResolver.NativeFieldInfoPtr_BuiltInConverters, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x00040DE0 File Offset: 0x0003EFE0
		// (set) Token: 0x060009F6 RID: 2550 RVA: 0x00004F9A File Offset: 0x0000319A
		public unsafe DefaultJsonNameTable _nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.NativeFieldInfoPtr__nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultJsonNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.NativeFieldInfoPtr__nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x00040E10 File Offset: 0x0003F010
		// (set) Token: 0x060009F8 RID: 2552 RVA: 0x00004FB9 File Offset: 0x000031B9
		public unsafe ThreadSafeStore<Type, JsonContract> _contractCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.NativeFieldInfoPtr__contractCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadSafeStore<Type, JsonContract>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.NativeFieldInfoPtr__contractCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x00040E40 File Offset: 0x0003F040
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x00004FD8 File Offset: 0x000031D8
		public unsafe BindingFlags _DefaultMembersSearchFlags_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.NativeFieldInfoPtr__DefaultMembersSearchFlags_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.NativeFieldInfoPtr__DefaultMembersSearchFlags_k__BackingField)) = value;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x00040E68 File Offset: 0x0003F068
		// (set) Token: 0x060009FC RID: 2556 RVA: 0x00004FF3 File Offset: 0x000031F3
		public unsafe bool _SerializeCompilerGeneratedMembers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.NativeFieldInfoPtr__SerializeCompilerGeneratedMembers_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.NativeFieldInfoPtr__SerializeCompilerGeneratedMembers_k__BackingField)) = value;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x00040E90 File Offset: 0x0003F090
		// (set) Token: 0x060009FE RID: 2558 RVA: 0x0000500E File Offset: 0x0000320E
		public unsafe bool _IgnoreSerializableInterface_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.NativeFieldInfoPtr__IgnoreSerializableInterface_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.NativeFieldInfoPtr__IgnoreSerializableInterface_k__BackingField)) = value;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x00040EB8 File Offset: 0x0003F0B8
		// (set) Token: 0x06000A00 RID: 2560 RVA: 0x00005029 File Offset: 0x00003229
		public unsafe bool _IgnoreSerializableAttribute_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.NativeFieldInfoPtr__IgnoreSerializableAttribute_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.NativeFieldInfoPtr__IgnoreSerializableAttribute_k__BackingField)) = value;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x00040EE0 File Offset: 0x0003F0E0
		// (set) Token: 0x06000A02 RID: 2562 RVA: 0x00005044 File Offset: 0x00003244
		public unsafe bool _IgnoreIsSpecifiedMembers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.NativeFieldInfoPtr__IgnoreIsSpecifiedMembers_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.NativeFieldInfoPtr__IgnoreIsSpecifiedMembers_k__BackingField)) = value;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x00040F08 File Offset: 0x0003F108
		// (set) Token: 0x06000A04 RID: 2564 RVA: 0x0000505F File Offset: 0x0000325F
		public unsafe bool _IgnoreShouldSerializeMembers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.NativeFieldInfoPtr__IgnoreShouldSerializeMembers_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.NativeFieldInfoPtr__IgnoreShouldSerializeMembers_k__BackingField)) = value;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x00040F30 File Offset: 0x0003F130
		// (set) Token: 0x06000A06 RID: 2566 RVA: 0x0000507A File Offset: 0x0000327A
		public unsafe NamingStrategy _NamingStrategy_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.NativeFieldInfoPtr__NamingStrategy_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NamingStrategy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.NativeFieldInfoPtr__NamingStrategy_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeFieldInfoPtr__instance;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeFieldInfoPtr_BlacklistedTypeNames;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeFieldInfoPtr_BuiltInConverters;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeFieldInfoPtr__nameTable;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeFieldInfoPtr__contractCache;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeFieldInfoPtr__DefaultMembersSearchFlags_k__BackingField;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeFieldInfoPtr__SerializeCompilerGeneratedMembers_k__BackingField;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeFieldInfoPtr__IgnoreSerializableInterface_k__BackingField;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeFieldInfoPtr__IgnoreSerializableAttribute_k__BackingField;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeFieldInfoPtr__IgnoreIsSpecifiedMembers_k__BackingField;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeFieldInfoPtr__IgnoreShouldSerializeMembers_k__BackingField;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeFieldInfoPtr__NamingStrategy_k__BackingField;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Internal_Static_get_IContractResolver_0;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeMethodInfoPtr_get_DynamicCodeGeneration_Public_get_Boolean_0;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultMembersSearchFlags_Public_get_BindingFlags_0;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultMembersSearchFlags_Public_set_Void_BindingFlags_0;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeMethodInfoPtr_get_SerializeCompilerGeneratedMembers_Public_get_Boolean_0;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeMethodInfoPtr_set_SerializeCompilerGeneratedMembers_Public_set_Void_Boolean_0;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreSerializableInterface_Public_get_Boolean_0;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreSerializableInterface_Public_set_Void_Boolean_0;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreSerializableAttribute_Public_get_Boolean_0;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreSerializableAttribute_Public_set_Void_Boolean_0;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreIsSpecifiedMembers_Public_get_Boolean_0;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreIsSpecifiedMembers_Public_set_Void_Boolean_0;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreShouldSerializeMembers_Public_get_Boolean_0;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreShouldSerializeMembers_Public_set_Void_Boolean_0;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeMethodInfoPtr_get_NamingStrategy_Public_get_NamingStrategy_0;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeMethodInfoPtr_set_NamingStrategy_Public_set_Void_NamingStrategy_0;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeMethodInfoPtr_ResolveContract_Public_Virtual_New_JsonContract_Type_0;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeMethodInfoPtr_FilterMembers_Private_Static_Boolean_MemberInfo_0;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeMethodInfoPtr_GetSerializableMembers_Protected_Virtual_New_List_1_MemberInfo_Type_0;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSerializeEntityMember_Private_Boolean_MemberInfo_0;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeMethodInfoPtr_CreateObjectContract_Protected_Virtual_New_JsonObjectContract_Type_0;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeMethodInfoPtr_ThrowUnableToSerializeError_Private_Static_Void_Object_StreamingContext_0;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeMethodInfoPtr_GetExtensionDataMemberForType_Private_MemberInfo_Type_0;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeMethodInfoPtr_SetExtensionDataDelegates_Private_Static_Void_JsonObjectContract_MemberInfo_0;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeConstructor_Private_ConstructorInfo_Type_0;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeMethodInfoPtr_GetImmutableConstructor_Private_ConstructorInfo_Type_JsonPropertyCollection_0;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeMethodInfoPtr_GetParameterizedConstructor_Private_ConstructorInfo_Type_0;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeMethodInfoPtr_CreateConstructorParameters_Protected_Virtual_New_IList_1_JsonProperty_ConstructorInfo_JsonPropertyCollection_0;

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeMethodInfoPtr_MatchProperty_Private_JsonProperty_JsonPropertyCollection_String_Type_0;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeMethodInfoPtr_CreatePropertyFromConstructorParameter_Protected_Virtual_New_JsonProperty_JsonProperty_ParameterInfo_0;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeMethodInfoPtr_ResolveContractConverter_Protected_Virtual_New_JsonConverter_Type_0;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultCreator_Private_Func_1_Object_Type_0;

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeMethodInfoPtr_InitializeContract_Private_Void_JsonContract_0;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeMethodInfoPtr_ResolveCallbackMethods_Private_Void_JsonContract_Type_0;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeMethodInfoPtr_GetCallbackMethodsForType_Private_Void_Type_byref_List_1_SerializationCallback_byref_List_1_SerializationCallback_byref_List_1_SerializationCallback_byref_List_1_SerializationCallback_byref_List_1_SerializationErrorCallback_0;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeMethodInfoPtr_IsConcurrentOrObservableCollection_Private_Static_Boolean_Type_0;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSkipDeserialized_Private_Static_Boolean_Type_0;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSkipSerializing_Private_Static_Boolean_Type_0;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeMethodInfoPtr_GetClassHierarchyForType_Private_List_1_Type_Type_0;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeMethodInfoPtr_CreateDictionaryContract_Protected_Virtual_New_JsonDictionaryContract_Type_0;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeMethodInfoPtr_CreateArrayContract_Protected_Virtual_New_JsonArrayContract_Type_0;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeMethodInfoPtr_CreatePrimitiveContract_Protected_Virtual_New_JsonPrimitiveContract_Type_0;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeMethodInfoPtr_CreateLinqContract_Protected_Virtual_New_JsonLinqContract_Type_0;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeMethodInfoPtr_CreateISerializableContract_Protected_Virtual_New_JsonISerializableContract_Type_0;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeMethodInfoPtr_CreateDynamicContract_Protected_Virtual_New_JsonDynamicContract_Type_0;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeMethodInfoPtr_CreateStringContract_Protected_Virtual_New_JsonStringContract_Type_0;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeMethodInfoPtr_CreateContract_Protected_Virtual_New_JsonContract_Type_0;

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeMethodInfoPtr_IsJsonPrimitiveType_Internal_Static_Boolean_Type_0;

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeMethodInfoPtr_IsIConvertible_Internal_Static_Boolean_Type_0;

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeMethodInfoPtr_CanConvertToString_Internal_Static_Boolean_Type_0;

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeMethodInfoPtr_IsValidCallback_Private_Static_Boolean_MethodInfo_Il2CppReferenceArray_1_ParameterInfo_Type_MethodInfo_byref_Type_0;

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeMethodInfoPtr_GetClrTypeFullName_Internal_Static_String_Type_0;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeMethodInfoPtr_CreateProperties_Protected_Virtual_New_IList_1_JsonProperty_Type_MemberSerialization_0;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeMethodInfoPtr_GetNameTable_Internal_Virtual_New_DefaultJsonNameTable_0;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeMethodInfoPtr_CreateMemberValueProvider_Protected_Virtual_New_IValueProvider_MemberInfo_0;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeMethodInfoPtr_CreateProperty_Protected_Virtual_New_JsonProperty_MemberInfo_MemberSerialization_0;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeMethodInfoPtr_SetPropertySettingsFromAttributes_Private_Void_JsonProperty_Object_String_Type_MemberSerialization_byref_Boolean_0;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeMethodInfoPtr_CreateShouldSerializeTest_Private_Predicate_1_Object_MemberInfo_0;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeMethodInfoPtr_SetIsSpecifiedActions_Private_Void_JsonProperty_MemberInfo_Boolean_0;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeMethodInfoPtr_ResolvePropertyName_Protected_Virtual_New_String_String_0;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_ResolveExtensionDataName_Protected_Virtual_New_String_String_0;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr_ResolveDictionaryKey_Protected_Virtual_New_String_String_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr_GetResolvedPropertyName_Public_String_String_0;

		// Token: 0x020001C2 RID: 450
		public class EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> : Object
		{
			// Token: 0x06001E2F RID: 7727 RVA: 0x0008BBF0 File Offset: 0x00089DF0
			// Note: this type is marked as 'beforefieldinit'.
			static EnumerableDictionaryWrapper()
			{
				Il2CppClassPointerStore<DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, "EnumerableDictionaryWrapper`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnumeratorKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnumeratorValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>>.NativeClassPtr);
				DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>.NativeFieldInfoPtr__e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>>.NativeClassPtr, "_e");
				DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_KeyValuePair_2_TEnumeratorKey_TEnumeratorValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>>.NativeClassPtr, 100665214);
				DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>>.NativeClassPtr, 100665215);
				DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>>.NativeClassPtr, 100665216);
			}

			// Token: 0x06001E30 RID: 7728 RVA: 0x0008BCB8 File Offset: 0x00089EB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746848, XrefRangeEnd = 746853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EnumerableDictionaryWrapper(IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_KeyValuePair_2_TEnumeratorKey_TEnumeratorValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E31 RID: 7729 RVA: 0x0008BD04 File Offset: 0x00089F04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746853, XrefRangeEnd = 746856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator<KeyValuePair<Object, Object>> GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<Object, Object>>>(intPtr3) : null;
			}

			// Token: 0x06001E32 RID: 7730 RVA: 0x0008BD44 File Offset: 0x00089F44
			[CallerCount(0)]
			public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001E33 RID: 7731 RVA: 0x0000EED5 File Offset: 0x0000D0D5
			public EnumerableDictionaryWrapper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700087D RID: 2173
			// (get) Token: 0x06001E34 RID: 7732 RVA: 0x0008BD84 File Offset: 0x00089F84
			// (set) Token: 0x06001E35 RID: 7733 RVA: 0x0000EEDE File Offset: 0x0000D0DE
			public unsafe IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>.NativeFieldInfoPtr__e);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>.NativeFieldInfoPtr__e), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400161A RID: 5658
			private static readonly IntPtr NativeFieldInfoPtr__e;

			// Token: 0x0400161B RID: 5659
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_KeyValuePair_2_TEnumeratorKey_TEnumeratorValue_0;

			// Token: 0x0400161C RID: 5660
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_Object_Object_0;

			// Token: 0x0400161D RID: 5661
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x02000234 RID: 564
			[ObfuscatedName("Newtonsoft.Json.Serialization.DefaultContractResolver+EnumerableDictionaryWrapper`2+<GetEnumerator>d__2")]
			public sealed class _GetEnumerator_d__2 : Object
			{
				// Token: 0x060022EB RID: 8939 RVA: 0x000996FC File Offset: 0x000978FC
				// Note: this type is marked as 'beforefieldinit'.
				static _GetEnumerator_d__2()
				{
					Il2CppClassPointerStore<DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>>.NativeClassPtr, "<GetEnumerator>d__2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnumeratorKey>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnumeratorValue>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2>.NativeClassPtr);
					DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2>.NativeClassPtr, "<>1__state");
					DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2>.NativeClassPtr, "<>2__current");
					DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2>.NativeClassPtr, "<>4__this");
					DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2>.NativeClassPtr, "<>7__wrap1");
					DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2>.NativeClassPtr, 100665217);
					DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2>.NativeClassPtr, 100665218);
					DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2>.NativeClassPtr, 100665219);
					DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2>.NativeClassPtr, 100665220);
					DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2>.NativeClassPtr, 100665221);
					DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2>.NativeClassPtr, 100665222);
					DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2>.NativeClassPtr, 100665223);
				}

				// Token: 0x060022EC RID: 8940 RVA: 0x00099850 File Offset: 0x00097A50
				[CallerCount(73)]
				[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _GetEnumerator_d__2(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060022ED RID: 8941 RVA: 0x00099898 File Offset: 0x00097A98
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746816, XrefRangeEnd = 746817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060022EE RID: 8942 RVA: 0x000998CC File Offset: 0x00097ACC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746817, XrefRangeEnd = 746842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060022EF RID: 8943 RVA: 0x00099908 File Offset: 0x00097B08
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746842, XrefRangeEnd = 746845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void __m__Finally1()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000A08 RID: 2568
				// (get) Token: 0x060022F0 RID: 8944 RVA: 0x0009993C File Offset: 0x00097B3C
				public unsafe KeyValuePair<Object, Object> prop_KeyValuePair_2_Object_Object_0
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return new KeyValuePair<Object, Object>(intPtr);
					}
				}

				// Token: 0x060022F1 RID: 8945 RVA: 0x00099974 File Offset: 0x00097B74
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000A09 RID: 2569
				// (get) Token: 0x060022F2 RID: 8946 RVA: 0x000999A8 File Offset: 0x00097BA8
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746845, XrefRangeEnd = 746848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x060022F3 RID: 8947 RVA: 0x00011DA8 File Offset: 0x0000FFA8
				public _GetEnumerator_d__2(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000A04 RID: 2564
				// (get) Token: 0x060022F4 RID: 8948 RVA: 0x000999E8 File Offset: 0x00097BE8
				// (set) Token: 0x060022F5 RID: 8949 RVA: 0x00011DB1 File Offset: 0x0000FFB1
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17000A05 RID: 2565
				// (get) Token: 0x060022F6 RID: 8950 RVA: 0x00099A10 File Offset: 0x00097C10
				// (set) Token: 0x060022F7 RID: 8951 RVA: 0x00011DCC File Offset: 0x0000FFCC
				public KeyValuePair<Object, Object> __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2.NativeFieldInfoPtr___2__current);
						return new KeyValuePair<Object, Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<Object, Object>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<Object, Object>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17000A06 RID: 2566
				// (get) Token: 0x060022F8 RID: 8952 RVA: 0x00099A40 File Offset: 0x00097C40
				// (set) Token: 0x060022F9 RID: 8953 RVA: 0x00011DFA File Offset: 0x0000FFFA
				public unsafe DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000A07 RID: 2567
				// (get) Token: 0x060022FA RID: 8954 RVA: 0x00099A70 File Offset: 0x00097C70
				// (set) Token: 0x060022FB RID: 8955 RVA: 0x00011E19 File Offset: 0x00010019
				public unsafe IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> __7__wrap1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2.NativeFieldInfoPtr___7__wrap1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>._GetEnumerator_d__2.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040018D2 RID: 6354
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040018D3 RID: 6355
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040018D4 RID: 6356
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040018D5 RID: 6357
				private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

				// Token: 0x040018D6 RID: 6358
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040018D7 RID: 6359
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040018D8 RID: 6360
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040018D9 RID: 6361
				private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

				// Token: 0x040018DA RID: 6362
				private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_Object_Object_0;

				// Token: 0x040018DB RID: 6363
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040018DC RID: 6364
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020001C3 RID: 451
		[ObfuscatedName("Newtonsoft.Json.Serialization.DefaultContractResolver+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001E36 RID: 7734 RVA: 0x0008BDB4 File Offset: 0x00089FB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DefaultContractResolver.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultContractResolver.__c>.NativeClassPtr);
				DefaultContractResolver.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver.__c>.NativeClassPtr, "<>9");
				DefaultContractResolver.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver.__c>.NativeClassPtr, "<>9__40_0");
				DefaultContractResolver.__c.NativeFieldInfoPtr___9__40_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver.__c>.NativeClassPtr, "<>9__40_1");
				DefaultContractResolver.__c.NativeFieldInfoPtr___9__44_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver.__c>.NativeClassPtr, "<>9__44_0");
				DefaultContractResolver.__c.NativeFieldInfoPtr___9__44_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver.__c>.NativeClassPtr, "<>9__44_1");
				DefaultContractResolver.__c.NativeFieldInfoPtr___9__47_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver.__c>.NativeClassPtr, "<>9__47_0");
				DefaultContractResolver.__c.NativeFieldInfoPtr___9__75_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver.__c>.NativeClassPtr, "<>9__75_0");
				DefaultContractResolver.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.__c>.NativeClassPtr, 100665225);
				DefaultContractResolver.__c.NativeMethodInfoPtr__GetSerializableMembers_b__40_0_Internal_Boolean_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.__c>.NativeClassPtr, 100665226);
				DefaultContractResolver.__c.NativeMethodInfoPtr__GetSerializableMembers_b__40_1_Internal_Boolean_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.__c>.NativeClassPtr, 100665227);
				DefaultContractResolver.__c.NativeMethodInfoPtr__GetExtensionDataMemberForType_b__44_0_Internal_IEnumerable_1_MemberInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.__c>.NativeClassPtr, 100665228);
				DefaultContractResolver.__c.NativeMethodInfoPtr__GetExtensionDataMemberForType_b__44_1_Internal_Boolean_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.__c>.NativeClassPtr, 100665229);
				DefaultContractResolver.__c.NativeMethodInfoPtr__GetAttributeConstructor_b__47_0_Internal_Boolean_ConstructorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.__c>.NativeClassPtr, 100665230);
				DefaultContractResolver.__c.NativeMethodInfoPtr__CreateProperties_b__75_0_Internal_Int32_JsonProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.__c>.NativeClassPtr, 100665231);
			}

			// Token: 0x06001E37 RID: 7735 RVA: 0x0008BEF8 File Offset: 0x0008A0F8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultContractResolver.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E38 RID: 7736 RVA: 0x0008BF34 File Offset: 0x0008A134
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746856, XrefRangeEnd = 746863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetSerializableMembers_b__40_0(MemberInfo m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.__c.NativeMethodInfoPtr__GetSerializableMembers_b__40_0_Internal_Boolean_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E39 RID: 7737 RVA: 0x0008BF84 File Offset: 0x0008A184
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746863, XrefRangeEnd = 746866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetSerializableMembers_b__40_1(MemberInfo m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.__c.NativeMethodInfoPtr__GetSerializableMembers_b__40_1_Internal_Boolean_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E3A RID: 7738 RVA: 0x0008BFD4 File Offset: 0x0008A1D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746866, XrefRangeEnd = 746877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<MemberInfo> _GetExtensionDataMemberForType_b__44_0(Type baseType)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseType);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.__c.NativeMethodInfoPtr__GetExtensionDataMemberForType_b__44_0_Internal_IEnumerable_1_MemberInfo_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<MemberInfo>>(intPtr3) : null;
				}
			}

			// Token: 0x06001E3B RID: 7739 RVA: 0x0008C024 File Offset: 0x0008A224
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746877, XrefRangeEnd = 746906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetExtensionDataMemberForType_b__44_1(MemberInfo m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.__c.NativeMethodInfoPtr__GetExtensionDataMemberForType_b__44_1_Internal_Boolean_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E3C RID: 7740 RVA: 0x0008C074 File Offset: 0x0008A274
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746906, XrefRangeEnd = 746913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAttributeConstructor_b__47_0(ConstructorInfo c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.__c.NativeMethodInfoPtr__GetAttributeConstructor_b__47_0_Internal_Boolean_ConstructorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E3D RID: 7741 RVA: 0x0008C0C4 File Offset: 0x0008A2C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746913, XrefRangeEnd = 746915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CreateProperties_b__75_0(JsonProperty p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.__c.NativeMethodInfoPtr__CreateProperties_b__75_0_Internal_Int32_JsonProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E3E RID: 7742 RVA: 0x0000EEFD File Offset: 0x0000D0FD
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700087E RID: 2174
			// (get) Token: 0x06001E3F RID: 7743 RVA: 0x0008C114 File Offset: 0x0008A314
			// (set) Token: 0x06001E40 RID: 7744 RVA: 0x0000EF06 File Offset: 0x0000D106
			public unsafe static DefaultContractResolver.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultContractResolver.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultContractResolver.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultContractResolver.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700087F RID: 2175
			// (get) Token: 0x06001E41 RID: 7745 RVA: 0x0008C13C File Offset: 0x0008A33C
			// (set) Token: 0x06001E42 RID: 7746 RVA: 0x0000EF18 File Offset: 0x0000D118
			public unsafe static Func<MemberInfo, bool> __9__40_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultContractResolver.__c.NativeFieldInfoPtr___9__40_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MemberInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultContractResolver.__c.NativeFieldInfoPtr___9__40_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000880 RID: 2176
			// (get) Token: 0x06001E43 RID: 7747 RVA: 0x0008C164 File Offset: 0x0008A364
			// (set) Token: 0x06001E44 RID: 7748 RVA: 0x0000EF2A File Offset: 0x0000D12A
			public unsafe static Func<MemberInfo, bool> __9__40_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultContractResolver.__c.NativeFieldInfoPtr___9__40_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MemberInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultContractResolver.__c.NativeFieldInfoPtr___9__40_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000881 RID: 2177
			// (get) Token: 0x06001E45 RID: 7749 RVA: 0x0008C18C File Offset: 0x0008A38C
			// (set) Token: 0x06001E46 RID: 7750 RVA: 0x0000EF3C File Offset: 0x0000D13C
			public unsafe static Func<Type, IEnumerable<MemberInfo>> __9__44_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultContractResolver.__c.NativeFieldInfoPtr___9__44_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Type, IEnumerable<MemberInfo>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultContractResolver.__c.NativeFieldInfoPtr___9__44_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000882 RID: 2178
			// (get) Token: 0x06001E47 RID: 7751 RVA: 0x0008C1B4 File Offset: 0x0008A3B4
			// (set) Token: 0x06001E48 RID: 7752 RVA: 0x0000EF4E File Offset: 0x0000D14E
			public unsafe static Func<MemberInfo, bool> __9__44_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultContractResolver.__c.NativeFieldInfoPtr___9__44_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MemberInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultContractResolver.__c.NativeFieldInfoPtr___9__44_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000883 RID: 2179
			// (get) Token: 0x06001E49 RID: 7753 RVA: 0x0008C1DC File Offset: 0x0008A3DC
			// (set) Token: 0x06001E4A RID: 7754 RVA: 0x0000EF60 File Offset: 0x0000D160
			public unsafe static Func<ConstructorInfo, bool> __9__47_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultContractResolver.__c.NativeFieldInfoPtr___9__47_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ConstructorInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultContractResolver.__c.NativeFieldInfoPtr___9__47_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000884 RID: 2180
			// (get) Token: 0x06001E4B RID: 7755 RVA: 0x0008C204 File Offset: 0x0008A404
			// (set) Token: 0x06001E4C RID: 7756 RVA: 0x0000EF72 File Offset: 0x0000D172
			public unsafe static Func<JsonProperty, int> __9__75_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultContractResolver.__c.NativeFieldInfoPtr___9__75_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<JsonProperty, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultContractResolver.__c.NativeFieldInfoPtr___9__75_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400161E RID: 5662
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400161F RID: 5663
			private static readonly IntPtr NativeFieldInfoPtr___9__40_0;

			// Token: 0x04001620 RID: 5664
			private static readonly IntPtr NativeFieldInfoPtr___9__40_1;

			// Token: 0x04001621 RID: 5665
			private static readonly IntPtr NativeFieldInfoPtr___9__44_0;

			// Token: 0x04001622 RID: 5666
			private static readonly IntPtr NativeFieldInfoPtr___9__44_1;

			// Token: 0x04001623 RID: 5667
			private static readonly IntPtr NativeFieldInfoPtr___9__47_0;

			// Token: 0x04001624 RID: 5668
			private static readonly IntPtr NativeFieldInfoPtr___9__75_0;

			// Token: 0x04001625 RID: 5669
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001626 RID: 5670
			private static readonly IntPtr NativeMethodInfoPtr__GetSerializableMembers_b__40_0_Internal_Boolean_MemberInfo_0;

			// Token: 0x04001627 RID: 5671
			private static readonly IntPtr NativeMethodInfoPtr__GetSerializableMembers_b__40_1_Internal_Boolean_MemberInfo_0;

			// Token: 0x04001628 RID: 5672
			private static readonly IntPtr NativeMethodInfoPtr__GetExtensionDataMemberForType_b__44_0_Internal_IEnumerable_1_MemberInfo_Type_0;

			// Token: 0x04001629 RID: 5673
			private static readonly IntPtr NativeMethodInfoPtr__GetExtensionDataMemberForType_b__44_1_Internal_Boolean_MemberInfo_0;

			// Token: 0x0400162A RID: 5674
			private static readonly IntPtr NativeMethodInfoPtr__GetAttributeConstructor_b__47_0_Internal_Boolean_ConstructorInfo_0;

			// Token: 0x0400162B RID: 5675
			private static readonly IntPtr NativeMethodInfoPtr__CreateProperties_b__75_0_Internal_Int32_JsonProperty_0;
		}

		// Token: 0x020001C4 RID: 452
		[ObfuscatedName("Newtonsoft.Json.Serialization.DefaultContractResolver+<>c__DisplayClass42_0")]
		public sealed class __c__DisplayClass42_0 : Object
		{
			// Token: 0x06001E4D RID: 7757 RVA: 0x0008C22C File Offset: 0x0008A42C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass42_0()
			{
				Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass42_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, "<>c__DisplayClass42_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass42_0>.NativeClassPtr);
				DefaultContractResolver.__c__DisplayClass42_0.NativeFieldInfoPtr_namingStrategy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass42_0>.NativeClassPtr, "namingStrategy");
				DefaultContractResolver.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass42_0>.NativeClassPtr, 100665232);
				DefaultContractResolver.__c__DisplayClass42_0.NativeMethodInfoPtr__CreateObjectContract_b__0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass42_0>.NativeClassPtr, 100665233);
			}

			// Token: 0x06001E4E RID: 7758 RVA: 0x0008C294 File Offset: 0x0008A494
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass42_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass42_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E4F RID: 7759 RVA: 0x0008C2D0 File Offset: 0x0008A4D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746915, XrefRangeEnd = 746916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _CreateObjectContract_b__0(string s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.__c__DisplayClass42_0.NativeMethodInfoPtr__CreateObjectContract_b__0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001E50 RID: 7760 RVA: 0x0000EF84 File Offset: 0x0000D184
			public __c__DisplayClass42_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000885 RID: 2181
			// (get) Token: 0x06001E51 RID: 7761 RVA: 0x0008C318 File Offset: 0x0008A518
			// (set) Token: 0x06001E52 RID: 7762 RVA: 0x0000EF8D File Offset: 0x0000D18D
			public unsafe NamingStrategy namingStrategy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.__c__DisplayClass42_0.NativeFieldInfoPtr_namingStrategy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NamingStrategy>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.__c__DisplayClass42_0.NativeFieldInfoPtr_namingStrategy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400162C RID: 5676
			private static readonly IntPtr NativeFieldInfoPtr_namingStrategy;

			// Token: 0x0400162D RID: 5677
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400162E RID: 5678
			private static readonly IntPtr NativeMethodInfoPtr__CreateObjectContract_b__0_Internal_String_String_0;
		}

		// Token: 0x020001C5 RID: 453
		[ObfuscatedName("Newtonsoft.Json.Serialization.DefaultContractResolver+<>c__DisplayClass45_0")]
		public sealed class __c__DisplayClass45_0 : Object
		{
			// Token: 0x06001E53 RID: 7763 RVA: 0x0008C348 File Offset: 0x0008A548
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass45_0()
			{
				Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass45_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, "<>c__DisplayClass45_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass45_0>.NativeClassPtr);
				DefaultContractResolver.__c__DisplayClass45_0.NativeFieldInfoPtr_getExtensionDataDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass45_0>.NativeClassPtr, "getExtensionDataDictionary");
				DefaultContractResolver.__c__DisplayClass45_0.NativeFieldInfoPtr_member = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass45_0>.NativeClassPtr, "member");
				DefaultContractResolver.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass45_0>.NativeClassPtr, 100665234);
			}

			// Token: 0x06001E54 RID: 7764 RVA: 0x0008C3B0 File Offset: 0x0008A5B0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass45_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass45_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E55 RID: 7765 RVA: 0x0000EFAC File Offset: 0x0000D1AC
			public __c__DisplayClass45_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000886 RID: 2182
			// (get) Token: 0x06001E56 RID: 7766 RVA: 0x0008C3EC File Offset: 0x0008A5EC
			// (set) Token: 0x06001E57 RID: 7767 RVA: 0x0000EFB5 File Offset: 0x0000D1B5
			public unsafe Func<Object, Object> getExtensionDataDictionary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.__c__DisplayClass45_0.NativeFieldInfoPtr_getExtensionDataDictionary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.__c__DisplayClass45_0.NativeFieldInfoPtr_getExtensionDataDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000887 RID: 2183
			// (get) Token: 0x06001E58 RID: 7768 RVA: 0x0008C41C File Offset: 0x0008A61C
			// (set) Token: 0x06001E59 RID: 7769 RVA: 0x0000EFD4 File Offset: 0x0000D1D4
			public unsafe MemberInfo member
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.__c__DisplayClass45_0.NativeFieldInfoPtr_member);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.__c__DisplayClass45_0.NativeFieldInfoPtr_member), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400162F RID: 5679
			private static readonly IntPtr NativeFieldInfoPtr_getExtensionDataDictionary;

			// Token: 0x04001630 RID: 5680
			private static readonly IntPtr NativeFieldInfoPtr_member;

			// Token: 0x04001631 RID: 5681
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001C6 RID: 454
		[ObfuscatedName("Newtonsoft.Json.Serialization.DefaultContractResolver+<>c__DisplayClass45_1")]
		public sealed class __c__DisplayClass45_1 : Object
		{
			// Token: 0x06001E5A RID: 7770 RVA: 0x0008C44C File Offset: 0x0008A64C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass45_1()
			{
				Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass45_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, "<>c__DisplayClass45_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass45_1>.NativeClassPtr);
				DefaultContractResolver.__c__DisplayClass45_1.NativeFieldInfoPtr_setExtensionDataDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass45_1>.NativeClassPtr, "setExtensionDataDictionary");
				DefaultContractResolver.__c__DisplayClass45_1.NativeFieldInfoPtr_createExtensionDataDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass45_1>.NativeClassPtr, "createExtensionDataDictionary");
				DefaultContractResolver.__c__DisplayClass45_1.NativeFieldInfoPtr_setExtensionDataDictionaryValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass45_1>.NativeClassPtr, "setExtensionDataDictionaryValue");
				DefaultContractResolver.__c__DisplayClass45_1.NativeFieldInfoPtr_field_Public___c__DisplayClass45_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass45_1>.NativeClassPtr, "CS$<>8__locals1");
				DefaultContractResolver.__c__DisplayClass45_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass45_1>.NativeClassPtr, 100665235);
				DefaultContractResolver.__c__DisplayClass45_1.NativeMethodInfoPtr__SetExtensionDataDelegates_b__0_Internal_Void_Object_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass45_1>.NativeClassPtr, 100665236);
			}

			// Token: 0x06001E5B RID: 7771 RVA: 0x0008C4F0 File Offset: 0x0008A6F0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass45_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass45_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.__c__DisplayClass45_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E5C RID: 7772 RVA: 0x0008C52C File Offset: 0x0008A72C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746916, XrefRangeEnd = 746942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetExtensionDataDelegates_b__0(Object o, string key, Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.__c__DisplayClass45_1.NativeMethodInfoPtr__SetExtensionDataDelegates_b__0_Internal_Void_Object_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E5D RID: 7773 RVA: 0x0000EFF3 File Offset: 0x0000D1F3
			public __c__DisplayClass45_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000888 RID: 2184
			// (get) Token: 0x06001E5E RID: 7774 RVA: 0x0008C594 File Offset: 0x0008A794
			// (set) Token: 0x06001E5F RID: 7775 RVA: 0x0000EFFC File Offset: 0x0000D1FC
			public unsafe Action<Object, Object> setExtensionDataDictionary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.__c__DisplayClass45_1.NativeFieldInfoPtr_setExtensionDataDictionary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object, Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.__c__DisplayClass45_1.NativeFieldInfoPtr_setExtensionDataDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000889 RID: 2185
			// (get) Token: 0x06001E60 RID: 7776 RVA: 0x0008C5C4 File Offset: 0x0008A7C4
			// (set) Token: 0x06001E61 RID: 7777 RVA: 0x0000F01B File Offset: 0x0000D21B
			public unsafe Func<Object> createExtensionDataDictionary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.__c__DisplayClass45_1.NativeFieldInfoPtr_createExtensionDataDictionary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.__c__DisplayClass45_1.NativeFieldInfoPtr_createExtensionDataDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700088A RID: 2186
			// (get) Token: 0x06001E62 RID: 7778 RVA: 0x0008C5F4 File Offset: 0x0008A7F4
			// (set) Token: 0x06001E63 RID: 7779 RVA: 0x0000F03A File Offset: 0x0000D23A
			public unsafe MethodCall<Object, Object> setExtensionDataDictionaryValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.__c__DisplayClass45_1.NativeFieldInfoPtr_setExtensionDataDictionaryValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodCall<Object, Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.__c__DisplayClass45_1.NativeFieldInfoPtr_setExtensionDataDictionaryValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700088B RID: 2187
			// (get) Token: 0x06001E64 RID: 7780 RVA: 0x0008C624 File Offset: 0x0008A824
			// (set) Token: 0x06001E65 RID: 7781 RVA: 0x0000F059 File Offset: 0x0000D259
			public unsafe DefaultContractResolver.__c__DisplayClass45_0 field_Public___c__DisplayClass45_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.__c__DisplayClass45_1.NativeFieldInfoPtr_field_Public___c__DisplayClass45_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultContractResolver.__c__DisplayClass45_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.__c__DisplayClass45_1.NativeFieldInfoPtr_field_Public___c__DisplayClass45_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001632 RID: 5682
			private static readonly IntPtr NativeFieldInfoPtr_setExtensionDataDictionary;

			// Token: 0x04001633 RID: 5683
			private static readonly IntPtr NativeFieldInfoPtr_createExtensionDataDictionary;

			// Token: 0x04001634 RID: 5684
			private static readonly IntPtr NativeFieldInfoPtr_setExtensionDataDictionaryValue;

			// Token: 0x04001635 RID: 5685
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass45_0_0;

			// Token: 0x04001636 RID: 5686
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001637 RID: 5687
			private static readonly IntPtr NativeMethodInfoPtr__SetExtensionDataDelegates_b__0_Internal_Void_Object_String_Object_0;
		}

		// Token: 0x020001C7 RID: 455
		[ObfuscatedName("Newtonsoft.Json.Serialization.DefaultContractResolver+<>c__DisplayClass45_2")]
		public sealed class __c__DisplayClass45_2 : Object
		{
			// Token: 0x06001E66 RID: 7782 RVA: 0x0008C654 File Offset: 0x0008A854
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass45_2()
			{
				Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass45_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, "<>c__DisplayClass45_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass45_2>.NativeClassPtr);
				DefaultContractResolver.__c__DisplayClass45_2.NativeFieldInfoPtr_createEnumerableWrapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass45_2>.NativeClassPtr, "createEnumerableWrapper");
				DefaultContractResolver.__c__DisplayClass45_2.NativeFieldInfoPtr_field_Public___c__DisplayClass45_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass45_2>.NativeClassPtr, "CS$<>8__locals2");
				DefaultContractResolver.__c__DisplayClass45_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass45_2>.NativeClassPtr, 100665237);
				DefaultContractResolver.__c__DisplayClass45_2.NativeMethodInfoPtr__SetExtensionDataDelegates_b__1_Internal_IEnumerable_1_KeyValuePair_2_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass45_2>.NativeClassPtr, 100665238);
			}

			// Token: 0x06001E67 RID: 7783 RVA: 0x0008C6D0 File Offset: 0x0008A8D0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass45_2()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass45_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.__c__DisplayClass45_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E68 RID: 7784 RVA: 0x0008C70C File Offset: 0x0008A90C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746942, XrefRangeEnd = 746951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<KeyValuePair<Object, Object>> _SetExtensionDataDelegates_b__1(Object o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.__c__DisplayClass45_2.NativeMethodInfoPtr__SetExtensionDataDelegates_b__1_Internal_IEnumerable_1_KeyValuePair_2_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Object, Object>>>(intPtr3) : null;
				}
			}

			// Token: 0x06001E69 RID: 7785 RVA: 0x0000F078 File Offset: 0x0000D278
			public __c__DisplayClass45_2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700088C RID: 2188
			// (get) Token: 0x06001E6A RID: 7786 RVA: 0x0008C75C File Offset: 0x0008A95C
			// (set) Token: 0x06001E6B RID: 7787 RVA: 0x0000F081 File Offset: 0x0000D281
			public unsafe ObjectConstructor<Object> createEnumerableWrapper
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.__c__DisplayClass45_2.NativeFieldInfoPtr_createEnumerableWrapper);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectConstructor<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.__c__DisplayClass45_2.NativeFieldInfoPtr_createEnumerableWrapper), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700088D RID: 2189
			// (get) Token: 0x06001E6C RID: 7788 RVA: 0x0008C78C File Offset: 0x0008A98C
			// (set) Token: 0x06001E6D RID: 7789 RVA: 0x0000F0A0 File Offset: 0x0000D2A0
			public unsafe DefaultContractResolver.__c__DisplayClass45_0 field_Public___c__DisplayClass45_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.__c__DisplayClass45_2.NativeFieldInfoPtr_field_Public___c__DisplayClass45_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultContractResolver.__c__DisplayClass45_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.__c__DisplayClass45_2.NativeFieldInfoPtr_field_Public___c__DisplayClass45_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001638 RID: 5688
			private static readonly IntPtr NativeFieldInfoPtr_createEnumerableWrapper;

			// Token: 0x04001639 RID: 5689
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass45_0_0;

			// Token: 0x0400163A RID: 5690
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400163B RID: 5691
			private static readonly IntPtr NativeMethodInfoPtr__SetExtensionDataDelegates_b__1_Internal_IEnumerable_1_KeyValuePair_2_Object_Object_Object_0;
		}

		// Token: 0x020001C8 RID: 456
		[ObfuscatedName("Newtonsoft.Json.Serialization.DefaultContractResolver+<>c__DisplayClass62_0")]
		public sealed class __c__DisplayClass62_0 : Object
		{
			// Token: 0x06001E6E RID: 7790 RVA: 0x0008C7BC File Offset: 0x0008A9BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass62_0()
			{
				Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass62_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, "<>c__DisplayClass62_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass62_0>.NativeClassPtr);
				DefaultContractResolver.__c__DisplayClass62_0.NativeFieldInfoPtr_namingStrategy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass62_0>.NativeClassPtr, "namingStrategy");
				DefaultContractResolver.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass62_0>.NativeClassPtr, 100665239);
				DefaultContractResolver.__c__DisplayClass62_0.NativeMethodInfoPtr__CreateDictionaryContract_b__0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass62_0>.NativeClassPtr, 100665240);
			}

			// Token: 0x06001E6F RID: 7791 RVA: 0x0008C824 File Offset: 0x0008AA24
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass62_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass62_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E70 RID: 7792 RVA: 0x0008C860 File Offset: 0x0008AA60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _CreateDictionaryContract_b__0(string s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.__c__DisplayClass62_0.NativeMethodInfoPtr__CreateDictionaryContract_b__0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001E71 RID: 7793 RVA: 0x0000F0BF File Offset: 0x0000D2BF
			public __c__DisplayClass62_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700088E RID: 2190
			// (get) Token: 0x06001E72 RID: 7794 RVA: 0x0008C8A8 File Offset: 0x0008AAA8
			// (set) Token: 0x06001E73 RID: 7795 RVA: 0x0000F0C8 File Offset: 0x0000D2C8
			public unsafe NamingStrategy namingStrategy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.__c__DisplayClass62_0.NativeFieldInfoPtr_namingStrategy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NamingStrategy>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.__c__DisplayClass62_0.NativeFieldInfoPtr_namingStrategy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400163C RID: 5692
			private static readonly IntPtr NativeFieldInfoPtr_namingStrategy;

			// Token: 0x0400163D RID: 5693
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400163E RID: 5694
			private static readonly IntPtr NativeMethodInfoPtr__CreateDictionaryContract_b__0_Internal_String_String_0;
		}

		// Token: 0x020001C9 RID: 457
		[ObfuscatedName("Newtonsoft.Json.Serialization.DefaultContractResolver+<>c__DisplayClass67_0")]
		public sealed class __c__DisplayClass67_0 : Object
		{
			// Token: 0x06001E74 RID: 7796 RVA: 0x0008C8D8 File Offset: 0x0008AAD8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass67_0()
			{
				Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass67_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, "<>c__DisplayClass67_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass67_0>.NativeClassPtr);
				DefaultContractResolver.__c__DisplayClass67_0.NativeFieldInfoPtr_namingStrategy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass67_0>.NativeClassPtr, "namingStrategy");
				DefaultContractResolver.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass67_0>.NativeClassPtr, 100665241);
				DefaultContractResolver.__c__DisplayClass67_0.NativeMethodInfoPtr__CreateDynamicContract_b__0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass67_0>.NativeClassPtr, 100665242);
			}

			// Token: 0x06001E75 RID: 7797 RVA: 0x0008C940 File Offset: 0x0008AB40
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass67_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass67_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E76 RID: 7798 RVA: 0x0008C97C File Offset: 0x0008AB7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _CreateDynamicContract_b__0(string s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.__c__DisplayClass67_0.NativeMethodInfoPtr__CreateDynamicContract_b__0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001E77 RID: 7799 RVA: 0x0000F0E7 File Offset: 0x0000D2E7
			public __c__DisplayClass67_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700088F RID: 2191
			// (get) Token: 0x06001E78 RID: 7800 RVA: 0x0008C9C4 File Offset: 0x0008ABC4
			// (set) Token: 0x06001E79 RID: 7801 RVA: 0x0000F0F0 File Offset: 0x0000D2F0
			public unsafe NamingStrategy namingStrategy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.__c__DisplayClass67_0.NativeFieldInfoPtr_namingStrategy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NamingStrategy>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.__c__DisplayClass67_0.NativeFieldInfoPtr_namingStrategy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400163F RID: 5695
			private static readonly IntPtr NativeFieldInfoPtr_namingStrategy;

			// Token: 0x04001640 RID: 5696
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001641 RID: 5697
			private static readonly IntPtr NativeMethodInfoPtr__CreateDynamicContract_b__0_Internal_String_String_0;
		}

		// Token: 0x020001CA RID: 458
		[ObfuscatedName("Newtonsoft.Json.Serialization.DefaultContractResolver+<>c__DisplayClass80_0")]
		public sealed class __c__DisplayClass80_0 : Object
		{
			// Token: 0x06001E7A RID: 7802 RVA: 0x0008C9F4 File Offset: 0x0008ABF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass80_0()
			{
				Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass80_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, "<>c__DisplayClass80_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass80_0>.NativeClassPtr);
				DefaultContractResolver.__c__DisplayClass80_0.NativeFieldInfoPtr_shouldSerializeCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass80_0>.NativeClassPtr, "shouldSerializeCall");
				DefaultContractResolver.__c__DisplayClass80_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass80_0>.NativeClassPtr, 100665243);
				DefaultContractResolver.__c__DisplayClass80_0.NativeMethodInfoPtr__CreateShouldSerializeTest_b__0_Internal_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass80_0>.NativeClassPtr, 100665244);
			}

			// Token: 0x06001E7B RID: 7803 RVA: 0x0008CA5C File Offset: 0x0008AC5C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass80_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass80_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.__c__DisplayClass80_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E7C RID: 7804 RVA: 0x0008CA98 File Offset: 0x0008AC98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746951, XrefRangeEnd = 746957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateShouldSerializeTest_b__0(Object o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.__c__DisplayClass80_0.NativeMethodInfoPtr__CreateShouldSerializeTest_b__0_Internal_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E7D RID: 7805 RVA: 0x0000F10F File Offset: 0x0000D30F
			public __c__DisplayClass80_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000890 RID: 2192
			// (get) Token: 0x06001E7E RID: 7806 RVA: 0x0008CAE8 File Offset: 0x0008ACE8
			// (set) Token: 0x06001E7F RID: 7807 RVA: 0x0000F118 File Offset: 0x0000D318
			public unsafe MethodCall<Object, Object> shouldSerializeCall
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.__c__DisplayClass80_0.NativeFieldInfoPtr_shouldSerializeCall);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodCall<Object, Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.__c__DisplayClass80_0.NativeFieldInfoPtr_shouldSerializeCall), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001642 RID: 5698
			private static readonly IntPtr NativeFieldInfoPtr_shouldSerializeCall;

			// Token: 0x04001643 RID: 5699
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001644 RID: 5700
			private static readonly IntPtr NativeMethodInfoPtr__CreateShouldSerializeTest_b__0_Internal_Boolean_Object_0;
		}

		// Token: 0x020001CB RID: 459
		[ObfuscatedName("Newtonsoft.Json.Serialization.DefaultContractResolver+<>c__DisplayClass81_0")]
		public sealed class __c__DisplayClass81_0 : Object
		{
			// Token: 0x06001E80 RID: 7808 RVA: 0x0008CB18 File Offset: 0x0008AD18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass81_0()
			{
				Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass81_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultContractResolver>.NativeClassPtr, "<>c__DisplayClass81_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass81_0>.NativeClassPtr);
				DefaultContractResolver.__c__DisplayClass81_0.NativeFieldInfoPtr_specifiedPropertyGet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass81_0>.NativeClassPtr, "specifiedPropertyGet");
				DefaultContractResolver.__c__DisplayClass81_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass81_0>.NativeClassPtr, 100665245);
				DefaultContractResolver.__c__DisplayClass81_0.NativeMethodInfoPtr__SetIsSpecifiedActions_b__0_Internal_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass81_0>.NativeClassPtr, 100665246);
			}

			// Token: 0x06001E81 RID: 7809 RVA: 0x0008CB80 File Offset: 0x0008AD80
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass81_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultContractResolver.__c__DisplayClass81_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.__c__DisplayClass81_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E82 RID: 7810 RVA: 0x0008CBBC File Offset: 0x0008ADBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746957, XrefRangeEnd = 746960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetIsSpecifiedActions_b__0(Object o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultContractResolver.__c__DisplayClass81_0.NativeMethodInfoPtr__SetIsSpecifiedActions_b__0_Internal_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E83 RID: 7811 RVA: 0x0000F137 File Offset: 0x0000D337
			public __c__DisplayClass81_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000891 RID: 2193
			// (get) Token: 0x06001E84 RID: 7812 RVA: 0x0008CC0C File Offset: 0x0008AE0C
			// (set) Token: 0x06001E85 RID: 7813 RVA: 0x0000F140 File Offset: 0x0000D340
			public unsafe Func<Object, Object> specifiedPropertyGet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.__c__DisplayClass81_0.NativeFieldInfoPtr_specifiedPropertyGet);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultContractResolver.__c__DisplayClass81_0.NativeFieldInfoPtr_specifiedPropertyGet), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001645 RID: 5701
			private static readonly IntPtr NativeFieldInfoPtr_specifiedPropertyGet;

			// Token: 0x04001646 RID: 5702
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001647 RID: 5703
			private static readonly IntPtr NativeMethodInfoPtr__SetIsSpecifiedActions_b__0_Internal_Boolean_Object_0;
		}
	}
}

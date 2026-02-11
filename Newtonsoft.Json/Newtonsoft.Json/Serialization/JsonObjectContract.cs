using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200008D RID: 141
	public class JsonObjectContract : JsonContainerContract
	{
		// Token: 0x06000B76 RID: 2934 RVA: 0x000463D0 File Offset: 0x000445D0
		// Note: this type is marked as 'beforefieldinit'.
		static JsonObjectContract()
		{
			Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "JsonObjectContract");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr);
			JsonObjectContract.NativeFieldInfoPtr__MemberSerialization_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, "<MemberSerialization>k__BackingField");
			JsonObjectContract.NativeFieldInfoPtr__MissingMemberHandling_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, "<MissingMemberHandling>k__BackingField");
			JsonObjectContract.NativeFieldInfoPtr__ItemRequired_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, "<ItemRequired>k__BackingField");
			JsonObjectContract.NativeFieldInfoPtr__ItemNullValueHandling_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, "<ItemNullValueHandling>k__BackingField");
			JsonObjectContract.NativeFieldInfoPtr__Properties_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, "<Properties>k__BackingField");
			JsonObjectContract.NativeFieldInfoPtr__ExtensionDataSetter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, "<ExtensionDataSetter>k__BackingField");
			JsonObjectContract.NativeFieldInfoPtr__ExtensionDataGetter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, "<ExtensionDataGetter>k__BackingField");
			JsonObjectContract.NativeFieldInfoPtr__ExtensionDataNameResolver_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, "<ExtensionDataNameResolver>k__BackingField");
			JsonObjectContract.NativeFieldInfoPtr_ExtensionDataIsJToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, "ExtensionDataIsJToken");
			JsonObjectContract.NativeFieldInfoPtr__hasRequiredOrDefaultValueProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, "_hasRequiredOrDefaultValueProperties");
			JsonObjectContract.NativeFieldInfoPtr__overrideCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, "_overrideCreator");
			JsonObjectContract.NativeFieldInfoPtr__parameterizedCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, "_parameterizedCreator");
			JsonObjectContract.NativeFieldInfoPtr__creatorParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, "_creatorParameters");
			JsonObjectContract.NativeFieldInfoPtr__extensionDataValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, "_extensionDataValueType");
			JsonObjectContract.NativeMethodInfoPtr_get_MemberSerialization_Public_get_MemberSerialization_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, 100665413);
			JsonObjectContract.NativeMethodInfoPtr_set_MemberSerialization_Public_set_Void_MemberSerialization_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, 100665414);
			JsonObjectContract.NativeMethodInfoPtr_get_MissingMemberHandling_Public_get_Nullable_1_MissingMemberHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, 100665415);
			JsonObjectContract.NativeMethodInfoPtr_set_MissingMemberHandling_Public_set_Void_Nullable_1_MissingMemberHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, 100665416);
			JsonObjectContract.NativeMethodInfoPtr_get_ItemRequired_Public_get_Nullable_1_Required_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, 100665417);
			JsonObjectContract.NativeMethodInfoPtr_set_ItemRequired_Public_set_Void_Nullable_1_Required_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, 100665418);
			JsonObjectContract.NativeMethodInfoPtr_get_ItemNullValueHandling_Public_get_Nullable_1_NullValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, 100665419);
			JsonObjectContract.NativeMethodInfoPtr_set_ItemNullValueHandling_Public_set_Void_Nullable_1_NullValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, 100665420);
			JsonObjectContract.NativeMethodInfoPtr_get_Properties_Public_get_JsonPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, 100665421);
			JsonObjectContract.NativeMethodInfoPtr_get_CreatorParameters_Public_get_JsonPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, 100665422);
			JsonObjectContract.NativeMethodInfoPtr_get_OverrideCreator_Public_get_ObjectConstructor_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, 100665423);
			JsonObjectContract.NativeMethodInfoPtr_set_OverrideCreator_Public_set_Void_ObjectConstructor_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, 100665424);
			JsonObjectContract.NativeMethodInfoPtr_get_ParameterizedCreator_Internal_get_ObjectConstructor_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, 100665425);
			JsonObjectContract.NativeMethodInfoPtr_set_ParameterizedCreator_Internal_set_Void_ObjectConstructor_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, 100665426);
			JsonObjectContract.NativeMethodInfoPtr_get_ExtensionDataSetter_Public_get_ExtensionDataSetter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, 100665427);
			JsonObjectContract.NativeMethodInfoPtr_set_ExtensionDataSetter_Public_set_Void_ExtensionDataSetter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, 100665428);
			JsonObjectContract.NativeMethodInfoPtr_get_ExtensionDataGetter_Public_get_ExtensionDataGetter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, 100665429);
			JsonObjectContract.NativeMethodInfoPtr_set_ExtensionDataGetter_Public_set_Void_ExtensionDataGetter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, 100665430);
			JsonObjectContract.NativeMethodInfoPtr_get_ExtensionDataValueType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, 100665431);
			JsonObjectContract.NativeMethodInfoPtr_set_ExtensionDataValueType_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, 100665432);
			JsonObjectContract.NativeMethodInfoPtr_get_ExtensionDataNameResolver_Public_get_Func_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, 100665433);
			JsonObjectContract.NativeMethodInfoPtr_set_ExtensionDataNameResolver_Public_set_Void_Func_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, 100665434);
			JsonObjectContract.NativeMethodInfoPtr_get_HasRequiredOrDefaultValueProperties_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, 100665435);
			JsonObjectContract.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, 100665436);
			JsonObjectContract.NativeMethodInfoPtr_GetUninitializedObject_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr, 100665437);
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x0004670C File Offset: 0x0004490C
		// (set) Token: 0x06000B78 RID: 2936 RVA: 0x00046748 File Offset: 0x00044948
		public unsafe MemberSerialization MemberSerialization
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectContract.NativeMethodInfoPtr_get_MemberSerialization_Public_get_MemberSerialization_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectContract.NativeMethodInfoPtr_set_MemberSerialization_Public_set_Void_MemberSerialization_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x00046788 File Offset: 0x00044988
		// (set) Token: 0x06000B7A RID: 2938 RVA: 0x000467C0 File Offset: 0x000449C0
		public unsafe Nullable<MissingMemberHandling> MissingMemberHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectContract.NativeMethodInfoPtr_get_MissingMemberHandling_Public_get_Nullable_1_MissingMemberHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<MissingMemberHandling>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectContract.NativeMethodInfoPtr_set_MissingMemberHandling_Public_set_Void_Nullable_1_MissingMemberHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x00046808 File Offset: 0x00044A08
		// (set) Token: 0x06000B7C RID: 2940 RVA: 0x00046840 File Offset: 0x00044A40
		public unsafe Nullable<Required> ItemRequired
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectContract.NativeMethodInfoPtr_get_ItemRequired_Public_get_Nullable_1_Required_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<Required>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectContract.NativeMethodInfoPtr_set_ItemRequired_Public_set_Void_Nullable_1_Required_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x00046888 File Offset: 0x00044A88
		// (set) Token: 0x06000B7E RID: 2942 RVA: 0x000468C0 File Offset: 0x00044AC0
		public unsafe Nullable<NullValueHandling> ItemNullValueHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectContract.NativeMethodInfoPtr_get_ItemNullValueHandling_Public_get_Nullable_1_NullValueHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectContract.NativeMethodInfoPtr_set_ItemNullValueHandling_Public_set_Void_Nullable_1_NullValueHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x00046908 File Offset: 0x00044B08
		public unsafe JsonPropertyCollection Properties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectContract.NativeMethodInfoPtr_get_Properties_Public_get_JsonPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000B80 RID: 2944 RVA: 0x00046948 File Offset: 0x00044B48
		public unsafe JsonPropertyCollection CreatorParameters
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 749914, RefRangeEnd = 749920, XrefRangeStart = 749909, XrefRangeEnd = 749914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectContract.NativeMethodInfoPtr_get_CreatorParameters_Public_get_JsonPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x00046988 File Offset: 0x00044B88
		// (set) Token: 0x06000B82 RID: 2946 RVA: 0x000469C8 File Offset: 0x00044BC8
		public unsafe ObjectConstructor<Object> OverrideCreator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectContract.NativeMethodInfoPtr_get_OverrideCreator_Public_get_ObjectConstructor_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectConstructor<Object>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectContract.NativeMethodInfoPtr_set_OverrideCreator_Public_set_Void_ObjectConstructor_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x00046A0C File Offset: 0x00044C0C
		// (set) Token: 0x06000B84 RID: 2948 RVA: 0x00046A4C File Offset: 0x00044C4C
		public unsafe ObjectConstructor<Object> ParameterizedCreator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectContract.NativeMethodInfoPtr_get_ParameterizedCreator_Internal_get_ObjectConstructor_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectConstructor<Object>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectContract.NativeMethodInfoPtr_set_ParameterizedCreator_Internal_set_Void_ObjectConstructor_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x00046A90 File Offset: 0x00044C90
		// (set) Token: 0x06000B86 RID: 2950 RVA: 0x00046AD0 File Offset: 0x00044CD0
		public unsafe ExtensionDataSetter ExtensionDataSetter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectContract.NativeMethodInfoPtr_get_ExtensionDataSetter_Public_get_ExtensionDataSetter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExtensionDataSetter>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectContract.NativeMethodInfoPtr_set_ExtensionDataSetter_Public_set_Void_ExtensionDataSetter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x00046B14 File Offset: 0x00044D14
		// (set) Token: 0x06000B88 RID: 2952 RVA: 0x00046B54 File Offset: 0x00044D54
		public unsafe ExtensionDataGetter ExtensionDataGetter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectContract.NativeMethodInfoPtr_get_ExtensionDataGetter_Public_get_ExtensionDataGetter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExtensionDataGetter>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectContract.NativeMethodInfoPtr_set_ExtensionDataGetter_Public_set_Void_ExtensionDataGetter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x00046B98 File Offset: 0x00044D98
		// (set) Token: 0x06000B8A RID: 2954 RVA: 0x00046BD8 File Offset: 0x00044DD8
		public unsafe Type ExtensionDataValueType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectContract.NativeMethodInfoPtr_get_ExtensionDataValueType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749920, XrefRangeEnd = 749931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectContract.NativeMethodInfoPtr_set_ExtensionDataValueType_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000B8B RID: 2955 RVA: 0x00046C1C File Offset: 0x00044E1C
		// (set) Token: 0x06000B8C RID: 2956 RVA: 0x00046C5C File Offset: 0x00044E5C
		public unsafe Func<string, string> ExtensionDataNameResolver
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectContract.NativeMethodInfoPtr_get_ExtensionDataNameResolver_Public_get_Func_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectContract.NativeMethodInfoPtr_set_ExtensionDataNameResolver_Public_set_Void_Func_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000B8D RID: 2957 RVA: 0x00046CA0 File Offset: 0x00044EA0
		public unsafe bool HasRequiredOrDefaultValueProperties
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 749969, RefRangeEnd = 749971, XrefRangeStart = 749931, XrefRangeEnd = 749969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectContract.NativeMethodInfoPtr_get_HasRequiredOrDefaultValueProperties_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x00046CDC File Offset: 0x00044EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749971, XrefRangeEnd = 749977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonObjectContract(Type underlyingType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonObjectContract>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(underlyingType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectContract.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x00046D28 File Offset: 0x00044F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749977, XrefRangeEnd = 749995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetUninitializedObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonObjectContract.NativeMethodInfoPtr_GetUninitializedObject_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00005B2B File Offset: 0x00003D2B
		public JsonObjectContract(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000B91 RID: 2961 RVA: 0x00046D68 File Offset: 0x00044F68
		// (set) Token: 0x06000B92 RID: 2962 RVA: 0x00005B34 File Offset: 0x00003D34
		public unsafe MemberSerialization _MemberSerialization_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr__MemberSerialization_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr__MemberSerialization_k__BackingField)) = value;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000B93 RID: 2963 RVA: 0x00046D90 File Offset: 0x00044F90
		// (set) Token: 0x06000B94 RID: 2964 RVA: 0x00005B4F File Offset: 0x00003D4F
		public Nullable<MissingMemberHandling> _MissingMemberHandling_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr__MissingMemberHandling_k__BackingField);
				return new Nullable<MissingMemberHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Newtonsoft.Json.MissingMemberHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr__MissingMemberHandling_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Newtonsoft.Json.MissingMemberHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000B95 RID: 2965 RVA: 0x00046DC0 File Offset: 0x00044FC0
		// (set) Token: 0x06000B96 RID: 2966 RVA: 0x00005B7D File Offset: 0x00003D7D
		public Nullable<Required> _ItemRequired_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr__ItemRequired_k__BackingField);
				return new Nullable<Required>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Required>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr__ItemRequired_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Required>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x00046DF0 File Offset: 0x00044FF0
		// (set) Token: 0x06000B98 RID: 2968 RVA: 0x00005BAB File Offset: 0x00003DAB
		public Nullable<NullValueHandling> _ItemNullValueHandling_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr__ItemNullValueHandling_k__BackingField);
				return new Nullable<NullValueHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<NullValueHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr__ItemNullValueHandling_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<NullValueHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x00046E20 File Offset: 0x00045020
		// (set) Token: 0x06000B9A RID: 2970 RVA: 0x00005BD9 File Offset: 0x00003DD9
		public unsafe JsonPropertyCollection _Properties_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr__Properties_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonPropertyCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr__Properties_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x00046E50 File Offset: 0x00045050
		// (set) Token: 0x06000B9C RID: 2972 RVA: 0x00005BF8 File Offset: 0x00003DF8
		public unsafe ExtensionDataSetter _ExtensionDataSetter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr__ExtensionDataSetter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExtensionDataSetter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr__ExtensionDataSetter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000B9D RID: 2973 RVA: 0x00046E80 File Offset: 0x00045080
		// (set) Token: 0x06000B9E RID: 2974 RVA: 0x00005C17 File Offset: 0x00003E17
		public unsafe ExtensionDataGetter _ExtensionDataGetter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr__ExtensionDataGetter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExtensionDataGetter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr__ExtensionDataGetter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x00046EB0 File Offset: 0x000450B0
		// (set) Token: 0x06000BA0 RID: 2976 RVA: 0x00005C36 File Offset: 0x00003E36
		public unsafe Func<string, string> _ExtensionDataNameResolver_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr__ExtensionDataNameResolver_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr__ExtensionDataNameResolver_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000BA1 RID: 2977 RVA: 0x00046EE0 File Offset: 0x000450E0
		// (set) Token: 0x06000BA2 RID: 2978 RVA: 0x00005C55 File Offset: 0x00003E55
		public unsafe bool ExtensionDataIsJToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr_ExtensionDataIsJToken);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr_ExtensionDataIsJToken)) = value;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x00046F08 File Offset: 0x00045108
		// (set) Token: 0x06000BA4 RID: 2980 RVA: 0x00005C70 File Offset: 0x00003E70
		public Nullable<bool> _hasRequiredOrDefaultValueProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr__hasRequiredOrDefaultValueProperties);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr__hasRequiredOrDefaultValueProperties), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x00046F38 File Offset: 0x00045138
		// (set) Token: 0x06000BA6 RID: 2982 RVA: 0x00005C9E File Offset: 0x00003E9E
		public unsafe ObjectConstructor<Object> _overrideCreator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr__overrideCreator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectConstructor<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr__overrideCreator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x00046F68 File Offset: 0x00045168
		// (set) Token: 0x06000BA8 RID: 2984 RVA: 0x00005CBD File Offset: 0x00003EBD
		public unsafe ObjectConstructor<Object> _parameterizedCreator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr__parameterizedCreator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectConstructor<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr__parameterizedCreator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x00046F98 File Offset: 0x00045198
		// (set) Token: 0x06000BAA RID: 2986 RVA: 0x00005CDC File Offset: 0x00003EDC
		public unsafe JsonPropertyCollection _creatorParameters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr__creatorParameters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonPropertyCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr__creatorParameters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000BAB RID: 2987 RVA: 0x00046FC8 File Offset: 0x000451C8
		// (set) Token: 0x06000BAC RID: 2988 RVA: 0x00005CFB File Offset: 0x00003EFB
		public unsafe Type _extensionDataValueType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr__extensionDataValueType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonObjectContract.NativeFieldInfoPtr__extensionDataValueType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeFieldInfoPtr__MemberSerialization_k__BackingField;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeFieldInfoPtr__MissingMemberHandling_k__BackingField;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeFieldInfoPtr__ItemRequired_k__BackingField;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeFieldInfoPtr__ItemNullValueHandling_k__BackingField;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeFieldInfoPtr__Properties_k__BackingField;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeFieldInfoPtr__ExtensionDataSetter_k__BackingField;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeFieldInfoPtr__ExtensionDataGetter_k__BackingField;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeFieldInfoPtr__ExtensionDataNameResolver_k__BackingField;

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeFieldInfoPtr_ExtensionDataIsJToken;

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeFieldInfoPtr__hasRequiredOrDefaultValueProperties;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeFieldInfoPtr__overrideCreator;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeFieldInfoPtr__parameterizedCreator;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeFieldInfoPtr__creatorParameters;

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeFieldInfoPtr__extensionDataValueType;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberSerialization_Public_get_MemberSerialization_0;

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeMethodInfoPtr_set_MemberSerialization_Public_set_Void_MemberSerialization_0;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeMethodInfoPtr_get_MissingMemberHandling_Public_get_Nullable_1_MissingMemberHandling_0;

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeMethodInfoPtr_set_MissingMemberHandling_Public_set_Void_Nullable_1_MissingMemberHandling_0;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemRequired_Public_get_Nullable_1_Required_0;

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemRequired_Public_set_Void_Nullable_1_Required_0;

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemNullValueHandling_Public_get_Nullable_1_NullValueHandling_0;

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemNullValueHandling_Public_set_Void_Nullable_1_NullValueHandling_0;

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_get_JsonPropertyCollection_0;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeMethodInfoPtr_get_CreatorParameters_Public_get_JsonPropertyCollection_0;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeMethodInfoPtr_get_OverrideCreator_Public_get_ObjectConstructor_1_Object_0;

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeMethodInfoPtr_set_OverrideCreator_Public_set_Void_ObjectConstructor_1_Object_0;

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeMethodInfoPtr_get_ParameterizedCreator_Internal_get_ObjectConstructor_1_Object_0;

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeMethodInfoPtr_set_ParameterizedCreator_Internal_set_Void_ObjectConstructor_1_Object_0;

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtensionDataSetter_Public_get_ExtensionDataSetter_0;

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeMethodInfoPtr_set_ExtensionDataSetter_Public_set_Void_ExtensionDataSetter_0;

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtensionDataGetter_Public_get_ExtensionDataGetter_0;

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeMethodInfoPtr_set_ExtensionDataGetter_Public_set_Void_ExtensionDataGetter_0;

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtensionDataValueType_Public_get_Type_0;

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeMethodInfoPtr_set_ExtensionDataValueType_Public_set_Void_Type_0;

		// Token: 0x04000977 RID: 2423
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtensionDataNameResolver_Public_get_Func_2_String_String_0;

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeMethodInfoPtr_set_ExtensionDataNameResolver_Public_set_Void_Func_2_String_String_0;

		// Token: 0x04000979 RID: 2425
		private static readonly IntPtr NativeMethodInfoPtr_get_HasRequiredOrDefaultValueProperties_Internal_get_Boolean_0;

		// Token: 0x0400097A RID: 2426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeMethodInfoPtr_GetUninitializedObject_Internal_Object_0;
	}
}

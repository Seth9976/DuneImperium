using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020000A7 RID: 167
	public class JsonSchemaGenerator : Object
	{
		// Token: 0x06000EFC RID: 3836 RVA: 0x00055CC0 File Offset: 0x00053EC0
		// Note: this type is marked as 'beforefieldinit'.
		static JsonSchemaGenerator()
		{
			Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Schema", "JsonSchemaGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr);
			JsonSchemaGenerator.NativeFieldInfoPtr__UndefinedSchemaIdHandling_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, "<UndefinedSchemaIdHandling>k__BackingField");
			JsonSchemaGenerator.NativeFieldInfoPtr__contractResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, "_contractResolver");
			JsonSchemaGenerator.NativeFieldInfoPtr__resolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, "_resolver");
			JsonSchemaGenerator.NativeFieldInfoPtr__stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, "_stack");
			JsonSchemaGenerator.NativeFieldInfoPtr__currentSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, "_currentSchema");
			JsonSchemaGenerator.NativeMethodInfoPtr_get_UndefinedSchemaIdHandling_Public_get_UndefinedSchemaIdHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, 100665952);
			JsonSchemaGenerator.NativeMethodInfoPtr_set_UndefinedSchemaIdHandling_Public_set_Void_UndefinedSchemaIdHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, 100665953);
			JsonSchemaGenerator.NativeMethodInfoPtr_get_ContractResolver_Public_get_IContractResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, 100665954);
			JsonSchemaGenerator.NativeMethodInfoPtr_set_ContractResolver_Public_set_Void_IContractResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, 100665955);
			JsonSchemaGenerator.NativeMethodInfoPtr_get_CurrentSchema_Private_get_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, 100665956);
			JsonSchemaGenerator.NativeMethodInfoPtr_Push_Private_Void_TypeSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, 100665957);
			JsonSchemaGenerator.NativeMethodInfoPtr_Pop_Private_TypeSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, 100665958);
			JsonSchemaGenerator.NativeMethodInfoPtr_Generate_Public_JsonSchema_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, 100665959);
			JsonSchemaGenerator.NativeMethodInfoPtr_Generate_Public_JsonSchema_Type_JsonSchemaResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, 100665960);
			JsonSchemaGenerator.NativeMethodInfoPtr_Generate_Public_JsonSchema_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, 100665961);
			JsonSchemaGenerator.NativeMethodInfoPtr_Generate_Public_JsonSchema_Type_JsonSchemaResolver_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, 100665962);
			JsonSchemaGenerator.NativeMethodInfoPtr_GetTitle_Private_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, 100665963);
			JsonSchemaGenerator.NativeMethodInfoPtr_GetDescription_Private_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, 100665964);
			JsonSchemaGenerator.NativeMethodInfoPtr_GetTypeId_Private_String_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, 100665965);
			JsonSchemaGenerator.NativeMethodInfoPtr_GenerateInternal_Private_JsonSchema_Type_Required_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, 100665966);
			JsonSchemaGenerator.NativeMethodInfoPtr_AddNullType_Private_JsonSchemaType_JsonSchemaType_Required_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, 100665967);
			JsonSchemaGenerator.NativeMethodInfoPtr_HasFlag_Private_Boolean_DefaultValueHandling_DefaultValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, 100665968);
			JsonSchemaGenerator.NativeMethodInfoPtr_GenerateObjectSchema_Private_Void_Type_JsonObjectContract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, 100665969);
			JsonSchemaGenerator.NativeMethodInfoPtr_GenerateISerializableContract_Private_Void_Type_JsonISerializableContract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, 100665970);
			JsonSchemaGenerator.NativeMethodInfoPtr_HasFlag_Internal_Static_Boolean_Nullable_1_JsonSchemaType_JsonSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, 100665971);
			JsonSchemaGenerator.NativeMethodInfoPtr_GetJsonSchemaType_Private_JsonSchemaType_Type_Required_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, 100665972);
			JsonSchemaGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, 100665973);
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x00055F0C File Offset: 0x0005410C
		// (set) Token: 0x06000EFE RID: 3838 RVA: 0x00055F48 File Offset: 0x00054148
		public unsafe UndefinedSchemaIdHandling UndefinedSchemaIdHandling
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaGenerator.NativeMethodInfoPtr_get_UndefinedSchemaIdHandling_Public_get_UndefinedSchemaIdHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaGenerator.NativeMethodInfoPtr_set_UndefinedSchemaIdHandling_Public_set_Void_UndefinedSchemaIdHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000EFF RID: 3839 RVA: 0x00055F88 File Offset: 0x00054188
		// (set) Token: 0x06000F00 RID: 3840 RVA: 0x00055FC8 File Offset: 0x000541C8
		public unsafe IContractResolver ContractResolver
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754930, XrefRangeEnd = 754931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaGenerator.NativeMethodInfoPtr_get_ContractResolver_Public_get_IContractResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaGenerator.NativeMethodInfoPtr_set_ContractResolver_Public_set_Void_IContractResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x0005600C File Offset: 0x0005420C
		public unsafe JsonSchema CurrentSchema
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaGenerator.NativeMethodInfoPtr_get_CurrentSchema_Private_get_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchema>(intPtr3) : null;
			}
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x0005604C File Offset: 0x0005424C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754931, XrefRangeEnd = 754940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(JsonSchemaGenerator.TypeSchema typeSchema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeSchema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaGenerator.NativeMethodInfoPtr_Push_Private_Void_TypeSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x00056090 File Offset: 0x00054290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754940, XrefRangeEnd = 754954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSchemaGenerator.TypeSchema Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaGenerator.NativeMethodInfoPtr_Pop_Private_TypeSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchemaGenerator.TypeSchema>(intPtr3) : null;
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x000560D0 File Offset: 0x000542D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754954, XrefRangeEnd = 754959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSchema Generate(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaGenerator.NativeMethodInfoPtr_Generate_Public_JsonSchema_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchema>(intPtr3) : null;
			}
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x00056120 File Offset: 0x00054320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754959, XrefRangeEnd = 754960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSchema Generate(Type type, JsonSchemaResolver resolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaGenerator.NativeMethodInfoPtr_Generate_Public_JsonSchema_Type_JsonSchemaResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchema>(intPtr3) : null;
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x00056184 File Offset: 0x00054384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754960, XrefRangeEnd = 754965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSchema Generate(Type type, bool rootSchemaNullable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rootSchemaNullable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaGenerator.NativeMethodInfoPtr_Generate_Public_JsonSchema_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchema>(intPtr3) : null;
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x000561E4 File Offset: 0x000543E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 754973, RefRangeEnd = 754976, XrefRangeStart = 754965, XrefRangeEnd = 754973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSchema Generate(Type type, JsonSchemaResolver resolver, bool rootSchemaNullable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resolver);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rootSchemaNullable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaGenerator.NativeMethodInfoPtr_Generate_Public_JsonSchema_Type_JsonSchemaResolver_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchema>(intPtr3) : null;
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x00056254 File Offset: 0x00054454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754976, XrefRangeEnd = 754984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTitle(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaGenerator.NativeMethodInfoPtr_GetTitle_Private_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x0005629C File Offset: 0x0005449C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754984, XrefRangeEnd = 754998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDescription(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaGenerator.NativeMethodInfoPtr_GetDescription_Private_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x000562E4 File Offset: 0x000544E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754998, XrefRangeEnd = 755006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTypeId(Type type, bool explicitOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref explicitOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaGenerator.NativeMethodInfoPtr_GetTypeId_Private_String_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x0005633C File Offset: 0x0005453C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 755073, RefRangeEnd = 755075, XrefRangeStart = 755006, XrefRangeEnd = 755073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSchema GenerateInternal(Type type, Required valueRequired, bool required)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueRequired;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref required;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaGenerator.NativeMethodInfoPtr_GenerateInternal_Private_JsonSchema_Type_Required_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchema>(intPtr3) : null;
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x000563A8 File Offset: 0x000545A8
		[CallerCount(0)]
		public unsafe JsonSchemaType AddNullType(JsonSchemaType type, Required valueRequired)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueRequired;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaGenerator.NativeMethodInfoPtr_AddNullType_Private_JsonSchemaType_JsonSchemaType_Required_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x00056400 File Offset: 0x00054600
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaGenerator.NativeMethodInfoPtr_HasFlag_Private_Boolean_DefaultValueHandling_DefaultValueHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x00056458 File Offset: 0x00054658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755075, XrefRangeEnd = 755116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateObjectSchema(Type type, JsonObjectContract contract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaGenerator.NativeMethodInfoPtr_GenerateObjectSchema_Private_Void_Type_JsonObjectContract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x000564AC File Offset: 0x000546AC
		[CallerCount(0)]
		public unsafe void GenerateISerializableContract(Type type, JsonISerializableContract contract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaGenerator.NativeMethodInfoPtr_GenerateISerializableContract_Private_Void_Type_JsonISerializableContract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x00056500 File Offset: 0x00054700
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 755123, RefRangeEnd = 755125, XrefRangeStart = 755116, XrefRangeEnd = 755123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasFlag(Nullable<JsonSchemaType> value, JsonSchemaType flag)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaGenerator.NativeMethodInfoPtr_HasFlag_Internal_Static_Boolean_Nullable_1_JsonSchemaType_JsonSchemaType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x00056554 File Offset: 0x00054754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755125, XrefRangeEnd = 755137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSchemaType GetJsonSchemaType(Type type, Required valueRequired)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueRequired;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaGenerator.NativeMethodInfoPtr_GetJsonSchemaType_Private_JsonSchemaType_Type_Required_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x000565B0 File Offset: 0x000547B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755137, XrefRangeEnd = 755145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSchemaGenerator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x00006FF8 File Offset: 0x000051F8
		public JsonSchemaGenerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x000565EC File Offset: 0x000547EC
		// (set) Token: 0x06000F15 RID: 3861 RVA: 0x00007001 File Offset: 0x00005201
		public unsafe UndefinedSchemaIdHandling _UndefinedSchemaIdHandling_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaGenerator.NativeFieldInfoPtr__UndefinedSchemaIdHandling_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaGenerator.NativeFieldInfoPtr__UndefinedSchemaIdHandling_k__BackingField)) = value;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000F16 RID: 3862 RVA: 0x00056614 File Offset: 0x00054814
		// (set) Token: 0x06000F17 RID: 3863 RVA: 0x0000701C File Offset: 0x0000521C
		public unsafe IContractResolver _contractResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaGenerator.NativeFieldInfoPtr__contractResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IContractResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaGenerator.NativeFieldInfoPtr__contractResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000F18 RID: 3864 RVA: 0x00056644 File Offset: 0x00054844
		// (set) Token: 0x06000F19 RID: 3865 RVA: 0x0000703B File Offset: 0x0000523B
		public unsafe JsonSchemaResolver _resolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaGenerator.NativeFieldInfoPtr__resolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSchemaResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaGenerator.NativeFieldInfoPtr__resolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000F1A RID: 3866 RVA: 0x00056674 File Offset: 0x00054874
		// (set) Token: 0x06000F1B RID: 3867 RVA: 0x0000705A File Offset: 0x0000525A
		public unsafe IList<JsonSchemaGenerator.TypeSchema> _stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaGenerator.NativeFieldInfoPtr__stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<JsonSchemaGenerator.TypeSchema>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaGenerator.NativeFieldInfoPtr__stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000F1C RID: 3868 RVA: 0x000566A4 File Offset: 0x000548A4
		// (set) Token: 0x06000F1D RID: 3869 RVA: 0x00007079 File Offset: 0x00005279
		public unsafe JsonSchema _currentSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaGenerator.NativeFieldInfoPtr__currentSchema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaGenerator.NativeFieldInfoPtr__currentSchema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BFD RID: 3069
		private static readonly IntPtr NativeFieldInfoPtr__UndefinedSchemaIdHandling_k__BackingField;

		// Token: 0x04000BFE RID: 3070
		private static readonly IntPtr NativeFieldInfoPtr__contractResolver;

		// Token: 0x04000BFF RID: 3071
		private static readonly IntPtr NativeFieldInfoPtr__resolver;

		// Token: 0x04000C00 RID: 3072
		private static readonly IntPtr NativeFieldInfoPtr__stack;

		// Token: 0x04000C01 RID: 3073
		private static readonly IntPtr NativeFieldInfoPtr__currentSchema;

		// Token: 0x04000C02 RID: 3074
		private static readonly IntPtr NativeMethodInfoPtr_get_UndefinedSchemaIdHandling_Public_get_UndefinedSchemaIdHandling_0;

		// Token: 0x04000C03 RID: 3075
		private static readonly IntPtr NativeMethodInfoPtr_set_UndefinedSchemaIdHandling_Public_set_Void_UndefinedSchemaIdHandling_0;

		// Token: 0x04000C04 RID: 3076
		private static readonly IntPtr NativeMethodInfoPtr_get_ContractResolver_Public_get_IContractResolver_0;

		// Token: 0x04000C05 RID: 3077
		private static readonly IntPtr NativeMethodInfoPtr_set_ContractResolver_Public_set_Void_IContractResolver_0;

		// Token: 0x04000C06 RID: 3078
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSchema_Private_get_JsonSchema_0;

		// Token: 0x04000C07 RID: 3079
		private static readonly IntPtr NativeMethodInfoPtr_Push_Private_Void_TypeSchema_0;

		// Token: 0x04000C08 RID: 3080
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Private_TypeSchema_0;

		// Token: 0x04000C09 RID: 3081
		private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_JsonSchema_Type_0;

		// Token: 0x04000C0A RID: 3082
		private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_JsonSchema_Type_JsonSchemaResolver_0;

		// Token: 0x04000C0B RID: 3083
		private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_JsonSchema_Type_Boolean_0;

		// Token: 0x04000C0C RID: 3084
		private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_JsonSchema_Type_JsonSchemaResolver_Boolean_0;

		// Token: 0x04000C0D RID: 3085
		private static readonly IntPtr NativeMethodInfoPtr_GetTitle_Private_String_Type_0;

		// Token: 0x04000C0E RID: 3086
		private static readonly IntPtr NativeMethodInfoPtr_GetDescription_Private_String_Type_0;

		// Token: 0x04000C0F RID: 3087
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeId_Private_String_Type_Boolean_0;

		// Token: 0x04000C10 RID: 3088
		private static readonly IntPtr NativeMethodInfoPtr_GenerateInternal_Private_JsonSchema_Type_Required_Boolean_0;

		// Token: 0x04000C11 RID: 3089
		private static readonly IntPtr NativeMethodInfoPtr_AddNullType_Private_JsonSchemaType_JsonSchemaType_Required_0;

		// Token: 0x04000C12 RID: 3090
		private static readonly IntPtr NativeMethodInfoPtr_HasFlag_Private_Boolean_DefaultValueHandling_DefaultValueHandling_0;

		// Token: 0x04000C13 RID: 3091
		private static readonly IntPtr NativeMethodInfoPtr_GenerateObjectSchema_Private_Void_Type_JsonObjectContract_0;

		// Token: 0x04000C14 RID: 3092
		private static readonly IntPtr NativeMethodInfoPtr_GenerateISerializableContract_Private_Void_Type_JsonISerializableContract_0;

		// Token: 0x04000C15 RID: 3093
		private static readonly IntPtr NativeMethodInfoPtr_HasFlag_Internal_Static_Boolean_Nullable_1_JsonSchemaType_JsonSchemaType_0;

		// Token: 0x04000C16 RID: 3094
		private static readonly IntPtr NativeMethodInfoPtr_GetJsonSchemaType_Private_JsonSchemaType_Type_Required_0;

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020001DD RID: 477
		public class TypeSchema : Object
		{
			// Token: 0x06001EE4 RID: 7908 RVA: 0x0008DE2C File Offset: 0x0008C02C
			// Note: this type is marked as 'beforefieldinit'.
			static TypeSchema()
			{
				Il2CppClassPointerStore<JsonSchemaGenerator.TypeSchema>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, "TypeSchema");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSchemaGenerator.TypeSchema>.NativeClassPtr);
				JsonSchemaGenerator.TypeSchema.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaGenerator.TypeSchema>.NativeClassPtr, "<Type>k__BackingField");
				JsonSchemaGenerator.TypeSchema.NativeFieldInfoPtr__Schema_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaGenerator.TypeSchema>.NativeClassPtr, "<Schema>k__BackingField");
				JsonSchemaGenerator.TypeSchema.NativeMethodInfoPtr_get_Type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaGenerator.TypeSchema>.NativeClassPtr, 100665974);
				JsonSchemaGenerator.TypeSchema.NativeMethodInfoPtr_get_Schema_Public_get_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaGenerator.TypeSchema>.NativeClassPtr, 100665975);
				JsonSchemaGenerator.TypeSchema.NativeMethodInfoPtr__ctor_Public_Void_Type_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaGenerator.TypeSchema>.NativeClassPtr, 100665976);
			}

			// Token: 0x170008A9 RID: 2217
			// (get) Token: 0x06001EE5 RID: 7909 RVA: 0x0008DEBC File Offset: 0x0008C0BC
			public unsafe Type Type
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaGenerator.TypeSchema.NativeMethodInfoPtr_get_Type_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
			}

			// Token: 0x170008AA RID: 2218
			// (get) Token: 0x06001EE6 RID: 7910 RVA: 0x0008DEFC File Offset: 0x0008C0FC
			public unsafe JsonSchema Schema
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaGenerator.TypeSchema.NativeMethodInfoPtr_get_Schema_Public_get_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchema>(intPtr3) : null;
				}
			}

			// Token: 0x06001EE7 RID: 7911 RVA: 0x0008DF3C File Offset: 0x0008C13C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754916, XrefRangeEnd = 754925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TypeSchema(Type type, JsonSchema schema)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSchemaGenerator.TypeSchema>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaGenerator.TypeSchema.NativeMethodInfoPtr__ctor_Public_Void_Type_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EE8 RID: 7912 RVA: 0x0000F3F5 File Offset: 0x0000D5F5
			public TypeSchema(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008A7 RID: 2215
			// (get) Token: 0x06001EE9 RID: 7913 RVA: 0x0008DF9C File Offset: 0x0008C19C
			// (set) Token: 0x06001EEA RID: 7914 RVA: 0x0000F3FE File Offset: 0x0000D5FE
			public unsafe Type _Type_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaGenerator.TypeSchema.NativeFieldInfoPtr__Type_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaGenerator.TypeSchema.NativeFieldInfoPtr__Type_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008A8 RID: 2216
			// (get) Token: 0x06001EEB RID: 7915 RVA: 0x0008DFCC File Offset: 0x0008C1CC
			// (set) Token: 0x06001EEC RID: 7916 RVA: 0x0000F41D File Offset: 0x0000D61D
			public unsafe JsonSchema _Schema_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaGenerator.TypeSchema.NativeFieldInfoPtr__Schema_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSchema>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaGenerator.TypeSchema.NativeFieldInfoPtr__Schema_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400167F RID: 5759
			private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

			// Token: 0x04001680 RID: 5760
			private static readonly IntPtr NativeFieldInfoPtr__Schema_k__BackingField;

			// Token: 0x04001681 RID: 5761
			private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_Type_0;

			// Token: 0x04001682 RID: 5762
			private static readonly IntPtr NativeMethodInfoPtr_get_Schema_Public_get_JsonSchema_0;

			// Token: 0x04001683 RID: 5763
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_JsonSchema_0;
		}

		// Token: 0x020001DE RID: 478
		[ObfuscatedName("Newtonsoft.Json.Schema.JsonSchemaGenerator+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Object
		{
			// Token: 0x06001EED RID: 7917 RVA: 0x0008DFFC File Offset: 0x0008C1FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<JsonSchemaGenerator.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonSchemaGenerator>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSchemaGenerator.__c__DisplayClass23_0>.NativeClassPtr);
				JsonSchemaGenerator.__c__DisplayClass23_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaGenerator.__c__DisplayClass23_0>.NativeClassPtr, "type");
				JsonSchemaGenerator.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaGenerator.__c__DisplayClass23_0>.NativeClassPtr, 100665977);
				JsonSchemaGenerator.__c__DisplayClass23_0.NativeMethodInfoPtr__GenerateInternal_b__0_Internal_Boolean_TypeSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaGenerator.__c__DisplayClass23_0>.NativeClassPtr, 100665978);
			}

			// Token: 0x06001EEE RID: 7918 RVA: 0x0008E064 File Offset: 0x0008C264
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSchemaGenerator.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaGenerator.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EEF RID: 7919 RVA: 0x0008E0A0 File Offset: 0x0008C2A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754925, XrefRangeEnd = 754930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GenerateInternal_b__0(JsonSchemaGenerator.TypeSchema tc)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tc);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaGenerator.__c__DisplayClass23_0.NativeMethodInfoPtr__GenerateInternal_b__0_Internal_Boolean_TypeSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001EF0 RID: 7920 RVA: 0x0000F43C File Offset: 0x0000D63C
			public __c__DisplayClass23_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008AB RID: 2219
			// (get) Token: 0x06001EF1 RID: 7921 RVA: 0x0008E0F0 File Offset: 0x0008C2F0
			// (set) Token: 0x06001EF2 RID: 7922 RVA: 0x0000F445 File Offset: 0x0000D645
			public unsafe Type type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaGenerator.__c__DisplayClass23_0.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaGenerator.__c__DisplayClass23_0.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001684 RID: 5764
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04001685 RID: 5765
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001686 RID: 5766
			private static readonly IntPtr NativeMethodInfoPtr__GenerateInternal_b__0_Internal_Boolean_TypeSchema_0;
		}
	}
}

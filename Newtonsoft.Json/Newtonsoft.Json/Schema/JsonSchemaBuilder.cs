using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020000A4 RID: 164
	public class JsonSchemaBuilder : Object
	{
		// Token: 0x06000E8A RID: 3722 RVA: 0x000549E8 File Offset: 0x00052BE8
		// Note: this type is marked as 'beforefieldinit'.
		static JsonSchemaBuilder()
		{
			Il2CppClassPointerStore<JsonSchemaBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Schema", "JsonSchemaBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSchemaBuilder>.NativeClassPtr);
			JsonSchemaBuilder.NativeFieldInfoPtr__stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaBuilder>.NativeClassPtr, "_stack");
			JsonSchemaBuilder.NativeFieldInfoPtr__resolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaBuilder>.NativeClassPtr, "_resolver");
			JsonSchemaBuilder.NativeFieldInfoPtr__documentSchemas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaBuilder>.NativeClassPtr, "_documentSchemas");
			JsonSchemaBuilder.NativeFieldInfoPtr__currentSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaBuilder>.NativeClassPtr, "_currentSchema");
			JsonSchemaBuilder.NativeFieldInfoPtr__rootSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaBuilder>.NativeClassPtr, "_rootSchema");
			JsonSchemaBuilder.NativeMethodInfoPtr__ctor_Public_Void_JsonSchemaResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaBuilder>.NativeClassPtr, 100665923);
			JsonSchemaBuilder.NativeMethodInfoPtr_Push_Private_Void_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaBuilder>.NativeClassPtr, 100665924);
			JsonSchemaBuilder.NativeMethodInfoPtr_Pop_Private_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaBuilder>.NativeClassPtr, 100665925);
			JsonSchemaBuilder.NativeMethodInfoPtr_get_CurrentSchema_Private_get_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaBuilder>.NativeClassPtr, 100665926);
			JsonSchemaBuilder.NativeMethodInfoPtr_Read_Internal_JsonSchema_JsonReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaBuilder>.NativeClassPtr, 100665927);
			JsonSchemaBuilder.NativeMethodInfoPtr_UnescapeReference_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaBuilder>.NativeClassPtr, 100665928);
			JsonSchemaBuilder.NativeMethodInfoPtr_ResolveReferences_Private_JsonSchema_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaBuilder>.NativeClassPtr, 100665929);
			JsonSchemaBuilder.NativeMethodInfoPtr_BuildSchema_Private_JsonSchema_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaBuilder>.NativeClassPtr, 100665930);
			JsonSchemaBuilder.NativeMethodInfoPtr_ProcessSchemaProperties_Private_Void_JObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaBuilder>.NativeClassPtr, 100665931);
			JsonSchemaBuilder.NativeMethodInfoPtr_ProcessExtends_Private_Void_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaBuilder>.NativeClassPtr, 100665932);
			JsonSchemaBuilder.NativeMethodInfoPtr_ProcessEnum_Private_Void_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaBuilder>.NativeClassPtr, 100665933);
			JsonSchemaBuilder.NativeMethodInfoPtr_ProcessAdditionalProperties_Private_Void_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaBuilder>.NativeClassPtr, 100665934);
			JsonSchemaBuilder.NativeMethodInfoPtr_ProcessAdditionalItems_Private_Void_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaBuilder>.NativeClassPtr, 100665935);
			JsonSchemaBuilder.NativeMethodInfoPtr_ProcessProperties_Private_IDictionary_2_String_JsonSchema_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaBuilder>.NativeClassPtr, 100665936);
			JsonSchemaBuilder.NativeMethodInfoPtr_ProcessItems_Private_Void_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaBuilder>.NativeClassPtr, 100665937);
			JsonSchemaBuilder.NativeMethodInfoPtr_ProcessType_Private_Nullable_1_JsonSchemaType_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaBuilder>.NativeClassPtr, 100665938);
			JsonSchemaBuilder.NativeMethodInfoPtr_MapType_Internal_Static_JsonSchemaType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaBuilder>.NativeClassPtr, 100665939);
			JsonSchemaBuilder.NativeMethodInfoPtr_MapType_Internal_Static_String_JsonSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaBuilder>.NativeClassPtr, 100665940);
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x00054BE4 File Offset: 0x00052DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754217, XrefRangeEnd = 754277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSchemaBuilder(JsonSchemaResolver resolver)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSchemaBuilder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resolver);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaBuilder.NativeMethodInfoPtr__ctor_Public_Void_JsonSchemaResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00054C30 File Offset: 0x00052E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754277, XrefRangeEnd = 754286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(JsonSchema value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaBuilder.NativeMethodInfoPtr_Push_Private_Void_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x00054C74 File Offset: 0x00052E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754286, XrefRangeEnd = 754296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSchema Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaBuilder.NativeMethodInfoPtr_Pop_Private_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchema>(intPtr3) : null;
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000E8E RID: 3726 RVA: 0x00054CB4 File Offset: 0x00052EB4
		public unsafe JsonSchema CurrentSchema
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaBuilder.NativeMethodInfoPtr_get_CurrentSchema_Private_get_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchema>(intPtr3) : null;
			}
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00054CF4 File Offset: 0x00052EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754296, XrefRangeEnd = 754309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSchema Read(JsonReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaBuilder.NativeMethodInfoPtr_Read_Internal_JsonSchema_JsonReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchema>(intPtr3) : null;
			}
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00054D44 File Offset: 0x00052F44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 754323, RefRangeEnd = 754325, XrefRangeStart = 754309, XrefRangeEnd = 754323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string UnescapeReference(string reference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(reference);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaBuilder.NativeMethodInfoPtr_UnescapeReference_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00054D8C File Offset: 0x00052F8C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 754413, RefRangeEnd = 754421, XrefRangeStart = 754325, XrefRangeEnd = 754413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSchema ResolveReferences(JsonSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaBuilder.NativeMethodInfoPtr_ResolveReferences_Private_JsonSchema_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchema>(intPtr3) : null;
			}
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x00054DDC File Offset: 0x00052FDC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 754477, RefRangeEnd = 754486, XrefRangeStart = 754421, XrefRangeEnd = 754477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSchema BuildSchema(JToken token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaBuilder.NativeMethodInfoPtr_BuildSchema_Private_JsonSchema_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchema>(intPtr3) : null;
			}
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x00054E2C File Offset: 0x0005302C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 754723, RefRangeEnd = 754724, XrefRangeStart = 754486, XrefRangeEnd = 754723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessSchemaProperties(JObject schemaObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaBuilder.NativeMethodInfoPtr_ProcessSchemaProperties_Private_Void_JObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x00054E70 File Offset: 0x00053070
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 754759, RefRangeEnd = 754760, XrefRangeStart = 754724, XrefRangeEnd = 754759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessExtends(JToken token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaBuilder.NativeMethodInfoPtr_ProcessExtends_Private_Void_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x00054EB4 File Offset: 0x000530B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 754789, RefRangeEnd = 754790, XrefRangeStart = 754760, XrefRangeEnd = 754789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessEnum(JToken token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaBuilder.NativeMethodInfoPtr_ProcessEnum_Private_Void_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x00054EF8 File Offset: 0x000530F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 754796, RefRangeEnd = 754797, XrefRangeStart = 754790, XrefRangeEnd = 754796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessAdditionalProperties(JToken token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaBuilder.NativeMethodInfoPtr_ProcessAdditionalProperties_Private_Void_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00054F3C File Offset: 0x0005313C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 754803, RefRangeEnd = 754804, XrefRangeStart = 754797, XrefRangeEnd = 754803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessAdditionalItems(JToken token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaBuilder.NativeMethodInfoPtr_ProcessAdditionalItems_Private_Void_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x00054F80 File Offset: 0x00053180
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 754836, RefRangeEnd = 754838, XrefRangeStart = 754804, XrefRangeEnd = 754836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDictionary<string, JsonSchema> ProcessProperties(JToken token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaBuilder.NativeMethodInfoPtr_ProcessProperties_Private_IDictionary_2_String_JsonSchema_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, JsonSchema>>(intPtr3) : null;
			}
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x00054FD0 File Offset: 0x000531D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 754853, RefRangeEnd = 754854, XrefRangeStart = 754838, XrefRangeEnd = 754853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessItems(JToken token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaBuilder.NativeMethodInfoPtr_ProcessItems_Private_Void_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x00055014 File Offset: 0x00053214
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 754883, RefRangeEnd = 754885, XrefRangeStart = 754854, XrefRangeEnd = 754883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<JsonSchemaType> ProcessType(JToken token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaBuilder.NativeMethodInfoPtr_ProcessType_Private_Nullable_1_JsonSchemaType_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<JsonSchemaType>(intPtr);
			}
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x0005505C File Offset: 0x0005325C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 754892, RefRangeEnd = 754893, XrefRangeStart = 754885, XrefRangeEnd = 754892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JsonSchemaType MapType(string type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaBuilder.NativeMethodInfoPtr_MapType_Internal_Static_JsonSchemaType_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x000550A0 File Offset: 0x000532A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 754911, RefRangeEnd = 754913, XrefRangeStart = 754893, XrefRangeEnd = 754911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string MapType(JsonSchemaType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaBuilder.NativeMethodInfoPtr_MapType_Internal_Static_String_JsonSchemaType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x00006C9B File Offset: 0x00004E9B
		public JsonSchemaBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000E9E RID: 3742 RVA: 0x000550D8 File Offset: 0x000532D8
		// (set) Token: 0x06000E9F RID: 3743 RVA: 0x00006CA4 File Offset: 0x00004EA4
		public unsafe IList<JsonSchema> _stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaBuilder.NativeFieldInfoPtr__stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<JsonSchema>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaBuilder.NativeFieldInfoPtr__stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x00055108 File Offset: 0x00053308
		// (set) Token: 0x06000EA1 RID: 3745 RVA: 0x00006CC3 File Offset: 0x00004EC3
		public unsafe JsonSchemaResolver _resolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaBuilder.NativeFieldInfoPtr__resolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSchemaResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaBuilder.NativeFieldInfoPtr__resolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x00055138 File Offset: 0x00053338
		// (set) Token: 0x06000EA3 RID: 3747 RVA: 0x00006CE2 File Offset: 0x00004EE2
		public unsafe IDictionary<string, JsonSchema> _documentSchemas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaBuilder.NativeFieldInfoPtr__documentSchemas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<string, JsonSchema>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaBuilder.NativeFieldInfoPtr__documentSchemas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000EA4 RID: 3748 RVA: 0x00055168 File Offset: 0x00053368
		// (set) Token: 0x06000EA5 RID: 3749 RVA: 0x00006D01 File Offset: 0x00004F01
		public unsafe JsonSchema _currentSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaBuilder.NativeFieldInfoPtr__currentSchema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaBuilder.NativeFieldInfoPtr__currentSchema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000EA6 RID: 3750 RVA: 0x00055198 File Offset: 0x00053398
		// (set) Token: 0x06000EA7 RID: 3751 RVA: 0x00006D20 File Offset: 0x00004F20
		public unsafe JObject _rootSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaBuilder.NativeFieldInfoPtr__rootSchema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaBuilder.NativeFieldInfoPtr__rootSchema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BBA RID: 3002
		private static readonly IntPtr NativeFieldInfoPtr__stack;

		// Token: 0x04000BBB RID: 3003
		private static readonly IntPtr NativeFieldInfoPtr__resolver;

		// Token: 0x04000BBC RID: 3004
		private static readonly IntPtr NativeFieldInfoPtr__documentSchemas;

		// Token: 0x04000BBD RID: 3005
		private static readonly IntPtr NativeFieldInfoPtr__currentSchema;

		// Token: 0x04000BBE RID: 3006
		private static readonly IntPtr NativeFieldInfoPtr__rootSchema;

		// Token: 0x04000BBF RID: 3007
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_JsonSchemaResolver_0;

		// Token: 0x04000BC0 RID: 3008
		private static readonly IntPtr NativeMethodInfoPtr_Push_Private_Void_JsonSchema_0;

		// Token: 0x04000BC1 RID: 3009
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Private_JsonSchema_0;

		// Token: 0x04000BC2 RID: 3010
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSchema_Private_get_JsonSchema_0;

		// Token: 0x04000BC3 RID: 3011
		private static readonly IntPtr NativeMethodInfoPtr_Read_Internal_JsonSchema_JsonReader_0;

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeMethodInfoPtr_UnescapeReference_Private_String_String_0;

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeMethodInfoPtr_ResolveReferences_Private_JsonSchema_JsonSchema_0;

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeMethodInfoPtr_BuildSchema_Private_JsonSchema_JToken_0;

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeMethodInfoPtr_ProcessSchemaProperties_Private_Void_JObject_0;

		// Token: 0x04000BC8 RID: 3016
		private static readonly IntPtr NativeMethodInfoPtr_ProcessExtends_Private_Void_JToken_0;

		// Token: 0x04000BC9 RID: 3017
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEnum_Private_Void_JToken_0;

		// Token: 0x04000BCA RID: 3018
		private static readonly IntPtr NativeMethodInfoPtr_ProcessAdditionalProperties_Private_Void_JToken_0;

		// Token: 0x04000BCB RID: 3019
		private static readonly IntPtr NativeMethodInfoPtr_ProcessAdditionalItems_Private_Void_JToken_0;

		// Token: 0x04000BCC RID: 3020
		private static readonly IntPtr NativeMethodInfoPtr_ProcessProperties_Private_IDictionary_2_String_JsonSchema_JToken_0;

		// Token: 0x04000BCD RID: 3021
		private static readonly IntPtr NativeMethodInfoPtr_ProcessItems_Private_Void_JToken_0;

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeMethodInfoPtr_ProcessType_Private_Nullable_1_JsonSchemaType_JToken_0;

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeMethodInfoPtr_MapType_Internal_Static_JsonSchemaType_String_0;

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeMethodInfoPtr_MapType_Internal_Static_String_JsonSchemaType_0;

		// Token: 0x020001DC RID: 476
		[ObfuscatedName("Newtonsoft.Json.Schema.JsonSchemaBuilder+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Object
		{
			// Token: 0x06001EDE RID: 7902 RVA: 0x0008DD0C File Offset: 0x0008BF0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<JsonSchemaBuilder.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonSchemaBuilder>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSchemaBuilder.__c__DisplayClass23_0>.NativeClassPtr);
				JsonSchemaBuilder.__c__DisplayClass23_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaBuilder.__c__DisplayClass23_0>.NativeClassPtr, "type");
				JsonSchemaBuilder.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaBuilder.__c__DisplayClass23_0>.NativeClassPtr, 100665941);
				JsonSchemaBuilder.__c__DisplayClass23_0.NativeMethodInfoPtr__MapType_b__0_Internal_Boolean_KeyValuePair_2_String_JsonSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaBuilder.__c__DisplayClass23_0>.NativeClassPtr, 100665942);
			}

			// Token: 0x06001EDF RID: 7903 RVA: 0x0008DD74 File Offset: 0x0008BF74
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSchemaBuilder.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaBuilder.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EE0 RID: 7904 RVA: 0x0008DDB0 File Offset: 0x0008BFB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754216, XrefRangeEnd = 754217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MapType_b__0(KeyValuePair<string, JsonSchemaType> kv)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kv));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaBuilder.__c__DisplayClass23_0.NativeMethodInfoPtr__MapType_b__0_Internal_Boolean_KeyValuePair_2_String_JsonSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001EE1 RID: 7905 RVA: 0x0000F3D1 File Offset: 0x0000D5D1
			public __c__DisplayClass23_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008A6 RID: 2214
			// (get) Token: 0x06001EE2 RID: 7906 RVA: 0x0008DE04 File Offset: 0x0008C004
			// (set) Token: 0x06001EE3 RID: 7907 RVA: 0x0000F3DA File Offset: 0x0000D5DA
			public unsafe JsonSchemaType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaBuilder.__c__DisplayClass23_0.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaBuilder.__c__DisplayClass23_0.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x0400167C RID: 5756
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x0400167D RID: 5757
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400167E RID: 5758
			private static readonly IntPtr NativeMethodInfoPtr__MapType_b__0_Internal_Boolean_KeyValuePair_2_String_JsonSchemaType_0;
		}
	}
}

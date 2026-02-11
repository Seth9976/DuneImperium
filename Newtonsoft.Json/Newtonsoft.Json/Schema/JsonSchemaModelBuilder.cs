using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020000A9 RID: 169
	public class JsonSchemaModelBuilder : Object
	{
		// Token: 0x06000F7F RID: 3967 RVA: 0x00057CEC File Offset: 0x00055EEC
		// Note: this type is marked as 'beforefieldinit'.
		static JsonSchemaModelBuilder()
		{
			Il2CppClassPointerStore<JsonSchemaModelBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Schema", "JsonSchemaModelBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSchemaModelBuilder>.NativeClassPtr);
			JsonSchemaModelBuilder.NativeFieldInfoPtr__nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaModelBuilder>.NativeClassPtr, "_nodes");
			JsonSchemaModelBuilder.NativeFieldInfoPtr__nodeModels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaModelBuilder>.NativeClassPtr, "_nodeModels");
			JsonSchemaModelBuilder.NativeFieldInfoPtr__node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaModelBuilder>.NativeClassPtr, "_node");
			JsonSchemaModelBuilder.NativeMethodInfoPtr_Build_Public_JsonSchemaModel_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModelBuilder>.NativeClassPtr, 100666028);
			JsonSchemaModelBuilder.NativeMethodInfoPtr_AddSchema_Public_JsonSchemaNode_JsonSchemaNode_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModelBuilder>.NativeClassPtr, 100666029);
			JsonSchemaModelBuilder.NativeMethodInfoPtr_AddProperties_Public_Void_IDictionary_2_String_JsonSchema_IDictionary_2_String_JsonSchemaNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModelBuilder>.NativeClassPtr, 100666030);
			JsonSchemaModelBuilder.NativeMethodInfoPtr_AddProperty_Public_Void_IDictionary_2_String_JsonSchemaNode_String_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModelBuilder>.NativeClassPtr, 100666031);
			JsonSchemaModelBuilder.NativeMethodInfoPtr_AddItem_Public_Void_JsonSchemaNode_Int32_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModelBuilder>.NativeClassPtr, 100666032);
			JsonSchemaModelBuilder.NativeMethodInfoPtr_AddAdditionalProperties_Public_Void_JsonSchemaNode_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModelBuilder>.NativeClassPtr, 100666033);
			JsonSchemaModelBuilder.NativeMethodInfoPtr_AddAdditionalItems_Public_Void_JsonSchemaNode_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModelBuilder>.NativeClassPtr, 100666034);
			JsonSchemaModelBuilder.NativeMethodInfoPtr_BuildNodeModel_Private_JsonSchemaModel_JsonSchemaNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModelBuilder>.NativeClassPtr, 100666035);
			JsonSchemaModelBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModelBuilder>.NativeClassPtr, 100666036);
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00057E0C File Offset: 0x0005600C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 755229, RefRangeEnd = 755230, XrefRangeStart = 755212, XrefRangeEnd = 755229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSchemaModel Build(JsonSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModelBuilder.NativeMethodInfoPtr_Build_Public_JsonSchemaModel_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchemaModel>(intPtr3) : null;
			}
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00057E5C File Offset: 0x0005605C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 755309, RefRangeEnd = 755319, XrefRangeStart = 755230, XrefRangeEnd = 755309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSchemaNode AddSchema(JsonSchemaNode existingNode, JsonSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(existingNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModelBuilder.NativeMethodInfoPtr_AddSchema_Public_JsonSchemaNode_JsonSchemaNode_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchemaNode>(intPtr3) : null;
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00057EC0 File Offset: 0x000560C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 755346, RefRangeEnd = 755348, XrefRangeStart = 755319, XrefRangeEnd = 755346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddProperties(IDictionary<string, JsonSchema> source, IDictionary<string, JsonSchemaNode> target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModelBuilder.NativeMethodInfoPtr_AddProperties_Public_Void_IDictionary_2_String_JsonSchema_IDictionary_2_String_JsonSchemaNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x00057F14 File Offset: 0x00056114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755348, XrefRangeEnd = 755354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddProperty(IDictionary<string, JsonSchemaNode> target, string propertyName, JsonSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModelBuilder.NativeMethodInfoPtr_AddProperty_Public_Void_IDictionary_2_String_JsonSchemaNode_String_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00057F7C File Offset: 0x0005617C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755354, XrefRangeEnd = 755364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItem(JsonSchemaNode parentNode, int index, JsonSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModelBuilder.NativeMethodInfoPtr_AddItem_Public_Void_JsonSchemaNode_Int32_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x00057FE0 File Offset: 0x000561E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755364, XrefRangeEnd = 755367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAdditionalProperties(JsonSchemaNode parentNode, JsonSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModelBuilder.NativeMethodInfoPtr_AddAdditionalProperties_Public_Void_JsonSchemaNode_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x00058034 File Offset: 0x00056234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755367, XrefRangeEnd = 755370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAdditionalItems(JsonSchemaNode parentNode, JsonSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModelBuilder.NativeMethodInfoPtr_AddAdditionalItems_Public_Void_JsonSchemaNode_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00058088 File Offset: 0x00056288
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 755451, RefRangeEnd = 755457, XrefRangeStart = 755370, XrefRangeEnd = 755451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSchemaModel BuildNodeModel(JsonSchemaNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModelBuilder.NativeMethodInfoPtr_BuildNodeModel_Private_JsonSchemaModel_JsonSchemaNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchemaModel>(intPtr3) : null;
			}
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x000580D8 File Offset: 0x000562D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 755472, RefRangeEnd = 755473, XrefRangeStart = 755457, XrefRangeEnd = 755472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSchemaModelBuilder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSchemaModelBuilder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModelBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x000073AF File Offset: 0x000055AF
		public JsonSchemaModelBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x00058114 File Offset: 0x00056314
		// (set) Token: 0x06000F8B RID: 3979 RVA: 0x000073B8 File Offset: 0x000055B8
		public unsafe JsonSchemaNodeCollection _nodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModelBuilder.NativeFieldInfoPtr__nodes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSchemaNodeCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModelBuilder.NativeFieldInfoPtr__nodes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x00058144 File Offset: 0x00056344
		// (set) Token: 0x06000F8D RID: 3981 RVA: 0x000073D7 File Offset: 0x000055D7
		public unsafe Dictionary<JsonSchemaNode, JsonSchemaModel> _nodeModels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModelBuilder.NativeFieldInfoPtr__nodeModels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<JsonSchemaNode, JsonSchemaModel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModelBuilder.NativeFieldInfoPtr__nodeModels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x00058174 File Offset: 0x00056374
		// (set) Token: 0x06000F8F RID: 3983 RVA: 0x000073F6 File Offset: 0x000055F6
		public unsafe JsonSchemaNode _node
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModelBuilder.NativeFieldInfoPtr__node);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSchemaNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModelBuilder.NativeFieldInfoPtr__node), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeFieldInfoPtr__nodes;

		// Token: 0x04000C61 RID: 3169
		private static readonly IntPtr NativeFieldInfoPtr__nodeModels;

		// Token: 0x04000C62 RID: 3170
		private static readonly IntPtr NativeFieldInfoPtr__node;

		// Token: 0x04000C63 RID: 3171
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_JsonSchemaModel_JsonSchema_0;

		// Token: 0x04000C64 RID: 3172
		private static readonly IntPtr NativeMethodInfoPtr_AddSchema_Public_JsonSchemaNode_JsonSchemaNode_JsonSchema_0;

		// Token: 0x04000C65 RID: 3173
		private static readonly IntPtr NativeMethodInfoPtr_AddProperties_Public_Void_IDictionary_2_String_JsonSchema_IDictionary_2_String_JsonSchemaNode_0;

		// Token: 0x04000C66 RID: 3174
		private static readonly IntPtr NativeMethodInfoPtr_AddProperty_Public_Void_IDictionary_2_String_JsonSchemaNode_String_JsonSchema_0;

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Void_JsonSchemaNode_Int32_JsonSchema_0;

		// Token: 0x04000C68 RID: 3176
		private static readonly IntPtr NativeMethodInfoPtr_AddAdditionalProperties_Public_Void_JsonSchemaNode_JsonSchema_0;

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeMethodInfoPtr_AddAdditionalItems_Public_Void_JsonSchemaNode_JsonSchema_0;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeMethodInfoPtr_BuildNodeModel_Private_JsonSchemaModel_JsonSchemaNode_0;

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

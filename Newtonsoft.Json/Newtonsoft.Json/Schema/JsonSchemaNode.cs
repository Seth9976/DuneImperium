using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020000AA RID: 170
	public class JsonSchemaNode : Object
	{
		// Token: 0x06000F90 RID: 3984 RVA: 0x000581A4 File Offset: 0x000563A4
		// Note: this type is marked as 'beforefieldinit'.
		static JsonSchemaNode()
		{
			Il2CppClassPointerStore<JsonSchemaNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Schema", "JsonSchemaNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSchemaNode>.NativeClassPtr);
			JsonSchemaNode.NativeFieldInfoPtr__Id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaNode>.NativeClassPtr, "<Id>k__BackingField");
			JsonSchemaNode.NativeFieldInfoPtr__Schemas_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaNode>.NativeClassPtr, "<Schemas>k__BackingField");
			JsonSchemaNode.NativeFieldInfoPtr__Properties_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaNode>.NativeClassPtr, "<Properties>k__BackingField");
			JsonSchemaNode.NativeFieldInfoPtr__PatternProperties_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaNode>.NativeClassPtr, "<PatternProperties>k__BackingField");
			JsonSchemaNode.NativeFieldInfoPtr__Items_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaNode>.NativeClassPtr, "<Items>k__BackingField");
			JsonSchemaNode.NativeFieldInfoPtr__AdditionalProperties_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaNode>.NativeClassPtr, "<AdditionalProperties>k__BackingField");
			JsonSchemaNode.NativeFieldInfoPtr__AdditionalItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaNode>.NativeClassPtr, "<AdditionalItems>k__BackingField");
			JsonSchemaNode.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaNode>.NativeClassPtr, 100666037);
			JsonSchemaNode.NativeMethodInfoPtr_get_Schemas_Public_get_ReadOnlyCollection_1_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaNode>.NativeClassPtr, 100666038);
			JsonSchemaNode.NativeMethodInfoPtr_get_Properties_Public_get_Dictionary_2_String_JsonSchemaNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaNode>.NativeClassPtr, 100666039);
			JsonSchemaNode.NativeMethodInfoPtr_get_PatternProperties_Public_get_Dictionary_2_String_JsonSchemaNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaNode>.NativeClassPtr, 100666040);
			JsonSchemaNode.NativeMethodInfoPtr_get_Items_Public_get_List_1_JsonSchemaNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaNode>.NativeClassPtr, 100666041);
			JsonSchemaNode.NativeMethodInfoPtr_get_AdditionalProperties_Public_get_JsonSchemaNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaNode>.NativeClassPtr, 100666042);
			JsonSchemaNode.NativeMethodInfoPtr_set_AdditionalProperties_Public_set_Void_JsonSchemaNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaNode>.NativeClassPtr, 100666043);
			JsonSchemaNode.NativeMethodInfoPtr_get_AdditionalItems_Public_get_JsonSchemaNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaNode>.NativeClassPtr, 100666044);
			JsonSchemaNode.NativeMethodInfoPtr_set_AdditionalItems_Public_set_Void_JsonSchemaNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaNode>.NativeClassPtr, 100666045);
			JsonSchemaNode.NativeMethodInfoPtr__ctor_Public_Void_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaNode>.NativeClassPtr, 100666046);
			JsonSchemaNode.NativeMethodInfoPtr__ctor_Private_Void_JsonSchemaNode_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaNode>.NativeClassPtr, 100666047);
			JsonSchemaNode.NativeMethodInfoPtr_Combine_Public_JsonSchemaNode_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaNode>.NativeClassPtr, 100666048);
			JsonSchemaNode.NativeMethodInfoPtr_GetId_Public_Static_String_IEnumerable_1_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaNode>.NativeClassPtr, 100666049);
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000F91 RID: 3985 RVA: 0x00058364 File Offset: 0x00056564
		public unsafe string Id
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaNode.NativeMethodInfoPtr_get_Id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000F92 RID: 3986 RVA: 0x0005839C File Offset: 0x0005659C
		public unsafe ReadOnlyCollection<JsonSchema> Schemas
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaNode.NativeMethodInfoPtr_get_Schemas_Public_get_ReadOnlyCollection_1_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<JsonSchema>>(intPtr3) : null;
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000F93 RID: 3987 RVA: 0x000583DC File Offset: 0x000565DC
		public unsafe Dictionary<string, JsonSchemaNode> Properties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaNode.NativeMethodInfoPtr_get_Properties_Public_get_Dictionary_2_String_JsonSchemaNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, JsonSchemaNode>>(intPtr3) : null;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000F94 RID: 3988 RVA: 0x0005841C File Offset: 0x0005661C
		public unsafe Dictionary<string, JsonSchemaNode> PatternProperties
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaNode.NativeMethodInfoPtr_get_PatternProperties_Public_get_Dictionary_2_String_JsonSchemaNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, JsonSchemaNode>>(intPtr3) : null;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000F95 RID: 3989 RVA: 0x0005845C File Offset: 0x0005665C
		public unsafe List<JsonSchemaNode> Items
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaNode.NativeMethodInfoPtr_get_Items_Public_get_List_1_JsonSchemaNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<JsonSchemaNode>>(intPtr3) : null;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000F96 RID: 3990 RVA: 0x0005849C File Offset: 0x0005669C
		// (set) Token: 0x06000F97 RID: 3991 RVA: 0x000584DC File Offset: 0x000566DC
		public unsafe JsonSchemaNode AdditionalProperties
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaNode.NativeMethodInfoPtr_get_AdditionalProperties_Public_get_JsonSchemaNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchemaNode>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaNode.NativeMethodInfoPtr_set_AdditionalProperties_Public_set_Void_JsonSchemaNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000F98 RID: 3992 RVA: 0x00058520 File Offset: 0x00056720
		// (set) Token: 0x06000F99 RID: 3993 RVA: 0x00058560 File Offset: 0x00056760
		public unsafe JsonSchemaNode AdditionalItems
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaNode.NativeMethodInfoPtr_get_AdditionalItems_Public_get_JsonSchemaNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchemaNode>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaNode.NativeMethodInfoPtr_set_AdditionalItems_Public_set_Void_JsonSchemaNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x000585A4 File Offset: 0x000567A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 755511, RefRangeEnd = 755512, XrefRangeStart = 755473, XrefRangeEnd = 755511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSchemaNode(JsonSchema schema)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSchemaNode>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaNode.NativeMethodInfoPtr__ctor_Public_Void_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x000585F0 File Offset: 0x000567F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 755558, RefRangeEnd = 755560, XrefRangeStart = 755512, XrefRangeEnd = 755558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSchemaNode(JsonSchemaNode source, JsonSchema schema)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSchemaNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaNode.NativeMethodInfoPtr__ctor_Private_Void_JsonSchemaNode_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x00058650 File Offset: 0x00056850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755560, XrefRangeEnd = 755564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSchemaNode Combine(JsonSchema schema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaNode.NativeMethodInfoPtr_Combine_Public_JsonSchemaNode_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchemaNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x000586A0 File Offset: 0x000568A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 755609, RefRangeEnd = 755612, XrefRangeStart = 755564, XrefRangeEnd = 755609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetId(IEnumerable<JsonSchema> schemata)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaNode.NativeMethodInfoPtr_GetId_Public_Static_String_IEnumerable_1_JsonSchema_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x00007415 File Offset: 0x00005615
		public JsonSchemaNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000F9F RID: 3999 RVA: 0x000586DC File Offset: 0x000568DC
		// (set) Token: 0x06000FA0 RID: 4000 RVA: 0x0000741E File Offset: 0x0000561E
		public unsafe string _Id_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaNode.NativeFieldInfoPtr__Id_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaNode.NativeFieldInfoPtr__Id_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000FA1 RID: 4001 RVA: 0x00058704 File Offset: 0x00056904
		// (set) Token: 0x06000FA2 RID: 4002 RVA: 0x0000743D File Offset: 0x0000563D
		public unsafe ReadOnlyCollection<JsonSchema> _Schemas_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaNode.NativeFieldInfoPtr__Schemas_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<JsonSchema>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaNode.NativeFieldInfoPtr__Schemas_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x00058734 File Offset: 0x00056934
		// (set) Token: 0x06000FA4 RID: 4004 RVA: 0x0000745C File Offset: 0x0000565C
		public unsafe Dictionary<string, JsonSchemaNode> _Properties_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaNode.NativeFieldInfoPtr__Properties_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, JsonSchemaNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaNode.NativeFieldInfoPtr__Properties_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000FA5 RID: 4005 RVA: 0x00058764 File Offset: 0x00056964
		// (set) Token: 0x06000FA6 RID: 4006 RVA: 0x0000747B File Offset: 0x0000567B
		public unsafe Dictionary<string, JsonSchemaNode> _PatternProperties_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaNode.NativeFieldInfoPtr__PatternProperties_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, JsonSchemaNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaNode.NativeFieldInfoPtr__PatternProperties_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000FA7 RID: 4007 RVA: 0x00058794 File Offset: 0x00056994
		// (set) Token: 0x06000FA8 RID: 4008 RVA: 0x0000749A File Offset: 0x0000569A
		public unsafe List<JsonSchemaNode> _Items_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaNode.NativeFieldInfoPtr__Items_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<JsonSchemaNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaNode.NativeFieldInfoPtr__Items_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x000587C4 File Offset: 0x000569C4
		// (set) Token: 0x06000FAA RID: 4010 RVA: 0x000074B9 File Offset: 0x000056B9
		public unsafe JsonSchemaNode _AdditionalProperties_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaNode.NativeFieldInfoPtr__AdditionalProperties_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSchemaNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaNode.NativeFieldInfoPtr__AdditionalProperties_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000FAB RID: 4011 RVA: 0x000587F4 File Offset: 0x000569F4
		// (set) Token: 0x06000FAC RID: 4012 RVA: 0x000074D8 File Offset: 0x000056D8
		public unsafe JsonSchemaNode _AdditionalItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaNode.NativeFieldInfoPtr__AdditionalItems_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSchemaNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaNode.NativeFieldInfoPtr__AdditionalItems_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeFieldInfoPtr__Id_k__BackingField;

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeFieldInfoPtr__Schemas_k__BackingField;

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeFieldInfoPtr__Properties_k__BackingField;

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeFieldInfoPtr__PatternProperties_k__BackingField;

		// Token: 0x04000C70 RID: 3184
		private static readonly IntPtr NativeFieldInfoPtr__Items_k__BackingField;

		// Token: 0x04000C71 RID: 3185
		private static readonly IntPtr NativeFieldInfoPtr__AdditionalProperties_k__BackingField;

		// Token: 0x04000C72 RID: 3186
		private static readonly IntPtr NativeFieldInfoPtr__AdditionalItems_k__BackingField;

		// Token: 0x04000C73 RID: 3187
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_String_0;

		// Token: 0x04000C74 RID: 3188
		private static readonly IntPtr NativeMethodInfoPtr_get_Schemas_Public_get_ReadOnlyCollection_1_JsonSchema_0;

		// Token: 0x04000C75 RID: 3189
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_get_Dictionary_2_String_JsonSchemaNode_0;

		// Token: 0x04000C76 RID: 3190
		private static readonly IntPtr NativeMethodInfoPtr_get_PatternProperties_Public_get_Dictionary_2_String_JsonSchemaNode_0;

		// Token: 0x04000C77 RID: 3191
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Public_get_List_1_JsonSchemaNode_0;

		// Token: 0x04000C78 RID: 3192
		private static readonly IntPtr NativeMethodInfoPtr_get_AdditionalProperties_Public_get_JsonSchemaNode_0;

		// Token: 0x04000C79 RID: 3193
		private static readonly IntPtr NativeMethodInfoPtr_set_AdditionalProperties_Public_set_Void_JsonSchemaNode_0;

		// Token: 0x04000C7A RID: 3194
		private static readonly IntPtr NativeMethodInfoPtr_get_AdditionalItems_Public_get_JsonSchemaNode_0;

		// Token: 0x04000C7B RID: 3195
		private static readonly IntPtr NativeMethodInfoPtr_set_AdditionalItems_Public_set_Void_JsonSchemaNode_0;

		// Token: 0x04000C7C RID: 3196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_JsonSchema_0;

		// Token: 0x04000C7D RID: 3197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_JsonSchemaNode_JsonSchema_0;

		// Token: 0x04000C7E RID: 3198
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_JsonSchemaNode_JsonSchema_0;

		// Token: 0x04000C7F RID: 3199
		private static readonly IntPtr NativeMethodInfoPtr_GetId_Public_Static_String_IEnumerable_1_JsonSchema_0;

		// Token: 0x020001DF RID: 479
		[ObfuscatedName("Newtonsoft.Json.Schema.JsonSchemaNode+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001EF3 RID: 7923 RVA: 0x0008E120 File Offset: 0x0008C320
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<JsonSchemaNode.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonSchemaNode>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSchemaNode.__c>.NativeClassPtr);
				JsonSchemaNode.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaNode.__c>.NativeClassPtr, "<>9");
				JsonSchemaNode.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaNode.__c>.NativeClassPtr, "<>9__26_0");
				JsonSchemaNode.__c.NativeFieldInfoPtr___9__26_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaNode.__c>.NativeClassPtr, "<>9__26_1");
				JsonSchemaNode.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaNode.__c>.NativeClassPtr, 100666051);
				JsonSchemaNode.__c.NativeMethodInfoPtr__GetId_b__26_0_Internal_String_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaNode.__c>.NativeClassPtr, 100666052);
				JsonSchemaNode.__c.NativeMethodInfoPtr__GetId_b__26_1_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaNode.__c>.NativeClassPtr, 100666053);
			}

			// Token: 0x06001EF4 RID: 7924 RVA: 0x0008E1C4 File Offset: 0x0008C3C4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSchemaNode.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaNode.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EF5 RID: 7925 RVA: 0x0008E200 File Offset: 0x0008C400
			[CallerCount(0)]
			public unsafe string _GetId_b__26_0(JsonSchema s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaNode.__c.NativeMethodInfoPtr__GetId_b__26_0_Internal_String_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001EF6 RID: 7926 RVA: 0x0008E248 File Offset: 0x0008C448
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetId_b__26_1(string id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaNode.__c.NativeMethodInfoPtr__GetId_b__26_1_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001EF7 RID: 7927 RVA: 0x0000F464 File Offset: 0x0000D664
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008AC RID: 2220
			// (get) Token: 0x06001EF8 RID: 7928 RVA: 0x0008E290 File Offset: 0x0008C490
			// (set) Token: 0x06001EF9 RID: 7929 RVA: 0x0000F46D File Offset: 0x0000D66D
			public unsafe static JsonSchemaNode.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JsonSchemaNode.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSchemaNode.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JsonSchemaNode.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008AD RID: 2221
			// (get) Token: 0x06001EFA RID: 7930 RVA: 0x0008E2B8 File Offset: 0x0008C4B8
			// (set) Token: 0x06001EFB RID: 7931 RVA: 0x0000F47F File Offset: 0x0000D67F
			public unsafe static Func<JsonSchema, string> __9__26_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JsonSchemaNode.__c.NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<JsonSchema, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JsonSchemaNode.__c.NativeFieldInfoPtr___9__26_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008AE RID: 2222
			// (get) Token: 0x06001EFC RID: 7932 RVA: 0x0008E2E0 File Offset: 0x0008C4E0
			// (set) Token: 0x06001EFD RID: 7933 RVA: 0x0000F491 File Offset: 0x0000D691
			public unsafe static Func<string, string> __9__26_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JsonSchemaNode.__c.NativeFieldInfoPtr___9__26_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JsonSchemaNode.__c.NativeFieldInfoPtr___9__26_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001687 RID: 5767
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001688 RID: 5768
			private static readonly IntPtr NativeFieldInfoPtr___9__26_0;

			// Token: 0x04001689 RID: 5769
			private static readonly IntPtr NativeFieldInfoPtr___9__26_1;

			// Token: 0x0400168A RID: 5770
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400168B RID: 5771
			private static readonly IntPtr NativeMethodInfoPtr__GetId_b__26_0_Internal_String_JsonSchema_0;

			// Token: 0x0400168C RID: 5772
			private static readonly IntPtr NativeMethodInfoPtr__GetId_b__26_1_Internal_String_String_0;
		}
	}
}

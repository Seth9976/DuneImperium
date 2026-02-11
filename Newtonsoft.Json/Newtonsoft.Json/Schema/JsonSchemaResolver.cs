using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020000AC RID: 172
	public class JsonSchemaResolver : Object
	{
		// Token: 0x06000FB1 RID: 4017 RVA: 0x0005890C File Offset: 0x00056B0C
		// Note: this type is marked as 'beforefieldinit'.
		static JsonSchemaResolver()
		{
			Il2CppClassPointerStore<JsonSchemaResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Schema", "JsonSchemaResolver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSchemaResolver>.NativeClassPtr);
			JsonSchemaResolver.NativeFieldInfoPtr__LoadedSchemas_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaResolver>.NativeClassPtr, "<LoadedSchemas>k__BackingField");
			JsonSchemaResolver.NativeMethodInfoPtr_get_LoadedSchemas_Public_get_IList_1_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaResolver>.NativeClassPtr, 100666056);
			JsonSchemaResolver.NativeMethodInfoPtr_set_LoadedSchemas_Protected_set_Void_IList_1_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaResolver>.NativeClassPtr, 100666057);
			JsonSchemaResolver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaResolver>.NativeClassPtr, 100666058);
			JsonSchemaResolver.NativeMethodInfoPtr_GetSchema_Public_Virtual_New_JsonSchema_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaResolver>.NativeClassPtr, 100666059);
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x000589A0 File Offset: 0x00056BA0
		// (set) Token: 0x06000FB3 RID: 4019 RVA: 0x000589E0 File Offset: 0x00056BE0
		public unsafe IList<JsonSchema> LoadedSchemas
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaResolver.NativeMethodInfoPtr_get_LoadedSchemas_Public_get_IList_1_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<JsonSchema>>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaResolver.NativeMethodInfoPtr_set_LoadedSchemas_Protected_set_Void_IList_1_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x00058A24 File Offset: 0x00056C24
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 755662, RefRangeEnd = 755668, XrefRangeStart = 755654, XrefRangeEnd = 755662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSchemaResolver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSchemaResolver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaResolver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x00058A60 File Offset: 0x00056C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755668, XrefRangeEnd = 755689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual JsonSchema GetSchema(string reference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(reference);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSchemaResolver.NativeMethodInfoPtr_GetSchema_Public_Virtual_New_JsonSchema_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchema>(intPtr3) : null;
			}
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x00007500 File Offset: 0x00005700
		public JsonSchemaResolver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000FB7 RID: 4023 RVA: 0x00058ABC File Offset: 0x00056CBC
		// (set) Token: 0x06000FB8 RID: 4024 RVA: 0x00007509 File Offset: 0x00005709
		public unsafe IList<JsonSchema> _LoadedSchemas_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaResolver.NativeFieldInfoPtr__LoadedSchemas_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<JsonSchema>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaResolver.NativeFieldInfoPtr__LoadedSchemas_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C82 RID: 3202
		private static readonly IntPtr NativeFieldInfoPtr__LoadedSchemas_k__BackingField;

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadedSchemas_Public_get_IList_1_JsonSchema_0;

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeMethodInfoPtr_set_LoadedSchemas_Protected_set_Void_IList_1_JsonSchema_0;

		// Token: 0x04000C85 RID: 3205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C86 RID: 3206
		private static readonly IntPtr NativeMethodInfoPtr_GetSchema_Public_Virtual_New_JsonSchema_String_0;

		// Token: 0x020001E0 RID: 480
		[ObfuscatedName("Newtonsoft.Json.Schema.JsonSchemaResolver+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06001EFE RID: 7934 RVA: 0x0008E308 File Offset: 0x0008C508
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<JsonSchemaResolver.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonSchemaResolver>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSchemaResolver.__c__DisplayClass5_0>.NativeClassPtr);
				JsonSchemaResolver.__c__DisplayClass5_0.NativeFieldInfoPtr_reference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaResolver.__c__DisplayClass5_0>.NativeClassPtr, "reference");
				JsonSchemaResolver.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaResolver.__c__DisplayClass5_0>.NativeClassPtr, 100666060);
				JsonSchemaResolver.__c__DisplayClass5_0.NativeMethodInfoPtr__GetSchema_b__0_Internal_Boolean_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaResolver.__c__DisplayClass5_0>.NativeClassPtr, 100666061);
				JsonSchemaResolver.__c__DisplayClass5_0.NativeMethodInfoPtr__GetSchema_b__1_Internal_Boolean_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaResolver.__c__DisplayClass5_0>.NativeClassPtr, 100666062);
			}

			// Token: 0x06001EFF RID: 7935 RVA: 0x0008E384 File Offset: 0x0008C584
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSchemaResolver.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaResolver.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F00 RID: 7936 RVA: 0x0008E3C0 File Offset: 0x0008C5C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755615, XrefRangeEnd = 755617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetSchema_b__0(JsonSchema s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaResolver.__c__DisplayClass5_0.NativeMethodInfoPtr__GetSchema_b__0_Internal_Boolean_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001F01 RID: 7937 RVA: 0x0008E410 File Offset: 0x0008C610
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755617, XrefRangeEnd = 755654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetSchema_b__1(JsonSchema s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaResolver.__c__DisplayClass5_0.NativeMethodInfoPtr__GetSchema_b__1_Internal_Boolean_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001F02 RID: 7938 RVA: 0x0000F4A3 File Offset: 0x0000D6A3
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008AF RID: 2223
			// (get) Token: 0x06001F03 RID: 7939 RVA: 0x0008E460 File Offset: 0x0008C660
			// (set) Token: 0x06001F04 RID: 7940 RVA: 0x0000F4AC File Offset: 0x0000D6AC
			public unsafe string reference
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaResolver.__c__DisplayClass5_0.NativeFieldInfoPtr_reference);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaResolver.__c__DisplayClass5_0.NativeFieldInfoPtr_reference), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400168D RID: 5773
			private static readonly IntPtr NativeFieldInfoPtr_reference;

			// Token: 0x0400168E RID: 5774
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400168F RID: 5775
			private static readonly IntPtr NativeMethodInfoPtr__GetSchema_b__0_Internal_Boolean_JsonSchema_0;

			// Token: 0x04001690 RID: 5776
			private static readonly IntPtr NativeMethodInfoPtr__GetSchema_b__1_Internal_Boolean_JsonSchema_0;
		}
	}
}
